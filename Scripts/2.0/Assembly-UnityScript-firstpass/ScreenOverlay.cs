using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Screen Overlay")]
public class ScreenOverlay : PostEffectsBase
{
	[Serializable]
	public enum OverlayBlendMode
	{
		Additive,
		ScreenBlend,
		Multiply,
		Overlay,
		AlphaBlend
	}

	public OverlayBlendMode blendMode;

	public float intensity;

	public Texture2D texture;

	public Shader overlayShader;

	private Material overlayMaterial;

	public ScreenOverlay()
	{
		blendMode = OverlayBlendMode.Overlay;
		intensity = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		overlayMaterial = CheckShaderAndCreateMaterial(overlayShader, overlayMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		overlayMaterial.SetFloat("_Intensity", intensity);
		overlayMaterial.SetTexture("_Overlay", texture);
		Graphics.Blit(source, destination, overlayMaterial, (int)blendMode);
	}

	public override void Main()
	{
	}
}
