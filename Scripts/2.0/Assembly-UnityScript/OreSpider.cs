using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class OreSpider : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242120 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024697_00242121;

			internal Vector3 _0024_0024698_00242122;

			internal OreSpider _0024self__00242123;

			public _0024(OreSpider self_)
			{
				_0024self__00242123 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242123.charging && Network.isServer)
					{
						int num = (_0024_0024697_00242121 = 12);
						Vector3 vector = (_0024_0024698_00242122 = _0024self__00242123.r.velocity);
						float num2 = (_0024_0024698_00242122.y = _0024_0024697_00242121);
						Vector3 vector3 = (_0024self__00242123.r.velocity = _0024_0024698_00242122);
						_0024self__00242123.charging = true;
						_0024self__00242123.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						_0024self__00242123.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024self__00242123.spdd = 5;
						result = (Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
				case 2:
					_0024self__00242123.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242123.charging = false;
					goto IL_011e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_011e:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal OreSpider _0024self__00242124;

		public _0024ChargeRight_00242120(OreSpider self_)
		{
			_0024self__00242124 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242124);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242125 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024699_00242126;

			internal Vector3 _0024_0024700_00242127;

			internal OreSpider _0024self__00242128;

			public _0024(OreSpider self_)
			{
				_0024self__00242128 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242128.charging && Network.isServer)
					{
						int num = (_0024_0024699_00242126 = 12);
						Vector3 vector = (_0024_0024700_00242127 = _0024self__00242128.r.velocity);
						float num2 = (_0024_0024700_00242127.y = _0024_0024699_00242126);
						Vector3 vector3 = (_0024self__00242128.r.velocity = _0024_0024700_00242127);
						_0024self__00242128.charging = true;
						_0024self__00242128.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						_0024self__00242128.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024self__00242128.spdd = -5;
						result = (Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
						break;
					}
					goto IL_011f;
				case 2:
					_0024self__00242128.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242128.charging = false;
					goto IL_011f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_011f:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal OreSpider _0024self__00242129;

		public _0024ChargeLeft_00242125(OreSpider self_)
		{
			_0024self__00242129 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242129);
		}
	}

	private GameObject player;

	public GameObject oreCover;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	private bool initialized;

	public OreSpider()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 4, 4, 4 };
		SetStats(15, 2, 0, 4, 10f, array, UnityEngine.Random.Range(6, 20), 4);
	}

	public virtual void SetPlayer(GameObject g)
	{
		if (!initialized)
		{
			GetComponent<NetworkView>().RPC("Init", RPCMode.All);
		}
		player = g;
	}

	[RPC]
	public virtual void Init()
	{
		initialized = true;
		@base.SetActive(value: true);
		oreCover.SetActive(value: false);
	}

	public override void Update()
	{
		r1U.origin = transform.position;
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		r2U.direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.5f, mask2) && e.transform.rotation.y == 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 1.5f, mask2) && e.transform.rotation.y != 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
			spdd *= -1;
		}
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 7f) && !knocking)
		{
			if (!(player.transform.position.x <= t.position.x))
			{
				StartCoroutine_Auto(ChargeRight());
			}
			else
			{
				StartCoroutine_Auto(ChargeLeft());
			}
		}
		if (charging && !knocking)
		{
			int num = spdd;
			Vector3 velocity = r.velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (r.velocity = velocity);
		}
	}

	public virtual IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00242120(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242125(this).GetEnumerator();
	}

	[RPC]
	public virtual void Turn(int a)
	{
		if (a == 0)
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

	[RPC]
	public virtual void ATK()
	{
		@base.GetComponent<Animation>().Play("i");
	}

	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}
}
