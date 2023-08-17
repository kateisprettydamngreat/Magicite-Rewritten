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
	internal sealed class _0024Start_00242075 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242076;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242076 = self_;
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
					if (((Component)_0024self__00242076).networkView.isMine && !downed)
					{
						_0024self__00242076.gameScript.DecreaseHunger();
					}
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242077;

		public _0024Start_00242075(PlayerControllerN self_)
		{
			_0024self__00242077 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242077);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SetZoneName_00242078 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00242079;

			internal PlayerControllerN _0024self__00242080;

			public _0024(string s, PlayerControllerN self_)
			{
				_0024s_00242079 = s;
				_0024self__00242080 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242080.leaving = false;
					if (Object.op_Implicit((Object)(object)_0024self__00242080.gameScript))
					{
						_0024self__00242080.gameScript.txtZone.text = _0024s_00242079;
						_0024self__00242080.gameScript.txtLevelName.text = _0024s_00242079;
						((Component)_0024self__00242080.gameScript.txtLevelName).gameObject.SetActive(true);
					}
					else if (((Component)_0024self__00242080).networkView.isMine)
					{
						_0024self__00242080.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0143;
				case 2:
					if (Object.op_Implicit((Object)(object)_0024self__00242080.gameScript))
					{
						_0024self__00242080.gameScript.txtZone.text = _0024s_00242079;
						_0024self__00242080.gameScript.txtLevelName.text = _0024s_00242079;
						((Component)_0024self__00242080.gameScript.txtLevelName).gameObject.SetActive(true);
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

		internal string _0024s_00242081;

		internal PlayerControllerN _0024self__00242082;

		public _0024SetZoneName_00242078(string s, PlayerControllerN self_)
		{
			_0024s_00242081 = s;
			_0024self__00242082 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024s_00242081, _0024self__00242082);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeaponsN_00242083 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242084;

			internal PlayerControllerN _0024self__00242085;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242084 = a;
				_0024self__00242085 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					mBonus += _0024a_00242084;
					_0024self__00242085.mWeapon.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					mBonus -= _0024a_00242084;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00242085.mWeapon.SetActive(false);
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

		internal int _0024a_00242086;

		internal PlayerControllerN _0024self__00242087;

		public _0024mWeaponsN_00242083(int a, PlayerControllerN self_)
		{
			_0024a_00242086 = a;
			_0024self__00242087 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242086, _0024self__00242087);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeapons_00242088 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242089;

			internal PlayerControllerN _0024self__00242090;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242089 = a;
				_0024self__00242090 = self_;
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
						((Component)_0024self__00242090).networkView.RPC("mWeaponsN", (RPCMode)2, new object[1] { _0024a_00242089 });
						goto IL_00c4;
					}
					mBonus += _0024a_00242089;
					_0024self__00242090.mWeapon.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					mBonus -= _0024a_00242089;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00242090.mWeapon.SetActive(false);
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

		internal int _0024a_00242091;

		internal PlayerControllerN _0024self__00242092;

		public _0024mWeapons_00242088(int a, PlayerControllerN self_)
		{
			_0024a_00242091 = a;
			_0024self__00242092 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242091, _0024self__00242092);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HELP_00242093 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242094;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242094 = self_;
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
					if (!_0024self__00242094.reviving)
					{
						((Component)_0024self__00242094).networkView.RPC("EX", (RPCMode)2, new object[0]);
						_0024self__00242094.reviving = true;
						((Component)_0024self__00242094).networkView.RPC("Tick", (RPCMode)2, new object[1] { 3 });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_014c;
				case 2:
					((Component)_0024self__00242094).networkView.RPC("Tick", (RPCMode)2, new object[1] { 2 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00242094).networkView.RPC("Tick", (RPCMode)2, new object[1] { 1 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242094.reviving = false;
					((Component)_0024self__00242094).networkView.RPC("Tick", (RPCMode)2, new object[1] { 0 });
					((Component)_0024self__00242094).networkView.RPC("Revive", (RPCMode)6, new object[0]);
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

		internal PlayerControllerN _0024self__00242095;

		public _0024HELP_00242093(PlayerControllerN self_)
		{
			_0024self__00242095 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242095);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeN_00242096 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242097;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242097 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242097.particleCharge.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242097.chargeBoost -= 4;
					if (_0024self__00242097.chargeBoost < 0)
					{
						_0024self__00242097.chargeBoost = 0;
					}
					if (_0024self__00242097.chargeBoost == 0)
					{
						_0024self__00242097.particleCharge.SetActive(false);
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

		internal PlayerControllerN _0024self__00242098;

		public _0024ChargeN_00242096(PlayerControllerN self_)
		{
			_0024self__00242098 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242098);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Charge_00242099 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242100;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242100 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242100.chargeBoost += 4;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242100).networkView.RPC("ChargeN", (RPCMode)2, new object[0]);
						goto IL_00d6;
					}
					_0024self__00242100.particleCharge.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242100.chargeBoost -= 4;
					if (_0024self__00242100.chargeBoost < 0)
					{
						_0024self__00242100.chargeBoost = 0;
					}
					if (_0024self__00242100.chargeBoost == 0)
					{
						_0024self__00242100.particleCharge.SetActive(false);
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

		internal PlayerControllerN _0024self__00242101;

		public _0024Charge_00242099(PlayerControllerN self_)
		{
			_0024self__00242101 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242101);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Offledge_00242102 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242103;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242103 = self_;
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
					if (!_0024self__00242103.offledge)
					{
						_0024self__00242103.offledge = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						break;
					}
					goto IL_00f9;
				case 2:
					if (Physics.Raycast(_0024self__00242103.ray, ref _0024self__00242103.hit, 1.5f))
					{
						if (((Component)((RaycastHit)(ref _0024self__00242103.hit)).transform).gameObject.layer == 11)
						{
							_0024self__00242103.grounded = true;
							_0024self__00242103.mode = 0;
							_0024self__00242103.canDoubleJump = true;
						}
						else
						{
							_0024self__00242103.mode = 2;
							_0024self__00242103.grounded = false;
						}
					}
					else
					{
						_0024self__00242103.mode = 2;
						_0024self__00242103.grounded = false;
					}
					_0024self__00242103.offledge = false;
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

		internal PlayerControllerN _0024self__00242104;

		public _0024Offledge_00242102(PlayerControllerN self_)
		{
			_0024self__00242104 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242104);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024EnterDoor_00242105 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024cd_00242106;

			internal PlayerControllerN _0024self__00242107;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242107 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242107.leaving = true;
					if (((Component)_0024self__00242107).networkView.isMine && MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							_0024self__00242107.inDoor = true;
							_0024self__00242107.Leaving(GameScript.curDoor);
						}
						else
						{
							_0024self__00242107.inDoor = true;
							_0024cd_00242106 = GameScript.curDoor;
							((Component)_0024self__00242107).networkView.RPC("Leaving", (RPCMode)0, new object[1] { _0024cd_00242106 });
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242107.leaving = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242108;

		public _0024EnterDoor_00242105(PlayerControllerN self_)
		{
			_0024self__00242108 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242108);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LeaveDoor_00242109 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024d_00242110;

			internal int _0024_0024804_00242111;

			internal Vector3 _0024_0024805_00242112;

			internal PlayerControllerN _0024self__00242113;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242113 = self_;
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
					_0024self__00242113.leaving = true;
					_0024self__00242113.inDoor = false;
					_0024self__00242113.trigger.canLeave = true;
					int num = (_0024_0024804_00242111 = 0);
					Vector3 val = (_0024_0024805_00242112 = _0024self__00242113.p.transform.position);
					float num2 = (_0024_0024805_00242112.z = _0024_0024804_00242111);
					Vector3 val3 = (_0024self__00242113.p.transform.position = _0024_0024805_00242112);
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							_0024self__00242113.inDoor = false;
							_0024self__00242113.NotLeaving(GameScript.curDoor);
						}
						else
						{
							_0024self__00242113.inDoor = false;
							((Component)_0024self__00242113).networkView.RPC("NotLeaving", (RPCMode)0, new object[1] { GameScript.curDoor });
						}
					}
					else
					{
						_0024self__00242113.inDoor = false;
						if (((Component)_0024self__00242113).networkView.isMine)
						{
							_0024d_00242110 = GameScript.curDoor;
							((Component)_0024self__00242113).networkView.RPC("NotLeaving", (RPCMode)0, new object[1] { _0024d_00242110 });
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
					_0024self__00242113.leaving = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242114;

		public _0024LeaveDoor_00242109(PlayerControllerN self_)
		{
			_0024self__00242114 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242114);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HELPSTAY_00242115 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242116;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242116 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0057: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242116).networkView.isMine)
					{
						_0024self__00242116.gameScript.immobilized = true;
						_0024self__00242116.immobilized = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
						break;
					}
					goto IL_0079;
				case 2:
					_0024self__00242116.gameScript.immobilized = false;
					_0024self__00242116.immobilized = false;
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

		internal PlayerControllerN _0024self__00242117;

		public _0024HELPSTAY_00242115(PlayerControllerN self_)
		{
			_0024self__00242117 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242117);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Dash_00242118 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024bonus_00242119;

			internal int _0024_0024806_00242120;

			internal Vector3 _0024_0024807_00242121;

			internal int _0024_0024808_00242122;

			internal Vector3 _0024_0024809_00242123;

			internal int _0024_0024810_00242124;

			internal Vector3 _0024_0024811_00242125;

			internal int _0024_0024812_00242126;

			internal Vector3 _0024_0024813_00242127;

			internal int _0024a_00242128;

			internal PlayerControllerN _0024self__00242129;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242128 = a;
				_0024self__00242129 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0314: Unknown result type (might be due to invalid IL or missing references)
				//IL_0319: Unknown result type (might be due to invalid IL or missing references)
				//IL_010d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0294: Unknown result type (might be due to invalid IL or missing references)
				//IL_0299: Unknown result type (might be due to invalid IL or missing references)
				//IL_029a: Unknown result type (might be due to invalid IL or missing references)
				//IL_029c: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_022a: Unknown result type (might be due to invalid IL or missing references)
				//IL_022f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Unknown result type (might be due to invalid IL or missing references)
				//IL_0232: Unknown result type (might be due to invalid IL or missing references)
				//IL_0237: Unknown result type (might be due to invalid IL or missing references)
				//IL_025e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0263: Unknown result type (might be due to invalid IL or missing references)
				//IL_0264: Unknown result type (might be due to invalid IL or missing references)
				//IL_026b: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0156: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0181: Unknown result type (might be due to invalid IL or missing references)
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_02df: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e9: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!(_0024self__00242129.gameScript.stamina < 1f))
					{
						_0024self__00242129.dashing = true;
						_0024self__00242129.gameScript.Stamina();
						_0024self__00242129.gameScript.stamina = _0024self__00242129.gameScript.stamina - 1f;
						_0024self__00242129.gameScript.LoadSTA();
						_0024bonus_00242119 = default(int);
						if (MenuScript.pHat == 7)
						{
							_0024bonus_00242119 = 10;
						}
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242129).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242129.t.position });
							((Component)_0024self__00242129).networkView.RPC("AnimD", (RPCMode)2, new object[0]);
						}
						else
						{
							_0024self__00242129.po(_0024self__00242129.t.position);
						}
						if (_0024self__00242129.grounded)
						{
							if (_0024a_00242128 != 0)
							{
								int num = (_0024_0024808_00242122 = 18 + _0024bonus_00242119);
								Vector3 val = (_0024_0024809_00242123 = _0024self__00242129.r.velocity);
								float num2 = (_0024_0024809_00242123.x = _0024_0024808_00242122);
								Vector3 val3 = (_0024self__00242129.r.velocity = _0024_0024809_00242123);
							}
							else
							{
								int num3 = (_0024_0024806_00242120 = -18 - _0024bonus_00242119);
								Vector3 val4 = (_0024_0024807_00242121 = _0024self__00242129.r.velocity);
								float num4 = (_0024_0024807_00242121.x = _0024_0024806_00242120);
								Vector3 val6 = (_0024self__00242129.r.velocity = _0024_0024807_00242121);
							}
						}
						else if (_0024a_00242128 != 0)
						{
							int num5 = (_0024_0024812_00242126 = 15 + _0024bonus_00242119);
							Vector3 val7 = (_0024_0024813_00242127 = _0024self__00242129.r.velocity);
							float num6 = (_0024_0024813_00242127.x = _0024_0024812_00242126);
							Vector3 val9 = (_0024self__00242129.r.velocity = _0024_0024813_00242127);
						}
						else
						{
							int num7 = (_0024_0024810_00242124 = -15 - _0024bonus_00242119);
							Vector3 val10 = (_0024_0024811_00242125 = _0024self__00242129.r.velocity);
							float num8 = (_0024_0024811_00242125.x = _0024_0024810_00242124);
							Vector3 val12 = (_0024self__00242129.r.velocity = _0024_0024811_00242125);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242129.t.position, Quaternion.identity);
					goto IL_0324;
				case 2:
					_0024self__00242129.dashing = false;
					goto IL_0324;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0324:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242130;

		internal PlayerControllerN _0024self__00242131;

		public _0024Dash_00242118(int a, PlayerControllerN self_)
		{
			_0024a_00242130 = a;
			_0024self__00242131 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242130, _0024self__00242131);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Jump_00242132 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024814_00242133;

			internal Vector3 _0024_0024815_00242134;

			internal int _0024_0024816_00242135;

			internal Vector3 _0024_0024817_00242136;

			internal PlayerControllerN _0024self__00242137;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242137 = self_;
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
					_0024self__00242137.djA = true;
					((Component)_0024self__00242137).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP", typeof(AudioClip)));
					_0024self__00242137.canBoost = true;
					_0024self__00242137.grounded = false;
					_0024self__00242137.mode = 2;
					if (!GameScript.isFloating)
					{
						int num = (_0024_0024816_00242135 = 25);
						Vector3 val = (_0024_0024817_00242136 = _0024self__00242137.r.velocity);
						float num2 = (_0024_0024817_00242136.y = _0024_0024816_00242135);
						Vector3 val3 = (_0024self__00242137.r.velocity = _0024_0024817_00242136);
					}
					else
					{
						int num3 = (_0024_0024814_00242133 = 12);
						Vector3 val4 = (_0024_0024815_00242134 = _0024self__00242137.r.velocity);
						float num4 = (_0024_0024815_00242134.y = _0024_0024814_00242133);
						Vector3 val6 = (_0024self__00242137.r.velocity = _0024_0024815_00242134);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242137.canBoost = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242138;

		public _0024Jump_00242132(PlayerControllerN self_)
		{
			_0024self__00242138 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242138);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DoubleJump_00242139 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024bonus_00242140;

			internal int _0024_0024818_00242141;

			internal Vector3 _0024_0024819_00242142;

			internal int _0024_0024820_00242143;

			internal Vector3 _0024_0024821_00242144;

			internal PlayerControllerN _0024self__00242145;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242145 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0251: Unknown result type (might be due to invalid IL or missing references)
				//IL_0256: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected O, but got Unknown
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0201: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Unknown result type (might be due to invalid IL or missing references)
				//IL_0209: Unknown result type (might be due to invalid IL or missing references)
				//IL_016b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0170: Unknown result type (might be due to invalid IL or missing references)
				//IL_0171: Unknown result type (might be due to invalid IL or missing references)
				//IL_0172: Unknown result type (might be due to invalid IL or missing references)
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_019b: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_021c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0226: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!(_0024self__00242145.gameScript.stamina < 1f))
					{
						_0024self__00242145.djA = false;
						((Component)_0024self__00242145).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00242145.canBoost = false;
						_0024self__00242145.canBoost2 = true;
						_0024self__00242145.gameScript.Stamina();
						_0024self__00242145.gameScript.stamina = _0024self__00242145.gameScript.stamina - 1f;
						_0024self__00242145.gameScript.LoadSTA();
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242145).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242145.t.position });
						}
						else
						{
							_0024self__00242145.po(_0024self__00242145.t.position);
						}
						_0024self__00242145.canDoubleJump = false;
						_0024bonus_00242140 = default(int);
						if (MenuScript.pHat == 9)
						{
							_0024bonus_00242140 = 24;
						}
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024820_00242143 = 27);
							Vector3 val = (_0024_0024821_00242144 = _0024self__00242145.r.velocity);
							float num2 = (_0024_0024821_00242144.y = _0024_0024820_00242143);
							Vector3 val3 = (_0024self__00242145.r.velocity = _0024_0024821_00242144);
						}
						else
						{
							int num3 = (_0024_0024818_00242141 = 12);
							Vector3 val4 = (_0024_0024819_00242142 = _0024self__00242145.r.velocity);
							float num4 = (_0024_0024819_00242142.y = _0024_0024818_00242141);
							Vector3 val6 = (_0024self__00242145.r.velocity = _0024_0024819_00242142);
						}
						_0024self__00242145.mode = 2;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242145.t.position, Quaternion.identity);
					goto IL_0261;
				case 2:
					_0024self__00242145.canBoost2 = false;
					goto IL_0261;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0261:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242146;

		public _0024DoubleJump_00242139(PlayerControllerN self_)
		{
			_0024self__00242146 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242146);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TripleJump_00242147 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024822_00242148;

			internal Vector3 _0024_0024823_00242149;

			internal int _0024_0024824_00242150;

			internal Vector3 _0024_0024825_00242151;

			internal PlayerControllerN _0024self__00242152;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242152 = self_;
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
					if (!(_0024self__00242152.gameScript.stamina < 1f))
					{
						_0024self__00242152.djA = false;
						((Component)_0024self__00242152).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00242152.canBoost = false;
						_0024self__00242152.canBoost2 = true;
						_0024self__00242152.gameScript.Stamina();
						_0024self__00242152.gameScript.stamina = _0024self__00242152.gameScript.stamina - 1f;
						_0024self__00242152.gameScript.LoadSTA();
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242152).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242152.t.position });
						}
						else
						{
							_0024self__00242152.po(_0024self__00242152.t.position);
						}
						_0024self__00242152.canTripleJump = false;
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024824_00242150 = 26);
							Vector3 val = (_0024_0024825_00242151 = _0024self__00242152.r.velocity);
							float num2 = (_0024_0024825_00242151.y = _0024_0024824_00242150);
							Vector3 val3 = (_0024self__00242152.r.velocity = _0024_0024825_00242151);
						}
						else
						{
							int num3 = (_0024_0024822_00242148 = 12);
							Vector3 val4 = (_0024_0024823_00242149 = _0024self__00242152.r.velocity);
							float num4 = (_0024_0024823_00242149.y = _0024_0024822_00242148);
							Vector3 val6 = (_0024self__00242152.r.velocity = _0024_0024823_00242149);
						}
						_0024self__00242152.mode = 2;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242152.t.position, Quaternion.identity);
					goto IL_0241;
				case 2:
					_0024self__00242152.canBoost2 = false;
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

		internal PlayerControllerN _0024self__00242153;

		public _0024TripleJump_00242147(PlayerControllerN self_)
		{
			_0024self__00242153 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242153);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Float_00242154 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024826_00242155;

			internal Vector3 _0024_0024827_00242156;

			internal PlayerControllerN _0024self__00242157;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242157 = self_;
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
						((Component)_0024self__00242157).networkView.RPC("FloatN", (RPCMode)2, new object[1] { 1 });
						_0024self__00242157.floatCounter++;
						int num = (_0024_0024826_00242155 = 10);
						Vector3 val = (_0024_0024827_00242156 = ((Component)_0024self__00242157).rigidbody.velocity);
						float num2 = (_0024_0024827_00242156.y = _0024_0024826_00242155);
						Vector3 val3 = (((Component)_0024self__00242157).rigidbody.velocity = _0024_0024827_00242156);
						GameScript.isFloating = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
						break;
					}
					goto IL_013f;
				case 2:
					_0024self__00242157.floatCounter--;
					if (_0024self__00242157.floatCounter < 0)
					{
						_0024self__00242157.floatCounter = 0;
					}
					if (_0024self__00242157.floatCounter == 0)
					{
						((Component)_0024self__00242157).networkView.RPC("FloatN", (RPCMode)2, new object[1] { 0 });
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

		internal PlayerControllerN _0024self__00242158;

		public _0024Float_00242154(PlayerControllerN self_)
		{
			_0024self__00242158 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242158);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024BeginLevel_00242159 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242160;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242160 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (Object.op_Implicit((Object)(object)_0024self__00242160.fade))
					{
						_0024self__00242160.fade.fadeOut();
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

		internal PlayerControllerN _0024self__00242161;

		public _0024BeginLevel_00242159(PlayerControllerN self_)
		{
			_0024self__00242161 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242161);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LoadLevel_00242162 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024level_00242163;

			internal bool _0024a_00242164;

			internal PlayerControllerN _0024self__00242165;

			public _0024(int level, bool a, PlayerControllerN self_)
			{
				_0024level_00242163 = level;
				_0024a_00242164 = a;
				_0024self__00242165 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242165.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					GameScript.changingScene = true;
					GameScript.isInstance = _0024a_00242164;
					Application.LoadLevel(_0024level_00242163);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024level_00242166;

		internal bool _0024a_00242167;

		internal PlayerControllerN _0024self__00242168;

		public _0024LoadLevel_00242162(int level, bool a, PlayerControllerN self_)
		{
			_0024level_00242166 = level;
			_0024a_00242167 = a;
			_0024self__00242168 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024level_00242166, _0024a_00242167, _0024self__00242168);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00242169 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242170;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242170 = self_;
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
						((Component)_0024self__00242170).networkView.RPC("GameOver", (RPCMode)2, new object[0]);
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

		internal PlayerControllerN _0024self__00242171;

		public _0024Check_00242169(PlayerControllerN self_)
		{
			_0024self__00242171 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242171);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GameOver_00242172 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242173;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242173 = self_;
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
					if (Object.op_Implicit((Object)(object)_0024self__00242173.gameScript))
					{
						((MonoBehaviour)_0024self__00242173).StartCoroutine_Auto(_0024self__00242173.gameScript.Die());
						goto IL_0121;
					}
					if (((Component)_0024self__00242173).networkView.isMine)
					{
						_0024self__00242173.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					}
					else
					{
						_0024self__00242173.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
						MonoBehaviour.print((object)"gamescript trying ");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					}
					break;
				case 2:
					((MonoBehaviour)_0024self__00242173).StartCoroutine_Auto(_0024self__00242173.gameScript.Die());
					goto IL_0121;
				case 3:
					((MonoBehaviour)_0024self__00242173).StartCoroutine_Auto(_0024self__00242173.gameScript.Die());
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

		internal PlayerControllerN _0024self__00242174;

		public _0024GameOver_00242172(PlayerControllerN self_)
		{
			_0024self__00242174 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242174);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LevelUp_00242175 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242176;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242176 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242176.levelUpObj.SetActive(true);
					((Component)_0024self__00242176).audio.PlayOneShot(_0024self__00242176.audioLevelUp);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242176.levelUpObj.SetActive(false);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242177;

		public _0024LevelUp_00242175(PlayerControllerN self_)
		{
			_0024self__00242177 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242177);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShieldN_00242178 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242179;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242179 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242179.shieldObj.SetActive(true);
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
						_0024self__00242179.shieldObj.SetActive(false);
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

		internal PlayerControllerN _0024self__00242180;

		public _0024ShieldN_00242178(PlayerControllerN self_)
		{
			_0024self__00242180 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242180);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242181 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00242182;

			internal int _0024_0024830_00242183;

			internal Vector3 _0024_0024831_00242184;

			internal int _0024_0024832_00242185;

			internal Vector3 _0024_0024833_00242186;

			internal int _0024_0024834_00242187;

			internal Vector3 _0024_0024835_00242188;

			internal int _0024_0024836_00242189;

			internal Vector3 _0024_0024837_00242190;

			internal bool _0024l_00242191;

			internal PlayerControllerN _0024self__00242192;

			public _0024(bool l, PlayerControllerN self_)
			{
				_0024l_00242191 = l;
				_0024self__00242192 = self_;
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
					if (!_0024self__00242192.inDoor && ((Component)_0024self__00242192).networkView.isMine)
					{
						_0024i_00242182 = default(int);
						if (_0024l_00242191)
						{
							int num = (_0024_0024830_00242183 = -10);
							Vector3 val = (_0024_0024831_00242184 = _0024self__00242192.r.velocity);
							float num2 = (_0024_0024831_00242184.x = _0024_0024830_00242183);
							Vector3 val3 = (_0024self__00242192.r.velocity = _0024_0024831_00242184);
							int num3 = (_0024_0024832_00242185 = 10);
							Vector3 val4 = (_0024_0024833_00242186 = _0024self__00242192.r.velocity);
							float num4 = (_0024_0024833_00242186.y = _0024_0024832_00242185);
							Vector3 val6 = (_0024self__00242192.r.velocity = _0024_0024833_00242186);
							result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
						}
						else
						{
							int num5 = (_0024_0024834_00242187 = 10);
							Vector3 val7 = (_0024_0024835_00242188 = _0024self__00242192.r.velocity);
							float num6 = (_0024_0024835_00242188.x = _0024_0024834_00242187);
							Vector3 val9 = (_0024self__00242192.r.velocity = _0024_0024835_00242188);
							int num7 = (_0024_0024836_00242189 = 10);
							Vector3 val10 = (_0024_0024837_00242190 = _0024self__00242192.r.velocity);
							float num8 = (_0024_0024837_00242190.y = _0024_0024836_00242189);
							Vector3 val12 = (_0024self__00242192.r.velocity = _0024_0024837_00242190);
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

		internal bool _0024l_00242193;

		internal PlayerControllerN _0024self__00242194;

		public _0024K_00242181(bool l, PlayerControllerN self_)
		{
			_0024l_00242193 = l;
			_0024self__00242194 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return (IEnumerator<WaitForEndOfFrame>)(object)new _0024(_0024l_00242193, _0024self__00242194);
		}
	}

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

	public PlayerControllerN()
	{
		txtName = (TextMesh[])(object)new TextMesh[2];
		mask = 2048;
	}

	public static GameObject GetLevelUp()
	{
		return lObj;
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

	public override IEnumerator Start()
	{
		return new _0024Start_00242075(this).GetEnumerator();
	}

	public override void Awake()
	{
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.pHat == 9)
		{
			waspEye = true;
		}
		GameScript.interacting = false;
		t = ((Component)this).transform;
		if (((Component)this).networkView.isMine && MenuScript.pHat == 6)
		{
			canTripleJump = true;
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
		return new _0024SetZoneName_00242078(s, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator mWeaponsN(int a)
	{
		return new _0024mWeaponsN_00242083(a, this).GetEnumerator();
	}

	public override IEnumerator mWeapons(int a)
	{
		return new _0024mWeapons_00242088(a, this).GetEnumerator();
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
		return new _0024HELP_00242093(this).GetEnumerator();
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
		return new _0024ChargeN_00242096(this).GetEnumerator();
	}

	public override IEnumerator Charge()
	{
		return new _0024Charge_00242099(this).GetEnumerator();
	}

	[RPC]
	public override void AddEXP(int a)
	{
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
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
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
			if (Physics.Raycast(ray, ref hit, 1f))
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
		return new _0024Offledge_00242102(this).GetEnumerator();
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
		return new _0024EnterDoor_00242105(this).GetEnumerator();
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
		return new _0024LeaveDoor_00242109(this).GetEnumerator();
	}

	public override IEnumerator HELPSTAY()
	{
		return new _0024HELPSTAY_00242115(this).GetEnumerator();
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
		if (Network.connections.Length + 1 != GameScript.readyPlayers)
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
		Application.LoadLevel(1);
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
		return new _0024Dash_00242118(a, this).GetEnumerator();
	}

	[RPC]
	public override void WritePlayer(int a)
	{
		((Component)gameScript).SendMessage("WriteFinal", (object)a);
	}

	public override IEnumerator Jump()
	{
		return new _0024Jump_00242132(this).GetEnumerator();
	}

	public override IEnumerator DoubleJump()
	{
		return new _0024DoubleJump_00242139(this).GetEnumerator();
	}

	public override IEnumerator TripleJump()
	{
		return new _0024TripleJump_00242147(this).GetEnumerator();
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
		return new _0024Float_00242154(this).GetEnumerator();
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
		return new _0024BeginLevel_00242159(this).GetEnumerator();
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
		return new _0024LoadLevel_00242162(level, a, this).GetEnumerator();
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

	public override void OnLevelWasLoaded(int level)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.pHat == 9)
		{
			waspEye = true;
		}
		particleRoar.SetActive(false);
		particleFloat.SetActive(false);
		mWeapon.SetActive(false);
		particleClair.SetActive(false);
		shieldObj.SetActive(false);
		particleCharge.SetActive(false);
		particleRage.SetActive(false);
		won = false;
		((Component)this).networkView.RPC("bWN", (RPCMode)2, new object[0]);
		reviveBox.SetActive(false);
		chargeBoost = 0;
		isBoss = false;
		if (((Component)this).networkView.isMine)
		{
			if (Network.connections.Length == 0)
			{
				nameObj.SetActive(false);
			}
			attackCube.SetActive(false);
			if (Object.op_Implicit((Object)(object)t))
			{
				t.position = new Vector3(2f, -2f, 0f);
			}
			inDoor = false;
			if (Object.op_Implicit((Object)(object)trigger))
			{
				trigger.canLeave = false;
			}
			int num = 0;
			Vector3 position = p.transform.position;
			float num2 = (position.z = num);
			Vector3 val2 = (p.transform.position = position);
			int num3 = default(int);
			for (num3 = 0; num3 < 3; num3++)
			{
				GameScript.door[num3] = 0;
			}
			GameScript.readyPlayers = 0;
			gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
			GameScript.cLevel = PlayerPrefs.GetInt("cLevel");
		}
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
		return new _0024Check_00242169(this).GetEnumerator();
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
		return new _0024GameOver_00242172(this).GetEnumerator();
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
		return new _0024LevelUp_00242175(this).GetEnumerator();
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
		return new _0024ShieldN_00242178(this).GetEnumerator();
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
		return new _0024K_00242181(l, this).GetEnumerator();
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
