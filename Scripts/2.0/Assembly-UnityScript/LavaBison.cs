using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class LavaBison : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241940 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00241941;

			internal LavaBison _0024self__00241942;

			public _0024(LavaBison self_)
			{
				_0024self__00241942 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241942.@base.GetComponent<Animation>()["i"].layer = 0;
					_0024self__00241942.@base.GetComponent<Animation>()["a"].layer = 1;
					_0024self__00241942.@base.GetComponent<Animation>()["r"].layer = 0;
					_0024drops_00241941 = new int[3] { 7, 19, 19 };
					_0024self__00241942.SetStats(150, 6, 2, 10, 2f, _0024drops_00241941, UnityEngine.Random.Range(10, 25), 10);
					goto case 3;
				case 3:
					result = (Yield(2, _0024self__00241942.StartCoroutine_Auto(_0024self__00241942.MoveCheck())) ? 1 : 0);
					break;
				case 2:
					result = (Yield(3, _0024self__00241942.StartCoroutine_Auto(_0024self__00241942.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00241943;

		public _0024Start_00241940(LavaBison self_)
		{
			_0024self__00241943 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00241943);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241944 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241945;

			internal Ray _0024ray2_00241946;

			internal int _0024_0024653_00241947;

			internal Vector3 _0024_0024654_00241948;

			internal LavaBison _0024self__00241949;

			public _0024(LavaBison self_)
			{
				_0024self__00241949 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00241949.isMonster)
					{
						_0024ray_00241945 = new Ray(_0024self__00241949.t.position, new Vector3(1f, 0f, 0f));
						_0024ray2_00241946 = new Ray(_0024self__00241949.t.position, new Vector3(-1f, 0f, 0f));
						if (Physics.Raycast(_0024ray_00241945, out _0024self__00241949.hit, 20f, 256))
						{
							_0024self__00241949.attacking = true;
							_0024self__00241949.@base.GetComponent<Animation>().Stop();
							_0024self__00241949.@base.GetComponent<Animation>().Play("a");
							_0024self__00241949.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00241946, out _0024self__00241949.hit, 20f, 256))
						{
							_0024self__00241949.attacking = true;
							_0024self__00241949.@base.GetComponent<Animation>().Stop();
							_0024self__00241949.@base.GetComponent<Animation>().Play("a");
							_0024self__00241949.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
							result = (Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
							break;
						}
					}
					goto IL_02b4;
				case 2:
					_0024self__00241949.@base.GetComponent<Animation>().Play("r");
					_0024self__00241949.atking = true;
					_0024self__00241949.spdd = 16f;
					result = (Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241949.atking = false;
					_0024self__00241949.spdd = 0f;
					_0024self__00241949.@base.GetComponent<Animation>().Play("i");
					goto IL_02b4;
				case 4:
					_0024self__00241949.@base.GetComponent<Animation>().Play("r");
					_0024self__00241949.atking = true;
					_0024self__00241949.spdd = -16f;
					result = (Yield(5, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241949.atking = false;
					_0024self__00241949.spdd = 0f;
					_0024self__00241949.@base.GetComponent<Animation>().Play("i");
					goto IL_02b4;
				case 6:
				{
					_0024self__00241949.attacking = false;
					int num = (_0024_0024653_00241947 = 0);
					Vector3 vector = (_0024_0024654_00241948 = _0024self__00241949.r.velocity);
					float num2 = (_0024_0024654_00241948.x = _0024_0024653_00241947);
					Vector3 vector3 = (_0024self__00241949.r.velocity = _0024_0024654_00241948);
					YieldDefault(1);
					goto case 1;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_02b4:
					result = (Yield(6, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00241950;

		public _0024AttackCheck_00241944(LavaBison self_)
		{
			_0024self__00241950 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241950);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241951 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal LavaBison _0024self__00241952;

			public _0024(LavaBison self_)
			{
				_0024self__00241952 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00241952.isMonster)
					{
						_0024self__00241952.atking = true;
					}
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241952.atking = false;
					_0024self__00241952.spdd = 0f;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00241953;

		public _0024MoveCheck_00241951(LavaBison self_)
		{
			_0024self__00241953 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241953);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00241954 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241955;

			internal Ray _0024ray2_00241956;

			internal LavaBison _0024self__00241957;

			public _0024(LavaBison self_)
			{
				_0024self__00241957 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024ray_00241955 = new Ray(_0024self__00241957.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00241956 = new Ray(_0024self__00241957.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241955, out _0024self__00241957.hit, 20f, 256))
					{
						_0024self__00241957.attacking = true;
						_0024self__00241957.@base.GetComponent<Animation>().Stop();
						_0024self__00241957.@base.GetComponent<Animation>().Play("a");
						_0024self__00241957.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241956, out _0024self__00241957.hit, 20f, 256))
					{
						_0024self__00241957.attacking = true;
						_0024self__00241957.@base.GetComponent<Animation>().Stop();
						_0024self__00241957.@base.GetComponent<Animation>().Play("a");
						_0024self__00241957.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_02a6;
				case 2:
					_0024self__00241957.@base.GetComponent<Animation>().Play("r");
					_0024self__00241957.atking = true;
					_0024self__00241957.spdd = 16f;
					result = (Yield(3, new WaitForSeconds(UnityEngine.Random.Range(1, 4))) ? 1 : 0);
					break;
				case 3:
					_0024self__00241957.atking = false;
					_0024self__00241957.spdd = 0f;
					_0024self__00241957.@base.GetComponent<Animation>().Play("i");
					goto IL_02a6;
				case 4:
					_0024self__00241957.@base.GetComponent<Animation>().Play("r");
					_0024self__00241957.atking = true;
					_0024self__00241957.spdd = -16f;
					result = (Yield(5, new WaitForSeconds(UnityEngine.Random.Range(1, 4))) ? 1 : 0);
					break;
				case 5:
					_0024self__00241957.atking = false;
					_0024self__00241957.spdd = 0f;
					_0024self__00241957.@base.GetComponent<Animation>().Play("i");
					goto IL_02a6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02a6:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00241958;

		public _0024ATK_00241954(LavaBison self_)
		{
			_0024self__00241958 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241958);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024T_00241959 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024655_00241960;

			internal Quaternion _0024_0024656_00241961;

			internal int _0024_0024657_00241962;

			internal Quaternion _0024_0024658_00241963;

			internal LavaBison _0024self__00241964;

			public _0024(LavaBison self_)
			{
				_0024self__00241964 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241964.turning)
					{
						_0024self__00241964.turning = true;
						if (_0024self__00241964.e.transform.rotation.y != 0f)
						{
							int num = (_0024_0024655_00241960 = 0);
							Quaternion quaternion = (_0024_0024656_00241961 = _0024self__00241964.e.transform.rotation);
							float num2 = (_0024_0024656_00241961.y = _0024_0024655_00241960);
							Quaternion quaternion3 = (_0024self__00241964.e.transform.rotation = _0024_0024656_00241961);
							_0024self__00241964.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						}
						else
						{
							int num3 = (_0024_0024657_00241962 = 180);
							Quaternion quaternion4 = (_0024_0024658_00241963 = _0024self__00241964.e.transform.rotation);
							float num4 = (_0024_0024658_00241963.y = _0024_0024657_00241962);
							Quaternion quaternion6 = (_0024self__00241964.e.transform.rotation = _0024_0024658_00241963);
							_0024self__00241964.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						}
						_0024self__00241964.spdd *= -1f;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_01aa;
				case 2:
					_0024self__00241964.turning = false;
					goto IL_01aa;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01aa:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00241965;

		public _0024T_00241959(LavaBison self_)
		{
			_0024self__00241965 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241965);
		}
	}

	private RaycastHit hit;

	private float spdd;

	private bool atking;

	private bool isMonster;

	private bool turning;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	public LavaBison()
	{
		mask2 = 2048;
	}

	public override void TD(int dmg)
	{
		if (!takingDamage)
		{
			if (!isMonster)
			{
				isMonster = true;
				gameObject.layer = 9;
			}
			GetComponent<AudioSource>().PlayOneShot(aHit);
			int num = dmg - DEF;
			if (num < 1)
			{
				num = 1;
			}
			GetComponent<NetworkView>().RPC("TDN", RPCMode.All, num);
			GetComponent<NetworkView>().RPC("TDN2", RPCMode.All, num);
		}
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241940(this).GetEnumerator();
	}

	public virtual IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241944(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241951(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator ATK()
	{
		return new _0024ATK_00241954(this).GetEnumerator();
	}

	public virtual IEnumerator T()
	{
		return new _0024T_00241959(this).GetEnumerator();
	}

	[RPC]
	public virtual void Turn(int dir)
	{
		if (dir == 0)
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

	public override void Update()
	{
		r1U.origin = transform.position;
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		r2U.direction = Vector3.right;
		if (atking && Network.isServer)
		{
			float x = spdd;
			Vector3 velocity = r.velocity;
			float num = (velocity.x = x);
			Vector3 vector2 = (r.velocity = velocity);
		}
		if (Physics.Raycast(r1U, 1.5f, mask2) && !turning && e.transform.rotation.y == 0f && Network.isServer)
		{
			StartCoroutine_Auto(T());
		}
		if (Physics.Raycast(r2U, 1.5f, mask2) && !turning && e.transform.rotation.y != 0f && Network.isServer)
		{
			StartCoroutine_Auto(T());
		}
	}

	public override void Main()
	{
	}
}
