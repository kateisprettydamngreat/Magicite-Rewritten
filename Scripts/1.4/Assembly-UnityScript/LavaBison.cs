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
	internal sealed class _0024TD_00242046 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalDMG_00242047;

			internal GameObject _0024n3_00242048;

			internal GameObject _0024n2_00242049;

			internal int _0024_0024710_00242050;

			internal Vector3 _0024_0024711_00242051;

			internal int _0024_0024712_00242052;

			internal Vector3 _0024_0024713_00242053;

			internal int _0024dmg_00242054;

			internal LavaBison _0024self__00242055;

			public _0024(int dmg, LavaBison self_)
			{
				_0024dmg_00242054 = dmg;
				_0024self__00242055 = self_;
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
					if (!_0024self__00242055.takingDamage)
					{
						if (!_0024self__00242055.isMonster)
						{
							_0024self__00242055.isMonster = true;
							((Component)_0024self__00242055).gameObject.layer = 9;
						}
						((Component)_0024self__00242055).audio.PlayOneShot(_0024self__00242055.aHit);
						_0024finalDMG_00242047 = _0024dmg_00242054 - _0024self__00242055.DEF;
						if (_0024finalDMG_00242047 < 1)
						{
							_0024finalDMG_00242047 = 1;
						}
						if (MenuScript.multiplayer > 0)
						{
							_0024n3_00242048 = (GameObject)Network.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242055.t.position, Quaternion.identity, 0);
							_0024n3_00242048.networkView.RPC("SDN", (RPCMode)2, new object[1] { _0024finalDMG_00242047 });
							((Component)_0024self__00242055).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024finalDMG_00242047 });
							((Component)_0024self__00242055).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024finalDMG_00242047 });
						}
						else
						{
							_0024self__00242055.takingDamage = true;
							if (_0024finalDMG_00242047 < 1)
							{
								_0024finalDMG_00242047 = 1;
							}
							_0024self__00242055.HP -= _0024finalDMG_00242047;
							_0024self__00242055.e.animation.Play();
							if (_0024dmg_00242054 > 0)
							{
								_0024n2_00242049 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242055.t.position, Quaternion.identity);
								_0024n2_00242049.SendMessage("SD", (object)_0024finalDMG_00242047);
							}
							if (!_0024self__00242055.r.isKinematic)
							{
								int num3 = (_0024_0024710_00242050 = 0);
								Vector3 val4 = (_0024_0024711_00242051 = ((Component)_0024self__00242055).rigidbody.velocity);
								float num4 = (_0024_0024711_00242051.x = _0024_0024710_00242050);
								Vector3 val6 = (((Component)_0024self__00242055).rigidbody.velocity = _0024_0024711_00242051);
							}
							if (_0024self__00242055.HP >= 1)
							{
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
								break;
							}
							_0024self__00242055.Die();
						}
					}
					goto IL_0348;
				case 2:
				{
					_0024self__00242055.e.animation.Stop();
					_0024self__00242055.takingDamage = false;
					int num = (_0024_0024712_00242052 = 0);
					Vector3 val = (_0024_0024713_00242053 = _0024self__00242055.e.transform.localPosition);
					float num2 = (_0024_0024713_00242053.z = _0024_0024712_00242052);
					Vector3 val3 = (_0024self__00242055.e.transform.localPosition = _0024_0024713_00242053);
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

		internal int _0024dmg_00242056;

		internal LavaBison _0024self__00242057;

		public _0024TD_00242046(int dmg, LavaBison self_)
		{
			_0024dmg_00242056 = dmg;
			_0024self__00242057 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242056, _0024self__00242057);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242058 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242059;

			internal LavaBison _0024self__00242060;

			public _0024(LavaBison self_)
			{
				_0024self__00242060 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242060.@base.animation["i"].layer = 0;
					_0024self__00242060.@base.animation["a"].layer = 1;
					_0024self__00242060.@base.animation["r"].layer = 0;
					_0024drops_00242059 = new int[3] { 7, 19, 19 };
					_0024self__00242060.SetStats(150, 6, 2, 10, 2f, _0024drops_00242059, Random.Range(10, 25), 10);
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242060).StartCoroutine_Auto(_0024self__00242060.MoveCheck())) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(3, ((MonoBehaviour)_0024self__00242060).StartCoroutine_Auto(_0024self__00242060.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00242061;

		public _0024Start_00242058(LavaBison self_)
		{
			_0024self__00242061 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242061);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242062 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242063;

			internal Ray _0024ray2_00242064;

			internal int _0024_0024714_00242065;

			internal Vector3 _0024_0024715_00242066;

			internal LavaBison _0024self__00242067;

			public _0024(LavaBison self_)
			{
				_0024self__00242067 = self_;
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
					if (_0024self__00242067.isMonster)
					{
						_0024ray_00242063 = new Ray(_0024self__00242067.t.position, new Vector3(1f, 0f, 0f));
						_0024ray2_00242064 = new Ray(_0024self__00242067.t.position, new Vector3(-1f, 0f, 0f));
						if (Physics.Raycast(_0024ray_00242063, ref _0024self__00242067.hit, 20f, 256))
						{
							_0024self__00242067.attacking = true;
							_0024self__00242067.@base.animation.Stop();
							_0024self__00242067.@base.animation.Play("a");
							_0024self__00242067.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00242064, ref _0024self__00242067.hit, 20f, 256))
						{
							_0024self__00242067.attacking = true;
							_0024self__00242067.@base.animation.Stop();
							_0024self__00242067.@base.animation.Play("a");
							_0024self__00242067.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
							break;
						}
					}
					goto IL_02b4;
				case 2:
					_0024self__00242067.@base.animation.Play("r");
					_0024self__00242067.atking = true;
					_0024self__00242067.spdd = 16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242067.atking = false;
					_0024self__00242067.spdd = 0f;
					_0024self__00242067.@base.animation.Play("i");
					goto IL_02b4;
				case 4:
					_0024self__00242067.@base.animation.Play("r");
					_0024self__00242067.atking = true;
					_0024self__00242067.spdd = -16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00242067.atking = false;
					_0024self__00242067.spdd = 0f;
					_0024self__00242067.@base.animation.Play("i");
					goto IL_02b4;
				case 6:
				{
					_0024self__00242067.attacking = false;
					int num = (_0024_0024714_00242065 = 0);
					Vector3 val = (_0024_0024715_00242066 = _0024self__00242067.r.velocity);
					float num2 = (_0024_0024715_00242066.x = _0024_0024714_00242065);
					Vector3 val3 = (_0024self__00242067.r.velocity = _0024_0024715_00242066);
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

		internal LavaBison _0024self__00242068;

		public _0024AttackCheck_00242062(LavaBison self_)
		{
			_0024self__00242068 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242068);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242069 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal LavaBison _0024self__00242070;

			public _0024(LavaBison self_)
			{
				_0024self__00242070 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024self__00242070.isMonster)
					{
						_0024self__00242070.atking = true;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242070.atking = false;
					_0024self__00242070.spdd = 0f;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal LavaBison _0024self__00242071;

		public _0024MoveCheck_00242069(LavaBison self_)
		{
			_0024self__00242071 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242071);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242072 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242073;

			internal Ray _0024ray2_00242074;

			internal LavaBison _0024self__00242075;

			public _0024(LavaBison self_)
			{
				_0024self__00242075 = self_;
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
					_0024ray_00242073 = new Ray(_0024self__00242075.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00242074 = new Ray(_0024self__00242075.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00242073, ref _0024self__00242075.hit, 20f, 256))
					{
						_0024self__00242075.attacking = true;
						_0024self__00242075.@base.animation.Stop();
						_0024self__00242075.@base.animation.Play("a");
						_0024self__00242075.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242074, ref _0024self__00242075.hit, 20f, 256))
					{
						_0024self__00242075.attacking = true;
						_0024self__00242075.@base.animation.Stop();
						_0024self__00242075.@base.animation.Play("a");
						_0024self__00242075.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_02a6;
				case 2:
					_0024self__00242075.@base.animation.Play("r");
					_0024self__00242075.atking = true;
					_0024self__00242075.spdd = 16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(1, 4))) ? 1 : 0);
					break;
				case 3:
					_0024self__00242075.atking = false;
					_0024self__00242075.spdd = 0f;
					_0024self__00242075.@base.animation.Play("i");
					goto IL_02a6;
				case 4:
					_0024self__00242075.@base.animation.Play("r");
					_0024self__00242075.atking = true;
					_0024self__00242075.spdd = -16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds((float)Random.Range(1, 4))) ? 1 : 0);
					break;
				case 5:
					_0024self__00242075.atking = false;
					_0024self__00242075.spdd = 0f;
					_0024self__00242075.@base.animation.Play("i");
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

		internal LavaBison _0024self__00242076;

		public _0024ATK_00242072(LavaBison self_)
		{
			_0024self__00242076 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242076);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024T_00242077 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024716_00242078;

			internal Quaternion _0024_0024717_00242079;

			internal int _0024_0024718_00242080;

			internal Quaternion _0024_0024719_00242081;

			internal LavaBison _0024self__00242082;

			public _0024(LavaBison self_)
			{
				_0024self__00242082 = self_;
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
					if (!_0024self__00242082.turning)
					{
						_0024self__00242082.turning = true;
						if (_0024self__00242082.e.transform.rotation.y != 0f)
						{
							int num = (_0024_0024716_00242078 = 0);
							Quaternion val = (_0024_0024717_00242079 = _0024self__00242082.e.transform.rotation);
							float num2 = (_0024_0024717_00242079.y = _0024_0024716_00242078);
							Quaternion val3 = (_0024self__00242082.e.transform.rotation = _0024_0024717_00242079);
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00242082).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
							}
						}
						else
						{
							int num3 = (_0024_0024718_00242080 = 180);
							Quaternion val4 = (_0024_0024719_00242081 = _0024self__00242082.e.transform.rotation);
							float num4 = (_0024_0024719_00242081.y = _0024_0024718_00242080);
							Quaternion val6 = (_0024self__00242082.e.transform.rotation = _0024_0024719_00242081);
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00242082).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
							}
						}
						_0024self__00242082.spdd *= -1f;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_01c0;
				case 2:
					_0024self__00242082.turning = false;
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

		internal LavaBison _0024self__00242083;

		public _0024T_00242077(LavaBison self_)
		{
			_0024self__00242083 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242083);
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
		return new _0024TD_00242046(dmg, this).GetEnumerator();
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242058(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242062(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242069(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00242072(this).GetEnumerator();
	}

	public override IEnumerator T()
	{
		return new _0024T_00242077(this).GetEnumerator();
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
