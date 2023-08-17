using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SmallWorm : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242794 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242795;

			internal SmallWorm _0024self__00242796;

			public _0024(SmallWorm self_)
			{
				_0024self__00242796 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ff: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242796.HP = _0024self__00242796.maxHP;
					_0024self__00242796.drops = new int[3] { 7, 18, 0 };
					_0024self__00242796.t = ((Component)_0024self__00242796).transform;
					((MonoBehaviour)_0024self__00242796).StartCoroutine_Auto(_0024self__00242796.Initialize());
					if (_0024self__00242796.isHead)
					{
						_0024i_00242795 = default(int);
						_0024self__00242796.mainHead.animation.Play();
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
				case 2:
					_0024i_00242795 = 0;
					goto IL_0112;
				case 3:
					_0024i_00242795++;
					goto IL_0112;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0112:
					if (_0024i_00242795 < 5)
					{
						_0024self__00242796.parts[_0024i_00242795].animation.Play("wBody");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
					IL_011e:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal SmallWorm _0024self__00242797;

		public _0024Start_00242794(SmallWorm self_)
		{
			_0024self__00242797 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242797);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Initialize_00242798 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SmallWorm _0024self__00242799;

			public _0024(SmallWorm self_)
			{
				_0024self__00242799 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_008b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242799.isHead || MenuScript.multiplayer > 0)
					{
						goto IL_00c2;
					}
					_0024self__00242799.mainHead.renderer.material = _0024self__00242799.leadHead;
					_0024self__00242799.player = GameObject.Find("player(Clone)");
					_0024self__00242799.speed = 10f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242799.mainHead.animation.Play("wHead");
					((MonoBehaviour)_0024self__00242799).StartCoroutine_Auto(_0024self__00242799.Attack());
					goto IL_00c2;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00c2:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal SmallWorm _0024self__00242800;

		public _0024Initialize_00242798(SmallWorm self_)
		{
			_0024self__00242800 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242800);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242801 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SmallWorm _0024self__00242802;

			public _0024(SmallWorm self_)
			{
				_0024self__00242802 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0046: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242802.time = Random.Range(8, 11);
					_0024self__00242802.curVector = _0024self__00242802.player.transform.position - _0024self__00242802.t.position;
					_0024self__00242802.attacking = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00242802.time)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242802.attacking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SmallWorm _0024self__00242803;

		public _0024Attack_00242801(SmallWorm self_)
		{
			_0024self__00242803 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242803);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00242804 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242805;

			internal int _0024dmg_00242806;

			internal SmallWorm _0024self__00242807;

			public _0024(int dmg, SmallWorm self_)
			{
				_0024dmg_00242806 = dmg;
				_0024self__00242807 = self_;
			}

			public override bool MoveNext()
			{
				//IL_014f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Expected O, but got Unknown
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Expected O, but got Unknown
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Expected O, but got Unknown
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_0122: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242807.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00242807.takingDamage = true;
							_0024self__00242807.HP -= _0024dmg_00242806;
							_0024n2_00242805 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242807.t.position, Quaternion.identity);
							_0024n2_00242805.SendMessage("SD", (object)_0024dmg_00242806);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00242807).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00242806 });
						((Component)_0024self__00242807).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00242806 });
					}
					goto IL_016a;
				case 2:
					if (_0024self__00242807.HP < 1)
					{
						_0024self__00242807.Die();
						goto IL_016a;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242807.takingDamage = false;
					goto IL_016a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_016a:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242808;

		internal SmallWorm _0024self__00242809;

		public _0024TD_00242804(int dmg, SmallWorm self_)
		{
			_0024dmg_00242808 = dmg;
			_0024self__00242809 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242808, _0024self__00242809);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242810 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024dmg_00242811;

			internal SmallWorm _0024self__00242812;

			public _0024(int dmg, SmallWorm self_)
			{
				_0024dmg_00242811 = dmg;
				_0024self__00242812 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242812.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242812.HP -= _0024dmg_00242811;
					if (_0024self__00242812.HP < 1)
					{
						_0024self__00242812.Die();
					}
					else
					{
						_0024self__00242812.takingDamage = false;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242813;

		internal SmallWorm _0024self__00242814;

		public _0024TDN_00242810(int dmg, SmallWorm self_)
		{
			_0024dmg_00242813 = dmg;
			_0024self__00242814 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242813, _0024self__00242814);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242815 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242816;

			internal int _0024dmg_00242817;

			internal SmallWorm _0024self__00242818;

			public _0024(int dmg, SmallWorm self_)
			{
				_0024dmg_00242817 = dmg;
				_0024self__00242818 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Expected O, but got Unknown
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Expected O, but got Unknown
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Expected O, but got Unknown
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Expected O, but got Unknown
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024n2_00242816 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242818.t.position, Quaternion.identity);
					_0024n2_00242816.SendMessage("SD", (object)_0024dmg_00242817);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					if (_0024self__00242818.HP < 1)
					{
						goto IL_00dc;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242818.takingDamage = false;
					goto IL_00dc;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00dc:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242819;

		internal SmallWorm _0024self__00242820;

		public _0024TDN2_00242815(int dmg, SmallWorm self_)
		{
			_0024dmg_00242819 = dmg;
			_0024self__00242820 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242819, _0024self__00242820);
		}
	}

	public bool isHead;

	public GameObject head;

	public float speed;

	public float space;

	public float time;

	public GameObject mainHead;

	public Material leadHead;

	public GameObject[] parts;

	private Transform t;

	private bool moving;

	private GameObject player;

	private Vector3 curVector;

	private bool attacking;

	private Vector3 a;

	private Vector3 b;

	private int HP;

	private int maxHP;

	private int GOLD;

	public int[] drops;

	private bool takingDamage;

	public SmallWorm()
	{
		parts = (GameObject[])(object)new GameObject[5];
		maxHP = 10;
		GOLD = 10;
		drops = new int[3];
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242794(this).GetEnumerator();
	}

	public override IEnumerator Initialize()
	{
		return new _0024Initialize_00242798(this).GetEnumerator();
	}

	public override IEnumerator Attack()
	{
		return new _0024Attack_00242801(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)head))
		{
			head = ((Component)this).gameObject;
			isHead = true;
			((MonoBehaviour)this).StartCoroutine_Auto(Initialize());
		}
		if (isHead)
		{
			if (attacking)
			{
				t.Translate(((Vector3)(ref curVector)).normalized * speed * Time.deltaTime);
			}
			return;
		}
		if (!(Mathf.Abs(head.transform.position.x - t.position.x) <= space))
		{
			t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
		}
		if (!(Mathf.Abs(head.transform.position.y - t.position.y) <= space))
		{
			t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
		}
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00242804(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242810(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242815(dmg, this).GetEnumerator();
	}

	public override void Die()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		GameObject val = null;
		int num = default(int);
		if (MenuScript.multiplayer > 0)
		{
			for (num = 0; num < GOLD; num++)
			{
				Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
			}
		}
		else
		{
			for (num = 0; num < GOLD; num++)
			{
				Object.Instantiate(Resources.Load("c"), t.position, Quaternion.identity);
			}
		}
		if (drops[0] > 0 && Random.Range(0, 2) == 0)
		{
			int num2 = Random.Range(1, 3);
			for (num = 0; num < num2; num++)
			{
				if (MenuScript.multiplayer > 0)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
					val.networkView.RPC("SetN", (RPCMode)6, new object[1] { drops[0] });
				}
				else
				{
					val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
					val.SendMessage("Set", (object)drops[0]);
				}
			}
		}
		if (drops[1] > 0 && Random.Range(0, 4) == 0)
		{
			int num3 = Random.Range(1, 3);
			for (num = 0; num < num3; num++)
			{
				if (MenuScript.multiplayer > 0)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
					val.networkView.RPC("SetN", (RPCMode)6, new object[1] { drops[1] });
				}
				else
				{
					val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
					val.SendMessage("Set", (object)drops[1]);
				}
			}
		}
		if (MenuScript.multiplayer == 0)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (Network.isServer)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
			Network.Destroy(((Component)this).networkView.viewID);
		}
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			((Component)c).SendMessage("TD", (object)10);
		}
	}

	public override void Main()
	{
	}
}
