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
	internal sealed class _0024Talk_00242143 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCCommoner _0024self__00242144;

			public _0024(NPCCommoner self_)
			{
				_0024self__00242144 = self_;
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
							((Component)_0024self__00242144).networkView.RPC("SaySomething", (RPCMode)2, new object[1] { Random.Range(0, 10) });
						}
					}
					else
					{
						((MonoBehaviour)_0024self__00242144).StartCoroutine_Auto(_0024self__00242144.SaySomething(Random.Range(0, 10)));
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

		internal NPCCommoner _0024self__00242145;

		public _0024Talk_00242143(NPCCommoner self_)
		{
			_0024self__00242145 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242145);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SaySomething_00242146 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00242147;

			internal int _0024_0024switch_0024391_00242148;

			internal int _0024a_00242149;

			internal NPCCommoner _0024self__00242150;

			public _0024(int a, NPCCommoner self_)
			{
				_0024a_00242149 = a;
				_0024self__00242150 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024s_00242147 = null;
					_0024_0024switch_0024391_00242148 = _0024a_00242149;
					if (_0024_0024switch_0024391_00242148 == 0)
					{
						_0024s_00242147 = "Life is great.";
					}
					else if (_0024_0024switch_0024391_00242148 == 1)
					{
						_0024s_00242147 = "Deephaven is scary.";
					}
					else if (_0024_0024switch_0024391_00242148 == 2)
					{
						_0024s_00242147 = "I'm hungry";
					}
					else if (_0024_0024switch_0024391_00242148 == 3)
					{
						_0024s_00242147 = "I hate chicken.";
					}
					else if (_0024_0024switch_0024391_00242148 == 4)
					{
						_0024s_00242147 = "The Scourge suck!";
					}
					else if (_0024_0024switch_0024391_00242148 == 5)
					{
						_0024s_00242147 = "I miss the sun...";
					}
					else if (_0024_0024switch_0024391_00242148 == 6)
					{
						_0024s_00242147 = "*Cough*";
					}
					else if (_0024_0024switch_0024391_00242148 == 7)
					{
						_0024s_00242147 = "Someone smells funny.";
					}
					else if (_0024_0024switch_0024391_00242148 == 8)
					{
						_0024s_00242147 = "Idk what I want.";
					}
					else if (_0024_0024switch_0024391_00242148 == 9)
					{
						_0024s_00242147 = "I need to poop!";
					}
					_0024self__00242150.txtTalk.text = string.Empty + _0024s_00242147;
					_0024self__00242150.txtTalk2.text = string.Empty + _0024s_00242147;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242150.txtTalk.text = string.Empty;
					_0024self__00242150.txtTalk2.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242151;

		internal NPCCommoner _0024self__00242152;

		public _0024SaySomething_00242146(int a, NPCCommoner self_)
		{
			_0024a_00242151 = a;
			_0024self__00242152 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242151, _0024self__00242152);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242153 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal NPCCommoner _0024self__00242154;

			public _0024(NPCCommoner self_)
			{
				_0024self__00242154 = self_;
			}

			public override bool MoveNext()
			{
				return base._state switch
				{
					1 => false, 
					_ => ((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242154).StartCoroutine_Auto(_0024self__00242154.Move())), 
				};
			}
		}

		internal NPCCommoner _0024self__00242155;

		public _0024Start_00242153(NPCCommoner self_)
		{
			_0024self__00242155 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242155);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00242156 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242157;

			internal int _0024_0024734_00242158;

			internal Vector3 _0024_0024735_00242159;

			internal int _0024dmg_00242160;

			internal NPCCommoner _0024self__00242161;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00242160 = dmg;
				_0024self__00242161 = self_;
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
					if (!_0024self__00242161.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00242161.txtTalk.text = "Ow!";
							_0024self__00242161.takingDamage = true;
							_0024self__00242161.hp -= _0024dmg_00242160;
							_0024n2_00242157 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242161.t.position, Quaternion.identity);
							_0024n2_00242157.SendMessage("SD", (object)_0024dmg_00242160);
							_0024self__00242161.@base.animation.Play();
							if (_0024self__00242161.hp < 1)
							{
								_0024self__00242161.Die();
								goto IL_01f3;
							}
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00242161).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00242160 });
						((Component)_0024self__00242161).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00242160 });
					}
					goto IL_021e;
				case 2:
				{
					_0024self__00242161.@base.animation.Stop();
					_0024self__00242161.takingDamage = false;
					int num = (_0024_0024734_00242158 = 0);
					Vector3 val = (_0024_0024735_00242159 = _0024self__00242161.@base.transform.localPosition);
					float num2 = (_0024_0024735_00242159.z = _0024_0024734_00242158);
					Vector3 val3 = (_0024self__00242161.@base.transform.localPosition = _0024_0024735_00242159);
					goto IL_01f3;
				}
				case 3:
					_0024self__00242161.txtTalk.text = string.Empty;
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

		internal int _0024dmg_00242162;

		internal NPCCommoner _0024self__00242163;

		public _0024TD_00242156(int dmg, NPCCommoner self_)
		{
			_0024dmg_00242162 = dmg;
			_0024self__00242163 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242162, _0024self__00242163);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242164 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242165;

			internal int _0024dmg_00242166;

			internal NPCCommoner _0024self__00242167;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00242166 = dmg;
				_0024self__00242167 = self_;
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
					_0024self__00242167.txtTalk.text = "Ow!";
					_0024self__00242167.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242167.hp -= _0024dmg_00242166;
					_0024i_00242165 = default(int);
					if (_0024self__00242167.hp < 1)
					{
						if (MenuScript.multiplayer > 0)
						{
							for (_0024i_00242165 = 0; _0024i_00242165 < _0024self__00242167.GOLD; _0024i_00242165++)
							{
								Network.Instantiate(Resources.Load("c"), _0024self__00242167.t.position, Quaternion.identity, 0);
							}
						}
						else
						{
							for (_0024i_00242165 = 0; _0024i_00242165 < _0024self__00242167.GOLD; _0024i_00242165++)
							{
								Object.Instantiate(Resources.Load("c"), _0024self__00242167.t.position, Quaternion.identity);
							}
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(((Component)_0024self__00242167).networkView.viewID);
							Network.Destroy(((Component)_0024self__00242167).networkView.viewID);
						}
					}
					else
					{
						_0024self__00242167.takingDamage = false;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242167.txtTalk.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242168;

		internal NPCCommoner _0024self__00242169;

		public _0024TDN_00242164(int dmg, NPCCommoner self_)
		{
			_0024dmg_00242168 = dmg;
			_0024self__00242169 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242168, _0024self__00242169);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242170 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242171;

			internal int _0024_0024736_00242172;

			internal Vector3 _0024_0024737_00242173;

			internal int _0024dmg_00242174;

			internal NPCCommoner _0024self__00242175;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00242174 = dmg;
				_0024self__00242175 = self_;
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
					_0024n2_00242171 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242175.t.position, Quaternion.identity);
					_0024n2_00242171.SendMessage("SD", (object)_0024dmg_00242174);
					_0024self__00242175.@base.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242175.hp < 1)
					{
						goto IL_014c;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00242175.@base.animation.Stop();
					_0024self__00242175.takingDamage = false;
					int num = (_0024_0024736_00242172 = 0);
					Vector3 val = (_0024_0024737_00242173 = _0024self__00242175.@base.transform.localPosition);
					float num2 = (_0024_0024737_00242173.z = _0024_0024736_00242172);
					Vector3 val3 = (_0024self__00242175.@base.transform.localPosition = _0024_0024737_00242173);
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

		internal int _0024dmg_00242176;

		internal NPCCommoner _0024self__00242177;

		public _0024TDN2_00242170(int dmg, NPCCommoner self_)
		{
			_0024dmg_00242176 = dmg;
			_0024self__00242177 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242176, _0024self__00242177);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Move_00242178 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242179;

			internal NPCCommoner _0024self__00242180;

			public _0024(NPCCommoner self_)
			{
				_0024self__00242180 = self_;
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
					_0024num_00242179 = Random.Range(-1, 2);
					if (_0024num_00242179 != 0)
					{
						_0024self__00242180.speed *= (float)_0024num_00242179;
					}
					if (!(_0024self__00242180.speed <= 0f))
					{
						((Component)_0024self__00242180.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00242180.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					}
					_0024self__00242180.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242180.canMove = false;
					_0024num_00242179 = Random.Range(-1, 2);
					if (_0024num_00242179 != 0)
					{
						_0024self__00242180.speed *= (float)_0024num_00242179;
					}
					if (!(_0024self__00242180.speed <= 0f))
					{
						((Component)_0024self__00242180.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00242180.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
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

		internal NPCCommoner _0024self__00242181;

		public _0024Move_00242178(NPCCommoner self_)
		{
			_0024self__00242181 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242181);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock_00242182 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024740_00242183;

			internal Vector3 _0024_0024741_00242184;

			internal int _0024_0024742_00242185;

			internal Vector3 _0024_0024743_00242186;

			internal int _0024_0024744_00242187;

			internal Vector3 _0024_0024745_00242188;

			internal Vector3 _0024p_00242189;

			internal NPCCommoner _0024self__00242190;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00242189 = p;
				_0024self__00242190 = self_;
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
						((Component)_0024self__00242190).networkView.RPC("KnockN", (RPCMode)2, new object[1] { _0024p_00242189 });
						goto IL_01a7;
					}
					if (_0024p_00242189.x <= _0024self__00242190.t.position.x)
					{
						int num3 = (_0024_0024742_00242185 = 10);
						Vector3 val4 = (_0024_0024743_00242186 = ((Component)_0024self__00242190).rigidbody.velocity);
						float num4 = (_0024_0024743_00242186.x = _0024_0024742_00242185);
						Vector3 val6 = (((Component)_0024self__00242190).rigidbody.velocity = _0024_0024743_00242186);
					}
					else
					{
						int num5 = (_0024_0024740_00242183 = -10);
						Vector3 val7 = (_0024_0024741_00242184 = ((Component)_0024self__00242190).rigidbody.velocity);
						float num6 = (_0024_0024741_00242184.x = _0024_0024740_00242183);
						Vector3 val9 = (((Component)_0024self__00242190).rigidbody.velocity = _0024_0024741_00242184);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024744_00242187 = 0);
					Vector3 val = (_0024_0024745_00242188 = ((Component)_0024self__00242190).rigidbody.velocity);
					float num2 = (_0024_0024745_00242188.x = _0024_0024744_00242187);
					Vector3 val3 = (((Component)_0024self__00242190).rigidbody.velocity = _0024_0024745_00242188);
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

		internal Vector3 _0024p_00242191;

		internal NPCCommoner _0024self__00242192;

		public _0024Knock_00242182(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00242191 = p;
			_0024self__00242192 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00242191, _0024self__00242192);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00242193 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024746_00242194;

			internal Vector3 _0024_0024747_00242195;

			internal int _0024_0024748_00242196;

			internal Vector3 _0024_0024749_00242197;

			internal int _0024_0024750_00242198;

			internal Vector3 _0024_0024751_00242199;

			internal Vector3 _0024p_00242200;

			internal NPCCommoner _0024self__00242201;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00242200 = p;
				_0024self__00242201 = self_;
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
					if (_0024p_00242200.x <= _0024self__00242201.t.position.x)
					{
						int num3 = (_0024_0024748_00242196 = 10);
						Vector3 val4 = (_0024_0024749_00242197 = ((Component)_0024self__00242201).rigidbody.velocity);
						float num4 = (_0024_0024749_00242197.x = _0024_0024748_00242196);
						Vector3 val6 = (((Component)_0024self__00242201).rigidbody.velocity = _0024_0024749_00242197);
					}
					else
					{
						int num5 = (_0024_0024746_00242194 = -10);
						Vector3 val7 = (_0024_0024747_00242195 = ((Component)_0024self__00242201).rigidbody.velocity);
						float num6 = (_0024_0024747_00242195.x = _0024_0024746_00242194);
						Vector3 val9 = (((Component)_0024self__00242201).rigidbody.velocity = _0024_0024747_00242195);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024750_00242198 = 0);
					Vector3 val = (_0024_0024751_00242199 = ((Component)_0024self__00242201).rigidbody.velocity);
					float num2 = (_0024_0024751_00242199.x = _0024_0024750_00242198);
					Vector3 val3 = (((Component)_0024self__00242201).rigidbody.velocity = _0024_0024751_00242199);
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

		internal Vector3 _0024p_00242202;

		internal NPCCommoner _0024self__00242203;

		public _0024KnockN_00242193(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00242202 = p;
			_0024self__00242203 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00242202, _0024self__00242203);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242204 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00242205;

			internal int _0024_0024752_00242206;

			internal Vector3 _0024_0024753_00242207;

			internal int _0024_0024754_00242208;

			internal Vector3 _0024_0024755_00242209;

			internal int _0024_0024756_00242210;

			internal Vector3 _0024_0024757_00242211;

			internal int _0024_0024758_00242212;

			internal Vector3 _0024_0024759_00242213;

			internal bool _0024l_00242214;

			internal NPCCommoner _0024self__00242215;

			public _0024(bool l, NPCCommoner self_)
			{
				_0024l_00242214 = l;
				_0024self__00242215 = self_;
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
					_0024i_00242205 = default(int);
					if (_0024l_00242214)
					{
						int num = (_0024_0024752_00242206 = -10);
						Vector3 val = (_0024_0024753_00242207 = _0024self__00242215.r.velocity);
						float num2 = (_0024_0024753_00242207.x = _0024_0024752_00242206);
						Vector3 val3 = (_0024self__00242215.r.velocity = _0024_0024753_00242207);
						int num3 = (_0024_0024754_00242208 = 10);
						Vector3 val4 = (_0024_0024755_00242209 = _0024self__00242215.r.velocity);
						float num4 = (_0024_0024755_00242209.y = _0024_0024754_00242208);
						Vector3 val6 = (_0024self__00242215.r.velocity = _0024_0024755_00242209);
						result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024756_00242210 = 10);
						Vector3 val7 = (_0024_0024757_00242211 = _0024self__00242215.r.velocity);
						float num6 = (_0024_0024757_00242211.x = _0024_0024756_00242210);
						Vector3 val9 = (_0024self__00242215.r.velocity = _0024_0024757_00242211);
						int num7 = (_0024_0024758_00242212 = 10);
						Vector3 val10 = (_0024_0024759_00242213 = _0024self__00242215.r.velocity);
						float num8 = (_0024_0024759_00242213.y = _0024_0024758_00242212);
						Vector3 val12 = (_0024self__00242215.r.velocity = _0024_0024759_00242213);
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

		internal bool _0024l_00242216;

		internal NPCCommoner _0024self__00242217;

		public _0024K_00242204(bool l, NPCCommoner self_)
		{
			_0024l_00242216 = l;
			_0024self__00242217 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return (IEnumerator<WaitForEndOfFrame>)(object)new _0024(_0024l_00242216, _0024self__00242217);
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
				((Component)this).networkView.RPC("SetAppearance", (RPCMode)6, new object[2]
				{
					race,
					Random.Range(0, 3)
				});
			}
		}
		else
		{
			SetAppearance(race, Random.Range(0, 3));
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
		return new _0024Talk_00242143(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator SaySomething(int a)
	{
		return new _0024SaySomething_00242146(a, this).GetEnumerator();
	}

	[RPC]
	public override void SetAppearance(int r, int v)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		head.renderer.material = (Material)Resources.Load("r/r" + (object)r + "h" + (object)v);
	}

	public override int GetRace()
	{
		int num = Random.Range(0, 100);
		int num2 = default(int);
		if (num < 40)
		{
			return 0;
		}
		if (num < 60)
		{
			return 1;
		}
		if (num < 70)
		{
			return 2;
		}
		if (num < 85)
		{
			return 3;
		}
		if (num < 90)
		{
			return 4;
		}
		if (num < 95)
		{
			return 5;
		}
		return 6;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242153(this).GetEnumerator();
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00242156(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242164(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242170(dmg, this).GetEnumerator();
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
		return new _0024Move_00242178(this).GetEnumerator();
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
		return new _0024Knock_00242182(p, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KnockN(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024KnockN_00242193(p, this).GetEnumerator();
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00242204(l, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
