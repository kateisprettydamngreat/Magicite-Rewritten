using System;
using UnityEngine;

[Serializable]
public class SpiderEgg : MonoBehaviour
{
	public bool isDragon;

	public bool isFairy;

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8 || ((Component)c).gameObject.layer == 24 || ((Component)c).gameObject.layer == 19)
		{
			((Component)this).networkView.RPC("Die", (RPCMode)2, new object[0]);
		}
	}

	[RPC]
	public override void Die()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (isFairy)
		{
			GameScript.FairyCounter();
		}
		else if (isDragon)
		{
			GameScript.DragonCounter();
		}
		else
		{
			GameScript.EggCounter();
		}
		if (MenuScript.multiplayer == 1)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
			Network.Destroy(((Component)this).networkView.viewID);
		}
	}

	public override void Main()
	{
	}
}
