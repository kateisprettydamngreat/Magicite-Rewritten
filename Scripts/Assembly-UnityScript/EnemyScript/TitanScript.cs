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
	internal sealed class _0024Start_00242643 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242644;

			internal TitanScript _0024self__00242645;

			public _0024(TitanScript self_)
			{
				_0024self__00242645 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242645.@base.GetComponent<Animation>()["i"].layer = 0;
					_0024self__00242645.@base.GetComponent<Animation>()["r"].layer = 0;
					_0024self__00242645.@base.GetComponent<Animation>()["a"].layer = 1;
					_0024self__00242645.@base.GetComponent<Animation>()["r"].speed = 2f;
					_0024self__00242645.@base.GetComponent<Animation>()["i"].speed = 2f;
					_0024self__00242645.@base.GetComponent<Animation>()["a"].speed = 0.5f;
					_0024drops_00242644 = new int[3] { 7, 18, 0 };
					_0024self__00242645.SetStats(20, 1, 1, 3, 4f, _0024drops_00242644, UnityEngine.Random.Range(2, 6), 3);
					goto case 2;
				case 2:
					result = (Yield(2, _0024self__00242645.StartCoroutine_Auto(_0024self__00242645.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal TitanScript _0024self__00242646;

		public _0024Start_00242643(TitanScript self_)
		{
			_0024self__00242646 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00242646);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242647 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024969_00242648;

			internal Vector3 _0024_0024970_00242649;

			internal TitanScript _0024self__00242650;

			public _0024(TitanScript self_)
			{
				_0024self__00242650 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (Network.isServer)
					{
						_0024self__00242650.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					}
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00242650.attacking = false;
					int num = (_0024_0024969_00242648 = 0);
					Vector3 vector = (_0024_0024970_00242649 = _0024self__00242650.r.velocity);
					float num2 = (_0024_0024970_00242649.x = _0024_0024969_00242648);
					Vector3 vector3 = (_0024self__00242650.r.velocity = _0024_0024970_00242649);
					YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal TitanScript _0024self__00242651;

		public _0024AttackCheck_00242647(TitanScript self_)
		{
			_0024self__00242651 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242651);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242652 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242653;

			internal int _0024dir_00242654;

			internal int _0024_0024971_00242655;

			internal Vector3 _0024_0024972_00242656;

			internal TitanScript _0024self__00242657;

			public _0024(TitanScript self_)
			{
				_0024self__00242657 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242657.attacking)
					{
						_0024self__00242657.moving = true;
						result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(2, 6))) ? 1 : 0);
						break;
					}
					goto case 3;
				case 2:
				{
					_0024num_00242653 = UnityEngine.Random.Range(1, 2);
					_0024dir_00242654 = UnityEngine.Random.Range(1, 3);
					_0024self__00242657.moving = false;
					_0024self__00242657.dir = _0024dir_00242654;
					int num = (_0024_0024971_00242655 = 0);
					Vector3 vector = (_0024_0024972_00242656 = _0024self__00242657.GetComponent<Rigidbody>().velocity);
					float num2 = (_0024_0024972_00242656.x = _0024_0024971_00242655);
					Vector3 vector3 = (_0024self__00242657.GetComponent<Rigidbody>().velocity = _0024_0024972_00242656);
					result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 3:
					result = (Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal TitanScript _0024self__00242658;

		public _0024MoveCheck_00242652(TitanScript self_)
		{
			_0024self__00242658 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242658);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242659 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242660;

			internal Ray _0024ray2_00242661;

			internal TitanScript _0024self__00242662;

			public _0024(TitanScript self_)
			{
				_0024self__00242662 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024ray_00242660 = new Ray(_0024self__00242662.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00242661 = new Ray(_0024self__00242662.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00242660, out _0024self__00242662.hit, 10f, 256))
					{
						_0024self__00242662.attacking = true;
						_0024self__00242662.@base.GetComponent<Animation>().Stop();
						_0024self__00242662.@base.GetComponent<Animation>().Play("a");
						_0024self__00242662.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242661, out _0024self__00242662.hit, 10f, 256))
					{
						_0024self__00242662.attacking = true;
						_0024self__00242662.@base.GetComponent<Animation>().Stop();
						_0024self__00242662.@base.GetComponent<Animation>().Play("a");
						_0024self__00242662.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 2;
				case 2:
				case 3:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal TitanScript _0024self__00242663;

		public _0024ATK_00242659(TitanScript self_)
		{
			_0024self__00242663 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242663);
		}
	}

	private RaycastHit hit;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242643(this).GetEnumerator();
	}

	public virtual IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242647(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242652(this).GetEnumerator();
	}

	public virtual void Attack(GameObject target)
	{
	}

	[RPC]
	public virtual IEnumerator ATK()
	{
		return new _0024ATK_00242659(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
