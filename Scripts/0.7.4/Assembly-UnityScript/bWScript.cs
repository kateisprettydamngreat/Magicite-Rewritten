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
	internal sealed class _0024Start_00242648 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241001_00242649;

			internal Vector2 _0024_00241002_00242650;

			internal float _0024_00241003_00242651;

			internal Vector2 _0024_00241004_00242652;

			internal bWScript _0024self__00242653;

			public _0024(bWScript self_)
			{
				_0024self__00242653 = self_;
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
					_0024self__00242653.r = ((Component)_0024self__00242653).renderer;
					goto case 3;
				case 3:
				{
					float num3 = (_0024_00241001_00242649 = _0024self__00242653.r.material.mainTextureOffset.x + 0.5f);
					Vector2 val4 = (_0024_00241002_00242650 = _0024self__00242653.r.material.mainTextureOffset);
					float num4 = (_0024_00241002_00242650.x = _0024_00241001_00242649);
					Vector2 val6 = (_0024self__00242653.r.material.mainTextureOffset = _0024_00241002_00242650);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					float num = (_0024_00241003_00242651 = _0024self__00242653.r.material.mainTextureOffset.x - 0.5f);
					Vector2 val = (_0024_00241004_00242652 = _0024self__00242653.r.material.mainTextureOffset);
					float num2 = (_0024_00241004_00242652.x = _0024_00241003_00242651);
					Vector2 val3 = (_0024self__00242653.r.material.mainTextureOffset = _0024_00241004_00242652);
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

		internal bWScript _0024self__00242654;

		public _0024Start_00242648(bWScript self_)
		{
			_0024self__00242654 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242654);
		}
	}

	private Renderer r;

	public override IEnumerator Start()
	{
		return new _0024Start_00242648(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
