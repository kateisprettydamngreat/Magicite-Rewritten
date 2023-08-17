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
	internal sealed class _0024Start_00241689 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ForestSpikes _0024self__00241690;

			public _0024(ForestSpikes self_)
			{
				_0024self__00241690 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Expected O, but got Unknown
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3) * 0.5f)) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(0, 5) * 0.5f)) ? 1 : 0);
					break;
				case 3:
					if (Network.isServer)
					{
						((Component)_0024self__00241690).networkView.RPC("pl", (RPCMode)6, new object[0]);
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ForestSpikes _0024self__00241691;

		public _0024Start_00241689(ForestSpikes self_)
		{
			_0024self__00241691 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241691);
		}
	}

	public GameObject @base;

	public override IEnumerator Start()
	{
		return new _0024Start_00241689(this).GetEnumerator();
	}

	[RPC]
	public override void pl()
	{
		@base.animation.Play();
	}

	public override void Main()
	{
	}
}
