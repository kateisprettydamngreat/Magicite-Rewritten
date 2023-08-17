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
	internal sealed class _0024Start_00242447 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242448;

			internal WormScript _0024self__00242449;

			public _0024(WormScript self_)
			{
				_0024self__00242449 = self_;
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
					_0024self__00242449.HP = _0024self__00242449.maxHP;
					_0024self__00242449.drops = new int[3] { 7, 18, 0 };
					_0024self__00242449.t = ((Component)_0024self__00242449).transform;
					((MonoBehaviour)_0024self__00242449).StartCoroutine_Auto(_0024self__00242449.Initialize());
					if (_0024self__00242449.isHead)
					{
						_0024i_00242448 = default(int);
						_0024self__00242449.mainHead.animation.Play();
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
				case 2:
					_0024i_00242448 = 0;
					goto IL_0112;
				case 3:
					_0024i_00242448++;
					goto IL_0112;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0112:
					if (_0024i_00242448 < 7)
					{
						_0024self__00242449.parts[_0024i_00242448].animation.Play("wBody");
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

		internal WormScript _0024self__00242450;

		public _0024Start_00242447(WormScript self_)
		{
			_0024self__00242450 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242450);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Initialize_00242451 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WormScript _0024self__00242452;

			public _0024(WormScript self_)
			{
				_0024self__00242452 = self_;
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
					if (_0024self__00242452.isHead)
					{
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242452).networkView.RPC("SetHead", (RPCMode)2, new object[0]);
							_0024self__00242452.speed = 10f;
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242452.mainHead.renderer.material = _0024self__00242452.leadHead;
							_0024self__00242452.speed = 10f;
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
						}
						break;
					}
					goto IL_0108;
				case 2:
					((MonoBehaviour)_0024self__00242452).StartCoroutine_Auto(_0024self__00242452.Attack());
					goto IL_0108;
				case 3:
					_0024self__00242452.mainHead.animation.Play("wHead");
					((MonoBehaviour)_0024self__00242452).StartCoroutine_Auto(_0024self__00242452.Attack());
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

		internal WormScript _0024self__00242453;

		public _0024Initialize_00242451(WormScript self_)
		{
			_0024self__00242453 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242453);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242454 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WormScript _0024self__00242455;

			public _0024(WormScript self_)
			{
				_0024self__00242455 = self_;
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
					if (Object.op_Implicit((Object)(object)_0024self__00242455.player))
					{
						if (MenuScript.multiplayer > 0)
						{
							if (MenuScript.multiplayer == 1)
							{
								_0024self__00242455.time = Random.Range(8, 11);
								_0024self__00242455.curVector = _0024self__00242455.player.transform.position - _0024self__00242455.t.position;
								_0024self__00242455.attacking = true;
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00242455.time)) ? 1 : 0);
							}
							else
							{
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(_0024self__00242455.time)) ? 1 : 0);
							}
						}
						else
						{
							_0024self__00242455.time = Random.Range(8, 11);
							_0024self__00242455.curVector = _0024self__00242455.player.transform.position - _0024self__00242455.t.position;
							_0024self__00242455.attacking = true;
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(_0024self__00242455.time)) ? 1 : 0);
						}
						break;
					}
					goto case 3;
				case 2:
					_0024self__00242455.attacking = false;
					goto case 3;
				case 4:
					_0024self__00242455.attacking = false;
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

		internal WormScript _0024self__00242456;

		public _0024Attack_00242454(WormScript self_)
		{
			_0024self__00242456 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242456);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00242457 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242458;

			internal int _0024dmg_00242459;

			internal WormScript _0024self__00242460;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242459 = dmg;
				_0024self__00242460 = self_;
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
					if (!_0024self__00242460.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00242460.takingDamage = true;
							_0024self__00242460.HP -= _0024dmg_00242459;
							_0024n2_00242458 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242460.t.position, Quaternion.identity);
							_0024n2_00242458.SendMessage("SD", (object)_0024dmg_00242459);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00242460).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00242459 });
						((Component)_0024self__00242460).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00242459 });
					}
					goto IL_016a;
				case 2:
					if (_0024self__00242460.HP < 1)
					{
						_0024self__00242460.Die();
						goto IL_016a;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242460.takingDamage = false;
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

		internal int _0024dmg_00242461;

		internal WormScript _0024self__00242462;

		public _0024TD_00242457(int dmg, WormScript self_)
		{
			_0024dmg_00242461 = dmg;
			_0024self__00242462 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242461, _0024self__00242462);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242463 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024dmg_00242464;

			internal WormScript _0024self__00242465;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242464 = dmg;
				_0024self__00242465 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242465.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242465.HP -= _0024dmg_00242464;
					if (_0024self__00242465.HP < 1)
					{
						_0024self__00242465.Die();
					}
					else
					{
						_0024self__00242465.takingDamage = false;
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

		internal int _0024dmg_00242466;

		internal WormScript _0024self__00242467;

		public _0024TDN_00242463(int dmg, WormScript self_)
		{
			_0024dmg_00242466 = dmg;
			_0024self__00242467 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242466, _0024self__00242467);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242468 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242469;

			internal int _0024dmg_00242470;

			internal WormScript _0024self__00242471;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242470 = dmg;
				_0024self__00242471 = self_;
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
					_0024n2_00242469 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242471.t.position, Quaternion.identity);
					_0024n2_00242469.SendMessage("SD", (object)_0024dmg_00242470);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					if (_0024self__00242471.HP < 1)
					{
						goto IL_00dc;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242471.takingDamage = false;
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

		internal int _0024dmg_00242472;

		internal WormScript _0024self__00242473;

		public _0024TDN2_00242468(int dmg, WormScript self_)
		{
			_0024dmg_00242472 = dmg;
			_0024self__00242473 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242472, _0024self__00242473);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242474 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00242475;

			internal int _0024_0024941_00242476;

			internal Vector3 _0024_0024942_00242477;

			internal int _0024_0024943_00242478;

			internal Vector3 _0024_0024944_00242479;

			internal int _0024_0024945_00242480;

			internal Vector3 _0024_0024946_00242481;

			internal int _0024_0024947_00242482;

			internal Vector3 _0024_0024948_00242483;

			internal bool _0024l_00242484;

			internal WormScript _0024self__00242485;

			public _0024(bool l, WormScript self_)
			{
				_0024l_00242484 = l;
				_0024self__00242485 = self_;
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
						((Component)_0024self__00242485).networkView.RPC("KN", (RPCMode)2, new object[1] { _0024l_00242484 });
						goto IL_027e;
					}
					_0024self__00242485.knocking = true;
					_0024wasK_00242475 = default(bool);
					if (((Component)_0024self__00242485).rigidbody.isKinematic)
					{
						_0024wasK_00242475 = true;
						((Component)_0024self__00242485).rigidbody.isKinematic = false;
					}
					if (_0024l_00242484)
					{
						int num = (_0024_0024941_00242476 = -15);
						Vector3 val = (_0024_0024942_00242477 = ((Component)_0024self__00242485).rigidbody.velocity);
						float num2 = (_0024_0024942_00242477.x = _0024_0024941_00242476);
						Vector3 val3 = (((Component)_0024self__00242485).rigidbody.velocity = _0024_0024942_00242477);
						int num3 = (_0024_0024943_00242478 = 10);
						Vector3 val4 = (_0024_0024944_00242479 = ((Component)_0024self__00242485).rigidbody.velocity);
						float num4 = (_0024_0024944_00242479.y = _0024_0024943_00242478);
						Vector3 val6 = (((Component)_0024self__00242485).rigidbody.velocity = _0024_0024944_00242479);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024945_00242480 = 15);
						Vector3 val7 = (_0024_0024946_00242481 = ((Component)_0024self__00242485).rigidbody.velocity);
						float num6 = (_0024_0024946_00242481.x = _0024_0024945_00242480);
						Vector3 val9 = (((Component)_0024self__00242485).rigidbody.velocity = _0024_0024946_00242481);
						int num7 = (_0024_0024947_00242482 = 10);
						Vector3 val10 = (_0024_0024948_00242483 = ((Component)_0024self__00242485).rigidbody.velocity);
						float num8 = (_0024_0024948_00242483.y = _0024_0024947_00242482);
						Vector3 val12 = (((Component)_0024self__00242485).rigidbody.velocity = _0024_0024948_00242483);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242485.knocking = false;
					if (_0024wasK_00242475)
					{
						((Component)_0024self__00242485).rigidbody.isKinematic = true;
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

		internal bool _0024l_00242486;

		internal WormScript _0024self__00242487;

		public _0024K_00242474(bool l, WormScript self_)
		{
			_0024l_00242486 = l;
			_0024self__00242487 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00242486, _0024self__00242487);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KN_00242488 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00242489;

			internal int _0024_0024949_00242490;

			internal Vector3 _0024_0024950_00242491;

			internal int _0024_0024951_00242492;

			internal Vector3 _0024_0024952_00242493;

			internal int _0024_0024953_00242494;

			internal Vector3 _0024_0024954_00242495;

			internal int _0024_0024955_00242496;

			internal Vector3 _0024_0024956_00242497;

			internal bool _0024l_00242498;

			internal WormScript _0024self__00242499;

			public _0024(bool l, WormScript self_)
			{
				_0024l_00242498 = l;
				_0024self__00242499 = self_;
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
					_0024self__00242499.knocking = true;
					_0024wasK_00242489 = default(bool);
					if (((Component)_0024self__00242499).rigidbody.isKinematic)
					{
						_0024wasK_00242489 = true;
						((Component)_0024self__00242499).rigidbody.isKinematic = false;
					}
					if (_0024l_00242498)
					{
						int num = (_0024_0024949_00242490 = -15);
						Vector3 val = (_0024_0024950_00242491 = ((Component)_0024self__00242499).rigidbody.velocity);
						float num2 = (_0024_0024950_00242491.x = _0024_0024949_00242490);
						Vector3 val3 = (((Component)_0024self__00242499).rigidbody.velocity = _0024_0024950_00242491);
						int num3 = (_0024_0024951_00242492 = 10);
						Vector3 val4 = (_0024_0024952_00242493 = ((Component)_0024self__00242499).rigidbody.velocity);
						float num4 = (_0024_0024952_00242493.y = _0024_0024951_00242492);
						Vector3 val6 = (((Component)_0024self__00242499).rigidbody.velocity = _0024_0024952_00242493);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024953_00242494 = 15);
						Vector3 val7 = (_0024_0024954_00242495 = ((Component)_0024self__00242499).rigidbody.velocity);
						float num6 = (_0024_0024954_00242495.x = _0024_0024953_00242494);
						Vector3 val9 = (((Component)_0024self__00242499).rigidbody.velocity = _0024_0024954_00242495);
						int num7 = (_0024_0024955_00242496 = 10);
						Vector3 val10 = (_0024_0024956_00242497 = ((Component)_0024self__00242499).rigidbody.velocity);
						float num8 = (_0024_0024956_00242497.y = _0024_0024955_00242496);
						Vector3 val12 = (((Component)_0024self__00242499).rigidbody.velocity = _0024_0024956_00242497);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242499.knocking = false;
					if (_0024wasK_00242489)
					{
						((Component)_0024self__00242499).rigidbody.isKinematic = true;
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

		internal bool _0024l_00242500;

		internal WormScript _0024self__00242501;

		public _0024KN_00242488(bool l, WormScript self_)
		{
			_0024l_00242500 = l;
			_0024self__00242501 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00242500, _0024self__00242501);
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
		return new _0024Start_00242447(this).GetEnumerator();
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
		return new _0024Initialize_00242451(this).GetEnumerator();
	}

	public override IEnumerator Attack()
	{
		return new _0024Attack_00242454(this).GetEnumerator();
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
		return new _0024TD_00242457(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242463(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242468(dmg, this).GetEnumerator();
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
		return new _0024K_00242474(l, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KN(bool l)
	{
		return new _0024KN_00242488(l, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
