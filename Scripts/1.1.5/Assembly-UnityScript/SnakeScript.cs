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
	internal sealed class _0024Start_00242741 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242742;

			internal SnakeScript _0024self__00242743;

			public _0024(SnakeScript self_)
			{
				_0024self__00242743 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242743.canChange = true;
					_0024self__00242743.@base.animation["i"].layer = 0;
					_0024drops_00242742 = new int[3] { 7, 18, 0 };
					_0024self__00242743.SetStats(354, 1, 1, 3, 6f, _0024drops_00242742, Random.Range(2, 6), 3);
					_0024self__00242743.moving = true;
					_0024self__00242743.dir = Random.Range(1, 3);
					((MonoBehaviour)_0024self__00242743).StartCoroutine_Auto(_0024self__00242743.Check());
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242743).StartCoroutine_Auto(_0024self__00242743.ChangeDir())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnakeScript _0024self__00242744;

		public _0024Start_00242741(SnakeScript self_)
		{
			_0024self__00242744 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242744);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00242745 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SnakeScript _0024self__00242746;

			public _0024(SnakeScript self_)
			{
				_0024self__00242746 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024self__00242746.t.position.x == _0024self__00242746.prev)
					{
						((MonoBehaviour)_0024self__00242746).StartCoroutine_Auto(_0024self__00242746.ChangeDir());
					}
					_0024self__00242746.prev = _0024self__00242746.t.position.x;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnakeScript _0024self__00242747;

		public _0024Check_00242745(SnakeScript self_)
		{
			_0024self__00242747 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242747);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChangeDir_00242748 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SnakeScript _0024self__00242749;

			public _0024(SnakeScript self_)
			{
				_0024self__00242749 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_0030: Expected O, but got Unknown
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(3, 10))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242749.canChange = false;
					if (_0024self__00242749.dir == 1)
					{
						_0024self__00242749.dir = 2;
					}
					else
					{
						_0024self__00242749.dir = 1;
					}
					_0024self__00242749.SPD += 3;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242749.SPD -= 3;
					_0024self__00242749.canChange = true;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnakeScript _0024self__00242750;

		public _0024ChangeDir_00242748(SnakeScript self_)
		{
			_0024self__00242750 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242750);
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

	public override IEnumerator Start()
	{
		return new _0024Start_00242741(this).GetEnumerator();
	}

	public override IEnumerator Check()
	{
		return new _0024Check_00242745(this).GetEnumerator();
	}

	public override IEnumerator ChangeDir()
	{
		return new _0024ChangeDir_00242748(this).GetEnumerator();
	}
}
