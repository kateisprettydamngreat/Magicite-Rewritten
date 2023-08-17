using UnityEngine;

[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Noise")]
public class NoiseEffect : MonoBehaviour
{
	public bool monochrome = true;

	private bool rgbFallback;

	public float grainIntensityMin = 0.1f;

	public float grainIntensityMax = 0.2f;

	public float grainSize = 2f;

	public float scratchIntensityMin = 0.05f;

	public float scratchIntensityMax = 0.25f;

	public float scratchFPS = 10f;

	public float scratchJitter = 0.01f;

	public Texture grainTexture;

	public Texture scratchTexture;

	public Shader shaderRGB;

	public Shader shaderYUV;

	private Material m_MaterialRGB;

	private Material m_MaterialYUV;

	private float scratchTimeLeft;

	private float scratchX;

	private float scratchY;

	protected Material material
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			if ((Object)(object)m_MaterialRGB == (Object)null)
			{
				m_MaterialRGB = new Material(shaderRGB);
				((Object)m_MaterialRGB).hideFlags = (HideFlags)13;
			}
			if ((Object)(object)m_MaterialYUV == (Object)null && !rgbFallback)
			{
				m_MaterialYUV = new Material(shaderYUV);
				((Object)m_MaterialYUV).hideFlags = (HideFlags)13;
			}
			return (rgbFallback || monochrome) ? m_MaterialRGB : m_MaterialYUV;
		}
	}

	protected void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			((Behaviour)this).enabled = false;
		}
		else if ((Object)(object)shaderRGB == (Object)null || (Object)(object)shaderYUV == (Object)null)
		{
			Debug.Log((object)"Noise shaders are not set up! Disabling noise effect.");
			((Behaviour)this).enabled = false;
		}
		else if (!shaderRGB.isSupported)
		{
			((Behaviour)this).enabled = false;
		}
		else if (!shaderYUV.isSupported)
		{
			rgbFallback = true;
		}
	}

	protected void OnDisable()
	{
		if (Object.op_Implicit((Object)(object)m_MaterialRGB))
		{
			Object.DestroyImmediate((Object)(object)m_MaterialRGB);
		}
		if (Object.op_Implicit((Object)(object)m_MaterialYUV))
		{
			Object.DestroyImmediate((Object)(object)m_MaterialYUV);
		}
	}

	private void SanitizeParameters()
	{
		grainIntensityMin = Mathf.Clamp(grainIntensityMin, 0f, 5f);
		grainIntensityMax = Mathf.Clamp(grainIntensityMax, 0f, 5f);
		scratchIntensityMin = Mathf.Clamp(scratchIntensityMin, 0f, 5f);
		scratchIntensityMax = Mathf.Clamp(scratchIntensityMax, 0f, 5f);
		scratchFPS = Mathf.Clamp(scratchFPS, 1f, 30f);
		scratchJitter = Mathf.Clamp(scratchJitter, 0f, 1f);
		grainSize = Mathf.Clamp(grainSize, 0.1f, 50f);
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		SanitizeParameters();
		if (scratchTimeLeft <= 0f)
		{
			scratchTimeLeft = Random.value * 2f / scratchFPS;
			scratchX = Random.value;
			scratchY = Random.value;
		}
		scratchTimeLeft -= Time.deltaTime;
		Material val = material;
		val.SetTexture("_GrainTex", grainTexture);
		val.SetTexture("_ScratchTex", scratchTexture);
		float num = 1f / grainSize;
		val.SetVector("_GrainOffsetScale", new Vector4(Random.value, Random.value, (float)Screen.width / (float)grainTexture.width * num, (float)Screen.height / (float)grainTexture.height * num));
		val.SetVector("_ScratchOffsetScale", new Vector4(scratchX + Random.value * scratchJitter, scratchY + Random.value * scratchJitter, (float)Screen.width / (float)scratchTexture.width, (float)Screen.height / (float)scratchTexture.height));
		val.SetVector("_Intensity", new Vector4(Random.Range(grainIntensityMin, grainIntensityMax), Random.Range(scratchIntensityMin, scratchIntensityMax), 0f, 0f));
		Graphics.Blit((Texture)(object)source, destination, val);
	}
}
