using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ArcherScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241092 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00241093;

			internal ArcherScript _0024self__00241094;

			public _0024(ArcherScript self_)
			{
				_0024self__00241094 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241094.@base.animation["i"].layer = 0;
					_0024self__00241094.@base.animation["a"].layer = 1;
					_0024drops_00241093 = new int[3] { 7, 18, 0 };
					_0024self__00241094.SetStats(40, 13, 10, 8, 3f, _0024drops_00241093, Random.Range(7, 15), 8);
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00241094).StartCoroutine_Auto(_0024self__00241094.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArcherScript _0024self__00241095;

		public _0024Start_00241092(ArcherScript self_)
		{
			_0024self__00241095 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00241095);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241096 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal Vector3 _0024startPos_00241097;

			internal Ray _0024ray_00241098;

			internal Ray _0024ray2_00241099;

			internal int _0024_0024379_00241100;

			internal Vector3 _0024_0024380_00241101;

			internal int _0024_0024381_00241102;

			internal Vector3 _0024_0024382_00241103;

			internal int _0024_0024383_00241104;

			internal Vector3 _0024_0024384_00241105;

			internal int _0024_0024385_00241106;

			internal Vector3 _0024_0024386_00241107;

			internal int _0024_0024387_00241108;

			internal Vector3 _0024_0024388_00241109;

			internal ArcherScript _0024self__00241110;

			public _0024(ArcherScript self_)
			{
				_0024self__00241110 = self_;
			}

			public override bool MoveNext()
			{
				//IL_045b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0465: Expected O, but got Unknown
				//IL_048f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0494: Unknown result type (might be due to invalid IL or missing references)
				//IL_0495: Unknown result type (might be due to invalid IL or missing references)
				//IL_0497: Unknown result type (might be due to invalid IL or missing references)
				//IL_049c: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_037b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0380: Unknown result type (might be due to invalid IL or missing references)
				//IL_0288: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_0142: Unknown result type (might be due to invalid IL or missing references)
				//IL_014c: Expected O, but got Unknown
				//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0203: Unknown result type (might be due to invalid IL or missing references)
				//IL_0208: Unknown result type (might be due to invalid IL or missing references)
				//IL_0209: Unknown result type (might be due to invalid IL or missing references)
				//IL_0210: Unknown result type (might be due to invalid IL or missing references)
				//IL_022d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0232: Unknown result type (might be due to invalid IL or missing references)
				//IL_0233: Unknown result type (might be due to invalid IL or missing references)
				//IL_0235: Unknown result type (might be due to invalid IL or missing references)
				//IL_023a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0261: Unknown result type (might be due to invalid IL or missing references)
				//IL_0266: Unknown result type (might be due to invalid IL or missing references)
				//IL_0267: Unknown result type (might be due to invalid IL or missing references)
				//IL_026e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0273: Unknown result type (might be due to invalid IL or missing references)
				//IL_027d: Expected O, but got Unknown
				//IL_017d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03de: Unknown result type (might be due to invalid IL or missing references)
				//IL_03df: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0402: Unknown result type (might be due to invalid IL or missing references)
				//IL_0407: Unknown result type (might be due to invalid IL or missing references)
				//IL_0408: Unknown result type (might be due to invalid IL or missing references)
				//IL_040a: Unknown result type (might be due to invalid IL or missing references)
				//IL_040f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0436: Unknown result type (might be due to invalid IL or missing references)
				//IL_043b: Unknown result type (might be due to invalid IL or missing references)
				//IL_043c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0443: Unknown result type (might be due to invalid IL or missing references)
				//IL_0448: Unknown result type (might be due to invalid IL or missing references)
				//IL_0452: Expected O, but got Unknown
				//IL_034f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0354: Unknown result type (might be due to invalid IL or missing references)
				//IL_0303: Unknown result type (might be due to invalid IL or missing references)
				//IL_0314: Unknown result type (might be due to invalid IL or missing references)
				//IL_031e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241110.attacking)
					{
						_0024startPos_00241097 = new Vector3(_0024self__00241110.t.position.x, _0024self__00241110.t.position.y - 0.5f, 0f);
						_0024ray_00241098 = new Ray(_0024startPos_00241097, new Vector3(1f, 0f, 0f));
						_0024ray2_00241099 = new Ray(_0024startPos_00241097, new Vector3(-1f, 0f, 0f));
						if (Physics.Raycast(_0024ray_00241098, ref _0024self__00241110.hit, 15f, 256))
						{
							((Component)_0024self__00241110).audio.PlayOneShot(_0024self__00241110.audioFire);
							_0024self__00241110.attacking = true;
							_0024self__00241110.@base.animation.Play("a");
							_0024self__00241110.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForSeconds(0.4f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00241099, ref _0024self__00241110.hit, 15f, 256))
						{
							((Component)_0024self__00241110).audio.PlayOneShot(_0024self__00241110.audioFire);
							_0024self__00241110.attacking = true;
							_0024self__00241110.@base.animation.Play("a");
							_0024self__00241110.e.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
							result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.4f)) ? 1 : 0);
							break;
						}
					}
					goto case 3;
				case 2:
				{
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							Network.Instantiate((Object)(object)_0024self__00241110.arrowR, _0024self__00241110.t.position, Quaternion.identity, 0);
						}
					}
					else
					{
						Object.Instantiate((Object)(object)_0024self__00241110.arrowR, _0024self__00241110.t.position, Quaternion.identity);
					}
					int num7 = (_0024_0024379_00241100 = 10);
					Vector3 val10 = (_0024_0024380_00241101 = _0024self__00241110.r.velocity);
					float num8 = (_0024_0024380_00241101.y = _0024_0024379_00241100);
					Vector3 val12 = (_0024self__00241110.r.velocity = _0024_0024380_00241101);
					int num9 = (_0024_0024381_00241102 = -3);
					Vector3 val13 = (_0024_0024382_00241103 = _0024self__00241110.r.velocity);
					float num10 = (_0024_0024382_00241103.x = _0024_0024381_00241102);
					Vector3 val15 = (_0024self__00241110.r.velocity = _0024_0024382_00241103);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 4:
				{
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							Network.Instantiate((Object)(object)_0024self__00241110.arrowL, _0024self__00241110.t.position, Quaternion.identity, 0);
						}
					}
					else
					{
						Object.Instantiate((Object)(object)_0024self__00241110.arrowL, _0024self__00241110.t.position, Quaternion.identity);
					}
					int num3 = (_0024_0024383_00241104 = 10);
					Vector3 val4 = (_0024_0024384_00241105 = _0024self__00241110.r.velocity);
					float num4 = (_0024_0024384_00241105.y = _0024_0024383_00241104);
					Vector3 val6 = (_0024self__00241110.r.velocity = _0024_0024384_00241105);
					int num5 = (_0024_0024385_00241106 = 3);
					Vector3 val7 = (_0024_0024386_00241107 = _0024self__00241110.r.velocity);
					float num6 = (_0024_0024386_00241107.x = _0024_0024385_00241106);
					Vector3 val9 = (_0024self__00241110.r.velocity = _0024_0024386_00241107);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(5, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 3:
				case 5:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(6, (YieldInstruction)new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 6:
				{
					_0024self__00241110.attacking = false;
					int num = (_0024_0024387_00241108 = 0);
					Vector3 val = (_0024_0024388_00241109 = _0024self__00241110.r.velocity);
					float num2 = (_0024_0024388_00241109.x = _0024_0024387_00241108);
					Vector3 val3 = (_0024self__00241110.r.velocity = _0024_0024388_00241109);
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArcherScript _0024self__00241111;

		public _0024AttackCheck_00241096(ArcherScript self_)
		{
			_0024self__00241111 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00241111);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241112 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241113;

			internal int _0024dir_00241114;

			internal int _0024_0024389_00241115;

			internal Vector3 _0024_0024390_00241116;

			internal ArcherScript _0024self__00241117;

			public _0024(ArcherScript self_)
			{
				_0024self__00241117 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Expected O, but got Unknown
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Expected O, but got Unknown
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241117.attacking)
					{
						_0024self__00241117.moving = true;
						int num = (_0024_0024389_00241115 = 0);
						Vector3 val = (_0024_0024390_00241116 = _0024self__00241117._0024get_rigidbody_00241118().velocity);
						float num2 = (_0024_0024390_00241116.x = _0024_0024389_00241115);
						Vector3 val3 = (_0024self__00241117._0024get_rigidbody_00241119().velocity = _0024_0024390_00241116);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024num_00241113 = Random.Range(0, 4);
					_0024dir_00241114 = Random.Range(1, 3);
					_0024self__00241117.dir = _0024dir_00241114;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00241113)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241117.moving = false;
					_0024self__00241117.dir = 0;
					goto case 4;
				case 4:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArcherScript _0024self__00241120;

		public _0024MoveCheck_00241112(ArcherScript self_)
		{
			_0024self__00241120 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241120);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00241121 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal Vector3 _0024startPos_00241122;

			internal Ray _0024ray_00241123;

			internal Ray _0024ray2_00241124;

			internal int _0024_0024391_00241125;

			internal Vector3 _0024_0024392_00241126;

			internal int _0024_0024393_00241127;

			internal Vector3 _0024_0024394_00241128;

			internal int _0024_0024395_00241129;

			internal Vector3 _0024_0024396_00241130;

			internal int _0024_0024397_00241131;

			internal Vector3 _0024_0024398_00241132;

			internal ArcherScript _0024self__00241133;

			public _0024(ArcherScript self_)
			{
				_0024self__00241133 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0164: Unknown result type (might be due to invalid IL or missing references)
				//IL_0188: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_018e: Unknown result type (might be due to invalid IL or missing references)
				//IL_018f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0194: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_021d: Unknown result type (might be due to invalid IL or missing references)
				//IL_021e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_022a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0234: Expected O, but got Unknown
				//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_031b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0320: Unknown result type (might be due to invalid IL or missing references)
				//IL_0321: Unknown result type (might be due to invalid IL or missing references)
				//IL_0323: Unknown result type (might be due to invalid IL or missing references)
				//IL_0328: Unknown result type (might be due to invalid IL or missing references)
				//IL_034f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0354: Unknown result type (might be due to invalid IL or missing references)
				//IL_0355: Unknown result type (might be due to invalid IL or missing references)
				//IL_035c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0378: Unknown result type (might be due to invalid IL or missing references)
				//IL_037d: Unknown result type (might be due to invalid IL or missing references)
				//IL_037e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0380: Unknown result type (might be due to invalid IL or missing references)
				//IL_0385: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03be: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c8: Expected O, but got Unknown
				//IL_023f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_013a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0144: Expected O, but got Unknown
				//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d5: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024startPos_00241122 = new Vector3(_0024self__00241133.t.position.x, _0024self__00241133.t.position.y - 0.5f, 0f);
					_0024ray_00241123 = new Ray(_0024startPos_00241122, new Vector3(1f, 0f, 0f));
					_0024ray2_00241124 = new Ray(_0024startPos_00241122, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241123, ref _0024self__00241133.hit, 15f, 256))
					{
						_0024self__00241133.attacking = true;
						((Component)_0024self__00241133).audio.PlayOneShot(_0024self__00241133.audioFire);
						_0024self__00241133.attacking = true;
						_0024self__00241133.@base.animation.Play("a");
						_0024self__00241133.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForSeconds(0.4f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241124, ref _0024self__00241133.hit, 15f, 256))
					{
						((Component)_0024self__00241133).audio.PlayOneShot(_0024self__00241133.audioFire);
						_0024self__00241133.attacking = true;
						_0024self__00241133.@base.animation.Play("a");
						_0024self__00241133.e.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.4f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 2:
				{
					Network.Instantiate((Object)(object)_0024self__00241133.arrowR, _0024self__00241133.t.position, Quaternion.identity, 0);
					int num5 = (_0024_0024391_00241125 = 10);
					Vector3 val7 = (_0024_0024392_00241126 = _0024self__00241133.r.velocity);
					float num6 = (_0024_0024392_00241126.y = _0024_0024391_00241125);
					Vector3 val9 = (_0024self__00241133.r.velocity = _0024_0024392_00241126);
					int num7 = (_0024_0024393_00241127 = -3);
					Vector3 val10 = (_0024_0024394_00241128 = _0024self__00241133.r.velocity);
					float num8 = (_0024_0024394_00241128.x = _0024_0024393_00241127);
					Vector3 val12 = (_0024self__00241133.r.velocity = _0024_0024394_00241128);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 4:
				{
					Network.Instantiate((Object)(object)_0024self__00241133.arrowL, _0024self__00241133.t.position, Quaternion.identity, 0);
					int num = (_0024_0024395_00241129 = 10);
					Vector3 val = (_0024_0024396_00241130 = _0024self__00241133.r.velocity);
					float num2 = (_0024_0024396_00241130.y = _0024_0024395_00241129);
					Vector3 val3 = (_0024self__00241133.r.velocity = _0024_0024396_00241130);
					int num3 = (_0024_0024397_00241131 = 3);
					Vector3 val4 = (_0024_0024398_00241132 = _0024self__00241133.r.velocity);
					float num4 = (_0024_0024398_00241132.x = _0024_0024397_00241131);
					Vector3 val6 = (_0024self__00241133.r.velocity = _0024_0024398_00241132);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(5, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 3:
				case 5:
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArcherScript _0024self__00241134;

		public _0024ATK_00241121(ArcherScript self_)
		{
			_0024self__00241134 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00241134);
		}
	}

	private RaycastHit hit;

	public GameObject arrowR;

	public GameObject arrowL;

	public AudioClip audioFire;

	public override IEnumerator Start()
	{
		return new _0024Start_00241092(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241096(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241112(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00241121(this).GetEnumerator();
	}

	public override void Main()
	{
	}

	internal Rigidbody _0024get_rigidbody_00241118()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00241119()
	{
		return ((Component)this).rigidbody;
	}
}
