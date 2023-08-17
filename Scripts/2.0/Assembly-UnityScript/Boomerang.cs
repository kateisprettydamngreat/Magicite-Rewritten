using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Boomerang : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00241281 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Boomerang _0024self__00241282;

			public _0024(Boomerang self_)
			{
				_0024self__00241282 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
					break;
				case 2:
					if (Network.isServer)
					{
						_0024self__00241282.StartCoroutine_Auto(_0024self__00241282.Exile());
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

		internal Boomerang _0024self__00241283;

		public _0024Die_00241281(Boomerang self_)
		{
			_0024self__00241283 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241283);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Shift_00241284 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Boomerang _0024self__00241285;

			public _0024(Boomerang self_)
			{
				_0024self__00241285 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241285.target = new Vector3(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x, Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).y, 0f);
					_0024self__00241285.finalVector = Vector3.Normalize(_0024self__00241285.target - _0024self__00241285.t.position);
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Boomerang _0024self__00241286;

		public _0024Shift_00241284(Boomerang self_)
		{
			_0024self__00241286 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241286);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241287 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Boomerang _0024self__00241288;

			public _0024(Boomerang self_)
			{
				_0024self__00241288 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241288.exiling)
					{
						_0024self__00241288.exiling = true;
						_0024self__00241288.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00241288.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00241288.GetComponent<NetworkView>().viewID);
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

		internal Boomerang _0024self__00241289;

		public _0024Exile_00241287(Boomerang self_)
		{
			_0024self__00241289 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241289);
		}
	}

	private Transform t;

	private Vector3 target;

	private bool movingRight;

	private Vector3 finalVector;

	private bool exiling;

	public virtual void Awake()
	{
		t = transform;
		StartCoroutine_Auto(Shift());
		StartCoroutine_Auto(Die());
	}

	public virtual IEnumerator Die()
	{
		return new _0024Die_00241281(this).GetEnumerator();
	}

	public virtual IEnumerator Shift()
	{
		return new _0024Shift_00241284(this).GetEnumerator();
	}

	public virtual void Update()
	{
		target = new Vector3(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x, Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).y, 0f);
		finalVector = Vector3.Normalize(target - t.position);
		GetComponent<Rigidbody>().velocity = finalVector * 20f;
	}

	public virtual void OnCollisionEnter(Collision c)
	{
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241287(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
