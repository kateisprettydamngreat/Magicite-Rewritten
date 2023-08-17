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
	internal sealed class _0024TD2_00242373 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024canHit_00242374;

			internal int _0024i_00242375;

			internal GameObject _0024d_00242376;

			internal Item _0024item_00242377;

			internal int _0024dmg_00242378;

			internal TreeScript _0024self__00242379;

			public _0024(int dmg, TreeScript self_)
			{
				_0024dmg_00242378 = dmg;
				_0024self__00242379 = self_;
			}

			public override bool MoveNext()
			{
				//IL_010b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Expected O, but got Unknown
				//IL_0391: Unknown result type (might be due to invalid IL or missing references)
				//IL_0396: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03aa: Expected O, but got Unknown
				//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03fb: Expected O, but got Unknown
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Expected O, but got Unknown
				//IL_0299: Unknown result type (might be due to invalid IL or missing references)
				//IL_029e: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b3: Expected O, but got Unknown
				//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024canHit_00242374 = false;
					MonoBehaviour.print((object)("TREE " + (object)_0024dmg_00242378));
					if (_0024dmg_00242378 > 10)
					{
						_0024dmg_00242378 -= 10;
						_0024self__00242379.trait = true;
					}
					else
					{
						_0024self__00242379.trait = false;
					}
					_0024i_00242375 = default(int);
					_0024d_00242376 = null;
					if (_0024self__00242379.trait)
					{
						_0024self__00242379.hp -= 2;
						_0024canHit_00242374 = true;
					}
					else if (_0024dmg_00242378 > 0)
					{
						_0024self__00242379.hp--;
						_0024canHit_00242374 = true;
					}
					if (_0024canHit_00242374)
					{
						_0024self__00242379.@base.animation.Play();
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_04eb;
				case 2:
					if (_0024self__00242379.hp <= 0)
					{
						GameScript.tempStats[5] = GameScript.tempStats[5] + 1;
					}
					if (_0024self__00242379.hp <= 0 && MenuScript.multiplayer == 1)
					{
						_0024item_00242377 = new Item(1, 1, new int[4], 0f, null);
						for (_0024i_00242375 = 0; _0024i_00242375 < _0024dmg_00242378; _0024i_00242375++)
						{
							if (MenuScript.multiplayer > 0)
							{
								_0024item_00242377.id = 1;
								_0024d_00242376 = (GameObject)Network.Instantiate(Resources.Load("item"), _0024self__00242379.t.position, Quaternion.identity, 0);
								_0024d_00242376.networkView.RPC("SetID", (RPCMode)6, new object[1] { _0024item_00242377.id });
								_0024d_00242376.networkView.RPC("SetD", (RPCMode)6, new object[1] { _0024item_00242377.d });
								_0024d_00242376.networkView.RPC("SetE", (RPCMode)6, new object[1] { _0024item_00242377.e });
								_0024d_00242376.networkView.RPC("SetQ", (RPCMode)6, new object[1] { _0024item_00242377.q });
								_0024item_00242377.id = 3;
								_0024d_00242376 = (GameObject)Network.Instantiate(Resources.Load("item"), _0024self__00242379.t.position, Quaternion.identity, 0);
								_0024d_00242376.networkView.RPC("SetID", (RPCMode)6, new object[1] { _0024item_00242377.id });
								_0024d_00242376.networkView.RPC("SetD", (RPCMode)6, new object[1] { _0024item_00242377.d });
								_0024d_00242376.networkView.RPC("SetE", (RPCMode)6, new object[1] { _0024item_00242377.e });
								_0024d_00242376.networkView.RPC("SetQ", (RPCMode)6, new object[1] { _0024item_00242377.q });
							}
							else
							{
								_0024item_00242377.id = 1;
								_0024d_00242376 = (GameObject)Object.Instantiate(Resources.Load("item"), _0024self__00242379.t.position, Quaternion.identity);
								_0024d_00242376.SendMessage("Set", (object)_0024item_00242377);
								_0024item_00242377.id = 3;
								_0024d_00242376 = (GameObject)Object.Instantiate(Resources.Load("item"), _0024self__00242379.t.position, Quaternion.identity);
								_0024d_00242376.SendMessage("Set", (object)_0024item_00242377);
							}
						}
						if (_0024self__00242379.height > 1)
						{
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00242379).networkView.RPC("UA", (RPCMode)6, new object[0]);
							}
							else
							{
								_0024self__00242379.height--;
								_0024self__00242379.hp = 1;
								_0024self__00242379.UpdateAppearance();
							}
						}
						else if (MenuScript.multiplayer > 0)
						{
							Network.RemoveRPCs(((Component)_0024self__00242379).networkView.viewID);
							Network.Destroy(((Component)_0024self__00242379).networkView.viewID);
						}
						else
						{
							Object.Destroy((Object)(object)((Component)_0024self__00242379).gameObject);
						}
					}
					goto IL_04eb;
				case 1:
					{
						result = 0;
						break;
					}
					IL_04eb:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242380;

		internal TreeScript _0024self__00242381;

		public _0024TD2_00242373(int dmg, TreeScript self_)
		{
			_0024dmg_00242380 = dmg;
			_0024self__00242381 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242380, _0024self__00242381);
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
		MonoBehaviour.print((object)("TREE " + (object)dmg));
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
		return new _0024TD2_00242373(dmg, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
