using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SkeletonScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242714 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242715;

			internal SkeletonScript _0024self__00242716;

			public _0024(SkeletonScript self_)
			{
				_0024self__00242716 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242716.@base.animation["i"].layer = 0;
					_0024self__00242716.@base.animation["a"].layer = 1;
					_0024drops_00242715 = new int[3] { 7, 18, 0 };
					_0024self__00242716.SetStats(50, 10, 10, 8, 4f, _0024drops_00242715, Random.Range(7, 16), 8);
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242716).StartCoroutine_Auto(_0024self__00242716.MoveCheck())) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(3, ((MonoBehaviour)_0024self__00242716).StartCoroutine_Auto(_0024self__00242716.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SkeletonScript _0024self__00242717;

		public _0024Start_00242714(SkeletonScript self_)
		{
			_0024self__00242717 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242717);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242718 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024startPos_00242719;

			internal Ray _0024ray_00242720;

			internal Ray _0024ray2_00242721;

			internal int _0024_00241000_00242722;

			internal Vector3 _0024_00241001_00242723;

			internal SkeletonScript _0024self__00242724;

			public _0024(SkeletonScript self_)
			{
				_0024self__00242724 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0204: Unknown result type (might be due to invalid IL or missing references)
				//IL_020e: Expected O, but got Unknown
				//IL_0236: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Unknown result type (might be due to invalid IL or missing references)
				//IL_023c: Unknown result type (might be due to invalid IL or missing references)
				//IL_023d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0242: Unknown result type (might be due to invalid IL or missing references)
				//IL_0268: Unknown result type (might be due to invalid IL or missing references)
				//IL_026d: Unknown result type (might be due to invalid IL or missing references)
				//IL_026e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0275: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_016c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0149: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Expected O, but got Unknown
				//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f8: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							((Component)_0024self__00242724).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						}
					}
					else
					{
						_0024startPos_00242719 = new Vector3(_0024self__00242724.t.position.x, _0024self__00242724.t.position.y - 0.5f, 0f);
						_0024ray_00242720 = new Ray(_0024startPos_00242719, new Vector3(1f, 0f, 0f));
						_0024ray2_00242721 = new Ray(_0024startPos_00242719, new Vector3(-1f, 0f, 0f));
						if (Physics.Raycast(_0024ray_00242720, ref _0024self__00242724.hit, 10f, 256))
						{
							_0024self__00242724.attacking = true;
							_0024self__00242724.@base.animation.Stop();
							_0024self__00242724.@base.animation.Play("a");
							_0024self__00242724.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00242721, ref _0024self__00242724.hit, 10f, 256))
						{
							_0024self__00242724.attacking = true;
							_0024self__00242724.@base.animation.Stop();
							_0024self__00242724.@base.animation.Play("a");
							_0024self__00242724.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
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
					_0024self__00242724.attacking = false;
					int num = (_0024_00241000_00242722 = 0);
					Vector3 val = (_0024_00241001_00242723 = _0024self__00242724.r.velocity);
					float num2 = (_0024_00241001_00242723.x = _0024_00241000_00242722);
					Vector3 val3 = (_0024self__00242724.r.velocity = _0024_00241001_00242723);
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

		internal SkeletonScript _0024self__00242725;

		public _0024AttackCheck_00242718(SkeletonScript self_)
		{
			_0024self__00242725 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242725);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242726 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242727;

			internal int _0024dir_00242728;

			internal int _0024_00241002_00242729;

			internal Vector3 _0024_00241003_00242730;

			internal SkeletonScript _0024self__00242731;

			public _0024(SkeletonScript self_)
			{
				_0024self__00242731 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Expected O, but got Unknown
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Expected O, but got Unknown
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242731.attacking)
					{
						_0024self__00242731.moving = true;
						int num = (_0024_00241002_00242729 = 0);
						Vector3 val = (_0024_00241003_00242730 = _0024self__00242731._0024get_rigidbody_00242732().velocity);
						float num2 = (_0024_00241003_00242730.x = _0024_00241002_00242729);
						Vector3 val3 = (_0024self__00242731._0024get_rigidbody_00242733().velocity = _0024_00241003_00242730);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024num_00242727 = Random.Range(0, 4);
					_0024dir_00242728 = Random.Range(1, 3);
					_0024self__00242731.dir = _0024dir_00242728;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00242727)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242731.moving = false;
					_0024self__00242731.dir = 0;
					goto case 4;
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

		internal SkeletonScript _0024self__00242734;

		public _0024MoveCheck_00242726(SkeletonScript self_)
		{
			_0024self__00242734 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242734);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242735 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024startPos_00242736;

			internal Ray _0024ray_00242737;

			internal Ray _0024ray2_00242738;

			internal SkeletonScript _0024self__00242739;

			public _0024(SkeletonScript self_)
			{
				_0024self__00242739 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_011d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0127: Expected O, but got Unknown
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024startPos_00242736 = new Vector3(_0024self__00242739.t.position.x, _0024self__00242739.t.position.y - 0.5f, 0f);
					_0024ray_00242737 = new Ray(_0024startPos_00242736, new Vector3(1f, 0f, 0f));
					_0024ray2_00242738 = new Ray(_0024startPos_00242736, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00242737, ref _0024self__00242739.hit, 10f, 256))
					{
						_0024self__00242739.attacking = true;
						_0024self__00242739.@base.animation.Stop();
						_0024self__00242739.@base.animation.Play("a");
						_0024self__00242739.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242738, ref _0024self__00242739.hit, 10f, 256))
					{
						_0024self__00242739.attacking = true;
						_0024self__00242739.@base.animation.Stop();
						_0024self__00242739.@base.animation.Play("a");
						_0024self__00242739.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
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

		internal SkeletonScript _0024self__00242740;

		public _0024ATK_00242735(SkeletonScript self_)
		{
			_0024self__00242740 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242740);
		}
	}

	private RaycastHit hit;

	public override IEnumerator Start()
	{
		return new _0024Start_00242714(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242718(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242726(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00242735(this).GetEnumerator();
	}

	public override void Main()
	{
	}

	internal Rigidbody _0024get_rigidbody_00242732()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00242733()
	{
		return ((Component)this).rigidbody;
	}
}
