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

	public override void SetPlayer(GameObject p)
	{
		player = p.transform;
		t = ((Component)this).transform;
	}

	public override void LateUpdate()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player))
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

	public override float GetAvgX()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		return (Camera.main.ScreenToWorldPoint(Input.mousePosition).x + player.position.x) * 0.5f;
	}

	public override float GetAvgY()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		return (Camera.main.ScreenToWorldPoint(Input.mousePosition).y + player.position.y) * 0.5f;
	}

	public override void Main()
	{
	}
}
