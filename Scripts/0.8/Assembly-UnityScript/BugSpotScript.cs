using System;
using UnityEngine;

[Serializable]
public class BugSpotScript : MonoBehaviour
{
	private Renderer r;

	private int drop;

	public override void Start()
	{
		if (MenuScript.multiplayer == 1)
		{
			drop = Random.Range(0, 3) switch
			{
				0 => 30, 
				1 => 31, 
				_ => 81, 
			};
			((Component)this).networkView.RPC("SetDropN", (RPCMode)6, new object[1] { drop });
		}
	}

	[RPC]
	public override void SetDropN(int a)
	{
		drop = a;
	}

	public override void TD(int dmg)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		if (dmg <= 0)
		{
			return;
		}
		int num = default(int);
		GameObject val = null;
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("TD2", (RPCMode)2, new object[1] { dmg });
			return;
		}
		GameScript.tempStats[8] = GameScript.tempStats[8] + 1;
		Item item = new Item(drop, 1, new int[4], 0f, null);
		for (num = 0; num < dmg; num++)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity);
			val.SendMessage("Set", (object)item);
		}
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}

	[RPC]
	public override void TD2(int dmg)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		if (dmg > 0)
		{
			GameScript.tempStats[8] = GameScript.tempStats[8] + 1;
			int num = default(int);
			GameObject val = null;
			Item item = new Item(drop, 1, new int[4], 0f, null);
			for (num = 0; num < dmg; num++)
			{
				val = (GameObject)Network.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity, 1);
				val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
				val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
				val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
				val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
			}
			Network.RemoveRPCs(((Component)this).networkView.viewID);
			Network.Destroy(((Component)this).networkView.viewID);
		}
	}

	public override int GetPlantItem(int a)
	{
		int num = default(int);
		return a switch
		{
			0 => 9, 
			1 => 10, 
			2 => 11, 
			_ => num, 
		};
	}

	public override void Main()
	{
	}
}
