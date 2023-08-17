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
	internal sealed class _0024MoveUp_00242528 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024posY_00242529;

			internal float _0024_0024918_00242530;

			internal Vector3 _0024_0024919_00242531;

			internal ScourgeDragon _0024self__00242532;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242532 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024posY_00242529 = ((Component)_0024self__00242532).transform.position.y + 35f;
					goto case 2;
				case 2:
					if (_0024self__00242532.t.position.y < _0024posY_00242529)
					{
						float num = (_0024_0024918_00242530 = _0024self__00242532.t.position.y + 0.2f);
						Vector3 val = (_0024_0024919_00242531 = _0024self__00242532.t.position);
						float num2 = (_0024_0024919_00242531.y = _0024_0024918_00242530);
						Vector3 val3 = (_0024self__00242532.t.position = _0024_0024919_00242531);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.03f)) ? 1 : 0);
						break;
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

		internal ScourgeDragon _0024self__00242533;

		public _0024MoveUp_00242528(ScourgeDragon self_)
		{
			_0024self__00242533 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242533);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242534 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242535;

			internal ScourgeDragon _0024self__00242536;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242536 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					((MonoBehaviour)_0024self__00242536).StartCoroutine_Auto(_0024self__00242536.MoveUp());
					_0024self__00242536.@base.animation["i"].layer = 0;
					_0024self__00242536.@base.animation["a1"].layer = 1;
					_0024self__00242536.@base.animation["a2"].layer = 1;
					_0024self__00242536.@base.animation["a3"].layer = 1;
					_0024self__00242536.@base.animation["a4"].layer = 1;
					_0024drops_00242535 = new int[3] { 7, 18, 0 };
					_0024self__00242536.SetStats(1000, 2, 10, 50, 0f, _0024drops_00242535, Random.Range(10, 30), 50);
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242536).StartCoroutine_Auto(_0024self__00242536.AttackCheck())) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(3, ((MonoBehaviour)_0024self__00242536).StartCoroutine_Auto(_0024self__00242536.TurnCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeDragon _0024self__00242537;

		public _0024Start_00242534(ScourgeDragon self_)
		{
			_0024self__00242537 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242537);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TurnCheck_00242538 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242539;

			internal int _0024_0024920_00242540;

			internal Quaternion _0024_0024921_00242541;

			internal int _0024_0024922_00242542;

			internal Quaternion _0024_0024923_00242543;

			internal ScourgeDragon _0024self__00242544;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242544 = self_;
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
						_0024num_00242539 = Random.Range(0, 2);
						if (_0024num_00242539 == 0)
						{
							if (_0024self__00242544.e.transform.rotation.y == 0f)
							{
								int num = (_0024_0024922_00242542 = 180);
								Quaternion val = (_0024_0024923_00242543 = _0024self__00242544.e.transform.rotation);
								float num2 = (_0024_0024923_00242543.y = _0024_0024922_00242542);
								Quaternion val3 = (_0024self__00242544.e.transform.rotation = _0024_0024923_00242543);
							}
							else
							{
								int num3 = (_0024_0024920_00242540 = 0);
								Quaternion val4 = (_0024_0024921_00242541 = _0024self__00242544.e.transform.rotation);
								float num4 = (_0024_0024921_00242541.y = _0024_0024920_00242540);
								Quaternion val6 = (_0024self__00242544.e.transform.rotation = _0024_0024921_00242541);
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

		internal ScourgeDragon _0024self__00242545;

		public _0024TurnCheck_00242538(ScourgeDragon self_)
		{
			_0024self__00242545 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242545);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242546 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242547;

			internal int _0024num_00242548;

			internal int _0024num2_00242549;

			internal ScourgeDragon _0024self__00242550;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242550 = self_;
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
					_0024i_00242547 = default(int);
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							((Component)_0024self__00242550).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						}
						goto IL_028d;
					}
					_0024self__00242550.attacking = true;
					_0024num_00242548 = Random.Range(0, 4);
					if (_0024num_00242548 == 0)
					{
						_0024self__00242550.@base.animation.Play("a4");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (_0024num_00242548 == 1)
					{
						_0024self__00242550.@base.animation.Play("a1");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (_0024num_00242548 == 1)
					{
						_0024self__00242550.@base.animation.Play("a2");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					_0024num2_00242549 = Random.Range(0, 3);
					if (_0024num2_00242549 == 0)
					{
						_0024self__00242550.@base.animation.Play("a3");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(2f)) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(1f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024i_00242547 = 0;
					goto IL_0173;
				case 3:
					_0024i_00242547++;
					goto IL_0173;
				case 6:
					_0024self__00242550.SpawnEnemies();
					goto case 4;
				case 4:
				case 5:
				case 7:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 8:
					_0024self__00242550.attacking = false;
					goto IL_028d;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0173:
					if (_0024i_00242547 < 5)
					{
						if (_0024self__00242550.e.transform.rotation.y != 0f)
						{
							Object.Instantiate(Resources.Load("dBallR"), _0024self__00242550.headObj.transform.position, Quaternion.identity);
						}
						else
						{
							Object.Instantiate(Resources.Load("dBallL"), _0024self__00242550.headObj.transform.position, Quaternion.identity);
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

		internal ScourgeDragon _0024self__00242551;

		public _0024AttackCheck_00242546(ScourgeDragon self_)
		{
			_0024self__00242551 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242551);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242552 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242553;

			internal int _0024dir_00242554;

			internal int _0024_0024924_00242555;

			internal Vector3 _0024_0024925_00242556;

			internal ScourgeDragon _0024self__00242557;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242557 = self_;
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
					if (!_0024self__00242557.attacking)
					{
						((Component)_0024self__00242557).audio.PlayOneShot(_0024self__00242557.a);
						_0024self__00242557.dir = 0;
						int num = (_0024_0024924_00242555 = 0);
						Vector3 val = (_0024_0024925_00242556 = _0024self__00242557._0024get_rigidbody_00242558().velocity);
						float num2 = (_0024_0024925_00242556.x = _0024_0024924_00242555);
						Vector3 val3 = (_0024self__00242557._0024get_rigidbody_00242559().velocity = _0024_0024925_00242556);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
						break;
					}
					goto IL_00f7;
				case 2:
					_0024num_00242553 = Random.Range(1, 2);
					_0024dir_00242554 = Random.Range(1, 3);
					_0024self__00242557.moving = false;
					_0024self__00242557.dir = _0024dir_00242554;
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
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00242553)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeDragon _0024self__00242560;

		public _0024MoveCheck_00242552(ScourgeDragon self_)
		{
			_0024self__00242560 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242560);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242561 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242562;

			internal Ray _0024ray2_00242563;

			internal ScourgeDragon _0024self__00242564;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242564 = self_;
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
					_0024ray_00242562 = new Ray(_0024self__00242564.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00242563 = new Ray(_0024self__00242564.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00242562, ref _0024self__00242564.hit, 10f, 256))
					{
						_0024self__00242564.attacking = true;
						_0024self__00242564.@base.animation.Stop();
						_0024self__00242564.@base.animation.Play("a1");
						_0024self__00242564.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242563, ref _0024self__00242564.hit, 10f, 256))
					{
						_0024self__00242564.attacking = true;
						_0024self__00242564.@base.animation.Stop();
						_0024self__00242564.@base.animation.Play("a1");
						_0024self__00242564.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
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

		internal ScourgeDragon _0024self__00242565;

		public _0024ATK_00242561(ScourgeDragon self_)
		{
			_0024self__00242565 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242565);
		}
	}

	private RaycastHit hit;

	public GameObject headObj;

	private bool initialized;

	public override IEnumerator MoveUp()
	{
		return new _0024MoveUp_00242528(this).GetEnumerator();
	}

	public override void Set()
	{
		MonoBehaviour.print((object)"SETTT");
		if (!initialized)
		{
			initialized = true;
			@base.SetActive(true);
			@base.animation.Play("i");
			if (MenuScript.multiplayer > 0 && Network.isServer)
			{
				((Component)this).networkView.RPC("I", (RPCMode)2, new object[0]);
			}
			((MonoBehaviour)this).StartCoroutine_Auto(AttackCheck());
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242534(this).GetEnumerator();
	}

	public override IEnumerator TurnCheck()
	{
		return new _0024TurnCheck_00242538(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242546(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242552(this).GetEnumerator();
	}

	[RPC]
	public override void SpawnEnemies()
	{
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00242561(this).GetEnumerator();
	}

	public override void Main()
	{
	}

	internal Rigidbody _0024get_rigidbody_00242558()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00242559()
	{
		return ((Component)this).rigidbody;
	}
}
