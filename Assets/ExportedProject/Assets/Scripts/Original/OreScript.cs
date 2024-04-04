using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class OreScript : MonoBehaviour
{
    [RPC]
    public virtual IEnumerator Exile()
    {
        if (!exiling)
        {
            exiling = true;
            transform.position = new Vector3(0f, 0f, -500f);
            yield return new WaitForSeconds(4f);

            if (Network.isServer)
            {
                Network.Destroy(GetComponent<NetworkView>().viewID);
                Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
            }
        }
    }

	public int tier;

	private int hp;

	public GameObject @base;

	private Transform t;

	private bool trait;

	private bool minerCap;

	private bool exiling;

	public OreScript()
	{
		hp = 2;
	}

	public virtual void Start()
	{
		trait = false;
		t = transform;
		if (Network.isServer)
		{
			GetComponent<NetworkView>().RPC("SetTier", RPCMode.All, tier);
		}
	}

	[RPC]
	public virtual void SetTier(int a)
	{
		tier = a;
	}

	public virtual void TD(int dmg)
	{
		MonoBehaviour.print("Ore is taking " + dmg + " damage");
		int num = default(int);
		GameObject gameObject = null;
		if (dmg >= 10)
		{
			dmg -= 10;
			minerCap = true;
		}
		GetComponent<NetworkView>().RPC("TD2", RPCMode.All, dmg);
	}

    public virtual int GetOre(int a)
    {
	    int num = default(int);
	    switch (a)
	    {
		    case 0:
			    return 4;
		    case 1:
			    return 5;
		    case 2:
			    return 6;
		    case 3:
			    return 60;
		    case 4:
			    return 62;
		    case 5:
			    return 64;
		    case 6:
			    return 66;
		    default:
			    return 6;
	    }
    }

	[RPC]
	public virtual void TD2(int dmg)
	{
		GameObject gameObject = null;
		int num = default(int);
		int[] array = null;
		if (dmg < 1)
		{
			return;
		}
		hp--;
		@base.GetComponent<Animation>().Play();
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
		if (minerCap && dmg > tier + 1 && UnityEngine.Random.Range(0, 4) == 0)
		{
			Item item = new Item(GetOre(tier), 1, new int[4], 0f, null);
			gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
			array = new int[7] { item.id, item.q, 0, 0, 0, 0, 0 };
			gameObject.SendMessage("InitL", array);
		}
		if (hp <= 0)
		{
			int num2 = UnityEngine.Random.Range(0, 3);
			Item item2 = new Item(38, 1, new int[4], 0f, null);
			if (dmg > tier + 1)
			{
				item2.id = GetOre(tier);
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
				array = new int[7] { item2.id, item2.q, 0, 0, 0, 0, 0 };
				gameObject.SendMessage("InitL", array);
			}
			item2.id = 38;
			int num3 = 2;
			for (num = 0; num < num3; num++)
			{
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
				array = new int[7] { item2.id, item2.q, 0, 0, 0, 0, 0 };
				gameObject.SendMessage("InitL", array);
			}
			if (UnityEngine.Random.Range(0, 5) == 0)
			{
				item2.id = 47;
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
				array = new int[7] { item2.id, item2.q, 0, 0, 0, 0, 0 };
				gameObject.SendMessage("InitL", array);
			}
			transform.position = new Vector3(0f, 0f, -500f);
			if (Network.isServer)
			{
				StartCoroutine(Exile());
			}
		}
	}

	}