using System;
using UnityEngine;

[Serializable]
public class StandScript : MonoBehaviour
{
	private Ray ray;

	private RaycastHit hit;

	public override void Awake()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Ray)(ref ray)).origin = ((Component)this).transform.position;
		((Ray)(ref ray)).direction = Vector3.down;
		if (!Physics.Raycast(ray, ref hit, 2.1f))
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public override void OnDisable()
	{
		if (MenuScript.multiplayer > 0 && Object.op_Implicit((Object)(object)((Component)this).networkView))
		{
			((Component)this).networkView.RPC("Disabled", (RPCMode)6, new object[0]);
		}
	}

	[RPC]
	public override void Disabled()
	{
		if (Object.op_Implicit((Object)(object)((Component)this).gameObject))
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 29 || ((Component)c).gameObject.layer == 11)
		{
			if (MenuScript.multiplayer > 0)
			{
				((Component)this).networkView.RPC("SA", (RPCMode)6, new object[0]);
			}
			else
			{
				((Component)this).gameObject.SetActive(false);
			}
		}
	}

	[RPC]
	public override void SA()
	{
		((Component)this).gameObject.SetActive(false);
	}

	public override void Main()
	{
	}
}
