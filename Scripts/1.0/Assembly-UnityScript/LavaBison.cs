using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class LavaBison : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00241997 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalDMG_00241998;

			internal GameObject _0024n3_00241999;

			internal GameObject _0024n2_00242000;

			internal int _0024_0024705_00242001;

			internal Vector3 _0024_0024706_00242002;

			internal int _0024_0024707_00242003;

			internal Vector3 _0024_0024708_00242004;

			internal int _0024dmg_00242005;

			internal LavaBison _0024self__00242006;

			public _0024(int dmg, LavaBison self_)
			{
				_0024dmg_00242005 = dmg;
				_0024self__00242006 = self_;
			}

			public override bool MoveNext()
			{
				//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0304: Unknown result type (might be due to invalid IL or missing references)
				//IL_0305: Unknown result type (might be due to invalid IL or missing references)
				//IL_0307: Unknown result type (might be due to invalid IL or missing references)
				//IL_030c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0338: Unknown result type (might be due to invalid IL or missing references)
				//IL_033d: Unknown result type (might be due to invalid IL or missing references)
				//IL_033e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0345: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00db: Expected O, but got Unknown
				//IL_00db: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e5: Expected O, but got Unknown
				//IL_01db: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fa: Expected O, but got Unknown
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0204: Expected O, but got Unknown
				//IL_024b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0250: Unknown result type (might be due to invalid IL or missing references)
				//IL_0251: Unknown result type (might be due to invalid IL or missing references)
				//IL_0252: Unknown result type (might be due to invalid IL or missing references)
				//IL_0257: Unknown result type (might be due to invalid IL or missing references)
				//IL_027b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0280: Unknown result type (might be due to invalid IL or missing references)
				//IL_0281: Unknown result type (might be due to invalid IL or missing references)
				//IL_0287: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02bb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242006.takingDamage)
					{
						if (!_0024self__00242006.isMonster)
						{
							_0024self__00242006.isMonster = true;
							((Component)_0024self__00242006).gameObject.layer = 9;
						}
						((Component)_0024self__00242006).audio.PlayOneShot(_0024self__00242006.aHit);
						_0024finalDMG_00241998 = _0024dmg_00242005 - _0024self__00242006.DEF;
						if (_0024finalDMG_00241998 < 1)
						{
							_0024finalDMG_00241998 = 1;
						}
						if (MenuScript.multiplayer > 0)
						{
							_0024n3_00241999 = (GameObject)Network.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242006.t.position, Quaternion.identity, 0);
							_0024n3_00241999.networkView.RPC("SDN", (RPCMode)2, new object[1] { _0024finalDMG_00241998 });
							((Component)_0024self__00242006).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024finalDMG_00241998 });
							((Component)_0024self__00242006).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024finalDMG_00241998 });
						}
						else
						{
							_0024self__00242006.takingDamage = true;
							if (_0024finalDMG_00241998 < 1)
							{
								_0024finalDMG_00241998 = 1;
							}
							_0024self__00242006.HP -= _0024finalDMG_00241998;
							_0024self__00242006.e.animation.Play();
							if (_0024dmg_00242005 > 0)
							{
								_0024n2_00242000 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242006.t.position, Quaternion.identity);
								_0024n2_00242000.SendMessage("SD", (object)_0024finalDMG_00241998);
							}
							if (!_0024self__00242006.r.isKinematic)
							{
								int num3 = (_0024_0024705_00242001 = 0);
								Vector3 val4 = (_0024_0024706_00242002 = ((Component)_0024self__00242006).rigidbody.velocity);
								float num4 = (_0024_0024706_00242002.x = _0024_0024705_00242001);
								Vector3 val6 = (((Component)_0024self__00242006).rigidbody.velocity = _0024_0024706_00242002);
							}
							if (_0024self__00242006.HP >= 1)
							{
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
								break;
							}
							_0024self__00242006.Die();
						}
					}
					goto IL_0348;
				case 2:
				{
					_0024self__00242006.e.animation.Stop();
					_0024self__00242006.takingDamage = false;
					int num = (_0024_0024707_00242003 = 0);
					Vector3 val = (_0024_0024708_00242004 = _0024self__00242006.e.transform.localPosition);
					float num2 = (_0024_0024708_00242004.z = _0024_0024707_00242003);
					Vector3 val3 = (_0024self__00242006.e.transform.localPosition = _0024_0024708_00242004);
					goto IL_0348;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_0348:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242007;

		internal LavaBison _0024self__00242008;

		public _0024TD_00241997(int dmg, LavaBison self_)
		{
			_0024dmg_00242007 = dmg;
			_0024self__00242008 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242007, _0024self__00242008);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242009 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242010;

			internal LavaBison _0024self__00242011;

			public _0024(LavaBison self_)
			{
				_0024self__00242011 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242011.@base.animation["i"].layer = 0;
					_0024self__00242011.@base.animation["a"].layer = 1;
					_0024self__00242011.@base.animation["r"].layer = 0;
					_0024drops_00242010 = new int[3] { 7, 19, 19 };
					_0024self__00242011.SetStats(150, 6, 2, 10, 2f, _0024drops_00242010, Random.Range(10, 25), 10);
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242011).StartCoroutine_Auto(_0024self__00242011.MoveCheck())) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(3, ((MonoBehaviour)_0024self__00242011).StartCoroutine_Auto(_0024self__00242011.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00242012;

		public _0024Start_00242009(LavaBison self_)
		{
			_0024self__00242012 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242012);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242013 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242014;

			internal Ray _0024ray2_00242015;

			internal int _0024_0024709_00242016;

			internal Vector3 _0024_0024710_00242017;

			internal LavaBison _0024self__00242018;

			public _0024(LavaBison self_)
			{
				_0024self__00242018 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_0162: Expected O, but got Unknown
				//IL_0271: Unknown result type (might be due to invalid IL or missing references)
				//IL_027b: Expected O, but got Unknown
				//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_031d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0322: Unknown result type (might be due to invalid IL or missing references)
				//IL_0323: Unknown result type (might be due to invalid IL or missing references)
				//IL_0329: Unknown result type (might be due to invalid IL or missing references)
				//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c5: Expected O, but got Unknown
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_010d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Expected O, but got Unknown
				//IL_0215: Unknown result type (might be due to invalid IL or missing references)
				//IL_0226: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024self__00242018.isMonster)
					{
						_0024ray_00242014 = new Ray(_0024self__00242018.t.position, new Vector3(1f, 0f, 0f));
						_0024ray2_00242015 = new Ray(_0024self__00242018.t.position, new Vector3(-1f, 0f, 0f));
						if (Physics.Raycast(_0024ray_00242014, ref _0024self__00242018.hit, 20f, 256))
						{
							_0024self__00242018.attacking = true;
							_0024self__00242018.@base.animation.Stop();
							_0024self__00242018.@base.animation.Play("a");
							_0024self__00242018.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00242015, ref _0024self__00242018.hit, 20f, 256))
						{
							_0024self__00242018.attacking = true;
							_0024self__00242018.@base.animation.Stop();
							_0024self__00242018.@base.animation.Play("a");
							_0024self__00242018.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
							break;
						}
					}
					goto IL_02b4;
				case 2:
					_0024self__00242018.@base.animation.Play("r");
					_0024self__00242018.atking = true;
					_0024self__00242018.spdd = 16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242018.atking = false;
					_0024self__00242018.spdd = 0f;
					_0024self__00242018.@base.animation.Play("i");
					goto IL_02b4;
				case 4:
					_0024self__00242018.@base.animation.Play("r");
					_0024self__00242018.atking = true;
					_0024self__00242018.spdd = -16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00242018.atking = false;
					_0024self__00242018.spdd = 0f;
					_0024self__00242018.@base.animation.Play("i");
					goto IL_02b4;
				case 6:
				{
					_0024self__00242018.attacking = false;
					int num = (_0024_0024709_00242016 = 0);
					Vector3 val = (_0024_0024710_00242017 = _0024self__00242018.r.velocity);
					float num2 = (_0024_0024710_00242017.x = _0024_0024709_00242016);
					Vector3 val3 = (_0024self__00242018.r.velocity = _0024_0024710_00242017);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_02b4:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00242019;

		public _0024AttackCheck_00242013(LavaBison self_)
		{
			_0024self__00242019 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242019);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242020 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal LavaBison _0024self__00242021;

			public _0024(LavaBison self_)
			{
				_0024self__00242021 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024self__00242021.isMonster)
					{
						_0024self__00242021.atking = true;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242021.atking = false;
					_0024self__00242021.spdd = 0f;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00242022;

		public _0024MoveCheck_00242020(LavaBison self_)
		{
			_0024self__00242022 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242022);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242023 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242024;

			internal Ray _0024ray2_00242025;

			internal LavaBison _0024self__00242026;

			public _0024(LavaBison self_)
			{
				_0024self__00242026 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0147: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Expected O, but got Unknown
				//IL_0263: Unknown result type (might be due to invalid IL or missing references)
				//IL_026d: Expected O, but got Unknown
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0103: Expected O, but got Unknown
				//IL_0204: Unknown result type (might be due to invalid IL or missing references)
				//IL_0215: Unknown result type (might be due to invalid IL or missing references)
				//IL_021f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024ray_00242024 = new Ray(_0024self__00242026.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00242025 = new Ray(_0024self__00242026.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00242024, ref _0024self__00242026.hit, 20f, 256))
					{
						_0024self__00242026.attacking = true;
						_0024self__00242026.@base.animation.Stop();
						_0024self__00242026.@base.animation.Play("a");
						_0024self__00242026.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242025, ref _0024self__00242026.hit, 20f, 256))
					{
						_0024self__00242026.attacking = true;
						_0024self__00242026.@base.animation.Stop();
						_0024self__00242026.@base.animation.Play("a");
						_0024self__00242026.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_02a6;
				case 2:
					_0024self__00242026.@base.animation.Play("r");
					_0024self__00242026.atking = true;
					_0024self__00242026.spdd = 16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(1, 4))) ? 1 : 0);
					break;
				case 3:
					_0024self__00242026.atking = false;
					_0024self__00242026.spdd = 0f;
					_0024self__00242026.@base.animation.Play("i");
					goto IL_02a6;
				case 4:
					_0024self__00242026.@base.animation.Play("r");
					_0024self__00242026.atking = true;
					_0024self__00242026.spdd = -16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds((float)Random.Range(1, 4))) ? 1 : 0);
					break;
				case 5:
					_0024self__00242026.atking = false;
					_0024self__00242026.spdd = 0f;
					_0024self__00242026.@base.animation.Play("i");
					goto IL_02a6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02a6:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00242027;

		public _0024ATK_00242023(LavaBison self_)
		{
			_0024self__00242027 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242027);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024T_00242028 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024711_00242029;

			internal Quaternion _0024_0024712_00242030;

			internal int _0024_0024713_00242031;

			internal Quaternion _0024_0024714_00242032;

			internal LavaBison _0024self__00242033;

			public _0024(LavaBison self_)
			{
				_0024self__00242033 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0114: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_014e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0155: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01af: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242033.turning)
					{
						_0024self__00242033.turning = true;
						if (_0024self__00242033.e.transform.rotation.y != 0f)
						{
							int num = (_0024_0024711_00242029 = 0);
							Quaternion val = (_0024_0024712_00242030 = _0024self__00242033.e.transform.rotation);
							float num2 = (_0024_0024712_00242030.y = _0024_0024711_00242029);
							Quaternion val3 = (_0024self__00242033.e.transform.rotation = _0024_0024712_00242030);
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00242033).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
							}
						}
						else
						{
							int num3 = (_0024_0024713_00242031 = 180);
							Quaternion val4 = (_0024_0024714_00242032 = _0024self__00242033.e.transform.rotation);
							float num4 = (_0024_0024714_00242032.y = _0024_0024713_00242031);
							Quaternion val6 = (_0024self__00242033.e.transform.rotation = _0024_0024714_00242032);
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00242033).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
							}
						}
						_0024self__00242033.spdd *= -1f;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_01c0;
				case 2:
					_0024self__00242033.turning = false;
					goto IL_01c0;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01c0:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00242034;

		public _0024T_00242028(LavaBison self_)
		{
			_0024self__00242034 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242034);
		}
	}

	private RaycastHit hit;

	private float spdd;

	private bool atking;

	private bool isMonster;

	private bool turning;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	public LavaBison()
	{
		mask2 = 2048;
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00241997(dmg, this).GetEnumerator();
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242009(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242013(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242020(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00242023(this).GetEnumerator();
	}

	public override IEnumerator T()
	{
		return new _0024T_00242028(this).GetEnumerator();
	}

	[RPC]
	public override void Turn(int dir)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (dir == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion val2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion val4 = (e.transform.rotation = rotation2);
		}
	}

	public override void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		((Ray)(ref r1U)).origin = ((Component)this).transform.position;
		((Ray)(ref r1U)).direction = Vector3.left;
		((Ray)(ref r2U)).origin = ((Component)this).transform.position;
		((Ray)(ref r2U)).direction = Vector3.right;
		if (atking)
		{
			float x = spdd;
			Vector3 velocity = r.velocity;
			float num = (velocity.x = x);
			Vector3 val2 = (r.velocity = velocity);
		}
		if (Physics.Raycast(r1U, 1.5f, mask2) && !turning && e.transform.rotation.y == 0f)
		{
			if (MenuScript.multiplayer > 0)
			{
				if (MenuScript.multiplayer == 1)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(T());
				}
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine_Auto(T());
			}
		}
		if (!Physics.Raycast(r2U, 1.5f, mask2) || turning || e.transform.rotation.y == 0f)
		{
			return;
		}
		if (MenuScript.multiplayer > 0)
		{
			if (MenuScript.multiplayer == 1)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(T());
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine_Auto(T());
		}
	}

	public override void Main()
	{
	}
}
