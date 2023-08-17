using System;
using UnityEngine;

[Serializable]
[AddComponentMenu("Image Effects/Vignette and Chromatic Aberration")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class Vignetting : PostEffectsBase
{
	[Serializable]
	public enum AberrationMode
	{
		Simple,
		Advanced
	}

	public AberrationMode mode;

	public float intensity;

	public float chromaticAberration;

	public float axialAberration;

	public float blur;

	public float blurSpread;

	public float luminanceDependency;

	public Shader vignetteShader;

	private Material vignetteMaterial;

	public Shader separableBlurShader;

	private Material separableBlurMaterial;

	public Shader chromAberrationShader;

	private Material chromAberrationMaterial;

	public Vignetting()
	{
		mode = AberrationMode.Simple;
		intensity = 0.375f;
		chromaticAberration = 0.2f;
		axialAberration = 0.5f;
		blurSpread = 0.75f;
		luminanceDependency = 0.25f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		vignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, vignetteMaterial);
		separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
		chromAberrationMaterial = CheckShaderAndCreateMaterial(chromAberrationShader, chromAberrationMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		bool num = Mathf.Abs(blur) > 0f;
		if (!num)
		{
			num = Mathf.Abs(intensity) > 0f;
		}
		bool flag = num;
		float num2 = 1f * (float)source.width / (1f * (float)source.height);
		float num3 = 0.001953125f;
		RenderTexture val = null;
		RenderTexture val2 = null;
		RenderTexture val3 = null;
		if (flag)
		{
			val = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
			if (!(Mathf.Abs(blur) <= 0f))
			{
				val2 = RenderTexture.GetTemporary((int)((float)source.width / 2f), (int)((float)source.height / 2f), 0, source.format);
				val3 = RenderTexture.GetTemporary((int)((float)source.width / 2f), (int)((float)source.height / 2f), 0, source.format);
				Graphics.Blit((Texture)(object)source, val2, chromAberrationMaterial, 0);
				for (int i = 0; i < 2; i++)
				{
					separableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * num3, 0f, 0f));
					Graphics.Blit((Texture)(object)val2, val3, separableBlurMaterial);
					separableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * num3 / num2, 0f, 0f, 0f));
					Graphics.Blit((Texture)(object)val3, val2, separableBlurMaterial);
				}
			}
			vignetteMaterial.SetFloat("_Intensity", intensity);
			vignetteMaterial.SetFloat("_Blur", blur);
			vignetteMaterial.SetTexture("_VignetteTex", (Texture)(object)val2);
			Graphics.Blit((Texture)(object)source, val, vignetteMaterial, 0);
		}
		chromAberrationMaterial.SetFloat("_ChromaticAberration", chromaticAberration);
		chromAberrationMaterial.SetFloat("_AxialAberration", axialAberration);
		chromAberrationMaterial.SetFloat("_Luminance", 1f / (float.Epsilon + luminanceDependency));
		if (flag)
		{
			((Texture)val).wrapMode = (TextureWrapMode)1;
		}
		else
		{
			((Texture)source).wrapMode = (TextureWrapMode)1;
		}
		Graphics.Blit((Texture)(object)((!flag) ? source : val), destination, chromAberrationMaterial, (mode != AberrationMode.Advanced) ? 1 : 2);
		if (Object.op_Implicit((Object)(object)val))
		{
			RenderTexture.ReleaseTemporary(val);
		}
		if (Object.op_Implicit((Object)(object)val2))
		{
			RenderTexture.ReleaseTemporary(val2);
		}
		if (Object.op_Implicit((Object)(object)val3))
		{
			RenderTexture.ReleaseTemporary(val3);
		}
	}

	public override void Main()
	{
	}
}
