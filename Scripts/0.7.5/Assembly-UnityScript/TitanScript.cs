using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class TitanScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242530 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242531;

			internal TitanScript _0024self__00242532;

			public _0024(TitanScript self_)
			{
				_0024self__00242532 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242532.@base.animation["i"].layer = 0;
					_0024self__00242532.@base.animation["r"].layer = 0;
					_0024self__00242532.@base.animation["a"].layer = 1;
					_0024self__00242532.@base.animation["r"].speed = 2f;
					_0024self__00242532.@base.animation["i"].speed = 2f;
					_0024self__00242532.@base.animation["a"].speed = 0.5f;
					_0024drops_00242531 = new int[3] { 7, 18, 0 };
					_0024self__00242532.SetStats(20, 1, 1, 3, 4f, _0024drops_00242531, Random.Range(2, 6), 3);
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242532).StartCoroutine_Auto(_0024self__00242532.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal TitanScript _0024self__00242533;

		public _0024Start_00242530(TitanScript self_)
		{
			_0024self__00242533 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242533);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242534 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242535;

			internal Ray _0024ray2_00242536;

			internal int _0024_0024962_00242537;

			internal Vector3 _0024_0024963_00242538;

			internal TitanScript _0024self__00242539;

			public _0024(TitanScript self_)
			{
				_0024self__00242539 = self_;
			}

			public override bool MoveNext()
			{
				//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01df: Expected O, but got Unknown
				//IL_0207: Unknown result type (might be due to invalid IL or missing references)
				//IL_020c: Unknown result type (might be due to invalid IL or missing references)
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_020e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0213: Unknown result type (might be due to invalid IL or missing references)
				//IL_0237: Unknown result type (might be due to invalid IL or missing references)
				//IL_023c: Unknown result type (might be due to invalid IL or missing references)
				//IL_023d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0243: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_009c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_013d: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Expected O, but got Unknown
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c9: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							((Component)_0024self__00242539).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						}
					}
					else
					{
						_0024ray_00242535 = new Ray(_0024self__00242539.t.position, new Vector3(1f, 0f, 0f));
						_0024ray2_00242536 = new Ray(_0024self__00242539.t.position, new Vector3(-1f, 0f, 0f));
						if (Physics.Raycast(_0024ray_00242535, ref _0024self__00242539.hit, 10f, 256))
						{
							_0024self__00242539.attacking = true;
							_0024self__00242539.@base.animation.Stop();
							_0024self__00242539.@base.animation.Play("a");
							_0024self__00242539.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00242536, ref _0024self__00242539.hit, 10f, 256))
						{
							_0024self__00242539.attacking = true;
							_0024self__00242539.@base.animation.Stop();
							_0024self__00242539.@base.animation.Play("a");
							_0024self__00242539.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
							break;
						}
					}
					goto case 2;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 4:
				{
					_0024self__00242539.attacking = false;
					int num = (_0024_0024962_00242537 = 0);
					Vector3 val = (_0024_0024963_00242538 = _0024self__00242539.r.velocity);
					float num2 = (_0024_0024963_00242538.x = _0024_0024962_00242537);
					Vector3 val3 = (_0024self__00242539.r.velocity = _0024_0024963_00242538);
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

		internal TitanScript _0024self__00242540;

		public _0024AttackCheck_00242534(TitanScript self_)
		{
			_0024self__00242540 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242540);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242541 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242542;

			internal int _0024dir_00242543;

			internal int _0024_0024964_00242544;

			internal Vector3 _0024_0024965_00242545;

			internal TitanScript _0024self__00242546;

			public _0024(TitanScript self_)
			{
				_0024self__00242546 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Expected O, but got Unknown
				//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0104: Expected O, but got Unknown
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242546.attacking)
					{
						_0024self__00242546.moving = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(2, 6))) ? 1 : 0);
						break;
					}
					goto case 3;
				case 2:
				{
					_0024num_00242542 = Random.Range(1, 2);
					_0024dir_00242543 = Random.Range(1, 3);
					_0024self__00242546.moving = false;
					_0024self__00242546.dir = _0024dir_00242543;
					int num = (_0024_0024964_00242544 = 0);
					Vector3 val = (_0024_0024965_00242545 = _0024self__00242546._0024get_rigidbody_00242547().velocity);
					float num2 = (_0024_0024965_00242545.x = _0024_0024964_00242544);
					Vector3 val3 = (_0024self__00242546._0024get_rigidbody_00242548().velocity = _0024_0024965_00242545);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 3:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal TitanScript _0024self__00242549;

		public _0024MoveCheck_00242541(TitanScript self_)
		{
			_0024self__00242549 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242549);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242550 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024target_00242551;

			internal TitanScript _0024self__00242552;

			public _0024(GameObject target, TitanScript self_)
			{
				_0024target_00242551 = target;
				_0024self__00242552 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_008b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0090: Unknown result type (might be due to invalid IL or missing references)
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_012a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0 || !Object.op_Implicit((Object)(object)_0024target_00242551) || _0024self__00242552.attacking)
					{
						goto IL_013b;
					}
					_0024self__00242552.attacking = true;
					_0024self__00242552.@base.animation.Stop();
					if (!(_0024target_00242551.transform.position.x < _0024self__00242552.t.position.x))
					{
						_0024self__00242552.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						_0024self__00242552.@base.animation.Play("a");
					}
					else
					{
						_0024self__00242552.@base.animation.Play("a");
						_0024self__00242552.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242552.attacking = false;
					goto IL_013b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_013b:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GameObject _0024target_00242553;

		internal TitanScript _0024self__00242554;

		public _0024Attack_00242550(GameObject target, TitanScript self_)
		{
			_0024target_00242553 = target;
			_0024self__00242554 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024target_00242553, _0024self__00242554);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242555 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242556;

			internal Ray _0024ray2_00242557;

			internal TitanScript _0024self__00242558;

			public _0024(TitanScript self_)
			{
				_0024self__00242558 = self_;
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
					_0024ray_00242556 = new Ray(_0024self__00242558.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00242557 = new Ray(_0024self__00242558.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00242556, ref _0024self__00242558.hit, 10f, 256))
					{
						_0024self__00242558.attacking = true;
						_0024self__00242558.@base.animation.Stop();
						_0024self__00242558.@base.animation.Play("a");
						_0024self__00242558.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242557, ref _0024self__00242558.hit, 10f, 256))
					{
						_0024self__00242558.attacking = true;
						_0024self__00242558.@base.animation.Stop();
						_0024self__00242558.@base.animation.Play("a");
						_0024self__00242558.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
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

		internal TitanScript _0024self__00242559;

		public _0024ATK_00242555(TitanScript self_)
		{
			_0024self__00242559 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242559);
		}
	}

	private RaycastHit hit;

	public override IEnumerator Start()
	{
		return new _0024Start_00242530(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242534(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242541(this).GetEnumerator();
	}

	public override IEnumerator Attack(GameObject target)
	{
		return new _0024Attack_00242550(target, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00242555(this).GetEnumerator();
	}

	public override void Main()
	{
	}

	internal Rigidbody _0024get_rigidbody_00242547()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00242548()
	{
		return ((Component)this).rigidbody;
	}
}
