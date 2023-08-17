using System;
using UnityEngine;

[Serializable]
[AddComponentMenu("Image Effects/Color Correction (Curves, Saturation)")]
[ExecuteInEditMode]
public class ColorCorrectionCurves : PostEffectsBase
{
	public AnimationCurve redChannel;

	public AnimationCurve greenChannel;

	public AnimationCurve blueChannel;

	public bool useDepthCorrection;

	public AnimationCurve zCurve;

	public AnimationCurve depthRedChannel;

	public AnimationCurve depthGreenChannel;

	public AnimationCurve depthBlueChannel;

	private Material ccMaterial;

	private Material ccDepthMaterial;

	private Material selectiveCcMaterial;

	private Texture2D rgbChannelTex;

	private Texture2D rgbDepthChannelTex;

	private Texture2D zCurveTex;

	public float saturation;

	public bool selectiveCc;

	public Color selectiveFromColor;

	public Color selectiveToColor;

	public ColorCorrectionMode mode;

	public bool updateTextures;

	public Shader colorCorrectionCurvesShader;

	public Shader simpleColorCorrectionCurvesShader;

	public Shader colorCorrectionSelectiveShader;

	private bool updateTexturesOnStartup;

	public ColorCorrectionCurves()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		saturation = 1f;
		selectiveFromColor = Color.white;
		selectiveToColor = Color.white;
		updateTextures = true;
		updateTexturesOnStartup = true;
	}

	public override void Start()
	{
		base.Start();
		updateTexturesOnStartup = true;
	}

	public override void Awake()
	{
	}

	public override bool CheckResources()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		CheckSupport(mode == ColorCorrectionMode.Advanced);
		ccMaterial = CheckShaderAndCreateMaterial(simpleColorCorrectionCurvesShader, ccMaterial);
		ccDepthMaterial = CheckShaderAndCreateMaterial(colorCorrectionCurvesShader, ccDepthMaterial);
		selectiveCcMaterial = CheckShaderAndCreateMaterial(colorCorrectionSelectiveShader, selectiveCcMaterial);
		if (!Object.op_Implicit((Object)(object)rgbChannelTex))
		{
			rgbChannelTex = new Texture2D(256, 4, (TextureFormat)5, false, true);
		}
		if (!Object.op_Implicit((Object)(object)rgbDepthChannelTex))
		{
			rgbDepthChannelTex = new Texture2D(256, 4, (TextureFormat)5, false, true);
		}
		if (!Object.op_Implicit((Object)(object)zCurveTex))
		{
			zCurveTex = new Texture2D(256, 1, (TextureFormat)5, false, true);
		}
		((Object)rgbChannelTex).hideFlags = (HideFlags)4;
		((Object)rgbDepthChannelTex).hideFlags = (HideFlags)4;
		((Object)zCurveTex).hideFlags = (HideFlags)4;
		((Texture)rgbChannelTex).wrapMode = (TextureWrapMode)1;
		((Texture)rgbDepthChannelTex).wrapMode = (TextureWrapMode)1;
		((Texture)zCurveTex).wrapMode = (TextureWrapMode)1;
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void UpdateParameters()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		if (redChannel != null && greenChannel != null && blueChannel != null)
		{
			for (float num = 0f; num <= 1f; num += 0.003921569f)
			{
				float num2 = Mathf.Clamp(redChannel.Evaluate(num), 0f, 1f);
				float num3 = Mathf.Clamp(greenChannel.Evaluate(num), 0f, 1f);
				float num4 = Mathf.Clamp(blueChannel.Evaluate(num), 0f, 1f);
				rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
				rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
				rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
				float num5 = Mathf.Clamp(zCurve.Evaluate(num), 0f, 1f);
				zCurveTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num5, num5, num5));
				num2 = Mathf.Clamp(depthRedChannel.Evaluate(num), 0f, 1f);
				num3 = Mathf.Clamp(depthGreenChannel.Evaluate(num), 0f, 1f);
				num4 = Mathf.Clamp(depthBlueChannel.Evaluate(num), 0f, 1f);
				rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
				rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
				rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
			}
			rgbChannelTex.Apply();
			rgbDepthChannelTex.Apply();
			zCurveTex.Apply();
		}
	}

	public override void UpdateTextures()
	{
		UpdateParameters();
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		if (updateTexturesOnStartup)
		{
			UpdateParameters();
			updateTexturesOnStartup = false;
		}
		if (useDepthCorrection)
		{
			((Component)this).camera.depthTextureMode = (DepthTextureMode)(((Component)this).camera.depthTextureMode | 1);
		}
		RenderTexture val = destination;
		if (selectiveCc)
		{
			val = RenderTexture.GetTemporary(source.width, source.height);
		}
		if (useDepthCorrection)
		{
			ccDepthMaterial.SetTexture("_RgbTex", (Texture)(object)rgbChannelTex);
			ccDepthMaterial.SetTexture("_ZCurve", (Texture)(object)zCurveTex);
			ccDepthMaterial.SetTexture("_RgbDepthTex", (Texture)(object)rgbDepthChannelTex);
			ccDepthMaterial.SetFloat("_Saturation", saturation);
			Graphics.Blit((Texture)(object)source, val, ccDepthMaterial);
		}
		else
		{
			ccMaterial.SetTexture("_RgbTex", (Texture)(object)rgbChannelTex);
			ccMaterial.SetFloat("_Saturation", saturation);
			Graphics.Blit((Texture)(object)source, val, ccMaterial);
		}
		if (selectiveCc)
		{
			selectiveCcMaterial.SetColor("selColor", selectiveFromColor);
			selectiveCcMaterial.SetColor("targetColor", selectiveToColor);
			Graphics.Blit((Texture)(object)val, destination, selectiveCcMaterial);
			RenderTexture.ReleaseTemporary(val);
		}
	}

	public override void Main()
	{
	}
}
