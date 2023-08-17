using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Contrast Enhance (Unsharp Mask)")]
[ExecuteInEditMode]
public class ContrastEnhance : PostEffectsBase
{
	public float intensity;

	public float threshhold;

	private Material separableBlurMaterial;

	private Material contrastCompositeMaterial;

	public float blurSpread;

	public Shader separableBlurShader;

	public Shader contrastCompositeShader;

	public ContrastEnhance()
	{
		intensity = 0.5f;
		blurSpread = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		contrastCompositeMaterial = CheckShaderAndCreateMaterial(contrastCompositeShader, contrastCompositeMaterial);
		separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width / 2f), (int)((float)source.height / 2f), 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width / 4f), (int)((float)source.height / 4f), 0);
		RenderTexture temporary3 = RenderTexture.GetTemporary((int)((float)source.width / 4f), (int)((float)source.height / 4f), 0);
		Graphics.Blit((Texture)(object)source, temporary);
		Graphics.Blit((Texture)(object)temporary, temporary2);
		separableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 1f / (float)temporary2.height, 0f, 0f));
		Graphics.Blit((Texture)(object)temporary2, temporary3, separableBlurMaterial);
		separableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 1f / (float)temporary2.width, 0f, 0f, 0f));
		Graphics.Blit((Texture)(object)temporary3, temporary2, separableBlurMaterial);
		contrastCompositeMaterial.SetTexture("_MainTexBlurred", (Texture)(object)temporary2);
		contrastCompositeMaterial.SetFloat("intensity", intensity);
		contrastCompositeMaterial.SetFloat("threshhold", threshhold);
		Graphics.Blit((Texture)(object)source, destination, contrastCompositeMaterial);
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	public override void Main()
	{
	}
}
