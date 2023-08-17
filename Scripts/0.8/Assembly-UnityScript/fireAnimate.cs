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
	internal sealed class _0024Start_00242998 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241129_00242999;

			internal Vector2 _0024_00241130_00243000;

			internal fireAnimate _0024self__00243001;

			public _0024(fireAnimate self_)
			{
				_0024self__00243001 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					float num = (_0024_00241129_00242999 = _0024self__00243001.r.material.mainTextureOffset.x + 0.25f);
					Vector2 val = (_0024_00241130_00243000 = _0024self__00243001.r.material.mainTextureOffset);
					float num2 = (_0024_00241130_00243000.x = _0024_00241129_00242999);
					Vector2 val3 = (_0024self__00243001.r.material.mainTextureOffset = _0024_00241130_00243000);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal fireAnimate _0024self__00243002;

		public _0024Start_00242998(fireAnimate self_)
		{
			_0024self__00243002 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243002);
		}
	}

	private Renderer r;

	public override void Awake()
	{
		r = ((Component)this).renderer;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242998(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
