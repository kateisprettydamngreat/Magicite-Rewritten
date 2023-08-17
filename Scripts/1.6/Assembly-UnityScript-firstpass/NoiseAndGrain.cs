using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Noise And Grain (Overlay, DX11)")]
public class NoiseAndGrain : PostEffectsBase
{
	public float intensityMultiplier;

	public float generalIntensity;

	public float blackIntensity;

	public float whiteIntensity;

	public float midGrey;

	public bool dx11Grain;

	public float softness;

	public bool monochrome;

	public Vector3 intensities;

	public Vector3 tiling;

	public float monochromeTiling;

	public FilterMode filterMode;

	public Texture2D noiseTexture;

	public Shader noiseShader;

	private Material noiseMaterial;

	public Shader dx11NoiseShader;

	private Material dx11NoiseMaterial;

	[NonSerialized]
	private static float TILE_AMOUNT = 64f;

	public NoiseAndGrain()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		intensityMultiplier = 0.25f;
		generalIntensity = 0.5f;
		blackIntensity = 1f;
		whiteIntensity = 1f;
		midGrey = 0.2f;
		intensities = new Vector3(1f, 1f, 1f);
		tiling = new Vector3(64f, 64f, 64f);
		monochromeTiling = 64f;
		filterMode = (FilterMode)1;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		noiseMaterial = CheckShaderAndCreateMaterial(noiseShader, noiseMaterial);
		if (dx11Grain && supportDX11)
		{
			dx11NoiseMaterial = CheckShaderAndCreateMaterial(dx11NoiseShader, dx11NoiseMaterial);
		}
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources() || (Object)null == (Object)(object)noiseTexture)
		{
			Graphics.Blit((Texture)(object)source, destination);
			if ((Object)null == (Object)(object)noiseTexture)
			{
				Debug.LogWarning((object)"Noise & Grain effect failing as noise texture is not assigned. please assign.", (Object)(object)((Component)this).transform);
			}
			return;
		}
		softness = Mathf.Clamp(softness, 0f, 0.99f);
		if (dx11Grain && supportDX11)
		{
			dx11NoiseMaterial.SetFloat("_DX11NoiseTime", (float)Time.frameCount);
			dx11NoiseMaterial.SetTexture("_NoiseTex", (Texture)(object)noiseTexture);
			dx11NoiseMaterial.SetVector("_NoisePerChannel", Vector4.op_Implicit((!monochrome) ? intensities : Vector3.one));
			dx11NoiseMaterial.SetVector("_MidGrey", Vector4.op_Implicit(new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey)));
			dx11NoiseMaterial.SetVector("_NoiseAmount", Vector4.op_Implicit(new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier));
			if (!(softness <= float.Epsilon))
			{
				RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
				DrawNoiseQuadGrid(source, temporary, dx11NoiseMaterial, noiseTexture, (!monochrome) ? 2 : 3);
				dx11NoiseMaterial.SetTexture("_NoiseTex", (Texture)(object)temporary);
				Graphics.Blit((Texture)(object)source, destination, dx11NoiseMaterial, 4);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				DrawNoiseQuadGrid(source, destination, dx11NoiseMaterial, noiseTexture, monochrome ? 1 : 0);
			}
			return;
		}
		if (Object.op_Implicit((Object)(object)noiseTexture))
		{
			((Texture)noiseTexture).wrapMode = (TextureWrapMode)0;
			((Texture)noiseTexture).filterMode = filterMode;
		}
		noiseMaterial.SetTexture("_NoiseTex", (Texture)(object)noiseTexture);
		noiseMaterial.SetVector("_NoisePerChannel", Vector4.op_Implicit((!monochrome) ? intensities : Vector3.one));
		noiseMaterial.SetVector("_NoiseTilingPerChannel", Vector4.op_Implicit((!monochrome) ? tiling : (Vector3.one * monochromeTiling)));
		noiseMaterial.SetVector("_MidGrey", Vector4.op_Implicit(new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey)));
		noiseMaterial.SetVector("_NoiseAmount", Vector4.op_Implicit(new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier));
		if (!(softness <= float.Epsilon))
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
			DrawNoiseQuadGrid(source, temporary2, noiseMaterial, noiseTexture, 2);
			noiseMaterial.SetTexture("_NoiseTex", (Texture)(object)temporary2);
			Graphics.Blit((Texture)(object)source, destination, noiseMaterial, 1);
			RenderTexture.ReleaseTemporary(temporary2);
		}
		else
		{
			DrawNoiseQuadGrid(source, destination, noiseMaterial, noiseTexture, 0);
		}
	}

	public static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
	{
		RenderTexture.active = dest;
		float num = (float)((Texture)noise).width * 1f;
		float num2 = 1f * (float)source.width / TILE_AMOUNT;
		fxMaterial.SetTexture("_MainTex", (Texture)(object)source);
		GL.PushMatrix();
		GL.LoadOrtho();
		float num3 = 1f * (float)source.width / (1f * (float)source.height);
		float num4 = 1f / num2;
		float num5 = num4 * num3;
		float num6 = num / ((float)((Texture)noise).width * 1f);
		fxMaterial.SetPass(passNr);
		GL.Begin(7);
		for (float num7 = 0f; num7 < 1f; num7 += num4)
		{
			for (float num8 = 0f; num8 < 1f; num8 += num5)
			{
				float num9 = Random.Range(0f, 1f);
				float num10 = Random.Range(0f, 1f);
				num9 = Mathf.Floor(num9 * num) / num;
				num10 = Mathf.Floor(num10 * num) / num;
				float num11 = 1f / num;
				GL.MultiTexCoord2(0, num9, num10);
				GL.MultiTexCoord2(1, 0f, 0f);
				GL.Vertex3(num7, num8, 0.1f);
				GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
				GL.MultiTexCoord2(1, 1f, 0f);
				GL.Vertex3(num7 + num4, num8, 0.1f);
				GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
				GL.MultiTexCoord2(1, 1f, 1f);
				GL.Vertex3(num7 + num4, num8 + num5, 0.1f);
				GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
				GL.MultiTexCoord2(1, 0f, 1f);
				GL.Vertex3(num7, num8 + num5, 0.1f);
			}
		}
		GL.End();
		GL.PopMatrix();
	}

	public override void Main()
	{
	}
}
