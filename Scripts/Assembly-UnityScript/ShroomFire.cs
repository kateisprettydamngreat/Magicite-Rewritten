using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ShroomFire : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242462 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ShroomFire _0024self__00242463;

			public _0024(ShroomFire self_)
			{
				_0024self__00242463 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242463.exiling)
					{
						_0024self__00242463.exiling = true;
						_0024self__00242463.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00242463.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00242463.GetComponent<NetworkView>().viewID);
					goto IL_008f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_008f:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ShroomFire _0024self__00242464;

		public _0024Exile_00242462(ShroomFire self_)
		{
			_0024self__00242464 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242464);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242465 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ShroomFire _0024self__00242466;

			public _0024(ShroomFire self_)
			{
				_0024self__00242466 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(6f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242466.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242466.StartCoroutine_Auto(_0024self__00242466.Exile());
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ShroomFire _0024self__00242467;

		public _0024Start_00242465(ShroomFire self_)
		{
			_0024self__00242467 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242467);
		}
	}

	private Vector3 playerPos;

	private Rigidbody r;

	private Vector3 finalVec;

	private Transform t;

	private bool canShoot;

	private bool exiling;

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00242462(this).GetEnumerator();
	}

	public virtual void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
	}

	[RPC]
	public virtual void Set(Vector3 v)
	{
		playerPos = v;
		finalVec = Vector3.Normalize(playerPos - transform.position);
		canShoot = true;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242465(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (canShoot)
		{
			t.Translate(finalVec * 9f * Time.deltaTime);
		}
	}

	public virtual void Main()
	{
	}
}
