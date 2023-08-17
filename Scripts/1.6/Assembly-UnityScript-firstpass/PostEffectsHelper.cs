using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class PostEffectsHelper : MonoBehaviour
{
	public override void Start()
	{
	}

	public override void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		Debug.Log((object)"OnRenderImage in Helper called ...");
	}

	public static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		RenderTexture.active = dest;
		material.SetTexture("_MainTex", (Texture)(object)source);
		bool flag = true;
		GL.PushMatrix();
		GL.LoadIdentity();
		GL.LoadProjectionMatrix(cameraForProjectionMatrix.projectionMatrix);
		float num = cameraForProjectionMatrix.fieldOfView * 0.5f * ((float)Math.PI / 180f);
		float num2 = Mathf.Cos(num) / Mathf.Sin(num);
		float aspect = cameraForProjectionMatrix.aspect;
		float num3 = aspect / (0f - num2);
		float num4 = aspect / num2;
		float num5 = 1f / (0f - num2);
		float num6 = 1f / num2;
		float num7 = 1f;
		num3 *= dist * num7;
		num4 *= dist * num7;
		num5 *= dist * num7;
		num6 *= dist * num7;
		float num8 = 0f - dist;
		for (int i = 0; i < material.passCount; i++)
		{
			material.SetPass(i);
			GL.Begin(7);
			float num9 = default(float);
			float num10 = default(float);
			if (flag)
			{
				num9 = 1f;
				num10 = 0f;
			}
			else
			{
				num9 = 0f;
				num10 = 1f;
			}
			GL.TexCoord2(0f, num9);
			GL.Vertex3(num3, num5, num8);
			GL.TexCoord2(1f, num9);
			GL.Vertex3(num4, num5, num8);
			GL.TexCoord2(1f, num10);
			GL.Vertex3(num4, num6, num8);
			GL.TexCoord2(0f, num10);
			GL.Vertex3(num3, num6, num8);
			GL.End();
		}
		GL.PopMatrix();
	}

	public static void DrawBorder(RenderTexture dest, Material material)
	{
		float num = default(float);
		float num2 = default(float);
		float num3 = default(float);
		float num4 = default(float);
		RenderTexture.active = dest;
		bool flag = true;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < material.passCount; i++)
		{
			material.SetPass(i);
			float num5 = default(float);
			float num6 = default(float);
			if (flag)
			{
				num5 = 1f;
				num6 = 0f;
			}
			else
			{
				num5 = 0f;
				num6 = 1f;
			}
			num = 0f;
			num2 = 0f + 1f / ((float)dest.width * 1f);
			num3 = 0f;
			num4 = 1f;
			GL.Begin(7);
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			num = 1f - 1f / ((float)dest.width * 1f);
			num2 = 1f;
			num3 = 0f;
			num4 = 1f;
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			num = 0f;
			num2 = 1f;
			num3 = 0f;
			num4 = 0f + 1f / ((float)dest.height * 1f);
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			num = 0f;
			num2 = 1f;
			num3 = 1f - 1f / ((float)dest.height * 1f);
			num4 = 1f;
			GL.TexCoord2(0f, num5);
			GL.Vertex3(num, num3, 0.1f);
			GL.TexCoord2(1f, num5);
			GL.Vertex3(num2, num3, 0.1f);
			GL.TexCoord2(1f, num6);
			GL.Vertex3(num2, num4, 0.1f);
			GL.TexCoord2(0f, num6);
			GL.Vertex3(num, num4, 0.1f);
			GL.End();
		}
		GL.PopMatrix();
	}

	public static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
	{
		RenderTexture.active = dest;
		material.SetTexture("_MainTex", (Texture)(object)source);
		bool flag = true;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < material.passCount; i++)
		{
			material.SetPass(i);
			GL.Begin(7);
			float num = default(float);
			float num2 = default(float);
			if (flag)
			{
				num = 1f;
				num2 = 0f;
			}
			else
			{
				num = 0f;
				num2 = 1f;
			}
			GL.TexCoord2(0f, num);
			GL.Vertex3(x1, y1, 0.1f);
			GL.TexCoord2(1f, num);
			GL.Vertex3(x2, y1, 0.1f);
			GL.TexCoord2(1f, num2);
			GL.Vertex3(x2, y2, 0.1f);
			GL.TexCoord2(0f, num2);
			GL.Vertex3(x1, y2, 0.1f);
			GL.End();
		}
		GL.PopMatrix();
	}

	public override void Main()
	{
	}
}
