using System;
using UnityEngine;

[Serializable]
public class SpiderEgg : MonoBehaviour
{
	public bool isDragon;

	public bool isFairy;

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8 || c.gameObject.layer == 24 || c.gameObject.layer == 19)
		{
			GetComponent<NetworkView>().RPC("Die", RPCMode.All);
		}
	}

	[RPC]
	public virtual void Die()
	{
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
		if (Network.isServer)
		{
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
			Network.Destroy(GetComponent<NetworkView>().viewID);
		}
	}

	public virtual void Main()
	{
	}
}
