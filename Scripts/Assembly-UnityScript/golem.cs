using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class golem : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242877 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241051_00242878;

			internal Vector3 _0024_00241052_00242879;

			internal golem _0024self__00242880;

			public _0024(golem self_)
			{
				_0024self__00242880 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242880.charging && Network.isServer)
					{
						int num = (_0024_00241051_00242878 = 16);
						Vector3 vector = (_0024_00241052_00242879 = _0024self__00242880.r.velocity);
						float num2 = (_0024_00241052_00242879.y = _0024_00241051_00242878);
						Vector3 vector3 = (_0024self__00242880.r.velocity = _0024_00241052_00242879);
						_0024self__00242880.charging = true;
						_0024self__00242880.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						_0024self__00242880.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024self__00242880.spdd = 7;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_011b;
				case 2:
					_0024self__00242880.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242880.charging = false;
					goto IL_011b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_011b:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal golem _0024self__00242881;

		public _0024ChargeRight_00242877(golem self_)
		{
			_0024self__00242881 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242881);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242882 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241053_00242883;

			internal Vector3 _0024_00241054_00242884;

			internal golem _0024self__00242885;

			public _0024(golem self_)
			{
				_0024self__00242885 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242885.charging && Network.isServer)
					{
						int num = (_0024_00241053_00242883 = 16);
						Vector3 vector = (_0024_00241054_00242884 = _0024self__00242885.r.velocity);
						float num2 = (_0024_00241054_00242884.y = _0024_00241053_00242883);
						Vector3 vector3 = (_0024self__00242885.r.velocity = _0024_00241054_00242884);
						_0024self__00242885.charging = true;
						_0024self__00242885.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						_0024self__00242885.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024self__00242885.spdd = -7;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_011c;
				case 2:
					_0024self__00242885.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242885.charging = false;
					goto IL_011c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_011c:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal golem _0024self__00242886;

		public _0024ChargeLeft_00242882(golem self_)
		{
			_0024self__00242886 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242886);
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

	public golem()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 19, 20, 17 };
		SetStats(35, 3, 0, 4, 10f, array, UnityEngine.Random.Range(6, 20), 4);
		@base.GetComponent<Animation>()["a"].speed = 1.7f;
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
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
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 13f) && !knocking)
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
		return new _0024ChargeRight_00242877(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242882(this).GetEnumerator();
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
