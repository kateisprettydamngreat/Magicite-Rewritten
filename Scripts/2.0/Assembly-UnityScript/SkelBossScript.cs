using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SkelBossScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242484 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242485;

			internal SkelBossScript _0024self__00242486;

			public _0024(SkelBossScript self_)
			{
				_0024self__00242486 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242486.@base.GetComponent<Animation>()["i"].layer = 0;
					_0024self__00242486.@base.GetComponent<Animation>()["r"].layer = 0;
					_0024self__00242486.@base.GetComponent<Animation>()["a"].layer = 1;
					_0024drops_00242485 = new int[3] { 7, 18, 0 };
					_0024self__00242486.SetStats(20, 1, 1, 3, 0f, _0024drops_00242485, UnityEngine.Random.Range(2, 6), 6);
					goto case 2;
				case 2:
					result = (Yield(2, _0024self__00242486.StartCoroutine_Auto(_0024self__00242486.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SkelBossScript _0024self__00242487;

		public _0024Start_00242484(SkelBossScript self_)
		{
			_0024self__00242487 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00242487);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242488 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242489;

			internal Ray _0024ray2_00242490;

			internal int _0024num_00242491;

			internal int _0024_0024905_00242492;

			internal Vector3 _0024_0024906_00242493;

			internal int _0024_0024907_00242494;

			internal Vector3 _0024_0024908_00242495;

			internal int _0024_0024909_00242496;

			internal Vector3 _0024_0024910_00242497;

			internal SkelBossScript _0024self__00242498;

			public _0024(SkelBossScript self_)
			{
				_0024self__00242498 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024ray_00242489 = new Ray(_0024self__00242498.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00242490 = new Ray(_0024self__00242498.t.position, new Vector3(-1f, 0f, 0f));
					_0024num_00242491 = default(int);
					if (Physics.Raycast(_0024ray_00242489, out _0024self__00242498.hit, 20f, 256))
					{
						_0024num_00242491 = UnityEngine.Random.Range(0, 5);
						if (_0024num_00242491 == 0)
						{
							_0024self__00242498.attacking = true;
							_0024self__00242498.@base.GetComponent<Animation>().Play("a");
							_0024self__00242498.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242498.attacking = true;
							_0024self__00242498.@base.GetComponent<Animation>().Play("r");
							result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
						}
						break;
					}
					if (Physics.Raycast(_0024ray2_00242490, out _0024self__00242498.hit, 20f, 256))
					{
						_0024num_00242491 = UnityEngine.Random.Range(0, 5);
						if (_0024num_00242491 == 0)
						{
							_0024self__00242498.attacking = true;
							_0024self__00242498.@base.GetComponent<Animation>().Play("a");
							_0024self__00242498.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
							result = (Yield(6, new WaitForSeconds(0.7f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242498.attacking = true;
							_0024self__00242498.@base.GetComponent<Animation>().Play("r");
							result = (Yield(8, new WaitForSeconds(0.5f)) ? 1 : 0);
						}
						break;
					}
					goto case 3;
				case 2:
					result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
				{
					_0024self__00242498.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					int num5 = (_0024_0024905_00242492 = 25);
					Vector3 vector7 = (_0024_0024906_00242493 = _0024self__00242498.r.velocity);
					float num6 = (_0024_0024906_00242493.x = _0024_0024905_00242492);
					Vector3 vector9 = (_0024self__00242498.r.velocity = _0024_0024906_00242493);
					result = (Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 6:
					result = (Yield(7, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 8:
				{
					_0024self__00242498.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					int num3 = (_0024_0024907_00242494 = -25);
					Vector3 vector4 = (_0024_0024908_00242495 = _0024self__00242498.r.velocity);
					float num4 = (_0024_0024908_00242495.x = _0024_0024907_00242494);
					Vector3 vector6 = (_0024self__00242498.r.velocity = _0024_0024908_00242495);
					result = (Yield(9, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 3:
				case 5:
				case 7:
				case 9:
					result = (Yield(10, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 10:
				{
					_0024self__00242498.attacking = false;
					int num = (_0024_0024909_00242496 = 0);
					Vector3 vector = (_0024_0024910_00242497 = _0024self__00242498.r.velocity);
					float num2 = (_0024_0024910_00242497.x = _0024_0024909_00242496);
					Vector3 vector3 = (_0024self__00242498.r.velocity = _0024_0024910_00242497);
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

		internal SkelBossScript _0024self__00242499;

		public _0024AttackCheck_00242488(SkelBossScript self_)
		{
			_0024self__00242499 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242499);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242500 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242501;

			internal int _0024dir_00242502;

			internal int _0024_0024911_00242503;

			internal Vector3 _0024_0024912_00242504;

			internal SkelBossScript _0024self__00242505;

			public _0024(SkelBossScript self_)
			{
				_0024self__00242505 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242505.attacking)
					{
						_0024self__00242505.GetComponent<AudioSource>().PlayOneShot(_0024self__00242505.a);
						_0024self__00242505.dir = 0;
						int num = (_0024_0024911_00242503 = 0);
						Vector3 vector = (_0024_0024912_00242504 = _0024self__00242505.GetComponent<Rigidbody>().velocity);
						float num2 = (_0024_0024912_00242504.x = _0024_0024911_00242503);
						Vector3 vector3 = (_0024self__00242505.GetComponent<Rigidbody>().velocity = _0024_0024912_00242504);
						result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(0, 3))) ? 1 : 0);
						break;
					}
					goto IL_00f7;
				case 2:
					_0024num_00242501 = UnityEngine.Random.Range(1, 2);
					_0024dir_00242502 = UnityEngine.Random.Range(1, 3);
					_0024self__00242505.moving = false;
					_0024self__00242505.dir = _0024dir_00242502;
					goto IL_00f7;
				case 3:
					YieldDefault(1);
					goto case 1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00f7:
					result = (Yield(3, new WaitForSeconds(_0024num_00242501)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SkelBossScript _0024self__00242506;

		public _0024MoveCheck_00242500(SkelBossScript self_)
		{
			_0024self__00242506 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242506);
		}
	}

	private RaycastHit hit;

	public GameObject boneThrowL;

	public GameObject boneThrowR;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242484(this).GetEnumerator();
	}

	public virtual IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242488(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242500(this).GetEnumerator();
	}
}
