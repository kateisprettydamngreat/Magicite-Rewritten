using System;
using UnityEngine;

[Serializable]
public class CameraScript : MonoBehaviour
{
	private Transform player;

	private Transform t;

	private bool shaking;

	private bool lookingDown;

	private Vector3 startPos;

	private Vector3 endPos;

	private float startTime;

	private float speed;

	private float journeyLength;

	private GameScript gameScript;

	public CameraScript()
	{
		speed = 0.1f;
		journeyLength = 1f;
	}

	public virtual void SetPlayer(GameObject p)
	{
		player = p.transform;
		t = transform;
	}

	public virtual void LateUpdate()
	{
		if ((bool)player)
		{
			if (!GameScript.inventoryOpen && !GameScript.menuOpen)
			{
				endPos = new Vector3(GetAvgX(), GetAvgY(), -20f);
			}
			else
			{
				endPos = new Vector3(player.position.x, player.position.y, -20f);
			}
			t.position = Vector3.Lerp(t.position, endPos, Time.deltaTime * 2f);
		}
	}

	public virtual float GetAvgX()
	{
		return (Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x + player.position.x) * 0.5f;
	}

	public virtual float GetAvgY()
	{
		return (Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).y + player.position.y) * 0.5f;
	}

	}