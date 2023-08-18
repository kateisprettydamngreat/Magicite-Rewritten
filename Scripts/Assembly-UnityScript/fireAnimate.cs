using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class fireAnimate : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242861 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241047_00242862;

			internal Vector2 _0024_00241048_00242863;

			internal fireAnimate _0024self__00242864;

			public _0024(fireAnimate self_)
			{
				_0024self__00242864 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					float num = (_0024_00241047_00242862 = _0024self__00242864.r.material.mainTextureOffset.x + 0.25f);
					Vector2 vector = (_0024_00241048_00242863 = _0024self__00242864.r.material.mainTextureOffset);
					float num2 = (_0024_00241048_00242863.x = _0024_00241047_00242862);
					Vector2 vector3 = (_0024self__00242864.r.material.mainTextureOffset = _0024_00241048_00242863);
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal fireAnimate _0024self__00242865;

		public _0024Start_00242861(fireAnimate self_)
		{
			_0024self__00242865 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242865);
		}
	}

	private Renderer r;

	public virtual void Awake()
	{
		r = GetComponent<Renderer>();
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242861(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
