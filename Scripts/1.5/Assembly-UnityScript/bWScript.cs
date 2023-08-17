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
	internal sealed class _0024Start_00243085 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241138_00243086;

			internal Vector2 _0024_00241139_00243087;

			internal float _0024_00241140_00243088;

			internal Vector2 _0024_00241141_00243089;

			internal bWScript _0024self__00243090;

			public _0024(bWScript self_)
			{
				_0024self__00243090 = self_;
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
					_0024self__00243090.r = ((Component)_0024self__00243090).renderer;
					goto case 3;
				case 3:
				{
					float num3 = (_0024_00241138_00243086 = _0024self__00243090.r.material.mainTextureOffset.x + 0.5f);
					Vector2 val4 = (_0024_00241139_00243087 = _0024self__00243090.r.material.mainTextureOffset);
					float num4 = (_0024_00241139_00243087.x = _0024_00241138_00243086);
					Vector2 val6 = (_0024self__00243090.r.material.mainTextureOffset = _0024_00241139_00243087);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					float num = (_0024_00241140_00243088 = _0024self__00243090.r.material.mainTextureOffset.x - 0.5f);
					Vector2 val = (_0024_00241141_00243089 = _0024self__00243090.r.material.mainTextureOffset);
					float num2 = (_0024_00241141_00243089.x = _0024_00241140_00243088);
					Vector2 val3 = (_0024self__00243090.r.material.mainTextureOffset = _0024_00241141_00243089);
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

		internal bWScript _0024self__00243091;

		public _0024Start_00243085(bWScript self_)
		{
			_0024self__00243091 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243091);
		}
	}

	private Renderer r;

	public override IEnumerator Start()
	{
		return new _0024Start_00243085(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
