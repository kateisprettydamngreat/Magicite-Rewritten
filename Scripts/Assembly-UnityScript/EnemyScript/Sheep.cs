using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Sheep : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242408 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242409;

			internal Sheep _0024self__00242410;

			public _0024(Sheep self_)
			{
				_0024self__00242410 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024drops_00242409 = new int[3] { 7, 18, 20 };
					_0024self__00242410.SetStats(7, 1, 1, 3, 3f, _0024drops_00242409, UnityEngine.Random.Range(2, 6), 2);
					goto case 2;
				case 2:
					result = (Yield(2, _0024self__00242410.StartCoroutine_Auto(_0024self__00242410.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Sheep _0024self__00242411;

		public _0024Start_00242408(Sheep self_)
		{
			_0024self__00242411 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00242411);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242412 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242413;

			internal int _0024dir_00242414;

			internal int _0024_0024869_00242415;

			internal Vector3 _0024_0024870_00242416;

			internal Sheep _0024self__00242417;

			public _0024(Sheep self_)
			{
				_0024self__00242417 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					_0024self__00242417.attacking = false;
					_0024self__00242417.moving = true;
					int num = (_0024_0024869_00242415 = 0);
					Vector3 vector = (_0024_0024870_00242416 = _0024self__00242417.GetComponent<Rigidbody>().velocity);
					float num2 = (_0024_0024870_00242416.x = _0024_0024869_00242415);
					Vector3 vector3 = (_0024self__00242417.GetComponent<Rigidbody>().velocity = _0024_0024870_00242416);
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(0, 3))) ? 1 : 0);
					break;
				}
				case 2:
					_0024num_00242413 = UnityEngine.Random.Range(0, 4);
					_0024dir_00242414 = UnityEngine.Random.Range(1, 3);
					_0024self__00242417.dir = _0024dir_00242414;
					result = (Yield(3, new WaitForSeconds(_0024num_00242413)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242417.moving = false;
					_0024self__00242417.dir = 0;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Sheep _0024self__00242418;

		public _0024MoveCheck_00242412(Sheep self_)
		{
			_0024self__00242418 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242418);
		}
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242408(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242412(this).GetEnumerator();
	}
}
