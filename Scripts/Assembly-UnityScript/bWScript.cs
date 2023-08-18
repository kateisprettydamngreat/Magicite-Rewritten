using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class bWScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242799 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241015_00242800;

			internal Vector2 _0024_00241016_00242801;

			internal float _0024_00241017_00242802;

			internal Vector2 _0024_00241018_00242803;

			internal bWScript _0024self__00242804;

			public _0024(bWScript self_)
			{
				_0024self__00242804 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242804.r = _0024self__00242804.GetComponent<Renderer>();
					goto case 3;
				case 3:
				{
					float num3 = (_0024_00241015_00242800 = _0024self__00242804.r.material.mainTextureOffset.x + 0.5f);
					Vector2 vector4 = (_0024_00241016_00242801 = _0024self__00242804.r.material.mainTextureOffset);
					float num4 = (_0024_00241016_00242801.x = _0024_00241015_00242800);
					Vector2 vector6 = (_0024self__00242804.r.material.mainTextureOffset = _0024_00241016_00242801);
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					float num = (_0024_00241017_00242802 = _0024self__00242804.r.material.mainTextureOffset.x - 0.5f);
					Vector2 vector = (_0024_00241018_00242803 = _0024self__00242804.r.material.mainTextureOffset);
					float num2 = (_0024_00241018_00242803.x = _0024_00241017_00242802);
					Vector2 vector3 = (_0024self__00242804.r.material.mainTextureOffset = _0024_00241018_00242803);
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bWScript _0024self__00242805;

		public _0024Start_00242799(bWScript self_)
		{
			_0024self__00242805 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242805);
		}
	}

	private Renderer r;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242799(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
