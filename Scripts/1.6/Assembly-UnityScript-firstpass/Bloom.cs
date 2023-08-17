using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Bloom (4.0, HDR, Lens Flares)")]
public class Bloom : PostEffectsBase
{
	[Serializable]
	public enum LensFlareStyle
	{
		Ghosting,
		Anamorphic,
		Combined
	}

	[Serializable]
	public enum TweakMode
	{
		Basic,
		Complex
	}

	[Serializable]
	public enum HDRBloomMode
	{
		Auto,
		On,
		Off
	}

	[Serializable]
	public enum BloomScreenBlendMode
	{
		Screen,
		Add
	}

	[Serializable]
	public enum BloomQuality
	{
		Cheap,
		High
	}

	public TweakMode tweakMode;

	public BloomScreenBlendMode screenBlendMode;

	public HDRBloomMode hdr;

	private bool doHdr;

	public float sepBlurSpread;

	public BloomQuality quality;

	public float bloomIntensity;

	public float bloomThreshhold;

	public Color bloomThreshholdColor;

	public int bloomBlurIterations;

	public int hollywoodFlareBlurIterations;

	public float flareRotation;

	public LensFlareStyle lensflareMode;

	public float hollyStretchWidth;

	public float lensflareIntensity;

	public float lensflareThreshhold;

	public float lensFlareSaturation;

	public Color flareColorA;

	public Color flareColorB;

	public Color flareColorC;

	public Color flareColorD;

	public float blurWidth;

	public Texture2D lensFlareVignetteMask;

	public Shader lensFlareShader;

	private Material lensFlareMaterial;

	public Shader screenBlendShader;

	private Material screenBlend;

	public Shader blurAndFlaresShader;

	private Material blurAndFlaresMaterial;

	public Shader brightPassFilterShader;

	private Material brightPassFilterMaterial;

	public Bloom()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		screenBlendMode = BloomScreenBlendMode.Add;
		hdr = HDRBloomMode.Auto;
		sepBlurSpread = 2.5f;
		quality = BloomQuality.High;
		bloomIntensity = 0.5f;
		bloomThreshhold = 0.5f;
		bloomThreshholdColor = Color.white;
		bloomBlurIterations = 2;
		hollywoodFlareBlurIterations = 2;
		lensflareMode = LensFlareStyle.Anamorphic;
		hollyStretchWidth = 2.5f;
		lensflareThreshhold = 0.3f;
		lensFlareSaturation = 0.75f;
		flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);
		flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);
		flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);
		flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);
		blurWidth = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
		lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
		blurAndFlaresMaterial = CheckShaderAndCreateMaterial(blurAndFlaresShader, blurAndFlaresMaterial);
		brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		doHdr = false;
		if (hdr == HDRBloomMode.Auto)
		{
			bool num = (int)source.format == 2;
			if (num)
			{
				num = ((Component)this).camera.hdr;
			}
			doHdr = num;
		}
		else
		{
			doHdr = hdr == HDRBloomMode.On;
		}
		bool num2 = doHdr;
		if (num2)
		{
			num2 = supportHDRTextures;
		}
		doHdr = num2;
		BloomScreenBlendMode bloomScreenBlendMode = screenBlendMode;
		if (doHdr)
		{
			bloomScreenBlendMode = BloomScreenBlendMode.Add;
		}
		RenderTextureFormat val = (RenderTextureFormat)((!doHdr) ? 7 : 2);
		RenderTexture temporary = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0, val);
		RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, val);
		RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, val);
		RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, val);
		float num3 = 1f * (float)source.width / (1f * (float)source.height);
		float num4 = 0.001953125f;
		if (quality > BloomQuality.Cheap)
		{
			Graphics.Blit((Texture)(object)source, temporary, screenBlend, 2);
			Graphics.Blit((Texture)(object)temporary, temporary3, screenBlend, 2);
			Graphics.Blit((Texture)(object)temporary3, temporary2, screenBlend, 6);
		}
		else
		{
			Graphics.Blit((Texture)(object)source, temporary);
			Graphics.Blit((Texture)(object)temporary, temporary2, screenBlend, 6);
		}
		BrightFilter(bloomThreshhold * bloomThreshholdColor, temporary2, temporary3);
		if (bloomBlurIterations < 1)
		{
			bloomBlurIterations = 1;
		}
		else if (bloomBlurIterations > 10)
		{
			bloomBlurIterations = 10;
		}
		for (int i = 0; i < bloomBlurIterations; i++)
		{
			float num5 = (1f + (float)i * 0.25f) * sepBlurSpread;
			blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, num5 * num4, 0f, 0f));
			Graphics.Blit((Texture)(object)temporary3, temporary4, blurAndFlaresMaterial, 4);
			if (quality > BloomQuality.Cheap)
			{
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num5 / num3 * num4, 0f, 0f, 0f));
				Graphics.Blit((Texture)(object)temporary4, temporary3, blurAndFlaresMaterial, 4);
				if (i == 0)
				{
					Graphics.Blit((Texture)(object)temporary3, temporary2);
				}
				else
				{
					Graphics.Blit((Texture)(object)temporary3, temporary2, screenBlend, 10);
				}
			}
			else
			{
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num5 / num3 * num4, 0f, 0f, 0f));
				Graphics.Blit((Texture)(object)temporary4, temporary3, blurAndFlaresMaterial, 4);
			}
		}
		if (quality > BloomQuality.Cheap)
		{
			Graphics.Blit((Texture)(object)temporary2, temporary3, screenBlend, 6);
		}
		if (!(lensflareIntensity <= float.Epsilon))
		{
			if (lensflareMode == LensFlareStyle.Ghosting)
			{
				BrightFilter(lensflareThreshhold, temporary3, temporary4);
				if (quality > BloomQuality.Cheap)
				{
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary2.height), 0f, 0f));
					Graphics.Blit((Texture)(object)temporary4, temporary2, blurAndFlaresMaterial, 4);
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary2.width), 0f, 0f, 0f));
					Graphics.Blit((Texture)(object)temporary2, temporary4, blurAndFlaresMaterial, 4);
				}
				Vignette(0.975f, temporary4, temporary4);
				BlendFlares(temporary4, temporary3);
			}
			else
			{
				float num6 = 1f * Mathf.Cos(flareRotation);
				float num7 = 1f * Mathf.Sin(flareRotation);
				float num8 = hollyStretchWidth * 1f / num3 * num4;
				float num9 = hollyStretchWidth * num4;
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6, num7, 0f, 0f));
				blurAndFlaresMaterial.SetVector("_Threshhold", new Vector4(lensflareThreshhold, 1f, 0f, 0f));
				blurAndFlaresMaterial.SetVector("_TintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
				blurAndFlaresMaterial.SetFloat("_Saturation", lensFlareSaturation);
				Graphics.Blit((Texture)(object)temporary4, temporary2, blurAndFlaresMaterial, 2);
				Graphics.Blit((Texture)(object)temporary2, temporary4, blurAndFlaresMaterial, 3);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num8, num7 * num8, 0f, 0f));
				blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth);
				Graphics.Blit((Texture)(object)temporary4, temporary2, blurAndFlaresMaterial, 1);
				blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 2f);
				Graphics.Blit((Texture)(object)temporary2, temporary4, blurAndFlaresMaterial, 1);
				blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 4f);
				Graphics.Blit((Texture)(object)temporary4, temporary2, blurAndFlaresMaterial, 1);
				for (int i = 0; i < hollywoodFlareBlurIterations; i++)
				{
					num8 = hollyStretchWidth * 2f / num3 * num4;
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num8 * num6, num8 * num7, 0f, 0f));
					Graphics.Blit((Texture)(object)temporary2, temporary4, blurAndFlaresMaterial, 4);
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num8 * num6, num8 * num7, 0f, 0f));
					Graphics.Blit((Texture)(object)temporary4, temporary2, blurAndFlaresMaterial, 4);
				}
				if (lensflareMode == LensFlareStyle.Anamorphic)
				{
					AddTo(1f, temporary2, temporary3);
				}
				else
				{
					Vignette(1f, temporary2, temporary4);
					BlendFlares(temporary4, temporary2);
					AddTo(1f, temporary2, temporary3);
				}
			}
		}
		int num10 = (int)bloomScreenBlendMode;
		screenBlend.SetFloat("_Intensity", bloomIntensity);
		screenBlend.SetTexture("_ColorBuffer", (Texture)(object)source);
		if (quality > BloomQuality.Cheap)
		{
			Graphics.Blit((Texture)(object)temporary3, temporary);
			Graphics.Blit((Texture)(object)temporary, destination, screenBlend, num10);
		}
		else
		{
			Graphics.Blit((Texture)(object)temporary3, destination, screenBlend, num10);
		}
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
		RenderTexture.ReleaseTemporary(temporary4);
	}

	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
		screenBlend.SetFloat("_Intensity", intensity_);
		Graphics.Blit((Texture)(object)from, to, screenBlend, 9);
	}

	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
		lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
		lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
		lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
		Graphics.Blit((Texture)(object)from, to, lensFlareMaterial);
	}

	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		brightPassFilterMaterial.SetVector("_Threshhold", new Vector4(thresh, thresh, thresh, thresh));
		Graphics.Blit((Texture)(object)from, to, brightPassFilterMaterial, 0);
	}

	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		brightPassFilterMaterial.SetVector("_Threshhold", Color.op_Implicit(threshColor));
		Graphics.Blit((Texture)(object)from, to, brightPassFilterMaterial, 1);
	}

	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
		if (Object.op_Implicit((Object)(object)lensFlareVignetteMask))
		{
			screenBlend.SetTexture("_ColorBuffer", (Texture)(object)lensFlareVignetteMask);
			Graphics.Blit((Texture)(object)((!((Object)(object)from == (Object)(object)to)) ? from : null), to, screenBlend, (!((Object)(object)from == (Object)(object)to)) ? 3 : 7);
		}
		else if ((Object)(object)from != (Object)(object)to)
		{
			Graphics.Blit((Texture)(object)from, to);
		}
	}

	public override void Main()
	{
	}
}
