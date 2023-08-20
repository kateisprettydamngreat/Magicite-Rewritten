using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class blooood : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242828 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal blooood _0024self__00242829;

			public _0024(blooood self_)
			{
				_0024self__00242829 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					Network.RemoveRPCs(_0024self__00242829.GetComponent<NetworkView>().viewID);
					Network.Destroy(_0024self__00242829.GetComponent<NetworkView>().viewID);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal blooood _0024self__00242830;

		public _0024Start_00242828(blooood self_)
		{
			_0024self__00242830 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242830);
		}
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242828(this).GetEnumerator();
	}
}
