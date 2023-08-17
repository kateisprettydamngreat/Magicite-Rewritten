using System;
using UnityEngine;

[Serializable]
[AddComponentMenu("Image Effects/Color Correction (3D Lookup Texture)")]
[ExecuteInEditMode]
public class ColorCorrectionLut : PostEffectsBase
{
	public Shader shader;

	private Material material;

	public Texture3D converted3DLut;

	public string basedOnTempTex;

	public ColorCorrectionLut()
	{
		basedOnTempTex = string.Empty;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: false);
		material = CheckShaderAndCreateMaterial(shader, material);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnDisable()
	{
		if (Object.op_Implicit((Object)(object)material))
		{
			Object.DestroyImmediate((Object)(object)material);
			material = null;
		}
	}

	public override void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)converted3DLut))
		{
			Object.DestroyImmediate((Object)(object)converted3DLut);
		}
		converted3DLut = null;
	}

	public override void SetIdentityLut()
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		int num = 16;
		Color[] array = (Color[])(object)new Color[num * num * num];
		float num2 = 1f / (1f * (float)num - 1f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					ref Color reference = ref array[i + j * num + k * num * num];
					reference = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
				}
			}
		}
		if (Object.op_Implicit((Object)(object)converted3DLut))
		{
			Object.DestroyImmediate((Object)(object)converted3DLut);
		}
		converted3DLut = new Texture3D(num, num, num, (TextureFormat)5, false);
		converted3DLut.SetPixels(array);
		converted3DLut.Apply();
		basedOnTempTex = string.Empty;
	}

	public override bool ValidDimensions(Texture2D tex2d)
	{
		int result;
		if (!Object.op_Implicit((Object)(object)tex2d))
		{
			result = 0;
		}
		else
		{
			int height = ((Texture)tex2d).height;
			result = ((height == Mathf.FloorToInt(Mathf.Sqrt((float)((Texture)tex2d).width))) ? 1 : 0);
		}
		return (byte)result != 0;
	}

	public override void Convert(Texture2D temp2DTex, string path)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)temp2DTex))
		{
			int num = ((Texture)temp2DTex).width * ((Texture)temp2DTex).height;
			num = ((Texture)temp2DTex).height;
			if (!ValidDimensions(temp2DTex))
			{
				Debug.LogWarning((object)("The given 2D texture " + ((Object)temp2DTex).name + " cannot be used as a 3D LUT."));
				basedOnTempTex = string.Empty;
				return;
			}
			Color[] pixels = temp2DTex.GetPixels();
			Color[] array = (Color[])(object)new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (Object.op_Implicit((Object)(object)converted3DLut))
			{
				Object.DestroyImmediate((Object)(object)converted3DLut);
			}
			converted3DLut = new Texture3D(num, num, num, (TextureFormat)5, false);
			converted3DLut.SetPixels(array);
			converted3DLut.Apply();
			basedOnTempTex = path;
		}
		else
		{
			Debug.LogError((object)"Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
		}
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		if ((Object)(object)converted3DLut == (Object)null)
		{
			SetIdentityLut();
		}
		int width = ((Texture)converted3DLut).width;
		((Texture)converted3DLut).wrapMode = (TextureWrapMode)1;
		material.SetFloat("_Scale", (float)(width - 1) / (1f * (float)width));
		material.SetFloat("_Offset", 1f / (2f * (float)width));
		material.SetTexture("_ClutTex", (Texture)(object)converted3DLut);
		Graphics.Blit((Texture)(object)source, destination, material, ((int)QualitySettings.activeColorSpace == 1) ? 1 : 0);
	}

	public override void Main()
	{
	}
}
