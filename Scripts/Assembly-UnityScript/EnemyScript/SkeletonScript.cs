using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SkeletonScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242507 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242508;

			internal SkeletonScript _0024self__00242509;

			public _0024(SkeletonScript self_)
			{
				_0024self__00242509 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242509.@base.GetComponent<Animation>()["i"].layer = 0;
					_0024self__00242509.@base.GetComponent<Animation>()["a"].layer = 1;
					_0024drops_00242508 = new int[3] { 7, 18, 0 };
					_0024self__00242509.SetStats(50, 10, 10, 8, 4f, _0024drops_00242508, UnityEngine.Random.Range(7, 16), 8);
					goto case 3;
				case 3:
					result = (Yield(2, _0024self__00242509.StartCoroutine_Auto(_0024self__00242509.MoveCheck())) ? 1 : 0);
					break;
				case 2:
					result = (Yield(3, _0024self__00242509.StartCoroutine_Auto(_0024self__00242509.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SkeletonScript _0024self__00242510;

		public _0024Start_00242507(SkeletonScript self_)
		{
			_0024self__00242510 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00242510);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242511 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024913_00242512;

			internal Vector3 _0024_0024914_00242513;

			internal SkeletonScript _0024self__00242514;

			public _0024(SkeletonScript self_)
			{
				_0024self__00242514 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (Network.isServer)
					{
						_0024self__00242514.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					}
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00242514.attacking = false;
					int num = (_0024_0024913_00242512 = 0);
					Vector3 vector = (_0024_0024914_00242513 = _0024self__00242514.r.velocity);
					float num2 = (_0024_0024914_00242513.x = _0024_0024913_00242512);
					Vector3 vector3 = (_0024self__00242514.r.velocity = _0024_0024914_00242513);
					YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SkeletonScript _0024self__00242515;

		public _0024AttackCheck_00242511(SkeletonScript self_)
		{
			_0024self__00242515 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242515);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242516 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242517;

			internal int _0024dir_00242518;

			internal int _0024_0024915_00242519;

			internal Vector3 _0024_0024916_00242520;

			internal SkeletonScript _0024self__00242521;

			public _0024(SkeletonScript self_)
			{
				_0024self__00242521 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242521.attacking)
					{
						_0024self__00242521.moving = true;
						int num = (_0024_0024915_00242519 = 0);
						Vector3 vector = (_0024_0024916_00242520 = _0024self__00242521.GetComponent<Rigidbody>().velocity);
						float num2 = (_0024_0024916_00242520.x = _0024_0024915_00242519);
						Vector3 vector3 = (_0024self__00242521.GetComponent<Rigidbody>().velocity = _0024_0024916_00242520);
						result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(0, 3))) ? 1 : 0);
					}
					else
					{
						result = (Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024num_00242517 = UnityEngine.Random.Range(0, 4);
					_0024dir_00242518 = UnityEngine.Random.Range(1, 3);
					_0024self__00242521.dir = _0024dir_00242518;
					result = (Yield(3, new WaitForSeconds(_0024num_00242517)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242521.moving = false;
					_0024self__00242521.dir = 0;
					goto case 4;
				case 4:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SkeletonScript _0024self__00242522;

		public _0024MoveCheck_00242516(SkeletonScript self_)
		{
			_0024self__00242522 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242522);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242523 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024startPos_00242524;

			internal Ray _0024ray_00242525;

			internal Ray _0024ray2_00242526;

			internal SkeletonScript _0024self__00242527;

			public _0024(SkeletonScript self_)
			{
				_0024self__00242527 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024startPos_00242524 = new Vector3(_0024self__00242527.t.position.x, _0024self__00242527.t.position.y - 0.5f, 0f);
					_0024ray_00242525 = new Ray(_0024startPos_00242524, new Vector3(1f, 0f, 0f));
					_0024ray2_00242526 = new Ray(_0024startPos_00242524, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00242525, out _0024self__00242527.hit, 10f, 256))
					{
						_0024self__00242527.attacking = true;
						_0024self__00242527.@base.GetComponent<Animation>().Stop();
						_0024self__00242527.@base.GetComponent<Animation>().Play("a");
						_0024self__00242527.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242526, out _0024self__00242527.hit, 10f, 256))
					{
						_0024self__00242527.attacking = true;
						_0024self__00242527.@base.GetComponent<Animation>().Stop();
						_0024self__00242527.@base.GetComponent<Animation>().Play("a");
						_0024self__00242527.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 2;
				case 2:
				case 3:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SkeletonScript _0024self__00242528;

		public _0024ATK_00242523(SkeletonScript self_)
		{
			_0024self__00242528 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242528);
		}
	}

	private RaycastHit hit;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242507(this).GetEnumerator();
	}

	public virtual IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242511(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242516(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator ATK()
	{
		return new _0024ATK_00242523(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
