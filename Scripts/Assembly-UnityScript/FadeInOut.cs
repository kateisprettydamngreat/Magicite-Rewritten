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

	public virtual void OnGUI()
	{
		alpha += (float)fadeDir * fadeSpeed * Time.deltaTime;
		alpha = Mathf.Clamp01(alpha);
		float a = alpha;
		Color color = GUI.color;
		float num = (color.a = a);
		Color color3 = (GUI.color = color);
		GUI.depth = drawDepth;
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), fadeOutTexture);
	}

	public virtual void fadeIn()
	{
		fadeDir = -1;
	}

	public virtual void fadeOut()
	{
		fadeDir = 1;
	}

	public virtual void Awake()
	{
		alpha = 1f;
		fadeIn();
	}

	public virtual void Main()
	{
	}
}
