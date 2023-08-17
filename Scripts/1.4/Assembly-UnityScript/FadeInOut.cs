using System;
using UnityEngine;

[Serializable]
public class FadeInOut : MonoBehaviour
{
	public Texture2D fadeOutTexture;

	public float fadeSpeed;

	public int drawDepth;

	private float alpha;

	private int fadeDir;

	public FadeInOut()
	{
		fadeSpeed = 2f;
		drawDepth = -1000;
		alpha = 1f;
		fadeDir = -1;
	}

	public override void OnGUI()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		alpha += (float)fadeDir * fadeSpeed * Time.deltaTime;
		alpha = Mathf.Clamp01(alpha);
		float a = alpha;
		Color color = GUI.color;
		float num = (color.a = a);
		Color val2 = (GUI.color = color);
		GUI.depth = drawDepth;
		GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), (Texture)(object)fadeOutTexture);
	}

	public override void fadeIn()
	{
		fadeDir = -1;
	}

	public override void fadeOut()
	{
		fadeDir = 1;
	}

	public override void Awake()
	{
		alpha = 1f;
		fadeIn();
	}

	public override void Main()
	{
	}
}
