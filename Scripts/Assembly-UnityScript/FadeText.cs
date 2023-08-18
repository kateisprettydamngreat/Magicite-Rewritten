using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FadeText : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00241463 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal FadeText _0024self__00241464;

			public _0024(FadeText self_)
			{
				_0024self__00241464 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241464.gameObject.SetActive(value: false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal FadeText _0024self__00241465;

		public _0024Die_00241463(FadeText self_)
		{
			_0024self__00241465 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241465);
		}
	}

	public virtual void OnEnable()
	{
		StartCoroutine_Auto(Die());
	}

	public virtual IEnumerator Die()
	{
		return new _0024Die_00241463(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
