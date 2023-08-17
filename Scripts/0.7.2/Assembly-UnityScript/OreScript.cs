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

	public OreScript()
	{
		hp = 1;
	}

	public override void Start()
	{
		trait = false;
		t = ((Component)this).transform;
	}

	public override void TD(int dmg)
	{
		MonoBehaviour.print((object)("Ore is taking " + (object)dmg + " damage"));
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
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
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
		int num = Random.Range(0, 3);
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
		int num2 = 2;
		int num3 = default(int);
		for (num3 = 0; num3 < num2; num3++)
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
