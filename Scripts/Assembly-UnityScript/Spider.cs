using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Spider : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242583 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024927_00242584;

			internal Vector3 _0024_0024928_00242585;

			internal Spider _0024self__00242586;

			public _0024(Spider self_)
			{
				_0024self__00242586 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242586.charging && Network.isServer)
					{
						int num = (_0024_0024927_00242584 = 20);
						Vector3 vector = (_0024_0024928_00242585 = _0024self__00242586.r.velocity);
						float num2 = (_0024_0024928_00242585.y = _0024_0024927_00242584);
						Vector3 vector3 = (_0024self__00242586.r.velocity = _0024_0024928_00242585);
						_0024self__00242586.charging = true;
						_0024self__00242586.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						_0024self__00242586.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024self__00242586.spdd = 5;
						result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto IL_011b;
				case 2:
					_0024self__00242586.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242586.charging = false;
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

		internal Spider _0024self__00242587;

		public _0024ChargeRight_00242583(Spider self_)
		{
			_0024self__00242587 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242587);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242588 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024929_00242589;

			internal Vector3 _0024_0024930_00242590;

			internal Spider _0024self__00242591;

			public _0024(Spider self_)
			{
				_0024self__00242591 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242591.charging && Network.isServer)
					{
						int num = (_0024_0024929_00242589 = 20);
						Vector3 vector = (_0024_0024930_00242590 = _0024self__00242591.r.velocity);
						float num2 = (_0024_0024930_00242590.y = _0024_0024929_00242589);
						Vector3 vector3 = (_0024self__00242591.r.velocity = _0024_0024930_00242590);
						_0024self__00242591.charging = true;
						_0024self__00242591.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						_0024self__00242591.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024self__00242591.spdd = -5;
						result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto IL_011c;
				case 2:
					_0024self__00242591.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242591.charging = false;
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

		internal Spider _0024self__00242592;

		public _0024ChargeLeft_00242588(Spider self_)
		{
			_0024self__00242592 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242592);
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

	public Spider()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 1;
		int[] array = new int[3] { 23, 23, 19 };
		SetStats(45, 4, 13, 17, 5f, array, UnityEngine.Random.Range(5, 15), 17);
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
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 35f) && !knocking)
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
		return new _0024ChargeRight_00242583(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242588(this).GetEnumerator();
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
		@base.GetComponent<Animation>().Play("r");
	}

	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}
}
