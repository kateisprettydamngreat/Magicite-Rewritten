using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Motion Blur (Color Accumulation)")]
[ExecuteInEditMode]
public class MotionBlur : ImageEffectBase
{
	public float blurAmount = 0.8f;

	public bool extraBlur;

	private RenderTexture accumTexture;

	protected override void Start()
	{
		if (!SystemInfo.supportsRenderTextures)
		{
			((Behaviour)this).enabled = false;
		}
		else
		{
			base.Start();
		}
	}

	protected override void OnDisable()
	{
		base.OnDisable();
		Object.DestroyImmediate((Object)(object)accumTexture);
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		if ((Object)(object)accumTexture == (Object)null || accumTexture.width != source.width || accumTexture.height != source.height)
		{
			Object.DestroyImmediate((Object)(object)accumTexture);
			accumTexture = new RenderTexture(source.width, source.height, 0);
			((Object)accumTexture).hideFlags = (HideFlags)13;
			Graphics.Blit((Texture)(object)source, accumTexture);
		}
		if (extraBlur)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
			Graphics.Blit((Texture)(object)accumTexture, temporary);
			Graphics.Blit((Texture)(object)temporary, accumTexture);
			RenderTexture.ReleaseTemporary(temporary);
		}
		blurAmount = Mathf.Clamp(blurAmount, 0f, 0.92f);
		base.material.SetTexture("_MainTex", (Texture)(object)accumTexture);
		base.material.SetFloat("_AccumOrig", 1f - blurAmount);
		Graphics.Blit((Texture)(object)source, accumTexture, base.material);
		Graphics.Blit((Texture)(object)accumTexture, destination);
	}
}
