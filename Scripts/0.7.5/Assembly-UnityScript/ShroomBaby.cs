using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ShroomBaby : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242356 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal int[] _0024drops_00242357;

			internal ShroomBaby _0024self__00242358;

			public _0024(ShroomBaby self_)
			{
				_0024self__00242358 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForSeconds((float)Random.Range(0, 6))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242358.@base.animation["i"].speed = 0.5f;
					_0024drops_00242357 = new int[3] { 9, 0, 15 };
					_0024self__00242358.SetStats(15, 4, 0, 5, 4f, _0024drops_00242357, Random.Range(5, 15), 7);
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)(object)((MonoBehaviour)_0024self__00242358).StartCoroutine_Auto(_0024self__00242358.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ShroomBaby _0024self__00242359;

		public _0024Start_00242356(ShroomBaby self_)
		{
			_0024self__00242359 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00242359);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242360 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242361;

			internal int _0024_0024890_00242362;

			internal Vector3 _0024_0024891_00242363;

			internal int _0024_0024892_00242364;

			internal Vector3 _0024_0024893_00242365;

			internal int _0024_0024894_00242366;

			internal Vector3 _0024_0024895_00242367;

			internal int _0024_0024896_00242368;

			internal Vector3 _0024_0024897_00242369;

			internal ShroomBaby _0024self__00242370;

			public _0024(ShroomBaby self_)
			{
				_0024self__00242370 = self_;
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
					_0024num_00242361 = Random.Range(0, 2);
					if (_0024num_00242361 != 0)
					{
						int num = (_0024_0024894_00242366 = -10);
						Vector3 val = (_0024_0024895_00242367 = ((Component)_0024self__00242370).rigidbody.velocity);
						float num2 = (_0024_0024895_00242367.x = _0024_0024894_00242366);
						Vector3 val3 = (((Component)_0024self__00242370).rigidbody.velocity = _0024_0024895_00242367);
						int num3 = (_0024_0024896_00242368 = Random.Range(10, 16));
						Vector3 val4 = (_0024_0024897_00242369 = ((Component)_0024self__00242370).rigidbody.velocity);
						float num4 = (_0024_0024897_00242369.y = _0024_0024896_00242368);
						Vector3 val6 = (((Component)_0024self__00242370).rigidbody.velocity = _0024_0024897_00242369);
					}
					else
					{
						int num5 = (_0024_0024890_00242362 = 10);
						Vector3 val7 = (_0024_0024891_00242363 = ((Component)_0024self__00242370).rigidbody.velocity);
						float num6 = (_0024_0024891_00242363.x = _0024_0024890_00242362);
						Vector3 val9 = (((Component)_0024self__00242370).rigidbody.velocity = _0024_0024891_00242363);
						int num7 = (_0024_0024892_00242364 = Random.Range(10, 16));
						Vector3 val10 = (_0024_0024893_00242365 = ((Component)_0024self__00242370).rigidbody.velocity);
						float num8 = (_0024_0024893_00242365.y = _0024_0024892_00242364);
						Vector3 val12 = (((Component)_0024self__00242370).rigidbody.velocity = _0024_0024893_00242365);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
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

		internal ShroomBaby _0024self__00242371;

		public _0024MoveCheck_00242360(ShroomBaby self_)
		{
			_0024self__00242371 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242371);
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242356(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242360(this).GetEnumerator();
	}
}
