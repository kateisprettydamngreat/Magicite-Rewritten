using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ScourgeKnightScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242254 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242255;

			internal ScourgeKnightScript _0024self__00242256;

			public _0024(ScourgeKnightScript self_)
			{
				_0024self__00242256 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242256.@base.animation["i"].layer = 0;
					_0024self__00242256.@base.animation["j"].layer = 1;
					_0024self__00242256.@base.animation["j"].speed = 0.5f;
					_0024self__00242256.@base.animation["a"].layer = 1;
					_0024drops_00242255 = new int[3] { 7, 18, 0 };
					_0024self__00242256.SetStats(160, 6, 1, 3, 2f, _0024drops_00242255, Random.Range(2, 6), 3);
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242256).StartCoroutine_Auto(_0024self__00242256.Action())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeKnightScript _0024self__00242257;

		public _0024Start_00242254(ScourgeKnightScript self_)
		{
			_0024self__00242257 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242257);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Action_00242258 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242259;

			internal int _0024i_00242260;

			internal int _0024dir_00242261;

			internal int _0024_0024848_00242262;

			internal Vector3 _0024_0024849_00242263;

			internal int _0024_0024850_00242264;

			internal Vector3 _0024_0024851_00242265;

			internal ScourgeKnightScript _0024self__00242266;

			public _0024(ScourgeKnightScript self_)
			{
				_0024self__00242266 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Expected O, but got Unknown
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Expected O, but got Unknown
				//IL_023a: Unknown result type (might be due to invalid IL or missing references)
				//IL_023f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0240: Unknown result type (might be due to invalid IL or missing references)
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Unknown result type (might be due to invalid IL or missing references)
				//IL_026a: Unknown result type (might be due to invalid IL or missing references)
				//IL_026f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0270: Unknown result type (might be due to invalid IL or missing references)
				//IL_0277: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				//IL_0111: Unknown result type (might be due to invalid IL or missing references)
				//IL_0116: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fd: Expected O, but got Unknown
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Expected O, but got Unknown
				//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0324: Unknown result type (might be due to invalid IL or missing references)
				//IL_0329: Unknown result type (might be due to invalid IL or missing references)
				//IL_032a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0331: Unknown result type (might be due to invalid IL or missing references)
				//IL_033b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0345: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024num_00242259 = Random.Range(0, 3);
					if (_0024num_00242259 == 0)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00242266.@base.animation.Play("a");
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
							break;
						}
						if (Network.isServer)
						{
							((Component)_0024self__00242266).networkView.RPC("AttackN", (RPCMode)6, new object[0]);
						}
					}
					else if (_0024num_00242259 == 1)
					{
						_0024dir_00242261 = Random.Range(-2, 3);
						if (MenuScript.multiplayer > 0)
						{
							if (Network.isServer)
							{
								((Component)_0024self__00242266).networkView.RPC("JumpN", (RPCMode)6, new object[1] { _0024dir_00242261 });
							}
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
						_0024self__00242266.@base.animation.Play("j");
						int num = (_0024_0024848_00242262 = 40);
						Vector3 val = (_0024_0024849_00242263 = _0024self__00242266.r.velocity);
						float num2 = (_0024_0024849_00242263.y = _0024_0024848_00242262);
						Vector3 val3 = (_0024self__00242266.r.velocity = _0024_0024849_00242263);
						if (_0024dir_00242261 < 0)
						{
							_0024self__00242266.e.transform.rotation = Quaternion.Euler(0f, -180f, 0f);
						}
						else
						{
							_0024self__00242266.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						int num3 = (_0024_0024850_00242264 = _0024dir_00242261 * 15);
						Vector3 val4 = (_0024_0024851_00242265 = _0024self__00242266.r.velocity);
						float num4 = (_0024_0024851_00242265.x = _0024_0024850_00242264);
						Vector3 val6 = (_0024self__00242266.r.velocity = _0024_0024851_00242265);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto case 5;
				case 3:
					_0024i_00242260 = default(int);
					_0024i_00242260 = 0;
					goto IL_016f;
				case 4:
					_0024i_00242260++;
					goto IL_016f;
				case 5:
				case 6:
				case 7:
					_0024self__00242266.@base.animation.Play("i");
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_016f:
					if (_0024i_00242260 < 3)
					{
						if (_0024self__00242266.e.transform.rotation.y != 0f)
						{
							Object.Instantiate(Resources.Load("ballR"), _0024self__00242266.t.position, Quaternion.identity);
						}
						else
						{
							Object.Instantiate(Resources.Load("ballL"), _0024self__00242266.t.position, Quaternion.identity);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.1f)) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					}
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeKnightScript _0024self__00242267;

		public _0024Action_00242258(ScourgeKnightScript self_)
		{
			_0024self__00242267 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242267);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackN_00242268 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242269;

			internal ScourgeKnightScript _0024self__00242270;

			public _0024(ScourgeKnightScript self_)
			{
				_0024self__00242270 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_004b: Expected O, but got Unknown
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Expected O, but got Unknown
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242270.@base.animation.Play("a");
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer == 1)
					{
						_0024i_00242269 = default(int);
						_0024i_00242269 = 0;
						goto IL_010c;
					}
					goto IL_0118;
				case 3:
					_0024i_00242269++;
					goto IL_010c;
				case 4:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0118:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
					IL_010c:
					if (_0024i_00242269 < 3)
					{
						if (_0024self__00242270.e.transform.rotation.y != 0f)
						{
							Network.Instantiate(Resources.Load("ballR"), _0024self__00242270.t.position, Quaternion.identity, 0);
						}
						else
						{
							Network.Instantiate(Resources.Load("ballL"), _0024self__00242270.t.position, Quaternion.identity, 0);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_0118;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeKnightScript _0024self__00242271;

		public _0024AttackN_00242268(ScourgeKnightScript self_)
		{
			_0024self__00242271 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242271);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024JumpN_00242272 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024852_00242273;

			internal Vector3 _0024_0024853_00242274;

			internal int _0024_0024854_00242275;

			internal Vector3 _0024_0024855_00242276;

			internal int _0024dir_00242277;

			internal ScourgeKnightScript _0024self__00242278;

			public _0024(int dir, ScourgeKnightScript self_)
			{
				_0024dir_00242277 = dir;
				_0024self__00242278 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0103: Unknown result type (might be due to invalid IL or missing references)
				//IL_0104: Unknown result type (might be due to invalid IL or missing references)
				//IL_0106: Unknown result type (might be due to invalid IL or missing references)
				//IL_010b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Unknown result type (might be due to invalid IL or missing references)
				//IL_0137: Unknown result type (might be due to invalid IL or missing references)
				//IL_0138: Unknown result type (might be due to invalid IL or missing references)
				//IL_013f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0146: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					_0024self__00242278.@base.animation.Play("j");
					int num = (_0024_0024852_00242273 = 40);
					Vector3 val = (_0024_0024853_00242274 = _0024self__00242278.r.velocity);
					float num2 = (_0024_0024853_00242274.y = _0024_0024852_00242273);
					Vector3 val3 = (_0024self__00242278.r.velocity = _0024_0024853_00242274);
					if (_0024dir_00242277 < 0)
					{
						_0024self__00242278.e.transform.rotation = Quaternion.Euler(0f, -180f, 0f);
					}
					else
					{
						_0024self__00242278.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					int num3 = (_0024_0024854_00242275 = _0024dir_00242277 * 15);
					Vector3 val4 = (_0024_0024855_00242276 = _0024self__00242278.r.velocity);
					float num4 = (_0024_0024855_00242276.x = _0024_0024854_00242275);
					Vector3 val6 = (_0024self__00242278.r.velocity = _0024_0024855_00242276);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				}
				case 2:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dir_00242279;

		internal ScourgeKnightScript _0024self__00242280;

		public _0024JumpN_00242272(int dir, ScourgeKnightScript self_)
		{
			_0024dir_00242279 = dir;
			_0024self__00242280 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dir_00242279, _0024self__00242280);
		}
	}

	private RaycastHit hit;

	public override IEnumerator Start()
	{
		return new _0024Start_00242254(this).GetEnumerator();
	}

	public override IEnumerator Action()
	{
		return new _0024Action_00242258(this).GetEnumerator();
	}

	public override void OnDestroy()
	{
		GameScript.bossDefeated = true;
	}

	[RPC]
	public override IEnumerator AttackN()
	{
		return new _0024AttackN_00242268(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator JumpN(int dir)
	{
		return new _0024JumpN_00242272(dir, this).GetEnumerator();
	}
}
