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
	internal sealed class _0024Start_00242649 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal ShroomBaby _0024self__00242650;

			public _0024(ShroomBaby self_)
			{
				_0024self__00242650 = self_;
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
					_0024self__00242650.@base.animation["i"].speed = 0.5f;
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)(object)((MonoBehaviour)_0024self__00242650).StartCoroutine_Auto(_0024self__00242650.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ShroomBaby _0024self__00242651;

		public _0024Start_00242649(ShroomBaby self_)
		{
			_0024self__00242651 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00242651);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242652 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242653;

			internal int _0024_0024966_00242654;

			internal Vector3 _0024_0024967_00242655;

			internal int _0024_0024968_00242656;

			internal Vector3 _0024_0024969_00242657;

			internal int _0024_0024970_00242658;

			internal Vector3 _0024_0024971_00242659;

			internal int _0024_0024972_00242660;

			internal Vector3 _0024_0024973_00242661;

			internal ShroomBaby _0024self__00242662;

			public _0024(ShroomBaby self_)
			{
				_0024self__00242662 = self_;
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
					_0024num_00242653 = Random.Range(0, 2);
					if (_0024num_00242653 != 0)
					{
						int num = (_0024_0024970_00242658 = -10);
						Vector3 val = (_0024_0024971_00242659 = ((Component)_0024self__00242662).rigidbody.velocity);
						float num2 = (_0024_0024971_00242659.x = _0024_0024970_00242658);
						Vector3 val3 = (((Component)_0024self__00242662).rigidbody.velocity = _0024_0024971_00242659);
						int num3 = (_0024_0024972_00242660 = Random.Range(10, 16));
						Vector3 val4 = (_0024_0024973_00242661 = ((Component)_0024self__00242662).rigidbody.velocity);
						float num4 = (_0024_0024973_00242661.y = _0024_0024972_00242660);
						Vector3 val6 = (((Component)_0024self__00242662).rigidbody.velocity = _0024_0024973_00242661);
					}
					else
					{
						int num5 = (_0024_0024966_00242654 = 10);
						Vector3 val7 = (_0024_0024967_00242655 = ((Component)_0024self__00242662).rigidbody.velocity);
						float num6 = (_0024_0024967_00242655.x = _0024_0024966_00242654);
						Vector3 val9 = (((Component)_0024self__00242662).rigidbody.velocity = _0024_0024967_00242655);
						int num7 = (_0024_0024968_00242656 = Random.Range(10, 16));
						Vector3 val10 = (_0024_0024969_00242657 = ((Component)_0024self__00242662).rigidbody.velocity);
						float num8 = (_0024_0024969_00242657.y = _0024_0024968_00242656);
						Vector3 val12 = (((Component)_0024self__00242662).rigidbody.velocity = _0024_0024969_00242657);
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

		internal ShroomBaby _0024self__00242663;

		public _0024MoveCheck_00242652(ShroomBaby self_)
		{
			_0024self__00242663 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242663);
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
		return new _0024Start_00242649(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242652(this).GetEnumerator();
	}
}
