// Assembly-UnityScript, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// GameScript
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
	internal sealed class _0024Invader_00241516 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241517;

			internal int _0024waitTime_00241518;

			internal GameScript _0024self__00241519;

			public _0024(GameScript self_)
			{
				_0024self__00241519 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00241517 = default(int);
					_0024waitTime_00241518 = UnityEngine.Random.Range(300, 350);
					if (districtLevel <= 1)
					{
						_0024waitTime_00241518 *= 2;
					}
					if (MenuScript.GameMode == 1 && districtLevel < 20)
					{
						_0024waitTime_00241518 = 3;
						_0024self__00241519.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/madman", typeof(AudioClip)));
					}
					result = (Yield(2, new WaitForSeconds(_0024waitTime_00241518)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241519.StartCoroutine_Auto(_0024self__00241519.Write(5));
					player.GetComponent<NetworkView>().RPC("Boss", RPCMode.All);
					if (MenuScript.GameMode == 1 && districtLevel < 20)
					{
						Network.Instantiate(Resources.Load("e/scourgeWall"), new Vector3(-15f, 0f, 0f), Quaternion.identity, 0);
					}
					_0024i_00241517 = 0;
					goto IL_0176;
				case 3:
					_0024i_00241517++;
					goto IL_0176;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0176:
					if (_0024i_00241517 < 5)
					{
						Network.Instantiate(Resources.Load("e/invader"), new Vector3(-15f, 15f, 0f), Quaternion.identity, 0);
						result = (Yield(3, new WaitForSeconds(UnityEngine.Random.Range(3, 8))) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241520;

		public _0024Invader_00241516(GameScript self_)
		{
			_0024self__00241520 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241520);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Timer_00241521 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241522;

			public _0024(GameScript self_)
			{
				_0024self__00241522 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (!_0024self__00241522.dead)
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

		internal GameScript _0024self__00241523;

		public _0024Timer_00241521(GameScript self_)
		{
			_0024self__00241523 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241523);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RegenManaComp_00241524 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241525;

			public _0024(GameScript self_)
			{
				_0024self__00241525 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 2:
					if (MAG < MAXMAG)
					{
						MAG++;
						_0024self__00241525.LoadMana();
					}
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241526;

		public _0024RegenManaComp_00241524(GameScript self_)
		{
			_0024self__00241526 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241526);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ScourgeMaskTick_00241527 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(5f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.pHat == 17)
					{
						goto IL_003f;
					}
					YieldDefault(1);
					goto case 1;
				case 3:
					player.SendMessage("TD", 1);
					goto IL_003f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_003f:
					result = (Yield(3, new WaitForSeconds(115f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TikiCheck_00241528 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024noo_00241529;

			internal GameObject _0024pot_00241530;

			internal GameScript _0024self__00241531;

			public _0024(GameScript self_)
			{
				_0024self__00241531 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.pHat == 10)
					{
						_0024noo_00241529 = UnityEngine.Random.Range(0, 2);
						if (_0024noo_00241529 == 0)
						{
							player.SendMessage("TD", 1);
						}
						else
						{
							HP += 3;
							_0024pot_00241530 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
							_0024pot_00241530.SendMessage("SD", 3);
							_0024self__00241531.LoadHearts();
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

		internal GameScript _0024self__00241532;

		public _0024TikiCheck_00241528(GameScript self_)
		{
			_0024self__00241532 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241532);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RecoverMana_00241533 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024noo_00241534;

			internal GameScript _0024self__00241535;

			public _0024(GameScript self_)
			{
				_0024self__00241535 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(manaWait)) ? 1 : 0);
					break;
				case 2:
					if (MAG < MAXMAG)
					{
						MAG++;
						_0024self__00241535.LoadMana();
						_0024self__00241535.GUImana.GetComponent<Animation>().Play();
						if (MenuScript.pHat == 18)
						{
							_0024noo_00241534 = UnityEngine.Random.Range(0, 5);
							if (_0024noo_00241534 == 0 && HP < MAXHP)
							{
								HP++;
								_0024self__00241535.LoadHearts();
							}
						}
					}
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241536;

		public _0024RecoverMana_00241533(GameScript self_)
		{
			_0024self__00241536 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241536);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ScourgeBoss_00241537 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024enemy_00241538;

			internal int _0024d_00241539;

			public _0024(int d)
			{
				_0024d_00241539 = d;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024enemy_00241538 = null;
					if (!isTown)
					{
						if (_0024d_00241539 == 5)
						{
							_0024enemy_00241538 = "abyssalTitan";
						}
						else if (_0024d_00241539 == 10)
						{
							_0024enemy_00241538 = "scourgeKnight";
						}
						else if (_0024d_00241539 == 15)
						{
							_0024enemy_00241538 = "scourgeKnight";
						}
						else
						{
							_0024enemy_00241538 = "abyssalTitan";
						}
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_00e6;
				case 2:
					if ((bool)exitObj)
					{
						exitObj.SendMessage("Close");
					}
					Network.Instantiate(Resources.Load("e/" + _0024enemy_00241538), new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
					goto IL_00e6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00e6:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024d_00241540;

		public _0024ScourgeBoss_00241537(int d)
		{
			_0024d_00241540 = d;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024d_00241540);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Write_00241541 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024tt_00241542;

			internal int _0024_0024switch_0024178_00241543;

			internal int _0024num_00241544;

			internal GameScript _0024self__00241545;

			public _0024(int num, GameScript self_)
			{
				_0024num_00241544 = num;
				_0024self__00241545 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					MonoBehaviour.print("WRITING");
					_0024tt_00241542 = null;
					_0024_0024switch_0024178_00241543 = _0024num_00241544;
					if (_0024_0024switch_0024178_00241543 == 0)
					{
						_0024tt_00241542 = "Your " + _0024self__00241545.GetGearName(inventory[curActiveSlot].id) + " is about to break.";
					}
					else if (_0024_0024switch_0024178_00241543 == 1)
					{
						_0024tt_00241542 = "Your stomach begins to grumble.";
					}
					else if (_0024_0024switch_0024178_00241543 == 2)
					{
						_0024tt_00241542 = "You are starving.";
					}
					else if (_0024_0024switch_0024178_00241543 == 3)
					{
						_0024tt_00241542 = "You feel uneasy.";
					}
					else if (_0024_0024switch_0024178_00241543 == 4)
					{
						_0024tt_00241542 = "A slight breeze brushes against your face.";
					}
					else if (_0024_0024switch_0024178_00241543 == 5)
					{
						_0024self__00241545.GlobalWrite(0);
					}
					else if (_0024_0024switch_0024178_00241543 == 6)
					{
						_0024tt_00241542 = "You feel as if the Scourge are watching you...";
					}
					else if (_0024_0024switch_0024178_00241543 == 7)
					{
						_0024tt_00241542 = "You've awakened the Broodmother...";
					}
					else
					{
						_0024tt_00241542 = string.Empty;
					}
					if (!string.IsNullOrEmpty(_0024tt_00241542))
					{
						_0024self__00241545.txtStatus2.gameObject.SetActive(value: true);
						_0024self__00241545.txtStatus2.text = _0024tt_00241542;
						result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto IL_01b2;
				case 2:
					_0024self__00241545.txtStatus2.text = " ";
					goto IL_01b2;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01b2:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024num_00241546;

		internal GameScript _0024self__00241547;

		public _0024Write_00241541(int num, GameScript self_)
		{
			_0024num_00241546 = num;
			_0024self__00241547 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024num_00241546, _0024self__00241547);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024WriteFinal_00241548 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024tt_00241549;

			internal int _0024_0024switch_0024180_00241550;

			internal int _0024a_00241551;

			internal GameScript _0024self__00241552;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241551 = a;
				_0024self__00241552 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024tt_00241549 = null;
					_0024_0024switch_0024180_00241550 = _0024a_00241551;
					_0024tt_00241549 = "The Scourge have invaded! Get out!!";
					_0024self__00241552.txtStatus2.gameObject.SetActive(value: true);
					_0024self__00241552.txtStatus2.text = _0024tt_00241549;
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241552.txtStatus2.text = " ";
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241553;

		internal GameScript _0024self__00241554;

		public _0024WriteFinal_00241548(int a, GameScript self_)
		{
			_0024a_00241553 = a;
			_0024self__00241554 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00241553, _0024self__00241554);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GenerateText_00241555 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241556;

			internal string _0024tt_00241557;

			internal int _0024_0024switch_0024182_00241558;

			internal GameScript _0024self__00241559;

			public _0024(GameScript self_)
			{
				_0024self__00241559 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024num_00241556 = UnityEngine.Random.Range(0, 30);
					_0024tt_00241557 = null;
					_0024_0024switch_0024182_00241558 = _0024num_00241556;
					if (_0024_0024switch_0024182_00241558 == 0)
					{
						_0024tt_00241557 = "You feel as if you are being watched...";
					}
					else if (_0024_0024switch_0024182_00241558 == 1)
					{
						_0024tt_00241557 = "You hear a distant rumble...";
					}
					else if (_0024_0024switch_0024182_00241558 == 2)
					{
						_0024tt_00241557 = "There is a foul taste in the air.";
					}
					else if (_0024_0024switch_0024182_00241558 == 3)
					{
						_0024tt_00241557 = "You feel uneasy.";
					}
					else if (_0024_0024switch_0024182_00241558 == 4)
					{
						_0024tt_00241557 = "A slight breeze brushes against your face.";
					}
					else
					{
						_0024tt_00241557 = string.Empty;
					}
					if ((bool)_0024self__00241559.txtStatus2)
					{
						_0024self__00241559.txtStatus2.text = _0024tt_00241557;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0126;
				case 2:
					_0024self__00241559.txtStatus2.text = string.Empty;
					goto IL_0126;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0126:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241560;

		public _0024GenerateText_00241555(GameScript self_)
		{
			_0024self__00241560 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241560);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241561 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241562;

			public _0024(GameScript self_)
			{
				_0024self__00241562 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241562.StartCoroutine_Auto(_0024self__00241562.StaminaStart());
					menuOpen = false;
					_0024self__00241562.LoadHearts();
					_0024self__00241562.LoadMana();
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					isReturning = false;
					_0024self__00241562.RefreshGold();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241563;

		public _0024Start_00241561(GameScript self_)
		{
			_0024self__00241563 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241563);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024StaminaStart_00241564 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024ppp_00241565;

			internal GameScript _0024self__00241566;

			public _0024(GameScript self_)
			{
				_0024self__00241566 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024ppp_00241565 = playerLevel;
					if (_0024ppp_00241565 <= 4)
					{
						_0024self__00241566.maxStamina = 4;
					}
					else if (_0024ppp_00241565 <= 12)
					{
						_0024self__00241566.maxStamina = _0024ppp_00241565;
					}
					else
					{
						_0024self__00241566.maxStamina = 12;
					}
					_0024self__00241566.stamina = _0024self__00241566.maxStamina;
					goto case 2;
				case 2:
					if (!(_0024self__00241566.stamina >= (float)_0024self__00241566.maxStamina))
					{
						_0024self__00241566.stamina += 1f;
						_0024self__00241566.LoadSTA();
					}
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241567;

		public _0024StaminaStart_00241564(GameScript self_)
		{
			_0024self__00241567 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241567);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024WriteEgg_00241568 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241569;

			public _0024(GameScript self_)
			{
				_0024self__00241569 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241569.writingEgg = true;
					_0024self__00241569.StartCoroutine_Auto(_0024self__00241569.Write(7));
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241569.writingEgg = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241570;

		public _0024WriteEgg_00241568(GameScript self_)
		{
			_0024self__00241570 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241570);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AddInput_00241571 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241572;

			internal GameScript _0024self__00241573;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241572 = a;
				_0024self__00241573 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241573.addingInput)
					{
						_0024self__00241573.GetComponent<AudioSource>().PlayOneShot(_0024self__00241573.audioSelect2);
						_0024self__00241573.cheatButton[_0024a_00241572 - 1].GetComponent<Animation>().Play();
						if (_0024self__00241573.inputCount == 0)
						{
							_0024self__00241573.txtInput.text = string.Empty;
						}
						_0024self__00241573.addingInput = true;
						_0024self__00241573.inputString[_0024self__00241573.inputCount] = _0024a_00241572;
						_0024self__00241573.inputCount++;
						_0024self__00241573.txtInput.text = _0024self__00241573.txtInput.text + (_0024a_00241572 + string.Empty);
						if (_0024self__00241573.inputCount == 7)
						{
							result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						goto IL_013f;
					}
					goto IL_014b;
				case 2:
					_0024self__00241573.CheckInput();
					_0024self__00241573.inputCount = 0;
					goto IL_013f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_014b:
					YieldDefault(1);
					goto case 1;
					IL_013f:
					_0024self__00241573.addingInput = false;
					goto IL_014b;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241574;

		internal GameScript _0024self__00241575;

		public _0024AddInput_00241571(int a, GameScript self_)
		{
			_0024a_00241574 = a;
			_0024self__00241575 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00241574, _0024self__00241575);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Craft_00241576 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024canCraft_00241577;

			internal string _0024craft_00241578;

			internal int _0024c1_00241579;

			internal int _0024c2_00241580;

			internal Item _0024newItem_00241581;

			internal int _0024newID_00241582;

			internal int _0024newQ_00241583;

			internal int _0024i_00241584;

			internal int _0024pood_00241585;

			internal int _0024lowestQ_00241586;

			internal int _0024aTemp_00241587;

			internal float _0024tempForge_00241588;

			internal int _0024luckCount_00241589;

			internal int _0024bonusStat_00241590;

			internal int _0024num1_00241591;

			internal GameScript _0024self__00241592;

			public _0024(GameScript self_)
			{
				_0024self__00241592 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024canCraft_00241577 = true;
					result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					_0024craft_00241578 = _0024self__00241592.firstItemSelected.id + "c" + _0024self__00241592.secondItemSelected.id;
					_0024c1_00241579 = _0024self__00241592.firstItemSelected.id;
					_0024c2_00241580 = _0024self__00241592.secondItemSelected.id;
					_0024newItem_00241581 = null;
					_0024newID_00241582 = 0;
					_0024newQ_00241583 = default(int);
					MonoBehaviour.print("crafting " + _0024c1_00241579 + " " + _0024c2_00241580);
					if (_0024c1_00241579 == 1 && _0024c2_00241580 == 1)
					{
						_0024newID_00241582 = 2;
					}
					else if (_0024c1_00241579 == 2 && _0024c2_00241580 == 2)
					{
						_0024newID_00241582 = 25;
					}
					else if (_0024c1_00241579 == 2 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 24;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 2)
					{
						_0024newID_00241582 = 24;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 26;
					}
					else if (_0024c1_00241579 == 9 && _0024c2_00241580 == 9)
					{
						_0024newID_00241582 = 15;
					}
					else if (_0024c1_00241579 == 25 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 501;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 25)
					{
						_0024newID_00241582 = 501;
					}
					else if (_0024c1_00241579 == 24 && _0024c2_00241580 == 25)
					{
						_0024newID_00241582 = 500;
					}
					else if (_0024c1_00241579 == 25 && _0024c2_00241580 == 24)
					{
						_0024newID_00241582 = 500;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 27;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 27;
					}
					else if (_0024c1_00241579 == 27 && _0024c2_00241580 == 25)
					{
						_0024newID_00241582 = 502;
					}
					else if (_0024c1_00241579 == 25 && _0024c2_00241580 == 27)
					{
						_0024newID_00241582 = 502;
					}
					else if (_0024c1_00241579 == 38 && _0024c2_00241580 == 38)
					{
						_0024newID_00241582 = 39;
					}
					else if (_0024c1_00241579 == 39 && _0024c2_00241580 == 39)
					{
						_0024newID_00241582 = 40;
					}
					else if (_0024c1_00241579 == 24 && _0024c2_00241580 == 40)
					{
						_0024newID_00241582 = 512;
					}
					else if (_0024c1_00241579 == 40 && _0024c2_00241580 == 24)
					{
						_0024newID_00241582 = 512;
					}
					else if (_0024c1_00241579 == 40 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 513;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 40)
					{
						_0024newID_00241582 = 513;
					}
					else if (_0024c1_00241579 == 40 && _0024c2_00241580 == 27)
					{
						_0024newID_00241582 = 514;
					}
					else if (_0024c1_00241579 == 27 && _0024c2_00241580 == 40)
					{
						_0024newID_00241582 = 514;
					}
					else if (_0024c1_00241579 == 18 && _0024c2_00241580 == 18)
					{
						_0024newID_00241582 = 51;
					}
					else if (_0024c1_00241579 == 71 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 602;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 71)
					{
						_0024newID_00241582 = 602;
					}
					else if (_0024c1_00241579 == 18 && _0024c2_00241580 == 50)
					{
						_0024newID_00241582 = 517;
					}
					else if (_0024c1_00241579 == 50 && _0024c2_00241580 == 18)
					{
						_0024newID_00241582 = 517;
					}
					else if (_0024c1_00241579 == 19 && _0024c2_00241580 == 19)
					{
						_0024newID_00241582 = 82;
					}
					else if (_0024c1_00241579 == 20 && _0024c2_00241580 == 20)
					{
						_0024newID_00241582 = 94;
					}
					else if (_0024c1_00241579 == 81 && _0024c2_00241580 == 81)
					{
						_0024newID_00241582 = 71;
					}
					else if (_0024c1_00241579 == 2 && _0024c2_00241580 == 82)
					{
						_0024newID_00241582 = 77;
					}
					else if (_0024c1_00241579 == 82 && _0024c2_00241580 == 2)
					{
						_0024newID_00241582 = 77;
					}
					else if (_0024c1_00241579 == 77 && _0024c2_00241580 == 30)
					{
						_0024newID_00241582 = 78;
					}
					else if (_0024c1_00241579 == 30 && _0024c2_00241580 == 77)
					{
						_0024newID_00241582 = 78;
					}
					else if (_0024c1_00241579 == 77 && _0024c2_00241580 == 31)
					{
						_0024newID_00241582 = 79;
					}
					else if (_0024c1_00241579 == 31 && _0024c2_00241580 == 77)
					{
						_0024newID_00241582 = 79;
					}
					else if (_0024c1_00241579 == 77 && _0024c2_00241580 == 81)
					{
						_0024newID_00241582 = 80;
					}
					else if (_0024c1_00241579 == 81 && _0024c2_00241580 == 77)
					{
						_0024newID_00241582 = 80;
					}
					else if (_0024c1_00241579 == 69 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 600;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 69)
					{
						_0024newID_00241582 = 600;
					}
					else if (_0024c1_00241579 == 70 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 601;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 70)
					{
						_0024newID_00241582 = 601;
					}
					else if (_0024c1_00241579 == 30 && _0024c2_00241580 == 30)
					{
						_0024newID_00241582 = 69;
					}
					else if (_0024c1_00241579 == 31 && _0024c2_00241580 == 31)
					{
						_0024newID_00241582 = 70;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 50)
					{
						_0024newID_00241582 = 517;
					}
					else if (_0024c1_00241579 == 50 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 517;
					}
					else if (_0024c1_00241579 == 24 && _0024c2_00241580 == 50)
					{
						_0024newID_00241582 = 516;
					}
					else if (_0024c1_00241579 == 50 && _0024c2_00241580 == 24)
					{
						_0024newID_00241582 = 516;
					}
					else if (_0024c1_00241579 == 60 && _0024c2_00241580 == 60)
					{
						_0024newID_00241582 = 61;
					}
					else if (_0024c1_00241579 == 51 && _0024c2_00241580 == 51)
					{
						_0024newID_00241582 = 50;
					}
					else if (_0024c1_00241579 == 27 && _0024c2_00241580 == 50)
					{
						_0024newID_00241582 = 518;
					}
					else if (_0024c1_00241579 == 50 && _0024c2_00241580 == 27)
					{
						_0024newID_00241582 = 518;
					}
					else if (_0024c1_00241579 == 29 && _0024c2_00241580 == 29)
					{
						_0024newID_00241582 = 68;
					}
					else if (_0024c1_00241579 == 27 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 28;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 27)
					{
						_0024newID_00241582 = 28;
					}
					else if (_0024c1_00241579 == 28 && _0024c2_00241580 == 29)
					{
						_0024newID_00241582 = 515;
					}
					else if (_0024c1_00241579 == 29 && _0024c2_00241580 == 28)
					{
						_0024newID_00241582 = 515;
					}
					else if (_0024c1_00241579 == 12 && _0024c2_00241580 == 12)
					{
						_0024newID_00241582 = 32;
					}
					else if (_0024c1_00241579 == 13 && _0024c2_00241580 == 13)
					{
						_0024newID_00241582 = 33;
					}
					else if (_0024c1_00241579 == 14 && _0024c2_00241580 == 14)
					{
						_0024newID_00241582 = 34;
					}
					else if (_0024c1_00241579 == 39 && _0024c2_00241580 == 39)
					{
						_0024newID_00241582 = 40;
					}
					else if (_0024c1_00241579 == 32 && _0024c2_00241580 == 24)
					{
						_0024newID_00241582 = 503;
					}
					else if (_0024c1_00241579 == 24 && _0024c2_00241580 == 32)
					{
						_0024newID_00241582 = 503;
					}
					else if (_0024c1_00241579 == 32 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 504;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 32)
					{
						_0024newID_00241582 = 504;
					}
					else if (_0024c1_00241579 == 32 && _0024c2_00241580 == 27)
					{
						_0024newID_00241582 = 505;
					}
					else if (_0024c1_00241579 == 27 && _0024c2_00241580 == 32)
					{
						_0024newID_00241582 = 505;
					}
					else if (_0024c1_00241579 == 24 && _0024c2_00241580 == 33)
					{
						_0024newID_00241582 = 506;
					}
					else if (_0024c1_00241579 == 33 && _0024c2_00241580 == 24)
					{
						_0024newID_00241582 = 506;
					}
					else if (_0024c1_00241579 == 33 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 507;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 33)
					{
						_0024newID_00241582 = 507;
					}
					else if (_0024c1_00241579 == 33 && _0024c2_00241580 == 27)
					{
						_0024newID_00241582 = 508;
					}
					else if (_0024c1_00241579 == 27 && _0024c2_00241580 == 33)
					{
						_0024newID_00241582 = 508;
					}
					else if (_0024c1_00241579 == 24 && _0024c2_00241580 == 34)
					{
						_0024newID_00241582 = 509;
					}
					else if (_0024c1_00241579 == 34 && _0024c2_00241580 == 24)
					{
						_0024newID_00241582 = 509;
					}
					else if (_0024c1_00241579 == 34 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 510;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 34)
					{
						_0024newID_00241582 = 510;
					}
					else if (_0024c1_00241579 == 34 && _0024c2_00241580 == 27)
					{
						_0024newID_00241582 = 511;
					}
					else if (_0024c1_00241579 == 27 && _0024c2_00241580 == 34)
					{
						_0024newID_00241582 = 511;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 35)
					{
						_0024newID_00241582 = 560;
					}
					else if (_0024c1_00241579 == 35 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 560;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 36)
					{
						_0024newID_00241582 = 561;
					}
					else if (_0024c1_00241579 == 36 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 561;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 37)
					{
						_0024newID_00241582 = 562;
					}
					else if (_0024c1_00241579 == 37 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 562;
					}
					else if (_0024c1_00241579 == 26 && _0024c2_00241580 == 41)
					{
						_0024newID_00241582 = 563;
					}
					else if (_0024c1_00241579 == 41 && _0024c2_00241580 == 26)
					{
						_0024newID_00241582 = 563;
					}
					else if (_0024c1_00241579 == 567 && _0024c2_00241580 == 71)
					{
						_0024newID_00241582 = 568;
					}
					else if (_0024c1_00241579 == 71 && _0024c2_00241580 == 567)
					{
						_0024newID_00241582 = 568;
					}
					else if (_0024c1_00241579 == 567 && _0024c2_00241580 == 69)
					{
						_0024newID_00241582 = 569;
					}
					else if (_0024c1_00241579 == 69 && _0024c2_00241580 == 567)
					{
						_0024newID_00241582 = 569;
					}
					else if (_0024c1_00241579 == 567 && _0024c2_00241580 == 70)
					{
						_0024newID_00241582 = 570;
					}
					else if (_0024c1_00241579 == 70 && _0024c2_00241580 == 567)
					{
						_0024newID_00241582 = 570;
					}
					else if (_0024c1_00241579 == 32 && _0024c2_00241580 == 32)
					{
						_0024newID_00241582 = 35;
					}
					else if (_0024c1_00241579 == 33 && _0024c2_00241580 == 33)
					{
						_0024newID_00241582 = 36;
					}
					else if (_0024c1_00241579 == 34 && _0024c2_00241580 == 34)
					{
						_0024newID_00241582 = 37;
					}
					else if (_0024c1_00241579 == 40 && _0024c2_00241580 == 40)
					{
						_0024newID_00241582 = 41;
					}
					else if (_0024c1_00241579 == 68 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 529;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 68)
					{
						_0024newID_00241582 = 529;
					}
					else if (_0024c1_00241579 == 15 && _0024c2_00241580 == 15)
					{
						_0024newID_00241582 = 42;
					}
					else if (_0024c1_00241579 == 16 && _0024c2_00241580 == 16)
					{
						_0024newID_00241582 = 43;
					}
					else if (_0024c1_00241579 == 44 && _0024c2_00241580 == 44)
					{
						_0024newID_00241582 = 45;
					}
					else if (_0024c1_00241579 == 10 && _0024c2_00241580 == 10)
					{
						_0024newID_00241582 = 16;
					}
					else if (_0024c1_00241579 == 23 && _0024c2_00241580 == 23)
					{
						_0024newID_00241582 = 29;
					}
					else if (_0024c1_00241579 == 39 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 53;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 39)
					{
						_0024newID_00241582 = 53;
					}
					else if (_0024c1_00241579 == 12 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 54;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 12)
					{
						_0024newID_00241582 = 54;
					}
					else if (_0024c1_00241579 == 13 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 55;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 13)
					{
						_0024newID_00241582 = 55;
					}
					else if (_0024c1_00241579 == 51 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 52;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 51)
					{
						_0024newID_00241582 = 52;
					}
					else if (_0024c1_00241579 == 3 && _0024c2_00241580 == 14)
					{
						_0024newID_00241582 = 56;
					}
					else if (_0024c1_00241579 == 14 && _0024c2_00241580 == 3)
					{
						_0024newID_00241582 = 56;
					}
					else if ((_0024c1_00241579 == 47 && _0024c2_00241580 == 47) || (_0024c1_00241579 == 38 && _0024c2_00241580 == 47) || (_0024c1_00241579 == 47 && _0024c2_00241580 == 38))
					{
						_0024newID_00241582 = 48;
					}
					else if ((_0024c1_00241579 == 9 && _0024c2_00241580 == 10) || (_0024c1_00241579 == 10 && _0024c2_00241580 == 9) || (_0024c1_00241579 == 9 && _0024c2_00241580 == 11) || (_0024c1_00241579 == 11 && _0024c2_00241580 == 9) || (_0024c1_00241579 == 10 && _0024c2_00241580 == 11) || (_0024c1_00241579 == 11 && _0024c2_00241580 == 10))
					{
						_0024newID_00241582 = 44;
					}
					else if (_0024c1_00241579 == 44 && _0024c2_00241580 == 44)
					{
						_0024newID_00241582 = 45;
					}
					else
					{
						_0024canCraft_00241577 = false;
					}
					if (_0024newID_00241582 >= 600 && _0024newID_00241582 <= 605)
					{
						MenuScript.canUnlockHat[5] = 1;
					}
					if (_0024canCraft_00241577 && _0024newID_00241582 == 568)
					{
						legendary[0] = 1;
					}
					else if (_0024canCraft_00241577 && _0024newID_00241582 == 569)
					{
						legendary[1] = 1;
					}
					else if (_0024canCraft_00241577 && _0024newID_00241582 == 570)
					{
						legendary[2] = 1;
					}
					if (_0024canCraft_00241577)
					{
						_0024i_00241584 = default(int);
						_0024pood_00241585 = UnityEngine.Random.Range(0, 2);
						if (_0024newID_00241582 == 15 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && _0024pood_00241585 == 0)
						{
							_0024newID_00241582 = 42;
						}
						if (_0024newID_00241582 == 16 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && _0024pood_00241585 == 0)
						{
							_0024newID_00241582 = 43;
						}
						if (_0024newID_00241582 == 44 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && _0024pood_00241585 == 0)
						{
							_0024newID_00241582 = 45;
						}
						_0024self__00241592.GetComponent<AudioSource>().PlayOneShot(_0024self__00241592.audioCraftt);
						if (_0024newID_00241582 < 500)
						{
							_0024lowestQ_00241586 = default(int);
							_0024aTemp_00241587 = 1;
							if (_0024newID_00241582 >= 52 && _0024newID_00241582 <= 56)
							{
								_0024aTemp_00241587 = 5;
							}
							if (_0024self__00241592.firstItemSelected.q == _0024self__00241592.secondItemSelected.q)
							{
								_0024lowestQ_00241586 = _0024self__00241592.firstItemSelected.q;
								_0024newItem_00241581 = new Item(_0024newID_00241582, _0024self__00241592.firstItemSelected.q * _0024aTemp_00241587, new int[4], 0f, null);
								inventory[_0024self__00241592.secondItemSelectedSlot] = _0024newItem_00241581;
								inventory[_0024self__00241592.firstItemSelectedSlot] = _0024self__00241592.EmptyItem();
								_0024self__00241592.ResetCraft();
								_0024self__00241592.RefreshInventory();
								_0024self__00241592.RefreshActionBar();
							}
							else if (_0024self__00241592.secondItemSelected.q < _0024self__00241592.firstItemSelected.q)
							{
								_0024lowestQ_00241586 = _0024self__00241592.secondItemSelected.q;
								_0024newItem_00241581 = new Item(_0024newID_00241582, _0024self__00241592.secondItemSelected.q * _0024aTemp_00241587, new int[4], 0f, null);
								inventory[_0024self__00241592.secondItemSelectedSlot] = _0024newItem_00241581;
								inventory[_0024self__00241592.firstItemSelectedSlot].q = inventory[_0024self__00241592.firstItemSelectedSlot].q - _0024self__00241592.secondItemSelected.q;
								_0024self__00241592.ResetCraft();
								_0024self__00241592.RefreshInventory();
								_0024self__00241592.RefreshActionBar();
							}
							else if (_0024self__00241592.firstItemSelected.q < _0024self__00241592.secondItemSelected.q)
							{
								_0024lowestQ_00241586 = _0024self__00241592.firstItemSelected.q;
								_0024newItem_00241581 = new Item(_0024newID_00241582, _0024self__00241592.firstItemSelected.q * _0024aTemp_00241587, new int[4], 0f, null);
								inventory[_0024self__00241592.firstItemSelectedSlot] = _0024newItem_00241581;
								inventory[_0024self__00241592.secondItemSelectedSlot].q = inventory[_0024self__00241592.secondItemSelectedSlot].q - _0024self__00241592.firstItemSelected.q;
								_0024self__00241592.ResetCraft();
								_0024self__00241592.RefreshInventory();
								_0024self__00241592.RefreshActionBar();
							}
						}
						else
						{
							_0024tempForge_00241588 = 6f;
							if (MenuScript.curTrait[1] == 5 || MenuScript.curTrait[2] == 5)
							{
								MonoBehaviour.print("+10 luck FORGING GEAR");
								_0024tempForge_00241588 = 12f;
							}
							_0024newItem_00241581 = new Item(_0024newID_00241582, 1, _0024self__00241592.GetGearStats(_0024newID_00241582), _0024self__00241592.GetMaxDurability(_0024newID_00241582), null);
							_0024luckCount_00241589 = UnityEngine.Random.Range(0, 100);
							_0024bonusStat_00241590 = default(int);
							_0024num1_00241591 = default(int);
							if (!((float)_0024luckCount_00241589 >= _0024tempForge_00241588 * 0.5f))
							{
								for (_0024i_00241584 = 0; _0024i_00241584 < 4; _0024i_00241584++)
								{
									_0024bonusStat_00241590 = UnityEngine.Random.Range(0, 4);
									_0024num1_00241591 = UnityEngine.Random.Range(1, 3);
									_0024newItem_00241581.e[_0024bonusStat_00241590] = _0024newItem_00241581.e[_0024bonusStat_00241590] + _0024num1_00241591;
									_0024newItem_00241581.tier = 3;
								}
							}
							else if (!((float)_0024luckCount_00241589 >= _0024tempForge_00241588))
							{
								for (_0024i_00241584 = 0; _0024i_00241584 < 2; _0024i_00241584++)
								{
									_0024bonusStat_00241590 = UnityEngine.Random.Range(0, 4);
									_0024num1_00241591 = UnityEngine.Random.Range(1, 3);
									_0024newItem_00241581.e[_0024bonusStat_00241590] = _0024newItem_00241581.e[_0024bonusStat_00241590] + _0024num1_00241591;
									_0024newItem_00241581.tier = 2;
								}
							}
							else if (!((float)_0024luckCount_00241589 >= _0024tempForge_00241588 * 2f))
							{
								for (_0024i_00241584 = 0; _0024i_00241584 < 1; _0024i_00241584++)
								{
									_0024bonusStat_00241590 = UnityEngine.Random.Range(0, 4);
									_0024num1_00241591 = UnityEngine.Random.Range(1, 3);
									_0024newItem_00241581.e[_0024bonusStat_00241590] = _0024newItem_00241581.e[_0024bonusStat_00241590] + _0024num1_00241591;
									_0024newItem_00241581.tier = 1;
								}
							}
							_0024self__00241592.holdingItem = true;
							_0024self__00241592.itemSelected = _0024newItem_00241581;
							_0024self__00241592.firstItemSelected.q = _0024self__00241592.firstItemSelected.q - 1;
							_0024self__00241592.secondItemSelected.q = _0024self__00241592.secondItemSelected.q - 1;
							if (_0024self__00241592.firstItemSelected.q < 1)
							{
								inventory[_0024self__00241592.firstItemSelectedSlot] = _0024self__00241592.EmptyItem();
							}
							if (_0024self__00241592.secondItemSelected.q < 1)
							{
								inventory[_0024self__00241592.secondItemSelectedSlot] = _0024self__00241592.EmptyItem();
							}
							_0024self__00241592.ResetCraft();
							_0024self__00241592.UpdateHoldingItem();
							_0024self__00241592.RefreshInventory();
							_0024self__00241592.RefreshActionBar();
						}
						tempStats[4] = tempStats[4] + 1;
					}
					else
					{
						_0024self__00241592.ResetCraft();
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

		internal GameScript _0024self__00241593;

		public _0024Craft_00241576(GameScript self_)
		{
			_0024self__00241593 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241593);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SelectReward_00241594 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024temp_00241595;

			internal int _0024bonusScore_00241596;

			internal GameObject _0024dd_00241597;

			internal int _0024c_00241598;

			internal GameScript _0024self__00241599;

			public _0024(int c, GameScript self_)
			{
				_0024c_00241598 = c;
				_0024self__00241599 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241599.selectingReward && _0024self__00241599.rewardChest[_0024c_00241598] > 0)
					{
						_0024self__00241599.selectingReward = true;
						_0024temp_00241595 = default(int);
						_0024self__00241599.rewardChestObj[_0024c_00241598].GetComponent<Renderer>().material = _0024self__00241599.rewOpened;
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_0491;
				case 2:
					if (_0024self__00241599.rewardChest[_0024c_00241598] == 999)
					{
						_0024bonusScore_00241596 = _0024self__00241599.GetScoreBonus();
						_0024dd_00241597 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("bonusScore"), _0024self__00241599.rewardChestObj[_0024c_00241598].transform.position, Quaternion.identity);
						_0024dd_00241597.SendMessage("SD", _0024bonusScore_00241596);
						MenuScript.curScore += _0024bonusScore_00241596;
						if (MenuScript.curScore > PlayerPrefs.GetInt("hScore"))
						{
							PlayerPrefs.SetInt("hScore", MenuScript.curScore);
						}
						_0024self__00241599.txtHighScore[0].text = string.Empty + MenuScript.curScore;
						_0024self__00241599.txtHighScore[1].text = string.Empty + MenuScript.curScore;
						_0024self__00241599.rewardChest[_0024c_00241598] = 0;
						result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					if (_0024self__00241599.rewardChest[_0024c_00241598] > 200)
					{
						_0024temp_00241595 = _0024self__00241599.rewardChest[_0024c_00241598];
						_0024temp_00241595 -= 200;
						_0024self__00241599.StartCoroutine_Auto(_0024self__00241599.UnlockHat(_0024temp_00241595));
						_0024self__00241599.rewardChest[_0024c_00241598] = 0;
						result = (Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					if (_0024self__00241599.rewardChest[_0024c_00241598] >= 100)
					{
						_0024temp_00241595 = _0024self__00241599.rewardChest[_0024c_00241598];
						_0024temp_00241595 -= 100;
						_0024self__00241599.StartCoroutine_Auto(_0024self__00241599.UnlockComp(_0024temp_00241595));
						_0024self__00241599.rewardChest[_0024c_00241598] = 0;
						result = (Yield(5, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					_0024temp_00241595 = _0024self__00241599.rewardChest[_0024c_00241598];
					if (MenuScript.raceUnlock[_0024temp_00241595 - 1] > 0)
					{
						if (MenuScript.raceUnlock[_0024temp_00241595 - 1] < 3)
						{
							_0024self__00241599.StartCoroutine_Auto(_0024self__00241599.UnlockVariant(_0024temp_00241595));
						}
					}
					else
					{
						_0024self__00241599.StartCoroutine_Auto(_0024self__00241599.UnlockRace(_0024temp_00241595));
					}
					_0024self__00241599.rewardChest[_0024c_00241598] = 0;
					result = (Yield(6, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241599.selectingReward = false;
					_0024self__00241599.rewardChestObj[_0024c_00241598].GetComponent<Renderer>().material = _0024self__00241599.rewShade;
					_0024self__00241599.RewardShowCheck();
					goto IL_0491;
				case 4:
					_0024self__00241599.selectingReward = false;
					_0024self__00241599.rewardChestObj[_0024c_00241598].GetComponent<Renderer>().material = _0024self__00241599.rewShade;
					_0024self__00241599.RewardShowCheck();
					goto IL_0491;
				case 5:
					_0024self__00241599.selectingReward = false;
					_0024self__00241599.rewardChestObj[_0024c_00241598].GetComponent<Renderer>().material = _0024self__00241599.rewShade;
					_0024self__00241599.RewardShowCheck();
					goto IL_0491;
				case 6:
					_0024self__00241599.selectingReward = false;
					_0024self__00241599.rewardChestObj[_0024c_00241598].GetComponent<Renderer>().material = _0024self__00241599.rewShade;
					_0024self__00241599.RewardShowCheck();
					goto IL_0491;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0491:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024c_00241600;

		internal GameScript _0024self__00241601;

		public _0024SelectReward_00241594(int c, GameScript self_)
		{
			_0024c_00241600 = c;
			_0024self__00241601 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024c_00241600, _0024self__00241601);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockHat_00241602 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024h_00241603;

			internal GameScript _0024self__00241604;

			public _0024(int h, GameScript self_)
			{
				_0024h_00241603 = h;
				_0024self__00241604 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241604.txtRewardTop[0].text = "NEW HAT UNLOCKED!";
					_0024self__00241604.rewardIcon.GetComponent<Renderer>().material = (Material)Resources.Load("hat/hat" + _0024h_00241603);
					PlayerPrefs.SetInt("hU" + _0024h_00241603, 1);
					MenuScript.hatUnlock[_0024h_00241603] = 2;
					_0024self__00241604.txtRewardBot[0].text = string.Empty + _0024self__00241604.GetHatName(_0024h_00241603);
					_0024self__00241604.txtRewardTop[1].text = _0024self__00241604.txtRewardTop[0].text;
					_0024self__00241604.txtRewardBot[1].text = _0024self__00241604.txtRewardBot[0].text;
					_0024self__00241604.rewardShade.SetActive(value: true);
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241604.rewardTop.SetActive(value: true);
					_0024self__00241604.rewardBot.SetActive(value: true);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024h_00241605;

		internal GameScript _0024self__00241606;

		public _0024UnlockHat_00241602(int h, GameScript self_)
		{
			_0024h_00241605 = h;
			_0024self__00241606 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024h_00241605, _0024self__00241606);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockComp_00241607 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024h_00241608;

			internal GameScript _0024self__00241609;

			public _0024(int h, GameScript self_)
			{
				_0024h_00241608 = h;
				_0024self__00241609 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241609.txtRewardTop[0].text = "NEW COMPANION UNLOCKED!";
					_0024self__00241609.rewardIcon.GetComponent<Renderer>().material = (Material)Resources.Load("iComp/c" + _0024h_00241608);
					MenuScript.companionUnlock[_0024h_00241608] = 2;
					PlayerPrefs.SetInt("cU" + _0024h_00241608, 1);
					_0024self__00241609.txtRewardBot[0].text = string.Empty + _0024self__00241609.GetCompName(_0024h_00241608);
					_0024self__00241609.txtRewardTop[1].text = _0024self__00241609.txtRewardTop[0].text;
					_0024self__00241609.txtRewardBot[1].text = _0024self__00241609.txtRewardBot[0].text;
					_0024self__00241609.rewardShade.SetActive(value: true);
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241609.rewardTop.SetActive(value: true);
					_0024self__00241609.rewardBot.SetActive(value: true);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024h_00241610;

		internal GameScript _0024self__00241611;

		public _0024UnlockComp_00241607(int h, GameScript self_)
		{
			_0024h_00241610 = h;
			_0024self__00241611 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024h_00241610, _0024self__00241611);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockVariant_00241612 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024r_00241613;

			internal GameScript _0024self__00241614;

			public _0024(int r, GameScript self_)
			{
				_0024r_00241613 = r;
				_0024self__00241614 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					MenuScript.raceUnlock[_0024r_00241613 - 1] = MenuScript.raceUnlock[_0024r_00241613 - 1] + 1;
					PlayerPrefs.SetInt("rU" + (_0024r_00241613 - 1), MenuScript.raceUnlock[_0024r_00241613 - 1]);
					_0024self__00241614.txtRewardTop[0].text = "NEW VARIANT UNLOCKED!";
					_0024self__00241614.rewardIcon.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + (_0024r_00241613 - 1) + "h" + (MenuScript.raceUnlock[_0024r_00241613 - 1] - 1));
					_0024self__00241614.txtRewardBot[0].text = string.Empty + _0024self__00241614.GetRaceName(_0024r_00241613 - 1) + " Variant " + MenuScript.raceUnlock[_0024r_00241613 - 1];
					_0024self__00241614.txtRewardTop[1].text = _0024self__00241614.txtRewardTop[0].text;
					_0024self__00241614.txtRewardBot[1].text = _0024self__00241614.txtRewardBot[0].text;
					_0024self__00241614.rewardShade.SetActive(value: true);
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241614.rewardTop.SetActive(value: true);
					_0024self__00241614.rewardBot.SetActive(value: true);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024r_00241615;

		internal GameScript _0024self__00241616;

		public _0024UnlockVariant_00241612(int r, GameScript self_)
		{
			_0024r_00241615 = r;
			_0024self__00241616 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024r_00241615, _0024self__00241616);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockRace_00241617 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024h_00241618;

			internal GameScript _0024self__00241619;

			public _0024(int h, GameScript self_)
			{
				_0024h_00241618 = h;
				_0024self__00241619 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241619.txtRewardTop[0].text = "NEW RACE UNLOCKED!";
					_0024self__00241619.rewardIcon.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + (_0024h_00241618 - 1) + "h0");
					MenuScript.raceUnlock[_0024h_00241618 - 1] = 1;
					PlayerPrefs.SetInt("rU" + (_0024h_00241618 - 1), 1);
					_0024self__00241619.txtRewardBot[0].text = string.Empty + _0024self__00241619.GetRaceName(_0024h_00241618 - 1);
					_0024self__00241619.txtRewardTop[1].text = _0024self__00241619.txtRewardTop[0].text;
					_0024self__00241619.txtRewardBot[1].text = _0024self__00241619.txtRewardBot[0].text;
					_0024self__00241619.rewardShade.SetActive(value: true);
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241619.rewardTop.SetActive(value: true);
					_0024self__00241619.rewardBot.SetActive(value: true);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024h_00241620;

		internal GameScript _0024self__00241621;

		public _0024UnlockRace_00241617(int h, GameScript self_)
		{
			_0024h_00241620 = h;
			_0024self__00241621 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024h_00241620, _0024self__00241621);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Menuu_00241622 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241623;

			public _0024(GameScript self_)
			{
				_0024self__00241623 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (Network.connections.Length == 0)
					{
						Time.timeScale = 1f;
					}
					_0024self__00241623.fade.fadeOut();
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241623.DeleteCharacter();
					_0024self__00241623.DeleteInventory();
					isInitialized = false;
					if (_0024self__00241623.dead)
					{
						_0024self__00241623.DeleteCharacter();
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
					_0024self__00241623.SaveInventory();
					Application.LoadLevel(1);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241624;

		public _0024Menuu_00241622(GameScript self_)
		{
			_0024self__00241624 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241624);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AgainN_00241625 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241626;

			public _0024(GameScript self_)
			{
				_0024self__00241626 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241626.fade.fadeOut();
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					PlayerTriggerScript.canTakeDamage = true;
					playersDead = 0;
					_0024self__00241626.DeleteCharacter();
					_0024self__00241626.DeleteInventory();
					isInitialized = false;
					isReturning = false;
					isInstance = false;
					changingScene = false;
					_0024self__00241626.SaveInventory();
					if (_0024self__00241626.dead)
					{
						_0024self__00241626.DeleteCharacter();
					}
					_0024self__00241626.dead = false;
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

		internal GameScript _0024self__00241627;

		public _0024AgainN_00241625(GameScript self_)
		{
			_0024self__00241627 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241627);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SpawnTownNetwork_00241628 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024type_00241629;

			internal int _0024enterHeight_00241630;

			internal int _0024exitHeight_00241631;

			internal int _0024height_00241632;

			internal int _0024_0024switch_0024226_00241633;

			internal int _0024_0024switch_0024228_00241634;

			internal int _0024altar_00241635;

			internal GameScript _0024self__00241636;

			public _0024(GameScript self_)
			{
				_0024self__00241636 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					MonoBehaviour.print("GAMESCRIPT SPAWN TOWN");
					if (!_0024self__00241636.spawningTown && Network.isServer)
					{
						_0024self__00241636.spawningTown = true;
						_0024type_00241629 = default(int);
						_0024enterHeight_00241630 = default(int);
						_0024exitHeight_00241631 = default(int);
						_0024height_00241632 = default(int);
						curStyle = UnityEngine.Random.Range(1, 2);
						Network.Instantiate(Resources.Load("z/zEntrance"), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
						if (curBiome != 8 && curBiome != 9)
						{
							_0024type_00241629 = UnityEngine.Random.Range(1, 9);
						}
						else if (curBiome == 8)
						{
							_0024type_00241629 = UnityEngine.Random.Range(1, 3);
						}
						else if (curBiome == 9)
						{
							_0024type_00241629 = UnityEngine.Random.Range(1, 4);
							if (_0024type_00241629 == 3)
							{
								_0024type_00241629 = 7;
							}
						}
						_0024_0024switch_0024226_00241633 = _0024type_00241629;
						if (_0024_0024switch_0024226_00241633 == 1)
						{
							_0024enterHeight_00241630 -= 8;
						}
						else if (_0024_0024switch_0024226_00241633 == 2)
						{
							_0024enterHeight_00241630 += 8;
						}
						else if (_0024_0024switch_0024226_00241633 == 3)
						{
							_0024enterHeight_00241630 -= 8;
						}
						else if (_0024_0024switch_0024226_00241633 == 4)
						{
							_0024enterHeight_00241630 += 8;
						}
						else if (_0024_0024switch_0024226_00241633 == 5)
						{
							_0024enterHeight_00241630 -= 8;
						}
						else if (_0024_0024switch_0024226_00241633 == 6)
						{
							_0024enterHeight_00241630 += 8;
						}
						else if (_0024_0024switch_0024226_00241633 == 7)
						{
							_0024enterHeight_00241630 += 0;
						}
						else if (_0024_0024switch_0024226_00241633 == 8)
						{
							_0024enterHeight_00241630 += 0;
						}
						else if (_0024_0024switch_0024226_00241633 == 9)
						{
							_0024enterHeight_00241630 += 8;
						}
						else if (_0024_0024switch_0024226_00241633 == 10)
						{
							_0024enterHeight_00241630 += 0;
						}
						_0024height_00241632 = _0024exitHeight_00241631 + _0024enterHeight_00241630;
						Network.Instantiate(Resources.Load("z/zone" + _0024type_00241629), new Vector3(40f, _0024height_00241632, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
						_0024_0024switch_0024228_00241634 = _0024type_00241629;
						if (_0024_0024switch_0024228_00241634 == 1)
						{
							_0024exitHeight_00241631 -= 8;
						}
						else if (_0024_0024switch_0024228_00241634 == 2)
						{
							_0024exitHeight_00241631 += 8;
						}
						else if (_0024_0024switch_0024228_00241634 == 3)
						{
							_0024exitHeight_00241631 -= 8;
						}
						else if (_0024_0024switch_0024228_00241634 == 4)
						{
							_0024exitHeight_00241631 += 8;
						}
						else if (_0024_0024switch_0024228_00241634 == 5)
						{
							_0024exitHeight_00241631 -= 8;
						}
						else if (_0024_0024switch_0024228_00241634 == 6)
						{
							_0024exitHeight_00241631 += 8;
						}
						else if (_0024_0024switch_0024228_00241634 == 7)
						{
							_0024exitHeight_00241631 += 0;
						}
						else if (_0024_0024switch_0024228_00241634 == 8)
						{
							_0024exitHeight_00241631 += 0;
						}
						else if (_0024_0024switch_0024228_00241634 == 9)
						{
							_0024exitHeight_00241631 += 0;
						}
						else if (_0024_0024switch_0024228_00241634 == 10)
						{
							_0024exitHeight_00241631 -= 8;
						}
						curZone++;
						_0024height_00241632 = _0024exitHeight_00241631 + _0024enterHeight_00241630;
						Network.Instantiate(Resources.Load("z/zExit"), new Vector3(80f, _0024height_00241632, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
						_0024altar_00241635 = UnityEngine.Random.Range(0, 3);
						if (_0024altar_00241635 == 0)
						{
							Network.Instantiate(Resources.Load("npc/npc6"), new Vector3(6.5f, -3f, 0f), Quaternion.identity, 0);
						}
						result = (Yield(2, new WaitForSeconds(5f)) ? 1 : 0);
						break;
					}
					goto IL_04b5;
				case 2:
					_0024self__00241636.spawningTown = false;
					goto IL_04b5;
				case 1:
					{
						result = 0;
						break;
					}
					IL_04b5:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241637;

		public _0024SpawnTownNetwork_00241628(GameScript self_)
		{
			_0024self__00241637 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241637);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ThrowPoison_00241638 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024r_00241639;

			internal GameScript _0024self__00241640;

			public _0024(GameScript self_)
			{
				_0024self__00241640 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024r_00241639 = null;
					_0024self__00241640.usingPot = true;
					player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					if (facingLeft)
					{
						_0024r_00241639 = (GameObject)Network.Instantiate(Resources.Load("poisonL"), player.transform.position, Quaternion.identity, 1);
					}
					else
					{
						_0024r_00241639 = (GameObject)Network.Instantiate(Resources.Load("poisonR"), player.transform.position, Quaternion.identity, 1);
					}
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024r_00241639.SendMessage("Set", player.transform.position);
					result = (Yield(3, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241640.usingPot = false;
					_0024self__00241640.RefreshInventory();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241641;

		public _0024ThrowPoison_00241638(GameScript self_)
		{
			_0024self__00241641 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241641);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ThrowDagger_00241642 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector2 _0024v_00241643;

			internal GameObject _0024ar_00241644;

			internal Vector2 _0024v2_00241645;

			internal Vector3 _0024object_pos_00241646;

			internal Vector3 _0024mouse_pos_00241647;

			internal float _0024angle_00241648;

			internal int _0024a_00241649;

			internal GameScript _0024self__00241650;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241649 = a;
				_0024self__00241650 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241650.usingPot = true;
					_0024v_00241643 = default(Vector2);
					_0024ar_00241644 = null;
					_0024v2_00241645 = player.transform.position;
					_0024object_pos_00241646 = default(Vector3);
					_0024mouse_pos_00241647 = default(Vector3);
					_0024angle_00241648 = default(float);
					player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024mouse_pos_00241647 = UnityEngine.Input.mousePosition;
					_0024object_pos_00241646 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos_00241647.z = -20f;
					_0024mouse_pos_00241647.x -= _0024object_pos_00241646.x;
					_0024mouse_pos_00241647.y -= _0024object_pos_00241646.y;
					_0024angle_00241648 = Mathf.Atan2(_0024mouse_pos_00241647.y, _0024mouse_pos_00241647.x) * 57.29578f;
					_0024ar_00241644 = (GameObject)Network.Instantiate(Resources.Load("skill/dagger" + _0024a_00241649), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241648)), 0);
					_0024ar_00241644.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, DEX + DEXBonus);
					result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241650.usingPot = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241651;

		internal GameScript _0024self__00241652;

		public _0024ThrowDagger_00241642(int a, GameScript self_)
		{
			_0024a_00241651 = a;
			_0024self__00241652 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00241651, _0024self__00241652);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ThrowRock_00241653 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024r_00241654;

			internal GameScript _0024self__00241655;

			public _0024(GameScript self_)
			{
				_0024self__00241655 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024r_00241654 = null;
					_0024self__00241655.usingPot = true;
					player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					if (facingLeft)
					{
						_0024r_00241654 = (GameObject)Network.Instantiate(Resources.Load("stoneL"), player.transform.position, Quaternion.identity, 1);
					}
					else
					{
						_0024r_00241654 = (GameObject)Network.Instantiate(Resources.Load("stoneR"), player.transform.position, Quaternion.identity, 1);
					}
					_0024r_00241654.SendMessage("Set", player.transform.position);
					result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241655.usingPot = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241656;

		public _0024ThrowRock_00241653(GameScript self_)
		{
			_0024self__00241656 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241656);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseTotalBiscuit_00241657 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241658;

			public _0024(GameScript self_)
			{
				_0024self__00241658 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241658.usingPot)
					{
						_0024self__00241658.usingPot = true;
						player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
						result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0167;
				case 2:
					_0024self__00241658.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/drink", typeof(AudioClip)));
					tempGearStat[0] = tempGearStat[0] + 3;
					tempGearStat[3] = tempGearStat[3] + 3;
					HP += 3;
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024self__00241658.RefreshActionBar();
					_0024self__00241658.UpdateCharacterWeapon();
					_0024self__00241658.RefreshPlayerStats();
					_0024self__00241658.LoadHearts();
					_0024self__00241658.LoadMana();
					result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241658.usingPot = false;
					goto IL_0167;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0167:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241659;

		public _0024UseTotalBiscuit_00241657(GameScript self_)
		{
			_0024self__00241659 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241659);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseHPPotion_00241660 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024pot_00241661;

			internal int _0024heal_00241662;

			internal GameScript _0024self__00241663;

			public _0024(int heal, GameScript self_)
			{
				_0024heal_00241662 = heal;
				_0024self__00241663 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (HP != MAXHP && !_0024self__00241663.usingPot)
					{
						_0024self__00241663.usingPot = true;
						potsUsed++;
						player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
						result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_01bf;
				case 2:
					_0024self__00241663.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/drink", typeof(AudioClip)));
					if (HP + _0024heal_00241662 > MAXHP)
					{
						HP = MAXHP;
					}
					else
					{
						HP += _0024heal_00241662;
					}
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024self__00241663.RefreshActionBar();
					_0024self__00241663.UpdateCharacterWeapon();
					_0024self__00241663.LoadHearts();
					result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241663.usingPot = false;
					_0024pot_00241661 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
					_0024pot_00241661.SendMessage("SD", _0024heal_00241662);
					goto IL_01bf;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01bf:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024heal_00241664;

		internal GameScript _0024self__00241665;

		public _0024UseHPPotion_00241660(int heal, GameScript self_)
		{
			_0024heal_00241664 = heal;
			_0024self__00241665 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024heal_00241664, _0024self__00241665);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseManaPotion_00241666 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024pot_00241667;

			internal int _0024heal_00241668;

			internal GameScript _0024self__00241669;

			public _0024(int heal, GameScript self_)
			{
				_0024heal_00241668 = heal;
				_0024self__00241669 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (MAG != MAXMAG && !_0024self__00241669.usingPot)
					{
						_0024self__00241669.usingPot = true;
						player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
						result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0180;
				case 2:
					_0024self__00241669.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/drink", typeof(AudioClip)));
					if (MAG + _0024heal_00241668 > MAXMAG)
					{
						MAG = MAXMAG;
					}
					else
					{
						MAG += _0024heal_00241668;
					}
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024self__00241669.UpdateCharacterWeapon();
					_0024self__00241669.RefreshActionBar();
					_0024self__00241669.GUImana.GetComponent<Animation>().Play();
					_0024self__00241669.LoadMana();
					result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241669.usingPot = false;
					goto IL_0180;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0180:
					_0024pot_00241667 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("healMana"), player.transform.position, Quaternion.identity);
					_0024pot_00241667.SendMessage("SD", _0024heal_00241668);
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024heal_00241670;

		internal GameScript _0024self__00241671;

		public _0024UseManaPotion_00241666(int heal, GameScript self_)
		{
			_0024heal_00241670 = heal;
			_0024self__00241671 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024heal_00241670, _0024self__00241671);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseDrum_00241672 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024drum_00241673;

			internal GameScript _0024self__00241674;

			public _0024(int drum, GameScript self_)
			{
				_0024drum_00241673 = drum;
				_0024self__00241674 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241674.usingDrum && !_0024self__00241674.usingPot)
					{
						_0024self__00241674.usingPot = true;
						_0024self__00241674.usingDrum = true;
						player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
						result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_01d2;
				case 2:
					_0024self__00241674.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/drum", typeof(AudioClip)));
					if (_0024drum_00241673 == 0)
					{
						Network.Instantiate(Resources.Load("skill/drumATK"), player.transform.position, Quaternion.identity, 0);
					}
					else if (_0024drum_00241673 == 1)
					{
						Network.Instantiate(Resources.Load("skill/drumDEX"), player.transform.position, Quaternion.identity, 0);
					}
					else
					{
						Network.Instantiate(Resources.Load("skill/drumMAG"), player.transform.position, Quaternion.identity, 0);
					}
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024self__00241674.UpdateCharacterWeapon();
					_0024self__00241674.RefreshActionBar();
					result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241674.usingDrum = false;
					_0024self__00241674.usingPot = false;
					goto IL_01d2;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01d2:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024drum_00241675;

		internal GameScript _0024self__00241676;

		public _0024UseDrum_00241672(int drum, GameScript self_)
		{
			_0024drum_00241675 = drum;
			_0024self__00241676 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024drum_00241675, _0024self__00241676);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseItem_00241677 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024switch_0024232_00241678;

			internal GameObject _0024it_00241679;

			internal Item _0024item_00241680;

			internal int[] _0024stats_00241681;

			internal GameObject _0024d_00241682;

			internal int _0024dood_00241683;

			internal GameObject _0024pot22_00241684;

			internal GameObject _0024it2_00241685;

			internal Item _0024item2_00241686;

			internal int _0024dood1_00241687;

			internal GameObject _0024pot223_00241688;

			internal int _0024nn_00241689;

			internal int _0024nn2_00241690;

			internal Vector2 _0024v1_00241691;

			internal GameObject _0024ar1_00241692;

			internal Vector2 _0024v21_00241693;

			internal Vector3 _0024object_pos1_00241694;

			internal Vector3 _0024mouse_pos1_00241695;

			internal float _0024angle1_00241696;

			internal Vector2 _0024v_00241697;

			internal GameObject _0024ar_00241698;

			internal Vector2 _0024v2_00241699;

			internal Vector3 _0024object_pos_00241700;

			internal Vector3 _0024mouse_pos_00241701;

			internal float _0024angle_00241702;

			internal float _0024fff_00241703;

			internal float _0024fff1_00241704;

			internal float _0024fff3_00241705;

			internal Vector2 _0024v11_00241706;

			internal GameObject _0024ar11_00241707;

			internal Vector2 _0024v211_00241708;

			internal Vector3 _0024object_pos11_00241709;

			internal Vector3 _0024mouse_pos11_00241710;

			internal float _0024angle11_00241711;

			internal float _0024fff9_00241712;

			internal float _0024fff99_00241713;

			internal float _0024fff98_00241714;

			internal Vector2 _0024vv_00241715;

			internal GameObject _0024arr_00241716;

			internal Vector2 _0024v22_00241717;

			internal Vector3 _0024object_poss_00241718;

			internal Vector3 _0024mouse_poss_00241719;

			internal float _0024anglee_00241720;

			internal float _0024fff988_00241721;

			internal Vector2 _0024v112_00241722;

			internal GameObject _0024ar112_00241723;

			internal Vector2 _0024v2112_00241724;

			internal Vector3 _0024object_pos112_00241725;

			internal Vector3 _0024mouse_pos112_00241726;

			internal float _0024angle112_00241727;

			internal GameObject _0024f_00241728;

			internal int _0024noo_00241729;

			internal int _0024noo1_00241730;

			internal GameObject _0024bo_00241731;

			internal int _0024noo2_00241732;

			internal int _0024noo22_00241733;

			internal int _0024slot_00241734;

			internal GameScript _0024self__00241735;

			public _0024(int slot, GameScript self_)
			{
				_0024slot_00241734 = slot;
				_0024self__00241735 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241735.@using && HP > 0 && !isCat)
					{
						_0024self__00241735.@using = true;
						_0024_0024switch_0024232_00241678 = inventory[_0024slot_00241734].id;
						if (_0024_0024switch_0024232_00241678 == 7)
						{
							if (isCooking)
							{
								_0024it_00241679 = null;
								_0024item_00241680 = new Item(8, 1, new int[4], 0f, null);
								_0024stats_00241681 = null;
								_0024d_00241682 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), player.transform.position, Quaternion.identity);
								_0024stats_00241681 = new int[7]
								{
									_0024item_00241680.id,
									_0024item_00241680.q,
									_0024item_00241680.e[0],
									_0024item_00241680.e[1],
									_0024item_00241680.e[2],
									_0024item_00241680.e[3],
									_0024item_00241680.d
								};
								_0024d_00241682.SendMessage("InitL", _0024stats_00241681);
								tempStats[8] = tempStats[8] + 1;
								inventory[_0024slot_00241734].q = inventory[_0024slot_00241734].q - 1;
								if (inventory[_0024slot_00241734].q < 1)
								{
									inventory[_0024slot_00241734].id = 0;
								}
							}
							else if (hunger < _0024self__00241735.maxHunger)
							{
								player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
								result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024232_00241678 == 8)
						{
							if (hunger < _0024self__00241735.maxHunger)
							{
								player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
								result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024232_00241678 == 21)
						{
							if (isCooking)
							{
								_0024it2_00241685 = null;
								_0024item2_00241686 = new Item(22, 1, new int[4], 0f, null);
								_0024it2_00241685 = (GameObject)Network.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity, 1);
								_0024it2_00241685.SendMessage("Set", _0024item2_00241686);
								inventory[_0024slot_00241734].q = inventory[_0024slot_00241734].q - 1;
								if (inventory[_0024slot_00241734].q < 1)
								{
									inventory[_0024slot_00241734].id = 0;
								}
							}
							else if (hunger < _0024self__00241735.maxHunger)
							{
								player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
								result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024232_00241678 == 22)
						{
							if (hunger < _0024self__00241735.maxHunger)
							{
								player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
								result = (Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024232_00241678 != 49)
						{
							if (_0024_0024switch_0024232_00241678 == 15)
							{
								_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseHPPotion(2));
							}
							else if (_0024_0024switch_0024232_00241678 == 16)
							{
								_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseManaPotion(3));
							}
							else if (_0024_0024switch_0024232_00241678 == 17)
							{
								_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.ThrowPoison());
							}
							else if (_0024_0024switch_0024232_00241678 == 38)
							{
								_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.ThrowRock());
								inventory[_0024slot_00241734].q = inventory[_0024slot_00241734].q - 1;
								if (inventory[_0024slot_00241734].q < 1)
								{
									inventory[_0024slot_00241734].id = 0;
								}
							}
							else if (_0024_0024switch_0024232_00241678 == 42)
							{
								_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseHPPotion(5));
							}
							else if (_0024_0024switch_0024232_00241678 == 43)
							{
								_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseManaPotion(7));
							}
							else if (_0024_0024switch_0024232_00241678 == 44)
							{
								_0024nn_00241689 = UnityEngine.Random.Range(15, 18);
								if (!_0024self__00241735.usingPot)
								{
									if (_0024nn_00241689 == 15)
									{
										_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseHPPotion(10));
									}
									else if (_0024nn_00241689 == 16)
									{
										_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseManaPotion(10));
									}
									else
									{
										_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.ThrowPoison());
									}
								}
							}
							else if (_0024_0024switch_0024232_00241678 == 45)
							{
								_0024nn2_00241690 = UnityEngine.Random.Range(15, 18);
								if (!_0024self__00241735.usingPot)
								{
									if (_0024nn2_00241690 == 15)
									{
										_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseHPPotion(15));
									}
									else if (_0024nn2_00241690 == 16)
									{
										_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseManaPotion(15));
									}
									else
									{
										_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.ThrowPoison());
									}
								}
							}
							else if (_0024_0024switch_0024232_00241678 == 46)
							{
								_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseTotalBiscuit());
							}
							else
							{
								if (_0024_0024switch_0024232_00241678 == 48)
								{
									result = (Yield(6, new WaitForSeconds(0.5f)) ? 1 : 0);
									break;
								}
								if (_0024_0024switch_0024232_00241678 == 61)
								{
									_0024v1_00241691 = default(Vector2);
									_0024ar1_00241692 = null;
									_0024v21_00241693 = player.transform.position;
									_0024object_pos1_00241694 = default(Vector3);
									_0024mouse_pos1_00241695 = default(Vector3);
									_0024angle1_00241696 = default(float);
									player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a4");
									result = (Yield(7, new WaitForSeconds(0.3f)) ? 1 : 0);
									break;
								}
								if (_0024_0024switch_0024232_00241678 == 78)
								{
									_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseDrum(0));
								}
								else if (_0024_0024switch_0024232_00241678 == 79)
								{
									_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseDrum(1));
								}
								else if (_0024_0024switch_0024232_00241678 == 80)
								{
									_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.UseDrum(2));
								}
								else if (_0024_0024switch_0024232_00241678 == 95)
								{
									if (!isTown)
									{
										player.GetComponent<NetworkView>().RPC("SummonSpirit", RPCMode.All);
										inventory[_0024slot_00241734].q = inventory[_0024slot_00241734].q - 1;
										if (inventory[_0024slot_00241734].q < 1)
										{
											inventory[_0024slot_00241734].id = 0;
										}
									}
								}
								else if (_0024_0024switch_0024232_00241678 == 515)
								{
									if (inventory[23].id >= 52 && inventory[23].id <= 56)
									{
										_0024v_00241697 = default(Vector2);
										_0024ar_00241698 = null;
										_0024v2_00241699 = player.transform.position;
										_0024object_pos_00241700 = default(Vector3);
										_0024mouse_pos_00241701 = default(Vector3);
										_0024angle_00241702 = default(float);
										arrowsShot++;
										if (arrowsShot >= 100)
										{
											MenuScript.canUnlockHat[4] = 1;
										}
										player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a4");
										result = (Yield(8, new WaitForSeconds(0.3f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024_0024switch_0024232_00241678 == 530)
								{
									if (inventory[23].id >= 52 && inventory[23].id <= 56)
									{
										_0024v11_00241706 = default(Vector2);
										_0024ar11_00241707 = null;
										_0024v211_00241708 = player.transform.position;
										_0024object_pos11_00241709 = default(Vector3);
										_0024mouse_pos11_00241710 = default(Vector3);
										_0024angle11_00241711 = default(float);
										arrowsShot++;
										if (arrowsShot >= 100)
										{
											MenuScript.canUnlockHat[4] = 1;
										}
										player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a4");
										result = (Yield(9, new WaitForSeconds(0.3f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024_0024switch_0024232_00241678 == 535)
								{
									if (MAG >= 5)
									{
										MAG -= 5;
										_0024self__00241735.LoadMana();
										_0024vv_00241715 = default(Vector2);
										_0024arr_00241716 = null;
										_0024v22_00241717 = player.transform.position;
										_0024object_poss_00241718 = default(Vector3);
										_0024mouse_poss_00241719 = default(Vector3);
										_0024anglee_00241720 = default(float);
										player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a4");
										result = (Yield(10, new WaitForSeconds(0.3f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024_0024switch_0024232_00241678 == 536)
								{
									if (inventory[23].id >= 52 && inventory[23].id <= 56)
									{
										_0024v112_00241722 = default(Vector2);
										_0024ar112_00241723 = null;
										_0024v2112_00241724 = player.transform.position;
										_0024object_pos112_00241725 = default(Vector3);
										_0024mouse_pos112_00241726 = default(Vector3);
										_0024angle112_00241727 = default(float);
										arrowsShot++;
										if (arrowsShot >= 100)
										{
											MenuScript.canUnlockHat[4] = 1;
										}
										player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a4");
										result = (Yield(11, new WaitForSeconds(0.3f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024_0024switch_0024232_00241678 == 600)
								{
									if (MAG >= 1)
									{
										_0024f_00241728 = null;
										if (MenuScript.pHat == 11)
										{
											_0024noo_00241729 = UnityEngine.Random.Range(0, 3);
											if (_0024noo_00241729 == 0)
											{
												_0024self__00241735.UseMana(1);
											}
										}
										else
										{
											_0024self__00241735.UseMana(1);
										}
										player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a3");
										result = (Yield(12, new WaitForSeconds(0.3f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024_0024switch_0024232_00241678 == 601)
								{
									if (MAG >= 1)
									{
										if (MenuScript.pHat == 11)
										{
											_0024noo1_00241730 = UnityEngine.Random.Range(0, 3);
											if (_0024noo1_00241730 == 0)
											{
												_0024self__00241735.UseMana(1);
											}
										}
										else
										{
											_0024self__00241735.UseMana(1);
										}
										player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
										result = (Yield(13, new WaitForSeconds(0.5f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024_0024switch_0024232_00241678 == 602)
								{
									if (MAG >= 3)
									{
										if (MenuScript.pHat == 11)
										{
											_0024noo2_00241732 = UnityEngine.Random.Range(0, 3);
											if (_0024noo2_00241732 == 0)
											{
												_0024self__00241735.UseMana(3);
											}
										}
										else
										{
											_0024self__00241735.UseMana(3);
										}
										player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
										result = (Yield(14, new WaitForSeconds(0.5f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024_0024switch_0024232_00241678 == 603)
								{
									if (MAG >= 1)
									{
										if (MenuScript.pHat == 11)
										{
											_0024noo22_00241733 = UnityEngine.Random.Range(0, 3);
											if (_0024noo22_00241733 == 0)
											{
												_0024self__00241735.UseMana(1);
											}
										}
										else
										{
											_0024self__00241735.UseMana(1);
										}
										player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "a1");
										result = (Yield(15, new WaitForSeconds(0.5f)) ? 1 : 0);
										break;
									}
								}
								else
								{
									_0024self__00241735.StartCoroutine_Auto(_0024self__00241735.MeleeAttack());
								}
							}
						}
						goto IL_2369;
					}
					goto IL_23a2;
				case 2:
					_0024self__00241735.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/eat", typeof(AudioClip)));
					hunger++;
					_0024self__00241735.UpdateHunger();
					_0024self__00241735.GetComponent<NetworkView>().RPC("Poop", RPCMode.All, player.transform.position);
					tempStats[8] = tempStats[8] + 1;
					inventory[_0024slot_00241734].q = inventory[_0024slot_00241734].q - 1;
					if (inventory[_0024slot_00241734].q < 1)
					{
						inventory[_0024slot_00241734].id = 0;
					}
					goto IL_2369;
				case 3:
					_0024self__00241735.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/eat", typeof(AudioClip)));
					hunger += 3;
					_0024dood_00241683 = UnityEngine.Random.Range(0, 2);
					if (_0024dood_00241683 == 0 && HP < MAXHP)
					{
						HP++;
						_0024pot22_00241684 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
						_0024pot22_00241684.SendMessage("SD", 1);
						_0024self__00241735.LoadHearts();
					}
					tempStats[8] = tempStats[8] + 1;
					_0024self__00241735.UpdateHunger();
					_0024self__00241735.GetComponent<NetworkView>().RPC("Poop", RPCMode.All, player.transform.position);
					inventory[_0024slot_00241734].q = inventory[_0024slot_00241734].q - 1;
					if (inventory[_0024slot_00241734].q < 1)
					{
						inventory[_0024slot_00241734].id = 0;
					}
					goto IL_2369;
				case 4:
					tempStats[8] = tempStats[8] + 1;
					hunger++;
					_0024self__00241735.UpdateHunger();
					_0024self__00241735.GetComponent<NetworkView>().RPC("Poop", RPCMode.All, player.transform.position);
					inventory[_0024slot_00241734].q = inventory[_0024slot_00241734].q - 1;
					if (inventory[_0024slot_00241734].q < 1)
					{
						inventory[_0024slot_00241734].id = 0;
					}
					goto IL_2369;
				case 5:
					hunger += 4;
					_0024dood1_00241687 = UnityEngine.Random.Range(0, 2);
					if (_0024dood1_00241687 == 0 && HP < MAXHP)
					{
						HP++;
						_0024pot223_00241688 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
						_0024pot223_00241688.SendMessage("SD", 1);
						_0024self__00241735.LoadHearts();
					}
					tempStats[8] = tempStats[8] + 1;
					_0024self__00241735.UpdateHunger();
					_0024self__00241735.GetComponent<NetworkView>().RPC("Poop", RPCMode.All, player.transform.position);
					inventory[_0024slot_00241734].q = inventory[_0024slot_00241734].q - 1;
					if (inventory[_0024slot_00241734].q < 1)
					{
						inventory[_0024slot_00241734].id = 0;
					}
					goto IL_2369;
				case 6:
					Network.Instantiate(Resources.Load("interact/fire"), player.transform.position, Quaternion.identity, 1);
					inventory[_0024slot_00241734].q = inventory[_0024slot_00241734].q - 1;
					if (inventory[_0024slot_00241734].q < 1)
					{
						inventory[_0024slot_00241734].id = 0;
					}
					goto IL_2369;
				case 7:
					_0024mouse_pos1_00241695 = UnityEngine.Input.mousePosition;
					_0024object_pos1_00241694 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos1_00241695.z = -20f;
					_0024mouse_pos1_00241695.x -= _0024object_pos1_00241694.x;
					_0024mouse_pos1_00241695.y -= _0024object_pos1_00241694.y;
					_0024angle1_00241696 = Mathf.Atan2(_0024mouse_pos1_00241695.y, _0024mouse_pos1_00241695.x) * 57.29578f;
					_0024ar1_00241692 = (GameObject)Network.Instantiate(Resources.Load("skill/lightBlast"), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle1_00241696)), 0);
					inventory[_0024slot_00241734].q = inventory[_0024slot_00241734].q - 1;
					if (inventory[_0024slot_00241734].q < 1)
					{
						inventory[_0024slot_00241734].id = 0;
					}
					goto IL_2369;
				case 8:
					_0024mouse_pos_00241701 = UnityEngine.Input.mousePosition;
					_0024object_pos_00241700 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos_00241701.z = -20f;
					_0024mouse_pos_00241701.x -= _0024object_pos_00241700.x;
					_0024mouse_pos_00241701.y -= _0024object_pos_00241700.y;
					_0024angle_00241702 = Mathf.Atan2(_0024mouse_pos_00241701.y, _0024mouse_pos_00241701.x) * 57.29578f;
					_0024ar_00241698 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241702)), 0);
					_0024fff_00241703 = DEX + DEXBonus + drumDEX;
					_0024ar_00241698.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, _0024fff_00241703);
					inventory[23].q = inventory[23].q - 1;
					if (inventory[23].q <= 0)
					{
						inventory[23] = _0024self__00241735.EmptyItem();
					}
					if (multishot)
					{
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle_00241702 -= 10f;
							_0024ar_00241698 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241702)), 0);
							_0024fff1_00241704 = 2 * (DEX + DEXBonus + drumDEX);
							_0024ar_00241698.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, _0024fff1_00241704);
							_0024ar_00241698.GetComponent<NetworkView>().RPC("SetMulti", RPCMode.All);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241735.EmptyItem();
							}
						}
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle_00241702 += 20f;
							_0024ar_00241698 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241702)), 0);
							_0024fff3_00241705 = 2 * (DEX + DEXBonus + drumDEX);
							_0024ar_00241698.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, _0024fff3_00241705);
							_0024ar_00241698.GetComponent<NetworkView>().RPC("SetMulti", RPCMode.All);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241735.EmptyItem();
							}
						}
						multishot = false;
					}
					goto IL_2369;
				case 9:
					_0024mouse_pos11_00241710 = UnityEngine.Input.mousePosition;
					_0024object_pos11_00241709 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos11_00241710.z = -20f;
					_0024mouse_pos11_00241710.x -= _0024object_pos11_00241709.x;
					_0024mouse_pos11_00241710.y -= _0024object_pos11_00241709.y;
					_0024angle11_00241711 = Mathf.Atan2(_0024mouse_pos11_00241710.y, _0024mouse_pos11_00241710.x) * 57.29578f;
					_0024ar11_00241707 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle11_00241711)), 0);
					_0024fff9_00241712 = DEX + DEXBonus + drumDEX + 7;
					_0024ar11_00241707.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, _0024fff9_00241712);
					_0024ar11_00241707.GetComponent<NetworkView>().RPC("SetMulti", RPCMode.All);
					inventory[23].q = inventory[23].q - 1;
					if (inventory[23].q <= 0)
					{
						inventory[23] = _0024self__00241735.EmptyItem();
					}
					if (multishot)
					{
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle11_00241711 -= 10f;
							_0024ar11_00241707 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle11_00241711)), 0);
							_0024fff99_00241713 = 2 * (DEX + DEXBonus + drumDEX + 7);
							_0024ar11_00241707.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, _0024fff99_00241713);
							_0024ar11_00241707.GetComponent<NetworkView>().RPC("SetMulti", RPCMode.All);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241735.EmptyItem();
							}
						}
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle11_00241711 += 20f;
							_0024ar11_00241707 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle11_00241711)), 0);
							_0024fff98_00241714 = 2 * (DEX + DEXBonus + drumDEX + 7);
							_0024ar11_00241707.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, _0024fff98_00241714);
							_0024ar11_00241707.GetComponent<NetworkView>().RPC("SetMulti", RPCMode.All);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241735.EmptyItem();
							}
						}
						multishot = false;
					}
					goto IL_2369;
				case 10:
					_0024mouse_poss_00241719 = UnityEngine.Input.mousePosition;
					_0024object_poss_00241718 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_poss_00241719.z = -20f;
					_0024mouse_poss_00241719.x -= _0024object_poss_00241718.x;
					_0024mouse_poss_00241719.y -= _0024object_poss_00241718.y;
					_0024anglee_00241720 = Mathf.Atan2(_0024mouse_poss_00241719.y, _0024mouse_poss_00241719.x) * 57.29578f;
					_0024arr_00241716 = (GameObject)Network.Instantiate(Resources.Load("skill/crossBolt"), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024anglee_00241720)), 0);
					_0024fff988_00241721 = 2 * (DEX + DEXBonus + drumDEX + 20);
					_0024arr_00241716.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, _0024fff988_00241721);
					goto IL_2369;
				case 11:
					_0024mouse_pos112_00241726 = UnityEngine.Input.mousePosition;
					_0024object_pos112_00241725 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos112_00241726.z = -20f;
					_0024mouse_pos112_00241726.x -= _0024object_pos112_00241725.x;
					_0024mouse_pos112_00241726.y -= _0024object_pos112_00241725.y;
					_0024angle112_00241727 = Mathf.Atan2(_0024mouse_pos112_00241726.y, _0024mouse_pos112_00241726.x) * 57.29578f;
					_0024ar112_00241723 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle112_00241727)), 0);
					_0024ar112_00241723.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, 1.25f * (float)(DEX + DEXBonus + drumDEX + 7));
					_0024ar112_00241723.GetComponent<NetworkView>().RPC("SetMulti", RPCMode.All);
					_0024ar112_00241723.GetComponent<NetworkView>().RPC("FireN", RPCMode.All);
					inventory[23].q = inventory[23].q - 1;
					if (inventory[23].q <= 0)
					{
						inventory[23] = _0024self__00241735.EmptyItem();
					}
					if (multishot)
					{
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle112_00241727 -= 10f;
							_0024ar112_00241723 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle112_00241727)), 0);
							_0024ar112_00241723.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, 2.5f * (float)(DEX + DEXBonus + drumDEX + 7));
							_0024ar112_00241723.GetComponent<NetworkView>().RPC("SetMulti", RPCMode.All);
							_0024ar112_00241723.GetComponent<NetworkView>().RPC("FireN", RPCMode.All);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241735.EmptyItem();
							}
						}
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle112_00241727 += 20f;
							_0024ar112_00241723 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle112_00241727)), 0);
							_0024ar112_00241723.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, 2.5f * (float)(DEX + DEXBonus + drumDEX + 7));
							_0024ar112_00241723.GetComponent<NetworkView>().RPC("SetMulti", RPCMode.All);
							_0024ar112_00241723.GetComponent<NetworkView>().RPC("FireN", RPCMode.All);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241735.EmptyItem();
							}
						}
						multishot = false;
					}
					goto IL_2369;
				case 12:
					if (facingLeft)
					{
						_0024f_00241728 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballL"), player.transform.position, Quaternion.identity, 0);
					}
					else
					{
						_0024f_00241728 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballR"), player.transform.position, Quaternion.identity, 0);
					}
					_0024f_00241728.SendMessage("Set", MAXMAG + drumMAG);
					_0024self__00241735.GUImana.GetComponent<Animation>().Play();
					goto IL_2369;
				case 13:
					_0024bo_00241731 = (GameObject)Network.Instantiate(Resources.Load("proj/bolt"), player.transform.position, Quaternion.identity, 0);
					_0024bo_00241731.SendMessage("Set", MAXMAG + drumMAG);
					_0024self__00241735.GUImana.GetComponent<Animation>().Play();
					goto IL_2369;
				case 14:
					player.SendMessage("iceShard", MAXMAG + drumMAG);
					_0024self__00241735.GUImana.GetComponent<Animation>().Play();
					goto IL_2369;
				case 15:
					if (facingLeft)
					{
						Network.Instantiate(Resources.Load("e/summon2"), player.transform.position, Quaternion.Euler(0f, 180f, 0f), 0);
					}
					else
					{
						Network.Instantiate(Resources.Load("e/summon2"), player.transform.position, Quaternion.Euler(0f, 0f, 0f), 0);
					}
					_0024self__00241735.GUImana.GetComponent<Animation>().Play();
					goto IL_2369;
				case 16:
					_0024self__00241735.@using = false;
					goto IL_23a2;
				case 1:
					{
						result = 0;
						break;
					}
					IL_23a2:
					YieldDefault(1);
					goto case 1;
					IL_2369:
					_0024self__00241735.RefreshActionBar();
					_0024self__00241735.UpdateCharacterWeapon();
					result = (Yield(16, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024slot_00241736;

		internal GameScript _0024self__00241737;

		public _0024UseItem_00241677(int slot, GameScript self_)
		{
			_0024slot_00241736 = slot;
			_0024self__00241737 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024slot_00241736, _0024self__00241737);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MeleeAttack_00241738 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024temp_00241739;

			internal int _0024nuu_00241740;

			internal int _0024id_00241741;

			internal GameObject _0024gg_00241742;

			internal GameObject _0024f_00241743;

			internal GameScript _0024self__00241744;

			public _0024(GameScript self_)
			{
				_0024self__00241744 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024temp_00241739 = default(float);
					if (_0024self__00241744.canAttack && HP > 0 && !isCat)
					{
						_0024self__00241744.ATKING = true;
						attacking = true;
						_0024self__00241744.canAttack = false;
						_0024self__00241744.@using = true;
						_0024temp_00241739 = SPD;
						SPD *= 0.5f;
						PlayerController.mode = 3;
						player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, _0024self__00241744.atkAnim);
						if (MenuScript.pHat == 19)
						{
							_0024nuu_00241740 = UnityEngine.Random.Range(0, 10);
							if (_0024nuu_00241740 == 0)
							{
								vBonus = _0024self__00241744.ATK;
								player.GetComponent<NetworkView>().RPC("VN", RPCMode.All, 1);
							}
						}
						result = (Yield(2, new WaitForSeconds(_0024self__00241744.atkWait)) ? 1 : 0);
						break;
					}
					goto IL_0486;
				case 2:
					PlayerControllerN.aCube.SetActive(value: true);
					_0024id_00241741 = inventory[curActiveSlot].id;
					if (_0024id_00241741 == 565 && MAG >= 1)
					{
						_0024self__00241744.UseMana(1);
						Network.Instantiate(Resources.Load("haz/fE"), PlayerControllerN.aCube.transform.position, Quaternion.identity, 0);
					}
					else if (_0024id_00241741 == 568)
					{
						_0024self__00241744.Ice();
					}
					else if (_0024id_00241741 == 569)
					{
						_0024self__00241744.Fireball();
					}
					else if (_0024id_00241741 == 570)
					{
						_0024self__00241744.Bolt();
					}
					if (MenuScript.pHat == 8 && _0024id_00241741 == 0 && MAG >= 1)
					{
						_0024self__00241744.UseMana(1);
						_0024gg_00241742 = (GameObject)Network.Instantiate(Resources.Load("rckP"), new Vector3(PlayerControllerN.aCube.transform.position.x, player.transform.position.y + 35f, 0f), Quaternion.identity, 0);
						_0024gg_00241742.GetComponent<NetworkView>().RPC("SetH", RPCMode.All, MAXMAG);
					}
					else if (MenuScript.pHat == 16 && _0024id_00241741 == 0 && MAG >= 1)
					{
						_0024self__00241744.UseMana(1);
						_0024f_00241743 = null;
						if (facingLeft)
						{
							_0024f_00241743 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballL"), player.transform.position, Quaternion.identity, 0);
						}
						else
						{
							_0024f_00241743 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballR"), player.transform.position, Quaternion.identity, 0);
						}
						_0024f_00241743.SendMessage("Set", MAXMAG);
					}
					else if (MenuScript.pHat == 21 && _0024id_00241741 == 0 && MAG > 0)
					{
						if (facingLeft)
						{
							Network.Instantiate(Resources.Load("e/summon"), player.transform.position, Quaternion.Euler(0f, 180f, 0f), 0);
						}
						else
						{
							Network.Instantiate(Resources.Load("e/summon"), player.transform.position, Quaternion.Euler(0f, 0f, 0f), 0);
						}
						_0024self__00241744.UseMana(1);
					}
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					PlayerControllerN.aCube.SetActive(value: false);
					if (vBonus > 0)
					{
						_0024self__00241744.StartCoroutine_Auto(_0024self__00241744.v());
					}
					SPD = _0024temp_00241739;
					_0024self__00241744.canAttack = true;
					_0024self__00241744.@using = false;
					attacking = false;
					_0024self__00241744.ATKING = false;
					goto IL_0486;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0486:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241745;

		public _0024MeleeAttack_00241738(GameScript self_)
		{
			_0024self__00241745 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241745);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024v_00241746 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					vBonus = 0;
					player.GetComponent<NetworkView>().RPC("VN", RPCMode.All, 0);
					YieldDefault(1);
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
			return new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockBack_00241747 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024571_00241748;

			internal Vector3 _0024_0024572_00241749;

			internal int _0024_0024573_00241750;

			internal Vector3 _0024_0024574_00241751;

			internal int _0024_0024575_00241752;

			internal Vector3 _0024_0024576_00241753;

			internal int _0024_0024577_00241754;

			internal Vector3 _0024_0024578_00241755;

			internal int _0024_0024579_00241756;

			internal Vector3 _0024_0024580_00241757;

			internal Transform _0024h_00241758;

			public _0024(Transform h)
			{
				_0024h_00241758 = h;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					int num5 = (_0024_0024571_00241748 = 5);
					Vector3 vector7 = (_0024_0024572_00241749 = _0024h_00241758.GetComponent<Rigidbody>().velocity);
					float num6 = (_0024_0024572_00241749.y = _0024_0024571_00241748);
					Vector3 vector9 = (_0024h_00241758.GetComponent<Rigidbody>().velocity = _0024_0024572_00241749);
					if (_0024h_00241758.position.x <= player.transform.position.x)
					{
						int num7 = (_0024_0024575_00241752 = -15);
						Vector3 vector10 = (_0024_0024576_00241753 = _0024h_00241758.GetComponent<Rigidbody>().velocity);
						float num8 = (_0024_0024576_00241753.x = _0024_0024575_00241752);
						Vector3 vector12 = (_0024h_00241758.GetComponent<Rigidbody>().velocity = _0024_0024576_00241753);
					}
					else
					{
						int num9 = (_0024_0024573_00241750 = 15);
						Vector3 vector13 = (_0024_0024574_00241751 = _0024h_00241758.GetComponent<Rigidbody>().velocity);
						float num10 = (_0024_0024574_00241751.x = _0024_0024573_00241750);
						Vector3 vector15 = (_0024h_00241758.GetComponent<Rigidbody>().velocity = _0024_0024574_00241751);
					}
					result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				}
				case 2:
					if ((bool)_0024h_00241758)
					{
						int num = (_0024_0024577_00241754 = 0);
						Vector3 vector = (_0024_0024578_00241755 = _0024h_00241758.GetComponent<Rigidbody>().velocity);
						float num2 = (_0024_0024578_00241755.y = _0024_0024577_00241754);
						Vector3 vector3 = (_0024h_00241758.GetComponent<Rigidbody>().velocity = _0024_0024578_00241755);
						int num3 = (_0024_0024579_00241756 = 0);
						Vector3 vector4 = (_0024_0024580_00241757 = _0024h_00241758.GetComponent<Rigidbody>().velocity);
						float num4 = (_0024_0024580_00241757.x = _0024_0024579_00241756);
						Vector3 vector6 = (_0024h_00241758.GetComponent<Rigidbody>().velocity = _0024_0024580_00241757);
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

		internal Transform _0024h_00241759;

		public _0024KnockBack_00241747(Transform h)
		{
			_0024h_00241759 = h;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024h_00241759);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GenerateLevel_00241760 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024enterHeight_00241761;

			internal int _0024exitHeight_00241762;

			internal int _0024type_00241763;

			internal int _0024height_00241764;

			internal int _0024i_00241765;

			internal int _0024gog2_00241766;

			internal int _0024_0024switch_0024261_00241767;

			internal int _0024_0024switch_0024263_00241768;

			internal GameScript _0024self__00241769;

			public _0024(GameScript self_)
			{
				_0024self__00241769 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024enterHeight_00241761 = 0;
					_0024exitHeight_00241762 = 0;
					_0024type_00241763 = default(int);
					_0024height_00241764 = 0;
					curZone = 0;
					_0024i_00241765 = 0;
					if (Network.isServer && !_0024self__00241769.generatingLevel)
					{
						_0024self__00241769.generatingLevel = true;
						Network.Instantiate(Resources.Load("z/zEntrance"), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
						_0024gog2_00241766 = UnityEngine.Random.Range(4, 6);
						for (_0024i_00241765 = 0; _0024i_00241765 < _0024gog2_00241766; _0024i_00241765++)
						{
							if (curBiome != 8 && curBiome != 9)
							{
								_0024type_00241763 = UnityEngine.Random.Range(1, 9);
							}
							else if (curBiome == 8)
							{
								_0024type_00241763 = UnityEngine.Random.Range(1, 3);
							}
							else if (curBiome == 9)
							{
								_0024type_00241763 = UnityEngine.Random.Range(1, 4);
								if (_0024type_00241763 == 3)
								{
									_0024type_00241763 = 7;
								}
							}
							_0024_0024switch_0024261_00241767 = _0024type_00241763;
							if (_0024_0024switch_0024261_00241767 == 1)
							{
								_0024enterHeight_00241761 -= 8;
							}
							else if (_0024_0024switch_0024261_00241767 == 2)
							{
								_0024enterHeight_00241761 += 8;
							}
							else if (_0024_0024switch_0024261_00241767 == 3)
							{
								_0024enterHeight_00241761 -= 8;
							}
							else if (_0024_0024switch_0024261_00241767 == 4)
							{
								_0024enterHeight_00241761 += 8;
							}
							else if (_0024_0024switch_0024261_00241767 == 5)
							{
								_0024enterHeight_00241761 -= 8;
							}
							else if (_0024_0024switch_0024261_00241767 == 6)
							{
								_0024enterHeight_00241761 += 8;
							}
							else if (_0024_0024switch_0024261_00241767 == 7)
							{
								_0024enterHeight_00241761 += 0;
							}
							else if (_0024_0024switch_0024261_00241767 == 8)
							{
								_0024enterHeight_00241761 += 0;
							}
							else if (_0024_0024switch_0024261_00241767 == 9)
							{
								_0024enterHeight_00241761 += 8;
							}
							else if (_0024_0024switch_0024261_00241767 == 10)
							{
								_0024enterHeight_00241761 += 0;
							}
							_0024height_00241764 = _0024exitHeight_00241762 + _0024enterHeight_00241761;
							Network.Instantiate(Resources.Load("z/zone" + _0024type_00241763), new Vector3(_0024i_00241765 * 64 + 40, _0024height_00241764, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
							_0024_0024switch_0024263_00241768 = _0024type_00241763;
							if (_0024_0024switch_0024263_00241768 == 1)
							{
								_0024exitHeight_00241762 -= 8;
							}
							else if (_0024_0024switch_0024263_00241768 == 2)
							{
								_0024exitHeight_00241762 += 8;
							}
							else if (_0024_0024switch_0024263_00241768 == 3)
							{
								_0024exitHeight_00241762 -= 8;
							}
							else if (_0024_0024switch_0024263_00241768 == 4)
							{
								_0024exitHeight_00241762 += 8;
							}
							else if (_0024_0024switch_0024263_00241768 == 5)
							{
								_0024exitHeight_00241762 -= 8;
							}
							else if (_0024_0024switch_0024263_00241768 == 6)
							{
								_0024exitHeight_00241762 += 8;
							}
							else if (_0024_0024switch_0024263_00241768 == 7)
							{
								_0024exitHeight_00241762 += 0;
							}
							else if (_0024_0024switch_0024263_00241768 == 8)
							{
								_0024exitHeight_00241762 += 0;
							}
							else if (_0024_0024switch_0024263_00241768 == 9)
							{
								_0024exitHeight_00241762 += 0;
							}
							else if (_0024_0024switch_0024263_00241768 == 10)
							{
								_0024exitHeight_00241762 -= 8;
							}
							curZone++;
						}
						_0024height_00241764 = _0024exitHeight_00241762 + _0024enterHeight_00241761;
						Network.Instantiate(Resources.Load("z/zExit"), new Vector3(curZone * 64 + 16, _0024height_00241764, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
						result = (Yield(2, new WaitForSeconds(5f)) ? 1 : 0);
						break;
					}
					goto IL_04ab;
				case 2:
					_0024self__00241769.generatingLevel = false;
					goto IL_04ab;
				case 1:
					{
						result = 0;
						break;
					}
					IL_04ab:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241770;

		public _0024GenerateLevel_00241760(GameScript self_)
		{
			_0024self__00241770 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241770);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00241771 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024ploop_00241772;

			internal int _0024ttt_00241773;

			internal GameScript _0024self__00241774;

			public _0024(GameScript self_)
			{
				_0024self__00241774 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					PlayerPrefs.SetInt("gChests", MenuScript.goldChests);
					if (MenuScript.goldChests >= 20)
					{
						MenuScript.canUnlockRace[13] = 1;
					}
					_0024ploop_00241772 = default(int);
					_0024ttt_00241773 = 0;
					for (_0024ploop_00241772 = 0; _0024ploop_00241772 < 3; _0024ploop_00241772++)
					{
						if (legendary[_0024ploop_00241772] == 1)
						{
							_0024ttt_00241773++;
						}
					}
					if (_0024ttt_00241773 == 3)
					{
						MenuScript.canUnlockCompanion[7] = 1;
					}
					player.SendMessage("TimerSet", timer);
					if (isCat)
					{
						isCat = false;
						player.SendMessage("Cat", (object)0);
					}
					if (inventoryOpen)
					{
						_0024self__00241774.OpenInventory();
					}
					_0024self__00241774.sSelected.SetActive(value: false);
					isTown = false;
					_0024self__00241774.dead = true;
					menuOpen = true;
					_0024self__00241774.menuExit.SetActive(value: false);
					inventoryOpen = false;
					isInitialized = false;
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (playerLevel >= 40)
					{
						MenuScript.canUnlockCompanion[3] = 1;
					}
					if (districtLevel >= 15)
					{
						MenuScript.canUnlockCompanion[1] = 1;
					}
					if (MenuScript.curName == "Roguelands")
					{
						MenuScript.canUnlockRace[12] = 1;
					}
					if (win)
					{
						if (MenuScript.GameMode == 1)
						{
							MenuScript.canUnlockCompanion[9] = 1;
						}
						else
						{
							MenuScript.canUnlockCompanion[9] = 0;
						}
						if (inventory[22].id == 905)
						{
							MenuScript.canUnlockCompanion[8] = 1;
						}
						if (tempStats[4] == 0)
						{
							MenuScript.canUnlockRace[9] = 1;
						}
						if (tempStats[1] <= 1)
						{
							MenuScript.canUnlockRace[11] = 1;
						}
						if (tempStats[5] == 0)
						{
							MenuScript.canUnlockCompanion[6] = 1;
						}
						if (!interacted)
						{
							MenuScript.canUnlockCompanion[5] = 1;
						}
						if (playerLevel < 5)
						{
							MenuScript.canUnlockCompanion[4] = 1;
						}
						MenuScript.canUnlockCompanion[2] = 1;
						if (hitsTaken < 1)
						{
							MenuScript.canUnlockHat[24] = 1;
						}
						MenuScript.canUnlockRace[5] = 1;
						MenuScript.canUnlockHat[12] = 1;
						MonoBehaviour.print("POTS USED " + potsUsed);
						if (potsUsed < 1)
						{
							MenuScript.canUnlockRace[8] = 1;
						}
						MonoBehaviour.print("PIGGY : " + MenuScript.canUnlockRace[8]);
						_0024self__00241774.txtDied.gameObject.SetActive(value: false);
						_0024self__00241774.menuVictory.SetActive(value: true);
					}
					_0024self__00241774.ShowTimer();
					result = (Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241774.SaveStats();
					if ((bool)_0024self__00241774.menuStats)
					{
						_0024self__00241774.menuStats.SetActive(value: true);
					}
					_0024self__00241774.StartCoroutine_Auto(_0024self__00241774.ShowStats());
					if (Network.isServer)
					{
						_0024self__00241774.bAgain.SetActive(value: true);
						_0024self__00241774.bMenu.SetActive(value: true);
					}
					else
					{
						_0024self__00241774.bAgain.SetActive(value: false);
						_0024self__00241774.bMenu.SetActive(value: false);
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

		internal GameScript _0024self__00241775;

		public _0024Die_00241771(GameScript self_)
		{
			_0024self__00241775 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241775);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShowStats_00241776 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241777;

			internal GameScript _0024self__00241778;

			public _0024(GameScript self_)
			{
				_0024self__00241778 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00241777 = default(int);
					_0024self__00241778.txtHighScore[0].text = string.Empty + MenuScript.curScore;
					_0024self__00241778.txtHighScore[1].text = string.Empty + MenuScript.curScore;
					_0024i_00241777 = 1;
					goto IL_00bc;
				case 2:
					_0024i_00241777++;
					goto IL_00bc;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00bc:
					if (_0024i_00241777 < 12)
					{
						_0024self__00241778.StartCoroutine_Auto(_0024self__00241778.StatShow(_0024i_00241777));
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241779;

		public _0024ShowStats_00241776(GameScript self_)
		{
			_0024self__00241779 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241779);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShowEXP_00241780 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024pLevel_00241781;

			internal float _0024curEXP_00241782;

			internal float _0024cap_00241783;

			internal int _0024i_00241784;

			internal GameScript _0024self__00241785;

			public _0024(GameScript self_)
			{
				_0024self__00241785 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024pLevel_00241781 = _0024self__00241785.GetPlayerLevel();
					_0024curEXP_00241782 = _0024self__00241785.GetCurEXP(_0024pLevel_00241781);
					_0024cap_00241783 = _0024self__00241785.GetLevelCap(_0024pLevel_00241781);
					_0024self__00241785.txtLevelEXP.text = "Level: " + _0024pLevel_00241781;
					_0024i_00241784 = default(int);
					_0024i_00241784 = 0;
					goto IL_019f;
				case 2:
					_0024i_00241784++;
					goto IL_019f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_019f:
					if ((float)_0024i_00241784 < _0024self__00241785.tempEXP)
					{
						_0024curEXP_00241782 += 1f;
						_0024self__00241785.accountEXP++;
						if (!(_0024curEXP_00241782 < _0024cap_00241783))
						{
							_0024pLevel_00241781++;
							_0024self__00241785.expBack2.GetComponent<Animation>().Play();
							_0024curEXP_00241782 = _0024self__00241785.GetCurEXP(_0024pLevel_00241781);
							_0024cap_00241783 = _0024self__00241785.GetLevelCap(_0024pLevel_00241781);
							_0024self__00241785.txtLevelEXP.text = "Level: " + _0024pLevel_00241781;
						}
						_0024self__00241785.txtPercent.text = _0024curEXP_00241782 + "/" + _0024cap_00241783;
						result = (Yield(2, new WaitForSeconds(0.01f)) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241786;

		public _0024ShowEXP_00241780(GameScript self_)
		{
			_0024self__00241786 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241786);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024StatShow_00241787 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00241788;

			internal int _0024i_00241789;

			internal int _0024a_00241790;

			internal GameScript _0024self__00241791;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241790 = a;
				_0024self__00241791 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024s_00241788 = _0024self__00241791.GetStatsName(_0024a_00241790);
					_0024i_00241789 = 0;
					_0024self__00241791.statObj[_0024a_00241790].SetActive(value: true);
					_0024self__00241791.txtStats[_0024a_00241790].text = _0024s_00241788 + ": " + _0024i_00241789;
					_0024i_00241789 = 0;
					goto IL_00eb;
				case 2:
					_0024i_00241789++;
					goto IL_00eb;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00eb:
					if (_0024i_00241789 < tempStats[_0024a_00241790] + 1)
					{
						_0024self__00241791.txtStats[_0024a_00241790].text = _0024s_00241788 + ": " + _0024i_00241789;
						result = (Yield(2, new WaitForSeconds(0.01f)) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241792;

		internal GameScript _0024self__00241793;

		public _0024StatShow_00241787(int a, GameScript self_)
		{
			_0024a_00241792 = a;
			_0024self__00241793 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00241792, _0024self__00241793);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AdditionalStat_00241794 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241795;

			internal GameScript _0024self__00241796;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241795 = a;
				_0024self__00241796 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(3.6f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241796.LUP[_0024a_00241795].SetActive(value: true);
					result = (Yield(3, new WaitForSeconds(3.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241796.LUP[_0024a_00241795].SetActive(value: false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241797;

		internal GameScript _0024self__00241798;

		public _0024AdditionalStat_00241794(int a, GameScript self_)
		{
			_0024a_00241797 = a;
			_0024self__00241798 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00241797, _0024self__00241798);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShowLUP_00241799 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241800;

			internal GameScript _0024self__00241801;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241800 = a;
				_0024self__00241801 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241801.LUP[_0024a_00241800].SetActive(value: true);
					result = (Yield(2, new WaitForSeconds(3.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241801.LUP[_0024a_00241800].SetActive(value: false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241802;

		internal GameScript _0024self__00241803;

		public _0024ShowLUP_00241799(int a, GameScript self_)
		{
			_0024a_00241802 = a;
			_0024self__00241803 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00241802, _0024self__00241803);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SkillTick_00241804 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024maxCD_00241805;

			internal float _0024_0024597_00241806;

			internal Vector3 _0024_0024598_00241807;

			internal int _0024a_00241808;

			internal float _0024max_00241809;

			internal GameScript _0024self__00241810;

			public _0024(int a, float max, GameScript self_)
			{
				_0024a_00241808 = a;
				_0024max_00241809 = max;
				_0024self__00241810 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024maxCD_00241805 = _0024max_00241809;
					_0024self__00241810.skillObjShade[_0024a_00241808].SetActive(value: true);
					goto case 2;
				case 2:
					if (_0024self__00241810.skillCooldown[_0024a_00241808] > 0f)
					{
						float num = (_0024_0024597_00241806 = _0024self__00241810.skillCooldown[_0024a_00241808] / _0024max_00241809 * 2f);
						Vector3 vector = (_0024_0024598_00241807 = _0024self__00241810.skillObjShade[_0024a_00241808].transform.localScale);
						float num2 = (_0024_0024598_00241807.y = _0024_0024597_00241806);
						Vector3 vector3 = (_0024self__00241810.skillObjShade[_0024a_00241808].transform.localScale = _0024_0024598_00241807);
						_0024self__00241810.skillCooldown[_0024a_00241808] = _0024self__00241810.skillCooldown[_0024a_00241808] - 1f;
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					_0024self__00241810.skillObjShade[_0024a_00241808].SetActive(value: false);
					_0024self__00241810.skillObj[_0024a_00241808].GetComponent<Animation>().Play();
					_0024self__00241810.skillCooldown[_0024a_00241808] = 0f;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241811;

		internal float _0024max_00241812;

		internal GameScript _0024self__00241813;

		public _0024SkillTick_00241804(int a, float max, GameScript self_)
		{
			_0024a_00241811 = a;
			_0024max_00241812 = max;
			_0024self__00241813 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00241811, _0024max_00241812, _0024self__00241813);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RageTick_00241814 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					rage = false;
					player.GetComponent<NetworkView>().RPC("Rage", RPCMode.All, 0);
					YieldDefault(1);
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
			return new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RoarTick_00241815 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					DEXBonus += 10;
					result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
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
					player.GetComponent<NetworkView>().RPC("Roar", RPCMode.All, 0);
					YieldDefault(1);
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
			return new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FloatTick_00241816 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(15f)) ? 1 : 0);
					break;
				case 2:
					rage = false;
					player.GetComponent<NetworkView>().RPC("Float", RPCMode.All, 0);
					YieldDefault(1);
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
			return new _0024();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ManaTick_00241817 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241818;

			internal GameScript _0024self__00241819;

			public _0024(GameScript self_)
			{
				_0024self__00241819 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00241818 = default(int);
					_0024i_00241818 = 0;
					goto IL_0079;
				case 2:
					_0024i_00241818++;
					goto IL_0079;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0079:
					if (_0024i_00241818 < 20)
					{
						if (MAG < MAXMAG)
						{
							MAG++;
							_0024self__00241819.LoadMana();
						}
						result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					clair = false;
					player.GetComponent<NetworkView>().RPC("Clair", RPCMode.All, 0);
					manaWait = 10;
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241820;

		public _0024ManaTick_00241817(GameScript self_)
		{
			_0024self__00241820 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241820);
		}
	}

	[NonSerialized]
	public static bool debugMode;

	[NonSerialized]
	public static bool usedAltar;

	[NonSerialized]
	public static int curAltar;

	[NonSerialized]
	public static int[] legendary = new int[3];

	public GameObject menuAltar;

	[NonSerialized]
	public static bool interacted;

	[NonSerialized]
	public static int hitsTaken;

	public GameObject[] cheatButton;

	[NonSerialized]
	public static bool isCat;

	private bool addingInput;

	public TextMesh txtInput;

	private int inputCount;

	private int[] inputString;

	private bool cheating;

	public GameObject menuCheat;

	private bool spawningTown;

	[NonSerialized]
	public static int vBonus;

	public GameObject menuHoarder;

	public Material blacksmithMenu;

	public TextMesh txtNPCName;

	public Material tailorMenu;

	public Material leatherworkerMenu;

	public GameObject musicBox;

	[NonSerialized]
	public static int drumATK;

	[NonSerialized]
	public static int drumDEX;

	[NonSerialized]
	public static int drumMAG;

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

	private int npcInteract;

	public GameObject rewardTop;

	public GameObject rewardBot;

	public GameObject rewardIcon;

	public GameObject rewardShade;

	public TextMesh[] txtRewardTop;

	public TextMesh[] txtRewardBot;

	private bool usingDrum;

	private bool[] isVariant;

	private int[] reward;

	[NonSerialized]
	public static bool win;

	public GameObject menuVictory;

	private string txtStatuss;

	public TextMesh txtStatus2;

	[NonSerialized]
	public static int eggCounter;

	[NonSerialized]
	public static int fairyCounter;

	[NonSerialized]
	public static int dragonCounter;

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

	private bool generatingLevel;

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
		cheatButton = new GameObject[4];
		inputString = new int[7];
		rewardChestObj = new GameObject[4];
		rewardChest = new int[4];
		txtRewardTop = new TextMesh[2];
		txtRewardBot = new TextMesh[2];
		isVariant = new bool[15];
		reward = new int[50];
		txtHighScore = new TextMesh[2];
		LUP = new GameObject[4];
		skillObjShade = new GameObject[3];
		skillCooldown = new float[3];
		skillObj = new GameObject[3];
		barBack = new GameObject[4];
		barFill = new GameObject[4];
		txtGearStat = new TextMesh[4];
		trait = new GameObject[3];
		bSmithObject = new GameObject[15];
		bSmithText = new TextMesh[15];
		txtStats = new TextMesh[16];
		statObj = new GameObject[16];
		maxHunger = 10;
		txtPlayerStat = new TextMesh[4];
		temp = new Item[20];
		canAttack = true;
		txtBarInfo = new TextMesh[4];
		maxStamina = 10;
		txtInfoName = new TextMesh[2];
		txtStat = new TextMesh[2];
		txtInfoEnchantment = new TextMesh[2];
		inventorySlot = new GameObject[31];
		inventoryQ = new TextMesh[31];
		txtIP = new TextMesh[2];
		curTownNPCs = new int[9];
		atkWait = 0.45f;
		atkAnim = "a1";
		cursorMode = CursorMode.Auto;
		hotSpot = new Vector2(8f, 8f);
	}

	public virtual void TD(int a)
	{
		HP -= a;
	}

	public virtual void Purchase(int id)
	{
		MonoBehaviour.print("Purchasing function called. ID:" + id);
		if (id == 0)
		{
			return;
		}
		int itemPrice = GetItemPrice(id);
		int[] array = null;
		if (curGold >= itemPrice)
		{
			curGold -= itemPrice;
			PlayerTriggerScript.itemPurchasing = 0;
			GameObject gameObject = null;
			Item item = new Item(id, 1, new int[4], 0f, null);
			if (item.id >= 500)
			{
				item.d = (int)GetMaxDurability(item.id);
				item.e = GetGearStats(item.id);
			}
			gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), player.transform.position, Quaternion.identity);
			array = new int[7] { item.id, item.q, 0, 0, 0, 0, 100 };
			gameObject.SendMessage("InitL", array);
			PlayerTriggerScript.currentStand.GetComponent<NetworkView>().RPC("Exile", RPCMode.All);
			isShopping = false;
			RefreshGold();
			GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/PURCHASE", typeof(AudioClip)));
			player.SendMessage("WW2");
			tempStats[11] = tempStats[11] + 1;
		}
		else
		{
			GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/FAIL", typeof(AudioClip)));
		}
	}

	public virtual int GetItemPrice(int id)
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
			46 => 500, 
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
			566 => 1000, 
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
		} * 2;
	}

	public virtual void RefreshGold()
	{
		txtGoldCounter.text = "x" + curGold;
		goldCounter.GetComponent<Animation>().Play();
	}

	public virtual void SetDead()
	{
		isDead = true;
	}

	public virtual void SetRevive()
	{
		isDead = false;
		HP = 1;
		LoadHearts();
	}

	public virtual void LoadEXP()
	{
		float num = exp;
		float num2 = maxEXP;
		txtStatEXP.text = exp + "/" + maxEXP;
		float x = num / num2 * 1.15f;
		Vector3 localScale = barEXP.transform.localScale;
		float num3 = (localScale.x = x);
		Vector3 vector2 = (barEXP.transform.localScale = localScale);
		txtLevel.text = "Lv: " + playerLevel;
	}

	public virtual IEnumerator Invader()
	{
		return new _0024Invader_00241516(this).GetEnumerator();
	}

	public static void EggCounter()
	{
		eggCounter++;
		if (eggCounter >= 3)
		{
			eggCounter = 0;
			Network.Instantiate(Resources.Load("e/broodmother"), new Vector3(player.transform.position.x, player.transform.position.y + 50f, 0f), Quaternion.identity, 0);
		}
	}

	public static void FairyCounter()
	{
		fairyCounter++;
		if (fairyCounter >= 3)
		{
			fairyCounter = 0;
			Network.Instantiate(Resources.Load("e/fQueen"), new Vector3(player.transform.position.x, player.transform.position.y + 50f, 0f), Quaternion.identity, 0);
		}
	}

	public static void DragonCounter()
	{
		dragonCounter++;
		if (dragonCounter >= 1)
		{
			dragonCounter = 0;
			Network.Instantiate(Resources.Load("e/scourgeDragon"), new Vector3(player.transform.position.x, player.transform.position.y - 30f, 0f), Quaternion.identity, 0);
		}
	}

	public virtual void DetectRes()
	{
		if (!(Camera.main.aspect < 1.7f))
		{
			Camera.main.orthographicSize = 12f;
		}
		else if (!(Camera.main.aspect < 1.5f))
		{
			Camera.main.orthographicSize = 13f;
		}
		else if (!(Camera.main.aspect < 1.3f))
		{
			Camera.main.orthographicSize = 14.5f;
		}
		else if (!(Camera.main.aspect < 1.25f))
		{
			Camera.main.orthographicSize = 15.2f;
		}
	}

	public virtual IEnumerator Timer()
	{
		return new _0024Timer_00241521(this).GetEnumerator();
	}

	public virtual void Awake()
	{
		usedAltar = false;
		Application.targetFrameRate = 60;
		drumATK = 0;
		drumDEX = 0;
		drumMAG = 0;
		if (Network.isServer)
		{
			StartCoroutine_Auto(Timer());
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
		fairyCounter = 0;
		dragonCounter = 0;
		DEXBonus = 0;
		rage = false;
		dead = false;
		PlayerControllerN.downed = false;
		isFloating = false;
		manaWait = 10;
		RefreshSkills();
		if (!isTown)
		{
			StartCoroutine_Auto(Invader());
		}
		Network.minimumAllocatableViewIDs = 700;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bossDefeated = false;
		txtDied.text = MenuScript.curName + " has fallen.";
		isShopping = false;
		accountEXP = MenuScript.accountEXP;
		txtLevel.text = "Lv: " + playerLevel;
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
		fade = (FadeInOut)Camera.main.gameObject.GetComponent("FadeInOut");
		readyPlayers = 0;
		int num5 = playerLevel;
		if (num5 <= 4)
		{
			maxStamina = 4;
		}
		else if (num5 <= 12)
		{
			maxStamina = num5;
		}
		else
		{
			maxStamina = 12;
		}
		stamina = maxStamina;
		if (!isInitialized)
		{
			win = false;
			interacted = false;
			hitsTaken = 0;
			int num6 = default(int);
			for (num6 = 0; num6 < 14; num6++)
			{
				MenuScript.canUnlockRace[num6] = 0;
			}
			for (num6 = 0; num6 < 25; num6++)
			{
				MenuScript.canUnlockHat[num6] = 0;
			}
			for (num6 = 0; num6 < 3; num6++)
			{
				legendary[num6] = 0;
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
			int num7 = default(int);
			for (num7 = 0; num7 < 15; num7++)
			{
				tempStats[num7] = 0;
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
			MAXMAG = MenuScript.playerStat[3] + tempPlayerStat[3] + tempLevelStat[3] + tempGearStat[3];
			MAG = MAXMAG;
			DEX = MenuScript.playerStat[2] + tempPlayerStat[2] + tempLevelStat[2] + tempGearStat[2];
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
			curBiome = 0;
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
			MAXMAG = MenuScript.playerStat[3] + tempPlayerStat[3] + tempLevelStat[3] + tempGearStat[3];
			DEX = MenuScript.playerStat[2] + tempPlayerStat[2] + tempLevelStat[2] + tempGearStat[2];
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
		Vector3 position = new Vector3(2f, 2f, 0f);
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
		else if (curBiome == 9)
		{
			MenuScript.canUnlockRace[10] = 1;
		}
		door[0] = 0;
		door[1] = 0;
		door[2] = 0;
		if (!changingScene)
		{
		}
		if (!player)
		{
			player = (GameObject)Network.Instantiate(Resources.Load("playerN"), position, Quaternion.identity, 0);
			if (player.GetComponent<NetworkView>().isMine)
			{
				num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
				num3 = PlayerControllerN.armor;
				num4 = PlayerControllerN.offhand;
				player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num2, num3, MenuScript.pRace, num4, MenuScript.pHat);
				player.GetComponent<NetworkView>().RPC("AssignName", RPCMode.All, MenuScript.curName);
			}
		}
		else if (player.GetComponent<NetworkView>().isMine)
		{
			num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
			num3 = PlayerControllerN.armor;
			num4 = PlayerControllerN.offhand;
			player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num2, num3, MenuScript.pRace, num4, MenuScript.pHat);
			player.GetComponent<NetworkView>().RPC("AssignName", RPCMode.All, MenuScript.curName);
		}
		player.SendMessage("Initialize");
		if (player.GetComponent<NetworkView>().isMine)
		{
			trait[1].GetComponent<Renderer>().material = (Material)Resources.Load("t/t" + MenuScript.curTrait[1], typeof(Material));
			trait[2].GetComponent<Renderer>().material = (Material)Resources.Load("t/t" + MenuScript.curTrait[2], typeof(Material));
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
		StartCoroutine_Auto(GenerateText());
		GenerateLevelName();
		StartCoroutine_Auto(ScourgeMaskTick());
		player.transform.position = new Vector3(0f, -1.5f, 0f);
		player.SendMessage("Initialize");
		if (player.GetComponent<NetworkView>().isMine)
		{
			trait[1].GetComponent<Renderer>().material = (Material)Resources.Load("t/t" + MenuScript.curTrait[1], typeof(Material));
			trait[2].GetComponent<Renderer>().material = (Material)Resources.Load("t/t" + MenuScript.curTrait[2], typeof(Material));
			if (hunger == 0)
			{
				hunger = maxHunger;
			}
			UpdateHunger();
		}
		Camera.main.SendMessage("SetPlayer", player);
		@base = GameObject.Find("base");
		head = GameObject.Find("head");
		head2 = GameObject.Find("head2");
		body = GameObject.Find("body");
		arm1 = GameObject.Find("arm1");
		arm2 = GameObject.Find("arm2");
		leg = GameObject.Find("leg");
		weapon = GameObject.Find("weapon");
		UpdateCharacterWeapon();
		isInstance = true;
		if (!isTown)
		{
			if (Network.isServer)
			{
				StartCoroutine_Auto(GenerateLevel());
			}
		}
		else if (Network.isServer)
		{
			StartCoroutine_Auto(SpawnTownNetwork());
		}
		if ((bool)player)
		{
			Camera.main.SendMessage("SetPlayer", player.gameObject);
			player.SendMessage("Initialize");
		}
		RefreshActionBar();
		maxStamina += STA;
		RefreshPlayerStats();
		StartCoroutine_Auto(RecoverMana());
		if (Network.isServer && curBiome == 19)
		{
			Network.Instantiate(Resources.Load("e/scourgeWall"), new Vector3(-15f, 0f, 0f), Quaternion.identity, 0);
		}
		LoadEXP();
		StartCoroutine_Auto(TikiCheck());
		LoadSTA();
		if (MenuScript.companion == 1)
		{
			HealC();
		}
		else if (MenuScript.companion == 3)
		{
			SPD *= 2f;
		}
		else if (MenuScript.companion == 9)
		{
			SPD *= 3f;
		}
		if (MenuScript.companion == 5)
		{
			StartCoroutine_Auto(RegenManaComp());
		}
	}

	public virtual IEnumerator RegenManaComp()
	{
		return new _0024RegenManaComp_00241524(this).GetEnumerator();
	}

	public virtual void HealC()
	{
		if (HP + 1 > MAXHP)
		{
			HP = MAXHP;
		}
		else
		{
			HP++;
		}
	}

	public virtual void SetRaceStats()
	{
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			tempLevelStat[num] += MenuScript.raceStats[num];
		}
	}

	public virtual IEnumerator ScourgeMaskTick()
	{
		return new _0024ScourgeMaskTick_00241527().GetEnumerator();
	}

	public virtual IEnumerator TikiCheck()
	{
		return new _0024TikiCheck_00241528(this).GetEnumerator();
	}

	public virtual IEnumerator RecoverMana()
	{
		return new _0024RecoverMana_00241533(this).GetEnumerator();
	}

	public virtual void SetStartingItems()
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
				int num2 = UnityEngine.Random.Range(0, 54);
				if (num2 == 49 || num2 == 11)
				{
					num2 = 9;
				}
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

	public virtual IEnumerator ScourgeBoss(int d)
	{
		return new _0024ScourgeBoss_00241537(d).GetEnumerator();
	}

	public virtual IEnumerator Write(int num)
	{
		return new _0024Write_00241541(num, this).GetEnumerator();
	}

	public virtual void GlobalWrite(int a)
	{
		if (Network.isServer)
		{
			player.GetComponent<NetworkView>().RPC("WritePlayer", RPCMode.All, a);
		}
	}

	public virtual IEnumerator WriteFinal(int a)
	{
		return new _0024WriteFinal_00241548(a, this).GetEnumerator();
	}

	public virtual IEnumerator GenerateText()
	{
		return new _0024GenerateText_00241555(this).GetEnumerator();
	}

	public virtual void GenerateLevelName()
	{
		string text = null;
		string text2 = null;
		text2 = ((curBiome == 19) ? "The Scourge Lair" : ("District " + districtLevel + ": "));
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
			8 => GetCavePrefix() + " Quarry", 
			9 => GetCavePrefix() + " Crater", 
			_ => string.Empty, 
		};
		if (Network.isServer)
		{
			player.GetComponent<NetworkView>().RPC("SetZoneName", RPCMode.All, text3);
		}
	}

	public virtual string GetForestPrefix()
	{
		int num = UnityEngine.Random.Range(0, 10);
		int num2 = UnityEngine.Random.Range(0, 10);
		string lhs = null;
		string rhs = null;
		switch (num)
		{
		case 0:
			lhs = "Thorn";
			break;
		case 1:
			lhs = "Bush";
			break;
		case 2:
			lhs = "Leaf";
			break;
		case 3:
			lhs = "Vine";
			break;
		case 4:
			lhs = "Rock";
			break;
		case 5:
			lhs = "Earth";
			break;
		case 6:
			lhs = "Toad";
			break;
		case 7:
			lhs = "Green";
			break;
		case 8:
			lhs = "Tree";
			break;
		case 9:
			lhs = "Deep";
			break;
		case 10:
			lhs = "Lush";
			break;
		}
		switch (num2)
		{
		case 0:
			rhs = "vale";
			break;
		case 1:
			rhs = "wreath";
			break;
		case 2:
			rhs = "night";
			break;
		case 3:
			rhs = "fire";
			break;
		case 4:
			rhs = "roar";
			break;
		case 5:
			rhs = "fang";
			break;
		case 6:
			rhs = "road";
			break;
		case 7:
			rhs = "wild";
			break;
		case 8:
			rhs = "wood";
			break;
		case 9:
			rhs = "grand";
			break;
		case 10:
			rhs = "flower";
			break;
		}
		return lhs + rhs;
	}

	public virtual string GetTundraPrefix()
	{
		int num = UnityEngine.Random.Range(0, 10);
		int num2 = UnityEngine.Random.Range(0, 10);
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
		return (UnityEngine.Random.Range(0, 2) != 0) ? (text2 + text) : (text + text2);
	}

	public virtual string GetDungeonPrefix()
	{
		int num = UnityEngine.Random.Range(0, 10);
		int num2 = UnityEngine.Random.Range(0, 10);
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
		return (UnityEngine.Random.Range(0, 2) != 0) ? (text2 + text) : (text + text2);
	}

	public virtual string GetCavePrefix()
	{
		int num = UnityEngine.Random.Range(0, 10);
		int num2 = UnityEngine.Random.Range(0, 10);
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
		return (UnityEngine.Random.Range(0, 2) != 0) ? (text2 + text) : (text + text2);
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241561(this).GetEnumerator();
	}

	public virtual IEnumerator StaminaStart()
	{
		return new _0024StaminaStart_00241564(this).GetEnumerator();
	}

	public virtual void LoadSTA()
	{
		int num = playerLevel;
		if (num <= 4)
		{
			maxStamina = 4;
		}
		else if (num <= 12)
		{
			maxStamina = num;
		}
		else
		{
			maxStamina = 12;
		}
		int num2 = default(int);
		float num3 = maxStamina;
		float num4 = stamina;
		txtBarInfo[3].text = stamina + "/" + maxStamina;
		float x = num3 * 0.3f;
		Vector3 localScale = barBack[3].transform.localScale;
		float num5 = (localScale.x = x);
		Vector3 vector2 = (barBack[3].transform.localScale = localScale);
		float x2 = num4 * 0.3f;
		Vector3 localScale2 = barFill[3].transform.localScale;
		float num6 = (localScale2.x = x2);
		Vector3 vector4 = (barFill[3].transform.localScale = localScale2);
	}

	public virtual void DecreaseHunger()
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
				player.SendMessage("TD", 1);
			}
			if (hunger == 3)
			{
				StartCoroutine_Auto(Write(1));
			}
			else if (hunger == 0)
			{
				StartCoroutine_Auto(Write(2));
			}
		}
		UpdateHunger();
	}

	public virtual void ShowSkillDesc(int a)
	{
		txtSkillDesc.text = GetSkillDesc(a);
		txtSkillName.text = string.Empty + GetSkillName(a);
		skillDesc.SetActive(value: true);
	}

	public virtual void CloseSkillDesc()
	{
		txtSkillDesc.text = string.Empty;
		txtSkillName.text = string.Empty;
		skillDesc.SetActive(value: false);
	}

	public virtual void UpdateHunger()
	{
		if (hunger > maxHunger)
		{
			hunger = maxHunger;
		}
		txtBarInfo[2].text = hunger + "/" + maxHunger;
		float x = (float)maxHunger * 0.3f;
		Vector3 localScale = barBack[2].transform.localScale;
		float num = (localScale.x = x);
		Vector3 vector2 = (barBack[2].transform.localScale = localScale);
		float x2 = (float)hunger * 0.3f;
		Vector3 localScale2 = barFill[2].transform.localScale;
		float num2 = (localScale2.x = x2);
		Vector3 vector4 = (barFill[2].transform.localScale = localScale2);
	}

	public virtual string GetTraitDesc(int id)
	{
		string text = null;
		return id switch
		{
			1 => "Chops down trees quicker.", 
			2 => "Mines ores faster.", 
			3 => "Collects twice as many\ningredients when gathering.", 
			4 => "50% chance to\ncraft Big Potions with\nonly basic ingredients.", 
			5 => "Higher chance at\ncrafting rare weapons\n& gear.", 
			6 => "+2 ATK\n-1 HP", 
			7 => "+4 HP\n-1 ATK.", 
			8 => "+2 DEX", 
			9 => "+2 HP", 
			10 => "Hunger Cap is doubled.", 
			11 => "+2 MAG", 
			12 => "Doesn't need a key when\nopening chests or locks.", 
			_ => "NULL", 
		};
	}

	public virtual string GetTraitName(int id)
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

	public virtual void ShowTraitDesc(int slot)
	{
		traitDesc.SetActive(value: true);
		txtTraitName.text = GetTraitName(MenuScript.curTrait[slot]);
		txtTraitDesc.text = GetTraitDesc(MenuScript.curTrait[slot]);
	}

	public virtual void OpenDoor()
	{
		if ((bool)exitObj)
		{
			exitObj.SendMessage("Open");
		}
	}

	public virtual IEnumerator WriteEgg()
	{
		return new _0024WriteEgg_00241568(this).GetEnumerator();
	}

	public virtual IEnumerator AddInput(int a)
	{
		return new _0024AddInput_00241571(a, this).GetEnumerator();
	}

	public virtual void CheckInput()
	{
		int num = default(int);
		string text = string.Empty;
		for (num = 0; num < 7; num++)
		{
			text += string.Empty + inputString[num];
		}
		switch (text)
		{
		case "1131313":
			txtInput.text = "Cat Form";
			CatForm();
			break;
		case "1414131":
			txtInput.text = "Unlocked Sean Hat";
			MenuScript.canUnlockHat[23] = 1;
			break;
		case "4431321":
			txtInput.text = "Title Set";
			SetTitle(1);
			break;
		case "3311323":
			txtInput.text = "Title Set";
			SetTitle(2);
			break;
		case "4141222":
			txtInput.text = "Title Set";
			SetTitle(3);
			break;
		case "2334344":
			txtInput.text = "Title Set";
			SetTitle(4);
			break;
		case "1123111":
			txtInput.text = "Title Set";
			SetTitle(5);
			break;
		case "1123122":
			txtInput.text = "Title Set";
			SetTitle(6);
			break;
		case "3313134":
			txtInput.text = "Emote!";
			Exclusive();
			break;
		case "4441142":
			txtInput.text = "Death Unlocked";
			DeathAnim();
			break;
		case "1234123":
			txtInput.text = "Jared's Bear Hat";
			BearHat();
			break;
		default:
			txtInput.text = "Invalid Code";
			break;
		}
	}

	public virtual void BearHat()
	{
		player.GetComponent<NetworkView>().RPC("SetBearHat", RPCMode.All);
	}

	public virtual void Exclusive()
	{
		if ((bool)player)
		{
			Network.Instantiate(Resources.Load("exclusive"), player.transform.position, Quaternion.identity, 0);
			int num = 20;
			Vector3 velocity = player.GetComponent<Rigidbody>().velocity;
			float num2 = (velocity.y = num);
			Vector3 vector2 = (player.GetComponent<Rigidbody>().velocity = velocity);
		}
	}

	public virtual void DeathAnim()
	{
		if (MenuScript.deathA == 0)
		{
			PlayerPrefs.SetInt("deathA", 1);
			MenuScript.deathA = 1;
		}
		else
		{
			PlayerPrefs.SetInt("deathA", 1);
			MenuScript.deathA = 1;
		}
	}

	public virtual void SetTitle(int a)
	{
		string text = null;
		text = a switch
		{
			1 => "Item Creator", 
			2 => "Enemy Creator", 
			3 => "Creator of Gods", 
			4 => "Ultimate Fan", 
			5 => "Creator of Worlds", 
			6 => "Champion", 
			_ => string.Empty, 
		};
		if ((bool)player)
		{
			player.GetComponent<NetworkView>().RPC("AssignTitle", RPCMode.All, text);
		}
	}

	public virtual void CatForm()
	{
		if (isCat)
		{
			isCat = false;
			player.SendMessage("Cat", (object)0);
		}
		else
		{
			isCat = true;
			player.SendMessage("Cat", 1);
		}
	}

	public virtual void Update()
	{
		if (eggCounter >= 3 && !writingEgg)
		{
			StartCoroutine_Auto(WriteEgg());
		}
		if (UnityEngine.Input.GetKeyDown(KeyCode.P) && debugMode)
		{
			districtLevel = 20;
		}
		if (UnityEngine.Input.GetKeyDown(KeyCode.I) && debugMode)
		{
			Network.Instantiate(Resources.Load("e/jelly"), new Vector3(player.transform.position.x + 10f, player.transform.position.y, 0f), Quaternion.identity, 0);
			GameObject gameObject = null;
			Item item = null;
			int[] array = null;
			HP = MAXHP;
			MAG = MAXMAG;
			LoadHearts();
			curGold += 200;
			RefreshGold();
			gameObject = ((Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= player.transform.position.x) ? ((GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), new Vector3(player.transform.position.x - 3f, player.transform.position.y, 0f), Quaternion.identity)) : ((GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), new Vector3(player.transform.position.x + 3f, player.transform.position.y, 0f), Quaternion.identity)));
			item = new Item(567, 1, new int[4], 999f, null);
			array = new int[7] { item.id, item.q, 0, 0, 0, 0, item.d };
			gameObject.SendMessage("InitL", array);
			gameObject = ((Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= player.transform.position.x) ? ((GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), new Vector3(player.transform.position.x - 3f, player.transform.position.y, 0f), Quaternion.identity)) : ((GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), new Vector3(player.transform.position.x + 3f, player.transform.position.y, 0f), Quaternion.identity)));
			item = new Item(12, 1, new int[4], 999f, null);
			array = new int[7] { item.id, item.q, 0, 0, 0, 0, item.d };
			gameObject.SendMessage("InitL", array);
		}
		if (UnityEngine.Input.GetKeyDown(KeyCode.U) && debugMode)
		{
			GainEXP(150);
		}
		if (debugMode)
		{
		}
		if (UnityEngine.Input.GetButtonDown("Slot 1"))
		{
			SelectSlot(0);
		}
		else if (UnityEngine.Input.GetButtonDown("Slot 2"))
		{
			SelectSlot(1);
		}
		else if (UnityEngine.Input.GetButtonDown("Slot 3"))
		{
			SelectSlot(2);
		}
		else if (UnityEngine.Input.GetButtonDown("Slot 4"))
		{
			SelectSlot(3);
		}
		else if (UnityEngine.Input.GetButtonDown("Slot 5"))
		{
			SelectSlot(4);
		}
		if ((bool)player)
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
		if (UnityEngine.Input.GetKeyDown(KeyCode.F1))
		{
			Screen.SetResolution(512, 320, fullscreen: false);
		}
		else if (UnityEngine.Input.GetKeyDown(KeyCode.F2))
		{
			Screen.SetResolution(640, 400, fullscreen: false);
		}
		else if (UnityEngine.Input.GetKeyDown(KeyCode.F3))
		{
			Screen.SetResolution(800, 500, fullscreen: false);
		}
		else if (UnityEngine.Input.GetKeyDown(KeyCode.F4))
		{
			Screen.SetResolution(960, 600, fullscreen: false);
		}
		else if (UnityEngine.Input.GetKeyDown(KeyCode.F5))
		{
			Screen.SetResolution(1120, 700, fullscreen: false);
		}
		else if (UnityEngine.Input.GetKeyDown(KeyCode.F6))
		{
			Screen.SetResolution(1920, 1080, fullscreen: true);
		}
		if (UnityEngine.Input.GetButtonDown("Inventory") && !dead)
		{
			OpenInventory();
		}
		int num2 = default(int);
		if (inventoryOpen)
		{
			rayCursor = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
			if (Physics.Raycast(rayCursor, out cursorHit, 10f, mask))
			{
				if (cursorHit.transform.gameObject.layer == 10)
				{
					if (cursorHit.transform.gameObject.tag == "sIcon")
					{
						int num = int.Parse(cursorHit.transform.gameObject.name);
						ShowSkillDesc(skill[num]);
					}
					else if (cursorHit.transform.gameObject.tag == "tIcon")
					{
						int slot = int.Parse(cursorHit.transform.gameObject.name);
						ShowTraitDesc(slot);
					}
					else
					{
						CloseSkillDesc();
						traitDesc.SetActive(value: false);
						num2 = int.Parse(cursorHit.transform.gameObject.tag);
						if (num2 < 100)
						{
							if (inventory[num2].id != 0)
							{
								SetInfoText(num2, inventory[num2].id);
							}
							else
							{
								infoObject.SetActive(value: false);
							}
						}
					}
				}
				else
				{
					CloseSkillDesc();
					traitDesc.SetActive(value: false);
				}
			}
			else
			{
				CloseSkillDesc();
				traitDesc.SetActive(value: false);
				infoObject.SetActive(value: false);
			}
		}
		if (UnityEngine.Input.GetButtonDown("CheatKey"))
		{
			if (cheating)
			{
				cheating = false;
				menuCheat.SetActive(value: false);
			}
			else
			{
				cheating = true;
				if (!inventoryOpen)
				{
					OpenInventory();
				}
				menuCheat.SetActive(value: true);
			}
		}
		if (UnityEngine.Input.GetButtonDown("Skill 1") && !dead && HP > 0)
		{
			UseSkill(0);
		}
		if (UnityEngine.Input.GetButtonDown("Skill 2") && !dead && HP > 0)
		{
			UseSkill(1);
		}
		if (UnityEngine.Input.GetButtonDown("Skill 3") && !dead && HP > 0)
		{
			UseSkill(2);
		}
		if (UnityEngine.Input.GetKeyDown(KeyCode.Escape))
		{
			PlayerPrefs.SetInt("gChests", MenuScript.goldChests);
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
				menuExit.SetActive(value: true);
				menuOpen = true;
				OpenInventory();
			}
			else if (menuOpen && !dead)
			{
				if (Network.connections.Length == 0)
				{
					Time.timeScale = 1f;
				}
				menuExit.SetActive(value: false);
				menuOpen = false;
			}
		}
		if (UnityEngine.Input.GetButtonDown("Craft"))
		{
			shifting = true;
		}
		if (UnityEngine.Input.GetButtonUp("Craft"))
		{
			shifting = false;
		}
		if (UnityEngine.Input.GetButtonDown("Melee Attack") && menuOpen)
		{
			GetComponent<AudioSource>().PlayOneShot(audioSelect2);
			ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
			if (Physics.Raycast(ray, out hit, 20f))
			{
				string text = hit.transform.gameObject.name;
				if (hit.transform.gameObject.tag == "sP")
				{
					if (hit.transform.gameObject.name == "sP0")
					{
						SelectSkill(0);
					}
					else if (hit.transform.gameObject.name == "sP1")
					{
						SelectSkill(1);
					}
					else if (hit.transform.gameObject.name == "sP2")
					{
						SelectSkill(2);
					}
					else
					{
						SelectSkill(3);
					}
				}
				switch (text)
				{
				case "bLeave":
					LeaveTown();
					break;
				case "bStay":
					menuOpen = false;
					menuLeaveTown.SetActive(value: false);
					menuReturnTown.SetActive(value: false);
					break;
				case "bReturn":
					ReturnTown();
					break;
				case "0":
					StartCoroutine_Auto(SelectReward(0));
					break;
				case "1":
					StartCoroutine_Auto(SelectReward(1));
					break;
				case "2":
					StartCoroutine_Auto(SelectReward(2));
					break;
				case "3":
					StartCoroutine_Auto(SelectReward(3));
					break;
				case "bClose":
					CloseReward();
					break;
				}
			}
		}
		if (UnityEngine.Input.GetButtonDown("Melee Attack") && inventoryOpen && !shifting)
		{
			ResetCraft();
			ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
			if (Physics.Raycast(ray, out hit, 20f))
			{
				if (hit.transform.gameObject.tag == "sP")
				{
					if (hit.transform.gameObject.name == "sP0")
					{
						SelectSkill(0);
					}
					else if (hit.transform.gameObject.name == "sP1")
					{
						SelectSkill(1);
					}
					else if (hit.transform.gameObject.name == "sP2")
					{
						SelectSkill(2);
					}
					else
					{
						SelectSkill(3);
					}
				}
				GetComponent<AudioSource>().PlayOneShot(audioSelect2);
				GameObject gameObject2 = hit.transform.gameObject;
				if (gameObject2.name == "drop" && holdingItem)
				{
					DropItem();
				}
				else if (gameObject2.name == "sell" && holdingItem)
				{
					SellItem();
				}
				else if (gameObject2.name == "b1")
				{
					StartCoroutine_Auto(AddInput(1));
				}
				else if (gameObject2.name == "b2")
				{
					StartCoroutine_Auto(AddInput(2));
				}
				else if (gameObject2.name == "b3")
				{
					StartCoroutine_Auto(AddInput(3));
				}
				else if (gameObject2.name == "b4")
				{
					StartCoroutine_Auto(AddInput(4));
				}
				else if (gameObject2.layer == 10 && gameObject2.tag != "sIcon" && gameObject2.tag != "tIcon")
				{
					int num3 = int.Parse(gameObject2.tag);
					if (!holdingItem && inventory[num3].id != 0)
					{
						SelectItem(num3);
					}
					else if (holdingItem && inventory[num3].id == 0)
					{
						PlaceItem(num3, gameObject2);
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
						else if (num3 == 22 && itemSelected.id >= 900 && itemSelected.id < 950)
						{
							SwapItem(num3);
						}
						else if ((num3 == 24 || num3 == 25) && itemSelected.id >= 950 && itemSelected.id < 1000)
						{
							SwapItem(num3);
						}
						else if (num3 < 20)
						{
							SwapItem(num3);
						}
					}
				}
				else if (gameObject2.layer == 30)
				{
					int num4 = int.Parse(gameObject2.name);
					if (!holdingItem && npcInventory[num4].id != 0)
					{
						SelectItemNPC(num4);
					}
					else if (holdingItem && npcInventory[num4].id == 0)
					{
						PlaceItemNPC(num4, gameObject2);
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
		else if (UnityEngine.Input.GetButtonDown("Use Item") && inventoryOpen && !shifting)
		{
			ResetCraft();
			ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
			if (Physics.Raycast(ray, out hit, 20f))
			{
				if (hit.transform.gameObject.tag == "sP")
				{
					if (hit.transform.gameObject.name == "sP0")
					{
						SelectSkill(0);
					}
					else if (hit.transform.gameObject.name == "sP1")
					{
						SelectSkill(1);
					}
					else if (hit.transform.gameObject.name == "sP2")
					{
						SelectSkill(2);
					}
					else
					{
						SelectSkill(3);
					}
				}
				GetComponent<AudioSource>().PlayOneShot(audioSelect);
				GameObject gameObject3 = hit.transform.gameObject;
				if (gameObject3.layer == 10)
				{
					int num5 = int.Parse(gameObject3.tag);
					if (!holdingItem && inventory[num5].id != 0 && num5 < 28)
					{
						SelectHalfItem(num5);
					}
					else if (!holdingItem && inventory[num5].id != 0 && num5 >= 28)
					{
						SelectOneItem(num5);
					}
					else if (holdingItem && inventory[num5].id == 0 && num5 != 20 && num5 != 21 && num5 != 22 && num5 != 24 && num5 != 25)
					{
						PlaceOneItem(num5, gameObject3);
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
				else if (gameObject3.layer == 30)
				{
					int num6 = int.Parse(gameObject3.name);
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
						PlaceOneItemNPC(num6, gameObject3);
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
		else if (UnityEngine.Input.GetButtonDown("Melee Attack") && inventoryOpen && shifting && !holdingItem)
		{
			ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
			if (Physics.Raycast(ray, out hit, 20f))
			{
				GameObject gameObject4 = hit.transform.gameObject;
				if (hit.transform.gameObject.layer == 10)
				{
					int num7 = int.Parse(gameObject4.tag);
					if (gameObject4.layer == 10 && inventory[num7].id != 0)
					{
						GetComponent<AudioSource>().PlayOneShot(audioSelect3);
						if (num7 < 20 && !crafting)
						{
							if (num7 == firstItemSelectedSlot)
							{
								firstItemSelectedSlot = -1;
								firstItemSelected = null;
								selectCraft1.SetActive(value: false);
							}
							else if (!RuntimeServices.EqualityOperator(firstItemSelected, null))
							{
								crafting = true;
								secondItemSelected = inventory[num2];
								secondItemSelectedSlot = num7;
								selectCraft2.SetActive(value: true);
								selectCraft2.transform.position = inventorySlot[num7].transform.position;
								StartCoroutine_Auto(Craft());
							}
							else
							{
								firstItemSelectedSlot = num7;
								firstItemSelected = inventory[num7];
								selectCraft1.SetActive(value: true);
								selectCraft1.transform.position = inventorySlot[num7].transform.position;
							}
						}
					}
				}
			}
		}
		else if (UnityEngine.Input.GetButtonDown("Use Item") && !inventoryOpen && !isDead && !immobilized && !usingItem)
		{
			StartCoroutine_Auto(UseItem(curActiveSlot));
		}
		else if (UnityEngine.Input.GetButtonDown("Melee Attack") && !inventoryOpen)
		{
			ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
			if (!isDead && (bool)player && player.GetComponent<NetworkView>().isMine)
			{
				Attack(curActiveSlot);
			}
			if (Physics.Raycast(ray, out hit, 20f))
			{
				GameObject gameObject5 = hit.transform.gameObject;
				if (hit.transform.gameObject.tag == "sP")
				{
					if (hit.transform.gameObject.name == "sP0")
					{
						SelectSkill(0);
					}
					else if (hit.transform.gameObject.name == "sP1")
					{
						SelectSkill(1);
					}
					else if (hit.transform.gameObject.name == "sP2")
					{
						SelectSkill(2);
					}
					else
					{
						SelectSkill(3);
					}
				}
				switch (gameObject5.name)
				{
				case "bResume":
					Resume();
					break;
				case "bOptions":
					Options();
					break;
				case "bMenu":
					StartCoroutine_Auto(Menuu());
					break;
				case "bQuit":
					SaveStats();
					StartCoroutine_Auto(Menuu());
					break;
				case "bAgain":
					Again();
					break;
				}
			}
		}
		if (!(UnityEngine.Input.GetAxis("mS") <= 0f) && !dead)
		{
			Scroll(0);
		}
		else if (!(UnityEngine.Input.GetAxis("mS") >= 0f) && !dead)
		{
			Scroll(1);
		}
	}

	public virtual void SellItem()
	{
		int num = default(int);
		Item item = null;
		int num2 = default(int);
		item = itemSelected;
		int num3 = UnityEngine.Random.Range(0, 10);
		num = ((num3 < 6) ? 2 : ((num3 >= 9) ? 4 : 3));
		if (item.id == 1 || item.id == 2 || item.id == 3)
		{
			num = 1;
		}
		GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/PURCHASE", typeof(AudioClip)));
		num2 = num * item.q;
		curGold += num2;
		RefreshGold();
		itemSelected = EmptyItem();
		holdingItem = false;
		sSelected.SetActive(value: false);
	}

	public virtual void DropItem()
	{
		int num = default(int);
		Item item = null;
		GameObject gameObject = null;
		int[] array = null;
		gameObject = ((Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= player.transform.position.x) ? ((GameObject)Network.Instantiate(Resources.Load("iNetwork"), new Vector3(player.transform.position.x - 3f, player.transform.position.y, 0f), Quaternion.identity, 0)) : ((GameObject)Network.Instantiate(Resources.Load("iNetwork"), new Vector3(player.transform.position.x + 3f, player.transform.position.y, 0f), Quaternion.identity, 0)));
		item = new Item(itemSelected.id, itemSelected.q, itemSelected.e, itemSelected.d, null);
		array = new int[7]
		{
			item.id,
			item.q,
			item.e[0],
			item.e[1],
			item.e[2],
			item.e[3],
			item.d
		};
		gameObject.GetComponent<NetworkView>().RPC("InitL", RPCMode.All, array);
		itemSelected = EmptyItem();
		holdingItem = false;
		sSelected.SetActive(value: false);
	}

	public virtual IEnumerator Craft()
	{
		return new _0024Craft_00241576(this).GetEnumerator();
	}

	public virtual void SaveStats()
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
			PlayerPrefs.SetInt("stat" + num, tempStats[num] + PlayerPrefs.GetInt("stat" + num));
		}
		MenuScript.curScore = (int)(tempEXP * 2f);
		if (MenuScript.curScore > PlayerPrefs.GetInt("hScore"))
		{
			PlayerPrefs.SetInt("hScore", MenuScript.curScore);
		}
		SetRewards();
	}

	public virtual bool ChanceRace(int a)
	{
		int num = 0;
		return UnityEngine.Random.Range(0, a switch
		{
			6 => 1, 
			8 => 1, 
			9 => 1, 
			10 => 2, 
			11 => 1, 
			12 => 1, 
			13 => 1, 
			14 => 1, 
			_ => 5, 
		}) == 0;
	}

	public virtual bool ChanceHat(int a)
	{
		int num = 0;
		MonoBehaviour.print(a + " is hat ");
		num = a switch
		{
			3 => 1, 
			11 => 1, 
			12 => 1, 
			18 => 1, 
			19 => 1, 
			20 => 1, 
			21 => 1, 
			22 => 1, 
			23 => 1, 
			24 => 1, 
			_ => 5, 
		};
		int num2 = default(int);
		num2 = ((num != 1) ? UnityEngine.Random.Range(0, num) : 0);
		return num2 == 0;
	}

	public virtual void SetRewards()
	{
		int num = default(int);
		int num2 = default(int);
		for (num = 0; num < playerLevel; num++)
		{
			if (UnityEngine.Random.Range(0, 5) != 0)
			{
				continue;
			}
			num2 = UnityEngine.Random.Range(0, 50);
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
			if (MenuScript.raceUnlock[num] >= 3 || MenuScript.canUnlockRace[num] != 1 || !ChanceRace(num))
			{
				continue;
			}
			num2 = UnityEngine.Random.Range(0, 50);
			while (reward[num2] != 0)
			{
				num2++;
				if (num2 > 49)
				{
					num2 = 0;
				}
			}
			reward[num2] = num + 1;
			MonoBehaviour.print("temp is " + num2);
			if (MenuScript.raceUnlock[num] > 0)
			{
				isVariant[num] = true;
			}
			else
			{
				isVariant[num] = false;
			}
		}
		for (num = 1; num < 10; num++)
		{
			if (MenuScript.companionUnlock[num] != 0 || MenuScript.canUnlockCompanion[num] != 1)
			{
				continue;
			}
			num2 = UnityEngine.Random.Range(0, 50);
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
		for (num = 0; num < 25; num++)
		{
			if (MenuScript.hatUnlock[num] != 0 || MenuScript.canUnlockHat[num] != 1 || !ChanceHat(num))
			{
				continue;
			}
			num2 = UnityEngine.Random.Range(0, 50);
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

	public virtual void CloseReward()
	{
		selectingReward = false;
		rewardTop.SetActive(value: false);
		rewardBot.SetActive(value: false);
		rewardShade.SetActive(value: false);
	}

	public virtual IEnumerator SelectReward(int c)
	{
		return new _0024SelectReward_00241594(c, this).GetEnumerator();
	}

	public virtual IEnumerator UnlockHat(int h)
	{
		return new _0024UnlockHat_00241602(h, this).GetEnumerator();
	}

	public virtual IEnumerator UnlockComp(int h)
	{
		return new _0024UnlockComp_00241607(h, this).GetEnumerator();
	}

	public virtual IEnumerator UnlockVariant(int r)
	{
		return new _0024UnlockVariant_00241612(r, this).GetEnumerator();
	}

	public virtual IEnumerator UnlockRace(int h)
	{
		return new _0024UnlockRace_00241617(h, this).GetEnumerator();
	}

	public virtual string GetHatName(int a)
	{
		string text = null;
		return a switch
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
			18 => "Frost Crown", 
			19 => "Viking Helm", 
			20 => "Black Dragon Hat", 
			21 => "Skeleton King Hood", 
			22 => "Pirate Hat", 
			23 => "Sean's Head", 
			24 => "Overworld Helm", 
			_ => string.Empty, 
		};
	}

	public virtual string GetRaceName(int race)
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
			9 => "Qualogg", 
			10 => "Bandicoot", 
			11 => "Djinn", 
			12 => "Lizardman", 
			13 => "Scourgeling", 
			14 => "Spirit", 
			_ => "null", 
		};
	}

	public virtual string GetCompName(int a)
	{
		string text = null;
		return a switch
		{
			1 => "Regen Fairy", 
			2 => "Ancient Bat", 
			3 => "Haste Beetle", 
			4 => "Gadget Guard", 
			5 => "Gorgon Eye", 
			6 => "Floaty Slime", 
			7 => "Gooey Ghost", 
			8 => "Flame of Hope", 
			9 => "4th Age Droid", 
			10 => "Tiki Mask", 
			11 => "Wizard Beard", 
			12 => "Hero Crown", 
			13 => "Shroom Hat", 
			14 => "Spider Egg", 
			15 => "Skeleton Mask", 
			16 => "Dragon Hat", 
			17 => "Black", 
			_ => string.Empty, 
		};
	}

	public virtual int GetScoreBonus()
	{
		int num = UnityEngine.Random.Range(0, 100);
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

	public virtual void RewardShowCheck()
	{
		int num = default(int);
		int num2 = default(int);
		for (num = 0; num < 4; num++)
		{
			if (rewardChest[num] != 0)
			{
				continue;
			}
			num2 = GetNextReward();
			if (num2 == 0)
			{
				if (rewardChestObj != null)
				{
					rewardChestObj[num].GetComponent<Renderer>().material = rewShade;
					rewardChest[num] = 0;
					rewardChestObj[num].GetComponent<Animation>().Stop();
				}
			}
			else if (rewardChestObj != null)
			{
				rewardChestObj[num].GetComponent<Renderer>().material = rewChest;
				rewardChestObj[num].GetComponent<Animation>().Play();
				rewardChest[num] = num2;
			}
		}
	}

	public virtual int GetNextReward()
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

	public virtual float ConvertToEXP(int s, float v)
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

	public virtual void BreakSound()
	{
		gameObject.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/break", typeof(AudioClip)));
	}

	public virtual void ResetCraft()
	{
		firstItemSelected = null;
		secondItemSelected = null;
		firstItemSelectedSlot = -1;
		secondItemSelectedSlot = -1;
		crafting = false;
		selectCraft1.SetActive(value: false);
		selectCraft2.SetActive(value: false);
	}

	public virtual void ExitMenuSave()
	{
	}

	public virtual IEnumerator Menuu()
	{
		return new _0024Menuu_00241622(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator AgainN()
	{
		return new _0024AgainN_00241625(this).GetEnumerator();
	}

	public virtual void Again()
	{
		if (Network.isServer)
		{
			player.GetComponent<NetworkView>().RPC("AgainN", RPCMode.All);
		}
	}

	public virtual void Stamina()
	{
		barStamina.GetComponent<Animation>().Play();
	}

	public virtual void ReturnTown()
	{
		changingScene = true;
		isReturning = true;
		isInstance = false;
		SaveInventory();
		player.GetComponent<NetworkView>().RPC("LoadLevel", RPCMode.All, 1, false);
	}

	public virtual void LeaveTown()
	{
		changingScene = true;
		isInstance = true;
		SaveInventory();
		player.GetComponent<NetworkView>().RPC("LoadLevel", RPCMode.All, 1, true);
	}

	public virtual IEnumerator SpawnTownNetwork()
	{
		return new _0024SpawnTownNetwork_00241628(this).GetEnumerator();
	}

	public virtual void SetBGNetwork(int tBiome)
	{
	}

	public virtual Vector3 GetHousePos(int a)
	{
		Vector3 vector = default(Vector3);
		return a switch
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
			_ => vector, 
		};
	}

	public virtual void UseMana(int m)
	{
		MAG -= m;
		barMana.GetComponent<Animation>().Play();
		LoadMana();
	}

	public virtual IEnumerator ThrowPoison()
	{
		return new _0024ThrowPoison_00241638(this).GetEnumerator();
	}

	public virtual IEnumerator ThrowDagger(int a)
	{
		return new _0024ThrowDagger_00241642(a, this).GetEnumerator();
	}

	public virtual IEnumerator ThrowRock()
	{
		return new _0024ThrowRock_00241653(this).GetEnumerator();
	}

	public virtual IEnumerator UseTotalBiscuit()
	{
		return new _0024UseTotalBiscuit_00241657(this).GetEnumerator();
	}

	public virtual IEnumerator UseHPPotion(int heal)
	{
		return new _0024UseHPPotion_00241660(heal, this).GetEnumerator();
	}

	public virtual IEnumerator UseManaPotion(int heal)
	{
		return new _0024UseManaPotion_00241666(heal, this).GetEnumerator();
	}

	public virtual IEnumerator UseDrum(int drum)
	{
		return new _0024UseDrum_00241672(drum, this).GetEnumerator();
	}

	public virtual IEnumerator UseItem(int slot)
	{
		return new _0024UseItem_00241677(slot, this).GetEnumerator();
	}

	[RPC]
	public virtual void Poop(Vector3 pos)
	{
		GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/poop"));
		UnityEngine.Object.Instantiate(Resources.Load("poop"), pos, Quaternion.identity);
	}

	public virtual void Attack(int slot)
	{
		if (!attacking)
		{
			attacking = true;
			StartCoroutine_Auto(MeleeAttack());
		}
	}

	public virtual void UseKey()
	{
	}

	public virtual void Ice()
	{
		if (MAG < 3)
		{
			return;
		}
		if (MenuScript.pHat == 11)
		{
			if (UnityEngine.Random.Range(0, 3) == 0)
			{
				UseMana(3);
			}
		}
		else
		{
			UseMana(3);
		}
		player.SendMessage("iceShard", MAXMAG + drumMAG);
		GUImana.GetComponent<Animation>().Play();
	}

	public virtual void Bolt()
	{
		MonoBehaviour.print(MenuScript.pHat + " curhat");
		if (MAG < 1)
		{
			return;
		}
		if (MenuScript.pHat == 11)
		{
			if (UnityEngine.Random.Range(0, 3) == 0)
			{
				UseMana(1);
			}
		}
		else
		{
			UseMana(1);
		}
		GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("proj/bolt"), player.transform.position, Quaternion.identity, 0);
		gameObject.SendMessage("Set", MAXMAG + drumMAG);
		GUImana.GetComponent<Animation>().Play();
	}

	public virtual void Fireball()
	{
		if (MAG < 1)
		{
			return;
		}
		GameObject gameObject = null;
		if (MenuScript.pHat == 11)
		{
			if (UnityEngine.Random.Range(0, 3) == 0)
			{
				UseMana(1);
			}
		}
		else
		{
			UseMana(1);
		}
		gameObject = ((!facingLeft) ? ((GameObject)Network.Instantiate(Resources.Load("proj/fireballR"), player.transform.position, Quaternion.identity, 0)) : ((GameObject)Network.Instantiate(Resources.Load("proj/fireballL"), player.transform.position, Quaternion.identity, 0)));
		gameObject.SendMessage("Set", MAXMAG + drumMAG);
		GUImana.GetComponent<Animation>().Play();
	}

	public virtual IEnumerator MeleeAttack()
	{
		return new _0024MeleeAttack_00241738(this).GetEnumerator();
	}

	public virtual IEnumerator v()
	{
		return new _0024v_00241746().GetEnumerator();
	}

	public virtual IEnumerator KnockBack(Transform h)
	{
		return new _0024KnockBack_00241747(h).GetEnumerator();
	}

	public virtual void SelectOneItemNPC(int slot)
	{
		if (npcInventory[slot].id < 500)
		{
			GetComponent<AudioSource>().PlayOneShot(audioCrafted);
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

	public virtual void SelectOneItem(int slot)
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

	public virtual void SelectHalfItemNPC(int slot)
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

	public virtual void SelectHalfItem(int slot)
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

	public virtual void SelectItemNPC(int slot)
	{
		holdingItem = true;
		Item item = null;
		switch (slot)
		{
		case 11:
			GetComponent<AudioSource>().PlayOneShot(audioCrafted);
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
			GetComponent<AudioSource>().PlayOneShot(audioCrafted);
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
			GetComponent<AudioSource>().PlayOneShot(audioCrafted);
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
			GetComponent<AudioSource>().PlayOneShot(audioCrafted);
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

	public virtual void SelectItem(int slot)
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
			if (player.GetComponent<NetworkView>().isMine)
			{
				PlayerControllerN.helm = 0;
				num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
				num3 = PlayerControllerN.armor;
				num4 = PlayerControllerN.offhand;
				player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num2, num3, MenuScript.pRace, num4, MenuScript.pHat);
			}
			break;
		case 21:
			PlayerController.armor = 0;
			if (player.GetComponent<NetworkView>().isMine)
			{
				PlayerControllerN.armor = 0;
				num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
				num3 = PlayerControllerN.armor;
				num4 = PlayerControllerN.offhand;
				player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num2, num3, MenuScript.pRace, num4, MenuScript.pHat);
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
			if (player.GetComponent<NetworkView>().isMine)
			{
				PlayerControllerN.offhand = 0;
				num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
				num3 = PlayerControllerN.armor;
				num4 = PlayerControllerN.offhand;
				player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num2, num3, MenuScript.pRace, num4, MenuScript.pHat);
				inventoryQ[slot].text = string.Empty + inventory[slot].q;
			}
			for (num = 0; num < 4; num++)
			{
				if (tempGearStat[num] - inventory[slot].e[num] >= 0)
				{
					tempGearStat[num] -= inventory[slot].e[num];
				}
			}
			break;
		case 24:
		case 25:
			for (num = 0; num < 4; num++)
			{
				tempGearStat[num] -= inventory[slot].e[num];
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
		MAXMAG = MenuScript.playerStat[3] + tempPlayerStat[3] + tempLevelStat[3] + tempGearStat[3];
		DEX = MenuScript.playerStat[2] + tempPlayerStat[2] + tempLevelStat[2] + tempGearStat[2];
		UpdateCharacterWeapon();
	}

	public virtual Item EmptyItem()
	{
		return new Item(0, 0, new int[4], 0f, null);
	}

	public virtual void UpdateHoldingItem()
	{
		sSelected.GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + itemSelected.id);
		sSelected.SetActive(value: true);
		if (itemSelected.q > 1)
		{
			selectedQ.text = string.Empty + itemSelected.q;
		}
		else
		{
			selectedQ.text = string.Empty;
		}
	}

	public virtual void PlaceItemNPC(int slot, GameObject g)
	{
		if (slot >= 11)
		{
			return;
		}
		holdingItem = false;
		npcInventory[slot] = itemSelected;
		itemSelected = EmptyItem();
		sSelected.SetActive(value: false);
		if (npcInteract == 1)
		{
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
		else if (npcInteract == 3)
		{
			switch (slot)
			{
			case 0:
			case 1:
				HideCheck();
				break;
			case 2:
			case 3:
			case 4:
				CapCheck();
				break;
			case 5:
			case 6:
			case 7:
				LeatherCheck();
				break;
			}
			RefreshLeatherworker();
		}
		else if (npcInteract == 4)
		{
			switch (slot)
			{
			case 0:
			case 1:
				ClothCheck();
				break;
			case 2:
			case 3:
			case 4:
				HoodCheck();
				break;
			case 5:
			case 6:
			case 7:
				RobeCheck();
				break;
			}
			RefreshTailor();
		}
	}

	public virtual void BarCheck()
	{
		if (npcInventory[0].id != 0 && npcInventory[1].id != 0)
		{
			string text = npcInventory[0].id + "c" + npcInventory[1].id;
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

	public virtual void HideCheck()
	{
		if (npcInventory[0].id != 0 && npcInventory[1].id != 0)
		{
			string text = npcInventory[0].id + "c" + npcInventory[1].id;
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
			case "82c39":
				CraftShow(83, lowestQ, 11);
				break;
			case "82c51":
				CraftShow(84, lowestQ, 11);
				break;
			case "82c12":
				CraftShow(85, lowestQ, 11);
				break;
			case "82c13":
				CraftShow(86, lowestQ, 11);
				break;
			case "82c14":
				CraftShow(87, lowestQ, 11);
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

	public virtual void ClothCheck()
	{
		if (npcInventory[0].id != 0 && npcInventory[1].id != 0)
		{
			string text = npcInventory[0].id + "c" + npcInventory[1].id;
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
			case "94c39":
				CraftShow(88, lowestQ, 11);
				break;
			case "94c51":
				CraftShow(89, lowestQ, 11);
				break;
			case "94c12":
				CraftShow(90, lowestQ, 11);
				break;
			case "94c13":
				CraftShow(91, lowestQ, 11);
				break;
			case "94c14":
				CraftShow(92, lowestQ, 11);
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

	public virtual void CapCheck()
	{
		if (npcInventory[2].id != 0 && npcInventory[3].id != 0 && npcInventory[4].id != 0)
		{
			string text = npcInventory[2].id + "c" + npcInventory[3].id + "c" + npcInventory[4].id;
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
			case "83c83c83":
				CraftShow(705, 1, 12);
				break;
			case "84c84c84":
				CraftShow(706, 1, 12);
				break;
			case "85c85c85":
				CraftShow(707, 1, 12);
				break;
			case "86c86c86":
				CraftShow(708, 1, 12);
				break;
			case "87c87c87":
				CraftShow(709, 1, 12);
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

	public virtual void HoodCheck()
	{
		if (npcInventory[2].id != 0 && npcInventory[3].id != 0 && npcInventory[4].id != 0)
		{
			string text = npcInventory[2].id + "c" + npcInventory[3].id + "c" + npcInventory[4].id;
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
			case "88c88c88":
				CraftShow(710, 1, 12);
				break;
			case "89c89c89":
				CraftShow(711, 1, 12);
				break;
			case "90c90c90":
				CraftShow(712, 1, 12);
				break;
			case "91c91c91":
				CraftShow(713, 1, 12);
				break;
			case "92c92c92":
				CraftShow(714, 1, 12);
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

	public virtual void HelmCheck()
	{
		if (npcInventory[2].id != 0 && npcInventory[3].id != 0 && npcInventory[4].id != 0)
		{
			string text = npcInventory[2].id + "c" + npcInventory[3].id + "c" + npcInventory[4].id;
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

	public virtual void LeatherCheck()
	{
		if (npcInventory[5].id != 0 && npcInventory[6].id != 0 && npcInventory[7].id != 0)
		{
			string text = npcInventory[5].id + "c" + npcInventory[6].id + "c" + npcInventory[7].id;
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
			case "83c83c83":
				CraftShow(805, 1, 13);
				return;
			case "84c84c84":
				CraftShow(806, 1, 13);
				return;
			case "85c85c85":
				CraftShow(807, 1, 13);
				return;
			case "86c86c86":
				CraftShow(808, 1, 13);
				return;
			case "87c87c87":
				CraftShow(809, 1, 13);
				return;
			}
			npcInventory[13] = EmptyItem();
			RefreshBlacksmith();
			RefreshLeatherworker();
			RefreshTailor();
		}
		else
		{
			npcInventory[13] = EmptyItem();
			RefreshBlacksmith();
			RefreshLeatherworker();
			RefreshTailor();
		}
	}

	public virtual void RobeCheck()
	{
		if (npcInventory[5].id != 0 && npcInventory[6].id != 0 && npcInventory[7].id != 0)
		{
			string text = npcInventory[5].id + "c" + npcInventory[6].id + "c" + npcInventory[7].id;
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
			case "88c88c88":
				CraftShow(810, 1, 13);
				return;
			case "89c89c89":
				CraftShow(811, 1, 13);
				return;
			case "90c90c90":
				CraftShow(812, 1, 13);
				return;
			case "91c91c91":
				CraftShow(813, 1, 13);
				return;
			case "92c92c92":
				CraftShow(814, 1, 13);
				return;
			}
			npcInventory[13] = EmptyItem();
			RefreshBlacksmith();
			RefreshLeatherworker();
			RefreshTailor();
		}
		else
		{
			npcInventory[13] = EmptyItem();
			RefreshBlacksmith();
			RefreshLeatherworker();
			RefreshTailor();
		}
	}

	public virtual void ArmorCheck()
	{
		if (npcInventory[5].id != 0 && npcInventory[6].id != 0 && npcInventory[7].id != 0)
		{
			string text = npcInventory[5].id + "c" + npcInventory[6].id + "c" + npcInventory[7].id;
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

	public virtual void ShieldCheck()
	{
		if (npcInventory[8].id != 0 && npcInventory[9].id != 0 && npcInventory[10].id != 0)
		{
			string text = npcInventory[8].id + "c" + npcInventory[9].id + "c" + npcInventory[10].id;
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

	public virtual void PlaceItem(int slot, GameObject g)
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
				if (itemSelected.id >= 700 && itemSelected.id < 800)
				{
					holdingItem = false;
					inventory[slot] = itemSelected;
					itemSelected = EmptyItem();
					sSelected.SetActive(value: false);
					PlayerController.helm = inventory[slot].id;
					if (player.GetComponent<NetworkView>().isMine)
					{
						PlayerControllerN.helm = inventory[slot].id;
					}
					for (num = 0; num < 4; num++)
					{
						tempGearStat[num] += inventory[slot].e[num];
					}
					if (player.GetComponent<NetworkView>().isMine)
					{
						num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
						num3 = PlayerControllerN.armor;
						num4 = PlayerControllerN.offhand;
						player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num2, num3, MenuScript.pRace, num4, MenuScript.pHat);
					}
					RefreshInventory();
				}
				break;
			case 21:
				if (itemSelected.id >= 800 && itemSelected.id < 900)
				{
					holdingItem = false;
					inventory[slot] = itemSelected;
					PlayerController.armor = itemSelected.id;
					if (player.GetComponent<NetworkView>().isMine)
					{
						PlayerControllerN.armor = inventory[slot].id;
						num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
						num3 = PlayerControllerN.armor;
						num4 = PlayerControllerN.offhand;
						player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num2, num3, MenuScript.pRace, num4, MenuScript.pHat);
					}
					for (num = 0; num < 4; num++)
					{
						tempGearStat[num] += inventory[slot].e[num];
					}
					itemSelected = EmptyItem();
					sSelected.SetActive(value: false);
					RefreshInventory();
				}
				break;
			case 22:
				if (itemSelected.id >= 900 && itemSelected.id < 950)
				{
					holdingItem = false;
					inventory[slot] = itemSelected;
					for (num = 0; num < 4; num++)
					{
						tempGearStat[num] += inventory[slot].e[num];
					}
					PlayerController.offhand = itemSelected.id;
					if (player.GetComponent<NetworkView>().isMine)
					{
						PlayerControllerN.offhand = inventory[slot].id;
						num2 = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
						num3 = PlayerControllerN.armor;
						num4 = PlayerControllerN.offhand;
						player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num2, num3, MenuScript.pRace, num4, MenuScript.pHat);
					}
					itemSelected = EmptyItem();
					sSelected.SetActive(value: false);
					RefreshInventory();
				}
				break;
			case 23:
				if (itemSelected.id >= 52 && itemSelected.id <= 56)
				{
					holdingItem = false;
					inventory[slot] = itemSelected;
					itemSelected = EmptyItem();
					inventoryQ[slot].text = string.Empty + inventory[slot].q;
					sSelected.SetActive(value: false);
					RefreshInventory();
				}
				break;
			case 24:
				if (itemSelected.id >= 950 && itemSelected.id < 958)
				{
					holdingItem = false;
					inventory[slot] = itemSelected;
					itemSelected = EmptyItem();
					sSelected.SetActive(value: false);
					for (num = 0; num < 4; num++)
					{
						tempGearStat[num] += inventory[slot].e[num];
					}
					RefreshInventory();
				}
				break;
			case 25:
				if (itemSelected.id >= 950 && itemSelected.id < 958)
				{
					holdingItem = false;
					inventory[slot] = itemSelected;
					itemSelected = EmptyItem();
					sSelected.SetActive(value: false);
					for (num = 0; num < 4; num++)
					{
						tempGearStat[num] += inventory[slot].e[num];
					}
					RefreshInventory();
				}
				break;
			case 100:
				if (itemSelected.id == 4 || itemSelected.id == 5 || itemSelected.id == 6)
				{
					holdingItem = false;
					npcInventory[int.Parse(g.name)] = itemSelected;
					itemSelected = EmptyItem();
					sSelected.SetActive(value: false);
					RefreshBlacksmith();
				}
				break;
			default:
				holdingItem = false;
				inventory[slot] = itemSelected;
				itemSelected = EmptyItem();
				sSelected.SetActive(value: false);
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
		}
		UpdateCharacterWeapon();
		MAXMAG = MenuScript.playerStat[3] + tempPlayerStat[3] + tempLevelStat[3] + tempGearStat[3];
		LoadMana();
		DEX = MenuScript.playerStat[2] + tempPlayerStat[2] + tempLevelStat[2] + tempGearStat[2];
	}

	public virtual void RefreshTailor()
	{
		int num = default(int);
		for (num = 0; num < 15; num++)
		{
			if (npcInventory[num].id != 0)
			{
				bSmithObject[num].GetComponent<Renderer>().enabled = true;
				bSmithObject[num].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + npcInventory[num].id);
				if (npcInventory[num].q > 1 && npcInventory[num].id < 500)
				{
					bSmithText[num].text = string.Empty + npcInventory[num].q;
				}
				else
				{
					bSmithText[num].text = string.Empty;
				}
			}
			else
			{
				bSmithObject[num].GetComponent<Renderer>().enabled = false;
				bSmithText[num].text = string.Empty;
			}
		}
		bSmithObject[8].SetActive(value: false);
		bSmithObject[9].SetActive(value: false);
		bSmithObject[10].SetActive(value: false);
		bSmithObject[14].SetActive(value: false);
	}

	public virtual void RefreshLeatherworker()
	{
		int num = default(int);
		for (num = 0; num < 15; num++)
		{
			if (npcInventory[num].id != 0)
			{
				bSmithObject[num].GetComponent<Renderer>().enabled = true;
				bSmithObject[num].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + npcInventory[num].id);
				if (npcInventory[num].q > 1 && npcInventory[num].id < 500)
				{
					bSmithText[num].text = string.Empty + npcInventory[num].q;
				}
				else
				{
					bSmithText[num].text = string.Empty;
				}
			}
			else
			{
				bSmithObject[num].GetComponent<Renderer>().enabled = false;
				bSmithText[num].text = string.Empty;
			}
		}
		bSmithObject[8].SetActive(value: false);
		bSmithObject[9].SetActive(value: false);
		bSmithObject[10].SetActive(value: false);
		bSmithObject[14].SetActive(value: false);
	}

	public virtual void RefreshBlacksmith()
	{
		int num = default(int);
		for (num = 0; num < 15; num++)
		{
			if (npcInventory[num].id != 0)
			{
				bSmithObject[num].GetComponent<Renderer>().enabled = true;
				bSmithObject[num].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + npcInventory[num].id);
				if (npcInventory[num].q > 1 && npcInventory[num].id < 500)
				{
					bSmithText[num].text = string.Empty + npcInventory[num].q;
				}
				else
				{
					bSmithText[num].text = string.Empty;
				}
			}
			else
			{
				bSmithObject[num].GetComponent<Renderer>().enabled = false;
				bSmithText[num].text = string.Empty;
			}
		}
		bSmithObject[8].SetActive(value: true);
		bSmithObject[9].SetActive(value: true);
		bSmithObject[10].SetActive(value: true);
		bSmithObject[14].SetActive(value: true);
	}

	public virtual void CraftShow(int s0, int q, int i)
	{
		npcInventory[i] = new Item(s0, q, new int[4], 0f, null);
		RefreshBlacksmith();
	}

	public virtual void PlaceOneItemNPC(int slot, GameObject g)
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
			sSelected.SetActive(value: false);
		}
		UpdateHoldingItem();
		if (npcInteract == 1)
		{
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
		else if (npcInteract == 3)
		{
			switch (slot)
			{
			case 0:
			case 1:
				HideCheck();
				break;
			case 2:
			case 3:
			case 4:
				CapCheck();
				break;
			case 5:
			case 6:
			case 7:
				LeatherCheck();
				break;
			}
			RefreshLeatherworker();
		}
		else if (npcInteract == 4)
		{
			switch (slot)
			{
			case 0:
			case 1:
				ClothCheck();
				break;
			case 2:
			case 3:
			case 4:
				HoodCheck();
				break;
			case 5:
			case 6:
			case 7:
				RobeCheck();
				break;
			}
			RefreshTailor();
		}
	}

	public virtual void PlaceOneItem(int slot, GameObject g)
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
			sSelected.SetActive(value: false);
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

	public virtual void AddOneItemHoldingNPC(int slot)
	{
		if (npcInventory[slot].id >= 500)
		{
			return;
		}
		switch (slot)
		{
		case 11:
			GetComponent<AudioSource>().PlayOneShot(audioCrafted);
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
			GetComponent<AudioSource>().PlayOneShot(audioCrafted);
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
			GetComponent<AudioSource>().PlayOneShot(audioCrafted);
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
			GetComponent<AudioSource>().PlayOneShot(audioCrafted);
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
		GetComponent<AudioSource>().PlayOneShot(audioCrafted);
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

	public virtual void AddOneItemHolding(int slot)
	{
		itemSelected.q++;
	}

	public virtual void AddOneItemNPC(int slot)
	{
		if (npcInventory[slot].q + 1 > 99 || npcInventory[slot].id >= 500)
		{
			return;
		}
		npcInventory[slot].q = npcInventory[slot].q + 1;
		itemSelected.q--;
		if (itemSelected.q == 0)
		{
			holdingItem = false;
			itemSelected = EmptyItem();
			sSelected.SetActive(value: false);
		}
		RefreshBlacksmith();
		if (npcInteract == 1)
		{
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
		else if (npcInteract == 3)
		{
			switch (slot)
			{
			case 0:
			case 1:
				HideCheck();
				break;
			case 2:
			case 3:
			case 4:
				CapCheck();
				break;
			case 5:
			case 6:
			case 7:
				LeatherCheck();
				break;
			}
			RefreshLeatherworker();
		}
		else if (npcInteract == 4)
		{
			switch (slot)
			{
			case 0:
			case 1:
				ClothCheck();
				break;
			case 2:
			case 3:
			case 4:
				HoodCheck();
				break;
			case 5:
			case 6:
			case 7:
				RobeCheck();
				break;
			}
			RefreshTailor();
		}
		UpdateHoldingItem();
	}

	public virtual void AddOneItem(int slot)
	{
		if ((inventory[slot].q + 1 <= 99 && inventory[slot].id < 500) || (inventory[slot].q + 1 <= 999 && inventory[slot].id >= 52 && inventory[slot].id <= 56))
		{
			inventory[slot].q = inventory[slot].q + 1;
			itemSelected.q--;
			if (itemSelected.q == 0)
			{
				holdingItem = false;
				itemSelected = EmptyItem();
				sSelected.SetActive(value: false);
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

	public virtual void SwapItemNPC(int slot)
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

	public virtual void SwapItem(int slot)
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
			if (player.GetComponent<NetworkView>().isMine)
			{
				PlayerControllerN.helm = inventory[slot].id;
				num = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
				num2 = PlayerControllerN.armor;
				num3 = PlayerControllerN.offhand;
				player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num, num2, MenuScript.pRace, num3, MenuScript.pHat);
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
			if (player.GetComponent<NetworkView>().isMine)
			{
				PlayerControllerN.armor = inventory[slot].id;
				num = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
				num2 = PlayerControllerN.armor;
				num3 = PlayerControllerN.offhand;
				player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num, num2, MenuScript.pRace, num3, MenuScript.pHat);
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
			if (player.GetComponent<NetworkView>().isMine)
			{
				PlayerControllerN.offhand = inventory[slot].id;
				num = ((PlayerControllerN.helm <= 0) ? MenuScript.pVariant : PlayerControllerN.helm);
				num2 = PlayerControllerN.armor;
				num3 = PlayerControllerN.offhand;
				player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, num, num2, MenuScript.pRace, num3, MenuScript.pHat);
			}
			break;
		case 24:
		case 25:
			for (num4 = 0; num4 < 4; num4++)
			{
				tempGearStat[num4] -= itemSelected.e[num4];
			}
			for (num4 = 0; num4 < 4; num4++)
			{
				tempGearStat[num4] += inventory[slot].e[num4];
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

	public virtual void CombineItemNPC(int slot)
	{
		if (npcInventory[slot].id >= 500)
		{
			return;
		}
		if (npcInventory[slot].q + itemSelected.q <= 99)
		{
			npcInventory[slot].q = npcInventory[slot].q + itemSelected.q;
			holdingItem = false;
			itemSelected = EmptyItem();
			sSelected.SetActive(value: false);
		}
		else
		{
			int num = 99 - npcInventory[slot].q;
			itemSelected.q -= num;
			npcInventory[slot].q = 99;
		}
		if (npcInteract == 1)
		{
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
		else if (npcInteract == 3)
		{
			switch (slot)
			{
			case 0:
			case 1:
				HideCheck();
				break;
			case 2:
			case 3:
			case 4:
				CapCheck();
				break;
			case 5:
			case 6:
			case 7:
				LeatherCheck();
				break;
			}
			RefreshLeatherworker();
		}
		else if (npcInteract == 4)
		{
			switch (slot)
			{
			case 0:
			case 1:
				ClothCheck();
				break;
			case 2:
			case 3:
			case 4:
				HoodCheck();
				break;
			case 5:
			case 6:
			case 7:
				RobeCheck();
				break;
			}
			RefreshTailor();
		}
		RefreshBlacksmith();
	}

	public virtual void CombineItem(int slot)
	{
		if (inventory[slot].q + itemSelected.q <= 99 || (inventory[slot].q + itemSelected.q <= 999 && itemSelected.id >= 52 && itemSelected.id <= 56))
		{
			inventory[slot].q = inventory[slot].q + itemSelected.q;
			holdingItem = false;
			itemSelected = EmptyItem();
			sSelected.SetActive(value: false);
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

	public virtual void DeleteInventory()
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

	public virtual void LoadInventory()
	{
		int num = default(int);
		DeleteInventory();
		for (num = 0; num < 31; num++)
		{
			inventory[num].id = PlayerPrefs.GetInt("id" + num);
			inventory[num].q = PlayerPrefs.GetInt("q" + num);
			inventory[num].d = PlayerPrefs.GetInt("d" + num);
		}
	}

	public virtual void SaveInventory()
	{
		int num = default(int);
		for (num = 0; num < 31; num++)
		{
			if (inventory[num] != null)
			{
				PlayerPrefs.SetInt("id" + num, inventory[num].id);
				PlayerPrefs.SetInt("q" + num, inventory[num].q);
				PlayerPrefs.SetInt("d" + num, inventory[num].d);
			}
		}
	}

	public virtual void RefreshPlayerStats()
	{
		int num = default(int);
		int[] array = new int[4];
		for (num = 0; num < 4; num++)
		{
			array[num] = tempPlayerStat[num] + tempGearStat[num] + MenuScript.playerStat[num] + tempLevelStat[num];
		}
		array[1] += drumATK;
		array[2] += drumDEX;
		array[3] += drumMAG;
		for (num = 0; num < 4; num++)
		{
			txtPlayerStat[num].text = GetStatName(num) + ": " + array[num];
		}
		if (array[0] > 0)
		{
			MAXHP = array[0];
		}
		else
		{
			MAXHP = 1;
		}
		MAXMAG = array[3];
		LoadHearts();
		LoadMana();
	}

	public virtual string GetStatName(int a)
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

	public virtual int AddItem(Item item)
	{
		int num = default(int);
		GameObject gameObject = null;
		int num2 = default(int);
		int result;
		if (item.id < 500)
		{
			if (item.id >= 52 && item.id <= 59 && item.id == inventory[23].id)
			{
				inventory[23].q = inventory[23].q + item.q;
				gameObject = (GameObject)UnityEngine.Object.Instantiate(txtItem, player.transform.position, Quaternion.identity);
				gameObject.SendMessage("ST", GetItemName(item.id));
				if (inventoryOpen)
				{
					RefreshInventory();
				}
				result = 1;
				goto IL_034e;
			}
			num = 0;
			while (num < 20)
			{
				if ((inventory[num].id != item.id || inventory[num].q >= 99) && (inventory[num].id != item.id || inventory[num].id < 52 || inventory[num].id > 56 || inventory[num].q >= 999))
				{
					num++;
					continue;
				}
				goto IL_014b;
			}
			num = 0;
			while (num < 20)
			{
				if (inventory[num].id != 0)
				{
					num++;
					continue;
				}
				goto IL_01ee;
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
				goto IL_029b;
			}
		}
		result = 0;
		goto IL_034e;
		IL_01ee:
		inventory[num].id = item.id;
		inventory[num].q = item.q;
		num2 = 1;
		gameObject = (GameObject)UnityEngine.Object.Instantiate(txtItem, player.transform.position, Quaternion.identity);
		gameObject.SendMessage("ST", GetItemName(item.id));
		RefreshActionBar();
		if (inventoryOpen)
		{
			RefreshInventory();
		}
		UpdateCharacterWeapon();
		result = 1;
		goto IL_034e;
		IL_014b:
		inventory[num].q = inventory[num].q + item.q;
		num2 = 1;
		gameObject = (GameObject)UnityEngine.Object.Instantiate(txtItem, player.transform.position, Quaternion.identity);
		gameObject.SendMessage("ST", GetItemName(item.id));
		RefreshActionBar();
		if (inventoryOpen)
		{
			RefreshInventory();
		}
		UpdateCharacterWeapon();
		result = 1;
		goto IL_034e;
		IL_034e:
		return result;
		IL_029b:
		inventory[num].id = item.id;
		inventory[num].q = item.q;
		inventory[num].e = item.e;
		inventory[num].d = item.d;
		gameObject = (GameObject)UnityEngine.Object.Instantiate(txtItem, player.transform.position, Quaternion.identity);
		gameObject.SendMessage("ST", GetGearName(item.id));
		RefreshActionBar();
		if (inventoryOpen)
		{
			RefreshInventory();
		}
		UpdateCharacterWeapon();
		result = 1;
		goto IL_034e;
	}

	public virtual void SetInfoText(int slot, int id)
	{
		infoObject.SetActive(value: true);
		if (id >= 500)
		{
			gearStats.SetActive(value: true);
			txtDesc.gameObject.SetActive(value: false);
			txtInfoName[0].text = GetGearName(id);
			txtDur.text = "Durability: " + inventory[slot].d + "/" + GetMaxDurability(id);
			if (inventory[slot].tier == 3)
			{
				txtInfoName[0].gameObject.GetComponent<Renderer>().material.color = Color.magenta;
			}
			else if (inventory[slot].tier == 2)
			{
				txtInfoName[0].gameObject.GetComponent<Renderer>().material.color = Color.yellow;
			}
			else if (inventory[slot].tier == 1)
			{
				txtInfoName[0].gameObject.GetComponent<Renderer>().material.color = Color.cyan;
			}
			else
			{
				txtInfoName[0].gameObject.GetComponent<Renderer>().material.color = Color.white;
			}
			int num = default(int);
			for (num = 0; num < 4; num++)
			{
				if (inventory[slot].e[num] > 0)
				{
					txtGearStat[num].text = GetStatName(num) + "+ " + inventory[slot].e[num];
					txtGearStat[num].gameObject.GetComponent<Renderer>().material.color = Color.green;
				}
				else if (inventory[slot].e[num] < 0)
				{
					txtGearStat[num].text = GetStatName(num) + string.Empty + inventory[slot].e[num];
					txtGearStat[num].gameObject.GetComponent<Renderer>().material.color = Color.red;
				}
				else
				{
					txtGearStat[num].text = GetStatName(num) + "+ " + 0;
					txtGearStat[num].gameObject.GetComponent<Renderer>().material.color = Color.white;
				}
			}
		}
		else
		{
			gearStats.SetActive(value: false);
			txtDesc.gameObject.SetActive(value: true);
			txtDesc.text = GetItemDesc(id);
			txtInfoName[0].text = GetItemName(id);
			txtInfoName[0].gameObject.GetComponent<Renderer>().material.color = Color.white;
		}
		txtInfoName[1].text = txtInfoName[0].text;
	}

	public virtual string GetItemDesc(int id)
	{
		string text = null;
		return id switch
		{
			1 => "A basic piece of\nwood used to\nmake planks.", 
			9 => "A vital ingredient\nfor making potions.", 
			7 => "Restores 1 hunger.", 
			8 => "Restores 3 hunger.\n50% chance to heal.", 
			21 => "Restores 1 hunger.", 
			22 => "Restores 3 hunger.\n50% chance to heal.", 
			15 => "Heals 2 HP.", 
			42 => "Heals 5 HP.", 
			46 => "increases HP and\nMAG by 3.", 
			95 => "Cannot be used in\nTown.", 
			_ => string.Empty, 
		};
	}

	public virtual void SelectSlot(int a)
	{
		if (!@using && !usingItem && !usingPot && !ATKING)
		{
			curActiveSlot = a;
			UpdateCharacterWeapon();
			select.transform.localPosition = GetSelectPos(curActiveSlot);
		}
	}

	public virtual void Scroll(int dir)
	{
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
		RefreshPlayerStats();
		select.transform.localPosition = GetSelectPos(curActiveSlot);
	}

	public virtual Vector3 GetSelectPos(object slot)
	{
		Vector3 result = default(Vector3);
		if (RuntimeServices.EqualityOperator(slot, 0))
		{
			return new Vector3(-18.75f, 11.05f, 8.75f);
		}
		if (RuntimeServices.EqualityOperator(slot, 1))
		{
			return new Vector3(-16.85f, 11.05f, 8.75f);
		}
		if (RuntimeServices.EqualityOperator(slot, 2))
		{
			return new Vector3(-15f, 11.05f, 8.75f);
		}
		if (RuntimeServices.EqualityOperator(slot, 3))
		{
			return new Vector3(-13.15f, 11.05f, 8.75f);
		}
		if (RuntimeServices.EqualityOperator(slot, 4))
		{
			return new Vector3(-11.25f, 11.05f, 8.75f);
		}
		return result;
	}

	public virtual void Close()
	{
		menuOpen = false;
		menuExit.SetActive(value: false);
		shade.SetActive(value: false);
	}

	public virtual void EnterIP()
	{
		enteringIP = true;
		txtIP[0].text = string.Empty;
		txtIP[1].text = string.Empty;
	}

	public virtual void Resume()
	{
		if (Network.connections.Length == 0)
		{
			Time.timeScale = 1f;
		}
		menuExit.SetActive(value: false);
		menuOpen = false;
	}

	public virtual void SetTextInfo()
	{
		txtName.text = string.Empty + MenuScript.curName;
		txtLevel.text = "Lv." + playerLevel;
		txtBarInfo[0].text = HP + "/" + MAXHP;
		txtBarInfo[1].text = MAG + "/" + MAXMAG;
		txtBarInfo[3].text = stamina + "/" + maxStamina;
	}

	public virtual void OpenInventory()
	{
		if (!inventoryOpen && !menuOpen)
		{
			if (!@using)
			{
				RefreshPlayerStats();
				RefreshInventory();
				SetTextInfo();
				menuInventory.SetActive(value: true);
				GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/invOpen", typeof(AudioClip)));
				menuEquipped.SetActive(value: true);
				inventoryOpen = true;
			}
			return;
		}
		menuCheat.SetActive(value: false);
		cheating = false;
		CloseSkillDesc();
		if (holdingItem)
		{
			DropItem();
		}
		if (interacting)
		{
			menuBlacksmith.SetActive(value: false);
			menuHoarder.SetActive(value: false);
			int num = default(int);
			Item item = null;
			int[] array = null;
			for (num = 0; num < 15; num++)
			{
				if (npcInventory[num].id != 0 && num < 11)
				{
					item = new Item(npcInventory[num].id, npcInventory[num].q, npcInventory[num].e, npcInventory[num].d, null);
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), player.transform.position, Quaternion.identity);
					array = new int[7]
					{
						item.id,
						item.q,
						item.e[0],
						item.e[1],
						item.e[2],
						item.e[3],
						item.d
					};
					gameObject.SendMessage("InitL", array);
				}
				npcInventory[num] = EmptyItem();
			}
			interacting = false;
		}
		inventoryOpen = false;
		ResetCraft();
		infoObject.SetActive(value: false);
		menuInventory.SetActive(value: false);
		GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/invClose", typeof(AudioClip)));
		menuEquipped.SetActive(value: false);
	}

	public virtual void RefreshActionBar()
	{
		int num = 0;
		for (num = 0; num < 5; num++)
		{
			if (inventory[num].id != 0)
			{
				inventorySlot[num].GetComponent<Renderer>().enabled = true;
				inventorySlot[num].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + inventory[num].id);
				if (inventory[num].q > 1)
				{
					inventoryQ[num].text = string.Empty + inventory[num].q;
				}
				else
				{
					inventoryQ[num].text = string.Empty;
				}
			}
			else
			{
				inventorySlot[num].GetComponent<Renderer>().enabled = false;
				inventoryQ[num].text = string.Empty;
			}
		}
	}

	public virtual void RefreshInventory()
	{
		int num = 0;
		for (num = 5; num < 31; num++)
		{
			if (inventory[num].id != 0)
			{
				inventorySlot[num].GetComponent<Renderer>().enabled = true;
				inventorySlot[num].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + inventory[num].id);
				if (inventory[num].q > 1)
				{
					if (num < 20 || num > 25)
					{
						inventoryQ[num].text = string.Empty + inventory[num].q;
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
						inventoryQ[num].text = string.Empty + inventory[num].q;
					}
					else
					{
						inventoryQ[num].text = string.Empty;
					}
				}
			}
			else
			{
				inventorySlot[num].GetComponent<Renderer>().enabled = false;
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

	public virtual IEnumerator GenerateLevel()
	{
		return new _0024GenerateLevel_00241760(this).GetEnumerator();
	}

	public virtual void SetMusic(int a)
	{
		musicBox.SendMessage("SetMusic", a);
	}

	public virtual void LoadMana()
	{
		txtBarInfo[1].text = MAG + "/" + MAXMAG;
		float x = (float)MAXMAG * 0.2f;
		Vector3 localScale = barBack[1].transform.localScale;
		float num = (localScale.x = x);
		Vector3 vector2 = (barBack[1].transform.localScale = localScale);
		float x2 = (float)MAG * 0.2f;
		Vector3 localScale2 = barFill[1].transform.localScale;
		float num2 = (localScale2.x = x2);
		Vector3 vector4 = (barFill[1].transform.localScale = localScale2);
	}

	public virtual void LoadHearts()
	{
		if (HP < 0)
		{
			HP = 0;
		}
		if (HP > MAXHP)
		{
			HP = MAXHP;
		}
		if ((bool)txtBarInfo[0])
		{
			txtBarInfo[0].text = HP + "/" + MAXHP;
		}
		if ((bool)barBack[0] && (bool)barFill[0])
		{
			float x = (float)MAXHP * 0.2f;
			Vector3 localScale = barBack[0].transform.localScale;
			float num = (localScale.x = x);
			Vector3 vector2 = (barBack[0].transform.localScale = localScale);
			float x2 = (float)HP * 0.2f;
			Vector3 localScale2 = barFill[0].transform.localScale;
			float num2 = (localScale2.x = x2);
			Vector3 vector4 = (barFill[0].transform.localScale = localScale2);
		}
	}

	public virtual IEnumerator Die()
	{
		return new _0024Die_00241771(this).GetEnumerator();
	}

	public virtual void ShowTimer()
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
		if ((bool)txtTimer)
		{
			txtTimer.text = "Total Time: " + num3 + ":" + num2 + ":" + num;
		}
		if (num3 <= 1 && win)
		{
			MenuScript.canUnlockRace[6] = 1;
		}
	}

	public virtual IEnumerator ShowStats()
	{
		return new _0024ShowStats_00241776(this).GetEnumerator();
	}

	public virtual IEnumerator ShowEXP()
	{
		return new _0024ShowEXP_00241780(this).GetEnumerator();
	}

	public virtual int GetCurEXP(int pLevel)
	{
		int num = accountEXP;
		if (pLevel > 1)
		{
			num -= GetTotalEXP(pLevel);
		}
		return num;
	}

	public virtual int GetLevelCap(int pLevel)
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

	public virtual int GetTotalEXP(int lvl)
	{
		int num = default(int);
		int num2 = default(int);
		for (num = 0; num < lvl; num++)
		{
			num2 += GetLevelCap(num);
		}
		return num2;
	}

	public virtual int GetPlayerLevel()
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

	public virtual IEnumerator StatShow(int a)
	{
		return new _0024StatShow_00241787(a, this).GetEnumerator();
	}

	public virtual string GetStatsName(int a)
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
			10 => "Bosses Defeated", 
			11 => "Items Bought", 
			_ => string.Empty, 
		};
	}

	public virtual void OnApplicationQuit()
	{
		changingScene = false;
		DeleteCharacter();
		SaveInventory();
	}

	public virtual void DeleteCharacter()
	{
		int num = 0;
		isInitialized = false;
		DeleteInventory();
		PlayerController.helm = 0;
		PlayerControllerN.helm = 0;
		curBiome = 0;
		if ((bool)player)
		{
			player.SendMessage("UpdateHead", MenuScript.pVariant, SendMessageOptions.DontRequireReceiver);
		}
		PlayerController.armor = 0;
		PlayerControllerN.armor = 0;
		if ((bool)player)
		{
			player.SendMessage("UpdateBody", MenuScript.pBody, SendMessageOptions.DontRequireReceiver);
		}
		PlayerController.offhand = 0;
		PlayerControllerN.offhand = 0;
		if ((bool)player)
		{
			player.SendMessage("UpdateOffhand", MenuScript.pBody, SendMessageOptions.DontRequireReceiver);
		}
		for (num = 0; num < 31; num++)
		{
			PlayerPrefs.SetInt("id" + num, 0);
			PlayerPrefs.SetInt("q" + num, 0);
			PlayerPrefs.SetInt("e" + num, 0);
			PlayerPrefs.SetInt("d" + num, 0);
			if (num < 20)
			{
				PlayerPrefs.SetInt("e" + num, 0);
			}
		}
		PlayerPrefs.SetInt("cLevel", 0);
	}

	public virtual void UpdateCharacterWeapon()
	{
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
			player.GetComponent<NetworkView>().RPC("uI", RPCMode.All, inventory[curActiveSlot].id);
		}
		else
		{
			weapon.GetComponent<Renderer>().material = (Material)Resources.Load("iE/i" + inventory[curActiveSlot].id);
		}
		SphereCollider sphereCollider = (SphereCollider)aSphere.GetComponent(typeof(SphereCollider));
		if (id >= 500 && id < 560)
		{
			atkAnim = "a1";
			float x = 0.4f;
			Vector3 center = sphereCollider.center;
			float num3 = (center.x = x);
			Vector3 vector2 = (sphereCollider.center = center);
			sphereCollider.radius = 0.6f;
			atkWait = 0.45f;
		}
		else if (id >= 560 && id < 580)
		{
			atkAnim = "a2";
			float x2 = 0.7f;
			Vector3 center2 = sphereCollider.center;
			float num4 = (center2.x = x2);
			Vector3 vector4 = (sphereCollider.center = center2);
			sphereCollider.radius = 1f;
			atkWait = 1f;
		}
		else if (id >= 600 && id < 650)
		{
			atkAnim = "a1";
			float x3 = 0.4f;
			Vector3 center3 = sphereCollider.center;
			float num5 = (center3.x = x3);
			Vector3 vector6 = (sphereCollider.center = center3);
			sphereCollider.radius = 0.6f;
			atkWait = 0.45f;
		}
		else
		{
			float x4 = 0.1f;
			Vector3 center4 = sphereCollider.center;
			float num6 = (center4.x = x4);
			Vector3 vector8 = (sphereCollider.center = center4);
			sphereCollider.radius = 0.6f;
			atkAnim = "a1";
			atkWait = 0.45f;
		}
		if (inventoryOpen)
		{
			RefreshPlayerStats();
		}
	}

	public virtual string GetSkillName(int a)
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

	public virtual string GetSkillDesc(int id)
	{
		string text = null;
		return id switch
		{
			1 => "Hurl a giant axe that\npasses through enemies.\nDeals damage based on\nATK/2.", 
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
			12 => "Next shot fired will\nshoot 3 arrows.\nWith double damage.\nConsumes 3 arrows.", 
			13 => "Perform an extra jump\nwhile summoning a badass\narrow. Based on DEX.", 
			14 => "Summons wisp at cursor\nlocation. Arrows passing\nthrough will deal\n2x damage.", 
			15 => "Summon a wolf that runs\naround and kills shit.", 
			_ => "null", 
		};
	}

	public virtual string GetEnchantmentName(int id)
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

	public virtual string GetStatBonus(int id)
	{
		string text = null;
		return id switch
		{
			500 => "ATK+1", 
			503 => "ATK+2", 
			_ => string.Empty, 
		};
	}

	public virtual float GetMaxDurability(int id)
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
			565 => 65f, 
			_ => id switch
			{
				560 => 100f, 
				567 => 50f, 
				568 => 180f, 
				569 => 180f, 
				570 => 180f, 
				600 => 50f, 
				601 => 50f, 
				602 => 50f, 
				603 => 300f, 
				_ => 65f, 
			}, 
		};
	}

	public virtual int[] GetGearStats(int id)
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
			519 => new int[4] { 0, 18, 0, 0 }, 
			520 => new int[4] { 5, 27, 5, 5 }, 
			521 => new int[4] { 2, 30, 2, 2 }, 
			530 => new int[4] { 0, 0, 6, 0 }, 
			531 => new int[4] { 2, 11, 0, 0 }, 
			532 => new int[4] { 2, 11, 0, 0 }, 
			533 => new int[4] { 5, 30, 2, 2 }, 
			534 => new int[4] { 0, 75, 0, 0 }, 
			535 => new int[4] { 0, 0, 15, 15 }, 
			536 => new int[4] { 0, 0, 3, 0 }, 
			560 => new int[4] { 0, 15, 0, 0 }, 
			561 => new int[4] { 0, 30, 0, 0 }, 
			562 => new int[4] { 0, 48, 0, 0 }, 
			563 => new int[4] { 0, 8, 0, 0 }, 
			565 => new int[4] { 0, 55, 0, 0 }, 
			566 => new int[4] { -3, 100, 0, 0 }, 
			567 => new int[4] { 0, 35, 0, 0 }, 
			568 => new int[4] { 0, 95, 0, 10 }, 
			569 => new int[4] { 0, 95, 0, 10 }, 
			570 => new int[4] { 0, 95, 0, 10 }, 
			700 => new int[4] { 2, 4, 0, 0 }, 
			701 => new int[4] { 3, 6, 0, 0 }, 
			702 => new int[4] { 4, 9, 0, 0 }, 
			703 => new int[4] { 1, 2, 0, 0 }, 
			704 => new int[4] { 1, 2, 0, 0 }, 
			705 => new int[4] { 1, 0, 2, 0 }, 
			706 => new int[4] { 1, 0, 2, 0 }, 
			707 => new int[4] { 2, 0, 4, 0 }, 
			708 => new int[4] { 3, 0, 6, 0 }, 
			709 => new int[4] { 4, 0, 9, 0 }, 
			710 => new int[4] { 1, 0, 0, 2 }, 
			711 => new int[4] { 1, 0, 0, 2 }, 
			712 => new int[4] { 2, 0, 0, 4 }, 
			713 => new int[4] { 3, 0, 0, 6 }, 
			714 => new int[4] { 4, 0, 0, 9 }, 
			800 => new int[4] { 2, 4, 0, 0 }, 
			801 => new int[4] { 3, 6, 0, 0 }, 
			802 => new int[4] { 4, 9, 0, 0 }, 
			803 => new int[4] { 1, 2, 0, 0 }, 
			804 => new int[4] { 1, 2, 0, 0 }, 
			805 => new int[4] { 1, 0, 2, 0 }, 
			806 => new int[4] { 1, 0, 2, 0 }, 
			807 => new int[4] { 2, 0, 4, 0 }, 
			808 => new int[4] { 3, 0, 6, 0 }, 
			809 => new int[4] { 4, 0, 9, 0 }, 
			810 => new int[4] { 1, 0, 0, 2 }, 
			811 => new int[4] { 1, 0, 0, 2 }, 
			812 => new int[4] { 2, 0, 0, 4 }, 
			813 => new int[4] { 3, 0, 0, 6 }, 
			814 => new int[4] { 4, 0, 0, 9 }, 
			900 => new int[4] { 2, 0, 0, 0 }, 
			901 => new int[4] { 3, 0, 0, 0 }, 
			902 => new int[4] { 4, 0, 0, 0 }, 
			903 => new int[4] { 1, 0, 0, 0 }, 
			904 => new int[4] { 1, 0, 0, 0 }, 
			905 => new int[4] { 5, 2, 2, 2 }, 
			906 => new int[4] { 5, 2, 0, 5 }, 
			907 => new int[4] { 3, 5, 5, 0 }, 
			950 => new int[4] { 0, 5, 0, 0 }, 
			951 => new int[4] { 0, 0, 0, 5 }, 
			952 => new int[4] { 0, 0, 5, 0 }, 
			953 => new int[4] { 5, 0, 0, 0 }, 
			954 => new int[4] { -2, 8, 0, 0 }, 
			955 => new int[4] { -2, 0, 0, 8 }, 
			956 => new int[4] { -2, 0, 8, 0 }, 
			957 => new int[4] { 2, 2, 2, 2 }, 
			_ => new int[4], 
		};
	}

	public virtual void Options()
	{
	}

	public virtual void OnDisconnectedFromServer()
	{
		PlayerPrefs.SetInt("gChests", MenuScript.goldChests);
		isInitialized = false;
		isReturning = false;
		isInstance = false;
		changingScene = false;
		DeleteCharacter();
		DeleteInventory();
		Application.LoadLevel(1);
	}

	public virtual void OnPlayerConnected(NetworkPlayer player)
	{
		if (Network.isServer)
		{
			Network.CloseConnection(player, sendDisconnectionNotification: false);
		}
	}

	public virtual void OnPlayerDisconnected(NetworkPlayer player)
	{
		Network.RemoveRPCs(player);
		Network.DestroyPlayerObjects(player);
	}

	public virtual void Action(int act)
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

	public virtual void SetLeatherworker()
	{
		menuBlacksmith.GetComponent<Renderer>().material = leatherworkerMenu;
		txtNPCName.text = "Finn the Leatherworker";
	}

	public virtual void SetTailor()
	{
		menuBlacksmith.GetComponent<Renderer>().material = tailorMenu;
		txtNPCName.text = "Flora the Tailor";
	}

	public virtual void Interact()
	{
		interacting = true;
		int num = 0;
		switch (interacter)
		{
		case "n1":
			txtNPCName.text = "Grognar the Blacksmith";
			menuBlacksmith.GetComponent<Renderer>().material = blacksmithMenu;
			menuBlacksmith.SetActive(value: true);
			RefreshBlacksmith();
			npcInteract = 1;
			interacted = true;
			break;
		case "n3":
			menuBlacksmith.SetActive(value: true);
			SetLeatherworker();
			RefreshLeatherworker();
			npcInteract = 3;
			interacted = true;
			break;
		case "n4":
			menuBlacksmith.SetActive(value: true);
			SetTailor();
			RefreshTailor();
			npcInteract = 4;
			interacted = true;
			break;
		case "n5":
			menuHoarder.SetActive(value: true);
			npcInteract = 5;
			interacted = true;
			break;
		case "n6":
			Altar();
			num = 1;
			break;
		default:
			num = 1;
			break;
		}
		if (!inventoryOpen && num == 0)
		{
			OpenInventory();
		}
	}

	public virtual void Altar()
	{
		if (curGold >= 500 && !usedAltar)
		{
			usedAltar = true;
			curGold -= 500;
			RefreshGold();
			int num = curAltar;
			switch (num)
			{
			case 0:
				tempGearStat[1] = tempGearStat[1] + 5;
				break;
			case 1:
				if (tempGearStat[0] > 0)
				{
					tempGearStat[0] = tempGearStat[0] - 1;
				}
				break;
			case 2:
				tempGearStat[0] = tempGearStat[0] + 2;
				tempGearStat[1] = tempGearStat[1] + 2;
				tempGearStat[2] = tempGearStat[2] + 2;
				tempGearStat[3] = tempGearStat[3] + 2;
				break;
			case 3:
				if (HP > 1)
				{
					HP--;
					LoadHearts();
				}
				break;
			case 4:
				HP = MAXHP;
				LoadHearts();
				break;
			case 6:
				tempGearStat[2] = tempGearStat[2] + 5;
				break;
			}
			RefreshPlayerStats();
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("txtAltar"), player.transform.position, Quaternion.identity, 0);
			gameObject.SendMessage("Set", num);
			GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/altar", typeof(AudioClip)));
		}
		interacting = false;
	}

	public virtual void InteractCancel()
	{
		if (inventoryOpen)
		{
			OpenInventory();
		}
		menuAlchemist.SetActive(value: false);
		menuBlacksmith.SetActive(value: false);
		menuTailor.SetActive(value: false);
		interacting = false;
	}

	public virtual void GainEXP(int a)
	{
		if (HP <= 0)
		{
			return;
		}
		exp += a;
		barEXPback.GetComponent<Animation>().Play();
		if (!(exp < maxEXP))
		{
			if (playerLevel == 1)
			{
				count = 8;
			}
			maxEXP = count + playerLevel * 5;
			exp = 0f;
			LevelUp();
		}
		LoadEXP();
	}

	public virtual IEnumerator AdditionalStat(int a)
	{
		return new _0024AdditionalStat_00241794(a, this).GetEnumerator();
	}

	public virtual IEnumerator ShowLUP(int a)
	{
		return new _0024ShowLUP_00241799(a, this).GetEnumerator();
	}

	public virtual void LevelUp()
	{
		playerLevel++;
		txtLevel.text = "Lv: " + playerLevel;
		int num = default(int);
		GameObject gameObject = null;
		for (num = 0; num < 4; num++)
		{
			if (num == MenuScript.growthStatGood1 || num == MenuScript.growthStatGood2)
			{
				if (playerLevel % 2 == 0)
				{
					tempLevelStat[num]++;
					StartCoroutine_Auto(ShowLUP(num));
					if (num == 0)
					{
						HP++;
					}
				}
			}
			else if (num == MenuScript.growthStatBad)
			{
				if (playerLevel % 4 == 0)
				{
					tempLevelStat[num]++;
					StartCoroutine_Auto(ShowLUP(num));
					if (num == 0)
					{
						HP++;
					}
				}
			}
			else if (playerLevel % 3 == 0)
			{
				tempLevelStat[num]++;
				StartCoroutine_Auto(ShowLUP(num));
				if (num == 0)
				{
					HP++;
				}
			}
		}
		if (MenuScript.companion == 8)
		{
			int num2 = UnityEngine.Random.Range(0, 4);
			int num3 = ++tempLevelStat[num2];
		}
		if (MenuScript.pHat == 3)
		{
			if (UnityEngine.Random.Range(0, 3) == 0)
			{
				tempLevelStat[1] = tempLevelStat[1] + 1;
				StartCoroutine_Auto(AdditionalStat(1));
			}
		}
		else if (MenuScript.pHat == 4)
		{
			if (UnityEngine.Random.Range(0, 3) == 0)
			{
				tempLevelStat[2] = tempLevelStat[2] + 1;
				StartCoroutine_Auto(AdditionalStat(2));
			}
		}
		else if (MenuScript.pHat == 5)
		{
			if (UnityEngine.Random.Range(0, 3) == 0)
			{
				tempLevelStat[3] = tempLevelStat[3] + 1;
				StartCoroutine_Auto(AdditionalStat(3));
			}
		}
		else if (MenuScript.pHat == 12 && UnityEngine.Random.Range(0, 3) == 0)
		{
			int num4 = UnityEngine.Random.Range(0, 4);
			tempLevelStat[num4]++;
			StartCoroutine_Auto(AdditionalStat(num4));
		}
		MAXHP = MenuScript.playerStat[0] + tempPlayerStat[0] + tempLevelStat[0];
		ATK = MenuScript.playerStat[1] + tempPlayerStat[1] + tempLevelStat[1];
		MAXMAG = MenuScript.playerStat[3] + tempPlayerStat[3] + tempLevelStat[3] + tempGearStat[3];
		DEX = MenuScript.playerStat[2] + tempPlayerStat[2] + tempLevelStat[2] + tempGearStat[2];
		SPD = (float)DEX * 0.05f + 7.6f;
		if (MenuScript.companion == 3)
		{
			SPD *= 2f;
		}
		if (MenuScript.pHat == 9)
		{
			SPD += 4f;
		}
		player.GetComponent<NetworkView>().RPC("LevelUp", RPCMode.All);
		if (playerLevel % 5 == 0 && curSkill <= 2)
		{
			SkillMenu();
		}
		RefreshPlayerStats();
		LoadHearts();
		LoadMana();
		int num5 = playerLevel;
		if (num5 <= 4)
		{
			maxStamina = 4;
		}
		else if (num5 <= 12)
		{
			maxStamina = num5;
		}
		else
		{
			maxStamina = 12;
		}
		LoadSTA();
	}

	public virtual void SelectSkill(int a)
	{
		menuSkill.SetActive(value: false);
		selectingSkill = false;
		a *= 5;
		int num = a + 5;
		GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/SKILL", typeof(AudioClip)));
		int num2 = a + UnityEngine.Random.Range(1, 6);
		int num3 = default(int);
		int num4 = 0;
		int num5 = 0;
		for (num3 = 0; num3 < 3; num3++)
		{
			if (num3 == curSkill)
			{
				skill[curSkill] = num2;
			}
			else if (skill[num3] == num2)
			{
				num2 = ((num2 >= num) ? (a + 1) : (num2 + 1));
			}
			if (skill[num3] > 5 && skill[num3] < 11)
			{
				num4++;
			}
			if (skill[num3] >= 1 && skill[num3] <= 5)
			{
				num5++;
			}
		}
		MonoBehaviour.print(num4 + " IS SKILL count");
		if (num4 > 2)
		{
			MenuScript.canUnlockHat[11] = 1;
		}
		if (num5 > 2)
		{
			MenuScript.canUnlockHat[19] = 1;
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

	public virtual void SkillMenu()
	{
		selectingSkill = true;
		menuSkill.SetActive(value: true);
	}

	public virtual void RefreshSkills()
	{
		int num = default(int);
		for (num = 0; num < 3; num++)
		{
			if (skill[num] > 0)
			{
				skillObj[num].SetActive(value: true);
				skillObj[num].GetComponent<Renderer>().material = (Material)Resources.Load("sI/s" + skill[num]);
			}
			else
			{
				skillObj[num].SetActive(value: false);
			}
		}
	}

	public virtual float GetSkillCooldown(int a)
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

	public virtual IEnumerator SkillTick(int a, float max)
	{
		return new _0024SkillTick_00241804(a, max, this).GetEnumerator();
	}

	public virtual void UseSkill(int b)
	{
		int num = skill[b];
		if (skillCooldown[b] > 0f || num <= 0)
		{
			return;
		}
		skillObj[b].GetComponent<Animation>().Play();
		int num2 = (int)GetSkillCooldown(num);
		skillCooldown[b] = num2;
		StartCoroutine_Auto(SkillTick(b, num2));
		GameObject gameObject = null;
		switch (num)
		{
		case 1:
		{
			Vector3 vector = default(Vector3);
			GameObject gameObject3 = null;
			vector = ((Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= player.transform.position.x) ? new Vector3(0f, 180f, 0f) : new Vector3(0f, 0f, 0f));
			int num3 = (MenuScript.playerStat[1] + tempPlayerStat[1] + tempLevelStat[1] + tempGearStat[1]) / 2;
			gameObject3 = (GameObject)Network.Instantiate(Resources.Load("skill/throwAxe"), player.transform.position, Quaternion.Euler(vector), 0);
			gameObject3.SendMessage("Set", num3);
			player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "dj");
			gameObject = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
			gameObject.GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, "TAKE THAT!");
			break;
		}
		case 2:
			rage = true;
			player.GetComponent<NetworkView>().RPC("Rage", RPCMode.All, 1);
			gameObject = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
			gameObject.GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, "I'M SO ANGRY!");
			StartCoroutine_Auto(RageTick());
			break;
		case 3:
			Network.Instantiate(Resources.Load("skill/Charge"), player.transform.position, Quaternion.identity, 0);
			gameObject = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
			gameObject.GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, "CHARGE!");
			break;
		case 4:
			Network.Instantiate(Resources.Load("skill/Shield"), player.transform.position, Quaternion.identity, 0);
			break;
		case 5:
		{
			GameObject gameObject6 = null;
			int num10 = 38;
			Vector3 velocity4 = player.GetComponent<Rigidbody>().velocity;
			float num11 = (velocity4.y = num10);
			Vector3 vector10 = (player.GetComponent<Rigidbody>().velocity = velocity4);
			int num12 = MenuScript.playerStat[1] + tempPlayerStat[1] + tempLevelStat[1] + tempGearStat[1];
			gameObject6 = (GameObject)Network.Instantiate(Resources.Load("skill/kBlade"), player.transform.position, Quaternion.identity, 0);
			gameObject6.SendMessage("Set", num12);
			player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "dj");
			gameObject = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
			gameObject.GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, "Woohoo!");
			break;
		}
		case 6:
		{
			GameObject gameObject7 = null;
			gameObject7 = (GameObject)Network.Instantiate(Resources.Load("skill/mWeapons"), player.transform.position, Quaternion.identity, 0);
			gameObject7.SendMessage("SetMag", MAXMAG);
			break;
		}
		case 7:
			clair = true;
			player.GetComponent<NetworkView>().RPC("Clair", RPCMode.All, 1);
			gameObject = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
			gameObject.GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, "I'M FOCUSED!");
			StartCoroutine_Auto(ManaTick());
			break;
		case 8:
		{
			Vector3 vector = ((Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= player.transform.position.x) ? new Vector3(0f, 180f, 0f) : new Vector3(0f, 0f, 0f));
			Vector3 position = new Vector3(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x, Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).y, 0f);
			GameObject gameObject4 = null;
			gameObject4 = (GameObject)Network.Instantiate(Resources.Load("skill/minion"), position, Quaternion.Euler(vector), 0);
			gameObject4.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, MAXMAG);
			break;
		}
		case 9:
		{
			Network.Instantiate(Resources.Load("warp"), player.transform.position, Quaternion.Euler(0f, 180f, 180f), 0);
			Ray ray = default(Ray);
			RaycastHit hitInfo = default(RaycastHit);
			int layerMask = 2048;
			if (!(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= player.transform.position.x))
			{
				ray = new Ray(player.transform.position, new Vector3(1f, 0f, 0f));
				Vector3 vector = new Vector3(player.transform.position.x + 8f, player.transform.position.y, 0f);
				if (!Physics.Raycast(ray, out hitInfo, 8.4f, layerMask))
				{
					player.transform.position = vector;
					int num6 = 0;
					Vector3 velocity2 = player.GetComponent<Rigidbody>().velocity;
					float num7 = (velocity2.x = num6);
					Vector3 vector6 = (player.GetComponent<Rigidbody>().velocity = velocity2);
				}
			}
			else
			{
				ray = new Ray(player.transform.position, new Vector3(-1f, 0f, 0f));
				Vector3 vector = new Vector3(player.transform.position.x - 8f, player.transform.position.y, 0f);
				if (!Physics.Raycast(ray, out hitInfo, 8.4f, layerMask))
				{
					player.transform.position = vector;
					int num8 = 0;
					Vector3 velocity3 = player.GetComponent<Rigidbody>().velocity;
					float num9 = (velocity3.x = num8);
					Vector3 vector8 = (player.GetComponent<Rigidbody>().velocity = velocity3);
				}
			}
			Network.Instantiate(Resources.Load("warp"), player.transform.position, Quaternion.Euler(0f, 180f, 180f), 0);
			break;
		}
		case 10:
			player.SendMessage("Float", 1);
			gameObject = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
			gameObject.GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, "PUT ME DOWN!");
			break;
		case 11:
			player.GetComponent<NetworkView>().RPC("Roar", RPCMode.All, 1);
			gameObject = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
			gameObject.GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, "RAAAAH");
			StartCoroutine_Auto(RoarTick());
			break;
		case 12:
			multishot = true;
			break;
		case 13:
		{
			GameObject gameObject5 = null;
			int num4 = 38;
			Vector3 velocity = player.GetComponent<Rigidbody>().velocity;
			float num5 = (velocity.y = num4);
			Vector3 vector4 = (player.GetComponent<Rigidbody>().velocity = velocity);
			gameObject5 = (GameObject)Network.Instantiate(Resources.Load("skill/dArrow"), player.transform.position, Quaternion.identity, 0);
			gameObject5.SendMessage("Set", finalATK);
			player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, "dj");
			gameObject = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
			gameObject.GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, "WOOHOO!");
			break;
		}
		case 14:
		{
			Vector3 vector2 = new Vector3(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x, Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).y, 0f);
			GetComponent<NetworkView>().RPC("Wisp", RPCMode.All, vector2);
			break;
		}
		case 15:
		{
			GameObject gameObject2 = null;
			gameObject2 = (GameObject)Network.Instantiate(rotation: Quaternion.Euler((Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= player.transform.position.x) ? new Vector3(0f, 180f, 0f) : new Vector3(0f, 0f, 0f)), prefab: Resources.Load("skill/wolf"), position: player.transform.position, group: 0);
			gameObject2.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, DEX + DEXBonus);
			break;
		}
		}
	}

	[RPC]
	public virtual void Wisp(Vector3 mP)
	{
		UnityEngine.Object.Instantiate(Resources.Load("skill/wisp"), mP, Quaternion.identity);
	}

	public virtual IEnumerator RageTick()
	{
		return new _0024RageTick_00241814().GetEnumerator();
	}

	public virtual IEnumerator RoarTick()
	{
		return new _0024RoarTick_00241815().GetEnumerator();
	}

	public virtual IEnumerator FloatTick()
	{
		return new _0024FloatTick_00241816().GetEnumerator();
	}

	public virtual IEnumerator ManaTick()
	{
		return new _0024ManaTick_00241817(this).GetEnumerator();
	}

  private Dictionary<int, string> itemNames = new Dictionary<int, string>
  {
    { 1, "Wood" },
    { 2, "Wooden Plank" },
    { 3, "Wooden Stick" },
    { 4, "Ironite Ore" },
    { 5, "Goldium Ore" },
    { 6, "Diamonite Ore" },
    { 7, "Raw Meat" },
    { 8, "Cooked Meat" },
    { 9, "Herb" },
    { 10, "Shroom" },
    { 11, "Root" },
    { 12, "Ironite Bar" },
    { 13, "Goldium Bar" },
    { 14, "Diamonite Bar" },
    { 15, "HP Potion" },
    { 16, "Mana Potion" },
    { 17, "Vial of Poison" },
    { 18, "Monster Bone" },
    { 19, "Monster Hide" },
    { 20, "Monster Pelt" },
    { 21, "Raw Chicken" },
    { 22, "Cooked Chicken" },
    { 23, "Spider Web" },
    { 24, "Sword Hilt" },
    { 25, "Wooden Blade" },
    { 26, "Axe Handle" },
    { 27, "Pick Handle" },
    { 28, "Unstrung Bow" },
    { 29, "String" },
    { 30, "Fire Bug" },
    { 31, "Thunder Bug" },
    { 32, "Ironite Blade" },
    { 33, "Goldmium Blade" },
    { 34, "Diamonite Blade" },
    { 35, "Ironite Great Blade" },
    { 36, "Goldium Great Blade" },
    { 37, "Diamonite Great Blade" },
    { 38, "Stone" },
    { 39, "Refined Stone" },
    { 40, "Stone Blade" },
    { 41, "Stone Great Blade" },
    { 42, "Big HP Potion" },
    { 43, "Big Mana Potion" },
    { 44, "Mysterious Potion" },
    { 45, "Big Mysterious Potion" },
    { 46, "Total Biscuit" },
    { 47, "Coal" },
    { 48, "Firestarter" },
    { 49, "Mystery Key" },
    { 50, "Bone Blade" },
    { 51, "Refined Bone" },
    { 52, "Bone Arrow" },
    { 53, "Stone Arrow" },
    { 54, "Ironite Arrow" },
    { 55, "Goldium Arrow" },
    { 56, "Diamonite Arrow" },
    { 57, "Dragonite Arrow" },
    { 58, "Adamantite Arrow" },
    { 59, "Obsidian Arrow" },
    { 60, "Crystalite Fragment" },
    { 61, "Crystalite Shard" },
    { 62, "Dragonite Ore" },
    { 63, "Dragonite Bar" },
    { 64, "Adamantite Ore" },
    { 65, "Adamantite Bar" },
    { 66, "Obsidian Ore" },
    { 67, "Obsidian Bar" },
    { 68, "Net" },
    { 69, "Fire Gem I" },
    { 70, "Thunder Gem I" },
    { 71, "Ice Gem I" },
    { 72, "Stone Dagger" },
    { 73, "Bone Dagger" },
    { 74, "Ironite Dagger" },
    { 75, "Goldium Dagger" },
    { 76, "Diamonite Dagger" },
    { 77, "Tribal Drum" },
    { 78, "Drum of Strength" },
    { 79, "Drum of Dexterity" },
    { 80, "Drum of Wisdom" },
    { 81, "Ice Bug" },
    { 82, "Refined Leather" },
    { 83, "Rugged Leather" },
    { 84, "Tribal Leather" },
    { 85, "Elegant Leather" },
    { 86, "Royal Leather" },
    { 87, "Luminous Leather" },
    { 88, "Rugged Fabric" },
    { 89, "Tribal Fabric" },
    { 90, "Elegant Fabric" },
    { 91, "Royal Fabric" },
    { 92, "Luminous Fabric" },
    { 94, "Refined Cloth" },
    { 95, "Spirit Gem" },
  };


  public virtual string GetItemName(int id)
      {
        if (itemNames.TryGetValue(id, out string itemName))
      {
          return itemName;
      }

      Debug.LogError("Item id doesn't exist");
   return "NULL";
  }

  private Dictionary<int, string> gearNames = new Dictionary<int, string>
    {
      { 500, "Wooden Sword" },
      { 501, "Wooden Axe" },
      { 502, "Wooden Pick" },
      { 503, "Ironite Sword" },
      { 504, "Ironite Axe" },
      { 505, "Ironite Pick" },
      { 506, "Goldium Sword" },
      { 507, "Goldium Axe" },
      { 508, "Goldium Pick" },
      { 509, "Diamonite Sword" },
      { 510, "Diamonite Axe" },
      { 511, "Diamonite Pick" },
      { 512, "Stone Sword" },
      { 513, "Stone Axe" },
      { 514, "Stone Pick" },
      { 515, "Wooden Bow" },
      { 516, "Bone Sword" },
      { 517, "Bone Axe" },
      { 518, "Bone Pick" },
      { 519, "Wooden Club" },
      { 520, "Lightbringer" },
      { 521, "Scourge Blade" },
      { 522, "Dragonite Pick" },
      { 523, "Wightslayer" },
      { 524, "Adamantite Axe" },
      { 525, "Adamantite Pick" },
      { 526, "Spellblade" },
      { 527, "Obsidian Axe" },
      { 528, "Obsidian Pick" },
      { 529, "Bug Net" },
      { 530, "Crystal Bow" },
      { 531, "Emerald Katana" },
      { 532, "Emerald Combat Axe" },
      { 533, "Obsidian Sword" },
      { 534, "Laser Sword" },
      { 535, "Laser Crossbow" },
      { 536, "Fire Bow" },
      { 550, "Giant Fish" },
      { 560, "Ironite Great Axe" },
      { 561, "Goldium Great Axe" },
      { 562, "Diamonite Great Axe" },
      { 563, "Stone Great Axe" },
      { 564, "Hellswrath" },
      { 565, "The Philibuster" },
      { 566, "Jelly Blade" },
      { 567, "Zweihander" },
      { 568, "Icebrand" },
      { 569, "Firebrand" },
      { 570, "Thunderbrand" },
      { 600, "Fireball" },
      { 601, "Bolt" },
      { 602, "Frostshard" },
      { 603, "Summon Zombie" },
      { 700, "Ironite Helm" },
      { 701, "Goldium Helm" },
      { 702, "Diamonite Helm" },
      { 703, "Stone Helm" },
      { 704, "Bone Helm" },
      { 705, "Rugged Cap" },
      { 706, "Tribal Cap" },
      { 707, "Elegant Cap" },
      { 708, "Royal Cap" },
      { 709, "Luminous Cap" },
      { 710, "Rugged Hood" },
      { 711, "Tribal Hood" },
      { 712, "Elegant Hood" },
      { 713, "Royal Hood" },
      { 714, "Luminous Hood" },
      { 800, "Ironite Armor" },
      { 801, "Goldium Armor" },
      { 802, "Diamonite Armor" },
      { 803, "Stone Armor" },
      { 804, "Bone Armor" },
      { 805, "Rugged Cloak" },
      { 806, "Tribal Cloak" },
      { 807, "Elegant Cloak" },
      { 808, "Royal Cloak" },
      { 809, "Luminous Cloak" },
      { 810, "Rugged Robes" },
      { 811, "Tribal Robes" },
      { 812, "Elegant Robes" },
      { 813, "Royal Robes" },
      { 814, "Luminous Robes" },
      { 900, "Ironite Shield" },
      { 901, "Goldium Shield" },
      { 902, "Diamonite Shield" },
      { 903, "Stone Shield" },
      { 904, "Bone Shield" },
      { 905, "Ryvenrath's Scale" },
      { 906, "Paladin Guard" },
      { 907, "Scourge Shield" },
      { 950, "Ring of Power" },
      { 951, "Ring of Wisdom" },
      { 952, "Ring of Nature" },
      { 953, "Ring of Life" },
      { 954, "Ring of Rage" },
      { 955, "Ring of Insanity" },
      { 956, "Archer's Ring" },
      { 957, "Ring of Balance" },
    };
    public virtual string GetGearName(int id)
        {
          if (gearNames.TryGetValue(id, out string gearName))
        {
            return gearName;
        }

        Debug.LogError("Gear id doesn't exist");
     return "NULL";
    }

	public virtual void Main()
	{
	}
}
