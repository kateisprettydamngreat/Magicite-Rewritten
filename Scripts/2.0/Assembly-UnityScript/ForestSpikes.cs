using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ForestSpikes : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241513 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ForestSpikes _0024self__00241514;

			public _0024(ForestSpikes self_)
			{
				_0024self__00241514 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds((float)UnityEngine.Random.Range(0, 3) * 0.5f)) ? 1 : 0);
					break;
				case 2:
					result = (Yield(3, new WaitForSeconds((float)UnityEngine.Random.Range(0, 5) * 0.5f)) ? 1 : 0);
					break;
				case 3:
					if (Network.isServer)
					{
						_0024self__00241514.GetComponent<NetworkView>().RPC("pl", RPCMode.All);
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

		internal ForestSpikes _0024self__00241515;

		public _0024Start_00241513(ForestSpikes self_)
		{
			_0024self__00241515 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241515);
		}
	}

	public GameObject @base;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241513(this).GetEnumerator();
	}

	[RPC]
	public virtual void pl()
	{
		@base.GetComponent<Animation>().Play();
	}

	public virtual void Main()
	{
	}
}
