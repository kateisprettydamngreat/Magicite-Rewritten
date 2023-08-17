using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;

[Serializable]
public class GameScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Invader_00241425 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241426;

			internal int _0024waitTime_00241427;

			internal GameScript _0024self__00241428;

			public _0024(GameScript self_)
			{
				_0024self__00241428 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Expected O, but got Unknown
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241426 = default(int);
					if (MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
					{
						_0024waitTime_00241427 = Random.Range(300, 350);
						if (districtLevel <= 1)
						{
							_0024waitTime_00241427 *= 2;
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)_0024waitTime_00241427)) ? 1 : 0);
						break;
					}
					goto IL_0118;
				case 2:
					((MonoBehaviour)_0024self__00241428).StartCoroutine_Auto(_0024self__00241428.Write(5));
					player.networkView.RPC("Boss", (RPCMode)2, new object[0]);
					_0024i_00241426 = 0;
					goto IL_010c;
				case 3:
					_0024i_00241426++;
					goto IL_010c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_010c:
					if (_0024i_00241426 < 5)
					{
						Network.Instantiate(Resources.Load("e/invader"), new Vector3(-15f, 15f, 0f), Quaternion.identity, 0);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(3, 8))) ? 1 : 0);
						break;
					}
					goto IL_0118;
					IL_0118:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241429;

		public _0024Invader_00241425(GameScript self_)
		{
			_0024self__00241429 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241429);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Timer_00241430 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241431;

			public _0024(GameScript self_)
			{
				_0024self__00241431 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (!_0024self__00241431.dead)
					{
						timer++;
					}
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241432;

		public _0024Timer_00241430(GameScript self_)
		{
			_0024self__00241432 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241432);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ScourgeMaskTick_00241433 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				//IL_001f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0029: Expected O, but got Unknown
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(5f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.pHat == 17)
					{
						goto IL_003f;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 3:
					player.SendMessage("TD", (object)1);
					goto IL_003f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_003f:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(115f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return (IEnumerator<WaitForSeconds>)(object)new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TikiCheck_00241434 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024noo_00241435;

			internal GameObject _0024pot_00241436;

			internal GameScript _0024self__00241437;

			public _0024(GameScript self_)
			{
				_0024self__00241437 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected O, but got Unknown
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					MonoBehaviour.print((object)"TIKI CHECK");
					if (MenuScript.pHat == 10)
					{
						_0024noo_00241435 = Random.Range(0, 2);
						if (_0024noo_00241435 == 0)
						{
							player.SendMessage("TD", (object)1);
						}
						else
						{
							HP += 3;
							_0024pot_00241436 = (GameObject)Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
							_0024pot_00241436.SendMessage("SD", (object)3);
							_0024self__00241437.LoadHearts();
						}
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

		internal GameScript _0024self__00241438;

		public _0024TikiCheck_00241434(GameScript self_)
		{
			_0024self__00241438 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241438);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LavaWorm_00241439 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(5f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer <= 0 || MenuScript.multiplayer == 1)
					{
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

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return (IEnumerator<WaitForSeconds>)(object)new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RecoverMana_00241440 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241441;

			public _0024(GameScript self_)
			{
				_0024self__00241441 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)manaWait)) ? 1 : 0);
					break;
				case 2:
					if (MAG < MAXMAG)
					{
						MAG++;
						_0024self__00241441.LoadMana();
						_0024self__00241441.GUImana.animation.Play();
					}
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241442;

		public _0024RecoverMana_00241440(GameScript self_)
		{
			_0024self__00241442 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241442);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ScourgeBoss_00241443 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024enemy_00241444;

			internal int _0024d_00241445;

			public _0024(int d)
			{
				_0024d_00241445 = d;
			}

			public override bool MoveNext()
			{
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0156: Unknown result type (might be due to invalid IL or missing references)
				//IL_0109: Unknown result type (might be due to invalid IL or missing references)
				//IL_0113: Expected O, but got Unknown
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024enemy_00241444 = null;
					if (!isTown)
					{
						if (_0024d_00241445 == 5)
						{
							_0024enemy_00241444 = "abyssalTitan";
						}
						else if (_0024d_00241445 == 10)
						{
							_0024enemy_00241444 = "scourgeKnight";
						}
						else if (_0024d_00241445 == 15)
						{
							_0024enemy_00241444 = "scourgeKnight";
						}
						else
						{
							_0024enemy_00241444 = "abyssalTitan";
						}
						if (MenuScript.multiplayer <= 0)
						{
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
						if (MenuScript.multiplayer == 1)
						{
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
					}
					goto IL_0161;
				case 2:
					if (Object.op_Implicit((Object)(object)exitObj))
					{
						exitObj.SendMessage("Close");
					}
					Network.Instantiate(Resources.Load("e/" + _0024enemy_00241444), new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
					goto IL_0161;
				case 3:
					if (Object.op_Implicit((Object)(object)exitObj))
					{
						exitObj.SendMessage("Close");
					}
					Object.Instantiate(Resources.Load("e/" + _0024enemy_00241444), new Vector3(0f, 0f, 0f), Quaternion.identity);
					goto IL_0161;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0161:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024d_00241446;

		public _0024ScourgeBoss_00241443(int d)
		{
			_0024d_00241446 = d;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024d_00241446);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SummonScourge_00241447 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Expected O, but got Unknown
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
							break;
						}
						goto IL_009c;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					Network.Instantiate(Resources.Load("e/scourge1"), new Vector3(0f, 0f, 0f), Quaternion.identity, 1);
					goto IL_009c;
				case 3:
					Object.Instantiate(Resources.Load("e/scourge1"), new Vector3(0f, 0f, 0f), Quaternion.identity);
					goto IL_009c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_009c:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return (IEnumerator<WaitForSeconds>)(object)new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RepeatScourge_00241448 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241449;

			internal GameScript _0024self__00241450;

			public _0024(GameScript self_)
			{
				_0024self__00241450 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer == 0)
					{
						_0024i_00241449 = default(int);
						_0024i_00241449 = 0;
						goto IL_0079;
					}
					goto IL_0085;
				case 2:
					((MonoBehaviour)_0024self__00241450).StartCoroutine_Auto(_0024self__00241450.SummonScourge());
					_0024i_00241449++;
					goto IL_0079;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0085:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
					IL_0079:
					if (_0024i_00241449 < 5)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(10, 15))) ? 1 : 0);
						break;
					}
					goto IL_0085;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241451;

		public _0024RepeatScourge_00241448(GameScript self_)
		{
			_0024self__00241451 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241451);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Quake_00241452 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241453;

			internal int _0024pos_00241454;

			internal int _0024i_00241455;

			public override bool MoveNext()
			{
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0156: Unknown result type (might be due to invalid IL or missing references)
				//IL_0173: Unknown result type (might be due to invalid IL or missing references)
				//IL_0178: Unknown result type (might be due to invalid IL or missing references)
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_018b: Unknown result type (might be due to invalid IL or missing references)
				//IL_019d: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a7: Expected O, but got Unknown
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_010c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0116: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024num_00241453 = default(int);
					_0024pos_00241454 = default(int);
					((Component)Camera.main).animation.Play("quake");
					_0024i_00241455 = default(int);
					_0024i_00241455 = 0;
					goto IL_01ba;
				case 3:
				case 4:
					_0024i_00241455++;
					goto IL_01ba;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01ba:
					if (_0024i_00241455 < 20)
					{
						if (MenuScript.multiplayer > 0)
						{
							if (MenuScript.multiplayer == 1)
							{
								_0024num_00241453 = Random.Range(0, 3);
								Network.Instantiate(Resources.Load("rck" + (object)_0024num_00241453), new Vector3(player.transform.position.x + (float)Random.Range(-10, 20), player.transform.position.y + 20f, 0f), Quaternion.identity, 1);
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.8f)) ? 1 : 0);
								break;
							}
							goto case 3;
						}
						_0024num_00241453 = Random.Range(0, 3);
						Object.Instantiate(Resources.Load("rck" + (object)_0024num_00241453), new Vector3(player.transform.position.x + (float)Random.Range(-10, 20), player.transform.position.y + 20f, 0f), Quaternion.identity);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.8f)) ? 1 : 0);
						break;
					}
					((Component)Camera.main).animation.Stop();
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return (IEnumerator<WaitForSeconds>)(object)new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Write_00241456 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024tt_00241457;

			internal int _0024_0024switch_0024179_00241458;

			internal int _0024num_00241459;

			internal GameScript _0024self__00241460;

			public _0024(int num, GameScript self_)
			{
				_0024num_00241459 = num;
				_0024self__00241460 = self_;
			}

			public override bool MoveNext()
			{
				//IL_018e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0198: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					MonoBehaviour.print((object)"WRITING");
					_0024tt_00241457 = null;
					_0024_0024switch_0024179_00241458 = _0024num_00241459;
					if (_0024_0024switch_0024179_00241458 == 0)
					{
						_0024tt_00241457 = "Your " + _0024self__00241460.GetGearName(inventory[curActiveSlot].id) + " is about to break.";
					}
					else if (_0024_0024switch_0024179_00241458 == 1)
					{
						_0024tt_00241457 = "Your stomach begins to grumble.";
					}
					else if (_0024_0024switch_0024179_00241458 == 2)
					{
						_0024tt_00241457 = "You are starving.";
					}
					else if (_0024_0024switch_0024179_00241458 == 3)
					{
						_0024tt_00241457 = "You feel uneasy.";
					}
					else if (_0024_0024switch_0024179_00241458 == 4)
					{
						_0024tt_00241457 = "A slight breeze brushes against your face.";
					}
					else if (_0024_0024switch_0024179_00241458 == 5)
					{
						_0024self__00241460.GlobalWrite(0);
					}
					else if (_0024_0024switch_0024179_00241458 == 6)
					{
						_0024tt_00241457 = "You feel as if the Scourge are watching you...";
					}
					else if (_0024_0024switch_0024179_00241458 == 7)
					{
						_0024tt_00241457 = "You've awakened the Broodmother...";
					}
					else
					{
						_0024tt_00241457 = string.Empty;
					}
					if (!string.IsNullOrEmpty(_0024tt_00241457))
					{
						((Component)_0024self__00241460.txtStatus2).gameObject.SetActive(true);
						_0024self__00241460.txtStatus2.text = _0024tt_00241457;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto IL_01b2;
				case 2:
					_0024self__00241460.txtStatus2.text = " ";
					goto IL_01b2;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01b2:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024num_00241461;

		internal GameScript _0024self__00241462;

		public _0024Write_00241456(int num, GameScript self_)
		{
			_0024num_00241461 = num;
			_0024self__00241462 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024num_00241461, _0024self__00241462);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024WriteFinal_00241463 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024tt_00241464;

			internal int _0024_0024switch_0024181_00241465;

			internal int _0024a_00241466;

			internal GameScript _0024self__00241467;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241466 = a;
				_0024self__00241467 = self_;
			}

			public override bool MoveNext()
			{
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024tt_00241464 = null;
					_0024_0024switch_0024181_00241465 = _0024a_00241466;
					_0024tt_00241464 = "The Scourge have invaded! Get out!!";
					((Component)_0024self__00241467.txtStatus2).gameObject.SetActive(true);
					_0024self__00241467.txtStatus2.text = _0024tt_00241464;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241467.txtStatus2.text = " ";
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241468;

		internal GameScript _0024self__00241469;

		public _0024WriteFinal_00241463(int a, GameScript self_)
		{
			_0024a_00241468 = a;
			_0024self__00241469 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241468, _0024self__00241469);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GenerateText_00241470 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241471;

			internal string _0024tt_00241472;

			internal int _0024_0024switch_0024183_00241473;

			internal GameScript _0024self__00241474;

			public _0024(GameScript self_)
			{
				_0024self__00241474 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0123: Unknown result type (might be due to invalid IL or missing references)
				//IL_012d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024num_00241471 = Random.Range(0, 30);
					_0024tt_00241472 = null;
					_0024_0024switch_0024183_00241473 = _0024num_00241471;
					if (_0024_0024switch_0024183_00241473 == 0)
					{
						_0024tt_00241472 = "You feel as if you are being watched...";
					}
					else if (_0024_0024switch_0024183_00241473 == 1)
					{
						_0024tt_00241472 = "You hear a distant rumble...";
						if (!isTown)
						{
							((MonoBehaviour)_0024self__00241474).StartCoroutine_Auto(_0024self__00241474.Quake());
						}
					}
					else if (_0024_0024switch_0024183_00241473 == 2)
					{
						_0024tt_00241472 = "There is a foul taste in the air.";
					}
					else if (_0024_0024switch_0024183_00241473 == 3)
					{
						_0024tt_00241472 = "You feel uneasy.";
					}
					else if (_0024_0024switch_0024183_00241473 == 4)
					{
						_0024tt_00241472 = "A slight breeze brushes against your face.";
					}
					else
					{
						_0024tt_00241472 = string.Empty;
					}
					if (Object.op_Implicit((Object)(object)_0024self__00241474.txtStatus2))
					{
						_0024self__00241474.txtStatus2.text = _0024tt_00241472;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0147;
				case 2:
					_0024self__00241474.txtStatus2.text = string.Empty;
					goto IL_0147;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0147:
					if (_0024num_00241471 == 3 && MenuScript.multiplayer == 0 && !isTown)
					{
						_0024self__00241474.Worm();
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241475;

		public _0024GenerateText_00241470(GameScript self_)
		{
			_0024self__00241475 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241475);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241476 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241477;

			public _0024(GameScript self_)
			{
				_0024self__00241477 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					((MonoBehaviour)_0024self__00241477).StartCoroutine_Auto(_0024self__00241477.StaminaStart());
					menuOpen = false;
					_0024self__00241477.LoadHearts();
					_0024self__00241477.LoadMana();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					isReturning = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241478;

		public _0024Start_00241476(GameScript self_)
		{
			_0024self__00241478 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241478);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024StaminaStart_00241479 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241480;

			public _0024(GameScript self_)
			{
				_0024self__00241480 = self_;
			}

			public override bool MoveNext()
			{
				//IL_009b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241480.maxStamina = MenuScript.playerStat[2] + 2 + tempPlayerStat[2] + tempLevelStat[2];
					_0024self__00241480.stamina = _0024self__00241480.maxStamina;
					goto case 2;
				case 2:
					if (!(_0024self__00241480.stamina >= (float)_0024self__00241480.maxStamina))
					{
						_0024self__00241480.stamina += 1f;
						_0024self__00241480.LoadSTA();
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241481;

		public _0024StaminaStart_00241479(GameScript self_)
		{
			_0024self__00241481 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241481);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024WriteEgg_00241482 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241483;

			public _0024(GameScript self_)
			{
				_0024self__00241483 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241483.writingEgg = true;
					((MonoBehaviour)_0024self__00241483).StartCoroutine_Auto(_0024self__00241483.Write(7));
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241483.writingEgg = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241484;

		public _0024WriteEgg_00241482(GameScript self_)
		{
			_0024self__00241484 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241484);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Craft_00241485 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024canCraft_00241486;

			internal string _0024craft_00241487;

			internal int _0024c1_00241488;

			internal int _0024c2_00241489;

			internal Item _0024newItem_00241490;

			internal int _0024newID_00241491;

			internal int _0024newQ_00241492;

			internal int _0024i_00241493;

			internal int _0024lowestQ_00241494;

			internal Item _0024bArrows_00241495;

			internal float _0024tempForge_00241496;

			internal int _0024luckCount_00241497;

			internal int _0024bonusStat_00241498;

			internal int _0024num1_00241499;

			internal GameScript _0024self__00241500;

			public _0024(GameScript self_)
			{
				_0024self__00241500 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024canCraft_00241486 = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					_0024craft_00241487 = (object)_0024self__00241500.firstItemSelected.id + "c" + (object)_0024self__00241500.secondItemSelected.id;
					_0024c1_00241488 = _0024self__00241500.firstItemSelected.id;
					_0024c2_00241489 = _0024self__00241500.secondItemSelected.id;
					_0024newItem_00241490 = null;
					_0024newID_00241491 = default(int);
					_0024newQ_00241492 = default(int);
					MonoBehaviour.print((object)("crafting " + (object)_0024c1_00241488 + " " + (object)_0024c2_00241489));
					if (_0024c1_00241488 == 1 && _0024c2_00241489 == 1)
					{
						_0024newID_00241491 = 2;
					}
					else if (_0024c1_00241488 == 2 && _0024c2_00241489 == 2)
					{
						_0024newID_00241491 = 25;
					}
					else if (_0024c1_00241488 == 2 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 24;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 2)
					{
						_0024newID_00241491 = 24;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 26;
					}
					else if (_0024c1_00241488 == 9 && _0024c2_00241489 == 9)
					{
						_0024newID_00241491 = 15;
					}
					else if (_0024c1_00241488 == 25 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 501;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 25)
					{
						_0024newID_00241491 = 501;
					}
					else if (_0024c1_00241488 == 24 && _0024c2_00241489 == 25)
					{
						_0024newID_00241491 = 500;
					}
					else if (_0024c1_00241488 == 25 && _0024c2_00241489 == 24)
					{
						_0024newID_00241491 = 500;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 27;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 27;
					}
					else if (_0024c1_00241488 == 27 && _0024c2_00241489 == 25)
					{
						_0024newID_00241491 = 502;
					}
					else if (_0024c1_00241488 == 25 && _0024c2_00241489 == 27)
					{
						_0024newID_00241491 = 502;
					}
					else if (_0024c1_00241488 == 38 && _0024c2_00241489 == 38)
					{
						_0024newID_00241491 = 39;
					}
					else if (_0024c1_00241488 == 39 && _0024c2_00241489 == 39)
					{
						_0024newID_00241491 = 40;
					}
					else if (_0024c1_00241488 == 24 && _0024c2_00241489 == 40)
					{
						_0024newID_00241491 = 512;
					}
					else if (_0024c1_00241488 == 40 && _0024c2_00241489 == 24)
					{
						_0024newID_00241491 = 512;
					}
					else if (_0024c1_00241488 == 40 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 513;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 40)
					{
						_0024newID_00241491 = 513;
					}
					else if (_0024c1_00241488 == 40 && _0024c2_00241489 == 27)
					{
						_0024newID_00241491 = 514;
					}
					else if (_0024c1_00241488 == 27 && _0024c2_00241489 == 40)
					{
						_0024newID_00241491 = 514;
					}
					else if (_0024c1_00241488 == 18 && _0024c2_00241489 == 18)
					{
						_0024newID_00241491 = 51;
					}
					else if (_0024c1_00241488 == 18 && _0024c2_00241489 == 50)
					{
						_0024newID_00241491 = 517;
					}
					else if (_0024c1_00241488 == 50 && _0024c2_00241489 == 18)
					{
						_0024newID_00241491 = 517;
					}
					else if (_0024c1_00241488 == 69 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 600;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 69)
					{
						_0024newID_00241491 = 600;
					}
					else if (_0024c1_00241488 == 70 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 601;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 70)
					{
						_0024newID_00241491 = 601;
					}
					else if (_0024c1_00241488 == 30 && _0024c2_00241489 == 30)
					{
						_0024newID_00241491 = 69;
					}
					else if (_0024c1_00241488 == 31 && _0024c2_00241489 == 31)
					{
						_0024newID_00241491 = 70;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 50)
					{
						_0024newID_00241491 = 517;
					}
					else if (_0024c1_00241488 == 50 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 517;
					}
					else if (_0024c1_00241488 == 24 && _0024c2_00241489 == 50)
					{
						_0024newID_00241491 = 516;
					}
					else if (_0024c1_00241488 == 50 && _0024c2_00241489 == 24)
					{
						_0024newID_00241491 = 516;
					}
					else if (_0024c1_00241488 == 60 && _0024c2_00241489 == 60)
					{
						_0024newID_00241491 = 61;
					}
					else if (_0024c1_00241488 == 51 && _0024c2_00241489 == 51)
					{
						_0024newID_00241491 = 50;
					}
					else if (_0024c1_00241488 == 27 && _0024c2_00241489 == 50)
					{
						_0024newID_00241491 = 518;
					}
					else if (_0024c1_00241488 == 50 && _0024c2_00241489 == 27)
					{
						_0024newID_00241491 = 518;
					}
					else if (_0024c1_00241488 == 29 && _0024c2_00241489 == 29)
					{
						_0024newID_00241491 = 68;
					}
					else if (_0024c1_00241488 == 27 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 28;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 27)
					{
						_0024newID_00241491 = 28;
					}
					else if (_0024c1_00241488 == 28 && _0024c2_00241489 == 29)
					{
						_0024newID_00241491 = 515;
					}
					else if (_0024c1_00241488 == 29 && _0024c2_00241489 == 28)
					{
						_0024newID_00241491 = 515;
					}
					else if (_0024c1_00241488 == 12 && _0024c2_00241489 == 12)
					{
						_0024newID_00241491 = 32;
					}
					else if (_0024c1_00241488 == 13 && _0024c2_00241489 == 13)
					{
						_0024newID_00241491 = 33;
					}
					else if (_0024c1_00241488 == 14 && _0024c2_00241489 == 14)
					{
						_0024newID_00241491 = 34;
					}
					else if (_0024c1_00241488 == 39 && _0024c2_00241489 == 39)
					{
						_0024newID_00241491 = 40;
					}
					else if (_0024c1_00241488 == 32 && _0024c2_00241489 == 24)
					{
						_0024newID_00241491 = 503;
					}
					else if (_0024c1_00241488 == 24 && _0024c2_00241489 == 32)
					{
						_0024newID_00241491 = 503;
					}
					else if (_0024c1_00241488 == 32 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 504;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 32)
					{
						_0024newID_00241491 = 504;
					}
					else if (_0024c1_00241488 == 32 && _0024c2_00241489 == 27)
					{
						_0024newID_00241491 = 505;
					}
					else if (_0024c1_00241488 == 27 && _0024c2_00241489 == 32)
					{
						_0024newID_00241491 = 505;
					}
					else if (_0024c1_00241488 == 24 && _0024c2_00241489 == 33)
					{
						_0024newID_00241491 = 506;
					}
					else if (_0024c1_00241488 == 33 && _0024c2_00241489 == 24)
					{
						_0024newID_00241491 = 506;
					}
					else if (_0024c1_00241488 == 33 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 507;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 33)
					{
						_0024newID_00241491 = 507;
					}
					else if (_0024c1_00241488 == 33 && _0024c2_00241489 == 27)
					{
						_0024newID_00241491 = 508;
					}
					else if (_0024c1_00241488 == 27 && _0024c2_00241489 == 33)
					{
						_0024newID_00241491 = 508;
					}
					else if (_0024c1_00241488 == 24 && _0024c2_00241489 == 34)
					{
						_0024newID_00241491 = 509;
					}
					else if (_0024c1_00241488 == 34 && _0024c2_00241489 == 24)
					{
						_0024newID_00241491 = 509;
					}
					else if (_0024c1_00241488 == 34 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 510;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 34)
					{
						_0024newID_00241491 = 510;
					}
					else if (_0024c1_00241488 == 34 && _0024c2_00241489 == 27)
					{
						_0024newID_00241491 = 511;
					}
					else if (_0024c1_00241488 == 27 && _0024c2_00241489 == 34)
					{
						_0024newID_00241491 = 511;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 35)
					{
						_0024newID_00241491 = 560;
					}
					else if (_0024c1_00241488 == 35 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 560;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 36)
					{
						_0024newID_00241491 = 561;
					}
					else if (_0024c1_00241488 == 36 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 561;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 37)
					{
						_0024newID_00241491 = 562;
					}
					else if (_0024c1_00241488 == 37 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 562;
					}
					else if (_0024c1_00241488 == 26 && _0024c2_00241489 == 41)
					{
						_0024newID_00241491 = 563;
					}
					else if (_0024c1_00241488 == 41 && _0024c2_00241489 == 26)
					{
						_0024newID_00241491 = 563;
					}
					else if (_0024c1_00241488 == 32 && _0024c2_00241489 == 32)
					{
						_0024newID_00241491 = 35;
					}
					else if (_0024c1_00241488 == 33 && _0024c2_00241489 == 33)
					{
						_0024newID_00241491 = 36;
					}
					else if (_0024c1_00241488 == 34 && _0024c2_00241489 == 34)
					{
						_0024newID_00241491 = 37;
					}
					else if (_0024c1_00241488 == 40 && _0024c2_00241489 == 40)
					{
						_0024newID_00241491 = 41;
					}
					else if (_0024c1_00241488 == 68 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 529;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 68)
					{
						_0024newID_00241491 = 529;
					}
					else if (_0024c1_00241488 == 15 && _0024c2_00241489 == 15)
					{
						_0024newID_00241491 = 42;
					}
					else if (_0024c1_00241488 == 16 && _0024c2_00241489 == 16)
					{
						_0024newID_00241491 = 43;
					}
					else if (_0024c1_00241488 == 44 && _0024c2_00241489 == 44)
					{
						_0024newID_00241491 = 45;
					}
					else if (_0024c1_00241488 == 10 && _0024c2_00241489 == 10)
					{
						_0024newID_00241491 = 16;
					}
					else if (_0024c1_00241488 == 23 && _0024c2_00241489 == 23)
					{
						_0024newID_00241491 = 29;
					}
					else if (_0024c1_00241488 == 39 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 53;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 39)
					{
						_0024newID_00241491 = 53;
					}
					else if (_0024c1_00241488 == 12 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 54;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 12)
					{
						_0024newID_00241491 = 54;
					}
					else if (_0024c1_00241488 == 13 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 55;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 13)
					{
						_0024newID_00241491 = 55;
					}
					else if (_0024c1_00241488 == 51 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 52;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 51)
					{
						_0024newID_00241491 = 52;
					}
					else if (_0024c1_00241488 == 3 && _0024c2_00241489 == 14)
					{
						_0024newID_00241491 = 56;
					}
					else if (_0024c1_00241488 == 14 && _0024c2_00241489 == 3)
					{
						_0024newID_00241491 = 56;
					}
					else if ((_0024c1_00241488 == 47 && _0024c2_00241489 == 47) || (_0024c1_00241488 == 38 && _0024c2_00241489 == 47) || (_0024c1_00241488 == 47 && _0024c2_00241489 == 38))
					{
						_0024newID_00241491 = 48;
					}
					else if ((_0024c1_00241488 == 9 && _0024c2_00241489 == 10) || (_0024c1_00241488 == 10 && _0024c2_00241489 == 9) || (_0024c1_00241488 == 9 && _0024c2_00241489 == 11) || (_0024c1_00241488 == 11 && _0024c2_00241489 == 9) || (_0024c1_00241488 == 10 && _0024c2_00241489 == 11) || (_0024c1_00241488 == 11 && _0024c2_00241489 == 10))
					{
						_0024newID_00241491 = 44;
					}
					else if (_0024c1_00241488 == 44 && _0024c2_00241489 == 44)
					{
						_0024newID_00241491 = 45;
					}
					else
					{
						_0024canCraft_00241486 = false;
					}
					if (_0024newID_00241491 >= 600 && _0024newID_00241491 <= 605)
					{
						MenuScript.canUnlockHat[5] = 1;
					}
					if (_0024canCraft_00241486)
					{
						_0024i_00241493 = default(int);
						if (_0024newID_00241491 == 15 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4))
						{
							_0024newID_00241491 = 42;
						}
						if (_0024newID_00241491 == 16 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4))
						{
							_0024newID_00241491 = 43;
						}
						if (_0024newID_00241491 == 44 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4))
						{
							_0024newID_00241491 = 45;
						}
						((Component)_0024self__00241500).audio.PlayOneShot(_0024self__00241500.audioCraftt);
						if (_0024newID_00241491 < 500)
						{
							_0024lowestQ_00241494 = default(int);
							if (_0024self__00241500.firstItemSelected.q == _0024self__00241500.secondItemSelected.q)
							{
								_0024lowestQ_00241494 = _0024self__00241500.firstItemSelected.q;
								_0024newItem_00241490 = new Item(_0024newID_00241491, _0024self__00241500.firstItemSelected.q, new int[4], 0f, null);
								inventory[_0024self__00241500.secondItemSelectedSlot] = _0024newItem_00241490;
								inventory[_0024self__00241500.firstItemSelectedSlot] = _0024self__00241500.EmptyItem();
								_0024self__00241500.ResetCraft();
								_0024self__00241500.RefreshInventory();
								_0024self__00241500.RefreshActionBar();
							}
							else if (_0024self__00241500.secondItemSelected.q < _0024self__00241500.firstItemSelected.q)
							{
								_0024lowestQ_00241494 = _0024self__00241500.secondItemSelected.q;
								_0024newItem_00241490 = new Item(_0024newID_00241491, _0024self__00241500.secondItemSelected.q, new int[4], 0f, null);
								inventory[_0024self__00241500.secondItemSelectedSlot] = _0024newItem_00241490;
								inventory[_0024self__00241500.firstItemSelectedSlot].q = inventory[_0024self__00241500.firstItemSelectedSlot].q - _0024self__00241500.secondItemSelected.q;
								_0024self__00241500.ResetCraft();
								_0024self__00241500.RefreshInventory();
								_0024self__00241500.RefreshActionBar();
							}
							else if (_0024self__00241500.firstItemSelected.q < _0024self__00241500.secondItemSelected.q)
							{
								_0024lowestQ_00241494 = _0024self__00241500.firstItemSelected.q;
								_0024newItem_00241490 = new Item(_0024newID_00241491, _0024self__00241500.firstItemSelected.q, new int[4], 0f, null);
								inventory[_0024self__00241500.firstItemSelectedSlot] = _0024newItem_00241490;
								inventory[_0024self__00241500.secondItemSelectedSlot].q = inventory[_0024self__00241500.secondItemSelectedSlot].q - _0024self__00241500.firstItemSelected.q;
								_0024self__00241500.ResetCraft();
								_0024self__00241500.RefreshInventory();
								_0024self__00241500.RefreshActionBar();
							}
							if (_0024newID_00241491 >= 52 && _0024newID_00241491 <= 56)
							{
								_0024bArrows_00241495 = new Item(_0024newID_00241491, 4 * _0024lowestQ_00241494, new int[4], 0f, null);
								_0024self__00241500.AddItem(_0024bArrows_00241495);
							}
						}
						else
						{
							_0024tempForge_00241496 = 6f;
							if (MenuScript.curTrait[1] == 5 || MenuScript.curTrait[2] == 5)
							{
								MonoBehaviour.print((object)"+10 luck FORGING GEAR");
								_0024tempForge_00241496 = 12f;
							}
							_0024newItem_00241490 = new Item(_0024newID_00241491, 1, _0024self__00241500.GetGearStats(_0024newID_00241491), _0024self__00241500.GetMaxDurability(_0024newID_00241491), null);
							_0024luckCount_00241497 = Random.Range(0, 100);
							_0024bonusStat_00241498 = default(int);
							_0024num1_00241499 = default(int);
							if (!((float)_0024luckCount_00241497 >= _0024tempForge_00241496 * 0.5f))
							{
								for (_0024i_00241493 = 0; _0024i_00241493 < 4; _0024i_00241493++)
								{
									_0024bonusStat_00241498 = Random.Range(0, 4);
									_0024num1_00241499 = Random.Range(1, 3);
									_0024newItem_00241490.e[_0024bonusStat_00241498] = _0024newItem_00241490.e[_0024bonusStat_00241498] + _0024num1_00241499;
									_0024newItem_00241490.tier = 3;
								}
							}
							else if (!((float)_0024luckCount_00241497 >= _0024tempForge_00241496))
							{
								for (_0024i_00241493 = 0; _0024i_00241493 < 2; _0024i_00241493++)
								{
									_0024bonusStat_00241498 = Random.Range(0, 4);
									_0024num1_00241499 = Random.Range(1, 3);
									_0024newItem_00241490.e[_0024bonusStat_00241498] = _0024newItem_00241490.e[_0024bonusStat_00241498] + _0024num1_00241499;
									_0024newItem_00241490.tier = 2;
								}
							}
							else if (!((float)_0024luckCount_00241497 >= _0024tempForge_00241496 * 2f))
							{
								for (_0024i_00241493 = 0; _0024i_00241493 < 1; _0024i_00241493++)
								{
									_0024bonusStat_00241498 = Random.Range(0, 4);
									_0024num1_00241499 = Random.Range(1, 3);
									_0024newItem_00241490.e[_0024bonusStat_00241498] = _0024newItem_00241490.e[_0024bonusStat_00241498] + _0024num1_00241499;
									_0024newItem_00241490.tier = 1;
								}
							}
							_0024self__00241500.holdingItem = true;
							_0024self__00241500.itemSelected = _0024newItem_00241490;
							_0024self__00241500.firstItemSelected.q = _0024self__00241500.firstItemSelected.q - 1;
							_0024self__00241500.secondItemSelected.q = _0024self__00241500.secondItemSelected.q - 1;
							if (_0024self__00241500.firstItemSelected.q < 1)
							{
								inventory[_0024self__00241500.firstItemSelectedSlot] = _0024self__00241500.EmptyItem();
							}
							if (_0024self__00241500.secondItemSelected.q < 1)
							{
								inventory[_0024self__00241500.secondItemSelectedSlot] = _0024self__00241500.EmptyItem();
							}
							_0024self__00241500.ResetCraft();
							_0024self__00241500.UpdateHoldingItem();
							_0024self__00241500.RefreshInventory();
							_0024self__00241500.RefreshActionBar();
						}
						tempStats[4] = tempStats[4] + 1;
					}
					else
					{
						_0024self__00241500.ResetCraft();
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

		internal GameScript _0024self__00241501;

		public _0024Craft_00241485(GameScript self_)
		{
			_0024self__00241501 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241501);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SelectReward_00241502 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024temp_00241503;

			internal int _0024bonusScore_00241504;

			internal GameObject _0024dd_00241505;

			internal int _0024c_00241506;

			internal GameScript _0024self__00241507;

			public _0024(int c, GameScript self_)
			{
				_0024c_00241506 = c;
				_0024self__00241507 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_010c: Expected O, but got Unknown
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Expected O, but got Unknown
				//IL_0290: Unknown result type (might be due to invalid IL or missing references)
				//IL_029a: Expected O, but got Unknown
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cb: Expected O, but got Unknown
				//IL_0359: Unknown result type (might be due to invalid IL or missing references)
				//IL_0363: Expected O, but got Unknown
				//IL_0430: Unknown result type (might be due to invalid IL or missing references)
				//IL_043a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241507.selectingReward && _0024self__00241507.rewardChest[_0024c_00241506] > 0)
					{
						_0024self__00241507.selectingReward = true;
						_0024temp_00241503 = default(int);
						_0024self__00241507.rewardChestObj[_0024c_00241506].renderer.material = _0024self__00241507.rewOpened;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_047d;
				case 2:
					if (_0024self__00241507.rewardChest[_0024c_00241506] == 999)
					{
						_0024bonusScore_00241504 = _0024self__00241507.GetScoreBonus();
						_0024dd_00241505 = (GameObject)Object.Instantiate(Resources.Load("bonusScore"), _0024self__00241507.rewardChestObj[_0024c_00241506].transform.position, Quaternion.identity);
						_0024dd_00241505.SendMessage("SD", (object)_0024bonusScore_00241504);
						MenuScript.curScore += _0024bonusScore_00241504;
						if (MenuScript.curScore > PlayerPrefs.GetInt("hScore"))
						{
							PlayerPrefs.SetInt("hScore", MenuScript.curScore);
						}
						_0024self__00241507.txtHighScore[0].text = string.Empty + (object)MenuScript.curScore;
						_0024self__00241507.txtHighScore[1].text = string.Empty + (object)MenuScript.curScore;
						_0024self__00241507.rewardChest[_0024c_00241506] = 0;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					}
					else if (_0024self__00241507.rewardChest[_0024c_00241506] > 200)
					{
						_0024temp_00241503 = _0024self__00241507.rewardChest[_0024c_00241506];
						_0024temp_00241503 -= 200;
						((MonoBehaviour)_0024self__00241507).StartCoroutine_Auto(_0024self__00241507.UnlockHat(_0024temp_00241503));
						_0024self__00241507.rewardChest[_0024c_00241506] = 0;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
					}
					else if (_0024self__00241507.rewardChest[_0024c_00241506] > 100)
					{
						_0024temp_00241503 = _0024self__00241507.rewardChest[_0024c_00241506];
						_0024temp_00241503 -= 100;
						((MonoBehaviour)_0024self__00241507).StartCoroutine_Auto(_0024self__00241507.UnlockComp(_0024temp_00241503));
						_0024self__00241507.rewardChest[_0024c_00241506] = 0;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.3f)) ? 1 : 0);
					}
					else
					{
						_0024temp_00241503 = _0024self__00241507.rewardChest[_0024c_00241506];
						if (MenuScript.raceUnlock[_0024temp_00241503 - 1] > 0)
						{
							((MonoBehaviour)_0024self__00241507).StartCoroutine_Auto(_0024self__00241507.UnlockVariant(_0024temp_00241503));
						}
						else
						{
							((MonoBehaviour)_0024self__00241507).StartCoroutine_Auto(_0024self__00241507.UnlockRace(_0024temp_00241503));
						}
						_0024self__00241507.rewardChest[_0024c_00241506] = 0;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.3f)) ? 1 : 0);
					}
					break;
				case 3:
					_0024self__00241507.selectingReward = false;
					_0024self__00241507.rewardChestObj[_0024c_00241506].renderer.material = _0024self__00241507.rewShade;
					_0024self__00241507.RewardShowCheck();
					goto IL_047d;
				case 4:
					_0024self__00241507.selectingReward = false;
					_0024self__00241507.rewardChestObj[_0024c_00241506].renderer.material = _0024self__00241507.rewShade;
					_0024self__00241507.RewardShowCheck();
					goto IL_047d;
				case 5:
					_0024self__00241507.selectingReward = false;
					_0024self__00241507.rewardChestObj[_0024c_00241506].renderer.material = _0024self__00241507.rewShade;
					_0024self__00241507.RewardShowCheck();
					goto IL_047d;
				case 6:
					_0024self__00241507.selectingReward = false;
					_0024self__00241507.rewardChestObj[_0024c_00241506].renderer.material = _0024self__00241507.rewShade;
					_0024self__00241507.RewardShowCheck();
					goto IL_047d;
				case 1:
					{
						result = 0;
						break;
					}
					IL_047d:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024c_00241508;

		internal GameScript _0024self__00241509;

		public _0024SelectReward_00241502(int c, GameScript self_)
		{
			_0024c_00241508 = c;
			_0024self__00241509 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024c_00241508, _0024self__00241509);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockHat_00241510 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024h_00241511;

			internal GameScript _0024self__00241512;

			public _0024(int h, GameScript self_)
			{
				_0024h_00241511 = h;
				_0024self__00241512 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Expected O, but got Unknown
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241512.txtRewardTop[0].text = "NEW HAT UNLOCKED!";
					_0024self__00241512.rewardIcon.renderer.material = (Material)Resources.Load("hat/hat" + (object)_0024h_00241511);
					PlayerPrefs.SetInt("hU" + (object)_0024h_00241511, 1);
					MenuScript.hatUnlock[_0024h_00241511] = 2;
					_0024self__00241512.txtRewardBot[0].text = string.Empty + _0024self__00241512.GetHatName(_0024h_00241511);
					_0024self__00241512.txtRewardTop[1].text = _0024self__00241512.txtRewardTop[0].text;
					_0024self__00241512.txtRewardBot[1].text = _0024self__00241512.txtRewardBot[0].text;
					_0024self__00241512.rewardShade.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241512.rewardTop.SetActive(true);
					_0024self__00241512.rewardBot.SetActive(true);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024h_00241513;

		internal GameScript _0024self__00241514;

		public _0024UnlockHat_00241510(int h, GameScript self_)
		{
			_0024h_00241513 = h;
			_0024self__00241514 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024h_00241513, _0024self__00241514);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockComp_00241515 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024h_00241516;

			internal GameScript _0024self__00241517;

			public _0024(int h, GameScript self_)
			{
				_0024h_00241516 = h;
				_0024self__00241517 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Expected O, but got Unknown
				//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0106: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241517.txtRewardTop[0].text = "NEW COMPANION UNLOCKED!";
					_0024self__00241517.rewardIcon.renderer.material = (Material)Resources.Load("iComp/comp" + (object)_0024h_00241516);
					MenuScript.compUnlock[_0024h_00241516] = 2;
					_0024self__00241517.txtRewardBot[0].text = string.Empty + _0024self__00241517.GetCompName(_0024h_00241516);
					_0024self__00241517.txtRewardTop[1].text = _0024self__00241517.txtRewardTop[0].text;
					_0024self__00241517.txtRewardBot[1].text = _0024self__00241517.txtRewardBot[0].text;
					_0024self__00241517.rewardShade.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241517.rewardTop.SetActive(true);
					_0024self__00241517.rewardBot.SetActive(true);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024h_00241518;

		internal GameScript _0024self__00241519;

		public _0024UnlockComp_00241515(int h, GameScript self_)
		{
			_0024h_00241518 = h;
			_0024self__00241519 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024h_00241518, _0024self__00241519);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockVariant_00241520 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024r_00241521;

			internal GameScript _0024self__00241522;

			public _0024(int r, GameScript self_)
			{
				_0024r_00241521 = r;
				_0024self__00241522 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Expected O, but got Unknown
				//IL_0181: Unknown result type (might be due to invalid IL or missing references)
				//IL_018b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					MenuScript.raceUnlock[_0024r_00241521 - 1] = MenuScript.raceUnlock[_0024r_00241521 - 1] + 1;
					PlayerPrefs.SetInt("rU" + (object)(_0024r_00241521 - 1), MenuScript.raceUnlock[_0024r_00241521 - 1]);
					_0024self__00241522.txtRewardTop[0].text = "NEW VARIANT UNLOCKED!";
					_0024self__00241522.rewardIcon.renderer.material = (Material)Resources.Load("r/r" + (object)(_0024r_00241521 - 1) + "h" + (object)(MenuScript.raceUnlock[_0024r_00241521 - 1] - 1));
					_0024self__00241522.txtRewardBot[0].text = string.Empty + _0024self__00241522.GetRaceName(_0024r_00241521 - 1) + " Variant " + (object)MenuScript.raceUnlock[_0024r_00241521 - 1];
					_0024self__00241522.txtRewardTop[1].text = _0024self__00241522.txtRewardTop[0].text;
					_0024self__00241522.txtRewardBot[1].text = _0024self__00241522.txtRewardBot[0].text;
					_0024self__00241522.rewardShade.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241522.rewardTop.SetActive(true);
					_0024self__00241522.rewardBot.SetActive(true);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024r_00241523;

		internal GameScript _0024self__00241524;

		public _0024UnlockVariant_00241520(int r, GameScript self_)
		{
			_0024r_00241523 = r;
			_0024self__00241524 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024r_00241523, _0024self__00241524);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockRace_00241525 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024h_00241526;

			internal GameScript _0024self__00241527;

			public _0024(int h, GameScript self_)
			{
				_0024h_00241526 = h;
				_0024self__00241527 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Expected O, but got Unknown
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_0133: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241527.txtRewardTop[0].text = "NEW RACE UNLOCKED!";
					_0024self__00241527.rewardIcon.renderer.material = (Material)Resources.Load("r/r" + (object)(_0024h_00241526 - 1) + "h0");
					MenuScript.raceUnlock[_0024h_00241526 - 1] = 1;
					PlayerPrefs.SetInt("rU" + (object)(_0024h_00241526 - 1), 1);
					_0024self__00241527.txtRewardBot[0].text = string.Empty + _0024self__00241527.GetRaceName(_0024h_00241526 - 1);
					_0024self__00241527.txtRewardTop[1].text = _0024self__00241527.txtRewardTop[0].text;
					_0024self__00241527.txtRewardBot[1].text = _0024self__00241527.txtRewardBot[0].text;
					_0024self__00241527.rewardShade.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241527.rewardTop.SetActive(true);
					_0024self__00241527.rewardBot.SetActive(true);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024h_00241528;

		internal GameScript _0024self__00241529;

		public _0024UnlockRace_00241525(int h, GameScript self_)
		{
			_0024h_00241528 = h;
			_0024self__00241529 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024h_00241528, _0024self__00241529);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Menuu_00241530 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241531;

			public _0024(GameScript self_)
			{
				_0024self__00241531 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (Network.connections.Length == 0)
					{
						Time.timeScale = 1f;
					}
					_0024self__00241531.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241531.DeleteCharacter();
					_0024self__00241531.DeleteInventory();
					isInitialized = false;
					if (_0024self__00241531.dead)
					{
						_0024self__00241531.DeleteCharacter();
					}
					if (Network.isClient)
					{
						Network.Disconnect();
					}
					else if (Network.isServer)
					{
						Network.Disconnect();
						MasterServer.UnregisterHost();
					}
					isReturning = false;
					isInstance = false;
					isTown = false;
					changingScene = false;
					_0024self__00241531.SaveInventory();
					Application.LoadLevel(0);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241532;

		public _0024Menuu_00241530(GameScript self_)
		{
			_0024self__00241532 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241532);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AgainN_00241533 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241534;

			public _0024(GameScript self_)
			{
				_0024self__00241534 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241534.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					PlayerTriggerScript.canTakeDamage = true;
					playersDead = 0;
					_0024self__00241534.DeleteCharacter();
					_0024self__00241534.DeleteInventory();
					isInitialized = false;
					isReturning = false;
					isInstance = false;
					changingScene = false;
					_0024self__00241534.SaveInventory();
					if (_0024self__00241534.dead)
					{
						_0024self__00241534.DeleteCharacter();
					}
					_0024self__00241534.dead = false;
					Application.LoadLevel(1);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241535;

		public _0024AgainN_00241533(GameScript self_)
		{
			_0024self__00241535 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241535);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ThrowPoison_00241536 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024r_00241537;

			internal GameScript _0024self__00241538;

			public _0024(GameScript self_)
			{
				_0024self__00241538 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Expected O, but got Unknown
				//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Expected O, but got Unknown
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Expected O, but got Unknown
				//IL_013d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_015d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024r_00241537 = null;
					if (MenuScript.multiplayer > 0)
					{
						_0024self__00241538.usingPot = true;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_016e;
				case 2:
					if (facingLeft)
					{
						_0024r_00241537 = (GameObject)Network.Instantiate(Resources.Load("poisonL"), player.transform.position, Quaternion.identity, 1);
					}
					else
					{
						_0024r_00241537 = (GameObject)Network.Instantiate(Resources.Load("poisonR"), player.transform.position, Quaternion.identity, 1);
					}
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024r_00241537.SendMessage("Set", (object)player.transform.position);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241538.usingPot = false;
					goto IL_016e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_016e:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241539;

		public _0024ThrowPoison_00241536(GameScript self_)
		{
			_0024self__00241539 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241539);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ThrowDagger_00241540 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector2 _0024v_00241541;

			internal GameObject _0024ar_00241542;

			internal Vector2 _0024v2_00241543;

			internal Vector3 _0024object_pos_00241544;

			internal Vector3 _0024mouse_pos_00241545;

			internal float _0024angle_00241546;

			internal int _0024a_00241547;

			internal GameScript _0024self__00241548;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241547 = a;
				_0024self__00241548 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Expected O, but got Unknown
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_0188: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0198: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a2: Expected O, but got Unknown
				//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e2: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241548.usingPot = true;
					_0024v_00241541 = default(Vector2);
					_0024ar_00241542 = null;
					_0024v2_00241543 = Vector2.op_Implicit(player.transform.position);
					_0024object_pos_00241544 = default(Vector3);
					_0024mouse_pos_00241545 = default(Vector3);
					_0024angle_00241546 = default(float);
					player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024mouse_pos_00241545 = Input.mousePosition;
					_0024object_pos_00241544 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos_00241545.z = -20f;
					_0024mouse_pos_00241545.x -= _0024object_pos_00241544.x;
					_0024mouse_pos_00241545.y -= _0024object_pos_00241544.y;
					_0024angle_00241546 = Mathf.Atan2(_0024mouse_pos_00241545.y, _0024mouse_pos_00241545.x) * 57.29578f;
					_0024ar_00241542 = (GameObject)Network.Instantiate(Resources.Load("skill/dagger" + (object)_0024a_00241547), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241546)), 0);
					_0024ar_00241542.networkView.RPC("SetN", (RPCMode)2, new object[1] { DEX + DEXBonus });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241548.usingPot = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241549;

		internal GameScript _0024self__00241550;

		public _0024ThrowDagger_00241540(int a, GameScript self_)
		{
			_0024a_00241549 = a;
			_0024self__00241550 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241549, _0024self__00241550);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ThrowRock_00241551 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024r_00241552;

			internal GameScript _0024self__00241553;

			public _0024(GameScript self_)
			{
				_0024self__00241553 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Expected O, but got Unknown
				//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Expected O, but got Unknown
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Expected O, but got Unknown
				//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_010a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0114: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024r_00241552 = null;
					if (MenuScript.multiplayer > 0)
					{
						_0024self__00241553.usingPot = true;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0125;
				case 2:
					if (facingLeft)
					{
						_0024r_00241552 = (GameObject)Network.Instantiate(Resources.Load("stoneL"), player.transform.position, Quaternion.identity, 1);
					}
					else
					{
						_0024r_00241552 = (GameObject)Network.Instantiate(Resources.Load("stoneR"), player.transform.position, Quaternion.identity, 1);
					}
					_0024r_00241552.SendMessage("Set", (object)player.transform.position);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241553.usingPot = false;
					goto IL_0125;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0125:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241554;

		public _0024ThrowRock_00241551(GameScript self_)
		{
			_0024self__00241554 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241554);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseHPPotion_00241555 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024pot_00241556;

			internal int _0024heal_00241557;

			internal GameScript _0024self__00241558;

			public _0024(int heal, GameScript self_)
			{
				_0024heal_00241557 = heal;
				_0024self__00241558 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bf: Expected O, but got Unknown
				//IL_0196: Unknown result type (might be due to invalid IL or missing references)
				//IL_019b: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01af: Expected O, but got Unknown
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Expected O, but got Unknown
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_0170: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0 && HP != MAXHP && !_0024self__00241558.usingPot)
					{
						_0024self__00241558.usingPot = true;
						potsUsed++;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_01ca;
				case 2:
					((Component)_0024self__00241558).audio.PlayOneShot((AudioClip)Resources.Load("Au/drink", typeof(AudioClip)));
					if (HP + _0024heal_00241557 > MAXHP)
					{
						HP = MAXHP;
					}
					else
					{
						HP += _0024heal_00241557;
					}
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024self__00241558.RefreshActionBar();
					_0024self__00241558.UpdateCharacterWeapon();
					_0024self__00241558.LoadHearts();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241558.usingPot = false;
					_0024pot_00241556 = (GameObject)Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
					_0024pot_00241556.SendMessage("SD", (object)_0024heal_00241557);
					goto IL_01ca;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01ca:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024heal_00241559;

		internal GameScript _0024self__00241560;

		public _0024UseHPPotion_00241555(int heal, GameScript self_)
		{
			_0024heal_00241559 = heal;
			_0024self__00241560 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024heal_00241559, _0024self__00241560);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseManaPotion_00241561 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024pot_00241562;

			internal int _0024heal_00241563;

			internal GameScript _0024self__00241564;

			public _0024(int heal, GameScript self_)
			{
				_0024heal_00241563 = heal;
				_0024self__00241564 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Expected O, but got Unknown
				//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01af: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Expected O, but got Unknown
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0085: Expected O, but got Unknown
				//IL_0170: Unknown result type (might be due to invalid IL or missing references)
				//IL_017a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0 && MAG != MAXMAG && !_0024self__00241564.usingPot)
					{
						_0024self__00241564.usingPot = true;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_018b;
				case 2:
					((Component)_0024self__00241564).audio.PlayOneShot((AudioClip)Resources.Load("Au/drink", typeof(AudioClip)));
					if (MAG + _0024heal_00241563 > MAXMAG)
					{
						MAG = MAXMAG;
					}
					else
					{
						MAG += _0024heal_00241563;
					}
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024self__00241564.UpdateCharacterWeapon();
					_0024self__00241564.RefreshActionBar();
					_0024self__00241564.GUImana.animation.Play();
					_0024self__00241564.LoadMana();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241564.usingPot = false;
					goto IL_018b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_018b:
					_0024pot_00241562 = (GameObject)Object.Instantiate(Resources.Load("healMana"), player.transform.position, Quaternion.identity);
					_0024pot_00241562.SendMessage("SD", (object)_0024heal_00241563);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024heal_00241565;

		internal GameScript _0024self__00241566;

		public _0024UseManaPotion_00241561(int heal, GameScript self_)
		{
			_0024heal_00241565 = heal;
			_0024self__00241566 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024heal_00241565, _0024self__00241566);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseItem_00241567 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024switch_0024235_00241568;

			internal GameObject _0024it_00241569;

			internal Item _0024item_00241570;

			internal int _0024dood_00241571;

			internal GameObject _0024pot22_00241572;

			internal GameObject _0024it2_00241573;

			internal Item _0024item2_00241574;

			internal int _0024dood1_00241575;

			internal GameObject _0024pot223_00241576;

			internal int _0024nn_00241577;

			internal int _0024nn2_00241578;

			internal Vector2 _0024v1_00241579;

			internal GameObject _0024ar1_00241580;

			internal Vector2 _0024v21_00241581;

			internal Vector3 _0024object_pos1_00241582;

			internal Vector3 _0024mouse_pos1_00241583;

			internal float _0024angle1_00241584;

			internal Vector2 _0024v_00241585;

			internal GameObject _0024ar_00241586;

			internal Vector2 _0024v2_00241587;

			internal Vector3 _0024object_pos_00241588;

			internal Vector3 _0024mouse_pos_00241589;

			internal float _0024angle_00241590;

			internal GameObject _0024f_00241591;

			internal int _0024noo_00241592;

			internal int _0024noo1_00241593;

			internal GameObject _0024bo_00241594;

			internal int _0024slot_00241595;

			internal GameScript _0024self__00241596;

			public _0024(int slot, GameScript self_)
			{
				_0024slot_00241595 = slot;
				_0024self__00241596 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0220: Unknown result type (might be due to invalid IL or missing references)
				//IL_022a: Expected O, but got Unknown
				//IL_0327: Unknown result type (might be due to invalid IL or missing references)
				//IL_0331: Expected O, but got Unknown
				//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cba: Expected O, but got Unknown
				//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f1e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f3d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fe7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ffb: Unknown result type (might be due to invalid IL or missing references)
				//IL_1006: Unknown result type (might be due to invalid IL or missing references)
				//IL_1010: Expected O, but got Unknown
				//IL_14c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_14cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_14d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_14e2: Expected O, but got Unknown
				//IL_13c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_13c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_13d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_13dd: Expected O, but got Unknown
				//IL_138f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1394: Unknown result type (might be due to invalid IL or missing references)
				//IL_139f: Unknown result type (might be due to invalid IL or missing references)
				//IL_13a9: Expected O, but got Unknown
				//IL_1551: Unknown result type (might be due to invalid IL or missing references)
				//IL_155b: Expected O, but got Unknown
				//IL_0385: Unknown result type (might be due to invalid IL or missing references)
				//IL_038a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0394: Unknown result type (might be due to invalid IL or missing references)
				//IL_039e: Expected O, but got Unknown
				//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_06f1: Expected O, but got Unknown
				//IL_10ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_10fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_1103: Unknown result type (might be due to invalid IL or missing references)
				//IL_110e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1118: Expected O, but got Unknown
				//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0303: Expected O, but got Unknown
				//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fc: Expected O, but got Unknown
				//IL_0122: Unknown result type (might be due to invalid IL or missing references)
				//IL_0127: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Expected O, but got Unknown
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f2: Expected O, but got Unknown
				//IL_1208: Unknown result type (might be due to invalid IL or missing references)
				//IL_1217: Unknown result type (might be due to invalid IL or missing references)
				//IL_121c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1227: Unknown result type (might be due to invalid IL or missing references)
				//IL_1231: Expected O, but got Unknown
				//IL_0675: Unknown result type (might be due to invalid IL or missing references)
				//IL_067f: Expected O, but got Unknown
				//IL_0596: Unknown result type (might be due to invalid IL or missing references)
				//IL_05a0: Expected O, but got Unknown
				//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_04db: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ef: Expected O, but got Unknown
				//IL_048c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0491: Unknown result type (might be due to invalid IL or missing references)
				//IL_049c: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a6: Expected O, but got Unknown
				//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0abc: Expected O, but got Unknown
				//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a61: Expected O, but got Unknown
				//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d44: Expected O, but got Unknown
				//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bd4: Expected O, but got Unknown
				//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dd3: Expected O, but got Unknown
				//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e95: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f13: Expected O, but got Unknown
				//IL_1361: Unknown result type (might be due to invalid IL or missing references)
				//IL_136b: Expected O, but got Unknown
				//IL_14a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_14ae: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241596.@using && HP > 0)
					{
						_0024self__00241596.@using = true;
						_0024_0024switch_0024235_00241568 = inventory[_0024slot_00241595].id;
						if (_0024_0024switch_0024235_00241568 == 7)
						{
							if (isCooking)
							{
								_0024it_00241569 = null;
								_0024item_00241570 = new Item(8, 1, new int[4], 0f, null);
								if (MenuScript.multiplayer > 0)
								{
									_0024it_00241569 = (GameObject)Network.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity, 1);
									_0024it_00241569.SendMessage("Set", (object)_0024item_00241570);
								}
								else
								{
									_0024it_00241569 = (GameObject)Object.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity);
									_0024it_00241569.SendMessage("Set", (object)_0024item_00241570);
								}
								tempStats[8] = tempStats[8] + 1;
								inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
								if (inventory[_0024slot_00241595].q < 1)
								{
									inventory[_0024slot_00241595].id = 0;
								}
							}
							else if (hunger < _0024self__00241596.maxHunger)
							{
								player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024235_00241568 == 8)
						{
							if (hunger < _0024self__00241596.maxHunger)
							{
								player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024235_00241568 == 21)
						{
							if (isCooking)
							{
								_0024it2_00241573 = null;
								_0024item2_00241574 = new Item(22, 1, new int[4], 0f, null);
								if (MenuScript.multiplayer > 0)
								{
									_0024it2_00241573 = (GameObject)Network.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity, 1);
									_0024it2_00241573.SendMessage("Set", (object)_0024item2_00241574);
								}
								else
								{
									_0024it2_00241573 = (GameObject)Object.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity);
									_0024it2_00241573.SendMessage("Set", (object)_0024item2_00241574);
								}
								inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
								if (inventory[_0024slot_00241595].q < 1)
								{
									inventory[_0024slot_00241595].id = 0;
								}
							}
							else if (hunger < _0024self__00241596.maxHunger)
							{
								player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024235_00241568 == 22)
						{
							if (hunger < _0024self__00241596.maxHunger)
							{
								player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024235_00241568 != 49)
						{
							if (_0024_0024switch_0024235_00241568 == 15)
							{
								((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.UseHPPotion(2));
							}
							else if (_0024_0024switch_0024235_00241568 == 16)
							{
								((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.UseManaPotion(3));
							}
							else if (_0024_0024switch_0024235_00241568 == 17)
							{
								((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.ThrowPoison());
							}
							else if (_0024_0024switch_0024235_00241568 == 38)
							{
								((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.ThrowRock());
								inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
								if (inventory[_0024slot_00241595].q < 1)
								{
									inventory[_0024slot_00241595].id = 0;
								}
							}
							else if (_0024_0024switch_0024235_00241568 == 42)
							{
								((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.UseHPPotion(5));
							}
							else if (_0024_0024switch_0024235_00241568 == 43)
							{
								((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.UseManaPotion(7));
							}
							else if (_0024_0024switch_0024235_00241568 == 44)
							{
								_0024nn_00241577 = Random.Range(15, 18);
								if (!_0024self__00241596.usingPot)
								{
									if (_0024nn_00241577 == 15)
									{
										((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.UseHPPotion(2));
									}
									else if (_0024nn_00241577 == 16)
									{
										((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.UseManaPotion(3));
									}
									else
									{
										((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.ThrowPoison());
									}
								}
							}
							else if (_0024_0024switch_0024235_00241568 == 45)
							{
								_0024nn2_00241578 = Random.Range(15, 18);
								if (!_0024self__00241596.usingPot)
								{
									if (_0024nn2_00241578 == 15)
									{
										((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.UseHPPotion(4));
									}
									else if (_0024nn2_00241578 == 16)
									{
										((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.UseManaPotion(7));
									}
									else
									{
										((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.ThrowPoison());
									}
								}
							}
							else if (_0024_0024switch_0024235_00241568 == 46)
							{
								_0024self__00241596.UseKey();
							}
							else
							{
								if (_0024_0024switch_0024235_00241568 == 48)
								{
									if (MenuScript.multiplayer > 0)
									{
										result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.5f)) ? 1 : 0);
										break;
									}
									_0024self__00241596.@base.animation.Play("a1");
									result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(0.5f)) ? 1 : 0);
									break;
								}
								if (_0024_0024switch_0024235_00241568 == 61)
								{
									_0024v1_00241579 = default(Vector2);
									_0024ar1_00241580 = null;
									_0024v21_00241581 = Vector2.op_Implicit(player.transform.position);
									_0024object_pos1_00241582 = default(Vector3);
									_0024mouse_pos1_00241583 = default(Vector3);
									_0024angle1_00241584 = default(float);
									if (MenuScript.multiplayer > 0)
									{
										player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a4" });
										result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(0.3f)) ? 1 : 0);
										break;
									}
								}
								else
								{
									if (_0024_0024switch_0024235_00241568 == 71)
									{
										((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.ThrowDagger(71));
										result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(9, new WaitForSeconds(0.2f)) ? 1 : 0);
										break;
									}
									if (_0024_0024switch_0024235_00241568 == 72)
									{
										((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.ThrowDagger(72));
										result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(10, new WaitForSeconds(0.2f)) ? 1 : 0);
										break;
									}
									if (_0024_0024switch_0024235_00241568 == 515)
									{
										if (inventory[23].id >= 52 && inventory[23].id <= 56)
										{
											_0024v_00241585 = default(Vector2);
											_0024ar_00241586 = null;
											_0024v2_00241587 = Vector2.op_Implicit(player.transform.position);
											_0024object_pos_00241588 = default(Vector3);
											_0024mouse_pos_00241589 = default(Vector3);
											_0024angle_00241590 = default(float);
											arrowsShot++;
											if (arrowsShot >= 100)
											{
												MenuScript.canUnlockHat[4] = 1;
											}
											if (MenuScript.multiplayer > 0)
											{
												player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a4" });
												result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(11, new WaitForSeconds(0.3f)) ? 1 : 0);
												break;
											}
										}
									}
									else if (_0024_0024switch_0024235_00241568 == 600)
									{
										if (MAG >= 1)
										{
											_0024f_00241591 = null;
											if (MenuScript.pHat == 11)
											{
												_0024noo_00241592 = Random.Range(0, 1);
												if (_0024noo_00241592 == 0)
												{
													_0024self__00241596.UseMana(1);
												}
											}
											else
											{
												_0024self__00241596.UseMana(1);
											}
											if (MenuScript.multiplayer > 0)
											{
												player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a3" });
												result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(12, new WaitForSeconds(0.3f)) ? 1 : 0);
												break;
											}
											goto IL_13f7;
										}
									}
									else if (_0024_0024switch_0024235_00241568 == 601)
									{
										if (MAG >= 1)
										{
											if (MenuScript.pHat == 11)
											{
												_0024noo1_00241593 = Random.Range(0, 1);
												if (_0024noo1_00241593 == 0)
												{
													_0024self__00241596.UseMana(1);
												}
											}
											else
											{
												_0024self__00241596.UseMana(1);
											}
											if (MenuScript.multiplayer > 0)
											{
												player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
												result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(13, new WaitForSeconds(0.5f)) ? 1 : 0);
												break;
											}
											goto IL_14fc;
										}
									}
									else
									{
										((MonoBehaviour)_0024self__00241596).StartCoroutine_Auto(_0024self__00241596.MeleeAttack());
									}
								}
							}
						}
						goto IL_1533;
					}
					goto IL_156c;
				case 2:
					((Component)_0024self__00241596).audio.PlayOneShot((AudioClip)Resources.Load("Au/eat", typeof(AudioClip)));
					hunger++;
					_0024self__00241596.UpdateHunger();
					_0024self__00241596.Poop();
					tempStats[8] = tempStats[8] + 1;
					inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
					if (inventory[_0024slot_00241595].q < 1)
					{
						inventory[_0024slot_00241595].id = 0;
					}
					goto IL_1533;
				case 3:
					((Component)_0024self__00241596).audio.PlayOneShot((AudioClip)Resources.Load("Au/eat", typeof(AudioClip)));
					hunger += 3;
					_0024dood_00241571 = Random.Range(0, 2);
					if (_0024dood_00241571 == 0 && HP < MAXHP)
					{
						HP++;
						_0024pot22_00241572 = (GameObject)Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
						_0024pot22_00241572.SendMessage("SD", (object)1);
						_0024self__00241596.LoadHearts();
					}
					tempStats[8] = tempStats[8] + 1;
					_0024self__00241596.UpdateHunger();
					_0024self__00241596.Poop();
					inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
					if (inventory[_0024slot_00241595].q < 1)
					{
						inventory[_0024slot_00241595].id = 0;
					}
					goto IL_1533;
				case 4:
					tempStats[8] = tempStats[8] + 1;
					hunger++;
					_0024self__00241596.UpdateHunger();
					_0024self__00241596.Poop();
					inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
					if (inventory[_0024slot_00241595].q < 1)
					{
						inventory[_0024slot_00241595].id = 0;
					}
					goto IL_1533;
				case 5:
					hunger += 4;
					_0024dood1_00241575 = Random.Range(0, 2);
					if (_0024dood1_00241575 == 0 && HP < MAXHP)
					{
						HP++;
						_0024pot223_00241576 = (GameObject)Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
						_0024pot223_00241576.SendMessage("SD", (object)1);
						_0024self__00241596.LoadHearts();
					}
					tempStats[8] = tempStats[8] + 1;
					_0024self__00241596.UpdateHunger();
					_0024self__00241596.Poop();
					inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
					if (inventory[_0024slot_00241595].q < 1)
					{
						inventory[_0024slot_00241595].id = 0;
					}
					goto IL_1533;
				case 6:
					Network.Instantiate(Resources.Load("interact/fire"), player.transform.position, Quaternion.identity, 1);
					goto IL_0ae5;
				case 7:
					Object.Instantiate(Resources.Load("interact/fire"), player.transform.position, Quaternion.identity);
					goto IL_0ae5;
				case 8:
					_0024mouse_pos1_00241583 = Input.mousePosition;
					_0024object_pos1_00241582 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos1_00241583.z = -20f;
					_0024mouse_pos1_00241583.x -= _0024object_pos1_00241582.x;
					_0024mouse_pos1_00241583.y -= _0024object_pos1_00241582.y;
					_0024angle1_00241584 = Mathf.Atan2(_0024mouse_pos1_00241583.y, _0024mouse_pos1_00241583.x) * 57.29578f;
					_0024ar1_00241580 = (GameObject)Network.Instantiate(Resources.Load("skill/lightBlast"), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle1_00241584)), 0);
					inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
					if (inventory[_0024slot_00241595].q < 1)
					{
						inventory[_0024slot_00241595].id = 0;
					}
					goto IL_1533;
				case 9:
					inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
					if (inventory[_0024slot_00241595].q < 1)
					{
						inventory[_0024slot_00241595].id = 0;
					}
					goto IL_1533;
				case 10:
					inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
					if (inventory[_0024slot_00241595].q < 1)
					{
						inventory[_0024slot_00241595].id = 0;
					}
					goto IL_1533;
				case 11:
					_0024mouse_pos_00241589 = Input.mousePosition;
					_0024object_pos_00241588 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos_00241589.z = -20f;
					_0024mouse_pos_00241589.x -= _0024object_pos_00241588.x;
					_0024mouse_pos_00241589.y -= _0024object_pos_00241588.y;
					_0024angle_00241590 = Mathf.Atan2(_0024mouse_pos_00241589.y, _0024mouse_pos_00241589.x) * 57.29578f;
					_0024ar_00241586 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + (object)inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241590)), 0);
					_0024ar_00241586.networkView.RPC("SetN", (RPCMode)2, new object[1] { DEX + DEXBonus });
					inventory[23].q = inventory[23].q - 1;
					if (inventory[23].q <= 0)
					{
						inventory[23] = _0024self__00241596.EmptyItem();
					}
					if (multishot)
					{
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle_00241590 -= 10f;
							_0024ar_00241586 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + (object)inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241590)), 0);
							_0024ar_00241586.networkView.RPC("SetN", (RPCMode)2, new object[1] { DEX + DEXBonus });
							_0024ar_00241586.networkView.RPC("SetMulti", (RPCMode)2, new object[0]);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241596.EmptyItem();
							}
						}
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle_00241590 += 20f;
							_0024ar_00241586 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + (object)inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241590)), 0);
							_0024ar_00241586.networkView.RPC("SetN", (RPCMode)2, new object[1] { DEX + DEXBonus });
							_0024ar_00241586.networkView.RPC("SetMulti", (RPCMode)2, new object[0]);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241596.EmptyItem();
							}
						}
						multishot = false;
					}
					goto IL_1533;
				case 12:
					if (facingLeft)
					{
						_0024f_00241591 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballL"), player.transform.position, Quaternion.identity, 0);
					}
					else
					{
						_0024f_00241591 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballR"), player.transform.position, Quaternion.identity, 0);
					}
					_0024f_00241591.SendMessage("Set", (object)MAXMAG);
					goto IL_13f7;
				case 13:
					_0024bo_00241594 = (GameObject)Network.Instantiate(Resources.Load("proj/bolt"), player.transform.position, Quaternion.identity, 0);
					_0024bo_00241594.SendMessage("Set", (object)MAXMAG);
					goto IL_14fc;
				case 14:
					_0024self__00241596.@using = false;
					goto IL_156c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_13f7:
					_0024self__00241596.GUImana.animation.Play();
					goto IL_1533;
					IL_1533:
					_0024self__00241596.RefreshActionBar();
					_0024self__00241596.UpdateCharacterWeapon();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(14, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
					IL_0ae5:
					inventory[_0024slot_00241595].q = inventory[_0024slot_00241595].q - 1;
					if (inventory[_0024slot_00241595].q < 1)
					{
						inventory[_0024slot_00241595].id = 0;
					}
					goto IL_1533;
					IL_156c:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
					IL_14fc:
					_0024self__00241596.GUImana.animation.Play();
					goto IL_1533;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024slot_00241597;

		internal GameScript _0024self__00241598;

		public _0024UseItem_00241567(int slot, GameScript self_)
		{
			_0024slot_00241597 = slot;
			_0024self__00241598 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024slot_00241597, _0024self__00241598);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MeleeAttack_00241599 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024temp_00241600;

			internal int _0024id_00241601;

			internal GameObject _0024gg_00241602;

			internal GameObject _0024f_00241603;

			internal GameScript _0024self__00241604;

			public _0024(GameScript self_)
			{
				_0024self__00241604 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0277: Unknown result type (might be due to invalid IL or missing references)
				//IL_0281: Expected O, but got Unknown
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected O, but got Unknown
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Unknown result type (might be due to invalid IL or missing references)
				//IL_016a: Unknown result type (might be due to invalid IL or missing references)
				//IL_016f: Unknown result type (might be due to invalid IL or missing references)
				//IL_017a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0184: Expected O, but got Unknown
				//IL_023a: Unknown result type (might be due to invalid IL or missing references)
				//IL_023f: Unknown result type (might be due to invalid IL or missing references)
				//IL_024a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0254: Expected O, but got Unknown
				//IL_0206: Unknown result type (might be due to invalid IL or missing references)
				//IL_020b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0216: Unknown result type (might be due to invalid IL or missing references)
				//IL_0220: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024temp_00241600 = default(float);
					if (_0024self__00241604.canAttack && HP > 0 && MenuScript.multiplayer > 0)
					{
						_0024self__00241604.ATKING = true;
						attacking = true;
						_0024self__00241604.canAttack = false;
						_0024self__00241604.@using = true;
						_0024temp_00241600 = SPD;
						SPD *= 0.5f;
						PlayerController.mode = 3;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { _0024self__00241604.atkAnim });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00241604.atkWait)) ? 1 : 0);
						break;
					}
					goto IL_02c6;
				case 2:
					PlayerControllerN.aCube.SetActive(true);
					_0024id_00241601 = inventory[curActiveSlot].id;
					if (MenuScript.pHat == 8 && _0024id_00241601 == 0 && MAG >= 1)
					{
						_0024self__00241604.UseMana(1);
						_0024gg_00241602 = (GameObject)Network.Instantiate(Resources.Load("rckP"), new Vector3(PlayerControllerN.aCube.transform.position.x, player.transform.position.y + 35f, 0f), Quaternion.identity, 0);
						_0024gg_00241602.networkView.RPC("SetH", (RPCMode)2, new object[1] { MAXMAG });
					}
					else if (MenuScript.pHat == 16 && _0024id_00241601 == 0 && MAG >= 1)
					{
						_0024self__00241604.UseMana(1);
						_0024f_00241603 = null;
						if (facingLeft)
						{
							_0024f_00241603 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballL"), player.transform.position, Quaternion.identity, 0);
						}
						else
						{
							_0024f_00241603 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballR"), player.transform.position, Quaternion.identity, 0);
						}
						_0024f_00241603.SendMessage("Set", (object)(MAXMAG * 2));
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 3:
					PlayerControllerN.aCube.SetActive(false);
					SPD = _0024temp_00241600;
					_0024self__00241604.canAttack = true;
					_0024self__00241604.@using = false;
					attacking = false;
					_0024self__00241604.ATKING = false;
					goto IL_02c6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02c6:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241605;

		public _0024MeleeAttack_00241599(GameScript self_)
		{
			_0024self__00241605 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241605);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockBack_00241606 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024585_00241607;

			internal Vector3 _0024_0024586_00241608;

			internal int _0024_0024587_00241609;

			internal Vector3 _0024_0024588_00241610;

			internal int _0024_0024589_00241611;

			internal Vector3 _0024_0024590_00241612;

			internal int _0024_0024591_00241613;

			internal Vector3 _0024_0024592_00241614;

			internal int _0024_0024593_00241615;

			internal Vector3 _0024_0024594_00241616;

			internal Transform _0024h_00241617;

			public _0024(Transform h)
			{
				_0024h_00241617 = h;
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
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0122: Unknown result type (might be due to invalid IL or missing references)
				//IL_0127: Unknown result type (might be due to invalid IL or missing references)
				//IL_014e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_019d: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01de: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0200: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Unknown result type (might be due to invalid IL or missing references)
				//IL_0207: Unknown result type (might be due to invalid IL or missing references)
				//IL_022e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0233: Unknown result type (might be due to invalid IL or missing references)
				//IL_0234: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0165: Unknown result type (might be due to invalid IL or missing references)
				//IL_016f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					int num5 = (_0024_0024585_00241607 = 5);
					Vector3 val7 = (_0024_0024586_00241608 = ((Component)_0024h_00241617).rigidbody.velocity);
					float num6 = (_0024_0024586_00241608.y = _0024_0024585_00241607);
					Vector3 val9 = (((Component)_0024h_00241617).rigidbody.velocity = _0024_0024586_00241608);
					if (_0024h_00241617.position.x <= player.transform.position.x)
					{
						int num7 = (_0024_0024589_00241611 = -15);
						Vector3 val10 = (_0024_0024590_00241612 = ((Component)_0024h_00241617).rigidbody.velocity);
						float num8 = (_0024_0024590_00241612.x = _0024_0024589_00241611);
						Vector3 val12 = (((Component)_0024h_00241617).rigidbody.velocity = _0024_0024590_00241612);
					}
					else
					{
						int num9 = (_0024_0024587_00241609 = 15);
						Vector3 val13 = (_0024_0024588_00241610 = ((Component)_0024h_00241617).rigidbody.velocity);
						float num10 = (_0024_0024588_00241610.x = _0024_0024587_00241609);
						Vector3 val15 = (((Component)_0024h_00241617).rigidbody.velocity = _0024_0024588_00241610);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				}
				case 2:
					if (Object.op_Implicit((Object)(object)_0024h_00241617))
					{
						int num = (_0024_0024591_00241613 = 0);
						Vector3 val = (_0024_0024592_00241614 = ((Component)_0024h_00241617).rigidbody.velocity);
						float num2 = (_0024_0024592_00241614.y = _0024_0024591_00241613);
						Vector3 val3 = (((Component)_0024h_00241617).rigidbody.velocity = _0024_0024592_00241614);
						int num3 = (_0024_0024593_00241615 = 0);
						Vector3 val4 = (_0024_0024594_00241616 = ((Component)_0024h_00241617).rigidbody.velocity);
						float num4 = (_0024_0024594_00241616.x = _0024_0024593_00241615);
						Vector3 val6 = (((Component)_0024h_00241617).rigidbody.velocity = _0024_0024594_00241616);
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

		internal Transform _0024h_00241618;

		public _0024KnockBack_00241606(Transform h)
		{
			_0024h_00241618 = h;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024h_00241618);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00241619 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241620;

			public _0024(GameScript self_)
			{
				_0024self__00241620 = self_;
			}

			public override bool MoveNext()
			{
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Expected O, but got Unknown
				//IL_0137: Unknown result type (might be due to invalid IL or missing references)
				//IL_0141: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					player.SendMessage("TimerSet", (object)timer);
					if (inventoryOpen)
					{
						_0024self__00241620.OpenInventory();
					}
					_0024self__00241620.sSelected.SetActive(false);
					_0024self__00241620.dead = true;
					menuOpen = true;
					_0024self__00241620.menuExit.SetActive(false);
					inventoryOpen = false;
					isInitialized = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (win)
					{
						MenuScript.canUnlockRace[5] = 1;
						MenuScript.canUnlockHat[12] = 1;
						MonoBehaviour.print((object)("POTS USED " + (object)potsUsed));
						if (potsUsed < 1)
						{
							MenuScript.canUnlockRace[8] = 1;
						}
						MonoBehaviour.print((object)("PIGGY : " + (object)MenuScript.canUnlockRace[8]));
						((Component)_0024self__00241620.txtDied).gameObject.SetActive(false);
						_0024self__00241620.menuVictory.SetActive(true);
					}
					_0024self__00241620.ShowTimer();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241620.SaveStats();
					if (Object.op_Implicit((Object)(object)_0024self__00241620.menuStats))
					{
						_0024self__00241620.menuStats.SetActive(true);
					}
					((MonoBehaviour)_0024self__00241620).StartCoroutine_Auto(_0024self__00241620.ShowStats());
					if (Network.isServer)
					{
						_0024self__00241620.bAgain.SetActive(true);
						_0024self__00241620.bMenu.SetActive(true);
					}
					else
					{
						_0024self__00241620.bAgain.SetActive(false);
						_0024self__00241620.bMenu.SetActive(false);
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

		internal GameScript _0024self__00241621;

		public _0024Die_00241619(GameScript self_)
		{
			_0024self__00241621 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241621);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShowStats_00241622 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241623;

			internal GameScript _0024self__00241624;

			public _0024(GameScript self_)
			{
				_0024self__00241624 = self_;
			}

			public override bool MoveNext()
			{
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241623 = default(int);
					_0024self__00241624.txtHighScore[0].text = string.Empty + (object)MenuScript.curScore;
					_0024self__00241624.txtHighScore[1].text = string.Empty + (object)MenuScript.curScore;
					_0024i_00241623 = 1;
					goto IL_00bc;
				case 2:
					_0024i_00241623++;
					goto IL_00bc;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00bc:
					if (_0024i_00241623 < 12)
					{
						((MonoBehaviour)_0024self__00241624).StartCoroutine_Auto(_0024self__00241624.StatShow(_0024i_00241623));
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241625;

		public _0024ShowStats_00241622(GameScript self_)
		{
			_0024self__00241625 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241625);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShowEXP_00241626 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024pLevel_00241627;

			internal float _0024curEXP_00241628;

			internal float _0024cap_00241629;

			internal int _0024i_00241630;

			internal GameScript _0024self__00241631;

			public _0024(GameScript self_)
			{
				_0024self__00241631 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024pLevel_00241627 = _0024self__00241631.GetPlayerLevel();
					_0024curEXP_00241628 = _0024self__00241631.GetCurEXP(_0024pLevel_00241627);
					_0024cap_00241629 = _0024self__00241631.GetLevelCap(_0024pLevel_00241627);
					_0024self__00241631.txtLevelEXP.text = "Level: " + (object)_0024pLevel_00241627;
					_0024i_00241630 = default(int);
					_0024i_00241630 = 0;
					goto IL_019f;
				case 2:
					_0024i_00241630++;
					goto IL_019f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_019f:
					if ((float)_0024i_00241630 < _0024self__00241631.tempEXP)
					{
						_0024curEXP_00241628 += 1f;
						_0024self__00241631.accountEXP++;
						if (!(_0024curEXP_00241628 < _0024cap_00241629))
						{
							_0024pLevel_00241627++;
							_0024self__00241631.expBack2.animation.Play();
							_0024curEXP_00241628 = _0024self__00241631.GetCurEXP(_0024pLevel_00241627);
							_0024cap_00241629 = _0024self__00241631.GetLevelCap(_0024pLevel_00241627);
							_0024self__00241631.txtLevelEXP.text = "Level: " + (object)_0024pLevel_00241627;
						}
						_0024self__00241631.txtPercent.text = (object)_0024curEXP_00241628 + "/" + (object)_0024cap_00241629;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.01f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241632;

		public _0024ShowEXP_00241626(GameScript self_)
		{
			_0024self__00241632 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241632);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024StatShow_00241633 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00241634;

			internal int _0024i_00241635;

			internal int _0024a_00241636;

			internal GameScript _0024self__00241637;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241636 = a;
				_0024self__00241637 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024s_00241634 = _0024self__00241637.GetStatsName(_0024a_00241636);
					_0024i_00241635 = 0;
					_0024self__00241637.statObj[_0024a_00241636].SetActive(true);
					_0024self__00241637.txtStats[_0024a_00241636].text = _0024s_00241634 + ": " + (object)_0024i_00241635;
					_0024i_00241635 = 0;
					goto IL_00eb;
				case 2:
					_0024i_00241635++;
					goto IL_00eb;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00eb:
					if (_0024i_00241635 < tempStats[_0024a_00241636])
					{
						_0024self__00241637.txtStats[_0024a_00241636].text = _0024s_00241634 + ": " + (object)_0024i_00241635;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.01f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241638;

		internal GameScript _0024self__00241639;

		public _0024StatShow_00241633(int a, GameScript self_)
		{
			_0024a_00241638 = a;
			_0024self__00241639 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241638, _0024self__00241639);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AdditionalStat_00241640 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241641;

			internal GameScript _0024self__00241642;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241641 = a;
				_0024self__00241642 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Expected O, but got Unknown
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3.6f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241642.LUP[_0024a_00241641].SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(3.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241642.LUP[_0024a_00241641].SetActive(false);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241643;

		internal GameScript _0024self__00241644;

		public _0024AdditionalStat_00241640(int a, GameScript self_)
		{
			_0024a_00241643 = a;
			_0024self__00241644 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241643, _0024self__00241644);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShowLUP_00241645 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241646;

			internal GameScript _0024self__00241647;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241646 = a;
				_0024self__00241647 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				//IL_0040: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241647.LUP[_0024a_00241646].SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241647.LUP[_0024a_00241646].SetActive(false);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241648;

		internal GameScript _0024self__00241649;

		public _0024ShowLUP_00241645(int a, GameScript self_)
		{
			_0024a_00241648 = a;
			_0024self__00241649 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241648, _0024self__00241649);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LevelUp_00241650 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241651;

			internal GameObject _0024pp_00241652;

			internal int _0024num_00241653;

			internal int _0024num1_00241654;

			internal int _0024num2_00241655;

			internal int _0024num3_00241656;

			internal int _0024doodo_00241657;

			internal GameScript _0024self__00241658;

			public _0024(GameScript self_)
			{
				_0024self__00241658 = self_;
			}

			public override bool MoveNext()
			{
				//IL_041a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0424: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					playerLevel++;
					_0024self__00241658.txtLevel.text = "Lv: " + (object)playerLevel;
					_0024i_00241651 = default(int);
					_0024pp_00241652 = null;
					for (_0024i_00241651 = 0; _0024i_00241651 < 4; _0024i_00241651++)
					{
						if (_0024i_00241651 == MenuScript.growthStatGood1 || _0024i_00241651 == MenuScript.growthStatGood2)
						{
							if (playerLevel % 2 == 0)
							{
								tempLevelStat[_0024i_00241651]++;
								((MonoBehaviour)_0024self__00241658).StartCoroutine_Auto(_0024self__00241658.ShowLUP(_0024i_00241651));
								if (_0024i_00241651 == 0)
								{
									HP++;
								}
							}
						}
						else if (_0024i_00241651 == MenuScript.growthStatBad)
						{
							if (playerLevel % 4 == 0)
							{
								tempLevelStat[_0024i_00241651]++;
								((MonoBehaviour)_0024self__00241658).StartCoroutine_Auto(_0024self__00241658.ShowLUP(_0024i_00241651));
								if (_0024i_00241651 == 0)
								{
									HP++;
								}
							}
						}
						else if (playerLevel % 3 == 0)
						{
							tempLevelStat[_0024i_00241651]++;
							((MonoBehaviour)_0024self__00241658).StartCoroutine_Auto(_0024self__00241658.ShowLUP(_0024i_00241651));
							if (_0024i_00241651 == 0)
							{
								HP++;
							}
						}
					}
					if (MenuScript.pHat == 3)
					{
						_0024num_00241653 = Random.Range(0, 3);
						if (_0024num_00241653 == 0)
						{
							tempLevelStat[1] = tempLevelStat[1] + 1;
							((MonoBehaviour)_0024self__00241658).StartCoroutine_Auto(_0024self__00241658.AdditionalStat(1));
						}
					}
					else if (MenuScript.pHat == 4)
					{
						_0024num1_00241654 = Random.Range(0, 3);
						if (_0024num1_00241654 == 0)
						{
							tempLevelStat[2] = tempLevelStat[2] + 1;
							((MonoBehaviour)_0024self__00241658).StartCoroutine_Auto(_0024self__00241658.AdditionalStat(2));
						}
					}
					else if (MenuScript.pHat == 5)
					{
						_0024num2_00241655 = Random.Range(0, 3);
						if (_0024num2_00241655 == 0)
						{
							tempLevelStat[3] = tempLevelStat[3] + 1;
							((MonoBehaviour)_0024self__00241658).StartCoroutine_Auto(_0024self__00241658.AdditionalStat(3));
						}
					}
					else if (MenuScript.pHat == 12)
					{
						_0024num3_00241656 = Random.Range(0, 3);
						if (_0024num3_00241656 == 0)
						{
							_0024doodo_00241657 = Random.Range(0, 4);
							tempLevelStat[_0024doodo_00241657]++;
							((MonoBehaviour)_0024self__00241658).StartCoroutine_Auto(_0024self__00241658.AdditionalStat(_0024doodo_00241657));
						}
					}
					MAXHP = MenuScript.playerStat[0] + tempPlayerStat[0] + tempLevelStat[0];
					_0024self__00241658.ATK = MenuScript.playerStat[1] + tempPlayerStat[1] + tempLevelStat[1];
					MAXMAG = MenuScript.playerStat[3] + tempPlayerStat[3] + tempLevelStat[3];
					DEX = MenuScript.playerStat[2] + tempPlayerStat[2] + tempLevelStat[2];
					SPD = (float)DEX * 0.05f + 7.6f;
					if (MenuScript.pHat == 9)
					{
						SPD += 4f;
					}
					if (MenuScript.multiplayer > 0)
					{
						player.networkView.RPC("LevelUp", (RPCMode)2, new object[0]);
						goto IL_0434;
					}
					PlayerController.lUp.SetActive(true);
					player.audio.PlayOneShot(_0024self__00241658.audioLevelUp);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					PlayerController.lUp.SetActive(false);
					goto IL_0434;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0434:
					if (playerLevel % 5 == 0 && curSkill <= 2)
					{
						_0024self__00241658.SkillMenu();
					}
					_0024self__00241658.RefreshPlayerStats();
					_0024self__00241658.LoadHearts();
					_0024self__00241658.LoadMana();
					_0024self__00241658.LoadSTA();
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241659;

		public _0024LevelUp_00241650(GameScript self_)
		{
			_0024self__00241659 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241659);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SkillTick_00241660 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024maxCD_00241661;

			internal float _0024_0024611_00241662;

			internal Vector3 _0024_0024612_00241663;

			internal int _0024a_00241664;

			internal float _0024max_00241665;

			internal GameScript _0024self__00241666;

			public _0024(int a, float max, GameScript self_)
			{
				_0024a_00241664 = a;
				_0024max_00241665 = max;
				_0024self__00241666 = self_;
			}

			public override bool MoveNext()
			{
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0085: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00be: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ff: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024maxCD_00241661 = _0024max_00241665;
					_0024self__00241666.skillObjShade[_0024a_00241664].SetActive(true);
					goto case 2;
				case 2:
					if (_0024self__00241666.skillCooldown[_0024a_00241664] > 0f)
					{
						float num = (_0024_0024611_00241662 = _0024self__00241666.skillCooldown[_0024a_00241664] / _0024max_00241665 * 2f);
						Vector3 val = (_0024_0024612_00241663 = _0024self__00241666.skillObjShade[_0024a_00241664].transform.localScale);
						float num2 = (_0024_0024612_00241663.y = _0024_0024611_00241662);
						Vector3 val3 = (_0024self__00241666.skillObjShade[_0024a_00241664].transform.localScale = _0024_0024612_00241663);
						_0024self__00241666.skillCooldown[_0024a_00241664] = _0024self__00241666.skillCooldown[_0024a_00241664] - 1f;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					_0024self__00241666.skillObjShade[_0024a_00241664].SetActive(false);
					_0024self__00241666.skillObj[_0024a_00241664].animation.Play();
					_0024self__00241666.skillCooldown[_0024a_00241664] = 0f;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241667;

		internal float _0024max_00241668;

		internal GameScript _0024self__00241669;

		public _0024SkillTick_00241660(int a, float max, GameScript self_)
		{
			_0024a_00241667 = a;
			_0024max_00241668 = max;
			_0024self__00241669 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241667, _0024max_00241668, _0024self__00241669);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RageTick_00241670 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					rage = false;
					if (MenuScript.multiplayer > 0)
					{
						player.networkView.RPC("Rage", (RPCMode)6, new object[1] { 0 });
					}
					else
					{
						player.SendMessage("Rage", (object)0);
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

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return (IEnumerator<WaitForSeconds>)(object)new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RoarTick_00241671 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				//IL_0029: Unknown result type (might be due to invalid IL or missing references)
				//IL_0033: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					DEXBonus += 10;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					if (DEXBonus >= 10)
					{
						DEXBonus -= 10;
					}
					else
					{
						DEXBonus = 0;
					}
					if (MenuScript.multiplayer > 0)
					{
						player.networkView.RPC("Roar", (RPCMode)6, new object[1] { 0 });
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

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return (IEnumerator<WaitForSeconds>)(object)new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FloatTick_00241672 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
					break;
				case 2:
					rage = false;
					if (MenuScript.multiplayer > 0)
					{
						player.networkView.RPC("Float", (RPCMode)6, new object[1] { 0 });
					}
					else
					{
						player.SendMessage("Float", (object)0);
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

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return (IEnumerator<WaitForSeconds>)(object)new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ManaTick_00241673 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241674;

			internal GameScript _0024self__00241675;

			public _0024(GameScript self_)
			{
				_0024self__00241675 = self_;
			}

			public override bool MoveNext()
			{
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241674 = default(int);
					_0024i_00241674 = 0;
					goto IL_0079;
				case 2:
					_0024i_00241674++;
					goto IL_0079;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0079:
					if (_0024i_00241674 < 20)
					{
						if (MAG < MAXMAG)
						{
							MAG++;
							_0024self__00241675.LoadMana();
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					clair = false;
					if (MenuScript.multiplayer > 0)
					{
						player.networkView.RPC("Clair", (RPCMode)6, new object[1] { 0 });
					}
					else
					{
						player.SendMessage("Clair", (object)0);
					}
					manaWait = 10;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241676;

		public _0024ManaTick_00241673(GameScript self_)
		{
			_0024self__00241676 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241676);
		}
	}

	public TextMesh txtTimer;

	[NonSerialized]
	public static int timer;

	[NonSerialized]
	public static int potsUsed;

	private bool selectingReward;

	public GameObject[] rewardChestObj;

	private int[] rewardChest;

	[NonSerialized]
	public static int arrowsShot;

	public Material rewShade;

	public Material rewChest;

	public Material rewOpened;

	public GameObject rewardTop;

	public GameObject rewardBot;

	public GameObject rewardIcon;

	public GameObject rewardShade;

	public TextMesh[] txtRewardTop;

	public TextMesh[] txtRewardBot;

	private bool[] isVariant;

	private int[] reward;

	[NonSerialized]
	public static bool win;

	public GameObject menuVictory;

	private string txtStatuss;

	public TextMesh txtStatus2;

	[NonSerialized]
	public static int eggCounter;

	public TextMesh[] txtHighScore;

	public GameObject bAgain;

	public GameObject bMenu;

	public GameObject blackk;

	public LayerMask mask;

	[NonSerialized]
	public static int finalBoss;

	[NonSerialized]
	public static GameObject aSphere;

	private bool writingEgg;

	public GameObject[] LUP;

	public TextMesh txtTraitName;

	public TextMesh txtTraitDesc;

	public GameObject traitDesc;

	public TextMesh txtSkillName;

	public TextMesh txtSkillDesc;

	public GameObject skillDesc;

	[NonSerialized]
	public static bool multishot;

	[NonSerialized]
	public static bool isFloating;

	[NonSerialized]
	public static int DEXBonus;

	[NonSerialized]
	public static int manaWait;

	public GameObject GUImana;

	public GameObject goldCounter;

	[NonSerialized]
	public static bool rage;

	[NonSerialized]
	public static bool clair;

	[NonSerialized]
	public static int curSkill;

	public GameObject[] skillObjShade;

	private float[] skillCooldown;

	public GameObject[] skillObj;

	[NonSerialized]
	public static int[] skill = new int[3];

	public GameObject menuSkill;

	[NonSerialized]
	public static GameObject exitObj;

	[NonSerialized]
	public static bool bossDefeated;

	private bool ATKING;

	public TextMesh txtDied;

	[NonSerialized]
	public static int[] doorBiome = new int[3];

	[NonSerialized]
	public static GameObject barrierObj;

	public TextMesh txtZone;

	[NonSerialized]
	public static int districtLevel;

	[NonSerialized]
	public static bool isShopping;

	public TextMesh txtGoldCounter;

	public GameObject expBack2;

	public TextMesh txtLevelEXP;

	public TextMesh txtPercent;

	public TextMesh txtDur;

	public GameObject barEXPback;

	public GameObject barEXP;

	public TextMesh txtStatEXP;

	public GameObject[] barBack;

	public GameObject[] barFill;

	public GameObject gearStats;

	public TextMesh txtDesc;

	public TextMesh[] txtGearStat;

	public GameObject[] trait;

	public AudioClip audioSelect;

	private bool usingPot;

	public AudioClip audioSelect2;

	public AudioClip audioSelect3;

	public AudioClip audioCraftt;

	private bool ForceFullscreen;

	private int accountEXP;

	private float tempEXP;

	public GameObject worm;

	[NonSerialized]
	public static bool isCooking;

	[NonSerialized]
	public static bool canInteract;

	[NonSerialized]
	public static string interacter;

	[NonSerialized]
	public static int[] tempStats = new int[16];

	[NonSerialized]
	public static int[] tempPlayerStat = new int[4];

	[NonSerialized]
	public static int[] tempLevelStat = new int[4];

	[NonSerialized]
	public static int[] tempGearStat = new int[4];

	[NonSerialized]
	public static bool interacting;

	[NonSerialized]
	public static bool canTakeDamage = true;

	[NonSerialized]
	public static int curZone;

	[NonSerialized]
	public static int curStyle;

	[NonSerialized]
	public static bool takingDamage;

	[NonSerialized]
	public static int curBiome;

	[NonSerialized]
	public static GameObject player;

	[NonSerialized]
	public static bool menuOpen;

	[NonSerialized]
	public static bool isInstance;

	[NonSerialized]
	public static bool facingLeft;

	[NonSerialized]
	public static bool isReturning;

	[NonSerialized]
	public static bool changingScene;

	[NonSerialized]
	public static int cLevel;

	[NonSerialized]
	public static bool isTown;

	[NonSerialized]
	public static int hunger;

	[NonSerialized]
	public static bool isInitialized;

	[NonSerialized]
	public static int HP;

	[NonSerialized]
	public static int playerLevel;

	[NonSerialized]
	public static float exp;

	[NonSerialized]
	public static float maxEXP = 8f;

	[NonSerialized]
	public static int count = 8;

	[NonSerialized]
	public static int readyPlayers;

	[NonSerialized]
	public static int playersDead;

	[NonSerialized]
	public static int[] door = new int[3];

	[NonSerialized]
	public static int finalATK;

	[NonSerialized]
	public static int finalATKChop;

	[NonSerialized]
	public static int finalATKMine = 1;

	[NonSerialized]
	public static int curDoor;

	[NonSerialized]
	public static bool attacking;

	[NonSerialized]
	public static int finalATKNet;

	public AudioClip audioCrafted;

	[NonSerialized]
	public static Item[] npcInventory = new Item[15];

	public GameObject[] bSmithObject;

	public TextMesh[] bSmithText;

	public GameObject menuStats;

	public TextMesh[] txtStats;

	public GameObject[] statObj;

	public GameObject menuBlacksmith;

	public GameObject menuAlchemist;

	public GameObject menuTailor;

	public GameObject selectCraft1;

	public GameObject selectCraft2;

	public TextMesh txtLevelName;

	public TextMesh txtStatus;

	[NonSerialized]
	public static int curGold;

	private int maxHunger;

	private bool shifting;

	public TextMesh[] txtPlayerStat;

	[NonSerialized]
	public static int curActiveSlot;

	[NonSerialized]
	public static Item[] inventory = new Item[31];

	private Item[] temp;

	private bool canAttack;

	public int ATK;

	[NonSerialized]
	public static int MAG;

	[NonSerialized]
	public static float SPD = 30f;

	public int STA;

	public int ATKChop;

	public int ATKMine;

	[NonSerialized]
	public static int MAXHP;

	[NonSerialized]
	public static int MAXMAG;

	[NonSerialized]
	public static int DEX;

	private int lowestQ;

	private string levelName;

	public Material staminaMaterial;

	public GameObject barStamina;

	public GameObject barMana;

	public AudioClip audioLevelUp;

	public TextMesh txtName;

	public TextMesh txtLevel;

	public TextMesh[] txtBarInfo;

	public Material materialHunger;

	public Material materialHungerNot;

	public int maxStamina;

	public float stamina;

	public GameObject txtItem;

	public AudioClip audioMelee;

	public GameObject menuNewTown;

	public GameObject menuLeaveTown;

	public GameObject menuReturnTown;

	public GameObject menuDefeated;

	public GameObject menuExit;

	public GameObject menuCraft;

	public GameObject sSelected;

	public TextMesh selectedQ;

	public GameObject infoObject;

	public TextMesh[] txtInfoName;

	public TextMesh[] txtStat;

	public TextMesh[] txtInfoEnchantment;

	public GameObject[] inventorySlot;

	public TextMesh[] inventoryQ;

	public GameObject select;

	public GameObject heartsObj;

	public GameObject bg;

	public GameObject bd;

	public TextMesh[] txtIP;

	public GameObject shade;

	public GameObject menuInventory;

	public GameObject menuEquipped;

	private Item craft0;

	private Item craft1;

	private bool crafting;

	private Item firstItemSelected;

	private Item secondItemSelected;

	private int firstItemSelectedSlot;

	private bool usingItem;

	private int secondItemSelectedSlot;

	private GameObject bridge;

	private bool isDead;

	private int interact;

	private int[] curTownNPCs;

	private int hasCurTown;

	private int curTownBiome;

	private Ray ray;

	private Item itemSelected;

	private bool holdingItem;

	private RaycastHit hit;

	private bool enteringIP;

	private int curCharacter;

	[NonSerialized]
	public static bool inventoryOpen;

	private Ray rayCursor;

	private RaycastHit cursorHit;

	private bool dead;

	private bool @using;

	private FadeInOut fade;

	private float atkWait;

	private string atkAnim;

	public GameObject head;

	public GameObject head2;

	public GameObject body;

	public GameObject arm1;

	public GameObject arm2;

	public GameObject leg;

	public GameObject weapon;

	public GameObject offHand;

	public GameObject @base;

	public bool immobilized;

	public Texture2D cursorTexture;

	public Texture2D cursorTexture2;

	private CursorMode cursorMode;

	[NonSerialized]
	public static bool selectingSkill;

	private Vector2 hotSpot;

	public GameScript()
	{
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		rewardChestObj = (GameObject[])(object)new GameObject[4];
		rewardChest = new int[4];
		txtRewardTop = (TextMesh[])(object)new TextMesh[2];
		txtRewardBot = (TextMesh[])(object)new TextMesh[2];
		isVariant = new bool[15];
		reward = new int[50];
		txtHighScore = (TextMesh[])(object)new TextMesh[2];
		LUP = (GameObject[])(object)new GameObject[4];
		skillObjShade = (GameObject[])(object)new GameObject[3];
		skillCooldown = new float[3];
		skillObj = (GameObject[])(object)new GameObject[3];
		barBack = (GameObject[])(object)new GameObject[4];
		barFill = (GameObject[])(object)new GameObject[4];
		txtGearStat = (TextMesh[])(object)new TextMesh[4];
		trait = (GameObject[])(object)new GameObject[3];
		bSmithObject = (GameObject[])(object)new GameObject[15];
		bSmithText = (TextMesh[])(object)new TextMesh[15];
		txtStats = (TextMesh[])(object)new TextMesh[16];
		statObj = (GameObject[])(object)new GameObject[16];
		maxHunger = 10;
		txtPlayerStat = (TextMesh[])(object)new TextMesh[4];
		temp = new Item[20];
		canAttack = true;
		txtBarInfo = (TextMesh[])(object)new TextMesh[4];
		maxStamina = 10;
		txtInfoName = (TextMesh[])(object)new TextMesh[2];
		txtStat = (TextMesh[])(object)new TextMesh[2];
		txtInfoEnchantment = (TextMesh[])(object)new TextMesh[2];
		inventorySlot = (GameObject[])(object)new GameObject[31];
		inventoryQ = (TextMesh[])(object)new TextMesh[31];
		txtIP = (TextMesh[])(object)new TextMesh[2];
		curTownNPCs = new int[9];
		atkWait = 0.45f;
		atkAnim = "a1";
		cursorMode = (CursorMode)0;
		hotSpot = new Vector2(8f, 8f);
	}

	public override void TD(int a)
	{
		HP -= a;
	}

	public override void Purchase(int id)
	{
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		if (id == 0)
		{
			return;
		}
		int itemPrice = GetItemPrice(id);
		if (curGold >= itemPrice)
		{
			curGold -= itemPrice;
			PlayerTriggerScript.itemPurchasing = 0;
			GameObject val = null;
			Item item = new Item(id, 1, new int[4], 0f, null);
			if (item.id >= 500)
			{
				item.d = (int)GetMaxDurability(item.id);
				item.e = GetGearStats(item.id);
			}
			if (MenuScript.multiplayer > 0)
			{
				val = (GameObject)Network.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity, 0);
				val.SendMessage("Set", (object)item);
			}
			else
			{
				val = (GameObject)Object.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity);
				val.SendMessage("Set", (object)item);
			}
			PlayerTriggerScript.currentStand.SetActive(false);
			isShopping = false;
			RefreshGold();
			((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/PURCHASE", typeof(AudioClip)));
			player.SendMessage("WW2");
			tempStats[12] = tempStats[12] + 1;
		}
		else
		{
			((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/FAIL", typeof(AudioClip)));
		}
	}

	public override int GetItemPrice(int id)
	{
		int num = default(int);
		return id switch
		{
			1 => 5, 
			2 => 10, 
			3 => 5, 
			4 => 15, 
			5 => 30, 
			6 => 70, 
			7 => 5, 
			8 => 8, 
			9 => 10, 
			10 => 10, 
			11 => 10, 
			12 => 30, 
			13 => 60, 
			14 => 140, 
			15 => 20, 
			16 => 20, 
			17 => 20, 
			18 => 7, 
			19 => 7, 
			20 => 7, 
			21 => 5, 
			22 => 10, 
			23 => 10, 
			24 => 15, 
			25 => 20, 
			26 => 10, 
			27 => 15, 
			28 => 30, 
			29 => 20, 
			30 => 20, 
			31 => 20, 
			32 => 60, 
			33 => 120, 
			34 => 280, 
			35 => 120, 
			36 => 240, 
			37 => 560, 
			38 => 10, 
			39 => 20, 
			40 => 40, 
			41 => 80, 
			42 => 45, 
			43 => 45, 
			44 => 20, 
			45 => 45, 
			46 => 100, 
			47 => 30, 
			48 => 65, 
			49 => 10, 
			50 => 15, 
			51 => 5, 
			52 => 5, 
			53 => 10, 
			54 => 20, 
			55 => 40, 
			56 => 60, 
			500 => 35, 
			501 => 30, 
			502 => 45, 
			503 => 120, 
			504 => 120, 
			505 => 120, 
			506 => 300, 
			507 => 300, 
			508 => 300, 
			509 => 700, 
			510 => 700, 
			511 => 700, 
			512 => 55, 
			513 => 50, 
			514 => 65, 
			515 => 100, 
			516 => 55, 
			517 => 50, 
			518 => 65, 
			519 => 200, 
			550 => 330, 
			560 => 135, 
			561 => 255, 
			562 => 1000, 
			563 => 95, 
			600 => 100, 
			601 => 100, 
			602 => 100, 
			700 => 90, 
			701 => 180, 
			702 => 420, 
			800 => 90, 
			801 => 180, 
			802 => 420, 
			900 => 90, 
			901 => 180, 
			902 => 420, 
			_ => 999, 
		};
	}

	public override void RefreshGold()
	{
		txtGoldCounter.text = "x" + (object)curGold;
		goldCounter.animation.Play();
	}

	public override void SetDead()
	{
		isDead = true;
	}

	public override void SetRevive()
	{
		isDead = false;
		HP = 1;
		LoadHearts();
	}

	public override void LoadEXP()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		float num = exp;
		float num2 = maxEXP;
		txtStatEXP.text = (object)exp + "/" + (object)maxEXP;
		float x = num / num2 * 1.15f;
		Vector3 localScale = barEXP.transform.localScale;
		float num3 = (localScale.x = x);
		Vector3 val2 = (barEXP.transform.localScale = localScale);
		txtLevel.text = "Lv: " + (object)playerLevel;
	}

	public override IEnumerator Invader()
	{
		return new _0024Invader_00241425(this).GetEnumerator();
	}

	public static void EggCounter()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer == 1)
		{
			eggCounter++;
			if (eggCounter >= 3)
			{
				eggCounter = 0;
				Network.Instantiate(Resources.Load("e/broodmother"), new Vector3(player.transform.position.x, player.transform.position.y + 50f, 0f), Quaternion.identity, 0);
			}
		}
	}

	public override void DetectRes()
	{
		if (!(Camera.main.aspect < 1.7f))
		{
			Debug.Log((object)"16:9");
			Camera.main.orthographicSize = 12f;
		}
		else if (!(Camera.main.aspect < 1.5f))
		{
			Debug.Log((object)"3:2");
			Camera.main.orthographicSize = 13f;
		}
		else if (!(Camera.main.aspect < 1.3f))
		{
			Debug.Log((object)"4:3");
			Camera.main.orthographicSize = 14.5f;
		}
		else if (!(Camera.main.aspect < 1.25f))
		{
			Debug.Log((object)"5:4");
			Camera.main.orthographicSize = 15.2f;
		}
	}

	public override IEnumerator Timer()
	{
		return new _0024Timer_00241430(this).GetEnumerator();
	}

	public override void Awake()
	{
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected O, but got Unknown
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected O, but got Unknown
		//IL_0cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected O, but got Unknown
		//IL_0ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		if (Network.isServer)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Timer());
		}
		DetectRes();
		ATKING = false;
		usingPot = false;
		int num = default(int);
		win = false;
		@using = false;
		finalATKNet = 0;
		isFloating = false;
		menuOpen = false;
		canAttack = true;
		dead = false;
		attacking = false;
		inventoryOpen = false;
		immobilized = false;
		PlayerTriggerScript.isDead = false;
		PlayerTriggerScript.canTakeDamage = true;
		eggCounter = 0;
		DEXBonus = 0;
		rage = false;
		dead = false;
		PlayerControllerN.downed = false;
		isFloating = false;
		manaWait = 10;
		RefreshSkills();
		if (!isTown)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Invader());
		}
		if (MenuScript.multiplayer > 0)
		{
			Network.minimumAllocatableViewIDs = 700;
		}
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bossDefeated = false;
		txtDied.text = MenuScript.curName + " has fallen.";
		isShopping = false;
		accountEXP = MenuScript.accountEXP;
		txtLevel.text = "Lv: " + (object)playerLevel;
		isCooking = false;
		LoadEXP();
		if (MenuScript.curTrait[1] == 10 || MenuScript.curTrait[2] == 10)
		{
			maxHunger = 12;
		}
		else
		{
			maxHunger = 8;
		}
		inventoryOpen = false;
		takingDamage = false;
		fade = (FadeInOut)(object)((Component)Camera.main).gameObject.GetComponent("FadeInOut");
		if (MenuScript.multiplayer != 2)
		{
			readyPlayers = 0;
		}
		maxStamina = MenuScript.playerStat[2] + tempPlayerStat[2] + 2 + tempLevelStat[2];
		stamina = maxStamina;
		if (!isInitialized)
		{
			int num5 = default(int);
			for (num5 = 0; num5 < 15; num5++)
			{
				MenuScript.canUnlockRace[num5] = 0;
			}
			for (num5 = 0; num5 < 24; num5++)
			{
				MenuScript.canUnlockHat[num5] = 0;
			}
			arrowsShot = 0;
			curGold = 0;
			potsUsed = 0;
			timer = 0;
			selectingSkill = false;
			curBiome = 0;
			finalBoss = 0;
			skill[0] = 0;
			skill[1] = 0;
			skill[2] = 0;
			RefreshSkills();
			curSkill = 0;
			districtLevel = 1;
			int num6 = default(int);
			for (num6 = 0; num6 < 15; num6++)
			{
				tempStats[num6] = 0;
			}
			RefreshGold();
			curActiveSlot = 0;
			playerLevel = 1;
			count = 0;
			exp = 0f;
			maxEXP = 8f;
			hunger = 8;
			isInitialized = true;
			for (num = 0; num < 4; num++)
			{
				tempGearStat[num] = 0;
				tempLevelStat[num] = 0;
				tempPlayerStat[num] = 0;
			}
			MAXHP = MenuScript.playerStat[0] + tempPlayerStat[0] + tempLevelStat[0];
			HP = MAXHP;
			ATK = MenuScript.playerStat[1] + tempPlayerStat[1] + tempLevelStat[1];
			MAXMAG = MenuScript.playerStat[3] + tempPlayerStat[3] + tempLevelStat[3];
			MAG = MAXMAG;
			DEX = MenuScript.playerStat[2] + tempPlayerStat[2] + tempLevelStat[2];
			SPD = (float)DEX * 0.05f + 7.6f;
			SetRaceStats();
			if (MenuScript.pHat == 9)
			{
				SPD += 4f;
			}
			SetStartingItems();
			if (districtLevel % 5 == 0)
			{
			}
			if (districtLevel == 20)
			{
				finalBoss = 1;
			}
			else if (districtLevel == 21)
			{
				curBiome = 19;
				isTown = false;
			}
		}
		else
		{
			districtLevel++;
			if (districtLevel == 10)
			{
				MenuScript.canUnlockRace[7] = 1;
			}
			if (districtLevel % 5 == 0)
			{
			}
			if (districtLevel == 20)
			{
				finalBoss = 1;
			}
			else if (districtLevel == 21)
			{
				curBiome = 19;
				isTown = false;
			}
			if (selectingSkill)
			{
				SkillMenu();
			}
			MAXHP = MenuScript.playerStat[0] + tempPlayerStat[0] + tempLevelStat[0];
			ATK = MenuScript.playerStat[1] + tempPlayerStat[1] + tempLevelStat[1];
			MAXMAG = MenuScript.playerStat[3] + tempPlayerStat[3] + tempLevelStat[3];
			DEX = MenuScript.playerStat[2] + tempPlayerStat[2] + tempLevelStat[2];
			SPD = (float)DEX * 0.05f + 7.6f;
			if (MenuScript.pHat == 9)
			{
				SPD += 4f;
			}
			RefreshGold();
		}
		select.transform.localPosition = GetSelectPos(curActiveSlot);
		UpdateHunger();
		facingLeft = false;
		dead = false;
		string curName = MenuScript.curName;
		Vector3 val = new Vector3(2f, 2f, 0f);
		if (curBiome == 1)
		{
			MenuScript.canUnlockHat[6] = 1;
		}
		else if (curBiome == 2)
		{
			MenuScript.canUnlockHat[7] = 1;
		}
		else if (curBiome == 7)
		{
			MenuScript.canUnlockHat[10] = 1;
		}
		else if (curBiome == 5)
		{
			MenuScript.canUnlockHat[13] = 1;
		}
		else if (curBiome == 3)
		{
			MenuScript.canUnlockHat[15] = 1;
		}
		else if (curBiome == 6)
		{
			MenuScript.canUnlockHat[16] = 1;
		}
		else if (curBiome == 19)
		{
			MenuScript.canUnlockHat[17] = 1;
		}
		if (MenuScript.multiplayer == 1)
		{
			door[0] = 0;
			door[1] = 0;
			door[2] = 0;
			if (!changingScene)
			{
			}
			if (!Object.op_Implicit((Object)(object)player))
			{
				player = (GameObject)Network.Instantiate(Resources.Load("playerN"), val, Quaternion.identity, 0);
				if (player.networkView.isMine)
				{
					num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
					num3 = PlayerControllerN.armor;
					num4 = PlayerControllerN.offhand;
					player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
					{
						num2,
						num3,
						MenuScript.pRace,
						num4,
						MenuScript.pHat
					});
					player.networkView.RPC("AssignName", (RPCMode)6, new object[1] { MenuScript.curName });
				}
			}
			else if (player.networkView.isMine)
			{
				num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
				num3 = PlayerControllerN.armor;
				num4 = PlayerControllerN.offhand;
				player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
				{
					num2,
					num3,
					MenuScript.pRace,
					num4,
					MenuScript.pHat
				});
				player.networkView.RPC("AssignName", (RPCMode)6, new object[1] { MenuScript.curName });
			}
			player.SendMessage("Initialize");
			if (player.networkView.isMine)
			{
				trait[1].renderer.material = (Material)Resources.Load("t/t" + (object)MenuScript.curTrait[1], typeof(Material));
				trait[2].renderer.material = (Material)Resources.Load("t/t" + (object)MenuScript.curTrait[2], typeof(Material));
				if (hunger == 0)
				{
					hunger = maxHunger;
				}
				UpdateHunger();
			}
			@base = GameObject.Find("base");
			head = GameObject.Find("head");
			head2 = GameObject.Find("head2");
			body = GameObject.Find("body");
			arm1 = GameObject.Find("arm1");
			arm2 = GameObject.Find("arm2");
			leg = GameObject.Find("leg");
			weapon = GameObject.Find("item");
			hasCurTown = PlayerPrefs.GetInt("hasTown");
			player.transform.position = new Vector3(0f, -1.5f, 0f);
			UpdateCharacterWeapon();
			((MonoBehaviour)this).StartCoroutine_Auto(GenerateText());
			GenerateLevelName();
			((MonoBehaviour)this).StartCoroutine_Auto(ScourgeMaskTick());
		}
		else if (MenuScript.multiplayer == 2)
		{
			MonoBehaviour.print((object)"================================= IS 2");
			if (!changingScene)
			{
				if (!Object.op_Implicit((Object)(object)player))
				{
					player = (GameObject)Network.Instantiate(Resources.Load("playerN"), val, Quaternion.identity, 0);
					num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
					num3 = PlayerControllerN.armor;
					num4 = PlayerControllerN.offhand;
					player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
					{
						num2,
						num3,
						MenuScript.pRace,
						num4,
						MenuScript.pHat
					});
					player.networkView.RPC("AssignName", (RPCMode)6, new object[1] { MenuScript.curName });
				}
				else if (player.networkView.isMine)
				{
					num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
					num3 = PlayerControllerN.armor;
					num4 = PlayerControllerN.offhand;
					player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
					{
						num2,
						num3,
						MenuScript.pRace,
						num4,
						MenuScript.pHat
					});
				}
			}
			else
			{
				player.transform.position = new Vector3(0f, -1.5f, 0f);
				player.SendMessage("Initialize");
				num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
				num3 = PlayerControllerN.armor;
				num4 = PlayerControllerN.offhand;
				player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
				{
					num2,
					num3,
					MenuScript.pRace,
					num4,
					MenuScript.pHat
				});
				player.networkView.RPC("AssignName", (RPCMode)6, new object[1] { MenuScript.curName });
				((Component)Camera.main).SendMessage("SetPlayer", (object)player);
				@base = GameObject.Find("base");
				head = GameObject.Find("head");
				head2 = GameObject.Find("head2");
				body = GameObject.Find("body");
				arm1 = GameObject.Find("arm1");
				arm2 = GameObject.Find("arm2");
				leg = GameObject.Find("leg");
				weapon = GameObject.Find("weapon");
				UpdateCharacterWeapon();
			}
			player.transform.position = new Vector3(0f, -1.5f, 0f);
			player.SendMessage("Initialize");
			if (player.networkView.isMine)
			{
				trait[1].renderer.material = (Material)Resources.Load("t/t" + (object)MenuScript.curTrait[1], typeof(Material));
				trait[2].renderer.material = (Material)Resources.Load("t/t" + (object)MenuScript.curTrait[2], typeof(Material));
				if (hunger == 0)
				{
					hunger = maxHunger;
				}
				UpdateHunger();
			}
			((Component)Camera.main).SendMessage("SetPlayer", (object)player);
			@base = GameObject.Find("base");
			head = GameObject.Find("head");
			head2 = GameObject.Find("head2");
			body = GameObject.Find("body");
			arm1 = GameObject.Find("arm1");
			arm2 = GameObject.Find("arm2");
			leg = GameObject.Find("leg");
			weapon = GameObject.Find("weapon");
			UpdateCharacterWeapon();
		}
		isInstance = true;
		if (!isTown)
		{
			if (MenuScript.multiplayer > 0)
			{
				if (Network.isServer)
				{
					GenerateLevel();
				}
			}
			else
			{
				GenerateLevel();
			}
		}
		else if (MenuScript.multiplayer > 0)
		{
			if (MenuScript.multiplayer == 1)
			{
				SpawnTownNetwork();
			}
		}
		else
		{
			SpawnTown();
		}
		if (Object.op_Implicit((Object)(object)player))
		{
			((Component)Camera.main).SendMessage("SetPlayer", (object)player.gameObject);
			player.SendMessage("Initialize");
		}
		RefreshActionBar();
		if (MenuScript.multiplayer != 2)
		{
			maxStamina += STA;
		}
		RefreshPlayerStats();
		((MonoBehaviour)this).StartCoroutine_Auto(RecoverMana());
		if (curBiome == 6 && !isTown)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(LavaWorm());
		}
		if (MenuScript.multiplayer == 1 && curBiome == 19)
		{
			Network.Instantiate(Resources.Load("e/scourgeWall"), new Vector3(-15f, 0f, 0f), Quaternion.identity, 0);
		}
		LoadEXP();
		((MonoBehaviour)this).StartCoroutine_Auto(TikiCheck());
	}

	public override void SetRaceStats()
	{
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			tempLevelStat[num] += MenuScript.raceStats[num];
		}
	}

	public override IEnumerator ScourgeMaskTick()
	{
		return new _0024ScourgeMaskTick_00241433().GetEnumerator();
	}

	public override IEnumerator TikiCheck()
	{
		return new _0024TikiCheck_00241434(this).GetEnumerator();
	}

	public override IEnumerator LavaWorm()
	{
		return new _0024LavaWorm_00241439().GetEnumerator();
	}

	public override void Worm()
	{
		if (MenuScript.multiplayer > 0 && MenuScript.multiplayer != 1)
		{
		}
	}

	public override IEnumerator RecoverMana()
	{
		return new _0024RecoverMana_00241440(this).GetEnumerator();
	}

	public override void SetStartingItems()
	{
		int num = default(int);
		for (num = 0; num < 3; num++)
		{
			if (MenuScript.startingItemID[num] == 8888)
			{
				continue;
			}
			if (MenuScript.startingItemID[num] == 9999)
			{
				int num2 = Random.Range(0, 54);
				switch (num2)
				{
				case 13:
					num2 = 5;
					break;
				case 14:
					num2 = 4;
					break;
				case 32:
				case 35:
				case 36:
				case 37:
					num2 = 4;
					break;
				case 33:
					num2 = 5;
					break;
				case 34:
					num2 = 5;
					break;
				}
				inventory[num] = new Item(num2, 1, new int[4], 0f, null);
			}
			else if (MenuScript.startingItemID[num] >= 500)
			{
				inventory[num] = new Item(MenuScript.startingItemID[num], 1, GetGearStats(MenuScript.startingItemID[num]), GetMaxDurability(MenuScript.startingItemID[num]), null);
			}
			else
			{
				inventory[num] = new Item(MenuScript.startingItemID[num], 1, new int[4], 0f, null);
			}
		}
	}

	public override IEnumerator ScourgeBoss(int d)
	{
		return new _0024ScourgeBoss_00241443(d).GetEnumerator();
	}

	public override void ScourgeAttack()
	{
	}

	public override IEnumerator SummonScourge()
	{
		return new _0024SummonScourge_00241447().GetEnumerator();
	}

	public override IEnumerator RepeatScourge()
	{
		return new _0024RepeatScourge_00241448(this).GetEnumerator();
	}

	public override IEnumerator Quake()
	{
		return new _0024Quake_00241452().GetEnumerator();
	}

	public override IEnumerator Write(int num)
	{
		return new _0024Write_00241456(num, this).GetEnumerator();
	}

	public override void GlobalWrite(int a)
	{
		if (Network.isServer)
		{
			player.networkView.RPC("WritePlayer", (RPCMode)2, new object[1] { a });
		}
	}

	public override IEnumerator WriteFinal(int a)
	{
		return new _0024WriteFinal_00241463(a, this).GetEnumerator();
	}

	public override IEnumerator GenerateText()
	{
		return new _0024GenerateText_00241470(this).GetEnumerator();
	}

	public override void GenerateLevelName()
	{
		string text = null;
		string text2 = null;
		text2 = ((curBiome == 19) ? "The Scourge Lair" : ("District " + (object)districtLevel + ": "));
		string text3 = text2 + curBiome switch
		{
			0 => GetForestPrefix() + " Forest", 
			1 => GetTundraPrefix() + " Tundra", 
			2 => GetCavePrefix() + " Cave", 
			3 => GetDungeonPrefix() + " Dungeon", 
			4 => GetCavePrefix() + " Desert", 
			5 => GetCavePrefix() + " Veldt", 
			6 => GetCavePrefix() + " Volcano", 
			7 => GetCavePrefix() + " Swamp", 
			8 => GetCavePrefix() + " Ice Cave", 
			_ => string.Empty, 
		};
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				player.networkView.RPC("SetZoneName", (RPCMode)6, new object[1] { text3 });
			}
		}
		else
		{
			txtZone.text = text3;
			txtLevelName.text = text3;
			((Component)txtLevelName).gameObject.SetActive(true);
		}
	}

	public override string GetForestPrefix()
	{
		int num = Random.Range(0, 10);
		int num2 = Random.Range(0, 10);
		string text = null;
		string text2 = null;
		switch (num)
		{
		case 0:
			text = "Thorn";
			break;
		case 1:
			text = "Bush";
			break;
		case 2:
			text = "Leaf";
			break;
		case 3:
			text = "Vine";
			break;
		case 4:
			text = "Rock";
			break;
		case 5:
			text = "Earth";
			break;
		case 6:
			text = "Toad";
			break;
		case 7:
			text = "Green";
			break;
		case 8:
			text = "Tree";
			break;
		case 9:
			text = "Deep";
			break;
		case 10:
			text = "Lush";
			break;
		}
		switch (num2)
		{
		case 0:
			text2 = "vale";
			break;
		case 1:
			text2 = "wreath";
			break;
		case 2:
			text2 = "night";
			break;
		case 3:
			text2 = "fire";
			break;
		case 4:
			text2 = "roar";
			break;
		case 5:
			text2 = "fang";
			break;
		case 6:
			text2 = "road";
			break;
		case 7:
			text2 = "wild";
			break;
		case 8:
			text2 = "wood";
			break;
		case 9:
			text2 = "grand";
			break;
		case 10:
			text2 = "flower";
			break;
		}
		return text + text2;
	}

	public override string GetTundraPrefix()
	{
		int num = Random.Range(0, 10);
		int num2 = Random.Range(0, 10);
		string text = null;
		string text2 = null;
		switch (num)
		{
		case 0:
			text = "Thorn";
			break;
		case 1:
			text = "Bush";
			break;
		case 2:
			text = "Leaf";
			break;
		case 3:
			text = "Vine";
			break;
		case 4:
			text = "Rock";
			break;
		case 5:
			text = "Earth";
			break;
		case 6:
			text = "Toad";
			break;
		case 7:
			text = "Green";
			break;
		case 8:
			text = "Tree";
			break;
		case 9:
			text = "Deep";
			break;
		case 10:
			text = "Lush";
			break;
		}
		switch (num2)
		{
		case 0:
			text2 = "vale";
			break;
		case 1:
			text2 = "wreath";
			break;
		case 2:
			text2 = "night";
			break;
		case 3:
			text2 = "fire";
			break;
		case 4:
			text2 = "roar";
			break;
		case 5:
			text2 = "fang";
			break;
		case 6:
			text2 = "road";
			break;
		case 7:
			text2 = "wild";
			break;
		case 8:
			text2 = "wood";
			break;
		case 9:
			text2 = "grand";
			break;
		case 10:
			text2 = "flower";
			break;
		}
		return (Random.Range(0, 2) != 0) ? (text2 + text) : (text + text2);
	}

	public override string GetDungeonPrefix()
	{
		int num = Random.Range(0, 10);
		int num2 = Random.Range(0, 10);
		string text = null;
		string text2 = null;
		switch (num)
		{
		case 0:
			text = "Thorn";
			break;
		case 1:
			text = "Bush";
			break;
		case 2:
			text = "Leaf";
			break;
		case 3:
			text = "Vine";
			break;
		case 4:
			text = "Rock";
			break;
		case 5:
			text = "Earth";
			break;
		case 6:
			text = "Toad";
			break;
		case 7:
			text = "Green";
			break;
		case 8:
			text = "Tree";
			break;
		case 9:
			text = "Deep";
			break;
		case 10:
			text = "Lush";
			break;
		}
		switch (num2)
		{
		case 0:
			text2 = "vale";
			break;
		case 1:
			text2 = "wreath";
			break;
		case 2:
			text2 = "night";
			break;
		case 3:
			text2 = "fire";
			break;
		case 4:
			text2 = "roar";
			break;
		case 5:
			text2 = "fang";
			break;
		case 6:
			text2 = "road";
			break;
		case 7:
			text2 = "wild";
			break;
		case 8:
			text2 = "wood";
			break;
		case 9:
			text2 = "grand";
			break;
		case 10:
			text2 = "flower";
			break;
		}
		return (Random.Range(0, 2) != 0) ? (text2 + text) : (text + text2);
	}

	public override string GetCavePrefix()
	{
		int num = Random.Range(0, 10);
		int num2 = Random.Range(0, 10);
		string text = null;
		string text2 = null;
		switch (num)
		{
		case 0:
			text = "Thorn";
			break;
		case 1:
			text = "Bush";
			break;
		case 2:
			text = "Leaf";
			break;
		case 3:
			text = "Vine";
			break;
		case 4:
			text = "Rock";
			break;
		case 5:
			text = "Earth";
			break;
		case 6:
			text = "Toad";
			break;
		case 7:
			text = "Green";
			break;
		case 8:
			text = "Tree";
			break;
		case 9:
			text = "Deep";
			break;
		case 10:
			text = "Lush";
			break;
		}
		switch (num2)
		{
		case 0:
			text2 = "vale";
			break;
		case 1:
			text2 = "wreath";
			break;
		case 2:
			text2 = "night";
			break;
		case 3:
			text2 = "fire";
			break;
		case 4:
			text2 = "roar";
			break;
		case 5:
			text2 = "fang";
			break;
		case 6:
			text2 = "road";
			break;
		case 7:
			text2 = "wild";
			break;
		case 8:
			text2 = "wood";
			break;
		case 9:
			text2 = "grand";
			break;
		case 10:
			text2 = "flower";
			break;
		}
		return (Random.Range(0, 2) != 0) ? (text2 + text) : (text + text2);
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241476(this).GetEnumerator();
	}

	public override IEnumerator StaminaStart()
	{
		return new _0024StaminaStart_00241479(this).GetEnumerator();
	}

	public override void LoadSTA()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		maxStamina = MenuScript.playerStat[2] + 2 + tempPlayerStat[2] + tempLevelStat[2];
		int num = default(int);
		float num2 = maxStamina;
		float num3 = stamina;
		txtBarInfo[3].text = (object)stamina + "/" + (object)maxStamina;
		float x = num2 * 0.3f;
		Vector3 localScale = barBack[3].transform.localScale;
		float num4 = (localScale.x = x);
		Vector3 val2 = (barBack[3].transform.localScale = localScale);
		float x2 = num3 * 0.3f;
		Vector3 localScale2 = barFill[3].transform.localScale;
		float num5 = (localScale2.x = x2);
		Vector3 val4 = (barFill[3].transform.localScale = localScale2);
	}

	public override void DecreaseHunger()
	{
		if (!isTown)
		{
			if (hunger > maxHunger)
			{
				hunger = maxHunger;
			}
			if (hunger > 0)
			{
				hunger--;
			}
			else
			{
				player.SendMessage("TD", (object)1);
			}
			if (hunger == 3)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Write(1));
			}
			else if (hunger == 0)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Write(2));
			}
		}
		UpdateHunger();
	}

	public override void ShowSkillDesc(int a)
	{
		txtSkillDesc.text = GetSkillDesc(a);
		txtSkillName.text = string.Empty + GetSkillName(a);
		skillDesc.SetActive(true);
	}

	public override void CloseSkillDesc()
	{
		txtSkillDesc.text = string.Empty;
		txtSkillName.text = string.Empty;
		skillDesc.SetActive(false);
	}

	public override void UpdateHunger()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		if (hunger > maxHunger)
		{
			hunger = maxHunger;
		}
		txtBarInfo[2].text = (object)hunger + "/" + (object)maxHunger;
		float x = (float)maxHunger * 0.3f;
		Vector3 localScale = barBack[2].transform.localScale;
		float num = (localScale.x = x);
		Vector3 val2 = (barBack[2].transform.localScale = localScale);
		float x2 = (float)hunger * 0.3f;
		Vector3 localScale2 = barFill[2].transform.localScale;
		float num2 = (localScale2.x = x2);
		Vector3 val4 = (barFill[2].transform.localScale = localScale2);
	}

	public override string GetTraitDesc(int id)
	{
		string text = null;
		return id switch
		{
			1 => "Chops down trees quicker.", 
			2 => "Mines ores faster.", 
			3 => "Collects twice as many\ningredients when gathering.", 
			4 => "Crafts Big Potions with\nonly basic ingredients.", 
			5 => "Higher chance at\ncrafting rare weapons\n& gear.", 
			6 => "+2 ATK\n-1 HP", 
			7 => "+2 HP\n-1 ATK.", 
			8 => "+2 DEX", 
			9 => "+1 HP", 
			10 => "Hunger Cap is doubled.", 
			11 => "+2 MAG", 
			12 => "Doesn't need a key when\nopening chests or locks.", 
			_ => "NULL", 
		};
	}

	public override string GetTraitName(int id)
	{
		string text = null;
		return id switch
		{
			1 => "Woodcutter", 
			2 => "Miner", 
			3 => "Gatherer", 
			4 => "Potion Brewer", 
			5 => "Artisan", 
			6 => "Aggressive", 
			7 => "Defensive", 
			8 => "Swift", 
			9 => "Healthy", 
			10 => "Big Eater", 
			11 => "Intelligent", 
			12 => "Lockmaster", 
			13 => "Pickpocket", 
			_ => "NULL", 
		};
	}

	public override void ShowTraitDesc(int slot)
	{
		traitDesc.SetActive(true);
		txtTraitName.text = GetTraitName(MenuScript.curTrait[slot]);
		txtTraitDesc.text = GetTraitDesc(MenuScript.curTrait[slot]);
	}

	public override void OpenDoor()
	{
		if (Object.op_Implicit((Object)(object)exitObj))
		{
			exitObj.SendMessage("Open");
		}
	}

	public override IEnumerator WriteEgg()
	{
		return new _0024WriteEgg_00241482(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1209: Unknown result type (might be due to invalid IL or missing references)
		//IL_120e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1213: Unknown result type (might be due to invalid IL or missing references)
		//IL_100c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Unknown result type (might be due to invalid IL or missing references)
		//IL_1016: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Unknown result type (might be due to invalid IL or missing references)
		//IL_126d: Unknown result type (might be due to invalid IL or missing references)
		//IL_118a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Unknown result type (might be due to invalid IL or missing references)
		if (eggCounter >= 3 && !writingEgg)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(WriteEgg());
		}
		if (Input.GetButtonDown("Slot 1"))
		{
			SelectSlot(0);
		}
		else if (Input.GetButtonDown("Slot 2"))
		{
			SelectSlot(1);
		}
		else if (Input.GetButtonDown("Slot 3"))
		{
			SelectSlot(2);
		}
		else if (Input.GetButtonDown("Slot 4"))
		{
			SelectSlot(3);
		}
		else if (Input.GetButtonDown("Slot 5"))
		{
			SelectSlot(4);
		}
		if (Object.op_Implicit((Object)(object)player))
		{
			Debug.DrawRay(player.transform.position, new Vector3(1f, 0f, 0f), Color.green);
		}
		if (bossDefeated)
		{
			OpenDoor();
			bossDefeated = false;
		}
		if (inventoryOpen || menuOpen)
		{
			Cursor.SetCursor(cursorTexture2, hotSpot, cursorMode);
		}
		else
		{
			Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		}
		if (Input.GetKeyDown((KeyCode)282))
		{
			Screen.SetResolution(512, 320, false);
		}
		else if (Input.GetKeyDown((KeyCode)283))
		{
			Screen.SetResolution(640, 400, false);
		}
		else if (Input.GetKeyDown((KeyCode)284))
		{
			Screen.SetResolution(800, 500, false);
		}
		else if (Input.GetKeyDown((KeyCode)285))
		{
			Screen.SetResolution(960, 600, false);
		}
		else if (Input.GetKeyDown((KeyCode)286))
		{
			Screen.SetResolution(1120, 700, false);
		}
		else if (Input.GetKeyDown((KeyCode)287))
		{
			Screen.SetResolution(1920, 1080, true);
		}
		if (Input.GetKeyDown((KeyCode)114) && !dead)
		{
			OpenInventory();
		}
		int num2 = default(int);
		if (inventoryOpen)
		{
			rayCursor = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(rayCursor, ref cursorHit, 10f, LayerMask.op_Implicit(mask)))
			{
				if (((Component)((RaycastHit)(ref cursorHit)).transform).gameObject.layer == 10)
				{
					if (((Component)((RaycastHit)(ref cursorHit)).transform).gameObject.tag == "sIcon")
					{
						int num = int.Parse(((Object)((Component)((RaycastHit)(ref cursorHit)).transform).gameObject).name);
						ShowSkillDesc(skill[num]);
					}
					else if (((Component)((RaycastHit)(ref cursorHit)).transform).gameObject.tag == "tIcon")
					{
						int slot = int.Parse(((Object)((Component)((RaycastHit)(ref cursorHit)).transform).gameObject).name);
						ShowTraitDesc(slot);
					}
					else
					{
						CloseSkillDesc();
						traitDesc.SetActive(false);
						num2 = int.Parse(((Component)((RaycastHit)(ref cursorHit)).transform).gameObject.tag);
						if (num2 < 100)
						{
							if (inventory[num2].id != 0)
							{
								SetInfoText(num2, inventory[num2].id);
							}
							else
							{
								infoObject.SetActive(false);
							}
						}
					}
				}
				else
				{
					CloseSkillDesc();
					traitDesc.SetActive(false);
				}
			}
			else
			{
				CloseSkillDesc();
				traitDesc.SetActive(false);
				infoObject.SetActive(false);
			}
		}
		if (Input.GetButtonDown("Skill 1") && !dead && HP > 0)
		{
			UseSkill(0);
		}
		if (Input.GetButtonDown("Skill 2") && !dead && HP > 0)
		{
			UseSkill(1);
		}
		if (Input.GetButtonDown("Skill 3") && !dead && HP > 0)
		{
			UseSkill(2);
		}
		if (Input.GetKeyDown((KeyCode)27))
		{
			if (inventoryOpen)
			{
				OpenInventory();
			}
			else if (!menuOpen && !dead)
			{
				if (Network.connections.Length == 0)
				{
					Time.timeScale = 0f;
				}
				menuExit.SetActive(true);
				menuOpen = true;
				OpenInventory();
			}
			else if (menuOpen && !dead)
			{
				if (Network.connections.Length == 0)
				{
					Time.timeScale = 1f;
				}
				menuExit.SetActive(false);
				menuOpen = false;
			}
		}
		if (Input.GetButtonDown("Craft"))
		{
			shifting = true;
		}
		if (Input.GetButtonUp("Craft"))
		{
			shifting = false;
		}
		if (Input.GetButtonDown("Melee Attack") && menuOpen)
		{
			((Component)this).audio.PlayOneShot(audioSelect2);
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, ref hit, 20f))
			{
				string name = ((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name;
				if (((Component)((RaycastHit)(ref hit)).transform).gameObject.tag == "sP")
				{
					if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP0")
					{
						SelectSkill(0);
					}
					else if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP1")
					{
						SelectSkill(1);
					}
					else if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP2")
					{
						SelectSkill(2);
					}
					else
					{
						SelectSkill(3);
					}
				}
				switch (name)
				{
				case "bLeave":
					if (MenuScript.multiplayer > 0)
					{
						LeaveTown();
					}
					else
					{
						LeaveTown();
					}
					break;
				case "bStay":
					menuOpen = false;
					menuLeaveTown.SetActive(false);
					menuReturnTown.SetActive(false);
					break;
				case "bReturn":
					ReturnTown();
					break;
				case "0":
					((MonoBehaviour)this).StartCoroutine_Auto(SelectReward(0));
					break;
				case "1":
					((MonoBehaviour)this).StartCoroutine_Auto(SelectReward(1));
					break;
				case "2":
					((MonoBehaviour)this).StartCoroutine_Auto(SelectReward(2));
					break;
				case "3":
					((MonoBehaviour)this).StartCoroutine_Auto(SelectReward(3));
					break;
				case "bClose":
					CloseReward();
					break;
				}
			}
		}
		if (Input.GetButtonDown("Melee Attack") && inventoryOpen && !shifting)
		{
			ResetCraft();
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, ref hit, 20f))
			{
				if (((Component)((RaycastHit)(ref hit)).transform).gameObject.tag == "sP")
				{
					if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP0")
					{
						SelectSkill(0);
					}
					else if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP1")
					{
						SelectSkill(1);
					}
					else if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP2")
					{
						SelectSkill(2);
					}
					else
					{
						SelectSkill(3);
					}
				}
				((Component)this).audio.PlayOneShot(audioSelect2);
				GameObject gameObject = ((Component)((RaycastHit)(ref hit)).transform).gameObject;
				if (((Object)gameObject).name == "drop" && holdingItem)
				{
					DropItem();
				}
				else if (gameObject.layer == 10 && gameObject.tag != "sIcon" && gameObject.tag != "tIcon")
				{
					int num3 = int.Parse(gameObject.tag);
					if (!holdingItem && inventory[num3].id != 0)
					{
						SelectItem(num3);
					}
					else if (holdingItem && inventory[num3].id == 0)
					{
						PlaceItem(num3, gameObject);
					}
					else if (holdingItem && inventory[num3].id < 500)
					{
						if (inventory[num3].id == itemSelected.id)
						{
							CombineItem(num3);
						}
						else
						{
							SwapItem(num3);
						}
					}
					else if (holdingItem && inventory[num3].id >= 500)
					{
						if (num3 == 20 && itemSelected.id >= 700 && itemSelected.id < 800)
						{
							SwapItem(num3);
						}
						else if (num3 == 21 && itemSelected.id >= 800 && itemSelected.id < 900)
						{
							SwapItem(num3);
						}
						else if (num3 == 22 && itemSelected.id >= 900 && itemSelected.id < 1000)
						{
							SwapItem(num3);
						}
						else if (num3 < 20)
						{
							SwapItem(num3);
						}
					}
				}
				else if (gameObject.layer == 30)
				{
					int num4 = int.Parse(((Object)gameObject).name);
					if (!holdingItem && npcInventory[num4].id != 0)
					{
						SelectItemNPC(num4);
					}
					else if (holdingItem && npcInventory[num4].id == 0)
					{
						PlaceItemNPC(num4, gameObject);
					}
					else if (holdingItem && npcInventory[num4].id < 500)
					{
						if (npcInventory[num4].id == itemSelected.id)
						{
							CombineItemNPC(num4);
						}
						else
						{
							SwapItemNPC(num4);
						}
					}
					else if (holdingItem && npcInventory[num4].id >= 500)
					{
						if (num4 == 20 && itemSelected.id >= 700 && itemSelected.id < 800)
						{
							SwapItemNPC(num4);
						}
						else if (num4 == 21 && itemSelected.id >= 800 && itemSelected.id < 900)
						{
							SwapItemNPC(num4);
						}
						else if (num4 < 20)
						{
							SwapItemNPC(num4);
						}
					}
				}
			}
		}
		else if (Input.GetButtonDown("Use Item") && inventoryOpen && !shifting)
		{
			ResetCraft();
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, ref hit, 20f))
			{
				if (((Component)((RaycastHit)(ref hit)).transform).gameObject.tag == "sP")
				{
					if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP0")
					{
						SelectSkill(0);
					}
					else if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP1")
					{
						SelectSkill(1);
					}
					else if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP2")
					{
						SelectSkill(2);
					}
					else
					{
						SelectSkill(3);
					}
				}
				((Component)this).audio.PlayOneShot(audioSelect);
				GameObject gameObject2 = ((Component)((RaycastHit)(ref hit)).transform).gameObject;
				if (gameObject2.layer == 10)
				{
					int num5 = int.Parse(gameObject2.tag);
					if (!holdingItem && inventory[num5].id != 0 && num5 < 28)
					{
						SelectHalfItem(num5);
					}
					else if (!holdingItem && inventory[num5].id != 0 && num5 >= 28)
					{
						SelectOneItem(num5);
					}
					else if (holdingItem && inventory[num5].id == 0 && num5 < 29)
					{
						PlaceOneItem(num5, gameObject2);
					}
					else if (holdingItem && inventory[num5].id == itemSelected.id && num5 >= 28)
					{
						AddOneItemHolding(num5);
					}
					else if (holdingItem && inventory[num5].id == itemSelected.id)
					{
						AddOneItem(num5);
					}
				}
				else if (gameObject2.layer == 30)
				{
					int num6 = int.Parse(((Object)gameObject2).name);
					if (!holdingItem && npcInventory[num6].id != 0 && num6 < 11)
					{
						SelectHalfItemNPC(num6);
					}
					else if (!holdingItem && npcInventory[num6].id != 0 && num6 == 11)
					{
						SelectOneItemNPC(num6);
					}
					else if (holdingItem && npcInventory[num6].id == 0 && num6 < 11)
					{
						PlaceOneItemNPC(num6, gameObject2);
					}
					else if (holdingItem && npcInventory[num6].id == itemSelected.id && num6 == 11)
					{
						AddOneItemHoldingNPC(num6);
					}
					else if (holdingItem && npcInventory[num6].id == itemSelected.id)
					{
						AddOneItemNPC(num6);
					}
				}
			}
		}
		else if (Input.GetButtonDown("Melee Attack") && inventoryOpen && shifting && !holdingItem)
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, ref hit, 20f))
			{
				GameObject gameObject3 = ((Component)((RaycastHit)(ref hit)).transform).gameObject;
				if (((Component)((RaycastHit)(ref hit)).transform).gameObject.layer == 10)
				{
					int num7 = int.Parse(gameObject3.tag);
					if (gameObject3.layer == 10 && inventory[num7].id != 0)
					{
						((Component)this).audio.PlayOneShot(audioSelect3);
						if (num7 < 20 && !crafting)
						{
							if (num7 == firstItemSelectedSlot)
							{
								firstItemSelectedSlot = -1;
								firstItemSelected = null;
								selectCraft1.SetActive(false);
							}
							else if (!RuntimeServices.EqualityOperator((object)firstItemSelected, (object)null))
							{
								crafting = true;
								secondItemSelected = inventory[num2];
								secondItemSelectedSlot = num7;
								selectCraft2.SetActive(true);
								selectCraft2.transform.position = inventorySlot[num7].transform.position;
								((MonoBehaviour)this).StartCoroutine_Auto(Craft());
							}
							else
							{
								firstItemSelectedSlot = num7;
								firstItemSelected = inventory[num7];
								selectCraft1.SetActive(true);
								selectCraft1.transform.position = inventorySlot[num7].transform.position;
							}
						}
					}
				}
			}
		}
		else if (Input.GetButtonDown("Use Item") && !inventoryOpen && !isDead && !immobilized && !usingItem)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(UseItem(curActiveSlot));
		}
		else if (Input.GetButtonDown("Melee Attack") && !inventoryOpen)
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (!isDead)
			{
				if (MenuScript.multiplayer > 0)
				{
					if (Object.op_Implicit((Object)(object)player) && player.networkView.isMine)
					{
						Attack(curActiveSlot);
					}
				}
				else
				{
					Attack(curActiveSlot);
				}
			}
			if (Physics.Raycast(ray, ref hit, 20f))
			{
				GameObject gameObject4 = ((Component)((RaycastHit)(ref hit)).transform).gameObject;
				if (((Component)((RaycastHit)(ref hit)).transform).gameObject.tag == "sP")
				{
					if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP0")
					{
						SelectSkill(0);
					}
					else if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP1")
					{
						SelectSkill(1);
					}
					else if (((Object)((Component)((RaycastHit)(ref hit)).transform).gameObject).name == "sP2")
					{
						SelectSkill(2);
					}
					else
					{
						SelectSkill(3);
					}
				}
				switch (((Object)gameObject4).name)
				{
				case "bResume":
					Resume();
					break;
				case "bOptions":
					Options();
					break;
				case "bMenu":
					((MonoBehaviour)this).StartCoroutine_Auto(Menuu());
					break;
				case "bQuit":
					SaveStats();
					((MonoBehaviour)this).StartCoroutine_Auto(Menuu());
					break;
				case "bAgain":
					Again();
					break;
				}
			}
		}
		if (!(Input.GetAxis("mS") <= 0f) && !dead)
		{
			Scroll(0);
		}
		else if (!(Input.GetAxis("mS") >= 0f) && !dead)
		{
			Scroll(1);
		}
	}

	public override void DropItem()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		int num = default(int);
		Item item = null;
		GameObject val = null;
		if (MenuScript.multiplayer > 0)
		{
			val = ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= player.transform.position.x) ? ((GameObject)Network.Instantiate(Resources.Load("item"), new Vector3(player.transform.position.x - 3f, player.transform.position.y, 0f), Quaternion.identity, 0)) : ((GameObject)Network.Instantiate(Resources.Load("item"), new Vector3(player.transform.position.x + 3f, player.transform.position.y, 0f), Quaternion.identity, 0)));
			item = new Item(itemSelected.id, itemSelected.q, itemSelected.e, itemSelected.d, null);
			val.networkView.RPC("DR", (RPCMode)6, new object[0]);
			val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
			val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
			val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
			val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
			itemSelected = EmptyItem();
			holdingItem = false;
			sSelected.SetActive(false);
		}
	}

	public override IEnumerator Craft()
	{
		return new _0024Craft_00241485(this).GetEnumerator();
	}

	public override void SaveStats()
	{
		int num = default(int);
		tempEXP = 0f;
		for (num = 0; num < 15; num++)
		{
			tempEXP += ConvertToEXP(num, tempStats[num]);
		}
		PlayerPrefs.SetInt("aEXP", MenuScript.accountEXP);
		for (num = 0; num < 15; num++)
		{
			PlayerPrefs.SetInt("stat" + (object)num, tempStats[num] + PlayerPrefs.GetInt("stat" + (object)num));
		}
		MenuScript.curScore = (int)(tempEXP * 2f);
		if (MenuScript.curScore > PlayerPrefs.GetInt("hScore"))
		{
			PlayerPrefs.SetInt("hScore", MenuScript.curScore);
		}
		SetRewards();
	}

	public override bool ChanceRace(int a)
	{
		int num = 0;
		return (Random.Range(0, a switch
		{
			3 => 20, 
			4 => 20, 
			6 => 1, 
			8 => 1, 
			_ => 5, 
		}) == 0) ? true : false;
	}

	public override bool ChanceHat(int a)
	{
		int num = 0;
		return (Random.Range(0, a switch
		{
			2 => 20, 
			4 => 20, 
			5 => 20, 
			12 => 1, 
			_ => 5, 
		}) == 0) ? true : false;
	}

	public override void SetRewards()
	{
		int num = default(int);
		int num2 = default(int);
		for (num = 0; num < playerLevel; num++)
		{
			if (Random.Range(0, 5) != 0)
			{
				continue;
			}
			num2 = Random.Range(0, 50);
			while (reward[num2] != 0)
			{
				num2++;
				if (num2 > 49)
				{
					num2 = 0;
				}
			}
			reward[num2] = 999;
		}
		for (num = 0; num < 15; num++)
		{
			MonoBehaviour.print((object)((object)num + " CAN UNLOCK? " + (object)MenuScript.canUnlockRace[num] + " Chance? " + (object)ChanceRace(num)));
			if (MenuScript.raceUnlock[num] >= 3 || MenuScript.canUnlockRace[num] != 1 || !ChanceRace(num))
			{
				continue;
			}
			num2 = Random.Range(0, 50);
			while (reward[num2] != 0)
			{
				num2++;
				if (num2 > 49)
				{
					num2 = 0;
				}
			}
			reward[num2] = num + 1;
			MonoBehaviour.print((object)("temp is " + (object)num2));
			if (MenuScript.raceUnlock[num] > 0)
			{
				isVariant[num] = true;
			}
			else
			{
				isVariant[num] = false;
			}
		}
		for (num = 0; num < 10; num++)
		{
			if (MenuScript.compUnlock[num] != 1)
			{
				continue;
			}
			num2 = Random.Range(0, 50);
			while (reward[num2] != 0)
			{
				num2++;
				if (num2 > 49)
				{
					num2 = 0;
				}
			}
			reward[num2] = num + 100;
		}
		for (num = 0; num < 24; num++)
		{
			if (MenuScript.hatUnlock[num] != 0 || MenuScript.canUnlockHat[num] != 1 || !ChanceHat(1))
			{
				continue;
			}
			num2 = Random.Range(0, 50);
			while (reward[num2] != 0)
			{
				num2++;
				if (num2 > 49)
				{
					num2 = 0;
				}
			}
			reward[num2] = num + 200;
		}
		RewardShowCheck();
	}

	public override void CloseReward()
	{
		selectingReward = false;
		GetNextReward();
		rewardTop.SetActive(false);
		rewardBot.SetActive(false);
		rewardShade.SetActive(false);
	}

	public override IEnumerator SelectReward(int c)
	{
		return new _0024SelectReward_00241502(c, this).GetEnumerator();
	}

	public override IEnumerator UnlockHat(int h)
	{
		return new _0024UnlockHat_00241510(h, this).GetEnumerator();
	}

	public override IEnumerator UnlockComp(int h)
	{
		return new _0024UnlockComp_00241515(h, this).GetEnumerator();
	}

	public override IEnumerator UnlockVariant(int r)
	{
		return new _0024UnlockVariant_00241520(r, this).GetEnumerator();
	}

	public override IEnumerator UnlockRace(int h)
	{
		return new _0024UnlockRace_00241525(h, this).GetEnumerator();
	}

	public override string GetHatName(int a)
	{
		string text = null;
		int num = a - 1;
		if (num < 1)
		{
			num = 1;
		}
		return num switch
		{
			1 => "Gatherer Headband", 
			2 => "Miner Cap", 
			3 => "Berserker Scarf", 
			4 => "Robin Hood Hat", 
			5 => "Magician Hat", 
			6 => "Bunny Ears", 
			7 => "Bat Wing", 
			8 => "Tyrannox Hat", 
			9 => "Wasp Glasses", 
			10 => "Tiki Mask", 
			11 => "Wizard Beard", 
			12 => "Hero Crown", 
			13 => "Shroom Hat", 
			14 => "Spider Egg", 
			15 => "Skeleton Mask", 
			16 => "Dragon Hat", 
			17 => "Scourge Mask", 
			_ => string.Empty, 
		};
	}

	public override string GetRaceName(int race)
	{
		string text = null;
		return race switch
		{
			0 => "Peon", 
			1 => "Noble", 
			2 => "Orclops", 
			3 => "Dwelf", 
			4 => "Crusader", 
			5 => "Remnant", 
			6 => "Trogon", 
			7 => "Earthkin", 
			8 => "Pigfolk", 
			_ => "null", 
		};
	}

	public override string GetCompName(int a)
	{
		string result = null;
		switch (a)
		{
		case 0:
			result = "Tealith";
			break;
		case 1:
			result = "Blueos";
			break;
		case 2:
			result = "Redral";
			break;
		case 3:
			result = "Purplet";
			break;
		case 4:
			result = "Greenon";
			break;
		case 5:
			result = "Violeta";
			break;
		case 6:
			result = "Orangeon";
			break;
		case 7:
			result = "Magentai";
			break;
		case 8:
			result = "Celadon";
			break;
		case 9:
			result = "Goldius";
			break;
		case 10:
			result = string.Empty;
			break;
		}
		return result;
	}

	public override int GetScoreBonus()
	{
		int num = Random.Range(0, 100);
		int num2 = 0;
		if (num > 90)
		{
			return 500;
		}
		if (num > 70)
		{
			return 200;
		}
		return 50;
	}

	public override void RewardShowCheck()
	{
		int num = default(int);
		int num2 = default(int);
		for (num = 0; num < 4; num++)
		{
			if (rewardChest[num] == 0)
			{
				num2 = GetNextReward();
				if (num2 == 0)
				{
					rewardChestObj[num].renderer.material = rewShade;
					rewardChest[num] = 0;
					rewardChestObj[num].animation.Stop();
				}
				else
				{
					rewardChestObj[num].renderer.material = rewChest;
					rewardChestObj[num].animation.Play();
					rewardChest[num] = num2;
				}
			}
		}
	}

	public override int GetNextReward()
	{
		int num = default(int);
		int result = 0;
		for (num = 0; num < 50; num++)
		{
			if (reward[num] > 0)
			{
				result = reward[num];
				reward[num] = 0;
				break;
			}
		}
		return result;
	}

	public override float ConvertToEXP(int s, float v)
	{
		v = s switch
		{
			1 => v * 0.5f, 
			2 => v * 0.5f, 
			3 => v * 0.3f, 
			4 => v * 0.3f, 
			5 => v * 1f, 
			6 => v * 0.4f, 
			7 => v * 0.4f, 
			8 => v * 0.3f, 
			9 => v * 0.7f, 
			10 => v * 2f, 
			11 => v * 10f, 
			12 => v * 2f, 
			13 => v * 60f, 
			14 => v * 4f, 
			_ => v * 0.1f, 
		};
		return v;
	}

	public override void BreakSound()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		((Component)this).gameObject.audio.PlayOneShot((AudioClip)Resources.Load("Au/break", typeof(AudioClip)));
	}

	public override void ResetCraft()
	{
		firstItemSelected = null;
		secondItemSelected = null;
		firstItemSelectedSlot = -1;
		secondItemSelectedSlot = -1;
		crafting = false;
		selectCraft1.SetActive(false);
		selectCraft2.SetActive(false);
	}

	public override void ExitMenuSave()
	{
	}

	public override IEnumerator Menuu()
	{
		return new _0024Menuu_00241530(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator AgainN()
	{
		return new _0024AgainN_00241533(this).GetEnumerator();
	}

	public override void Again()
	{
		if (Network.isServer)
		{
			player.networkView.RPC("AgainN", (RPCMode)2, new object[0]);
		}
	}

	public override void Stamina()
	{
		barStamina.animation.Play();
	}

	public override void ReturnTown()
	{
		changingScene = true;
		isReturning = true;
		isInstance = false;
		SaveInventory();
		if (MenuScript.multiplayer > 0)
		{
			player.networkView.RPC("LoadLevel", (RPCMode)6, new object[2] { 1, false });
		}
		else
		{
			Application.LoadLevel(1);
		}
	}

	public override void LeaveTown()
	{
		changingScene = true;
		isInstance = true;
		SaveInventory();
		if (MenuScript.multiplayer > 0)
		{
			player.networkView.RPC("LoadLevel", (RPCMode)6, new object[2] { 1, true });
		}
		else
		{
			Application.LoadLevel(1);
		}
	}

	public override void SpawnTown()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		curStyle = Random.Range(1, 2);
		Object.Instantiate(Resources.Load("z/zEntrance"), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 180f));
		num = Random.Range(1, 9);
		switch (num)
		{
		case 1:
			num2 -= 8;
			break;
		case 2:
			num2 += 8;
			break;
		case 3:
			num2 -= 8;
			break;
		case 4:
			num2 += 8;
			break;
		case 5:
			num2 -= 8;
			break;
		case 6:
			num2 += 8;
			break;
		case 7:
			num2 += 0;
			break;
		case 8:
			num2 += 0;
			break;
		case 9:
			num2 += 8;
			break;
		case 10:
			num2 += 0;
			break;
		}
		num4 = num3 + num2;
		Object.Instantiate(Resources.Load("z/zone" + (object)num), new Vector3(40f, (float)num4, 0f), Quaternion.Euler(0f, 180f, 180f));
		switch (num)
		{
		case 1:
			num3 -= 8;
			break;
		case 2:
			num3 += 8;
			break;
		case 3:
			num3 -= 8;
			break;
		case 4:
			num3 += 8;
			break;
		case 5:
			num3 -= 8;
			break;
		case 6:
			num3 += 8;
			break;
		case 7:
			num3 += 0;
			break;
		case 8:
			num3 += 0;
			break;
		case 9:
			num3 += 0;
			break;
		case 10:
			num3 -= 8;
			break;
		}
		curZone++;
		num4 = num3 + num2;
		Object.Instantiate(Resources.Load("z/zExit"), new Vector3(80f, (float)num4, 0f), Quaternion.Euler(0f, 180f, 180f));
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

	public override void SpawnTownNetwork()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		curStyle = Random.Range(1, 2);
		Network.Instantiate(Resources.Load("z/zEntrance"), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
		num = Random.Range(1, 9);
		switch (num)
		{
		case 1:
			num2 -= 8;
			break;
		case 2:
			num2 += 8;
			break;
		case 3:
			num2 -= 8;
			break;
		case 4:
			num2 += 8;
			break;
		case 5:
			num2 -= 8;
			break;
		case 6:
			num2 += 8;
			break;
		case 7:
			num2 += 0;
			break;
		case 8:
			num2 += 0;
			break;
		case 9:
			num2 += 8;
			break;
		case 10:
			num2 += 0;
			break;
		}
		num4 = num3 + num2;
		Network.Instantiate(Resources.Load("z/zone" + (object)num), new Vector3(40f, (float)num4, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
		switch (num)
		{
		case 1:
			num3 -= 8;
			break;
		case 2:
			num3 += 8;
			break;
		case 3:
			num3 -= 8;
			break;
		case 4:
			num3 += 8;
			break;
		case 5:
			num3 -= 8;
			break;
		case 6:
			num3 += 8;
			break;
		case 7:
			num3 += 0;
			break;
		case 8:
			num3 += 0;
			break;
		case 9:
			num3 += 0;
			break;
		case 10:
			num3 -= 8;
			break;
		}
		curZone++;
		num4 = num3 + num2;
		Network.Instantiate(Resources.Load("z/zExit"), new Vector3(80f, (float)num4, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
	}

	public override void SetBGNetwork(int tBiome)
	{
	}

	public override Vector3 GetHousePos(int a)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		return (Vector3)(a switch
		{
			0 => new Vector3(-9f, 3.5f, 1.5f), 
			1 => new Vector3(-5f, 3.5f, 1.5f), 
			2 => new Vector3(5f, 3.5f, 1.5f), 
			3 => new Vector3(9f, 3.5f, 1.5f), 
			4 => new Vector3(-9f, -4f, 1.5f), 
			5 => new Vector3(-5f, -4f, 1.5f), 
			6 => new Vector3(0f, -4f, 1.5f), 
			7 => new Vector3(5f, -4f, 1.5f), 
			8 => new Vector3(9f, -4f, 1.5f), 
			_ => val, 
		});
	}

	public override void UseMana(int m)
	{
		MAG -= m;
		barMana.animation.Play();
		LoadMana();
	}

	public override IEnumerator ThrowPoison()
	{
		return new _0024ThrowPoison_00241536(this).GetEnumerator();
	}

	public override IEnumerator ThrowDagger(int a)
	{
		return new _0024ThrowDagger_00241540(a, this).GetEnumerator();
	}

	public override IEnumerator ThrowRock()
	{
		return new _0024ThrowRock_00241551(this).GetEnumerator();
	}

	public override IEnumerator UseHPPotion(int heal)
	{
		return new _0024UseHPPotion_00241555(heal, this).GetEnumerator();
	}

	public override IEnumerator UseManaPotion(int heal)
	{
		return new _0024UseManaPotion_00241561(heal, this).GetEnumerator();
	}

	public override IEnumerator UseItem(int slot)
	{
		return new _0024UseItem_00241567(slot, this).GetEnumerator();
	}

	public override void Poop()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer > 0)
		{
			player.audio.PlayOneShot((AudioClip)Resources.Load("Au/poop"));
			Network.Instantiate(Resources.Load("poop"), player.transform.position, Quaternion.identity, 0);
		}
	}

	public override void Attack(int slot)
	{
		if (!attacking)
		{
			attacking = true;
			((MonoBehaviour)this).StartCoroutine_Auto(MeleeAttack());
		}
	}

	public override void UseKey()
	{
	}

	public override IEnumerator MeleeAttack()
	{
		return new _0024MeleeAttack_00241599(this).GetEnumerator();
	}

	public override IEnumerator KnockBack(Transform h)
	{
		return new _0024KnockBack_00241606(h).GetEnumerator();
	}

	public override void SelectOneItemNPC(int slot)
	{
		if (npcInventory[slot].id < 500)
		{
			((Component)this).audio.PlayOneShot(audioCrafted);
			itemSelected = new Item(npcInventory[slot].id, 1, npcInventory[slot].e, npcInventory[slot].d, null);
			UpdateHoldingItem();
			holdingItem = true;
			npcInventory[slot].q = npcInventory[slot].q - 1;
			npcInventory[0].q = npcInventory[0].q - 1;
			npcInventory[1].q = npcInventory[1].q - 1;
			if (npcInventory[0].q <= 0)
			{
				npcInventory[0].id = 0;
			}
			if (npcInventory[1].q <= 0)
			{
				npcInventory[1].id = 0;
			}
			BarCheck();
			if (slot == 2 || slot == 3 || slot == 4)
			{
				HelmCheck();
			}
			if (slot == 5 || slot == 6 || slot == 7)
			{
				ArmorCheck();
			}
			if (slot == 8 || slot == 9 || slot == 10)
			{
				ShieldCheck();
			}
			RefreshBlacksmith();
		}
		else
		{
			SelectItem(slot);
		}
	}

	public override void SelectOneItem(int slot)
	{
		if (inventory[slot].id < 500)
		{
			itemSelected = new Item(inventory[slot].id, 1, inventory[slot].e, inventory[slot].d, null);
			UpdateHoldingItem();
			holdingItem = true;
			inventory[slot].q = inventory[slot].q - 1;
		}
		else
		{
			SelectItem(slot);
		}
	}

	public override void SelectHalfItemNPC(int slot)
	{
		int num = default(int);
		if (npcInventory[slot].q == 1)
		{
			SelectItemNPC(slot);
		}
		else if (npcInventory[slot].q % 2 == 0)
		{
			itemSelected = new Item(npcInventory[slot].id, (int)((float)npcInventory[slot].q * 0.5f), npcInventory[slot].e, npcInventory[slot].d, null);
			npcInventory[slot].q = (int)((float)npcInventory[slot].q * 0.5f);
			UpdateHoldingItem();
			holdingItem = true;
			num = itemSelected.q;
			if (slot == 11)
			{
				npcInventory[0].q = npcInventory[0].q - num;
				npcInventory[1].q = npcInventory[1].q - num;
			}
		}
		else
		{
			itemSelected = new Item(npcInventory[slot].id, (int)((float)npcInventory[slot].q * 0.5f + 1f), npcInventory[slot].e, npcInventory[slot].d, null);
			npcInventory[slot].q = (int)((float)npcInventory[slot].q * 0.5f);
			holdingItem = true;
			UpdateHoldingItem();
			num = itemSelected.q;
			if (slot == 11)
			{
				npcInventory[0].q = npcInventory[0].q - num;
				npcInventory[1].q = npcInventory[1].q - num;
			}
		}
		if (slot == 1 || slot == 0)
		{
			BarCheck();
		}
		RefreshBlacksmith();
	}

	public override void SelectHalfItem(int slot)
	{
		int num = default(int);
		if (slot >= 20 && slot <= 25)
		{
			return;
		}
		if (inventory[slot].q == 1 || inventory[slot].q == 0)
		{
			SelectItem(slot);
		}
		else if (inventory[slot].q % 2 == 0)
		{
			itemSelected = new Item(inventory[slot].id, (int)((float)inventory[slot].q * 0.5f), inventory[slot].e, inventory[slot].d, null);
			inventory[slot].q = (int)((float)inventory[slot].q * 0.5f);
			UpdateHoldingItem();
			holdingItem = true;
			if (slot < 5)
			{
				RefreshActionBar();
			}
			else
			{
				RefreshInventory();
			}
			num = itemSelected.q;
			if (slot > 27)
			{
				inventory[26].q = inventory[26].q - num;
				inventory[27].q = inventory[27].q - num;
				RefreshInventory();
			}
		}
		else
		{
			itemSelected = new Item(inventory[slot].id, (int)((float)inventory[slot].q * 0.5f + 1f), inventory[slot].e, inventory[slot].d, null);
			inventory[slot].q = (int)((float)inventory[slot].q * 0.5f);
			holdingItem = true;
			UpdateHoldingItem();
			if (slot < 5)
			{
				RefreshActionBar();
			}
			else
			{
				RefreshInventory();
			}
			num = itemSelected.q;
			if (slot > 27)
			{
				inventory[26].q = inventory[26].q - num;
				inventory[27].q = inventory[27].q - num;
				RefreshInventory();
			}
		}
	}

	public override void SelectItemNPC(int slot)
	{
		holdingItem = true;
		Item item = null;
		switch (slot)
		{
		case 11:
			((Component)this).audio.PlayOneShot(audioCrafted);
			if (npcInventory[0].q > lowestQ)
			{
				npcInventory[0].q = npcInventory[0].q - lowestQ;
			}
			else
			{
				npcInventory[0] = EmptyItem();
			}
			if (npcInventory[1].q > lowestQ)
			{
				npcInventory[1].q = npcInventory[1].q - lowestQ;
			}
			else
			{
				npcInventory[1] = EmptyItem();
			}
			itemSelected = npcInventory[11];
			npcInventory[11] = EmptyItem();
			break;
		case 0:
		case 1:
			BarCheck();
			itemSelected = npcInventory[slot];
			npcInventory[slot] = EmptyItem();
			break;
		case 2:
		case 3:
		case 4:
			HelmCheck();
			itemSelected = npcInventory[slot];
			npcInventory[slot] = EmptyItem();
			break;
		case 5:
		case 6:
		case 7:
			ArmorCheck();
			itemSelected = npcInventory[slot];
			npcInventory[slot] = EmptyItem();
			break;
		case 8:
		case 9:
		case 10:
			ShieldCheck();
			itemSelected = npcInventory[slot];
			npcInventory[slot] = EmptyItem();
			break;
		case 12:
			((Component)this).audio.PlayOneShot(audioCrafted);
			if (npcInventory[2].q > 1)
			{
				npcInventory[2].q = npcInventory[2].q - 1;
			}
			else
			{
				npcInventory[2] = EmptyItem();
			}
			if (npcInventory[3].q > 1)
			{
				npcInventory[3].q = npcInventory[3].q - 1;
			}
			else
			{
				npcInventory[3] = EmptyItem();
			}
			if (npcInventory[4].q > 1)
			{
				npcInventory[4].q = npcInventory[4].q - 1;
			}
			else
			{
				npcInventory[4] = EmptyItem();
			}
			item = new Item(npcInventory[12].id, 1, GetGearStats(npcInventory[12].id), GetMaxDurability(npcInventory[12].id), null);
			itemSelected = item;
			npcInventory[12] = EmptyItem();
			HelmCheck();
			break;
		case 13:
			((Component)this).audio.PlayOneShot(audioCrafted);
			if (npcInventory[5].q > 1)
			{
				npcInventory[5].q = npcInventory[5].q - 1;
			}
			else
			{
				npcInventory[5] = EmptyItem();
			}
			if (npcInventory[6].q > 1)
			{
				npcInventory[6].q = npcInventory[6].q - 1;
			}
			else
			{
				npcInventory[6] = EmptyItem();
			}
			if (npcInventory[7].q > 1)
			{
				npcInventory[7].q = npcInventory[7].q - 1;
			}
			else
			{
				npcInventory[7] = EmptyItem();
			}
			item = new Item(npcInventory[13].id, 1, GetGearStats(npcInventory[13].id), GetMaxDurability(npcInventory[13].id), null);
			itemSelected = item;
			npcInventory[13] = EmptyItem();
			ArmorCheck();
			break;
		case 14:
			((Component)this).audio.PlayOneShot(audioCrafted);
			if (npcInventory[8].q > 1)
			{
				npcInventory[8].q = npcInventory[8].q - 1;
			}
			else
			{
				npcInventory[8] = EmptyItem();
			}
			if (npcInventory[9].q > 1)
			{
				npcInventory[9].q = npcInventory[9].q - 1;
			}
			else
			{
				npcInventory[9] = EmptyItem();
			}
			if (npcInventory[10].q > 1)
			{
				npcInventory[10].q = npcInventory[10].q - 1;
			}
			else
			{
				npcInventory[10] = EmptyItem();
			}
			item = new Item(npcInventory[14].id, 1, GetGearStats(npcInventory[14].id), GetMaxDurability(npcInventory[14].id), null);
			itemSelected = item;
			npcInventory[14] = EmptyItem();
			ShieldCheck();
			break;
		default:
			itemSelected = npcInventory[slot];
			npcInventory[slot] = EmptyItem();
			break;
		}
		switch (slot)
		{
		case 0:
		case 1:
			npcInventory[slot] = EmptyItem();
			BarCheck();
			break;
		case 2:
		case 3:
		case 4:
			npcInventory[slot] = EmptyItem();
			HelmCheck();
			break;
		case 5:
		case 6:
		case 7:
			npcInventory[slot] = EmptyItem();
			ArmorCheck();
			break;
		case 8:
		case 9:
		case 10:
			npcInventory[slot] = EmptyItem();
			ShieldCheck();
			break;
		}
		RefreshBlacksmith();
		UpdateHoldingItem();
		RefreshBlacksmith();
	}

	public override void SelectItem(int slot)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		switch (slot)
		{
		case 20:
			PlayerController.helm = 0;
			for (num = 0; num < 4; num++)
			{
				if (tempGearStat[num] - inventory[slot].e[num] >= 0)
				{
					tempGearStat[num] -= inventory[slot].e[num];
				}
			}
			if (MenuScript.multiplayer > 0)
			{
				if (player.networkView.isMine)
				{
					PlayerControllerN.helm = 0;
					num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
					num3 = PlayerControllerN.armor;
					num4 = PlayerControllerN.offhand;
					player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
					{
						num2,
						num3,
						MenuScript.pRace,
						num4,
						MenuScript.pHat
					});
				}
			}
			else
			{
				player.SendMessage("UpdateHead", (object)MenuScript.pVariant);
			}
			break;
		case 21:
			PlayerController.armor = 0;
			if (MenuScript.multiplayer > 0)
			{
				if (player.networkView.isMine)
				{
					PlayerControllerN.armor = 0;
					num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
					num3 = PlayerControllerN.armor;
					num4 = PlayerControllerN.offhand;
					player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
					{
						num2,
						num3,
						MenuScript.pRace,
						num4,
						MenuScript.pHat
					});
				}
			}
			else
			{
				player.SendMessage("UpdateBody", (object)MenuScript.pBody);
			}
			for (num = 0; num < 4; num++)
			{
				if (tempGearStat[num] - inventory[slot].e[num] >= 0)
				{
					tempGearStat[num] -= inventory[slot].e[num];
				}
			}
			break;
		case 22:
			PlayerController.offhand = 0;
			if (MenuScript.multiplayer > 0)
			{
				if (player.networkView.isMine)
				{
					PlayerControllerN.offhand = 0;
					num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
					num3 = PlayerControllerN.armor;
					num4 = PlayerControllerN.offhand;
					player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
					{
						num2,
						num3,
						MenuScript.pRace,
						num4,
						MenuScript.pHat
					});
					inventoryQ[slot].text = string.Empty + (object)inventory[slot].q;
				}
			}
			else
			{
				player.SendMessage("UpdateOffhand", (object)MenuScript.pOffhand);
			}
			for (num = 0; num < 4; num++)
			{
				if (tempGearStat[num] - inventory[slot].e[num] >= 0)
				{
					tempGearStat[num] -= inventory[slot].e[num];
				}
			}
			break;
		}
		holdingItem = true;
		itemSelected = inventory[slot];
		inventory[slot] = EmptyItem();
		UpdateHoldingItem();
		if (slot < 5)
		{
			RefreshActionBar();
		}
		else
		{
			RefreshInventory();
		}
		UpdateCharacterWeapon();
	}

	public override Item EmptyItem()
	{
		return new Item(0, 0, new int[4], 0f, null);
	}

	public override void UpdateHoldingItem()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		sSelected.renderer.material = (Material)Resources.Load("i/i" + (object)itemSelected.id);
		sSelected.SetActive(true);
		if (itemSelected.q > 1)
		{
			selectedQ.text = string.Empty + (object)itemSelected.q;
		}
		else
		{
			selectedQ.text = string.Empty;
		}
	}

	public override void PlaceItemNPC(int slot, GameObject g)
	{
		if (slot < 11)
		{
			holdingItem = false;
			npcInventory[slot] = itemSelected;
			itemSelected = EmptyItem();
			sSelected.SetActive(false);
			switch (slot)
			{
			case 0:
			case 1:
				BarCheck();
				break;
			case 2:
			case 3:
			case 4:
				HelmCheck();
				break;
			case 5:
			case 6:
			case 7:
				ArmorCheck();
				break;
			case 8:
			case 9:
			case 10:
				ShieldCheck();
				break;
			}
			RefreshBlacksmith();
		}
	}

	public override void BarCheck()
	{
		if (npcInventory[0].id != 0 && npcInventory[1].id != 0)
		{
			string text = (object)npcInventory[0].id + "c" + (object)npcInventory[1].id;
			if (npcInventory[0].q < npcInventory[1].q)
			{
				lowestQ = npcInventory[0].q;
			}
			else
			{
				lowestQ = npcInventory[1].q;
			}
			switch (text)
			{
			case "4c4":
				CraftShow(12, lowestQ, 11);
				break;
			case "5c5":
				CraftShow(13, lowestQ, 11);
				break;
			case "6c6":
				CraftShow(14, lowestQ, 11);
				break;
			default:
				npcInventory[11] = EmptyItem();
				RefreshBlacksmith();
				break;
			}
		}
		else
		{
			npcInventory[11] = EmptyItem();
			RefreshBlacksmith();
		}
	}

	public override void HelmCheck()
	{
		if (npcInventory[2].id != 0 && npcInventory[3].id != 0 && npcInventory[4].id != 0)
		{
			string text = (object)npcInventory[2].id + "c" + (object)npcInventory[3].id + "c" + (object)npcInventory[4].id;
			int num = default(int);
			lowestQ = npcInventory[2].q;
			if (npcInventory[3].q < lowestQ)
			{
				lowestQ = npcInventory[3].q;
			}
			if (npcInventory[4].q < lowestQ)
			{
				lowestQ = npcInventory[4].q;
			}
			switch (text)
			{
			case "12c12c12":
				CraftShow(700, 1, 12);
				break;
			case "13c13c13":
				CraftShow(701, 1, 12);
				break;
			case "14c14c14":
				CraftShow(702, 1, 12);
				break;
			case "39c39c39":
				CraftShow(703, 1, 12);
				break;
			case "51c51c51":
				CraftShow(704, 1, 12);
				break;
			default:
				npcInventory[12] = EmptyItem();
				RefreshBlacksmith();
				break;
			}
		}
		else
		{
			npcInventory[12] = EmptyItem();
			RefreshBlacksmith();
		}
	}

	public override void ArmorCheck()
	{
		if (npcInventory[5].id != 0 && npcInventory[6].id != 0 && npcInventory[7].id != 0)
		{
			string text = (object)npcInventory[5].id + "c" + (object)npcInventory[6].id + "c" + (object)npcInventory[7].id;
			int num = default(int);
			lowestQ = npcInventory[5].q;
			if (lowestQ > npcInventory[6].q)
			{
			}
			lowestQ = npcInventory[6].q;
			if (lowestQ > npcInventory[6].q)
			{
			}
			lowestQ = npcInventory[6].q;
			switch (text)
			{
			case "12c12c12":
				CraftShow(800, 1, 13);
				break;
			case "13c13c13":
				CraftShow(801, 1, 13);
				break;
			case "14c14c14":
				CraftShow(802, 1, 13);
				break;
			case "39c39c39":
				CraftShow(803, 1, 13);
				break;
			case "51c51c51":
				CraftShow(804, 1, 13);
				break;
			default:
				npcInventory[13] = EmptyItem();
				RefreshBlacksmith();
				break;
			}
		}
		else
		{
			npcInventory[13] = EmptyItem();
			RefreshBlacksmith();
		}
	}

	public override void ShieldCheck()
	{
		if (npcInventory[8].id != 0 && npcInventory[9].id != 0 && npcInventory[10].id != 0)
		{
			string text = (object)npcInventory[8].id + "c" + (object)npcInventory[9].id + "c" + (object)npcInventory[10].id;
			int num = default(int);
			lowestQ = npcInventory[8].q;
			if (lowestQ > npcInventory[9].q)
			{
			}
			lowestQ = npcInventory[9].q;
			if (lowestQ > npcInventory[10].q)
			{
			}
			lowestQ = npcInventory[10].q;
			switch (text)
			{
			case "12c12c12":
				CraftShow(900, 1, 14);
				break;
			case "13c13c13":
				CraftShow(901, 1, 14);
				break;
			case "14c14c14":
				CraftShow(902, 1, 14);
				break;
			case "39c39c39":
				CraftShow(903, 1, 14);
				break;
			case "51c51c51":
				CraftShow(904, 1, 14);
				break;
			default:
				npcInventory[14] = EmptyItem();
				RefreshBlacksmith();
				break;
			}
		}
		else
		{
			npcInventory[14] = EmptyItem();
			RefreshBlacksmith();
		}
	}

	public override void PlaceItem(int slot, GameObject g)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		if (slot < 28)
		{
			switch (slot)
			{
			case 20:
				if (itemSelected.id < 700 || itemSelected.id >= 800)
				{
					break;
				}
				holdingItem = false;
				inventory[slot] = itemSelected;
				itemSelected = EmptyItem();
				sSelected.SetActive(false);
				PlayerController.helm = inventory[slot].id;
				if (MenuScript.multiplayer > 0 && player.networkView.isMine)
				{
					PlayerControllerN.helm = inventory[slot].id;
				}
				for (num = 0; num < 4; num++)
				{
					tempGearStat[num] += inventory[slot].e[num];
				}
				if (MenuScript.multiplayer > 0)
				{
					if (player.networkView.isMine)
					{
						num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
						num3 = PlayerControllerN.armor;
						num4 = PlayerControllerN.offhand;
						player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
						{
							num2,
							num3,
							MenuScript.pRace,
							num4,
							MenuScript.pHat
						});
					}
				}
				else
				{
					player.SendMessage("UpdateHead", (object)inventory[slot].id);
				}
				RefreshInventory();
				break;
			case 21:
				if (itemSelected.id < 800 || itemSelected.id >= 900)
				{
					break;
				}
				holdingItem = false;
				inventory[slot] = itemSelected;
				PlayerController.armor = itemSelected.id;
				if (MenuScript.multiplayer > 0)
				{
					if (player.networkView.isMine)
					{
						PlayerControllerN.armor = inventory[slot].id;
						num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
						num3 = PlayerControllerN.armor;
						num4 = PlayerControllerN.offhand;
						player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
						{
							num2,
							num3,
							MenuScript.pRace,
							num4,
							MenuScript.pHat
						});
					}
				}
				else
				{
					player.SendMessage("UpdateBody", (object)itemSelected.id);
				}
				for (num = 0; num < 4; num++)
				{
					tempGearStat[num] += inventory[slot].e[num];
				}
				itemSelected = EmptyItem();
				sSelected.SetActive(false);
				RefreshInventory();
				break;
			case 22:
				if (itemSelected.id < 900 || itemSelected.id >= 1000)
				{
					break;
				}
				holdingItem = false;
				inventory[slot] = itemSelected;
				for (num = 0; num < 4; num++)
				{
					tempGearStat[num] += inventory[slot].e[num];
				}
				PlayerController.offhand = itemSelected.id;
				if (MenuScript.multiplayer > 0)
				{
					if (player.networkView.isMine)
					{
						PlayerControllerN.offhand = inventory[slot].id;
						num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
						num3 = PlayerControllerN.armor;
						num4 = PlayerControllerN.offhand;
						player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
						{
							num2,
							num3,
							MenuScript.pRace,
							num4,
							MenuScript.pHat
						});
					}
				}
				else
				{
					player.SendMessage("UpdateOffhand", (object)itemSelected.id);
				}
				itemSelected = EmptyItem();
				sSelected.SetActive(false);
				RefreshInventory();
				break;
			case 23:
				if (itemSelected.id >= 52 && itemSelected.id <= 56)
				{
					holdingItem = false;
					inventory[slot] = itemSelected;
					itemSelected = EmptyItem();
					inventoryQ[slot].text = string.Empty + (object)inventory[slot].q;
					sSelected.SetActive(false);
					RefreshInventory();
				}
				break;
			case 100:
				if (itemSelected.id == 4 || itemSelected.id == 5 || itemSelected.id == 6)
				{
					holdingItem = false;
					npcInventory[int.Parse(((Object)g).name)] = itemSelected;
					itemSelected = EmptyItem();
					sSelected.SetActive(false);
					RefreshBlacksmith();
				}
				break;
			default:
				holdingItem = false;
				inventory[slot] = itemSelected;
				itemSelected = EmptyItem();
				sSelected.SetActive(false);
				if (slot < 5)
				{
					RefreshActionBar();
				}
				else
				{
					RefreshInventory();
				}
				break;
			case 24:
			case 25:
				break;
			}
		}
		UpdateCharacterWeapon();
	}

	public override void RefreshBlacksmith()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		int num = default(int);
		for (num = 0; num < 15; num++)
		{
			if (npcInventory[num].id != 0)
			{
				bSmithObject[num].renderer.enabled = true;
				bSmithObject[num].renderer.material = (Material)Resources.Load("i/i" + (object)npcInventory[num].id);
				if (npcInventory[num].q > 1 && npcInventory[num].id < 500)
				{
					bSmithText[num].text = string.Empty + (object)npcInventory[num].q;
				}
				else
				{
					bSmithText[num].text = string.Empty;
				}
			}
			else
			{
				bSmithObject[num].renderer.enabled = false;
				bSmithText[num].text = string.Empty;
			}
		}
	}

	public override void CraftShow(int s0, int q, int i)
	{
		npcInventory[i] = new Item(s0, q, new int[4], 0f, null);
		RefreshBlacksmith();
	}

	public override void PlaceOneItemNPC(int slot, GameObject g)
	{
		if (itemSelected.id >= 500)
		{
			PlaceItemNPC(slot, g);
			return;
		}
		npcInventory[slot] = new Item(itemSelected.id, 1, itemSelected.e, itemSelected.d, null);
		itemSelected.q--;
		RefreshBlacksmith();
		if (itemSelected.q == 0)
		{
			holdingItem = false;
			itemSelected = EmptyItem();
			sSelected.SetActive(false);
		}
		UpdateHoldingItem();
		switch (slot)
		{
		case 0:
		case 1:
			BarCheck();
			break;
		case 2:
		case 3:
		case 4:
			HelmCheck();
			break;
		case 5:
		case 6:
		case 7:
			ArmorCheck();
			break;
		case 8:
		case 9:
		case 10:
			ShieldCheck();
			break;
		}
	}

	public override void PlaceOneItem(int slot, GameObject g)
	{
		if (slot >= 28)
		{
			return;
		}
		if (itemSelected.id >= 500)
		{
			PlaceItem(slot, g);
			return;
		}
		inventory[slot] = new Item(itemSelected.id, 1, itemSelected.e, itemSelected.d, null);
		itemSelected.q--;
		switch (slot)
		{
		case 26:
			craft0 = inventory[slot];
			if (slot < 5)
			{
				RefreshActionBar();
			}
			else
			{
				RefreshInventory();
			}
			break;
		case 27:
			craft1 = inventory[slot];
			if (slot < 5)
			{
				RefreshActionBar();
			}
			else
			{
				RefreshInventory();
			}
			break;
		}
		if (itemSelected.q == 0)
		{
			holdingItem = false;
			itemSelected = EmptyItem();
			sSelected.SetActive(false);
		}
		UpdateHoldingItem();
		if (slot < 5)
		{
			RefreshActionBar();
		}
		else
		{
			RefreshInventory();
		}
		UpdateCharacterWeapon();
	}

	public override void AddOneItemHoldingNPC(int slot)
	{
		if (npcInventory[slot].id >= 500)
		{
			return;
		}
		switch (slot)
		{
		case 11:
			((Component)this).audio.PlayOneShot(audioCrafted);
			if (npcInventory[0].q > 1)
			{
				npcInventory[0].q = npcInventory[0].q - 1;
			}
			else
			{
				npcInventory[0] = EmptyItem();
			}
			if (npcInventory[1].q > 1)
			{
				npcInventory[1].q = npcInventory[1].q - 1;
			}
			else
			{
				npcInventory[1] = EmptyItem();
			}
			break;
		case 12:
			((Component)this).audio.PlayOneShot(audioCrafted);
			if (npcInventory[2].q > 1)
			{
				npcInventory[2].q = npcInventory[2].q - 1;
			}
			else
			{
				npcInventory[2] = EmptyItem();
			}
			if (npcInventory[3].q > 1)
			{
				npcInventory[3].q = npcInventory[3].q - 1;
			}
			else
			{
				npcInventory[3] = EmptyItem();
			}
			if (npcInventory[4].q > 1)
			{
				npcInventory[4].q = npcInventory[4].q - 1;
			}
			else
			{
				npcInventory[4] = EmptyItem();
			}
			npcInventory[12] = EmptyItem();
			HelmCheck();
			break;
		case 13:
			((Component)this).audio.PlayOneShot(audioCrafted);
			if (npcInventory[5].q > 1)
			{
				npcInventory[5].q = npcInventory[5].q - 1;
			}
			else
			{
				npcInventory[5] = EmptyItem();
			}
			if (npcInventory[6].q > 1)
			{
				npcInventory[6].q = npcInventory[6].q - 1;
			}
			else
			{
				npcInventory[6] = EmptyItem();
			}
			if (npcInventory[7].q > 1)
			{
				npcInventory[7].q = npcInventory[7].q - 1;
			}
			else
			{
				npcInventory[7] = EmptyItem();
			}
			npcInventory[13] = EmptyItem();
			ArmorCheck();
			break;
		case 14:
			((Component)this).audio.PlayOneShot(audioCrafted);
			if (npcInventory[8].q > 1)
			{
				npcInventory[8].q = npcInventory[8].q - 1;
			}
			else
			{
				npcInventory[8] = EmptyItem();
			}
			if (npcInventory[9].q > 1)
			{
				npcInventory[9].q = npcInventory[9].q - 1;
			}
			else
			{
				npcInventory[9] = EmptyItem();
			}
			if (npcInventory[10].q > 1)
			{
				npcInventory[10].q = npcInventory[10].q - 1;
			}
			else
			{
				npcInventory[10] = EmptyItem();
			}
			npcInventory[14] = EmptyItem();
			ShieldCheck();
			break;
		}
		((Component)this).audio.PlayOneShot(audioCrafted);
		itemSelected.q++;
		UpdateHoldingItem();
		if (npcInventory[0].q == 0)
		{
			npcInventory[0] = EmptyItem();
		}
		if (npcInventory[1].q == 0)
		{
			npcInventory[1] = EmptyItem();
		}
		switch (slot)
		{
		case 0:
		case 1:
		case 11:
			BarCheck();
			break;
		case 2:
		case 3:
		case 4:
			HelmCheck();
			break;
		case 5:
		case 6:
		case 7:
			ArmorCheck();
			break;
		case 8:
		case 9:
		case 10:
			ShieldCheck();
			break;
		}
		RefreshBlacksmith();
	}

	public override void AddOneItemHolding(int slot)
	{
		itemSelected.q++;
	}

	public override void AddOneItemNPC(int slot)
	{
		if (npcInventory[slot].q + 1 <= 99 && npcInventory[slot].id < 500)
		{
			npcInventory[slot].q = npcInventory[slot].q + 1;
			itemSelected.q--;
			if (itemSelected.q == 0)
			{
				holdingItem = false;
				itemSelected = EmptyItem();
				sSelected.SetActive(false);
			}
			RefreshBlacksmith();
			switch (slot)
			{
			case 0:
			case 1:
				BarCheck();
				break;
			case 2:
			case 3:
			case 4:
				HelmCheck();
				break;
			case 5:
			case 6:
			case 7:
				ArmorCheck();
				break;
			case 8:
			case 9:
			case 10:
				ShieldCheck();
				break;
			}
			UpdateHoldingItem();
		}
	}

	public override void AddOneItem(int slot)
	{
		if ((inventory[slot].q + 1 <= 99 && inventory[slot].id < 500) || (inventory[slot].q + 1 <= 999 && inventory[slot].id >= 52 && inventory[slot].id <= 56))
		{
			inventory[slot].q = inventory[slot].q + 1;
			itemSelected.q--;
			if (itemSelected.q == 0)
			{
				holdingItem = false;
				itemSelected = EmptyItem();
				sSelected.SetActive(false);
			}
			if (slot < 5)
			{
				RefreshActionBar();
			}
			else
			{
				RefreshInventory();
			}
			UpdateHoldingItem();
		}
	}

	public override void SwapItemNPC(int slot)
	{
		if (slot < 11)
		{
			Item item = npcInventory[slot];
			npcInventory[slot] = itemSelected;
			itemSelected = item;
			UpdateHoldingItem();
			switch (slot)
			{
			case 0:
			case 1:
				BarCheck();
				break;
			case 2:
			case 3:
			case 4:
				HelmCheck();
				break;
			case 5:
			case 6:
			case 7:
				ArmorCheck();
				break;
			case 8:
			case 9:
			case 10:
				ShieldCheck();
				break;
			}
		}
		RefreshBlacksmith();
	}

	public override void SwapItem(int slot)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		Item item = inventory[slot];
		int num4 = default(int);
		inventory[slot] = itemSelected;
		itemSelected = item;
		UpdateHoldingItem();
		switch (slot)
		{
		case 20:
			for (num4 = 0; num4 < 4; num4++)
			{
				tempGearStat[num4] -= itemSelected.e[num4];
			}
			for (num4 = 0; num4 < 4; num4++)
			{
				tempGearStat[num4] += inventory[slot].e[num4];
			}
			PlayerController.helm = inventory[slot].id;
			if (MenuScript.multiplayer > 0)
			{
				if (player.networkView.isMine)
				{
					PlayerControllerN.helm = inventory[slot].id;
					num = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
					num2 = PlayerControllerN.armor;
					num3 = PlayerControllerN.offhand;
					player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
					{
						num,
						num2,
						MenuScript.pRace,
						num3,
						MenuScript.pHat
					});
				}
			}
			else
			{
				player.SendMessage("UpdateHead", (object)inventory[slot].id);
			}
			break;
		case 21:
			for (num4 = 0; num4 < 4; num4++)
			{
				tempGearStat[num4] -= itemSelected.e[num4];
			}
			for (num4 = 0; num4 < 4; num4++)
			{
				tempGearStat[num4] += inventory[slot].e[num4];
			}
			PlayerController.armor = inventory[slot].id;
			if (MenuScript.multiplayer > 0)
			{
				if (player.networkView.isMine)
				{
					PlayerControllerN.armor = inventory[slot].id;
					num = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
					num2 = PlayerControllerN.armor;
					num3 = PlayerControllerN.offhand;
					player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
					{
						num,
						num2,
						MenuScript.pRace,
						num3,
						MenuScript.pHat
					});
				}
			}
			else
			{
				player.SendMessage("UpdateBody", (object)inventory[slot].id);
			}
			break;
		case 22:
			for (num4 = 0; num4 < 4; num4++)
			{
				tempGearStat[num4] -= itemSelected.e[num4];
			}
			for (num4 = 0; num4 < 4; num4++)
			{
				tempGearStat[num4] += inventory[slot].e[num4];
			}
			PlayerController.offhand = inventory[slot].id;
			if (MenuScript.multiplayer > 0)
			{
				if (player.networkView.isMine)
				{
					PlayerControllerN.offhand = inventory[slot].id;
					num = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
					num2 = PlayerControllerN.armor;
					num3 = PlayerControllerN.offhand;
					player.networkView.RPC("UpdateAppearance", (RPCMode)6, new object[5]
					{
						num,
						num2,
						MenuScript.pRace,
						num3,
						MenuScript.pHat
					});
				}
			}
			else
			{
				player.SendMessage("UpdateOffhand", (object)inventory[slot].id);
			}
			break;
		}
		if (slot < 5)
		{
			RefreshActionBar();
		}
		else
		{
			RefreshInventory();
		}
		UpdateCharacterWeapon();
	}

	public override void CombineItemNPC(int slot)
	{
		if (npcInventory[slot].id < 500)
		{
			if (npcInventory[slot].q + itemSelected.q <= 99)
			{
				npcInventory[slot].q = npcInventory[slot].q + itemSelected.q;
				holdingItem = false;
				itemSelected = EmptyItem();
				sSelected.SetActive(false);
			}
			else
			{
				int num = 99 - npcInventory[slot].q;
				itemSelected.q -= num;
				npcInventory[slot].q = 99;
			}
			switch (slot)
			{
			case 0:
			case 1:
				BarCheck();
				break;
			case 2:
			case 3:
			case 4:
				HelmCheck();
				break;
			case 5:
			case 6:
			case 7:
				ArmorCheck();
				break;
			case 8:
			case 9:
			case 10:
				ShieldCheck();
				break;
			}
			RefreshBlacksmith();
		}
	}

	public override void CombineItem(int slot)
	{
		if (inventory[slot].q + itemSelected.q <= 99 || (inventory[slot].q + itemSelected.q <= 999 && itemSelected.id >= 52 && itemSelected.id <= 56))
		{
			inventory[slot].q = inventory[slot].q + itemSelected.q;
			holdingItem = false;
			itemSelected = EmptyItem();
			sSelected.SetActive(false);
		}
		else
		{
			int num = 99 - inventory[slot].q;
			itemSelected.q -= num;
			inventory[slot].q = 99;
		}
		if (slot < 5)
		{
			RefreshActionBar();
		}
		else
		{
			RefreshInventory();
		}
	}

	public override void DeleteInventory()
	{
		int num = default(int);
		for (num = 0; num < 31; num++)
		{
			inventory[num] = EmptyItem();
		}
		for (num = 0; num < 15; num++)
		{
			npcInventory[num] = EmptyItem();
		}
	}

	public override void LoadInventory()
	{
		int num = default(int);
		DeleteInventory();
		for (num = 0; num < 31; num++)
		{
			inventory[num].id = PlayerPrefs.GetInt("id" + (object)num);
			inventory[num].q = PlayerPrefs.GetInt("q" + (object)num);
			inventory[num].d = PlayerPrefs.GetInt("d" + (object)num);
		}
	}

	public override void SaveInventory()
	{
		int num = default(int);
		for (num = 0; num < 31; num++)
		{
			if (inventory[num] != null)
			{
				PlayerPrefs.SetInt("id" + (object)num, inventory[num].id);
				PlayerPrefs.SetInt("q" + (object)num, inventory[num].q);
				PlayerPrefs.SetInt("d" + (object)num, inventory[num].d);
			}
		}
	}

	public override void RefreshPlayerStats()
	{
		int num = default(int);
		int[] array = new int[4];
		for (num = 0; num < 4; num++)
		{
			array[num] = tempPlayerStat[num] + tempGearStat[num] + MenuScript.playerStat[num] + tempLevelStat[num];
		}
		for (num = 0; num < 4; num++)
		{
			txtPlayerStat[num].text = GetStatName(num) + ": " + (object)array[num];
		}
		MAXHP = array[0];
		MAXMAG = array[3];
		LoadHearts();
		LoadMana();
	}

	public override string GetStatName(int a)
	{
		string text = null;
		return a switch
		{
			0 => "HP", 
			1 => "ATK", 
			2 => "DEX", 
			3 => "MAG", 
			_ => "NULL", 
		};
	}

	public override int AddItem(Item item)
	{
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		int num = default(int);
		GameObject val = null;
		int num2 = default(int);
		if (item.id < 500)
		{
			num = 0;
			while (num < 20)
			{
				if ((inventory[num].id != item.id || inventory[num].q >= 99) && (inventory[num].id != item.id || inventory[num].id < 52 || inventory[num].id > 56 || inventory[num].q >= 999))
				{
					num++;
					continue;
				}
				goto IL_00a6;
			}
			num = 0;
			while (num < 20)
			{
				if (inventory[num].id != 0)
				{
					num++;
					continue;
				}
				goto IL_0149;
			}
		}
		else
		{
			num = 0;
			while (num < 20)
			{
				if (inventory[num].id != 0)
				{
					num++;
					continue;
				}
				goto IL_01f6;
			}
		}
		int result = 0;
		goto IL_02a9;
		IL_0149:
		inventory[num].id = item.id;
		inventory[num].q = item.q;
		num2 = 1;
		val = (GameObject)Object.Instantiate((Object)(object)txtItem, player.transform.position, Quaternion.identity);
		val.SendMessage("ST", (object)GetItemName(item.id));
		RefreshActionBar();
		if (inventoryOpen)
		{
			RefreshInventory();
		}
		UpdateCharacterWeapon();
		result = 1;
		goto IL_02a9;
		IL_02a9:
		return result;
		IL_00a6:
		inventory[num].q = inventory[num].q + item.q;
		num2 = 1;
		val = (GameObject)Object.Instantiate((Object)(object)txtItem, player.transform.position, Quaternion.identity);
		val.SendMessage("ST", (object)GetItemName(item.id));
		RefreshActionBar();
		if (inventoryOpen)
		{
			RefreshInventory();
		}
		UpdateCharacterWeapon();
		result = 1;
		goto IL_02a9;
		IL_01f6:
		inventory[num].id = item.id;
		inventory[num].q = item.q;
		inventory[num].e = item.e;
		inventory[num].d = item.d;
		val = (GameObject)Object.Instantiate((Object)(object)txtItem, player.transform.position, Quaternion.identity);
		val.SendMessage("ST", (object)GetGearName(item.id));
		RefreshActionBar();
		if (inventoryOpen)
		{
			RefreshInventory();
		}
		UpdateCharacterWeapon();
		result = 1;
		goto IL_02a9;
	}

	public override void SetInfoText(int slot, int id)
	{
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		infoObject.SetActive(true);
		if (id >= 500)
		{
			gearStats.SetActive(true);
			((Component)txtDesc).gameObject.SetActive(false);
			txtInfoName[0].text = GetGearName(id);
			txtDur.text = "Durability: " + (object)inventory[slot].d + "/" + (object)GetMaxDurability(id);
			if (inventory[slot].tier == 3)
			{
				((Component)txtInfoName[0]).gameObject.renderer.material.color = Color.magenta;
			}
			else if (inventory[slot].tier == 2)
			{
				((Component)txtInfoName[0]).gameObject.renderer.material.color = Color.yellow;
			}
			else if (inventory[slot].tier == 1)
			{
				((Component)txtInfoName[0]).gameObject.renderer.material.color = Color.cyan;
			}
			else
			{
				((Component)txtInfoName[0]).gameObject.renderer.material.color = Color.white;
			}
			int num = default(int);
			for (num = 0; num < 4; num++)
			{
				if (inventory[slot].e[num] > 0)
				{
					txtGearStat[num].text = GetStatName(num) + "+ " + (object)inventory[slot].e[num];
					((Component)txtGearStat[num]).gameObject.renderer.material.color = Color.green;
				}
				else if (inventory[slot].e[num] < 0)
				{
					txtGearStat[num].text = GetStatName(num) + string.Empty + (object)inventory[slot].e[num];
					((Component)txtGearStat[num]).gameObject.renderer.material.color = Color.red;
				}
				else
				{
					txtGearStat[num].text = GetStatName(num) + "+ " + (object)0;
					((Component)txtGearStat[num]).gameObject.renderer.material.color = Color.white;
				}
			}
		}
		else
		{
			gearStats.SetActive(false);
			((Component)txtDesc).gameObject.SetActive(true);
			txtDesc.text = GetItemDesc(id);
			txtInfoName[0].text = GetItemName(id);
			((Component)txtInfoName[0]).gameObject.renderer.material.color = Color.white;
		}
		txtInfoName[1].text = txtInfoName[0].text;
	}

	public override string GetItemDesc(int id)
	{
		string text = null;
		return id switch
		{
			1 => "A basic piece of\nwood Used to make\nplanks.", 
			9 => "A vital ingredient\nfor making potions.", 
			7 => "Restores 1 hunger.", 
			8 => "Restores 3 hunger.\n50% chance to heal.", 
			21 => "Restores 1 hunger.", 
			22 => "Restores 3 hunger.\n50% chance to heal.", 
			15 => "Heals 2 HP.", 
			42 => "Heals 5 HP.", 
			_ => string.Empty, 
		};
	}

	public override void SelectSlot(int a)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (!@using && !usingItem && !usingPot && !ATKING)
		{
			curActiveSlot = a;
			UpdateCharacterWeapon();
			select.transform.localPosition = GetSelectPos(curActiveSlot);
		}
	}

	public override void Scroll(int dir)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (@using || usingItem || usingPot || ATKING)
		{
			return;
		}
		if (dir == 0)
		{
			if (curActiveSlot > 0)
			{
				curActiveSlot--;
			}
			else
			{
				curActiveSlot = 4;
			}
		}
		else if (curActiveSlot < 4)
		{
			curActiveSlot++;
		}
		else
		{
			curActiveSlot = 0;
		}
		UpdateCharacterWeapon();
		select.transform.localPosition = GetSelectPos(curActiveSlot);
	}

	public override Vector3 GetSelectPos(object slot)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		Vector3 result = default(Vector3);
		if (RuntimeServices.EqualityOperator(slot, (object)0))
		{
			return new Vector3(-18.75f, 11.05f, 5f);
		}
		if (RuntimeServices.EqualityOperator(slot, (object)1))
		{
			return new Vector3(-16.85f, 11.05f, 5f);
		}
		if (RuntimeServices.EqualityOperator(slot, (object)2))
		{
			return new Vector3(-15f, 11.05f, 5f);
		}
		if (RuntimeServices.EqualityOperator(slot, (object)3))
		{
			return new Vector3(-13.15f, 11.05f, 5f);
		}
		if (RuntimeServices.EqualityOperator(slot, (object)4))
		{
			return new Vector3(-11.25f, 11.05f, 5f);
		}
		return result;
	}

	public override void Close()
	{
		menuOpen = false;
		menuExit.SetActive(false);
		shade.SetActive(false);
	}

	public override void EnterIP()
	{
		enteringIP = true;
		txtIP[0].text = string.Empty;
		txtIP[1].text = string.Empty;
	}

	public override void Resume()
	{
		if (Network.connections.Length == 0)
		{
			Time.timeScale = 1f;
		}
		menuExit.SetActive(false);
		menuOpen = false;
	}

	public override void SetTextInfo()
	{
		txtName.text = string.Empty + MenuScript.curName;
		txtLevel.text = "Lv." + (object)playerLevel;
		txtBarInfo[0].text = (object)HP + "/" + (object)MAXHP;
		txtBarInfo[1].text = (object)MAG + "/" + (object)MAXMAG;
		txtBarInfo[3].text = (object)stamina + "/" + (object)maxStamina;
	}

	public override void OpenInventory()
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		if (!inventoryOpen && !menuOpen)
		{
			RefreshPlayerStats();
			RefreshInventory();
			SetTextInfo();
			menuInventory.SetActive(true);
			menuEquipped.SetActive(true);
			inventoryOpen = true;
			return;
		}
		CloseSkillDesc();
		if (holdingItem)
		{
			DropItem();
		}
		if (interacting)
		{
			menuBlacksmith.SetActive(false);
			int num = default(int);
			Item item = null;
			for (num = 0; num < 15; num++)
			{
				if (npcInventory[num].id != 0 && num < 11)
				{
					GameObject val = (GameObject)Network.Instantiate(Resources.Load("item"), new Vector3(player.transform.position.x + 3f, player.transform.position.y, 0f), Quaternion.identity, 0);
					item = new Item(npcInventory[num].id, npcInventory[num].q, npcInventory[num].e, npcInventory[num].d, null);
					val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
					val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
					val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
					val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
				}
				npcInventory[num] = EmptyItem();
			}
			interacting = false;
		}
		inventoryOpen = false;
		ResetCraft();
		infoObject.SetActive(false);
		menuInventory.SetActive(false);
		menuEquipped.SetActive(false);
	}

	public override void RefreshActionBar()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		int num = 0;
		for (num = 0; num < 5; num++)
		{
			if (inventory[num].id != 0)
			{
				inventorySlot[num].renderer.enabled = true;
				inventorySlot[num].renderer.material = (Material)Resources.Load("i/i" + (object)inventory[num].id);
				if (inventory[num].q > 1)
				{
					inventoryQ[num].text = string.Empty + (object)inventory[num].q;
				}
				else
				{
					inventoryQ[num].text = string.Empty;
				}
			}
			else
			{
				inventorySlot[num].renderer.enabled = false;
				inventoryQ[num].text = string.Empty;
			}
		}
	}

	public override void RefreshInventory()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		int num = 0;
		for (num = 5; num < 31; num++)
		{
			if (inventory[num].id != 0)
			{
				inventorySlot[num].renderer.enabled = true;
				inventorySlot[num].renderer.material = (Material)Resources.Load("i/i" + (object)inventory[num].id);
				if (inventory[num].q > 1)
				{
					if (num < 20 || num > 25)
					{
						inventoryQ[num].text = string.Empty + (object)inventory[num].q;
					}
				}
				else if (num < 20 || num > 25)
				{
					inventoryQ[num].text = string.Empty;
				}
				if (num == 23)
				{
					if (inventory[num].q > 1)
					{
						inventoryQ[num].text = string.Empty + (object)inventory[num].q;
					}
					else
					{
						inventoryQ[num].text = string.Empty;
					}
				}
			}
			else
			{
				inventorySlot[num].renderer.enabled = false;
				if (num < 20 || num > 25)
				{
					inventoryQ[num].text = string.Empty;
				}
				if (num == 23)
				{
					inventoryQ[23].text = string.Empty;
				}
			}
		}
	}

	public override void GenerateLevel()
	{
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		int num3 = default(int);
		int num4 = 0;
		curZone = 0;
		int num5 = 0;
		if (MenuScript.multiplayer > 0)
		{
			if (!Network.isServer)
			{
				return;
			}
			Network.Instantiate(Resources.Load("z/zEntrance"), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
			int num6 = Random.Range(6, 8);
			for (num5 = 0; num5 < num6; num5++)
			{
				num3 = Random.Range(1, 9);
				switch (num3)
				{
				case 1:
					num -= 8;
					break;
				case 2:
					num += 8;
					break;
				case 3:
					num -= 8;
					break;
				case 4:
					num += 8;
					break;
				case 5:
					num -= 8;
					break;
				case 6:
					num += 8;
					break;
				case 7:
					num += 0;
					break;
				case 8:
					num += 0;
					break;
				case 9:
					num += 8;
					break;
				case 10:
					num += 0;
					break;
				}
				num4 = num2 + num;
				Network.Instantiate(Resources.Load("z/zone" + (object)num3), new Vector3((float)(num5 * 64 + 40), (float)num4, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
				switch (num3)
				{
				case 1:
					num2 -= 8;
					break;
				case 2:
					num2 += 8;
					break;
				case 3:
					num2 -= 8;
					break;
				case 4:
					num2 += 8;
					break;
				case 5:
					num2 -= 8;
					break;
				case 6:
					num2 += 8;
					break;
				case 7:
					num2 += 0;
					break;
				case 8:
					num2 += 0;
					break;
				case 9:
					num2 += 0;
					break;
				case 10:
					num2 -= 8;
					break;
				}
				curZone++;
			}
			num4 = num2 + num;
			Network.Instantiate(Resources.Load("z/zExit"), new Vector3((float)(curZone * 64 + 16), (float)num4, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
			return;
		}
		Object.Instantiate(Resources.Load("z/zEntrance"), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 180f));
		int num7 = Random.Range(4, 8);
		for (num5 = 0; num5 < 1; num5++)
		{
			num3 = Random.Range(1, 9);
			switch (num3)
			{
			case 1:
				num -= 8;
				break;
			case 2:
				num += 8;
				break;
			case 3:
				num -= 8;
				break;
			case 4:
				num += 8;
				break;
			case 5:
				num -= 8;
				break;
			case 6:
				num += 8;
				break;
			case 7:
				num += 0;
				break;
			case 8:
				num += 0;
				break;
			case 9:
				num += 8;
				break;
			case 10:
				num += 0;
				break;
			}
			num4 = num2 + num;
			Object.Instantiate(Resources.Load("z/zone" + (object)num3), new Vector3((float)(num5 * 64 + 40), (float)num4, 0f), Quaternion.Euler(0f, 180f, 180f));
			switch (num3)
			{
			case 1:
				num2 -= 8;
				break;
			case 2:
				num2 += 8;
				break;
			case 3:
				num2 -= 8;
				break;
			case 4:
				num2 += 8;
				break;
			case 5:
				num2 -= 8;
				break;
			case 6:
				num2 += 8;
				break;
			case 7:
				num2 += 0;
				break;
			case 8:
				num2 += 0;
				break;
			case 9:
				num2 += 0;
				break;
			case 10:
				num2 -= 8;
				break;
			}
			curZone++;
		}
		num4 = num2 + num;
		Object.Instantiate(Resources.Load("z/zExit"), new Vector3((float)(curZone * 64 + 16), (float)num4, 0f), Quaternion.Euler(0f, 180f, 180f));
	}

	public override void LoadMana()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		txtBarInfo[1].text = (object)MAG + "/" + (object)MAXMAG;
		float x = (float)MAXMAG * 0.2f;
		Vector3 localScale = barBack[1].transform.localScale;
		float num = (localScale.x = x);
		Vector3 val2 = (barBack[1].transform.localScale = localScale);
		float x2 = (float)MAG * 0.2f;
		Vector3 localScale2 = barFill[1].transform.localScale;
		float num2 = (localScale2.x = x2);
		Vector3 val4 = (barFill[1].transform.localScale = localScale2);
	}

	public override void LoadHearts()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		if (HP < 0)
		{
			HP = 0;
		}
		if (HP > MAXHP)
		{
			HP = MAXHP;
		}
		if (Object.op_Implicit((Object)(object)txtBarInfo[0]))
		{
			txtBarInfo[0].text = (object)HP + "/" + (object)MAXHP;
		}
		float x = (float)MAXHP * 0.2f;
		Vector3 localScale = barBack[0].transform.localScale;
		float num = (localScale.x = x);
		Vector3 val2 = (barBack[0].transform.localScale = localScale);
		float x2 = (float)HP * 0.2f;
		Vector3 localScale2 = barFill[0].transform.localScale;
		float num2 = (localScale2.x = x2);
		Vector3 val4 = (barFill[0].transform.localScale = localScale2);
	}

	public override IEnumerator Die()
	{
		return new _0024Die_00241619(this).GetEnumerator();
	}

	public override void ShowTimer()
	{
		int num = timer;
		int num2 = 0;
		int num3 = 0;
		while (num >= 60)
		{
			num2++;
			num -= 60;
		}
		while (num2 >= 60)
		{
			num3++;
			num2 -= 60;
		}
		txtTimer.text = "Total Time: " + (object)num3 + ":" + (object)num2 + ":" + (object)num;
		MonoBehaviour.print((object)((object)win + "WIN?  tIMER"));
		if (num3 <= 1 && win)
		{
			MenuScript.canUnlockRace[6] = 1;
		}
	}

	public override IEnumerator ShowStats()
	{
		return new _0024ShowStats_00241622(this).GetEnumerator();
	}

	public override IEnumerator ShowEXP()
	{
		return new _0024ShowEXP_00241626(this).GetEnumerator();
	}

	public override int GetCurEXP(int pLevel)
	{
		int num = accountEXP;
		if (pLevel > 1)
		{
			num -= GetTotalEXP(pLevel);
		}
		return num;
	}

	public override int GetLevelCap(int pLevel)
	{
		int num = 0;
		int num2 = 100;
		int num3 = default(int);
		for (num3 = 1; num3 < pLevel; num3++)
		{
			num2 = (int)((float)num2 * 1.2f);
		}
		if (pLevel == 0)
		{
			num2 = 0;
		}
		return num2;
	}

	public override int GetTotalEXP(int lvl)
	{
		int num = default(int);
		int num2 = default(int);
		for (num = 0; num < lvl; num++)
		{
			num2 += GetLevelCap(num);
		}
		return num2;
	}

	public override int GetPlayerLevel()
	{
		int num = accountEXP;
		int num2 = 0;
		int num3 = default(int);
		int num4 = 100;
		while (num >= 0)
		{
			num -= num4;
			num4 = (int)((float)num4 * 1.2f);
			num2++;
		}
		return num2;
	}

	public override IEnumerator StatShow(int a)
	{
		return new _0024StatShow_00241633(a, this).GetEnumerator();
	}

	public override string GetStatsName(int a)
	{
		string text = null;
		return a switch
		{
			0 => "Characters Created", 
			1 => "Enemies Defeated", 
			2 => "Gold Collected", 
			3 => "EXP Acquired", 
			4 => "Items Crafted", 
			5 => "Trees Chopped", 
			6 => "Ore Mined", 
			7 => "Resources Gathered", 
			8 => "Foods Eaten", 
			9 => "Chests Opened", 
			10 => "Quests Completed", 
			11 => "Items Bought", 
			12 => "Altars Used", 
			_ => string.Empty, 
		};
	}

	public override void OnApplicationQuit()
	{
		changingScene = false;
		DeleteCharacter();
		SaveInventory();
	}

	public override void DeleteCharacter()
	{
		int num = 0;
		isInitialized = false;
		DeleteInventory();
		PlayerController.helm = 0;
		PlayerControllerN.helm = 0;
		curBiome = 0;
		if (Object.op_Implicit((Object)(object)player))
		{
			player.SendMessage("UpdateHead", (object)MenuScript.pVariant, (SendMessageOptions)1);
		}
		PlayerController.armor = 0;
		PlayerControllerN.armor = 0;
		if (Object.op_Implicit((Object)(object)player))
		{
			player.SendMessage("UpdateBody", (object)MenuScript.pBody, (SendMessageOptions)1);
		}
		PlayerController.offhand = 0;
		PlayerControllerN.offhand = 0;
		if (Object.op_Implicit((Object)(object)player))
		{
			player.SendMessage("UpdateOffhand", (object)MenuScript.pBody, (SendMessageOptions)1);
		}
		for (num = 0; num < 31; num++)
		{
			PlayerPrefs.SetInt("id" + (object)num, 0);
			PlayerPrefs.SetInt("q" + (object)num, 0);
			PlayerPrefs.SetInt("e" + (object)num, 0);
			PlayerPrefs.SetInt("d" + (object)num, 0);
			if (num < 20)
			{
				PlayerPrefs.SetInt("e" + (object)num, 0);
			}
		}
		PlayerPrefs.SetInt("cLevel", 0);
	}

	public override void UpdateCharacterWeapon()
	{
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		int id = inventory[curActiveSlot].id;
		int num = 0;
		if (id < 500)
		{
			for (num = 0; num < 4; num++)
			{
				tempPlayerStat[num] = 0;
			}
		}
		else
		{
			for (num = 0; num < 4; num++)
			{
				tempPlayerStat[num] = inventory[curActiveSlot].e[num];
			}
		}
		int num2 = id;
		switch (num2)
		{
		case 500:
			finalATKChop = ATKChop;
			break;
		case 512:
			finalATKChop = ATKChop;
			break;
		case 503:
			finalATKChop = ATKChop;
			break;
		case 506:
			finalATKChop = ATKChop;
			break;
		case 509:
			finalATKChop = ATKChop;
			break;
		case 501:
			finalATK = ATK;
			finalATKChop = ATKChop + 1;
			finalATKMine = ATKMine;
			break;
		case 502:
			finalATK = ATK;
			finalATKChop = ATKChop;
			finalATKMine = ATKMine + 1;
			break;
		case 504:
			finalATK = ATK;
			finalATKChop = ATKChop + 3;
			finalATKMine = ATKMine;
			break;
		case 505:
			finalATK = ATK;
			finalATKChop = ATKChop;
			finalATKMine = ATKMine + 3;
			break;
		case 507:
			finalATK = ATK;
			finalATKChop = ATKChop + 4;
			finalATKMine = ATKMine;
			break;
		case 508:
			finalATK = ATK;
			finalATKChop = ATKChop;
			finalATKMine = ATKMine + 4;
			break;
		case 510:
			finalATK = ATK;
			finalATKChop = ATKChop + 5;
			finalATKMine = ATKMine;
			break;
		case 511:
			finalATK = ATK;
			finalATKChop = ATKChop;
			finalATKMine = ATKMine + 5;
			break;
		case 513:
			finalATK = ATK;
			finalATKChop = ATKChop + 2;
			finalATKMine = ATKMine;
			break;
		case 514:
			finalATK = ATK;
			finalATKChop = ATKChop;
			finalATKMine = ATKMine + 2;
			break;
		case 517:
			finalATK = ATK;
			finalATKChop = ATKChop + 2;
			finalATKMine = ATKMine;
			break;
		case 518:
			finalATK = ATK;
			finalATKChop = ATKChop;
			finalATKMine = ATKMine + 2;
			break;
		case 529:
			finalATKNet = 1;
			finalATK = ATK;
			finalATKChop = ATKChop;
			finalATKMine = ATKMine;
			break;
		default:
			switch (num2)
			{
			case 504:
				finalATK = ATK;
				finalATKChop = ATKChop + 3;
				break;
			case 506:
				finalATK = ATK;
				finalATKChop = ATKChop;
				break;
			case 509:
				finalATK = ATK;
				finalATKChop = ATKChop;
				break;
			case 560:
				finalATKChop = ATKChop;
				break;
			default:
				finalATK = ATK;
				finalATKChop = ATKChop;
				finalATKMine = ATKMine;
				break;
			}
			break;
		}
		if (MenuScript.curTrait[1] == 1 || MenuScript.curTrait[2] == 1)
		{
			finalATKChop += 10;
		}
		if (MenuScript.pHat == 2)
		{
			finalATKMine += 10;
		}
		if (Network.isClient || Network.isServer)
		{
			player.networkView.RPC("uI", (RPCMode)6, new object[1] { inventory[curActiveSlot].id });
		}
		else
		{
			weapon.renderer.material = (Material)Resources.Load("iE/i" + (object)inventory[curActiveSlot].id);
		}
		SphereCollider val = (SphereCollider)aSphere.GetComponent(typeof(SphereCollider));
		if (id >= 500 && id < 560)
		{
			atkAnim = "a1";
			float x = 0.4f;
			Vector3 center = val.center;
			float num3 = (center.x = x);
			Vector3 val3 = (val.center = center);
			atkWait = 0.45f;
		}
		else if (id >= 560 && id < 580)
		{
			atkAnim = "a2";
			float x2 = 0.6f;
			Vector3 center2 = val.center;
			float num4 = (center2.x = x2);
			Vector3 val5 = (val.center = center2);
			atkWait = 1f;
		}
		else if (id >= 600 && id < 650)
		{
			atkAnim = "a1";
			float x3 = 0.4f;
			Vector3 center3 = val.center;
			float num5 = (center3.x = x3);
			Vector3 val7 = (val.center = center3);
			atkWait = 0.45f;
		}
		else
		{
			float x4 = 0.1f;
			Vector3 center4 = val.center;
			float num6 = (center4.x = x4);
			Vector3 val9 = (val.center = center4);
			atkAnim = "a1";
			atkWait = 0.45f;
		}
		if (inventoryOpen)
		{
			RefreshPlayerStats();
		}
	}

	public override string GetSkillName(int a)
	{
		string text = null;
		return a switch
		{
			1 => "Throwing Axe", 
			2 => "Berserker's Rage", 
			3 => "Charge!", 
			4 => "Guardian's Aura", 
			5 => "Knight's Blade", 
			6 => "Magic Weapons", 
			7 => "Clairvoyance", 
			8 => "Necromancer's Minion", 
			9 => "Warp", 
			10 => "Levitate", 
			11 => "Hunter's Roar", 
			12 => "Triple Shot", 
			13 => "Druid's Arrow", 
			14 => "Fire Wisp", 
			15 => "Dire Wolf", 
			_ => "null", 
		};
	}

	public override string GetSkillDesc(int id)
	{
		string text = null;
		return id switch
		{
			1 => "Hurl a giant axe that\npasses through enemies.\nDeals damage based on\nATK.", 
			2 => "For 10 seconds, your\nATK is doubled.", 
			3 => "You and nearby Allies\ngain 4 SPD for 10\nseconds.", 
			4 => "You and nearby Allies\ntake 4 less damage\nfor 10 seconds.", 
			5 => "Perform an extra jump\nwhile summoning a badass\nsword. Based on ATK.", 
			6 => "You and nearby Allies\ndeal bonus damage equal\nto your MAG for\n10 seconds.", 
			7 => "For 10 seconds, you\nrapidly regain mana.", 
			8 => "Summon a minion at your\ncursor's location. Shoots\nfireballs whaaat.", 
			9 => "Teleport left or right\nbased on cursor location.", 
			10 => "Makes your friends\njealous.", 
			11 => "You and nearby Allies\ngain 10 DEX for 10\nseconds.", 
			12 => "Next shot fired will\nshoot 3 arrows.\nConsumes 3 arrows.", 
			13 => "Perform an extra jump\nwhile summoning a badass\narrow. Based on DEX.", 
			14 => "Summons wisp at cursor\nlocation. Arrows passing\nthrough will deal\n2x damage.", 
			15 => "Summon a wolf that runs\naround and kills shit.", 
			_ => "null", 
		};
	}

	public override string GetEnchantmentName(int id)
	{
		string text = null;
		return id switch
		{
			1 => "Power I", 
			2 => "Power II", 
			3 => "Power III", 
			4 => "Wrath I", 
			5 => "Wrath II", 
			6 => "Wrath III", 
			7 => "Swiftness I", 
			8 => "Swiftness II", 
			9 => "Switftness III", 
			_ => "[Empty]", 
		};
	}

	public override string GetStatBonus(int id)
	{
		string text = null;
		return id switch
		{
			500 => "ATK+1", 
			503 => "ATK+2", 
			_ => string.Empty, 
		};
	}

	public override float GetMaxDurability(int id)
	{
		float num = default(float);
		return id switch
		{
			500 => 50f, 
			501 => 50f, 
			502 => 50f, 
			503 => 80f, 
			504 => 80f, 
			505 => 80f, 
			506 => 160f, 
			507 => 160f, 
			508 => 160f, 
			509 => 250f, 
			510 => 250f, 
			511 => 250f, 
			512 => 55f, 
			513 => 55f, 
			514 => 55f, 
			515 => 100f, 
			516 => 60f, 
			517 => 60f, 
			518 => 60f, 
			519 => 50f, 
			560 => 90f, 
			561 => 180f, 
			562 => 270f, 
			563 => 65f, 
			600 => 50f, 
			601 => 50f, 
			_ => 20f, 
		};
	}

	public override int[] GetGearStats(int id)
	{
		int[] array = new int[4];
		return id switch
		{
			500 => new int[4] { 0, 2, 0, 0 }, 
			503 => new int[4] { 0, 8, 0, 0 }, 
			506 => new int[4] { 0, 15, 0, 0 }, 
			509 => new int[4] { 0, 25, 0, 0 }, 
			512 => new int[4] { 0, 4, 0, 0 }, 
			516 => new int[4] { 0, 4, 0, 0 }, 
			560 => new int[4] { 0, 15, 0, 0 }, 
			561 => new int[4] { 0, 30, 0, 0 }, 
			562 => new int[4] { 0, 48, 0, 0 }, 
			563 => new int[4] { 0, 8, 0, 0 }, 
			700 => new int[4] { 2, 0, 0, 0 }, 
			701 => new int[4] { 3, 0, 0, 0 }, 
			702 => new int[4] { 4, 0, 0, 0 }, 
			703 => new int[4] { 1, 0, 0, 0 }, 
			704 => new int[4] { 1, 0, 0, 0 }, 
			800 => new int[4] { 2, 0, 0, 0 }, 
			801 => new int[4] { 3, 0, 0, 0 }, 
			802 => new int[4] { 4, 0, 0, 0 }, 
			803 => new int[4] { 1, 0, 0, 0 }, 
			804 => new int[4] { 1, 0, 0, 0 }, 
			900 => new int[4] { 2, 0, 0, 0 }, 
			901 => new int[4] { 3, 0, 0, 0 }, 
			902 => new int[4] { 4, 0, 0, 0 }, 
			903 => new int[4] { 1, 0, 0, 0 }, 
			904 => new int[4] { 1, 0, 0, 0 }, 
			_ => new int[4], 
		};
	}

	public override void Options()
	{
	}

	public override void OnDisconnectedFromServer()
	{
		isInitialized = false;
		isReturning = false;
		isInstance = false;
		changingScene = false;
		DeleteCharacter();
		DeleteInventory();
		Application.LoadLevel(0);
	}

	public override void OnPlayerConnected(NetworkPlayer player)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (Network.isServer)
		{
			Network.CloseConnection(player, false);
		}
	}

	public override void OnPlayerDisconnected(NetworkPlayer player)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Network.RemoveRPCs(player);
		Network.DestroyPlayerObjects(player);
	}

	public override void Action(int act)
	{
		if (act > 0)
		{
			interact = act;
		}
		else
		{
			interact = 0;
		}
	}

	public override void Interact()
	{
		interacting = true;
		if (!inventoryOpen)
		{
			OpenInventory();
		}
		string text = interacter;
		if (text == "n1")
		{
			menuBlacksmith.SetActive(true);
			RefreshBlacksmith();
		}
		else if (text == "n3")
		{
			menuTailor.SetActive(true);
		}
	}

	public override void InteractCancel()
	{
		if (inventoryOpen)
		{
			OpenInventory();
		}
		menuAlchemist.SetActive(false);
		menuBlacksmith.SetActive(false);
		menuTailor.SetActive(false);
		interacting = false;
	}

	public override void GainEXP(int a)
	{
		if (HP <= 0)
		{
			return;
		}
		exp += a;
		barEXPback.animation.Play();
		if (!(exp < maxEXP))
		{
			if (playerLevel == 1)
			{
				count = 8;
			}
			maxEXP = count + playerLevel * 5;
			exp = 0f;
			((MonoBehaviour)this).StartCoroutine_Auto(LevelUp());
		}
		LoadEXP();
	}

	public override IEnumerator AdditionalStat(int a)
	{
		return new _0024AdditionalStat_00241640(a, this).GetEnumerator();
	}

	public override IEnumerator ShowLUP(int a)
	{
		return new _0024ShowLUP_00241645(a, this).GetEnumerator();
	}

	public override IEnumerator LevelUp()
	{
		return new _0024LevelUp_00241650(this).GetEnumerator();
	}

	public override void SelectSkill(int a)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		menuSkill.SetActive(false);
		selectingSkill = false;
		a *= 5;
		int num = a + 5;
		((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/SKILL", typeof(AudioClip)));
		int num2 = a + Random.Range(1, 6);
		int num3 = default(int);
		int num4 = 0;
		for (num3 = 0; num3 < 3; num3++)
		{
			if (num3 == curSkill)
			{
				skill[curSkill] = num2;
				break;
			}
			if (skill[num3] == num2)
			{
				num2 = ((num2 >= num) ? (a + 1) : (num2 + 1));
			}
			if (skill[num3] >= 10)
			{
				num4++;
			}
		}
		if (num4 >= 3)
		{
			MenuScript.canUnlockHat[11] = 1;
		}
		RefreshSkills();
		if (curSkill == 0)
		{
			MenuScript.canUnlockRace[3] = 1;
		}
		else if (curSkill == 1)
		{
			MenuScript.canUnlockRace[4] = 1;
		}
		curSkill++;
	}

	public override void SkillMenu()
	{
		selectingSkill = true;
		menuSkill.SetActive(true);
	}

	public override void RefreshSkills()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		int num = default(int);
		for (num = 0; num < 3; num++)
		{
			if (skill[num] > 0)
			{
				skillObj[num].SetActive(true);
				skillObj[num].renderer.material = (Material)Resources.Load("sI/s" + (object)skill[num]);
			}
			else
			{
				skillObj[num].SetActive(false);
			}
		}
	}

	public override float GetSkillCooldown(int a)
	{
		int num = default(int);
		return a switch
		{
			1 => 200, 
			2 => 400, 
			3 => 400, 
			4 => 400, 
			5 => 150, 
			6 => 400, 
			7 => 200, 
			8 => 350, 
			9 => 150, 
			10 => 200, 
			11 => 400, 
			12 => 150, 
			13 => 150, 
			14 => 150, 
			15 => 150, 
			_ => 150, 
		};
	}

	public override IEnumerator SkillTick(int a, float max)
	{
		return new _0024SkillTick_00241660(a, max, this).GetEnumerator();
	}

	public override void UseSkill(int b)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected O, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected O, but got Unknown
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c10: Expected O, but got Unknown
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Expected O, but got Unknown
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Expected O, but got Unknown
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected O, but got Unknown
		//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce8: Expected O, but got Unknown
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c86: Expected O, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4f: Expected O, but got Unknown
		//IL_0e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea4: Expected O, but got Unknown
		//IL_0d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Expected O, but got Unknown
		//IL_0deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected O, but got Unknown
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected O, but got Unknown
		//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f26: Expected O, but got Unknown
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Unknown result type (might be due to invalid IL or missing references)
		//IL_1033: Unknown result type (might be due to invalid IL or missing references)
		//IL_103d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1044: Expected O, but got Unknown
		//IL_0fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Expected O, but got Unknown
		int num = skill[b];
		if (skillCooldown[b] > 0f || num <= 0)
		{
			return;
		}
		skillObj[b].animation.Play();
		int num2 = (int)GetSkillCooldown(num);
		skillCooldown[b] = num2;
		((MonoBehaviour)this).StartCoroutine_Auto(SkillTick(b, num2));
		GameObject val = null;
		switch (num)
		{
		case 1:
		{
			Vector3 val3 = default(Vector3);
			GameObject val5 = null;
			val3 = ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= player.transform.position.x) ? new Vector3(0f, 180f, 0f) : new Vector3(0f, 0f, 0f));
			if (MenuScript.multiplayer > 0)
			{
				val5 = (GameObject)Network.Instantiate(Resources.Load("skill/throwAxe"), player.transform.position, Quaternion.Euler(val3), 0);
				val5.SendMessage("Set", (object)finalATK);
				player.networkView.RPC("mA", (RPCMode)2, new object[1] { "dj" });
				val = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
				val.networkView.RPC("SDSN", (RPCMode)2, new object[1] { "TAKE THAT!" });
			}
			else
			{
				val5 = (GameObject)Object.Instantiate(Resources.Load("skill/throwAxe"), player.transform.position, Quaternion.Euler(val3));
				val5.SendMessage("Set", (object)finalATK);
				@base.animation.Play("dj");
				val = (GameObject)Object.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity);
				val.SendMessage("SDS", (object)"TAKE THAT!");
			}
			break;
		}
		case 2:
			rage = true;
			if (MenuScript.multiplayer > 0)
			{
				player.networkView.RPC("Rage", (RPCMode)6, new object[1] { 1 });
				val = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
				val.networkView.RPC("SDSN", (RPCMode)2, new object[1] { "I'M SO ANGRY!" });
			}
			else
			{
				player.SendMessage("Rage", (object)1);
				val = (GameObject)Object.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity);
				val.SendMessage("SDS", (object)"I'M SO ANGRY!");
			}
			((MonoBehaviour)this).StartCoroutine_Auto(RageTick());
			break;
		case 3:
			if (MenuScript.multiplayer > 0)
			{
				Network.Instantiate(Resources.Load("skill/Charge"), player.transform.position, Quaternion.identity, 0);
				val = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
				val.networkView.RPC("SDSN", (RPCMode)2, new object[1] { "CHARGE!" });
			}
			else
			{
				Object.Instantiate(Resources.Load("skill/Charge"), player.transform.position, Quaternion.identity);
				val = (GameObject)Object.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity);
				val.SendMessage("SDS", (object)"CHARGE!");
			}
			break;
		case 4:
			if (MenuScript.multiplayer > 0)
			{
				Network.Instantiate(Resources.Load("skill/Shield"), player.transform.position, Quaternion.identity, 0);
			}
			else
			{
				Object.Instantiate(Resources.Load("skill/Shield"), player.transform.position, Quaternion.identity);
			}
			break;
		case 5:
		{
			GameObject val14 = null;
			int num8 = 38;
			Vector3 velocity3 = player.rigidbody.velocity;
			float num9 = (velocity3.y = num8);
			Vector3 val16 = (player.rigidbody.velocity = velocity3);
			if (MenuScript.multiplayer > 0)
			{
				val14 = (GameObject)Network.Instantiate(Resources.Load("skill/kBlade"), player.transform.position, Quaternion.identity, 0);
				val14.SendMessage("Set", (object)finalATK);
				player.networkView.RPC("mA", (RPCMode)2, new object[1] { "dj" });
				val = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
				val.networkView.RPC("SDSN", (RPCMode)2, new object[1] { "Woohoo!" });
			}
			else
			{
				val14 = (GameObject)Object.Instantiate(Resources.Load("skill/kBlade"), player.transform.position, Quaternion.identity);
				val14.SendMessage("Set", (object)finalATK);
				@base.animation.Play("dj");
				val = (GameObject)Object.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity);
				val.SendMessage("SDS", (object)"TAKE THAT!");
			}
			break;
		}
		case 6:
		{
			GameObject val4 = null;
			val4 = ((MenuScript.multiplayer <= 0) ? ((GameObject)Object.Instantiate(Resources.Load("skill/mWeapons"), player.transform.position, Quaternion.identity)) : ((GameObject)Network.Instantiate(Resources.Load("skill/mWeapons"), player.transform.position, Quaternion.identity, 0)));
			val4.SendMessage("SetMag", (object)MAXMAG);
			break;
		}
		case 7:
			clair = true;
			if (MenuScript.multiplayer > 0)
			{
				player.networkView.RPC("Clair", (RPCMode)6, new object[1] { 1 });
				val = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
				val.networkView.RPC("SDSN", (RPCMode)2, new object[1] { "I'M FOCUSED!" });
			}
			else
			{
				player.SendMessage("Clair", (object)1);
				val = (GameObject)Object.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity);
				val.SendMessage("SDS", (object)"I'M FOCUSED!");
			}
			((MonoBehaviour)this).StartCoroutine_Auto(ManaTick());
			break;
		case 8:
		{
			Vector3 val3 = ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= player.transform.position.x) ? new Vector3(0f, 180f, 0f) : new Vector3(0f, 0f, 0f));
			Vector3 val20 = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0f);
			GameObject val21 = null;
			if (MenuScript.multiplayer > 0)
			{
				val21 = (GameObject)Network.Instantiate(Resources.Load("skill/minion"), val20, Quaternion.Euler(val3), 0);
				val21.networkView.RPC("SetN", (RPCMode)2, new object[1] { MAXMAG });
			}
			else
			{
				val21 = (GameObject)Object.Instantiate(Resources.Load("skill/minion"), val20, Quaternion.Euler(val3));
				val21.SendMessage("Set", (object)MAXMAG);
			}
			break;
		}
		case 9:
		{
			if (MenuScript.multiplayer > 0)
			{
				Network.Instantiate(Resources.Load("warp"), player.transform.position, Quaternion.Euler(0f, 180f, 180f), 0);
			}
			else
			{
				Object.Instantiate(Resources.Load("warp"), player.transform.position, Quaternion.Euler(0f, 180f, 180f));
			}
			Ray val8 = default(Ray);
			RaycastHit val9 = default(RaycastHit);
			int num3 = 2048;
			if (!(Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= player.transform.position.x))
			{
				val8 = new Ray(player.transform.position, new Vector3(1f, 0f, 0f));
				Vector3 val3 = new Vector3(player.transform.position.x + 8f, player.transform.position.y, 0f);
				if (!Physics.Raycast(val8, ref val9, 8.4f, num3))
				{
					player.transform.position = val3;
					int num4 = 0;
					Vector3 velocity = player.rigidbody.velocity;
					float num5 = (velocity.x = num4);
					Vector3 val11 = (player.rigidbody.velocity = velocity);
				}
			}
			else
			{
				val8 = new Ray(player.transform.position, new Vector3(-1f, 0f, 0f));
				Vector3 val3 = new Vector3(player.transform.position.x - 8f, player.transform.position.y, 0f);
				if (!Physics.Raycast(val8, ref val9, 8.4f, num3))
				{
					player.transform.position = val3;
					int num6 = 0;
					Vector3 velocity2 = player.rigidbody.velocity;
					float num7 = (velocity2.x = num6);
					Vector3 val13 = (player.rigidbody.velocity = velocity2);
				}
			}
			if (MenuScript.multiplayer > 0)
			{
				Network.Instantiate(Resources.Load("warp"), player.transform.position, Quaternion.Euler(0f, 180f, 180f), 0);
			}
			else
			{
				Object.Instantiate(Resources.Load("warp"), player.transform.position, Quaternion.Euler(0f, 180f, 180f));
			}
			break;
		}
		case 10:
			if (MenuScript.multiplayer > 0)
			{
				player.SendMessage("Float", (object)1);
				val = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
				val.networkView.RPC("SDSN", (RPCMode)2, new object[1] { "PUT ME DOWN!" });
			}
			else
			{
				player.SendMessage("Float", (object)1);
				val = (GameObject)Object.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity);
				val.SendMessage("SDS", (object)"PUT ME DOWN!");
			}
			break;
		case 11:
			if (MenuScript.multiplayer > 0)
			{
				player.networkView.RPC("Roar", (RPCMode)6, new object[1] { 1 });
				val = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
				val.networkView.RPC("SDSN", (RPCMode)2, new object[1] { "RAAAAH" });
			}
			else
			{
				player.SendMessage("Roar", (object)1);
				val = (GameObject)Object.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity);
				val.SendMessage("SDS", (object)"RAAAAH");
			}
			((MonoBehaviour)this).StartCoroutine_Auto(RoarTick());
			break;
		case 12:
			multishot = true;
			break;
		case 13:
		{
			GameObject val17 = null;
			int num10 = 38;
			Vector3 velocity4 = player.rigidbody.velocity;
			float num11 = (velocity4.y = num10);
			Vector3 val19 = (player.rigidbody.velocity = velocity4);
			if (MenuScript.multiplayer > 0)
			{
				val17 = (GameObject)Network.Instantiate(Resources.Load("skill/dArrow"), player.transform.position, Quaternion.identity, 0);
				val17.SendMessage("Set", (object)finalATK);
				player.networkView.RPC("mA", (RPCMode)2, new object[1] { "dj" });
				val = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
				val.networkView.RPC("SDSN", (RPCMode)2, new object[1] { "WOOHOO!" });
			}
			else
			{
				val17 = (GameObject)Object.Instantiate(Resources.Load("skill/dArrow"), player.transform.position, Quaternion.identity);
				val17.SendMessage("Set", (object)finalATK);
				@base.animation.Play("dj");
				val = (GameObject)Object.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity);
				val.SendMessage("SDS", (object)"WOOHOO!");
			}
			break;
		}
		case 14:
		{
			Vector3 val6 = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0f);
			GameObject val7 = null;
			if (MenuScript.multiplayer > 0)
			{
				val7 = (GameObject)Network.Instantiate(Resources.Load("skill/wisp"), val6, Quaternion.identity, 0);
			}
			else
			{
				val7 = (GameObject)Object.Instantiate(Resources.Load("skill/wisp"), val6, Quaternion.identity);
			}
			break;
		}
		case 15:
		{
			GameObject val2 = null;
			Vector3 val3 = ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= player.transform.position.x) ? new Vector3(0f, 180f, 0f) : new Vector3(0f, 0f, 0f));
			if (MenuScript.multiplayer > 0)
			{
				val2 = (GameObject)Network.Instantiate(Resources.Load("skill/wolf"), player.transform.position, Quaternion.Euler(val3), 0);
				val2.networkView.RPC("SetN", (RPCMode)2, new object[1] { DEX + DEXBonus });
			}
			else
			{
				val2 = (GameObject)Object.Instantiate(Resources.Load("skill/wolf"), player.transform.position, Quaternion.Euler(val3));
				val2.SendMessage("Set", (object)(DEX + DEXBonus));
			}
			break;
		}
		}
	}

	public override IEnumerator RageTick()
	{
		return new _0024RageTick_00241670().GetEnumerator();
	}

	public override IEnumerator RoarTick()
	{
		return new _0024RoarTick_00241671().GetEnumerator();
	}

	public override IEnumerator FloatTick()
	{
		return new _0024FloatTick_00241672().GetEnumerator();
	}

	public override IEnumerator ManaTick()
	{
		return new _0024ManaTick_00241673(this).GetEnumerator();
	}

	public override string GetItemName(int id)
	{
		string text = null;
		return id switch
		{
			1 => "Wood", 
			2 => "Wooden Plank", 
			3 => "Wooden Stick", 
			4 => "Ironite Ore", 
			5 => "Goldium Ore", 
			6 => "Diamonite Ore", 
			7 => "Raw Meat", 
			8 => "Cooked Meat", 
			9 => "Herb", 
			10 => "Shroom", 
			11 => "Root", 
			12 => "Ironite Bar", 
			13 => "Goldium Bar", 
			14 => "Diamonite Bar", 
			15 => "HP Potion", 
			16 => "Mana Potion", 
			17 => "Vial of Poison", 
			18 => "Monster Bone", 
			19 => "Monster Hide", 
			20 => "Cloth", 
			21 => "Raw Chicken", 
			22 => "Cooked Chicken", 
			23 => "Spider Web", 
			24 => "Sword Hilt", 
			25 => "Wooden Blade", 
			26 => "Axe Handle", 
			27 => "Pick Handle", 
			28 => "Unstrung Bow", 
			29 => "String", 
			30 => "Fire Bug", 
			31 => "Thunder Bug", 
			32 => "Ironite Blade", 
			33 => "Goldmium Blade", 
			34 => "Diamonite Blade", 
			35 => "Ironite Great Blade", 
			36 => "Goldium Great Blade", 
			37 => "Diamonite Great Blade", 
			38 => "Stone", 
			39 => "Refined Stone", 
			40 => "Stone Blade", 
			41 => "Stone Great Blade", 
			42 => "Big HP Potion", 
			43 => "Big Mana Potion", 
			44 => "Mysterious Potion", 
			45 => "Big Mysterious Potion", 
			46 => "Key", 
			47 => "Coal", 
			48 => "Firestarter", 
			49 => "Mystery Key", 
			50 => "Bone Blade", 
			51 => "Refined Bone", 
			52 => "Bone Arrow", 
			53 => "Stone Arrow", 
			54 => "Iron Arrow", 
			55 => "Goldium Arrow", 
			56 => "Diamonite Arrow", 
			57 => "Dragonite Arrow", 
			58 => "Adamantite Arrow", 
			59 => "Obsidian Arrow", 
			60 => "Crystalite Fragment", 
			61 => "Crystalite Shard", 
			62 => "Dragonite Ore", 
			63 => "Dragonite Bar", 
			64 => "Adamantite Ore", 
			65 => "Adamantite Bar", 
			66 => "Obsidian Ore", 
			67 => "Obsidian Bar", 
			68 => "Net", 
			69 => "Fire Gem I", 
			70 => "Thunder Gem I", 
			71 => "Wooden Dagger", 
			72 => "Stone Dagger", 
			73 => "Bone Dagger", 
			74 => "Ironite Dagger", 
			75 => "Goldium Dagger", 
			76 => "Diamonite Dagger", 
			_ => "NULL", 
		};
	}

	public override string GetGearName(int id)
	{
		string text = null;
		return id switch
		{
			500 => "Wooden Sword", 
			501 => "Wooden Axe", 
			502 => "Wooden Pick", 
			503 => "Ironite Sword", 
			504 => "Ironite Axe", 
			505 => "Ironite Pick", 
			506 => "Goldium Sword", 
			507 => "Goldium Axe", 
			508 => "Goldium Pick", 
			509 => "Diamonite Sword", 
			510 => "Diamonite Axe", 
			511 => "Diamonite Pick", 
			512 => "Stone Sword", 
			513 => "Stone Axe", 
			514 => "Stone Pick", 
			515 => "Wooden Bow", 
			516 => "Bone Sword", 
			517 => "Bone Axe", 
			518 => "Bone Pick", 
			519 => "Wooden Club", 
			520 => "Excalibur", 
			521 => "Dragonite Axe", 
			522 => "Dragonite Pick", 
			523 => "Wightslayer", 
			524 => "Adamantite Axe", 
			525 => "Adamantite Pick", 
			526 => "Spellblade", 
			527 => "Obsidian Axe", 
			528 => "Obsidian Pick", 
			529 => "Bug Net", 
			550 => "Giant Fish", 
			560 => "Ironite Great Axe", 
			561 => "Goldium Great Axe", 
			562 => "Diamonite Great Axe", 
			563 => "Stone Great Axe", 
			564 => "Hellswrath", 
			565 => "Vorpal Axe", 
			566 => "Godslayer", 
			600 => "Fireball", 
			601 => "Bolt", 
			602 => "Frostshard", 
			700 => "Ironite Helm", 
			701 => "Goldium Helm", 
			702 => "Diamonite Helm", 
			703 => "Stone Helm", 
			704 => "Bone Helm", 
			705 => "Green Hood", 
			706 => "Blue Hood", 
			707 => "Red Hood", 
			708 => "Black Hood", 
			709 => "Dragonite Helm", 
			710 => "Adamantite Helm", 
			711 => "Obsidian Helm", 
			800 => "Ironite Armor", 
			801 => "Goldium Armor", 
			802 => "Diamonite Armor", 
			803 => "Stone Armor", 
			804 => "Bone Armor", 
			900 => "Ironite Shield", 
			901 => "Goldium Shield", 
			902 => "Diamonite Shield", 
			903 => "Stone Shield", 
			904 => "Bone Shield", 
			_ => "NULL", 
		};
	}

	public override void Main()
	{
	}
}
