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
	internal sealed class _0024TD2_00242633 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024canHit_00242634;

			internal int _0024i_00242635;

			internal GameObject _0024d_00242636;

			internal Item _0024item_00242637;

			internal int _0024dmg_00242638;

			internal TreeScript _0024self__00242639;

			public _0024(int dmg, TreeScript self_)
			{
				_0024dmg_00242638 = dmg;
				_0024self__00242639 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fb: Expected O, but got Unknown
				//IL_038c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0391: Unknown result type (might be due to invalid IL or missing references)
				//IL_039b: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a5: Expected O, but got Unknown
				//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f6: Expected O, but got Unknown
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bb: Expected O, but got Unknown
				//IL_0294: Unknown result type (might be due to invalid IL or missing references)
				//IL_0299: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ae: Expected O, but got Unknown
				//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024canHit_00242634 = false;
					if (_0024dmg_00242638 > 10)
					{
						_0024dmg_00242638 -= 10;
						_0024self__00242639.trait = true;
					}
					else
					{
						_0024self__00242639.trait = false;
					}
					_0024i_00242635 = default(int);
					_0024d_00242636 = null;
					if (_0024self__00242639.trait)
					{
						_0024self__00242639.hp -= 2;
						_0024canHit_00242634 = true;
					}
					else if (_0024dmg_00242638 > 0)
					{
						_0024self__00242639.hp--;
						_0024canHit_00242634 = true;
					}
					if (_0024canHit_00242634)
					{
						_0024self__00242639.@base.animation.Play();
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_04e6;
				case 2:
					if (_0024self__00242639.hp <= 0)
					{
						GameScript.tempStats[5] = GameScript.tempStats[5] + 1;
						if (GameScript.tempStats[5] >= 3)
						{
							MenuScript.canUnlockRace[0] = 1;
						}
					}
					if (_0024self__00242639.hp <= 0 && MenuScript.multiplayer == 1)
					{
						_0024item_00242637 = new Item(1, 1, new int[4], 0f, null);
						for (_0024i_00242635 = 0; _0024i_00242635 < _0024dmg_00242638; _0024i_00242635++)
						{
							if (MenuScript.multiplayer > 0)
							{
								_0024item_00242637.id = 1;
								_0024d_00242636 = (GameObject)Network.Instantiate(Resources.Load("item"), _0024self__00242639.t.position, Quaternion.identity, 0);
								_0024d_00242636.networkView.RPC("SetID", (RPCMode)6, new object[1] { _0024item_00242637.id });
								_0024d_00242636.networkView.RPC("SetD", (RPCMode)6, new object[1] { _0024item_00242637.d });
								_0024d_00242636.networkView.RPC("SetE", (RPCMode)6, new object[1] { _0024item_00242637.e });
								_0024d_00242636.networkView.RPC("SetQ", (RPCMode)6, new object[1] { _0024item_00242637.q });
								_0024item_00242637.id = 3;
								_0024d_00242636 = (GameObject)Network.Instantiate(Resources.Load("item"), _0024self__00242639.t.position, Quaternion.identity, 0);
								_0024d_00242636.networkView.RPC("SetID", (RPCMode)6, new object[1] { _0024item_00242637.id });
								_0024d_00242636.networkView.RPC("SetD", (RPCMode)6, new object[1] { _0024item_00242637.d });
								_0024d_00242636.networkView.RPC("SetE", (RPCMode)6, new object[1] { _0024item_00242637.e });
								_0024d_00242636.networkView.RPC("SetQ", (RPCMode)6, new object[1] { _0024item_00242637.q });
							}
							else
							{
								_0024item_00242637.id = 1;
								_0024d_00242636 = (GameObject)Object.Instantiate(Resources.Load("item"), _0024self__00242639.t.position, Quaternion.identity);
								_0024d_00242636.SendMessage("Set", (object)_0024item_00242637);
								_0024item_00242637.id = 3;
								_0024d_00242636 = (GameObject)Object.Instantiate(Resources.Load("item"), _0024self__00242639.t.position, Quaternion.identity);
								_0024d_00242636.SendMessage("Set", (object)_0024item_00242637);
							}
						}
						if (_0024self__00242639.height > 1)
						{
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00242639).networkView.RPC("UA", (RPCMode)6, new object[0]);
							}
							else
							{
								_0024self__00242639.height--;
								_0024self__00242639.hp = 1;
								_0024self__00242639.UpdateAppearance();
							}
						}
						else if (MenuScript.multiplayer > 0)
						{
							Network.RemoveRPCs(((Component)_0024self__00242639).networkView.viewID);
							Network.Destroy(((Component)_0024self__00242639).networkView.viewID);
						}
						else
						{
							Object.Destroy((Object)(object)((Component)_0024self__00242639).gameObject);
						}
					}
					goto IL_04e6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_04e6:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242640;

		internal TreeScript _0024self__00242641;

		public _0024TD2_00242633(int dmg, TreeScript self_)
		{
			_0024dmg_00242640 = dmg;
			_0024self__00242641 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242640, _0024self__00242641);
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

	public TreeScript()
	{
		hp = 1;
		maxHeight = 3;
		bases = (GameObject[])(object)new GameObject[3];
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				((Component)this).networkView.RPC("Init", (RPCMode)6, new object[1] { Random.Range(1, 4) });
				((Component)this).networkView.RPC("UpdateAppearance", (RPCMode)6, new object[0]);
			}
		}
		else
		{
			Init(Random.Range(1, 4));
			UpdateAppearance();
		}
	}

	[RPC]
	public override void Init(int a)
	{
		height = a;
	}

	[RPC]
	public override void UpdateAppearance()
	{
		int num = default(int);
		for (num = 0; num < 3; num++)
		{
			if (num < height)
			{
				bases[num].renderer.material = treeTop;
				if (num != 0)
				{
					bases[num - 1].renderer.material = treeBase;
				}
			}
			else
			{
				bases[num].SetActive(false);
			}
		}
	}

	public override void OnDestroy()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer > 0)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
		}
	}

	[RPC]
	public override void UA()
	{
		height--;
		hp = 1;
		((Component)this).networkView.RPC("UpdateAppearance", (RPCMode)6, new object[0]);
	}

	public override void TD(int dmg)
	{
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
		GameObject val = null;
		if (dmg > 0 && MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("TD2", (RPCMode)2, new object[1] { dmg });
		}
	}

	[RPC]
	public override IEnumerator TD2(int dmg)
	{
		return new _0024TD2_00242633(dmg, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
