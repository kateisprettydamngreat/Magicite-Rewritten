using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Edge Detection (Color)")]
public class EdgeDetectEffect : ImageEffectBase
{
	public float threshold = 0.2f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_Treshold", threshold * threshold);
		Graphics.Blit(source, destination, base.material);
	}
}
