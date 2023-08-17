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
	internal sealed class _0024Invader_00241659 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241660;

			internal int _0024waitTime_00241661;

			internal GameScript _0024self__00241662;

			public _0024(GameScript self_)
			{
				_0024self__00241662 = self_;
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
					_0024i_00241660 = default(int);
					if (MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
					{
						_0024waitTime_00241661 = Random.Range(300, 350);
						if (districtLevel <= 1)
						{
							_0024waitTime_00241661 *= 2;
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)_0024waitTime_00241661)) ? 1 : 0);
						break;
					}
					goto IL_0118;
				case 2:
					((MonoBehaviour)_0024self__00241662).StartCoroutine_Auto(_0024self__00241662.Write(5));
					player.networkView.RPC("Boss", (RPCMode)2, new object[0]);
					_0024i_00241660 = 0;
					goto IL_010c;
				case 3:
					_0024i_00241660++;
					goto IL_010c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_010c:
					if (_0024i_00241660 < 5)
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

		internal GameScript _0024self__00241663;

		public _0024Invader_00241659(GameScript self_)
		{
			_0024self__00241663 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241663);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Timer_00241664 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241665;

			public _0024(GameScript self_)
			{
				_0024self__00241665 = self_;
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
					if (!_0024self__00241665.dead)
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

		internal GameScript _0024self__00241666;

		public _0024Timer_00241664(GameScript self_)
		{
			_0024self__00241666 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241666);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RegenManaComp_00241667 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241668;

			public _0024(GameScript self_)
			{
				_0024self__00241668 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				//IL_002d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 2:
					if (MAG < MAXMAG)
					{
						MAG++;
						_0024self__00241668.LoadMana();
					}
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241669;

		public _0024RegenManaComp_00241667(GameScript self_)
		{
			_0024self__00241669 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241669);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ScourgeMaskTick_00241670 : GenericGenerator<WaitForSeconds>
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
	internal sealed class _0024TikiCheck_00241671 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024noo_00241672;

			internal GameObject _0024pot_00241673;

			internal GameScript _0024self__00241674;

			public _0024(GameScript self_)
			{
				_0024self__00241674 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected O, but got Unknown
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a2: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.pHat == 10)
					{
						_0024noo_00241672 = Random.Range(0, 2);
						if (_0024noo_00241672 == 0)
						{
							player.SendMessage("TD", (object)1);
						}
						else
						{
							HP += 3;
							_0024pot_00241673 = (GameObject)Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
							_0024pot_00241673.SendMessage("SD", (object)3);
							_0024self__00241674.LoadHearts();
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

		internal GameScript _0024self__00241675;

		public _0024TikiCheck_00241671(GameScript self_)
		{
			_0024self__00241675 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241675);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LavaWorm_00241676 : GenericGenerator<WaitForSeconds>
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
	internal sealed class _0024RecoverMana_00241677 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024noo_00241678;

			internal GameScript _0024self__00241679;

			public _0024(GameScript self_)
			{
				_0024self__00241679 = self_;
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
						_0024self__00241679.LoadMana();
						_0024self__00241679.GUImana.animation.Play();
						if (MenuScript.pHat == 18)
						{
							_0024noo_00241678 = Random.Range(0, 5);
							if (_0024noo_00241678 == 0 && HP < MAXHP)
							{
								HP++;
								_0024self__00241679.LoadHearts();
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

		internal GameScript _0024self__00241680;

		public _0024RecoverMana_00241677(GameScript self_)
		{
			_0024self__00241680 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241680);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ScourgeBoss_00241681 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024enemy_00241682;

			internal int _0024d_00241683;

			public _0024(int d)
			{
				_0024d_00241683 = d;
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
					_0024enemy_00241682 = null;
					if (!isTown)
					{
						if (_0024d_00241683 == 5)
						{
							_0024enemy_00241682 = "abyssalTitan";
						}
						else if (_0024d_00241683 == 10)
						{
							_0024enemy_00241682 = "scourgeKnight";
						}
						else if (_0024d_00241683 == 15)
						{
							_0024enemy_00241682 = "scourgeKnight";
						}
						else
						{
							_0024enemy_00241682 = "abyssalTitan";
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
					Network.Instantiate(Resources.Load("e/" + _0024enemy_00241682), new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
					goto IL_0161;
				case 3:
					if (Object.op_Implicit((Object)(object)exitObj))
					{
						exitObj.SendMessage("Close");
					}
					Object.Instantiate(Resources.Load("e/" + _0024enemy_00241682), new Vector3(0f, 0f, 0f), Quaternion.identity);
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

		internal int _0024d_00241684;

		public _0024ScourgeBoss_00241681(int d)
		{
			_0024d_00241684 = d;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024d_00241684);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SummonScourge_00241685 : GenericGenerator<WaitForSeconds>
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
	internal sealed class _0024RepeatScourge_00241686 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241687;

			internal GameScript _0024self__00241688;

			public _0024(GameScript self_)
			{
				_0024self__00241688 = self_;
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
						_0024i_00241687 = default(int);
						_0024i_00241687 = 0;
						goto IL_0079;
					}
					goto IL_0085;
				case 2:
					((MonoBehaviour)_0024self__00241688).StartCoroutine_Auto(_0024self__00241688.SummonScourge());
					_0024i_00241687++;
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
					if (_0024i_00241687 < 5)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(10, 15))) ? 1 : 0);
						break;
					}
					goto IL_0085;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241689;

		public _0024RepeatScourge_00241686(GameScript self_)
		{
			_0024self__00241689 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241689);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Write_00241690 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024tt_00241691;

			internal int _0024_0024switch_0024198_00241692;

			internal int _0024num_00241693;

			internal GameScript _0024self__00241694;

			public _0024(int num, GameScript self_)
			{
				_0024num_00241693 = num;
				_0024self__00241694 = self_;
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
					_0024tt_00241691 = null;
					_0024_0024switch_0024198_00241692 = _0024num_00241693;
					if (_0024_0024switch_0024198_00241692 == 0)
					{
						_0024tt_00241691 = "Your " + _0024self__00241694.GetGearName(inventory[curActiveSlot].id) + " is about to break.";
					}
					else if (_0024_0024switch_0024198_00241692 == 1)
					{
						_0024tt_00241691 = "Your stomach begins to grumble.";
					}
					else if (_0024_0024switch_0024198_00241692 == 2)
					{
						_0024tt_00241691 = "You are starving.";
					}
					else if (_0024_0024switch_0024198_00241692 == 3)
					{
						_0024tt_00241691 = "You feel uneasy.";
					}
					else if (_0024_0024switch_0024198_00241692 == 4)
					{
						_0024tt_00241691 = "A slight breeze brushes against your face.";
					}
					else if (_0024_0024switch_0024198_00241692 == 5)
					{
						_0024self__00241694.GlobalWrite(0);
					}
					else if (_0024_0024switch_0024198_00241692 == 6)
					{
						_0024tt_00241691 = "You feel as if the Scourge are watching you...";
					}
					else if (_0024_0024switch_0024198_00241692 == 7)
					{
						_0024tt_00241691 = "You've awakened the Broodmother...";
					}
					else
					{
						_0024tt_00241691 = string.Empty;
					}
					if (!string.IsNullOrEmpty(_0024tt_00241691))
					{
						((Component)_0024self__00241694.txtStatus2).gameObject.SetActive(true);
						_0024self__00241694.txtStatus2.text = _0024tt_00241691;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto IL_01b2;
				case 2:
					_0024self__00241694.txtStatus2.text = " ";
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

		internal int _0024num_00241695;

		internal GameScript _0024self__00241696;

		public _0024Write_00241690(int num, GameScript self_)
		{
			_0024num_00241695 = num;
			_0024self__00241696 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024num_00241695, _0024self__00241696);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024WriteFinal_00241697 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024tt_00241698;

			internal int _0024_0024switch_0024200_00241699;

			internal int _0024a_00241700;

			internal GameScript _0024self__00241701;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241700 = a;
				_0024self__00241701 = self_;
			}

			public override bool MoveNext()
			{
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024tt_00241698 = null;
					_0024_0024switch_0024200_00241699 = _0024a_00241700;
					_0024tt_00241698 = "The Scourge have invaded! Get out!!";
					((Component)_0024self__00241701.txtStatus2).gameObject.SetActive(true);
					_0024self__00241701.txtStatus2.text = _0024tt_00241698;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241701.txtStatus2.text = " ";
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241702;

		internal GameScript _0024self__00241703;

		public _0024WriteFinal_00241697(int a, GameScript self_)
		{
			_0024a_00241702 = a;
			_0024self__00241703 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241702, _0024self__00241703);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GenerateText_00241704 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241705;

			internal string _0024tt_00241706;

			internal int _0024_0024switch_0024202_00241707;

			internal GameScript _0024self__00241708;

			public _0024(GameScript self_)
			{
				_0024self__00241708 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024num_00241705 = Random.Range(0, 30);
					_0024tt_00241706 = null;
					_0024_0024switch_0024202_00241707 = _0024num_00241705;
					if (_0024_0024switch_0024202_00241707 == 0)
					{
						_0024tt_00241706 = "You feel as if you are being watched...";
					}
					else if (_0024_0024switch_0024202_00241707 == 1)
					{
						_0024tt_00241706 = "You hear a distant rumble...";
						if (!isTown)
						{
							_0024self__00241708.Quake();
						}
					}
					else if (_0024_0024switch_0024202_00241707 == 2)
					{
						_0024tt_00241706 = "There is a foul taste in the air.";
					}
					else if (_0024_0024switch_0024202_00241707 == 3)
					{
						_0024tt_00241706 = "You feel uneasy.";
					}
					else if (_0024_0024switch_0024202_00241707 == 4)
					{
						_0024tt_00241706 = "A slight breeze brushes against your face.";
					}
					else
					{
						_0024tt_00241706 = string.Empty;
					}
					if (Object.op_Implicit((Object)(object)_0024self__00241708.txtStatus2))
					{
						_0024self__00241708.txtStatus2.text = _0024tt_00241706;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_013b;
				case 2:
					_0024self__00241708.txtStatus2.text = string.Empty;
					goto IL_013b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_013b:
					if (_0024num_00241705 == 3 && MenuScript.multiplayer == 0 && !isTown)
					{
						_0024self__00241708.Worm();
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241709;

		public _0024GenerateText_00241704(GameScript self_)
		{
			_0024self__00241709 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241709);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241710 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241711;

			public _0024(GameScript self_)
			{
				_0024self__00241711 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					((MonoBehaviour)_0024self__00241711).StartCoroutine_Auto(_0024self__00241711.StaminaStart());
					menuOpen = false;
					_0024self__00241711.LoadHearts();
					_0024self__00241711.LoadMana();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					isReturning = false;
					_0024self__00241711.RefreshGold();
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241712;

		public _0024Start_00241710(GameScript self_)
		{
			_0024self__00241712 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241712);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024StaminaStart_00241713 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024ppp_00241714;

			internal GameScript _0024self__00241715;

			public _0024(GameScript self_)
			{
				_0024self__00241715 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024ppp_00241714 = playerLevel;
					if (_0024ppp_00241714 <= 4)
					{
						_0024self__00241715.maxStamina = 4;
					}
					else if (_0024ppp_00241714 <= 12)
					{
						_0024self__00241715.maxStamina = _0024ppp_00241714;
					}
					else
					{
						_0024self__00241715.maxStamina = 12;
					}
					_0024self__00241715.stamina = _0024self__00241715.maxStamina;
					goto case 2;
				case 2:
					if (!(_0024self__00241715.stamina >= (float)_0024self__00241715.maxStamina))
					{
						_0024self__00241715.stamina += 1f;
						_0024self__00241715.LoadSTA();
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

		internal GameScript _0024self__00241716;

		public _0024StaminaStart_00241713(GameScript self_)
		{
			_0024self__00241716 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241716);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024WriteEgg_00241717 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241718;

			public _0024(GameScript self_)
			{
				_0024self__00241718 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241718.writingEgg = true;
					((MonoBehaviour)_0024self__00241718).StartCoroutine_Auto(_0024self__00241718.Write(7));
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241718.writingEgg = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241719;

		public _0024WriteEgg_00241717(GameScript self_)
		{
			_0024self__00241719 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241719);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AddInput_00241720 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241721;

			internal GameScript _0024self__00241722;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241721 = a;
				_0024self__00241722 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_0123: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241722.addingInput)
					{
						((Component)_0024self__00241722).audio.PlayOneShot(_0024self__00241722.audioSelect2);
						_0024self__00241722.cheatButton[_0024a_00241721 - 1].animation.Play();
						if (_0024self__00241722.inputCount == 0)
						{
							_0024self__00241722.txtInput.text = string.Empty;
						}
						_0024self__00241722.addingInput = true;
						_0024self__00241722.inputString[_0024self__00241722.inputCount] = _0024a_00241721;
						_0024self__00241722.inputCount++;
						_0024self__00241722.txtInput.text = _0024self__00241722.txtInput.text + ((object)_0024a_00241721 + string.Empty);
						if (_0024self__00241722.inputCount == 7)
						{
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						goto IL_013f;
					}
					goto IL_014b;
				case 2:
					_0024self__00241722.CheckInput();
					_0024self__00241722.inputCount = 0;
					goto IL_013f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_014b:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
					IL_013f:
					_0024self__00241722.addingInput = false;
					goto IL_014b;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241723;

		internal GameScript _0024self__00241724;

		public _0024AddInput_00241720(int a, GameScript self_)
		{
			_0024a_00241723 = a;
			_0024self__00241724 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241723, _0024self__00241724);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Craft_00241725 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024canCraft_00241726;

			internal string _0024craft_00241727;

			internal int _0024c1_00241728;

			internal int _0024c2_00241729;

			internal Item _0024newItem_00241730;

			internal int _0024newID_00241731;

			internal int _0024newQ_00241732;

			internal int _0024i_00241733;

			internal int _0024pood_00241734;

			internal int _0024lowestQ_00241735;

			internal int _0024aTemp_00241736;

			internal float _0024tempForge_00241737;

			internal int _0024luckCount_00241738;

			internal int _0024bonusStat_00241739;

			internal int _0024num1_00241740;

			internal GameScript _0024self__00241741;

			public _0024(GameScript self_)
			{
				_0024self__00241741 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024canCraft_00241726 = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					_0024craft_00241727 = (object)_0024self__00241741.firstItemSelected.id + "c" + (object)_0024self__00241741.secondItemSelected.id;
					_0024c1_00241728 = _0024self__00241741.firstItemSelected.id;
					_0024c2_00241729 = _0024self__00241741.secondItemSelected.id;
					_0024newItem_00241730 = null;
					_0024newID_00241731 = 0;
					_0024newQ_00241732 = default(int);
					MonoBehaviour.print((object)("crafting " + (object)_0024c1_00241728 + " " + (object)_0024c2_00241729));
					if (_0024c1_00241728 == 1 && _0024c2_00241729 == 1)
					{
						_0024newID_00241731 = 2;
					}
					else if (_0024c1_00241728 == 2 && _0024c2_00241729 == 2)
					{
						_0024newID_00241731 = 25;
					}
					else if (_0024c1_00241728 == 2 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 24;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 2)
					{
						_0024newID_00241731 = 24;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 26;
					}
					else if (_0024c1_00241728 == 9 && _0024c2_00241729 == 9)
					{
						_0024newID_00241731 = 15;
					}
					else if (_0024c1_00241728 == 25 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 501;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 25)
					{
						_0024newID_00241731 = 501;
					}
					else if (_0024c1_00241728 == 24 && _0024c2_00241729 == 25)
					{
						_0024newID_00241731 = 500;
					}
					else if (_0024c1_00241728 == 25 && _0024c2_00241729 == 24)
					{
						_0024newID_00241731 = 500;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 27;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 27;
					}
					else if (_0024c1_00241728 == 27 && _0024c2_00241729 == 25)
					{
						_0024newID_00241731 = 502;
					}
					else if (_0024c1_00241728 == 25 && _0024c2_00241729 == 27)
					{
						_0024newID_00241731 = 502;
					}
					else if (_0024c1_00241728 == 38 && _0024c2_00241729 == 38)
					{
						_0024newID_00241731 = 39;
					}
					else if (_0024c1_00241728 == 39 && _0024c2_00241729 == 39)
					{
						_0024newID_00241731 = 40;
					}
					else if (_0024c1_00241728 == 24 && _0024c2_00241729 == 40)
					{
						_0024newID_00241731 = 512;
					}
					else if (_0024c1_00241728 == 40 && _0024c2_00241729 == 24)
					{
						_0024newID_00241731 = 512;
					}
					else if (_0024c1_00241728 == 40 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 513;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 40)
					{
						_0024newID_00241731 = 513;
					}
					else if (_0024c1_00241728 == 40 && _0024c2_00241729 == 27)
					{
						_0024newID_00241731 = 514;
					}
					else if (_0024c1_00241728 == 27 && _0024c2_00241729 == 40)
					{
						_0024newID_00241731 = 514;
					}
					else if (_0024c1_00241728 == 18 && _0024c2_00241729 == 18)
					{
						_0024newID_00241731 = 51;
					}
					else if (_0024c1_00241728 == 71 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 602;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 71)
					{
						_0024newID_00241731 = 602;
					}
					else if (_0024c1_00241728 == 18 && _0024c2_00241729 == 50)
					{
						_0024newID_00241731 = 517;
					}
					else if (_0024c1_00241728 == 50 && _0024c2_00241729 == 18)
					{
						_0024newID_00241731 = 517;
					}
					else if (_0024c1_00241728 == 19 && _0024c2_00241729 == 19)
					{
						_0024newID_00241731 = 82;
					}
					else if (_0024c1_00241728 == 20 && _0024c2_00241729 == 20)
					{
						_0024newID_00241731 = 94;
					}
					else if (_0024c1_00241728 == 81 && _0024c2_00241729 == 81)
					{
						_0024newID_00241731 = 71;
					}
					else if (_0024c1_00241728 == 2 && _0024c2_00241729 == 82)
					{
						_0024newID_00241731 = 77;
					}
					else if (_0024c1_00241728 == 82 && _0024c2_00241729 == 2)
					{
						_0024newID_00241731 = 77;
					}
					else if (_0024c1_00241728 == 77 && _0024c2_00241729 == 30)
					{
						_0024newID_00241731 = 78;
					}
					else if (_0024c1_00241728 == 30 && _0024c2_00241729 == 77)
					{
						_0024newID_00241731 = 78;
					}
					else if (_0024c1_00241728 == 77 && _0024c2_00241729 == 31)
					{
						_0024newID_00241731 = 79;
					}
					else if (_0024c1_00241728 == 31 && _0024c2_00241729 == 77)
					{
						_0024newID_00241731 = 79;
					}
					else if (_0024c1_00241728 == 77 && _0024c2_00241729 == 81)
					{
						_0024newID_00241731 = 80;
					}
					else if (_0024c1_00241728 == 81 && _0024c2_00241729 == 77)
					{
						_0024newID_00241731 = 80;
					}
					else if (_0024c1_00241728 == 69 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 600;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 69)
					{
						_0024newID_00241731 = 600;
					}
					else if (_0024c1_00241728 == 70 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 601;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 70)
					{
						_0024newID_00241731 = 601;
					}
					else if (_0024c1_00241728 == 30 && _0024c2_00241729 == 30)
					{
						_0024newID_00241731 = 69;
					}
					else if (_0024c1_00241728 == 31 && _0024c2_00241729 == 31)
					{
						_0024newID_00241731 = 70;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 50)
					{
						_0024newID_00241731 = 517;
					}
					else if (_0024c1_00241728 == 50 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 517;
					}
					else if (_0024c1_00241728 == 24 && _0024c2_00241729 == 50)
					{
						_0024newID_00241731 = 516;
					}
					else if (_0024c1_00241728 == 50 && _0024c2_00241729 == 24)
					{
						_0024newID_00241731 = 516;
					}
					else if (_0024c1_00241728 == 60 && _0024c2_00241729 == 60)
					{
						_0024newID_00241731 = 61;
					}
					else if (_0024c1_00241728 == 51 && _0024c2_00241729 == 51)
					{
						_0024newID_00241731 = 50;
					}
					else if (_0024c1_00241728 == 27 && _0024c2_00241729 == 50)
					{
						_0024newID_00241731 = 518;
					}
					else if (_0024c1_00241728 == 50 && _0024c2_00241729 == 27)
					{
						_0024newID_00241731 = 518;
					}
					else if (_0024c1_00241728 == 29 && _0024c2_00241729 == 29)
					{
						_0024newID_00241731 = 68;
					}
					else if (_0024c1_00241728 == 27 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 28;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 27)
					{
						_0024newID_00241731 = 28;
					}
					else if (_0024c1_00241728 == 28 && _0024c2_00241729 == 29)
					{
						_0024newID_00241731 = 515;
					}
					else if (_0024c1_00241728 == 29 && _0024c2_00241729 == 28)
					{
						_0024newID_00241731 = 515;
					}
					else if (_0024c1_00241728 == 12 && _0024c2_00241729 == 12)
					{
						_0024newID_00241731 = 32;
					}
					else if (_0024c1_00241728 == 13 && _0024c2_00241729 == 13)
					{
						_0024newID_00241731 = 33;
					}
					else if (_0024c1_00241728 == 14 && _0024c2_00241729 == 14)
					{
						_0024newID_00241731 = 34;
					}
					else if (_0024c1_00241728 == 39 && _0024c2_00241729 == 39)
					{
						_0024newID_00241731 = 40;
					}
					else if (_0024c1_00241728 == 32 && _0024c2_00241729 == 24)
					{
						_0024newID_00241731 = 503;
					}
					else if (_0024c1_00241728 == 24 && _0024c2_00241729 == 32)
					{
						_0024newID_00241731 = 503;
					}
					else if (_0024c1_00241728 == 32 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 504;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 32)
					{
						_0024newID_00241731 = 504;
					}
					else if (_0024c1_00241728 == 32 && _0024c2_00241729 == 27)
					{
						_0024newID_00241731 = 505;
					}
					else if (_0024c1_00241728 == 27 && _0024c2_00241729 == 32)
					{
						_0024newID_00241731 = 505;
					}
					else if (_0024c1_00241728 == 24 && _0024c2_00241729 == 33)
					{
						_0024newID_00241731 = 506;
					}
					else if (_0024c1_00241728 == 33 && _0024c2_00241729 == 24)
					{
						_0024newID_00241731 = 506;
					}
					else if (_0024c1_00241728 == 33 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 507;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 33)
					{
						_0024newID_00241731 = 507;
					}
					else if (_0024c1_00241728 == 33 && _0024c2_00241729 == 27)
					{
						_0024newID_00241731 = 508;
					}
					else if (_0024c1_00241728 == 27 && _0024c2_00241729 == 33)
					{
						_0024newID_00241731 = 508;
					}
					else if (_0024c1_00241728 == 24 && _0024c2_00241729 == 34)
					{
						_0024newID_00241731 = 509;
					}
					else if (_0024c1_00241728 == 34 && _0024c2_00241729 == 24)
					{
						_0024newID_00241731 = 509;
					}
					else if (_0024c1_00241728 == 34 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 510;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 34)
					{
						_0024newID_00241731 = 510;
					}
					else if (_0024c1_00241728 == 34 && _0024c2_00241729 == 27)
					{
						_0024newID_00241731 = 511;
					}
					else if (_0024c1_00241728 == 27 && _0024c2_00241729 == 34)
					{
						_0024newID_00241731 = 511;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 35)
					{
						_0024newID_00241731 = 560;
					}
					else if (_0024c1_00241728 == 35 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 560;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 36)
					{
						_0024newID_00241731 = 561;
					}
					else if (_0024c1_00241728 == 36 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 561;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 37)
					{
						_0024newID_00241731 = 562;
					}
					else if (_0024c1_00241728 == 37 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 562;
					}
					else if (_0024c1_00241728 == 26 && _0024c2_00241729 == 41)
					{
						_0024newID_00241731 = 563;
					}
					else if (_0024c1_00241728 == 41 && _0024c2_00241729 == 26)
					{
						_0024newID_00241731 = 563;
					}
					else if (_0024c1_00241728 == 567 && _0024c2_00241729 == 71)
					{
						_0024newID_00241731 = 568;
					}
					else if (_0024c1_00241728 == 71 && _0024c2_00241729 == 567)
					{
						_0024newID_00241731 = 568;
					}
					else if (_0024c1_00241728 == 567 && _0024c2_00241729 == 69)
					{
						_0024newID_00241731 = 569;
					}
					else if (_0024c1_00241728 == 69 && _0024c2_00241729 == 567)
					{
						_0024newID_00241731 = 569;
					}
					else if (_0024c1_00241728 == 567 && _0024c2_00241729 == 70)
					{
						_0024newID_00241731 = 570;
					}
					else if (_0024c1_00241728 == 70 && _0024c2_00241729 == 567)
					{
						_0024newID_00241731 = 570;
					}
					else if (_0024c1_00241728 == 32 && _0024c2_00241729 == 32)
					{
						_0024newID_00241731 = 35;
					}
					else if (_0024c1_00241728 == 33 && _0024c2_00241729 == 33)
					{
						_0024newID_00241731 = 36;
					}
					else if (_0024c1_00241728 == 34 && _0024c2_00241729 == 34)
					{
						_0024newID_00241731 = 37;
					}
					else if (_0024c1_00241728 == 40 && _0024c2_00241729 == 40)
					{
						_0024newID_00241731 = 41;
					}
					else if (_0024c1_00241728 == 68 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 529;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 68)
					{
						_0024newID_00241731 = 529;
					}
					else if (_0024c1_00241728 == 15 && _0024c2_00241729 == 15)
					{
						_0024newID_00241731 = 42;
					}
					else if (_0024c1_00241728 == 16 && _0024c2_00241729 == 16)
					{
						_0024newID_00241731 = 43;
					}
					else if (_0024c1_00241728 == 44 && _0024c2_00241729 == 44)
					{
						_0024newID_00241731 = 45;
					}
					else if (_0024c1_00241728 == 10 && _0024c2_00241729 == 10)
					{
						_0024newID_00241731 = 16;
					}
					else if (_0024c1_00241728 == 23 && _0024c2_00241729 == 23)
					{
						_0024newID_00241731 = 29;
					}
					else if (_0024c1_00241728 == 39 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 53;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 39)
					{
						_0024newID_00241731 = 53;
					}
					else if (_0024c1_00241728 == 12 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 54;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 12)
					{
						_0024newID_00241731 = 54;
					}
					else if (_0024c1_00241728 == 13 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 55;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 13)
					{
						_0024newID_00241731 = 55;
					}
					else if (_0024c1_00241728 == 51 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 52;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 51)
					{
						_0024newID_00241731 = 52;
					}
					else if (_0024c1_00241728 == 3 && _0024c2_00241729 == 14)
					{
						_0024newID_00241731 = 56;
					}
					else if (_0024c1_00241728 == 14 && _0024c2_00241729 == 3)
					{
						_0024newID_00241731 = 56;
					}
					else if ((_0024c1_00241728 == 47 && _0024c2_00241729 == 47) || (_0024c1_00241728 == 38 && _0024c2_00241729 == 47) || (_0024c1_00241728 == 47 && _0024c2_00241729 == 38))
					{
						_0024newID_00241731 = 48;
					}
					else if ((_0024c1_00241728 == 9 && _0024c2_00241729 == 10) || (_0024c1_00241728 == 10 && _0024c2_00241729 == 9) || (_0024c1_00241728 == 9 && _0024c2_00241729 == 11) || (_0024c1_00241728 == 11 && _0024c2_00241729 == 9) || (_0024c1_00241728 == 10 && _0024c2_00241729 == 11) || (_0024c1_00241728 == 11 && _0024c2_00241729 == 10))
					{
						_0024newID_00241731 = 44;
					}
					else if (_0024c1_00241728 == 44 && _0024c2_00241729 == 44)
					{
						_0024newID_00241731 = 45;
					}
					else
					{
						_0024canCraft_00241726 = false;
					}
					if (_0024newID_00241731 >= 600 && _0024newID_00241731 <= 605)
					{
						MenuScript.canUnlockHat[5] = 1;
					}
					if (_0024canCraft_00241726 && _0024newID_00241731 == 568)
					{
						legendary[0] = 1;
					}
					else if (_0024canCraft_00241726 && _0024newID_00241731 == 569)
					{
						legendary[1] = 1;
					}
					else if (_0024canCraft_00241726 && _0024newID_00241731 == 570)
					{
						legendary[2] = 1;
					}
					if (_0024canCraft_00241726)
					{
						_0024i_00241733 = default(int);
						_0024pood_00241734 = Random.Range(0, 2);
						if (_0024newID_00241731 == 15 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && _0024pood_00241734 == 0)
						{
							_0024newID_00241731 = 42;
						}
						if (_0024newID_00241731 == 16 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && _0024pood_00241734 == 0)
						{
							_0024newID_00241731 = 43;
						}
						if (_0024newID_00241731 == 44 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && _0024pood_00241734 == 0)
						{
							_0024newID_00241731 = 45;
						}
						((Component)_0024self__00241741).audio.PlayOneShot(_0024self__00241741.audioCraftt);
						if (_0024newID_00241731 < 500)
						{
							_0024lowestQ_00241735 = default(int);
							_0024aTemp_00241736 = 1;
							if (_0024newID_00241731 >= 52 && _0024newID_00241731 <= 56)
							{
								_0024aTemp_00241736 = 5;
							}
							if (_0024self__00241741.firstItemSelected.q == _0024self__00241741.secondItemSelected.q)
							{
								_0024lowestQ_00241735 = _0024self__00241741.firstItemSelected.q;
								_0024newItem_00241730 = new Item(_0024newID_00241731, _0024self__00241741.firstItemSelected.q * _0024aTemp_00241736, new int[4], 0f, null);
								inventory[_0024self__00241741.secondItemSelectedSlot] = _0024newItem_00241730;
								inventory[_0024self__00241741.firstItemSelectedSlot] = _0024self__00241741.EmptyItem();
								_0024self__00241741.ResetCraft();
								_0024self__00241741.RefreshInventory();
								_0024self__00241741.RefreshActionBar();
							}
							else if (_0024self__00241741.secondItemSelected.q < _0024self__00241741.firstItemSelected.q)
							{
								_0024lowestQ_00241735 = _0024self__00241741.secondItemSelected.q;
								_0024newItem_00241730 = new Item(_0024newID_00241731, _0024self__00241741.secondItemSelected.q * _0024aTemp_00241736, new int[4], 0f, null);
								inventory[_0024self__00241741.secondItemSelectedSlot] = _0024newItem_00241730;
								inventory[_0024self__00241741.firstItemSelectedSlot].q = inventory[_0024self__00241741.firstItemSelectedSlot].q - _0024self__00241741.secondItemSelected.q;
								_0024self__00241741.ResetCraft();
								_0024self__00241741.RefreshInventory();
								_0024self__00241741.RefreshActionBar();
							}
							else if (_0024self__00241741.firstItemSelected.q < _0024self__00241741.secondItemSelected.q)
							{
								_0024lowestQ_00241735 = _0024self__00241741.firstItemSelected.q;
								_0024newItem_00241730 = new Item(_0024newID_00241731, _0024self__00241741.firstItemSelected.q * _0024aTemp_00241736, new int[4], 0f, null);
								inventory[_0024self__00241741.firstItemSelectedSlot] = _0024newItem_00241730;
								inventory[_0024self__00241741.secondItemSelectedSlot].q = inventory[_0024self__00241741.secondItemSelectedSlot].q - _0024self__00241741.firstItemSelected.q;
								_0024self__00241741.ResetCraft();
								_0024self__00241741.RefreshInventory();
								_0024self__00241741.RefreshActionBar();
							}
						}
						else
						{
							_0024tempForge_00241737 = 6f;
							if (MenuScript.curTrait[1] == 5 || MenuScript.curTrait[2] == 5)
							{
								MonoBehaviour.print((object)"+10 luck FORGING GEAR");
								_0024tempForge_00241737 = 12f;
							}
							_0024newItem_00241730 = new Item(_0024newID_00241731, 1, _0024self__00241741.GetGearStats(_0024newID_00241731), _0024self__00241741.GetMaxDurability(_0024newID_00241731), null);
							_0024luckCount_00241738 = Random.Range(0, 100);
							_0024bonusStat_00241739 = default(int);
							_0024num1_00241740 = default(int);
							if (!((float)_0024luckCount_00241738 >= _0024tempForge_00241737 * 0.5f))
							{
								for (_0024i_00241733 = 0; _0024i_00241733 < 4; _0024i_00241733++)
								{
									_0024bonusStat_00241739 = Random.Range(0, 4);
									_0024num1_00241740 = Random.Range(1, 3);
									_0024newItem_00241730.e[_0024bonusStat_00241739] = _0024newItem_00241730.e[_0024bonusStat_00241739] + _0024num1_00241740;
									_0024newItem_00241730.tier = 3;
								}
							}
							else if (!((float)_0024luckCount_00241738 >= _0024tempForge_00241737))
							{
								for (_0024i_00241733 = 0; _0024i_00241733 < 2; _0024i_00241733++)
								{
									_0024bonusStat_00241739 = Random.Range(0, 4);
									_0024num1_00241740 = Random.Range(1, 3);
									_0024newItem_00241730.e[_0024bonusStat_00241739] = _0024newItem_00241730.e[_0024bonusStat_00241739] + _0024num1_00241740;
									_0024newItem_00241730.tier = 2;
								}
							}
							else if (!((float)_0024luckCount_00241738 >= _0024tempForge_00241737 * 2f))
							{
								for (_0024i_00241733 = 0; _0024i_00241733 < 1; _0024i_00241733++)
								{
									_0024bonusStat_00241739 = Random.Range(0, 4);
									_0024num1_00241740 = Random.Range(1, 3);
									_0024newItem_00241730.e[_0024bonusStat_00241739] = _0024newItem_00241730.e[_0024bonusStat_00241739] + _0024num1_00241740;
									_0024newItem_00241730.tier = 1;
								}
							}
							_0024self__00241741.holdingItem = true;
							_0024self__00241741.itemSelected = _0024newItem_00241730;
							_0024self__00241741.firstItemSelected.q = _0024self__00241741.firstItemSelected.q - 1;
							_0024self__00241741.secondItemSelected.q = _0024self__00241741.secondItemSelected.q - 1;
							if (_0024self__00241741.firstItemSelected.q < 1)
							{
								inventory[_0024self__00241741.firstItemSelectedSlot] = _0024self__00241741.EmptyItem();
							}
							if (_0024self__00241741.secondItemSelected.q < 1)
							{
								inventory[_0024self__00241741.secondItemSelectedSlot] = _0024self__00241741.EmptyItem();
							}
							_0024self__00241741.ResetCraft();
							_0024self__00241741.UpdateHoldingItem();
							_0024self__00241741.RefreshInventory();
							_0024self__00241741.RefreshActionBar();
						}
						tempStats[4] = tempStats[4] + 1;
					}
					else
					{
						_0024self__00241741.ResetCraft();
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

		internal GameScript _0024self__00241742;

		public _0024Craft_00241725(GameScript self_)
		{
			_0024self__00241742 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241742);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SelectReward_00241743 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024temp_00241744;

			internal int _0024bonusScore_00241745;

			internal GameObject _0024dd_00241746;

			internal int _0024c_00241747;

			internal GameScript _0024self__00241748;

			public _0024(int c, GameScript self_)
			{
				_0024c_00241747 = c;
				_0024self__00241748 = self_;
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
				//IL_0444: Unknown result type (might be due to invalid IL or missing references)
				//IL_044e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241748.selectingReward && _0024self__00241748.rewardChest[_0024c_00241747] > 0)
					{
						_0024self__00241748.selectingReward = true;
						_0024temp_00241744 = default(int);
						_0024self__00241748.rewardChestObj[_0024c_00241747].renderer.material = _0024self__00241748.rewOpened;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_0491;
				case 2:
					if (_0024self__00241748.rewardChest[_0024c_00241747] == 999)
					{
						_0024bonusScore_00241745 = _0024self__00241748.GetScoreBonus();
						_0024dd_00241746 = (GameObject)Object.Instantiate(Resources.Load("bonusScore"), _0024self__00241748.rewardChestObj[_0024c_00241747].transform.position, Quaternion.identity);
						_0024dd_00241746.SendMessage("SD", (object)_0024bonusScore_00241745);
						MenuScript.curScore += _0024bonusScore_00241745;
						if (MenuScript.curScore > PlayerPrefs.GetInt("hScore"))
						{
							PlayerPrefs.SetInt("hScore", MenuScript.curScore);
						}
						_0024self__00241748.txtHighScore[0].text = string.Empty + (object)MenuScript.curScore;
						_0024self__00241748.txtHighScore[1].text = string.Empty + (object)MenuScript.curScore;
						_0024self__00241748.rewardChest[_0024c_00241747] = 0;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					if (_0024self__00241748.rewardChest[_0024c_00241747] > 200)
					{
						_0024temp_00241744 = _0024self__00241748.rewardChest[_0024c_00241747];
						_0024temp_00241744 -= 200;
						((MonoBehaviour)_0024self__00241748).StartCoroutine_Auto(_0024self__00241748.UnlockHat(_0024temp_00241744));
						_0024self__00241748.rewardChest[_0024c_00241747] = 0;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					if (_0024self__00241748.rewardChest[_0024c_00241747] >= 100)
					{
						_0024temp_00241744 = _0024self__00241748.rewardChest[_0024c_00241747];
						_0024temp_00241744 -= 100;
						((MonoBehaviour)_0024self__00241748).StartCoroutine_Auto(_0024self__00241748.UnlockComp(_0024temp_00241744));
						_0024self__00241748.rewardChest[_0024c_00241747] = 0;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					_0024temp_00241744 = _0024self__00241748.rewardChest[_0024c_00241747];
					if (MenuScript.raceUnlock[_0024temp_00241744 - 1] > 0)
					{
						if (MenuScript.raceUnlock[_0024temp_00241744 - 1] < 3)
						{
							((MonoBehaviour)_0024self__00241748).StartCoroutine_Auto(_0024self__00241748.UnlockVariant(_0024temp_00241744));
						}
					}
					else
					{
						((MonoBehaviour)_0024self__00241748).StartCoroutine_Auto(_0024self__00241748.UnlockRace(_0024temp_00241744));
					}
					_0024self__00241748.rewardChest[_0024c_00241747] = 0;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241748.selectingReward = false;
					_0024self__00241748.rewardChestObj[_0024c_00241747].renderer.material = _0024self__00241748.rewShade;
					_0024self__00241748.RewardShowCheck();
					goto IL_0491;
				case 4:
					_0024self__00241748.selectingReward = false;
					_0024self__00241748.rewardChestObj[_0024c_00241747].renderer.material = _0024self__00241748.rewShade;
					_0024self__00241748.RewardShowCheck();
					goto IL_0491;
				case 5:
					_0024self__00241748.selectingReward = false;
					_0024self__00241748.rewardChestObj[_0024c_00241747].renderer.material = _0024self__00241748.rewShade;
					_0024self__00241748.RewardShowCheck();
					goto IL_0491;
				case 6:
					_0024self__00241748.selectingReward = false;
					_0024self__00241748.rewardChestObj[_0024c_00241747].renderer.material = _0024self__00241748.rewShade;
					_0024self__00241748.RewardShowCheck();
					goto IL_0491;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0491:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024c_00241749;

		internal GameScript _0024self__00241750;

		public _0024SelectReward_00241743(int c, GameScript self_)
		{
			_0024c_00241749 = c;
			_0024self__00241750 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024c_00241749, _0024self__00241750);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockHat_00241751 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024h_00241752;

			internal GameScript _0024self__00241753;

			public _0024(int h, GameScript self_)
			{
				_0024h_00241752 = h;
				_0024self__00241753 = self_;
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
					_0024self__00241753.txtRewardTop[0].text = "NEW HAT UNLOCKED!";
					_0024self__00241753.rewardIcon.renderer.material = (Material)Resources.Load("hat/hat" + (object)_0024h_00241752);
					PlayerPrefs.SetInt("hU" + (object)_0024h_00241752, 1);
					MenuScript.hatUnlock[_0024h_00241752] = 2;
					_0024self__00241753.txtRewardBot[0].text = string.Empty + _0024self__00241753.GetHatName(_0024h_00241752);
					_0024self__00241753.txtRewardTop[1].text = _0024self__00241753.txtRewardTop[0].text;
					_0024self__00241753.txtRewardBot[1].text = _0024self__00241753.txtRewardBot[0].text;
					_0024self__00241753.rewardShade.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241753.rewardTop.SetActive(true);
					_0024self__00241753.rewardBot.SetActive(true);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024h_00241754;

		internal GameScript _0024self__00241755;

		public _0024UnlockHat_00241751(int h, GameScript self_)
		{
			_0024h_00241754 = h;
			_0024self__00241755 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024h_00241754, _0024self__00241755);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockComp_00241756 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024h_00241757;

			internal GameScript _0024self__00241758;

			public _0024(int h, GameScript self_)
			{
				_0024h_00241757 = h;
				_0024self__00241758 = self_;
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
					_0024self__00241758.txtRewardTop[0].text = "NEW COMPANION UNLOCKED!";
					_0024self__00241758.rewardIcon.renderer.material = (Material)Resources.Load("iComp/c" + (object)_0024h_00241757);
					MenuScript.companionUnlock[_0024h_00241757] = 2;
					PlayerPrefs.SetInt("cU" + (object)_0024h_00241757, 1);
					_0024self__00241758.txtRewardBot[0].text = string.Empty + _0024self__00241758.GetCompName(_0024h_00241757);
					_0024self__00241758.txtRewardTop[1].text = _0024self__00241758.txtRewardTop[0].text;
					_0024self__00241758.txtRewardBot[1].text = _0024self__00241758.txtRewardBot[0].text;
					_0024self__00241758.rewardShade.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241758.rewardTop.SetActive(true);
					_0024self__00241758.rewardBot.SetActive(true);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024h_00241759;

		internal GameScript _0024self__00241760;

		public _0024UnlockComp_00241756(int h, GameScript self_)
		{
			_0024h_00241759 = h;
			_0024self__00241760 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024h_00241759, _0024self__00241760);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockVariant_00241761 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024r_00241762;

			internal GameScript _0024self__00241763;

			public _0024(int r, GameScript self_)
			{
				_0024r_00241762 = r;
				_0024self__00241763 = self_;
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
					MenuScript.raceUnlock[_0024r_00241762 - 1] = MenuScript.raceUnlock[_0024r_00241762 - 1] + 1;
					PlayerPrefs.SetInt("rU" + (object)(_0024r_00241762 - 1), MenuScript.raceUnlock[_0024r_00241762 - 1]);
					_0024self__00241763.txtRewardTop[0].text = "NEW VARIANT UNLOCKED!";
					_0024self__00241763.rewardIcon.renderer.material = (Material)Resources.Load("r/r" + (object)(_0024r_00241762 - 1) + "h" + (object)(MenuScript.raceUnlock[_0024r_00241762 - 1] - 1));
					_0024self__00241763.txtRewardBot[0].text = string.Empty + _0024self__00241763.GetRaceName(_0024r_00241762 - 1) + " Variant " + (object)MenuScript.raceUnlock[_0024r_00241762 - 1];
					_0024self__00241763.txtRewardTop[1].text = _0024self__00241763.txtRewardTop[0].text;
					_0024self__00241763.txtRewardBot[1].text = _0024self__00241763.txtRewardBot[0].text;
					_0024self__00241763.rewardShade.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241763.rewardTop.SetActive(true);
					_0024self__00241763.rewardBot.SetActive(true);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024r_00241764;

		internal GameScript _0024self__00241765;

		public _0024UnlockVariant_00241761(int r, GameScript self_)
		{
			_0024r_00241764 = r;
			_0024self__00241765 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024r_00241764, _0024self__00241765);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UnlockRace_00241766 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024h_00241767;

			internal GameScript _0024self__00241768;

			public _0024(int h, GameScript self_)
			{
				_0024h_00241767 = h;
				_0024self__00241768 = self_;
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
					_0024self__00241768.txtRewardTop[0].text = "NEW RACE UNLOCKED!";
					_0024self__00241768.rewardIcon.renderer.material = (Material)Resources.Load("r/r" + (object)(_0024h_00241767 - 1) + "h0");
					MenuScript.raceUnlock[_0024h_00241767 - 1] = 1;
					PlayerPrefs.SetInt("rU" + (object)(_0024h_00241767 - 1), 1);
					_0024self__00241768.txtRewardBot[0].text = string.Empty + _0024self__00241768.GetRaceName(_0024h_00241767 - 1);
					_0024self__00241768.txtRewardTop[1].text = _0024self__00241768.txtRewardTop[0].text;
					_0024self__00241768.txtRewardBot[1].text = _0024self__00241768.txtRewardBot[0].text;
					_0024self__00241768.rewardShade.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241768.rewardTop.SetActive(true);
					_0024self__00241768.rewardBot.SetActive(true);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024h_00241769;

		internal GameScript _0024self__00241770;

		public _0024UnlockRace_00241766(int h, GameScript self_)
		{
			_0024h_00241769 = h;
			_0024self__00241770 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024h_00241769, _0024self__00241770);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Menuu_00241771 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241772;

			public _0024(GameScript self_)
			{
				_0024self__00241772 = self_;
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
					_0024self__00241772.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241772.DeleteCharacter();
					_0024self__00241772.DeleteInventory();
					isInitialized = false;
					if (_0024self__00241772.dead)
					{
						_0024self__00241772.DeleteCharacter();
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
					_0024self__00241772.SaveInventory();
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

		internal GameScript _0024self__00241773;

		public _0024Menuu_00241771(GameScript self_)
		{
			_0024self__00241773 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241773);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AgainN_00241774 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241775;

			public _0024(GameScript self_)
			{
				_0024self__00241775 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241775.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					PlayerTriggerScript.canTakeDamage = true;
					playersDead = 0;
					_0024self__00241775.DeleteCharacter();
					_0024self__00241775.DeleteInventory();
					isInitialized = false;
					isReturning = false;
					isInstance = false;
					changingScene = false;
					_0024self__00241775.SaveInventory();
					if (_0024self__00241775.dead)
					{
						_0024self__00241775.DeleteCharacter();
					}
					_0024self__00241775.dead = false;
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

		internal GameScript _0024self__00241776;

		public _0024AgainN_00241774(GameScript self_)
		{
			_0024self__00241776 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241776);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ThrowPoison_00241777 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024r_00241778;

			internal GameScript _0024self__00241779;

			public _0024(GameScript self_)
			{
				_0024self__00241779 = self_;
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
					_0024r_00241778 = null;
					if (MenuScript.multiplayer > 0)
					{
						_0024self__00241779.usingPot = true;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_016e;
				case 2:
					if (facingLeft)
					{
						_0024r_00241778 = (GameObject)Network.Instantiate(Resources.Load("poisonL"), player.transform.position, Quaternion.identity, 1);
					}
					else
					{
						_0024r_00241778 = (GameObject)Network.Instantiate(Resources.Load("poisonR"), player.transform.position, Quaternion.identity, 1);
					}
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024r_00241778.SendMessage("Set", (object)player.transform.position);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241779.usingPot = false;
					goto IL_016e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_016e:
					_0024self__00241779.RefreshInventory();
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241780;

		public _0024ThrowPoison_00241777(GameScript self_)
		{
			_0024self__00241780 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241780);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ThrowDagger_00241781 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector2 _0024v_00241782;

			internal GameObject _0024ar_00241783;

			internal Vector2 _0024v2_00241784;

			internal Vector3 _0024object_pos_00241785;

			internal Vector3 _0024mouse_pos_00241786;

			internal float _0024angle_00241787;

			internal int _0024a_00241788;

			internal GameScript _0024self__00241789;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241788 = a;
				_0024self__00241789 = self_;
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
					_0024self__00241789.usingPot = true;
					_0024v_00241782 = default(Vector2);
					_0024ar_00241783 = null;
					_0024v2_00241784 = Vector2.op_Implicit(player.transform.position);
					_0024object_pos_00241785 = default(Vector3);
					_0024mouse_pos_00241786 = default(Vector3);
					_0024angle_00241787 = default(float);
					player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024mouse_pos_00241786 = Input.mousePosition;
					_0024object_pos_00241785 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos_00241786.z = -20f;
					_0024mouse_pos_00241786.x -= _0024object_pos_00241785.x;
					_0024mouse_pos_00241786.y -= _0024object_pos_00241785.y;
					_0024angle_00241787 = Mathf.Atan2(_0024mouse_pos_00241786.y, _0024mouse_pos_00241786.x) * 57.29578f;
					_0024ar_00241783 = (GameObject)Network.Instantiate(Resources.Load("skill/dagger" + (object)_0024a_00241788), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241787)), 0);
					_0024ar_00241783.networkView.RPC("SetN", (RPCMode)2, new object[1] { DEX + DEXBonus });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241789.usingPot = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241790;

		internal GameScript _0024self__00241791;

		public _0024ThrowDagger_00241781(int a, GameScript self_)
		{
			_0024a_00241790 = a;
			_0024self__00241791 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241790, _0024self__00241791);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ThrowRock_00241792 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024r_00241793;

			internal GameScript _0024self__00241794;

			public _0024(GameScript self_)
			{
				_0024self__00241794 = self_;
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
					_0024r_00241793 = null;
					if (MenuScript.multiplayer > 0)
					{
						_0024self__00241794.usingPot = true;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0125;
				case 2:
					if (facingLeft)
					{
						_0024r_00241793 = (GameObject)Network.Instantiate(Resources.Load("stoneL"), player.transform.position, Quaternion.identity, 1);
					}
					else
					{
						_0024r_00241793 = (GameObject)Network.Instantiate(Resources.Load("stoneR"), player.transform.position, Quaternion.identity, 1);
					}
					_0024r_00241793.SendMessage("Set", (object)player.transform.position);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241794.usingPot = false;
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

		internal GameScript _0024self__00241795;

		public _0024ThrowRock_00241792(GameScript self_)
		{
			_0024self__00241795 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241795);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseTotalBiscuit_00241796 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameScript _0024self__00241797;

			public _0024(GameScript self_)
			{
				_0024self__00241797 = self_;
			}

			public override bool MoveNext()
			{
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Expected O, but got Unknown
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Expected O, but got Unknown
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0 && !_0024self__00241797.usingPot)
					{
						_0024self__00241797.usingPot = true;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0172;
				case 2:
					((Component)_0024self__00241797).audio.PlayOneShot((AudioClip)Resources.Load("Au/drink", typeof(AudioClip)));
					tempGearStat[0] = tempGearStat[0] + 3;
					tempGearStat[3] = tempGearStat[3] + 3;
					HP += 3;
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024self__00241797.RefreshActionBar();
					_0024self__00241797.UpdateCharacterWeapon();
					_0024self__00241797.RefreshPlayerStats();
					_0024self__00241797.LoadHearts();
					_0024self__00241797.LoadMana();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241797.usingPot = false;
					goto IL_0172;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0172:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241798;

		public _0024UseTotalBiscuit_00241796(GameScript self_)
		{
			_0024self__00241798 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241798);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseHPPotion_00241799 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024pot_00241800;

			internal int _0024heal_00241801;

			internal GameScript _0024self__00241802;

			public _0024(int heal, GameScript self_)
			{
				_0024heal_00241801 = heal;
				_0024self__00241802 = self_;
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
					if (MenuScript.multiplayer > 0 && HP != MAXHP && !_0024self__00241802.usingPot)
					{
						_0024self__00241802.usingPot = true;
						potsUsed++;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_01ca;
				case 2:
					((Component)_0024self__00241802).audio.PlayOneShot((AudioClip)Resources.Load("Au/drink", typeof(AudioClip)));
					if (HP + _0024heal_00241801 > MAXHP)
					{
						HP = MAXHP;
					}
					else
					{
						HP += _0024heal_00241801;
					}
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024self__00241802.RefreshActionBar();
					_0024self__00241802.UpdateCharacterWeapon();
					_0024self__00241802.LoadHearts();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241802.usingPot = false;
					_0024pot_00241800 = (GameObject)Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
					_0024pot_00241800.SendMessage("SD", (object)_0024heal_00241801);
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

		internal int _0024heal_00241803;

		internal GameScript _0024self__00241804;

		public _0024UseHPPotion_00241799(int heal, GameScript self_)
		{
			_0024heal_00241803 = heal;
			_0024self__00241804 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024heal_00241803, _0024self__00241804);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseManaPotion_00241805 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024pot_00241806;

			internal int _0024heal_00241807;

			internal GameScript _0024self__00241808;

			public _0024(int heal, GameScript self_)
			{
				_0024heal_00241807 = heal;
				_0024self__00241808 = self_;
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
					if (MenuScript.multiplayer > 0 && MAG != MAXMAG && !_0024self__00241808.usingPot)
					{
						_0024self__00241808.usingPot = true;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_018b;
				case 2:
					((Component)_0024self__00241808).audio.PlayOneShot((AudioClip)Resources.Load("Au/drink", typeof(AudioClip)));
					if (MAG + _0024heal_00241807 > MAXMAG)
					{
						MAG = MAXMAG;
					}
					else
					{
						MAG += _0024heal_00241807;
					}
					inventory[curActiveSlot].q = inventory[curActiveSlot].q - 1;
					if (inventory[curActiveSlot].q < 1)
					{
						inventory[curActiveSlot].id = 0;
					}
					_0024self__00241808.UpdateCharacterWeapon();
					_0024self__00241808.RefreshActionBar();
					_0024self__00241808.GUImana.animation.Play();
					_0024self__00241808.LoadMana();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241808.usingPot = false;
					goto IL_018b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_018b:
					_0024pot_00241806 = (GameObject)Object.Instantiate(Resources.Load("healMana"), player.transform.position, Quaternion.identity);
					_0024pot_00241806.SendMessage("SD", (object)_0024heal_00241807);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024heal_00241809;

		internal GameScript _0024self__00241810;

		public _0024UseManaPotion_00241805(int heal, GameScript self_)
		{
			_0024heal_00241809 = heal;
			_0024self__00241810 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024heal_00241809, _0024self__00241810);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseDrum_00241811 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024drum_00241812;

			internal GameScript _0024self__00241813;

			public _0024(int drum, GameScript self_)
			{
				_0024drum_00241812 = drum;
				_0024self__00241813 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c0: Expected O, but got Unknown
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_013f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0144: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Expected O, but got Unknown
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0 && !_0024self__00241813.usingDrum && !_0024self__00241813.usingPot)
					{
						_0024self__00241813.usingPot = true;
						_0024self__00241813.usingDrum = true;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_01dd;
				case 2:
					((Component)_0024self__00241813).audio.PlayOneShot((AudioClip)Resources.Load("Au/drum", typeof(AudioClip)));
					if (_0024drum_00241812 == 0)
					{
						Network.Instantiate(Resources.Load("skill/drumATK"), player.transform.position, Quaternion.identity, 0);
					}
					else if (_0024drum_00241812 == 1)
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
					_0024self__00241813.UpdateCharacterWeapon();
					_0024self__00241813.RefreshActionBar();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241813.usingDrum = false;
					_0024self__00241813.usingPot = false;
					goto IL_01dd;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01dd:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024drum_00241814;

		internal GameScript _0024self__00241815;

		public _0024UseDrum_00241811(int drum, GameScript self_)
		{
			_0024drum_00241814 = drum;
			_0024self__00241815 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024drum_00241814, _0024self__00241815);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UseItem_00241816 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024switch_0024252_00241817;

			internal GameObject _0024it_00241818;

			internal Item _0024item_00241819;

			internal int _0024dood_00241820;

			internal GameObject _0024pot22_00241821;

			internal GameObject _0024it2_00241822;

			internal Item _0024item2_00241823;

			internal int _0024dood1_00241824;

			internal GameObject _0024pot223_00241825;

			internal int _0024nn_00241826;

			internal int _0024nn2_00241827;

			internal Vector2 _0024v1_00241828;

			internal GameObject _0024ar1_00241829;

			internal Vector2 _0024v21_00241830;

			internal Vector3 _0024object_pos1_00241831;

			internal Vector3 _0024mouse_pos1_00241832;

			internal float _0024angle1_00241833;

			internal Vector2 _0024v_00241834;

			internal GameObject _0024ar_00241835;

			internal Vector2 _0024v2_00241836;

			internal Vector3 _0024object_pos_00241837;

			internal Vector3 _0024mouse_pos_00241838;

			internal float _0024angle_00241839;

			internal Vector2 _0024v11_00241840;

			internal GameObject _0024ar11_00241841;

			internal Vector2 _0024v211_00241842;

			internal Vector3 _0024object_pos11_00241843;

			internal Vector3 _0024mouse_pos11_00241844;

			internal float _0024angle11_00241845;

			internal Vector2 _0024vv_00241846;

			internal GameObject _0024arr_00241847;

			internal Vector2 _0024v22_00241848;

			internal Vector3 _0024object_poss_00241849;

			internal Vector3 _0024mouse_poss_00241850;

			internal float _0024anglee_00241851;

			internal GameObject _0024f_00241852;

			internal int _0024noo_00241853;

			internal int _0024noo1_00241854;

			internal GameObject _0024bo_00241855;

			internal int _0024noo2_00241856;

			internal int _0024slot_00241857;

			internal GameScript _0024self__00241858;

			public _0024(int slot, GameScript self_)
			{
				_0024slot_00241857 = slot;
				_0024self__00241858 = self_;
			}

			public override bool MoveNext()
			{
				//IL_022e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0238: Expected O, but got Unknown
				//IL_0335: Unknown result type (might be due to invalid IL or missing references)
				//IL_033f: Expected O, but got Unknown
				//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
				//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
				//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c13: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cab: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cd4: Expected O, but got Unknown
				//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e98: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
				//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f75: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f8a: Expected O, but got Unknown
				//IL_1347: Unknown result type (might be due to invalid IL or missing references)
				//IL_134c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1361: Unknown result type (might be due to invalid IL or missing references)
				//IL_1366: Unknown result type (might be due to invalid IL or missing references)
				//IL_136b: Unknown result type (might be due to invalid IL or missing references)
				//IL_1415: Unknown result type (might be due to invalid IL or missing references)
				//IL_1424: Unknown result type (might be due to invalid IL or missing references)
				//IL_1429: Unknown result type (might be due to invalid IL or missing references)
				//IL_1434: Unknown result type (might be due to invalid IL or missing references)
				//IL_143e: Expected O, but got Unknown
				//IL_17f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_17fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_1811: Unknown result type (might be due to invalid IL or missing references)
				//IL_1816: Unknown result type (might be due to invalid IL or missing references)
				//IL_181b: Unknown result type (might be due to invalid IL or missing references)
				//IL_18ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_18bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_18c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_18cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_18d7: Expected O, but got Unknown
				//IL_1b1a: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b1f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b2a: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b34: Expected O, but got Unknown
				//IL_1a0f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a14: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a1f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1a29: Expected O, but got Unknown
				//IL_19db: Unknown result type (might be due to invalid IL or missing references)
				//IL_19e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_19eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_19f5: Expected O, but got Unknown
				//IL_1c84: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c8e: Expected O, but got Unknown
				//IL_0393: Unknown result type (might be due to invalid IL or missing references)
				//IL_0398: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ac: Expected O, but got Unknown
				//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_06ff: Expected O, but got Unknown
				//IL_106f: Unknown result type (might be due to invalid IL or missing references)
				//IL_107e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1083: Unknown result type (might be due to invalid IL or missing references)
				//IL_108e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1098: Expected O, but got Unknown
				//IL_1541: Unknown result type (might be due to invalid IL or missing references)
				//IL_1550: Unknown result type (might be due to invalid IL or missing references)
				//IL_1555: Unknown result type (might be due to invalid IL or missing references)
				//IL_1560: Unknown result type (might be due to invalid IL or missing references)
				//IL_156a: Expected O, but got Unknown
				//IL_1190: Unknown result type (might be due to invalid IL or missing references)
				//IL_119f: Unknown result type (might be due to invalid IL or missing references)
				//IL_11a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_11af: Unknown result type (might be due to invalid IL or missing references)
				//IL_11b9: Expected O, but got Unknown
				//IL_1664: Unknown result type (might be due to invalid IL or missing references)
				//IL_1673: Unknown result type (might be due to invalid IL or missing references)
				//IL_1678: Unknown result type (might be due to invalid IL or missing references)
				//IL_1683: Unknown result type (might be due to invalid IL or missing references)
				//IL_168d: Expected O, but got Unknown
				//IL_0307: Unknown result type (might be due to invalid IL or missing references)
				//IL_0311: Expected O, but got Unknown
				//IL_0200: Unknown result type (might be due to invalid IL or missing references)
				//IL_020a: Expected O, but got Unknown
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0135: Unknown result type (might be due to invalid IL or missing references)
				//IL_013f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0149: Expected O, but got Unknown
				//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Expected O, but got Unknown
				//IL_0683: Unknown result type (might be due to invalid IL or missing references)
				//IL_068d: Expected O, but got Unknown
				//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_05ae: Expected O, but got Unknown
				//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04fd: Expected O, but got Unknown
				//IL_049a: Unknown result type (might be due to invalid IL or missing references)
				//IL_049f: Unknown result type (might be due to invalid IL or missing references)
				//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_04b4: Expected O, but got Unknown
				//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ad6: Expected O, but got Unknown
				//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a7b: Expected O, but got Unknown
				//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bee: Expected O, but got Unknown
				//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e0f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e1b: Unknown result type (might be due to invalid IL or missing references)
				//IL_1766: Unknown result type (might be due to invalid IL or missing references)
				//IL_177e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1783: Unknown result type (might be due to invalid IL or missing references)
				//IL_1788: Unknown result type (might be due to invalid IL or missing references)
				//IL_1793: Unknown result type (might be due to invalid IL or missing references)
				//IL_179f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1296: Unknown result type (might be due to invalid IL or missing references)
				//IL_12ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_12b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_12c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_12cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_17e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_17f1: Expected O, but got Unknown
				//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e8d: Expected O, but got Unknown
				//IL_1337: Unknown result type (might be due to invalid IL or missing references)
				//IL_1341: Expected O, but got Unknown
				//IL_19ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_19b7: Expected O, but got Unknown
				//IL_1af6: Unknown result type (might be due to invalid IL or missing references)
				//IL_1b00: Expected O, but got Unknown
				//IL_1c01: Unknown result type (might be due to invalid IL or missing references)
				//IL_1c0b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241858.@using && HP > 0 && !isCat)
					{
						_0024self__00241858.@using = true;
						_0024_0024switch_0024252_00241817 = inventory[_0024slot_00241857].id;
						if (_0024_0024switch_0024252_00241817 == 7)
						{
							if (isCooking)
							{
								_0024it_00241818 = null;
								_0024item_00241819 = new Item(8, 1, new int[4], 0f, null);
								if (MenuScript.multiplayer > 0)
								{
									_0024it_00241818 = (GameObject)Network.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity, 1);
									_0024it_00241818.SendMessage("Set", (object)_0024item_00241819);
								}
								else
								{
									_0024it_00241818 = (GameObject)Object.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity);
									_0024it_00241818.SendMessage("Set", (object)_0024item_00241819);
								}
								tempStats[8] = tempStats[8] + 1;
								inventory[_0024slot_00241857].q = inventory[_0024slot_00241857].q - 1;
								if (inventory[_0024slot_00241857].q < 1)
								{
									inventory[_0024slot_00241857].id = 0;
								}
							}
							else if (hunger < _0024self__00241858.maxHunger)
							{
								player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024252_00241817 == 8)
						{
							if (hunger < _0024self__00241858.maxHunger)
							{
								player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024252_00241817 == 21)
						{
							if (isCooking)
							{
								_0024it2_00241822 = null;
								_0024item2_00241823 = new Item(22, 1, new int[4], 0f, null);
								if (MenuScript.multiplayer > 0)
								{
									_0024it2_00241822 = (GameObject)Network.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity, 1);
									_0024it2_00241822.SendMessage("Set", (object)_0024item2_00241823);
								}
								else
								{
									_0024it2_00241822 = (GameObject)Object.Instantiate(Resources.Load("item"), player.transform.position, Quaternion.identity);
									_0024it2_00241822.SendMessage("Set", (object)_0024item2_00241823);
								}
								inventory[_0024slot_00241857].q = inventory[_0024slot_00241857].q - 1;
								if (inventory[_0024slot_00241857].q < 1)
								{
									inventory[_0024slot_00241857].id = 0;
								}
							}
							else if (hunger < _0024self__00241858.maxHunger)
							{
								player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024252_00241817 == 22)
						{
							if (hunger < _0024self__00241858.maxHunger)
							{
								player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
								break;
							}
						}
						else if (_0024_0024switch_0024252_00241817 != 49)
						{
							if (_0024_0024switch_0024252_00241817 == 15)
							{
								((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseHPPotion(2));
							}
							else if (_0024_0024switch_0024252_00241817 == 16)
							{
								((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseManaPotion(3));
							}
							else if (_0024_0024switch_0024252_00241817 == 17)
							{
								((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.ThrowPoison());
							}
							else if (_0024_0024switch_0024252_00241817 == 38)
							{
								((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.ThrowRock());
								inventory[_0024slot_00241857].q = inventory[_0024slot_00241857].q - 1;
								if (inventory[_0024slot_00241857].q < 1)
								{
									inventory[_0024slot_00241857].id = 0;
								}
							}
							else if (_0024_0024switch_0024252_00241817 == 42)
							{
								((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseHPPotion(5));
							}
							else if (_0024_0024switch_0024252_00241817 == 43)
							{
								((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseManaPotion(7));
							}
							else if (_0024_0024switch_0024252_00241817 == 44)
							{
								_0024nn_00241826 = Random.Range(15, 18);
								if (!_0024self__00241858.usingPot)
								{
									if (_0024nn_00241826 == 15)
									{
										((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseHPPotion(2));
									}
									else if (_0024nn_00241826 == 16)
									{
										((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseManaPotion(3));
									}
									else
									{
										((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.ThrowPoison());
									}
								}
							}
							else if (_0024_0024switch_0024252_00241817 == 45)
							{
								_0024nn2_00241827 = Random.Range(15, 18);
								if (!_0024self__00241858.usingPot)
								{
									if (_0024nn2_00241827 == 15)
									{
										((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseHPPotion(4));
									}
									else if (_0024nn2_00241827 == 16)
									{
										((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseManaPotion(7));
									}
									else
									{
										((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.ThrowPoison());
									}
								}
							}
							else if (_0024_0024switch_0024252_00241817 == 46)
							{
								((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseTotalBiscuit());
							}
							else
							{
								if (_0024_0024switch_0024252_00241817 == 48)
								{
									if (MenuScript.multiplayer > 0)
									{
										result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.5f)) ? 1 : 0);
										break;
									}
									_0024self__00241858.@base.animation.Play("a1");
									result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(0.5f)) ? 1 : 0);
									break;
								}
								if (_0024_0024switch_0024252_00241817 == 61)
								{
									_0024v1_00241828 = default(Vector2);
									_0024ar1_00241829 = null;
									_0024v21_00241830 = Vector2.op_Implicit(player.transform.position);
									_0024object_pos1_00241831 = default(Vector3);
									_0024mouse_pos1_00241832 = default(Vector3);
									_0024angle1_00241833 = default(float);
									if (MenuScript.multiplayer > 0)
									{
										player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a4" });
										result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(0.3f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024_0024switch_0024252_00241817 == 78)
								{
									((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseDrum(0));
								}
								else if (_0024_0024switch_0024252_00241817 == 79)
								{
									((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseDrum(1));
								}
								else if (_0024_0024switch_0024252_00241817 == 80)
								{
									((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.UseDrum(2));
								}
								else if (_0024_0024switch_0024252_00241817 == 515)
								{
									if (inventory[23].id >= 52 && inventory[23].id <= 56)
									{
										_0024v_00241834 = default(Vector2);
										_0024ar_00241835 = null;
										_0024v2_00241836 = Vector2.op_Implicit(player.transform.position);
										_0024object_pos_00241837 = default(Vector3);
										_0024mouse_pos_00241838 = default(Vector3);
										_0024angle_00241839 = default(float);
										arrowsShot++;
										if (arrowsShot >= 100)
										{
											MenuScript.canUnlockHat[4] = 1;
										}
										if (MenuScript.multiplayer > 0)
										{
											player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a4" });
											result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(9, new WaitForSeconds(0.3f)) ? 1 : 0);
											break;
										}
									}
								}
								else if (_0024_0024switch_0024252_00241817 == 530)
								{
									if (inventory[23].id >= 52 && inventory[23].id <= 56)
									{
										_0024v11_00241840 = default(Vector2);
										_0024ar11_00241841 = null;
										_0024v211_00241842 = Vector2.op_Implicit(player.transform.position);
										_0024object_pos11_00241843 = default(Vector3);
										_0024mouse_pos11_00241844 = default(Vector3);
										_0024angle11_00241845 = default(float);
										arrowsShot++;
										if (arrowsShot >= 100)
										{
											MenuScript.canUnlockHat[4] = 1;
										}
										if (MenuScript.multiplayer > 0)
										{
											player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a4" });
											result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(10, new WaitForSeconds(0.3f)) ? 1 : 0);
											break;
										}
									}
								}
								else if (_0024_0024switch_0024252_00241817 == 535)
								{
									if (MAG >= 5)
									{
										MAG -= 5;
										_0024self__00241858.LoadMana();
										_0024vv_00241846 = default(Vector2);
										_0024arr_00241847 = null;
										_0024v22_00241848 = Vector2.op_Implicit(player.transform.position);
										_0024object_poss_00241849 = default(Vector3);
										_0024mouse_poss_00241850 = default(Vector3);
										_0024anglee_00241851 = default(float);
										if (MenuScript.multiplayer > 0)
										{
											player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a4" });
											result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(11, new WaitForSeconds(0.3f)) ? 1 : 0);
											break;
										}
									}
								}
								else if (_0024_0024switch_0024252_00241817 == 600)
								{
									if (MAG >= 1)
									{
										_0024f_00241852 = null;
										if (MenuScript.pHat == 11)
										{
											_0024noo_00241853 = Random.Range(0, 3);
											if (_0024noo_00241853 == 0)
											{
												_0024self__00241858.UseMana(1);
											}
										}
										else
										{
											_0024self__00241858.UseMana(1);
										}
										if (MenuScript.multiplayer > 0)
										{
											player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a3" });
											result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(12, new WaitForSeconds(0.3f)) ? 1 : 0);
											break;
										}
										goto IL_1a49;
									}
								}
								else if (_0024_0024switch_0024252_00241817 == 601)
								{
									if (MAG >= 1)
									{
										if (MenuScript.pHat == 11)
										{
											_0024noo1_00241854 = Random.Range(0, 3);
											if (_0024noo1_00241854 == 0)
											{
												_0024self__00241858.UseMana(1);
											}
										}
										else
										{
											_0024self__00241858.UseMana(1);
										}
										if (MenuScript.multiplayer > 0)
										{
											player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
											result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(13, new WaitForSeconds(0.5f)) ? 1 : 0);
											break;
										}
										goto IL_1b54;
									}
								}
								else if (_0024_0024switch_0024252_00241817 == 602)
								{
									if (MAG >= 3)
									{
										if (MenuScript.pHat == 11)
										{
											_0024noo2_00241856 = Random.Range(0, 3);
											if (_0024noo2_00241856 == 0)
											{
												_0024self__00241858.UseMana(3);
											}
										}
										else
										{
											_0024self__00241858.UseMana(3);
										}
										if (MenuScript.multiplayer > 0)
										{
											player.networkView.RPC("mA", (RPCMode)2, new object[1] { "a1" });
											result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(14, new WaitForSeconds(0.5f)) ? 1 : 0);
											break;
										}
										goto IL_1c2f;
									}
								}
								else
								{
									((MonoBehaviour)_0024self__00241858).StartCoroutine_Auto(_0024self__00241858.MeleeAttack());
								}
							}
						}
						goto IL_1c66;
					}
					goto IL_1c9f;
				case 2:
					((Component)_0024self__00241858).audio.PlayOneShot((AudioClip)Resources.Load("Au/eat", typeof(AudioClip)));
					hunger++;
					_0024self__00241858.UpdateHunger();
					_0024self__00241858.Poop();
					tempStats[8] = tempStats[8] + 1;
					inventory[_0024slot_00241857].q = inventory[_0024slot_00241857].q - 1;
					if (inventory[_0024slot_00241857].q < 1)
					{
						inventory[_0024slot_00241857].id = 0;
					}
					goto IL_1c66;
				case 3:
					((Component)_0024self__00241858).audio.PlayOneShot((AudioClip)Resources.Load("Au/eat", typeof(AudioClip)));
					hunger += 3;
					_0024dood_00241820 = Random.Range(0, 2);
					if (_0024dood_00241820 == 0 && HP < MAXHP)
					{
						HP++;
						_0024pot22_00241821 = (GameObject)Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
						_0024pot22_00241821.SendMessage("SD", (object)1);
						_0024self__00241858.LoadHearts();
					}
					tempStats[8] = tempStats[8] + 1;
					_0024self__00241858.UpdateHunger();
					_0024self__00241858.Poop();
					inventory[_0024slot_00241857].q = inventory[_0024slot_00241857].q - 1;
					if (inventory[_0024slot_00241857].q < 1)
					{
						inventory[_0024slot_00241857].id = 0;
					}
					goto IL_1c66;
				case 4:
					tempStats[8] = tempStats[8] + 1;
					hunger++;
					_0024self__00241858.UpdateHunger();
					_0024self__00241858.Poop();
					inventory[_0024slot_00241857].q = inventory[_0024slot_00241857].q - 1;
					if (inventory[_0024slot_00241857].q < 1)
					{
						inventory[_0024slot_00241857].id = 0;
					}
					goto IL_1c66;
				case 5:
					hunger += 4;
					_0024dood1_00241824 = Random.Range(0, 2);
					if (_0024dood1_00241824 == 0 && HP < MAXHP)
					{
						HP++;
						_0024pot223_00241825 = (GameObject)Object.Instantiate(Resources.Load("heal"), player.transform.position, Quaternion.identity);
						_0024pot223_00241825.SendMessage("SD", (object)1);
						_0024self__00241858.LoadHearts();
					}
					tempStats[8] = tempStats[8] + 1;
					_0024self__00241858.UpdateHunger();
					_0024self__00241858.Poop();
					inventory[_0024slot_00241857].q = inventory[_0024slot_00241857].q - 1;
					if (inventory[_0024slot_00241857].q < 1)
					{
						inventory[_0024slot_00241857].id = 0;
					}
					goto IL_1c66;
				case 6:
					Network.Instantiate(Resources.Load("interact/fire"), player.transform.position, Quaternion.identity, 1);
					goto IL_0aff;
				case 7:
					Object.Instantiate(Resources.Load("interact/fire"), player.transform.position, Quaternion.identity);
					goto IL_0aff;
				case 8:
					_0024mouse_pos1_00241832 = Input.mousePosition;
					_0024object_pos1_00241831 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos1_00241832.z = -20f;
					_0024mouse_pos1_00241832.x -= _0024object_pos1_00241831.x;
					_0024mouse_pos1_00241832.y -= _0024object_pos1_00241831.y;
					_0024angle1_00241833 = Mathf.Atan2(_0024mouse_pos1_00241832.y, _0024mouse_pos1_00241832.x) * 57.29578f;
					_0024ar1_00241829 = (GameObject)Network.Instantiate(Resources.Load("skill/lightBlast"), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle1_00241833)), 0);
					inventory[_0024slot_00241857].q = inventory[_0024slot_00241857].q - 1;
					if (inventory[_0024slot_00241857].q < 1)
					{
						inventory[_0024slot_00241857].id = 0;
					}
					goto IL_1c66;
				case 9:
					_0024mouse_pos_00241838 = Input.mousePosition;
					_0024object_pos_00241837 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos_00241838.z = -20f;
					_0024mouse_pos_00241838.x -= _0024object_pos_00241837.x;
					_0024mouse_pos_00241838.y -= _0024object_pos_00241837.y;
					_0024angle_00241839 = Mathf.Atan2(_0024mouse_pos_00241838.y, _0024mouse_pos_00241838.x) * 57.29578f;
					_0024ar_00241835 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + (object)inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241839)), 0);
					_0024ar_00241835.networkView.RPC("SetN", (RPCMode)2, new object[1] { DEX + DEXBonus + drumDEX });
					inventory[23].q = inventory[23].q - 1;
					if (inventory[23].q <= 0)
					{
						inventory[23] = _0024self__00241858.EmptyItem();
					}
					if (multishot)
					{
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle_00241839 -= 10f;
							_0024ar_00241835 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + (object)inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241839)), 0);
							_0024ar_00241835.networkView.RPC("SetN", (RPCMode)2, new object[1] { 2 * (DEX + DEXBonus + drumDEX) });
							_0024ar_00241835.networkView.RPC("SetMulti", (RPCMode)2, new object[0]);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241858.EmptyItem();
							}
						}
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle_00241839 += 20f;
							_0024ar_00241835 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + (object)inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00241839)), 0);
							_0024ar_00241835.networkView.RPC("SetN", (RPCMode)2, new object[1] { 2 * (DEX + DEXBonus + drumDEX) });
							_0024ar_00241835.networkView.RPC("SetMulti", (RPCMode)2, new object[0]);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241858.EmptyItem();
							}
						}
						multishot = false;
					}
					goto IL_1c66;
				case 10:
					_0024mouse_pos11_00241844 = Input.mousePosition;
					_0024object_pos11_00241843 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_pos11_00241844.z = -20f;
					_0024mouse_pos11_00241844.x -= _0024object_pos11_00241843.x;
					_0024mouse_pos11_00241844.y -= _0024object_pos11_00241843.y;
					_0024angle11_00241845 = Mathf.Atan2(_0024mouse_pos11_00241844.y, _0024mouse_pos11_00241844.x) * 57.29578f;
					_0024ar11_00241841 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + (object)inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle11_00241845)), 0);
					_0024ar11_00241841.networkView.RPC("SetN", (RPCMode)2, new object[1] { DEX + DEXBonus + drumDEX + 7 });
					_0024ar11_00241841.networkView.RPC("SetMulti", (RPCMode)2, new object[0]);
					inventory[23].q = inventory[23].q - 1;
					if (inventory[23].q <= 0)
					{
						inventory[23] = _0024self__00241858.EmptyItem();
					}
					if (multishot)
					{
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle11_00241845 -= 10f;
							_0024ar11_00241841 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + (object)inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle11_00241845)), 0);
							_0024ar11_00241841.networkView.RPC("SetN", (RPCMode)2, new object[1] { 2 * (DEX + DEXBonus + drumDEX + 7) });
							_0024ar11_00241841.networkView.RPC("SetMulti", (RPCMode)2, new object[0]);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241858.EmptyItem();
							}
						}
						if (inventory[23].id >= 52 && inventory[23].id <= 56)
						{
							_0024angle11_00241845 += 20f;
							_0024ar11_00241841 = (GameObject)Network.Instantiate(Resources.Load("skill/arrow" + (object)inventory[23].id), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle11_00241845)), 0);
							_0024ar11_00241841.networkView.RPC("SetN", (RPCMode)2, new object[1] { 2 * (DEX + DEXBonus + drumDEX + 7) });
							_0024ar11_00241841.networkView.RPC("SetMulti", (RPCMode)2, new object[0]);
							inventory[23].q = inventory[23].q - 1;
							if (inventory[23].q == 0)
							{
								inventory[23] = _0024self__00241858.EmptyItem();
							}
						}
						multishot = false;
					}
					goto IL_1c66;
				case 11:
					_0024mouse_poss_00241850 = Input.mousePosition;
					_0024object_poss_00241849 = Camera.main.WorldToScreenPoint(player.transform.position);
					_0024mouse_poss_00241850.z = -20f;
					_0024mouse_poss_00241850.x -= _0024object_poss_00241849.x;
					_0024mouse_poss_00241850.y -= _0024object_poss_00241849.y;
					_0024anglee_00241851 = Mathf.Atan2(_0024mouse_poss_00241850.y, _0024mouse_poss_00241850.x) * 57.29578f;
					_0024arr_00241847 = (GameObject)Network.Instantiate(Resources.Load("skill/crossBolt"), player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024anglee_00241851)), 0);
					_0024arr_00241847.networkView.RPC("SetN", (RPCMode)2, new object[1] { DEX + DEXBonus + drumDEX + 20 });
					goto IL_1c66;
				case 12:
					if (facingLeft)
					{
						_0024f_00241852 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballL"), player.transform.position, Quaternion.identity, 0);
					}
					else
					{
						_0024f_00241852 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballR"), player.transform.position, Quaternion.identity, 0);
					}
					_0024f_00241852.SendMessage("Set", (object)(MAXMAG + drumMAG));
					goto IL_1a49;
				case 13:
					_0024bo_00241855 = (GameObject)Network.Instantiate(Resources.Load("proj/bolt"), player.transform.position, Quaternion.identity, 0);
					_0024bo_00241855.SendMessage("Set", (object)(MAXMAG + drumMAG));
					goto IL_1b54;
				case 14:
					player.SendMessage("iceShard", (object)(MAXMAG + drumMAG));
					goto IL_1c2f;
				case 15:
					_0024self__00241858.@using = false;
					goto IL_1c9f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_1c66:
					_0024self__00241858.RefreshActionBar();
					_0024self__00241858.UpdateCharacterWeapon();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(15, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
					IL_0aff:
					inventory[_0024slot_00241857].q = inventory[_0024slot_00241857].q - 1;
					if (inventory[_0024slot_00241857].q < 1)
					{
						inventory[_0024slot_00241857].id = 0;
					}
					goto IL_1c66;
					IL_1a49:
					_0024self__00241858.GUImana.animation.Play();
					goto IL_1c66;
					IL_1c2f:
					_0024self__00241858.GUImana.animation.Play();
					goto IL_1c66;
					IL_1c9f:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
					IL_1b54:
					_0024self__00241858.GUImana.animation.Play();
					goto IL_1c66;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024slot_00241859;

		internal GameScript _0024self__00241860;

		public _0024UseItem_00241816(int slot, GameScript self_)
		{
			_0024slot_00241859 = slot;
			_0024self__00241860 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024slot_00241859, _0024self__00241860);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MeleeAttack_00241861 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024temp_00241862;

			internal int _0024nuu_00241863;

			internal int _0024id_00241864;

			internal GameObject _0024gg_00241865;

			internal GameObject _0024f_00241866;

			internal GameScript _0024self__00241867;

			public _0024(GameScript self_)
			{
				_0024self__00241867 = self_;
			}

			public override bool MoveNext()
			{
				//IL_019c: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Expected O, but got Unknown
				//IL_0420: Unknown result type (might be due to invalid IL or missing references)
				//IL_042a: Expected O, but got Unknown
				//IL_024f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0254: Unknown result type (might be due to invalid IL or missing references)
				//IL_0266: Unknown result type (might be due to invalid IL or missing references)
				//IL_026b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0279: Unknown result type (might be due to invalid IL or missing references)
				//IL_027e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0289: Unknown result type (might be due to invalid IL or missing references)
				//IL_0293: Expected O, but got Unknown
				//IL_0349: Unknown result type (might be due to invalid IL or missing references)
				//IL_034e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0359: Unknown result type (might be due to invalid IL or missing references)
				//IL_0363: Expected O, but got Unknown
				//IL_0315: Unknown result type (might be due to invalid IL or missing references)
				//IL_031a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0325: Unknown result type (might be due to invalid IL or missing references)
				//IL_032f: Expected O, but got Unknown
				//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0401: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024temp_00241862 = default(float);
					if (_0024self__00241867.canAttack && HP > 0 && !isCat && MenuScript.multiplayer > 0)
					{
						_0024self__00241867.ATKING = true;
						attacking = true;
						_0024self__00241867.canAttack = false;
						_0024self__00241867.@using = true;
						_0024temp_00241862 = SPD;
						SPD *= 0.5f;
						PlayerController.mode = 3;
						player.networkView.RPC("mA", (RPCMode)2, new object[1] { _0024self__00241867.atkAnim });
						if (MenuScript.pHat == 19)
						{
							_0024nuu_00241863 = Random.Range(0, 10);
							if (_0024nuu_00241863 == 0)
							{
								vBonus = _0024self__00241867.ATK;
								player.networkView.RPC("VN", (RPCMode)2, new object[1] { 1 });
							}
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00241867.atkWait)) ? 1 : 0);
						break;
					}
					goto IL_0491;
				case 2:
					PlayerControllerN.aCube.SetActive(true);
					_0024id_00241864 = inventory[curActiveSlot].id;
					if (_0024id_00241864 == 565 && MAG >= 1)
					{
						_0024self__00241867.UseMana(1);
						Network.Instantiate(Resources.Load("haz/fE"), PlayerControllerN.aCube.transform.position, Quaternion.identity, 0);
					}
					else if (_0024id_00241864 == 568)
					{
						_0024self__00241867.Ice();
					}
					else if (_0024id_00241864 == 569)
					{
						_0024self__00241867.Fireball();
					}
					else if (_0024id_00241864 == 570)
					{
						_0024self__00241867.Bolt();
					}
					if (MenuScript.pHat == 8 && _0024id_00241864 == 0 && MAG >= 1)
					{
						_0024self__00241867.UseMana(1);
						_0024gg_00241865 = (GameObject)Network.Instantiate(Resources.Load("rckP"), new Vector3(PlayerControllerN.aCube.transform.position.x, player.transform.position.y + 35f, 0f), Quaternion.identity, 0);
						_0024gg_00241865.networkView.RPC("SetH", (RPCMode)2, new object[1] { MAXMAG });
					}
					else if (MenuScript.pHat == 16 && _0024id_00241864 == 0 && MAG >= 1)
					{
						_0024self__00241867.UseMana(1);
						_0024f_00241866 = null;
						if (facingLeft)
						{
							_0024f_00241866 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballL"), player.transform.position, Quaternion.identity, 0);
						}
						else
						{
							_0024f_00241866 = (GameObject)Network.Instantiate(Resources.Load("proj/fireballR"), player.transform.position, Quaternion.identity, 0);
						}
						_0024f_00241866.SendMessage("Set", (object)MAXMAG);
					}
					else if (MenuScript.pHat == 21 && _0024id_00241864 == 0 && MAG > 0)
					{
						if (facingLeft)
						{
							Network.Instantiate(Resources.Load("e/summon"), player.transform.position, Quaternion.Euler(0f, 180f, 0f), 0);
						}
						else
						{
							Network.Instantiate(Resources.Load("e/summon"), player.transform.position, Quaternion.Euler(0f, 0f, 0f), 0);
						}
						_0024self__00241867.UseMana(1);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 3:
					PlayerControllerN.aCube.SetActive(false);
					if (vBonus > 0)
					{
						((MonoBehaviour)_0024self__00241867).StartCoroutine_Auto(_0024self__00241867.v());
					}
					SPD = _0024temp_00241862;
					_0024self__00241867.canAttack = true;
					_0024self__00241867.@using = false;
					attacking = false;
					_0024self__00241867.ATKING = false;
					goto IL_0491;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0491:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241868;

		public _0024MeleeAttack_00241861(GameScript self_)
		{
			_0024self__00241868 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241868);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024v_00241869 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					vBonus = 0;
					player.networkView.RPC("VN", (RPCMode)2, new object[1] { 0 });
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
	internal sealed class _0024KnockBack_00241870 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024632_00241871;

			internal Vector3 _0024_0024633_00241872;

			internal int _0024_0024634_00241873;

			internal Vector3 _0024_0024635_00241874;

			internal int _0024_0024636_00241875;

			internal Vector3 _0024_0024637_00241876;

			internal int _0024_0024638_00241877;

			internal Vector3 _0024_0024639_00241878;

			internal int _0024_0024640_00241879;

			internal Vector3 _0024_0024641_00241880;

			internal Transform _0024h_00241881;

			public _0024(Transform h)
			{
				_0024h_00241881 = h;
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
					int num5 = (_0024_0024632_00241871 = 5);
					Vector3 val7 = (_0024_0024633_00241872 = ((Component)_0024h_00241881).rigidbody.velocity);
					float num6 = (_0024_0024633_00241872.y = _0024_0024632_00241871);
					Vector3 val9 = (((Component)_0024h_00241881).rigidbody.velocity = _0024_0024633_00241872);
					if (_0024h_00241881.position.x <= player.transform.position.x)
					{
						int num7 = (_0024_0024636_00241875 = -15);
						Vector3 val10 = (_0024_0024637_00241876 = ((Component)_0024h_00241881).rigidbody.velocity);
						float num8 = (_0024_0024637_00241876.x = _0024_0024636_00241875);
						Vector3 val12 = (((Component)_0024h_00241881).rigidbody.velocity = _0024_0024637_00241876);
					}
					else
					{
						int num9 = (_0024_0024634_00241873 = 15);
						Vector3 val13 = (_0024_0024635_00241874 = ((Component)_0024h_00241881).rigidbody.velocity);
						float num10 = (_0024_0024635_00241874.x = _0024_0024634_00241873);
						Vector3 val15 = (((Component)_0024h_00241881).rigidbody.velocity = _0024_0024635_00241874);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				}
				case 2:
					if (Object.op_Implicit((Object)(object)_0024h_00241881))
					{
						int num = (_0024_0024638_00241877 = 0);
						Vector3 val = (_0024_0024639_00241878 = ((Component)_0024h_00241881).rigidbody.velocity);
						float num2 = (_0024_0024639_00241878.y = _0024_0024638_00241877);
						Vector3 val3 = (((Component)_0024h_00241881).rigidbody.velocity = _0024_0024639_00241878);
						int num3 = (_0024_0024640_00241879 = 0);
						Vector3 val4 = (_0024_0024641_00241880 = ((Component)_0024h_00241881).rigidbody.velocity);
						float num4 = (_0024_0024641_00241880.x = _0024_0024640_00241879);
						Vector3 val6 = (((Component)_0024h_00241881).rigidbody.velocity = _0024_0024641_00241880);
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

		internal Transform _0024h_00241882;

		public _0024KnockBack_00241870(Transform h)
		{
			_0024h_00241882 = h;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024h_00241882);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00241883 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024ploop_00241884;

			internal int _0024ttt_00241885;

			internal GameScript _0024self__00241886;

			public _0024(GameScript self_)
			{
				_0024self__00241886 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0296: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Expected O, but got Unknown
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_012f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024ploop_00241884 = default(int);
					_0024ttt_00241885 = 0;
					for (_0024ploop_00241884 = 0; _0024ploop_00241884 < 3; _0024ploop_00241884++)
					{
						if (legendary[_0024ploop_00241884] == 1)
						{
							_0024ttt_00241885++;
						}
					}
					if (_0024ttt_00241885 == 3)
					{
						MenuScript.canUnlockCompanion[7] = 1;
					}
					player.SendMessage("TimerSet", (object)timer);
					if (isCat)
					{
						isCat = false;
						player.SendMessage("Cat", (object)0);
					}
					if (inventoryOpen)
					{
						_0024self__00241886.OpenInventory();
					}
					_0024self__00241886.sSelected.SetActive(false);
					isTown = false;
					_0024self__00241886.dead = true;
					menuOpen = true;
					_0024self__00241886.menuExit.SetActive(false);
					inventoryOpen = false;
					isInitialized = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
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
					if (win)
					{
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
						MonoBehaviour.print((object)("POTS USED " + (object)potsUsed));
						if (potsUsed < 1)
						{
							MenuScript.canUnlockRace[8] = 1;
						}
						MonoBehaviour.print((object)("PIGGY : " + (object)MenuScript.canUnlockRace[8]));
						((Component)_0024self__00241886.txtDied).gameObject.SetActive(false);
						_0024self__00241886.menuVictory.SetActive(true);
					}
					_0024self__00241886.ShowTimer();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241886.SaveStats();
					if (Object.op_Implicit((Object)(object)_0024self__00241886.menuStats))
					{
						_0024self__00241886.menuStats.SetActive(true);
					}
					((MonoBehaviour)_0024self__00241886).StartCoroutine_Auto(_0024self__00241886.ShowStats());
					if (Network.isServer)
					{
						_0024self__00241886.bAgain.SetActive(true);
						_0024self__00241886.bMenu.SetActive(true);
					}
					else
					{
						_0024self__00241886.bAgain.SetActive(false);
						_0024self__00241886.bMenu.SetActive(false);
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

		internal GameScript _0024self__00241887;

		public _0024Die_00241883(GameScript self_)
		{
			_0024self__00241887 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241887);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShowStats_00241888 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241889;

			internal GameScript _0024self__00241890;

			public _0024(GameScript self_)
			{
				_0024self__00241890 = self_;
			}

			public override bool MoveNext()
			{
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241889 = default(int);
					_0024self__00241890.txtHighScore[0].text = string.Empty + (object)MenuScript.curScore;
					_0024self__00241890.txtHighScore[1].text = string.Empty + (object)MenuScript.curScore;
					_0024i_00241889 = 1;
					goto IL_00bc;
				case 2:
					_0024i_00241889++;
					goto IL_00bc;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00bc:
					if (_0024i_00241889 < 12)
					{
						((MonoBehaviour)_0024self__00241890).StartCoroutine_Auto(_0024self__00241890.StatShow(_0024i_00241889));
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241891;

		public _0024ShowStats_00241888(GameScript self_)
		{
			_0024self__00241891 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241891);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShowEXP_00241892 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024pLevel_00241893;

			internal float _0024curEXP_00241894;

			internal float _0024cap_00241895;

			internal int _0024i_00241896;

			internal GameScript _0024self__00241897;

			public _0024(GameScript self_)
			{
				_0024self__00241897 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024pLevel_00241893 = _0024self__00241897.GetPlayerLevel();
					_0024curEXP_00241894 = _0024self__00241897.GetCurEXP(_0024pLevel_00241893);
					_0024cap_00241895 = _0024self__00241897.GetLevelCap(_0024pLevel_00241893);
					_0024self__00241897.txtLevelEXP.text = "Level: " + (object)_0024pLevel_00241893;
					_0024i_00241896 = default(int);
					_0024i_00241896 = 0;
					goto IL_019f;
				case 2:
					_0024i_00241896++;
					goto IL_019f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_019f:
					if ((float)_0024i_00241896 < _0024self__00241897.tempEXP)
					{
						_0024curEXP_00241894 += 1f;
						_0024self__00241897.accountEXP++;
						if (!(_0024curEXP_00241894 < _0024cap_00241895))
						{
							_0024pLevel_00241893++;
							_0024self__00241897.expBack2.animation.Play();
							_0024curEXP_00241894 = _0024self__00241897.GetCurEXP(_0024pLevel_00241893);
							_0024cap_00241895 = _0024self__00241897.GetLevelCap(_0024pLevel_00241893);
							_0024self__00241897.txtLevelEXP.text = "Level: " + (object)_0024pLevel_00241893;
						}
						_0024self__00241897.txtPercent.text = (object)_0024curEXP_00241894 + "/" + (object)_0024cap_00241895;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.01f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241898;

		public _0024ShowEXP_00241892(GameScript self_)
		{
			_0024self__00241898 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241898);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024StatShow_00241899 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00241900;

			internal int _0024i_00241901;

			internal int _0024a_00241902;

			internal GameScript _0024self__00241903;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241902 = a;
				_0024self__00241903 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024s_00241900 = _0024self__00241903.GetStatsName(_0024a_00241902);
					_0024i_00241901 = 0;
					_0024self__00241903.statObj[_0024a_00241902].SetActive(true);
					_0024self__00241903.txtStats[_0024a_00241902].text = _0024s_00241900 + ": " + (object)_0024i_00241901;
					_0024i_00241901 = 0;
					goto IL_00eb;
				case 2:
					_0024i_00241901++;
					goto IL_00eb;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00eb:
					if (_0024i_00241901 < tempStats[_0024a_00241902] + 1)
					{
						_0024self__00241903.txtStats[_0024a_00241902].text = _0024s_00241900 + ": " + (object)_0024i_00241901;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.01f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241904;

		internal GameScript _0024self__00241905;

		public _0024StatShow_00241899(int a, GameScript self_)
		{
			_0024a_00241904 = a;
			_0024self__00241905 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241904, _0024self__00241905);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AdditionalStat_00241906 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241907;

			internal GameScript _0024self__00241908;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241907 = a;
				_0024self__00241908 = self_;
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
					_0024self__00241908.LUP[_0024a_00241907].SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(3.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241908.LUP[_0024a_00241907].SetActive(false);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241909;

		internal GameScript _0024self__00241910;

		public _0024AdditionalStat_00241906(int a, GameScript self_)
		{
			_0024a_00241909 = a;
			_0024self__00241910 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241909, _0024self__00241910);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShowLUP_00241911 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241912;

			internal GameScript _0024self__00241913;

			public _0024(int a, GameScript self_)
			{
				_0024a_00241912 = a;
				_0024self__00241913 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				//IL_0040: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241913.LUP[_0024a_00241912].SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241913.LUP[_0024a_00241912].SetActive(false);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241914;

		internal GameScript _0024self__00241915;

		public _0024ShowLUP_00241911(int a, GameScript self_)
		{
			_0024a_00241914 = a;
			_0024self__00241915 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241914, _0024self__00241915);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LevelUp_00241916 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241917;

			internal GameObject _0024pp_00241918;

			internal int _0024num_00241919;

			internal int _0024num1_00241920;

			internal int _0024num2_00241921;

			internal int _0024num3_00241922;

			internal int _0024doodo_00241923;

			internal int _0024ppp_00241924;

			internal GameScript _0024self__00241925;

			public _0024(GameScript self_)
			{
				_0024self__00241925 = self_;
			}

			public override bool MoveNext()
			{
				//IL_048d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0497: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					playerLevel++;
					_0024self__00241925.txtLevel.text = "Lv: " + (object)playerLevel;
					_0024i_00241917 = default(int);
					_0024pp_00241918 = null;
					for (_0024i_00241917 = 0; _0024i_00241917 < 4; _0024i_00241917++)
					{
						if (_0024i_00241917 == MenuScript.growthStatGood1 || _0024i_00241917 == MenuScript.growthStatGood2)
						{
							if (playerLevel % 2 == 0)
							{
								tempLevelStat[_0024i_00241917]++;
								((MonoBehaviour)_0024self__00241925).StartCoroutine_Auto(_0024self__00241925.ShowLUP(_0024i_00241917));
								if (_0024i_00241917 == 0)
								{
									HP++;
								}
							}
						}
						else if (_0024i_00241917 == MenuScript.growthStatBad)
						{
							if (playerLevel % 4 == 0)
							{
								tempLevelStat[_0024i_00241917]++;
								((MonoBehaviour)_0024self__00241925).StartCoroutine_Auto(_0024self__00241925.ShowLUP(_0024i_00241917));
								if (_0024i_00241917 == 0)
								{
									HP++;
								}
							}
						}
						else if (playerLevel % 3 == 0)
						{
							tempLevelStat[_0024i_00241917]++;
							((MonoBehaviour)_0024self__00241925).StartCoroutine_Auto(_0024self__00241925.ShowLUP(_0024i_00241917));
							if (_0024i_00241917 == 0)
							{
								HP++;
							}
						}
					}
					if (MenuScript.companion == 8)
					{
						tempLevelStat[0] = tempLevelStat[0] + 1;
						tempLevelStat[1] = tempLevelStat[1] + 1;
						tempLevelStat[2] = tempLevelStat[2] + 1;
						tempLevelStat[3] = tempLevelStat[3] + 1;
					}
					if (MenuScript.pHat == 3)
					{
						_0024num_00241919 = Random.Range(0, 3);
						if (_0024num_00241919 == 0)
						{
							tempLevelStat[1] = tempLevelStat[1] + 1;
							((MonoBehaviour)_0024self__00241925).StartCoroutine_Auto(_0024self__00241925.AdditionalStat(1));
						}
					}
					else if (MenuScript.pHat == 4)
					{
						_0024num1_00241920 = Random.Range(0, 3);
						if (_0024num1_00241920 == 0)
						{
							tempLevelStat[2] = tempLevelStat[2] + 1;
							((MonoBehaviour)_0024self__00241925).StartCoroutine_Auto(_0024self__00241925.AdditionalStat(2));
						}
					}
					else if (MenuScript.pHat == 5)
					{
						_0024num2_00241921 = Random.Range(0, 3);
						if (_0024num2_00241921 == 0)
						{
							tempLevelStat[3] = tempLevelStat[3] + 1;
							((MonoBehaviour)_0024self__00241925).StartCoroutine_Auto(_0024self__00241925.AdditionalStat(3));
						}
					}
					else if (MenuScript.pHat == 12)
					{
						_0024num3_00241922 = Random.Range(0, 3);
						if (_0024num3_00241922 == 0)
						{
							_0024doodo_00241923 = Random.Range(0, 4);
							tempLevelStat[_0024doodo_00241923]++;
							((MonoBehaviour)_0024self__00241925).StartCoroutine_Auto(_0024self__00241925.AdditionalStat(_0024doodo_00241923));
						}
					}
					MAXHP = MenuScript.playerStat[0] + tempPlayerStat[0] + tempLevelStat[0];
					_0024self__00241925.ATK = MenuScript.playerStat[1] + tempPlayerStat[1] + tempLevelStat[1];
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
					if (MenuScript.multiplayer > 0)
					{
						player.networkView.RPC("LevelUp", (RPCMode)2, new object[0]);
						goto IL_04a7;
					}
					PlayerController.lUp.SetActive(true);
					player.audio.PlayOneShot(_0024self__00241925.audioLevelUp);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					PlayerController.lUp.SetActive(false);
					goto IL_04a7;
				case 1:
					{
						result = 0;
						break;
					}
					IL_04a7:
					if (playerLevel % 5 == 0 && curSkill <= 2)
					{
						_0024self__00241925.SkillMenu();
					}
					_0024self__00241925.RefreshPlayerStats();
					_0024self__00241925.LoadHearts();
					_0024self__00241925.LoadMana();
					_0024ppp_00241924 = playerLevel;
					if (_0024ppp_00241924 <= 4)
					{
						_0024self__00241925.maxStamina = 4;
					}
					else if (_0024ppp_00241924 <= 12)
					{
						_0024self__00241925.maxStamina = _0024ppp_00241924;
					}
					else
					{
						_0024self__00241925.maxStamina = 12;
					}
					_0024self__00241925.LoadSTA();
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameScript _0024self__00241926;

		public _0024LevelUp_00241916(GameScript self_)
		{
			_0024self__00241926 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241926);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SkillTick_00241927 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024maxCD_00241928;

			internal float _0024_0024658_00241929;

			internal Vector3 _0024_0024659_00241930;

			internal int _0024a_00241931;

			internal float _0024max_00241932;

			internal GameScript _0024self__00241933;

			public _0024(int a, float max, GameScript self_)
			{
				_0024a_00241931 = a;
				_0024max_00241932 = max;
				_0024self__00241933 = self_;
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
					_0024maxCD_00241928 = _0024max_00241932;
					_0024self__00241933.skillObjShade[_0024a_00241931].SetActive(true);
					goto case 2;
				case 2:
					if (_0024self__00241933.skillCooldown[_0024a_00241931] > 0f)
					{
						float num = (_0024_0024658_00241929 = _0024self__00241933.skillCooldown[_0024a_00241931] / _0024max_00241932 * 2f);
						Vector3 val = (_0024_0024659_00241930 = _0024self__00241933.skillObjShade[_0024a_00241931].transform.localScale);
						float num2 = (_0024_0024659_00241930.y = _0024_0024658_00241929);
						Vector3 val3 = (_0024self__00241933.skillObjShade[_0024a_00241931].transform.localScale = _0024_0024659_00241930);
						_0024self__00241933.skillCooldown[_0024a_00241931] = _0024self__00241933.skillCooldown[_0024a_00241931] - 1f;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					_0024self__00241933.skillObjShade[_0024a_00241931].SetActive(false);
					_0024self__00241933.skillObj[_0024a_00241931].animation.Play();
					_0024self__00241933.skillCooldown[_0024a_00241931] = 0f;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241934;

		internal float _0024max_00241935;

		internal GameScript _0024self__00241936;

		public _0024SkillTick_00241927(int a, float max, GameScript self_)
		{
			_0024a_00241934 = a;
			_0024max_00241935 = max;
			_0024self__00241936 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241934, _0024max_00241935, _0024self__00241936);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RageTick_00241937 : GenericGenerator<WaitForSeconds>
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
	internal sealed class _0024RoarTick_00241938 : GenericGenerator<WaitForSeconds>
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
	internal sealed class _0024FloatTick_00241939 : GenericGenerator<WaitForSeconds>
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
	internal sealed class _0024ManaTick_00241940 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241941;

			internal GameScript _0024self__00241942;

			public _0024(GameScript self_)
			{
				_0024self__00241942 = self_;
			}

			public override bool MoveNext()
			{
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241941 = default(int);
					_0024i_00241941 = 0;
					goto IL_0079;
				case 2:
					_0024i_00241941++;
					goto IL_0079;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0079:
					if (_0024i_00241941 < 20)
					{
						if (MAG < MAXMAG)
						{
							MAG++;
							_0024self__00241942.LoadMana();
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

		internal GameScript _0024self__00241943;

		public _0024ManaTick_00241940(GameScript self_)
		{
			_0024self__00241943 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241943);
		}
	}

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
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		cheatButton = (GameObject[])(object)new GameObject[4];
		inputString = new int[7];
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
			tempStats[11] = tempStats[11] + 1;
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
		return new _0024Invader_00241659(this).GetEnumerator();
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

	public static void FairyCounter()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer == 1)
		{
			fairyCounter++;
			if (fairyCounter >= 3)
			{
				fairyCounter = 0;
				Network.Instantiate(Resources.Load("e/fQueen"), new Vector3(player.transform.position.x, player.transform.position.y + 50f, 0f), Quaternion.identity, 0);
			}
		}
	}

	public static void DragonCounter()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer == 1)
		{
			dragonCounter++;
			if (dragonCounter >= 1)
			{
				dragonCounter = 0;
				Network.Instantiate(Resources.Load("e/scourgeDragon"), new Vector3(player.transform.position.x, player.transform.position.y - 30f, 0f), Quaternion.identity, 0);
			}
		}
	}

	public override void DetectRes()
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

	public override IEnumerator Timer()
	{
		return new _0024Timer_00241664(this).GetEnumerator();
	}

	public override void Awake()
	{
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected O, but got Unknown
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Expected O, but got Unknown
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected O, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected O, but got Unknown
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Expected O, but got Unknown
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Expected O, but got Unknown
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		usedAltar = false;
		Application.targetFrameRate = 60;
		drumATK = 0;
		drumDEX = 0;
		drumMAG = 0;
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
			for (num6 = 0; num6 < 8; num6++)
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
		else if (curBiome == 9)
		{
			MenuScript.canUnlockRace[10] = 1;
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
			if (MenuScript.multiplayer > 0 && Network.isServer)
			{
				GenerateLevel();
			}
		}
		else if (MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			SpawnTownNetwork();
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
		LoadSTA();
		if (MenuScript.companion == 1)
		{
			HealC();
		}
		else if (MenuScript.companion == 3)
		{
			SPD *= 2f;
		}
		if (MenuScript.companion == 5)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(RegenManaComp());
		}
	}

	public override IEnumerator RegenManaComp()
	{
		return new _0024RegenManaComp_00241667(this).GetEnumerator();
	}

	public override void HealC()
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
		return new _0024ScourgeMaskTick_00241670().GetEnumerator();
	}

	public override IEnumerator TikiCheck()
	{
		return new _0024TikiCheck_00241671(this).GetEnumerator();
	}

	public override IEnumerator LavaWorm()
	{
		return new _0024LavaWorm_00241676().GetEnumerator();
	}

	public override void Worm()
	{
		if (MenuScript.multiplayer > 0 && MenuScript.multiplayer != 1)
		{
		}
	}

	public override IEnumerator RecoverMana()
	{
		return new _0024RecoverMana_00241677(this).GetEnumerator();
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

	public override IEnumerator ScourgeBoss(int d)
	{
		return new _0024ScourgeBoss_00241681(d).GetEnumerator();
	}

	public override void ScourgeAttack()
	{
	}

	public override IEnumerator SummonScourge()
	{
		return new _0024SummonScourge_00241685().GetEnumerator();
	}

	public override IEnumerator RepeatScourge()
	{
		return new _0024RepeatScourge_00241686(this).GetEnumerator();
	}

	public override void Quake()
	{
	}

	public override IEnumerator Write(int num)
	{
		return new _0024Write_00241690(num, this).GetEnumerator();
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
		return new _0024WriteFinal_00241697(a, this).GetEnumerator();
	}

	public override IEnumerator GenerateText()
	{
		return new _0024GenerateText_00241704(this).GetEnumerator();
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
			8 => GetCavePrefix() + " Quarry", 
			9 => GetCavePrefix() + " Crater", 
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
		return new _0024Start_00241710(this).GetEnumerator();
	}

	public override IEnumerator StaminaStart()
	{
		return new _0024StaminaStart_00241713(this).GetEnumerator();
	}

	public override void LoadSTA()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
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
		txtBarInfo[3].text = (object)stamina + "/" + (object)maxStamina;
		float x = num3 * 0.3f;
		Vector3 localScale = barBack[3].transform.localScale;
		float num5 = (localScale.x = x);
		Vector3 val2 = (barBack[3].transform.localScale = localScale);
		float x2 = num4 * 0.3f;
		Vector3 localScale2 = barFill[3].transform.localScale;
		float num6 = (localScale2.x = x2);
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
		return new _0024WriteEgg_00241717(this).GetEnumerator();
	}

	public override IEnumerator AddInput(int a)
	{
		return new _0024AddInput_00241720(a, this).GetEnumerator();
	}

	public override void CheckInput()
	{
		int num = default(int);
		string text = string.Empty;
		for (num = 0; num < 7; num++)
		{
			text += string.Empty + (object)inputString[num];
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
		default:
			txtInput.text = "Invalid Code";
			break;
		}
	}

	public override void Exclusive()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player))
		{
			Network.Instantiate(Resources.Load("exclusive"), player.transform.position, Quaternion.identity, 0);
			int num = 20;
			Vector3 velocity = player.rigidbody.velocity;
			float num2 = (velocity.y = num);
			Vector3 val2 = (player.rigidbody.velocity = velocity);
		}
	}

	public override void DeathAnim()
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

	public override void SetTitle(int a)
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
		if (Object.op_Implicit((Object)(object)player))
		{
			player.networkView.RPC("AssignTitle", (RPCMode)6, new object[1] { text });
		}
	}

	public override void CatForm()
	{
		if (isCat)
		{
			isCat = false;
			player.SendMessage("Cat", (object)0);
		}
		else
		{
			isCat = true;
			player.SendMessage("Cat", (object)1);
		}
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
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_139e: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1402: Unknown result type (might be due to invalid IL or missing references)
		//IL_131f: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c8: Unknown result type (might be due to invalid IL or missing references)
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
		if (Input.GetButtonDown("Inventory") && !dead)
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
		if (Input.GetButtonDown("CheatKey"))
		{
			if (cheating)
			{
				cheating = false;
				menuCheat.SetActive(false);
			}
			else
			{
				cheating = true;
				if (!inventoryOpen)
				{
					OpenInventory();
				}
				menuCheat.SetActive(true);
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
				else if (((Object)gameObject).name == "sell" && holdingItem)
				{
					SellItem();
				}
				else if (((Object)gameObject).name == "b1")
				{
					((MonoBehaviour)this).StartCoroutine_Auto(AddInput(1));
				}
				else if (((Object)gameObject).name == "b2")
				{
					((MonoBehaviour)this).StartCoroutine_Auto(AddInput(2));
				}
				else if (((Object)gameObject).name == "b3")
				{
					((MonoBehaviour)this).StartCoroutine_Auto(AddInput(3));
				}
				else if (((Object)gameObject).name == "b4")
				{
					((MonoBehaviour)this).StartCoroutine_Auto(AddInput(4));
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
					else if (holdingItem && inventory[num5].id == 0 && num5 != 20 && num5 != 21 && num5 != 22 && num5 != 24 && num5 != 25)
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

	public override void SellItem()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		int num = default(int);
		Item item = null;
		int num2 = default(int);
		item = itemSelected;
		int num3 = Random.Range(0, 10);
		num = ((num3 < 6) ? 2 : ((num3 >= 9) ? 4 : 3));
		if (item.id == 1 || item.id == 2 || item.id == 3)
		{
			num = 1;
		}
		((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/PURCHASE", typeof(AudioClip)));
		num2 = num * item.q;
		curGold += num2;
		RefreshGold();
		itemSelected = EmptyItem();
		holdingItem = false;
		sSelected.SetActive(false);
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
		return new _0024Craft_00241725(this).GetEnumerator();
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
			6 => 1, 
			8 => 1, 
			9 => 1, 
			10 => 2, 
			11 => 1, 
			_ => 5, 
		}) == 0) ? true : false;
	}

	public override bool ChanceHat(int a)
	{
		int num = 0;
		MonoBehaviour.print((object)((object)a + " is hat "));
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
		num2 = ((num != 1) ? Random.Range(0, num) : 0);
		return (num2 == 0) ? true : false;
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
		for (num = 1; num < 9; num++)
		{
			if (MenuScript.companionUnlock[num] != 0 || MenuScript.canUnlockCompanion[num] != 1)
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
		for (num = 0; num < 25; num++)
		{
			if (MenuScript.hatUnlock[num] != 0 || MenuScript.canUnlockHat[num] != 1 || !ChanceHat(num))
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
		rewardTop.SetActive(false);
		rewardBot.SetActive(false);
		rewardShade.SetActive(false);
	}

	public override IEnumerator SelectReward(int c)
	{
		return new _0024SelectReward_00241743(c, this).GetEnumerator();
	}

	public override IEnumerator UnlockHat(int h)
	{
		return new _0024UnlockHat_00241751(h, this).GetEnumerator();
	}

	public override IEnumerator UnlockComp(int h)
	{
		return new _0024UnlockComp_00241756(h, this).GetEnumerator();
	}

	public override IEnumerator UnlockVariant(int r)
	{
		return new _0024UnlockVariant_00241761(r, this).GetEnumerator();
	}

	public override IEnumerator UnlockRace(int h)
	{
		return new _0024UnlockRace_00241766(h, this).GetEnumerator();
	}

	public override string GetHatName(int a)
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
			9 => "Qualogg", 
			10 => "Bandicoot", 
			11 => "Djinn", 
			_ => "null", 
		};
	}

	public override string GetCompName(int a)
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
			9 => "Wasp Glasses", 
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
			if (rewardChest[num] != 0)
			{
				continue;
			}
			num2 = GetNextReward();
			if (num2 == 0)
			{
				if (rewardChestObj != null)
				{
					rewardChestObj[num].renderer.material = rewShade;
					rewardChest[num] = 0;
					rewardChestObj[num].animation.Stop();
				}
			}
			else if (rewardChestObj != null)
			{
				rewardChestObj[num].renderer.material = rewChest;
				rewardChestObj[num].animation.Play();
				rewardChest[num] = num2;
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
		return new _0024Menuu_00241771(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator AgainN()
	{
		return new _0024AgainN_00241774(this).GetEnumerator();
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

	public override void SpawnTownNetwork()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		curStyle = Random.Range(1, 2);
		Network.Instantiate(Resources.Load("z/zEntrance"), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
		if (curBiome != 8 && curBiome != 9)
		{
			num = Random.Range(1, 9);
		}
		else if (curBiome == 8)
		{
			num = Random.Range(1, 3);
		}
		else if (curBiome == 9)
		{
			num = Random.Range(1, 4);
			if (num == 3)
			{
				num = 7;
			}
		}
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
		if (Random.Range(0, 3) == 0)
		{
			Network.Instantiate(Resources.Load("npc/npc6"), new Vector3(6.5f, -3f, 0f), Quaternion.identity, 0);
		}
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
		return new _0024ThrowPoison_00241777(this).GetEnumerator();
	}

	public override IEnumerator ThrowDagger(int a)
	{
		return new _0024ThrowDagger_00241781(a, this).GetEnumerator();
	}

	public override IEnumerator ThrowRock()
	{
		return new _0024ThrowRock_00241792(this).GetEnumerator();
	}

	public override IEnumerator UseTotalBiscuit()
	{
		return new _0024UseTotalBiscuit_00241796(this).GetEnumerator();
	}

	public override IEnumerator UseHPPotion(int heal)
	{
		return new _0024UseHPPotion_00241799(heal, this).GetEnumerator();
	}

	public override IEnumerator UseManaPotion(int heal)
	{
		return new _0024UseManaPotion_00241805(heal, this).GetEnumerator();
	}

	public override IEnumerator UseDrum(int drum)
	{
		return new _0024UseDrum_00241811(drum, this).GetEnumerator();
	}

	public override IEnumerator UseItem(int slot)
	{
		return new _0024UseItem_00241816(slot, this).GetEnumerator();
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

	public override void Ice()
	{
		if (MAG < 3)
		{
			return;
		}
		if (MenuScript.pHat == 11)
		{
			if (Random.Range(0, 3) == 0)
			{
				UseMana(3);
			}
		}
		else
		{
			UseMana(3);
		}
		if (MenuScript.multiplayer > 0)
		{
			player.SendMessage("iceShard", (object)(MAXMAG + drumMAG));
		}
		GUImana.animation.Play();
	}

	public override void Bolt()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		MonoBehaviour.print((object)((object)MenuScript.pHat + " curhat"));
		if (MAG < 1)
		{
			return;
		}
		if (MenuScript.pHat == 11)
		{
			if (Random.Range(0, 3) == 0)
			{
				UseMana(1);
			}
		}
		else
		{
			UseMana(1);
		}
		if (MenuScript.multiplayer > 0)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("proj/bolt"), player.transform.position, Quaternion.identity, 0);
			val.SendMessage("Set", (object)(MAXMAG + drumMAG));
		}
		GUImana.animation.Play();
	}

	public override void Fireball()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		if (MAG < 1)
		{
			return;
		}
		GameObject val = null;
		if (MenuScript.pHat == 11)
		{
			if (Random.Range(0, 3) == 0)
			{
				UseMana(1);
			}
		}
		else
		{
			UseMana(1);
		}
		if (MenuScript.multiplayer > 0)
		{
			val = ((!facingLeft) ? ((GameObject)Network.Instantiate(Resources.Load("proj/fireballR"), player.transform.position, Quaternion.identity, 0)) : ((GameObject)Network.Instantiate(Resources.Load("proj/fireballL"), player.transform.position, Quaternion.identity, 0)));
			val.SendMessage("Set", (object)(MAXMAG + drumMAG));
		}
		GUImana.animation.Play();
	}

	public override IEnumerator MeleeAttack()
	{
		return new _0024MeleeAttack_00241861(this).GetEnumerator();
	}

	public override IEnumerator v()
	{
		return new _0024v_00241869().GetEnumerator();
	}

	public override IEnumerator KnockBack(Transform h)
	{
		return new _0024KnockBack_00241870(h).GetEnumerator();
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
		if (slot >= 11)
		{
			return;
		}
		holdingItem = false;
		npcInventory[slot] = itemSelected;
		itemSelected = EmptyItem();
		sSelected.SetActive(false);
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

	public override void HideCheck()
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

	public override void ClothCheck()
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

	public override void CapCheck()
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

	public override void HoodCheck()
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

	public override void LeatherCheck()
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

	public override void RobeCheck()
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
				if (itemSelected.id < 900 || itemSelected.id >= 950)
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
			case 24:
				if (itemSelected.id >= 950 && itemSelected.id < 958)
				{
					holdingItem = false;
					inventory[slot] = itemSelected;
					itemSelected = EmptyItem();
					sSelected.SetActive(false);
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
					sSelected.SetActive(false);
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
			}
		}
		UpdateCharacterWeapon();
		MAXMAG = MenuScript.playerStat[3] + tempPlayerStat[3] + tempLevelStat[3] + tempGearStat[3];
		LoadMana();
		DEX = MenuScript.playerStat[2] + tempPlayerStat[2] + tempLevelStat[2] + tempGearStat[2];
	}

	public override void RefreshTailor()
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
		bSmithObject[8].SetActive(false);
		bSmithObject[9].SetActive(false);
		bSmithObject[10].SetActive(false);
		bSmithObject[14].SetActive(false);
	}

	public override void RefreshLeatherworker()
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
		bSmithObject[8].SetActive(false);
		bSmithObject[9].SetActive(false);
		bSmithObject[10].SetActive(false);
		bSmithObject[14].SetActive(false);
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
		bSmithObject[8].SetActive(true);
		bSmithObject[9].SetActive(true);
		bSmithObject[10].SetActive(true);
		bSmithObject[14].SetActive(true);
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
			sSelected.SetActive(false);
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

	public override void CombineItemNPC(int slot)
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
			sSelected.SetActive(false);
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
		array[1] += drumATK;
		array[2] += drumDEX;
		array[3] += drumMAG;
		for (num = 0; num < 4; num++)
		{
			txtPlayerStat[num].text = GetStatName(num) + ": " + (object)array[num];
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
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		int num = default(int);
		GameObject val = null;
		int num2 = default(int);
		int result;
		if (item.id < 500)
		{
			if (item.id >= 52 && item.id <= 59 && item.id == inventory[23].id)
			{
				inventory[23].q = inventory[23].q + item.q;
				val = (GameObject)Object.Instantiate((Object)(object)txtItem, player.transform.position, Quaternion.identity);
				val.SendMessage("ST", (object)GetItemName(item.id));
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
		val = (GameObject)Object.Instantiate((Object)(object)txtItem, player.transform.position, Quaternion.identity);
		val.SendMessage("ST", (object)GetItemName(item.id));
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
		val = (GameObject)Object.Instantiate((Object)(object)txtItem, player.transform.position, Quaternion.identity);
		val.SendMessage("ST", (object)GetGearName(item.id));
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
		val = (GameObject)Object.Instantiate((Object)(object)txtItem, player.transform.position, Quaternion.identity);
		val.SendMessage("ST", (object)GetItemName(item.id));
		RefreshActionBar();
		if (inventoryOpen)
		{
			RefreshInventory();
		}
		UpdateCharacterWeapon();
		result = 1;
		goto IL_034e;
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
			1 => "A basic piece of\nwood used to\nmake planks.", 
			9 => "A vital ingredient\nfor making potions.", 
			7 => "Restores 1 hunger.", 
			8 => "Restores 3 hunger.\n50% chance to heal.", 
			21 => "Restores 1 hunger.", 
			22 => "Restores 3 hunger.\n50% chance to heal.", 
			15 => "Heals 2 HP.", 
			42 => "Heals 5 HP.", 
			46 => "increases HP and\nMAG by 3.", 
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
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
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

	public override Vector3 GetSelectPos(object slot)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		Vector3 result = default(Vector3);
		if (RuntimeServices.EqualityOperator(slot, (object)0))
		{
			return new Vector3(-18.75f, 11.05f, 8.75f);
		}
		if (RuntimeServices.EqualityOperator(slot, (object)1))
		{
			return new Vector3(-16.85f, 11.05f, 8.75f);
		}
		if (RuntimeServices.EqualityOperator(slot, (object)2))
		{
			return new Vector3(-15f, 11.05f, 8.75f);
		}
		if (RuntimeServices.EqualityOperator(slot, (object)3))
		{
			return new Vector3(-13.15f, 11.05f, 8.75f);
		}
		if (RuntimeServices.EqualityOperator(slot, (object)4))
		{
			return new Vector3(-11.25f, 11.05f, 8.75f);
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
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		if (!inventoryOpen && !menuOpen)
		{
			if (!@using)
			{
				RefreshPlayerStats();
				RefreshInventory();
				SetTextInfo();
				menuInventory.SetActive(true);
				menuEquipped.SetActive(true);
				inventoryOpen = true;
			}
			return;
		}
		menuCheat.SetActive(false);
		cheating = false;
		CloseSkillDesc();
		if (holdingItem)
		{
			DropItem();
		}
		if (interacting)
		{
			menuBlacksmith.SetActive(false);
			menuHoarder.SetActive(false);
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
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		int num3 = default(int);
		int num4 = 0;
		curZone = 0;
		int num5 = 0;
		if (MenuScript.multiplayer <= 0 || !Network.isServer)
		{
			return;
		}
		Network.Instantiate(Resources.Load("z/zEntrance"), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 180f), 0);
		int num6 = Random.Range(4, 7);
		for (num5 = 0; num5 < num6; num5++)
		{
			if (curBiome != 8 && curBiome != 9)
			{
				num3 = Random.Range(1, 9);
			}
			else if (curBiome == 8)
			{
				num3 = Random.Range(1, 3);
			}
			else if (curBiome == 9)
			{
				num3 = Random.Range(1, 4);
				if (num3 == 3)
				{
					num3 = 7;
				}
			}
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
	}

	public override void SetMusic(int a)
	{
		musicBox.SendMessage("SetMusic", (object)a);
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
		return new _0024Die_00241883(this).GetEnumerator();
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
		if (Object.op_Implicit((Object)(object)txtTimer))
		{
			txtTimer.text = "Total Time: " + (object)num3 + ":" + (object)num2 + ":" + (object)num;
		}
		if (num3 <= 1 && win)
		{
			MenuScript.canUnlockRace[6] = 1;
		}
	}

	public override IEnumerator ShowStats()
	{
		return new _0024ShowStats_00241888(this).GetEnumerator();
	}

	public override IEnumerator ShowEXP()
	{
		return new _0024ShowEXP_00241892(this).GetEnumerator();
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
		return new _0024StatShow_00241899(a, this).GetEnumerator();
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
			10 => "Bosses Defeated", 
			11 => "Items Bought", 
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
			float x2 = 0.7f;
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
			12 => "Next shot fired will\nshoot 3 arrows.\nWith double damage.\nConsumes 3 arrows.", 
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
				_ => 20f, 
			}, 
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
			530 => new int[4] { 0, 0, 6, 0 }, 
			531 => new int[4] { 2, 11, 0, 0 }, 
			532 => new int[4] { 2, 11, 0, 0 }, 
			533 => new int[4] { 5, 30, 2, 2 }, 
			534 => new int[4] { 0, 75, 0, 0 }, 
			535 => new int[4] { 0, 0, 15, 15 }, 
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

	public override void SetLeatherworker()
	{
		menuBlacksmith.renderer.material = leatherworkerMenu;
		txtNPCName.text = "Finn the Leatherworker";
	}

	public override void SetTailor()
	{
		menuBlacksmith.renderer.material = tailorMenu;
		txtNPCName.text = "Flora the Tailor";
	}

	public override void Interact()
	{
		interacting = true;
		int num = 0;
		switch (interacter)
		{
		case "n1":
			txtNPCName.text = "Grognar the Blacksmith";
			menuBlacksmith.renderer.material = blacksmithMenu;
			menuBlacksmith.SetActive(true);
			RefreshBlacksmith();
			npcInteract = 1;
			interacted = true;
			break;
		case "n3":
			menuBlacksmith.SetActive(true);
			SetLeatherworker();
			RefreshLeatherworker();
			npcInteract = 3;
			interacted = true;
			break;
		case "n4":
			menuBlacksmith.SetActive(true);
			SetTailor();
			RefreshTailor();
			npcInteract = 4;
			interacted = true;
			break;
		case "n5":
			menuHoarder.SetActive(true);
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

	public override void Altar()
	{
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
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
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("txtAltar"), player.transform.position, Quaternion.identity, 0);
			val.SendMessage("Set", (object)num);
			((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/altar", typeof(AudioClip)));
		}
		interacting = false;
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
		return new _0024AdditionalStat_00241906(a, this).GetEnumerator();
	}

	public override IEnumerator ShowLUP(int a)
	{
		return new _0024ShowLUP_00241911(a, this).GetEnumerator();
	}

	public override IEnumerator LevelUp()
	{
		return new _0024LevelUp_00241916(this).GetEnumerator();
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
		MonoBehaviour.print((object)((object)num4 + " IS SKILL count"));
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
		return new _0024SkillTick_00241927(a, max, this).GetEnumerator();
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
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected O, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected O, but got Unknown
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected O, but got Unknown
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected O, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected O, but got Unknown
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected O, but got Unknown
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected O, but got Unknown
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected O, but got Unknown
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected O, but got Unknown
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Expected O, but got Unknown
		//IL_0e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected O, but got Unknown
		//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e38: Expected O, but got Unknown
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Expected O, but got Unknown
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efa: Expected O, but got Unknown
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
				int num3 = MenuScript.playerStat[1] + tempPlayerStat[1] + tempLevelStat[1] + tempGearStat[1];
				val5 = (GameObject)Network.Instantiate(Resources.Load("skill/throwAxe"), player.transform.position, Quaternion.Euler(val3), 0);
				val5.SendMessage("Set", (object)num3);
				player.networkView.RPC("mA", (RPCMode)2, new object[1] { "dj" });
				val = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
				val.networkView.RPC("SDSN", (RPCMode)2, new object[1] { "TAKE THAT!" });
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
			int num9 = 38;
			Vector3 velocity3 = player.rigidbody.velocity;
			float num10 = (velocity3.y = num9);
			Vector3 val16 = (player.rigidbody.velocity = velocity3);
			if (MenuScript.multiplayer > 0)
			{
				int num11 = MenuScript.playerStat[1] + tempPlayerStat[1] + tempLevelStat[1] + tempGearStat[1];
				val14 = (GameObject)Network.Instantiate(Resources.Load("skill/kBlade"), player.transform.position, Quaternion.identity, 0);
				val14.SendMessage("Set", (object)num11);
				player.networkView.RPC("mA", (RPCMode)2, new object[1] { "dj" });
				val = (GameObject)Network.Instantiate(Resources.Load("text"), player.transform.position, Quaternion.identity, 0);
				val.networkView.RPC("SDSN", (RPCMode)2, new object[1] { "Woohoo!" });
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
			int num4 = 2048;
			if (!(Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= player.transform.position.x))
			{
				val8 = new Ray(player.transform.position, new Vector3(1f, 0f, 0f));
				Vector3 val3 = new Vector3(player.transform.position.x + 8f, player.transform.position.y, 0f);
				if (!Physics.Raycast(val8, ref val9, 8.4f, num4))
				{
					player.transform.position = val3;
					int num5 = 0;
					Vector3 velocity = player.rigidbody.velocity;
					float num6 = (velocity.x = num5);
					Vector3 val11 = (player.rigidbody.velocity = velocity);
				}
			}
			else
			{
				val8 = new Ray(player.transform.position, new Vector3(-1f, 0f, 0f));
				Vector3 val3 = new Vector3(player.transform.position.x - 8f, player.transform.position.y, 0f);
				if (!Physics.Raycast(val8, ref val9, 8.4f, num4))
				{
					player.transform.position = val3;
					int num7 = 0;
					Vector3 velocity2 = player.rigidbody.velocity;
					float num8 = (velocity2.x = num7);
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
			int num12 = 38;
			Vector3 velocity4 = player.rigidbody.velocity;
			float num13 = (velocity4.y = num12);
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
		return new _0024RageTick_00241937().GetEnumerator();
	}

	public override IEnumerator RoarTick()
	{
		return new _0024RoarTick_00241938().GetEnumerator();
	}

	public override IEnumerator FloatTick()
	{
		return new _0024FloatTick_00241939().GetEnumerator();
	}

	public override IEnumerator ManaTick()
	{
		return new _0024ManaTick_00241940(this).GetEnumerator();
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
			20 => "Monster Pelt", 
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
			46 => "Total Biscuit", 
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
			71 => "Ice Gem I", 
			72 => "Stone Dagger", 
			73 => "Bone Dagger", 
			74 => "Ironite Dagger", 
			75 => "Goldium Dagger", 
			76 => "Diamonite Dagger", 
			77 => "Tribal Drum", 
			78 => "Drum of Strength", 
			79 => "Drum of Dexterity", 
			80 => "Drum of Wisdom", 
			81 => "Ice Bug", 
			82 => "Refined Leather", 
			83 => "Rugged Leather", 
			84 => "Tribal Leather", 
			85 => "Elegant Leather", 
			86 => "Royal Leather", 
			87 => "Luminous Leather", 
			88 => "Rugged Fabric", 
			89 => "Tribal Fabric", 
			90 => "Elegant Fabric", 
			91 => "Royal Fabric", 
			92 => "Luminous Fabric", 
			94 => "Refined Cloth", 
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
			530 => "Crystal Bow", 
			531 => "Emerald Katana", 
			532 => "Emerald Combat Axe", 
			533 => "Obsidian Sword", 
			534 => "Laser Sword", 
			535 => "Laser Crossbow", 
			550 => "Giant Fish", 
			560 => "Ironite Great Axe", 
			561 => "Goldium Great Axe", 
			562 => "Diamonite Great Axe", 
			563 => "Stone Great Axe", 
			564 => "Hellswrath", 
			565 => "The Philibuster", 
			566 => "Jelly Blade", 
			567 => "Zweihander", 
			568 => "Icebrand", 
			569 => "Firebrand", 
			570 => "Thunderbrand", 
			600 => "Fireball", 
			601 => "Bolt", 
			602 => "Frostshard", 
			700 => "Ironite Helm", 
			701 => "Goldium Helm", 
			702 => "Diamonite Helm", 
			703 => "Stone Helm", 
			704 => "Bone Helm", 
			705 => "Rugged Cap", 
			706 => "Tribal Cap", 
			707 => "Elegant Cap", 
			708 => "Royal Cap", 
			709 => "Luminous Cap", 
			710 => "Rugged Hood", 
			711 => "Tribal Hood", 
			712 => "Elegant Hood", 
			713 => "Royal Hood", 
			714 => "Luminous Hood", 
			800 => "Ironite Armor", 
			801 => "Goldium Armor", 
			802 => "Diamonite Armor", 
			803 => "Stone Armor", 
			804 => "Bone Armor", 
			805 => "Rugged Cloak", 
			806 => "Tribal Cloak", 
			807 => "Elegant Cloak", 
			808 => "Royal Cloak", 
			809 => "Luminous Cloak", 
			810 => "Rugged Robes", 
			811 => "Tribal Robes", 
			812 => "Elegant Robes", 
			813 => "Royal Robes", 
			814 => "Luminous Robes", 
			900 => "Ironite Shield", 
			901 => "Goldium Shield", 
			902 => "Diamonite Shield", 
			903 => "Stone Shield", 
			904 => "Bone Shield", 
			905 => "Ryvenrath's Scale", 
			950 => "Ring of Power", 
			951 => "Ring of Wisdom", 
			952 => "Ring of Nature", 
			953 => "Ring of Life", 
			954 => "Ring of Rage", 
			955 => "Ring of Insanity", 
			956 => "Archer's Ring", 
			957 => "Ring of Balance", 
			_ => "NULL", 
		};
	}

	public override void Main()
	{
	}
}
