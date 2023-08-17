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
	internal sealed class _0024Start_00242559 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242560;

			internal Sheep _0024self__00242561;

			public _0024(Sheep self_)
			{
				_0024self__00242561 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024drops_00242560 = new int[3] { 7, 18, 20 };
					_0024self__00242561.SetStats(7, 1, 1, 3, 3f, _0024drops_00242560, Random.Range(2, 6), 2);
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242561).StartCoroutine_Auto(_0024self__00242561.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Sheep _0024self__00242562;

		public _0024Start_00242559(Sheep self_)
		{
			_0024self__00242562 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242562);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242563 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242564;

			internal int _0024dir_00242565;

			internal int _0024_0024947_00242566;

			internal Vector3 _0024_0024948_00242567;

			internal Sheep _0024self__00242568;

			public _0024(Sheep self_)
			{
				_0024self__00242568 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_009c: Expected O, but got Unknown
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					_0024self__00242568.attacking = false;
					_0024self__00242568.moving = true;
					int num = (_0024_0024947_00242566 = 0);
					Vector3 val = (_0024_0024948_00242567 = _0024self__00242568._0024get_rigidbody_00242569().velocity);
					float num2 = (_0024_0024948_00242567.x = _0024_0024947_00242566);
					Vector3 val3 = (_0024self__00242568._0024get_rigidbody_00242570().velocity = _0024_0024948_00242567);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
					break;
				}
				case 2:
					_0024num_00242564 = Random.Range(0, 4);
					_0024dir_00242565 = Random.Range(1, 3);
					_0024self__00242568.dir = _0024dir_00242565;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00242564)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242568.moving = false;
					_0024self__00242568.dir = 0;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Sheep _0024self__00242571;

		public _0024MoveCheck_00242563(Sheep self_)
		{
			_0024self__00242571 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242571);
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242559(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242563(this).GetEnumerator();
	}

	internal Rigidbody _0024get_rigidbody_00242569()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00242570()
	{
		return ((Component)this).rigidbody;
	}
}
