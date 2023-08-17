using System;
using UnityEngine;

[Serializable]
public class BugSpot : MonoBehaviour
{
	public int tier;

	private int hp;

	public GameObject @base;

	private Transform t;

	private bool trait;

	public BugSpot()
	{
		hp = 3;
	}

	public override void Start()
	{
		trait = false;
		t = ((Component)this).transform;
	}

	public override void TD(int dmg)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		int num = default(int);
		GameObject val = null;
		if (dmg >= 10)
		{
			MonoBehaviour.print((object)"trait is true");
			MonoBehaviour.print((object)("first is " + (object)MenuScript.curTrait[1] + " second is " + (object)MenuScript.curTrait[2]));
			trait = true;
			dmg -= 10;
		}
		else
		{
			trait = false;
		}
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("TD2", (RPCMode)2, new object[1] { dmg });
			return;
		}
		MonoBehaviour.print((object)("dmg " + (object)dmg));
		if (dmg < 1)
		{
			return;
		}
		if (trait)
		{
			hp -= 2;
		}
		else
		{
			hp--;
		}
		@base.animation.Play();
		if (hp > 0)
		{
			return;
		}
		Item item = new Item(38, 1, new int[4], 0f, null);
		GameScript.tempStats[7] = GameScript.tempStats[7] + 1;
		int num2 = tier;
		if (tier > 2)
		{
			num2 = 3;
		}
		if (dmg > num2 + 1)
		{
			item.id = GetOre(tier);
			if (MenuScript.multiplayer > 0)
			{
				val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				val.networkView.RPC("SetN", (RPCMode)6, new object[1] { item });
			}
			else
			{
				val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
				val.SendMessage("Set", (object)item);
			}
		}
		item.id = 38;
		int num3 = 1;
		for (num = 0; num < num3; num++)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
			val.SendMessage("Set", (object)item);
			val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
			val.SendMessage("Set", (object)item);
		}
		if (Random.Range(0, 5) == 0)
		{
			item.id = 47;
			if (MenuScript.multiplayer > 0)
			{
				val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				val.networkView.RPC("SetN", (RPCMode)6, new object[1] { item });
			}
			else
			{
				val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
				val.SendMessage("Set", (object)item);
			}
		}
		if (MenuScript.multiplayer > 0)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
			Network.Destroy(((Component)this).networkView.viewID);
		}
		else
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
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
			_ => num, 
		};
	}

	[RPC]
	public override void TD2(int dmg)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		GameObject val = null;
		if (dmg < 1)
		{
			return;
		}
		if (trait)
		{
			hp -= 2;
		}
		else
		{
			hp--;
		}
		@base.animation.Play();
		if (hp > 0)
		{
			return;
		}
		Item item = new Item(38, 1, new int[4], 0f, null);
		GameScript.tempStats[7] = GameScript.tempStats[7] + 1;
		if (dmg > tier + 1)
		{
			item.id = GetOre(tier);
			if (MenuScript.multiplayer > 0)
			{
				val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
				val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
				val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
				val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
			}
		}
		item.id = 38;
		int num = 2;
		int num2 = default(int);
		for (num2 = 0; num2 < num; num2++)
		{
			val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
			val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
			val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
			val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
			val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
		}
		if (Random.Range(0, 5) == 0)
		{
			item.id = 47;
			if (MenuScript.multiplayer > 0)
			{
				val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
				val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
				val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
			}
		}
		Network.RemoveRPCs(((Component)this).networkView.viewID);
		Network.Destroy(((Component)this).networkView.viewID);
	}

	public override void Main()
	{
	}
}
