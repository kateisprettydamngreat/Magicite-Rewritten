using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Sepia Tone")]
public class SepiaToneEffect : ImageEffectBase
{
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		Graphics.Blit(source, destination, base.material);
	}
}
