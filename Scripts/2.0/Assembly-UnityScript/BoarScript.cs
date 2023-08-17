using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BoarScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241247 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00241248;

			internal BoarScript _0024self__00241249;

			public _0024(BoarScript self_)
			{
				_0024self__00241249 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241249.@base.GetComponent<Animation>()["i"].layer = 0;
					_0024self__00241249.@base.GetComponent<Animation>()["a"].layer = 1;
					_0024self__00241249.@base.GetComponent<Animation>()["r"].layer = 0;
					_0024self__00241249.@base.GetComponent<Animation>()["r"].speed = 2f;
					_0024drops_00241248 = new int[3] { 18, 20, 19 };
					_0024self__00241249.SetStats(35, 2, 2, 11, 2f, _0024drops_00241248, UnityEngine.Random.Range(5, 15), 11);
					goto case 3;
				case 3:
					result = (Yield(2, _0024self__00241249.StartCoroutine_Auto(_0024self__00241249.MoveCheck())) ? 1 : 0);
					break;
				case 2:
					result = (Yield(3, _0024self__00241249.StartCoroutine_Auto(_0024self__00241249.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal BoarScript _0024self__00241250;

		public _0024Start_00241247(BoarScript self_)
		{
			_0024self__00241250 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00241250);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241251 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241252;

			internal Ray _0024ray2_00241253;

			internal int _0024_0024441_00241254;

			internal Vector3 _0024_0024442_00241255;

			internal BoarScript _0024self__00241256;

			public _0024(BoarScript self_)
			{
				_0024self__00241256 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024ray_00241252 = new Ray(_0024self__00241256.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00241253 = new Ray(_0024self__00241256.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241252, out _0024self__00241256.hit, 20f, 256))
					{
						_0024self__00241256.attacking = true;
						_0024self__00241256.@base.GetComponent<Animation>().Stop();
						_0024self__00241256.@base.GetComponent<Animation>().Play("a");
						_0024self__00241256.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241253, out _0024self__00241256.hit, 20f, 256))
					{
						_0024self__00241256.attacking = true;
						_0024self__00241256.@base.GetComponent<Animation>().Stop();
						_0024self__00241256.@base.GetComponent<Animation>().Play("a");
						_0024self__00241256.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_02a4;
				case 2:
					_0024self__00241256.@base.GetComponent<Animation>().Play("r");
					_0024self__00241256.atking = true;
					_0024self__00241256.spdd = 16f;
					result = (Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241256.atking = false;
					_0024self__00241256.spdd = 0f;
					_0024self__00241256.@base.GetComponent<Animation>().Play("i");
					goto IL_02a4;
				case 4:
					_0024self__00241256.@base.GetComponent<Animation>().Play("r");
					_0024self__00241256.atking = true;
					_0024self__00241256.spdd = -16f;
					result = (Yield(5, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241256.atking = false;
					_0024self__00241256.spdd = 0f;
					_0024self__00241256.@base.GetComponent<Animation>().Play("i");
					goto IL_02a4;
				case 6:
				{
					_0024self__00241256.attacking = false;
					int num = (_0024_0024441_00241254 = 0);
					Vector3 vector = (_0024_0024442_00241255 = _0024self__00241256.r.velocity);
					float num2 = (_0024_0024442_00241255.x = _0024_0024441_00241254);
					Vector3 vector3 = (_0024self__00241256.r.velocity = _0024_0024442_00241255);
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

		internal BoarScript _0024self__00241257;

		public _0024AttackCheck_00241251(BoarScript self_)
		{
			_0024self__00241257 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241257);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241258 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BoarScript _0024self__00241259;

			public _0024(BoarScript self_)
			{
				_0024self__00241259 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241259.atking = true;
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241259.atking = false;
					_0024self__00241259.spdd = 0f;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal BoarScript _0024self__00241260;

		public _0024MoveCheck_00241258(BoarScript self_)
		{
			_0024self__00241260 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241260);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00241261 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241262;

			internal Ray _0024ray2_00241263;

			internal BoarScript _0024self__00241264;

			public _0024(BoarScript self_)
			{
				_0024self__00241264 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024ray_00241262 = new Ray(_0024self__00241264.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00241263 = new Ray(_0024self__00241264.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241262, out _0024self__00241264.hit, 20f, 256))
					{
						_0024self__00241264.attacking = true;
						_0024self__00241264.@base.GetComponent<Animation>().Stop();
						_0024self__00241264.@base.GetComponent<Animation>().Play("a");
						_0024self__00241264.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241263, out _0024self__00241264.hit, 20f, 256))
					{
						_0024self__00241264.attacking = true;
						_0024self__00241264.@base.GetComponent<Animation>().Stop();
						_0024self__00241264.@base.GetComponent<Animation>().Play("a");
						_0024self__00241264.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_02a6;
				case 2:
					_0024self__00241264.@base.GetComponent<Animation>().Play("r");
					_0024self__00241264.atking = true;
					_0024self__00241264.spdd = 16f;
					result = (Yield(3, new WaitForSeconds(UnityEngine.Random.Range(1, 4))) ? 1 : 0);
					break;
				case 3:
					_0024self__00241264.atking = false;
					_0024self__00241264.spdd = 0f;
					_0024self__00241264.@base.GetComponent<Animation>().Play("i");
					goto IL_02a6;
				case 4:
					_0024self__00241264.@base.GetComponent<Animation>().Play("r");
					_0024self__00241264.atking = true;
					_0024self__00241264.spdd = -16f;
					result = (Yield(5, new WaitForSeconds(UnityEngine.Random.Range(1, 4))) ? 1 : 0);
					break;
				case 5:
					_0024self__00241264.atking = false;
					_0024self__00241264.spdd = 0f;
					_0024self__00241264.@base.GetComponent<Animation>().Play("i");
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

		internal BoarScript _0024self__00241265;

		public _0024ATK_00241261(BoarScript self_)
		{
			_0024self__00241265 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241265);
		}
	}

	private RaycastHit hit;

	private float spdd;

	private bool atking;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241247(this).GetEnumerator();
	}

	public virtual IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241251(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241258(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator ATK()
	{
		return new _0024ATK_00241261(this).GetEnumerator();
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
