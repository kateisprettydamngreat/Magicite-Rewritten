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
	internal sealed class _0024iceShard_00242212 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalM_00242213;

			internal int _0024mag_00242214;

			internal PlayerControllerN _0024self__00242215;

			public _0024(int mag, PlayerControllerN self_)
			{
				_0024mag_00242214 = mag;
				_0024self__00242215 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242215.shard.SetActive(value: true);
					if (_0024self__00242215.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242215.shard.SetActive(value: true);
						_0024self__00242215.GetComponent<NetworkView>().RPC("iceShardN", RPCMode.All, _0024mag_00242214, 1);
						_0024finalM_00242213 = (int)((float)_0024mag_00242214 * 0.5f);
						_0024self__00242215.shard1.GetComponent<NetworkView>().RPC("SetHH", RPCMode.All, _0024finalM_00242213);
						_0024self__00242215.shard2.GetComponent<NetworkView>().RPC("SetHH", RPCMode.All, _0024finalM_00242213);
						_0024self__00242215.shard3.GetComponent<NetworkView>().RPC("SetHH", RPCMode.All, _0024finalM_00242213);
						_0024self__00242215.shardCount++;
						result = (Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
						break;
					}
					goto IL_01aa;
				case 2:
					_0024self__00242215.shardCount--;
					if (_0024self__00242215.shardCount <= 0)
					{
						_0024self__00242215.GetComponent<NetworkView>().RPC("iceShardN", RPCMode.All, _0024mag_00242214, 0);
					}
					goto IL_01aa;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01aa:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024mag_00242216;

		internal PlayerControllerN _0024self__00242217;

		public _0024iceShard_00242212(int mag, PlayerControllerN self_)
		{
			_0024mag_00242216 = mag;
			_0024self__00242217 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024mag_00242216, _0024self__00242217);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242218 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242219;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242219 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					leavingLevel = false;
					goto IL_0039;
				case 3:
					if (_0024self__00242219.GetComponent<NetworkView>().isMine && !downed)
					{
						_0024self__00242219.gameScript.DecreaseHunger();
					}
					goto IL_0039;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0039:
					result = (Yield(3, new WaitForSeconds(60f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242220;

		public _0024Start_00242218(PlayerControllerN self_)
		{
			_0024self__00242220 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242220);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SetZoneName_00242221 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00242222;

			internal PlayerControllerN _0024self__00242223;

			public _0024(string s, PlayerControllerN self_)
			{
				_0024s_00242222 = s;
				_0024self__00242223 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242223.leaving = false;
					if ((bool)_0024self__00242223.gameScript)
					{
						_0024self__00242223.gameScript.txtZone.text = _0024s_00242222;
						_0024self__00242223.gameScript.txtLevelName.text = _0024s_00242222;
						_0024self__00242223.gameScript.txtLevelName.gameObject.SetActive(value: true);
					}
					else if (_0024self__00242223.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242223.gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
						result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0143;
				case 2:
					if ((bool)_0024self__00242223.gameScript)
					{
						_0024self__00242223.gameScript.txtZone.text = _0024s_00242222;
						_0024self__00242223.gameScript.txtLevelName.text = _0024s_00242222;
						_0024self__00242223.gameScript.txtLevelName.gameObject.SetActive(value: true);
					}
					goto IL_0143;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0143:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024s_00242224;

		internal PlayerControllerN _0024self__00242225;

		public _0024SetZoneName_00242221(string s, PlayerControllerN self_)
		{
			_0024s_00242224 = s;
			_0024self__00242225 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024s_00242224, _0024self__00242225);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DrumATKTick_00242226 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242227;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242227 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242227.GetComponent<NetworkView>().isMine)
					{
						result = (Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
						break;
					}
					goto IL_0094;
				case 2:
					if (GameScript.drumATK > 10)
					{
						GameScript.drumATK -= 10;
					}
					else
					{
						GameScript.drumATK = 0;
					}
					if (GameScript.drumATK <= 0)
					{
						_0024self__00242227.GetComponent<NetworkView>().RPC("drumATKN", RPCMode.All, 0);
					}
					goto IL_0094;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0094:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242228;

		public _0024DrumATKTick_00242226(PlayerControllerN self_)
		{
			_0024self__00242228 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242228);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DrumDEXTick_00242229 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242230;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242230 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242230.GetComponent<NetworkView>().isMine)
					{
						result = (Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
						break;
					}
					goto IL_0094;
				case 2:
					if (GameScript.drumDEX > 10)
					{
						GameScript.drumDEX -= 10;
					}
					else
					{
						GameScript.drumDEX = 0;
					}
					if (GameScript.drumDEX <= 0)
					{
						_0024self__00242230.GetComponent<NetworkView>().RPC("drumDEXN", RPCMode.All, 0);
					}
					goto IL_0094;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0094:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242231;

		public _0024DrumDEXTick_00242229(PlayerControllerN self_)
		{
			_0024self__00242231 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242231);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DrumMAGTick_00242232 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242233;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242233 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242233.GetComponent<NetworkView>().isMine)
					{
						result = (Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
						break;
					}
					goto IL_0089;
				case 2:
					if (GameScript.drumMAG > 10)
					{
						GameScript.drumMAG -= 10;
					}
					else
					{
						GameScript.drumMAG = 0;
					}
					_0024self__00242233.GetComponent<NetworkView>().RPC("drumMAGN", RPCMode.All, 0);
					goto IL_0089;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0089:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242234;

		public _0024DrumMAGTick_00242232(PlayerControllerN self_)
		{
			_0024self__00242234 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242234);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeaponsN_00242235 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242236;

			internal PlayerControllerN _0024self__00242237;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242236 = a;
				_0024self__00242237 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					mBonus += _0024a_00242236;
					_0024self__00242237.mWeapon.SetActive(value: true);
					result = (Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
					break;
				case 2:
					mBonus -= _0024a_00242236;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00242237.mWeapon.SetActive(value: false);
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242238;

		internal PlayerControllerN _0024self__00242239;

		public _0024mWeaponsN_00242235(int a, PlayerControllerN self_)
		{
			_0024a_00242238 = a;
			_0024self__00242239 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00242238, _0024self__00242239);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HELP_00242240 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242241;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242241 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242241.reviving)
					{
						_0024self__00242241.GetComponent<NetworkView>().RPC("EX", RPCMode.All);
						_0024self__00242241.reviving = true;
						_0024self__00242241.GetComponent<NetworkView>().RPC("Tick", RPCMode.All, 3);
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_014c;
				case 2:
					_0024self__00242241.GetComponent<NetworkView>().RPC("Tick", RPCMode.All, 2);
					result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242241.GetComponent<NetworkView>().RPC("Tick", RPCMode.All, 1);
					result = (Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242241.reviving = false;
					_0024self__00242241.GetComponent<NetworkView>().RPC("Tick", RPCMode.All, 0);
					_0024self__00242241.GetComponent<NetworkView>().RPC("Revive", RPCMode.All);
					goto IL_014c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_014c:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242242;

		public _0024HELP_00242240(PlayerControllerN self_)
		{
			_0024self__00242242 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242242);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeN_00242243 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242244;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242244 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242244.particleCharge.SetActive(value: true);
					result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242244.chargeBoost -= 4;
					if (_0024self__00242244.chargeBoost < 0)
					{
						_0024self__00242244.chargeBoost = 0;
					}
					if (_0024self__00242244.chargeBoost == 0)
					{
						_0024self__00242244.particleCharge.SetActive(value: false);
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242245;

		public _0024ChargeN_00242243(PlayerControllerN self_)
		{
			_0024self__00242245 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242245);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Offledge_00242246 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242247;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242247 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242247.offledge)
					{
						_0024self__00242247.offledge = true;
						result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						break;
					}
					goto IL_00f9;
				case 2:
					if (Physics.Raycast(_0024self__00242247.ray, out _0024self__00242247.hit, 1.5f))
					{
						if (_0024self__00242247.hit.transform.gameObject.layer == 11)
						{
							_0024self__00242247.grounded = true;
							_0024self__00242247.mode = 0;
							_0024self__00242247.canDoubleJump = true;
						}
						else
						{
							_0024self__00242247.mode = 2;
							_0024self__00242247.grounded = false;
						}
					}
					else
					{
						_0024self__00242247.mode = 2;
						_0024self__00242247.grounded = false;
					}
					_0024self__00242247.offledge = false;
					goto IL_00f9;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00f9:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242248;

		public _0024Offledge_00242246(PlayerControllerN self_)
		{
			_0024self__00242248 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242248);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024EnterDoor_00242249 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024cd_00242250;

			internal PlayerControllerN _0024self__00242251;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242251 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242251.leaving = true;
					_0024cd_00242250 = GameScript.curDoor;
					MonoBehaviour.print(_0024cd_00242250 + " CURDOR ");
					_0024self__00242251.inDoor = true;
					_0024self__00242251.GetComponent<NetworkView>().RPC("Leaving", RPCMode.All, _0024cd_00242250);
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242251.leaving = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242252;

		public _0024EnterDoor_00242249(PlayerControllerN self_)
		{
			_0024self__00242252 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242252);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LeaveDoor_00242253 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024811_00242254;

			internal Vector3 _0024_0024812_00242255;

			internal PlayerControllerN _0024self__00242256;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242256 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					_0024self__00242256.leaving = true;
					_0024self__00242256.inDoor = false;
					_0024self__00242256.trigger.canLeave = true;
					int num = (_0024_0024811_00242254 = 0);
					Vector3 vector = (_0024_0024812_00242255 = _0024self__00242256.p.transform.position);
					float num2 = (_0024_0024812_00242255.z = _0024_0024811_00242254);
					Vector3 vector3 = (_0024self__00242256.p.transform.position = _0024_0024812_00242255);
					_0024self__00242256.inDoor = false;
					_0024self__00242256.GetComponent<NetworkView>().RPC("NotLeaving", RPCMode.Server, GameScript.curDoor);
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
					_0024self__00242256.leaving = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242257;

		public _0024LeaveDoor_00242253(PlayerControllerN self_)
		{
			_0024self__00242257 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242257);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HELPSTAY_00242258 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242259;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242259 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242259.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242259.gameScript.immobilized = true;
						_0024self__00242259.immobilized = true;
						result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
						break;
					}
					goto IL_0079;
				case 2:
					_0024self__00242259.gameScript.immobilized = false;
					_0024self__00242259.immobilized = false;
					goto IL_0079;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0079:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242260;

		public _0024HELPSTAY_00242258(PlayerControllerN self_)
		{
			_0024self__00242260 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242260);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Leaving_00242261 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242262;

			internal int _0024i_00242263;

			internal int _0024d_00242264;

			public _0024(int d)
			{
				_0024d_00242264 = d;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!leavingLevel)
					{
						leavingLevel = true;
						Camera.main.gameObject.SendMessage("fadeOut");
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_00bf;
				case 2:
					if (Network.isServer)
					{
						_0024a_00242262 = default(int);
						GameScript.changingScene = true;
						_0024i_00242263 = _0024d_00242264;
						GameScript.curBiome = GameScript.doorBiome[_0024i_00242263];
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
					Application.LoadLevel(2);
					goto IL_00bf;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00bf:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024d_00242265;

		public _0024Leaving_00242261(int d)
		{
			_0024d_00242265 = d;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024d_00242265);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Dash_00242266 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024bonus_00242267;

			internal GameObject _0024dd_00242268;

			internal int _0024_0024813_00242269;

			internal Vector3 _0024_0024814_00242270;

			internal int _0024_0024815_00242271;

			internal Vector3 _0024_0024816_00242272;

			internal int _0024_0024817_00242273;

			internal Vector3 _0024_0024818_00242274;

			internal int _0024_0024819_00242275;

			internal Vector3 _0024_0024820_00242276;

			internal int _0024a_00242277;

			internal PlayerControllerN _0024self__00242278;

			public _0024(int a, PlayerControllerN self_)
			{
				_0024a_00242277 = a;
				_0024self__00242278 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!(_0024self__00242278.gameScript.stamina < 1f))
					{
						_0024self__00242278.dashing = true;
						_0024self__00242278.gameScript.Stamina();
						if (MenuScript.pHat != 20)
						{
							_0024self__00242278.gameScript.stamina = _0024self__00242278.gameScript.stamina - 1f;
						}
						_0024self__00242278.gameScript.LoadSTA();
						_0024bonus_00242267 = default(int);
						if (MenuScript.pHat == 7)
						{
							_0024bonus_00242267 = 10;
						}
						_0024self__00242278.GetComponent<NetworkView>().RPC("po", RPCMode.All, _0024self__00242278.t.position);
						_0024self__00242278.GetComponent<NetworkView>().RPC("AnimD", RPCMode.All);
						if (_0024self__00242278.grounded)
						{
							if (_0024a_00242277 != 0)
							{
								int num = (_0024_0024815_00242271 = 18 + _0024bonus_00242267);
								Vector3 vector = (_0024_0024816_00242272 = _0024self__00242278.r.velocity);
								float num2 = (_0024_0024816_00242272.x = _0024_0024815_00242271);
								Vector3 vector3 = (_0024self__00242278.r.velocity = _0024_0024816_00242272);
							}
							else
							{
								int num3 = (_0024_0024813_00242269 = -18 - _0024bonus_00242267);
								Vector3 vector4 = (_0024_0024814_00242270 = _0024self__00242278.r.velocity);
								float num4 = (_0024_0024814_00242270.x = _0024_0024813_00242269);
								Vector3 vector6 = (_0024self__00242278.r.velocity = _0024_0024814_00242270);
							}
						}
						else
						{
							if (MenuScript.companion == 4)
							{
								_0024dd_00242268 = (GameObject)Network.Instantiate(Resources.Load("skill/gadget"), _0024self__00242278.transform.position, Quaternion.identity, 0);
								_0024dd_00242268.SendMessage("SetHH", GameScript.finalATK);
							}
							if (_0024a_00242277 != 0)
							{
								int num5 = (_0024_0024819_00242275 = 15 + _0024bonus_00242267);
								Vector3 vector7 = (_0024_0024820_00242276 = _0024self__00242278.r.velocity);
								float num6 = (_0024_0024820_00242276.x = _0024_0024819_00242275);
								Vector3 vector9 = (_0024self__00242278.r.velocity = _0024_0024820_00242276);
							}
							else
							{
								int num7 = (_0024_0024817_00242273 = -15 - _0024bonus_00242267);
								Vector3 vector10 = (_0024_0024818_00242274 = _0024self__00242278.r.velocity);
								float num8 = (_0024_0024818_00242274.x = _0024_0024817_00242273);
								Vector3 vector12 = (_0024self__00242278.r.velocity = _0024_0024818_00242274);
							}
						}
						result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					UnityEngine.Object.Instantiate(Resources.Load("noSta"), _0024self__00242278.t.position, Quaternion.identity);
					goto IL_035a;
				case 2:
					_0024self__00242278.dashing = false;
					goto IL_035a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_035a:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242279;

		internal PlayerControllerN _0024self__00242280;

		public _0024Dash_00242266(int a, PlayerControllerN self_)
		{
			_0024a_00242279 = a;
			_0024self__00242280 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00242279, _0024self__00242280);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Jump_00242281 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024821_00242282;

			internal Vector3 _0024_0024822_00242283;

			internal int _0024_0024823_00242284;

			internal Vector3 _0024_0024824_00242285;

			internal PlayerControllerN _0024self__00242286;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242286 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242286.djA = true;
					_0024self__00242286.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/JUMP", typeof(AudioClip)));
					_0024self__00242286.canBoost = true;
					_0024self__00242286.grounded = false;
					_0024self__00242286.mode = 2;
					if (!GameScript.isFloating)
					{
						int num = (_0024_0024823_00242284 = 25);
						Vector3 vector = (_0024_0024824_00242285 = _0024self__00242286.r.velocity);
						float num2 = (_0024_0024824_00242285.y = _0024_0024823_00242284);
						Vector3 vector3 = (_0024self__00242286.r.velocity = _0024_0024824_00242285);
					}
					else
					{
						int num3 = (_0024_0024821_00242282 = 12);
						Vector3 vector4 = (_0024_0024822_00242283 = _0024self__00242286.r.velocity);
						float num4 = (_0024_0024822_00242283.y = _0024_0024821_00242282);
						Vector3 vector6 = (_0024self__00242286.r.velocity = _0024_0024822_00242283);
					}
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.companion != 7)
					{
						_0024self__00242286.canBoost = false;
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242287;

		public _0024Jump_00242281(PlayerControllerN self_)
		{
			_0024self__00242287 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242287);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DoubleJump_00242288 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024bonus_00242289;

			internal int _0024_0024825_00242290;

			internal Vector3 _0024_0024826_00242291;

			internal int _0024_0024827_00242292;

			internal Vector3 _0024_0024828_00242293;

			internal PlayerControllerN _0024self__00242294;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242294 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242294.gameScript.stamina >= 1f || MenuScript.companion == 7)
					{
						_0024self__00242294.djA = false;
						_0024self__00242294.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00242294.canBoost = false;
						_0024self__00242294.canBoost2 = true;
						if (MenuScript.companion != 7)
						{
							_0024self__00242294.gameScript.Stamina();
						}
						if (MenuScript.pHat != 20 && MenuScript.companion != 7)
						{
							_0024self__00242294.gameScript.stamina = _0024self__00242294.gameScript.stamina - 1f;
						}
						_0024self__00242294.gameScript.LoadSTA();
						_0024self__00242294.GetComponent<NetworkView>().RPC("po", RPCMode.All, _0024self__00242294.t.position);
						_0024self__00242294.canDoubleJump = false;
						_0024bonus_00242289 = default(int);
						if (MenuScript.pHat == 9)
						{
							_0024bonus_00242289 = 24;
						}
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024827_00242292 = 27);
							Vector3 vector = (_0024_0024828_00242293 = _0024self__00242294.r.velocity);
							float num2 = (_0024_0024828_00242293.y = _0024_0024827_00242292);
							Vector3 vector3 = (_0024self__00242294.r.velocity = _0024_0024828_00242293);
						}
						else
						{
							int num3 = (_0024_0024825_00242290 = 12);
							Vector3 vector4 = (_0024_0024826_00242291 = _0024self__00242294.r.velocity);
							float num4 = (_0024_0024826_00242291.y = _0024_0024825_00242290);
							Vector3 vector6 = (_0024self__00242294.r.velocity = _0024_0024826_00242291);
						}
						_0024self__00242294.mode = 2;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					UnityEngine.Object.Instantiate(Resources.Load("noSta"), _0024self__00242294.t.position, Quaternion.identity);
					goto IL_0263;
				case 2:
					_0024self__00242294.canBoost2 = false;
					goto IL_0263;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0263:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242295;

		public _0024DoubleJump_00242288(PlayerControllerN self_)
		{
			_0024self__00242295 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242295);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TripleJump_00242296 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024829_00242297;

			internal Vector3 _0024_0024830_00242298;

			internal int _0024_0024831_00242299;

			internal Vector3 _0024_0024832_00242300;

			internal PlayerControllerN _0024self__00242301;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242301 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!(_0024self__00242301.gameScript.stamina < 1f))
					{
						_0024self__00242301.djA = false;
						_0024self__00242301.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00242301.canBoost = false;
						_0024self__00242301.canBoost2 = true;
						_0024self__00242301.gameScript.Stamina();
						_0024self__00242301.gameScript.stamina = _0024self__00242301.gameScript.stamina - 1f;
						_0024self__00242301.gameScript.LoadSTA();
						_0024self__00242301.GetComponent<NetworkView>().RPC("po", RPCMode.All, _0024self__00242301.t.position);
						_0024self__00242301.canTripleJump = false;
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024831_00242299 = 26);
							Vector3 vector = (_0024_0024832_00242300 = _0024self__00242301.r.velocity);
							float num2 = (_0024_0024832_00242300.y = _0024_0024831_00242299);
							Vector3 vector3 = (_0024self__00242301.r.velocity = _0024_0024832_00242300);
						}
						else
						{
							int num3 = (_0024_0024829_00242297 = 12);
							Vector3 vector4 = (_0024_0024830_00242298 = _0024self__00242301.r.velocity);
							float num4 = (_0024_0024830_00242298.y = _0024_0024829_00242297);
							Vector3 vector6 = (_0024self__00242301.r.velocity = _0024_0024830_00242298);
						}
						_0024self__00242301.mode = 2;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					UnityEngine.Object.Instantiate(Resources.Load("noSta"), _0024self__00242301.t.position, Quaternion.identity);
					goto IL_0216;
				case 2:
					_0024self__00242301.canBoost2 = false;
					goto IL_0216;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0216:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242302;

		public _0024TripleJump_00242296(PlayerControllerN self_)
		{
			_0024self__00242302 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242302);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Float_00242303 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024833_00242304;

			internal Vector3 _0024_0024834_00242305;

			internal PlayerControllerN _0024self__00242306;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242306 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					_0024self__00242306.GetComponent<NetworkView>().RPC("FloatN", RPCMode.All, 1);
					_0024self__00242306.floatCounter++;
					int num = (_0024_0024833_00242304 = 10);
					Vector3 vector = (_0024_0024834_00242305 = _0024self__00242306.GetComponent<Rigidbody>().velocity);
					float num2 = (_0024_0024834_00242305.y = _0024_0024833_00242304);
					Vector3 vector3 = (_0024self__00242306.GetComponent<Rigidbody>().velocity = _0024_0024834_00242305);
					GameScript.isFloating = true;
					result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				}
				case 2:
					_0024self__00242306.floatCounter--;
					if (_0024self__00242306.floatCounter < 0)
					{
						_0024self__00242306.floatCounter = 0;
					}
					if (_0024self__00242306.floatCounter == 0)
					{
						_0024self__00242306.GetComponent<NetworkView>().RPC("FloatN", RPCMode.All, 0);
						if (MenuScript.companion != 6)
						{
							GameScript.isFloating = false;
						}
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242307;

		public _0024Float_00242303(PlayerControllerN self_)
		{
			_0024self__00242307 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242307);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024BeginLevel_00242308 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242309;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242309 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if ((bool)_0024self__00242309.fade)
					{
						_0024self__00242309.fade.fadeOut();
					}
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					Application.LoadLevel(2);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242310;

		public _0024BeginLevel_00242308(PlayerControllerN self_)
		{
			_0024self__00242310 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242310);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LoadLevel_00242311 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024level_00242312;

			internal bool _0024a_00242313;

			internal PlayerControllerN _0024self__00242314;

			public _0024(int level, bool a, PlayerControllerN self_)
			{
				_0024level_00242312 = level;
				_0024a_00242313 = a;
				_0024self__00242314 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242314.fade.fadeOut();
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					GameScript.changingScene = true;
					GameScript.isInstance = _0024a_00242313;
					Application.LoadLevel(_0024level_00242312);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024level_00242315;

		internal bool _0024a_00242316;

		internal PlayerControllerN _0024self__00242317;

		public _0024LoadLevel_00242311(int level, bool a, PlayerControllerN self_)
		{
			_0024level_00242315 = level;
			_0024a_00242316 = a;
			_0024self__00242317 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024level_00242315, _0024a_00242316, _0024self__00242317);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnLevelWasLoaded_00242318 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024nuu_00242319;

			internal int _0024i_00242320;

			internal int _0024_0024835_00242321;

			internal Vector3 _0024_0024836_00242322;

			internal PlayerControllerN _0024self__00242323;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242323 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					GameScript.playersDead = 0;
					if ((bool)_0024self__00242323.gameScript)
					{
						GameScript.playersDead = 0;
					}
					if (GameScript.HP <= 0)
					{
						downed = false;
						_0024self__00242323.exclamation.SetActive(value: false);
						GameScript.canTakeDamage = true;
						_0024self__00242323.mode = 0;
						GameScript.curGold = 0;
						if ((bool)_0024self__00242323.gameScript)
						{
							_0024self__00242323.gameScript.RefreshGold();
						}
						_0024self__00242323.GetComponent<NetworkView>().RPC("SetRevive", RPCMode.All);
						_0024self__00242323.gameScript.SetRevive();
						PlayerTriggerScript.canTakeDamage = true;
						_0024self__00242323.trigger.enabled = true;
					}
					if (_0024self__00242323.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242323.musicBox = GameObject.Find("musicBox");
					}
					if (MenuScript.companion == 6 || MenuScript.companion == 9)
					{
						GameScript.isFloating = true;
						_0024self__00242323.GetComponent<Rigidbody>().useGravity = false;
					}
					GameScript.readyPlayers = 0;
					_0024self__00242323.changing = false;
					if (MenuScript.pHat == 9)
					{
						_0024self__00242323.waspEye = true;
					}
					if (Network.isServer)
					{
						_0024self__00242323.HungerCheck();
					}
					_0024self__00242323.particleRoar.SetActive(value: false);
					_0024self__00242323.particleFloat.SetActive(value: false);
					_0024self__00242323.mWeapon.SetActive(value: false);
					_0024self__00242323.particleClair.SetActive(value: false);
					_0024self__00242323.shieldObj.SetActive(value: false);
					_0024self__00242323.particleCharge.SetActive(value: false);
					_0024self__00242323.particleRage.SetActive(value: false);
					_0024self__00242323.GetComponent<NetworkView>().RPC("drumATKN", RPCMode.All, 0);
					_0024self__00242323.GetComponent<NetworkView>().RPC("drumDEXN", RPCMode.All, 0);
					_0024self__00242323.GetComponent<NetworkView>().RPC("drumMAGN", RPCMode.All, 0);
					_0024self__00242323.won = false;
					_0024self__00242323.GetComponent<NetworkView>().RPC("bWN", RPCMode.All);
					_0024self__00242323.reviveBox.GetComponent<BoxCollider>().enabled = false;
					_0024self__00242323.chargeBoost = 0;
					isBoss = false;
					if (Network.isServer)
					{
						_0024nuu_00242319 = GameScript.curBiome;
						if (GameScript.isTown)
						{
							_0024nuu_00242319 = 99;
						}
						_0024self__00242323.GetComponent<NetworkView>().RPC("SetMusic", RPCMode.All, _0024nuu_00242319);
					}
					if (_0024self__00242323.GetComponent<NetworkView>().isMine)
					{
						if (Network.connections.Length == 0)
						{
							_0024self__00242323.nameObj.SetActive(value: false);
						}
						_0024self__00242323.attackCube.SetActive(value: false);
						if ((bool)_0024self__00242323.t)
						{
							_0024self__00242323.t.position = new Vector3(2f, -2f, 0f);
						}
						_0024self__00242323.inDoor = false;
						if ((bool)_0024self__00242323.trigger)
						{
							_0024self__00242323.trigger.canLeave = false;
						}
						int num = (_0024_0024835_00242321 = 0);
						Vector3 vector = (_0024_0024836_00242322 = _0024self__00242323.p.transform.position);
						float num2 = (_0024_0024836_00242322.z = _0024_0024835_00242321);
						Vector3 vector3 = (_0024self__00242323.p.transform.position = _0024_0024836_00242322);
						_0024i_00242320 = default(int);
						for (_0024i_00242320 = 0; _0024i_00242320 < 3; _0024i_00242320++)
						{
							GameScript.door[_0024i_00242320] = 0;
						}
						GameScript.readyPlayers = 0;
						_0024self__00242323.gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
						GameScript.cLevel = PlayerPrefs.GetInt("cLevel");
					}
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242323.gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
					leavingLevel = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242324;

		public _0024OnLevelWasLoaded_00242318(PlayerControllerN self_)
		{
			_0024self__00242324 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242324);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00242325 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242326;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242326 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(2.2f)) ? 1 : 0);
					break;
				case 2:
					if (GameScript.playersDead >= Network.connections.Length + 1)
					{
						_0024self__00242326.GetComponent<NetworkView>().RPC("GameOver", RPCMode.All);
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242327;

		public _0024Check_00242325(PlayerControllerN self_)
		{
			_0024self__00242327 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242327);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GameOver_00242328 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242329;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242329 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if ((bool)_0024self__00242329.gameScript)
					{
						_0024self__00242329.StartCoroutine_Auto(_0024self__00242329.gameScript.Die());
						goto IL_0121;
					}
					if (_0024self__00242329.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242329.gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					}
					else
					{
						_0024self__00242329.gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
						MonoBehaviour.print("gamescript trying ");
						result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024self__00242329.StartCoroutine_Auto(_0024self__00242329.gameScript.Die());
					goto IL_0121;
				case 3:
					_0024self__00242329.StartCoroutine_Auto(_0024self__00242329.gameScript.Die());
					goto IL_0121;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0121:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242330;

		public _0024GameOver_00242328(PlayerControllerN self_)
		{
			_0024self__00242330 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242330);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LevelUp_00242331 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242332;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242332 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242332.levelUpObj.SetActive(value: true);
					_0024self__00242332.GetComponent<AudioSource>().PlayOneShot(_0024self__00242332.audioLevelUp);
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242332.levelUpObj.SetActive(value: false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242333;

		public _0024LevelUp_00242331(PlayerControllerN self_)
		{
			_0024self__00242333 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242333);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShieldN_00242334 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerControllerN _0024self__00242335;

			public _0024(PlayerControllerN self_)
			{
				_0024self__00242335 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242335.shieldObj.SetActive(value: true);
					result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					PlayerTriggerScript.ShieldDEF -= 4;
					if (PlayerTriggerScript.ShieldDEF < 0)
					{
						PlayerTriggerScript.ShieldDEF = 0;
					}
					if (PlayerTriggerScript.ShieldDEF == 0)
					{
						_0024self__00242335.shieldObj.SetActive(value: false);
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerControllerN _0024self__00242336;

		public _0024ShieldN_00242334(PlayerControllerN self_)
		{
			_0024self__00242336 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242336);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242337 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00242338;

			internal int _0024_0024837_00242339;

			internal Vector3 _0024_0024838_00242340;

			internal int _0024_0024839_00242341;

			internal Vector3 _0024_0024840_00242342;

			internal int _0024_0024841_00242343;

			internal Vector3 _0024_0024842_00242344;

			internal int _0024_0024843_00242345;

			internal Vector3 _0024_0024844_00242346;

			internal bool _0024l_00242347;

			internal PlayerControllerN _0024self__00242348;

			public _0024(bool l, PlayerControllerN self_)
			{
				_0024l_00242347 = l;
				_0024self__00242348 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242348.inDoor && _0024self__00242348.GetComponent<NetworkView>().isMine)
					{
						_0024i_00242338 = default(int);
						if (_0024l_00242347)
						{
							int num = (_0024_0024837_00242339 = -10);
							Vector3 vector = (_0024_0024838_00242340 = _0024self__00242348.r.velocity);
							float num2 = (_0024_0024838_00242340.x = _0024_0024837_00242339);
							Vector3 vector3 = (_0024self__00242348.r.velocity = _0024_0024838_00242340);
							int num3 = (_0024_0024839_00242341 = 10);
							Vector3 vector4 = (_0024_0024840_00242342 = _0024self__00242348.r.velocity);
							float num4 = (_0024_0024840_00242342.y = _0024_0024839_00242341);
							Vector3 vector6 = (_0024self__00242348.r.velocity = _0024_0024840_00242342);
							result = (Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
						}
						else
						{
							int num5 = (_0024_0024841_00242343 = 10);
							Vector3 vector7 = (_0024_0024842_00242344 = _0024self__00242348.r.velocity);
							float num6 = (_0024_0024842_00242344.x = _0024_0024841_00242343);
							Vector3 vector9 = (_0024self__00242348.r.velocity = _0024_0024842_00242344);
							int num7 = (_0024_0024843_00242345 = 10);
							Vector3 vector10 = (_0024_0024844_00242346 = _0024self__00242348.r.velocity);
							float num8 = (_0024_0024844_00242346.y = _0024_0024843_00242345);
							Vector3 vector12 = (_0024self__00242348.r.velocity = _0024_0024844_00242346);
							result = (Yield(3, new WaitForEndOfFrame()) ? 1 : 0);
						}
						break;
					}
					goto case 2;
				case 2:
				case 3:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00242349;

		internal PlayerControllerN _0024self__00242350;

		public _0024K_00242337(bool l, PlayerControllerN self_)
		{
			_0024l_00242349 = l;
			_0024self__00242350 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return new _0024(_0024l_00242349, _0024self__00242350);
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

	[NonSerialized]
	public static bool leavingLevel;

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

	private GameObject musicBox;

	public PlayerControllerN()
	{
		txtTitle = new TextMesh[2];
		txtName = new TextMesh[2];
		mask = 2048;
	}

	public static GameObject GetLevelUp()
	{
		return lObj;
	}

	public virtual void V()
	{
		GetComponent<NetworkView>().RPC("VN", RPCMode.All);
	}

	[RPC]
	public virtual void VN(int m)
	{
		if (m == 1)
		{
			vikingAxe.SetActive(value: true);
		}
		else
		{
			vikingAxe.SetActive(value: false);
		}
	}

	public virtual void Cat(int a)
	{
		if (a == 0)
		{
			GetComponent<NetworkView>().RPC("CatN", RPCMode.All, 0);
		}
		else
		{
			GetComponent<NetworkView>().RPC("CatN", RPCMode.All, 1);
		}
	}

	[RPC]
	public virtual void CatN(int a)
	{
		if (a == 0)
		{
			cat.SetActive(value: false);
			@base.SetActive(value: true);
			cat.GetComponent<Animation>().Play();
			return;
		}
		cat.SetActive(value: true);
		@base.SetActive(value: false);
		if (mode == 99)
		{
			@base.GetComponent<Animation>().Play("dead");
		}
		else
		{
			@base.GetComponent<Animation>().Play("i");
		}
	}

	[RPC]
	public virtual void iceShardN(int dmg, int m)
	{
		if (m == 1)
		{
			shard.SetActive(value: true);
		}
		else
		{
			shard.SetActive(value: false);
		}
	}

	public virtual IEnumerator iceShard(int mag)
	{
		return new _0024iceShard_00242212(mag, this).GetEnumerator();
	}

	[RPC]
	public virtual void Rage(int a)
	{
		if (a == 1)
		{
			particleRage.SetActive(value: true);
		}
		else
		{
			particleRage.SetActive(value: false);
		}
	}

	[RPC]
	public virtual void Clair(int a)
	{
		if (a == 1)
		{
			particleClair.SetActive(value: true);
		}
		else
		{
			particleClair.SetActive(value: false);
		}
	}

	public static void DisableAttackCube()
	{
	}

	[RPC]
	public virtual void SetMusic(int a)
	{
		if ((bool)gameScript)
		{
			gameScript.SendMessage("SetMusic", a);
		}
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242218(this).GetEnumerator();
	}

	public virtual void HungerCheck()
	{
		if (GameScript.isTown)
		{
			GetComponent<NetworkView>().RPC("hh", RPCMode.All, 1);
		}
		else
		{
			GetComponent<NetworkView>().RPC("hh", RPCMode.All, 0);
		}
	}

	[RPC]
	public virtual void hh(int a)
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

	[RPC]
	public virtual void PVP(int v)
	{
		MenuScript.pvp = v;
	}

	public virtual void Awake()
	{
		GameScript.readyPlayers = 0;
		if (MenuScript.pHat == 9)
		{
			waspEye = true;
		}
		GameScript.interacting = false;
		t = transform;
		r = GetComponent<Rigidbody>();
		if (GetComponent<NetworkView>().isMine)
		{
			if (MenuScript.pHat == 6)
			{
				canTripleJump = true;
			}
			if (MenuScript.companion > 0)
			{
				companion = (GameObject)Network.Instantiate(Resources.Load("comp/c" + MenuScript.companion), t.position, Quaternion.identity, 0);
				companion.SendMessage("Set", gameObject);
			}
		}
		else
		{
			GetComponent<Rigidbody>().isKinematic = true;
		}
		leaving = false;
		UnityEngine.Object.DontDestroyOnLoad(this);
		@base.GetComponent<Animation>()["a4"].layer = 2;
		@base.GetComponent<Animation>()["a4"].speed = 2f;
		@base.GetComponent<Animation>()["i"].speed = 2f;
		@base.GetComponent<Animation>()["a1"].layer = 2;
		@base.GetComponent<Animation>()["a2"].layer = 2;
		@base.GetComponent<Animation>()["a3"].layer = 2;
		@base.GetComponent<Animation>()["a2"].speed = 1.5f;
		if (GetComponent<NetworkView>().isMine)
		{
			aCube = attackCube;
			if (Network.isServer)
			{
				GameScript.playersDead = 0;
				GetComponent<NetworkView>().RPC("PVP", RPCMode.All, MenuScript.pvp);
			}
			inDoor = false;
			lObj = levelUpObj;
			if (GetComponent<NetworkView>().isMine)
			{
				fade = (FadeInOut)Camera.main.gameObject.GetComponent("FadeInOut");
				aCube = attackCube;
			}
			else
			{
				((AudioListener)gameObject.GetComponent(typeof(AudioListener))).enabled = false;
			}
			gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
			trigger = (PlayerTriggerScript)p.GetComponent("PlayerTriggerScript");
			GameScript.aSphere = aCube;
			Initialize();
			if ((bool)GetComponent<NetworkView>())
			{
				GetComponent<NetworkView>().RPC("D", RPCMode.All);
			}
			@base.GetComponent<Animation>()["i"].layer = 1;
			@base.GetComponent<Animation>()["r"].layer = 1;
			@base.GetComponent<Animation>()["j"].layer = 1;
			@base.GetComponent<Animation>()["dj"].layer = 1;
			@base.GetComponent<Animation>()["dead"].layer = 1;
			@base.GetComponent<Animation>()["a1"].layer = 2;
			@base.GetComponent<Animation>()["a2"].layer = 2;
			@base.GetComponent<Animation>()["a3"].layer = 2;
		}
		else
		{
			((AudioListener)gameObject.GetComponent(typeof(AudioListener))).enabled = false;
			gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
		}
	}

	[RPC]
	public virtual IEnumerator SetZoneName(string s)
	{
		return new _0024SetZoneName_00242221(s, this).GetEnumerator();
	}

	[RPC]
	public virtual void drumATKN(int a)
	{
		if (a == 1)
		{
			drumAtkObj.SetActive(value: true);
		}
		else
		{
			drumAtkObj.SetActive(value: false);
		}
	}

	public virtual void drumATK()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			GameScript.drumATK += 10;
			GetComponent<NetworkView>().RPC("drumATKN", RPCMode.All, 1);
			StartCoroutine_Auto(DrumATKTick());
		}
	}

	public virtual IEnumerator DrumATKTick()
	{
		return new _0024DrumATKTick_00242226(this).GetEnumerator();
	}

	[RPC]
	public virtual void drumDEXN(int a)
	{
		if (a == 1)
		{
			drumDexObj.SetActive(value: true);
		}
		else
		{
			drumDexObj.SetActive(value: false);
		}
	}

	public virtual void drumDEX()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			GameScript.drumDEX += 10;
			GetComponent<NetworkView>().RPC("drumDEXN", RPCMode.All, 1);
			StartCoroutine_Auto(DrumDEXTick());
		}
	}

	public virtual IEnumerator DrumDEXTick()
	{
		return new _0024DrumDEXTick_00242229(this).GetEnumerator();
	}

	[RPC]
	public virtual void drumMAGN(int a)
	{
		if (a == 1)
		{
			drumMagObj.SetActive(value: true);
		}
		else
		{
			drumMagObj.SetActive(value: false);
		}
	}

	public virtual void drumMAG()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			GameScript.drumMAG += 10;
			GetComponent<NetworkView>().RPC("drumMAGN", RPCMode.All, 1);
			StartCoroutine_Auto(DrumMAGTick());
		}
	}

	public virtual IEnumerator DrumMAGTick()
	{
		return new _0024DrumMAGTick_00242232(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator mWeaponsN(int a)
	{
		return new _0024mWeaponsN_00242235(a, this).GetEnumerator();
	}

	public virtual void mWeapons(int a)
	{
		GetComponent<NetworkView>().RPC("mWeaponsN", RPCMode.All, a);
	}

	[RPC]
	public virtual void D()
	{
		levelUpObj.SetActive(value: false);
	}

	public virtual void Initialize()
	{
		UnityEngine.Object.DontDestroyOnLoad(this);
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		GameScript.facingLeft = false;
		@base.GetComponent<Animation>()["i"].layer = 1;
		@base.GetComponent<Animation>()["r"].layer = 1;
		@base.GetComponent<Animation>()["j"].layer = 1;
		@base.GetComponent<Animation>()["a1"].layer = 2;
	}

	[RPC]
	public virtual void EX()
	{
		exclamation.SetActive(value: false);
	}

	public virtual IEnumerator HELP()
	{
		return new _0024HELP_00242240(this).GetEnumerator();
	}

	[RPC]
	public virtual void Tick(int a)
	{
		if (a == 0)
		{
			txtTick.text = string.Empty;
		}
		else
		{
			txtTick.text = string.Empty + a;
		}
	}

	[RPC]
	public virtual IEnumerator ChargeN()
	{
		return new _0024ChargeN_00242243(this).GetEnumerator();
	}

	public virtual void Charge()
	{
		chargeBoost += 4;
		GetComponent<NetworkView>().RPC("ChargeN", RPCMode.All);
	}

	[RPC]
	public virtual void AddEXP(int a)
	{
		if (!gameScript)
		{
			MonoBehaviour.print("NO GAMESCRIPT");
		}
		if ((bool)gameScript)
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
	public virtual void AddGold()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			GameScript.tempStats[2] = GameScript.tempStats[2] + 1;
			GameScript.curGold++;
			if (MenuScript.pHat == 22)
			{
				GameScript.tempStats[2] = GameScript.tempStats[2] + 1;
				GameScript.curGold++;
			}
			if ((bool)gameScript)
			{
				gameScript.RefreshGold();
			}
		}
	}

	[RPC]
	public virtual void Roar(int a)
	{
		if (a == 1)
		{
			particleRoar.SetActive(value: true);
		}
		else
		{
			particleRoar.SetActive(value: false);
		}
	}

	public virtual void TimerSet(int a)
	{
		GetComponent<NetworkView>().RPC("SetFinalTime", RPCMode.All, a);
	}

	[RPC]
	public virtual void SetFinalTime(int a)
	{
		GameScript.timer = a;
	}

	public virtual void Update()
	{
		MonoBehaviour.print("GameScript.isTown: " + GameScript.isTown);
		if (GameScript.win && !won)
		{
			won = true;
			GetComponent<NetworkView>().RPC("GameOver", RPCMode.All);
		}
		r1U.origin = transform.position;
		float y = r1U.origin.y + 0.6f;
		Vector3 origin = r1U.origin;
		float num = (origin.y = y);
		Vector3 vector2 = (r1U.origin = origin);
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		float y2 = r2U.origin.y + 0.6f;
		Vector3 origin2 = r2U.origin;
		float num2 = (origin2.y = y2);
		Vector3 vector4 = (r2U.origin = origin2);
		r2U.direction = Vector3.right;
		r1D.origin = transform.position;
		float y3 = r1D.origin.y - 0.7f;
		Vector3 origin3 = r1D.origin;
		float num3 = (origin3.y = y3);
		Vector3 vector6 = (r1D.origin = origin3);
		r1D.direction = Vector3.left;
		r2D.origin = transform.position;
		float y4 = r2D.origin.y - 0.7f;
		Vector3 origin4 = r2D.origin;
		float num4 = (origin4.y = y4);
		Vector3 vector8 = (r2D.origin = origin4);
		r2D.direction = Vector3.right;
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
		if (!GetComponent<NetworkView>().isMine || immobilized)
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
					Vector3 vector10 = (r.velocity = velocity);
				}
			}
			else if (!(r.velocity.y >= -25f))
			{
				int num7 = -25;
				Vector3 velocity2 = r.velocity;
				float num8 = (velocity2.y = num7);
				Vector3 vector12 = (r.velocity = velocity2);
			}
			if (!(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= t.position.x))
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
			if (Physics.Raycast(ray, out hit, 1f, mask))
			{
				if (hit.transform.gameObject.layer == 11)
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
					StartCoroutine_Auto(Offledge());
				}
			}
			else
			{
				mode = 2;
				StartCoroutine_Auto(Offledge());
			}
			if (UnityEngine.Input.GetButton("Left") && !inDoor && !dashing)
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
					Vector3 vector14 = (r.velocity = velocity3);
				}
			}
			if (!UnityEngine.Input.GetButtonDown("Left") || inDoor || GameScript.attacking || !r.isKinematic)
			{
			}
			if (!UnityEngine.Input.GetButtonDown("Right") || inDoor || GameScript.attacking || !r.isKinematic)
			{
			}
			if (UnityEngine.Input.GetButtonDown("Down") && GameScript.isFloating && !r.isKinematic)
			{
				if (MenuScript.companion == 9)
				{
					int num10 = -20;
					Vector3 velocity4 = r.velocity;
					float num11 = (velocity4.y = num10);
					Vector3 vector16 = (r.velocity = velocity4);
				}
				else
				{
					int num12 = -10;
					Vector3 velocity5 = r.velocity;
					float num13 = (velocity5.y = num12);
					Vector3 vector18 = (r.velocity = velocity5);
				}
			}
			if (UnityEngine.Input.GetButtonDown("Interact") && GameScript.isFloating && !r.isKinematic)
			{
				if (MenuScript.companion == 9)
				{
					int num14 = 20;
					Vector3 velocity6 = r.velocity;
					float num15 = (velocity6.y = num14);
					Vector3 vector20 = (r.velocity = velocity6);
				}
				else
				{
					int num16 = 10;
					Vector3 velocity7 = r.velocity;
					float num17 = (velocity7.y = num16);
					Vector3 vector22 = (r.velocity = velocity7);
				}
			}
			if (UnityEngine.Input.GetButtonDown("Dash Left") && !inDoor)
			{
				StartCoroutine_Auto(Dash(0));
			}
			else if (UnityEngine.Input.GetButtonDown("Dash Right") && !inDoor)
			{
				StartCoroutine_Auto(Dash(1));
			}
			if (UnityEngine.Input.GetButton("Right") && !inDoor && !dashing)
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
					Vector3 velocity8 = r.velocity;
					float num18 = (velocity8.x = x2);
					Vector3 vector24 = (r.velocity = velocity8);
				}
			}
			if (UnityEngine.Input.GetButtonUp("Left") && !inDoor)
			{
				if (grounded)
				{
					mode = 0;
				}
				int num19 = 0;
				Vector3 velocity9 = r.velocity;
				float num20 = (velocity9.x = num19);
				Vector3 vector26 = (r.velocity = velocity9);
			}
			else if (UnityEngine.Input.GetButtonUp("Right"))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num21 = 0;
				Vector3 velocity10 = r.velocity;
				float num22 = (velocity10.x = num21);
				Vector3 vector28 = (r.velocity = velocity10);
			}
			if (UnityEngine.Input.GetButtonDown("Jump"))
			{
				if (grounded)
				{
					StartCoroutine_Auto(Jump());
				}
				else if (canDoubleJump || MenuScript.companion == 7)
				{
					StartCoroutine_Auto(DoubleJump());
				}
				else if (canTripleJump)
				{
					StartCoroutine_Auto(TripleJump());
				}
			}
			if (UnityEngine.Input.GetButton("Jump") && !dashing)
			{
				if (canBoost)
				{
					float y5 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity11 = r.velocity;
					float num23 = (velocity11.y = y5);
					Vector3 vector30 = (r.velocity = velocity11);
				}
				else if (canBoost2)
				{
					float y6 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity12 = r.velocity;
					float num24 = (velocity12.y = y6);
					Vector3 vector32 = (r.velocity = velocity12);
				}
			}
			if (UnityEngine.Input.GetButtonDown("Interact"))
			{
				if (GameScript.canInteract && !GameScript.interacting)
				{
					MonoBehaviour.print("Nice! Can Interact and not already interacting");
					GameScript.interacting = true;
					gameScript.Interact();
					WW2();
				}
				else
				{
					MonoBehaviour.print("canInteract: " + GameScript.canInteract + "   interacting: " + GameScript.interacting);
				}
				if (GameScript.isShopping && PlayerTriggerScript.itemPurchasing != 0 && PlayerTriggerScript.purchasingItem != null)
				{
					MonoBehaviour.print("Purchasing!");
					gameScript.Purchase(PlayerTriggerScript.itemPurchasing);
				}
				else
				{
					MonoBehaviour.print("isShopping: " + GameScript.isShopping + "   itemPruchasing:" + PlayerTriggerScript.itemPurchasing + "  purchasingItem: " + PlayerTriggerScript.purchasingItem);
				}
				if (trigger.canFortune)
				{
				}
				if (canHelp && !inDoor)
				{
					if ((bool)downedAlly)
					{
						GetComponent<NetworkView>().RPC("bWN", RPCMode.All);
						if ((bool)downedAlly)
						{
							downedAlly.SendMessage("HELP");
						}
						StartCoroutine_Auto(HELPSTAY());
					}
					else
					{
						helping = false;
						GetComponent<NetworkView>().RPC("bWN", RPCMode.All);
					}
				}
				if (trigger.canLeave && !inDoor && !leaving)
				{
					leaving = true;
					StartCoroutine_Auto(EnterDoor());
				}
				else if (inDoor && !leaving)
				{
					StartCoroutine_Auto(LeaveDoor());
				}
			}
			if (inDoor)
			{
				mode = 4;
				int num25 = 10;
				Vector3 position = p.transform.position;
				float num26 = (position.z = num25);
				Vector3 vector34 = (p.transform.position = position);
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
			GetComponent<NetworkView>().RPC("AnimIN", RPCMode.All);
			jA = false;
		}
		else if (mode == 1)
		{
			GetComponent<NetworkView>().RPC("AnimRN", RPCMode.All);
			jA = false;
		}
		else if (mode == 2)
		{
			if (!jA)
			{
				GetComponent<NetworkView>().RPC("AnimJumpN", RPCMode.All);
				jA = true;
			}
			if (!djA)
			{
				GetComponent<NetworkView>().RPC("AnimJump2N", RPCMode.All);
				djA = true;
			}
		}
		else if (mode == 3)
		{
			@base.GetComponent<Animation>().Play("a1");
			jA = false;
		}
		else
		{
			jA = false;
		}
	}

	[RPC]
	public virtual void SummonSpirit()
	{
		if ((bool)musicBox)
		{
			musicBox.SendMessage("SetBoss");
		}
		else
		{
			musicBox = GameObject.Find("musicBox");
			musicBox.SendMessage("SetBoss");
		}
		if (Network.isServer)
		{
			Network.Instantiate(Resources.Load("e/ghostKnight"), new Vector3(transform.position.x, transform.position.y + 18f, 0f), Quaternion.identity, 0);
		}
	}

	public virtual IEnumerator Offledge()
	{
		return new _0024Offledge_00242246(this).GetEnumerator();
	}

	[RPC]
	public virtual void SetBearHat()
	{
		head2.GetComponent<Renderer>().material = (Material)Resources.Load("bearHat");
	}

	public virtual void DeathAnim()
	{
		Network.Instantiate(Resources.Load("deathA"), t.position, Quaternion.identity, 0);
	}

	[RPC]
	public virtual void AnimJumpN()
	{
		@base.GetComponent<Animation>().Play("j");
	}

	[RPC]
	public virtual void AnimJump2N()
	{
		@base.GetComponent<Animation>().Play("dj");
	}

	[RPC]
	public virtual void AnimIN()
	{
		@base.GetComponent<Animation>().Play("i");
	}

	[RPC]
	public virtual void AnimRN()
	{
		@base.GetComponent<Animation>().Play("r");
	}

	public virtual IEnumerator EnterDoor()
	{
		return new _0024EnterDoor_00242249(this).GetEnumerator();
	}

	[RPC]
	public virtual void PrintState()
	{
		int num = default(int);
		for (num = 0; num < 3; num++)
		{
		}
	}

	public virtual IEnumerator LeaveDoor()
	{
		return new _0024LeaveDoor_00242253(this).GetEnumerator();
	}

	public virtual IEnumerator HELPSTAY()
	{
		return new _0024HELPSTAY_00242258(this).GetEnumerator();
	}

	[RPC]
	public virtual void SDoor(int a)
	{
	}

	[RPC]
	public virtual IEnumerator Leaving(int d)
	{
		return new _0024Leaving_00242261(d).GetEnumerator();
	}

	[RPC]
	public virtual void NotLeaving(int d)
	{
		if (Network.isServer)
		{
			GameScript.door[d] = GameScript.door[d] - 1;
			GameScript.readyPlayers--;
			PrintState();
		}
	}

	[RPC]
	public virtual void ChangeScene()
	{
	}

	[RPC]
	public virtual void AnimD()
	{
		@base.GetComponent<Animation>().Play("dj");
	}

	[RPC]
	public virtual void AgainN()
	{
		inDoor = false;
		reviveBox.GetComponent<BoxCollider>().enabled = false;
		PlayerTriggerScript.canTakeDamage = true;
		mode = 0;
		downed = false;
		StartCoroutine_Auto(gameScript.AgainN());
	}

	[RPC]
	public virtual void Restart()
	{
		Application.LoadLevel(0);
	}

	[RPC]
	public virtual void Again()
	{
		GetComponent<NetworkView>().RPC("AgainN", RPCMode.All);
	}

	public virtual IEnumerator Dash(int a)
	{
		return new _0024Dash_00242266(a, this).GetEnumerator();
	}

	[RPC]
	public virtual void WritePlayer(int a)
	{
		gameScript.SendMessage("WriteFinal", a);
	}

	public virtual IEnumerator Jump()
	{
		return new _0024Jump_00242281(this).GetEnumerator();
	}

	public virtual IEnumerator DoubleJump()
	{
		return new _0024DoubleJump_00242288(this).GetEnumerator();
	}

	public virtual IEnumerator TripleJump()
	{
		return new _0024TripleJump_00242296(this).GetEnumerator();
	}

	[RPC]
	public virtual void FloatN(int a)
	{
		if (a == 1)
		{
			particleFloat.SetActive(value: true);
			GetComponent<Rigidbody>().useGravity = false;
			return;
		}
		particleFloat.SetActive(value: false);
		if (MenuScript.companion != 6)
		{
			GetComponent<Rigidbody>().useGravity = true;
		}
	}

	public virtual IEnumerator Float()
	{
		return new _0024Float_00242303(this).GetEnumerator();
	}

	[RPC]
	public virtual void TD(int dmg)
	{
		if (GetComponent<NetworkView>().isMine && !inDoor && !downed && (bool)trigger)
		{
			StartCoroutine_Auto(trigger.TD(dmg));
		}
	}

	public virtual void OnDestroy()
	{
		if ((bool)companion)
		{
			Network.Destroy(companion.GetComponent<NetworkView>().viewID);
		}
	}

	[RPC]
	public virtual void RemoveDoor(int d)
	{
		GameScript.door[d] = GameScript.door[d] - 1;
		GameScript.readyPlayers--;
	}

	public virtual void OnDisconnectedFromServer()
	{
		if (inDoor)
		{
			GetComponent<NetworkView>().RPC("RemoveDoor", RPCMode.Server, GameScript.curDoor);
		}
		UnityEngine.Object.Destroy(gameObject);
	}

	public virtual IEnumerator BeginLevel()
	{
		return new _0024BeginLevel_00242308(this).GetEnumerator();
	}

	[RPC]
	public virtual void UpdateAppearance(int h, int b, int race, int o, int hat)
	{
		if (h >= 700)
		{
			head2.GetComponent<Renderer>().material = (Material)Resources.Load("h/h" + h, typeof(Material));
		}
		else
		{
			head.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race + "h" + h, typeof(Material));
			head2.GetComponent<Renderer>().material = (Material)Resources.Load("hat/hat" + hat, typeof(Material));
		}
		if (b > 0)
		{
			body.GetComponent<Renderer>().material = (Material)Resources.Load("b/b" + b, typeof(Material));
			arm1.GetComponent<Renderer>().material = (Material)Resources.Load("a/a" + b, typeof(Material));
			arm2.GetComponent<Renderer>().material = (Material)Resources.Load("a/a" + b, typeof(Material));
			leg.GetComponent<Renderer>().material = (Material)Resources.Load("l/l" + b, typeof(Material));
		}
		else
		{
			body.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race + "b", typeof(Material));
			arm1.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race + "a", typeof(Material));
			arm2.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race + "a", typeof(Material));
			leg.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race + "l", typeof(Material));
		}
		offHand.GetComponent<Renderer>().material = (Material)Resources.Load("o/o" + o, typeof(Material));
	}

	public virtual void bW(GameObject a)
	{
		if (GetComponent<NetworkView>().isMine)
		{
			downedAlly = a;
			buttonW.SetActive(value: true);
			canHelp = true;
		}
	}

	public virtual void WW()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			buttonW.SetActive(value: true);
		}
	}

	public virtual void WW2()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			buttonW.SetActive(value: false);
		}
	}

	[RPC]
	public virtual void bWN()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			buttonW.SetActive(value: false);
			canHelp = false;
		}
	}

	[RPC]
	public virtual void uI(int id)
	{
		weapon.GetComponent<Renderer>().material = (Material)Resources.Load("iE/i" + id, typeof(Material));
	}

	[RPC]
	public virtual void AssignTitle(string n)
	{
		txtTitle[0].text = n;
		txtTitle[1].text = n;
	}

	[RPC]
	public virtual void AssignName(string n)
	{
		txtName[0].text = n;
		txtName[1].text = n;
	}

	[RPC]
	public virtual void SetBGNetwork(int tBiome)
	{
		gameScript.SetBGNetwork(tBiome);
	}

	[RPC]
	public virtual void mA(string s)
	{
		mode = 3;
		@base.GetComponent<Animation>().Stop();
		@base.GetComponent<Animation>().Play(s);
	}

	[RPC]
	public virtual void Boss()
	{
		isBoss = true;
	}

	[RPC]
	public virtual IEnumerator LoadLevel(int level, bool a)
	{
		return new _0024LoadLevel_00242311(level, a, this).GetEnumerator();
	}

	public virtual void RA()
	{
		gameScript.RefreshActionBar();
	}

	public virtual void Break()
	{
		GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/break", typeof(AudioClip)));
		gameScript.UpdateCharacterWeapon();
	}

	public virtual void Write(int a)
	{
		StartCoroutine_Auto(gameScript.Write(a));
	}

	public virtual IEnumerator OnLevelWasLoaded(int level)
	{
		return new _0024OnLevelWasLoaded_00242318(this).GetEnumerator();
	}

	[RPC]
	public virtual void SpawnNPC(NetworkViewID id, int pos, int n)
	{
	}

	public virtual Vector3 GetNPCPos(int a)
	{
		Vector3 vector = default(Vector3);
		return a switch
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
			_ => vector, 
		};
	}

	[RPC]
	public virtual void po(Vector3 pos)
	{
		UnityEngine.Object.Instantiate(pop, pos, Quaternion.Euler(0f, 180f, 180f));
	}

	[RPC]
	public virtual void AddDeadPerson()
	{
		GameScript.playersDead++;
		StartCoroutine_Auto(Check());
	}

	public virtual IEnumerator Check()
	{
		return new _0024Check_00242325(this).GetEnumerator();
	}

	[RPC]
	public virtual void RemoveDeadPerson()
	{
		GameScript.playersDead--;
		if (GameScript.playersDead < 0)
		{
			GameScript.playersDead = 0;
		}
	}

	[RPC]
	public virtual IEnumerator GameOver()
	{
		return new _0024GameOver_00242328(this).GetEnumerator();
	}

	[RPC]
	public virtual void AnimDead()
	{
		@base.GetComponent<Animation>().Play("dead");
		if (!GetComponent<NetworkView>().isMine)
		{
			r.isKinematic = false;
		}
	}

	[RPC]
	public virtual void SetDead()
	{
		exclamation.SetActive(value: true);
		reviveBox.GetComponent<BoxCollider>().enabled = true;
		if (!GetComponent<NetworkView>().isMine)
		{
			GetComponent<Rigidbody>().isKinematic = false;
		}
	}

	[RPC]
	public virtual void SetRevive()
	{
		exclamation.SetActive(value: false);
		reviveBox.GetComponent<BoxCollider>().enabled = false;
	}

	[RPC]
	public virtual void Revive()
	{
		if (Network.isServer)
		{
			RemoveDeadPerson();
			MonoBehaviour.print("isServer");
		}
		else
		{
			MonoBehaviour.print("not server");
			GetComponent<NetworkView>().RPC("RemoveDeadPerson", RPCMode.Server);
		}
		exclamation.SetActive(value: false);
		reviveBox.GetComponent<BoxCollider>().enabled = false;
		exclamation.SetActive(value: false);
		if (GetComponent<NetworkView>().isMine)
		{
			downed = false;
			GameScript.canTakeDamage = true;
			mode = 0;
			gameScript.SetRevive();
			PlayerTriggerScript.canTakeDamage = true;
			trigger.enabled = true;
		}
		else
		{
			r.isKinematic = true;
		}
	}

	[RPC]
	public virtual void Die()
	{
		if (!downed)
		{
			downed = true;
			if (GetComponent<NetworkView>().isMine)
			{
				GetComponent<NetworkView>().RPC("SetDead", RPCMode.All);
				gameScript.SetDead();
				trigger.enabled = false;
				GetComponent<NetworkView>().RPC("AnimDead", RPCMode.All);
				mode = 99;
			}
			else
			{
				MonoBehaviour.print("HELLO DOOD");
				r.isKinematic = false;
			}
			if (Network.isServer)
			{
				AddDeadPerson();
			}
			else
			{
				GetComponent<NetworkView>().RPC("AddDeadPerson", RPCMode.All);
			}
		}
	}

	public virtual void Rev()
	{
		GameScript.HP = 2;
		gameScript.LoadHearts();
		downed = false;
		trigger.enabled = true;
		GetComponent<Collider>().enabled = true;
		r.isKinematic = true;
		@base.gameObject.SetActive(value: true);
		bar.SetActive(value: false);
		mode = 0;
		ghost.SetActive(value: false);
	}

	[RPC]
	public virtual void RevCheck()
	{
		GameScript.playersDead--;
	}

	[RPC]
	public virtual void Lose()
	{
		t.position = new Vector3(99f, 99f, 99f);
	}

	[RPC]
	public virtual IEnumerator LevelUp()
	{
		return new _0024LevelUp_00242331(this).GetEnumerator();
	}

	public virtual void OnPlayerDisconnected(NetworkPlayer player)
	{
		Network.RemoveRPCs(player);
		Network.DestroyPlayerObjects(player);
		StartCoroutine_Auto(Check());
	}

	[RPC]
	public virtual IEnumerator ShieldN()
	{
		return new _0024ShieldN_00242334(this).GetEnumerator();
	}

	public virtual void Shield()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			PlayerTriggerScript.ShieldDEF += 4;
		}
		GetComponent<NetworkView>().RPC("ShieldN", RPCMode.All);
	}

	[RPC]
	public virtual void AnimRun()
	{
		if (!downed)
		{
			@base.GetComponent<Animation>().Stop();
			@base.GetComponent<Animation>().Play("r");
		}
		else
		{
			@base.GetComponent<Animation>().Play("dead");
		}
	}

	[RPC]
	public virtual void AnimIdle()
	{
		if (!downed)
		{
			@base.GetComponent<Animation>().Play("i");
		}
		else
		{
			@base.GetComponent<Animation>().Play("dead");
		}
	}

	[RPC]
	public virtual void AnimJump()
	{
		if (!downed)
		{
			@base.GetComponent<Animation>().Play("j");
		}
		else
		{
			@base.GetComponent<Animation>().Play("dead");
		}
	}

	[RPC]
	public virtual void AnimJump2()
	{
		if (!downed)
		{
			@base.GetComponent<Animation>().Play("dj");
		}
		else
		{
			@base.GetComponent<Animation>().Play("dead");
		}
	}

	[RPC]
	public virtual IEnumerator K(bool l)
	{
		return new _0024K_00242337(l, this).GetEnumerator();
	}

	public virtual void TDp()
	{
		float num = (float)GameScript.MAXHP * 0.2f;
		int dMG = (int)num;
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			StartCoroutine_Auto(trigger.TD(dMG));
		}
	}

	public virtual void Main()
	{
	}
}
