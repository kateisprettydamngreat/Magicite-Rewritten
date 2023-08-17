using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class NPCCommoner : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Talk_00241726 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCCommoner _0024self__00241727;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241727 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_0052: Expected O, but got Unknown
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0039: Expected O, but got Unknown
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(5, 20))) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(0, 6))) ? 1 : 0);
					break;
				case 3:
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							((Component)_0024self__00241727).networkView.RPC("SaySomething", (RPCMode)2, new object[1] { Random.Range(0, 10) });
						}
					}
					else
					{
						((MonoBehaviour)_0024self__00241727).StartCoroutine_Auto(_0024self__00241727.SaySomething(Random.Range(0, 10)));
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds((float)Random.Range(0, 6))) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal NPCCommoner _0024self__00241728;

		public _0024Talk_00241726(NPCCommoner self_)
		{
			_0024self__00241728 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241728);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SaySomething_00241729 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00241730;

			internal int _0024_0024switch_0024323_00241731;

			internal int _0024a_00241732;

			internal NPCCommoner _0024self__00241733;

			public _0024(int a, NPCCommoner self_)
			{
				_0024a_00241732 = a;
				_0024self__00241733 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024s_00241730 = null;
					_0024_0024switch_0024323_00241731 = _0024a_00241732;
					if (_0024_0024switch_0024323_00241731 == 0)
					{
						_0024s_00241730 = "Life is great.";
					}
					else if (_0024_0024switch_0024323_00241731 == 1)
					{
						_0024s_00241730 = "Deephaven is scary.";
					}
					else if (_0024_0024switch_0024323_00241731 == 2)
					{
						_0024s_00241730 = "I'm hungry";
					}
					else if (_0024_0024switch_0024323_00241731 == 3)
					{
						_0024s_00241730 = "I hate chicken.";
					}
					else if (_0024_0024switch_0024323_00241731 == 4)
					{
						_0024s_00241730 = "The Scourge suck!";
					}
					else if (_0024_0024switch_0024323_00241731 == 5)
					{
						_0024s_00241730 = "I miss the sun...";
					}
					else if (_0024_0024switch_0024323_00241731 == 6)
					{
						_0024s_00241730 = "*Cough*";
					}
					else if (_0024_0024switch_0024323_00241731 == 7)
					{
						_0024s_00241730 = "Someone smells funny.";
					}
					else if (_0024_0024switch_0024323_00241731 == 8)
					{
						_0024s_00241730 = "Idk what I want.";
					}
					else if (_0024_0024switch_0024323_00241731 == 9)
					{
						_0024s_00241730 = "I need to poop!";
					}
					_0024self__00241733.txtTalk.text = string.Empty + _0024s_00241730;
					_0024self__00241733.txtTalk2.text = string.Empty + _0024s_00241730;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241733.txtTalk.text = string.Empty;
					_0024self__00241733.txtTalk2.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241734;

		internal NPCCommoner _0024self__00241735;

		public _0024SaySomething_00241729(int a, NPCCommoner self_)
		{
			_0024a_00241734 = a;
			_0024self__00241735 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241734, _0024self__00241735);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241736 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal NPCCommoner _0024self__00241737;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241737 = self_;
			}

			public override bool MoveNext()
			{
				return base._state switch
				{
					1 => false, 
					_ => ((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00241737).StartCoroutine_Auto(_0024self__00241737.Move())), 
				};
			}
		}

		internal NPCCommoner _0024self__00241738;

		public _0024Start_00241736(NPCCommoner self_)
		{
			_0024self__00241738 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00241738);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00241739 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00241740;

			internal int _0024_0024644_00241741;

			internal Vector3 _0024_0024645_00241742;

			internal int _0024dmg_00241743;

			internal NPCCommoner _0024self__00241744;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241743 = dmg;
				_0024self__00241744 = self_;
			}

			public override bool MoveNext()
			{
				//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0204: Expected O, but got Unknown
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0101: Expected O, but got Unknown
				//IL_0101: Unknown result type (might be due to invalid IL or missing references)
				//IL_010b: Expected O, but got Unknown
				//IL_0164: Unknown result type (might be due to invalid IL or missing references)
				//IL_016e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241744.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00241744.txtTalk.text = "Ow!";
							_0024self__00241744.takingDamage = true;
							_0024self__00241744.hp -= _0024dmg_00241743;
							_0024n2_00241740 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241744.t.position, Quaternion.identity);
							_0024n2_00241740.SendMessage("SD", (object)_0024dmg_00241743);
							_0024self__00241744.@base.animation.Play();
							if (_0024self__00241744.hp < 1)
							{
								_0024self__00241744.Die();
								goto IL_01f3;
							}
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00241744).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00241743 });
						((Component)_0024self__00241744).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00241743 });
					}
					goto IL_021e;
				case 2:
				{
					_0024self__00241744.@base.animation.Stop();
					_0024self__00241744.takingDamage = false;
					int num = (_0024_0024644_00241741 = 0);
					Vector3 val = (_0024_0024645_00241742 = _0024self__00241744.@base.transform.localPosition);
					float num2 = (_0024_0024645_00241742.z = _0024_0024644_00241741);
					Vector3 val3 = (_0024self__00241744.@base.transform.localPosition = _0024_0024645_00241742);
					goto IL_01f3;
				}
				case 3:
					_0024self__00241744.txtTalk.text = string.Empty;
					goto IL_021e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_021e:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
					IL_01f3:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00241745;

		internal NPCCommoner _0024self__00241746;

		public _0024TD_00241739(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241745 = dmg;
			_0024self__00241746 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241745, _0024self__00241746);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00241747 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241748;

			internal int _0024dmg_00241749;

			internal NPCCommoner _0024self__00241750;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241749 = dmg;
				_0024self__00241750 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Expected O, but got Unknown
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_019d: Expected O, but got Unknown
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0171: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241750.txtTalk.text = "Ow!";
					_0024self__00241750.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241750.hp -= _0024dmg_00241749;
					_0024i_00241748 = default(int);
					if (_0024self__00241750.hp < 1)
					{
						if (MenuScript.multiplayer > 0)
						{
							for (_0024i_00241748 = 0; _0024i_00241748 < _0024self__00241750.GOLD; _0024i_00241748++)
							{
								Network.Instantiate(Resources.Load("c"), _0024self__00241750.t.position, Quaternion.identity, 0);
							}
						}
						else
						{
							for (_0024i_00241748 = 0; _0024i_00241748 < _0024self__00241750.GOLD; _0024i_00241748++)
							{
								Object.Instantiate(Resources.Load("c"), _0024self__00241750.t.position, Quaternion.identity);
							}
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(((Component)_0024self__00241750).networkView.viewID);
							Network.Destroy(((Component)_0024self__00241750).networkView.viewID);
						}
					}
					else
					{
						_0024self__00241750.takingDamage = false;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241750.txtTalk.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00241751;

		internal NPCCommoner _0024self__00241752;

		public _0024TDN_00241747(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241751 = dmg;
			_0024self__00241752 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241751, _0024self__00241752);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00241753 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00241754;

			internal int _0024_0024646_00241755;

			internal Vector3 _0024_0024647_00241756;

			internal int _0024dmg_00241757;

			internal NPCCommoner _0024self__00241758;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241757 = dmg;
				_0024self__00241758 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0030: Unknown result type (might be due to invalid IL or missing references)
				//IL_0040: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected O, but got Unknown
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected O, but got Unknown
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Expected O, but got Unknown
				//IL_0109: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Unknown result type (might be due to invalid IL or missing references)
				//IL_0144: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024n2_00241754 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241758.t.position, Quaternion.identity);
					_0024n2_00241754.SendMessage("SD", (object)_0024dmg_00241757);
					_0024self__00241758.@base.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241758.hp < 1)
					{
						goto IL_014c;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00241758.@base.animation.Stop();
					_0024self__00241758.takingDamage = false;
					int num = (_0024_0024646_00241755 = 0);
					Vector3 val = (_0024_0024647_00241756 = _0024self__00241758.@base.transform.localPosition);
					float num2 = (_0024_0024647_00241756.z = _0024_0024646_00241755);
					Vector3 val3 = (_0024self__00241758.@base.transform.localPosition = _0024_0024647_00241756);
					goto IL_014c;
				}
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

		internal int _0024dmg_00241759;

		internal NPCCommoner _0024self__00241760;

		public _0024TDN2_00241753(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241759 = dmg;
			_0024self__00241760 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241759, _0024self__00241760);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Move_00241761 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241762;

			internal NPCCommoner _0024self__00241763;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241763 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_0164: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Expected O, but got Unknown
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_0183: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024num_00241762 = Random.Range(-1, 2);
					if (_0024num_00241762 != 0)
					{
						_0024self__00241763.speed *= (float)_0024num_00241762;
					}
					if (!(_0024self__00241763.speed <= 0f))
					{
						((Component)_0024self__00241763.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00241763.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					}
					_0024self__00241763.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00241763.canMove = false;
					_0024num_00241762 = Random.Range(-1, 2);
					if (_0024num_00241762 != 0)
					{
						_0024self__00241763.speed *= (float)_0024num_00241762;
					}
					if (!(_0024self__00241763.speed <= 0f))
					{
						((Component)_0024self__00241763.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00241763.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(1, 10))) ? 1 : 0);
					break;
				case 3:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal NPCCommoner _0024self__00241764;

		public _0024Move_00241761(NPCCommoner self_)
		{
			_0024self__00241764 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241764);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock_00241765 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024650_00241766;

			internal Vector3 _0024_0024651_00241767;

			internal int _0024_0024652_00241768;

			internal Vector3 _0024_0024653_00241769;

			internal int _0024_0024654_00241770;

			internal Vector3 _0024_0024655_00241771;

			internal Vector3 _0024p_00241772;

			internal NPCCommoner _0024self__00241773;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241772 = p;
				_0024self__00241773 = self_;
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
						((Component)_0024self__00241773).networkView.RPC("KnockN", (RPCMode)2, new object[1] { _0024p_00241772 });
						goto IL_01a7;
					}
					if (_0024p_00241772.x <= _0024self__00241773.t.position.x)
					{
						int num3 = (_0024_0024652_00241768 = 10);
						Vector3 val4 = (_0024_0024653_00241769 = ((Component)_0024self__00241773).rigidbody.velocity);
						float num4 = (_0024_0024653_00241769.x = _0024_0024652_00241768);
						Vector3 val6 = (((Component)_0024self__00241773).rigidbody.velocity = _0024_0024653_00241769);
					}
					else
					{
						int num5 = (_0024_0024650_00241766 = -10);
						Vector3 val7 = (_0024_0024651_00241767 = ((Component)_0024self__00241773).rigidbody.velocity);
						float num6 = (_0024_0024651_00241767.x = _0024_0024650_00241766);
						Vector3 val9 = (((Component)_0024self__00241773).rigidbody.velocity = _0024_0024651_00241767);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024654_00241770 = 0);
					Vector3 val = (_0024_0024655_00241771 = ((Component)_0024self__00241773).rigidbody.velocity);
					float num2 = (_0024_0024655_00241771.x = _0024_0024654_00241770);
					Vector3 val3 = (((Component)_0024self__00241773).rigidbody.velocity = _0024_0024655_00241771);
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

		internal Vector3 _0024p_00241774;

		internal NPCCommoner _0024self__00241775;

		public _0024Knock_00241765(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241774 = p;
			_0024self__00241775 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241774, _0024self__00241775);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00241776 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024656_00241777;

			internal Vector3 _0024_0024657_00241778;

			internal int _0024_0024658_00241779;

			internal Vector3 _0024_0024659_00241780;

			internal int _0024_0024660_00241781;

			internal Vector3 _0024_0024661_00241782;

			internal Vector3 _0024p_00241783;

			internal NPCCommoner _0024self__00241784;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241783 = p;
				_0024self__00241784 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_012f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_0136: Unknown result type (might be due to invalid IL or missing references)
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0162: Unknown result type (might be due to invalid IL or missing references)
				//IL_0163: Unknown result type (might be due to invalid IL or missing references)
				//IL_016a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00be: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_0101: Unknown result type (might be due to invalid IL or missing references)
				//IL_010b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024p_00241783.x <= _0024self__00241784.t.position.x)
					{
						int num3 = (_0024_0024658_00241779 = 10);
						Vector3 val4 = (_0024_0024659_00241780 = ((Component)_0024self__00241784).rigidbody.velocity);
						float num4 = (_0024_0024659_00241780.x = _0024_0024658_00241779);
						Vector3 val6 = (((Component)_0024self__00241784).rigidbody.velocity = _0024_0024659_00241780);
					}
					else
					{
						int num5 = (_0024_0024656_00241777 = -10);
						Vector3 val7 = (_0024_0024657_00241778 = ((Component)_0024self__00241784).rigidbody.velocity);
						float num6 = (_0024_0024657_00241778.x = _0024_0024656_00241777);
						Vector3 val9 = (((Component)_0024self__00241784).rigidbody.velocity = _0024_0024657_00241778);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024660_00241781 = 0);
					Vector3 val = (_0024_0024661_00241782 = ((Component)_0024self__00241784).rigidbody.velocity);
					float num2 = (_0024_0024661_00241782.x = _0024_0024660_00241781);
					Vector3 val3 = (((Component)_0024self__00241784).rigidbody.velocity = _0024_0024661_00241782);
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

		internal Vector3 _0024p_00241785;

		internal NPCCommoner _0024self__00241786;

		public _0024KnockN_00241776(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241785 = p;
			_0024self__00241786 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241785, _0024self__00241786);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00241787 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00241788;

			internal int _0024_0024662_00241789;

			internal Vector3 _0024_0024663_00241790;

			internal int _0024_0024664_00241791;

			internal Vector3 _0024_0024665_00241792;

			internal int _0024_0024666_00241793;

			internal Vector3 _0024_0024667_00241794;

			internal int _0024_0024668_00241795;

			internal Vector3 _0024_0024669_00241796;

			internal bool _0024l_00241797;

			internal NPCCommoner _0024self__00241798;

			public _0024(bool l, NPCCommoner self_)
			{
				_0024l_00241797 = l;
				_0024self__00241798 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0116: Unknown result type (might be due to invalid IL or missing references)
				//IL_011b: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0123: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Unknown result type (might be due to invalid IL or missing references)
				//IL_014f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_0174: Unknown result type (might be due to invalid IL or missing references)
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_017a: Unknown result type (might be due to invalid IL or missing references)
				//IL_017c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0181: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c4: Expected O, but got Unknown
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00db: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f2: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241788 = default(int);
					if (_0024l_00241797)
					{
						int num = (_0024_0024662_00241789 = -10);
						Vector3 val = (_0024_0024663_00241790 = _0024self__00241798.r.velocity);
						float num2 = (_0024_0024663_00241790.x = _0024_0024662_00241789);
						Vector3 val3 = (_0024self__00241798.r.velocity = _0024_0024663_00241790);
						int num3 = (_0024_0024664_00241791 = 10);
						Vector3 val4 = (_0024_0024665_00241792 = _0024self__00241798.r.velocity);
						float num4 = (_0024_0024665_00241792.y = _0024_0024664_00241791);
						Vector3 val6 = (_0024self__00241798.r.velocity = _0024_0024665_00241792);
						result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024666_00241793 = 10);
						Vector3 val7 = (_0024_0024667_00241794 = _0024self__00241798.r.velocity);
						float num6 = (_0024_0024667_00241794.x = _0024_0024666_00241793);
						Vector3 val9 = (_0024self__00241798.r.velocity = _0024_0024667_00241794);
						int num7 = (_0024_0024668_00241795 = 10);
						Vector3 val10 = (_0024_0024669_00241796 = _0024self__00241798.r.velocity);
						float num8 = (_0024_0024669_00241796.y = _0024_0024668_00241795);
						Vector3 val12 = (_0024self__00241798.r.velocity = _0024_0024669_00241796);
						result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(3, new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
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

		internal bool _0024l_00241799;

		internal NPCCommoner _0024self__00241800;

		public _0024K_00241787(bool l, NPCCommoner self_)
		{
			_0024l_00241799 = l;
			_0024self__00241800 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return (IEnumerator<WaitForEndOfFrame>)(object)new _0024(_0024l_00241799, _0024self__00241800);
		}
	}

	private int pos;

	private Transform t;

	private int moving;

	private int maxHP;

	private int hp;

	private bool takingDamage;

	public GameObject @base;

	public GameObject base2;

	public float speed;

	public Transform npc;

	private Rigidbody r;

	private int GOLD;

	private bool canMove;

	private int race;

	public GameObject head2;

	public GameObject head;

	public TextMesh txtTalk;

	public TextMesh txtTalk2;

	public override void OnDestroy()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer > 0)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
		}
	}

	public override void Awake()
	{
		((MonoBehaviour)this).StartCoroutine_Auto(Talk());
		race = GetRace();
		int num = Random.Range(1, 49);
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				((Component)this).networkView.RPC("SetAppearance", (RPCMode)6, new object[2] { race, num });
			}
		}
		else
		{
			SetAppearance(race, num);
		}
		base2.animation["i"].speed = 0.7f;
		GOLD = Random.Range(2, 6);
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		takingDamage = false;
		maxHP = 10;
		hp = maxHP;
		t = ((Component)this).transform;
	}

	public override IEnumerator Talk()
	{
		return new _0024Talk_00241726(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator SaySomething(int a)
	{
		return new _0024SaySomething_00241729(a, this).GetEnumerator();
	}

	[RPC]
	public override void SetAppearance(int r, int h)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		head.renderer.material = (Material)Resources.Load("r/r" + (object)r);
		if (r > 2)
		{
			head2.SetActive(false);
		}
		else
		{
			head2.renderer.material = (Material)Resources.Load("h/h" + (object)h);
		}
	}

	public override int GetRace()
	{
		int num = Random.Range(0, 100);
		int num2 = default(int);
		if (num < 40)
		{
			return 1;
		}
		if (num < 60)
		{
			return 2;
		}
		if (num < 70)
		{
			return 3;
		}
		if (num < 85)
		{
			return 4;
		}
		if (num < 90)
		{
			return 5;
		}
		if (num < 95)
		{
			return 6;
		}
		return 7;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241736(this).GetEnumerator();
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00241739(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00241747(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00241753(dmg, this).GetEnumerator();
	}

	public override void Die()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		if (MenuScript.multiplayer > 0)
		{
			for (num = 0; num < GOLD; num++)
			{
				Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
			}
		}
		else
		{
			for (num = 0; num < GOLD; num++)
			{
				Object.Instantiate(Resources.Load("c"), t.position, Quaternion.identity);
			}
		}
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				Network.RemoveRPCs(((Component)this).networkView.viewID);
				Network.Destroy(((Component)this).gameObject);
			}
			else
			{
				((Component)this).networkView.RPC("die", (RPCMode)0, new object[0]);
			}
		}
		else
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public override void Update()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (canMove)
		{
			float x = speed;
			Vector3 velocity = ((Component)this).rigidbody.velocity;
			float num = (velocity.x = x);
			Vector3 val2 = (((Component)this).rigidbody.velocity = velocity);
		}
	}

	public override IEnumerator Move()
	{
		return new _0024Move_00241761(this).GetEnumerator();
	}

	[RPC]
	public override void DieN(NetworkViewID id)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).networkView.viewID == id)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	[RPC]
	public override void Initialize(NetworkViewID id)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).networkView.viewID = id;
	}

	public override IEnumerator Knock(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Knock_00241765(p, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KnockN(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024KnockN_00241776(p, this).GetEnumerator();
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00241787(l, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
