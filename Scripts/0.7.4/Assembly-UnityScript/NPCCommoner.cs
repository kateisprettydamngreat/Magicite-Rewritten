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
	internal sealed class _0024Talk_00241845 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCCommoner _0024self__00241846;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241846 = self_;
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
							((Component)_0024self__00241846).networkView.RPC("SaySomething", (RPCMode)2, new object[1] { Random.Range(0, 10) });
						}
					}
					else
					{
						((MonoBehaviour)_0024self__00241846).StartCoroutine_Auto(_0024self__00241846.SaySomething(Random.Range(0, 10)));
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

		internal NPCCommoner _0024self__00241847;

		public _0024Talk_00241845(NPCCommoner self_)
		{
			_0024self__00241847 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241847);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SaySomething_00241848 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00241849;

			internal int _0024_0024switch_0024356_00241850;

			internal int _0024a_00241851;

			internal NPCCommoner _0024self__00241852;

			public _0024(int a, NPCCommoner self_)
			{
				_0024a_00241851 = a;
				_0024self__00241852 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024s_00241849 = null;
					_0024_0024switch_0024356_00241850 = _0024a_00241851;
					if (_0024_0024switch_0024356_00241850 == 0)
					{
						_0024s_00241849 = "Life is great.";
					}
					else if (_0024_0024switch_0024356_00241850 == 1)
					{
						_0024s_00241849 = "Deephaven is scary.";
					}
					else if (_0024_0024switch_0024356_00241850 == 2)
					{
						_0024s_00241849 = "I'm hungry";
					}
					else if (_0024_0024switch_0024356_00241850 == 3)
					{
						_0024s_00241849 = "I hate chicken.";
					}
					else if (_0024_0024switch_0024356_00241850 == 4)
					{
						_0024s_00241849 = "The Scourge suck!";
					}
					else if (_0024_0024switch_0024356_00241850 == 5)
					{
						_0024s_00241849 = "I miss the sun...";
					}
					else if (_0024_0024switch_0024356_00241850 == 6)
					{
						_0024s_00241849 = "*Cough*";
					}
					else if (_0024_0024switch_0024356_00241850 == 7)
					{
						_0024s_00241849 = "Someone smells funny.";
					}
					else if (_0024_0024switch_0024356_00241850 == 8)
					{
						_0024s_00241849 = "Idk what I want.";
					}
					else if (_0024_0024switch_0024356_00241850 == 9)
					{
						_0024s_00241849 = "I need to poop!";
					}
					_0024self__00241852.txtTalk.text = string.Empty + _0024s_00241849;
					_0024self__00241852.txtTalk2.text = string.Empty + _0024s_00241849;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241852.txtTalk.text = string.Empty;
					_0024self__00241852.txtTalk2.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241853;

		internal NPCCommoner _0024self__00241854;

		public _0024SaySomething_00241848(int a, NPCCommoner self_)
		{
			_0024a_00241853 = a;
			_0024self__00241854 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241853, _0024self__00241854);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241855 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal NPCCommoner _0024self__00241856;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241856 = self_;
			}

			public override bool MoveNext()
			{
				return base._state switch
				{
					1 => false, 
					_ => ((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00241856).StartCoroutine_Auto(_0024self__00241856.Move())), 
				};
			}
		}

		internal NPCCommoner _0024self__00241857;

		public _0024Start_00241855(NPCCommoner self_)
		{
			_0024self__00241857 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00241857);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00241858 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00241859;

			internal int _0024_0024677_00241860;

			internal Vector3 _0024_0024678_00241861;

			internal int _0024dmg_00241862;

			internal NPCCommoner _0024self__00241863;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241862 = dmg;
				_0024self__00241863 = self_;
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
					if (!_0024self__00241863.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00241863.txtTalk.text = "Ow!";
							_0024self__00241863.takingDamage = true;
							_0024self__00241863.hp -= _0024dmg_00241862;
							_0024n2_00241859 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241863.t.position, Quaternion.identity);
							_0024n2_00241859.SendMessage("SD", (object)_0024dmg_00241862);
							_0024self__00241863.@base.animation.Play();
							if (_0024self__00241863.hp < 1)
							{
								_0024self__00241863.Die();
								goto IL_01f3;
							}
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00241863).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00241862 });
						((Component)_0024self__00241863).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00241862 });
					}
					goto IL_021e;
				case 2:
				{
					_0024self__00241863.@base.animation.Stop();
					_0024self__00241863.takingDamage = false;
					int num = (_0024_0024677_00241860 = 0);
					Vector3 val = (_0024_0024678_00241861 = _0024self__00241863.@base.transform.localPosition);
					float num2 = (_0024_0024678_00241861.z = _0024_0024677_00241860);
					Vector3 val3 = (_0024self__00241863.@base.transform.localPosition = _0024_0024678_00241861);
					goto IL_01f3;
				}
				case 3:
					_0024self__00241863.txtTalk.text = string.Empty;
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

		internal int _0024dmg_00241864;

		internal NPCCommoner _0024self__00241865;

		public _0024TD_00241858(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241864 = dmg;
			_0024self__00241865 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241864, _0024self__00241865);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00241866 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241867;

			internal int _0024dmg_00241868;

			internal NPCCommoner _0024self__00241869;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241868 = dmg;
				_0024self__00241869 = self_;
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
					_0024self__00241869.txtTalk.text = "Ow!";
					_0024self__00241869.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241869.hp -= _0024dmg_00241868;
					_0024i_00241867 = default(int);
					if (_0024self__00241869.hp < 1)
					{
						if (MenuScript.multiplayer > 0)
						{
							for (_0024i_00241867 = 0; _0024i_00241867 < _0024self__00241869.GOLD; _0024i_00241867++)
							{
								Network.Instantiate(Resources.Load("c"), _0024self__00241869.t.position, Quaternion.identity, 0);
							}
						}
						else
						{
							for (_0024i_00241867 = 0; _0024i_00241867 < _0024self__00241869.GOLD; _0024i_00241867++)
							{
								Object.Instantiate(Resources.Load("c"), _0024self__00241869.t.position, Quaternion.identity);
							}
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(((Component)_0024self__00241869).networkView.viewID);
							Network.Destroy(((Component)_0024self__00241869).networkView.viewID);
						}
					}
					else
					{
						_0024self__00241869.takingDamage = false;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241869.txtTalk.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00241870;

		internal NPCCommoner _0024self__00241871;

		public _0024TDN_00241866(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241870 = dmg;
			_0024self__00241871 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241870, _0024self__00241871);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00241872 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00241873;

			internal int _0024_0024679_00241874;

			internal Vector3 _0024_0024680_00241875;

			internal int _0024dmg_00241876;

			internal NPCCommoner _0024self__00241877;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241876 = dmg;
				_0024self__00241877 = self_;
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
					_0024n2_00241873 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241877.t.position, Quaternion.identity);
					_0024n2_00241873.SendMessage("SD", (object)_0024dmg_00241876);
					_0024self__00241877.@base.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241877.hp < 1)
					{
						goto IL_014c;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00241877.@base.animation.Stop();
					_0024self__00241877.takingDamage = false;
					int num = (_0024_0024679_00241874 = 0);
					Vector3 val = (_0024_0024680_00241875 = _0024self__00241877.@base.transform.localPosition);
					float num2 = (_0024_0024680_00241875.z = _0024_0024679_00241874);
					Vector3 val3 = (_0024self__00241877.@base.transform.localPosition = _0024_0024680_00241875);
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

		internal int _0024dmg_00241878;

		internal NPCCommoner _0024self__00241879;

		public _0024TDN2_00241872(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241878 = dmg;
			_0024self__00241879 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241878, _0024self__00241879);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Move_00241880 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241881;

			internal NPCCommoner _0024self__00241882;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241882 = self_;
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
					_0024num_00241881 = Random.Range(-1, 2);
					if (_0024num_00241881 != 0)
					{
						_0024self__00241882.speed *= (float)_0024num_00241881;
					}
					if (!(_0024self__00241882.speed <= 0f))
					{
						((Component)_0024self__00241882.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00241882.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					}
					_0024self__00241882.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00241882.canMove = false;
					_0024num_00241881 = Random.Range(-1, 2);
					if (_0024num_00241881 != 0)
					{
						_0024self__00241882.speed *= (float)_0024num_00241881;
					}
					if (!(_0024self__00241882.speed <= 0f))
					{
						((Component)_0024self__00241882.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00241882.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
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

		internal NPCCommoner _0024self__00241883;

		public _0024Move_00241880(NPCCommoner self_)
		{
			_0024self__00241883 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241883);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock_00241884 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024683_00241885;

			internal Vector3 _0024_0024684_00241886;

			internal int _0024_0024685_00241887;

			internal Vector3 _0024_0024686_00241888;

			internal int _0024_0024687_00241889;

			internal Vector3 _0024_0024688_00241890;

			internal Vector3 _0024p_00241891;

			internal NPCCommoner _0024self__00241892;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241891 = p;
				_0024self__00241892 = self_;
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
						((Component)_0024self__00241892).networkView.RPC("KnockN", (RPCMode)2, new object[1] { _0024p_00241891 });
						goto IL_01a7;
					}
					if (_0024p_00241891.x <= _0024self__00241892.t.position.x)
					{
						int num3 = (_0024_0024685_00241887 = 10);
						Vector3 val4 = (_0024_0024686_00241888 = ((Component)_0024self__00241892).rigidbody.velocity);
						float num4 = (_0024_0024686_00241888.x = _0024_0024685_00241887);
						Vector3 val6 = (((Component)_0024self__00241892).rigidbody.velocity = _0024_0024686_00241888);
					}
					else
					{
						int num5 = (_0024_0024683_00241885 = -10);
						Vector3 val7 = (_0024_0024684_00241886 = ((Component)_0024self__00241892).rigidbody.velocity);
						float num6 = (_0024_0024684_00241886.x = _0024_0024683_00241885);
						Vector3 val9 = (((Component)_0024self__00241892).rigidbody.velocity = _0024_0024684_00241886);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024687_00241889 = 0);
					Vector3 val = (_0024_0024688_00241890 = ((Component)_0024self__00241892).rigidbody.velocity);
					float num2 = (_0024_0024688_00241890.x = _0024_0024687_00241889);
					Vector3 val3 = (((Component)_0024self__00241892).rigidbody.velocity = _0024_0024688_00241890);
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

		internal Vector3 _0024p_00241893;

		internal NPCCommoner _0024self__00241894;

		public _0024Knock_00241884(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241893 = p;
			_0024self__00241894 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241893, _0024self__00241894);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00241895 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024689_00241896;

			internal Vector3 _0024_0024690_00241897;

			internal int _0024_0024691_00241898;

			internal Vector3 _0024_0024692_00241899;

			internal int _0024_0024693_00241900;

			internal Vector3 _0024_0024694_00241901;

			internal Vector3 _0024p_00241902;

			internal NPCCommoner _0024self__00241903;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241902 = p;
				_0024self__00241903 = self_;
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
					if (_0024p_00241902.x <= _0024self__00241903.t.position.x)
					{
						int num3 = (_0024_0024691_00241898 = 10);
						Vector3 val4 = (_0024_0024692_00241899 = ((Component)_0024self__00241903).rigidbody.velocity);
						float num4 = (_0024_0024692_00241899.x = _0024_0024691_00241898);
						Vector3 val6 = (((Component)_0024self__00241903).rigidbody.velocity = _0024_0024692_00241899);
					}
					else
					{
						int num5 = (_0024_0024689_00241896 = -10);
						Vector3 val7 = (_0024_0024690_00241897 = ((Component)_0024self__00241903).rigidbody.velocity);
						float num6 = (_0024_0024690_00241897.x = _0024_0024689_00241896);
						Vector3 val9 = (((Component)_0024self__00241903).rigidbody.velocity = _0024_0024690_00241897);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024693_00241900 = 0);
					Vector3 val = (_0024_0024694_00241901 = ((Component)_0024self__00241903).rigidbody.velocity);
					float num2 = (_0024_0024694_00241901.x = _0024_0024693_00241900);
					Vector3 val3 = (((Component)_0024self__00241903).rigidbody.velocity = _0024_0024694_00241901);
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

		internal Vector3 _0024p_00241904;

		internal NPCCommoner _0024self__00241905;

		public _0024KnockN_00241895(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241904 = p;
			_0024self__00241905 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241904, _0024self__00241905);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00241906 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00241907;

			internal int _0024_0024695_00241908;

			internal Vector3 _0024_0024696_00241909;

			internal int _0024_0024697_00241910;

			internal Vector3 _0024_0024698_00241911;

			internal int _0024_0024699_00241912;

			internal Vector3 _0024_0024700_00241913;

			internal int _0024_0024701_00241914;

			internal Vector3 _0024_0024702_00241915;

			internal bool _0024l_00241916;

			internal NPCCommoner _0024self__00241917;

			public _0024(bool l, NPCCommoner self_)
			{
				_0024l_00241916 = l;
				_0024self__00241917 = self_;
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
					_0024i_00241907 = default(int);
					if (_0024l_00241916)
					{
						int num = (_0024_0024695_00241908 = -10);
						Vector3 val = (_0024_0024696_00241909 = _0024self__00241917.r.velocity);
						float num2 = (_0024_0024696_00241909.x = _0024_0024695_00241908);
						Vector3 val3 = (_0024self__00241917.r.velocity = _0024_0024696_00241909);
						int num3 = (_0024_0024697_00241910 = 10);
						Vector3 val4 = (_0024_0024698_00241911 = _0024self__00241917.r.velocity);
						float num4 = (_0024_0024698_00241911.y = _0024_0024697_00241910);
						Vector3 val6 = (_0024self__00241917.r.velocity = _0024_0024698_00241911);
						result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024699_00241912 = 10);
						Vector3 val7 = (_0024_0024700_00241913 = _0024self__00241917.r.velocity);
						float num6 = (_0024_0024700_00241913.x = _0024_0024699_00241912);
						Vector3 val9 = (_0024self__00241917.r.velocity = _0024_0024700_00241913);
						int num7 = (_0024_0024701_00241914 = 10);
						Vector3 val10 = (_0024_0024702_00241915 = _0024self__00241917.r.velocity);
						float num8 = (_0024_0024702_00241915.y = _0024_0024701_00241914);
						Vector3 val12 = (_0024self__00241917.r.velocity = _0024_0024702_00241915);
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

		internal bool _0024l_00241918;

		internal NPCCommoner _0024self__00241919;

		public _0024K_00241906(bool l, NPCCommoner self_)
		{
			_0024l_00241918 = l;
			_0024self__00241919 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return (IEnumerator<WaitForEndOfFrame>)(object)new _0024(_0024l_00241918, _0024self__00241919);
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
		return new _0024Talk_00241845(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator SaySomething(int a)
	{
		return new _0024SaySomething_00241848(a, this).GetEnumerator();
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
		return new _0024Start_00241855(this).GetEnumerator();
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00241858(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00241866(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00241872(dmg, this).GetEnumerator();
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
		return new _0024Move_00241880(this).GetEnumerator();
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
		return new _0024Knock_00241884(p, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KnockN(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024KnockN_00241895(p, this).GetEnumerator();
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00241906(l, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
