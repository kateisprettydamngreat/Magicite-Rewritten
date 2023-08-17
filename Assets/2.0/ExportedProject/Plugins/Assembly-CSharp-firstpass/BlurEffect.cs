using UnityEngine;

[AddComponentMenu("Image Effects/Blur")]
[ExecuteInEditMode]
public class BlurEffect : MonoBehaviour
{
	public int iterations = 3;

	public float blurSpread = 0.6f;

	public Shader blurShader;

	private static Material m_Material;

	protected Material material
	{
		get
		{
			if (m_Material == null)
			{
				m_Material = new Material(blurShader);
				m_Material.hideFlags = HideFlags.DontSave;
			}
			return m_Material;
		}
	}

	protected void OnDisable()
	{
		if ((bool)m_Material)
		{
			Object.DestroyImmediate(m_Material);
		}
	}

	protected void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!blurShader || !material.shader.isSupported)
		{
			base.enabled = false;
		}
	}

	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
		float num = 0.5f + (float)iteration * blurSpread;
		Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
	}

	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
		float num = 1f;
		Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
		DownSample4x(source, temporary);
		bool flag = true;
		for (int i = 0; i < iterations; i++)
		{
			if (flag)
			{
				FourTapCone(temporary, temporary2, i);
			}
			else
			{
				FourTapCone(temporary2, temporary, i);
			}
			flag = !flag;
		}
		if (flag)
		{
			Graphics.Blit(temporary, destination);
		}
		else
		{
			Graphics.Blit(temporary2, destination);
		}
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
	}
}
