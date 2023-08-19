using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ChickenKing : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Jump_00241303 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241304;

			internal int _0024_0024455_00241305;

			internal Vector3 _0024_0024456_00241306;

			internal ChickenKing _0024self__00241307;

			public _0024(ChickenKing self_)
			{
				_0024self__00241307 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024a_00241304 = UnityEngine.Random.Range(0, 3);
					if (_0024a_00241304 == 0)
					{
						_0024self__00241307.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/ch"));
					}
					if (_0024self__00241307.charging)
					{
						int num = (_0024_0024455_00241305 = 35);
						Vector3 vector = (_0024_0024456_00241306 = _0024self__00241307.GetComponent<Rigidbody>().velocity);
						float num2 = (_0024_0024456_00241306.y = _0024_0024455_00241305);
						Vector3 vector3 = (_0024self__00241307.GetComponent<Rigidbody>().velocity = _0024_0024456_00241306);
					}
					result = (Yield(2, new WaitForSeconds(2.5f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ChickenKing _0024self__00241308;

		public _0024Jump_00241303(ChickenKing self_)
		{
			_0024self__00241308 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241308);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00241309 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024prevHP_00241310;

			internal int _0024num_00241311;

			internal ChickenKing _0024self__00241312;

			public _0024(ChickenKing self_)
			{
				_0024self__00241312 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024prevHP_00241310 = default(int);
					goto case 4;
				case 4:
					_0024prevHP_00241310 = _0024self__00241312.HP;
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241312.HP < _0024prevHP_00241310 && Network.isServer)
					{
						_0024num_00241311 = UnityEngine.Random.Range(0, 3);
						if (_0024num_00241311 == 0 && !_0024self__00241312.roaring)
						{
							_0024self__00241312.roaring = true;
							_0024self__00241312.GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
							_0024self__00241312.Meteor();
							result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
					}
					goto IL_00ee;
				case 3:
					_0024self__00241312.roaring = false;
					goto IL_00ee;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00ee:
					result = (Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ChickenKing _0024self__00241313;

		public _0024Check_00241309(ChickenKing self_)
		{
			_0024self__00241313 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241313);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00241314 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ChickenKing _0024self__00241315;

			public _0024(ChickenKing self_)
			{
				_0024self__00241315 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241315.charging && Network.isServer)
					{
						_0024self__00241315.charging = true;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0138;
				case 2:
					_0024self__00241315.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241315.GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
					result = (Yield(4, new WaitForSeconds(1.3f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241315.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					_0024self__00241315.spdd = 6;
					result = (Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241315.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00241315.spdd = 0;
					_0024self__00241315.charging = false;
					goto IL_0138;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0138:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ChickenKing _0024self__00241316;

		public _0024ChargeRight_00241314(ChickenKing self_)
		{
			_0024self__00241316 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241316);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00241317 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ChickenKing _0024self__00241318;

			public _0024(ChickenKing self_)
			{
				_0024self__00241318 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241318.charging && Network.isServer)
					{
						_0024self__00241318.charging = true;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0139;
				case 2:
					_0024self__00241318.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241318.GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
					result = (Yield(4, new WaitForSeconds(1.3f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241318.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					_0024self__00241318.spdd = -6;
					result = (Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241318.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00241318.spdd = 0;
					_0024self__00241318.charging = false;
					goto IL_0139;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0139:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ChickenKing _0024self__00241319;

		public _0024ChargeLeft_00241317(ChickenKing self_)
		{
			_0024self__00241319 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241319);
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

	private bool roaring;

	private Ray r2U;

	public ChickenKing()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 0;
		@base.GetComponent<Animation>()["a"].speed = 2f;
		@base.GetComponent<Animation>()["i"].speed = 2f;
		StartCoroutine_Auto(Jump());
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 42, 42, 42 };
		SetStats(300, 2, 0, 40, 10f, array, UnityEngine.Random.Range(6, 20), 40);
		StartCoroutine_Auto(Check());
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public virtual IEnumerator Jump()
	{
		return new _0024Jump_00241303(this).GetEnumerator();
	}

	public override void Update()
	{
		r1U.origin = transform.position;
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		r2U.direction = Vector3.right;
		if (Physics.Raycast(r1U, 3f, mask2) && e.transform.rotation.y == 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 3f, mask2) && e.transform.rotation.y != 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
			spdd *= -1;
		}
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 150f) && !knocking)
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
		else
		{
			int num3 = 0;
			Vector3 velocity2 = r.velocity;
			float num4 = (velocity2.x = num3);
			Vector3 vector4 = (r.velocity = velocity2);
		}
		if (roaring)
		{
			int num5 = 0;
			Vector3 velocity3 = r.velocity;
			float num6 = (velocity3.x = num5);
			Vector3 vector6 = (r.velocity = velocity3);
		}
	}

	public virtual IEnumerator Check()
	{
		return new _0024Check_00241309(this).GetEnumerator();
	}

	public virtual void Meteor()
	{
	}

	public virtual IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00241314(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00241317(this).GetEnumerator();
	}

	[RPC]
	public virtual void Turn(int a)
	{
		if ((bool)e)
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
	}

	[RPC]
	public virtual void ROAR()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("a");
		}
		if (Network.isServer)
		{
			int num = 50;
			Vector3 velocity = GetComponent<Rigidbody>().velocity;
			float num2 = (velocity.y = num);
			Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		}
	}

	[RPC]
	public virtual void ATK()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("a");
		}
	}

	[RPC]
	public virtual void SUMMON()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("a");
		}
	}

	[RPC]
	public virtual void IDLE()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("i");
		}
	}
}
