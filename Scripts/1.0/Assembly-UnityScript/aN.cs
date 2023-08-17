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
	internal sealed class _0024Start_00243140 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241205_00243141;

			internal Vector2 _0024_00241206_00243142;

			internal aN _0024self__00243143;

			public _0024(aN self_)
			{
				_0024self__00243143 = self_;
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
					_0024self__00243143.r = _0024self__00243143.@base.renderer;
					goto case 2;
				case 2:
				{
					float num = (_0024_00241205_00243141 = _0024self__00243143.r.material.mainTextureOffset.x + 0.5f);
					Vector2 val = (_0024_00241206_00243142 = _0024self__00243143.r.material.mainTextureOffset);
					float num2 = (_0024_00241206_00243142.x = _0024_00241205_00243141);
					Vector2 val3 = (_0024self__00243143.r.material.mainTextureOffset = _0024_00241206_00243142);
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

		internal aN _0024self__00243144;

		public _0024Start_00243140(aN self_)
		{
			_0024self__00243144 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243144);
		}
	}

	public GameObject @base;

	private Renderer r;

	public override IEnumerator Start()
	{
		return new _0024Start_00243140(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
