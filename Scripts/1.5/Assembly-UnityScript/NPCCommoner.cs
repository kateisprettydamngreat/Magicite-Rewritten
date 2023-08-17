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
	internal sealed class _0024Talk_00242183 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCCommoner _0024self__00242184;

			public _0024(NPCCommoner self_)
			{
				_0024self__00242184 = self_;
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
							((Component)_0024self__00242184).networkView.RPC("SaySomething", (RPCMode)2, new object[1] { Random.Range(0, 10) });
						}
					}
					else
					{
						((MonoBehaviour)_0024self__00242184).StartCoroutine_Auto(_0024self__00242184.SaySomething(Random.Range(0, 10)));
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

		internal NPCCommoner _0024self__00242185;

		public _0024Talk_00242183(NPCCommoner self_)
		{
			_0024self__00242185 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242185);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SaySomething_00242186 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00242187;

			internal int _0024_0024switch_0024393_00242188;

			internal int _0024a_00242189;

			internal NPCCommoner _0024self__00242190;

			public _0024(int a, NPCCommoner self_)
			{
				_0024a_00242189 = a;
				_0024self__00242190 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024s_00242187 = null;
					_0024_0024switch_0024393_00242188 = _0024a_00242189;
					if (_0024_0024switch_0024393_00242188 == 0)
					{
						_0024s_00242187 = "Life is great.";
					}
					else if (_0024_0024switch_0024393_00242188 == 1)
					{
						_0024s_00242187 = "Deephaven is scary.";
					}
					else if (_0024_0024switch_0024393_00242188 == 2)
					{
						_0024s_00242187 = "I'm hungry";
					}
					else if (_0024_0024switch_0024393_00242188 == 3)
					{
						_0024s_00242187 = "I hate chicken.";
					}
					else if (_0024_0024switch_0024393_00242188 == 4)
					{
						_0024s_00242187 = "The Scourge suck!";
					}
					else if (_0024_0024switch_0024393_00242188 == 5)
					{
						_0024s_00242187 = "I miss the sun...";
					}
					else if (_0024_0024switch_0024393_00242188 == 6)
					{
						_0024s_00242187 = "*Cough*";
					}
					else if (_0024_0024switch_0024393_00242188 == 7)
					{
						_0024s_00242187 = "Someone smells funny.";
					}
					else if (_0024_0024switch_0024393_00242188 == 8)
					{
						_0024s_00242187 = "Idk what I want.";
					}
					else if (_0024_0024switch_0024393_00242188 == 9)
					{
						_0024s_00242187 = "I need to poop!";
					}
					_0024self__00242190.txtTalk.text = string.Empty + _0024s_00242187;
					_0024self__00242190.txtTalk2.text = string.Empty + _0024s_00242187;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242190.txtTalk.text = string.Empty;
					_0024self__00242190.txtTalk2.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242191;

		internal NPCCommoner _0024self__00242192;

		public _0024SaySomething_00242186(int a, NPCCommoner self_)
		{
			_0024a_00242191 = a;
			_0024self__00242192 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242191, _0024self__00242192);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242193 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal NPCCommoner _0024self__00242194;

			public _0024(NPCCommoner self_)
			{
				_0024self__00242194 = self_;
			}

			public override bool MoveNext()
			{
				return base._state switch
				{
					1 => false, 
					_ => ((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242194).StartCoroutine_Auto(_0024self__00242194.Move())), 
				};
			}
		}

		internal NPCCommoner _0024self__00242195;

		public _0024Start_00242193(NPCCommoner self_)
		{
			_0024self__00242195 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242195);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00242196 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242197;

			internal int _0024_0024750_00242198;

			internal Vector3 _0024_0024751_00242199;

			internal int _0024dmg_00242200;

			internal NPCCommoner _0024self__00242201;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00242200 = dmg;
				_0024self__00242201 = self_;
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
					if (!_0024self__00242201.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00242201.txtTalk.text = "Ow!";
							_0024self__00242201.takingDamage = true;
							_0024self__00242201.hp -= _0024dmg_00242200;
							_0024n2_00242197 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242201.t.position, Quaternion.identity);
							_0024n2_00242197.SendMessage("SD", (object)_0024dmg_00242200);
							_0024self__00242201.@base.animation.Play();
							if (_0024self__00242201.hp < 1)
							{
								_0024self__00242201.Die();
								goto IL_01f3;
							}
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00242201).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00242200 });
						((Component)_0024self__00242201).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00242200 });
					}
					goto IL_021e;
				case 2:
				{
					_0024self__00242201.@base.animation.Stop();
					_0024self__00242201.takingDamage = false;
					int num = (_0024_0024750_00242198 = 0);
					Vector3 val = (_0024_0024751_00242199 = _0024self__00242201.@base.transform.localPosition);
					float num2 = (_0024_0024751_00242199.z = _0024_0024750_00242198);
					Vector3 val3 = (_0024self__00242201.@base.transform.localPosition = _0024_0024751_00242199);
					goto IL_01f3;
				}
				case 3:
					_0024self__00242201.txtTalk.text = string.Empty;
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

		internal int _0024dmg_00242202;

		internal NPCCommoner _0024self__00242203;

		public _0024TD_00242196(int dmg, NPCCommoner self_)
		{
			_0024dmg_00242202 = dmg;
			_0024self__00242203 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242202, _0024self__00242203);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242204 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242205;

			internal int _0024dmg_00242206;

			internal NPCCommoner _0024self__00242207;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00242206 = dmg;
				_0024self__00242207 = self_;
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
					_0024self__00242207.txtTalk.text = "Ow!";
					_0024self__00242207.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242207.hp -= _0024dmg_00242206;
					_0024i_00242205 = default(int);
					if (_0024self__00242207.hp < 1)
					{
						if (MenuScript.multiplayer > 0)
						{
							for (_0024i_00242205 = 0; _0024i_00242205 < _0024self__00242207.GOLD; _0024i_00242205++)
							{
								Network.Instantiate(Resources.Load("c"), _0024self__00242207.t.position, Quaternion.identity, 0);
							}
						}
						else
						{
							for (_0024i_00242205 = 0; _0024i_00242205 < _0024self__00242207.GOLD; _0024i_00242205++)
							{
								Object.Instantiate(Resources.Load("c"), _0024self__00242207.t.position, Quaternion.identity);
							}
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(((Component)_0024self__00242207).networkView.viewID);
							Network.Destroy(((Component)_0024self__00242207).networkView.viewID);
						}
					}
					else
					{
						_0024self__00242207.takingDamage = false;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242207.txtTalk.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242208;

		internal NPCCommoner _0024self__00242209;

		public _0024TDN_00242204(int dmg, NPCCommoner self_)
		{
			_0024dmg_00242208 = dmg;
			_0024self__00242209 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242208, _0024self__00242209);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242210 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242211;

			internal int _0024_0024752_00242212;

			internal Vector3 _0024_0024753_00242213;

			internal int _0024dmg_00242214;

			internal NPCCommoner _0024self__00242215;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00242214 = dmg;
				_0024self__00242215 = self_;
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
					_0024n2_00242211 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242215.t.position, Quaternion.identity);
					_0024n2_00242211.SendMessage("SD", (object)_0024dmg_00242214);
					_0024self__00242215.@base.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242215.hp < 1)
					{
						goto IL_014c;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00242215.@base.animation.Stop();
					_0024self__00242215.takingDamage = false;
					int num = (_0024_0024752_00242212 = 0);
					Vector3 val = (_0024_0024753_00242213 = _0024self__00242215.@base.transform.localPosition);
					float num2 = (_0024_0024753_00242213.z = _0024_0024752_00242212);
					Vector3 val3 = (_0024self__00242215.@base.transform.localPosition = _0024_0024753_00242213);
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

		internal int _0024dmg_00242216;

		internal NPCCommoner _0024self__00242217;

		public _0024TDN2_00242210(int dmg, NPCCommoner self_)
		{
			_0024dmg_00242216 = dmg;
			_0024self__00242217 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242216, _0024self__00242217);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Move_00242218 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242219;

			internal NPCCommoner _0024self__00242220;

			public _0024(NPCCommoner self_)
			{
				_0024self__00242220 = self_;
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
					_0024num_00242219 = Random.Range(-1, 2);
					if (_0024num_00242219 != 0)
					{
						_0024self__00242220.speed *= (float)_0024num_00242219;
					}
					if (!(_0024self__00242220.speed <= 0f))
					{
						((Component)_0024self__00242220.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00242220.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					}
					_0024self__00242220.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242220.canMove = false;
					_0024num_00242219 = Random.Range(-1, 2);
					if (_0024num_00242219 != 0)
					{
						_0024self__00242220.speed *= (float)_0024num_00242219;
					}
					if (!(_0024self__00242220.speed <= 0f))
					{
						((Component)_0024self__00242220.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00242220.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
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

		internal NPCCommoner _0024self__00242221;

		public _0024Move_00242218(NPCCommoner self_)
		{
			_0024self__00242221 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242221);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock_00242222 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024756_00242223;

			internal Vector3 _0024_0024757_00242224;

			internal int _0024_0024758_00242225;

			internal Vector3 _0024_0024759_00242226;

			internal int _0024_0024760_00242227;

			internal Vector3 _0024_0024761_00242228;

			internal Vector3 _0024p_00242229;

			internal NPCCommoner _0024self__00242230;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00242229 = p;
				_0024self__00242230 = self_;
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
						((Component)_0024self__00242230).networkView.RPC("KnockN", (RPCMode)2, new object[1] { _0024p_00242229 });
						goto IL_01a7;
					}
					if (_0024p_00242229.x <= _0024self__00242230.t.position.x)
					{
						int num3 = (_0024_0024758_00242225 = 10);
						Vector3 val4 = (_0024_0024759_00242226 = ((Component)_0024self__00242230).rigidbody.velocity);
						float num4 = (_0024_0024759_00242226.x = _0024_0024758_00242225);
						Vector3 val6 = (((Component)_0024self__00242230).rigidbody.velocity = _0024_0024759_00242226);
					}
					else
					{
						int num5 = (_0024_0024756_00242223 = -10);
						Vector3 val7 = (_0024_0024757_00242224 = ((Component)_0024self__00242230).rigidbody.velocity);
						float num6 = (_0024_0024757_00242224.x = _0024_0024756_00242223);
						Vector3 val9 = (((Component)_0024self__00242230).rigidbody.velocity = _0024_0024757_00242224);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024760_00242227 = 0);
					Vector3 val = (_0024_0024761_00242228 = ((Component)_0024self__00242230).rigidbody.velocity);
					float num2 = (_0024_0024761_00242228.x = _0024_0024760_00242227);
					Vector3 val3 = (((Component)_0024self__00242230).rigidbody.velocity = _0024_0024761_00242228);
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

		internal Vector3 _0024p_00242231;

		internal NPCCommoner _0024self__00242232;

		public _0024Knock_00242222(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00242231 = p;
			_0024self__00242232 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00242231, _0024self__00242232);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00242233 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024762_00242234;

			internal Vector3 _0024_0024763_00242235;

			internal int _0024_0024764_00242236;

			internal Vector3 _0024_0024765_00242237;

			internal int _0024_0024766_00242238;

			internal Vector3 _0024_0024767_00242239;

			internal Vector3 _0024p_00242240;

			internal NPCCommoner _0024self__00242241;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00242240 = p;
				_0024self__00242241 = self_;
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
					if (_0024p_00242240.x <= _0024self__00242241.t.position.x)
					{
						int num3 = (_0024_0024764_00242236 = 10);
						Vector3 val4 = (_0024_0024765_00242237 = ((Component)_0024self__00242241).rigidbody.velocity);
						float num4 = (_0024_0024765_00242237.x = _0024_0024764_00242236);
						Vector3 val6 = (((Component)_0024self__00242241).rigidbody.velocity = _0024_0024765_00242237);
					}
					else
					{
						int num5 = (_0024_0024762_00242234 = -10);
						Vector3 val7 = (_0024_0024763_00242235 = ((Component)_0024self__00242241).rigidbody.velocity);
						float num6 = (_0024_0024763_00242235.x = _0024_0024762_00242234);
						Vector3 val9 = (((Component)_0024self__00242241).rigidbody.velocity = _0024_0024763_00242235);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024766_00242238 = 0);
					Vector3 val = (_0024_0024767_00242239 = ((Component)_0024self__00242241).rigidbody.velocity);
					float num2 = (_0024_0024767_00242239.x = _0024_0024766_00242238);
					Vector3 val3 = (((Component)_0024self__00242241).rigidbody.velocity = _0024_0024767_00242239);
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

		internal Vector3 _0024p_00242242;

		internal NPCCommoner _0024self__00242243;

		public _0024KnockN_00242233(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00242242 = p;
			_0024self__00242243 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00242242, _0024self__00242243);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242244 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00242245;

			internal int _0024_0024768_00242246;

			internal Vector3 _0024_0024769_00242247;

			internal int _0024_0024770_00242248;

			internal Vector3 _0024_0024771_00242249;

			internal int _0024_0024772_00242250;

			internal Vector3 _0024_0024773_00242251;

			internal int _0024_0024774_00242252;

			internal Vector3 _0024_0024775_00242253;

			internal bool _0024l_00242254;

			internal NPCCommoner _0024self__00242255;

			public _0024(bool l, NPCCommoner self_)
			{
				_0024l_00242254 = l;
				_0024self__00242255 = self_;
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
					_0024i_00242245 = default(int);
					if (_0024l_00242254)
					{
						int num = (_0024_0024768_00242246 = -10);
						Vector3 val = (_0024_0024769_00242247 = _0024self__00242255.r.velocity);
						float num2 = (_0024_0024769_00242247.x = _0024_0024768_00242246);
						Vector3 val3 = (_0024self__00242255.r.velocity = _0024_0024769_00242247);
						int num3 = (_0024_0024770_00242248 = 10);
						Vector3 val4 = (_0024_0024771_00242249 = _0024self__00242255.r.velocity);
						float num4 = (_0024_0024771_00242249.y = _0024_0024770_00242248);
						Vector3 val6 = (_0024self__00242255.r.velocity = _0024_0024771_00242249);
						result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024772_00242250 = 10);
						Vector3 val7 = (_0024_0024773_00242251 = _0024self__00242255.r.velocity);
						float num6 = (_0024_0024773_00242251.x = _0024_0024772_00242250);
						Vector3 val9 = (_0024self__00242255.r.velocity = _0024_0024773_00242251);
						int num7 = (_0024_0024774_00242252 = 10);
						Vector3 val10 = (_0024_0024775_00242253 = _0024self__00242255.r.velocity);
						float num8 = (_0024_0024775_00242253.y = _0024_0024774_00242252);
						Vector3 val12 = (_0024self__00242255.r.velocity = _0024_0024775_00242253);
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

		internal bool _0024l_00242256;

		internal NPCCommoner _0024self__00242257;

		public _0024K_00242244(bool l, NPCCommoner self_)
		{
			_0024l_00242256 = l;
			_0024self__00242257 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return (IEnumerator<WaitForEndOfFrame>)(object)new _0024(_0024l_00242256, _0024self__00242257);
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
		return new _0024Talk_00242183(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator SaySomething(int a)
	{
		return new _0024SaySomething_00242186(a, this).GetEnumerator();
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
		return new _0024Start_00242193(this).GetEnumerator();
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00242196(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242204(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242210(dmg, this).GetEnumerator();
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
		return new _0024Move_00242218(this).GetEnumerator();
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
		return new _0024Knock_00242222(p, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KnockN(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024KnockN_00242233(p, this).GetEnumerator();
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00242244(l, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
