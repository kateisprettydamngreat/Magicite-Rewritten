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
	internal sealed class _0024SetStatsN_00241455 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024hp_00241456;

			internal int _0024atk_00241457;

			internal EnemyScript _0024self__00241458;

			public _0024(int hp, int atk, EnemyScript self_)
			{
				_0024hp_00241456 = hp;
				_0024atk_00241457 = atk;
				_0024self__00241458 = self_;
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
					_0024self__00241458.MAXHP = _0024hp_00241456;
					_0024self__00241458.HP = _0024hp_00241456;
					_0024self__00241458.ATK = _0024atk_00241457;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024hp_00241459;

		internal int _0024atk_00241460;

		internal EnemyScript _0024self__00241461;

		public _0024SetStatsN_00241455(int hp, int atk, EnemyScript self_)
		{
			_0024hp_00241459 = hp;
			_0024atk_00241460 = atk;
			_0024self__00241461 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024hp_00241459, _0024atk_00241460, _0024self__00241461);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock22_00241462 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024wasK_00241463;

			internal int _0024_0024523_00241464;

			internal Vector3 _0024_0024524_00241465;

			internal int _0024_0024525_00241466;

			internal Vector3 _0024_0024526_00241467;

			internal int _0024_0024527_00241468;

			internal Vector3 _0024_0024528_00241469;

			internal Vector3 _0024p_00241470;

			internal EnemyScript _0024self__00241471;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241470 = p;
				_0024self__00241471 = self_;
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
					_0024wasK_00241463 = default(bool);
					if (_0024self__00241471.r.isKinematic)
					{
						_0024wasK_00241463 = true;
						((Component)_0024self__00241471).rigidbody.isKinematic = false;
					}
					int num = (_0024_0024523_00241464 = 2);
					Vector3 val = (_0024_0024524_00241465 = ((Component)_0024self__00241471).rigidbody.velocity);
					float num2 = (_0024_0024524_00241465.y = _0024_0024523_00241464);
					Vector3 val3 = (((Component)_0024self__00241471).rigidbody.velocity = _0024_0024524_00241465);
					if (_0024p_00241470.x <= _0024self__00241471.t.position.x)
					{
						int num3 = (_0024_0024527_00241468 = 10);
						Vector3 val4 = (_0024_0024528_00241469 = ((Component)_0024self__00241471).rigidbody.velocity);
						float num4 = (_0024_0024528_00241469.x = _0024_0024527_00241468);
						Vector3 val6 = (((Component)_0024self__00241471).rigidbody.velocity = _0024_0024528_00241469);
					}
					else
					{
						int num5 = (_0024_0024525_00241466 = -10);
						Vector3 val7 = (_0024_0024526_00241467 = ((Component)_0024self__00241471).rigidbody.velocity);
						float num6 = (_0024_0024526_00241467.x = _0024_0024525_00241466);
						Vector3 val9 = (((Component)_0024self__00241471).rigidbody.velocity = _0024_0024526_00241467);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
					if (_0024wasK_00241463)
					{
						((Component)_0024self__00241471).rigidbody.isKinematic = true;
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

		internal Vector3 _0024p_00241472;

		internal EnemyScript _0024self__00241473;

		public _0024Knock22_00241462(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241472 = p;
			_0024self__00241473 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241472, _0024self__00241473);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock_00241474 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024529_00241475;

			internal Vector3 _0024_0024530_00241476;

			internal int _0024_0024531_00241477;

			internal Vector3 _0024_0024532_00241478;

			internal int _0024_0024533_00241479;

			internal Vector3 _0024_0024534_00241480;

			internal Vector3 _0024p_00241481;

			internal EnemyScript _0024self__00241482;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241481 = p;
				_0024self__00241482 = self_;
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
						((Component)_0024self__00241482).networkView.RPC("KnockN", (RPCMode)2, new object[1] { _0024p_00241481 });
						goto IL_01a7;
					}
					if (_0024p_00241481.x <= _0024self__00241482.t.position.x)
					{
						int num3 = (_0024_0024531_00241477 = 10);
						Vector3 val4 = (_0024_0024532_00241478 = ((Component)_0024self__00241482).rigidbody.velocity);
						float num4 = (_0024_0024532_00241478.x = _0024_0024531_00241477);
						Vector3 val6 = (((Component)_0024self__00241482).rigidbody.velocity = _0024_0024532_00241478);
					}
					else
					{
						int num5 = (_0024_0024529_00241475 = -10);
						Vector3 val7 = (_0024_0024530_00241476 = ((Component)_0024self__00241482).rigidbody.velocity);
						float num6 = (_0024_0024530_00241476.x = _0024_0024529_00241475);
						Vector3 val9 = (((Component)_0024self__00241482).rigidbody.velocity = _0024_0024530_00241476);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024533_00241479 = 0);
					Vector3 val = (_0024_0024534_00241480 = ((Component)_0024self__00241482).rigidbody.velocity);
					float num2 = (_0024_0024534_00241480.x = _0024_0024533_00241479);
					Vector3 val3 = (((Component)_0024self__00241482).rigidbody.velocity = _0024_0024534_00241480);
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

		internal Vector3 _0024p_00241483;

		internal EnemyScript _0024self__00241484;

		public _0024Knock_00241474(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241483 = p;
			_0024self__00241484 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241483, _0024self__00241484);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00241485 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024535_00241486;

			internal Vector3 _0024_0024536_00241487;

			internal int _0024_0024537_00241488;

			internal Vector3 _0024_0024538_00241489;

			internal int _0024_0024539_00241490;

			internal Vector3 _0024_0024540_00241491;

			internal int _0024_0024541_00241492;

			internal Vector3 _0024_0024542_00241493;

			internal Vector3 _0024p_00241494;

			internal EnemyScript _0024self__00241495;

			public _0024(Vector3 p, EnemyScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241494 = p;
				_0024self__00241495 = self_;
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
					int num3 = (_0024_0024535_00241486 = 2);
					Vector3 val4 = (_0024_0024536_00241487 = ((Component)_0024self__00241495).rigidbody.velocity);
					float num4 = (_0024_0024536_00241487.y = _0024_0024535_00241486);
					Vector3 val6 = (((Component)_0024self__00241495).rigidbody.velocity = _0024_0024536_00241487);
					if (_0024p_00241494.x <= _0024self__00241495.t.position.x)
					{
						int num5 = (_0024_0024539_00241490 = 10);
						Vector3 val7 = (_0024_0024540_00241491 = ((Component)_0024self__00241495).rigidbody.velocity);
						float num6 = (_0024_0024540_00241491.x = _0024_0024539_00241490);
						Vector3 val9 = (((Component)_0024self__00241495).rigidbody.velocity = _0024_0024540_00241491);
					}
					else
					{
						int num7 = (_0024_0024537_00241488 = -10);
						Vector3 val10 = (_0024_0024538_00241489 = ((Component)_0024self__00241495).rigidbody.velocity);
						float num8 = (_0024_0024538_00241489.x = _0024_0024537_00241488);
						Vector3 val12 = (((Component)_0024self__00241495).rigidbody.velocity = _0024_0024538_00241489);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					int num = (_0024_0024541_00241492 = 0);
					Vector3 val = (_0024_0024542_00241493 = ((Component)_0024self__00241495).rigidbody.velocity);
					float num2 = (_0024_0024542_00241493.x = _0024_0024541_00241492);
					Vector3 val3 = (((Component)_0024self__00241495).rigidbody.velocity = _0024_0024542_00241493);
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

		internal Vector3 _0024p_00241496;

		internal EnemyScript _0024self__00241497;

		public _0024KnockN_00241485(Vector3 p, EnemyScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241496 = p;
			_0024self__00241497 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241496, _0024self__00241497);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00241498 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalDMG_00241499;

			internal GameObject _0024n3_00241500;

			internal GameObject _0024n2_00241501;

			internal int _0024_0024543_00241502;

			internal Vector3 _0024_0024544_00241503;

			internal int _0024_0024545_00241504;

			internal Vector3 _0024_0024546_00241505;

			internal int _0024dmg_00241506;

			internal EnemyScript _0024self__00241507;

			public _0024(int dmg, EnemyScript self_)
			{
				_0024dmg_00241506 = dmg;
				_0024self__00241507 = self_;
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
					if (!_0024self__00241507.takingDamage)
					{
						((Component)_0024self__00241507).audio.PlayOneShot(_0024self__00241507.aHit);
						_0024finalDMG_00241499 = _0024dmg_00241506;
						if (_0024finalDMG_00241499 < 1)
						{
							_0024finalDMG_00241499 = 1;
						}
						if (MenuScript.multiplayer > 0)
						{
							_0024n3_00241500 = (GameObject)Network.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241507.t.position, Quaternion.identity, 0);
							_0024n3_00241500.networkView.RPC("SDN", (RPCMode)2, new object[1] { _0024finalDMG_00241499 });
							((Component)_0024self__00241507).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024finalDMG_00241499 });
							((Component)_0024self__00241507).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024finalDMG_00241499 });
						}
						else
						{
							_0024self__00241507.takingDamage = true;
							if (_0024finalDMG_00241499 < 1)
							{
								_0024finalDMG_00241499 = 1;
							}
							_0024self__00241507.HP -= _0024finalDMG_00241499;
							_0024self__00241507.e.animation.Play();
							if (_0024dmg_00241506 > 0)
							{
								_0024n2_00241501 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241507.t.position, Quaternion.identity);
								_0024n2_00241501.SendMessage("SD", (object)_0024finalDMG_00241499);
							}
							if (!_0024self__00241507.r.isKinematic)
							{
								int num3 = (_0024_0024543_00241502 = 0);
								Vector3 val4 = (_0024_0024544_00241503 = ((Component)_0024self__00241507).rigidbody.velocity);
								float num4 = (_0024_0024544_00241503.x = _0024_0024543_00241502);
								Vector3 val6 = (((Component)_0024self__00241507).rigidbody.velocity = _0024_0024544_00241503);
							}
							if (_0024self__00241507.HP >= 1)
							{
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
								break;
							}
							_0024self__00241507.Die();
						}
					}
					goto IL_030e;
				case 2:
				{
					_0024self__00241507.e.animation.Stop();
					_0024self__00241507.takingDamage = false;
					int num = (_0024_0024545_00241504 = 0);
					Vector3 val = (_0024_0024546_00241505 = _0024self__00241507.e.transform.localPosition);
					float num2 = (_0024_0024546_00241505.z = _0024_0024545_00241504);
					Vector3 val3 = (_0024self__00241507.e.transform.localPosition = _0024_0024546_00241505);
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

		internal int _0024dmg_00241508;

		internal EnemyScript _0024self__00241509;

		public _0024TD_00241498(int dmg, EnemyScript self_)
		{
			_0024dmg_00241508 = dmg;
			_0024self__00241509 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241508, _0024self__00241509);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00241510 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024547_00241511;

			internal Vector3 _0024_0024548_00241512;

			internal int _0024_0024549_00241513;

			internal Vector3 _0024_0024550_00241514;

			internal EnemyScript _0024self__00241515;

			public _0024(EnemyScript self_)
			{
				_0024self__00241515 = self_;
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
					_0024self__00241515.e.animation.Play();
					if (!((Component)_0024self__00241515).rigidbody.isKinematic)
					{
						int num3 = (_0024_0024547_00241511 = 0);
						Vector3 val4 = (_0024_0024548_00241512 = ((Component)_0024self__00241515).rigidbody.velocity);
						float num4 = (_0024_0024548_00241512.x = _0024_0024547_00241511);
						Vector3 val6 = (((Component)_0024self__00241515).rigidbody.velocity = _0024_0024548_00241512);
					}
					if (_0024self__00241515.HP < 1)
					{
						goto IL_014b;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241515.e.animation.Stop();
					_0024self__00241515.takingDamage = false;
					int num = (_0024_0024549_00241513 = 0);
					Vector3 val = (_0024_0024550_00241514 = _0024self__00241515.e.transform.localPosition);
					float num2 = (_0024_0024550_00241514.z = _0024_0024549_00241513);
					Vector3 val3 = (_0024self__00241515.e.transform.localPosition = _0024_0024550_00241514);
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

		internal EnemyScript _0024self__00241516;

		public _0024TDN2_00241510(EnemyScript self_)
		{
			_0024self__00241516 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241516);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KN_00241517 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00241518;

			internal int _0024_0024551_00241519;

			internal Vector3 _0024_0024552_00241520;

			internal int _0024_0024553_00241521;

			internal Vector3 _0024_0024554_00241522;

			internal int _0024_0024555_00241523;

			internal Vector3 _0024_0024556_00241524;

			internal int _0024_0024557_00241525;

			internal Vector3 _0024_0024558_00241526;

			internal bool _0024l_00241527;

			internal EnemyScript _0024self__00241528;

			public _0024(bool l, EnemyScript self_)
			{
				_0024l_00241527 = l;
				_0024self__00241528 = self_;
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
					_0024self__00241528.knocking = true;
					_0024wasK_00241518 = default(bool);
					if (_0024self__00241528.r.isKinematic)
					{
						_0024wasK_00241518 = true;
						_0024self__00241528.r.isKinematic = false;
					}
					if (_0024l_00241527)
					{
						int num = (_0024_0024551_00241519 = -15);
						Vector3 val = (_0024_0024552_00241520 = _0024self__00241528.r.velocity);
						float num2 = (_0024_0024552_00241520.x = _0024_0024551_00241519);
						Vector3 val3 = (_0024self__00241528.r.velocity = _0024_0024552_00241520);
						int num3 = (_0024_0024553_00241521 = 10);
						Vector3 val4 = (_0024_0024554_00241522 = _0024self__00241528.r.velocity);
						float num4 = (_0024_0024554_00241522.y = _0024_0024553_00241521);
						Vector3 val6 = (_0024self__00241528.r.velocity = _0024_0024554_00241522);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024555_00241523 = 15);
						Vector3 val7 = (_0024_0024556_00241524 = _0024self__00241528.r.velocity);
						float num6 = (_0024_0024556_00241524.x = _0024_0024555_00241523);
						Vector3 val9 = (_0024self__00241528.r.velocity = _0024_0024556_00241524);
						int num7 = (_0024_0024557_00241525 = 10);
						Vector3 val10 = (_0024_0024558_00241526 = _0024self__00241528.r.velocity);
						float num8 = (_0024_0024558_00241526.y = _0024_0024557_00241525);
						Vector3 val12 = (_0024self__00241528.r.velocity = _0024_0024558_00241526);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241528.knocking = false;
					if (_0024wasK_00241518)
					{
						_0024self__00241528.r.isKinematic = true;
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

		internal bool _0024l_00241529;

		internal EnemyScript _0024self__00241530;

		public _0024KN_00241517(bool l, EnemyScript self_)
		{
			_0024l_00241529 = l;
			_0024self__00241530 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00241529, _0024self__00241530);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00241531 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00241532;

			internal int _0024_0024559_00241533;

			internal Vector3 _0024_0024560_00241534;

			internal int _0024_0024561_00241535;

			internal Vector3 _0024_0024562_00241536;

			internal int _0024_0024563_00241537;

			internal Vector3 _0024_0024564_00241538;

			internal int _0024_0024565_00241539;

			internal Vector3 _0024_0024566_00241540;

			internal bool _0024l_00241541;

			internal EnemyScript _0024self__00241542;

			public _0024(bool l, EnemyScript self_)
			{
				_0024l_00241541 = l;
				_0024self__00241542 = self_;
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
						((Component)_0024self__00241542).networkView.RPC("KN", (RPCMode)2, new object[1] { _0024l_00241541 });
						goto IL_027e;
					}
					_0024self__00241542.knocking = true;
					_0024wasK_00241532 = default(bool);
					if (_0024self__00241542.r.isKinematic)
					{
						_0024wasK_00241532 = true;
						_0024self__00241542.r.isKinematic = false;
					}
					if (_0024l_00241541)
					{
						int num = (_0024_0024559_00241533 = -12);
						Vector3 val = (_0024_0024560_00241534 = _0024self__00241542.r.velocity);
						float num2 = (_0024_0024560_00241534.x = _0024_0024559_00241533);
						Vector3 val3 = (_0024self__00241542.r.velocity = _0024_0024560_00241534);
						int num3 = (_0024_0024561_00241535 = 10);
						Vector3 val4 = (_0024_0024562_00241536 = _0024self__00241542.r.velocity);
						float num4 = (_0024_0024562_00241536.y = _0024_0024561_00241535);
						Vector3 val6 = (_0024self__00241542.r.velocity = _0024_0024562_00241536);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024563_00241537 = 12);
						Vector3 val7 = (_0024_0024564_00241538 = _0024self__00241542.r.velocity);
						float num6 = (_0024_0024564_00241538.x = _0024_0024563_00241537);
						Vector3 val9 = (_0024self__00241542.r.velocity = _0024_0024564_00241538);
						int num7 = (_0024_0024565_00241539 = 10);
						Vector3 val10 = (_0024_0024566_00241540 = _0024self__00241542.r.velocity);
						float num8 = (_0024_0024566_00241540.y = _0024_0024565_00241539);
						Vector3 val12 = (_0024self__00241542.r.velocity = _0024_0024566_00241540);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241542.knocking = false;
					if (_0024wasK_00241532)
					{
						_0024self__00241542.r.isKinematic = true;
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

		internal bool _0024l_00241543;

		internal EnemyScript _0024self__00241544;

		public _0024K_00241531(bool l, EnemyScript self_)
		{
			_0024l_00241543 = l;
			_0024self__00241544 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00241543, _0024self__00241544);
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
		return new _0024SetStatsN_00241455(hp, atk, this).GetEnumerator();
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
			MAXHP = (int)((float)MAXHP + (float)HP * 0.75f * (float)Network.connections.Length);
			this.ATK = (int)((float)this.ATK + (float)ATK * 0.5f * (float)Network.connections.Length);
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
		return new _0024Knock22_00241462(p, this).GetEnumerator();
	}

	public override IEnumerator Knock(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Knock_00241474(p, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KnockN(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024KnockN_00241485(p, this).GetEnumerator();
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00241498(dmg, this).GetEnumerator();
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
		return new _0024TDN2_00241510(this).GetEnumerator();
	}

	public override void Die()
	{
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		GameObject val = null;
		int num = default(int);
		Item item = null;
		if (bossID > 0)
		{
			GameScript.bossesDefeated++;
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
		return new _0024KN_00241517(l, this).GetEnumerator();
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00241531(l, this).GetEnumerator();
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
