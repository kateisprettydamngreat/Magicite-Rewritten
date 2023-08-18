using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class commander : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Summon_00242831 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00242832;

			internal commander _0024self__00242833;

			public _0024(commander self_)
			{
				_0024self__00242833 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024g_00242832 = null;
					goto IL_0023;
				case 2:
					if ((bool)_0024self__00242833.player && _0024self__00242833.canFire)
					{
						_0024g_00242832 = (GameObject)Network.Instantiate(Resources.Load("haz/comFire"), _0024self__00242833.transform.position, Quaternion.identity, 0);
						_0024g_00242832.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024self__00242833.player.transform.position);
					}
					goto IL_0023;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0023:
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal commander _0024self__00242834;

		public _0024Summon_00242831(commander self_)
		{
			_0024self__00242834 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242834);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242835 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024nuu_00242836;

			internal int _0024_00241029_00242837;

			internal Vector3 _0024_00241030_00242838;

			internal commander _0024self__00242839;

			public _0024(commander self_)
			{
				_0024self__00242839 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242839.charging && Network.isServer)
					{
						int num = (_0024_00241029_00242837 = 15);
						Vector3 vector = (_0024_00241030_00242838 = _0024self__00242839.r.velocity);
						float num2 = (_0024_00241030_00242838.y = _0024_00241029_00242837);
						Vector3 vector3 = (_0024self__00242839.r.velocity = _0024_00241030_00242838);
						_0024self__00242839.charging = true;
						_0024self__00242839.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						_0024self__00242839.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024nuu_00242836 = UnityEngine.Random.Range(0, 3);
						if (_0024nuu_00242836 == 0)
						{
							_0024self__00242839.spdd = 4;
						}
						else
						{
							_0024self__00242839.spdd = -4;
						}
						result = (Yield(2, new WaitForSeconds(0.75f)) ? 1 : 0);
						break;
					}
					goto IL_0148;
				case 2:
					_0024self__00242839.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242839.charging = false;
					goto IL_0148;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0148:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal commander _0024self__00242840;

		public _0024ChargeRight_00242835(commander self_)
		{
			_0024self__00242840 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242840);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242841 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024nuu_00242842;

			internal int _0024_00241031_00242843;

			internal Vector3 _0024_00241032_00242844;

			internal commander _0024self__00242845;

			public _0024(commander self_)
			{
				_0024self__00242845 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242845.charging && Network.isServer)
					{
						int num = (_0024_00241031_00242843 = 15);
						Vector3 vector = (_0024_00241032_00242844 = _0024self__00242845.r.velocity);
						float num2 = (_0024_00241032_00242844.y = _0024_00241031_00242843);
						Vector3 vector3 = (_0024self__00242845.r.velocity = _0024_00241032_00242844);
						_0024self__00242845.charging = true;
						_0024self__00242845.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						_0024self__00242845.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024nuu_00242842 = UnityEngine.Random.Range(0, 3);
						if (_0024nuu_00242842 == 0)
						{
							_0024self__00242845.spdd = -4;
						}
						else
						{
							_0024self__00242845.spdd = 4;
						}
						result = (Yield(2, new WaitForSeconds(0.75f)) ? 1 : 0);
						break;
					}
					goto IL_0148;
				case 2:
					_0024self__00242845.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242845.charging = false;
					goto IL_0148;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0148:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal commander _0024self__00242846;

		public _0024ChargeLeft_00242841(commander self_)
		{
			_0024self__00242846 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242846);
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

	private bool canFire;

	public commander()
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
		SetStats(1500, 7, 0, 450, 10f, array, UnityEngine.Random.Range(6, 20), 450);
		StartCoroutine_Auto(Summon());
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public virtual IEnumerator Summon()
	{
		return new _0024Summon_00242831(this).GetEnumerator();
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
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 40f) && !knocking)
		{
			canFire = true;
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
		return new _0024ChargeRight_00242835(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242841(this).GetEnumerator();
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
