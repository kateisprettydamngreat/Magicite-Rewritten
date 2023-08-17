using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BallScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00241215 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BallScript _0024self__00241216;

			public _0024(BallScript self_)
			{
				_0024self__00241216 = self_;
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
					_0024self__00241216.StartCoroutine_Auto(_0024self__00241216.Exile());
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal BallScript _0024self__00241217;

		public _0024Die_00241215(BallScript self_)
		{
			_0024self__00241217 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241217);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241218 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BallScript _0024self__00241219;

			public _0024(BallScript self_)
			{
				_0024self__00241219 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241219.exiling)
					{
						_0024self__00241219.exiling = true;
						_0024self__00241219.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00241219.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00241219.GetComponent<NetworkView>().viewID);
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

		internal BallScript _0024self__00241220;

		public _0024Exile_00241218(BallScript self_)
		{
			_0024self__00241220 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241220);
		}
	}

	public bool isLeft;

	public bool isTwo;

	private int dir;

	private int speed;

	private Transform t;

	private bool exiling;

	public BallScript()
	{
		speed = 10;
	}

	public virtual void Awake()
	{
		if (Network.isServer)
		{
			t = transform;
			dir = UnityEngine.Random.Range(-1, 2);
			if (isLeft)
			{
				speed = 4;
			}
			else
			{
				speed = -4;
			}
			if (isTwo)
			{
				speed *= UnityEngine.Random.Range(2, 5);
			}
			else
			{
				speed *= UnityEngine.Random.Range(1, 4);
			}
			StartCoroutine_Auto(Die());
		}
	}

	public virtual IEnumerator Die()
	{
		return new _0024Die_00241215(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (Network.isServer)
		{
			if (dir == -1)
			{
				t.Translate(Vector3.up * 3f * Time.deltaTime);
			}
			else if (dir == 1)
			{
				t.Translate(Vector3.up * -3f * Time.deltaTime);
			}
			t.Translate(Vector3.left * speed * Time.deltaTime);
		}
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241218(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
