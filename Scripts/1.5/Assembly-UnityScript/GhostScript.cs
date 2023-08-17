using System;
using UnityEngine;

[Serializable]
public class GhostScript : MonoBehaviour
{
	public GameObject bar;

	public GameObject player;

	private float revCount;

	private bool reviving;

	public override void Awake()
	{
		revCount = 0f;
	}

	public override void OnEnable()
	{
		revCount = 0f;
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (!reviving && ((Component)c).gameObject.layer == 8)
		{
			reviving = true;
		}
	}

	public override void OnTriggerExit(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			reviving = false;
			revCount = 0f;
		}
	}

	public override void Update()
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		if (reviving)
		{
			revCount += 1f * Time.deltaTime;
			if (!(revCount < 5f))
			{
				player.SendMessage("Rev");
				player.networkView.RPC("Revive", (RPCMode)6, new object[0]);
				((Component)this).gameObject.SetActive(false);
				player.networkView.RPC("RevCheck", (RPCMode)0, new object[0]);
			}
		}
		float x = revCount / 5f * 2f;
		Vector3 localScale = bar.transform.localScale;
		float num = (localScale.x = x);
		Vector3 val2 = (bar.transform.localScale = localScale);
	}

	public override void Main()
	{
	}
}
