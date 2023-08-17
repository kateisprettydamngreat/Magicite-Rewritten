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
	internal sealed class _0024Start_00241119 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241120;

			internal float _0024_0024389_00241121;

			internal Vector2 _0024_0024390_00241122;

			internal Animate _0024self__00241123;

			public _0024(Animate self_)
			{
				_0024self__00241123 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241123.r = ((Component)_0024self__00241123).renderer;
					_0024i_00241120 = default(int);
					_0024i_00241120 = 0;
					goto IL_00eb;
				case 2:
					_0024i_00241120++;
					goto IL_00eb;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00eb:
					if (_0024i_00241120 < 3)
					{
						float num = (_0024_0024389_00241121 = _0024self__00241123.r.material.mainTextureOffset.x + 0.25f);
						Vector2 val = (_0024_0024390_00241122 = _0024self__00241123.r.material.mainTextureOffset);
						float num2 = (_0024_0024390_00241122.x = _0024_0024389_00241121);
						Vector2 val3 = (_0024self__00241123.r.material.mainTextureOffset = _0024_0024390_00241122);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					if (!_0024self__00241123.nodestroy)
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241123).gameObject);
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Animate _0024self__00241124;

		public _0024Start_00241119(Animate self_)
		{
			_0024self__00241124 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241124);
		}
	}

	public bool nodestroy;

	private Renderer r;

	public override IEnumerator Start()
	{
		return new _0024Start_00241119(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
