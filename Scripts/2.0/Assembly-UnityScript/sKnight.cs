using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class sKnight : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242949 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241093_00242950;

			internal Vector3 _0024_00241094_00242951;

			internal sKnight _0024self__00242952;

			public _0024(sKnight self_)
			{
				_0024self__00242952 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242952.charging && Network.isServer)
					{
						int num = (_0024_00241093_00242950 = 15);
						Vector3 vector = (_0024_00241094_00242951 = _0024self__00242952.r.velocity);
						float num2 = (_0024_00241094_00242951.y = _0024_00241093_00242950);
						Vector3 vector3 = (_0024self__00242952.r.velocity = _0024_00241094_00242951);
						_0024self__00242952.charging = true;
						_0024self__00242952.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						_0024self__00242952.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024self__00242952.spdd = 6;
						result = (Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
				case 2:
					_0024self__00242952.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242952.charging = false;
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

		internal sKnight _0024self__00242953;

		public _0024ChargeRight_00242949(sKnight self_)
		{
			_0024self__00242953 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242953);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242954 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241095_00242955;

			internal Vector3 _0024_00241096_00242956;

			internal sKnight _0024self__00242957;

			public _0024(sKnight self_)
			{
				_0024self__00242957 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242957.charging && Network.isServer)
					{
						int num = (_0024_00241095_00242955 = 15);
						Vector3 vector = (_0024_00241096_00242956 = _0024self__00242957.r.velocity);
						float num2 = (_0024_00241096_00242956.y = _0024_00241095_00242955);
						Vector3 vector3 = (_0024self__00242957.r.velocity = _0024_00241096_00242956);
						_0024self__00242957.charging = true;
						_0024self__00242957.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						_0024self__00242957.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024self__00242957.spdd = -6;
						result = (Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
						break;
					}
					goto IL_011f;
				case 2:
					_0024self__00242957.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242957.charging = false;
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

		internal sKnight _0024self__00242958;

		public _0024ChargeLeft_00242954(sKnight self_)
		{
			_0024self__00242958 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242958);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	public sKnight()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(55, 7, 0, 20, 10f, array, UnityEngine.Random.Range(6, 20), 20);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if (!Network.isServer)
		{
			return;
		}
		r1U.origin = transform.position;
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		r2U.direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.5f, mask2) && e.transform.rotation.y == 0f)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 1.5f, mask2) && e.transform.rotation.y != 0f)
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
		return new _0024ChargeRight_00242949(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242954(this).GetEnumerator();
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
		@base.GetComponent<Animation>().Play("a");
	}

	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}
}
