using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Destro : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241441 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Destro _0024self__00241442;

			public _0024(Destro self_)
			{
				_0024self__00241442 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0039: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer == 1)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00241442.wait)) ? 1 : 0);
						break;
					}
					goto IL_0053;
				case 2:
					Network.Destroy(((Component)_0024self__00241442).networkView.viewID);
					goto IL_0053;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0053:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Destro _0024self__00241443;

		public _0024Start_00241441(Destro self_)
		{
			_0024self__00241443 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241443);
		}
	}

	public float wait;

	public Destro()
	{
		wait = 0.3f;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241441(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
