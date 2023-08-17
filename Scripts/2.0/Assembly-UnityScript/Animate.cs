using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Animate : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241141 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241142;

			internal float _0024_0024385_00241143;

			internal Vector2 _0024_0024386_00241144;

			internal Animate _0024self__00241145;

			public _0024(Animate self_)
			{
				_0024self__00241145 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241145.r = _0024self__00241145.GetComponent<Renderer>();
					_0024i_00241142 = default(int);
					_0024i_00241142 = 0;
					goto IL_00eb;
				case 2:
					_0024i_00241142++;
					goto IL_00eb;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00eb:
					if (_0024i_00241142 < 3)
					{
						float num = (_0024_0024385_00241143 = _0024self__00241145.r.material.mainTextureOffset.x + 0.25f);
						Vector2 vector = (_0024_0024386_00241144 = _0024self__00241145.r.material.mainTextureOffset);
						float num2 = (_0024_0024386_00241144.x = _0024_0024385_00241143);
						Vector2 vector3 = (_0024self__00241145.r.material.mainTextureOffset = _0024_0024386_00241144);
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					if (!_0024self__00241145.nodestroy)
					{
						UnityEngine.Object.Destroy(_0024self__00241145.gameObject);
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Animate _0024self__00241146;

		public _0024Start_00241141(Animate self_)
		{
			_0024self__00241146 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241146);
		}
	}

	public bool nodestroy;

	private Renderer r;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241141(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
