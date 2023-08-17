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
	internal sealed class _0024Start_00242716 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241024_00242717;

			internal Vector2 _0024_00241025_00242718;

			internal float _0024_00241026_00242719;

			internal Vector2 _0024_00241027_00242720;

			internal bWScript _0024self__00242721;

			public _0024(bWScript self_)
			{
				_0024self__00242721 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0114: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0147: Unknown result type (might be due to invalid IL or missing references)
				//IL_014c: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_015e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0168: Expected O, but got Unknown
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242721.r = ((Component)_0024self__00242721).renderer;
					goto case 3;
				case 3:
				{
					float num3 = (_0024_00241024_00242717 = _0024self__00242721.r.material.mainTextureOffset.x + 0.5f);
					Vector2 val4 = (_0024_00241025_00242718 = _0024self__00242721.r.material.mainTextureOffset);
					float num4 = (_0024_00241025_00242718.x = _0024_00241024_00242717);
					Vector2 val6 = (_0024self__00242721.r.material.mainTextureOffset = _0024_00241025_00242718);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					float num = (_0024_00241026_00242719 = _0024self__00242721.r.material.mainTextureOffset.x - 0.5f);
					Vector2 val = (_0024_00241027_00242720 = _0024self__00242721.r.material.mainTextureOffset);
					float num2 = (_0024_00241027_00242720.x = _0024_00241026_00242719);
					Vector2 val3 = (_0024self__00242721.r.material.mainTextureOffset = _0024_00241027_00242720);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bWScript _0024self__00242722;

		public _0024Start_00242716(bWScript self_)
		{
			_0024self__00242722 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242722);
		}
	}

	private Renderer r;

	public override IEnumerator Start()
	{
		return new _0024Start_00242716(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
