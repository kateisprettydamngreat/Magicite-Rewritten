using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class TreeScript : MonoBehaviour
{
	[RPC]
	public IEnumerator Exile() 
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

	[Serializable]
	[CompilerGenerated]
	internal sealed class TreeDamageCoroutine : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class TreeDamageCoroutineEnumerator : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool canHit;

			internal int i;

			internal GameObject droppedItem;

			internal int[] itemStats;

			internal Item item;

			internal int damage;

			internal TreeScript self;

			public TreeDamageCoroutineEnumerator(int dmg, TreeScript self_)
			{
				damage = dmg;
				self = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					canHit = false;
					if (damage > 10)
					{
						damage -= 10;
						self.trait = true;
					}
					else
					{
						self.trait = false;
					}
					i = default(int);
					droppedItem = null;
					itemStats = null;
					if (self.trait)
					{
						self.hp -= 2;
						canHit = true;
					}
					else if (damage > 0)
					{
						self.hp--;
						canHit = true;
					}
					if (canHit)
					{
						self.@base.GetComponent<Animation>().Play();
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_02d9;
				case 2:
					if (self.hp <= 0)
					{
						GameScript.tempStats[5] = GameScript.tempStats[5] + 1;
						if (GameScript.tempStats[5] >= 3)
						{
							MenuScript.canUnlockRace[0] = 1;
						}
					}
					if (self.hp <= 0)
					{
						item = new Item(1, 1, new int[4], 0f, null);
						for (i = 0; i < damage; i++)
						{
							item.id = 1;
							droppedItem = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), self.t.position, Quaternion.identity);
							itemStats = new int[7] { item.id, item.q, 0, 0, 0, 0, 0 };
							droppedItem.SendMessage("InitL", itemStats);
							item.id = 3;
							droppedItem = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), self.t.position, Quaternion.identity);
							itemStats = new int[7] { item.id, item.q, 0, 0, 0, 0, 0 };
							droppedItem.SendMessage("InitL", itemStats);
						}
						if (Network.isServer)
						{
							if (self.height > 1)
							{
								self.GetComponent<NetworkView>().RPC("UA", RPCMode.All);
							}
							else
							{
								self.GetComponent<NetworkView>().RPC("Exile", RPCMode.All);
							}
						}
					}
					goto IL_02d9;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02d9:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int damage;

		internal TreeScript treeScript;

		public TreeDamageCoroutine(int dmg, TreeScript self_)
		{
			damage = dmg;
			treeScript = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new TreeDamageCoroutineEnumerator(damage, treeScript);
		}
	}
	[RPC]
	public virtual IEnumerator TD2(int dmg)
	{
		return new TreeDamageCoroutine(dmg, this).GetEnumerator();
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