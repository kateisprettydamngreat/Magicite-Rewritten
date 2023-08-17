using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/BloomAndFlares (3.5, Deprecated)")]
[ExecuteInEditMode]
public class BloomAndLensFlares : PostEffectsBase
{
	public TweakMode34 tweakMode;

	public BloomScreenBlendMode screenBlendMode;

	public HDRBloomMode hdr;

	private bool doHdr;

	public float sepBlurSpread;

	public float useSrcAlphaAsMask;

	public float bloomIntensity;

	public float bloomThreshhold;

	public int bloomBlurIterations;

	public bool lensflares;

	public int hollywoodFlareBlurIterations;

	public LensflareStyle34 lensflareMode;

	public float hollyStretchWidth;

	public float lensflareIntensity;

	public float lensflareThreshhold;

	public Color flareColorA;

	public Color flareColorB;

	public Color flareColorC;

	public Color flareColorD;

	public float blurWidth;

	public Texture2D lensFlareVignetteMask;

	public Shader lensFlareShader;

	private Material lensFlareMaterial;

	public Shader vignetteShader;

	private Material vignetteMaterial;

	public Shader separableBlurShader;

	private Material separableBlurMaterial;

	public Shader addBrightStuffOneOneShader;

	private Material addBrightStuffBlendOneOneMaterial;

	public Shader screenBlendShader;

	private Material screenBlend;

	public Shader hollywoodFlaresShader;

	private Material hollywoodFlaresMaterial;

	public Shader brightPassFilterShader;

	private Material brightPassFilterMaterial;

	public BloomAndLensFlares()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		screenBlendMode = BloomScreenBlendMode.Add;
		hdr = HDRBloomMode.Auto;
		sepBlurSpread = 1.5f;
		useSrcAlphaAsMask = 0.5f;
		bloomIntensity = 1f;
		bloomThreshhold = 0.5f;
		bloomBlurIterations = 2;
		hollywoodFlareBlurIterations = 2;
		lensflareMode = LensflareStyle34.Anamorphic;
		hollyStretchWidth = 3.5f;
		lensflareIntensity = 1f;
		lensflareThreshhold = 0.3f;
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
		vignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, vignetteMaterial);
		separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
		addBrightStuffBlendOneOneMaterial = CheckShaderAndCreateMaterial(addBrightStuffOneOneShader, addBrightStuffBlendOneOneMaterial);
		hollywoodFlaresMaterial = CheckShaderAndCreateMaterial(hollywoodFlaresShader, hollywoodFlaresMaterial);
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
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
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
		Graphics.Blit((Texture)(object)source, temporary, screenBlend, 2);
		Graphics.Blit((Texture)(object)temporary, temporary2, screenBlend, 2);
		RenderTexture.ReleaseTemporary(temporary);
		BrightFilter(bloomThreshhold, useSrcAlphaAsMask, temporary2, temporary3);
		temporary2.DiscardContents();
		if (bloomBlurIterations < 1)
		{
			bloomBlurIterations = 1;
		}
		for (int i = 0; i < bloomBlurIterations; i++)
		{
			float num5 = (1f + (float)i * 0.5f) * sepBlurSpread;
			separableBlurMaterial.SetVector("offsets", new Vector4(0f, num5 * num4, 0f, 0f));
			RenderTexture val2 = ((i != 0) ? temporary2 : temporary3);
			Graphics.Blit((Texture)(object)val2, temporary4, separableBlurMaterial);
			val2.DiscardContents();
			separableBlurMaterial.SetVector("offsets", new Vector4(num5 / num3 * num4, 0f, 0f, 0f));
			Graphics.Blit((Texture)(object)temporary4, temporary2, separableBlurMaterial);
			temporary4.DiscardContents();
		}
		if (lensflares)
		{
			if (lensflareMode == LensflareStyle34.Ghosting)
			{
				BrightFilter(lensflareThreshhold, 0f, temporary2, temporary4);
				temporary2.DiscardContents();
				Vignette(0.975f, temporary4, temporary3);
				temporary4.DiscardContents();
				BlendFlares(temporary3, temporary2);
				temporary3.DiscardContents();
			}
			else
			{
				hollywoodFlaresMaterial.SetVector("_Threshhold", new Vector4(lensflareThreshhold, 1f / (1f - lensflareThreshhold), 0f, 0f));
				hollywoodFlaresMaterial.SetVector("tintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
				Graphics.Blit((Texture)(object)temporary4, temporary3, hollywoodFlaresMaterial, 2);
				temporary4.DiscardContents();
				Graphics.Blit((Texture)(object)temporary3, temporary4, hollywoodFlaresMaterial, 3);
				temporary3.DiscardContents();
				hollywoodFlaresMaterial.SetVector("offsets", new Vector4(sepBlurSpread * 1f / num3 * num4, 0f, 0f, 0f));
				hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth);
				Graphics.Blit((Texture)(object)temporary4, temporary3, hollywoodFlaresMaterial, 1);
				temporary4.DiscardContents();
				hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 2f);
				Graphics.Blit((Texture)(object)temporary3, temporary4, hollywoodFlaresMaterial, 1);
				temporary3.DiscardContents();
				hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 4f);
				Graphics.Blit((Texture)(object)temporary4, temporary3, hollywoodFlaresMaterial, 1);
				temporary4.DiscardContents();
				if (lensflareMode == LensflareStyle34.Anamorphic)
				{
					for (int j = 0; j < hollywoodFlareBlurIterations; j++)
					{
						separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num3 * num4, 0f, 0f, 0f));
						Graphics.Blit((Texture)(object)temporary3, temporary4, separableBlurMaterial);
						temporary3.DiscardContents();
						separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num3 * num4, 0f, 0f, 0f));
						Graphics.Blit((Texture)(object)temporary4, temporary3, separableBlurMaterial);
						temporary4.DiscardContents();
					}
					AddTo(1f, temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					for (int k = 0; k < hollywoodFlareBlurIterations; k++)
					{
						separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num3 * num4, 0f, 0f, 0f));
						Graphics.Blit((Texture)(object)temporary3, temporary4, separableBlurMaterial);
						temporary3.DiscardContents();
						separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num3 * num4, 0f, 0f, 0f));
						Graphics.Blit((Texture)(object)temporary4, temporary3, separableBlurMaterial);
						temporary4.DiscardContents();
					}
					Vignette(1f, temporary3, temporary4);
					temporary3.DiscardContents();
					BlendFlares(temporary4, temporary3);
					temporary4.DiscardContents();
					AddTo(1f, temporary3, temporary2);
					temporary3.DiscardContents();
				}
			}
		}
		screenBlend.SetFloat("_Intensity", bloomIntensity);
		screenBlend.SetTexture("_ColorBuffer", (Texture)(object)source);
		Graphics.Blit((Texture)(object)temporary2, destination, screenBlend, (int)bloomScreenBlendMode);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
		RenderTexture.ReleaseTemporary(temporary4);
	}

	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
		addBrightStuffBlendOneOneMaterial.SetFloat("_Intensity", intensity_);
		Graphics.Blit((Texture)(object)from, to, addBrightStuffBlendOneOneMaterial);
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

	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (doHdr)
		{
			brightPassFilterMaterial.SetVector("threshhold", new Vector4(thresh, 1f, 0f, 0f));
		}
		else
		{
			brightPassFilterMaterial.SetVector("threshhold", new Vector4(thresh, 1f / (1f - thresh), 0f, 0f));
		}
		brightPassFilterMaterial.SetFloat("useSrcAlphaAsMask", useAlphaAsMask);
		Graphics.Blit((Texture)(object)from, to, brightPassFilterMaterial);
	}

	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
		if (Object.op_Implicit((Object)(object)lensFlareVignetteMask))
		{
			screenBlend.SetTexture("_ColorBuffer", (Texture)(object)lensFlareVignetteMask);
			Graphics.Blit((Texture)(object)from, to, screenBlend, 3);
		}
		else
		{
			vignetteMaterial.SetFloat("vignetteIntensity", amount);
			Graphics.Blit((Texture)(object)from, to, vignetteMaterial);
		}
	}

	public override void Main()
	{
	}
}
