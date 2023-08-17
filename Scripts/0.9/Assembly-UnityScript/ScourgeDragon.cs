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
	internal sealed class _0024MoveUp_00242476 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024posY_00242477;

			internal float _0024_0024909_00242478;

			internal Vector3 _0024_0024910_00242479;

			internal ScourgeDragon _0024self__00242480;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242480 = self_;
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
					_0024posY_00242477 = ((Component)_0024self__00242480).transform.position.y + 35f;
					goto case 2;
				case 2:
					if (_0024self__00242480.t.position.y < _0024posY_00242477)
					{
						float num = (_0024_0024909_00242478 = _0024self__00242480.t.position.y + 0.2f);
						Vector3 val = (_0024_0024910_00242479 = _0024self__00242480.t.position);
						float num2 = (_0024_0024910_00242479.y = _0024_0024909_00242478);
						Vector3 val3 = (_0024self__00242480.t.position = _0024_0024910_00242479);
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

		internal ScourgeDragon _0024self__00242481;

		public _0024MoveUp_00242476(ScourgeDragon self_)
		{
			_0024self__00242481 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242481);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242482 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242483;

			internal ScourgeDragon _0024self__00242484;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242484 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					((MonoBehaviour)_0024self__00242484).StartCoroutine_Auto(_0024self__00242484.MoveUp());
					_0024self__00242484.@base.animation["i"].layer = 0;
					_0024self__00242484.@base.animation["a1"].layer = 1;
					_0024self__00242484.@base.animation["a2"].layer = 1;
					_0024self__00242484.@base.animation["a3"].layer = 1;
					_0024self__00242484.@base.animation["a4"].layer = 1;
					_0024drops_00242483 = new int[3] { 7, 18, 0 };
					_0024self__00242484.SetStats(1000, 2, 10, 50, 0f, _0024drops_00242483, Random.Range(10, 30), 50);
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242484).StartCoroutine_Auto(_0024self__00242484.AttackCheck())) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(3, ((MonoBehaviour)_0024self__00242484).StartCoroutine_Auto(_0024self__00242484.TurnCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeDragon _0024self__00242485;

		public _0024Start_00242482(ScourgeDragon self_)
		{
			_0024self__00242485 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242485);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TurnCheck_00242486 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242487;

			internal int _0024_0024911_00242488;

			internal Quaternion _0024_0024912_00242489;

			internal int _0024_0024913_00242490;

			internal Quaternion _0024_0024914_00242491;

			internal ScourgeDragon _0024self__00242492;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242492 = self_;
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
						_0024num_00242487 = Random.Range(0, 2);
						if (_0024num_00242487 == 0)
						{
							if (_0024self__00242492.e.transform.rotation.y == 0f)
							{
								int num = (_0024_0024913_00242490 = 180);
								Quaternion val = (_0024_0024914_00242491 = _0024self__00242492.e.transform.rotation);
								float num2 = (_0024_0024914_00242491.y = _0024_0024913_00242490);
								Quaternion val3 = (_0024self__00242492.e.transform.rotation = _0024_0024914_00242491);
							}
							else
							{
								int num3 = (_0024_0024911_00242488 = 0);
								Quaternion val4 = (_0024_0024912_00242489 = _0024self__00242492.e.transform.rotation);
								float num4 = (_0024_0024912_00242489.y = _0024_0024911_00242488);
								Quaternion val6 = (_0024self__00242492.e.transform.rotation = _0024_0024912_00242489);
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

		internal ScourgeDragon _0024self__00242493;

		public _0024TurnCheck_00242486(ScourgeDragon self_)
		{
			_0024self__00242493 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242493);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242494 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242495;

			internal int _0024num_00242496;

			internal int _0024num2_00242497;

			internal ScourgeDragon _0024self__00242498;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242498 = self_;
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
					_0024i_00242495 = default(int);
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							((Component)_0024self__00242498).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						}
						goto IL_028d;
					}
					_0024self__00242498.attacking = true;
					_0024num_00242496 = Random.Range(0, 4);
					if (_0024num_00242496 == 0)
					{
						_0024self__00242498.@base.animation.Play("a4");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (_0024num_00242496 == 1)
					{
						_0024self__00242498.@base.animation.Play("a1");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (_0024num_00242496 == 1)
					{
						_0024self__00242498.@base.animation.Play("a2");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					_0024num2_00242497 = Random.Range(0, 3);
					if (_0024num2_00242497 == 0)
					{
						_0024self__00242498.@base.animation.Play("a3");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(2f)) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(1f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024i_00242495 = 0;
					goto IL_0173;
				case 3:
					_0024i_00242495++;
					goto IL_0173;
				case 6:
					_0024self__00242498.SpawnEnemies();
					goto case 4;
				case 4:
				case 5:
				case 7:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 8:
					_0024self__00242498.attacking = false;
					goto IL_028d;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0173:
					if (_0024i_00242495 < 5)
					{
						if (_0024self__00242498.e.transform.rotation.y != 0f)
						{
							Object.Instantiate(Resources.Load("dBallR"), _0024self__00242498.headObj.transform.position, Quaternion.identity);
						}
						else
						{
							Object.Instantiate(Resources.Load("dBallL"), _0024self__00242498.headObj.transform.position, Quaternion.identity);
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

		internal ScourgeDragon _0024self__00242499;

		public _0024AttackCheck_00242494(ScourgeDragon self_)
		{
			_0024self__00242499 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242499);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242500 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242501;

			internal int _0024dir_00242502;

			internal int _0024_0024915_00242503;

			internal Vector3 _0024_0024916_00242504;

			internal ScourgeDragon _0024self__00242505;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242505 = self_;
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
					if (!_0024self__00242505.attacking)
					{
						((Component)_0024self__00242505).audio.PlayOneShot(_0024self__00242505.a);
						_0024self__00242505.dir = 0;
						int num = (_0024_0024915_00242503 = 0);
						Vector3 val = (_0024_0024916_00242504 = _0024self__00242505._0024get_rigidbody_00242506().velocity);
						float num2 = (_0024_0024916_00242504.x = _0024_0024915_00242503);
						Vector3 val3 = (_0024self__00242505._0024get_rigidbody_00242507().velocity = _0024_0024916_00242504);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
						break;
					}
					goto IL_00f7;
				case 2:
					_0024num_00242501 = Random.Range(1, 2);
					_0024dir_00242502 = Random.Range(1, 3);
					_0024self__00242505.moving = false;
					_0024self__00242505.dir = _0024dir_00242502;
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
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00242501)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeDragon _0024self__00242508;

		public _0024MoveCheck_00242500(ScourgeDragon self_)
		{
			_0024self__00242508 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242508);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242509 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242510;

			internal Ray _0024ray2_00242511;

			internal ScourgeDragon _0024self__00242512;

			public _0024(ScourgeDragon self_)
			{
				_0024self__00242512 = self_;
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
					_0024ray_00242510 = new Ray(_0024self__00242512.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00242511 = new Ray(_0024self__00242512.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00242510, ref _0024self__00242512.hit, 10f, 256))
					{
						_0024self__00242512.attacking = true;
						_0024self__00242512.@base.animation.Stop();
						_0024self__00242512.@base.animation.Play("a1");
						_0024self__00242512.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242511, ref _0024self__00242512.hit, 10f, 256))
					{
						_0024self__00242512.attacking = true;
						_0024self__00242512.@base.animation.Stop();
						_0024self__00242512.@base.animation.Play("a1");
						_0024self__00242512.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
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

		internal ScourgeDragon _0024self__00242513;

		public _0024ATK_00242509(ScourgeDragon self_)
		{
			_0024self__00242513 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242513);
		}
	}

	private RaycastHit hit;

	public GameObject headObj;

	private bool initialized;

	public override IEnumerator MoveUp()
	{
		return new _0024MoveUp_00242476(this).GetEnumerator();
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
		return new _0024Start_00242482(this).GetEnumerator();
	}

	public override IEnumerator TurnCheck()
	{
		return new _0024TurnCheck_00242486(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242494(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242500(this).GetEnumerator();
	}

	[RPC]
	public override void SpawnEnemies()
	{
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00242509(this).GetEnumerator();
	}

	public override void Main()
	{
	}

	internal Rigidbody _0024get_rigidbody_00242506()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00242507()
	{
		return ((Component)this).rigidbody;
	}
}
