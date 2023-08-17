using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Tilt shift")]
[RequireComponent(typeof(Camera))]
public class TiltShift : PostEffectsBase
{
	public Shader tiltShiftShader;

	private Material tiltShiftMaterial;

	public int renderTextureDivider;

	public int blurIterations;

	public bool enableForegroundBlur;

	public int foregroundBlurIterations;

	public float maxBlurSpread;

	public float focalPoint;

	public float smoothness;

	public bool visualizeCoc;

	private float start01;

	private float distance01;

	private float end01;

	private float curve;

	public TiltShift()
	{
		renderTextureDivider = 2;
		blurIterations = 2;
		enableForegroundBlur = true;
		foregroundBlurIterations = 2;
		maxBlurSpread = 1.5f;
		focalPoint = 30f;
		smoothness = 1.65f;
		distance01 = 0.2f;
		end01 = 1f;
		curve = 1f;
	}

	public override bool CheckResources()
	{
		CheckSupport(needDepth: true);
		tiltShiftMaterial = CheckShaderAndCreateMaterial(tiltShiftShader, tiltShiftMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckResources())
		{
			Graphics.Blit((Texture)(object)source, destination);
			return;
		}
		float num = 1f * (float)source.width / (1f * (float)source.height);
		float num2 = 0.001953125f;
		renderTextureDivider = ((renderTextureDivider < 1) ? 1 : renderTextureDivider);
		renderTextureDivider = ((renderTextureDivider <= 4) ? renderTextureDivider : 4);
		blurIterations = ((blurIterations >= 1) ? blurIterations : 0);
		blurIterations = ((blurIterations <= 4) ? blurIterations : 4);
		float num3 = (distance01 = ((Component)this).camera.WorldToViewportPoint(focalPoint * ((Component)((Component)this).camera).transform.forward + ((Component)((Component)this).camera).transform.position).z / ((Component)this).camera.farClipPlane);
		start01 = 0f;
		end01 = 1f;
		start01 = Mathf.Min(num3 - float.Epsilon, start01);
		end01 = Mathf.Max(num3 + float.Epsilon, end01);
		curve = smoothness * distance01;
		RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary(source.width, source.height, 0);
		RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / renderTextureDivider, source.height / renderTextureDivider, 0);
		RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / renderTextureDivider, source.height / renderTextureDivider, 0);
		tiltShiftMaterial.SetVector("_SimpleDofParams", new Vector4(start01, distance01, end01, curve));
		tiltShiftMaterial.SetTexture("_Coc", (Texture)(object)temporary);
		if (enableForegroundBlur)
		{
			Graphics.Blit((Texture)(object)source, temporary, tiltShiftMaterial, 0);
			Graphics.Blit((Texture)(object)temporary, temporary3);
			for (int i = 0; i < foregroundBlurIterations; i++)
			{
				tiltShiftMaterial.SetVector("offsets", new Vector4(0f, maxBlurSpread * 0.75f * num2, 0f, 0f));
				Graphics.Blit((Texture)(object)temporary3, temporary4, tiltShiftMaterial, 3);
				tiltShiftMaterial.SetVector("offsets", new Vector4(maxBlurSpread * 0.75f / num * num2, 0f, 0f, 0f));
				Graphics.Blit((Texture)(object)temporary4, temporary3, tiltShiftMaterial, 3);
			}
			Graphics.Blit((Texture)(object)temporary3, temporary2, tiltShiftMaterial, 7);
			tiltShiftMaterial.SetTexture("_Coc", (Texture)(object)temporary2);
		}
		else
		{
			RenderTexture.active = temporary;
			GL.Clear(false, true, Color.black);
		}
		Graphics.Blit((Texture)(object)source, temporary, tiltShiftMaterial, 5);
		tiltShiftMaterial.SetTexture("_Coc", (Texture)(object)temporary);
		Graphics.Blit((Texture)(object)source, temporary4);
		for (int j = 0; j < blurIterations; j++)
		{
			tiltShiftMaterial.SetVector("offsets", new Vector4(0f, maxBlurSpread * 1f * num2, 0f, 0f));
			Graphics.Blit((Texture)(object)temporary4, temporary3, tiltShiftMaterial, 6);
			tiltShiftMaterial.SetVector("offsets", new Vector4(maxBlurSpread * 1f / num * num2, 0f, 0f, 0f));
			Graphics.Blit((Texture)(object)temporary3, temporary4, tiltShiftMaterial, 6);
		}
		tiltShiftMaterial.SetTexture("_Blurred", (Texture)(object)temporary4);
		Graphics.Blit((Texture)(object)source, destination, tiltShiftMaterial, (!visualizeCoc) ? 1 : 4);
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
		RenderTexture.ReleaseTemporary(temporary3);
		RenderTexture.ReleaseTemporary(temporary4);
	}

	public override void Main()
	{
	}
}
