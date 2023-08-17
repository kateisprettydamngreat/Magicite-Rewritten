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
	internal sealed class _0024Start_00241250 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Deatha _0024self__00241251;

			public _0024(Deatha self_)
			{
				_0024self__00241251 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0040: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_0030: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer == 1)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_004a;
				case 2:
					Network.Destroy(((Component)_0024self__00241251).networkView.viewID);
					goto IL_004a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_004a:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Deatha _0024self__00241252;

		public _0024Start_00241250(Deatha self_)
		{
			_0024self__00241252 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241252);
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241250(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
