using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Sun Shafts")]
public class SunShafts : PostEffectsBase
{
	public SunShaftsResolution resolution;

	public ShaftsScreenBlendMode screenBlendMode;

	public Transform sunTransform;

	public int radialBlurIterations;

	public Color sunColor;

	public float sunShaftBlurRadius;

	public float sunShaftIntensity;

	public float useSkyBoxAlpha;

	public float maxRadius;

	public bool useDepthTexture;

	public Shader sunShaftsShader;

	private Material sunShaftsMaterial;

	public Shader simpleClearShader;

	private Material simpleClearMaterial;

	public SunShafts()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		resolution = SunShaftsResolution.Normal;
		screenBlendMode = ShaftsScreenBlendMode.Screen;
		radialBlurIterations = 2;
		sunColor = Color.white;
		sunShaftBlurRadius = 2.5f;
		sunShaftIntensity = 1.15f;
		useSkyBoxAlpha = 0.75f;
		maxRadius = 0.75f;
		useDepthTexture = true;
	}

	public override bool CheckResources()
	{
		CheckSupport(useDepthTexture);
		sunShaftsMaterial = CheckShaderAndCreateMaterial(sunShaftsShader, sunShaftsMaterial);
		simpleClearMaterial = CheckShaderAndCreateMaterial(simpleClearShader, simpleClearMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		if (useDepthTexture)
		{
			((Component)this).camera.depthTextureMode = (DepthTextureMode)(((Component)this).camera.depthTextureMode | 1);
		}
		float num = 4f;
		if (resolution == SunShaftsResolution.Normal)
		{
			num = 2f;
		}
		else if (resolution == SunShaftsResolution.High)
		{
			num = 1f;
		}
		Vector3 val = Vector3.one * 0.5f;
		val = (Vector3)((!Object.op_Implicit((Object)(object)sunTransform)) ? new Vector3(0.5f, 0.5f, 0f) : ((Component)this).camera.WorldToViewportPoint(sunTransform.position));
		RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width / num), (int)((float)source.height / num), 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width / num), (int)((float)source.height / num), 0);
		sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * sunShaftBlurRadius);
		sunShaftsMaterial.SetVector("_SunPosition", new Vector4(val.x, val.y, val.z, maxRadius));
		sunShaftsMaterial.SetFloat("_NoSkyBoxMask", 1f - useSkyBoxAlpha);
		if (!useDepthTexture)
		{
			RenderTexture val2 = (RenderTexture.active = RenderTexture.GetTemporary(source.width, source.height, 0));
			GL.ClearWithSkybox(false, ((Component)this).camera);
			sunShaftsMaterial.SetTexture("_Skybox", (Texture)(object)val2);
			Graphics.Blit((Texture)(object)source, temporary2, sunShaftsMaterial, 3);
			RenderTexture.ReleaseTemporary(val2);
		}
		else
		{
			Graphics.Blit((Texture)(object)source, temporary2, sunShaftsMaterial, 2);
		}
		DrawBorder(temporary2, simpleClearMaterial);
		radialBlurIterations = ClampBlurIterationsToSomethingThatMakesSense(radialBlurIterations);
		float num2 = sunShaftBlurRadius * 0.0013020834f;
		sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
		sunShaftsMaterial.SetVector("_SunPosition", new Vector4(val.x, val.y, val.z, maxRadius));
		for (int i = 0; i < radialBlurIterations; i++)
		{
			Graphics.Blit((Texture)(object)temporary2, temporary, sunShaftsMaterial, 1);
			num2 = sunShaftBlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			Graphics.Blit((Texture)(object)temporary, temporary2, sunShaftsMaterial, 1);
			num2 = sunShaftBlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
		}
		if (!(val.z < 0f))
		{
			sunShaftsMaterial.SetVector("_SunColor", new Vector4(sunColor.r, sunColor.g, sunColor.b, sunColor.a) * sunShaftIntensity);
		}
		else
		{
			sunShaftsMaterial.SetVector("_SunColor", Vector4.zero);
		}
		sunShaftsMaterial.SetTexture("_ColorBuffer", (Texture)(object)temporary2);
		Graphics.Blit((Texture)(object)source, destination, sunShaftsMaterial, (screenBlendMode != 0) ? 4 : 0);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary);
	}

	private int ClampBlurIterationsToSomethingThatMakesSense(int its)
	{
		return (its < 1) ? 1 : ((its <= 4) ? its : 4);
	}

	public override void Main()
	{
	}
}
