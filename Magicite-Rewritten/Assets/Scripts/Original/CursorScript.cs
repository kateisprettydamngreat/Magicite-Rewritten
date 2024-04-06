using System;
using UnityEngine;

[Serializable]
public class CursorScript : MonoBehaviour
{
	private Transform t;

	public virtual void Start()
	{
		t = transform;
	}

	public virtual void LateUpdate()
	{
		float x = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x;
		Vector3 position = t.position;
		float num = (position.x = x);
		Vector3 vector2 = (t.position = position);
		float y = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).y;
		Vector3 position2 = t.position;
		float num2 = (position2.y = y);
		Vector3 vector4 = (t.position = position2);
	}

	}