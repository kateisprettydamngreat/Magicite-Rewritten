using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class TreeScript : MonoBehaviour
{
	public IEnumerator ExileRoutine() 
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

	public IEnumerator TakeDamageCoroutine(int damage)
	{
		bool canHit = false;
		
		if (damage > 10)
		{
			damage -= 10;
			trait = true;
		}
		else
		{
			trait = false; 
		}

		int i = 0;
		GameObject d = null; 
		int[] stats = null;
		Item item = new Item(1, 1, new int[4], 0f, null);

		if (trait)
		{
			hp -= 2;
			canHit = true;
		}
		else if (damage > 0) 
		{
			hp--;
			canHit = true;
		}

		if (canHit)
		{
			base.GetComponent<Animation>().Play();
			
			yield return new WaitForSeconds(0.1f);
			
			if (hp <= 0)
			{
				GameScript.tempStats[5] += 1;
				if (GameScript.tempStats[5] >= 3)
				{
					MenuScript.canUnlockRace[0] = 1;
				}
			}

			if (hp <= 0)
			{
				for (i = 0; i < damage; i++) 
				{
					item.id = 1;
					d = Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
					stats = new int[]{ item.id, item.q, 0, 0, 0, 0, 0 };
					d.SendMessage("InitL", stats);
					
					item.id = 3;
					d = Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
					stats = new int[]{ item.id, item.q, 0, 0, 0, 0, 0 };
					d.SendMessage("InitL", stats);
				}
				
				if (Network.isServer)
				{
					if (height > 1)
					{
						GetComponent<NetworkView>().RPC("UA", RPCMode.All);
					}
					else 
					{
						GetComponent<NetworkView>().RPC("Exile", RPCMode.All);
					}
				}
			}
		}

		yield return null;
	}


	public Material treeTop;

	public Material treeBase;

	private int hp;

	public GameObject @base;

	private Transform t;

	private bool isEnt;

	private int height;

	public int maxHeight;

	public GameObject[] bases;

	private bool trait;

	private bool exiling;

	public TreeScript()
	{
		hp = 1;
		maxHeight = 3;
		bases = new GameObject[3];
	}

	public virtual void Awake()
	{
		t = transform;
		if (Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Init", RPCMode.All, UnityEngine.Random.Range(1, 4));
			GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All);
		}
	}

	[RPC]
	public virtual void Init(int a)
	{
		height = a;
	}

	[RPC]
	public virtual void UpdateAppearance()
	{
		int num = default(int);
		for (num = 0; num < 3; num++)
		{
			if (num < height)
			{
				bases[num].GetComponent<Renderer>().material = treeTop;
				if (num != 0)
				{
					bases[num - 1].GetComponent<Renderer>().material = treeBase;
				}
			}
			else
			{
				bases[num].SetActive(value: false);
			}
		}
	}

	public virtual void OnDestroy()
	{
		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
	}

	[RPC]
	public virtual void UA()
	{
		height--;
		hp = 1;
		GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All);
	}

	public virtual void TD(int dmg)
	{
		MonoBehaviour.print("TAKING DAMAGE");
		bool flag = false;
		if (dmg >= 10)
		{
			dmg -= 10;
			trait = true;
		}
		else
		{
			trait = false;
		}
		int num = default(int);
		GameObject gameObject = null;
		if (dmg > 0)
		{
			GetComponent<NetworkView>().RPC("TD2", RPCMode.All, dmg);
		}
	}


	}