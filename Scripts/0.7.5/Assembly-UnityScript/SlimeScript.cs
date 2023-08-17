using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlimeScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242443 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal int[] _0024drops_00242444;

			internal SlimeScript _0024self__00242445;

			public _0024(SlimeScript self_)
			{
				_0024self__00242445 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242445.@base.animation["i"].speed = 0.5f;
					_0024drops_00242444 = new int[3] { 9, 0, 15 };
					_0024self__00242445.SetStats(10, 1, 0, 3, 4f, _0024drops_00242444, Random.Range(5, 15), 3);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForSeconds((float)Random.Range(0, 6))) ? 1 : 0);
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)(object)((MonoBehaviour)_0024self__00242445).StartCoroutine_Auto(_0024self__00242445.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SlimeScript _0024self__00242446;

		public _0024Start_00242443(SlimeScript self_)
		{
			_0024self__00242446 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00242446);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242447 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242448;

			internal int _0024_0024924_00242449;

			internal Vector3 _0024_0024925_00242450;

			internal int _0024_0024926_00242451;

			internal Vector3 _0024_0024927_00242452;

			internal int _0024_0024928_00242453;

			internal Vector3 _0024_0024929_00242454;

			internal int _0024_0024930_00242455;

			internal Vector3 _0024_0024931_00242456;

			internal SlimeScript _0024self__00242457;

			public _0024(SlimeScript self_)
			{
				_0024self__00242457 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0109: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0111: Unknown result type (might be due to invalid IL or missing references)
				//IL_0116: Unknown result type (might be due to invalid IL or missing references)
				//IL_013d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0142: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Unknown result type (might be due to invalid IL or missing references)
				//IL_016e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0173: Unknown result type (might be due to invalid IL or missing references)
				//IL_0174: Unknown result type (might be due to invalid IL or missing references)
				//IL_0176: Unknown result type (might be due to invalid IL or missing references)
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01af: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024num_00242448 = Random.Range(0, 2);
					if (_0024num_00242448 != 0)
					{
						int num = (_0024_0024928_00242453 = -10);
						Vector3 val = (_0024_0024929_00242454 = ((Component)_0024self__00242457).rigidbody.velocity);
						float num2 = (_0024_0024929_00242454.x = _0024_0024928_00242453);
						Vector3 val3 = (((Component)_0024self__00242457).rigidbody.velocity = _0024_0024929_00242454);
						int num3 = (_0024_0024930_00242455 = Random.Range(10, 16));
						Vector3 val4 = (_0024_0024931_00242456 = ((Component)_0024self__00242457).rigidbody.velocity);
						float num4 = (_0024_0024931_00242456.y = _0024_0024930_00242455);
						Vector3 val6 = (((Component)_0024self__00242457).rigidbody.velocity = _0024_0024931_00242456);
					}
					else
					{
						int num5 = (_0024_0024924_00242449 = 10);
						Vector3 val7 = (_0024_0024925_00242450 = ((Component)_0024self__00242457).rigidbody.velocity);
						float num6 = (_0024_0024925_00242450.x = _0024_0024924_00242449);
						Vector3 val9 = (((Component)_0024self__00242457).rigidbody.velocity = _0024_0024925_00242450);
						int num7 = (_0024_0024926_00242451 = Random.Range(10, 16));
						Vector3 val10 = (_0024_0024927_00242452 = ((Component)_0024self__00242457).rigidbody.velocity);
						float num8 = (_0024_0024927_00242452.y = _0024_0024926_00242451);
						Vector3 val12 = (((Component)_0024self__00242457).rigidbody.velocity = _0024_0024927_00242452);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SlimeScript _0024self__00242458;

		public _0024MoveCheck_00242447(SlimeScript self_)
		{
			_0024self__00242458 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242458);
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242443(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242447(this).GetEnumerator();
	}
}
