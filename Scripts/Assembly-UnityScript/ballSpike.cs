using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ballSpike : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242806 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242807;

			internal float _0024_00241019_00242808;

			internal Vector3 _0024_00241020_00242809;

			internal ballSpike _0024self__00242810;

			public _0024(ballSpike self_)
			{
				_0024self__00242810 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242810.t = _0024self__00242810.transform;
					if (Network.isServer)
					{
						float num = (_0024_00241019_00242808 = _0024self__00242810.t.position.y + (float)UnityEngine.Random.Range(0, 5));
						Vector3 vector = (_0024_00241020_00242809 = _0024self__00242810.t.position);
						float num2 = (_0024_00241020_00242809.y = _0024_00241019_00242808);
						Vector3 vector3 = (_0024self__00242810.t.position = _0024_00241020_00242809);
						result = (Yield(2, new WaitForSeconds((float)UnityEngine.Random.Range(0, 5) * 0.1f)) ? 1 : 0);
						break;
					}
					goto IL_0156;
				case 2:
					result = (Yield(3, new WaitForSeconds((float)UnityEngine.Random.Range(0, 5) * 0.1f)) ? 1 : 0);
					break;
				case 3:
					_0024num_00242807 = UnityEngine.Random.Range(0, 2);
					if (_0024num_00242807 == 0)
					{
						_0024self__00242810.GetComponent<NetworkView>().RPC("swing", RPCMode.All, 1);
					}
					else
					{
						_0024self__00242810.GetComponent<NetworkView>().RPC("swing", RPCMode.All, 0);
					}
					goto IL_0156;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0156:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ballSpike _0024self__00242811;

		public _0024Start_00242806(ballSpike self_)
		{
			_0024self__00242811 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242811);
		}
	}

	private Transform t;

	public GameObject @base;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242806(this).GetEnumerator();
	}

	[RPC]
	public virtual void swing(int a)
	{
		if (a == 0)
		{
			@base.GetComponent<Animation>()["swingB"].speed = 1f;
		}
		else
		{
			@base.GetComponent<Animation>()["swingB"].speed = -1f;
		}
		@base.GetComponent<Animation>().Play();
	}

	}