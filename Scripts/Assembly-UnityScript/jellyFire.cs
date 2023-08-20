using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class jellyFire : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Set_00242887 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024v_00242888;

			internal jellyFire _0024self__00242889;

			public _0024(Vector3 v, jellyFire self_)
			{
				_0024v_00242888 = v;
				_0024self__00242889 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242889.playerPos = _0024v_00242888;
					_0024self__00242889.finalVec = Vector3.Normalize(_0024self__00242889.playerPos - _0024self__00242889.transform.position);
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242889.canShoot = true;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024v_00242890;

		internal jellyFire _0024self__00242891;

		public _0024Set_00242887(Vector3 v, jellyFire self_)
		{
			_0024v_00242890 = v;
			_0024self__00242891 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024v_00242890, _0024self__00242891);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242892 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal jellyFire _0024self__00242893;

			public _0024(jellyFire self_)
			{
				_0024self__00242893 = self_;
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
					_0024self__00242893.StartCoroutine_Auto(_0024self__00242893.Exile());
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal jellyFire _0024self__00242894;

		public _0024Start_00242892(jellyFire self_)
		{
			_0024self__00242894 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242894);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242895 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal jellyFire _0024self__00242896;

			public _0024(jellyFire self_)
			{
				_0024self__00242896 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242896.exiling)
					{
						_0024self__00242896.exiling = true;
						_0024self__00242896.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00242896.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00242896.GetComponent<NetworkView>().viewID);
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

		internal jellyFire _0024self__00242897;

		public _0024Exile_00242895(jellyFire self_)
		{
			_0024self__00242897 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242897);
		}
	}

	private Vector3 playerPos;

	private Rigidbody r;

	private Vector3 finalVec;

	private Transform t;

	private bool canShoot;

	private bool exiling;

	public virtual void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
	}

	[RPC]
	public virtual IEnumerator Set(Vector3 v)
	{
		return new _0024Set_00242887(v, this).GetEnumerator();
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242892(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (canShoot && Network.isServer)
		{
			t.Translate(finalVec * 8f * Time.deltaTime);
		}
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00242895(this).GetEnumerator();
	}

	}