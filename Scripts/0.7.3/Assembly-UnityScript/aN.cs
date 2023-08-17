using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class aN : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242603 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_0024999_00242604;

			internal Vector2 _0024_00241000_00242605;

			internal aN _0024self__00242606;

			public _0024(aN self_)
			{
				_0024self__00242606 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ca: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242606.r = _0024self__00242606.@base.renderer;
					goto case 2;
				case 2:
				{
					float num = (_0024_0024999_00242604 = _0024self__00242606.r.material.mainTextureOffset.x + 0.5f);
					Vector2 val = (_0024_00241000_00242605 = _0024self__00242606.r.material.mainTextureOffset);
					float num2 = (_0024_00241000_00242605.x = _0024_0024999_00242604);
					Vector2 val3 = (_0024self__00242606.r.material.mainTextureOffset = _0024_00241000_00242605);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal aN _0024self__00242607;

		public _0024Start_00242603(aN self_)
		{
			_0024self__00242607 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242607);
		}
	}

	public GameObject @base;

	private Renderer r;

	public override IEnumerator Start()
	{
		return new _0024Start_00242603(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
