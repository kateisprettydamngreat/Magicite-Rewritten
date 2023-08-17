using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Depth of Field (3.4)")]
[ExecuteInEditMode]
public class DepthOfField34 : PostEffectsBase
{
	[NonSerialized]
	private static int SMOOTH_DOWNSAMPLE_PASS = 6;

	[NonSerialized]
	private static float BOKEH_EXTRA_BLUR = 2f;

	public Dof34QualitySetting quality;

	public DofResolution resolution;

	public bool simpleTweakMode;

	public float focalPoint;

	public float smoothness;

	public float focalZDistance;

	public float focalZStartCurve;

	public float focalZEndCurve;

	private float focalStartCurve;

	private float focalEndCurve;

	private float focalDistance01;

	public Transform objectFocus;

	public float focalSize;

	public DofBlurriness bluriness;

	public float maxBlurSpread;

	public float foregroundBlurExtrude;

	public Shader dofBlurShader;

	private Material dofBlurMaterial;

	public Shader dofShader;

	private Material dofMaterial;

	public bool visualize;

	public BokehDestination bokehDestination;

	private float widthOverHeight;

	private float oneOverBaseSize;

	public bool bokeh;

	public bool bokehSupport;

	public Shader bokehShader;

	public Texture2D bokehTexture;

	public float bokehScale;

	public float bokehIntensity;

	public float bokehThreshholdContrast;

	public float bokehThreshholdLuminance;

	public int bokehDownsample;

	private Material bokehMaterial;

	private RenderTexture foregroundTexture;

	private RenderTexture mediumRezWorkTexture;

	private RenderTexture finalDefocus;

	private RenderTexture lowRezWorkTexture;

	private RenderTexture bokehSource;

	private RenderTexture bokehSource2;

	public DepthOfField34()
	{
		quality = Dof34QualitySetting.OnlyBackground;
		resolution = DofResolution.Low;
		simpleTweakMode = true;
		focalPoint = 1f;
		smoothness = 0.5f;
		focalZStartCurve = 1f;
		focalZEndCurve = 1f;
		focalStartCurve = 2f;
		focalEndCurve = 2f;
		focalDistance01 = 0.1f;
		bluriness = DofBlurriness.High;
		maxBlurSpread = 1.75f;
		foregroundBlurExtrude = 1.15f;
		bokehDestination = BokehDestination.Background;
		widthOverHeight = 1.25f;
		oneOverBaseSize = 0.001953125f;
		bokehSupport = true;
		bokehScale = 2.4f;
		bokehIntensity = 0.15f;
		bokehThreshholdContrast = 0.1f;
		bokehThreshholdLuminance = 0.55f;
		bokehDownsample = 1;
	}

	public override void CreateMaterials()
	{
		dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
		dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
		bokehSupport = bokehShader.isSupported;
		if (bokeh && bokehSupport && Object.op_Implicit((Object)(object)bokehShader))
		{
			bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
		}
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
		dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
		bokehSupport = bokehShader.isSupported;
		if (bokeh && bokehSupport && Object.op_Implicit((Object)(object)bokehShader))
		{
			bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
		}
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnDisable()
	{
		Quads.Cleanup();
	}

	public override void OnEnable()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).camera.depthTextureMode = (DepthTextureMode)(((Component)this).camera.depthTextureMode | 1);
	}

	public override float FocalDistance01(float worldDist)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)this).camera.WorldToViewportPoint((worldDist - ((Component)this).camera.nearClipPlane) * ((Component)((Component)this).camera).transform.forward + ((Component)((Component)this).camera).transform.position).z / (((Component)this).camera.farClipPlane - ((Component)this).camera.nearClipPlane);
	}

	public override int GetDividerBasedOnQuality()
	{
		int result = 1;
		if (resolution == DofResolution.Medium)
		{
			result = 2;
		}
		else if (resolution == DofResolution.Low)
		{
			result = 2;
		}
		return result;
	}

	public override int GetLowResolutionDividerBasedOnQuality(int baseDivider)
	{
		int num = baseDivider;
		if (resolution == DofResolution.High)
		{
			num *= 2;
		}
		if (resolution == DofResolution.Low)
		{
			num *= 2;
		}
		return num;
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		if (!(smoothness >= 0.1f))
		{
			smoothness = 0.1f;
		}
		bool num = bokeh;
		if (num)
		{
			num = bokehSupport;
		}
		bokeh = num;
		float num2 = ((!bokeh) ? 1f : BOKEH_EXTRA_BLUR);
		bool flag = quality > Dof34QualitySetting.OnlyBackground;
		float num3 = focalSize / (((Component)this).camera.farClipPlane - ((Component)this).camera.nearClipPlane);
		if (simpleTweakMode)
		{
			focalDistance01 = ((!Object.op_Implicit((Object)(object)objectFocus)) ? FocalDistance01(focalPoint) : (((Component)this).camera.WorldToViewportPoint(objectFocus.position).z / ((Component)this).camera.farClipPlane));
			focalStartCurve = focalDistance01 * smoothness;
			focalEndCurve = focalStartCurve;
			bool num4 = flag;
			if (num4)
			{
				num4 = focalPoint > ((Component)this).camera.nearClipPlane + float.Epsilon;
			}
			flag = num4;
		}
		else
		{
			if (Object.op_Implicit((Object)(object)objectFocus))
			{
				Vector3 val = ((Component)this).camera.WorldToViewportPoint(objectFocus.position);
				val.z /= ((Component)this).camera.farClipPlane;
				focalDistance01 = val.z;
			}
			else
			{
				focalDistance01 = FocalDistance01(focalZDistance);
			}
			focalStartCurve = focalZStartCurve;
			focalEndCurve = focalZEndCurve;
			bool num5 = flag;
			if (num5)
			{
				num5 = focalPoint > ((Component)this).camera.nearClipPlane + float.Epsilon;
			}
			flag = num5;
		}
		widthOverHeight = 1f * (float)source.width / (1f * (float)source.height);
		oneOverBaseSize = 0.001953125f;
		dofMaterial.SetFloat("_ForegroundBlurExtrude", foregroundBlurExtrude);
		dofMaterial.SetVector("_CurveParams", new Vector4((!simpleTweakMode) ? focalStartCurve : (1f / focalStartCurve), (!simpleTweakMode) ? focalEndCurve : (1f / focalEndCurve), num3 * 0.5f, focalDistance01));
		dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), 0f, 0f));
		int dividerBasedOnQuality = GetDividerBasedOnQuality();
		int lowResolutionDividerBasedOnQuality = GetLowResolutionDividerBasedOnQuality(dividerBasedOnQuality);
		AllocateTextures(flag, source, dividerBasedOnQuality, lowResolutionDividerBasedOnQuality);
		Graphics.Blit((Texture)(object)source, source, dofMaterial, 3);
		Downsample(source, mediumRezWorkTexture);
		Blur(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 4, maxBlurSpread);
		if (bokeh && (bokehDestination & BokehDestination.Background) != 0)
		{
			dofMaterial.SetVector("_Threshhold", new Vector4(bokehThreshholdContrast, bokehThreshholdLuminance, 0.95f, 0f));
			Graphics.Blit((Texture)(object)mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
			Graphics.Blit((Texture)(object)mediumRezWorkTexture, lowRezWorkTexture);
			Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread * num2);
		}
		else
		{
			Downsample(mediumRezWorkTexture, lowRezWorkTexture);
			Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread);
		}
		dofBlurMaterial.SetTexture("_TapLow", (Texture)(object)lowRezWorkTexture);
		dofBlurMaterial.SetTexture("_TapMedium", (Texture)(object)mediumRezWorkTexture);
		Graphics.Blit((Texture)null, finalDefocus, dofBlurMaterial, 3);
		if (bokeh && (bokehDestination & BokehDestination.Background) != 0)
		{
			AddBokeh(bokehSource2, bokehSource, finalDefocus);
		}
		dofMaterial.SetTexture("_TapLowBackground", (Texture)(object)finalDefocus);
		dofMaterial.SetTexture("_TapMedium", (Texture)(object)mediumRezWorkTexture);
		Graphics.Blit((Texture)(object)source, (!flag) ? destination : foregroundTexture, dofMaterial, visualize ? 2 : 0);
		if (flag)
		{
			Graphics.Blit((Texture)(object)foregroundTexture, source, dofMaterial, 5);
			Downsample(source, mediumRezWorkTexture);
			BlurFg(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 2, maxBlurSpread);
			if (bokeh && (bokehDestination & BokehDestination.Foreground) != 0)
			{
				dofMaterial.SetVector("_Threshhold", new Vector4(bokehThreshholdContrast * 0.5f, bokehThreshholdLuminance, 0f, 0f));
				Graphics.Blit((Texture)(object)mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
				Graphics.Blit((Texture)(object)mediumRezWorkTexture, lowRezWorkTexture);
				BlurFg(lowRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread * num2);
			}
			else
			{
				BlurFg(mediumRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread);
			}
			Graphics.Blit((Texture)(object)lowRezWorkTexture, finalDefocus);
			dofMaterial.SetTexture("_TapLowForeground", (Texture)(object)finalDefocus);
			Graphics.Blit((Texture)(object)source, destination, dofMaterial, visualize ? 1 : 4);
			if (bokeh && (bokehDestination & BokehDestination.Foreground) != 0)
			{
				AddBokeh(bokehSource2, bokehSource, destination);
			}
		}
		ReleaseTextures();
	}

	public override void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
		if (iterations > DofBlurriness.Low)
		{
			BlurHex(from, to, blurPass, spread, temporary);
			if (iterations > DofBlurriness.High)
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit((Texture)(object)to, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit((Texture)(object)temporary, to, dofBlurMaterial, blurPass);
			}
		}
		else
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit((Texture)(object)from, temporary, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit((Texture)(object)temporary, to, dofBlurMaterial, blurPass);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	public override void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		dofBlurMaterial.SetTexture("_TapHigh", (Texture)(object)from);
		RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
		if (iterations > DofBlurriness.Low)
		{
			BlurHex(from, to, blurPass, spread, temporary);
			if (iterations > DofBlurriness.High)
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit((Texture)(object)to, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit((Texture)(object)temporary, to, dofBlurMaterial, blurPass);
			}
		}
		else
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit((Texture)(object)from, temporary, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit((Texture)(object)temporary, to, dofBlurMaterial, blurPass);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	public override void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
		Graphics.Blit((Texture)(object)from, tmp, dofBlurMaterial, blurPass);
		dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
		Graphics.Blit((Texture)(object)tmp, to, dofBlurMaterial, blurPass);
		dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, spread * oneOverBaseSize, 0f, 0f));
		Graphics.Blit((Texture)(object)to, tmp, dofBlurMaterial, blurPass);
		dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, (0f - spread) * oneOverBaseSize, 0f, 0f));
		Graphics.Blit((Texture)(object)tmp, to, dofBlurMaterial, blurPass);
	}

	public override void Downsample(RenderTexture from, RenderTexture to)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)to.width), 1f / (1f * (float)to.height), 0f, 0f));
		Graphics.Blit((Texture)(object)from, to, dofMaterial, SMOOTH_DOWNSAMPLE_PASS);
	}

	public override void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)bokehMaterial))
		{
			return;
		}
		Mesh[] meshes = Quads.GetMeshes(tempTex.width, tempTex.height);
		RenderTexture.active = tempTex;
		GL.Clear(false, true, new Color(0f, 0f, 0f, 0f));
		GL.PushMatrix();
		GL.LoadIdentity();
		((Texture)bokehInfo).filterMode = (FilterMode)0;
		float num = (float)bokehInfo.width * 1f / ((float)bokehInfo.height * 1f);
		float num2 = 2f / (1f * (float)bokehInfo.width);
		num2 += bokehScale * maxBlurSpread * BOKEH_EXTRA_BLUR * oneOverBaseSize;
		bokehMaterial.SetTexture("_Source", (Texture)(object)bokehInfo);
		bokehMaterial.SetTexture("_MainTex", (Texture)(object)bokehTexture);
		bokehMaterial.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
		bokehMaterial.SetFloat("_Intensity", bokehIntensity);
		bokehMaterial.SetPass(0);
		int i = 0;
		Mesh[] array = meshes;
		for (int length = array.Length; i < length; i++)
		{
			if (Object.op_Implicit((Object)(object)array[i]))
			{
				Graphics.DrawMeshNow(array[i], Matrix4x4.identity);
			}
		}
		GL.PopMatrix();
		Graphics.Blit((Texture)(object)tempTex, finalTarget, dofMaterial, 8);
		((Texture)bokehInfo).filterMode = (FilterMode)1;
	}

	public override void ReleaseTextures()
	{
		if (Object.op_Implicit((Object)(object)foregroundTexture))
		{
			RenderTexture.ReleaseTemporary(foregroundTexture);
		}
		if (Object.op_Implicit((Object)(object)finalDefocus))
		{
			RenderTexture.ReleaseTemporary(finalDefocus);
		}
		if (Object.op_Implicit((Object)(object)mediumRezWorkTexture))
		{
			RenderTexture.ReleaseTemporary(mediumRezWorkTexture);
		}
		if (Object.op_Implicit((Object)(object)lowRezWorkTexture))
		{
			RenderTexture.ReleaseTemporary(lowRezWorkTexture);
		}
		if (Object.op_Implicit((Object)(object)bokehSource))
		{
			RenderTexture.ReleaseTemporary(bokehSource);
		}
		if (Object.op_Implicit((Object)(object)bokehSource2))
		{
			RenderTexture.ReleaseTemporary(bokehSource2);
		}
	}

	public override void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		foregroundTexture = null;
		if (blurForeground)
		{
			foregroundTexture = RenderTexture.GetTemporary(source.width, source.height, 0);
		}
		mediumRezWorkTexture = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
		finalDefocus = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
		lowRezWorkTexture = RenderTexture.GetTemporary(source.width / lowTexDivider, source.height / lowTexDivider, 0);
		bokehSource = null;
		bokehSource2 = null;
		if (bokeh)
		{
			bokehSource = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, (RenderTextureFormat)2);
			bokehSource2 = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, (RenderTextureFormat)2);
			((Texture)bokehSource).filterMode = (FilterMode)1;
			((Texture)bokehSource2).filterMode = (FilterMode)1;
			RenderTexture.active = bokehSource2;
			GL.Clear(false, true, new Color(0f, 0f, 0f, 0f));
		}
		((Texture)source).filterMode = (FilterMode)1;
		((Texture)finalDefocus).filterMode = (FilterMode)1;
		((Texture)mediumRezWorkTexture).filterMode = (FilterMode)1;
		((Texture)lowRezWorkTexture).filterMode = (FilterMode)1;
		if (Object.op_Implicit((Object)(object)foregroundTexture))
		{
			((Texture)foregroundTexture).filterMode = (FilterMode)1;
		}
	}

	public override void Main()
	{
	}
}
