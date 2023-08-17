using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EnemyScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SetStatsN_00241368 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024hp_00241369;

			internal int _0024atk_00241370;

			internal EnemyScript _0024self__00241371;

			public _0024(int hp, int atk, EnemyScript self_)
			{
				_0024hp_00241369 = hp;
				_0024atk_00241370 = atk;
				_0024self__00241371 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241371.MAXHP = _0024hp_00241369;
					_0024self__00241371.HP = _0024hp_00241369;
					_0024self__00241371.ATK = _0024atk_00241370;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024hp_00241372;

		internal int _0024atk_00241373;

		internal EnemyScript _0024self__00241374;

		public _0024SetStatsN_00241368(int hp, int atk, EnemyScript self_)
		{
			_0024hp_00241372 = hp;
			_0024atk_00241373 = atk;
			_0024self__00241374 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024hp_00241372, _0024atk_00241373, _0024self__00241374);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241375 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal EnemyScript _0024self__00241376;

			public _0024(EnemyScript self_)
			{
				_0024self__00241376 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241376.exiling)
					{
						_0024self__00241376.exiling = true;
						_0024self__00241376.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00241376.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00241376.GetComponent<NetworkView>().viewID);
					goto IL_008f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_008f:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal EnemyScript _0024self__00241377;

		public _0024Exile_00241375(EnemyScript self_)
		{
			_0024self__00241377 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241377);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock22_00241378 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024wasK_00241379;

			internal int _0024_0024495_00241380;

			internal Vector3 _0024_0024496_00241381;

			internal int _0024_0024497_00241382;

			internal Vector3 _0024_0024498_00241383;

			internal int _0024_0024499_00241384;

			internal Vector3 _0024_0024500_00241385;

			internal Vector3 _0024p_00241386;

			internal EnemyScript _0024self__00241387;

			public _0024(Vector3 p, EnemyScript self_)
			{
				_0024p_00241386 = p;
				_0024self__00241387 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					_0024wasK_00241379 = default(bool);
					if (_0024self__00241387.r.isKinematic)
					{
						_0024wasK_00241379 = true;
						_0024self__00241387.GetComponent<Rigidbody>().isKinematic = false;
					}
					int num = (_0024_0024495_00241380 = 2);
					Vector3 vector = (_0024_0024496_00241381 = _0024self__00241387.GetComponent<Rigidbody>().velocity);
					float num2 = (_0024_0024496_00241381.y = _0024_0024495_00241380);
					Vector3 vector3 = (_0024self__00241387.GetComponent<Rigidbody>().velocity = _0024_0024496_00241381);
					if (_0024p_00241386.x <= _0024self__00241387.t.position.x)
					{
						int num3 = (_0024_0024499_00241384 = 10);
						Vector3 vector4 = (_0024_0024500_00241385 = _0024self__00241387.GetComponent<Rigidbody>().velocity);
						float num4 = (_0024_0024500_00241385.x = _0024_0024499_00241384);
						Vector3 vector6 = (_0024self__00241387.GetComponent<Rigidbody>().velocity = _0024_0024500_00241385);
					}
					else
					{
						int num5 = (_0024_0024497_00241382 = -10);
						Vector3 vector7 = (_0024_0024498_00241383 = _0024self__00241387.GetComponent<Rigidbody>().velocity);
						float num6 = (_0024_0024498_00241383.x = _0024_0024497_00241382);
						Vector3 vector9 = (_0024self__00241387.GetComponent<Rigidbody>().velocity = _0024_0024498_00241383);
					}
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
					if (_0024wasK_00241379)
					{
						_0024self__00241387.GetComponent<Rigidbody>().isKinematic = true;
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024p_00241388;

		internal EnemyScript _0024self__00241389;

		public _0024Knock22_00241378(Vector3 p, EnemyScript self_)
		{
			_0024p_00241388 = p;
			_0024self__00241389 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024p_00241388, _0024self__00241389);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00241390 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024501_00241391;

			internal Vector3 _0024_0024502_00241392;

			internal int _0024_0024503_00241393;

			internal Vector3 _0024_0024504_00241394;

			internal int _0024_0024505_00241395;

			internal Vector3 _0024_0024506_00241396;

			internal int _0024_0024507_00241397;

			internal Vector3 _0024_0024508_00241398;

			internal Vector3 _0024p_00241399;

			internal EnemyScript _0024self__00241400;

			public _0024(Vector3 p, EnemyScript self_)
			{
				_0024p_00241399 = p;
				_0024self__00241400 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					int num3 = (_0024_0024501_00241391 = 2);
					Vector3 vector4 = (_0024_0024502_00241392 = _0024self__00241400.GetComponent<Rigidbody>().velocity);
					float num4 = (_0024_0024502_00241392.y = _0024_0024501_00241391);
					Vector3 vector6 = (_0024self__00241400.GetComponent<Rigidbody>().velocity = _0024_0024502_00241392);
					if (_0024p_00241399.x <= _0024self__00241400.t.position.x)
					{
						int num5 = (_0024_0024505_00241395 = 10);
						Vector3 vector7 = (_0024_0024506_00241396 = _0024self__00241400.GetComponent<Rigidbody>().velocity);
						float num6 = (_0024_0024506_00241396.x = _0024_0024505_00241395);
						Vector3 vector9 = (_0024self__00241400.GetComponent<Rigidbody>().velocity = _0024_0024506_00241396);
					}
					else
					{
						int num7 = (_0024_0024503_00241393 = -10);
						Vector3 vector10 = (_0024_0024504_00241394 = _0024self__00241400.GetComponent<Rigidbody>().velocity);
						float num8 = (_0024_0024504_00241394.x = _0024_0024503_00241393);
						Vector3 vector12 = (_0024self__00241400.GetComponent<Rigidbody>().velocity = _0024_0024504_00241394);
					}
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					int num = (_0024_0024507_00241397 = 0);
					Vector3 vector = (_0024_0024508_00241398 = _0024self__00241400.GetComponent<Rigidbody>().velocity);
					float num2 = (_0024_0024508_00241398.x = _0024_0024507_00241397);
					Vector3 vector3 = (_0024self__00241400.GetComponent<Rigidbody>().velocity = _0024_0024508_00241398);
					YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024p_00241401;

		internal EnemyScript _0024self__00241402;

		public _0024KnockN_00241390(Vector3 p, EnemyScript self_)
		{
			_0024p_00241401 = p;
			_0024self__00241402 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024p_00241401, _0024self__00241402);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00241403 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n3_00241404;

			internal int _0024_0024509_00241405;

			internal Vector3 _0024_0024510_00241406;

			internal int _0024_0024511_00241407;

			internal Vector3 _0024_0024512_00241408;

			internal int _0024dmg_00241409;

			internal EnemyScript _0024self__00241410;

			public _0024(int dmg, EnemyScript self_)
			{
				_0024dmg_00241409 = dmg;
				_0024self__00241410 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024n3_00241404 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241410.t.position, Quaternion.identity);
					_0024n3_00241404.SendMessage("SDN", _0024dmg_00241409);
					_0024self__00241410.takingDamage = true;
					_0024self__00241410.e.GetComponent<Animation>().Play();
					_0024self__00241410.HP -= _0024dmg_00241409;
					if (Network.isServer && _0024self__00241410.bossID == 99 && _0024self__00241410.HP < 1000 && !_0024self__00241410.sworded)
					{
						_0024self__00241410.sworded = true;
						_0024self__00241410.sword3 = (GameObject)Network.Instantiate(Resources.Load("ghostSword"), _0024self__00241410.t.position, Quaternion.identity, 0);
						_0024self__00241410.sword3.SendMessage("Set", _0024self__00241410.gameObject);
					}
					if (_0024self__00241410.HP < 1)
					{
						_0024self__00241410.StartCoroutine_Auto(_0024self__00241410.Die());
					}
					else
					{
						_0024self__00241410.takingDamage = false;
					}
					_0024self__00241410.e.GetComponent<Animation>().Play();
					if (!_0024self__00241410.GetComponent<Rigidbody>().isKinematic)
					{
						int num3 = (_0024_0024509_00241405 = 0);
						Vector3 vector4 = (_0024_0024510_00241406 = _0024self__00241410.GetComponent<Rigidbody>().velocity);
						float num4 = (_0024_0024510_00241406.x = _0024_0024509_00241405);
						Vector3 vector6 = (_0024self__00241410.GetComponent<Rigidbody>().velocity = _0024_0024510_00241406);
					}
					if (_0024self__00241410.HP < 1)
					{
						goto IL_02be;
					}
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241410.e.GetComponent<Animation>().Stop();
					_0024self__00241410.takingDamage = false;
					int num = (_0024_0024511_00241407 = 0);
					Vector3 vector = (_0024_0024512_00241408 = _0024self__00241410.e.transform.localPosition);
					float num2 = (_0024_0024512_00241408.z = _0024_0024511_00241407);
					Vector3 vector3 = (_0024self__00241410.e.transform.localPosition = _0024_0024512_00241408);
					goto IL_02be;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_02be:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00241411;

		internal EnemyScript _0024self__00241412;

		public _0024TDN_00241403(int dmg, EnemyScript self_)
		{
			_0024dmg_00241411 = dmg;
			_0024self__00241412 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dmg_00241411, _0024self__00241412);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00241413 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024d_00241414;

			internal int _0024i_00241415;

			internal Item _0024item_00241416;

			internal int _0024ppp_00241417;

			internal EnemyScript _0024self__00241418;

			public _0024(EnemyScript self_)
			{
				_0024self__00241418 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241418.dyindood)
					{
						_0024d_00241414 = null;
						_0024i_00241415 = default(int);
						_0024item_00241416 = null;
						if (_0024self__00241418.isChicken && Network.isServer)
						{
							_0024ppp_00241417 = UnityEngine.Random.Range(0, 8);
							if (_0024ppp_00241417 == 0)
							{
								Network.Instantiate(Resources.Load("e/chickenKing"), new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
							}
						}
						if (_0024self__00241418.bossID > 0)
						{
							GameScript.tempStats[10] = GameScript.tempStats[10] + 1;
						}
						if (_0024self__00241418.bossID == 1)
						{
							MenuScript.canUnlockHat[8] = 1;
						}
						else if (_0024self__00241418.bossID == 2)
						{
							MenuScript.canUnlockHat[14] = 1;
						}
						else if (_0024self__00241418.bossID == 3)
						{
							MenuScript.canUnlockHat[18] = 1;
						}
						else if (_0024self__00241418.bossID == 4)
						{
							MenuScript.canUnlockHat[20] = 1;
						}
						else if (_0024self__00241418.bossID == 5)
						{
							MenuScript.canUnlockHat[21] = 1;
						}
						else if (_0024self__00241418.bossID == 6)
						{
							MenuScript.canUnlockHat[22] = 1;
						}
						else if (_0024self__00241418.bossID == 99 && Network.isServer)
						{
							_0024self__00241418.GetComponent<NetworkView>().RPC("DED", RPCMode.All);
						}
						GameScript.tempStats[1] = GameScript.tempStats[1] + 1;
						if (GameScript.tempStats[1] > 14)
						{
							MenuScript.canUnlockRace[1] = 1;
						}
						else if (GameScript.tempStats[1] >= 10)
						{
							MenuScript.canUnlockHat[3] = 1;
						}
						if (Network.isServer)
						{
							_0024self__00241418.GetComponent<NetworkView>().RPC("DropLocal", RPCMode.All);
						}
						if (Network.isServer)
						{
							if (_0024self__00241418.bossID == 99)
							{
								_0024self__00241418.dyindood = true;
								result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
							goto case 2;
						}
					}
					goto IL_0264;
				case 2:
					_0024self__00241418.StartCoroutine_Auto(_0024self__00241418.Exile());
					goto IL_0264;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0264:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal EnemyScript _0024self__00241419;

		public _0024Die_00241413(EnemyScript self_)
		{
			_0024self__00241419 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241419);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KN_00241420 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00241421;

			internal int _0024_0024513_00241422;

			internal Vector3 _0024_0024514_00241423;

			internal int _0024_0024515_00241424;

			internal Vector3 _0024_0024516_00241425;

			internal int _0024_0024517_00241426;

			internal Vector3 _0024_0024518_00241427;

			internal int _0024_0024519_00241428;

			internal Vector3 _0024_0024520_00241429;

			internal bool _0024l_00241430;

			internal EnemyScript _0024self__00241431;

			public _0024(bool l, EnemyScript self_)
			{
				_0024l_00241430 = l;
				_0024self__00241431 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241431.knocking = true;
					_0024wasK_00241421 = default(bool);
					if (_0024self__00241431.r.isKinematic)
					{
						_0024wasK_00241421 = true;
						_0024self__00241431.r.isKinematic = false;
					}
					if (_0024l_00241430)
					{
						int num = (_0024_0024513_00241422 = -15);
						Vector3 vector = (_0024_0024514_00241423 = _0024self__00241431.r.velocity);
						float num2 = (_0024_0024514_00241423.x = _0024_0024513_00241422);
						Vector3 vector3 = (_0024self__00241431.r.velocity = _0024_0024514_00241423);
						int num3 = (_0024_0024515_00241424 = 10);
						Vector3 vector4 = (_0024_0024516_00241425 = _0024self__00241431.r.velocity);
						float num4 = (_0024_0024516_00241425.y = _0024_0024515_00241424);
						Vector3 vector6 = (_0024self__00241431.r.velocity = _0024_0024516_00241425);
						result = (Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024517_00241426 = 15);
						Vector3 vector7 = (_0024_0024518_00241427 = _0024self__00241431.r.velocity);
						float num6 = (_0024_0024518_00241427.x = _0024_0024517_00241426);
						Vector3 vector9 = (_0024self__00241431.r.velocity = _0024_0024518_00241427);
						int num7 = (_0024_0024519_00241428 = 10);
						Vector3 vector10 = (_0024_0024520_00241429 = _0024self__00241431.r.velocity);
						float num8 = (_0024_0024520_00241429.y = _0024_0024519_00241428);
						Vector3 vector12 = (_0024self__00241431.r.velocity = _0024_0024520_00241429);
						result = (Yield(3, new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241431.knocking = false;
					if (_0024wasK_00241421)
					{
						_0024self__00241431.r.isKinematic = true;
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00241432;

		internal EnemyScript _0024self__00241433;

		public _0024KN_00241420(bool l, EnemyScript self_)
		{
			_0024l_00241432 = l;
			_0024self__00241433 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new _0024(_0024l_00241432, _0024self__00241433);
		}
	}

	public bool isChicken;

	public int bossID;

	public AudioClip a;

	public AudioClip aHit;

	public GameObject @base;

	public GameObject e;

	public bool moving;

	public int dir;

	public int HP;

	public int MAXHP;

	public int ATK;

	public int DEF;

	public int EXP;

	public int SPD;

	public int[] drops;

	public Transform t;

	public bool takingDamage;

	public Rigidbody r;

	private int GOLD;

	private int exp;

	public bool attacking;

	public bool knocking;

	private float poisonDMG;

	private bool dyindood;

	private GameObject sword3;

	private GameObject sword4;

	private bool sworded;

	private bool exiling;

	public EnemyScript()
	{
		drops = new int[3];
	}

	public virtual void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
	}

	[RPC]
	public virtual IEnumerator SetStatsN(int hp, int atk)
	{
		return new _0024SetStatsN_00241368(hp, atk, this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241375(this).GetEnumerator();
	}

	public virtual void SetStats(int HP, int ATK, int DEF, int EXP, float SPD, int[] drops, int coins, int exp)
	{
		MAXHP = HP;
		this.HP = MAXHP;
		this.ATK = ATK;
		this.DEF = DEF;
		this.EXP = EXP;
		this.SPD = (int)SPD;
		this.drops = drops;
		GOLD = coins;
		this.exp = exp;
		poisonDMG = MAXHP;
		poisonDMG *= 0.2f;
		MAXHP = (int)((float)MAXHP + (float)HP * 0.5f * (float)Network.connections.Length);
		this.ATK = (int)((float)this.ATK + (float)ATK * 0.4f * (float)Network.connections.Length);
		GetComponent<NetworkView>().RPC("SetStatsN", RPCMode.All, MAXHP, this.ATK);
	}

	public virtual void Update()
	{
		if (!attacking && !knocking)
		{
			if (dir == 1 && moving)
			{
				@base.GetComponent<Animation>().Play("r");
				int num = -SPD;
				Vector3 velocity = GetComponent<Rigidbody>().velocity;
				float num2 = (velocity.x = num);
				Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
				e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			}
			else if (dir == 2 && moving)
			{
				@base.GetComponent<Animation>().Play("r");
				int sPD = SPD;
				Vector3 velocity2 = GetComponent<Rigidbody>().velocity;
				float num3 = (velocity2.x = sPD);
				Vector3 vector4 = (GetComponent<Rigidbody>().velocity = velocity2);
				e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			else
			{
				@base.GetComponent<Animation>().Play("i");
			}
		}
	}

	public virtual void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.layer == 8)
		{
			c.gameObject.SendMessage("TD", ATK);
		}
	}

	public virtual IEnumerator Knock22(Vector3 p)
	{
		return new _0024Knock22_00241378(p, this).GetEnumerator();
	}

	public virtual void Knock(Vector3 p)
	{
		GetComponent<NetworkView>().RPC("KnockN", RPCMode.All, p);
	}

	[RPC]
	public virtual IEnumerator KnockN(Vector3 p)
	{
		return new _0024KnockN_00241390(p, this).GetEnumerator();
	}

	public virtual void TD(int dmg)
	{
		if (!takingDamage)
		{
			GetComponent<AudioSource>().PlayOneShot(aHit);
			int num = dmg;
			if (num < 1)
			{
				num = 1;
			}
			GetComponent<NetworkView>().RPC("TDN", RPCMode.All, num);
		}
	}

	[RPC]
	public virtual IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00241403(dmg, this).GetEnumerator();
	}

	[RPC]
	public virtual void DED()
	{
		MenuScript.canUnlockRace[14] = 1;
		GameObject gameObject = GameObject.Find("musicBox");
		gameObject.SendMessage("SetNormal");
	}

	public virtual IEnumerator Die()
	{
		return new _0024Die_00241413(this).GetEnumerator();
	}

	[RPC]
	public virtual void DropLocal()
	{
		int num = default(int);
		Item item = null;
		GameObject gameObject = null;
		int[] array = null;
		for (num = 0; num < GOLD; num++)
		{
			UnityEngine.Object.Instantiate(Resources.Load("c"), t.position, Quaternion.identity);
		}
		int num2 = exp;
		while (num2 >= 20)
		{
			num2 -= 20;
			UnityEngine.Object.Instantiate(Resources.Load("expHuge"), t.position, Quaternion.identity);
		}
		while (num2 >= 8)
		{
			num2 -= 8;
			UnityEngine.Object.Instantiate(Resources.Load("expBig"), t.position, Quaternion.identity);
		}
		for (num = 0; num < num2; num++)
		{
			UnityEngine.Object.Instantiate(Resources.Load("exp"), t.position, Quaternion.identity);
		}
		if (drops[0] > 0 && UnityEngine.Random.Range(0, 2) == 0)
		{
			int num3 = UnityEngine.Random.Range(1, 3);
			for (num = 0; num < num3; num++)
			{
				item = new Item(drops[0], 1, new int[4], 0f, null);
				if (item.id == 566)
				{
					item.e = new int[4] { -3, 100, 0, 0 };
					item.d = 100;
				}
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
				array = new int[7]
				{
					item.id,
					item.q,
					item.e[0],
					item.e[1],
					item.e[2],
					item.e[3],
					item.d
				};
				gameObject.SendMessage("InitL", array);
			}
		}
		if (drops[1] > 0 && UnityEngine.Random.Range(0, 4) == 0)
		{
			int num4 = UnityEngine.Random.Range(1, 3);
			item = new Item(drops[1], 1, new int[2], 0f, null);
			for (num = 0; num < num4; num++)
			{
				if (item.id == 566)
				{
					item.e = new int[4] { -3, 100, 0, 0 };
					item.d = 100;
				}
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
				array = new int[7] { item.id, item.q, 0, 0, 0, 0, item.d };
				gameObject.SendMessage("InitL", array);
			}
		}
		if (drops[2] > 0 && UnityEngine.Random.Range(0, 8) == 0)
		{
			int num5 = UnityEngine.Random.Range(1, 3);
			item = new Item(drops[2], 1, new int[4], 0f, null);
			if (item.id == 566)
			{
				item.e = new int[4] { -3, 100, 0, 0 };
				item.d = 100;
			}
			for (num = 0; num < num5; num++)
			{
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
				array = new int[7]
				{
					item.id,
					item.q,
					item.e[0],
					item.e[1],
					item.e[2],
					item.e[3],
					item.d
				};
				gameObject.SendMessage("InitL", array);
			}
		}
	}

	[RPC]
	public virtual IEnumerator KN(bool l)
	{
		return new _0024KN_00241420(l, this).GetEnumerator();
	}

	public virtual void K(bool l)
	{
		GetComponent<NetworkView>().RPC("KN", RPCMode.All, l);
	}

	public virtual void TDp()
	{
		int dmg = (int)poisonDMG;
		TD(dmg);
	}

	public virtual void Main()
	{
	}
}
