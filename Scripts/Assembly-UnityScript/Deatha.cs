using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Deatha : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241127 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Deatha _0024self__00241128;

			public _0024(Deatha self_)
			{
				_0024self__00241128 = self_;
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
					Network.Destroy(_0024self__00241128.GetComponent<NetworkView>().viewID);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Deatha _0024self__00241129;

		public _0024Start_00241127(Deatha self_)
		{
			_0024self__00241129 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241129);
		}
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241127(this).GetEnumerator();
	}

	}