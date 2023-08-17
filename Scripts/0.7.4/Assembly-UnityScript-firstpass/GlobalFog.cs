using System;
using UnityEngine;

[Serializable]
[AddComponentMenu("Image Effects/Global Fog")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class GlobalFog : PostEffectsBase
{
	[Serializable]
	public enum FogMode
	{
		AbsoluteYAndDistance,
		AbsoluteY,
		Distance,
		RelativeYAndDistance
	}

	public FogMode fogMode;

	private float CAMERA_NEAR;

	private float CAMERA_FAR;

	private float CAMERA_FOV;

	private float CAMERA_ASPECT_RATIO;

	public float startDistance;

	public float globalDensity;

	public float heightScale;

	public float height;

	public Color globalFogColor;

	public Shader fogShader;

	private Material fogMaterial;

	public GlobalFog()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		fogMode = FogMode.AbsoluteYAndDistance;
		CAMERA_NEAR = 0.5f;
		CAMERA_FAR = 50f;
		CAMERA_FOV = 60f;
		CAMERA_ASPECT_RATIO = 1.333333f;
		startDistance = 200f;
		globalDensity = 1f;
		heightScale = 100f;
		globalFogColor = Color.grey;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		fogMaterial = CheckShaderAndCreateMaterial(fogShader, fogMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		CAMERA_NEAR = ((Component)this).camera.nearClipPlane;
		CAMERA_FAR = ((Component)this).camera.farClipPlane;
		CAMERA_FOV = ((Component)this).camera.fieldOfView;
		CAMERA_ASPECT_RATIO = ((Component)this).camera.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		Vector4 val = default(Vector4);
		Vector3 val2 = default(Vector3);
		float num = CAMERA_FOV * 0.5f;
		Vector3 val3 = ((Component)((Component)this).camera).transform.right * CAMERA_NEAR * Mathf.Tan(num * ((float)Math.PI / 180f)) * CAMERA_ASPECT_RATIO;
		Vector3 val4 = ((Component)((Component)this).camera).transform.up * CAMERA_NEAR * Mathf.Tan(num * ((float)Math.PI / 180f));
		Vector3 val5 = ((Component)((Component)this).camera).transform.forward * CAMERA_NEAR - val3 + val4;
		float num2 = ((Vector3)(ref val5)).magnitude * CAMERA_FAR / CAMERA_NEAR;
		((Vector3)(ref val5)).Normalize();
		val5 *= num2;
		Vector3 val6 = ((Component)((Component)this).camera).transform.forward * CAMERA_NEAR + val3 + val4;
		((Vector3)(ref val6)).Normalize();
		val6 *= num2;
		Vector3 val7 = ((Component)((Component)this).camera).transform.forward * CAMERA_NEAR + val3 - val4;
		((Vector3)(ref val7)).Normalize();
		val7 *= num2;
		Vector3 val8 = ((Component)((Component)this).camera).transform.forward * CAMERA_NEAR - val3 - val4;
		((Vector3)(ref val8)).Normalize();
		val8 *= num2;
		((Matrix4x4)(ref identity)).SetRow(0, Vector4.op_Implicit(val5));
		((Matrix4x4)(ref identity)).SetRow(1, Vector4.op_Implicit(val6));
		((Matrix4x4)(ref identity)).SetRow(2, Vector4.op_Implicit(val7));
		((Matrix4x4)(ref identity)).SetRow(3, Vector4.op_Implicit(val8));
		fogMaterial.SetMatrix("_FrustumCornersWS", identity);
		fogMaterial.SetVector("_CameraWS", Vector4.op_Implicit(((Component)((Component)this).camera).transform.position));
		fogMaterial.SetVector("_StartDistance", new Vector4(1f / startDistance, num2 - startDistance));
		fogMaterial.SetVector("_Y", new Vector4(height, 1f / heightScale));
		fogMaterial.SetFloat("_GlobalDensity", globalDensity * 0.01f);
		fogMaterial.SetColor("_FogColor", globalFogColor);
		CustomGraphicsBlit(source, destination, fogMaterial, (int)fogMode);
	}

	public static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
	{
		RenderTexture.active = dest;
		fxMaterial.SetTexture("_MainTex", (Texture)(object)source);
		GL.PushMatrix();
		GL.LoadOrtho();
		fxMaterial.SetPass(passNr);
		GL.Begin(7);
		GL.MultiTexCoord2(0, 0f, 0f);
		GL.Vertex3(0f, 0f, 3f);
		GL.MultiTexCoord2(0, 1f, 0f);
		GL.Vertex3(1f, 0f, 2f);
		GL.MultiTexCoord2(0, 1f, 1f);
		GL.Vertex3(1f, 1f, 1f);
		GL.MultiTexCoord2(0, 0f, 1f);
		GL.Vertex3(0f, 1f, 0f);
		GL.End();
		GL.PopMatrix();
	}

	public override void Main()
	{
	}
}
