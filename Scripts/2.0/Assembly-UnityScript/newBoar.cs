using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class newBoar : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242917 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241077_00242918;

			internal Vector3 _0024_00241078_00242919;

			internal newBoar _0024self__00242920;

			public _0024(newBoar self_)
			{
				_0024self__00242920 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242920.charging && Network.isServer && !_0024self__00242920.gooing)
					{
						int num = (_0024_00241077_00242918 = 8);
						Vector3 vector = (_0024_00241078_00242919 = _0024self__00242920.r.velocity);
						float num2 = (_0024_00241078_00242919.y = _0024_00241077_00242918);
						Vector3 vector3 = (_0024self__00242920.r.velocity = _0024_00241078_00242919);
						_0024self__00242920.spdd = 0;
						_0024self__00242920.gooing = true;
						_0024self__00242920.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						_0024self__00242920.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_01ab;
				case 2:
					_0024self__00242920.GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
					_0024self__00242920.charging = true;
					_0024self__00242920.spdd = 15;
					result = (Yield(3, new WaitForSeconds(1.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242920.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242920.charging = false;
					_0024self__00242920.spdd = 0;
					result = (Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242920.gooing = false;
					goto IL_01ab;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01ab:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal newBoar _0024self__00242921;

		public _0024ChargeRight_00242917(newBoar self_)
		{
			_0024self__00242921 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242921);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242922 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241079_00242923;

			internal Vector3 _0024_00241080_00242924;

			internal newBoar _0024self__00242925;

			public _0024(newBoar self_)
			{
				_0024self__00242925 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242925.charging && Network.isServer && !_0024self__00242925.gooing)
					{
						int num = (_0024_00241079_00242923 = 8);
						Vector3 vector = (_0024_00241080_00242924 = _0024self__00242925.r.velocity);
						float num2 = (_0024_00241080_00242924.y = _0024_00241079_00242923);
						Vector3 vector3 = (_0024self__00242925.r.velocity = _0024_00241080_00242924);
						_0024self__00242925.spdd = 0;
						_0024self__00242925.gooing = true;
						_0024self__00242925.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						_0024self__00242925.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_01ab;
				case 2:
					_0024self__00242925.GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
					_0024self__00242925.charging = true;
					_0024self__00242925.spdd = -15;
					result = (Yield(3, new WaitForSeconds(1.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242925.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242925.charging = false;
					_0024self__00242925.spdd = 0;
					result = (Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242925.gooing = false;
					goto IL_01ab;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01ab:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal newBoar _0024self__00242926;

		public _0024ChargeLeft_00242922(newBoar self_)
		{
			_0024self__00242926 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242926);
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

	private bool gooing;

	private Ray r1U;

	private Ray r2U;

	public newBoar()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(35, 2, 2, 11, 2f, array, UnityEngine.Random.Range(5, 15), 11);
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["r"].layer = 0;
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
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 30f) && !(Mathf.Abs(player.transform.position.y - t.position.y) >= 1.5f) && !knocking && !gooing)
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
		return new _0024ChargeRight_00242917(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242922(this).GetEnumerator();
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
	public virtual void RUN()
	{
		@base.GetComponent<Animation>().Play("r");
	}

	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}
}
