using UnityEngine;

[AddComponentMenu("Image Effects/Edge Detection (Color)")]
[ExecuteInEditMode]
public class EdgeDetectEffect : ImageEffectBase
{
	public float threshold = 0.2f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_Treshold", threshold * threshold);
		Graphics.Blit((Texture)(object)source, destination, base.material);
	}
}
