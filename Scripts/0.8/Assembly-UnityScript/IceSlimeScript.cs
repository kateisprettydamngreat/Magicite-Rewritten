using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class IceSlimeScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241922 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal IceSlimeScript _0024self__00241923;

			public _0024(IceSlimeScript self_)
			{
				_0024self__00241923 = self_;
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
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)(object)((MonoBehaviour)_0024self__00241923).StartCoroutine_Auto(_0024self__00241923.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal IceSlimeScript _0024self__00241924;

		public _0024Start_00241922(IceSlimeScript self_)
		{
			_0024self__00241924 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00241924);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241925 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241926;

			internal int _0024_0024683_00241927;

			internal Vector3 _0024_0024684_00241928;

			internal int _0024_0024685_00241929;

			internal Vector3 _0024_0024686_00241930;

			internal int _0024_0024687_00241931;

			internal Vector3 _0024_0024688_00241932;

			internal int _0024_0024689_00241933;

			internal Vector3 _0024_0024690_00241934;

			internal IceSlimeScript _0024self__00241935;

			public _0024(IceSlimeScript self_)
			{
				_0024self__00241935 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_010d: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_013c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0141: Unknown result type (might be due to invalid IL or missing references)
				//IL_0142: Unknown result type (might be due to invalid IL or missing references)
				//IL_0149: Unknown result type (might be due to invalid IL or missing references)
				//IL_016d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0172: Unknown result type (might be due to invalid IL or missing references)
				//IL_0173: Unknown result type (might be due to invalid IL or missing references)
				//IL_0175: Unknown result type (might be due to invalid IL or missing references)
				//IL_017a: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_0046: Unknown result type (might be due to invalid IL or missing references)
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bf: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024num_00241926 = Random.Range(0, 2);
					if (_0024num_00241926 != 0)
					{
						int num = (_0024_0024687_00241931 = -5);
						Vector3 val = (_0024_0024688_00241932 = ((Component)_0024self__00241935).rigidbody.velocity);
						float num2 = (_0024_0024688_00241932.x = _0024_0024687_00241931);
						Vector3 val3 = (((Component)_0024self__00241935).rigidbody.velocity = _0024_0024688_00241932);
						int num3 = (_0024_0024689_00241933 = Random.Range(10, 16));
						Vector3 val4 = (_0024_0024690_00241934 = ((Component)_0024self__00241935).rigidbody.velocity);
						float num4 = (_0024_0024690_00241934.y = _0024_0024689_00241933);
						Vector3 val6 = (((Component)_0024self__00241935).rigidbody.velocity = _0024_0024690_00241934);
					}
					else
					{
						int num5 = (_0024_0024683_00241927 = 5);
						Vector3 val7 = (_0024_0024684_00241928 = ((Component)_0024self__00241935).rigidbody.velocity);
						float num6 = (_0024_0024684_00241928.x = _0024_0024683_00241927);
						Vector3 val9 = (((Component)_0024self__00241935).rigidbody.velocity = _0024_0024684_00241928);
						int num7 = (_0024_0024685_00241929 = Random.Range(10, 16));
						Vector3 val10 = (_0024_0024686_00241930 = ((Component)_0024self__00241935).rigidbody.velocity);
						float num8 = (_0024_0024686_00241930.y = _0024_0024685_00241929);
						Vector3 val12 = (((Component)_0024self__00241935).rigidbody.velocity = _0024_0024686_00241930);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
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

		internal IceSlimeScript _0024self__00241936;

		public _0024MoveCheck_00241925(IceSlimeScript self_)
		{
			_0024self__00241936 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241936);
		}
	}

	public override void Awake()
	{
		int[] array = new int[3] { 10, 9, 16 };
		SetStats(15, 2, 0, 6, 7f, array, Random.Range(5, 15), 6);
		@base.animation["i"].speed = 0.5f;
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241922(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241925(this).GetEnumerator();
	}
}
