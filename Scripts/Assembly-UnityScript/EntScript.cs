using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EntScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241434 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int[] _0024drops_00241435;

			internal EntScript _0024self__00241436;

			public _0024(EntScript self_)
			{
				_0024self__00241436 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241436.@base.GetComponent<Animation>()["i"].layer = 0;
					_0024drops_00241435 = new int[3] { 7, 18, 0 };
					_0024self__00241436.SetStats(10, 1, 1, 3, 2f, _0024drops_00241435, UnityEngine.Random.Range(2, 6), 3);
					goto case 2;
				case 2:
					_0024self__00241436.StartCoroutine_Auto(_0024self__00241436.AttackCheck());
					result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EntScript _0024self__00241437;

		public _0024Start_00241434(EntScript self_)
		{
			_0024self__00241437 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241437);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241438 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241439;

			internal Ray _0024ray2_00241440;

			internal int _0024_0024521_00241441;

			internal Vector3 _0024_0024522_00241442;

			internal int _0024_0024523_00241443;

			internal Vector3 _0024_0024524_00241444;

			internal int _0024_0024525_00241445;

			internal Vector3 _0024_0024526_00241446;

			internal int _0024_0024527_00241447;

			internal Vector3 _0024_0024528_00241448;

			internal int _0024_0024529_00241449;

			internal Vector3 _0024_0024530_00241450;

			internal EntScript _0024self__00241451;

			public _0024(EntScript self_)
			{
				_0024self__00241451 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024ray_00241439 = new Ray(_0024self__00241451.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00241440 = new Ray(_0024self__00241451.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241439, out _0024self__00241451.hit, 10f, 256))
					{
						_0024self__00241451.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						int num3 = (_0024_0024521_00241441 = UnityEngine.Random.Range(5, 10));
						Vector3 vector4 = (_0024_0024522_00241442 = _0024self__00241451.r.velocity);
						float num4 = (_0024_0024522_00241442.y = _0024_0024521_00241441);
						Vector3 vector6 = (_0024self__00241451.r.velocity = _0024_0024522_00241442);
						int num5 = (_0024_0024523_00241443 = 10);
						Vector3 vector7 = (_0024_0024524_00241444 = _0024self__00241451.r.velocity);
						float num6 = (_0024_0024524_00241444.x = _0024_0024523_00241443);
						Vector3 vector9 = (_0024self__00241451.r.velocity = _0024_0024524_00241444);
					}
					else if (Physics.Raycast(_0024ray2_00241440, out _0024self__00241451.hit, 10f, 256))
					{
						_0024self__00241451.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						int num7 = (_0024_0024525_00241445 = UnityEngine.Random.Range(5, 10));
						Vector3 vector10 = (_0024_0024526_00241446 = _0024self__00241451.r.velocity);
						float num8 = (_0024_0024526_00241446.y = _0024_0024525_00241445);
						Vector3 vector12 = (_0024self__00241451.r.velocity = _0024_0024526_00241446);
						int num9 = (_0024_0024527_00241447 = -10);
						Vector3 vector13 = (_0024_0024528_00241448 = _0024self__00241451.r.velocity);
						float num10 = (_0024_0024528_00241448.x = _0024_0024527_00241447);
						Vector3 vector15 = (_0024self__00241451.r.velocity = _0024_0024528_00241448);
					}
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241451.attacking = false;
					int num = (_0024_0024529_00241449 = 0);
					Vector3 vector = (_0024_0024530_00241450 = _0024self__00241451.r.velocity);
					float num2 = (_0024_0024530_00241450.x = _0024_0024529_00241449);
					Vector3 vector3 = (_0024self__00241451.r.velocity = _0024_0024530_00241450);
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

		internal EntScript _0024self__00241452;

		public _0024AttackCheck_00241438(EntScript self_)
		{
			_0024self__00241452 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241452);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241453 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241454;

			internal int _0024dir_00241455;

			internal int _0024_0024531_00241456;

			internal Vector3 _0024_0024532_00241457;

			internal EntScript _0024self__00241458;

			public _0024(EntScript self_)
			{
				_0024self__00241458 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241458.attacking)
					{
						_0024self__00241458.GetComponent<AudioSource>().PlayOneShot(_0024self__00241458.a);
						_0024self__00241458.dir = 0;
						int num = (_0024_0024531_00241456 = 0);
						Vector3 vector = (_0024_0024532_00241457 = _0024self__00241458.GetComponent<Rigidbody>().velocity);
						float num2 = (_0024_0024532_00241457.x = _0024_0024531_00241456);
						Vector3 vector3 = (_0024self__00241458.GetComponent<Rigidbody>().velocity = _0024_0024532_00241457);
						result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(0, 3))) ? 1 : 0);
						break;
					}
					goto IL_00f7;
				case 2:
					_0024num_00241454 = UnityEngine.Random.Range(1, 2);
					_0024dir_00241455 = UnityEngine.Random.Range(1, 3);
					_0024self__00241458.moving = false;
					_0024self__00241458.dir = _0024dir_00241455;
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
					result = (Yield(3, new WaitForSeconds(_0024num_00241454)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EntScript _0024self__00241459;

		public _0024MoveCheck_00241453(EntScript self_)
		{
			_0024self__00241459 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241459);
		}
	}

	private RaycastHit hit;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241434(this).GetEnumerator();
	}

	public virtual IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241438(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241453(this).GetEnumerator();
	}
}
