using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class RockScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00242377 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal RockScript _0024self__00242378;

			public _0024(RockScript self_)
			{
				_0024self__00242378 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 2:
					if (Network.isServer)
					{
						_0024self__00242378.StartCoroutine_Auto(_0024self__00242378.Exile());
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

		internal RockScript _0024self__00242379;

		public _0024Die_00242377(RockScript self_)
		{
			_0024self__00242379 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242379);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242380 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal RockScript _0024self__00242381;

			public _0024(RockScript self_)
			{
				_0024self__00242381 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242381.exiling)
					{
						_0024self__00242381.exiling = true;
						_0024self__00242381.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00242381.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00242381.GetComponent<NetworkView>().viewID);
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

		internal RockScript _0024self__00242382;

		public _0024Exile_00242380(RockScript self_)
		{
			_0024self__00242382 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242382);
		}
	}

	private Transform t;

	private int speed;

	public int bonus;

	private bool exiling;

	public virtual void Awake()
	{
		t = transform;
		speed = UnityEngine.Random.Range(8, 15);
		GetComponent<NetworkView>().RPC("Die", RPCMode.All);
	}

	public virtual void Update()
	{
		t.Translate(Vector3.up * Time.deltaTime * -(speed + bonus));
	}

	[RPC]
	public virtual IEnumerator Die()
	{
		return new _0024Die_00242377(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00242380(this).GetEnumerator();
	}

	}