using System;
using UnityEngine;

[Serializable]
public class OreScript : MonoBehaviour
{
	public int tier;

	private int hp;

	public GameObject @base;

	private Transform t;

	private bool trait;

	private bool minerCap;

	public OreScript()
	{
		hp = 2;
	}

	public override void Start()
	{
		trait = false;
		t = ((Component)this).transform;
		if (MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("SetTier", (RPCMode)6, new object[1] { tier });
		}
	}

	[RPC]
	public override void SetTier(int a)
	{
		tier = a;
	}

	public override void TD(int dmg)
	{
		MonoBehaviour.print((object)("Ore is taking " + (object)dmg + " damage"));
		int num = default(int);
		GameObject val = null;
		if (dmg >= 10)
		{
			dmg -= 10;
			minerCap = true;
		}
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("TD2", (RPCMode)2, new object[1] { dmg });
		}
	}

	public override int GetOre(int a)
	{
		int num = default(int);
		return a switch
		{
			0 => 4, 
			1 => 5, 
			2 => 6, 
			3 => 60, 
			4 => 62, 
			5 => 64, 
			6 => 66, 
			_ => 6, 
		};
	}

	[RPC]
	public override void TD2(int dmg)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		GameObject val = null;
		int num = default(int);
		if (dmg < 1)
		{
			return;
		}
		hp--;
		@base.animation.Play();
		if (hp <= 0)
		{
			GameScript.tempStats[6] = GameScript.tempStats[6] + 1;
			if (GameScript.tempStats[5] >= 20)
			{
				MenuScript.canUnlockRace[2] = 1;
			}
			else if (GameScript.tempStats[5] >= 10)
			{
				MenuScript.canUnlockHat[2] = 1;
			}
		}
		if (minerCap && dmg > tier + 1 && Random.Range(0, 4) == 0)
		{
			Item item = new Item(GetOre(tier), 1, new int[4], 0f, null);
			val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
			val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
			val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
			val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
			val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
		}
		if (hp > 0 || MenuScript.multiplayer != 1)
		{
			return;
		}
		int num2 = Random.Range(0, 3);
		Item item2 = new Item(38, 1, new int[4], 0f, null);
		if (dmg > tier + 1)
		{
			item2.id = GetOre(tier);
			if (MenuScript.multiplayer > 0)
			{
				for (num = 0; num < Network.connections.Length + 1; num++)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
					val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item2.id });
					val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item2.d });
					val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item2.e });
					val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item2.q });
				}
			}
		}
		item2.id = 38;
		int num3 = 2;
		for (num = 0; num < Network.connections.Length + 1; num++)
		{
			val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
			val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item2.id });
			val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item2.d });
			val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item2.e });
			val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item2.q });
		}
		if (Random.Range(0, 5) == 0)
		{
			item2.id = 47;
			if (MenuScript.multiplayer > 0)
			{
				for (num = 0; num < Network.connections.Length + 1; num++)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
					val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item2.id });
					val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item2.d });
					val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item2.e });
					val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item2.q });
				}
			}
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
