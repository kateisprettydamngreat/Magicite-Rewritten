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
	internal sealed class _0024iceShard_00242307 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalM_00242308;

			internal int _0024mag_00242309;

			internal PlayerControllerN _0024self__00242310;

			public _0024(int mag, PlayerControllerN self_)
			{
				_0024mag_00242309 = mag;
				_0024self__00242310 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0101: Unknown result type (might be due to invalid IL or missing references)
				//IL_010b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242310).networkView.isMine)
					{
						_0024self__00242310.shard.SetActive(true);
						((Component)_0024self__00242310).networkView.RPC("iceShardN", (RPCMode)2, new object[2] { _0024mag_00242309, 1 });
						_0024finalM_00242308 = (int)((float)_0024mag_00242309 * 0.5f);
						_0024self__00242310.shard1.SendMessage("SetH", (object)_0024finalM_00242308);
						_0024self__00242310.shard2.SendMessage("SetH", (object)_0024finalM_00242308);
						_0024self__00242310.shard3.SendMessage("SetH", (object)_0024finalM_00242308);
						_0024self__00242310.shardCount++;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
						break;
					}
					goto IL_016c;
				case 2:
					_0024self__00242310.shardCount--;
					if (_0024self__00242310.shardCount <= 0)
					{
						((Component)_0024self__00242310).networkView.RPC("iceShardN", (RPCMode)2, new object[2] { _0024mag_00242309, 0 });
					}
					goto IL_016c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_016c:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024mag_00242311;

		internal PlayerControllerN _0024self__00242312;

		public _0024iceShard_00242307(int mag, PlayerControllerN self_)
		{
			_0024mag_00242311 = mag;
			_0024self__00242312 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024mag_00242311, _0024self__00242312);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242313 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242314;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242314 = self_;
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
					if (((Component)_0024self__00242314).networkView.isMine && !downed)
					{
						_0024self__00242314.gameScript.DecreaseHunger();
					}
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242315;

		public _0024Start_00242313(PlayerControllerN self_)
		{
			_0024self__00242315 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242315);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SetZoneName_00242316 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00242317;

			internal PlayerControllerN _0024self__00242318;

			public _0024(string s, PlayerControllerN self_)
			{
				_0024s_00242317 = s;
				_0024self__00242318 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242318.leaving = false;
					if (Object.op_Implicit((Object)(object)_0024self__00242318.gameScript))
					{
						_0024self__00242318.gameScript.txtZone.text = _0024s_00242317;
						_0024self__00242318.gameScript.txtLevelName.text = _0024s_00242317;
						((Component)_0024self__00242318.gameScript.txtLevelName).gameObject.SetActive(true);
					}
					else if (((Component)_0024self__00242318).networkView.isMine)
					{
						_0024self__00242318.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0143;
				case 2:
					if (Object.op_Implicit((Object)(object)_0024self__00242318.gameScript))
					{
						_0024self__00242318.gameScript.txtZone.text = _0024s_00242317;
						_0024self__00242318.gameScript.txtLevelName.text = _0024s_00242317;
						((Component)_0024self__00242318.gameScript.txtLevelName).gameObject.SetActive(true);
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

		internal string _0024s_00242319;

		internal PlayerControllerN _0024self__00242320;

		public _0024SetZoneName_00242316(string s, PlayerControllerN self_)
		{
			_0024s_00242319 = s;
			_0024self__00242320 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024s_00242319, _0024self__00242320);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DrumATKTick_00242321 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242322;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242322 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242322).networkView.isMine)
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
						((Component)_0024self__00242322).networkView.RPC("drumATKN", (RPCMode)6, new object[1] { 0 });
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

		internal PlayerControllerN _0024self__00242323;

		public _0024DrumATKTick_00242321(PlayerControllerN self_)
		{
			_0024self__00242323 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242323);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DrumDEXTick_00242324 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242325;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242325 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242325).networkView.isMine)
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
						((Component)_0024self__00242325).networkView.RPC("drumDEXN", (RPCMode)6, new object[1] { 0 });
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

		internal PlayerControllerN _0024self__00242326;

		public _0024DrumDEXTick_00242324(PlayerControllerN self_)
		{
			_0024self__00242326 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242326);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DrumMAGTick_00242327 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242328;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242328 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242328).networkView.isMine)
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
						((Component)_0024self__00242328).networkView.RPC("drumMAGN", (RPCMode)6, new object[1] { 0 });
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

		internal PlayerControllerN _0024self__00242329;

		public _0024DrumMAGTick_00242327(PlayerControllerN self_)
		{
			_0024self__00242329 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242329);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeaponsN_00242330 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242331;

			internal PlayerControllerN _0024self__00242332;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242331 = a;
				_0024self__00242332 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					mBonus += _0024a_00242331;
					_0024self__00242332.mWeapon.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
					break;
				case 2:
					mBonus -= _0024a_00242331;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00242332.mWeapon.SetActive(false);
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

		internal int _0024a_00242333;

		internal PlayerControllerN _0024self__00242334;

		public _0024mWeaponsN_00242330(int a, PlayerControllerN self_)
		{
			_0024a_00242333 = a;
			_0024self__00242334 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242333, _0024self__00242334);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeapons_00242335 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242336;

			internal PlayerControllerN _0024self__00242337;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242336 = a;
				_0024self__00242337 = self_;
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
						((Component)_0024self__00242337).networkView.RPC("mWeaponsN", (RPCMode)2, new object[1] { _0024a_00242336 });
						goto IL_00c4;
					}
					mBonus += _0024a_00242336;
					_0024self__00242337.mWeapon.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					mBonus -= _0024a_00242336;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00242337.mWeapon.SetActive(false);
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

		internal int _0024a_00242338;

		internal PlayerControllerN _0024self__00242339;

		public _0024mWeapons_00242335(int a, PlayerControllerN self_)
		{
			_0024a_00242338 = a;
			_0024self__00242339 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242338, _0024self__00242339);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HELP_00242340 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242341;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242341 = self_;
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
					if (!_0024self__00242341.reviving)
					{
						((Component)_0024self__00242341).networkView.RPC("EX", (RPCMode)2, new object[0]);
						_0024self__00242341.reviving = true;
						((Component)_0024self__00242341).networkView.RPC("Tick", (RPCMode)2, new object[1] { 3 });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_014c;
				case 2:
					((Component)_0024self__00242341).networkView.RPC("Tick", (RPCMode)2, new object[1] { 2 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00242341).networkView.RPC("Tick", (RPCMode)2, new object[1] { 1 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242341.reviving = false;
					((Component)_0024self__00242341).networkView.RPC("Tick", (RPCMode)2, new object[1] { 0 });
					((Component)_0024self__00242341).networkView.RPC("Revive", (RPCMode)6, new object[0]);
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

		internal PlayerControllerN _0024self__00242342;

		public _0024HELP_00242340(PlayerControllerN self_)
		{
			_0024self__00242342 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242342);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeN_00242343 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242344;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242344 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242344.particleCharge.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242344.chargeBoost -= 4;
					if (_0024self__00242344.chargeBoost < 0)
					{
						_0024self__00242344.chargeBoost = 0;
					}
					if (_0024self__00242344.chargeBoost == 0)
					{
						_0024self__00242344.particleCharge.SetActive(false);
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

		internal PlayerControllerN _0024self__00242345;

		public _0024ChargeN_00242343(PlayerControllerN self_)
		{
			_0024self__00242345 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242345);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Charge_00242346 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242347;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242347 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242347.chargeBoost += 4;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242347).networkView.RPC("ChargeN", (RPCMode)2, new object[0]);
						goto IL_00d6;
					}
					_0024self__00242347.particleCharge.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242347.chargeBoost -= 4;
					if (_0024self__00242347.chargeBoost < 0)
					{
						_0024self__00242347.chargeBoost = 0;
					}
					if (_0024self__00242347.chargeBoost == 0)
					{
						_0024self__00242347.particleCharge.SetActive(false);
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

		internal PlayerControllerN _0024self__00242348;

		public _0024Charge_00242346(PlayerControllerN self_)
		{
			_0024self__00242348 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242348);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Offledge_00242349 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242350;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242350 = self_;
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
					if (!_0024self__00242350.offledge)
					{
						_0024self__00242350.offledge = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						break;
					}
					goto IL_00f9;
				case 2:
					if (Physics.Raycast(_0024self__00242350.ray, ref _0024self__00242350.hit, 1.5f))
					{
						if (((Component)((RaycastHit)(ref _0024self__00242350.hit)).transform).gameObject.layer == 11)
						{
							_0024self__00242350.grounded = true;
							_0024self__00242350.mode = 0;
							_0024self__00242350.canDoubleJump = true;
						}
						else
						{
							_0024self__00242350.mode = 2;
							_0024self__00242350.grounded = false;
						}
					}
					else
					{
						_0024self__00242350.mode = 2;
						_0024self__00242350.grounded = false;
					}
					_0024self__00242350.offledge = false;
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

		internal PlayerControllerN _0024self__00242351;

		public _0024Offledge_00242349(PlayerControllerN self_)
		{
			_0024self__00242351 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242351);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024EnterDoor_00242352 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024cd_00242353;

			internal PlayerControllerN _0024self__00242354;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242354 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242354.leaving = true;
					if (((Component)_0024self__00242354).networkView.isMine && MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							_0024self__00242354.inDoor = true;
							_0024self__00242354.Leaving(GameScript.curDoor);
						}
						else
						{
							_0024self__00242354.inDoor = true;
							_0024cd_00242353 = GameScript.curDoor;
							((Component)_0024self__00242354).networkView.RPC("Leaving", (RPCMode)0, new object[1] { _0024cd_00242353 });
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242354.leaving = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242355;

		public _0024EnterDoor_00242352(PlayerControllerN self_)
		{
			_0024self__00242355 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242355);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LeaveDoor_00242356 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024d_00242357;

			internal int _0024_0024871_00242358;

			internal Vector3 _0024_0024872_00242359;

			internal PlayerControllerN _0024self__00242360;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242360 = self_;
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
					_0024self__00242360.leaving = true;
					_0024self__00242360.inDoor = false;
					_0024self__00242360.trigger.canLeave = true;
					int num = (_0024_0024871_00242358 = 0);
					Vector3 val = (_0024_0024872_00242359 = _0024self__00242360.p.transform.position);
					float num2 = (_0024_0024872_00242359.z = _0024_0024871_00242358);
					Vector3 val3 = (_0024self__00242360.p.transform.position = _0024_0024872_00242359);
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							_0024self__00242360.inDoor = false;
							_0024self__00242360.NotLeaving(GameScript.curDoor);
						}
						else
						{
							_0024self__00242360.inDoor = false;
							((Component)_0024self__00242360).networkView.RPC("NotLeaving", (RPCMode)0, new object[1] { GameScript.curDoor });
						}
					}
					else
					{
						_0024self__00242360.inDoor = false;
						if (((Component)_0024self__00242360).networkView.isMine)
						{
							_0024d_00242357 = GameScript.curDoor;
							((Component)_0024self__00242360).networkView.RPC("NotLeaving", (RPCMode)0, new object[1] { _0024d_00242357 });
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
					_0024self__00242360.leaving = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242361;

		public _0024LeaveDoor_00242356(PlayerControllerN self_)
		{
			_0024self__00242361 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242361);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HELPSTAY_00242362 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242363;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242363 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0057: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242363).networkView.isMine)
					{
						_0024self__00242363.gameScript.immobilized = true;
						_0024self__00242363.immobilized = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
						break;
					}
					goto IL_0079;
				case 2:
					_0024self__00242363.gameScript.immobilized = false;
					_0024self__00242363.immobilized = false;
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

		internal PlayerControllerN _0024self__00242364;

		public _0024HELPSTAY_00242362(PlayerControllerN self_)
		{
			_0024self__00242364 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242364);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Dash_00242365 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024bonus_00242366;

			internal int _0024_0024873_00242367;

			internal Vector3 _0024_0024874_00242368;

			internal int _0024_0024875_00242369;

			internal Vector3 _0024_0024876_00242370;

			internal int _0024_0024877_00242371;

			internal Vector3 _0024_0024878_00242372;

			internal int _0024_0024879_00242373;

			internal Vector3 _0024_0024880_00242374;

			internal int _0024a_00242375;

			internal PlayerControllerN _0024self__00242376;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242375 = a;
				_0024self__00242376 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0320: Unknown result type (might be due to invalid IL or missing references)
				//IL_0325: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02da: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0236: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Unknown result type (might be due to invalid IL or missing references)
				//IL_023c: Unknown result type (might be due to invalid IL or missing references)
				//IL_023e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0243: Unknown result type (might be due to invalid IL or missing references)
				//IL_026a: Unknown result type (might be due to invalid IL or missing references)
				//IL_026f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0270: Unknown result type (might be due to invalid IL or missing references)
				//IL_0277: Unknown result type (might be due to invalid IL or missing references)
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
				//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f5: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!(_0024self__00242376.gameScript.stamina < 1f))
					{
						_0024self__00242376.dashing = true;
						_0024self__00242376.gameScript.Stamina();
						if (MenuScript.pHat != 20)
						{
							_0024self__00242376.gameScript.stamina = _0024self__00242376.gameScript.stamina - 1f;
						}
						_0024self__00242376.gameScript.LoadSTA();
						_0024bonus_00242366 = default(int);
						if (MenuScript.pHat == 7)
						{
							_0024bonus_00242366 = 10;
						}
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242376).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242376.t.position });
							((Component)_0024self__00242376).networkView.RPC("AnimD", (RPCMode)2, new object[0]);
						}
						else
						{
							_0024self__00242376.po(_0024self__00242376.t.position);
						}
						if (_0024self__00242376.grounded)
						{
							if (_0024a_00242375 != 0)
							{
								int num = (_0024_0024875_00242369 = 18 + _0024bonus_00242366);
								Vector3 val = (_0024_0024876_00242370 = _0024self__00242376.r.velocity);
								float num2 = (_0024_0024876_00242370.x = _0024_0024875_00242369);
								Vector3 val3 = (_0024self__00242376.r.velocity = _0024_0024876_00242370);
							}
							else
							{
								int num3 = (_0024_0024873_00242367 = -18 - _0024bonus_00242366);
								Vector3 val4 = (_0024_0024874_00242368 = _0024self__00242376.r.velocity);
								float num4 = (_0024_0024874_00242368.x = _0024_0024873_00242367);
								Vector3 val6 = (_0024self__00242376.r.velocity = _0024_0024874_00242368);
							}
						}
						else if (_0024a_00242375 != 0)
						{
							int num5 = (_0024_0024879_00242373 = 15 + _0024bonus_00242366);
							Vector3 val7 = (_0024_0024880_00242374 = _0024self__00242376.r.velocity);
							float num6 = (_0024_0024880_00242374.x = _0024_0024879_00242373);
							Vector3 val9 = (_0024self__00242376.r.velocity = _0024_0024880_00242374);
						}
						else
						{
							int num7 = (_0024_0024877_00242371 = -15 - _0024bonus_00242366);
							Vector3 val10 = (_0024_0024878_00242372 = _0024self__00242376.r.velocity);
							float num8 = (_0024_0024878_00242372.x = _0024_0024877_00242371);
							Vector3 val12 = (_0024self__00242376.r.velocity = _0024_0024878_00242372);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242376.t.position, Quaternion.identity);
					goto IL_0330;
				case 2:
					_0024self__00242376.dashing = false;
					goto IL_0330;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0330:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242377;

		internal PlayerControllerN _0024self__00242378;

		public _0024Dash_00242365(int a, PlayerControllerN self_)
		{
			_0024a_00242377 = a;
			_0024self__00242378 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242377, _0024self__00242378);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Jump_00242379 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024881_00242380;

			internal Vector3 _0024_0024882_00242381;

			internal int _0024_0024883_00242382;

			internal Vector3 _0024_0024884_00242383;

			internal PlayerControllerN _0024self__00242384;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242384 = self_;
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
					_0024self__00242384.djA = true;
					((Component)_0024self__00242384).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP", typeof(AudioClip)));
					_0024self__00242384.canBoost = true;
					_0024self__00242384.grounded = false;
					_0024self__00242384.mode = 2;
					if (!GameScript.isFloating)
					{
						int num = (_0024_0024883_00242382 = 25);
						Vector3 val = (_0024_0024884_00242383 = _0024self__00242384.r.velocity);
						float num2 = (_0024_0024884_00242383.y = _0024_0024883_00242382);
						Vector3 val3 = (_0024self__00242384.r.velocity = _0024_0024884_00242383);
					}
					else
					{
						int num3 = (_0024_0024881_00242380 = 12);
						Vector3 val4 = (_0024_0024882_00242381 = _0024self__00242384.r.velocity);
						float num4 = (_0024_0024882_00242381.y = _0024_0024881_00242380);
						Vector3 val6 = (_0024self__00242384.r.velocity = _0024_0024882_00242381);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242384.canBoost = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242385;

		public _0024Jump_00242379(PlayerControllerN self_)
		{
			_0024self__00242385 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242385);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DoubleJump_00242386 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024bonus_00242387;

			internal int _0024_0024885_00242388;

			internal Vector3 _0024_0024886_00242389;

			internal int _0024_0024887_00242390;

			internal Vector3 _0024_0024888_00242391;

			internal PlayerControllerN _0024self__00242392;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242392 = self_;
			}

			public override bool MoveNext()
			{
				//IL_025d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0262: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected O, but got Unknown
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01da: Unknown result type (might be due to invalid IL or missing references)
				//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0208: Unknown result type (might be due to invalid IL or missing references)
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_020e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0215: Unknown result type (might be due to invalid IL or missing references)
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_017c: Unknown result type (might be due to invalid IL or missing references)
				//IL_017d: Unknown result type (might be due to invalid IL or missing references)
				//IL_017e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0183: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0228: Unknown result type (might be due to invalid IL or missing references)
				//IL_0232: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!(_0024self__00242392.gameScript.stamina < 1f))
					{
						_0024self__00242392.djA = false;
						((Component)_0024self__00242392).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00242392.canBoost = false;
						_0024self__00242392.canBoost2 = true;
						_0024self__00242392.gameScript.Stamina();
						if (MenuScript.pHat != 20)
						{
							_0024self__00242392.gameScript.stamina = _0024self__00242392.gameScript.stamina - 1f;
						}
						_0024self__00242392.gameScript.LoadSTA();
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242392).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242392.t.position });
						}
						else
						{
							_0024self__00242392.po(_0024self__00242392.t.position);
						}
						_0024self__00242392.canDoubleJump = false;
						_0024bonus_00242387 = default(int);
						if (MenuScript.pHat == 9)
						{
							_0024bonus_00242387 = 24;
						}
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024887_00242390 = 27);
							Vector3 val = (_0024_0024888_00242391 = _0024self__00242392.r.velocity);
							float num2 = (_0024_0024888_00242391.y = _0024_0024887_00242390);
							Vector3 val3 = (_0024self__00242392.r.velocity = _0024_0024888_00242391);
						}
						else
						{
							int num3 = (_0024_0024885_00242388 = 12);
							Vector3 val4 = (_0024_0024886_00242389 = _0024self__00242392.r.velocity);
							float num4 = (_0024_0024886_00242389.y = _0024_0024885_00242388);
							Vector3 val6 = (_0024self__00242392.r.velocity = _0024_0024886_00242389);
						}
						_0024self__00242392.mode = 2;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242392.t.position, Quaternion.identity);
					goto IL_026d;
				case 2:
					_0024self__00242392.canBoost2 = false;
					goto IL_026d;
				case 1:
					{
						result = 0;
						break;
					}
					IL_026d:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242393;

		public _0024DoubleJump_00242386(PlayerControllerN self_)
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
	internal sealed class _0024TripleJump_00242394 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024889_00242395;

			internal Vector3 _0024_0024890_00242396;

			internal int _0024_0024891_00242397;

			internal Vector3 _0024_0024892_00242398;

			internal PlayerControllerN _0024self__00242399;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242399 = self_;
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
					if (!(_0024self__00242399.gameScript.stamina < 1f))
					{
						_0024self__00242399.djA = false;
						((Component)_0024self__00242399).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00242399.canBoost = false;
						_0024self__00242399.canBoost2 = true;
						_0024self__00242399.gameScript.Stamina();
						_0024self__00242399.gameScript.stamina = _0024self__00242399.gameScript.stamina - 1f;
						_0024self__00242399.gameScript.LoadSTA();
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242399).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242399.t.position });
						}
						else
						{
							_0024self__00242399.po(_0024self__00242399.t.position);
						}
						_0024self__00242399.canTripleJump = false;
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024891_00242397 = 26);
							Vector3 val = (_0024_0024892_00242398 = _0024self__00242399.r.velocity);
							float num2 = (_0024_0024892_00242398.y = _0024_0024891_00242397);
							Vector3 val3 = (_0024self__00242399.r.velocity = _0024_0024892_00242398);
						}
						else
						{
							int num3 = (_0024_0024889_00242395 = 12);
							Vector3 val4 = (_0024_0024890_00242396 = _0024self__00242399.r.velocity);
							float num4 = (_0024_0024890_00242396.y = _0024_0024889_00242395);
							Vector3 val6 = (_0024self__00242399.r.velocity = _0024_0024890_00242396);
						}
						_0024self__00242399.mode = 2;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242399.t.position, Quaternion.identity);
					goto IL_0241;
				case 2:
					_0024self__00242399.canBoost2 = false;
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

		internal PlayerControllerN _0024self__00242400;

		public _0024TripleJump_00242394(PlayerControllerN self_)
		{
			_0024self__00242400 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242400);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Float_00242401 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024893_00242402;

			internal Vector3 _0024_0024894_00242403;

			internal PlayerControllerN _0024self__00242404;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242404 = self_;
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
						((Component)_0024self__00242404).networkView.RPC("FloatN", (RPCMode)2, new object[1] { 1 });
						_0024self__00242404.floatCounter++;
						int num = (_0024_0024893_00242402 = 10);
						Vector3 val = (_0024_0024894_00242403 = ((Component)_0024self__00242404).rigidbody.velocity);
						float num2 = (_0024_0024894_00242403.y = _0024_0024893_00242402);
						Vector3 val3 = (((Component)_0024self__00242404).rigidbody.velocity = _0024_0024894_00242403);
						GameScript.isFloating = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
						break;
					}
					goto IL_013f;
				case 2:
					_0024self__00242404.floatCounter--;
					if (_0024self__00242404.floatCounter < 0)
					{
						_0024self__00242404.floatCounter = 0;
					}
					if (_0024self__00242404.floatCounter == 0)
					{
						((Component)_0024self__00242404).networkView.RPC("FloatN", (RPCMode)2, new object[1] { 0 });
						GameScript.isFloating = false;
					}
					goto IL_013f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_013f:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242405;

		public _0024Float_00242401(PlayerControllerN self_)
		{
			_0024self__00242405 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242405);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024BeginLevel_00242406 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242407;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242407 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (Object.op_Implicit((Object)(object)_0024self__00242407.fade))
					{
						_0024self__00242407.fade.fadeOut();
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

		internal PlayerControllerN _0024self__00242408;

		public _0024BeginLevel_00242406(PlayerControllerN self_)
		{
			_0024self__00242408 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242408);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LoadLevel_00242409 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024level_00242410;

			internal bool _0024a_00242411;

			internal PlayerControllerN _0024self__00242412;

			public _0024(int level, bool a, PlayerControllerN self_)
			{
				_0024level_00242410 = level;
				_0024a_00242411 = a;
				_0024self__00242412 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242412.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					GameScript.changingScene = true;
					GameScript.isInstance = _0024a_00242411;
					Application.LoadLevel(_0024level_00242410);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024level_00242413;

		internal bool _0024a_00242414;

		internal PlayerControllerN _0024self__00242415;

		public _0024LoadLevel_00242409(int level, bool a, PlayerControllerN self_)
		{
			_0024level_00242413 = level;
			_0024a_00242414 = a;
			_0024self__00242415 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024level_00242413, _0024a_00242414, _0024self__00242415);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnLevelWasLoaded_00242416 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024nuu_00242417;

			internal int _0024i_00242418;

			internal int _0024_0024895_00242419;

			internal Vector3 _0024_0024896_00242420;

			internal PlayerControllerN _0024self__00242421;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242421 = self_;
			}

			public override bool MoveNext()
			{
				//IL_037f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0389: Expected O, but got Unknown
				//IL_0268: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0301: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					GameScript.readyPlayers = 0;
					_0024self__00242421.changing = false;
					if (MenuScript.pHat == 9)
					{
						_0024self__00242421.waspEye = true;
					}
					MonoBehaviour.print((object)"Level was loaded");
					if (((Component)_0024self__00242421).networkView.isMine)
					{
						MonoBehaviour.print((object)"its mine");
					}
					else
					{
						MonoBehaviour.print((object)"notmine");
					}
					_0024self__00242421.particleRoar.SetActive(false);
					_0024self__00242421.particleFloat.SetActive(false);
					_0024self__00242421.mWeapon.SetActive(false);
					_0024self__00242421.particleClair.SetActive(false);
					_0024self__00242421.shieldObj.SetActive(false);
					_0024self__00242421.particleCharge.SetActive(false);
					_0024self__00242421.particleRage.SetActive(false);
					((Component)_0024self__00242421).networkView.RPC("drumATKN", (RPCMode)6, new object[1] { 0 });
					((Component)_0024self__00242421).networkView.RPC("drumDEXN", (RPCMode)6, new object[1] { 0 });
					((Component)_0024self__00242421).networkView.RPC("drumMAGN", (RPCMode)6, new object[1] { 0 });
					_0024self__00242421.won = false;
					((Component)_0024self__00242421).networkView.RPC("bWN", (RPCMode)2, new object[0]);
					_0024self__00242421.reviveBox.SetActive(false);
					_0024self__00242421.chargeBoost = 0;
					isBoss = false;
					if (Network.isServer)
					{
						_0024nuu_00242417 = GameScript.curBiome;
						if (GameScript.isTown)
						{
							_0024nuu_00242417 = 99;
						}
						((Component)_0024self__00242421).networkView.RPC("SetMusic", (RPCMode)6, new object[1] { _0024nuu_00242417 });
					}
					if (((Component)_0024self__00242421).networkView.isMine)
					{
						if (Network.connections.Length == 0)
						{
							_0024self__00242421.nameObj.SetActive(false);
						}
						_0024self__00242421.attackCube.SetActive(false);
						if (Object.op_Implicit((Object)(object)_0024self__00242421.t))
						{
							_0024self__00242421.t.position = new Vector3(2f, -2f, 0f);
						}
						_0024self__00242421.inDoor = false;
						if (Object.op_Implicit((Object)(object)_0024self__00242421.trigger))
						{
							_0024self__00242421.trigger.canLeave = false;
						}
						int num = (_0024_0024895_00242419 = 0);
						Vector3 val = (_0024_0024896_00242420 = _0024self__00242421.p.transform.position);
						float num2 = (_0024_0024896_00242420.z = _0024_0024895_00242419);
						Vector3 val3 = (_0024self__00242421.p.transform.position = _0024_0024896_00242420);
						_0024i_00242418 = default(int);
						for (_0024i_00242418 = 0; _0024i_00242418 < 3; _0024i_00242418++)
						{
							GameScript.door[_0024i_00242418] = 0;
						}
						GameScript.readyPlayers = 0;
						_0024self__00242421.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						GameScript.cLevel = PlayerPrefs.GetInt("cLevel");
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242421.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242422;

		public _0024OnLevelWasLoaded_00242416(PlayerControllerN self_)
		{
			_0024self__00242422 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242422);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00242423 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242424;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242424 = self_;
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
						((Component)_0024self__00242424).networkView.RPC("GameOver", (RPCMode)2, new object[0]);
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

		internal PlayerControllerN _0024self__00242425;

		public _0024Check_00242423(PlayerControllerN self_)
		{
			_0024self__00242425 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242425);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GameOver_00242426 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242427;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242427 = self_;
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
					if (Object.op_Implicit((Object)(object)_0024self__00242427.gameScript))
					{
						((MonoBehaviour)_0024self__00242427).StartCoroutine_Auto(_0024self__00242427.gameScript.Die());
						goto IL_0121;
					}
					if (((Component)_0024self__00242427).networkView.isMine)
					{
						_0024self__00242427.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					}
					else
					{
						_0024self__00242427.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						MonoBehaviour.print((object)"gamescript trying ");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					}
					break;
				case 2:
					((MonoBehaviour)_0024self__00242427).StartCoroutine_Auto(_0024self__00242427.gameScript.Die());
					goto IL_0121;
				case 3:
					((MonoBehaviour)_0024self__00242427).StartCoroutine_Auto(_0024self__00242427.gameScript.Die());
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

		internal PlayerControllerN _0024self__00242428;

		public _0024GameOver_00242426(PlayerControllerN self_)
		{
			_0024self__00242428 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242428);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LevelUp_00242429 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242430;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242430 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242430.levelUpObj.SetActive(true);
					((Component)_0024self__00242430).audio.PlayOneShot(_0024self__00242430.audioLevelUp);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242430.levelUpObj.SetActive(false);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242431;

		public _0024LevelUp_00242429(PlayerControllerN self_)
		{
			_0024self__00242431 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242431);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShieldN_00242432 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242433;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242433 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242433.shieldObj.SetActive(true);
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
						_0024self__00242433.shieldObj.SetActive(false);
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

		internal PlayerControllerN _0024self__00242434;

		public _0024ShieldN_00242432(PlayerControllerN self_)
		{
			_0024self__00242434 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242434);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242435 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00242436;

			internal int _0024_0024897_00242437;

			internal Vector3 _0024_0024898_00242438;

			internal int _0024_0024899_00242439;

			internal Vector3 _0024_0024900_00242440;

			internal int _0024_0024901_00242441;

			internal Vector3 _0024_0024902_00242442;

			internal int _0024_0024903_00242443;

			internal Vector3 _0024_0024904_00242444;

			internal bool _0024l_00242445;

			internal PlayerControllerN _0024self__00242446;

			public _0024(bool l, PlayerControllerN self_)
			{
				_0024l_00242445 = l;
				_0024self__00242446 = self_;
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
					if (!_0024self__00242446.inDoor && ((Component)_0024self__00242446).networkView.isMine)
					{
						_0024i_00242436 = default(int);
						if (_0024l_00242445)
						{
							int num = (_0024_0024897_00242437 = -10);
							Vector3 val = (_0024_0024898_00242438 = _0024self__00242446.r.velocity);
							float num2 = (_0024_0024898_00242438.x = _0024_0024897_00242437);
							Vector3 val3 = (_0024self__00242446.r.velocity = _0024_0024898_00242438);
							int num3 = (_0024_0024899_00242439 = 10);
							Vector3 val4 = (_0024_0024900_00242440 = _0024self__00242446.r.velocity);
							float num4 = (_0024_0024900_00242440.y = _0024_0024899_00242439);
							Vector3 val6 = (_0024self__00242446.r.velocity = _0024_0024900_00242440);
							result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
						}
						else
						{
							int num5 = (_0024_0024901_00242441 = 10);
							Vector3 val7 = (_0024_0024902_00242442 = _0024self__00242446.r.velocity);
							float num6 = (_0024_0024902_00242442.x = _0024_0024901_00242441);
							Vector3 val9 = (_0024self__00242446.r.velocity = _0024_0024902_00242442);
							int num7 = (_0024_0024903_00242443 = 10);
							Vector3 val10 = (_0024_0024904_00242444 = _0024self__00242446.r.velocity);
							float num8 = (_0024_0024904_00242444.y = _0024_0024903_00242443);
							Vector3 val12 = (_0024self__00242446.r.velocity = _0024_0024904_00242444);
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

		internal bool _0024l_00242447;

		internal PlayerControllerN _0024self__00242448;

		public _0024K_00242435(bool l, PlayerControllerN self_)
		{
			_0024l_00242447 = l;
			_0024self__00242448 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return (IEnumerator<WaitForEndOfFrame>)(object)new _0024(_0024l_00242447, _0024self__00242448);
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
		if (((Component)this).networkView.isMine)
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
		if (((Component)this).networkView.isMine)
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
	}

	public override IEnumerator iceShard(int mag)
	{
		return new _0024iceShard_00242307(mag, this).GetEnumerator();
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
		return new _0024Start_00242313(this).GetEnumerator();
	}

	public override void Awake()
	{
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
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
				companion = (GameObject)Network.Instantiate(Resources.Load("comp/" + (object)MenuScript.companion), t.position, Quaternion.identity, 0);
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
		return new _0024SetZoneName_00242316(s, this).GetEnumerator();
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
		return new _0024DrumATKTick_00242321(this).GetEnumerator();
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
		return new _0024DrumDEXTick_00242324(this).GetEnumerator();
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
		return new _0024DrumMAGTick_00242327(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator mWeaponsN(int a)
	{
		return new _0024mWeaponsN_00242330(a, this).GetEnumerator();
	}

	public override IEnumerator mWeapons(int a)
	{
		return new _0024mWeapons_00242335(a, this).GetEnumerator();
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
		return new _0024HELP_00242340(this).GetEnumerator();
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
		return new _0024ChargeN_00242343(this).GetEnumerator();
	}

	public override IEnumerator Charge()
	{
		return new _0024Charge_00242346(this).GetEnumerator();
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
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
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
			if (Physics.Raycast(ray, ref hit, 1.2f, mask))
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
				else if (canDoubleJump)
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
		return new _0024Offledge_00242349(this).GetEnumerator();
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
		return new _0024EnterDoor_00242352(this).GetEnumerator();
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
		return new _0024LeaveDoor_00242356(this).GetEnumerator();
	}

	public override IEnumerator HELPSTAY()
	{
		return new _0024HELPSTAY_00242362(this).GetEnumerator();
	}

	[RPC]
	public override void Leaving(int d)
	{
		if (!Network.isServer)
		{
			return;
		}
		int num = default(int);
		GameScript.door[d] = GameScript.door[d] + 1;
		GameScript.readyPlayers++;
		PrintState();
		if (Network.connections.Length + 1 > GameScript.readyPlayers)
		{
			return;
		}
		int num2 = default(int);
		for (num2 = 0; num2 < 3; num2++)
		{
			if (GameScript.door[num2] == GameScript.readyPlayers && GameScript.door[num2] == Network.connections.Length + 1)
			{
				GameScript.changingScene = true;
				GameScript.curBiome = GameScript.doorBiome[num2];
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
				((Component)this).networkView.RPC("ChangeScene", (RPCMode)2, new object[0]);
			}
		}
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
		if (!changing)
		{
			changing = true;
			Application.LoadLevel(1);
		}
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
		return new _0024Dash_00242365(a, this).GetEnumerator();
	}

	[RPC]
	public override void WritePlayer(int a)
	{
		((Component)gameScript).SendMessage("WriteFinal", (object)a);
	}

	public override IEnumerator Jump()
	{
		return new _0024Jump_00242379(this).GetEnumerator();
	}

	public override IEnumerator DoubleJump()
	{
		return new _0024DoubleJump_00242386(this).GetEnumerator();
	}

	public override IEnumerator TripleJump()
	{
		return new _0024TripleJump_00242394(this).GetEnumerator();
	}

	[RPC]
	public override void FloatN(int a)
	{
		if (a == 1)
		{
			particleFloat.SetActive(true);
			((Component)this).rigidbody.useGravity = false;
		}
		else
		{
			particleFloat.SetActive(false);
			((Component)this).rigidbody.useGravity = true;
		}
	}

	public override IEnumerator Float()
	{
		return new _0024Float_00242401(this).GetEnumerator();
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
		return new _0024BeginLevel_00242406(this).GetEnumerator();
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
		return new _0024LoadLevel_00242409(level, a, this).GetEnumerator();
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
		return new _0024OnLevelWasLoaded_00242416(this).GetEnumerator();
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
		return new _0024Check_00242423(this).GetEnumerator();
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
		return new _0024GameOver_00242426(this).GetEnumerator();
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
				((Component)this).networkView.RPC("AddDeadPerson", (RPCMode)2, new object[0]);
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
		return new _0024LevelUp_00242429(this).GetEnumerator();
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
		return new _0024ShieldN_00242432(this).GetEnumerator();
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
		return new _0024K_00242435(l, this).GetEnumerator();
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
