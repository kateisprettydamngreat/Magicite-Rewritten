using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BoneThrw : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241275 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BoneThrw _0024self__00241276;

			public _0024(BoneThrw self_)
			{
				_0024self__00241276 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241276.r = _0024self__00241276.@base.GetComponent<Renderer>();
					_0024self__00241276.t = _0024self__00241276.transform;
					if (_0024self__00241276.isRight)
					{
					}
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					if (Network.isServer)
					{
						_0024self__00241276.StartCoroutine_Auto(_0024self__00241276.Exile());
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

		internal BoneThrw _0024self__00241277;

		public _0024Start_00241275(BoneThrw self_)
		{
			_0024self__00241277 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241277);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241278 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BoneThrw _0024self__00241279;

			public _0024(BoneThrw self_)
			{
				_0024self__00241279 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241279.exiling)
					{
						_0024self__00241279.exiling = true;
						_0024self__00241279.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00241279.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00241279.GetComponent<NetworkView>().viewID);
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

		internal BoneThrw _0024self__00241280;

		public _0024Exile_00241278(BoneThrw self_)
		{
			_0024self__00241280 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241280);
		}
	}

	public bool isRight;

	public GameObject @base;

	private Renderer r;

	private float speed;

	private Transform t;

	private bool exiling;

	public BoneThrw()
	{
		speed = 5f;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241275(this).GetEnumerator();
	}

	public virtual void Update()
	{
		speed += 0.2f;
		if (isRight)
		{
			t.Translate(Vector3.left * Time.deltaTime * (0f - speed));
		}
		else
		{
			t.Translate(Vector3.left * Time.deltaTime * speed);
		}
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer != 9)
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241278(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
