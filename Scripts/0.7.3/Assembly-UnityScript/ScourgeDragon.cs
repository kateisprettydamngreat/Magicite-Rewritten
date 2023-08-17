using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ScourgeDragon : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242041 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242042;

			internal ScourgeDragon _0024self__00242043;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242043 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242043.@base.animation["i"].layer = 0;
					_0024self__00242043.@base.animation["a1"].layer = 1;
					_0024self__00242043.@base.animation["a2"].layer = 1;
					_0024self__00242043.@base.animation["a3"].layer = 1;
					_0024self__00242043.@base.animation["a4"].layer = 1;
					_0024drops_00242042 = new int[3] { 7, 18, 0 };
					_0024self__00242043.SetStats(1000, 2, 10, 50, 0f, _0024drops_00242042, Random.Range(10, 30), 50);
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242043).StartCoroutine_Auto(_0024self__00242043.AttackCheck())) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(3, ((MonoBehaviour)_0024self__00242043).StartCoroutine_Auto(_0024self__00242043.TurnCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeDragon _0024self__00242044;

		public _0024Start_00242041(ScourgeDragon self_)
		{
			_0024self__00242044 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242044);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TurnCheck_00242045 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242046;

			internal int _0024_0024779_00242047;

			internal Quaternion _0024_0024780_00242048;

			internal int _0024_0024781_00242049;

			internal Quaternion _0024_0024782_00242050;

			internal ScourgeDragon _0024self__00242051;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242051 = self_;
			}

			public override bool MoveNext()
			{
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0145: Expected O, but got Unknown
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_012a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0085: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_008b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer <= 0)
					{
						_0024num_00242046 = Random.Range(0, 2);
						if (_0024num_00242046 == 0)
						{
							if (_0024self__00242051.e.transform.rotation.y == 0f)
							{
								int num = (_0024_0024781_00242049 = 180);
								Quaternion val = (_0024_0024782_00242050 = _0024self__00242051.e.transform.rotation);
								float num2 = (_0024_0024782_00242050.y = _0024_0024781_00242049);
								Quaternion val3 = (_0024self__00242051.e.transform.rotation = _0024_0024782_00242050);
							}
							else
							{
								int num3 = (_0024_0024779_00242047 = 0);
								Quaternion val4 = (_0024_0024780_00242048 = _0024self__00242051.e.transform.rotation);
								float num4 = (_0024_0024780_00242048.y = _0024_0024779_00242047);
								Quaternion val6 = (_0024self__00242051.e.transform.rotation = _0024_0024780_00242048);
							}
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
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

		internal ScourgeDragon _0024self__00242052;

		public _0024TurnCheck_00242045(ScourgeDragon self_)
		{
			_0024self__00242052 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242052);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242053 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242054;

			internal int _0024num_00242055;

			internal int _0024num2_00242056;

			internal ScourgeDragon _0024self__00242057;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242057 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0272: Unknown result type (might be due to invalid IL or missing references)
				//IL_027c: Expected O, but got Unknown
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Expected O, but got Unknown
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01af: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Expected O, but got Unknown
				//IL_013f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0144: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f8: Expected O, but got Unknown
				//IL_0156: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Expected O, but got Unknown
				//IL_025c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0266: Expected O, but got Unknown
				//IL_0239: Unknown result type (might be due to invalid IL or missing references)
				//IL_0243: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00242054 = default(int);
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							((Component)_0024self__00242057).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						}
						goto IL_028d;
					}
					_0024self__00242057.attacking = true;
					_0024num_00242055 = Random.Range(0, 4);
					if (_0024num_00242055 == 0)
					{
						_0024self__00242057.@base.animation.Play("a4");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (_0024num_00242055 == 1)
					{
						_0024self__00242057.@base.animation.Play("a1");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (_0024num_00242055 == 1)
					{
						_0024self__00242057.@base.animation.Play("a2");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					_0024num2_00242056 = Random.Range(0, 3);
					if (_0024num2_00242056 == 0)
					{
						_0024self__00242057.@base.animation.Play("a3");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(2f)) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(1f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024i_00242054 = 0;
					goto IL_0173;
				case 3:
					_0024i_00242054++;
					goto IL_0173;
				case 6:
					_0024self__00242057.SpawnEnemies();
					goto case 4;
				case 4:
				case 5:
				case 7:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 8:
					_0024self__00242057.attacking = false;
					goto IL_028d;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0173:
					if (_0024i_00242054 < 5)
					{
						if (_0024self__00242057.e.transform.rotation.y != 0f)
						{
							Object.Instantiate(Resources.Load("dBallR"), _0024self__00242057.headObj.transform.position, Quaternion.identity);
						}
						else
						{
							Object.Instantiate(Resources.Load("dBallL"), _0024self__00242057.headObj.transform.position, Quaternion.identity);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto case 4;
					IL_028d:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeDragon _0024self__00242058;

		public _0024AttackCheck_00242053(ScourgeDragon self_)
		{
			_0024self__00242058 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242058);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242059 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242060;

			internal int _0024dir_00242061;

			internal int _0024_0024783_00242062;

			internal Vector3 _0024_0024784_00242063;

			internal ScourgeDragon _0024self__00242064;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242064 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_010a: Expected O, but got Unknown
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_009e: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242064.attacking)
					{
						((Component)_0024self__00242064).audio.PlayOneShot(_0024self__00242064.a);
						_0024self__00242064.dir = 0;
						int num = (_0024_0024783_00242062 = 0);
						Vector3 val = (_0024_0024784_00242063 = _0024self__00242064._0024get_rigidbody_00242065().velocity);
						float num2 = (_0024_0024784_00242063.x = _0024_0024783_00242062);
						Vector3 val3 = (_0024self__00242064._0024get_rigidbody_00242066().velocity = _0024_0024784_00242063);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
						break;
					}
					goto IL_00f7;
				case 2:
					_0024num_00242060 = Random.Range(1, 2);
					_0024dir_00242061 = Random.Range(1, 3);
					_0024self__00242064.moving = false;
					_0024self__00242064.dir = _0024dir_00242061;
					goto IL_00f7;
				case 3:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00f7:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00242060)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeDragon _0024self__00242067;

		public _0024MoveCheck_00242059(ScourgeDragon self_)
		{
			_0024self__00242067 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242067);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242068 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242069;

			internal Ray _0024ray2_00242070;

			internal ScourgeDragon _0024self__00242071;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242071 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_0103: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Expected O, but got Unknown
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024ray_00242069 = new Ray(_0024self__00242071.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00242070 = new Ray(_0024self__00242071.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00242069, ref _0024self__00242071.hit, 10f, 256))
					{
						_0024self__00242071.attacking = true;
						_0024self__00242071.@base.animation.Stop();
						_0024self__00242071.@base.animation.Play("a");
						_0024self__00242071.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242070, ref _0024self__00242071.hit, 10f, 256))
					{
						_0024self__00242071.attacking = true;
						_0024self__00242071.@base.animation.Stop();
						_0024self__00242071.@base.animation.Play("a");
						_0024self__00242071.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 2;
				case 2:
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

		internal ScourgeDragon _0024self__00242072;

		public _0024ATK_00242068(ScourgeDragon self_)
		{
			_0024self__00242072 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242072);
		}
	}

	private RaycastHit hit;

	public GameObject headObj;

	public override IEnumerator Start()
	{
		return new _0024Start_00242041(this).GetEnumerator();
	}

	public override IEnumerator TurnCheck()
	{
		return new _0024TurnCheck_00242045(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242053(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242059(this).GetEnumerator();
	}

	[RPC]
	public override void SpawnEnemies()
	{
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00242068(this).GetEnumerator();
	}

	public override void Main()
	{
	}

	internal Rigidbody _0024get_rigidbody_00242065()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00242066()
	{
		return ((Component)this).rigidbody;
	}
}
