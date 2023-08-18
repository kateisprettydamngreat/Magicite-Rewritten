using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class LightBlast : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241966 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal LightBlast _0024self__00241967;

			public _0024(LightBlast self_)
			{
				_0024self__00241967 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241967.exiling)
					{
						_0024self__00241967.exiling = true;
						_0024self__00241967.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_0099;
				case 2:
					if (Network.isServer)
					{
						Network.Destroy(_0024self__00241967.GetComponent<NetworkView>().viewID);
						Network.RemoveRPCs(_0024self__00241967.GetComponent<NetworkView>().viewID);
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

		internal LightBlast _0024self__00241968;

		public _0024Exile_00241966(LightBlast self_)
		{
			_0024self__00241968 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241968);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241969 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal LightBlast _0024self__00241970;

			public _0024(LightBlast self_)
			{
				_0024self__00241970 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241970.t = _0024self__00241970.transform;
					if (_0024self__00241970.isRight)
					{
					}
					_0024self__00241970.GetComponent<Collider>().enabled = true;
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241970.GetComponent<NetworkView>().isMine)
					{
						_0024self__00241970.StartCoroutine_Auto(_0024self__00241970.Exile());
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

		internal LightBlast _0024self__00241971;

		public _0024Start_00241969(LightBlast self_)
		{
			_0024self__00241971 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241971);
		}
	}

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

	private int baseDMG;

	private bool exiling;

	private Transform t;

	public LightBlast()
	{
		@base = new GameObject[2];
		speed = 32f;
		baseDMG = 150;
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241966(this).GetEnumerator();
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241969(this).GetEnumerator();
	}

	[RPC]
	public virtual void SetN(int m)
	{
		MAG = m + GetDmg(tier);
	}

	public virtual void Set(int m)
	{
		GetComponent<NetworkView>().RPC("SetN", (RPCMode)m);
		MonoBehaviour.print(MAG + "IS sTRENGTH " + m + " is m");
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
			1 => 1, 
			2 => 2, 
			3 => 4, 
			4 => 8, 
			_ => 1, 
		};
	}

	public virtual void Update()
	{
		speed += 10f * Time.deltaTime;
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
		@base[0].GetComponent<Renderer>().material = fireA;
		@base[1].GetComponent<Renderer>().material = fireA;
		particleFire.SetActive(value: true);
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (!(transform.position.x <= c.gameObject.transform.position.x))
		{
			left = true;
		}
		else
		{
			left = false;
		}
		if (c.gameObject.layer == 9 || c.gameObject.layer == 12)
		{
			cantMove = true;
			c.gameObject.SendMessage("TD", 150);
			if (GetComponent<NetworkView>().isMine)
			{
				StartCoroutine_Auto(Exile());
			}
		}
		else if (c.gameObject.layer == 8)
		{
			if (!c.gameObject.GetComponent<NetworkView>().isMine && GetComponent<NetworkView>().isMine)
			{
				c.gameObject.GetComponent<NetworkView>().RPC("TD", RPCMode.All, 150);
				if (GetComponent<NetworkView>().isMine)
				{
					StartCoroutine_Auto(Exile());
				}
			}
		}
		else if (c.gameObject.layer == 11 && !initialized)
		{
			initialized = true;
			cantMove = true;
			if (GetComponent<NetworkView>().isMine)
			{
				StartCoroutine_Auto(Exile());
			}
		}
	}

	public virtual void Main()
	{
	}
}
