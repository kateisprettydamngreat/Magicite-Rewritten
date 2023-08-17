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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			if ((Object)(object)m_Material == (Object)null)
			{
				m_Material = new Material(blurShader);
				((Object)m_Material).hideFlags = (HideFlags)4;
			}
			return m_Material;
		}
	}

	protected void OnDisable()
	{
		if (Object.op_Implicit((Object)(object)m_Material))
		{
			Object.DestroyImmediate((Object)(object)m_Material);
		}
	}

	protected void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			((Behaviour)this).enabled = false;
		}
		else if (!Object.op_Implicit((Object)(object)blurShader) || !material.shader.isSupported)
		{
			((Behaviour)this).enabled = false;
		}
	}

	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		float num = 0.5f + (float)iteration * blurSpread;
		Graphics.BlitMultiTap((Texture)(object)source, dest, material, (Vector2[])(object)new Vector2[4]
		{
			new Vector2(0f - num, 0f - num),
			new Vector2(0f - num, num),
			new Vector2(num, num),
			new Vector2(num, 0f - num)
		});
	}

	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		float num = 1f;
		Graphics.BlitMultiTap((Texture)(object)source, dest, material, (Vector2[])(object)new Vector2[4]
		{
			new Vector2(0f - num, 0f - num),
			new Vector2(0f - num, num),
			new Vector2(num, num),
			new Vector2(num, 0f - num)
		});
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
			Graphics.Blit((Texture)(object)temporary, destination);
		}
		else
		{
			Graphics.Blit((Texture)(object)temporary2, destination);
		}
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
	}
}
