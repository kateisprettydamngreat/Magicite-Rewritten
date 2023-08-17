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
	internal sealed class _0024Start_00241049 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00241050;

			internal ArcherScript _0024self__00241051;

			public _0024(ArcherScript self_)
			{
				_0024self__00241051 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241051.@base.animation["i"].layer = 0;
					_0024self__00241051.@base.animation["a"].layer = 1;
					_0024drops_00241050 = new int[3] { 7, 18, 0 };
					_0024self__00241051.SetStats(40, 13, 10, 8, 3f, _0024drops_00241050, Random.Range(7, 15), 8);
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00241051).StartCoroutine_Auto(_0024self__00241051.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArcherScript _0024self__00241052;

		public _0024Start_00241049(ArcherScript self_)
		{
			_0024self__00241052 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00241052);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241053 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal Vector3 _0024startPos_00241054;

			internal Ray _0024ray_00241055;

			internal Ray _0024ray2_00241056;

			internal int _0024_0024345_00241057;

			internal Vector3 _0024_0024346_00241058;

			internal int _0024_0024347_00241059;

			internal Vector3 _0024_0024348_00241060;

			internal int _0024_0024349_00241061;

			internal Vector3 _0024_0024350_00241062;

			internal int _0024_0024351_00241063;

			internal Vector3 _0024_0024352_00241064;

			internal int _0024_0024353_00241065;

			internal Vector3 _0024_0024354_00241066;

			internal ArcherScript _0024self__00241067;

			public _0024(ArcherScript self_)
			{
				_0024self__00241067 = self_;
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
					if (!_0024self__00241067.attacking)
					{
						_0024startPos_00241054 = new Vector3(_0024self__00241067.t.position.x, _0024self__00241067.t.position.y - 0.5f, 0f);
						_0024ray_00241055 = new Ray(_0024startPos_00241054, new Vector3(1f, 0f, 0f));
						_0024ray2_00241056 = new Ray(_0024startPos_00241054, new Vector3(-1f, 0f, 0f));
						if (Physics.Raycast(_0024ray_00241055, ref _0024self__00241067.hit, 15f, 256))
						{
							((Component)_0024self__00241067).audio.PlayOneShot(_0024self__00241067.audioFire);
							_0024self__00241067.attacking = true;
							_0024self__00241067.@base.animation.Play("a");
							_0024self__00241067.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForSeconds(0.4f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00241056, ref _0024self__00241067.hit, 15f, 256))
						{
							((Component)_0024self__00241067).audio.PlayOneShot(_0024self__00241067.audioFire);
							_0024self__00241067.attacking = true;
							_0024self__00241067.@base.animation.Play("a");
							_0024self__00241067.e.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
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
							Network.Instantiate((Object)(object)_0024self__00241067.arrowR, _0024self__00241067.t.position, Quaternion.identity, 0);
						}
					}
					else
					{
						Object.Instantiate((Object)(object)_0024self__00241067.arrowR, _0024self__00241067.t.position, Quaternion.identity);
					}
					int num7 = (_0024_0024345_00241057 = 10);
					Vector3 val10 = (_0024_0024346_00241058 = _0024self__00241067.r.velocity);
					float num8 = (_0024_0024346_00241058.y = _0024_0024345_00241057);
					Vector3 val12 = (_0024self__00241067.r.velocity = _0024_0024346_00241058);
					int num9 = (_0024_0024347_00241059 = -3);
					Vector3 val13 = (_0024_0024348_00241060 = _0024self__00241067.r.velocity);
					float num10 = (_0024_0024348_00241060.x = _0024_0024347_00241059);
					Vector3 val15 = (_0024self__00241067.r.velocity = _0024_0024348_00241060);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 4:
				{
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							Network.Instantiate((Object)(object)_0024self__00241067.arrowL, _0024self__00241067.t.position, Quaternion.identity, 0);
						}
					}
					else
					{
						Object.Instantiate((Object)(object)_0024self__00241067.arrowL, _0024self__00241067.t.position, Quaternion.identity);
					}
					int num3 = (_0024_0024349_00241061 = 10);
					Vector3 val4 = (_0024_0024350_00241062 = _0024self__00241067.r.velocity);
					float num4 = (_0024_0024350_00241062.y = _0024_0024349_00241061);
					Vector3 val6 = (_0024self__00241067.r.velocity = _0024_0024350_00241062);
					int num5 = (_0024_0024351_00241063 = 3);
					Vector3 val7 = (_0024_0024352_00241064 = _0024self__00241067.r.velocity);
					float num6 = (_0024_0024352_00241064.x = _0024_0024351_00241063);
					Vector3 val9 = (_0024self__00241067.r.velocity = _0024_0024352_00241064);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(5, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 3:
				case 5:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(6, (YieldInstruction)new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 6:
				{
					_0024self__00241067.attacking = false;
					int num = (_0024_0024353_00241065 = 0);
					Vector3 val = (_0024_0024354_00241066 = _0024self__00241067.r.velocity);
					float num2 = (_0024_0024354_00241066.x = _0024_0024353_00241065);
					Vector3 val3 = (_0024self__00241067.r.velocity = _0024_0024354_00241066);
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

		internal ArcherScript _0024self__00241068;

		public _0024AttackCheck_00241053(ArcherScript self_)
		{
			_0024self__00241068 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00241068);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241069 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241070;

			internal int _0024dir_00241071;

			internal int _0024_0024355_00241072;

			internal Vector3 _0024_0024356_00241073;

			internal ArcherScript _0024self__00241074;

			public _0024(ArcherScript self_)
			{
				_0024self__00241074 = self_;
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
					if (!_0024self__00241074.attacking)
					{
						_0024self__00241074.moving = true;
						int num = (_0024_0024355_00241072 = 0);
						Vector3 val = (_0024_0024356_00241073 = _0024self__00241074._0024get_rigidbody_00241075().velocity);
						float num2 = (_0024_0024356_00241073.x = _0024_0024355_00241072);
						Vector3 val3 = (_0024self__00241074._0024get_rigidbody_00241076().velocity = _0024_0024356_00241073);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024num_00241070 = Random.Range(0, 4);
					_0024dir_00241071 = Random.Range(1, 3);
					_0024self__00241074.dir = _0024dir_00241071;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00241070)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241074.moving = false;
					_0024self__00241074.dir = 0;
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

		internal ArcherScript _0024self__00241077;

		public _0024MoveCheck_00241069(ArcherScript self_)
		{
			_0024self__00241077 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241077);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00241078 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal Vector3 _0024startPos_00241079;

			internal Ray _0024ray_00241080;

			internal Ray _0024ray2_00241081;

			internal int _0024_0024357_00241082;

			internal Vector3 _0024_0024358_00241083;

			internal int _0024_0024359_00241084;

			internal Vector3 _0024_0024360_00241085;

			internal int _0024_0024361_00241086;

			internal Vector3 _0024_0024362_00241087;

			internal int _0024_0024363_00241088;

			internal Vector3 _0024_0024364_00241089;

			internal ArcherScript _0024self__00241090;

			public _0024(ArcherScript self_)
			{
				_0024self__00241090 = self_;
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
					_0024startPos_00241079 = new Vector3(_0024self__00241090.t.position.x, _0024self__00241090.t.position.y - 0.5f, 0f);
					_0024ray_00241080 = new Ray(_0024startPos_00241079, new Vector3(1f, 0f, 0f));
					_0024ray2_00241081 = new Ray(_0024startPos_00241079, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241080, ref _0024self__00241090.hit, 15f, 256))
					{
						_0024self__00241090.attacking = true;
						((Component)_0024self__00241090).audio.PlayOneShot(_0024self__00241090.audioFire);
						_0024self__00241090.attacking = true;
						_0024self__00241090.@base.animation.Play("a");
						_0024self__00241090.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForSeconds(0.4f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241081, ref _0024self__00241090.hit, 15f, 256))
					{
						((Component)_0024self__00241090).audio.PlayOneShot(_0024self__00241090.audioFire);
						_0024self__00241090.attacking = true;
						_0024self__00241090.@base.animation.Play("a");
						_0024self__00241090.e.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.4f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 2:
				{
					Network.Instantiate((Object)(object)_0024self__00241090.arrowR, _0024self__00241090.t.position, Quaternion.identity, 0);
					int num5 = (_0024_0024357_00241082 = 10);
					Vector3 val7 = (_0024_0024358_00241083 = _0024self__00241090.r.velocity);
					float num6 = (_0024_0024358_00241083.y = _0024_0024357_00241082);
					Vector3 val9 = (_0024self__00241090.r.velocity = _0024_0024358_00241083);
					int num7 = (_0024_0024359_00241084 = -3);
					Vector3 val10 = (_0024_0024360_00241085 = _0024self__00241090.r.velocity);
					float num8 = (_0024_0024360_00241085.x = _0024_0024359_00241084);
					Vector3 val12 = (_0024self__00241090.r.velocity = _0024_0024360_00241085);
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 4:
				{
					Network.Instantiate((Object)(object)_0024self__00241090.arrowL, _0024self__00241090.t.position, Quaternion.identity, 0);
					int num = (_0024_0024361_00241086 = 10);
					Vector3 val = (_0024_0024362_00241087 = _0024self__00241090.r.velocity);
					float num2 = (_0024_0024362_00241087.y = _0024_0024361_00241086);
					Vector3 val3 = (_0024self__00241090.r.velocity = _0024_0024362_00241087);
					int num3 = (_0024_0024363_00241088 = 3);
					Vector3 val4 = (_0024_0024364_00241089 = _0024self__00241090.r.velocity);
					float num4 = (_0024_0024364_00241089.x = _0024_0024363_00241088);
					Vector3 val6 = (_0024self__00241090.r.velocity = _0024_0024364_00241089);
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

		internal ArcherScript _0024self__00241091;

		public _0024ATK_00241078(ArcherScript self_)
		{
			_0024self__00241091 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00241091);
		}
	}

	private RaycastHit hit;

	public GameObject arrowR;

	public GameObject arrowL;

	public AudioClip audioFire;

	public override IEnumerator Start()
	{
		return new _0024Start_00241049(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241053(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241069(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00241078(this).GetEnumerator();
	}

	public override void Main()
	{
	}

	internal Rigidbody _0024get_rigidbody_00241075()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00241076()
	{
		return ((Component)this).rigidbody;
	}
}
