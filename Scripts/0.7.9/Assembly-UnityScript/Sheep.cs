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
	internal sealed class _0024Start_00242384 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242385;

			internal Sheep _0024self__00242386;

			public _0024(Sheep self_)
			{
				_0024self__00242386 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024drops_00242385 = new int[3] { 7, 18, 20 };
					_0024self__00242386.SetStats(7, 1, 1, 3, 3f, _0024drops_00242385, Random.Range(2, 6), 2);
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242386).StartCoroutine_Auto(_0024self__00242386.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Sheep _0024self__00242387;

		public _0024Start_00242384(Sheep self_)
		{
			_0024self__00242387 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242387);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242388 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242389;

			internal int _0024dir_00242390;

			internal int _0024_0024897_00242391;

			internal Vector3 _0024_0024898_00242392;

			internal Sheep _0024self__00242393;

			public _0024(Sheep self_)
			{
				_0024self__00242393 = self_;
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
					_0024self__00242393.attacking = false;
					_0024self__00242393.moving = true;
					int num = (_0024_0024897_00242391 = 0);
					Vector3 val = (_0024_0024898_00242392 = _0024self__00242393._0024get_rigidbody_00242394().velocity);
					float num2 = (_0024_0024898_00242392.x = _0024_0024897_00242391);
					Vector3 val3 = (_0024self__00242393._0024get_rigidbody_00242395().velocity = _0024_0024898_00242392);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
					break;
				}
				case 2:
					_0024num_00242389 = Random.Range(0, 4);
					_0024dir_00242390 = Random.Range(1, 3);
					_0024self__00242393.dir = _0024dir_00242390;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00242389)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242393.moving = false;
					_0024self__00242393.dir = 0;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Sheep _0024self__00242396;

		public _0024MoveCheck_00242388(Sheep self_)
		{
			_0024self__00242396 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242396);
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242384(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242388(this).GetEnumerator();
	}

	internal Rigidbody _0024get_rigidbody_00242394()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00242395()
	{
		return ((Component)this).rigidbody;
	}
}
