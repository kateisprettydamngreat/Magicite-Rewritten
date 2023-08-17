using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BlueWorm : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Action_00241242 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241243;

			internal Vector3 _0024pos_00241244;

			internal BlueWorm _0024self__00241245;

			public _0024(BlueWorm self_)
			{
				_0024self__00241245 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00241243 = default(int);
					_0024pos_00241244 = default(Vector3);
					goto case 5;
				case 5:
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(2, 5))) ? 1 : 0);
					break;
				case 2:
					if (Network.isServer)
					{
						_0024self__00241245.GetComponent<NetworkView>().RPC("A", RPCMode.All);
					}
					result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024i_00241243 = 0;
					goto IL_012c;
				case 4:
					_0024i_00241243++;
					goto IL_012c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_012c:
					if (_0024i_00241243 < 6)
					{
						_0024pos_00241244 = new Vector3(_0024self__00241245.t.position.x + (float)UnityEngine.Random.Range(-8, 8), _0024self__00241245.t.position.y + 28f, 0f);
						Network.Instantiate(Resources.Load("rckW"), _0024pos_00241244, Quaternion.identity, 0);
						result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					}
					else
					{
						result = (Yield(5, new WaitForSeconds(1f)) ? 1 : 0);
					}
					break;
				}
				return (byte)result != 0;
			}
		}

		internal BlueWorm _0024self__00241246;

		public _0024Action_00241242(BlueWorm self_)
		{
			_0024self__00241246 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241246);
		}
	}

	private RaycastHit hit;

	private int mask;

	private int spd;

	private bool turning;

	private int mask2;

	private bool ATKING;

	private GameObject player;

	private bool initialized;

	public BlueWorm()
	{
		mask = 256;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["i"].speed = 0.5f;
		@base.GetComponent<Animation>()["i1"].layer = 1;
		@base.GetComponent<Animation>()["i"].speed = 0.5f;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["a"].speed = 0.5f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(100, 6, 2, 0, 2f, array, UnityEngine.Random.Range(10, 25), 10);
	}

	public override void Update()
	{
	}

	public virtual void K()
	{
	}

	public virtual void KN()
	{
	}

	[RPC]
	public virtual void A()
	{
		@base.GetComponent<Animation>().CrossFade("a");
	}

	[RPC]
	public virtual void I()
	{
		@base.GetComponent<Animation>().Play("i1");
	}

	[RPC]
	public virtual void Turn(int dir)
	{
		if (dir == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion quaternion2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion quaternion4 = (e.transform.rotation = rotation2);
		}
	}

	public virtual void Set()
	{
		MonoBehaviour.print("SETTT");
		if (!initialized)
		{
			initialized = true;
			@base.SetActive(value: true);
			@base.GetComponent<Animation>().Play("i1");
			if (Network.isServer)
			{
				GetComponent<NetworkView>().RPC("I", RPCMode.All);
			}
			StartCoroutine_Auto(Action());
		}
	}

	public virtual IEnumerator Action()
	{
		return new _0024Action_00241242(this).GetEnumerator();
	}
}
