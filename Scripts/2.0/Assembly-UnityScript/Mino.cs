using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Mino : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242019 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Mino _0024self__00242020;

			public _0024(Mino self_)
			{
				_0024self__00242020 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242020.charging && Network.isServer)
					{
						_0024self__00242020.charging = true;
						_0024self__00242020.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						_0024self__00242020.GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0114;
				case 2:
					_0024self__00242020.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					_0024self__00242020.spdd = 12;
					_0024self__00242020.running = true;
					result = (Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242020.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242020.charging = false;
					_0024self__00242020.running = false;
					goto IL_0114;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0114:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Mino _0024self__00242021;

		public _0024ChargeRight_00242019(Mino self_)
		{
			_0024self__00242021 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242021);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242022 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Mino _0024self__00242023;

			public _0024(Mino self_)
			{
				_0024self__00242023 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242023.charging && Network.isServer)
					{
						_0024self__00242023.charging = true;
						_0024self__00242023.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						_0024self__00242023.GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0114;
				case 2:
					_0024self__00242023.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					_0024self__00242023.spdd = -12;
					_0024self__00242023.running = true;
					result = (Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242023.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242023.charging = false;
					_0024self__00242023.running = false;
					goto IL_0114;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0114:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Mino _0024self__00242024;

		public _0024ChargeLeft_00242022(Mino self_)
		{
			_0024self__00242024 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242024);
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

	private bool running;

	public Mino()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["r"].speed = 2f;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 20, 15, 15 };
		SetStats(85, 7, 0, 40, 10f, array, UnityEngine.Random.Range(6, 20), 40);
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
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 15f) && !knocking)
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
		if (charging && !knocking && running)
		{
			int num = spdd;
			Vector3 velocity = r.velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (r.velocity = velocity);
		}
	}

	public virtual IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00242019(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242022(this).GetEnumerator();
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

	[RPC]
	public virtual void ROAR()
	{
		@base.GetComponent<Animation>().Play("a");
	}
}
