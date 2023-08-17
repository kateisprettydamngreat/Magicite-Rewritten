using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class PoisonParent : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241130 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PoisonParent _0024self__00241131;

			public _0024(PoisonParent self_)
			{
				_0024self__00241131 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241131.exiling)
					{
						_0024self__00241131.exiling = true;
						_0024self__00241131.transform.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00241131.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00241131.GetComponent<NetworkView>().viewID);
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

		internal PoisonParent _0024self__00241132;

		public _0024Exile_00241130(PoisonParent self_)
		{
			_0024self__00241132 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241132);
		}
	}

	private bool exiling;

	public virtual void Start()
	{
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241130(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
