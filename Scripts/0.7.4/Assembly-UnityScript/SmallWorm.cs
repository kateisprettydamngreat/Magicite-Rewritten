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
	internal sealed class _0024Start_00242391 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242392;

			internal SmallWorm _0024self__00242393;

			public _0024(SmallWorm self_)
			{
				_0024self__00242393 = self_;
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
					_0024self__00242393.HP = _0024self__00242393.maxHP;
					_0024self__00242393.drops = new int[3] { 7, 18, 0 };
					_0024self__00242393.t = ((Component)_0024self__00242393).transform;
					((MonoBehaviour)_0024self__00242393).StartCoroutine_Auto(_0024self__00242393.Initialize());
					if (_0024self__00242393.isHead)
					{
						_0024i_00242392 = default(int);
						_0024self__00242393.mainHead.animation.Play();
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
				case 2:
					_0024i_00242392 = 0;
					goto IL_0112;
				case 3:
					_0024i_00242392++;
					goto IL_0112;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0112:
					if (_0024i_00242392 < 5)
					{
						_0024self__00242393.parts[_0024i_00242392].animation.Play("wBody");
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

		internal SmallWorm _0024self__00242394;

		public _0024Start_00242391(SmallWorm self_)
		{
			_0024self__00242394 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242394);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Initialize_00242395 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SmallWorm _0024self__00242396;

			public _0024(SmallWorm self_)
			{
				_0024self__00242396 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_008b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242396.isHead || MenuScript.multiplayer > 0)
					{
						goto IL_00c2;
					}
					_0024self__00242396.mainHead.renderer.material = _0024self__00242396.leadHead;
					_0024self__00242396.player = GameObject.Find("player(Clone)");
					_0024self__00242396.speed = 10f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242396.mainHead.animation.Play("wHead");
					((MonoBehaviour)_0024self__00242396).StartCoroutine_Auto(_0024self__00242396.Attack());
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

		internal SmallWorm _0024self__00242397;

		public _0024Initialize_00242395(SmallWorm self_)
		{
			_0024self__00242397 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242397);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242398 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SmallWorm _0024self__00242399;

			public _0024(SmallWorm self_)
			{
				_0024self__00242399 = self_;
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
					_0024self__00242399.time = Random.Range(8, 11);
					_0024self__00242399.curVector = _0024self__00242399.player.transform.position - _0024self__00242399.t.position;
					_0024self__00242399.attacking = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00242399.time)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242399.attacking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SmallWorm _0024self__00242400;

		public _0024Attack_00242398(SmallWorm self_)
		{
			_0024self__00242400 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242400);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00242401 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242402;

			internal int _0024dmg_00242403;

			internal SmallWorm _0024self__00242404;

			public _0024(int dmg, SmallWorm self_)
			{
				_0024dmg_00242403 = dmg;
				_0024self__00242404 = self_;
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
					if (!_0024self__00242404.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00242404.takingDamage = true;
							_0024self__00242404.HP -= _0024dmg_00242403;
							_0024n2_00242402 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242404.t.position, Quaternion.identity);
							_0024n2_00242402.SendMessage("SD", (object)_0024dmg_00242403);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00242404).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00242403 });
						((Component)_0024self__00242404).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00242403 });
					}
					goto IL_016a;
				case 2:
					if (_0024self__00242404.HP < 1)
					{
						_0024self__00242404.Die();
						goto IL_016a;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242404.takingDamage = false;
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

		internal int _0024dmg_00242405;

		internal SmallWorm _0024self__00242406;

		public _0024TD_00242401(int dmg, SmallWorm self_)
		{
			_0024dmg_00242405 = dmg;
			_0024self__00242406 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242405, _0024self__00242406);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242407 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024dmg_00242408;

			internal SmallWorm _0024self__00242409;

			public _0024(int dmg, SmallWorm self_)
			{
				_0024dmg_00242408 = dmg;
				_0024self__00242409 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242409.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242409.HP -= _0024dmg_00242408;
					if (_0024self__00242409.HP < 1)
					{
						_0024self__00242409.Die();
					}
					else
					{
						_0024self__00242409.takingDamage = false;
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

		internal int _0024dmg_00242410;

		internal SmallWorm _0024self__00242411;

		public _0024TDN_00242407(int dmg, SmallWorm self_)
		{
			_0024dmg_00242410 = dmg;
			_0024self__00242411 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242410, _0024self__00242411);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242412 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242413;

			internal int _0024dmg_00242414;

			internal SmallWorm _0024self__00242415;

			public _0024(int dmg, SmallWorm self_)
			{
				_0024dmg_00242414 = dmg;
				_0024self__00242415 = self_;
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
					_0024n2_00242413 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242415.t.position, Quaternion.identity);
					_0024n2_00242413.SendMessage("SD", (object)_0024dmg_00242414);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					if (_0024self__00242415.HP < 1)
					{
						goto IL_00dc;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242415.takingDamage = false;
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

		internal int _0024dmg_00242416;

		internal SmallWorm _0024self__00242417;

		public _0024TDN2_00242412(int dmg, SmallWorm self_)
		{
			_0024dmg_00242416 = dmg;
			_0024self__00242417 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242416, _0024self__00242417);
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
		return new _0024Start_00242391(this).GetEnumerator();
	}

	public override IEnumerator Initialize()
	{
		return new _0024Initialize_00242395(this).GetEnumerator();
	}

	public override IEnumerator Attack()
	{
		return new _0024Attack_00242398(this).GetEnumerator();
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
		return new _0024TD_00242401(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242407(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242412(dmg, this).GetEnumerator();
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