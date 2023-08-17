using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EntScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241420 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int[] _0024drops_00241421;

			internal EntScript _0024self__00241422;

			public _0024(EntScript self_)
			{
				_0024self__00241422 = self_;
			}

			public override bool MoveNext()
			{
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241422.@base.animation["i"].layer = 0;
					_0024drops_00241421 = new int[3] { 7, 18, 0 };
					_0024self__00241422.SetStats(10, 1, 1, 3, 2f, _0024drops_00241421, Random.Range(2, 6), 3);
					goto case 2;
				case 2:
					((MonoBehaviour)_0024self__00241422).StartCoroutine_Auto(_0024self__00241422.AttackCheck());
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EntScript _0024self__00241423;

		public _0024Start_00241420(EntScript self_)
		{
			_0024self__00241423 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241423);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241424 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241425;

			internal Ray _0024ray2_00241426;

			internal int _0024_0024557_00241427;

			internal Vector3 _0024_0024558_00241428;

			internal int _0024_0024559_00241429;

			internal Vector3 _0024_0024560_00241430;

			internal int _0024_0024561_00241431;

			internal Vector3 _0024_0024562_00241432;

			internal int _0024_0024563_00241433;

			internal Vector3 _0024_0024564_00241434;

			internal int _0024_0024565_00241435;

			internal Vector3 _0024_0024566_00241436;

			internal EntScript _0024self__00241437;

			public _0024(EntScript self_)
			{
				_0024self__00241437 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_02af: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_016a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0104: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Unknown result type (might be due to invalid IL or missing references)
				//IL_0275: Unknown result type (might be due to invalid IL or missing references)
				//IL_027f: Expected O, but got Unknown
				//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0200: Unknown result type (might be due to invalid IL or missing references)
				//IL_0205: Unknown result type (might be due to invalid IL or missing references)
				//IL_0206: Unknown result type (might be due to invalid IL or missing references)
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_022a: Unknown result type (might be due to invalid IL or missing references)
				//IL_022f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Unknown result type (might be due to invalid IL or missing references)
				//IL_0232: Unknown result type (might be due to invalid IL or missing references)
				//IL_0237: Unknown result type (might be due to invalid IL or missing references)
				//IL_025e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0263: Unknown result type (might be due to invalid IL or missing references)
				//IL_0264: Unknown result type (might be due to invalid IL or missing references)
				//IL_026b: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024ray_00241425 = new Ray(_0024self__00241437.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00241426 = new Ray(_0024self__00241437.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241425, ref _0024self__00241437.hit, 10f, 256))
					{
						_0024self__00241437.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						int num3 = (_0024_0024557_00241427 = Random.Range(5, 10));
						Vector3 val4 = (_0024_0024558_00241428 = _0024self__00241437.r.velocity);
						float num4 = (_0024_0024558_00241428.y = _0024_0024557_00241427);
						Vector3 val6 = (_0024self__00241437.r.velocity = _0024_0024558_00241428);
						int num5 = (_0024_0024559_00241429 = 10);
						Vector3 val7 = (_0024_0024560_00241430 = _0024self__00241437.r.velocity);
						float num6 = (_0024_0024560_00241430.x = _0024_0024559_00241429);
						Vector3 val9 = (_0024self__00241437.r.velocity = _0024_0024560_00241430);
					}
					else if (Physics.Raycast(_0024ray2_00241426, ref _0024self__00241437.hit, 10f, 256))
					{
						_0024self__00241437.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						int num7 = (_0024_0024561_00241431 = Random.Range(5, 10));
						Vector3 val10 = (_0024_0024562_00241432 = _0024self__00241437.r.velocity);
						float num8 = (_0024_0024562_00241432.y = _0024_0024561_00241431);
						Vector3 val12 = (_0024self__00241437.r.velocity = _0024_0024562_00241432);
						int num9 = (_0024_0024563_00241433 = -10);
						Vector3 val13 = (_0024_0024564_00241434 = _0024self__00241437.r.velocity);
						float num10 = (_0024_0024564_00241434.x = _0024_0024563_00241433);
						Vector3 val15 = (_0024self__00241437.r.velocity = _0024_0024564_00241434);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241437.attacking = false;
					int num = (_0024_0024565_00241435 = 0);
					Vector3 val = (_0024_0024566_00241436 = _0024self__00241437.r.velocity);
					float num2 = (_0024_0024566_00241436.x = _0024_0024565_00241435);
					Vector3 val3 = (_0024self__00241437.r.velocity = _0024_0024566_00241436);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EntScript _0024self__00241438;

		public _0024AttackCheck_00241424(EntScript self_)
		{
			_0024self__00241438 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241438);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241439 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241440;

			internal int _0024dir_00241441;

			internal int _0024_0024567_00241442;

			internal Vector3 _0024_0024568_00241443;

			internal EntScript _0024self__00241444;

			public _0024(EntScript self_)
			{
				_0024self__00241444 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_010a: Expected O, but got Unknown
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_009e: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241444.attacking)
					{
						((Component)_0024self__00241444).audio.PlayOneShot(_0024self__00241444.a);
						_0024self__00241444.dir = 0;
						int num = (_0024_0024567_00241442 = 0);
						Vector3 val = (_0024_0024568_00241443 = _0024self__00241444._0024get_rigidbody_00241445().velocity);
						float num2 = (_0024_0024568_00241443.x = _0024_0024567_00241442);
						Vector3 val3 = (_0024self__00241444._0024get_rigidbody_00241446().velocity = _0024_0024568_00241443);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
						break;
					}
					goto IL_00f7;
				case 2:
					_0024num_00241440 = Random.Range(1, 2);
					_0024dir_00241441 = Random.Range(1, 3);
					_0024self__00241444.moving = false;
					_0024self__00241444.dir = _0024dir_00241441;
					goto IL_00f7;
				case 3:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00f7:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00241440)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EntScript _0024self__00241447;

		public _0024MoveCheck_00241439(EntScript self_)
		{
			_0024self__00241447 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241447);
		}
	}

	private RaycastHit hit;

	public override IEnumerator Start()
	{
		return new _0024Start_00241420(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241424(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241439(this).GetEnumerator();
	}

	internal Rigidbody _0024get_rigidbody_00241445()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00241446()
	{
		return ((Component)this).rigidbody;
	}
}
