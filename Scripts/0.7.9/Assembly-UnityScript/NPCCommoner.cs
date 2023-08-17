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
	internal sealed class _0024Talk_00241945 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCCommoner _0024self__00241946;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241946 = self_;
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
							((Component)_0024self__00241946).networkView.RPC("SaySomething", (RPCMode)2, new object[1] { Random.Range(0, 10) });
						}
					}
					else
					{
						((MonoBehaviour)_0024self__00241946).StartCoroutine_Auto(_0024self__00241946.SaySomething(Random.Range(0, 10)));
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

		internal NPCCommoner _0024self__00241947;

		public _0024Talk_00241945(NPCCommoner self_)
		{
			_0024self__00241947 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241947);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SaySomething_00241948 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00241949;

			internal int _0024_0024switch_0024370_00241950;

			internal int _0024a_00241951;

			internal NPCCommoner _0024self__00241952;

			public _0024(int a, NPCCommoner self_)
			{
				_0024a_00241951 = a;
				_0024self__00241952 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024s_00241949 = null;
					_0024_0024switch_0024370_00241950 = _0024a_00241951;
					if (_0024_0024switch_0024370_00241950 == 0)
					{
						_0024s_00241949 = "Life is great.";
					}
					else if (_0024_0024switch_0024370_00241950 == 1)
					{
						_0024s_00241949 = "Deephaven is scary.";
					}
					else if (_0024_0024switch_0024370_00241950 == 2)
					{
						_0024s_00241949 = "I'm hungry";
					}
					else if (_0024_0024switch_0024370_00241950 == 3)
					{
						_0024s_00241949 = "I hate chicken.";
					}
					else if (_0024_0024switch_0024370_00241950 == 4)
					{
						_0024s_00241949 = "The Scourge suck!";
					}
					else if (_0024_0024switch_0024370_00241950 == 5)
					{
						_0024s_00241949 = "I miss the sun...";
					}
					else if (_0024_0024switch_0024370_00241950 == 6)
					{
						_0024s_00241949 = "*Cough*";
					}
					else if (_0024_0024switch_0024370_00241950 == 7)
					{
						_0024s_00241949 = "Someone smells funny.";
					}
					else if (_0024_0024switch_0024370_00241950 == 8)
					{
						_0024s_00241949 = "Idk what I want.";
					}
					else if (_0024_0024switch_0024370_00241950 == 9)
					{
						_0024s_00241949 = "I need to poop!";
					}
					_0024self__00241952.txtTalk.text = string.Empty + _0024s_00241949;
					_0024self__00241952.txtTalk2.text = string.Empty + _0024s_00241949;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241952.txtTalk.text = string.Empty;
					_0024self__00241952.txtTalk2.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241953;

		internal NPCCommoner _0024self__00241954;

		public _0024SaySomething_00241948(int a, NPCCommoner self_)
		{
			_0024a_00241953 = a;
			_0024self__00241954 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241953, _0024self__00241954);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241955 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal NPCCommoner _0024self__00241956;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241956 = self_;
			}

			public override bool MoveNext()
			{
				return base._state switch
				{
					1 => false, 
					_ => ((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00241956).StartCoroutine_Auto(_0024self__00241956.Move())), 
				};
			}
		}

		internal NPCCommoner _0024self__00241957;

		public _0024Start_00241955(NPCCommoner self_)
		{
			_0024self__00241957 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00241957);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00241958 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00241959;

			internal int _0024_0024711_00241960;

			internal Vector3 _0024_0024712_00241961;

			internal int _0024dmg_00241962;

			internal NPCCommoner _0024self__00241963;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241962 = dmg;
				_0024self__00241963 = self_;
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
					if (!_0024self__00241963.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00241963.txtTalk.text = "Ow!";
							_0024self__00241963.takingDamage = true;
							_0024self__00241963.hp -= _0024dmg_00241962;
							_0024n2_00241959 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241963.t.position, Quaternion.identity);
							_0024n2_00241959.SendMessage("SD", (object)_0024dmg_00241962);
							_0024self__00241963.@base.animation.Play();
							if (_0024self__00241963.hp < 1)
							{
								_0024self__00241963.Die();
								goto IL_01f3;
							}
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00241963).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00241962 });
						((Component)_0024self__00241963).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00241962 });
					}
					goto IL_021e;
				case 2:
				{
					_0024self__00241963.@base.animation.Stop();
					_0024self__00241963.takingDamage = false;
					int num = (_0024_0024711_00241960 = 0);
					Vector3 val = (_0024_0024712_00241961 = _0024self__00241963.@base.transform.localPosition);
					float num2 = (_0024_0024712_00241961.z = _0024_0024711_00241960);
					Vector3 val3 = (_0024self__00241963.@base.transform.localPosition = _0024_0024712_00241961);
					goto IL_01f3;
				}
				case 3:
					_0024self__00241963.txtTalk.text = string.Empty;
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

		internal int _0024dmg_00241964;

		internal NPCCommoner _0024self__00241965;

		public _0024TD_00241958(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241964 = dmg;
			_0024self__00241965 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241964, _0024self__00241965);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00241966 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241967;

			internal int _0024dmg_00241968;

			internal NPCCommoner _0024self__00241969;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241968 = dmg;
				_0024self__00241969 = self_;
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
					_0024self__00241969.txtTalk.text = "Ow!";
					_0024self__00241969.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241969.hp -= _0024dmg_00241968;
					_0024i_00241967 = default(int);
					if (_0024self__00241969.hp < 1)
					{
						if (MenuScript.multiplayer > 0)
						{
							for (_0024i_00241967 = 0; _0024i_00241967 < _0024self__00241969.GOLD; _0024i_00241967++)
							{
								Network.Instantiate(Resources.Load("c"), _0024self__00241969.t.position, Quaternion.identity, 0);
							}
						}
						else
						{
							for (_0024i_00241967 = 0; _0024i_00241967 < _0024self__00241969.GOLD; _0024i_00241967++)
							{
								Object.Instantiate(Resources.Load("c"), _0024self__00241969.t.position, Quaternion.identity);
							}
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(((Component)_0024self__00241969).networkView.viewID);
							Network.Destroy(((Component)_0024self__00241969).networkView.viewID);
						}
					}
					else
					{
						_0024self__00241969.takingDamage = false;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241969.txtTalk.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00241970;

		internal NPCCommoner _0024self__00241971;

		public _0024TDN_00241966(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241970 = dmg;
			_0024self__00241971 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241970, _0024self__00241971);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00241972 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00241973;

			internal int _0024_0024713_00241974;

			internal Vector3 _0024_0024714_00241975;

			internal int _0024dmg_00241976;

			internal NPCCommoner _0024self__00241977;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241976 = dmg;
				_0024self__00241977 = self_;
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
					_0024n2_00241973 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241977.t.position, Quaternion.identity);
					_0024n2_00241973.SendMessage("SD", (object)_0024dmg_00241976);
					_0024self__00241977.@base.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241977.hp < 1)
					{
						goto IL_014c;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00241977.@base.animation.Stop();
					_0024self__00241977.takingDamage = false;
					int num = (_0024_0024713_00241974 = 0);
					Vector3 val = (_0024_0024714_00241975 = _0024self__00241977.@base.transform.localPosition);
					float num2 = (_0024_0024714_00241975.z = _0024_0024713_00241974);
					Vector3 val3 = (_0024self__00241977.@base.transform.localPosition = _0024_0024714_00241975);
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

		internal int _0024dmg_00241978;

		internal NPCCommoner _0024self__00241979;

		public _0024TDN2_00241972(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241978 = dmg;
			_0024self__00241979 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241978, _0024self__00241979);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Move_00241980 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241981;

			internal NPCCommoner _0024self__00241982;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241982 = self_;
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
					_0024num_00241981 = Random.Range(-1, 2);
					if (_0024num_00241981 != 0)
					{
						_0024self__00241982.speed *= (float)_0024num_00241981;
					}
					if (!(_0024self__00241982.speed <= 0f))
					{
						((Component)_0024self__00241982.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00241982.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					}
					_0024self__00241982.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00241982.canMove = false;
					_0024num_00241981 = Random.Range(-1, 2);
					if (_0024num_00241981 != 0)
					{
						_0024self__00241982.speed *= (float)_0024num_00241981;
					}
					if (!(_0024self__00241982.speed <= 0f))
					{
						((Component)_0024self__00241982.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00241982.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
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

		internal NPCCommoner _0024self__00241983;

		public _0024Move_00241980(NPCCommoner self_)
		{
			_0024self__00241983 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241983);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock_00241984 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024717_00241985;

			internal Vector3 _0024_0024718_00241986;

			internal int _0024_0024719_00241987;

			internal Vector3 _0024_0024720_00241988;

			internal int _0024_0024721_00241989;

			internal Vector3 _0024_0024722_00241990;

			internal Vector3 _0024p_00241991;

			internal NPCCommoner _0024self__00241992;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241991 = p;
				_0024self__00241992 = self_;
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
						((Component)_0024self__00241992).networkView.RPC("KnockN", (RPCMode)2, new object[1] { _0024p_00241991 });
						goto IL_01a7;
					}
					if (_0024p_00241991.x <= _0024self__00241992.t.position.x)
					{
						int num3 = (_0024_0024719_00241987 = 10);
						Vector3 val4 = (_0024_0024720_00241988 = ((Component)_0024self__00241992).rigidbody.velocity);
						float num4 = (_0024_0024720_00241988.x = _0024_0024719_00241987);
						Vector3 val6 = (((Component)_0024self__00241992).rigidbody.velocity = _0024_0024720_00241988);
					}
					else
					{
						int num5 = (_0024_0024717_00241985 = -10);
						Vector3 val7 = (_0024_0024718_00241986 = ((Component)_0024self__00241992).rigidbody.velocity);
						float num6 = (_0024_0024718_00241986.x = _0024_0024717_00241985);
						Vector3 val9 = (((Component)_0024self__00241992).rigidbody.velocity = _0024_0024718_00241986);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024721_00241989 = 0);
					Vector3 val = (_0024_0024722_00241990 = ((Component)_0024self__00241992).rigidbody.velocity);
					float num2 = (_0024_0024722_00241990.x = _0024_0024721_00241989);
					Vector3 val3 = (((Component)_0024self__00241992).rigidbody.velocity = _0024_0024722_00241990);
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

		internal Vector3 _0024p_00241993;

		internal NPCCommoner _0024self__00241994;

		public _0024Knock_00241984(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241993 = p;
			_0024self__00241994 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241993, _0024self__00241994);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00241995 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024723_00241996;

			internal Vector3 _0024_0024724_00241997;

			internal int _0024_0024725_00241998;

			internal Vector3 _0024_0024726_00241999;

			internal int _0024_0024727_00242000;

			internal Vector3 _0024_0024728_00242001;

			internal Vector3 _0024p_00242002;

			internal NPCCommoner _0024self__00242003;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00242002 = p;
				_0024self__00242003 = self_;
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
					if (_0024p_00242002.x <= _0024self__00242003.t.position.x)
					{
						int num3 = (_0024_0024725_00241998 = 10);
						Vector3 val4 = (_0024_0024726_00241999 = ((Component)_0024self__00242003).rigidbody.velocity);
						float num4 = (_0024_0024726_00241999.x = _0024_0024725_00241998);
						Vector3 val6 = (((Component)_0024self__00242003).rigidbody.velocity = _0024_0024726_00241999);
					}
					else
					{
						int num5 = (_0024_0024723_00241996 = -10);
						Vector3 val7 = (_0024_0024724_00241997 = ((Component)_0024self__00242003).rigidbody.velocity);
						float num6 = (_0024_0024724_00241997.x = _0024_0024723_00241996);
						Vector3 val9 = (((Component)_0024self__00242003).rigidbody.velocity = _0024_0024724_00241997);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024727_00242000 = 0);
					Vector3 val = (_0024_0024728_00242001 = ((Component)_0024self__00242003).rigidbody.velocity);
					float num2 = (_0024_0024728_00242001.x = _0024_0024727_00242000);
					Vector3 val3 = (((Component)_0024self__00242003).rigidbody.velocity = _0024_0024728_00242001);
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

		internal Vector3 _0024p_00242004;

		internal NPCCommoner _0024self__00242005;

		public _0024KnockN_00241995(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00242004 = p;
			_0024self__00242005 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00242004, _0024self__00242005);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242006 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00242007;

			internal int _0024_0024729_00242008;

			internal Vector3 _0024_0024730_00242009;

			internal int _0024_0024731_00242010;

			internal Vector3 _0024_0024732_00242011;

			internal int _0024_0024733_00242012;

			internal Vector3 _0024_0024734_00242013;

			internal int _0024_0024735_00242014;

			internal Vector3 _0024_0024736_00242015;

			internal bool _0024l_00242016;

			internal NPCCommoner _0024self__00242017;

			public _0024(bool l, NPCCommoner self_)
			{
				_0024l_00242016 = l;
				_0024self__00242017 = self_;
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
					_0024i_00242007 = default(int);
					if (_0024l_00242016)
					{
						int num = (_0024_0024729_00242008 = -10);
						Vector3 val = (_0024_0024730_00242009 = _0024self__00242017.r.velocity);
						float num2 = (_0024_0024730_00242009.x = _0024_0024729_00242008);
						Vector3 val3 = (_0024self__00242017.r.velocity = _0024_0024730_00242009);
						int num3 = (_0024_0024731_00242010 = 10);
						Vector3 val4 = (_0024_0024732_00242011 = _0024self__00242017.r.velocity);
						float num4 = (_0024_0024732_00242011.y = _0024_0024731_00242010);
						Vector3 val6 = (_0024self__00242017.r.velocity = _0024_0024732_00242011);
						result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024733_00242012 = 10);
						Vector3 val7 = (_0024_0024734_00242013 = _0024self__00242017.r.velocity);
						float num6 = (_0024_0024734_00242013.x = _0024_0024733_00242012);
						Vector3 val9 = (_0024self__00242017.r.velocity = _0024_0024734_00242013);
						int num7 = (_0024_0024735_00242014 = 10);
						Vector3 val10 = (_0024_0024736_00242015 = _0024self__00242017.r.velocity);
						float num8 = (_0024_0024736_00242015.y = _0024_0024735_00242014);
						Vector3 val12 = (_0024self__00242017.r.velocity = _0024_0024736_00242015);
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

		internal bool _0024l_00242018;

		internal NPCCommoner _0024self__00242019;

		public _0024K_00242006(bool l, NPCCommoner self_)
		{
			_0024l_00242018 = l;
			_0024self__00242019 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return (IEnumerator<WaitForEndOfFrame>)(object)new _0024(_0024l_00242018, _0024self__00242019);
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
		return new _0024Talk_00241945(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator SaySomething(int a)
	{
		return new _0024SaySomething_00241948(a, this).GetEnumerator();
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
		return new _0024Start_00241955(this).GetEnumerator();
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00241958(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00241966(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00241972(dmg, this).GetEnumerator();
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
		return new _0024Move_00241980(this).GetEnumerator();
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
		return new _0024Knock_00241984(p, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KnockN(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024KnockN_00241995(p, this).GetEnumerator();
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00242006(l, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
