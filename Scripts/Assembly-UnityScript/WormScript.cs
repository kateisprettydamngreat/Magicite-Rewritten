using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class WormScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242740 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242741;

			internal WormScript _0024self__00242742;

			public _0024(WormScript self_)
			{
				_0024self__00242742 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242742.HP = _0024self__00242742.maxHP;
					_0024self__00242742.drops = new int[3] { 7, 18, 0 };
					_0024self__00242742.t = _0024self__00242742.transform;
					_0024self__00242742.StartCoroutine_Auto(_0024self__00242742.Initialize());
					if (_0024self__00242742.isHead)
					{
						_0024i_00242741 = default(int);
						_0024self__00242742.mainHead.GetComponent<Animation>().Play();
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
				case 2:
					_0024i_00242741 = 0;
					goto IL_0112;
				case 3:
					_0024i_00242741++;
					goto IL_0112;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0112:
					if (_0024i_00242741 < 7)
					{
						_0024self__00242742.parts[_0024i_00242741].GetComponent<Animation>().Play("wBody");
						result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
					IL_011e:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal WormScript _0024self__00242743;

		public _0024Start_00242740(WormScript self_)
		{
			_0024self__00242743 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242743);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Initialize_00242744 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WormScript _0024self__00242745;

			public _0024(WormScript self_)
			{
				_0024self__00242745 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242745.isHead)
					{
						_0024self__00242745.GetComponent<NetworkView>().RPC("SetHead", RPCMode.All);
						_0024self__00242745.speed = 10f;
						result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						break;
					}
					goto IL_007e;
				case 2:
					_0024self__00242745.StartCoroutine_Auto(_0024self__00242745.Attack());
					goto IL_007e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_007e:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal WormScript _0024self__00242746;

		public _0024Initialize_00242744(WormScript self_)
		{
			_0024self__00242746 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242746);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242747 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WormScript _0024self__00242748;

			public _0024(WormScript self_)
			{
				_0024self__00242748 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if ((bool)_0024self__00242748.player)
					{
						if (Network.isServer)
						{
							_0024self__00242748.time = UnityEngine.Random.Range(8, 11);
							_0024self__00242748.curVector = _0024self__00242748.player.transform.position - _0024self__00242748.t.position;
							_0024self__00242748.attacking = true;
							result = (Yield(2, new WaitForSeconds(_0024self__00242748.time)) ? 1 : 0);
						}
						else
						{
							result = (Yield(3, new WaitForSeconds(_0024self__00242748.time)) ? 1 : 0);
						}
						break;
					}
					goto case 3;
				case 2:
					_0024self__00242748.attacking = false;
					goto case 3;
				case 3:
					result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal WormScript _0024self__00242749;

		public _0024Attack_00242747(WormScript self_)
		{
			_0024self__00242749 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242749);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242750 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024dmg_00242751;

			internal WormScript _0024self__00242752;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242751 = dmg;
				_0024self__00242752 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242752.takingDamage = true;
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242752.HP -= _0024dmg_00242751;
					if (_0024self__00242752.HP < 1)
					{
						_0024self__00242752.Die();
					}
					else
					{
						_0024self__00242752.takingDamage = false;
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

		internal int _0024dmg_00242753;

		internal WormScript _0024self__00242754;

		public _0024TDN_00242750(int dmg, WormScript self_)
		{
			_0024dmg_00242753 = dmg;
			_0024self__00242754 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dmg_00242753, _0024self__00242754);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242755 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242756;

			internal int _0024dmg_00242757;

			internal WormScript _0024self__00242758;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242757 = dmg;
				_0024self__00242758 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024n2_00242756 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242758.t.position, Quaternion.identity);
					_0024n2_00242756.SendMessage("SD", _0024dmg_00242757);
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					if (_0024self__00242758.HP < 1)
					{
						goto IL_00dc;
					}
					result = (Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242758.takingDamage = false;
					goto IL_00dc;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00dc:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242759;

		internal WormScript _0024self__00242760;

		public _0024TDN2_00242755(int dmg, WormScript self_)
		{
			_0024dmg_00242759 = dmg;
			_0024self__00242760 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dmg_00242759, _0024self__00242760);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KN_00242761 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00242762;

			internal int _0024_00241003_00242763;

			internal Vector3 _0024_00241004_00242764;

			internal int _0024_00241005_00242765;

			internal Vector3 _0024_00241006_00242766;

			internal int _0024_00241007_00242767;

			internal Vector3 _0024_00241008_00242768;

			internal int _0024_00241009_00242769;

			internal Vector3 _0024_00241010_00242770;

			internal bool _0024l_00242771;

			internal WormScript _0024self__00242772;

			public _0024(bool l, WormScript self_)
			{
				_0024l_00242771 = l;
				_0024self__00242772 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242772.knocking = true;
					_0024wasK_00242762 = default(bool);
					if (_0024self__00242772.GetComponent<Rigidbody>().isKinematic)
					{
						_0024wasK_00242762 = true;
						_0024self__00242772.GetComponent<Rigidbody>().isKinematic = false;
					}
					if (_0024l_00242771)
					{
						int num = (_0024_00241003_00242763 = -15);
						Vector3 vector = (_0024_00241004_00242764 = _0024self__00242772.GetComponent<Rigidbody>().velocity);
						float num2 = (_0024_00241004_00242764.x = _0024_00241003_00242763);
						Vector3 vector3 = (_0024self__00242772.GetComponent<Rigidbody>().velocity = _0024_00241004_00242764);
						int num3 = (_0024_00241005_00242765 = 10);
						Vector3 vector4 = (_0024_00241006_00242766 = _0024self__00242772.GetComponent<Rigidbody>().velocity);
						float num4 = (_0024_00241006_00242766.y = _0024_00241005_00242765);
						Vector3 vector6 = (_0024self__00242772.GetComponent<Rigidbody>().velocity = _0024_00241006_00242766);
						result = (Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_00241007_00242767 = 15);
						Vector3 vector7 = (_0024_00241008_00242768 = _0024self__00242772.GetComponent<Rigidbody>().velocity);
						float num6 = (_0024_00241008_00242768.x = _0024_00241007_00242767);
						Vector3 vector9 = (_0024self__00242772.GetComponent<Rigidbody>().velocity = _0024_00241008_00242768);
						int num7 = (_0024_00241009_00242769 = 10);
						Vector3 vector10 = (_0024_00241010_00242770 = _0024self__00242772.GetComponent<Rigidbody>().velocity);
						float num8 = (_0024_00241010_00242770.y = _0024_00241009_00242769);
						Vector3 vector12 = (_0024self__00242772.GetComponent<Rigidbody>().velocity = _0024_00241010_00242770);
						result = (Yield(3, new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242772.knocking = false;
					if (_0024wasK_00242762)
					{
						_0024self__00242772.GetComponent<Rigidbody>().isKinematic = true;
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

		internal bool _0024l_00242773;

		internal WormScript _0024self__00242774;

		public _0024KN_00242761(bool l, WormScript self_)
		{
			_0024l_00242773 = l;
			_0024self__00242774 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new _0024(_0024l_00242773, _0024self__00242774);
		}
	}

	public bool isBase;

	public bool isHead;

	public GameObject head;

	public float speed;

	public float space;

	public float time;

	public GameObject mainHead;

	public Material leadHead;

	public GameObject[] parts;

	public GameObject[] parts2;

	private bool knocking;

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

	public WormScript()
	{
		parts = new GameObject[5];
		parts2 = new GameObject[7];
		maxHP = 1;
		GOLD = 20;
		drops = new int[3];
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242740(this).GetEnumerator();
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
		int num = default(int);
		if (!isBase)
		{
			return;
		}
		for (num = 0; num < parts2.Length; num++)
		{
			if ((bool)parts2[num])
			{
				parts2[num].SendMessage("SetPlayer", g);
			}
		}
		StartCoroutine_Auto(Attack());
	}

	[RPC]
	public virtual void SetHead()
	{
		mainHead.GetComponent<Renderer>().material = leadHead;
		mainHead.GetComponent<Animation>().Play("wHead");
	}

	public virtual IEnumerator Initialize()
	{
		return new _0024Initialize_00242744(this).GetEnumerator();
	}

	public virtual IEnumerator Attack()
	{
		return new _0024Attack_00242747(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (!head)
		{
			head = gameObject;
			isHead = true;
			StartCoroutine_Auto(Initialize());
		}
		if (isHead)
		{
			if ((bool)player && attacking && Network.isServer)
			{
				t.Translate(curVector.normalized * speed * Time.deltaTime);
			}
		}
		else if (Network.isServer)
		{
			if (!(Mathf.Abs(head.transform.position.x - t.position.x) <= space))
			{
				t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
			}
			if (!(Mathf.Abs(head.transform.position.y - t.position.y) <= space))
			{
				t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
			}
		}
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
		return new _0024TDN_00242750(dmg, this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242755(dmg, this).GetEnumerator();
	}

	public virtual void Die()
	{
		GameObject gameObject = null;
		int num = default(int);
		Item item = null;
		for (num = 0; num < GOLD; num++)
		{
			Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
		}
		if (drops[0] > 0 && UnityEngine.Random.Range(0, 2) == 0)
		{
			int num2 = UnityEngine.Random.Range(1, 3);
			item = new Item(drops[0], 1, new int[6], 0f, null);
			for (num = 0; num < num2; num++)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetID", RPCMode.All, item.id);
				gameObject.GetComponent<NetworkView>().RPC("SetD", RPCMode.All, item.d);
				gameObject.GetComponent<NetworkView>().RPC("SetE", RPCMode.All, item.e);
			}
		}
		if (drops[1] > 0 && UnityEngine.Random.Range(0, 4) == 0)
		{
			int num3 = UnityEngine.Random.Range(1, 3);
			item = new Item(drops[1], 1, new int[6], 0f, null);
			for (num = 0; num < num3; num++)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetID", RPCMode.All, item.id);
				gameObject.GetComponent<NetworkView>().RPC("SetD", RPCMode.All, item.d);
				gameObject.GetComponent<NetworkView>().RPC("SetE", RPCMode.All, item.e);
			}
		}
		if (Network.isServer)
		{
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
			Network.Destroy(GetComponent<NetworkView>().viewID);
		}
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			c.SendMessage("TD", 18);
		}
	}

	public virtual void K(bool l)
	{
		GetComponent<NetworkView>().RPC("KN", RPCMode.All, l);
	}

	[RPC]
	public virtual IEnumerator KN(bool l)
	{
		return new _0024KN_00242761(l, this).GetEnumerator();
	}

	}