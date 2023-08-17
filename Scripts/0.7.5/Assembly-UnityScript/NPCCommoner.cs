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
	internal sealed class _0024Talk_00241904 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCCommoner _0024self__00241905;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241905 = self_;
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
							((Component)_0024self__00241905).networkView.RPC("SaySomething", (RPCMode)2, new object[1] { Random.Range(0, 10) });
						}
					}
					else
					{
						((MonoBehaviour)_0024self__00241905).StartCoroutine_Auto(_0024self__00241905.SaySomething(Random.Range(0, 10)));
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

		internal NPCCommoner _0024self__00241906;

		public _0024Talk_00241904(NPCCommoner self_)
		{
			_0024self__00241906 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241906);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SaySomething_00241907 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00241908;

			internal int _0024_0024switch_0024359_00241909;

			internal int _0024a_00241910;

			internal NPCCommoner _0024self__00241911;

			public _0024(int a, NPCCommoner self_)
			{
				_0024a_00241910 = a;
				_0024self__00241911 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024s_00241908 = null;
					_0024_0024switch_0024359_00241909 = _0024a_00241910;
					if (_0024_0024switch_0024359_00241909 == 0)
					{
						_0024s_00241908 = "Life is great.";
					}
					else if (_0024_0024switch_0024359_00241909 == 1)
					{
						_0024s_00241908 = "Deephaven is scary.";
					}
					else if (_0024_0024switch_0024359_00241909 == 2)
					{
						_0024s_00241908 = "I'm hungry";
					}
					else if (_0024_0024switch_0024359_00241909 == 3)
					{
						_0024s_00241908 = "I hate chicken.";
					}
					else if (_0024_0024switch_0024359_00241909 == 4)
					{
						_0024s_00241908 = "The Scourge suck!";
					}
					else if (_0024_0024switch_0024359_00241909 == 5)
					{
						_0024s_00241908 = "I miss the sun...";
					}
					else if (_0024_0024switch_0024359_00241909 == 6)
					{
						_0024s_00241908 = "*Cough*";
					}
					else if (_0024_0024switch_0024359_00241909 == 7)
					{
						_0024s_00241908 = "Someone smells funny.";
					}
					else if (_0024_0024switch_0024359_00241909 == 8)
					{
						_0024s_00241908 = "Idk what I want.";
					}
					else if (_0024_0024switch_0024359_00241909 == 9)
					{
						_0024s_00241908 = "I need to poop!";
					}
					_0024self__00241911.txtTalk.text = string.Empty + _0024s_00241908;
					_0024self__00241911.txtTalk2.text = string.Empty + _0024s_00241908;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241911.txtTalk.text = string.Empty;
					_0024self__00241911.txtTalk2.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241912;

		internal NPCCommoner _0024self__00241913;

		public _0024SaySomething_00241907(int a, NPCCommoner self_)
		{
			_0024a_00241912 = a;
			_0024self__00241913 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241912, _0024self__00241913);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241914 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal NPCCommoner _0024self__00241915;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241915 = self_;
			}

			public override bool MoveNext()
			{
				return base._state switch
				{
					1 => false, 
					_ => ((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00241915).StartCoroutine_Auto(_0024self__00241915.Move())), 
				};
			}
		}

		internal NPCCommoner _0024self__00241916;

		public _0024Start_00241914(NPCCommoner self_)
		{
			_0024self__00241916 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00241916);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00241917 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00241918;

			internal int _0024_0024700_00241919;

			internal Vector3 _0024_0024701_00241920;

			internal int _0024dmg_00241921;

			internal NPCCommoner _0024self__00241922;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241921 = dmg;
				_0024self__00241922 = self_;
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
					if (!_0024self__00241922.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00241922.txtTalk.text = "Ow!";
							_0024self__00241922.takingDamage = true;
							_0024self__00241922.hp -= _0024dmg_00241921;
							_0024n2_00241918 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241922.t.position, Quaternion.identity);
							_0024n2_00241918.SendMessage("SD", (object)_0024dmg_00241921);
							_0024self__00241922.@base.animation.Play();
							if (_0024self__00241922.hp < 1)
							{
								_0024self__00241922.Die();
								goto IL_01f3;
							}
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00241922).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00241921 });
						((Component)_0024self__00241922).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00241921 });
					}
					goto IL_021e;
				case 2:
				{
					_0024self__00241922.@base.animation.Stop();
					_0024self__00241922.takingDamage = false;
					int num = (_0024_0024700_00241919 = 0);
					Vector3 val = (_0024_0024701_00241920 = _0024self__00241922.@base.transform.localPosition);
					float num2 = (_0024_0024701_00241920.z = _0024_0024700_00241919);
					Vector3 val3 = (_0024self__00241922.@base.transform.localPosition = _0024_0024701_00241920);
					goto IL_01f3;
				}
				case 3:
					_0024self__00241922.txtTalk.text = string.Empty;
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

		internal int _0024dmg_00241923;

		internal NPCCommoner _0024self__00241924;

		public _0024TD_00241917(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241923 = dmg;
			_0024self__00241924 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241923, _0024self__00241924);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00241925 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241926;

			internal int _0024dmg_00241927;

			internal NPCCommoner _0024self__00241928;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241927 = dmg;
				_0024self__00241928 = self_;
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
					_0024self__00241928.txtTalk.text = "Ow!";
					_0024self__00241928.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241928.hp -= _0024dmg_00241927;
					_0024i_00241926 = default(int);
					if (_0024self__00241928.hp < 1)
					{
						if (MenuScript.multiplayer > 0)
						{
							for (_0024i_00241926 = 0; _0024i_00241926 < _0024self__00241928.GOLD; _0024i_00241926++)
							{
								Network.Instantiate(Resources.Load("c"), _0024self__00241928.t.position, Quaternion.identity, 0);
							}
						}
						else
						{
							for (_0024i_00241926 = 0; _0024i_00241926 < _0024self__00241928.GOLD; _0024i_00241926++)
							{
								Object.Instantiate(Resources.Load("c"), _0024self__00241928.t.position, Quaternion.identity);
							}
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(((Component)_0024self__00241928).networkView.viewID);
							Network.Destroy(((Component)_0024self__00241928).networkView.viewID);
						}
					}
					else
					{
						_0024self__00241928.takingDamage = false;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241928.txtTalk.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00241929;

		internal NPCCommoner _0024self__00241930;

		public _0024TDN_00241925(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241929 = dmg;
			_0024self__00241930 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241929, _0024self__00241930);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00241931 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00241932;

			internal int _0024_0024702_00241933;

			internal Vector3 _0024_0024703_00241934;

			internal int _0024dmg_00241935;

			internal NPCCommoner _0024self__00241936;

			public _0024(int dmg, NPCCommoner self_)
			{
				_0024dmg_00241935 = dmg;
				_0024self__00241936 = self_;
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
					_0024n2_00241932 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241936.t.position, Quaternion.identity);
					_0024n2_00241932.SendMessage("SD", (object)_0024dmg_00241935);
					_0024self__00241936.@base.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241936.hp < 1)
					{
						goto IL_014c;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00241936.@base.animation.Stop();
					_0024self__00241936.takingDamage = false;
					int num = (_0024_0024702_00241933 = 0);
					Vector3 val = (_0024_0024703_00241934 = _0024self__00241936.@base.transform.localPosition);
					float num2 = (_0024_0024703_00241934.z = _0024_0024702_00241933);
					Vector3 val3 = (_0024self__00241936.@base.transform.localPosition = _0024_0024703_00241934);
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

		internal int _0024dmg_00241937;

		internal NPCCommoner _0024self__00241938;

		public _0024TDN2_00241931(int dmg, NPCCommoner self_)
		{
			_0024dmg_00241937 = dmg;
			_0024self__00241938 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241937, _0024self__00241938);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Move_00241939 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241940;

			internal NPCCommoner _0024self__00241941;

			public _0024(NPCCommoner self_)
			{
				_0024self__00241941 = self_;
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
					_0024num_00241940 = Random.Range(-1, 2);
					if (_0024num_00241940 != 0)
					{
						_0024self__00241941.speed *= (float)_0024num_00241940;
					}
					if (!(_0024self__00241941.speed <= 0f))
					{
						((Component)_0024self__00241941.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00241941.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					}
					_0024self__00241941.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00241941.canMove = false;
					_0024num_00241940 = Random.Range(-1, 2);
					if (_0024num_00241940 != 0)
					{
						_0024self__00241941.speed *= (float)_0024num_00241940;
					}
					if (!(_0024self__00241941.speed <= 0f))
					{
						((Component)_0024self__00241941.npc).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					else
					{
						((Component)_0024self__00241941.npc).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
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

		internal NPCCommoner _0024self__00241942;

		public _0024Move_00241939(NPCCommoner self_)
		{
			_0024self__00241942 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241942);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Knock_00241943 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024706_00241944;

			internal Vector3 _0024_0024707_00241945;

			internal int _0024_0024708_00241946;

			internal Vector3 _0024_0024709_00241947;

			internal int _0024_0024710_00241948;

			internal Vector3 _0024_0024711_00241949;

			internal Vector3 _0024p_00241950;

			internal NPCCommoner _0024self__00241951;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241950 = p;
				_0024self__00241951 = self_;
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
						((Component)_0024self__00241951).networkView.RPC("KnockN", (RPCMode)2, new object[1] { _0024p_00241950 });
						goto IL_01a7;
					}
					if (_0024p_00241950.x <= _0024self__00241951.t.position.x)
					{
						int num3 = (_0024_0024708_00241946 = 10);
						Vector3 val4 = (_0024_0024709_00241947 = ((Component)_0024self__00241951).rigidbody.velocity);
						float num4 = (_0024_0024709_00241947.x = _0024_0024708_00241946);
						Vector3 val6 = (((Component)_0024self__00241951).rigidbody.velocity = _0024_0024709_00241947);
					}
					else
					{
						int num5 = (_0024_0024706_00241944 = -10);
						Vector3 val7 = (_0024_0024707_00241945 = ((Component)_0024self__00241951).rigidbody.velocity);
						float num6 = (_0024_0024707_00241945.x = _0024_0024706_00241944);
						Vector3 val9 = (((Component)_0024self__00241951).rigidbody.velocity = _0024_0024707_00241945);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024710_00241948 = 0);
					Vector3 val = (_0024_0024711_00241949 = ((Component)_0024self__00241951).rigidbody.velocity);
					float num2 = (_0024_0024711_00241949.x = _0024_0024710_00241948);
					Vector3 val3 = (((Component)_0024self__00241951).rigidbody.velocity = _0024_0024711_00241949);
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

		internal Vector3 _0024p_00241952;

		internal NPCCommoner _0024self__00241953;

		public _0024Knock_00241943(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241952 = p;
			_0024self__00241953 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241952, _0024self__00241953);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KnockN_00241954 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024712_00241955;

			internal Vector3 _0024_0024713_00241956;

			internal int _0024_0024714_00241957;

			internal Vector3 _0024_0024715_00241958;

			internal int _0024_0024716_00241959;

			internal Vector3 _0024_0024717_00241960;

			internal Vector3 _0024p_00241961;

			internal NPCCommoner _0024self__00241962;

			public _0024(Vector3 p, NPCCommoner self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024p_00241961 = p;
				_0024self__00241962 = self_;
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
					if (_0024p_00241961.x <= _0024self__00241962.t.position.x)
					{
						int num3 = (_0024_0024714_00241957 = 10);
						Vector3 val4 = (_0024_0024715_00241958 = ((Component)_0024self__00241962).rigidbody.velocity);
						float num4 = (_0024_0024715_00241958.x = _0024_0024714_00241957);
						Vector3 val6 = (((Component)_0024self__00241962).rigidbody.velocity = _0024_0024715_00241958);
					}
					else
					{
						int num5 = (_0024_0024712_00241955 = -10);
						Vector3 val7 = (_0024_0024713_00241956 = ((Component)_0024self__00241962).rigidbody.velocity);
						float num6 = (_0024_0024713_00241956.x = _0024_0024712_00241955);
						Vector3 val9 = (((Component)_0024self__00241962).rigidbody.velocity = _0024_0024713_00241956);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_0024716_00241959 = 0);
					Vector3 val = (_0024_0024717_00241960 = ((Component)_0024self__00241962).rigidbody.velocity);
					float num2 = (_0024_0024717_00241960.x = _0024_0024716_00241959);
					Vector3 val3 = (((Component)_0024self__00241962).rigidbody.velocity = _0024_0024717_00241960);
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

		internal Vector3 _0024p_00241963;

		internal NPCCommoner _0024self__00241964;

		public _0024KnockN_00241954(Vector3 p, NPCCommoner self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024p_00241963 = p;
			_0024self__00241964 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024p_00241963, _0024self__00241964);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00241965 : GenericGenerator<WaitForEndOfFrame>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			internal int _0024i_00241966;

			internal int _0024_0024718_00241967;

			internal Vector3 _0024_0024719_00241968;

			internal int _0024_0024720_00241969;

			internal Vector3 _0024_0024721_00241970;

			internal int _0024_0024722_00241971;

			internal Vector3 _0024_0024723_00241972;

			internal int _0024_0024724_00241973;

			internal Vector3 _0024_0024725_00241974;

			internal bool _0024l_00241975;

			internal NPCCommoner _0024self__00241976;

			public _0024(bool l, NPCCommoner self_)
			{
				_0024l_00241975 = l;
				_0024self__00241976 = self_;
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
					_0024i_00241966 = default(int);
					if (_0024l_00241975)
					{
						int num = (_0024_0024718_00241967 = -10);
						Vector3 val = (_0024_0024719_00241968 = _0024self__00241976.r.velocity);
						float num2 = (_0024_0024719_00241968.x = _0024_0024718_00241967);
						Vector3 val3 = (_0024self__00241976.r.velocity = _0024_0024719_00241968);
						int num3 = (_0024_0024720_00241969 = 10);
						Vector3 val4 = (_0024_0024721_00241970 = _0024self__00241976.r.velocity);
						float num4 = (_0024_0024721_00241970.y = _0024_0024720_00241969);
						Vector3 val6 = (_0024self__00241976.r.velocity = _0024_0024721_00241970);
						result = (((GenericGeneratorEnumerator<WaitForEndOfFrame>)this).Yield(2, new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024722_00241971 = 10);
						Vector3 val7 = (_0024_0024723_00241972 = _0024self__00241976.r.velocity);
						float num6 = (_0024_0024723_00241972.x = _0024_0024722_00241971);
						Vector3 val9 = (_0024self__00241976.r.velocity = _0024_0024723_00241972);
						int num7 = (_0024_0024724_00241973 = 10);
						Vector3 val10 = (_0024_0024725_00241974 = _0024self__00241976.r.velocity);
						float num8 = (_0024_0024725_00241974.y = _0024_0024724_00241973);
						Vector3 val12 = (_0024self__00241976.r.velocity = _0024_0024725_00241974);
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

		internal bool _0024l_00241977;

		internal NPCCommoner _0024self__00241978;

		public _0024K_00241965(bool l, NPCCommoner self_)
		{
			_0024l_00241977 = l;
			_0024self__00241978 = self_;
		}

		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return (IEnumerator<WaitForEndOfFrame>)(object)new _0024(_0024l_00241977, _0024self__00241978);
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
		return new _0024Talk_00241904(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator SaySomething(int a)
	{
		return new _0024SaySomething_00241907(a, this).GetEnumerator();
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
		return new _0024Start_00241914(this).GetEnumerator();
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00241917(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00241925(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00241931(dmg, this).GetEnumerator();
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
		return new _0024Move_00241939(this).GetEnumerator();
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
		return new _0024Knock_00241943(p, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KnockN(Vector3 p)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024KnockN_00241954(p, this).GetEnumerator();
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00241965(l, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
