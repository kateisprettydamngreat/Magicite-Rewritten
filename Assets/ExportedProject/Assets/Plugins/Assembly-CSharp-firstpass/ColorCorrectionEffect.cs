using UnityEngine;

[AddComponentMenu("Image Effects/Color Correction (Ramp)")]
[ExecuteInEditMode]
public class ColorCorrectionEffect : ImageEffectBase
{
	public Texture textureRamp;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetTexture("_RampTex", textureRamp);
		Graphics.Blit(source, destination, base.material);
	}
}
