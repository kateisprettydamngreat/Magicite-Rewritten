using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class TreeScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242667 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal TreeScript _0024self__00242668;

			public _0024(TreeScript self_)
			{
				_0024self__00242668 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242668.exiling)
					{
						_0024self__00242668.exiling = true;
						_0024self__00242668.transform.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_0099;
				case 2:
					if (Network.isServer)
					{
						Network.Destroy(_0024self__00242668.GetComponent<NetworkView>().viewID);
						Network.RemoveRPCs(_0024self__00242668.GetComponent<NetworkView>().viewID);
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

		internal TreeScript _0024self__00242669;

		public _0024Exile_00242667(TreeScript self_)
		{
			_0024self__00242669 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242669);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD2_00242670 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024canHit_00242671;

			internal int _0024i_00242672;

			internal GameObject _0024d_00242673;

			internal int[] _0024stats_00242674;

			internal Item _0024item_00242675;

			internal int _0024dmg_00242676;

			internal TreeScript _0024self__00242677;

			public _0024(int dmg, TreeScript self_)
			{
				_0024dmg_00242676 = dmg;
				_0024self__00242677 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024canHit_00242671 = false;
					if (_0024dmg_00242676 > 10)
					{
						_0024dmg_00242676 -= 10;
						_0024self__00242677.trait = true;
					}
					else
					{
						_0024self__00242677.trait = false;
					}
					_0024i_00242672 = default(int);
					_0024d_00242673 = null;
					_0024stats_00242674 = null;
					if (_0024self__00242677.trait)
					{
						_0024self__00242677.hp -= 2;
						_0024canHit_00242671 = true;
					}
					else if (_0024dmg_00242676 > 0)
					{
						_0024self__00242677.hp--;
						_0024canHit_00242671 = true;
					}
					if (_0024canHit_00242671)
					{
						_0024self__00242677.@base.GetComponent<Animation>().Play();
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_02d9;
				case 2:
					if (_0024self__00242677.hp <= 0)
					{
						GameScript.tempStats[5] = GameScript.tempStats[5] + 1;
						if (GameScript.tempStats[5] >= 3)
						{
							MenuScript.canUnlockRace[0] = 1;
						}
					}
					if (_0024self__00242677.hp <= 0)
					{
						_0024item_00242675 = new Item(1, 1, new int[4], 0f, null);
						for (_0024i_00242672 = 0; _0024i_00242672 < _0024dmg_00242676; _0024i_00242672++)
						{
							_0024item_00242675.id = 1;
							_0024d_00242673 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), _0024self__00242677.t.position, Quaternion.identity);
							_0024stats_00242674 = new int[7] { _0024item_00242675.id, _0024item_00242675.q, 0, 0, 0, 0, 0 };
							_0024d_00242673.SendMessage("InitL", _0024stats_00242674);
							_0024item_00242675.id = 3;
							_0024d_00242673 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), _0024self__00242677.t.position, Quaternion.identity);
							_0024stats_00242674 = new int[7] { _0024item_00242675.id, _0024item_00242675.q, 0, 0, 0, 0, 0 };
							_0024d_00242673.SendMessage("InitL", _0024stats_00242674);
						}
						if (Network.isServer)
						{
							if (_0024self__00242677.height > 1)
							{
								_0024self__00242677.GetComponent<NetworkView>().RPC("UA", RPCMode.All);
							}
							else
							{
								_0024self__00242677.GetComponent<NetworkView>().RPC("Exile", RPCMode.All);
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

		internal int _0024dmg_00242678;

		internal TreeScript _0024self__00242679;

		public _0024TD2_00242670(int dmg, TreeScript self_)
		{
			_0024dmg_00242678 = dmg;
			_0024self__00242679 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dmg_00242678, _0024self__00242679);
		}
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

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00242667(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator TD2(int dmg)
	{
		return new _0024TD2_00242670(dmg, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
