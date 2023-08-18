using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SnowSpawner : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242572 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242573;

			internal SnowSpawner _0024self__00242574;

			public _0024(SnowSpawner self_)
			{
				_0024self__00242574 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242574.t = _0024self__00242574.transform;
					if (Network.isServer)
					{
						result = (Yield(2, new WaitForSeconds((float)UnityEngine.Random.Range(0, 5) * 0.5f)) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				case 2:
					result = (Yield(3, new WaitForSeconds((float)UnityEngine.Random.Range(0, 5) * 0.5f)) ? 1 : 0);
					break;
				case 3:
				case 4:
					_0024num_00242573 = UnityEngine.Random.Range(0, 2);
					if (_0024num_00242573 == 0)
					{
						Network.Instantiate(Resources.Load("rckS1"), new Vector3(_0024self__00242574.t.position.x, _0024self__00242574.t.position.y + 35f, 0f), Quaternion.identity, 0);
					}
					else
					{
						Network.Instantiate(Resources.Load("rckS"), new Vector3(_0024self__00242574.t.position.x, _0024self__00242574.t.position.y + 35f, 0f), Quaternion.identity, 0);
					}
					result = (Yield(4, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnowSpawner _0024self__00242575;

		public _0024Start_00242572(SnowSpawner self_)
		{
			_0024self__00242575 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242575);
		}
	}

	private Transform t;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242572(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
