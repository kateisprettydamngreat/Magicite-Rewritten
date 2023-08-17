using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Depth of Field (3.4)")]
[ExecuteInEditMode]
public class DepthOfField34 : PostEffectsBase
{
	[NonSerialized]
	private static int SMOOTH_DOWNSAMPLE_PASS = 6;

	[NonSerialized]
	private static float BOKEH_EXTRA_BLUR = 2f;

	public Dof34QualitySetting quality;

	public DofResolution resolution;

	public bool simpleTweakMode;

	public float focalPoint;

	public float smoothness;

	public float focalZDistance;

	public float focalZStartCurve;

	public float focalZEndCurve;

	private float focalStartCurve;

	private float focalEndCurve;

	private float focalDistance01;

	public Transform objectFocus;

	public float focalSize;

	public DofBlurriness bluriness;

	public float maxBlurSpread;

	public float foregroundBlurExtrude;

	public Shader dofBlurShader;

	private Material dofBlurMaterial;

	public Shader dofShader;

	private Material dofMaterial;

	public bool visualize;

	public BokehDestination bokehDestination;

	private float widthOverHeight;

	private float oneOverBaseSize;

	public bool bokeh;

	public bool bokehSupport;

	public Shader bokehShader;

	public Texture2D bokehTexture;

	public float bokehScale;

	public float bokehIntensity;

	public float bokehThreshholdContrast;

	public float bokehThreshholdLuminance;

	public int bokehDownsample;

	private Material bokehMaterial;

	private RenderTexture foregroundTexture;

	private RenderTexture mediumRezWorkTexture;

	private RenderTexture finalDefocus;

	private RenderTexture lowRezWorkTexture;

	private RenderTexture bokehSource;

	private RenderTexture bokehSource2;

	public DepthOfField34()
	{
		quality = Dof34QualitySetting.OnlyBackground;
		resolution = DofResolution.Low;
		simpleTweakMode = true;
		focalPoint = 1f;
		smoothness = 0.5f;
		focalZStartCurve = 1f;
		focalZEndCurve = 1f;
		focalStartCurve = 2f;
		focalEndCurve = 2f;
		focalDistance01 = 0.1f;
		bluriness = DofBlurriness.High;
		maxBlurSpread = 1.75f;
		foregroundBlurExtrude = 1.15f;
		bokehDestination = BokehDestination.Background;
		widthOverHeight = 1.25f;
		oneOverBaseSize = 0.001953125f;
		bokehSupport = true;
		bokehScale = 2.4f;
		bokehIntensity = 0.15f;
		bokehThreshholdContrast = 0.1f;
		bokehThreshholdLuminance = 0.55f;
		bokehDownsample = 1;
	}

	public virtual void CreateMaterials()
	{
		dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
		dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
		bokehSupport = bokehShader.isSupported;
		if (bokeh && bokehSupport && (bool)bokehShader)
		{
			bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
		}
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
		dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
		bokehSupport = bokehShader.isSupported;
		if (bokeh && bokehSupport && (bool)bokehShader)
		{
			bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
		}
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public virtual void OnDisable()
	{
		Quads.Cleanup();
	}

	public override void OnEnable()
	{
		GetComponent<Camera>().depthTextureMode = GetComponent<Camera>().depthTextureMode | DepthTextureMode.Depth;
	}

	public virtual float FocalDistance01(float worldDist)
	{
		return GetComponent<Camera>().WorldToViewportPoint((worldDist - GetComponent<Camera>().nearClipPlane) * GetComponent<Camera>().transform.forward + GetComponent<Camera>().transform.position).z / (GetComponent<Camera>().farClipPlane - GetComponent<Camera>().nearClipPlane);
	}

	public virtual int GetDividerBasedOnQuality()
	{
		int result = 1;
		if (resolution == DofResolution.Medium)
		{
			result = 2;
		}
		else if (resolution == DofResolution.Low)
		{
			result = 2;
		}
		return result;
	}

	public virtual int GetLowResolutionDividerBasedOnQuality(int baseDivider)
	{
		int num = baseDivider;
		if (resolution == DofResolution.High)
		{
			num *= 2;
		}
		if (resolution == DofResolution.Low)
		{
			num *= 2;
		}
		return num;
	}

	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!CheckResources())
		{
			Graphics.Blit(source, destination);
			return;
		}
		if (!(smoothness >= 0.1f))
		{
			smoothness = 0.1f;
		}
		bool num = bokeh;
		if (num)
		{
			num = bokehSupport;
		}
		bokeh = num;
		float num2 = ((!bokeh) ? 1f : BOKEH_EXTRA_BLUR);
		bool flag = quality > Dof34QualitySetting.OnlyBackground;
		float num3 = focalSize / (GetComponent<Camera>().farClipPlane - GetComponent<Camera>().nearClipPlane);
		if (simpleTweakMode)
		{
			focalDistance01 = ((!objectFocus) ? FocalDistance01(focalPoint) : (GetComponent<Camera>().WorldToViewportPoint(objectFocus.position).z / GetComponent<Camera>().farClipPlane));
			focalStartCurve = focalDistance01 * smoothness;
			focalEndCurve = focalStartCurve;
			bool num4 = flag;
			if (num4)
			{
				num4 = focalPoint > GetComponent<Camera>().nearClipPlane + Mathf.Epsilon;
			}
			flag = num4;
		}
		else
		{
			if ((bool)objectFocus)
			{
				Vector3 vector = GetComponent<Camera>().WorldToViewportPoint(objectFocus.position);
				vector.z /= GetComponent<Camera>().farClipPlane;
				focalDistance01 = vector.z;
			}
			else
			{
				focalDistance01 = FocalDistance01(focalZDistance);
			}
			focalStartCurve = focalZStartCurve;
			focalEndCurve = focalZEndCurve;
			bool num5 = flag;
			if (num5)
			{
				num5 = focalPoint > GetComponent<Camera>().nearClipPlane + Mathf.Epsilon;
			}
			flag = num5;
		}
		widthOverHeight = 1f * (float)source.width / (1f * (float)source.height);
		oneOverBaseSize = 0.001953125f;
		dofMaterial.SetFloat("_ForegroundBlurExtrude", foregroundBlurExtrude);
		dofMaterial.SetVector("_CurveParams", new Vector4((!simpleTweakMode) ? focalStartCurve : (1f / focalStartCurve), (!simpleTweakMode) ? focalEndCurve : (1f / focalEndCurve), num3 * 0.5f, focalDistance01));
		dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), 0f, 0f));
		int dividerBasedOnQuality = GetDividerBasedOnQuality();
		int lowResolutionDividerBasedOnQuality = GetLowResolutionDividerBasedOnQuality(dividerBasedOnQuality);
		AllocateTextures(flag, source, dividerBasedOnQuality, lowResolutionDividerBasedOnQuality);
		Graphics.Blit(source, source, dofMaterial, 3);
		Downsample(source, mediumRezWorkTexture);
		Blur(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 4, maxBlurSpread);
		if (bokeh && (bokehDestination & BokehDestination.Background) != 0)
		{
			dofMaterial.SetVector("_Threshhold", new Vector4(bokehThreshholdContrast, bokehThreshholdLuminance, 0.95f, 0f));
			Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
			Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
			Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread * num2);
		}
		else
		{
			Downsample(mediumRezWorkTexture, lowRezWorkTexture);
			Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread);
		}
		dofBlurMaterial.SetTexture("_TapLow", lowRezWorkTexture);
		dofBlurMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
		Graphics.Blit(null, finalDefocus, dofBlurMaterial, 3);
		if (bokeh && (bokehDestination & BokehDestination.Background) != 0)
		{
			AddBokeh(bokehSource2, bokehSource, finalDefocus);
		}
		dofMaterial.SetTexture("_TapLowBackground", finalDefocus);
		dofMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
		Graphics.Blit(source, (!flag) ? destination : foregroundTexture, dofMaterial, visualize ? 2 : 0);
		if (flag)
		{
			Graphics.Blit(foregroundTexture, source, dofMaterial, 5);
			Downsample(source, mediumRezWorkTexture);
			BlurFg(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 2, maxBlurSpread);
			if (bokeh && (bokehDestination & BokehDestination.Foreground) != 0)
			{
				dofMaterial.SetVector("_Threshhold", new Vector4(bokehThreshholdContrast * 0.5f, bokehThreshholdLuminance, 0f, 0f));
				Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
				Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
				BlurFg(lowRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread * num2);
			}
			else
			{
				BlurFg(mediumRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread);
			}
			Graphics.Blit(lowRezWorkTexture, finalDefocus);
			dofMaterial.SetTexture("_TapLowForeground", finalDefocus);
			Graphics.Blit(source, destination, dofMaterial, visualize ? 1 : 4);
			if (bokeh && (bokehDestination & BokehDestination.Foreground) != 0)
			{
				AddBokeh(bokehSource2, bokehSource, destination);
			}
		}
		ReleaseTextures();
	}

	public virtual void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
		if (iterations > DofBlurriness.Low)
		{
			BlurHex(from, to, blurPass, spread, temporary);
			if (iterations > DofBlurriness.High)
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
		}
		else
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	public virtual void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
		dofBlurMaterial.SetTexture("_TapHigh", from);
		RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
		if (iterations > DofBlurriness.Low)
		{
			BlurHex(from, to, blurPass, spread, temporary);
			if (iterations > DofBlurriness.High)
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
		}
		else
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	public virtual void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
	{
		dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
		Graphics.Blit(from, tmp, dofBlurMaterial, blurPass);
		dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
		Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
		dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, spread * oneOverBaseSize, 0f, 0f));
		Graphics.Blit(to, tmp, dofBlurMaterial, blurPass);
		dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, (0f - spread) * oneOverBaseSize, 0f, 0f));
		Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
	}

	public virtual void Downsample(RenderTexture from, RenderTexture to)
	{
		dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)to.width), 1f / (1f * (float)to.height), 0f, 0f));
		Graphics.Blit(from, to, dofMaterial, SMOOTH_DOWNSAMPLE_PASS);
	}

	public virtual void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
	{
		if (!bokehMaterial)
		{
			return;
		}
		Mesh[] meshes = Quads.GetMeshes(tempTex.width, tempTex.height);
		RenderTexture.active = tempTex;
		GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
		GL.PushMatrix();
		GL.LoadIdentity();
		bokehInfo.filterMode = FilterMode.Point;
		float num = (float)bokehInfo.width * 1f / ((float)bokehInfo.height * 1f);
		float num2 = 2f / (1f * (float)bokehInfo.width);
		num2 += bokehScale * maxBlurSpread * BOKEH_EXTRA_BLUR * oneOverBaseSize;
		bokehMaterial.SetTexture("_Source", bokehInfo);
		bokehMaterial.SetTexture("_MainTex", bokehTexture);
		bokehMaterial.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
		bokehMaterial.SetFloat("_Intensity", bokehIntensity);
		bokehMaterial.SetPass(0);
		int i = 0;
		Mesh[] array = meshes;
		for (int length = array.Length; i < length; i++)
		{
			if ((bool)array[i])
			{
				Graphics.DrawMeshNow(array[i], Matrix4x4.identity);
			}
		}
		GL.PopMatrix();
		Graphics.Blit(tempTex, finalTarget, dofMaterial, 8);
		bokehInfo.filterMode = FilterMode.Bilinear;
	}

	public virtual void ReleaseTextures()
	{
		if ((bool)foregroundTexture)
		{
			RenderTexture.ReleaseTemporary(foregroundTexture);
		}
		if ((bool)finalDefocus)
		{
			RenderTexture.ReleaseTemporary(finalDefocus);
		}
		if ((bool)mediumRezWorkTexture)
		{
			RenderTexture.ReleaseTemporary(mediumRezWorkTexture);
		}
		if ((bool)lowRezWorkTexture)
		{
			RenderTexture.ReleaseTemporary(lowRezWorkTexture);
		}
		if ((bool)bokehSource)
		{
			RenderTexture.ReleaseTemporary(bokehSource);
		}
		if ((bool)bokehSource2)
		{
			RenderTexture.ReleaseTemporary(bokehSource2);
		}
	}

	public virtual void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
	{
		foregroundTexture = null;
		if (blurForeground)
		{
			foregroundTexture = RenderTexture.GetTemporary(source.width, source.height, 0);
		}
		mediumRezWorkTexture = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
		finalDefocus = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
		lowRezWorkTexture = RenderTexture.GetTemporary(source.width / lowTexDivider, source.height / lowTexDivider, 0);
		bokehSource = null;
		bokehSource2 = null;
		if (bokeh)
		{
			bokehSource = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
			bokehSource2 = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
			bokehSource.filterMode = FilterMode.Bilinear;
			bokehSource2.filterMode = FilterMode.Bilinear;
			RenderTexture.active = bokehSource2;
			GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
		}
		source.filterMode = FilterMode.Bilinear;
		finalDefocus.filterMode = FilterMode.Bilinear;
		mediumRezWorkTexture.filterMode = FilterMode.Bilinear;
		lowRezWorkTexture.filterMode = FilterMode.Bilinear;
		if ((bool)foregroundTexture)
		{
			foregroundTexture.filterMode = FilterMode.Bilinear;
		}
	}

	public override void Main()
	{
	}
}
