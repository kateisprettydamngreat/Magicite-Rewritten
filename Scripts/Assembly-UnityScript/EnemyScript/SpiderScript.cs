using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SpiderScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242603 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024947_00242604;

			internal Vector3 _0024_0024948_00242605;

			internal SpiderScript _0024self__00242606;

			public _0024(SpiderScript self_)
			{
				_0024self__00242606 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242606.charging && Network.isServer)
					{
						int num = (_0024_0024947_00242604 = 15);
						Vector3 vector = (_0024_0024948_00242605 = _0024self__00242606.r.velocity);
						float num2 = (_0024_0024948_00242605.y = _0024_0024947_00242604);
						Vector3 vector3 = (_0024self__00242606.r.velocity = _0024_0024948_00242605);
						_0024self__00242606.charging = true;
						_0024self__00242606.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						_0024self__00242606.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024self__00242606.spdd = 5;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_011b;
				case 2:
					_0024self__00242606.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242606.charging = false;
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

		internal SpiderScript _0024self__00242607;

		public _0024ChargeRight_00242603(SpiderScript self_)
		{
			_0024self__00242607 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242607);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242608 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024949_00242609;

			internal Vector3 _0024_0024950_00242610;

			internal SpiderScript _0024self__00242611;

			public _0024(SpiderScript self_)
			{
				_0024self__00242611 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242611.charging && Network.isServer)
					{
						int num = (_0024_0024949_00242609 = 15);
						Vector3 vector = (_0024_0024950_00242610 = _0024self__00242611.r.velocity);
						float num2 = (_0024_0024950_00242610.y = _0024_0024949_00242609);
						Vector3 vector3 = (_0024self__00242611.r.velocity = _0024_0024950_00242610);
						_0024self__00242611.charging = true;
						_0024self__00242611.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						_0024self__00242611.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024self__00242611.spdd = -5;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_011c;
				case 2:
					_0024self__00242611.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242611.charging = false;
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

		internal SpiderScript _0024self__00242612;

		public _0024ChargeLeft_00242608(SpiderScript self_)
		{
			_0024self__00242612 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242612);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	public SpiderScript()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 1;
		int[] array = new int[3] { 23, 0, 10 };
		SetStats(20, 2, 13, 6, 5f, array, UnityEngine.Random.Range(5, 15), 6);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
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
		return new _0024ChargeRight_00242603(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242608(this).GetEnumerator();
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
