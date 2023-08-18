using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class GatorScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241821 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00241822;

			internal GatorScript _0024self__00241823;

			public _0024(GatorScript self_)
			{
				_0024self__00241823 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241823.@base.GetComponent<Animation>()["i"].layer = 0;
					_0024self__00241823.@base.GetComponent<Animation>()["a"].layer = 1;
					_0024self__00241823.@base.GetComponent<Animation>()["r"].layer = 0;
					_0024drops_00241822 = new int[3] { 7, 18, 0 };
					_0024self__00241823.SetStats(30, 6, 2, 10, 2f, _0024drops_00241822, UnityEngine.Random.Range(10, 25), 10);
					_0024self__00241823.StartCoroutine_Auto(_0024self__00241823.Jump());
					goto case 3;
				case 3:
					result = (Yield(2, _0024self__00241823.StartCoroutine_Auto(_0024self__00241823.MoveCheck())) ? 1 : 0);
					break;
				case 2:
					result = (Yield(3, _0024self__00241823.StartCoroutine_Auto(_0024self__00241823.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GatorScript _0024self__00241824;

		public _0024Start_00241821(GatorScript self_)
		{
			_0024self__00241824 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00241824);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Jump_00241825 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GatorScript _0024self__00241826;

			public _0024(GatorScript self_)
			{
				_0024self__00241826 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(0, 5))) ? 1 : 0);
					break;
				case 2:
				case 3:
					if (_0024self__00241826.spdd != 0f)
					{
					}
					result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GatorScript _0024self__00241827;

		public _0024Jump_00241825(GatorScript self_)
		{
			_0024self__00241827 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241827);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241828 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241829;

			internal Ray _0024ray2_00241830;

			internal int _0024_0024607_00241831;

			internal Vector3 _0024_0024608_00241832;

			internal GatorScript _0024self__00241833;

			public _0024(GatorScript self_)
			{
				_0024self__00241833 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024ray_00241829 = new Ray(_0024self__00241833.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00241830 = new Ray(_0024self__00241833.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241829, out _0024self__00241833.hit, 20f, 256))
					{
						_0024self__00241833.attacking = true;
						_0024self__00241833.@base.GetComponent<Animation>().Stop();
						_0024self__00241833.@base.GetComponent<Animation>().Play("a");
						_0024self__00241833.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241830, out _0024self__00241833.hit, 20f, 256))
					{
						_0024self__00241833.attacking = true;
						_0024self__00241833.@base.GetComponent<Animation>().Stop();
						_0024self__00241833.@base.GetComponent<Animation>().Play("a");
						_0024self__00241833.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_02a4;
				case 2:
					_0024self__00241833.@base.GetComponent<Animation>().Play("r");
					_0024self__00241833.atking = true;
					_0024self__00241833.spdd = 10f;
					result = (Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241833.atking = false;
					_0024self__00241833.spdd = 0f;
					_0024self__00241833.@base.GetComponent<Animation>().Play("i");
					goto IL_02a4;
				case 4:
					_0024self__00241833.@base.GetComponent<Animation>().Play("r");
					_0024self__00241833.atking = true;
					_0024self__00241833.spdd = -10f;
					result = (Yield(5, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241833.atking = false;
					_0024self__00241833.spdd = 0f;
					_0024self__00241833.@base.GetComponent<Animation>().Play("i");
					goto IL_02a4;
				case 6:
				{
					_0024self__00241833.attacking = false;
					int num = (_0024_0024607_00241831 = 0);
					Vector3 vector = (_0024_0024608_00241832 = _0024self__00241833.r.velocity);
					float num2 = (_0024_0024608_00241832.x = _0024_0024607_00241831);
					Vector3 vector3 = (_0024self__00241833.r.velocity = _0024_0024608_00241832);
					YieldDefault(1);
					goto case 1;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_02a4:
					result = (Yield(6, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GatorScript _0024self__00241834;

		public _0024AttackCheck_00241828(GatorScript self_)
		{
			_0024self__00241834 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241834);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241835 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GatorScript _0024self__00241836;

			public _0024(GatorScript self_)
			{
				_0024self__00241836 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241836.atking = true;
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241836.atking = false;
					_0024self__00241836.spdd = 0f;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GatorScript _0024self__00241837;

		public _0024MoveCheck_00241835(GatorScript self_)
		{
			_0024self__00241837 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241837);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00241838 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241839;

			internal Ray _0024ray2_00241840;

			internal GatorScript _0024self__00241841;

			public _0024(GatorScript self_)
			{
				_0024self__00241841 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024ray_00241839 = new Ray(_0024self__00241841.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00241840 = new Ray(_0024self__00241841.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241839, out _0024self__00241841.hit, 20f, 256))
					{
						_0024self__00241841.attacking = true;
						_0024self__00241841.@base.GetComponent<Animation>().Stop();
						_0024self__00241841.@base.GetComponent<Animation>().Play("a");
						_0024self__00241841.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241840, out _0024self__00241841.hit, 20f, 256))
					{
						_0024self__00241841.attacking = true;
						_0024self__00241841.@base.GetComponent<Animation>().Stop();
						_0024self__00241841.@base.GetComponent<Animation>().Play("a");
						_0024self__00241841.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_02a6;
				case 2:
					_0024self__00241841.@base.GetComponent<Animation>().Play("r");
					_0024self__00241841.atking = true;
					_0024self__00241841.spdd = 10f;
					result = (Yield(3, new WaitForSeconds(UnityEngine.Random.Range(1, 4))) ? 1 : 0);
					break;
				case 3:
					_0024self__00241841.atking = false;
					_0024self__00241841.spdd = 0f;
					_0024self__00241841.@base.GetComponent<Animation>().Play("i");
					goto IL_02a6;
				case 4:
					_0024self__00241841.@base.GetComponent<Animation>().Play("r");
					_0024self__00241841.atking = true;
					_0024self__00241841.spdd = -10f;
					result = (Yield(5, new WaitForSeconds(UnityEngine.Random.Range(1, 4))) ? 1 : 0);
					break;
				case 5:
					_0024self__00241841.atking = false;
					_0024self__00241841.spdd = 0f;
					_0024self__00241841.@base.GetComponent<Animation>().Play("i");
					goto IL_02a6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02a6:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal GatorScript _0024self__00241842;

		public _0024ATK_00241838(GatorScript self_)
		{
			_0024self__00241842 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241842);
		}
	}

	private RaycastHit hit;

	private float spdd;

	private bool atking;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241821(this).GetEnumerator();
	}

	public virtual IEnumerator Jump()
	{
		return new _0024Jump_00241825(this).GetEnumerator();
	}

	public virtual IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241828(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241835(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator ATK()
	{
		return new _0024ATK_00241838(this).GetEnumerator();
	}

	public override void Update()
	{
		if (atking)
		{
			float x = spdd;
			Vector3 velocity = r.velocity;
			float num = (velocity.x = x);
			Vector3 vector2 = (r.velocity = velocity);
		}
	}

	public override void Main()
	{
	}
}
