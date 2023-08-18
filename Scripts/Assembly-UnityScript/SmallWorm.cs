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
	internal sealed class _0024Start_00242544 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242545;

			internal SmallWorm _0024self__00242546;

			public _0024(SmallWorm self_)
			{
				_0024self__00242546 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242546.HP = _0024self__00242546.maxHP;
					_0024self__00242546.drops = new int[3] { 7, 18, 0 };
					_0024self__00242546.t = _0024self__00242546.transform;
					_0024self__00242546.Initialize();
					if (_0024self__00242546.isHead)
					{
						_0024i_00242545 = default(int);
						_0024self__00242546.mainHead.GetComponent<Animation>().Play();
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_0112;
				case 2:
					_0024i_00242545 = 0;
					goto IL_0106;
				case 3:
					_0024i_00242545++;
					goto IL_0106;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0106:
					if (_0024i_00242545 < 5)
					{
						_0024self__00242546.parts[_0024i_00242545].GetComponent<Animation>().Play("wBody");
						result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_0112;
					IL_0112:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal SmallWorm _0024self__00242547;

		public _0024Start_00242544(SmallWorm self_)
		{
			_0024self__00242547 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242547);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242548 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SmallWorm _0024self__00242549;

			public _0024(SmallWorm self_)
			{
				_0024self__00242549 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242549.time = UnityEngine.Random.Range(8, 11);
					_0024self__00242549.curVector = _0024self__00242549.player.transform.position - _0024self__00242549.t.position;
					_0024self__00242549.attacking = true;
					result = (Yield(2, new WaitForSeconds(_0024self__00242549.time)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242549.attacking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SmallWorm _0024self__00242550;

		public _0024Attack_00242548(SmallWorm self_)
		{
			_0024self__00242550 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242550);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242551 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024dmg_00242552;

			internal SmallWorm _0024self__00242553;

			public _0024(int dmg, SmallWorm self_)
			{
				_0024dmg_00242552 = dmg;
				_0024self__00242553 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242553.takingDamage = true;
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242553.HP -= _0024dmg_00242552;
					if (_0024self__00242553.HP < 1)
					{
						_0024self__00242553.Die();
					}
					else
					{
						_0024self__00242553.takingDamage = false;
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

		internal int _0024dmg_00242554;

		internal SmallWorm _0024self__00242555;

		public _0024TDN_00242551(int dmg, SmallWorm self_)
		{
			_0024dmg_00242554 = dmg;
			_0024self__00242555 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dmg_00242554, _0024self__00242555);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242556 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242557;

			internal int _0024dmg_00242558;

			internal SmallWorm _0024self__00242559;

			public _0024(int dmg, SmallWorm self_)
			{
				_0024dmg_00242558 = dmg;
				_0024self__00242559 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024n2_00242557 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242559.t.position, Quaternion.identity);
					_0024n2_00242557.SendMessage("SD", _0024dmg_00242558);
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					if (_0024self__00242559.HP < 1)
					{
						goto IL_00dc;
					}
					result = (Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242559.takingDamage = false;
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

		internal int _0024dmg_00242560;

		internal SmallWorm _0024self__00242561;

		public _0024TDN2_00242556(int dmg, SmallWorm self_)
		{
			_0024dmg_00242560 = dmg;
			_0024self__00242561 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dmg_00242560, _0024self__00242561);
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
		parts = new GameObject[5];
		maxHP = 10;
		GOLD = 10;
		drops = new int[3];
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242544(this).GetEnumerator();
	}

	public virtual void Initialize()
	{
		if (!isHead)
		{
		}
	}

	public virtual IEnumerator Attack()
	{
		return new _0024Attack_00242548(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (!head)
		{
			head = gameObject;
			isHead = true;
			Initialize();
		}
		if (isHead)
		{
			if (attacking)
			{
				t.Translate(curVector.normalized * speed * Time.deltaTime);
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
		return new _0024TDN_00242551(dmg, this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242556(dmg, this).GetEnumerator();
	}

	public virtual void Die()
	{
		GameObject gameObject = null;
		int num = default(int);
		for (num = 0; num < GOLD; num++)
		{
			Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
		}
		if (drops[0] > 0 && UnityEngine.Random.Range(0, 2) == 0)
		{
			int num2 = UnityEngine.Random.Range(1, 3);
			for (num = 0; num < num2; num++)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, drops[0]);
			}
		}
		if (drops[1] > 0 && UnityEngine.Random.Range(0, 4) == 0)
		{
			int num3 = UnityEngine.Random.Range(1, 3);
			for (num = 0; num < num3; num++)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, drops[1]);
			}
		}
		UnityEngine.Object.Destroy(this.gameObject);
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
			c.SendMessage("TD", 10);
		}
	}

	public virtual void Main()
	{
	}
}
