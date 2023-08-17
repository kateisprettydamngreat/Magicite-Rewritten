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
	internal sealed class _0024Start_00241299 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00241300;

			internal ArcherScript _0024self__00241301;

			public _0024(ArcherScript self_)
			{
				_0024self__00241301 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241301.@base.animation["i"].layer = 0;
					_0024self__00241301.@base.animation["a"].layer = 1;
					_0024drops_00241300 = new int[3] { 15, 18, 15 };
					_0024self__00241301.SetStats(40, 13, 10, 8, 3f, _0024drops_00241300, Random.Range(7, 15), 8);
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00241301).StartCoroutine_Auto(_0024self__00241301.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArcherScript _0024self__00241302;

		public _0024Start_00241299(ArcherScript self_)
		{
			_0024self__00241302 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00241302);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241303 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal Vector3 _0024startPos_00241304;

			internal Ray _0024ray_00241305;

			internal Ray _0024ray2_00241306;

			internal int _0024_0024416_00241307;

			internal Vector3 _0024_0024417_00241308;

			internal int _0024_0024418_00241309;

			internal Vector3 _0024_0024419_00241310;

			internal int _0024_0024420_00241311;

			internal Vector3 _0024_0024421_00241312;

			internal int _0024_0024422_00241313;

			internal Vector3 _0024_0024423_00241314;

			internal int _0024_0024424_00241315;

			internal Vector3 _0024_0024425_00241316;

			internal ArcherScript _0024self__00241317;

			public _0024(ArcherScript self_)
			{
				_0024self__00241317 = self_;
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
					if (!_0024self__00241317.attacking)
					{
						_0024startPos_00241304 = new Vector3(_0024self__00241317.t.position.x, _0024self__00241317.t.position.y - 0.5f, 0f);
						_0024ray_00241305 = new Ray(_0024startPos_00241304, new Vector3(1f, 0f, 0f));
						_0024ray2_00241306 = new Ray(_0024startPos_00241304, new Vector3(-1f, 0f, 0f));
						if (Physics.Raycast(_0024ray_00241305, ref _0024self__00241317.hit, 15f, 256))
						{
							((Component)_0024self__00241317).audio.PlayOneShot(_0024self__00241317.audioFire);
							_0024self__00241317.attacking = true;
							_0024self__00241317.@base.animation.Play("a");
							_0024self__00241317.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForSeconds(0.4f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00241306, ref _0024self__00241317.hit, 15f, 256))
						{
							((Component)_0024self__00241317).audio.PlayOneShot(_0024self__00241317.audioFire);
							_0024self__00241317.attacking = true;
							_0024self__00241317.@base.animation.Play("a");
							_0024self__00241317.e.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
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
							Network.Instantiate((Object)(object)_0024self__00241317.arrowR, _0024self__00241317.t.position, Quaternion.identity, 0);
						}
					}
					else
					{
						Object.Instantiate((Object)(object)_0024self__00241317.arrowR, _0024self__00241317.t.position, Quaternion.identity);
					}
					int num7 = (_0024_0024416_00241307 = 10);
					Vector3 val10 = (_0024_0024417_00241308 = _0024self__00241317.r.velocity);
					float num8 = (_0024_0024417_00241308.y = _0024_0024416_00241307);
					Vector3 val12 = (_0024self__00241317.r.velocity = _0024_0024417_00241308);
					int num9 = (_0024_0024418_00241309 = -3);
					Vector3 val13 = (_0024_0024419_00241310 = _0024self__00241317.r.velocity);
					float num10 = (_0024_0024419_00241310.x = _0024_0024418_00241309);
					Vector3 val15 = (_0024self__00241317.r.velocity = _0024_0024419_00241310);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 4:
				{
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							Network.Instantiate((Object)(object)_0024self__00241317.arrowL, _0024self__00241317.t.position, Quaternion.identity, 0);
						}
					}
					else
					{
						Object.Instantiate((Object)(object)_0024self__00241317.arrowL, _0024self__00241317.t.position, Quaternion.identity);
					}
					int num3 = (_0024_0024420_00241311 = 10);
					Vector3 val4 = (_0024_0024421_00241312 = _0024self__00241317.r.velocity);
					float num4 = (_0024_0024421_00241312.y = _0024_0024420_00241311);
					Vector3 val6 = (_0024self__00241317.r.velocity = _0024_0024421_00241312);
					int num5 = (_0024_0024422_00241313 = 3);
					Vector3 val7 = (_0024_0024423_00241314 = _0024self__00241317.r.velocity);
					float num6 = (_0024_0024423_00241314.x = _0024_0024422_00241313);
					Vector3 val9 = (_0024self__00241317.r.velocity = _0024_0024423_00241314);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(5, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 3:
				case 5:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(6, (YieldInstruction)new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 6:
				{
					_0024self__00241317.attacking = false;
					int num = (_0024_0024424_00241315 = 0);
					Vector3 val = (_0024_0024425_00241316 = _0024self__00241317.r.velocity);
					float num2 = (_0024_0024425_00241316.x = _0024_0024424_00241315);
					Vector3 val3 = (_0024self__00241317.r.velocity = _0024_0024425_00241316);
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

		internal ArcherScript _0024self__00241318;

		public _0024AttackCheck_00241303(ArcherScript self_)
		{
			_0024self__00241318 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00241318);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241319 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241320;

			internal int _0024dir_00241321;

			internal int _0024_0024426_00241322;

			internal Vector3 _0024_0024427_00241323;

			internal ArcherScript _0024self__00241324;

			public _0024(ArcherScript self_)
			{
				_0024self__00241324 = self_;
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
					if (!_0024self__00241324.attacking)
					{
						_0024self__00241324.moving = true;
						int num = (_0024_0024426_00241322 = 0);
						Vector3 val = (_0024_0024427_00241323 = _0024self__00241324._0024get_rigidbody_00241325().velocity);
						float num2 = (_0024_0024427_00241323.x = _0024_0024426_00241322);
						Vector3 val3 = (_0024self__00241324._0024get_rigidbody_00241326().velocity = _0024_0024427_00241323);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024num_00241320 = Random.Range(0, 4);
					_0024dir_00241321 = Random.Range(1, 3);
					_0024self__00241324.dir = _0024dir_00241321;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00241320)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241324.moving = false;
					_0024self__00241324.dir = 0;
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

		internal ArcherScript _0024self__00241327;

		public _0024MoveCheck_00241319(ArcherScript self_)
		{
			_0024self__00241327 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241327);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00241328 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal Vector3 _0024startPos_00241329;

			internal Ray _0024ray_00241330;

			internal Ray _0024ray2_00241331;

			internal int _0024_0024428_00241332;

			internal Vector3 _0024_0024429_00241333;

			internal int _0024_0024430_00241334;

			internal Vector3 _0024_0024431_00241335;

			internal int _0024_0024432_00241336;

			internal Vector3 _0024_0024433_00241337;

			internal int _0024_0024434_00241338;

			internal Vector3 _0024_0024435_00241339;

			internal ArcherScript _0024self__00241340;

			public _0024(ArcherScript self_)
			{
				_0024self__00241340 = self_;
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
					_0024startPos_00241329 = new Vector3(_0024self__00241340.t.position.x, _0024self__00241340.t.position.y - 0.5f, 0f);
					_0024ray_00241330 = new Ray(_0024startPos_00241329, new Vector3(1f, 0f, 0f));
					_0024ray2_00241331 = new Ray(_0024startPos_00241329, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241330, ref _0024self__00241340.hit, 15f, 256))
					{
						_0024self__00241340.attacking = true;
						((Component)_0024self__00241340).audio.PlayOneShot(_0024self__00241340.audioFire);
						_0024self__00241340.attacking = true;
						_0024self__00241340.@base.animation.Play("a");
						_0024self__00241340.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForSeconds(0.4f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241331, ref _0024self__00241340.hit, 15f, 256))
					{
						((Component)_0024self__00241340).audio.PlayOneShot(_0024self__00241340.audioFire);
						_0024self__00241340.attacking = true;
						_0024self__00241340.@base.animation.Play("a");
						_0024self__00241340.e.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.4f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 2:
				{
					Network.Instantiate((Object)(object)_0024self__00241340.arrowR, _0024self__00241340.t.position, Quaternion.identity, 0);
					int num5 = (_0024_0024428_00241332 = 10);
					Vector3 val7 = (_0024_0024429_00241333 = _0024self__00241340.r.velocity);
					float num6 = (_0024_0024429_00241333.y = _0024_0024428_00241332);
					Vector3 val9 = (_0024self__00241340.r.velocity = _0024_0024429_00241333);
					int num7 = (_0024_0024430_00241334 = -3);
					Vector3 val10 = (_0024_0024431_00241335 = _0024self__00241340.r.velocity);
					float num8 = (_0024_0024431_00241335.x = _0024_0024430_00241334);
					Vector3 val12 = (_0024self__00241340.r.velocity = _0024_0024431_00241335);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 4:
				{
					Network.Instantiate((Object)(object)_0024self__00241340.arrowL, _0024self__00241340.t.position, Quaternion.identity, 0);
					int num = (_0024_0024432_00241336 = 10);
					Vector3 val = (_0024_0024433_00241337 = _0024self__00241340.r.velocity);
					float num2 = (_0024_0024433_00241337.y = _0024_0024432_00241336);
					Vector3 val3 = (_0024self__00241340.r.velocity = _0024_0024433_00241337);
					int num3 = (_0024_0024434_00241338 = 3);
					Vector3 val4 = (_0024_0024435_00241339 = _0024self__00241340.r.velocity);
					float num4 = (_0024_0024435_00241339.x = _0024_0024434_00241338);
					Vector3 val6 = (_0024self__00241340.r.velocity = _0024_0024435_00241339);
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

		internal ArcherScript _0024self__00241341;

		public _0024ATK_00241328(ArcherScript self_)
		{
			_0024self__00241341 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00241341);
		}
	}

	private RaycastHit hit;

	public GameObject arrowR;

	public GameObject arrowL;

	public AudioClip audioFire;

	public override IEnumerator Start()
	{
		return new _0024Start_00241299(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241303(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241319(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00241328(this).GetEnumerator();
	}

	public override void Main()
	{
	}

	internal Rigidbody _0024get_rigidbody_00241325()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00241326()
	{
		return ((Component)this).rigidbody;
	}
}
