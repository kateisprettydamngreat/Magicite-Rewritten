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

	public virtual void Start()
	{
		trait = false;
		t = transform;
	}

	public virtual void TD(int dmg)
	{
		int num = default(int);
		GameObject gameObject = null;
		if (dmg >= 10)
		{
			MonoBehaviour.print("trait is true");
			MonoBehaviour.print("first is " + MenuScript.curTrait[1] + " second is " + MenuScript.curTrait[2]);
			trait = true;
			dmg -= 10;
		}
		else
		{
			trait = false;
		}
		GetComponent<NetworkView>().RPC("TD2", RPCMode.All, dmg);
	}

	public virtual int GetOre(int a)
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
	public virtual void TD2(int dmg)
	{
		GameObject gameObject = null;
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
		@base.GetComponent<Animation>().Play();
		if (hp <= 0)
		{
			Item item = new Item(38, 1, new int[4], 0f, null);
			GameScript.tempStats[7] = GameScript.tempStats[7] + 1;
			if (dmg > tier + 1)
			{
				item.id = GetOre(tier);
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetID", RPCMode.All, item.id);
				gameObject.GetComponent<NetworkView>().RPC("SetD", RPCMode.All, item.d);
				gameObject.GetComponent<NetworkView>().RPC("SetE", RPCMode.All, item.e);
				gameObject.GetComponent<NetworkView>().RPC("SetQ", RPCMode.All, item.q);
			}
			item.id = 38;
			int num = 2;
			int num2 = default(int);
			for (num2 = 0; num2 < num; num2++)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetID", RPCMode.All, item.id);
				gameObject.GetComponent<NetworkView>().RPC("SetD", RPCMode.All, item.d);
				gameObject.GetComponent<NetworkView>().RPC("SetE", RPCMode.All, item.e);
				gameObject.GetComponent<NetworkView>().RPC("SetQ", RPCMode.All, item.q);
			}
			if (UnityEngine.Random.Range(0, 5) == 0)
			{
				item.id = 47;
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetID", RPCMode.All, item.id);
				gameObject.GetComponent<NetworkView>().RPC("SetD", RPCMode.All, item.d);
				gameObject.GetComponent<NetworkView>().RPC("SetE", RPCMode.All, item.e);
			}
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
			Network.Destroy(GetComponent<NetworkView>().viewID);
		}
	}

	}