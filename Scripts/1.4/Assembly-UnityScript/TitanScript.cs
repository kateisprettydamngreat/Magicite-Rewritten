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
	internal sealed class _0024Start_00242859 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242860;

			internal TitanScript _0024self__00242861;

			public _0024(TitanScript self_)
			{
				_0024self__00242861 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242861.@base.animation["i"].layer = 0;
					_0024self__00242861.@base.animation["r"].layer = 0;
					_0024self__00242861.@base.animation["a"].layer = 1;
					_0024self__00242861.@base.animation["r"].speed = 2f;
					_0024self__00242861.@base.animation["i"].speed = 2f;
					_0024self__00242861.@base.animation["a"].speed = 0.5f;
					_0024drops_00242860 = new int[3] { 7, 18, 0 };
					_0024self__00242861.SetStats(20, 1, 1, 3, 4f, _0024drops_00242860, Random.Range(2, 6), 3);
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242861).StartCoroutine_Auto(_0024self__00242861.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal TitanScript _0024self__00242862;

		public _0024Start_00242859(TitanScript self_)
		{
			_0024self__00242862 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242862);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242863 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242864;

			internal Ray _0024ray2_00242865;

			internal int _0024_00241060_00242866;

			internal Vector3 _0024_00241061_00242867;

			internal TitanScript _0024self__00242868;

			public _0024(TitanScript self_)
			{
				_0024self__00242868 = self_;
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
							((Component)_0024self__00242868).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						}
					}
					else
					{
						_0024ray_00242864 = new Ray(_0024self__00242868.t.position, new Vector3(1f, 0f, 0f));
						_0024ray2_00242865 = new Ray(_0024self__00242868.t.position, new Vector3(-1f, 0f, 0f));
						if (Physics.Raycast(_0024ray_00242864, ref _0024self__00242868.hit, 10f, 256))
						{
							_0024self__00242868.attacking = true;
							_0024self__00242868.@base.animation.Stop();
							_0024self__00242868.@base.animation.Play("a");
							_0024self__00242868.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00242865, ref _0024self__00242868.hit, 10f, 256))
						{
							_0024self__00242868.attacking = true;
							_0024self__00242868.@base.animation.Stop();
							_0024self__00242868.@base.animation.Play("a");
							_0024self__00242868.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
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
					_0024self__00242868.attacking = false;
					int num = (_0024_00241060_00242866 = 0);
					Vector3 val = (_0024_00241061_00242867 = _0024self__00242868.r.velocity);
					float num2 = (_0024_00241061_00242867.x = _0024_00241060_00242866);
					Vector3 val3 = (_0024self__00242868.r.velocity = _0024_00241061_00242867);
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

		internal TitanScript _0024self__00242869;

		public _0024AttackCheck_00242863(TitanScript self_)
		{
			_0024self__00242869 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242869);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242870 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242871;

			internal int _0024dir_00242872;

			internal int _0024_00241062_00242873;

			internal Vector3 _0024_00241063_00242874;

			internal TitanScript _0024self__00242875;

			public _0024(TitanScript self_)
			{
				_0024self__00242875 = self_;
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
					if (!_0024self__00242875.attacking)
					{
						_0024self__00242875.moving = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(2, 6))) ? 1 : 0);
						break;
					}
					goto case 3;
				case 2:
				{
					_0024num_00242871 = Random.Range(1, 2);
					_0024dir_00242872 = Random.Range(1, 3);
					_0024self__00242875.moving = false;
					_0024self__00242875.dir = _0024dir_00242872;
					int num = (_0024_00241062_00242873 = 0);
					Vector3 val = (_0024_00241063_00242874 = _0024self__00242875._0024get_rigidbody_00242876().velocity);
					float num2 = (_0024_00241063_00242874.x = _0024_00241062_00242873);
					Vector3 val3 = (_0024self__00242875._0024get_rigidbody_00242877().velocity = _0024_00241063_00242874);
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

		internal TitanScript _0024self__00242878;

		public _0024MoveCheck_00242870(TitanScript self_)
		{
			_0024self__00242878 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242878);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242879 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024target_00242880;

			internal TitanScript _0024self__00242881;

			public _0024(GameObject target, TitanScript self_)
			{
				_0024target_00242880 = target;
				_0024self__00242881 = self_;
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
					if (MenuScript.multiplayer > 0 || !Object.op_Implicit((Object)(object)_0024target_00242880) || _0024self__00242881.attacking)
					{
						goto IL_013b;
					}
					_0024self__00242881.attacking = true;
					_0024self__00242881.@base.animation.Stop();
					if (!(_0024target_00242880.transform.position.x < _0024self__00242881.t.position.x))
					{
						_0024self__00242881.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						_0024self__00242881.@base.animation.Play("a");
					}
					else
					{
						_0024self__00242881.@base.animation.Play("a");
						_0024self__00242881.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242881.attacking = false;
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

		internal GameObject _0024target_00242882;

		internal TitanScript _0024self__00242883;

		public _0024Attack_00242879(GameObject target, TitanScript self_)
		{
			_0024target_00242882 = target;
			_0024self__00242883 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024target_00242882, _0024self__00242883);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242884 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242885;

			internal Ray _0024ray2_00242886;

			internal TitanScript _0024self__00242887;

			public _0024(TitanScript self_)
			{
				_0024self__00242887 = self_;
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
					_0024ray_00242885 = new Ray(_0024self__00242887.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00242886 = new Ray(_0024self__00242887.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00242885, ref _0024self__00242887.hit, 10f, 256))
					{
						_0024self__00242887.attacking = true;
						_0024self__00242887.@base.animation.Stop();
						_0024self__00242887.@base.animation.Play("a");
						_0024self__00242887.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242886, ref _0024self__00242887.hit, 10f, 256))
					{
						_0024self__00242887.attacking = true;
						_0024self__00242887.@base.animation.Stop();
						_0024self__00242887.@base.animation.Play("a");
						_0024self__00242887.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
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

		internal TitanScript _0024self__00242888;

		public _0024ATK_00242884(TitanScript self_)
		{
			_0024self__00242888 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242888);
		}
	}

	private RaycastHit hit;

	public override IEnumerator Start()
	{
		return new _0024Start_00242859(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242863(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242870(this).GetEnumerator();
	}

	public override IEnumerator Attack(GameObject target)
	{
		return new _0024Attack_00242879(target, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00242884(this).GetEnumerator();
	}

	public override void Main()
	{
	}

	internal Rigidbody _0024get_rigidbody_00242876()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00242877()
	{
		return ((Component)this).rigidbody;
	}
}
