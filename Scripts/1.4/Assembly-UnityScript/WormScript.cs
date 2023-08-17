using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class WormScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242966 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242967;

			internal WormScript _0024self__00242968;

			public _0024(WormScript self_)
			{
				_0024self__00242968 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ff: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242968.HP = _0024self__00242968.maxHP;
					_0024self__00242968.drops = new int[3] { 7, 18, 0 };
					_0024self__00242968.t = ((Component)_0024self__00242968).transform;
					((MonoBehaviour)_0024self__00242968).StartCoroutine_Auto(_0024self__00242968.Initialize());
					if (_0024self__00242968.isHead)
					{
						_0024i_00242967 = default(int);
						_0024self__00242968.mainHead.animation.Play();
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
				case 2:
					_0024i_00242967 = 0;
					goto IL_0112;
				case 3:
					_0024i_00242967++;
					goto IL_0112;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0112:
					if (_0024i_00242967 < 7)
					{
						_0024self__00242968.parts[_0024i_00242967].animation.Play("wBody");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
					IL_011e:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal WormScript _0024self__00242969;

		public _0024Start_00242966(WormScript self_)
		{
			_0024self__00242969 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242969);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Initialize_00242970 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WormScript _0024self__00242971;

			public _0024(WormScript self_)
			{
				_0024self__00242971 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d1: Expected O, but got Unknown
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024self__00242971.isHead)
					{
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242971).networkView.RPC("SetHead", (RPCMode)2, new object[0]);
							_0024self__00242971.speed = 10f;
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242971.mainHead.renderer.material = _0024self__00242971.leadHead;
							_0024self__00242971.speed = 10f;
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
						}
						break;
					}
					goto IL_0108;
				case 2:
					((MonoBehaviour)_0024self__00242971).StartCoroutine_Auto(_0024self__00242971.Attack());
					goto IL_0108;
				case 3:
					_0024self__00242971.mainHead.animation.Play("wHead");
					((MonoBehaviour)_0024self__00242971).StartCoroutine_Auto(_0024self__00242971.Attack());
					goto IL_0108;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0108:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal WormScript _0024self__00242972;

		public _0024Initialize_00242970(WormScript self_)
		{
			_0024self__00242972 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242972);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242973 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WormScript _0024self__00242974;

			public _0024(WormScript self_)
			{
				_0024self__00242974 = self_;
			}

			public override bool MoveNext()
			{
				//IL_017a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0184: Expected O, but got Unknown
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0135: Unknown result type (might be due to invalid IL or missing references)
				//IL_013a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_0162: Expected O, but got Unknown
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Expected O, but got Unknown
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bf: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (Object.op_Implicit((Object)(object)_0024self__00242974.player))
					{
						if (MenuScript.multiplayer > 0)
						{
							if (MenuScript.multiplayer == 1)
							{
								_0024self__00242974.time = Random.Range(8, 11);
								_0024self__00242974.curVector = _0024self__00242974.player.transform.position - _0024self__00242974.t.position;
								_0024self__00242974.attacking = true;
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00242974.time)) ? 1 : 0);
							}
							else
							{
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(_0024self__00242974.time)) ? 1 : 0);
							}
						}
						else
						{
							_0024self__00242974.time = Random.Range(8, 11);
							_0024self__00242974.curVector = _0024self__00242974.player.transform.position - _0024self__00242974.t.position;
							_0024self__00242974.attacking = true;
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(_0024self__00242974.time)) ? 1 : 0);
						}
						break;
					}
					goto case 3;
				case 2:
					_0024self__00242974.attacking = false;
					goto case 3;
				case 4:
					_0024self__00242974.attacking = false;
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal WormScript _0024self__00242975;

		public _0024Attack_00242973(WormScript self_)
		{
			_0024self__00242975 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242975);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00242976 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242977;

			internal int _0024dmg_00242978;

			internal WormScript _0024self__00242979;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242978 = dmg;
				_0024self__00242979 = self_;
			}

			public override bool MoveNext()
			{
				//IL_014f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Expected O, but got Unknown
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Expected O, but got Unknown
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Expected O, but got Unknown
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_0122: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242979.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00242979.takingDamage = true;
							_0024self__00242979.HP -= _0024dmg_00242978;
							_0024n2_00242977 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242979.t.position, Quaternion.identity);
							_0024n2_00242977.SendMessage("SD", (object)_0024dmg_00242978);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00242979).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00242978 });
						((Component)_0024self__00242979).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00242978 });
					}
					goto IL_016a;
				case 2:
					if (_0024self__00242979.HP < 1)
					{
						_0024self__00242979.Die();
						goto IL_016a;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242979.takingDamage = false;
					goto IL_016a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_016a:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242980;

		internal WormScript _0024self__00242981;

		public _0024TD_00242976(int dmg, WormScript self_)
		{
			_0024dmg_00242980 = dmg;
			_0024self__00242981 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242980, _0024self__00242981);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242982 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024dmg_00242983;

			internal WormScript _0024self__00242984;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242983 = dmg;
				_0024self__00242984 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242984.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242984.HP -= _0024dmg_00242983;
					if (_0024self__00242984.HP < 1)
					{
						_0024self__00242984.Die();
					}
					else
					{
						_0024self__00242984.takingDamage = false;
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

		internal int _0024dmg_00242985;

		internal WormScript _0024self__00242986;

		public _0024TDN_00242982(int dmg, WormScript self_)
		{
			_0024dmg_00242985 = dmg;
			_0024self__00242986 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242985, _0024self__00242986);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242987 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242988;

			internal int _0024dmg_00242989;

			internal WormScript _0024self__00242990;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242989 = dmg;
				_0024self__00242990 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Expected O, but got Unknown
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Expected O, but got Unknown
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Expected O, but got Unknown
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Expected O, but got Unknown
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024n2_00242988 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242990.t.position, Quaternion.identity);
					_0024n2_00242988.SendMessage("SD", (object)_0024dmg_00242989);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					if (_0024self__00242990.HP < 1)
					{
						goto IL_00dc;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242990.takingDamage = false;
					goto IL_00dc;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00dc:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242991;

		internal WormScript _0024self__00242992;

		public _0024TDN2_00242987(int dmg, WormScript self_)
		{
			_0024dmg_00242991 = dmg;
			_0024self__00242992 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242991, _0024self__00242992);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242993 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00242994;

			internal int _0024_00241102_00242995;

			internal Vector3 _0024_00241103_00242996;

			internal int _0024_00241104_00242997;

			internal Vector3 _0024_00241105_00242998;

			internal int _0024_00241106_00242999;

			internal Vector3 _0024_00241107_00243000;

			internal int _0024_00241108_00243001;

			internal Vector3 _0024_00241109_00243002;

			internal bool _0024l_00243003;

			internal WormScript _0024self__00243004;

			public _0024(bool l, WormScript self_)
			{
				_0024l_00243003 = l;
				_0024self__00243004 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_0251: Expected O, but got Unknown
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_0195: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_021f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0224: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Expected O, but got Unknown
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00243004).networkView.RPC("KN", (RPCMode)2, new object[1] { _0024l_00243003 });
						goto IL_027e;
					}
					_0024self__00243004.knocking = true;
					_0024wasK_00242994 = default(bool);
					if (((Component)_0024self__00243004).rigidbody.isKinematic)
					{
						_0024wasK_00242994 = true;
						((Component)_0024self__00243004).rigidbody.isKinematic = false;
					}
					if (_0024l_00243003)
					{
						int num = (_0024_00241102_00242995 = -15);
						Vector3 val = (_0024_00241103_00242996 = ((Component)_0024self__00243004).rigidbody.velocity);
						float num2 = (_0024_00241103_00242996.x = _0024_00241102_00242995);
						Vector3 val3 = (((Component)_0024self__00243004).rigidbody.velocity = _0024_00241103_00242996);
						int num3 = (_0024_00241104_00242997 = 10);
						Vector3 val4 = (_0024_00241105_00242998 = ((Component)_0024self__00243004).rigidbody.velocity);
						float num4 = (_0024_00241105_00242998.y = _0024_00241104_00242997);
						Vector3 val6 = (((Component)_0024self__00243004).rigidbody.velocity = _0024_00241105_00242998);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_00241106_00242999 = 15);
						Vector3 val7 = (_0024_00241107_00243000 = ((Component)_0024self__00243004).rigidbody.velocity);
						float num6 = (_0024_00241107_00243000.x = _0024_00241106_00242999);
						Vector3 val9 = (((Component)_0024self__00243004).rigidbody.velocity = _0024_00241107_00243000);
						int num7 = (_0024_00241108_00243001 = 10);
						Vector3 val10 = (_0024_00241109_00243002 = ((Component)_0024self__00243004).rigidbody.velocity);
						float num8 = (_0024_00241109_00243002.y = _0024_00241108_00243001);
						Vector3 val12 = (((Component)_0024self__00243004).rigidbody.velocity = _0024_00241109_00243002);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00243004.knocking = false;
					if (_0024wasK_00242994)
					{
						((Component)_0024self__00243004).rigidbody.isKinematic = true;
					}
					goto IL_027e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_027e:
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00243005;

		internal WormScript _0024self__00243006;

		public _0024K_00242993(bool l, WormScript self_)
		{
			_0024l_00243005 = l;
			_0024self__00243006 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00243005, _0024self__00243006);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KN_00243007 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00243008;

			internal int _0024_00241110_00243009;

			internal Vector3 _0024_00241111_00243010;

			internal int _0024_00241112_00243011;

			internal Vector3 _0024_00241113_00243012;

			internal int _0024_00241114_00243013;

			internal Vector3 _0024_00241115_00243014;

			internal int _0024_00241116_00243015;

			internal Vector3 _0024_00241117_00243016;

			internal bool _0024l_00243017;

			internal WormScript _0024self__00243018;

			public _0024(bool l, WormScript self_)
			{
				_0024l_00243017 = l;
				_0024self__00243018 = self_;
			}

			public override bool MoveNext()
			{
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0217: Expected O, but got Unknown
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0194: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0201: Expected O, but got Unknown
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_012f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00243018.knocking = true;
					_0024wasK_00243008 = default(bool);
					if (((Component)_0024self__00243018).rigidbody.isKinematic)
					{
						_0024wasK_00243008 = true;
						((Component)_0024self__00243018).rigidbody.isKinematic = false;
					}
					if (_0024l_00243017)
					{
						int num = (_0024_00241110_00243009 = -15);
						Vector3 val = (_0024_00241111_00243010 = ((Component)_0024self__00243018).rigidbody.velocity);
						float num2 = (_0024_00241111_00243010.x = _0024_00241110_00243009);
						Vector3 val3 = (((Component)_0024self__00243018).rigidbody.velocity = _0024_00241111_00243010);
						int num3 = (_0024_00241112_00243011 = 10);
						Vector3 val4 = (_0024_00241113_00243012 = ((Component)_0024self__00243018).rigidbody.velocity);
						float num4 = (_0024_00241113_00243012.y = _0024_00241112_00243011);
						Vector3 val6 = (((Component)_0024self__00243018).rigidbody.velocity = _0024_00241113_00243012);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_00241114_00243013 = 15);
						Vector3 val7 = (_0024_00241115_00243014 = ((Component)_0024self__00243018).rigidbody.velocity);
						float num6 = (_0024_00241115_00243014.x = _0024_00241114_00243013);
						Vector3 val9 = (((Component)_0024self__00243018).rigidbody.velocity = _0024_00241115_00243014);
						int num7 = (_0024_00241116_00243015 = 10);
						Vector3 val10 = (_0024_00241117_00243016 = ((Component)_0024self__00243018).rigidbody.velocity);
						float num8 = (_0024_00241117_00243016.y = _0024_00241116_00243015);
						Vector3 val12 = (((Component)_0024self__00243018).rigidbody.velocity = _0024_00241117_00243016);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00243018.knocking = false;
					if (_0024wasK_00243008)
					{
						((Component)_0024self__00243018).rigidbody.isKinematic = true;
					}
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00243019;

		internal WormScript _0024self__00243020;

		public _0024KN_00243007(bool l, WormScript self_)
		{
			_0024l_00243019 = l;
			_0024self__00243020 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00243019, _0024self__00243020);
		}
	}

	public bool isBase;

	public bool isHead;

	public GameObject head;

	public float speed;

	public float space;

	public float time;

	public GameObject mainHead;

	public Material leadHead;

	public GameObject[] parts;

	public GameObject[] parts2;

	private bool knocking;

	private Transform t;

	private bool moving;

	private GameObject player;

	private Vector3 curVector;

	private bool attacking;

	private Vector3 a;

	private Vector3 b;

	private int HP;

	private int maxHP;

	private int GOLD;

	public int[] drops;

	private bool takingDamage;

	public WormScript()
	{
		parts = (GameObject[])(object)new GameObject[5];
		parts2 = (GameObject[])(object)new GameObject[7];
		maxHP = 1;
		GOLD = 20;
		drops = new int[3];
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242966(this).GetEnumerator();
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
		int num = default(int);
		if (!isBase)
		{
			return;
		}
		for (num = 0; num < parts2.Length; num++)
		{
			if (Object.op_Implicit((Object)(object)parts2[num]))
			{
				parts2[num].SendMessage("SetPlayer", (object)g);
			}
		}
		((MonoBehaviour)this).StartCoroutine_Auto(Attack());
	}

	[RPC]
	public override void SetHead()
	{
		mainHead.renderer.material = leadHead;
		mainHead.animation.Play("wHead");
	}

	public override IEnumerator Initialize()
	{
		return new _0024Initialize_00242970(this).GetEnumerator();
	}

	public override IEnumerator Attack()
	{
		return new _0024Attack_00242973(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)head))
		{
			if (MenuScript.multiplayer > 0)
			{
				head = ((Component)this).gameObject;
				isHead = true;
				((MonoBehaviour)this).StartCoroutine_Auto(Initialize());
			}
			else
			{
				head = ((Component)this).gameObject;
				isHead = true;
				((MonoBehaviour)this).StartCoroutine_Auto(Initialize());
			}
		}
		if (isHead)
		{
			if (!Object.op_Implicit((Object)(object)player) || !attacking)
			{
				return;
			}
			if (MenuScript.multiplayer > 0)
			{
				if (MenuScript.multiplayer == 1)
				{
					t.Translate(((Vector3)(ref curVector)).normalized * speed * Time.deltaTime);
				}
			}
			else
			{
				t.Translate(((Vector3)(ref curVector)).normalized * speed * Time.deltaTime);
			}
		}
		else if (MenuScript.multiplayer > 0)
		{
			if (MenuScript.multiplayer == 1)
			{
				if (!(Mathf.Abs(head.transform.position.x - t.position.x) <= space))
				{
					t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
				}
				if (!(Mathf.Abs(head.transform.position.y - t.position.y) <= space))
				{
					t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
				}
			}
		}
		else
		{
			if (!(Mathf.Abs(head.transform.position.x - t.position.x) <= space))
			{
				t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
			}
			if (!(Mathf.Abs(head.transform.position.y - t.position.y) <= space))
			{
				t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
			}
		}
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00242976(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242982(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242987(dmg, this).GetEnumerator();
	}

	public override void Die()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		GameObject val = null;
		int num = default(int);
		Item item = null;
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
		if (drops[0] > 0 && Random.Range(0, 2) == 0)
		{
			int num2 = Random.Range(1, 3);
			item = new Item(drops[0], 1, new int[6], 0f, null);
			for (num = 0; num < num2; num++)
			{
				if (MenuScript.multiplayer > 0)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
					val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
					val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
					val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
				}
				else
				{
					val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
					val.SendMessage("Set", (object)item);
				}
			}
		}
		if (drops[1] > 0 && Random.Range(0, 4) == 0)
		{
			int num3 = Random.Range(1, 3);
			item = new Item(drops[1], 1, new int[6], 0f, null);
			for (num = 0; num < num3; num++)
			{
				if (MenuScript.multiplayer > 0)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
					val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
					val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
					val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
				}
				else
				{
					val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
					val.SendMessage("Set", (object)item);
				}
			}
		}
		if (MenuScript.multiplayer == 0)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (Network.isServer)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
			Network.Destroy(((Component)this).networkView.viewID);
		}
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			((Component)c).SendMessage("TD", (object)18);
		}
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00242993(l, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KN(bool l)
	{
		return new _0024KN_00243007(l, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
