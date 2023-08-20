using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ghoulFire : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Set_00242866 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024v_00242867;

			internal ghoulFire _0024self__00242868;

			public _0024(Vector3 v, ghoulFire self_)
			{
				_0024v_00242867 = v;
				_0024self__00242868 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242868.playerPos = _0024v_00242867;
					_0024self__00242868.finalVec = Vector3.Normalize(_0024self__00242868.playerPos - _0024self__00242868.transform.position);
					if (_0024self__00242868.isButterfly)
					{
						_0024self__00242868.wait = 2f;
						_0024self__00242868.spdd = 10;
					}
					else
					{
						_0024self__00242868.wait = 0.5f;
					}
					if (!_0024self__00242868.noWait)
					{
						result = (Yield(2, new WaitForSeconds(_0024self__00242868.wait)) ? 1 : 0);
						break;
					}
					goto case 2;
				case 2:
					_0024self__00242868.canShoot = true;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024v_00242869;

		internal ghoulFire _0024self__00242870;

		public _0024Set_00242866(Vector3 v, ghoulFire self_)
		{
			_0024v_00242869 = v;
			_0024self__00242870 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024v_00242869, _0024self__00242870);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242871 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ghoulFire _0024self__00242872;

			public _0024(ghoulFire self_)
			{
				_0024self__00242872 = self_;
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
					_0024self__00242872.StartCoroutine_Auto(_0024self__00242872.Exile());
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ghoulFire _0024self__00242873;

		public _0024Start_00242871(ghoulFire self_)
		{
			_0024self__00242873 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242873);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242874 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ghoulFire _0024self__00242875;

			public _0024(ghoulFire self_)
			{
				_0024self__00242875 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242875.exiling)
					{
						_0024self__00242875.exiling = true;
						_0024self__00242875.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00242875.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00242875.GetComponent<NetworkView>().viewID);
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

		internal ghoulFire _0024self__00242876;

		public _0024Exile_00242874(ghoulFire self_)
		{
			_0024self__00242876 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242876);
		}
	}

	public bool noWait;

	private Vector3 playerPos;

	private Rigidbody r;

	private Vector3 finalVec;

	private Transform t;

	private bool canShoot;

	private float wait;

	public bool isButterfly;

	private int spdd;

	private bool exiling;

	public ghoulFire()
	{
		spdd = 18;
	}

	public virtual void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
	}

	[RPC]
	public virtual IEnumerator Set(Vector3 v)
	{
		return new _0024Set_00242866(v, this).GetEnumerator();
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242871(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (canShoot && Network.isServer)
		{
			t.Translate(finalVec * spdd * Time.deltaTime);
		}
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00242874(this).GetEnumerator();
	}

	}