using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ArrowScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241196 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ArrowScript _0024self__00241197;

			public _0024(ArrowScript self_)
			{
				_0024self__00241197 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241197.t = _0024self__00241197.transform;
					if (_0024self__00241197.isEnemy)
					{
						_0024self__00241197.speed = 23f;
					}
					if (_0024self__00241197.isRight)
					{
					}
					result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241197.GetComponent<Collider>().enabled = true;
					result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241197.StartCoroutine_Auto(_0024self__00241197.Exile());
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArrowScript _0024self__00241198;

		public _0024Start_00241196(ArrowScript self_)
		{
			_0024self__00241198 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241198);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241199 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ArrowScript _0024self__00241200;

			public _0024(ArrowScript self_)
			{
				_0024self__00241200 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241200.exiling)
					{
						_0024self__00241200.exiling = true;
						_0024self__00241200.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00241200.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00241200.GetComponent<NetworkView>().viewID);
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

		internal ArrowScript _0024self__00241201;

		public _0024Exile_00241199(ArrowScript self_)
		{
			_0024self__00241201 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241201);
		}
	}

	public bool isBolt;

	public bool isEnemy;

	public Material fireA;

	public GameObject[] @base;

	public GameObject particleFire;

	public GameObject particleMulti;

	public int tier;

	public bool isRight;

	private Renderer r;

	public GameObject lightObj;

	public int min;

	public int max;

	public float wait;

	private float speed;

	private int MAG;

	private bool cantMove;

	private bool initialized;

	private bool left;

	private bool fire;

	private bool exiling;

	private Transform t;

	public ArrowScript()
	{
		@base = new GameObject[2];
		speed = 30f;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241196(this).GetEnumerator();
	}

	[RPC]
	public virtual void SetN(float m)
	{
		int num = (int)m;
		MAG = num + GetDmg(tier);
	}

	public virtual void Set(int m)
	{
		GetComponent<NetworkView>().RPC("SetN", (RPCMode)m);
	}

	[RPC]
	public virtual void SetMulti()
	{
		particleMulti.SetActive(value: true);
	}

	public virtual int GetDmg(int a)
	{
		int num = default(int);
		return a switch
		{
			0 => 1, 
			1 => 1, 
			2 => 4, 
			3 => 11, 
			4 => 20, 
			5 => 40, 
			_ => 1, 
		};
	}

	public virtual void Update()
	{
		if (!cantMove)
		{
			if (isRight)
			{
				t.Translate(Vector3.left * Time.deltaTime * (0f - speed));
			}
			else
			{
				t.Translate(Vector3.left * Time.deltaTime * speed);
			}
		}
	}

	public virtual int GetID(int a)
	{
		int num = default(int);
		return a switch
		{
			0 => 52, 
			1 => 53, 
			2 => 54, 
			3 => 55, 
			4 => 56, 
			5 => 57, 
			_ => 53, 
		};
	}

	[RPC]
	public virtual void FireN()
	{
		fire = true;
		@base[0].GetComponent<Renderer>().material = fireA;
		@base[1].GetComponent<Renderer>().material = fireA;
		particleFire.SetActive(value: true);
	}

	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241199(this).GetEnumerator();
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "fWisp" && !fire)
		{
			fire = true;
			MAG *= 2;
			GetComponent<NetworkView>().RPC("FireN", RPCMode.All);
		}
		if (!(transform.position.x <= c.gameObject.transform.position.x))
		{
			left = true;
		}
		else
		{
			left = false;
		}
		if (!isEnemy && (c.gameObject.layer == 9 || c.gameObject.layer == 12))
		{
			cantMove = true;
			c.gameObject.SendMessage("TD", MAG);
			if (Network.isServer)
			{
				StartCoroutine_Auto(Exile());
			}
		}
		else if (c.gameObject.layer == 8)
		{
			if (isEnemy)
			{
				c.gameObject.SendMessage("TD", MAG);
				StartCoroutine_Auto(Exile());
			}
			else if (MenuScript.pvp == 1 && !GetComponent<NetworkView>().isMine)
			{
				c.gameObject.SendMessage("TD", MAG);
				MonoBehaviour.print("hit");
			}
		}
		else if (c.gameObject.layer == 11 && !isBolt && !initialized && !isEnemy && GetComponent<NetworkView>().isMine)
		{
			initialized = true;
			cantMove = true;
			Item item = new Item(GetID(tier), 1, new int[4], 0f, null);
			GameObject gameObject = null;
			int[] array = null;
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
			t.position = new Vector3(0f, 0f, -500f);
			if (Network.isServer)
			{
				StartCoroutine_Auto(Exile());
			}
		}
	}

	}