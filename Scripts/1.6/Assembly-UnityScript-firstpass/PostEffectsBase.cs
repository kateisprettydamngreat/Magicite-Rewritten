using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class PostEffectsBase : MonoBehaviour
{
	protected bool supportHDRTextures;

	protected bool supportDX11;

	protected bool isSupported;

	public PostEffectsBase()
	{
		supportHDRTextures = true;
		isSupported = true;
	}

	public override Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		object result;
		if (!Object.op_Implicit((Object)(object)s))
		{
			Debug.Log((object)("Missing shader in " + ((Object)this).ToString()));
			((Behaviour)this).enabled = false;
			result = null;
		}
		else if (s.isSupported && Object.op_Implicit((Object)(object)m2Create) && (Object)(object)m2Create.shader == (Object)(object)s)
		{
			result = m2Create;
		}
		else if (!s.isSupported)
		{
			NotSupported();
			Debug.Log((object)("The shader " + ((Object)s).ToString() + " on effect " + ((Object)this).ToString() + " is not supported on this platform!"));
			result = null;
		}
		else
		{
			m2Create = new Material(s);
			((Object)m2Create).hideFlags = (HideFlags)4;
			result = ((!Object.op_Implicit((Object)(object)m2Create)) ? null : m2Create);
		}
		return (Material)result;
	}

	public override Material CreateMaterial(Shader s, Material m2Create)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		object result;
		if (!Object.op_Implicit((Object)(object)s))
		{
			Debug.Log((object)("Missing shader in " + ((Object)this).ToString()));
			result = null;
		}
		else if (Object.op_Implicit((Object)(object)m2Create) && (Object)(object)m2Create.shader == (Object)(object)s && s.isSupported)
		{
			result = m2Create;
		}
		else if (!s.isSupported)
		{
			result = null;
		}
		else
		{
			m2Create = new Material(s);
			((Object)m2Create).hideFlags = (HideFlags)4;
			result = ((!Object.op_Implicit((Object)(object)m2Create)) ? null : m2Create);
		}
		return (Material)result;
	}

	public override void OnEnable()
	{
		isSupported = true;
	}

	public override bool CheckSupport()
	{
		return CheckSupport(needDepth: false);
	}

	public override bool CheckResources()
	{
		Debug.LogWarning((object)("CheckResources () for " + ((Object)this).ToString() + " should be overwritten."));
		return isSupported;
	}

	public override void Start()
	{
		CheckResources();
	}

	public override bool CheckSupport(bool needDepth)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		isSupported = true;
		supportHDRTextures = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)2);
		bool num = SystemInfo.graphicsShaderLevel >= 50;
		if (num)
		{
			num = SystemInfo.supportsComputeShaders;
		}
		supportDX11 = num;
		int result;
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			NotSupported();
			result = 0;
		}
		else if (needDepth && !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)1))
		{
			NotSupported();
			result = 0;
		}
		else
		{
			if (needDepth)
			{
				((Component)this).camera.depthTextureMode = (DepthTextureMode)(((Component)this).camera.depthTextureMode | 1);
			}
			result = 1;
		}
		return (byte)result != 0;
	}

	public override bool CheckSupport(bool needDepth, bool needHdr)
	{
		int result;
		if (!CheckSupport(needDepth))
		{
			result = 0;
		}
		else if (needHdr && !supportHDRTextures)
		{
			NotSupported();
			result = 0;
		}
		else
		{
			result = 1;
		}
		return (byte)result != 0;
	}

	public override bool Dx11Support()
	{
		return supportDX11;
	}

	public override void ReportAutoDisable()
	{
		Debug.LogWarning((object)("The image effect " + ((Object)this).ToString() + " has been disabled as it's not supported on the current platform."));
	}

	public override bool CheckShader(Shader s)
	{
		Debug.Log((object)("The shader " + ((Object)s).ToString() + " on effect " + ((Object)this).ToString() + " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package."));
		int result;
		if (!s.isSupported)
		{
			NotSupported();
			result = 0;
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	public override void NotSupported()
	{
		((Behaviour)this).enabled = false;
		isSupported = false;
	}

	public override void DrawBorder(RenderTexture dest, Material material)
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

	public override void Main()
	{
	}
}
