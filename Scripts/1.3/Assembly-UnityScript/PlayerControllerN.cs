using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class PlayerControllerN : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024iceShard_00242358 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalM_00242359;

			internal int _0024mag_00242360;

			internal PlayerControllerN _0024self__00242361;

			public _0024(int mag, PlayerControllerN self_)
			{
				_0024mag_00242360 = mag;
				_0024self__00242361 = self_;
			}

			public override bool MoveNext()
			{
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0138: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242361).networkView.isMine)
					{
						_0024self__00242361.shard.SetActive(true);
						((Component)_0024self__00242361).networkView.RPC("iceShardN", (RPCMode)6, new object[2] { _0024mag_00242360, 1 });
						_0024finalM_00242359 = (int)((float)_0024mag_00242360 * 0.5f);
						_0024self__00242361.shard1.networkView.RPC("SetHH", (RPCMode)6, new object[1] { _0024finalM_00242359 });
						_0024self__00242361.shard2.networkView.RPC("SetHH", (RPCMode)6, new object[1] { _0024finalM_00242359 });
						_0024self__00242361.shard3.networkView.RPC("SetHH", (RPCMode)6, new object[1] { _0024finalM_00242359 });
						_0024self__00242361.shardCount++;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
						break;
					}
					goto IL_0199;
				case 2:
					_0024self__00242361.shardCount--;
					if (_0024self__00242361.shardCount <= 0)
					{
						((Component)_0024self__00242361).networkView.RPC("iceShardN", (RPCMode)2, new object[2] { _0024mag_00242360, 0 });
					}
					goto IL_0199;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0199:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024mag_00242362;

		internal PlayerControllerN _0024self__00242363;

		public _0024iceShard_00242358(int mag, PlayerControllerN self_)
		{
			_0024mag_00242362 = mag;
			_0024self__00242363 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024mag_00242362, _0024self__00242363);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242364 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242365;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242365 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(60f)) ? 1 : 0);
					break;
				case 2:
					if (((Component)_0024self__00242365).networkView.isMine && !downed)
					{
						_0024self__00242365.gameScript.DecreaseHunger();
					}
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242366;

		public _0024Start_00242364(PlayerControllerN self_)
		{
			_0024self__00242366 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242366);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SetZoneName_00242367 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00242368;

			internal PlayerControllerN _0024self__00242369;

			public _0024(string s, PlayerControllerN self_)
			{
				_0024s_00242368 = s;
				_0024self__00242369 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242369.leaving = false;
					if (Object.op_Implicit((Object)(object)_0024self__00242369.gameScript))
					{
						_0024self__00242369.gameScript.txtZone.text = _0024s_00242368;
						_0024self__00242369.gameScript.txtLevelName.text = _0024s_00242368;
						((Component)_0024self__00242369.gameScript.txtLevelName).gameObject.SetActive(true);
					}
					else if (((Component)_0024self__00242369).networkView.isMine)
					{
						_0024self__00242369.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0143;
				case 2:
					if (Object.op_Implicit((Object)(object)_0024self__00242369.gameScript))
					{
						_0024self__00242369.gameScript.txtZone.text = _0024s_00242368;
						_0024self__00242369.gameScript.txtLevelName.text = _0024s_00242368;
						((Component)_0024self__00242369.gameScript.txtLevelName).gameObject.SetActive(true);
					}
					goto IL_0143;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0143:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024s_00242370;

		internal PlayerControllerN _0024self__00242371;

		public _0024SetZoneName_00242367(string s, PlayerControllerN self_)
		{
			_0024s_00242370 = s;
			_0024self__00242371 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024s_00242370, _0024self__00242371);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DrumATKTick_00242372 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242373;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242373 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242373).networkView.isMine)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
						break;
					}
					goto IL_009f;
				case 2:
					if (GameScript.drumATK > 10)
					{
						GameScript.drumATK -= 10;
					}
					else
					{
						GameScript.drumATK = 0;
					}
					if (MenuScript.multiplayer > 0 && GameScript.drumATK <= 0)
					{
						((Component)_0024self__00242373).networkView.RPC("drumATKN", (RPCMode)6, new object[1] { 0 });
					}
					goto IL_009f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_009f:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242374;

		public _0024DrumATKTick_00242372(PlayerControllerN self_)
		{
			_0024self__00242374 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242374);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DrumDEXTick_00242375 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242376;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242376 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242376).networkView.isMine)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
						break;
					}
					goto IL_009f;
				case 2:
					if (GameScript.drumDEX > 10)
					{
						GameScript.drumDEX -= 10;
					}
					else
					{
						GameScript.drumDEX = 0;
					}
					if (MenuScript.multiplayer > 0 && GameScript.drumDEX <= 0)
					{
						((Component)_0024self__00242376).networkView.RPC("drumDEXN", (RPCMode)6, new object[1] { 0 });
					}
					goto IL_009f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_009f:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242377;

		public _0024DrumDEXTick_00242375(PlayerControllerN self_)
		{
			_0024self__00242377 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242377);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DrumMAGTick_00242378 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242379;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242379 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242379).networkView.isMine)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
						break;
					}
					goto IL_009f;
				case 2:
					if (GameScript.drumMAG > 10)
					{
						GameScript.drumMAG -= 10;
					}
					else
					{
						GameScript.drumMAG = 0;
					}
					if (MenuScript.multiplayer > 0 && GameScript.drumMAG <= 0)
					{
						((Component)_0024self__00242379).networkView.RPC("drumMAGN", (RPCMode)6, new object[1] { 0 });
					}
					goto IL_009f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_009f:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242380;

		public _0024DrumMAGTick_00242378(PlayerControllerN self_)
		{
			_0024self__00242380 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242380);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeaponsN_00242381 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242382;

			internal PlayerControllerN _0024self__00242383;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242382 = a;
				_0024self__00242383 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					mBonus += _0024a_00242382;
					_0024self__00242383.mWeapon.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
					break;
				case 2:
					mBonus -= _0024a_00242382;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00242383.mWeapon.SetActive(false);
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

		internal int _0024a_00242384;

		internal PlayerControllerN _0024self__00242385;

		public _0024mWeaponsN_00242381(int a, PlayerControllerN self_)
		{
			_0024a_00242384 = a;
			_0024self__00242385 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242384, _0024self__00242385);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeapons_00242386 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242387;

			internal PlayerControllerN _0024self__00242388;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242387 = a;
				_0024self__00242388 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242388).networkView.RPC("mWeaponsN", (RPCMode)2, new object[1] { _0024a_00242387 });
						goto IL_00c4;
					}
					mBonus += _0024a_00242387;
					_0024self__00242388.mWeapon.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					mBonus -= _0024a_00242387;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00242388.mWeapon.SetActive(false);
					}
					goto IL_00c4;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00c4:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242389;

		internal PlayerControllerN _0024self__00242390;

		public _0024mWeapons_00242386(int a, PlayerControllerN self_)
		{
			_0024a_00242389 = a;
			_0024self__00242390 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242389, _0024self__00242390);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HELP_00242391 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242392;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242392 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c2: Expected O, but got Unknown
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fa: Expected O, but got Unknown
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242392.reviving)
					{
						((Component)_0024self__00242392).networkView.RPC("EX", (RPCMode)2, new object[0]);
						_0024self__00242392.reviving = true;
						((Component)_0024self__00242392).networkView.RPC("Tick", (RPCMode)2, new object[1] { 3 });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_014c;
				case 2:
					((Component)_0024self__00242392).networkView.RPC("Tick", (RPCMode)2, new object[1] { 2 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00242392).networkView.RPC("Tick", (RPCMode)2, new object[1] { 1 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242392.reviving = false;
					((Component)_0024self__00242392).networkView.RPC("Tick", (RPCMode)2, new object[1] { 0 });
					((Component)_0024self__00242392).networkView.RPC("Revive", (RPCMode)6, new object[0]);
					goto IL_014c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_014c:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242393;

		public _0024HELP_00242391(PlayerControllerN self_)
		{
			_0024self__00242393 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242393);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeN_00242394 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242395;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242395 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242395.particleCharge.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242395.chargeBoost -= 4;
					if (_0024self__00242395.chargeBoost < 0)
					{
						_0024self__00242395.chargeBoost = 0;
					}
					if (_0024self__00242395.chargeBoost == 0)
					{
						_0024self__00242395.particleCharge.SetActive(false);
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

		internal PlayerControllerN _0024self__00242396;

		public _0024ChargeN_00242394(PlayerControllerN self_)
		{
			_0024self__00242396 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242396);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Charge_00242397 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242398;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242398 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242398.chargeBoost += 4;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242398).networkView.RPC("ChargeN", (RPCMode)2, new object[0]);
						goto IL_00d6;
					}
					_0024self__00242398.particleCharge.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242398.chargeBoost -= 4;
					if (_0024self__00242398.chargeBoost < 0)
					{
						_0024self__00242398.chargeBoost = 0;
					}
					if (_0024self__00242398.chargeBoost == 0)
					{
						_0024self__00242398.particleCharge.SetActive(false);
					}
					goto IL_00d6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00d6:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242399;

		public _0024Charge_00242397(PlayerControllerN self_)
		{
			_0024self__00242399 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242399);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Offledge_00242400 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242401;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242401 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242401.offledge)
					{
						_0024self__00242401.offledge = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						break;
					}
					goto IL_00f9;
				case 2:
					if (Physics.Raycast(_0024self__00242401.ray, ref _0024self__00242401.hit, 1.5f))
					{
						if (((Component)((RaycastHit)(ref _0024self__00242401.hit)).transform).gameObject.layer == 11)
						{
							_0024self__00242401.grounded = true;
							_0024self__00242401.mode = 0;
							_0024self__00242401.canDoubleJump = true;
						}
						else
						{
							_0024self__00242401.mode = 2;
							_0024self__00242401.grounded = false;
						}
					}
					else
					{
						_0024self__00242401.mode = 2;
						_0024self__00242401.grounded = false;
					}
					_0024self__00242401.offledge = false;
					goto IL_00f9;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00f9:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242402;

		public _0024Offledge_00242400(PlayerControllerN self_)
		{
			_0024self__00242402 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242402);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024EnterDoor_00242403 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024cd_00242404;

			internal PlayerControllerN _0024self__00242405;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242405 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242405.leaving = true;
					_0024cd_00242404 = GameScript.curDoor;
					MonoBehaviour.print((object)((object)_0024cd_00242404 + " CURDOOOOOR "));
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							_0024self__00242405.inDoor = true;
							((Component)_0024self__00242405).networkView.RPC("Leaving", (RPCMode)6, new object[1] { _0024cd_00242404 });
						}
						else
						{
							_0024self__00242405.inDoor = true;
							((Component)_0024self__00242405).networkView.RPC("Leaving", (RPCMode)6, new object[1] { _0024cd_00242404 });
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242405.leaving = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242406;

		public _0024EnterDoor_00242403(PlayerControllerN self_)
		{
			_0024self__00242406 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242406);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LeaveDoor_00242407 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024d_00242408;

			internal int _0024_0024880_00242409;

			internal Vector3 _0024_0024881_00242410;

			internal PlayerControllerN _0024self__00242411;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242411 = self_;
			}

			public override bool MoveNext()
			{
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Unknown result type (might be due to invalid IL or missing references)
				//IL_016d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0177: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					_0024self__00242411.leaving = true;
					_0024self__00242411.inDoor = false;
					_0024self__00242411.trigger.canLeave = true;
					int num = (_0024_0024880_00242409 = 0);
					Vector3 val = (_0024_0024881_00242410 = _0024self__00242411.p.transform.position);
					float num2 = (_0024_0024881_00242410.z = _0024_0024880_00242409);
					Vector3 val3 = (_0024self__00242411.p.transform.position = _0024_0024881_00242410);
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							_0024self__00242411.inDoor = false;
							_0024self__00242411.NotLeaving(GameScript.curDoor);
						}
						else
						{
							_0024self__00242411.inDoor = false;
							((Component)_0024self__00242411).networkView.RPC("NotLeaving", (RPCMode)0, new object[1] { GameScript.curDoor });
						}
					}
					else
					{
						_0024self__00242411.inDoor = false;
						if (((Component)_0024self__00242411).networkView.isMine)
						{
							_0024d_00242408 = GameScript.curDoor;
							((Component)_0024self__00242411).networkView.RPC("NotLeaving", (RPCMode)0, new object[1] { _0024d_00242408 });
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
					_0024self__00242411.leaving = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242412;

		public _0024LeaveDoor_00242407(PlayerControllerN self_)
		{
			_0024self__00242412 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242412);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HELPSTAY_00242413 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242414;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242414 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0057: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242414).networkView.isMine)
					{
						_0024self__00242414.gameScript.immobilized = true;
						_0024self__00242414.immobilized = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
						break;
					}
					goto IL_0079;
				case 2:
					_0024self__00242414.gameScript.immobilized = false;
					_0024self__00242414.immobilized = false;
					goto IL_0079;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0079:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242415;

		public _0024HELPSTAY_00242413(PlayerControllerN self_)
		{
			_0024self__00242415 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242415);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Dash_00242416 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024bonus_00242417;

			internal GameObject _0024dd_00242418;

			internal int _0024_0024882_00242419;

			internal Vector3 _0024_0024883_00242420;

			internal int _0024_0024884_00242421;

			internal Vector3 _0024_0024885_00242422;

			internal int _0024_0024886_00242423;

			internal Vector3 _0024_0024887_00242424;

			internal int _0024_0024888_00242425;

			internal Vector3 _0024_0024889_00242426;

			internal int _0024a_00242427;

			internal PlayerControllerN _0024self__00242428;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242427 = a;
				_0024self__00242428 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0375: Unknown result type (might be due to invalid IL or missing references)
				//IL_037a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_022b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0245: Expected O, but got Unknown
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Unknown result type (might be due to invalid IL or missing references)
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0162: Unknown result type (might be due to invalid IL or missing references)
				//IL_0163: Unknown result type (might be due to invalid IL or missing references)
				//IL_0164: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_0199: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0302: Unknown result type (might be due to invalid IL or missing references)
				//IL_0329: Unknown result type (might be due to invalid IL or missing references)
				//IL_032e: Unknown result type (might be due to invalid IL or missing references)
				//IL_032f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0336: Unknown result type (might be due to invalid IL or missing references)
				//IL_028b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0290: Unknown result type (might be due to invalid IL or missing references)
				//IL_0291: Unknown result type (might be due to invalid IL or missing references)
				//IL_0293: Unknown result type (might be due to invalid IL or missing references)
				//IL_0298: Unknown result type (might be due to invalid IL or missing references)
				//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0340: Unknown result type (might be due to invalid IL or missing references)
				//IL_034a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!(_0024self__00242428.gameScript.stamina < 1f))
					{
						_0024self__00242428.dashing = true;
						_0024self__00242428.gameScript.Stamina();
						if (MenuScript.pHat != 20)
						{
							_0024self__00242428.gameScript.stamina = _0024self__00242428.gameScript.stamina - 1f;
						}
						_0024self__00242428.gameScript.LoadSTA();
						_0024bonus_00242417 = default(int);
						if (MenuScript.pHat == 7)
						{
							_0024bonus_00242417 = 10;
						}
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242428).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242428.t.position });
							((Component)_0024self__00242428).networkView.RPC("AnimD", (RPCMode)2, new object[0]);
						}
						else
						{
							_0024self__00242428.po(_0024self__00242428.t.position);
						}
						if (_0024self__00242428.grounded)
						{
							if (_0024a_00242427 != 0)
							{
								int num = (_0024_0024884_00242421 = 18 + _0024bonus_00242417);
								Vector3 val = (_0024_0024885_00242422 = _0024self__00242428.r.velocity);
								float num2 = (_0024_0024885_00242422.x = _0024_0024884_00242421);
								Vector3 val3 = (_0024self__00242428.r.velocity = _0024_0024885_00242422);
							}
							else
							{
								int num3 = (_0024_0024882_00242419 = -18 - _0024bonus_00242417);
								Vector3 val4 = (_0024_0024883_00242420 = _0024self__00242428.r.velocity);
								float num4 = (_0024_0024883_00242420.x = _0024_0024882_00242419);
								Vector3 val6 = (_0024self__00242428.r.velocity = _0024_0024883_00242420);
							}
						}
						else
						{
							if (MenuScript.companion == 4)
							{
								_0024dd_00242418 = (GameObject)Network.Instantiate(Resources.Load("skill/gadget"), ((Component)_0024self__00242428).transform.position, Quaternion.identity, 0);
								_0024dd_00242418.SendMessage("SetHH", (object)GameScript.finalATK);
							}
							if (_0024a_00242427 != 0)
							{
								int num5 = (_0024_0024888_00242425 = 15 + _0024bonus_00242417);
								Vector3 val7 = (_0024_0024889_00242426 = _0024self__00242428.r.velocity);
								float num6 = (_0024_0024889_00242426.x = _0024_0024888_00242425);
								Vector3 val9 = (_0024self__00242428.r.velocity = _0024_0024889_00242426);
							}
							else
							{
								int num7 = (_0024_0024886_00242423 = -15 - _0024bonus_00242417);
								Vector3 val10 = (_0024_0024887_00242424 = _0024self__00242428.r.velocity);
								float num8 = (_0024_0024887_00242424.x = _0024_0024886_00242423);
								Vector3 val12 = (_0024self__00242428.r.velocity = _0024_0024887_00242424);
							}
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242428.t.position, Quaternion.identity);
					goto IL_0385;
				case 2:
					_0024self__00242428.dashing = false;
					goto IL_0385;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0385:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242429;

		internal PlayerControllerN _0024self__00242430;

		public _0024Dash_00242416(int a, PlayerControllerN self_)
		{
			_0024a_00242429 = a;
			_0024self__00242430 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242429, _0024self__00242430);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Jump_00242431 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024890_00242432;

			internal Vector3 _0024_0024891_00242433;

			internal int _0024_0024892_00242434;

			internal Vector3 _0024_0024893_00242435;

			internal PlayerControllerN _0024self__00242436;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242436 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0123: Unknown result type (might be due to invalid IL or missing references)
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_009e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_0137: Unknown result type (might be due to invalid IL or missing references)
				//IL_0141: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242436.djA = true;
					((Component)_0024self__00242436).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP", typeof(AudioClip)));
					_0024self__00242436.canBoost = true;
					_0024self__00242436.grounded = false;
					_0024self__00242436.mode = 2;
					if (!GameScript.isFloating)
					{
						int num = (_0024_0024892_00242434 = 25);
						Vector3 val = (_0024_0024893_00242435 = _0024self__00242436.r.velocity);
						float num2 = (_0024_0024893_00242435.y = _0024_0024892_00242434);
						Vector3 val3 = (_0024self__00242436.r.velocity = _0024_0024893_00242435);
					}
					else
					{
						int num3 = (_0024_0024890_00242432 = 12);
						Vector3 val4 = (_0024_0024891_00242433 = _0024self__00242436.r.velocity);
						float num4 = (_0024_0024891_00242433.y = _0024_0024890_00242432);
						Vector3 val6 = (_0024self__00242436.r.velocity = _0024_0024891_00242433);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.companion != 7)
					{
						_0024self__00242436.canBoost = false;
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

		internal PlayerControllerN _0024self__00242437;

		public _0024Jump_00242431(PlayerControllerN self_)
		{
			_0024self__00242437 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242437);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DoubleJump_00242438 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024bonus_00242439;

			internal int _0024_0024894_00242440;

			internal Vector3 _0024_0024895_00242441;

			internal int _0024_0024896_00242442;

			internal Vector3 _0024_0024897_00242443;

			internal PlayerControllerN _0024self__00242444;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242444 = self_;
			}

			public override bool MoveNext()
			{
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Expected O, but got Unknown
				//IL_0297: Unknown result type (might be due to invalid IL or missing references)
				//IL_029c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_0133: Unknown result type (might be due to invalid IL or missing references)
				//IL_020e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0213: Unknown result type (might be due to invalid IL or missing references)
				//IL_0214: Unknown result type (might be due to invalid IL or missing references)
				//IL_0216: Unknown result type (might be due to invalid IL or missing references)
				//IL_021b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0242: Unknown result type (might be due to invalid IL or missing references)
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_0248: Unknown result type (might be due to invalid IL or missing references)
				//IL_024f: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_0262: Unknown result type (might be due to invalid IL or missing references)
				//IL_026c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					MonoBehaviour.print((object)("composd" + (object)MenuScript.companion));
					if (_0024self__00242444.gameScript.stamina >= 1f || MenuScript.companion == 7)
					{
						_0024self__00242444.djA = false;
						((Component)_0024self__00242444).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00242444.canBoost = false;
						_0024self__00242444.canBoost2 = true;
						if (MenuScript.companion != 7)
						{
							_0024self__00242444.gameScript.Stamina();
						}
						if (MenuScript.pHat != 20 && MenuScript.companion != 7)
						{
							_0024self__00242444.gameScript.stamina = _0024self__00242444.gameScript.stamina - 1f;
						}
						_0024self__00242444.gameScript.LoadSTA();
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242444).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242444.t.position });
						}
						else
						{
							_0024self__00242444.po(_0024self__00242444.t.position);
						}
						_0024self__00242444.canDoubleJump = false;
						_0024bonus_00242439 = default(int);
						if (MenuScript.pHat == 9)
						{
							_0024bonus_00242439 = 24;
						}
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024896_00242442 = 27);
							Vector3 val = (_0024_0024897_00242443 = _0024self__00242444.r.velocity);
							float num2 = (_0024_0024897_00242443.y = _0024_0024896_00242442);
							Vector3 val3 = (_0024self__00242444.r.velocity = _0024_0024897_00242443);
						}
						else
						{
							int num3 = (_0024_0024894_00242440 = 12);
							Vector3 val4 = (_0024_0024895_00242441 = _0024self__00242444.r.velocity);
							float num4 = (_0024_0024895_00242441.y = _0024_0024894_00242440);
							Vector3 val6 = (_0024self__00242444.r.velocity = _0024_0024895_00242441);
						}
						_0024self__00242444.mode = 2;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242444.t.position, Quaternion.identity);
					goto IL_02a7;
				case 2:
					_0024self__00242444.canBoost2 = false;
					goto IL_02a7;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02a7:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242445;

		public _0024DoubleJump_00242438(PlayerControllerN self_)
		{
			_0024self__00242445 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242445);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TripleJump_00242446 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024898_00242447;

			internal Vector3 _0024_0024899_00242448;

			internal int _0024_0024900_00242449;

			internal Vector3 _0024_0024901_00242450;

			internal PlayerControllerN _0024self__00242451;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242451 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_0236: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected O, but got Unknown
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0180: Unknown result type (might be due to invalid IL or missing references)
				//IL_0181: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0206: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!(_0024self__00242451.gameScript.stamina < 1f))
					{
						_0024self__00242451.djA = false;
						((Component)_0024self__00242451).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00242451.canBoost = false;
						_0024self__00242451.canBoost2 = true;
						_0024self__00242451.gameScript.Stamina();
						_0024self__00242451.gameScript.stamina = _0024self__00242451.gameScript.stamina - 1f;
						_0024self__00242451.gameScript.LoadSTA();
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242451).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242451.t.position });
						}
						else
						{
							_0024self__00242451.po(_0024self__00242451.t.position);
						}
						_0024self__00242451.canTripleJump = false;
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024900_00242449 = 26);
							Vector3 val = (_0024_0024901_00242450 = _0024self__00242451.r.velocity);
							float num2 = (_0024_0024901_00242450.y = _0024_0024900_00242449);
							Vector3 val3 = (_0024self__00242451.r.velocity = _0024_0024901_00242450);
						}
						else
						{
							int num3 = (_0024_0024898_00242447 = 12);
							Vector3 val4 = (_0024_0024899_00242448 = _0024self__00242451.r.velocity);
							float num4 = (_0024_0024899_00242448.y = _0024_0024898_00242447);
							Vector3 val6 = (_0024self__00242451.r.velocity = _0024_0024899_00242448);
						}
						_0024self__00242451.mode = 2;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242451.t.position, Quaternion.identity);
					goto IL_0241;
				case 2:
					_0024self__00242451.canBoost2 = false;
					goto IL_0241;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0241:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242452;

		public _0024TripleJump_00242446(PlayerControllerN self_)
		{
			_0024self__00242452 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242452);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Float_00242453 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024902_00242454;

			internal Vector3 _0024_0024903_00242455;

			internal PlayerControllerN _0024self__00242456;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242456 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ca: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242456).networkView.RPC("FloatN", (RPCMode)2, new object[1] { 1 });
						_0024self__00242456.floatCounter++;
						int num = (_0024_0024902_00242454 = 10);
						Vector3 val = (_0024_0024903_00242455 = ((Component)_0024self__00242456).rigidbody.velocity);
						float num2 = (_0024_0024903_00242455.y = _0024_0024902_00242454);
						Vector3 val3 = (((Component)_0024self__00242456).rigidbody.velocity = _0024_0024903_00242455);
						GameScript.isFloating = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
						break;
					}
					goto IL_014a;
				case 2:
					_0024self__00242456.floatCounter--;
					if (_0024self__00242456.floatCounter < 0)
					{
						_0024self__00242456.floatCounter = 0;
					}
					if (_0024self__00242456.floatCounter == 0)
					{
						((Component)_0024self__00242456).networkView.RPC("FloatN", (RPCMode)2, new object[1] { 0 });
						if (MenuScript.companion != 6)
						{
							GameScript.isFloating = false;
						}
					}
					goto IL_014a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_014a:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242457;

		public _0024Float_00242453(PlayerControllerN self_)
		{
			_0024self__00242457 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242457);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024BeginLevel_00242458 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242459;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242459 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (Object.op_Implicit((Object)(object)_0024self__00242459.fade))
					{
						_0024self__00242459.fade.fadeOut();
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					Application.LoadLevel(2);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242460;

		public _0024BeginLevel_00242458(PlayerControllerN self_)
		{
			_0024self__00242460 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242460);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LoadLevel_00242461 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024level_00242462;

			internal bool _0024a_00242463;

			internal PlayerControllerN _0024self__00242464;

			public _0024(int level, bool a, PlayerControllerN self_)
			{
				_0024level_00242462 = level;
				_0024a_00242463 = a;
				_0024self__00242464 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242464.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					GameScript.changingScene = true;
					GameScript.isInstance = _0024a_00242463;
					Application.LoadLevel(_0024level_00242462);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024level_00242465;

		internal bool _0024a_00242466;

		internal PlayerControllerN _0024self__00242467;

		public _0024LoadLevel_00242461(int level, bool a, PlayerControllerN self_)
		{
			_0024level_00242465 = level;
			_0024a_00242466 = a;
			_0024self__00242467 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024level_00242465, _0024a_00242466, _0024self__00242467);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnLevelWasLoaded_00242468 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024nuu_00242469;

			internal int _0024i_00242470;

			internal int _0024_0024904_00242471;

			internal Vector3 _0024_0024905_00242472;

			internal PlayerControllerN _0024self__00242473;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242473 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0471: Unknown result type (might be due to invalid IL or missing references)
				//IL_047b: Expected O, but got Unknown
				//IL_035a: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03be: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					GameScript.playersDead = 0;
					if (Object.op_Implicit((Object)(object)_0024self__00242473.gameScript))
					{
						GameScript.playersDead = 0;
					}
					if (GameScript.HP <= 0)
					{
						downed = false;
						_0024self__00242473.exclamation.SetActive(false);
						GameScript.canTakeDamage = true;
						_0024self__00242473.mode = 0;
						GameScript.curGold = 0;
						if (Object.op_Implicit((Object)(object)_0024self__00242473.gameScript))
						{
							_0024self__00242473.gameScript.RefreshGold();
						}
						((Component)_0024self__00242473).networkView.RPC("SetRevive", (RPCMode)6, new object[0]);
						_0024self__00242473.gameScript.SetRevive();
						PlayerTriggerScript.canTakeDamage = true;
						((Behaviour)_0024self__00242473.trigger).enabled = true;
					}
					if (((Component)_0024self__00242473).networkView.isMine && MenuScript.companion == 6)
					{
						GameScript.isFloating = true;
						((Component)_0024self__00242473).rigidbody.useGravity = false;
					}
					GameScript.readyPlayers = 0;
					_0024self__00242473.changing = false;
					if (MenuScript.pHat == 9)
					{
						_0024self__00242473.waspEye = true;
					}
					if (((Component)_0024self__00242473).networkView.isMine && MenuScript.multiplayer == 1)
					{
						_0024self__00242473.HungerCheck();
					}
					_0024self__00242473.particleRoar.SetActive(false);
					_0024self__00242473.particleFloat.SetActive(false);
					_0024self__00242473.mWeapon.SetActive(false);
					_0024self__00242473.particleClair.SetActive(false);
					_0024self__00242473.shieldObj.SetActive(false);
					_0024self__00242473.particleCharge.SetActive(false);
					_0024self__00242473.particleRage.SetActive(false);
					((Component)_0024self__00242473).networkView.RPC("drumATKN", (RPCMode)6, new object[1] { 0 });
					((Component)_0024self__00242473).networkView.RPC("drumDEXN", (RPCMode)6, new object[1] { 0 });
					((Component)_0024self__00242473).networkView.RPC("drumMAGN", (RPCMode)6, new object[1] { 0 });
					_0024self__00242473.won = false;
					((Component)_0024self__00242473).networkView.RPC("bWN", (RPCMode)2, new object[0]);
					_0024self__00242473.reviveBox.SetActive(false);
					_0024self__00242473.chargeBoost = 0;
					isBoss = false;
					if (Network.isServer)
					{
						_0024nuu_00242469 = GameScript.curBiome;
						if (GameScript.isTown)
						{
							_0024nuu_00242469 = 99;
						}
						((Component)_0024self__00242473).networkView.RPC("SetMusic", (RPCMode)6, new object[1] { _0024nuu_00242469 });
					}
					if (((Component)_0024self__00242473).networkView.isMine)
					{
						if (Network.connections.Length == 0)
						{
							_0024self__00242473.nameObj.SetActive(false);
						}
						_0024self__00242473.attackCube.SetActive(false);
						if (Object.op_Implicit((Object)(object)_0024self__00242473.t))
						{
							_0024self__00242473.t.position = new Vector3(2f, -2f, 0f);
						}
						_0024self__00242473.inDoor = false;
						if (Object.op_Implicit((Object)(object)_0024self__00242473.trigger))
						{
							_0024self__00242473.trigger.canLeave = false;
						}
						int num = (_0024_0024904_00242471 = 0);
						Vector3 val = (_0024_0024905_00242472 = _0024self__00242473.p.transform.position);
						float num2 = (_0024_0024905_00242472.z = _0024_0024904_00242471);
						Vector3 val3 = (_0024self__00242473.p.transform.position = _0024_0024905_00242472);
						_0024i_00242470 = default(int);
						for (_0024i_00242470 = 0; _0024i_00242470 < 3; _0024i_00242470++)
						{
							GameScript.door[_0024i_00242470] = 0;
						}
						GameScript.readyPlayers = 0;
						_0024self__00242473.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						GameScript.cLevel = PlayerPrefs.GetInt("cLevel");
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242473.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242474;

		public _0024OnLevelWasLoaded_00242468(PlayerControllerN self_)
		{
			_0024self__00242474 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242474);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00242475 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242476;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242476 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2.2f)) ? 1 : 0);
					break;
				case 2:
					if (GameScript.playersDead >= Network.connections.Length + 1)
					{
						((Component)_0024self__00242476).networkView.RPC("GameOver", (RPCMode)6, new object[0]);
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

		internal PlayerControllerN _0024self__00242477;

		public _0024Check_00242475(PlayerControllerN self_)
		{
			_0024self__00242477 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242477);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GameOver_00242478 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242479;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242479 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Expected O, but got Unknown
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (Object.op_Implicit((Object)(object)_0024self__00242479.gameScript))
					{
						((MonoBehaviour)_0024self__00242479).StartCoroutine_Auto(_0024self__00242479.gameScript.Die());
						goto IL_0121;
					}
					if (((Component)_0024self__00242479).networkView.isMine)
					{
						_0024self__00242479.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					}
					else
					{
						_0024self__00242479.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						MonoBehaviour.print((object)"gamescript trying ");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					}
					break;
				case 2:
					((MonoBehaviour)_0024self__00242479).StartCoroutine_Auto(_0024self__00242479.gameScript.Die());
					goto IL_0121;
				case 3:
					((MonoBehaviour)_0024self__00242479).StartCoroutine_Auto(_0024self__00242479.gameScript.Die());
					goto IL_0121;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0121:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242480;

		public _0024GameOver_00242478(PlayerControllerN self_)
		{
			_0024self__00242480 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242480);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LevelUp_00242481 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242482;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242482 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242482.levelUpObj.SetActive(true);
					((Component)_0024self__00242482).audio.PlayOneShot(_0024self__00242482.audioLevelUp);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242482.levelUpObj.SetActive(false);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242483;

		public _0024LevelUp_00242481(PlayerControllerN self_)
		{
			_0024self__00242483 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242483);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShieldN_00242484 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242485;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242485 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242485.shieldObj.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					PlayerTriggerScript.ShieldDEF -= 4;
					if (PlayerTriggerScript.ShieldDEF < 0)
					{
						PlayerTriggerScript.ShieldDEF = 0;
					}
					if (PlayerTriggerScript.ShieldDEF == 0)
					{
						_0024self__00242485.shieldObj.SetActive(false);
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

		internal PlayerControllerN _0024self__00242486;

		public _0024ShieldN_00242484(PlayerControllerN self_)
		{
			_0024self__00242486 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242486);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242487 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00242488;

			internal int _0024_0024906_00242489;

			internal Vector3 _0024_0024907_00242490;

			internal int _0024_0024908_00242491;

			internal Vector3 _0024_0024909_00242492;

			internal int _0024_0024910_00242493;

			internal Vector3 _0024_0024911_00242494;

			internal int _0024_0024912_00242495;

			internal Vector3 _0024_0024913_00242496;

			internal bool _0024l_00242497;

			internal PlayerControllerN _0024self__00242498;

			public _0024(bool l, PlayerControllerN self_)
			{
				_0024l_00242497 = l;
				_0024self__00242498 = self_;
			}

			public override bool MoveNext()
			{
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				//IL_0141: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Unknown result type (might be due to invalid IL or missing references)
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_016f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0174: Unknown result type (might be due to invalid IL or missing references)
				//IL_0175: Unknown result type (might be due to invalid IL or missing references)
				//IL_017c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0199: Unknown result type (might be due to invalid IL or missing references)
				//IL_019e: Unknown result type (might be due to invalid IL or missing references)
				//IL_019f: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01da: Unknown result type (might be due to invalid IL or missing references)
				//IL_01df: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e9: Expected O, but got Unknown
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_0101: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_010d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242498.inDoor && ((Component)_0024self__00242498).networkView.isMine)
					{
						_0024i_00242488 = default(int);
						if (_0024l_00242497)
						{
							int num = (_0024_0024906_00242489 = -10);
							Vector3 val = (_0024_0024907_00242490 = _0024self__00242498.r.velocity);
							float num2 = (_0024_0024907_00242490.x = _0024_0024906_00242489);
							Vector3 val3 = (_0024self__00242498.r.velocity = _0024_0024907_00242490);
							int num3 = (_0024_0024908_00242491 = 10);
							Vector3 val4 = (_0024_0024909_00242492 = _0024self__00242498.r.velocity);
							float num4 = (_0024_0024909_00242492.y = _0024_0024908_00242491);
							Vector3 val6 = (_0024self__00242498.r.velocity = _0024_0024909_00242492);
							result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
						}
						else
						{
							int num5 = (_0024_0024910_00242493 = 10);
							Vector3 val7 = (_0024_0024911_00242494 = _0024self__00242498.r.velocity);
							float num6 = (_0024_0024911_00242494.x = _0024_0024910_00242493);
							Vector3 val9 = (_0024self__00242498.r.velocity = _0024_0024911_00242494);
							int num7 = (_0024_0024912_00242495 = 10);
							Vector3 val10 = (_0024_0024913_00242496 = _0024self__00242498.r.velocity);
							float num8 = (_0024_0024913_00242496.y = _0024_0024912_00242495);
							Vector3 val12 = (_0024self__00242498.r.velocity = _0024_0024913_00242496);
							result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(3, new WaitForEndOfFrame()) ? 1 : 0);
						}
						break;
					}
					goto case 2;
				case 2:
				case 3:
					((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00242499;

		internal PlayerControllerN _0024self__00242500;

		public _0024K_00242487(bool l, PlayerControllerN self_)
		{
			_0024l_00242499 = l;
			_0024self__00242500 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return (IEnumerator<WaitForEndOfFrame>)(object)new _0024(_0024l_00242499, _0024self__00242500);
		}
	}

	public TextMesh[] txtTitle;

	public GameObject cat;

	public GameObject vikingAxe;

	public GameObject shard;

	public GameObject shard1;

	public GameObject shard2;

	public GameObject shard3;

	public GameObject drumAtkObj;

	public GameObject drumDexObj;

	public GameObject drumMagObj;

	private bool changing;

	public GameObject particleRoar;

	public GameObject particleFloat;

	private int floatCounter;

	public GameObject nameObj;

	[NonSerialized]
	public static int mBonus;

	public GameObject mWeapon;

	public GameObject particleClair;

	public GameObject shieldObj;

	private int chargeBoost;

	public GameObject particleCharge;

	public GameObject particleRage;

	[NonSerialized]
	public static bool isBoss;

	public AudioClip themeCave;

	public AudioClip themeTown;

	[NonSerialized]
	public static int helm;

	[NonSerialized]
	public static int armor;

	[NonSerialized]
	public static int offhand;

	public AudioClip audioLevelUp;

	public GameObject attackCube;

	public GameObject levelUpObj;

	public GameObject @base;

	public GameObject p;

	public GameObject head;

	public GameObject head2;

	public GameObject body;

	public GameObject body2;

	public GameObject arm1;

	public GameObject arm2;

	public GameObject leg;

	public GameObject weapon;

	public GameObject offHand;

	public TextMesh[] txtName;

	public GameObject pop;

	public GameObject bar;

	public GameObject ghost;

	public GameObject buttonW;

	public GameObject reviveBox;

	private int race;

	public GameObject exclamation;

	public TextMesh txtTick;

	private bool offledge;

	private int mask;

	private bool leaving;

	private bool moving;

	private Transform t;

	private int cc;

	private GameScript gameScript;

	private PlayerTriggerScript trigger;

	private bool canMove;

	private bool dead;

	private Ray ray;

	private RaycastHit hit;

	private int mode;

	private bool grounded;

	private Rigidbody r;

	private bool canDoubleJump;

	[NonSerialized]
	public static bool downed;

	private bool dashing;

	private bool canBoost;

	private bool canBoost2;

	private int curDoorLocal;

	[NonSerialized]
	public static GameObject lObj;

	[NonSerialized]
	public static GameObject aCube;

	private bool inDoor;

	private bool canHelp;

	private GameObject downedAlly;

	private bool helping;

	private bool reviving;

	private bool immobilized;

	private FadeInOut fade;

	private bool jA;

	private bool djA;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private bool cantLeft;

	private bool cantRight;

	private GameObject companion;

	private bool slidingL;

	private bool slidingR;

	private bool won;

	private bool canTripleJump;

	private bool waspEye;

	private int shardCount;

	public PlayerControllerN()
	{
		txtTitle = (TextMesh[])(object)new TextMesh[2];
		txtName = (TextMesh[])(object)new TextMesh[2];
		mask = 2048;
	}

	public static GameObject GetLevelUp()
	{
		return lObj;
	}

	public override void V()
	{
		((Component)this).networkView.RPC("VN", (RPCMode)2, new object[0]);
	}

	[RPC]
	public override void VN(int m)
	{
		if (m == 1)
		{
			vikingAxe.SetActive(true);
		}
		else
		{
			vikingAxe.SetActive(false);
		}
	}

	public override void Cat(int a)
	{
		if (a == 0)
		{
			((Component)this).networkView.RPC("CatN", (RPCMode)6, new object[1] { 0 });
		}
		else
		{
			((Component)this).networkView.RPC("CatN", (RPCMode)6, new object[1] { 1 });
		}
	}

	[RPC]
	public override void CatN(int a)
	{
		if (a == 0)
		{
			cat.SetActive(false);
			@base.SetActive(true);
			cat.animation.Play();
			return;
		}
		cat.SetActive(true);
		@base.SetActive(false);
		if (mode == 99)
		{
			@base.animation.Play("dead");
		}
		else
		{
			@base.animation.Play("i");
		}
	}

	[RPC]
	public override void iceShardN(int dmg, int m)
	{
		if (m == 1)
		{
			shard.SetActive(true);
		}
		else
		{
			shard.SetActive(false);
		}
	}

	public override IEnumerator iceShard(int mag)
	{
		return new _0024iceShard_00242358(mag, this).GetEnumerator();
	}

	[RPC]
	public override void Rage(int a)
	{
		if (a == 1)
		{
			particleRage.SetActive(true);
		}
		else
		{
			particleRage.SetActive(false);
		}
	}

	[RPC]
	public override void Clair(int a)
	{
		if (a == 1)
		{
			particleClair.SetActive(true);
		}
		else
		{
			particleClair.SetActive(false);
		}
	}

	public static void DisableAttackCube()
	{
	}

	[RPC]
	public override void SetMusic(int a)
	{
		if (Object.op_Implicit((Object)(object)gameScript))
		{
			((Component)gameScript).SendMessage("SetMusic", (object)a);
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242364(this).GetEnumerator();
	}

	public override void HungerCheck()
	{
		if (GameScript.isTown)
		{
			((Component)this).networkView.RPC("hh", (RPCMode)6, new object[1] { 1 });
		}
		else
		{
			((Component)this).networkView.RPC("hh", (RPCMode)6, new object[1] { 0 });
		}
	}

	[RPC]
	public override void hh(int a)
	{
		if (a == 0)
		{
			GameScript.isTown = false;
		}
		else
		{
			GameScript.isTown = true;
		}
	}

	public override void Awake()
	{
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		GameScript.readyPlayers = 0;
		if (MenuScript.pHat == 9)
		{
			waspEye = true;
		}
		GameScript.interacting = false;
		t = ((Component)this).transform;
		if (((Component)this).networkView.isMine)
		{
			if (MenuScript.pHat == 6)
			{
				canTripleJump = true;
			}
			if (MenuScript.companion > 0)
			{
				companion = (GameObject)Network.Instantiate(Resources.Load("comp/c" + (object)MenuScript.companion), t.position, Quaternion.identity, 0);
				companion.SendMessage("Set", (object)((Component)this).gameObject);
			}
		}
		leaving = false;
		Object.DontDestroyOnLoad((Object)(object)this);
		@base.animation["a4"].layer = 2;
		@base.animation["a4"].speed = 2f;
		@base.animation["i"].speed = 2f;
		@base.animation["a1"].layer = 2;
		@base.animation["a2"].layer = 2;
		@base.animation["a3"].layer = 2;
		@base.animation["a2"].speed = 1.5f;
		if (((Component)this).networkView.isMine)
		{
			aCube = attackCube;
			if (Network.isServer)
			{
				GameScript.playersDead = 0;
			}
			inDoor = false;
			lObj = levelUpObj;
			if (((Component)this).networkView.isMine)
			{
				fade = (FadeInOut)(object)((Component)Camera.main).gameObject.GetComponent("FadeInOut");
				aCube = attackCube;
			}
			else
			{
				((Behaviour)(AudioListener)((Component)this).gameObject.GetComponent(typeof(AudioListener))).enabled = false;
			}
			gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
			trigger = (PlayerTriggerScript)(object)p.GetComponent("PlayerTriggerScript");
			GameScript.aSphere = aCube;
			Initialize();
			if (Object.op_Implicit((Object)(object)((Component)this).networkView))
			{
				((Component)this).networkView.RPC("D", (RPCMode)6, new object[0]);
			}
			@base.animation["i"].layer = 1;
			@base.animation["r"].layer = 1;
			@base.animation["j"].layer = 1;
			@base.animation["dj"].layer = 1;
			@base.animation["dead"].layer = 1;
			@base.animation["a1"].layer = 2;
			@base.animation["a2"].layer = 2;
			@base.animation["a3"].layer = 2;
		}
		else
		{
			((Behaviour)(AudioListener)((Component)this).gameObject.GetComponent(typeof(AudioListener))).enabled = false;
			gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
		}
	}

	[RPC]
	public override IEnumerator SetZoneName(string s)
	{
		return new _0024SetZoneName_00242367(s, this).GetEnumerator();
	}

	[RPC]
	public override void drumATKN(int a)
	{
		if (a == 1)
		{
			drumAtkObj.SetActive(true);
		}
		else
		{
			drumAtkObj.SetActive(false);
		}
	}

	public override void drumATK()
	{
		if (((Component)this).networkView.isMine)
		{
			GameScript.drumATK += 10;
			((Component)this).networkView.RPC("drumATKN", (RPCMode)2, new object[1] { 1 });
			((MonoBehaviour)this).StartCoroutine_Auto(DrumATKTick());
		}
	}

	public override IEnumerator DrumATKTick()
	{
		return new _0024DrumATKTick_00242372(this).GetEnumerator();
	}

	[RPC]
	public override void drumDEXN(int a)
	{
		if (a == 1)
		{
			drumDexObj.SetActive(true);
		}
		else
		{
			drumDexObj.SetActive(false);
		}
	}

	public override void drumDEX()
	{
		if (((Component)this).networkView.isMine)
		{
			GameScript.drumDEX += 10;
			((Component)this).networkView.RPC("drumDEXN", (RPCMode)2, new object[1] { 1 });
			((MonoBehaviour)this).StartCoroutine_Auto(DrumDEXTick());
		}
	}

	public override IEnumerator DrumDEXTick()
	{
		return new _0024DrumDEXTick_00242375(this).GetEnumerator();
	}

	[RPC]
	public override void drumMAGN(int a)
	{
		if (a == 1)
		{
			drumMagObj.SetActive(true);
		}
		else
		{
			drumMagObj.SetActive(false);
		}
	}

	public override void drumMAG()
	{
		if (((Component)this).networkView.isMine)
		{
			GameScript.drumMAG += 10;
			((Component)this).networkView.RPC("drumMAGN", (RPCMode)2, new object[1] { 1 });
			((MonoBehaviour)this).StartCoroutine_Auto(DrumMAGTick());
		}
	}

	public override IEnumerator DrumMAGTick()
	{
		return new _0024DrumMAGTick_00242378(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator mWeaponsN(int a)
	{
		return new _0024mWeaponsN_00242381(a, this).GetEnumerator();
	}

	public override IEnumerator mWeapons(int a)
	{
		return new _0024mWeapons_00242386(a, this).GetEnumerator();
	}

	[RPC]
	public override void D()
	{
		levelUpObj.SetActive(false);
	}

	public override void Initialize()
	{
		Object.DontDestroyOnLoad((Object)(object)this);
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		GameScript.facingLeft = false;
		@base.animation["i"].layer = 1;
		@base.animation["r"].layer = 1;
		@base.animation["j"].layer = 1;
		@base.animation["a1"].layer = 2;
	}

	[RPC]
	public override void EX()
	{
		exclamation.SetActive(false);
	}

	public override IEnumerator HELP()
	{
		return new _0024HELP_00242391(this).GetEnumerator();
	}

	[RPC]
	public override void Tick(int a)
	{
		if (a == 0)
		{
			txtTick.text = string.Empty;
		}
		else
		{
			txtTick.text = string.Empty + (object)a;
		}
	}

	[RPC]
	public override IEnumerator ChargeN()
	{
		return new _0024ChargeN_00242394(this).GetEnumerator();
	}

	public override IEnumerator Charge()
	{
		return new _0024Charge_00242397(this).GetEnumerator();
	}

	[RPC]
	public override void AddEXP(int a)
	{
		if (!Object.op_Implicit((Object)(object)gameScript))
		{
			MonoBehaviour.print((object)"NO GAMESCRIPT");
		}
		if (Object.op_Implicit((Object)(object)gameScript))
		{
			switch (a)
			{
			case 2:
				gameScript.GainEXP(20);
				GameScript.tempStats[3] = GameScript.tempStats[3] + 20;
				break;
			case 1:
				gameScript.GainEXP(8);
				GameScript.tempStats[3] = GameScript.tempStats[3] + 8;
				break;
			default:
				gameScript.GainEXP(1);
				GameScript.tempStats[3] = GameScript.tempStats[3] + 1;
				break;
			}
		}
	}

	[RPC]
	public override void AddGold()
	{
		if (((Component)this).networkView.isMine)
		{
			GameScript.tempStats[2] = GameScript.tempStats[2] + 1;
			GameScript.curGold++;
			if (MenuScript.pHat == 22)
			{
				GameScript.tempStats[2] = GameScript.tempStats[2] + 1;
				GameScript.curGold++;
			}
			if (Object.op_Implicit((Object)(object)gameScript))
			{
				gameScript.RefreshGold();
			}
		}
	}

	[RPC]
	public override void Roar(int a)
	{
		if (a == 1)
		{
			particleRoar.SetActive(true);
		}
		else
		{
			particleRoar.SetActive(false);
		}
	}

	public override void TimerSet(int a)
	{
		if (MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("SetFinalTime", (RPCMode)2, new object[1] { a });
		}
	}

	[RPC]
	public override void SetFinalTime(int a)
	{
		GameScript.timer = a;
	}

	public override void Update()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		if (GameScript.win && MenuScript.multiplayer == 1 && !won)
		{
			won = true;
			((Component)this).networkView.RPC("GameOver", (RPCMode)6, new object[0]);
		}
		((Ray)(ref r1U)).origin = ((Component)this).transform.position;
		float y = ((Ray)(ref r1U)).origin.y + 0.6f;
		Vector3 origin = ((Ray)(ref r1U)).origin;
		float num = (origin.y = y);
		Vector3 val2 = (((Ray)(ref r1U)).origin = origin);
		((Ray)(ref r1U)).direction = Vector3.left;
		((Ray)(ref r2U)).origin = ((Component)this).transform.position;
		float y2 = ((Ray)(ref r2U)).origin.y + 0.6f;
		Vector3 origin2 = ((Ray)(ref r2U)).origin;
		float num2 = (origin2.y = y2);
		Vector3 val4 = (((Ray)(ref r2U)).origin = origin2);
		((Ray)(ref r2U)).direction = Vector3.right;
		((Ray)(ref r1D)).origin = ((Component)this).transform.position;
		float y3 = ((Ray)(ref r1D)).origin.y - 0.7f;
		Vector3 origin3 = ((Ray)(ref r1D)).origin;
		float num3 = (origin3.y = y3);
		Vector3 val6 = (((Ray)(ref r1D)).origin = origin3);
		((Ray)(ref r1D)).direction = Vector3.left;
		((Ray)(ref r2D)).origin = ((Component)this).transform.position;
		float y4 = ((Ray)(ref r2D)).origin.y - 0.7f;
		Vector3 origin4 = ((Ray)(ref r2D)).origin;
		float num4 = (origin4.y = y4);
		Vector3 val8 = (((Ray)(ref r2D)).origin = origin4);
		((Ray)(ref r2D)).direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.2f, mask) || Physics.Raycast(r1D, 1.2f, mask))
		{
			cantLeft = true;
			slidingL = true;
		}
		else
		{
			slidingL = false;
			cantLeft = false;
		}
		if (Physics.Raycast(r2U, 1.2f, mask) || Physics.Raycast(r2D, 1.2f, mask))
		{
			cantRight = true;
		}
		else
		{
			slidingR = false;
			cantRight = false;
		}
		if (!(t.position.y >= -120f))
		{
			t.position = new Vector3(0f, 0f, 0f);
		}
		if (!((Component)this).networkView.isMine || immobilized)
		{
			return;
		}
		if (!downed)
		{
			if (waspEye)
			{
				if (!(r.velocity.y >= -5f))
				{
					int num5 = -5;
					Vector3 velocity = r.velocity;
					float num6 = (velocity.y = num5);
					Vector3 val10 = (r.velocity = velocity);
				}
			}
			else if (!(r.velocity.y >= -25f))
			{
				int num7 = -25;
				Vector3 velocity2 = r.velocity;
				float num8 = (velocity2.y = num7);
				Vector3 val12 = (r.velocity = velocity2);
			}
			if (!(Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= t.position.x))
			{
				if (GameScript.facingLeft && !inDoor)
				{
					GameScript.facingLeft = false;
					p.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
				}
			}
			else if (!GameScript.facingLeft && !inDoor)
			{
				GameScript.facingLeft = true;
				p.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			ray = new Ray(t.position, new Vector3(0f, -1f, 0f));
			if (Physics.Raycast(ray, ref hit, 1f, mask))
			{
				if (((Component)((RaycastHit)(ref hit)).transform).gameObject.layer == 11)
				{
					grounded = true;
					mode = 0;
					canDoubleJump = true;
					if (MenuScript.pHat == 6)
					{
						canTripleJump = true;
					}
				}
				else
				{
					mode = 2;
					((MonoBehaviour)this).StartCoroutine_Auto(Offledge());
				}
			}
			else
			{
				mode = 2;
				((MonoBehaviour)this).StartCoroutine_Auto(Offledge());
			}
			if (Input.GetButton("Left") && !inDoor && !dashing)
			{
				if (grounded)
				{
					mode = 1;
				}
				else
				{
					mode = 2;
				}
				if (!cantLeft)
				{
					float x = 0f - GameScript.SPD - (float)chargeBoost;
					Vector3 velocity3 = r.velocity;
					float num9 = (velocity3.x = x);
					Vector3 val14 = (r.velocity = velocity3);
				}
			}
			if (!Input.GetButtonDown("Left") || inDoor || !GameScript.attacking)
			{
			}
			if (!Input.GetButtonDown("Right") || inDoor || !GameScript.attacking)
			{
			}
			if (Input.GetButtonDown("Down") && GameScript.isFloating)
			{
				int num10 = -10;
				Vector3 velocity4 = r.velocity;
				float num11 = (velocity4.y = num10);
				Vector3 val16 = (r.velocity = velocity4);
			}
			if (Input.GetButtonDown("Interact") && GameScript.isFloating)
			{
				int num12 = 10;
				Vector3 velocity5 = r.velocity;
				float num13 = (velocity5.y = num12);
				Vector3 val18 = (r.velocity = velocity5);
			}
			if (Input.GetButtonDown("Dash Left") && !inDoor)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Dash(0));
			}
			else if (Input.GetButtonDown("Dash Right") && !inDoor)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Dash(1));
			}
			if (Input.GetButton("Right") && !inDoor && !dashing)
			{
				if (grounded)
				{
					mode = 1;
				}
				else
				{
					mode = 2;
				}
				if (!cantRight)
				{
					float x2 = GameScript.SPD + (float)chargeBoost;
					Vector3 velocity6 = r.velocity;
					float num14 = (velocity6.x = x2);
					Vector3 val20 = (r.velocity = velocity6);
				}
			}
			if (Input.GetButtonUp("Left") && !inDoor)
			{
				if (grounded)
				{
					mode = 0;
				}
				int num15 = 0;
				Vector3 velocity7 = r.velocity;
				float num16 = (velocity7.x = num15);
				Vector3 val22 = (r.velocity = velocity7);
			}
			else if (Input.GetButtonUp("Right"))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num17 = 0;
				Vector3 velocity8 = r.velocity;
				float num18 = (velocity8.x = num17);
				Vector3 val24 = (r.velocity = velocity8);
			}
			if (Input.GetButtonDown("Jump"))
			{
				if (grounded)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(Jump());
				}
				else if (canDoubleJump || MenuScript.companion == 7)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(DoubleJump());
				}
				else if (canTripleJump)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(TripleJump());
				}
			}
			if (Input.GetButton("Jump") && !dashing)
			{
				if (canBoost)
				{
					float y5 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity9 = r.velocity;
					float num19 = (velocity9.y = y5);
					Vector3 val26 = (r.velocity = velocity9);
				}
				else if (canBoost2)
				{
					float y6 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity10 = r.velocity;
					float num20 = (velocity10.y = y6);
					Vector3 val28 = (r.velocity = velocity10);
				}
			}
			if (Input.GetButtonDown("Interact"))
			{
				if (GameScript.canInteract && !GameScript.interacting)
				{
					gameScript.Interact();
					WW2();
				}
				if (GameScript.isShopping && PlayerTriggerScript.itemPurchasing != 0 && (Object)(object)PlayerTriggerScript.purchasingItem != (Object)null)
				{
					gameScript.Purchase(PlayerTriggerScript.itemPurchasing);
				}
				if (trigger.canFortune)
				{
				}
				if (canHelp && !inDoor)
				{
					if (Object.op_Implicit((Object)(object)downedAlly))
					{
						((Component)this).networkView.RPC("bWN", (RPCMode)2, new object[0]);
						if (Object.op_Implicit((Object)(object)downedAlly))
						{
							downedAlly.SendMessage("HELP");
						}
						((MonoBehaviour)this).StartCoroutine_Auto(HELPSTAY());
					}
					else
					{
						helping = false;
						((Component)this).networkView.RPC("bWN", (RPCMode)2, new object[0]);
					}
				}
				if (trigger.canLeave && !inDoor && !leaving)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(EnterDoor());
				}
				else if (inDoor && !leaving)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(LeaveDoor());
				}
			}
			if (inDoor)
			{
				mode = 4;
				int num21 = 10;
				Vector3 position = p.transform.position;
				float num22 = (position.z = num21);
				Vector3 val30 = (p.transform.position = position);
			}
		}
		if (GameScript.HP <= 0 || GameScript.win)
		{
			mode = 99;
			PlayerTriggerScript.isDead = true;
			PlayerTriggerScript.canTakeDamage = false;
		}
		if (GameScript.attacking)
		{
			return;
		}
		if (mode == 0)
		{
			((Component)this).networkView.RPC("AnimIN", (RPCMode)2, new object[0]);
			jA = false;
		}
		else if (mode == 1)
		{
			((Component)this).networkView.RPC("AnimRN", (RPCMode)2, new object[0]);
			jA = false;
		}
		else if (mode == 2)
		{
			if (!jA)
			{
				((Component)this).networkView.RPC("AnimJumpN", (RPCMode)2, new object[0]);
				jA = true;
			}
			if (!djA)
			{
				((Component)this).networkView.RPC("AnimJump2N", (RPCMode)2, new object[0]);
				djA = true;
			}
		}
		else if (mode == 3)
		{
			@base.animation.Play("a1");
			jA = false;
		}
		else
		{
			jA = false;
		}
	}

	public override IEnumerator Offledge()
	{
		return new _0024Offledge_00242400(this).GetEnumerator();
	}

	public override void DeathAnim()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Network.Instantiate(Resources.Load("deathA"), t.position, Quaternion.identity, 0);
	}

	[RPC]
	public override void AnimJumpN()
	{
		@base.animation.Play("j");
	}

	[RPC]
	public override void AnimJump2N()
	{
		@base.animation.Play("dj");
	}

	[RPC]
	public override void AnimIN()
	{
		@base.animation.Play("i");
	}

	[RPC]
	public override void AnimRN()
	{
		@base.animation.Play("r");
	}

	public override IEnumerator EnterDoor()
	{
		return new _0024EnterDoor_00242403(this).GetEnumerator();
	}

	[RPC]
	public override void PrintState()
	{
		int num = default(int);
		for (num = 0; num < 3; num++)
		{
		}
	}

	public override IEnumerator LeaveDoor()
	{
		return new _0024LeaveDoor_00242407(this).GetEnumerator();
	}

	public override IEnumerator HELPSTAY()
	{
		return new _0024HELPSTAY_00242413(this).GetEnumerator();
	}

	[RPC]
	public override void SDoor(int a)
	{
	}

	[RPC]
	public override void Leaving(int d)
	{
		if (Network.isServer)
		{
			int num = default(int);
			GameScript.changingScene = true;
			GameScript.curBiome = GameScript.doorBiome[d];
			if (GameScript.isTown)
			{
				GameScript.isTown = false;
			}
			else if (GameScript.districtLevel == 21)
			{
				GameScript.isTown = false;
			}
			else
			{
				GameScript.isTown = true;
			}
		}
		Application.LoadLevel(1);
	}

	[RPC]
	public override void NotLeaving(int d)
	{
		if (Network.isServer)
		{
			GameScript.door[d] = GameScript.door[d] - 1;
			GameScript.readyPlayers--;
			PrintState();
		}
	}

	[RPC]
	public override void ChangeScene()
	{
	}

	[RPC]
	public override void AnimD()
	{
		@base.animation.Play("dj");
	}

	[RPC]
	public override void AgainN()
	{
		inDoor = false;
		reviveBox.SetActive(false);
		PlayerTriggerScript.canTakeDamage = true;
		mode = 0;
		downed = false;
		((MonoBehaviour)this).StartCoroutine_Auto(gameScript.AgainN());
	}

	[RPC]
	public override void Restart()
	{
		Application.LoadLevel(1);
	}

	[RPC]
	public override void Again()
	{
		((Component)this).networkView.RPC("AgainN", (RPCMode)6, new object[0]);
	}

	public override IEnumerator Dash(int a)
	{
		return new _0024Dash_00242416(a, this).GetEnumerator();
	}

	[RPC]
	public override void WritePlayer(int a)
	{
		((Component)gameScript).SendMessage("WriteFinal", (object)a);
	}

	public override IEnumerator Jump()
	{
		return new _0024Jump_00242431(this).GetEnumerator();
	}

	public override IEnumerator DoubleJump()
	{
		return new _0024DoubleJump_00242438(this).GetEnumerator();
	}

	public override IEnumerator TripleJump()
	{
		return new _0024TripleJump_00242446(this).GetEnumerator();
	}

	[RPC]
	public override void FloatN(int a)
	{
		if (a == 1)
		{
			particleFloat.SetActive(true);
			((Component)this).rigidbody.useGravity = false;
			return;
		}
		particleFloat.SetActive(false);
		if (MenuScript.companion != 6)
		{
			((Component)this).rigidbody.useGravity = true;
		}
	}

	public override IEnumerator Float()
	{
		return new _0024Float_00242453(this).GetEnumerator();
	}

	[RPC]
	public override void TD(int dmg)
	{
		if (((Component)this).networkView.isMine && !inDoor && !downed && Object.op_Implicit((Object)(object)trigger))
		{
			((MonoBehaviour)this).StartCoroutine_Auto(trigger.TD(dmg));
		}
	}

	public override void OnDestroy()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)companion))
		{
			Network.Destroy(companion.networkView.viewID);
		}
	}

	[RPC]
	public override void RemoveDoor(int d)
	{
		GameScript.door[d] = GameScript.door[d] - 1;
		GameScript.readyPlayers--;
	}

	public override void OnDisconnectedFromServer()
	{
		if (inDoor)
		{
			((Component)this).networkView.RPC("RemoveDoor", (RPCMode)0, new object[1] { GameScript.curDoor });
		}
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}

	public override IEnumerator BeginLevel()
	{
		return new _0024BeginLevel_00242458(this).GetEnumerator();
	}

	[RPC]
	public override void UpdateAppearance(int h, int b, int race, int o, int hat)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		if (h >= 700)
		{
			head2.renderer.material = (Material)Resources.Load("h/h" + (object)h, typeof(Material));
		}
		else
		{
			head.renderer.material = (Material)Resources.Load("r/r" + (object)race + "h" + (object)h, typeof(Material));
			head2.renderer.material = (Material)Resources.Load("hat/hat" + (object)hat, typeof(Material));
		}
		if (b > 0)
		{
			body.renderer.material = (Material)Resources.Load("b/b" + (object)b, typeof(Material));
			arm1.renderer.material = (Material)Resources.Load("a/a" + (object)b, typeof(Material));
			arm2.renderer.material = (Material)Resources.Load("a/a" + (object)b, typeof(Material));
			leg.renderer.material = (Material)Resources.Load("l/l" + (object)b, typeof(Material));
		}
		else
		{
			body.renderer.material = (Material)Resources.Load("r/r" + (object)race + "b", typeof(Material));
			arm1.renderer.material = (Material)Resources.Load("r/r" + (object)race + "a", typeof(Material));
			arm2.renderer.material = (Material)Resources.Load("r/r" + (object)race + "a", typeof(Material));
			leg.renderer.material = (Material)Resources.Load("r/r" + (object)race + "l", typeof(Material));
		}
		offHand.renderer.material = (Material)Resources.Load("o/o" + (object)o, typeof(Material));
	}

	public override void bW(GameObject a)
	{
		if (((Component)this).networkView.isMine)
		{
			downedAlly = a;
			buttonW.SetActive(true);
			canHelp = true;
		}
	}

	public override void WW()
	{
		if (((Component)this).networkView.isMine)
		{
			buttonW.SetActive(true);
		}
	}

	public override void WW2()
	{
		if (((Component)this).networkView.isMine)
		{
			buttonW.SetActive(false);
		}
	}

	[RPC]
	public override void bWN()
	{
		if (((Component)this).networkView.isMine)
		{
			buttonW.SetActive(false);
			canHelp = false;
		}
	}

	[RPC]
	public override void uI(int id)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		weapon.renderer.material = (Material)Resources.Load("iE/i" + (object)id, typeof(Material));
	}

	[RPC]
	public override void AssignTitle(string n)
	{
		txtTitle[0].text = n;
		txtTitle[1].text = n;
	}

	[RPC]
	public override void AssignName(string n)
	{
		txtName[0].text = n;
		txtName[1].text = n;
	}

	[RPC]
	public override void SetBGNetwork(int tBiome)
	{
		gameScript.SetBGNetwork(tBiome);
	}

	[RPC]
	public override void mA(string s)
	{
		mode = 3;
		@base.animation.Stop();
		@base.animation.Play(s);
	}

	[RPC]
	public override void Boss()
	{
		isBoss = true;
	}

	[RPC]
	public override IEnumerator LoadLevel(int level, bool a)
	{
		return new _0024LoadLevel_00242461(level, a, this).GetEnumerator();
	}

	public override void RA()
	{
		gameScript.RefreshActionBar();
	}

	public override void Break()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/break", typeof(AudioClip)));
		gameScript.UpdateCharacterWeapon();
	}

	public override void Write(int a)
	{
		((MonoBehaviour)this).StartCoroutine_Auto(gameScript.Write(a));
	}

	public override IEnumerator OnLevelWasLoaded(int level)
	{
		return new _0024OnLevelWasLoaded_00242468(this).GetEnumerator();
	}

	[RPC]
	public override void SpawnNPC(NetworkViewID id, int pos, int n)
	{
	}

	public override Vector3 GetNPCPos(int a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		return (Vector3)(a switch
		{
			0 => new Vector3(-9f, 3f, 1f), 
			1 => new Vector3(-5f, 3f, 1f), 
			2 => new Vector3(5f, 3f, 1f), 
			3 => new Vector3(9f, 3f, 1f), 
			4 => new Vector3(-9f, -4.5f, 1f), 
			5 => new Vector3(-5f, -4.5f, 1f), 
			6 => new Vector3(0f, -4.5f, 1f), 
			7 => new Vector3(5f, -4.5f, 1f), 
			8 => new Vector3(9f, -4.5f, 1f), 
			_ => val, 
		});
	}

	[RPC]
	public override void po(Vector3 pos)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate((Object)(object)pop, pos, Quaternion.Euler(0f, 180f, 180f));
	}

	[RPC]
	public override void AddDeadPerson()
	{
		if (MenuScript.multiplayer == 1)
		{
			GameScript.playersDead++;
			((MonoBehaviour)this).StartCoroutine_Auto(Check());
		}
	}

	public override IEnumerator Check()
	{
		return new _0024Check_00242475(this).GetEnumerator();
	}

	[RPC]
	public override void RemoveDeadPerson()
	{
		GameScript.playersDead--;
		if (GameScript.playersDead < 0)
		{
			GameScript.playersDead = 0;
		}
	}

	[RPC]
	public override IEnumerator GameOver()
	{
		return new _0024GameOver_00242478(this).GetEnumerator();
	}

	[RPC]
	public override void AnimDead()
	{
		@base.animation.Play("dead");
	}

	[RPC]
	public override void SetDead()
	{
		exclamation.SetActive(true);
		reviveBox.SetActive(true);
	}

	[RPC]
	public override void SetRevive()
	{
		exclamation.SetActive(false);
		reviveBox.SetActive(false);
	}

	[RPC]
	public override void Revive()
	{
		if (((Component)this).networkView.isMine)
		{
			downed = false;
			exclamation.SetActive(false);
			GameScript.canTakeDamage = true;
			mode = 0;
			((Component)this).networkView.RPC("SetRevive", (RPCMode)6, new object[0]);
			gameScript.SetRevive();
			PlayerTriggerScript.canTakeDamage = true;
			((Behaviour)trigger).enabled = true;
			if (Network.isServer)
			{
				RemoveDeadPerson();
				MonoBehaviour.print((object)"isServer");
			}
			else
			{
				MonoBehaviour.print((object)"not server");
				((Component)this).networkView.RPC("RemoveDeadPerson", (RPCMode)0, new object[0]);
			}
		}
	}

	[RPC]
	public override void Die()
	{
		if (!downed)
		{
			downed = true;
			if (((Component)this).networkView.isMine)
			{
				((Component)this).networkView.RPC("SetDead", (RPCMode)6, new object[0]);
				gameScript.SetDead();
				((Behaviour)trigger).enabled = false;
				((Component)this).networkView.RPC("AnimDead", (RPCMode)6, new object[0]);
				mode = 99;
			}
			MonoBehaviour.print((object)"now Downed");
			if (Network.isServer)
			{
				AddDeadPerson();
			}
			else
			{
				((Component)this).networkView.RPC("AddDeadPerson", (RPCMode)6, new object[0]);
			}
		}
	}

	public override void Rev()
	{
		GameScript.HP = 2;
		gameScript.LoadHearts();
		downed = false;
		((Behaviour)trigger).enabled = true;
		((Component)this).collider.enabled = true;
		r.isKinematic = false;
		@base.gameObject.SetActive(true);
		bar.SetActive(false);
		mode = 0;
		ghost.SetActive(false);
	}

	[RPC]
	public override void RevCheck()
	{
		GameScript.playersDead--;
	}

	[RPC]
	public override void Lose()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		t.position = new Vector3(99f, 99f, 99f);
	}

	[RPC]
	public override IEnumerator LevelUp()
	{
		return new _0024LevelUp_00242481(this).GetEnumerator();
	}

	public override void OnPlayerDisconnected(NetworkPlayer player)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		MonoBehaviour.print((object)("Checking! " + (object)MenuScript.multiplayer));
		Network.RemoveRPCs(player);
		Network.DestroyPlayerObjects(player);
		if (MenuScript.multiplayer == 1)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Check());
		}
	}

	[RPC]
	public override IEnumerator ShieldN()
	{
		return new _0024ShieldN_00242484(this).GetEnumerator();
	}

	public override void Shield()
	{
		if (((Component)this).networkView.isMine)
		{
			PlayerTriggerScript.ShieldDEF += 4;
		}
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("ShieldN", (RPCMode)2, new object[0]);
		}
	}

	[RPC]
	public override void AnimRun()
	{
		if (!downed)
		{
			@base.animation.Stop();
			@base.animation.Play("r");
		}
		else
		{
			@base.animation.Play("dead");
		}
	}

	[RPC]
	public override void AnimIdle()
	{
		if (!downed)
		{
			@base.animation.Play("i");
		}
		else
		{
			@base.animation.Play("dead");
		}
	}

	[RPC]
	public override void AnimJump()
	{
		if (!downed)
		{
			@base.animation.Play("j");
		}
		else
		{
			@base.animation.Play("dead");
		}
	}

	[RPC]
	public override void AnimJump2()
	{
		if (!downed)
		{
			@base.animation.Play("dj");
		}
		else
		{
			@base.animation.Play("dead");
		}
	}

	[RPC]
	public override IEnumerator K(bool l)
	{
		return new _0024K_00242487(l, this).GetEnumerator();
	}

	public override void TDp()
	{
		float num = (float)GameScript.MAXHP * 0.2f;
		int dMG = (int)num;
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(trigger.TD(dMG));
		}
	}

	public override void Main()
	{
	}
}
