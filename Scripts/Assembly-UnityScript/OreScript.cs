using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class OreScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242117 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal OreScript _0024self__00242118;

			public _0024(OreScript self_)
			{
				_0024self__00242118 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242118.exiling)
					{
						_0024self__00242118.exiling = true;
						_0024self__00242118.transform.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_0099;
				case 2:
					if (Network.isServer)
					{
						Network.Destroy(_0024self__00242118.GetComponent<NetworkView>().viewID);
						Network.RemoveRPCs(_0024self__00242118.GetComponent<NetworkView>().viewID);
					}
					goto IL_0099;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0099:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal OreScript _0024self__00242119;

		public _0024Exile_00242117(OreScript self_)
		{
			_0024self__00242119 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242119);
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
				StartCoroutine_Auto(Exile());
			}
		}
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00242117(this).GetEnumerator();
	}

	}