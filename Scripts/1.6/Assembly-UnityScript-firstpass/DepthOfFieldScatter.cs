using System;
using Boo.Lang.Runtime;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Depth of Field (Lens Blur, Scatter, DX11)")]
[ExecuteInEditMode]
public class DepthOfFieldScatter : PostEffectsBase
{
	[Serializable]
	public enum BlurType
	{
		DiscBlur,
		DX11
	}

	[Serializable]
	public enum BlurSampleCount
	{
		Low,
		Medium,
		High
	}

	public bool visualizeFocus;

	public float focalLength;

	public float focalSize;

	public float aperture;

	public Transform focalTransform;

	public float maxBlurSize;

	public bool highResolution;

	public BlurType blurType;

	public BlurSampleCount blurSampleCount;

	public bool nearBlur;

	public float foregroundOverlap;

	public Shader dofHdrShader;

	private Material dofHdrMaterial;

	public Shader dx11BokehShader;

	private Material dx11bokehMaterial;

	public float dx11BokehThreshhold;

	public float dx11SpawnHeuristic;

	public Texture2D dx11BokehTexture;

	public float dx11BokehScale;

	public float dx11BokehIntensity;

	private float focalDistance01;

	private ComputeBuffer cbDrawArgs;

	private ComputeBuffer cbPoints;

	private float internalBlurWidth;

	public DepthOfFieldScatter()
	{
		focalLength = 10f;
		focalSize = 0.05f;
		aperture = 11.5f;
		maxBlurSize = 2f;
		blurType = BlurType.DiscBlur;
		blurSampleCount = BlurSampleCount.High;
		foregroundOverlap = 1f;
		dx11BokehThreshhold = 0.5f;
		dx11SpawnHeuristic = 0.0875f;
		dx11BokehScale = 1.2f;
		dx11BokehIntensity = 2.5f;
		focalDistance01 = 10f;
		internalBlurWidth = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		dofHdrMaterial = CheckShaderAndCreateMaterial(dofHdrShader, dofHdrMaterial);
		if (supportDX11 && blurType == BlurType.DX11)
		{
			dx11bokehMaterial = CheckShaderAndCreateMaterial(dx11BokehShader, dx11bokehMaterial);
			CreateComputeResources();
		}
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnEnable()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).camera.depthTextureMode = (DepthTextureMode)(((Component)this).camera.depthTextureMode | 1);
	}

	public override void OnDisable()
	{
		ReleaseComputeResources();
		if (Object.op_Implicit((Object)(object)dofHdrMaterial))
		{
			Object.DestroyImmediate((Object)(object)dofHdrMaterial);
		}
		dofHdrMaterial = null;
		if (Object.op_Implicit((Object)(object)dx11bokehMaterial))
		{
			Object.DestroyImmediate((Object)(object)dx11bokehMaterial);
		}
		dx11bokehMaterial = null;
	}

	public override void ReleaseComputeResources()
	{
		if (cbDrawArgs != null)
		{
			cbDrawArgs.Release();
		}
		cbDrawArgs = null;
		if (cbPoints != null)
		{
			cbPoints.Release();
		}
		cbPoints = null;
	}

	public override void CreateComputeResources()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		if (RuntimeServices.EqualityOperator((object)cbDrawArgs, (object)null))
		{
			cbDrawArgs = new ComputeBuffer(1, 16, (ComputeBufferType)256);
			int[] data = new int[4] { 0, 1, 0, 0 };
			cbDrawArgs.SetData((Array)data);
		}
		if (RuntimeServices.EqualityOperator((object)cbPoints, (object)null))
		{
			cbPoints = new ComputeBuffer(90000, 28, (ComputeBufferType)2);
		}
	}

	public override float FocalDistance01(float worldDist)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)this).camera.WorldToViewportPoint((worldDist - ((Component)this).camera.nearClipPlane) * ((Component)((Component)this).camera).transform.forward + ((Component)((Component)this).camera).transform.position).z / (((Component)this).camera.farClipPlane - ((Component)this).camera.nearClipPlane);
	}

	private void WriteCoc(RenderTexture fromTo, RenderTexture temp1, RenderTexture temp2, bool fgDilate)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		dofHdrMaterial.SetTexture("_FgOverlap", (Texture)null);
		if (nearBlur && fgDilate)
		{
			Graphics.Blit((Texture)(object)fromTo, temp2, dofHdrMaterial, 4);
			float num = internalBlurWidth * foregroundOverlap;
			dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
			Graphics.Blit((Texture)(object)temp2, temp1, dofHdrMaterial, 2);
			dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
			Graphics.Blit((Texture)(object)temp1, temp2, dofHdrMaterial, 2);
			dofHdrMaterial.SetTexture("_FgOverlap", (Texture)(object)temp2);
			Graphics.Blit((Texture)(object)fromTo, fromTo, dofHdrMaterial, 13);
		}
		else
		{
			Graphics.Blit((Texture)(object)fromTo, fromTo, dofHdrMaterial, 0);
		}
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		if (!(aperture >= 0f))
		{
			aperture = 0f;
		}
		if (!(maxBlurSize >= 0.1f))
		{
			maxBlurSize = 0.1f;
		}
		focalSize = Mathf.Clamp(focalSize, 0f, 2f);
		internalBlurWidth = Mathf.Max(maxBlurSize, 0f);
		focalDistance01 = ((!Object.op_Implicit((Object)(object)focalTransform)) ? FocalDistance01(focalLength) : (((Component)this).camera.WorldToViewportPoint(focalTransform.position).z / ((Component)this).camera.farClipPlane));
		dofHdrMaterial.SetVector("_CurveParams", new Vector4(1f, focalSize, aperture / 10f, focalDistance01));
		RenderTexture val = null;
		RenderTexture val2 = null;
		RenderTexture val3 = null;
		RenderTexture val4 = null;
		float num = internalBlurWidth * foregroundOverlap;
		if (visualizeFocus)
		{
			val = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
			val2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
			WriteCoc(source, val, val2, fgDilate: true);
			Graphics.Blit((Texture)(object)source, destination, dofHdrMaterial, 16);
		}
		else if (blurType == BlurType.DX11 && Object.op_Implicit((Object)(object)dx11bokehMaterial))
		{
			if (highResolution)
			{
				internalBlurWidth = ((internalBlurWidth >= 0.1f) ? internalBlurWidth : 0.1f);
				num = internalBlurWidth * foregroundOverlap;
				val = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
				WriteCoc(source, null, null, fgDilate: false);
				val3 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				val4 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				Graphics.Blit((Texture)(object)source, val3, dofHdrMaterial, 15);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
				Graphics.Blit((Texture)(object)val3, val4, dofHdrMaterial, 19);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
				Graphics.Blit((Texture)(object)val4, val3, dofHdrMaterial, 19);
				if (nearBlur)
				{
					Graphics.Blit((Texture)(object)source, val4, dofHdrMaterial, 4);
				}
				dx11bokehMaterial.SetTexture("_BlurredColor", (Texture)(object)val3);
				dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
				dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshhold, 0.005f, 4f), internalBlurWidth));
				dx11bokehMaterial.SetTexture("_FgCocMask", (Texture)(object)((!nearBlur) ? null : val4));
				Graphics.SetRandomWriteTarget(1, cbPoints);
				Graphics.Blit((Texture)(object)source, val, dx11bokehMaterial, 0);
				Graphics.ClearRandomWriteTargets();
				if (nearBlur)
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
					Graphics.Blit((Texture)(object)val4, val3, dofHdrMaterial, 2);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
					Graphics.Blit((Texture)(object)val3, val4, dofHdrMaterial, 2);
					Graphics.Blit((Texture)(object)val4, val, dofHdrMaterial, 3);
				}
				Graphics.Blit((Texture)(object)val, temporary, dofHdrMaterial, 20);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
				Graphics.Blit((Texture)(object)val, source, dofHdrMaterial, 5);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
				Graphics.Blit((Texture)(object)source, temporary, dofHdrMaterial, 21);
				Graphics.SetRenderTarget(temporary);
				ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
				dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
				dx11bokehMaterial.SetTexture("_MainTex", (Texture)(object)dx11BokehTexture);
				dx11bokehMaterial.SetVector("_Screen", Vector4.op_Implicit(new Vector3(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), internalBlurWidth)));
				dx11bokehMaterial.SetPass(2);
				Graphics.DrawProceduralIndirect((MeshTopology)5, cbDrawArgs, 0);
				Graphics.Blit((Texture)(object)temporary, destination);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(val3);
				RenderTexture.ReleaseTemporary(val4);
			}
			else
			{
				val = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				val2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				num = internalBlurWidth * foregroundOverlap;
				WriteCoc(source, null, null, fgDilate: false);
				((Texture)source).filterMode = (FilterMode)1;
				Graphics.Blit((Texture)(object)source, val, dofHdrMaterial, 6);
				val3 = RenderTexture.GetTemporary(val.width >> 1, val.height >> 1, 0, val.format);
				val4 = RenderTexture.GetTemporary(val.width >> 1, val.height >> 1, 0, val.format);
				Graphics.Blit((Texture)(object)val, val3, dofHdrMaterial, 15);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
				Graphics.Blit((Texture)(object)val3, val4, dofHdrMaterial, 19);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
				Graphics.Blit((Texture)(object)val4, val3, dofHdrMaterial, 19);
				RenderTexture val5 = null;
				if (nearBlur)
				{
					val5 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					Graphics.Blit((Texture)(object)source, val5, dofHdrMaterial, 4);
				}
				dx11bokehMaterial.SetTexture("_BlurredColor", (Texture)(object)val3);
				dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
				dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshhold, 0.005f, 4f), internalBlurWidth));
				dx11bokehMaterial.SetTexture("_FgCocMask", (Texture)(object)val5);
				Graphics.SetRandomWriteTarget(1, cbPoints);
				Graphics.Blit((Texture)(object)val, val2, dx11bokehMaterial, 0);
				Graphics.ClearRandomWriteTargets();
				RenderTexture.ReleaseTemporary(val3);
				RenderTexture.ReleaseTemporary(val4);
				if (nearBlur)
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
					Graphics.Blit((Texture)(object)val5, val, dofHdrMaterial, 2);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
					Graphics.Blit((Texture)(object)val, val5, dofHdrMaterial, 2);
					Graphics.Blit((Texture)(object)val5, val2, dofHdrMaterial, 3);
				}
				dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
				Graphics.Blit((Texture)(object)val2, val, dofHdrMaterial, 5);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
				Graphics.Blit((Texture)(object)val, val2, dofHdrMaterial, 5);
				Graphics.SetRenderTarget(val2);
				ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
				dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
				dx11bokehMaterial.SetTexture("_MainTex", (Texture)(object)dx11BokehTexture);
				dx11bokehMaterial.SetVector("_Screen", Vector4.op_Implicit(new Vector3(1f / (1f * (float)val2.width), 1f / (1f * (float)val2.height), internalBlurWidth)));
				dx11bokehMaterial.SetPass(1);
				Graphics.DrawProceduralIndirect((MeshTopology)5, cbDrawArgs, 0);
				dofHdrMaterial.SetTexture("_LowRez", (Texture)(object)val2);
				dofHdrMaterial.SetTexture("_FgOverlap", (Texture)(object)val5);
				dofHdrMaterial.SetVector("_Offsets", 1f * (float)source.width / (1f * (float)val2.width) * internalBlurWidth * Vector4.one);
				Graphics.Blit((Texture)(object)source, destination, dofHdrMaterial, 9);
				if (Object.op_Implicit((Object)(object)val5))
				{
					RenderTexture.ReleaseTemporary(val5);
				}
			}
		}
		else
		{
			val = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
			val2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
			((Texture)source).filterMode = (FilterMode)1;
			if (highResolution)
			{
				internalBlurWidth *= 2f;
			}
			WriteCoc(source, val, val2, fgDilate: true);
			int num2 = ((blurSampleCount != BlurSampleCount.High && blurSampleCount != BlurSampleCount.Medium) ? 11 : 17);
			if (highResolution)
			{
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.025f, internalBlurWidth));
				Graphics.Blit((Texture)(object)source, destination, dofHdrMaterial, num2);
			}
			else
			{
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.1f, internalBlurWidth));
				Graphics.Blit((Texture)(object)source, val, dofHdrMaterial, 6);
				Graphics.Blit((Texture)(object)val, val2, dofHdrMaterial, num2);
				dofHdrMaterial.SetTexture("_LowRez", (Texture)(object)val2);
				dofHdrMaterial.SetTexture("_FgOverlap", (Texture)null);
				dofHdrMaterial.SetVector("_Offsets", Vector4.one * (1f * (float)source.width / (1f * (float)val2.width)) * internalBlurWidth);
				Graphics.Blit((Texture)(object)source, destination, dofHdrMaterial, (blurSampleCount != BlurSampleCount.High) ? 12 : 18);
			}
		}
		if (Object.op_Implicit((Object)(object)val))
		{
			RenderTexture.ReleaseTemporary(val);
		}
		if (Object.op_Implicit((Object)(object)val2))
		{
			RenderTexture.ReleaseTemporary(val2);
		}
	}

	public override void Main()
	{
	}
}
