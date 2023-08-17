using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class YetiScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242775 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242776;

			internal YetiScript _0024self__00242777;

			public _0024(YetiScript self_)
			{
				_0024self__00242777 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242777.@base.GetComponent<Animation>()["i"].layer = 0;
					_0024self__00242777.@base.GetComponent<Animation>()["a"].layer = 1;
					_0024self__00242777.@base.GetComponent<Animation>()["i"].speed = 0.5f;
					_0024drops_00242776 = new int[3] { 1, 0, 0 };
					_0024self__00242777.SetStats(20, 2, 1, 8, 6f, _0024drops_00242776, UnityEngine.Random.Range(3, 20), 6);
					goto case 2;
				case 2:
					result = (Yield(2, _0024self__00242777.StartCoroutine_Auto(_0024self__00242777.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal YetiScript _0024self__00242778;

		public _0024Start_00242775(YetiScript self_)
		{
			_0024self__00242778 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00242778);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242779 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024startPos_00242780;

			internal Ray _0024ray_00242781;

			internal Ray _0024ray2_00242782;

			internal int _0024num_00242783;

			internal YetiScript _0024self__00242784;

			public _0024(YetiScript self_)
			{
				_0024self__00242784 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024startPos_00242780 = new Vector3(_0024self__00242784.t.position.x, _0024self__00242784.t.position.y - 0.3f, 0f);
					_0024ray_00242781 = new Ray(_0024startPos_00242780, new Vector3(1f, 0f, 0f));
					_0024ray2_00242782 = new Ray(_0024startPos_00242780, new Vector3(-1f, 0f, 0f));
					_0024num_00242783 = default(int);
					if (Physics.Raycast(_0024ray_00242781, out _0024self__00242784.hit, 20f, 256))
					{
						_0024self__00242784.attacking = true;
						_0024num_00242783 = UnityEngine.Random.Range(0, 5);
						_0024self__00242784.@base.GetComponent<Animation>().Play("a");
						_0024self__00242784.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242782, out _0024self__00242784.hit, 20f, 256))
					{
						_0024self__00242784.attacking = true;
						_0024self__00242784.@base.GetComponent<Animation>().Play("a");
						_0024self__00242784.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 2:
					if (Network.isServer)
					{
						Network.Instantiate(_0024self__00242784.ballR, _0024self__00242784.t.position, Quaternion.identity, 0);
					}
					result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 4:
					if (Network.isServer)
					{
						Network.Instantiate(_0024self__00242784.ballL, _0024self__00242784.t.position, Quaternion.identity, 0);
					}
					result = (Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 3:
				case 5:
					_0024self__00242784.attacking = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal YetiScript _0024self__00242785;

		public _0024ATK_00242779(YetiScript self_)
		{
			_0024self__00242785 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242785);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242786 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024startPos_00242787;

			internal Ray _0024ray_00242788;

			internal Ray _0024ray2_00242789;

			internal int _0024num_00242790;

			internal int _0024doodoo_00242791;

			internal int _0024doodoso_00242792;

			internal int _0024_00241011_00242793;

			internal Vector3 _0024_00241012_00242794;

			internal int _0024_00241013_00242795;

			internal Vector3 _0024_00241014_00242796;

			internal YetiScript _0024self__00242797;

			public _0024(YetiScript self_)
			{
				_0024self__00242797 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024startPos_00242787 = new Vector3(_0024self__00242797.t.position.x, _0024self__00242797.t.position.y - 0.3f, 0f);
					_0024ray_00242788 = new Ray(_0024startPos_00242787, new Vector3(1f, 0f, 0f));
					_0024ray2_00242789 = new Ray(_0024startPos_00242787, new Vector3(-1f, 0f, 0f));
					_0024num_00242790 = default(int);
					if (!_0024self__00242797.attacking)
					{
						if (Physics.Raycast(_0024ray_00242788, out _0024self__00242797.hit, 20f, 256))
						{
							_0024num_00242790 = UnityEngine.Random.Range(0, 5);
							if (Network.isServer)
							{
								_0024doodoo_00242791 = UnityEngine.Random.Range(0, 3);
								if (_0024doodoo_00242791 == 0)
								{
									int num = (_0024_00241011_00242793 = 20);
									Vector3 vector = (_0024_00241012_00242794 = _0024self__00242797.r.velocity);
									float num2 = (_0024_00241012_00242794.y = _0024_00241011_00242793);
									Vector3 vector3 = (_0024self__00242797.r.velocity = _0024_00241012_00242794);
								}
							}
							_0024self__00242797.@base.GetComponent<Animation>().Play("a");
							_0024self__00242797.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00242789, out _0024self__00242797.hit, 20f, 256))
						{
							if (Network.isServer)
							{
								_0024doodoso_00242792 = UnityEngine.Random.Range(0, 3);
								if (_0024doodoso_00242792 == 0)
								{
									int num3 = (_0024_00241013_00242795 = 20);
									Vector3 vector4 = (_0024_00241014_00242796 = _0024self__00242797.r.velocity);
									float num4 = (_0024_00241014_00242796.y = _0024_00241013_00242795);
									Vector3 vector6 = (_0024self__00242797.r.velocity = _0024_00241014_00242796);
								}
							}
							_0024self__00242797.@base.GetComponent<Animation>().Play("a");
							_0024self__00242797.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
							result = (Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
							break;
						}
					}
					goto case 3;
				case 2:
					if (Network.isServer)
					{
						Network.Instantiate(_0024self__00242797.ballR, _0024self__00242797.t.position, Quaternion.identity, 0);
					}
					result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 4:
					if (Network.isServer)
					{
						Network.Instantiate(_0024self__00242797.ballL, _0024self__00242797.t.position, Quaternion.identity, 0);
					}
					result = (Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 3:
				case 5:
					result = (Yield(6, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 6:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal YetiScript _0024self__00242798;

		public _0024AttackCheck_00242786(YetiScript self_)
		{
			_0024self__00242798 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242798);
		}
	}

	public GameObject ballL;

	public GameObject ballR;

	private RaycastHit hit;

	private int num;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242775(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator ATK()
	{
		return new _0024ATK_00242779(this).GetEnumerator();
	}

	public virtual IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242786(this).GetEnumerator();
	}
}
