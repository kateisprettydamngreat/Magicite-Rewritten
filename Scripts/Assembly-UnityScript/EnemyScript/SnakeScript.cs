using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SnakeScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242562 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242563;

			internal SnakeScript _0024self__00242564;

			public _0024(SnakeScript self_)
			{
				_0024self__00242564 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242564.canChange = true;
					_0024self__00242564.@base.GetComponent<Animation>()["i"].layer = 0;
					_0024drops_00242563 = new int[3] { 7, 18, 0 };
					_0024self__00242564.SetStats(354, 1, 1, 3, 6f, _0024drops_00242563, UnityEngine.Random.Range(2, 6), 3);
					_0024self__00242564.moving = true;
					_0024self__00242564.dir = UnityEngine.Random.Range(1, 3);
					_0024self__00242564.StartCoroutine_Auto(_0024self__00242564.Check());
					goto case 2;
				case 2:
					result = (Yield(2, _0024self__00242564.StartCoroutine_Auto(_0024self__00242564.ChangeDir())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnakeScript _0024self__00242565;

		public _0024Start_00242562(SnakeScript self_)
		{
			_0024self__00242565 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00242565);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00242566 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SnakeScript _0024self__00242567;

			public _0024(SnakeScript self_)
			{
				_0024self__00242567 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242567.t.position.x == _0024self__00242567.prev)
					{
						_0024self__00242567.StartCoroutine_Auto(_0024self__00242567.ChangeDir());
					}
					_0024self__00242567.prev = _0024self__00242567.t.position.x;
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnakeScript _0024self__00242568;

		public _0024Check_00242566(SnakeScript self_)
		{
			_0024self__00242568 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242568);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChangeDir_00242569 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SnakeScript _0024self__00242570;

			public _0024(SnakeScript self_)
			{
				_0024self__00242570 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(3, 10))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242570.canChange = false;
					if (_0024self__00242570.dir == 1)
					{
						_0024self__00242570.dir = 2;
					}
					else
					{
						_0024self__00242570.dir = 1;
					}
					_0024self__00242570.SPD += 3;
					result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242570.SPD -= 3;
					_0024self__00242570.canChange = true;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnakeScript _0024self__00242571;

		public _0024ChangeDir_00242569(SnakeScript self_)
		{
			_0024self__00242571 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242571);
		}
	}

	private RaycastHit hit;

	private bool canChange;

	private Ray ray;

	private Ray ray2;

	private float prev;

	public SnakeScript()
	{
		prev = 1f;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242562(this).GetEnumerator();
	}

	public virtual IEnumerator Check()
	{
		return new _0024Check_00242566(this).GetEnumerator();
	}

	public virtual IEnumerator ChangeDir()
	{
		return new _0024ChangeDir_00242569(this).GetEnumerator();
	}
}
