using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EnemyScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock22_00241309 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024wasK_00241310;

			internal int _0024_0024502_00241311;

			internal Vector3 _0024_0024503_00241312;

			internal int _0024_0024504_00241313;

			internal Vector3 _0024_0024505_00241314;

			internal int _0024_0024506_00241315;

			internal Vector3 _0024_0024507_00241316;

			internal Vector3 _0024p_00241317;

			internal EnemyScript _0024self__00241318;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241317 = p;
				_0024self__00241318 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_009c: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_017f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0184: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Unknown result type (might be due to invalid IL or missing references)
				//IL_0122: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_0196: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a0: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					_0024wasK_00241310 = default(bool);
					if (_0024self__00241318.r.isKinematic)
					{
						_0024wasK_00241310 = true;
						((Component)_0024self__00241318).rigidbody.isKinematic = false;
					}
					int num = (_0024_0024502_00241311 = 2);
					Vector3 val = (_0024_0024503_00241312 = ((Component)_0024self__00241318).rigidbody.velocity);
					float num2 = (_0024_0024503_00241312.y = _0024_0024502_00241311);
					Vector3 val3 = (((Component)_0024self__00241318).rigidbody.velocity = _0024_0024503_00241312);
					if (_0024p_00241317.x <= _0024self__00241318.t.position.x)
					{
						int num3 = (_0024_0024506_00241315 = 10);
						Vector3 val4 = (_0024_0024507_00241316 = ((Component)_0024self__00241318).rigidbody.velocity);
						float num4 = (_0024_0024507_00241316.x = _0024_0024506_00241315);
						Vector3 val6 = (((Component)_0024self__00241318).rigidbody.velocity = _0024_0024507_00241316);
					}
					else
					{
						int num5 = (_0024_0024504_00241313 = -10);
						Vector3 val7 = (_0024_0024505_00241314 = ((Component)_0024self__00241318).rigidbody.velocity);
						float num6 = (_0024_0024505_00241314.x = _0024_0024504_00241313);
						Vector3 val9 = (((Component)_0024self__00241318).rigidbody.velocity = _0024_0024505_00241314);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
					if (_0024wasK_00241310)
					{
						((Component)_0024self__00241318).rigidbody.isKinematic = true;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024p_00241319;

		internal EnemyScript _0024self__00241320;

		public _0024Knock22_00241309(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241319 = p;
			_0024self__00241320 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241319, _0024self__00241320);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock_00241321 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024508_00241322;

			internal Vector3 _0024_0024509_00241323;

			internal int _0024_0024510_00241324;

			internal Vector3 _0024_0024511_00241325;

			internal int _0024_0024512_00241326;

			internal Vector3 _0024_0024513_00241327;

			internal Vector3 _0024p_00241328;

			internal EnemyScript _0024self__00241329;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241328 = p;
				_0024self__00241329 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0163: Unknown result type (might be due to invalid IL or missing references)
				//IL_0168: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Unknown result type (might be due to invalid IL or missing references)
				//IL_016b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0170: Unknown result type (might be due to invalid IL or missing references)
				//IL_0197: Unknown result type (might be due to invalid IL or missing references)
				//IL_019c: Unknown result type (might be due to invalid IL or missing references)
				//IL_019d: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_012a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0145: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00241329).networkView.RPC("KnockN", (RPCMode)2, new object[1] { _0024p_00241328 });
						goto IL_01a7;
					}
					if (_0024p_00241328.x <= _0024self__00241329.t.position.x)
					{
						int num3 = (_0024_0024510_00241324 = 10);
						Vector3 val4 = (_0024_0024511_00241325 = ((Component)_0024self__00241329).rigidbody.velocity);
						float num4 = (_0024_0024511_00241325.x = _0024_0024510_00241324);
						Vector3 val6 = (((Component)_0024self__00241329).rigidbody.velocity = _0024_0024511_00241325);
					}
					else
					{
						int num5 = (_0024_0024508_00241322 = -10);
						Vector3 val7 = (_0024_0024509_00241323 = ((Component)_0024self__00241329).rigidbody.velocity);
						float num6 = (_0024_0024509_00241323.x = _0024_0024508_00241322);
						Vector3 val9 = (((Component)_0024self__00241329).rigidbody.velocity = _0024_0024509_00241323);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024512_00241326 = 0);
					Vector3 val = (_0024_0024513_00241327 = ((Component)_0024self__00241329).rigidbody.velocity);
					float num2 = (_0024_0024513_00241327.x = _0024_0024512_00241326);
					Vector3 val3 = (((Component)_0024self__00241329).rigidbody.velocity = _0024_0024513_00241327);
					goto IL_01a7;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_01a7:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024p_00241330;

		internal EnemyScript _0024self__00241331;

		public _0024Knock_00241321(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241330 = p;
			_0024self__00241331 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241330, _0024self__00241331);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00241332 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024514_00241333;

			internal Vector3 _0024_0024515_00241334;

			internal int _0024_0024516_00241335;

			internal Vector3 _0024_0024517_00241336;

			internal int _0024_0024518_00241337;

			internal Vector3 _0024_0024519_00241338;

			internal int _0024_0024520_00241339;

			internal Vector3 _0024_0024521_00241340;

			internal Vector3 _0024p_00241341;

			internal EnemyScript _0024self__00241342;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241341 = p;
				_0024self__00241342 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018a: Unknown result type (might be due to invalid IL or missing references)
				//IL_018b: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0146: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_014c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0167: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					int num3 = (_0024_0024514_00241333 = 2);
					Vector3 val4 = (_0024_0024515_00241334 = ((Component)_0024self__00241342).rigidbody.velocity);
					float num4 = (_0024_0024515_00241334.y = _0024_0024514_00241333);
					Vector3 val6 = (((Component)_0024self__00241342).rigidbody.velocity = _0024_0024515_00241334);
					if (_0024p_00241341.x <= _0024self__00241342.t.position.x)
					{
						int num5 = (_0024_0024518_00241337 = 10);
						Vector3 val7 = (_0024_0024519_00241338 = ((Component)_0024self__00241342).rigidbody.velocity);
						float num6 = (_0024_0024519_00241338.x = _0024_0024518_00241337);
						Vector3 val9 = (((Component)_0024self__00241342).rigidbody.velocity = _0024_0024519_00241338);
					}
					else
					{
						int num7 = (_0024_0024516_00241335 = -10);
						Vector3 val10 = (_0024_0024517_00241336 = ((Component)_0024self__00241342).rigidbody.velocity);
						float num8 = (_0024_0024517_00241336.x = _0024_0024516_00241335);
						Vector3 val12 = (((Component)_0024self__00241342).rigidbody.velocity = _0024_0024517_00241336);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					int num = (_0024_0024520_00241339 = 0);
					Vector3 val = (_0024_0024521_00241340 = ((Component)_0024self__00241342).rigidbody.velocity);
					float num2 = (_0024_0024521_00241340.x = _0024_0024520_00241339);
					Vector3 val3 = (((Component)_0024self__00241342).rigidbody.velocity = _0024_0024521_00241340);
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

		internal Vector3 _0024p_00241343;

		internal EnemyScript _0024self__00241344;

		public _0024KnockN_00241332(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241343 = p;
			_0024self__00241344 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241343, _0024self__00241344);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00241345 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalDMG_00241346;

			internal GameObject _0024n3_00241347;

			internal GameObject _0024n2_00241348;

			internal int _0024_0024522_00241349;

			internal Vector3 _0024_0024523_00241350;

			internal int _0024_0024524_00241351;

			internal Vector3 _0024_0024525_00241352;

			internal int _0024dmg_00241353;

			internal EnemyScript _0024self__00241354;

			public _0024(int dmg, EnemyScript self_)
			{
				_0024dmg_00241353 = dmg;
				_0024self__00241354 = self_;
			}

			public override bool MoveNext()
			{
				//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0303: Unknown result type (might be due to invalid IL or missing references)
				//IL_0304: Unknown result type (might be due to invalid IL or missing references)
				//IL_030b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Expected O, but got Unknown
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Expected O, but got Unknown
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Expected O, but got Unknown
				//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ca: Expected O, but got Unknown
				//IL_0211: Unknown result type (might be due to invalid IL or missing references)
				//IL_0216: Unknown result type (might be due to invalid IL or missing references)
				//IL_0217: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_021d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Unknown result type (might be due to invalid IL or missing references)
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_024d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0277: Unknown result type (might be due to invalid IL or missing references)
				//IL_0281: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241354.takingDamage)
					{
						((Component)_0024self__00241354).audio.PlayOneShot(_0024self__00241354.aHit);
						_0024finalDMG_00241346 = _0024dmg_00241353;
						if (_0024finalDMG_00241346 < 1)
						{
							_0024finalDMG_00241346 = 1;
						}
						if (MenuScript.multiplayer > 0)
						{
							_0024n3_00241347 = (GameObject)Network.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241354.t.position, Quaternion.identity, 0);
							_0024n3_00241347.networkView.RPC("SDN", (RPCMode)2, new object[1] { _0024finalDMG_00241346 });
							((Component)_0024self__00241354).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024finalDMG_00241346 });
							((Component)_0024self__00241354).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024finalDMG_00241346 });
						}
						else
						{
							_0024self__00241354.takingDamage = true;
							if (_0024finalDMG_00241346 < 1)
							{
								_0024finalDMG_00241346 = 1;
							}
							_0024self__00241354.HP -= _0024finalDMG_00241346;
							_0024self__00241354.e.animation.Play();
							if (_0024dmg_00241353 > 0)
							{
								_0024n2_00241348 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241354.t.position, Quaternion.identity);
								_0024n2_00241348.SendMessage("SD", (object)_0024finalDMG_00241346);
							}
							if (!_0024self__00241354.r.isKinematic)
							{
								int num3 = (_0024_0024522_00241349 = 0);
								Vector3 val4 = (_0024_0024523_00241350 = ((Component)_0024self__00241354).rigidbody.velocity);
								float num4 = (_0024_0024523_00241350.x = _0024_0024522_00241349);
								Vector3 val6 = (((Component)_0024self__00241354).rigidbody.velocity = _0024_0024523_00241350);
							}
							if (_0024self__00241354.HP >= 1)
							{
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
								break;
							}
							_0024self__00241354.Die();
						}
					}
					goto IL_030e;
				case 2:
				{
					_0024self__00241354.e.animation.Stop();
					_0024self__00241354.takingDamage = false;
					int num = (_0024_0024524_00241351 = 0);
					Vector3 val = (_0024_0024525_00241352 = _0024self__00241354.e.transform.localPosition);
					float num2 = (_0024_0024525_00241352.z = _0024_0024524_00241351);
					Vector3 val3 = (_0024self__00241354.e.transform.localPosition = _0024_0024525_00241352);
					goto IL_030e;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_030e:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00241355;

		internal EnemyScript _0024self__00241356;

		public _0024TD_00241345(int dmg, EnemyScript self_)
		{
			_0024dmg_00241355 = dmg;
			_0024self__00241356 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241355, _0024self__00241356);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00241357 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024526_00241358;

			internal Vector3 _0024_0024527_00241359;

			internal int _0024_0024528_00241360;

			internal Vector3 _0024_0024529_00241361;

			internal EnemyScript _0024self__00241362;

			public _0024(EnemyScript self_)
			{
				_0024self__00241362 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_0107: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_010a: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				//IL_0141: Unknown result type (might be due to invalid IL or missing references)
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00be: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241362.e.animation.Play();
					if (!((Component)_0024self__00241362).rigidbody.isKinematic)
					{
						int num3 = (_0024_0024526_00241358 = 0);
						Vector3 val4 = (_0024_0024527_00241359 = ((Component)_0024self__00241362).rigidbody.velocity);
						float num4 = (_0024_0024527_00241359.x = _0024_0024526_00241358);
						Vector3 val6 = (((Component)_0024self__00241362).rigidbody.velocity = _0024_0024527_00241359);
					}
					if (_0024self__00241362.HP < 1)
					{
						goto IL_014b;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241362.e.animation.Stop();
					_0024self__00241362.takingDamage = false;
					int num = (_0024_0024528_00241360 = 0);
					Vector3 val = (_0024_0024529_00241361 = _0024self__00241362.e.transform.localPosition);
					float num2 = (_0024_0024529_00241361.z = _0024_0024528_00241360);
					Vector3 val3 = (_0024self__00241362.e.transform.localPosition = _0024_0024529_00241361);
					goto IL_014b;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_014b:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal EnemyScript _0024self__00241363;

		public _0024TDN2_00241357(EnemyScript self_)
		{
			_0024self__00241363 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241363);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KN_00241364 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00241365;

			internal int _0024_0024530_00241366;

			internal Vector3 _0024_0024531_00241367;

			internal int _0024_0024532_00241368;

			internal Vector3 _0024_0024533_00241369;

			internal int _0024_0024534_00241370;

			internal Vector3 _0024_0024535_00241371;

			internal int _0024_0024536_00241372;

			internal Vector3 _0024_0024537_00241373;

			internal bool _0024l_00241374;

			internal EnemyScript _0024self__00241375;

			public _0024(bool l, EnemyScript self_)
			{
				_0024l_00241374 = l;
				_0024self__00241375 = self_;
			}

			public override bool MoveNext()
			{
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0217: Expected O, but got Unknown
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0194: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0201: Expected O, but got Unknown
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_012f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241375.knocking = true;
					_0024wasK_00241365 = default(bool);
					if (_0024self__00241375.r.isKinematic)
					{
						_0024wasK_00241365 = true;
						_0024self__00241375.r.isKinematic = false;
					}
					if (_0024l_00241374)
					{
						int num = (_0024_0024530_00241366 = -15);
						Vector3 val = (_0024_0024531_00241367 = _0024self__00241375.r.velocity);
						float num2 = (_0024_0024531_00241367.x = _0024_0024530_00241366);
						Vector3 val3 = (_0024self__00241375.r.velocity = _0024_0024531_00241367);
						int num3 = (_0024_0024532_00241368 = 10);
						Vector3 val4 = (_0024_0024533_00241369 = _0024self__00241375.r.velocity);
						float num4 = (_0024_0024533_00241369.y = _0024_0024532_00241368);
						Vector3 val6 = (_0024self__00241375.r.velocity = _0024_0024533_00241369);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024534_00241370 = 15);
						Vector3 val7 = (_0024_0024535_00241371 = _0024self__00241375.r.velocity);
						float num6 = (_0024_0024535_00241371.x = _0024_0024534_00241370);
						Vector3 val9 = (_0024self__00241375.r.velocity = _0024_0024535_00241371);
						int num7 = (_0024_0024536_00241372 = 10);
						Vector3 val10 = (_0024_0024537_00241373 = _0024self__00241375.r.velocity);
						float num8 = (_0024_0024537_00241373.y = _0024_0024536_00241372);
						Vector3 val12 = (_0024self__00241375.r.velocity = _0024_0024537_00241373);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241375.knocking = false;
					if (_0024wasK_00241365)
					{
						_0024self__00241375.r.isKinematic = true;
					}
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00241376;

		internal EnemyScript _0024self__00241377;

		public _0024KN_00241364(bool l, EnemyScript self_)
		{
			_0024l_00241376 = l;
			_0024self__00241377 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00241376, _0024self__00241377);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00241378 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00241379;

			internal int _0024_0024538_00241380;

			internal Vector3 _0024_0024539_00241381;

			internal int _0024_0024540_00241382;

			internal Vector3 _0024_0024541_00241383;

			internal int _0024_0024542_00241384;

			internal Vector3 _0024_0024543_00241385;

			internal int _0024_0024544_00241386;

			internal Vector3 _0024_0024545_00241387;

			internal bool _0024l_00241388;

			internal EnemyScript _0024self__00241389;

			public _0024(bool l, EnemyScript self_)
			{
				_0024l_00241388 = l;
				_0024self__00241389 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_0251: Expected O, but got Unknown
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_0195: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_021f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0224: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Expected O, but got Unknown
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00241389).networkView.RPC("KN", (RPCMode)2, new object[1] { _0024l_00241388 });
						goto IL_027e;
					}
					_0024self__00241389.knocking = true;
					_0024wasK_00241379 = default(bool);
					if (_0024self__00241389.r.isKinematic)
					{
						_0024wasK_00241379 = true;
						_0024self__00241389.r.isKinematic = false;
					}
					if (_0024l_00241388)
					{
						int num = (_0024_0024538_00241380 = -12);
						Vector3 val = (_0024_0024539_00241381 = _0024self__00241389.r.velocity);
						float num2 = (_0024_0024539_00241381.x = _0024_0024538_00241380);
						Vector3 val3 = (_0024self__00241389.r.velocity = _0024_0024539_00241381);
						int num3 = (_0024_0024540_00241382 = 10);
						Vector3 val4 = (_0024_0024541_00241383 = _0024self__00241389.r.velocity);
						float num4 = (_0024_0024541_00241383.y = _0024_0024540_00241382);
						Vector3 val6 = (_0024self__00241389.r.velocity = _0024_0024541_00241383);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024542_00241384 = 12);
						Vector3 val7 = (_0024_0024543_00241385 = _0024self__00241389.r.velocity);
						float num6 = (_0024_0024543_00241385.x = _0024_0024542_00241384);
						Vector3 val9 = (_0024self__00241389.r.velocity = _0024_0024543_00241385);
						int num7 = (_0024_0024544_00241386 = 10);
						Vector3 val10 = (_0024_0024545_00241387 = _0024self__00241389.r.velocity);
						float num8 = (_0024_0024545_00241387.y = _0024_0024544_00241386);
						Vector3 val12 = (_0024self__00241389.r.velocity = _0024_0024545_00241387);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241389.knocking = false;
					if (_0024wasK_00241379)
					{
						_0024self__00241389.r.isKinematic = true;
					}
					goto IL_027e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_027e:
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00241390;

		internal EnemyScript _0024self__00241391;

		public _0024K_00241378(bool l, EnemyScript self_)
		{
			_0024l_00241390 = l;
			_0024self__00241391 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00241390, _0024self__00241391);
		}
	}

	public int bossID;

	public AudioClip a;

	public AudioClip aHit;

	public GameObject @base;

	public GameObject e;

	public bool moving;

	public int dir;

	public int HP;

	public int MAXHP;

	public int ATK;

	public int DEF;

	public int EXP;

	public int SPD;

	public int[] drops;

	public Transform t;

	public bool takingDamage;

	public Rigidbody r;

	private int GOLD;

	private int exp;

	public bool attacking;

	public bool knocking;

	private float poisonDMG;

	public EnemyScript()
	{
		drops = new int[3];
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
	}

	public override void SetStats(int HP, int ATK, int DEF, int EXP, float SPD, int[] drops, int coins, int exp)
	{
		MAXHP = HP;
		MAXHP = (int)((float)MAXHP + (float)HP * 0.75f * (float)Network.connections.Length);
		this.HP = MAXHP;
		this.ATK = ATK;
		this.ATK = (int)((float)this.ATK + (float)ATK * 0.5f * (float)Network.connections.Length);
		this.DEF = DEF;
		this.EXP = EXP;
		this.SPD = (int)SPD;
		this.drops = drops;
		GOLD = coins;
		this.exp = exp;
		poisonDMG = MAXHP;
		poisonDMG *= 0.2f;
	}

	public override void Update()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (!attacking && !knocking)
		{
			if (dir == 1 && moving)
			{
				@base.animation.Play("r");
				int num = -SPD;
				Vector3 velocity = ((Component)this).rigidbody.velocity;
				float num2 = (velocity.x = num);
				Vector3 val2 = (((Component)this).rigidbody.velocity = velocity);
				e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			}
			else if (dir == 2 && moving)
			{
				@base.animation.Play("r");
				int sPD = SPD;
				Vector3 velocity2 = ((Component)this).rigidbody.velocity;
				float num3 = (velocity2.x = sPD);
				Vector3 val4 = (((Component)this).rigidbody.velocity = velocity2);
				e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			else
			{
				@base.animation.Play("i");
			}
		}
	}

	public override void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.layer == 8)
		{
			c.gameObject.SendMessage("TD", (object)ATK);
		}
	}

	public override IEnumerator Knock22(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Knock22_00241309(p, this).GetEnumerator();
	}

	public override IEnumerator Knock(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Knock_00241321(p, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KnockN(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024KnockN_00241332(p, this).GetEnumerator();
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00241345(dmg, this).GetEnumerator();
	}

	[RPC]
	public override void TDN(int dmg)
	{
		takingDamage = true;
		e.animation.Play();
		HP -= dmg;
		if (HP < 1)
		{
			Die();
		}
		else
		{
			takingDamage = false;
		}
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00241357(this).GetEnumerator();
	}

	public override void Die()
	{
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		GameObject val = null;
		int num = default(int);
		Item item = null;
		if (bossID == 1)
		{
			MenuScript.canUnlockHat[8] = 1;
		}
		else if (bossID == 2)
		{
			MenuScript.canUnlockHat[14] = 1;
		}
		if (MenuScript.multiplayer > 0)
		{
			GameScript.tempStats[1] = GameScript.tempStats[1] + 1;
			if (GameScript.tempStats[1] > 14)
			{
				MenuScript.canUnlockRace[1] = 1;
			}
			else if (GameScript.tempStats[1] >= 60)
			{
				MenuScript.canUnlockHat[3] = 1;
			}
			if (Network.isServer)
			{
				for (num = 0; num < GOLD; num++)
				{
					Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
				}
				int num2 = exp;
				while (num2 >= 20)
				{
					num2 -= 20;
					Network.Instantiate(Resources.Load("expHuge"), t.position, Quaternion.identity, 0);
				}
				while (num2 >= 8)
				{
					num2 -= 8;
					Network.Instantiate(Resources.Load("expBig"), t.position, Quaternion.identity, 0);
				}
				for (num = 0; num < num2; num++)
				{
					Network.Instantiate(Resources.Load("exp"), t.position, Quaternion.identity, 0);
				}
				if (drops[0] > 0 && Random.Range(0, 2) == 0)
				{
					int num3 = Random.Range(1, 3);
					for (num = 0; num < num3; num++)
					{
						item = new Item(drops[0], 1, new int[4], 0f, null);
						if (MenuScript.multiplayer > 0)
						{
							val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
							val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
							val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
							val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
							val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { 1 });
						}
					}
				}
				if (drops[1] > 0 && Random.Range(0, 4) == 0)
				{
					int num4 = Random.Range(1, 3);
					item = new Item(drops[1], 1, new int[2], 0f, null);
					for (num = 0; num < num4; num++)
					{
						if (MenuScript.multiplayer > 0)
						{
							val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
							val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
							val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
							val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
							val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { 1 });
						}
						else
						{
							val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
							val.SendMessage("Set", (object)item);
						}
					}
				}
				if (drops[2] > 0 && Random.Range(0, 8) == 0)
				{
					int num5 = Random.Range(1, 3);
					item = new Item(drops[2], 1, new int[4], 0f, null);
					for (num = 0; num < num5; num++)
					{
						if (MenuScript.multiplayer > 0)
						{
							val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
							val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
							val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
							val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
							val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { 1 });
						}
						else
						{
							val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
							val.SendMessage("Set", (object)item);
						}
					}
				}
			}
		}
		if (MenuScript.multiplayer == 0)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (Network.isServer)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
			Network.Destroy(((Component)this).networkView.viewID);
		}
	}

	public override void OnDestroy()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer > 0)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
		}
	}

	[RPC]
	public override IEnumerator KN(bool l)
	{
		return new _0024KN_00241364(l, this).GetEnumerator();
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00241378(l, this).GetEnumerator();
	}

	public override void TDp()
	{
		int dmg = (int)poisonDMG;
		((MonoBehaviour)this).StartCoroutine_Auto(TD(dmg));
	}

	public override void Main()
	{
	}
}
