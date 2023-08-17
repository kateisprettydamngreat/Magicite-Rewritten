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
	internal sealed class _0024Start_00242609 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal ShroomBaby _0024self__00242610;

			public _0024(ShroomBaby self_)
			{
				_0024self__00242610 = self_;
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
					_0024self__00242610.@base.animation["i"].speed = 0.5f;
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)(object)((MonoBehaviour)_0024self__00242610).StartCoroutine_Auto(_0024self__00242610.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ShroomBaby _0024self__00242611;

		public _0024Start_00242609(ShroomBaby self_)
		{
			_0024self__00242611 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00242611);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242612 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242613;

			internal int _0024_0024966_00242614;

			internal Vector3 _0024_0024967_00242615;

			internal int _0024_0024968_00242616;

			internal Vector3 _0024_0024969_00242617;

			internal int _0024_0024970_00242618;

			internal Vector3 _0024_0024971_00242619;

			internal int _0024_0024972_00242620;

			internal Vector3 _0024_0024973_00242621;

			internal ShroomBaby _0024self__00242622;

			public _0024(ShroomBaby self_)
			{
				_0024self__00242622 = self_;
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
					_0024num_00242613 = Random.Range(0, 2);
					if (_0024num_00242613 != 0)
					{
						int num = (_0024_0024970_00242618 = -10);
						Vector3 val = (_0024_0024971_00242619 = ((Component)_0024self__00242622).rigidbody.velocity);
						float num2 = (_0024_0024971_00242619.x = _0024_0024970_00242618);
						Vector3 val3 = (((Component)_0024self__00242622).rigidbody.velocity = _0024_0024971_00242619);
						int num3 = (_0024_0024972_00242620 = Random.Range(10, 16));
						Vector3 val4 = (_0024_0024973_00242621 = ((Component)_0024self__00242622).rigidbody.velocity);
						float num4 = (_0024_0024973_00242621.y = _0024_0024972_00242620);
						Vector3 val6 = (((Component)_0024self__00242622).rigidbody.velocity = _0024_0024973_00242621);
					}
					else
					{
						int num5 = (_0024_0024966_00242614 = 10);
						Vector3 val7 = (_0024_0024967_00242615 = ((Component)_0024self__00242622).rigidbody.velocity);
						float num6 = (_0024_0024967_00242615.x = _0024_0024966_00242614);
						Vector3 val9 = (((Component)_0024self__00242622).rigidbody.velocity = _0024_0024967_00242615);
						int num7 = (_0024_0024968_00242616 = Random.Range(10, 16));
						Vector3 val10 = (_0024_0024969_00242617 = ((Component)_0024self__00242622).rigidbody.velocity);
						float num8 = (_0024_0024969_00242617.y = _0024_0024968_00242616);
						Vector3 val12 = (((Component)_0024self__00242622).rigidbody.velocity = _0024_0024969_00242617);
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

		internal ShroomBaby _0024self__00242623;

		public _0024MoveCheck_00242612(ShroomBaby self_)
		{
			_0024self__00242623 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242623);
		}
	}

	public override void Awake()
	{
		int[] array = new int[3] { 20, 19, 15 };
		SetStats(15, 4, 0, 5, 4f, array, Random.Range(5, 15), 7);
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242609(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242612(this).GetEnumerator();
	}
}
