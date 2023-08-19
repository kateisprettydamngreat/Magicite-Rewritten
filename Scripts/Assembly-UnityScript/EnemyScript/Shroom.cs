using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Shroom : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FaceRight_00242428 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024875_00242429;

			internal Vector3 _0024_0024876_00242430;

			internal Shroom _0024self__00242431;

			public _0024(Shroom self_)
			{
				_0024self__00242431 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242431.atking && Network.isServer && !_0024self__00242431.running)
					{
						int num = (_0024_0024875_00242429 = 8);
						Vector3 vector = (_0024_0024876_00242430 = _0024self__00242431.r.velocity);
						float num2 = (_0024_0024876_00242430.y = _0024_0024875_00242429);
						Vector3 vector3 = (_0024self__00242431.r.velocity = _0024_0024876_00242430);
						_0024self__00242431.running = true;
						_0024self__00242431.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						_0024self__00242431.GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
						_0024self__00242431.spdd = UnityEngine.Random.Range(-1, 2) * 4;
						if (_0024self__00242431.spdd == 0)
						{
							_0024self__00242431.spdd = 4;
						}
						result = (Yield(2, new WaitForSeconds((float)UnityEngine.Random.Range(1, 3) * 0.3f)) ? 1 : 0);
						break;
					}
					goto IL_015a;
				case 2:
					_0024self__00242431.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242431.running = false;
					goto IL_015a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_015a:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Shroom _0024self__00242432;

		public _0024FaceRight_00242428(Shroom self_)
		{
			_0024self__00242432 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242432);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FaceLeft_00242433 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024877_00242434;

			internal Vector3 _0024_0024878_00242435;

			internal Shroom _0024self__00242436;

			public _0024(Shroom self_)
			{
				_0024self__00242436 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242436.atking && Network.isServer && !_0024self__00242436.running)
					{
						int num = (_0024_0024877_00242434 = 8);
						Vector3 vector = (_0024_0024878_00242435 = _0024self__00242436.r.velocity);
						float num2 = (_0024_0024878_00242435.y = _0024_0024877_00242434);
						Vector3 vector3 = (_0024self__00242436.r.velocity = _0024_0024878_00242435);
						_0024self__00242436.running = true;
						_0024self__00242436.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						_0024self__00242436.GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
						_0024self__00242436.spdd = UnityEngine.Random.Range(-1, 2) * 4;
						if (_0024self__00242436.spdd == 0)
						{
							_0024self__00242436.spdd = -4;
						}
						result = (Yield(2, new WaitForSeconds((float)UnityEngine.Random.Range(1, 2) * 0.3f)) ? 1 : 0);
						break;
					}
					goto IL_015b;
				case 2:
					_0024self__00242436.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242436.running = false;
					goto IL_015b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_015b:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Shroom _0024self__00242437;

		public _0024FaceLeft_00242433(Shroom self_)
		{
			_0024self__00242437 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242437);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TRY_00242438 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Shroom _0024self__00242439;

			public _0024(Shroom self_)
			{
				_0024self__00242439 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242439.TRYatking = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Shroom _0024self__00242440;

		public _0024TRY_00242438(Shroom self_)
		{
			_0024self__00242440 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242440);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATTACK_00242441 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Shroom _0024self__00242442;

			public _0024(Shroom self_)
			{
				_0024self__00242442 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242442.atking = true;
					_0024self__00242442.spdd = 0;
					_0024self__00242442.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					result = (Yield(2, new WaitForSeconds(0.35f)) ? 1 : 0);
					break;
				case 2:
					result = (Yield(3, new WaitForSeconds(1.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242442.atking = false;
					_0024self__00242442.TRYatking = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Shroom _0024self__00242443;

		public _0024ATTACK_00242441(Shroom self_)
		{
			_0024self__00242443 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242443);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242444 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Shroom _0024self__00242445;

			public _0024(Shroom self_)
			{
				_0024self__00242445 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242445.@base.GetComponent<Animation>().Play("r");
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242445.swordBox.SetActive(value: true);
					result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242445.swordBox.SetActive(value: false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Shroom _0024self__00242446;

		public _0024ATK_00242444(Shroom self_)
		{
			_0024self__00242446 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242446);
		}
	}

	public GameObject swordBox;

	public AudioClip audioMove;

	public AudioClip audioAttack;

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

	private bool TRYatking;

	public Shroom()
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
		SetStats(50, 4, 0, 4, 10f, array, UnityEngine.Random.Range(6, 20), 4);
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 1;
		@base.GetComponent<Animation>()["r"].speed = 0.5f;
		@base.GetComponent<Animation>()["a"].speed = 2f;
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			int num = (int)Mathf.Abs(player.transform.position.x - t.position.x);
			if (num < 20 && !knocking)
			{
				if (!(player.transform.position.x <= t.position.x))
				{
					StartCoroutine_Auto(FaceRight());
				}
				else
				{
					StartCoroutine_Auto(FaceLeft());
				}
				if (num < 7 && !TRYatking && !atking)
				{
					TRYatking = true;
					if (UnityEngine.Random.Range(0, 3) == 0)
					{
						StartCoroutine_Auto(ATTACK());
					}
					else
					{
						StartCoroutine_Auto(TRY());
					}
				}
			}
		}
		if (running && !knocking)
		{
			int num2 = spdd;
			Vector3 velocity = r.velocity;
			float num3 = (velocity.x = num2);
			Vector3 vector2 = (r.velocity = velocity);
		}
	}

	public virtual IEnumerator FaceRight()
	{
		return new _0024FaceRight_00242428(this).GetEnumerator();
	}

	public virtual IEnumerator FaceLeft()
	{
		return new _0024FaceLeft_00242433(this).GetEnumerator();
	}

	public virtual IEnumerator TRY()
	{
		return new _0024TRY_00242438(this).GetEnumerator();
	}

	public virtual IEnumerator ATTACK()
	{
		return new _0024ATTACK_00242441(this).GetEnumerator();
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
	public virtual void RUN()
	{
		@base.GetComponent<Animation>().Play("a");
	}

	[RPC]
	public virtual IEnumerator ATK()
	{
		return new _0024ATK_00242444(this).GetEnumerator();
	}

	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}
}
