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
	internal sealed class _0024SetStatsN_00241491 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024hp_00241492;

			internal int _0024atk_00241493;

			internal EnemyScript _0024self__00241494;

			public _0024(int hp, int atk, EnemyScript self_)
			{
				_0024hp_00241492 = hp;
				_0024atk_00241493 = atk;
				_0024self__00241494 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241494.MAXHP = _0024hp_00241492;
					_0024self__00241494.HP = _0024hp_00241492;
					_0024self__00241494.ATK = _0024atk_00241493;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024hp_00241495;

		internal int _0024atk_00241496;

		internal EnemyScript _0024self__00241497;

		public _0024SetStatsN_00241491(int hp, int atk, EnemyScript self_)
		{
			_0024hp_00241495 = hp;
			_0024atk_00241496 = atk;
			_0024self__00241497 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024hp_00241495, _0024atk_00241496, _0024self__00241497);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock22_00241498 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024wasK_00241499;

			internal int _0024_0024532_00241500;

			internal Vector3 _0024_0024533_00241501;

			internal int _0024_0024534_00241502;

			internal Vector3 _0024_0024535_00241503;

			internal int _0024_0024536_00241504;

			internal Vector3 _0024_0024537_00241505;

			internal Vector3 _0024p_00241506;

			internal EnemyScript _0024self__00241507;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241506 = p;
				_0024self__00241507 = self_;
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
					_0024wasK_00241499 = default(bool);
					if (_0024self__00241507.r.isKinematic)
					{
						_0024wasK_00241499 = true;
						((Component)_0024self__00241507).rigidbody.isKinematic = false;
					}
					int num = (_0024_0024532_00241500 = 2);
					Vector3 val = (_0024_0024533_00241501 = ((Component)_0024self__00241507).rigidbody.velocity);
					float num2 = (_0024_0024533_00241501.y = _0024_0024532_00241500);
					Vector3 val3 = (((Component)_0024self__00241507).rigidbody.velocity = _0024_0024533_00241501);
					if (_0024p_00241506.x <= _0024self__00241507.t.position.x)
					{
						int num3 = (_0024_0024536_00241504 = 10);
						Vector3 val4 = (_0024_0024537_00241505 = ((Component)_0024self__00241507).rigidbody.velocity);
						float num4 = (_0024_0024537_00241505.x = _0024_0024536_00241504);
						Vector3 val6 = (((Component)_0024self__00241507).rigidbody.velocity = _0024_0024537_00241505);
					}
					else
					{
						int num5 = (_0024_0024534_00241502 = -10);
						Vector3 val7 = (_0024_0024535_00241503 = ((Component)_0024self__00241507).rigidbody.velocity);
						float num6 = (_0024_0024535_00241503.x = _0024_0024534_00241502);
						Vector3 val9 = (((Component)_0024self__00241507).rigidbody.velocity = _0024_0024535_00241503);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
					if (_0024wasK_00241499)
					{
						((Component)_0024self__00241507).rigidbody.isKinematic = true;
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

		internal Vector3 _0024p_00241508;

		internal EnemyScript _0024self__00241509;

		public _0024Knock22_00241498(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241508 = p;
			_0024self__00241509 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241508, _0024self__00241509);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock_00241510 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024538_00241511;

			internal Vector3 _0024_0024539_00241512;

			internal int _0024_0024540_00241513;

			internal Vector3 _0024_0024541_00241514;

			internal int _0024_0024542_00241515;

			internal Vector3 _0024_0024543_00241516;

			internal Vector3 _0024p_00241517;

			internal EnemyScript _0024self__00241518;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241517 = p;
				_0024self__00241518 = self_;
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
						((Component)_0024self__00241518).networkView.RPC("KnockN", (RPCMode)2, new object[1] { _0024p_00241517 });
						goto IL_01a7;
					}
					if (_0024p_00241517.x <= _0024self__00241518.t.position.x)
					{
						int num3 = (_0024_0024540_00241513 = 10);
						Vector3 val4 = (_0024_0024541_00241514 = ((Component)_0024self__00241518).rigidbody.velocity);
						float num4 = (_0024_0024541_00241514.x = _0024_0024540_00241513);
						Vector3 val6 = (((Component)_0024self__00241518).rigidbody.velocity = _0024_0024541_00241514);
					}
					else
					{
						int num5 = (_0024_0024538_00241511 = -10);
						Vector3 val7 = (_0024_0024539_00241512 = ((Component)_0024self__00241518).rigidbody.velocity);
						float num6 = (_0024_0024539_00241512.x = _0024_0024538_00241511);
						Vector3 val9 = (((Component)_0024self__00241518).rigidbody.velocity = _0024_0024539_00241512);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024542_00241515 = 0);
					Vector3 val = (_0024_0024543_00241516 = ((Component)_0024self__00241518).rigidbody.velocity);
					float num2 = (_0024_0024543_00241516.x = _0024_0024542_00241515);
					Vector3 val3 = (((Component)_0024self__00241518).rigidbody.velocity = _0024_0024543_00241516);
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

		internal Vector3 _0024p_00241519;

		internal EnemyScript _0024self__00241520;

		public _0024Knock_00241510(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241519 = p;
			_0024self__00241520 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241519, _0024self__00241520);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00241521 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024544_00241522;

			internal Vector3 _0024_0024545_00241523;

			internal int _0024_0024546_00241524;

			internal Vector3 _0024_0024547_00241525;

			internal int _0024_0024548_00241526;

			internal Vector3 _0024_0024549_00241527;

			internal int _0024_0024550_00241528;

			internal Vector3 _0024_0024551_00241529;

			internal Vector3 _0024p_00241530;

			internal EnemyScript _0024self__00241531;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241530 = p;
				_0024self__00241531 = self_;
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
					int num3 = (_0024_0024544_00241522 = 2);
					Vector3 val4 = (_0024_0024545_00241523 = ((Component)_0024self__00241531).rigidbody.velocity);
					float num4 = (_0024_0024545_00241523.y = _0024_0024544_00241522);
					Vector3 val6 = (((Component)_0024self__00241531).rigidbody.velocity = _0024_0024545_00241523);
					if (_0024p_00241530.x <= _0024self__00241531.t.position.x)
					{
						int num5 = (_0024_0024548_00241526 = 10);
						Vector3 val7 = (_0024_0024549_00241527 = ((Component)_0024self__00241531).rigidbody.velocity);
						float num6 = (_0024_0024549_00241527.x = _0024_0024548_00241526);
						Vector3 val9 = (((Component)_0024self__00241531).rigidbody.velocity = _0024_0024549_00241527);
					}
					else
					{
						int num7 = (_0024_0024546_00241524 = -10);
						Vector3 val10 = (_0024_0024547_00241525 = ((Component)_0024self__00241531).rigidbody.velocity);
						float num8 = (_0024_0024547_00241525.x = _0024_0024546_00241524);
						Vector3 val12 = (((Component)_0024self__00241531).rigidbody.velocity = _0024_0024547_00241525);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					int num = (_0024_0024550_00241528 = 0);
					Vector3 val = (_0024_0024551_00241529 = ((Component)_0024self__00241531).rigidbody.velocity);
					float num2 = (_0024_0024551_00241529.x = _0024_0024550_00241528);
					Vector3 val3 = (((Component)_0024self__00241531).rigidbody.velocity = _0024_0024551_00241529);
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

		internal Vector3 _0024p_00241532;

		internal EnemyScript _0024self__00241533;

		public _0024KnockN_00241521(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241532 = p;
			_0024self__00241533 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241532, _0024self__00241533);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00241534 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalDMG_00241535;

			internal GameObject _0024n3_00241536;

			internal GameObject _0024n2_00241537;

			internal int _0024_0024552_00241538;

			internal Vector3 _0024_0024553_00241539;

			internal int _0024_0024554_00241540;

			internal Vector3 _0024_0024555_00241541;

			internal int _0024dmg_00241542;

			internal EnemyScript _0024self__00241543;

			public _0024(int dmg, EnemyScript self_)
			{
				_0024dmg_00241542 = dmg;
				_0024self__00241543 = self_;
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
					if (!_0024self__00241543.takingDamage)
					{
						((Component)_0024self__00241543).audio.PlayOneShot(_0024self__00241543.aHit);
						_0024finalDMG_00241535 = _0024dmg_00241542;
						if (_0024finalDMG_00241535 < 1)
						{
							_0024finalDMG_00241535 = 1;
						}
						if (MenuScript.multiplayer > 0)
						{
							_0024n3_00241536 = (GameObject)Network.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241543.t.position, Quaternion.identity, 0);
							_0024n3_00241536.networkView.RPC("SDN", (RPCMode)2, new object[1] { _0024finalDMG_00241535 });
							((Component)_0024self__00241543).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024finalDMG_00241535 });
							((Component)_0024self__00241543).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024finalDMG_00241535 });
						}
						else
						{
							_0024self__00241543.takingDamage = true;
							if (_0024finalDMG_00241535 < 1)
							{
								_0024finalDMG_00241535 = 1;
							}
							_0024self__00241543.HP -= _0024finalDMG_00241535;
							_0024self__00241543.e.animation.Play();
							if (_0024dmg_00241542 > 0)
							{
								_0024n2_00241537 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241543.t.position, Quaternion.identity);
								_0024n2_00241537.SendMessage("SD", (object)_0024finalDMG_00241535);
							}
							if (!_0024self__00241543.r.isKinematic)
							{
								int num3 = (_0024_0024552_00241538 = 0);
								Vector3 val4 = (_0024_0024553_00241539 = ((Component)_0024self__00241543).rigidbody.velocity);
								float num4 = (_0024_0024553_00241539.x = _0024_0024552_00241538);
								Vector3 val6 = (((Component)_0024self__00241543).rigidbody.velocity = _0024_0024553_00241539);
							}
							if (_0024self__00241543.HP >= 1)
							{
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
								break;
							}
							_0024self__00241543.Die();
						}
					}
					goto IL_030e;
				case 2:
				{
					_0024self__00241543.e.animation.Stop();
					_0024self__00241543.takingDamage = false;
					int num = (_0024_0024554_00241540 = 0);
					Vector3 val = (_0024_0024555_00241541 = _0024self__00241543.e.transform.localPosition);
					float num2 = (_0024_0024555_00241541.z = _0024_0024554_00241540);
					Vector3 val3 = (_0024self__00241543.e.transform.localPosition = _0024_0024555_00241541);
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

		internal int _0024dmg_00241544;

		internal EnemyScript _0024self__00241545;

		public _0024TD_00241534(int dmg, EnemyScript self_)
		{
			_0024dmg_00241544 = dmg;
			_0024self__00241545 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241544, _0024self__00241545);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00241546 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024556_00241547;

			internal Vector3 _0024_0024557_00241548;

			internal int _0024_0024558_00241549;

			internal Vector3 _0024_0024559_00241550;

			internal EnemyScript _0024self__00241551;

			public _0024(EnemyScript self_)
			{
				_0024self__00241551 = self_;
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
					_0024self__00241551.e.animation.Play();
					if (!((Component)_0024self__00241551).rigidbody.isKinematic)
					{
						int num3 = (_0024_0024556_00241547 = 0);
						Vector3 val4 = (_0024_0024557_00241548 = ((Component)_0024self__00241551).rigidbody.velocity);
						float num4 = (_0024_0024557_00241548.x = _0024_0024556_00241547);
						Vector3 val6 = (((Component)_0024self__00241551).rigidbody.velocity = _0024_0024557_00241548);
					}
					if (_0024self__00241551.HP < 1)
					{
						goto IL_014b;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241551.e.animation.Stop();
					_0024self__00241551.takingDamage = false;
					int num = (_0024_0024558_00241549 = 0);
					Vector3 val = (_0024_0024559_00241550 = _0024self__00241551.e.transform.localPosition);
					float num2 = (_0024_0024559_00241550.z = _0024_0024558_00241549);
					Vector3 val3 = (_0024self__00241551.e.transform.localPosition = _0024_0024559_00241550);
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

		internal EnemyScript _0024self__00241552;

		public _0024TDN2_00241546(EnemyScript self_)
		{
			_0024self__00241552 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241552);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KN_00241553 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00241554;

			internal int _0024_0024560_00241555;

			internal Vector3 _0024_0024561_00241556;

			internal int _0024_0024562_00241557;

			internal Vector3 _0024_0024563_00241558;

			internal int _0024_0024564_00241559;

			internal Vector3 _0024_0024565_00241560;

			internal int _0024_0024566_00241561;

			internal Vector3 _0024_0024567_00241562;

			internal bool _0024l_00241563;

			internal EnemyScript _0024self__00241564;

			public _0024(bool l, EnemyScript self_)
			{
				_0024l_00241563 = l;
				_0024self__00241564 = self_;
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
					_0024self__00241564.knocking = true;
					_0024wasK_00241554 = default(bool);
					if (_0024self__00241564.r.isKinematic)
					{
						_0024wasK_00241554 = true;
						_0024self__00241564.r.isKinematic = false;
					}
					if (_0024l_00241563)
					{
						int num = (_0024_0024560_00241555 = -15);
						Vector3 val = (_0024_0024561_00241556 = _0024self__00241564.r.velocity);
						float num2 = (_0024_0024561_00241556.x = _0024_0024560_00241555);
						Vector3 val3 = (_0024self__00241564.r.velocity = _0024_0024561_00241556);
						int num3 = (_0024_0024562_00241557 = 10);
						Vector3 val4 = (_0024_0024563_00241558 = _0024self__00241564.r.velocity);
						float num4 = (_0024_0024563_00241558.y = _0024_0024562_00241557);
						Vector3 val6 = (_0024self__00241564.r.velocity = _0024_0024563_00241558);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024564_00241559 = 15);
						Vector3 val7 = (_0024_0024565_00241560 = _0024self__00241564.r.velocity);
						float num6 = (_0024_0024565_00241560.x = _0024_0024564_00241559);
						Vector3 val9 = (_0024self__00241564.r.velocity = _0024_0024565_00241560);
						int num7 = (_0024_0024566_00241561 = 10);
						Vector3 val10 = (_0024_0024567_00241562 = _0024self__00241564.r.velocity);
						float num8 = (_0024_0024567_00241562.y = _0024_0024566_00241561);
						Vector3 val12 = (_0024self__00241564.r.velocity = _0024_0024567_00241562);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241564.knocking = false;
					if (_0024wasK_00241554)
					{
						_0024self__00241564.r.isKinematic = true;
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

		internal bool _0024l_00241565;

		internal EnemyScript _0024self__00241566;

		public _0024KN_00241553(bool l, EnemyScript self_)
		{
			_0024l_00241565 = l;
			_0024self__00241566 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00241565, _0024self__00241566);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00241567 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00241568;

			internal int _0024_0024568_00241569;

			internal Vector3 _0024_0024569_00241570;

			internal int _0024_0024570_00241571;

			internal Vector3 _0024_0024571_00241572;

			internal int _0024_0024572_00241573;

			internal Vector3 _0024_0024573_00241574;

			internal int _0024_0024574_00241575;

			internal Vector3 _0024_0024575_00241576;

			internal bool _0024l_00241577;

			internal EnemyScript _0024self__00241578;

			public _0024(bool l, EnemyScript self_)
			{
				_0024l_00241577 = l;
				_0024self__00241578 = self_;
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
						((Component)_0024self__00241578).networkView.RPC("KN", (RPCMode)2, new object[1] { _0024l_00241577 });
						goto IL_027e;
					}
					_0024self__00241578.knocking = true;
					_0024wasK_00241568 = default(bool);
					if (_0024self__00241578.r.isKinematic)
					{
						_0024wasK_00241568 = true;
						_0024self__00241578.r.isKinematic = false;
					}
					if (_0024l_00241577)
					{
						int num = (_0024_0024568_00241569 = -12);
						Vector3 val = (_0024_0024569_00241570 = _0024self__00241578.r.velocity);
						float num2 = (_0024_0024569_00241570.x = _0024_0024568_00241569);
						Vector3 val3 = (_0024self__00241578.r.velocity = _0024_0024569_00241570);
						int num3 = (_0024_0024570_00241571 = 10);
						Vector3 val4 = (_0024_0024571_00241572 = _0024self__00241578.r.velocity);
						float num4 = (_0024_0024571_00241572.y = _0024_0024570_00241571);
						Vector3 val6 = (_0024self__00241578.r.velocity = _0024_0024571_00241572);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024572_00241573 = 12);
						Vector3 val7 = (_0024_0024573_00241574 = _0024self__00241578.r.velocity);
						float num6 = (_0024_0024573_00241574.x = _0024_0024572_00241573);
						Vector3 val9 = (_0024self__00241578.r.velocity = _0024_0024573_00241574);
						int num7 = (_0024_0024574_00241575 = 10);
						Vector3 val10 = (_0024_0024575_00241576 = _0024self__00241578.r.velocity);
						float num8 = (_0024_0024575_00241576.y = _0024_0024574_00241575);
						Vector3 val12 = (_0024self__00241578.r.velocity = _0024_0024575_00241576);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241578.knocking = false;
					if (_0024wasK_00241568)
					{
						_0024self__00241578.r.isKinematic = true;
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

		internal bool _0024l_00241579;

		internal EnemyScript _0024self__00241580;

		public _0024K_00241567(bool l, EnemyScript self_)
		{
			_0024l_00241579 = l;
			_0024self__00241580 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00241579, _0024self__00241580);
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

	[RPC]
	public override IEnumerator SetStatsN(int hp, int atk)
	{
		return new _0024SetStatsN_00241491(hp, atk, this).GetEnumerator();
	}

	public override void SetStats(int HP, int ATK, int DEF, int EXP, float SPD, int[] drops, int coins, int exp)
	{
		MAXHP = HP;
		this.HP = MAXHP;
		this.ATK = ATK;
		this.DEF = DEF;
		this.EXP = EXP;
		this.SPD = (int)SPD;
		this.drops = drops;
		GOLD = coins;
		this.exp = exp;
		poisonDMG = MAXHP;
		poisonDMG *= 0.2f;
		if (MenuScript.multiplayer == 1)
		{
			MAXHP = (int)((float)MAXHP + (float)HP * 0.5f * (float)Network.connections.Length);
			this.ATK = (int)((float)this.ATK + (float)ATK * 0.4f * (float)Network.connections.Length);
			((Component)this).networkView.RPC("SetStatsN", (RPCMode)2, new object[2] { MAXHP, this.ATK });
		}
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
		return new _0024Knock22_00241498(p, this).GetEnumerator();
	}

	public override IEnumerator Knock(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Knock_00241510(p, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KnockN(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024KnockN_00241521(p, this).GetEnumerator();
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00241534(dmg, this).GetEnumerator();
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
		return new _0024TDN2_00241546(this).GetEnumerator();
	}

	public override void Die()
	{
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		GameObject val = null;
		int num = default(int);
		Item item = null;
		if (bossID > 0)
		{
			GameScript.tempStats[10] = GameScript.tempStats[10] + 1;
		}
		if (bossID == 1)
		{
			MenuScript.canUnlockHat[8] = 1;
		}
		else if (bossID == 2)
		{
			MenuScript.canUnlockHat[14] = 1;
		}
		else if (bossID == 3)
		{
			MenuScript.canUnlockHat[18] = 1;
		}
		else if (bossID == 4)
		{
			MenuScript.canUnlockHat[20] = 1;
		}
		else if (bossID == 5)
		{
			MenuScript.canUnlockHat[21] = 1;
		}
		else if (bossID == 6)
		{
			MenuScript.canUnlockHat[22] = 1;
		}
		if (MenuScript.multiplayer > 0)
		{
			GameScript.tempStats[1] = GameScript.tempStats[1] + 1;
			if (GameScript.tempStats[1] > 14)
			{
				MenuScript.canUnlockRace[1] = 1;
			}
			else if (GameScript.tempStats[1] >= 10)
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
						if (item.id == 566)
						{
							item.e = new int[4] { -3, 100, 0, 0 };
							item.d = 100;
						}
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
					if (item.id == 566)
					{
						item.e = new int[4] { -3, 100, 0, 0 };
						item.d = 100;
					}
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
		return new _0024KN_00241553(l, this).GetEnumerator();
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00241567(l, this).GetEnumerator();
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
