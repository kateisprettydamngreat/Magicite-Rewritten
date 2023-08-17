using System;
using UnityEngine;

[Serializable]
public class beeHive : MonoBehaviour
{
	public GameObject wasp;

	private int hp;

	public GameObject @base;

	private bool burst;

	public beeHive()
	{
		hp = 12;
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 19 || ((Component)c).gameObject.layer == 24)
		{
			((Component)this).networkView.RPC("TD", (RPCMode)2, new object[0]);
		}
	}

	[RPC]
	public override void TD()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		@base.animation.Play();
		hp--;
		if (hp % 4 == 0 && MenuScript.multiplayer == 1)
		{
			Network.Instantiate((Object)(object)wasp, ((Component)this).transform.position, Quaternion.identity, 0);
		}
		if (hp > 0)
		{
			return;
		}
		MenuScript.canUnlockHat[9] = 1;
		if (MenuScript.multiplayer == 1 && !burst)
		{
			burst = true;
			int num = default(int);
			for (num = 0; num < 5; num++)
			{
				Network.Instantiate((Object)(object)wasp, new Vector3(((Component)this).transform.position.x + (float)Random.Range(-2, 3), ((Component)this).transform.position.y + (float)Random.Range(-2, 3), 0f), Quaternion.identity, 0);
			}
			Network.RemoveRPCs(((Component)this).networkView.viewID);
			Network.Destroy(((Component)this).networkView.viewID);
		}
	}

	public override void Main()
	{
	}
}
