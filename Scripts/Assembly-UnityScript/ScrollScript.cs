using System;
using UnityEngine;

[Serializable]
public class ScrollScript : MonoBehaviour
{
	private Renderer r;

	public virtual void Start()
	{
		r = GetComponent<Renderer>();
	}

	public virtual void Update()
	{
		float x = r.material.mainTextureOffset.x + Time.deltaTime * 0.02f;
		Vector2 mainTextureOffset = r.material.mainTextureOffset;
		float num = (mainTextureOffset.x = x);
		Vector2 vector2 = (r.material.mainTextureOffset = mainTextureOffset);
		float y = r.material.mainTextureOffset.y + Time.deltaTime * 0.02f;
		Vector2 mainTextureOffset2 = r.material.mainTextureOffset;
		float num2 = (mainTextureOffset2.y = y);
		Vector2 vector4 = (r.material.mainTextureOffset = mainTextureOffset2);
	}

	public virtual void Main()
	{
	}
}
