using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Tyrannox : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00242680 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024prevHP_00242681;

			internal int _0024num_00242682;

			internal Tyrannox _0024self__00242683;

			public _0024(Tyrannox self_)
			{
				_0024self__00242683 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024prevHP_00242681 = default(int);
					goto case 4;
				case 4:
					_0024prevHP_00242681 = _0024self__00242683.HP;
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242683.HP < _0024prevHP_00242681 && Network.isServer)
					{
						_0024num_00242682 = UnityEngine.Random.Range(0, 3);
						if (_0024num_00242682 == 0 && !_0024self__00242683.roaring)
						{
							_0024self__00242683.roaring = true;
							_0024self__00242683.GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
							_0024self__00242683.StartCoroutine_Auto(_0024self__00242683.Meteor());
							result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
					}
					goto IL_00fa;
				case 3:
					_0024self__00242683.roaring = false;
					goto IL_00fa;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00fa:
					result = (Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Tyrannox _0024self__00242684;

		public _0024Check_00242680(Tyrannox self_)
		{
			_0024self__00242684 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242684);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Meteor_00242685 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242686;

			internal Tyrannox _0024self__00242687;

			public _0024(Tyrannox self_)
			{
				_0024self__00242687 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00242686 = default(int);
					if (Network.isServer)
					{
						_0024i_00242686 = 0;
						goto IL_00b9;
					}
					goto IL_00c5;
				case 2:
					_0024i_00242686++;
					goto IL_00b9;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00c5:
					YieldDefault(1);
					goto case 1;
					IL_00b9:
					if (_0024i_00242686 < 6)
					{
						Network.Instantiate(Resources.Load("rckP"), new Vector3(_0024self__00242687.t.position.x + (float)UnityEngine.Random.Range(-20, 20), _0024self__00242687.t.position.y + 35f, 0f), Quaternion.identity, 0);
						result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					goto IL_00c5;
				}
				return (byte)result != 0;
			}
		}

		internal Tyrannox _0024self__00242688;

		public _0024Meteor_00242685(Tyrannox self_)
		{
			_0024self__00242688 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242688);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242689 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Tyrannox _0024self__00242690;

			public _0024(Tyrannox self_)
			{
				_0024self__00242690 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242690.charging && Network.isServer)
					{
						_0024self__00242690.charging = true;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0138;
				case 2:
					_0024self__00242690.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242690.GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
					result = (Yield(4, new WaitForSeconds(1.3f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242690.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					_0024self__00242690.spdd = 6;
					result = (Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00242690.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242690.spdd = 0;
					_0024self__00242690.charging = false;
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

		internal Tyrannox _0024self__00242691;

		public _0024ChargeRight_00242689(Tyrannox self_)
		{
			_0024self__00242691 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242691);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242692 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Tyrannox _0024self__00242693;

			public _0024(Tyrannox self_)
			{
				_0024self__00242693 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242693.charging && Network.isServer)
					{
						_0024self__00242693.charging = true;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0139;
				case 2:
					_0024self__00242693.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242693.GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
					result = (Yield(4, new WaitForSeconds(1.3f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242693.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					_0024self__00242693.spdd = -6;
					result = (Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00242693.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242693.spdd = 0;
					_0024self__00242693.charging = false;
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

		internal Tyrannox _0024self__00242694;

		public _0024ChargeLeft_00242692(Tyrannox self_)
		{
			_0024self__00242694 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242694);
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

	public Tyrannox()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a1"].layer = 0;
		@base.GetComponent<Animation>()["a2"].layer = 1;
		@base.GetComponent<Animation>()["a3"].layer = 1;
		@base.GetComponent<Animation>()["a1"].speed = 2f;
		@base.GetComponent<Animation>()["a2"].speed = 1.5f;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 19, 20, 15 };
		SetStats(100, 3, 0, 40, 10f, array, UnityEngine.Random.Range(6, 20), 40);
		StartCoroutine_Auto(Check());
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
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 30f) && !knocking)
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
		return new _0024Check_00242680(this).GetEnumerator();
	}

	public virtual IEnumerator Meteor()
	{
		return new _0024Meteor_00242685(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00242689(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242692(this).GetEnumerator();
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
			@base.GetComponent<Animation>().Play("a2");
		}
	}

	[RPC]
	public virtual void ATK()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("a1");
		}
	}

	[RPC]
	public virtual void SUMMON()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("a3");
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
