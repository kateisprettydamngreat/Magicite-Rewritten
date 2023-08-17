using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Camera Motion Blur")]
public class CameraMotionBlur : PostEffectsBase
{
	[Serializable]
	public enum MotionBlurFilter
	{
		CameraMotion,
		LocalBlur,
		Reconstruction,
		ReconstructionDX11
	}

	[NonSerialized]
	public static int MAX_RADIUS = 10;

	public MotionBlurFilter filterType;

	public bool preview;

	public Vector3 previewScale;

	public float movementScale;

	public float rotationScale;

	public float maxVelocity;

	public int maxNumSamples;

	public float minVelocity;

	public float velocityScale;

	public float softZDistance;

	public int velocityDownsample;

	public LayerMask excludeLayers;

	private GameObject tmpCam;

	public Shader shader;

	public Shader dx11MotionBlurShader;

	public Shader replacementClear;

	private Material motionBlurMaterial;

	private Material dx11MotionBlurMaterial;

	public Texture2D noiseTexture;

	public bool showVelocity;

	public float showVelocityScale;

	private Matrix4x4 currentViewProjMat;

	private Matrix4x4 prevViewProjMat;

	private int prevFrameCount;

	private bool wasActive;

	private Vector3 prevFrameForward;

	private Vector3 prevFrameRight;

	private Vector3 prevFrameUp;

	private Vector3 prevFramePos;

	public CameraMotionBlur()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		filterType = MotionBlurFilter.Reconstruction;
		previewScale = Vector3.one;
		rotationScale = 1f;
		maxVelocity = 8f;
		maxNumSamples = 17;
		minVelocity = 0.1f;
		velocityScale = 0.375f;
		softZDistance = 0.005f;
		velocityDownsample = 1;
		showVelocityScale = 1f;
		prevFrameForward = Vector3.forward;
		prevFrameRight = Vector3.right;
		prevFrameUp = Vector3.up;
		prevFramePos = Vector3.zero;
	}

	private void CalculateViewProjection()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		Matrix4x4 worldToCameraMatrix = ((Component)this).camera.worldToCameraMatrix;
		Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(((Component)this).camera.projectionMatrix, true);
		currentViewProjMat = gPUProjectionMatrix * worldToCameraMatrix;
	}

	public override void Start()
	{
		CheckResources();
		wasActive = ((Component)this).gameObject.activeInHierarchy;
		CalculateViewProjection();
		Remember();
		prevFrameCount = -1;
		wasActive = false;
	}

	public override void OnEnable()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).camera.depthTextureMode = (DepthTextureMode)(((Component)this).camera.depthTextureMode | 1);
	}

	public override void OnDisable()
	{
		if ((Object)null != (Object)(object)motionBlurMaterial)
		{
			Object.DestroyImmediate((Object)(object)motionBlurMaterial);
			motionBlurMaterial = null;
		}
		if ((Object)null != (Object)(object)dx11MotionBlurMaterial)
		{
			Object.DestroyImmediate((Object)(object)dx11MotionBlurMaterial);
			dx11MotionBlurMaterial = null;
		}
		if ((Object)null != (Object)(object)tmpCam)
		{
			Object.DestroyImmediate((Object)(object)tmpCam);
			tmpCam = null;
		}
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true, needHdr: true);
		motionBlurMaterial = CheckShaderAndCreateMaterial(shader, motionBlurMaterial);
		if (supportDX11 && filterType == MotionBlurFilter.ReconstructionDX11)
		{
			dx11MotionBlurMaterial = CheckShaderAndCreateMaterial(dx11MotionBlurShader, dx11MotionBlurMaterial);
		}
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		if (filterType == MotionBlurFilter.CameraMotion)
		{
			StartFrame();
		}
		RenderTextureFormat val = (RenderTextureFormat)((!SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)13)) ? 2 : 13);
		RenderTexture temporary = RenderTexture.GetTemporary(divRoundUp(source.width, velocityDownsample), divRoundUp(source.height, velocityDownsample), 0, val);
		int num = 1;
		int num2 = 1;
		maxVelocity = Mathf.Max(2f, maxVelocity);
		float num3 = maxVelocity;
		bool flag = false;
		if (filterType == MotionBlurFilter.ReconstructionDX11 && (Object)(object)dx11MotionBlurMaterial == (Object)null)
		{
			flag = true;
		}
		if (filterType == MotionBlurFilter.Reconstruction || flag)
		{
			maxVelocity = Mathf.Min(maxVelocity, (float)MAX_RADIUS);
			num = divRoundUp(temporary.width, (int)maxVelocity);
			num2 = divRoundUp(temporary.height, (int)maxVelocity);
			num3 = temporary.width / num;
		}
		else
		{
			num = divRoundUp(temporary.width, (int)maxVelocity);
			num2 = divRoundUp(temporary.height, (int)maxVelocity);
			num3 = temporary.width / num;
		}
		RenderTexture temporary2 = RenderTexture.GetTemporary(num, num2, 0, val);
		RenderTexture temporary3 = RenderTexture.GetTemporary(num, num2, 0, val);
		((Texture)temporary).filterMode = (FilterMode)0;
		((Texture)temporary2).filterMode = (FilterMode)0;
		((Texture)temporary3).filterMode = (FilterMode)0;
		if (Object.op_Implicit((Object)(object)noiseTexture))
		{
			((Texture)noiseTexture).filterMode = (FilterMode)0;
		}
		((Texture)source).wrapMode = (TextureWrapMode)1;
		((Texture)temporary).wrapMode = (TextureWrapMode)1;
		((Texture)temporary3).wrapMode = (TextureWrapMode)1;
		((Texture)temporary2).wrapMode = (TextureWrapMode)1;
		CalculateViewProjection();
		if (((Component)this).gameObject.activeInHierarchy && !wasActive)
		{
			Remember();
		}
		wasActive = ((Component)this).gameObject.activeInHierarchy;
		Matrix4x4 val2 = Matrix4x4.Inverse(currentViewProjMat);
		motionBlurMaterial.SetMatrix("_InvViewProj", val2);
		motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
		motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * val2);
		motionBlurMaterial.SetFloat("_MaxVelocity", num3);
		motionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
		motionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
		motionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
		motionBlurMaterial.SetTexture("_NoiseTex", (Texture)(object)noiseTexture);
		motionBlurMaterial.SetTexture("_VelTex", (Texture)(object)temporary);
		motionBlurMaterial.SetTexture("_NeighbourMaxTex", (Texture)(object)temporary3);
		motionBlurMaterial.SetTexture("_TileTexDebug", (Texture)(object)temporary2);
		if (preview)
		{
			Matrix4x4 worldToCameraMatrix = ((Component)this).camera.worldToCameraMatrix;
			Matrix4x4 identity = Matrix4x4.identity;
			((Matrix4x4)(ref identity)).SetTRS(previewScale * 0.25f, Quaternion.identity, Vector3.one);
			Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(((Component)this).camera.projectionMatrix, true);
			prevViewProjMat = gPUProjectionMatrix * identity * worldToCameraMatrix;
			motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
			motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * val2);
		}
		if (filterType == MotionBlurFilter.CameraMotion)
		{
			Vector4 zero = Vector4.zero;
			float num4 = Vector3.Dot(((Component)this).transform.up, Vector3.up);
			Vector3 val3 = prevFramePos - ((Component)this).transform.position;
			float magnitude = ((Vector3)(ref val3)).magnitude;
			float num5 = 1f;
			num5 = Vector3.Angle(((Component)this).transform.up, prevFrameUp) / ((Component)this).camera.fieldOfView * ((float)source.width * 0.75f);
			zero.x = rotationScale * num5;
			num5 = Vector3.Angle(((Component)this).transform.forward, prevFrameForward) / ((Component)this).camera.fieldOfView * ((float)source.width * 0.75f);
			zero.y = rotationScale * num4 * num5;
			num5 = Vector3.Angle(((Component)this).transform.forward, prevFrameForward) / ((Component)this).camera.fieldOfView * ((float)source.width * 0.75f);
			zero.z = rotationScale * (1f - num4) * num5;
			if (!(magnitude <= float.Epsilon) && !(movementScale <= float.Epsilon))
			{
				zero.w = movementScale * Vector3.Dot(((Component)this).transform.forward, val3) * ((float)source.width * 0.5f);
				zero.x += movementScale * Vector3.Dot(((Component)this).transform.up, val3) * ((float)source.width * 0.5f);
				zero.y += movementScale * Vector3.Dot(((Component)this).transform.right, val3) * ((float)source.width * 0.5f);
			}
			if (preview)
			{
				motionBlurMaterial.SetVector("_BlurDirectionPacked", new Vector4(previewScale.y, previewScale.x, 0f, previewScale.z) * 0.5f * ((Component)this).camera.fieldOfView);
			}
			else
			{
				motionBlurMaterial.SetVector("_BlurDirectionPacked", zero);
			}
		}
		else
		{
			Graphics.Blit((Texture)(object)source, temporary, motionBlurMaterial, 0);
			Camera val4 = null;
			if (((LayerMask)(ref excludeLayers)).value != 0)
			{
				val4 = GetTmpCam();
			}
			if (Object.op_Implicit((Object)(object)val4) && ((LayerMask)(ref excludeLayers)).value != 0 && Object.op_Implicit((Object)(object)replacementClear) && replacementClear.isSupported)
			{
				val4.targetTexture = temporary;
				val4.cullingMask = LayerMask.op_Implicit(excludeLayers);
				val4.RenderWithShader(replacementClear, string.Empty);
			}
		}
		if (!preview && Time.frameCount != prevFrameCount)
		{
			prevFrameCount = Time.frameCount;
			Remember();
		}
		((Texture)source).filterMode = (FilterMode)1;
		if (showVelocity)
		{
			motionBlurMaterial.SetFloat("_DisplayVelocityScale", showVelocityScale);
			Graphics.Blit((Texture)(object)temporary, destination, motionBlurMaterial, 1);
		}
		else if (filterType == MotionBlurFilter.ReconstructionDX11 && !flag)
		{
			dx11MotionBlurMaterial.SetFloat("_MaxVelocity", num3);
			dx11MotionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
			dx11MotionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
			dx11MotionBlurMaterial.SetTexture("_NoiseTex", (Texture)(object)noiseTexture);
			dx11MotionBlurMaterial.SetTexture("_VelTex", (Texture)(object)temporary);
			dx11MotionBlurMaterial.SetTexture("_NeighbourMaxTex", (Texture)(object)temporary3);
			dx11MotionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
			dx11MotionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
			maxNumSamples = 2 * (maxNumSamples / 2) + 1;
			dx11MotionBlurMaterial.SetFloat("_SampleCount", (float)maxNumSamples * 1f);
			Graphics.Blit((Texture)(object)temporary, temporary2, dx11MotionBlurMaterial, 0);
			Graphics.Blit((Texture)(object)temporary2, temporary3, dx11MotionBlurMaterial, 1);
			Graphics.Blit((Texture)(object)source, destination, dx11MotionBlurMaterial, 2);
		}
		else if (filterType == MotionBlurFilter.Reconstruction || flag)
		{
			motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
			Graphics.Blit((Texture)(object)temporary, temporary2, motionBlurMaterial, 2);
			Graphics.Blit((Texture)(object)temporary2, temporary3, motionBlurMaterial, 3);
			Graphics.Blit((Texture)(object)source, destination, motionBlurMaterial, 4);
		}
		else if (filterType == MotionBlurFilter.CameraMotion)
		{
			Graphics.Blit((Texture)(object)source, destination, motionBlurMaterial, 6);
		}
		else
		{
			Graphics.Blit((Texture)(object)source, destination, motionBlurMaterial, 5);
		}
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	public override void Remember()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		prevViewProjMat = currentViewProjMat;
		prevFrameForward = ((Component)this).transform.forward;
		prevFrameRight = ((Component)this).transform.right;
		prevFrameUp = ((Component)this).transform.up;
		prevFramePos = ((Component)this).transform.position;
	}

	public override Camera GetTmpCam()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		if ((Object)(object)tmpCam == (Object)null)
		{
			string text = "_" + ((Object)((Component)this).camera).name + "_MotionBlurTmpCam";
			GameObject val = GameObject.Find(text);
			if ((Object)null == (Object)(object)val)
			{
				tmpCam = new GameObject(text, new Type[1] { typeof(Camera) });
			}
			else
			{
				tmpCam = val;
			}
		}
		((Object)tmpCam).hideFlags = (HideFlags)4;
		tmpCam.transform.position = ((Component)((Component)this).camera).transform.position;
		tmpCam.transform.rotation = ((Component)((Component)this).camera).transform.rotation;
		tmpCam.transform.localScale = ((Component)((Component)this).camera).transform.localScale;
		tmpCam.camera.CopyFrom(((Component)this).camera);
		((Behaviour)tmpCam.camera).enabled = false;
		tmpCam.camera.depthTextureMode = (DepthTextureMode)0;
		tmpCam.camera.clearFlags = (CameraClearFlags)4;
		return tmpCam.camera;
	}

	public override void StartFrame()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		prevFramePos = Vector3.Slerp(prevFramePos, ((Component)this).transform.position, 0.75f);
	}

	public override int divRoundUp(int x, int d)
	{
		return (x + d - 1) / d;
	}

	public override void Main()
	{
	}
}
