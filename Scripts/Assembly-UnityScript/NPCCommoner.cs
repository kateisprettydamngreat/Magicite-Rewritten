using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class NPCCommoner : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Talk_00242031 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCCommoner _0024self__00242032;

			public _0024(NPCCommoner self_)
			{
				_0024self__00242032 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(5, 20))) ? 1 : 0);
					break;
				case 2:
					result = (Yield(3, new WaitForSeconds(UnityEngine.Random.Range(0, 6))) ? 1 : 0);
					break;
				case 3:
					if (Network.isServer)
					{
						_0024self__00242032.GetComponent<NetworkView>().RPC("SaySomething", RPCMode.All, UnityEngine.Random.Range(0, 10));
					}
					result = (Yield(4, new WaitForSeconds(UnityEngine.Random.Range(0, 6))) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal NPCCommoner _0024self__00242033;

		public _0024Talk_00242031(NPCCommoner self_)
		{
			_0024self__00242033 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242033);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SaySomething_00242034 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00242035;

			internal int _0024_0024switch_0024372_00242036;

			internal int _0024a_00242037;

			internal NPCCommoner _0024self__00242038;

			public _0024(int a, NPCCommoner self_)
			{
				_0024a_00242037 = a;
				_0024self__00242038 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024s_00242035 = null;
					_0024_0024switch_0024372_00242036 = _0024a_00242037;
					if (_0024_0024switch_0024372_00242036 == 0)
					{
						_0024s_00242035 = "Life is great.";
					}
					else if (_0024_0024switch_0024372_00242036 == 1)
					{
						_0024s_00242035 = "Deephaven is scary.";
					}
					else if (_0024_0024switch_0024372_00242036 == 2)
					{
						_0024s_00242035 = "I'm hungry";
					}
					else if (_0024_0024switch_0024372_00242036 == 3)
					{
						_0024s_00242035 = "I hate chicken.";
					}
					else if (_0024_0024switch_0024372_00242036 == 4)
					{
						_0024s_00242035 = "The Scourge suck!";
					}
					else if (_0024_0024switch_0024372_00242036 == 5)
					{
						_0024s_00242035 = "I miss the sun...";
					}
					else if (_0024_0024switch_0024372_00242036 == 6)
					{
						_0024s_00242035 = "*Cough*";
					}
					else if (_0024_0024switch_0024372_00242036 == 7)
					{
						_0024s_00242035 = "Someone smells funny.";
					}
					else if (_0024_0024switch_0024372_00242036 == 8)
					{
						_0024s_00242035 = "Idk what I want.";
					}
					else if (_0024_0024switch_0024372_00242036 == 9)
					{
						_0024s_00242035 = "I need to poop!";
					}
					_0024self__00242038.txtTalk.text = string.Empty + _0024s_00242035;
					_0024self__00242038.txtTalk2.text = string.Empty + _0024s_00242035;
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242038.txtTalk.text = string.Empty;
					_0024self__00242038.txtTalk2.text = string.Empty;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242039;

		internal NPCCommoner _0024self__00242040;

		public _0024SaySomething_00242034(int a, NPCCommoner self_)
		{
			_0024a_00242039 = a;
			_0024self__00242040 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00242039, _0024self__00242040);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242041 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal NPCCommoner _0024self__00242042;

			public _0024(NPCCommoner self_)
			{
				_0024self__00242042 = self_;
			}

			public override bool MoveNext()
			{
				return _state switch
				{
					1 => false, 
					_ => Yield(2, _0024self__00242042.StartCoroutine_Auto(_0024self__00242042.Move())), 
				};
			}
		}

		internal NPCCommoner _0024self__00242043;

		public _0024Start_00242041(NPCCommoner self_)
		{
			_0024self__00242043 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00242043);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242044 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242045;

			internal int _0024dmg_00242046;

			internal NPCCommoner _0024self__00242047;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00242046 = dmg;
				_0024self__00242047 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242047.txtTalk.text = "Ow!";
					_0024self__00242047.takingDamage = true;
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242047.hp -= _0024dmg_00242046;
					_0024i_00242045 = default(int);
					if (_0024self__00242047.hp < 1)
					{
						for (_0024i_00242045 = 0; _0024i_00242045 < _0024self__00242047.GOLD; _0024i_00242045++)
						{
							Network.Instantiate(Resources.Load("c"), _0024self__00242047.t.position, Quaternion.identity, 0);
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(_0024self__00242047.GetComponent<NetworkView>().viewID);
							Network.Destroy(_0024self__00242047.GetComponent<NetworkView>().viewID);
						}
					}
					else
					{
						_0024self__00242047.takingDamage = false;
					}
					result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242047.txtTalk.text = string.Empty;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242048;

		internal NPCCommoner _0024self__00242049;

		public _0024TDN_00242044(int dmg, NPCCommoner self_)
		{
			_0024dmg_00242048 = dmg;
			_0024self__00242049 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dmg_00242048, _0024self__00242049);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242050 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242051;

			internal int _0024_0024673_00242052;

			internal Vector3 _0024_0024674_00242053;

			internal int _0024dmg_00242054;

			internal NPCCommoner _0024self__00242055;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00242054 = dmg;
				_0024self__00242055 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024n2_00242051 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242055.t.position, Quaternion.identity);
					_0024n2_00242051.SendMessage("SD", _0024dmg_00242054);
					_0024self__00242055.@base.GetComponent<Animation>().Play();
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242055.hp < 1)
					{
						goto IL_014c;
					}
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00242055.@base.GetComponent<Animation>().Stop();
					_0024self__00242055.takingDamage = false;
					int num = (_0024_0024673_00242052 = 0);
					Vector3 vector = (_0024_0024674_00242053 = _0024self__00242055.@base.transform.localPosition);
					float num2 = (_0024_0024674_00242053.z = _0024_0024673_00242052);
					Vector3 vector3 = (_0024self__00242055.@base.transform.localPosition = _0024_0024674_00242053);
					goto IL_014c;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_014c:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242056;

		internal NPCCommoner _0024self__00242057;

		public _0024TDN2_00242050(int dmg, NPCCommoner self_)
		{
			_0024dmg_00242056 = dmg;
			_0024self__00242057 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dmg_00242056, _0024self__00242057);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Move_00242058 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242059;

			internal NPCCommoner _0024self__00242060;

			public _0024(NPCCommoner self_)
			{
				_0024self__00242060 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024num_00242059 = UnityEngine.Random.Range(-1, 2);
					if (_0024num_00242059 != 0)
					{
						_0024self__00242060.speed *= (float)_0024num_00242059;
					}
					if (!(_0024self__00242060.speed <= 0f))
					{
						_0024self__00242060.npc.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						_0024self__00242060.npc.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					}
					_0024self__00242060.canMove = true;
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242060.canMove = false;
					_0024num_00242059 = UnityEngine.Random.Range(-1, 2);
					if (_0024num_00242059 != 0)
					{
						_0024self__00242060.speed *= (float)_0024num_00242059;
					}
					if (!(_0024self__00242060.speed <= 0f))
					{
						_0024self__00242060.npc.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						_0024self__00242060.npc.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					}
					result = (Yield(3, new WaitForSeconds(UnityEngine.Random.Range(1, 10))) ? 1 : 0);
					break;
				case 3:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal NPCCommoner _0024self__00242061;

		public _0024Move_00242058(NPCCommoner self_)
		{
			_0024self__00242061 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242061);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00242062 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024677_00242063;

			internal Vector3 _0024_0024678_00242064;

			internal int _0024_0024679_00242065;

			internal Vector3 _0024_0024680_00242066;

			internal int _0024_0024681_00242067;

			internal Vector3 _0024_0024682_00242068;

			internal Vector3 _0024p_00242069;

			internal NPCCommoner _0024self__00242070;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				_0024p_00242069 = p;
				_0024self__00242070 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024p_00242069.x <= _0024self__00242070.t.position.x)
					{
						int num3 = (_0024_0024679_00242065 = 10);
						Vector3 vector4 = (_0024_0024680_00242066 = _0024self__00242070.GetComponent<Rigidbody>().velocity);
						float num4 = (_0024_0024680_00242066.x = _0024_0024679_00242065);
						Vector3 vector6 = (_0024self__00242070.GetComponent<Rigidbody>().velocity = _0024_0024680_00242066);
					}
					else
					{
						int num5 = (_0024_0024677_00242063 = -10);
						Vector3 vector7 = (_0024_0024678_00242064 = _0024self__00242070.GetComponent<Rigidbody>().velocity);
						float num6 = (_0024_0024678_00242064.x = _0024_0024677_00242063);
						Vector3 vector9 = (_0024self__00242070.GetComponent<Rigidbody>().velocity = _0024_0024678_00242064);
					}
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024681_00242067 = 0);
					Vector3 vector = (_0024_0024682_00242068 = _0024self__00242070.GetComponent<Rigidbody>().velocity);
					float num2 = (_0024_0024682_00242068.x = _0024_0024681_00242067);
					Vector3 vector3 = (_0024self__00242070.GetComponent<Rigidbody>().velocity = _0024_0024682_00242068);
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

		internal Vector3 _0024p_00242071;

		internal NPCCommoner _0024self__00242072;

		public _0024KnockN_00242062(Vector3 p, NPCCommoner self_)
		{
			_0024p_00242071 = p;
			_0024self__00242072 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024p_00242071, _0024self__00242072);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242073 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00242074;

			internal int _0024_0024683_00242075;

			internal Vector3 _0024_0024684_00242076;

			internal int _0024_0024685_00242077;

			internal Vector3 _0024_0024686_00242078;

			internal int _0024_0024687_00242079;

			internal Vector3 _0024_0024688_00242080;

			internal int _0024_0024689_00242081;

			internal Vector3 _0024_0024690_00242082;

			internal bool _0024l_00242083;

			internal NPCCommoner _0024self__00242084;

			public _0024(bool l, NPCCommoner self_)
			{
				_0024l_00242083 = l;
				_0024self__00242084 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00242074 = default(int);
					if (_0024l_00242083)
					{
						int num = (_0024_0024683_00242075 = -10);
						Vector3 vector = (_0024_0024684_00242076 = _0024self__00242084.r.velocity);
						float num2 = (_0024_0024684_00242076.x = _0024_0024683_00242075);
						Vector3 vector3 = (_0024self__00242084.r.velocity = _0024_0024684_00242076);
						int num3 = (_0024_0024685_00242077 = 10);
						Vector3 vector4 = (_0024_0024686_00242078 = _0024self__00242084.r.velocity);
						float num4 = (_0024_0024686_00242078.y = _0024_0024685_00242077);
						Vector3 vector6 = (_0024self__00242084.r.velocity = _0024_0024686_00242078);
						result = (Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024687_00242079 = 10);
						Vector3 vector7 = (_0024_0024688_00242080 = _0024self__00242084.r.velocity);
						float num6 = (_0024_0024688_00242080.x = _0024_0024687_00242079);
						Vector3 vector9 = (_0024self__00242084.r.velocity = _0024_0024688_00242080);
						int num7 = (_0024_0024689_00242081 = 10);
						Vector3 vector10 = (_0024_0024690_00242082 = _0024self__00242084.r.velocity);
						float num8 = (_0024_0024690_00242082.y = _0024_0024689_00242081);
						Vector3 vector12 = (_0024self__00242084.r.velocity = _0024_0024690_00242082);
						result = (Yield(3, new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00242085;

		internal NPCCommoner _0024self__00242086;

		public _0024K_00242073(bool l, NPCCommoner self_)
		{
			_0024l_00242085 = l;
			_0024self__00242086 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return new _0024(_0024l_00242085, _0024self__00242086);
		}
	}

	private int pos;

	private Transform t;

	private int moving;

	private int maxHP;

	private int hp;

	private bool takingDamage;

	public GameObject @base;

	public GameObject base2;

	public float speed;

	public Transform npc;

	private Rigidbody r;

	private int GOLD;

	private bool canMove;

	private int race;

	public GameObject head2;

	public GameObject head;

	public TextMesh txtTalk;

	public TextMesh txtTalk2;

	public virtual void OnDestroy()
	{
		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
	}

	public virtual void Awake()
	{
		StartCoroutine_Auto(Talk());
		race = GetRace();
		int num = UnityEngine.Random.Range(1, 49);
		if (Network.isServer)
		{
			GetComponent<NetworkView>().RPC("SetAppearance", RPCMode.All, race, UnityEngine.Random.Range(0, 3));
		}
		base2.GetComponent<Animation>()["i"].speed = 0.7f;
		GOLD = UnityEngine.Random.Range(2, 6);
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		takingDamage = false;
		maxHP = 10;
		hp = maxHP;
		t = transform;
	}

	public virtual IEnumerator Talk()
	{
		return new _0024Talk_00242031(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator SaySomething(int a)
	{
		return new _0024SaySomething_00242034(a, this).GetEnumerator();
	}

	[RPC]
	public virtual void SetAppearance(int r, int v)
	{
		head.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + r + "h" + v);
	}

	public virtual int GetRace()
	{
		int num = UnityEngine.Random.Range(0, 100);
		int num2 = default(int);
		if (num < 40)
		{
			return 0;
		}
		if (num < 60)
		{
			return 1;
		}
		if (num < 70)
		{
			return 2;
		}
		if (num < 85)
		{
			return 3;
		}
		if (num < 90)
		{
			return 4;
		}
		if (num < 95)
		{
			return 5;
		}
		return 6;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242041(this).GetEnumerator();
	}

	public virtual void TD(int dmg)
	{
		if (!takingDamage)
		{
			GetComponent<NetworkView>().RPC("TDN", RPCMode.All, dmg);
			GetComponent<NetworkView>().RPC("TDN2", RPCMode.All, dmg);
		}
	}

	[RPC]
	public virtual IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242044(dmg, this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242050(dmg, this).GetEnumerator();
	}

	public virtual void Die()
	{
		int num = default(int);
		for (num = 0; num < GOLD; num++)
		{
			Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
		}
		if (Network.isServer)
		{
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
			Network.Destroy(gameObject);
		}
		else
		{
			GetComponent<NetworkView>().RPC("die", RPCMode.Server);
		}
	}

	public virtual void Update()
	{
		if (canMove)
		{
			float x = speed;
			Vector3 velocity = GetComponent<Rigidbody>().velocity;
			float num = (velocity.x = x);
			Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		}
	}

	public virtual IEnumerator Move()
	{
		return new _0024Move_00242058(this).GetEnumerator();
	}

	[RPC]
	public virtual void DieN(NetworkViewID id)
	{
		if (GetComponent<NetworkView>().viewID == id)
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	[RPC]
	public virtual void Initialize(NetworkViewID id)
	{
		GetComponent<NetworkView>().viewID = id;
	}

	public virtual void Knock(Vector3 p)
	{
		GetComponent<NetworkView>().RPC("KnockN", RPCMode.All, p);
	}

	[RPC]
	public virtual IEnumerator KnockN(Vector3 p)
	{
		return new _0024KnockN_00242062(p, this).GetEnumerator();
	}

	public virtual IEnumerator K(bool l)
	{
		return new _0024K_00242073(l, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
