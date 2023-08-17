using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Glow")]
public class GlowEffect : MonoBehaviour
{
	public float glowIntensity = 1.5f;

	public int blurIterations = 3;

	public float blurSpread = 0.7f;

	public Color glowTint = new Color(1f, 1f, 1f, 0f);

	public Shader compositeShader;

	private Material m_CompositeMaterial;

	public Shader blurShader;

	private Material m_BlurMaterial;

	public Shader downsampleShader;

	private Material m_DownsampleMaterial;

	protected Material compositeMaterial
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			if ((Object)(object)m_CompositeMaterial == (Object)null)
			{
				m_CompositeMaterial = new Material(compositeShader);
				((Object)m_CompositeMaterial).hideFlags = (HideFlags)13;
			}
			return m_CompositeMaterial;
		}
	}

	protected Material blurMaterial
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			if ((Object)(object)m_BlurMaterial == (Object)null)
			{
				m_BlurMaterial = new Material(blurShader);
				((Object)m_BlurMaterial).hideFlags = (HideFlags)13;
			}
			return m_BlurMaterial;
		}
	}

	protected Material downsampleMaterial
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			if ((Object)(object)m_DownsampleMaterial == (Object)null)
			{
				m_DownsampleMaterial = new Material(downsampleShader);
				((Object)m_DownsampleMaterial).hideFlags = (HideFlags)13;
			}
			return m_DownsampleMaterial;
		}
	}

	protected void OnDisable()
	{
		if (Object.op_Implicit((Object)(object)m_CompositeMaterial))
		{
			Object.DestroyImmediate((Object)(object)m_CompositeMaterial);
		}
		if (Object.op_Implicit((Object)(object)m_BlurMaterial))
		{
			Object.DestroyImmediate((Object)(object)m_BlurMaterial);
		}
		if (Object.op_Implicit((Object)(object)m_DownsampleMaterial))
		{
			Object.DestroyImmediate((Object)(object)m_DownsampleMaterial);
		}
	}

	protected void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			((Behaviour)this).enabled = false;
			return;
		}
		if ((Object)(object)downsampleShader == (Object)null)
		{
			Debug.Log((object)"No downsample shader assigned! Disabling glow.");
			((Behaviour)this).enabled = false;
			return;
		}
		if (!blurMaterial.shader.isSupported)
		{
			((Behaviour)this).enabled = false;
		}
		if (!compositeMaterial.shader.isSupported)
		{
			((Behaviour)this).enabled = false;
		}
		if (!downsampleMaterial.shader.isSupported)
		{
			((Behaviour)this).enabled = false;
		}
	}

	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		float num = 0.5f + (float)iteration * blurSpread;
		Graphics.BlitMultiTap((Texture)(object)source, dest, blurMaterial, (Vector2[])(object)new Vector2[4]
		{
			new Vector2(num, num),
			new Vector2(0f - num, num),
			new Vector2(num, 0f - num),
			new Vector2(0f - num, 0f - num)
		});
	}

	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		downsampleMaterial.color = new Color(glowTint.r, glowTint.g, glowTint.b, glowTint.a / 4f);
		Graphics.Blit((Texture)(object)source, dest, downsampleMaterial);
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		glowIntensity = Mathf.Clamp(glowIntensity, 0f, 10f);
		blurIterations = Mathf.Clamp(blurIterations, 0, 30);
		blurSpread = Mathf.Clamp(blurSpread, 0.5f, 1f);
		RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
		DownSample4x(source, temporary);
		float num = Mathf.Clamp01((glowIntensity - 1f) / 4f);
		blurMaterial.color = new Color(1f, 1f, 1f, 0.25f + num);
		bool flag = true;
		for (int i = 0; i < blurIterations; i++)
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
		Graphics.Blit((Texture)(object)source, destination);
		if (flag)
		{
			BlitGlow(temporary, destination);
		}
		else
		{
			BlitGlow(temporary2, destination);
		}
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
	}

	public void BlitGlow(RenderTexture source, RenderTexture dest)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		compositeMaterial.color = new Color(1f, 1f, 1f, Mathf.Clamp01(glowIntensity));
		Graphics.Blit((Texture)(object)source, dest, compositeMaterial);
	}
}
