using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class bwbw : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Anim_00243145 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241207_00243146;

			internal Vector2 _0024_00241208_00243147;

			internal bwbw _0024self__00243148;

			public _0024(bwbw self_)
			{
				_0024self__00243148 = self_;
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
					float num = (_0024_00241207_00243146 = _0024self__00243148.r.material.mainTextureOffset.x + 0.5f);
					Vector2 val = (_0024_00241208_00243147 = _0024self__00243148.r.material.mainTextureOffset);
					float num2 = (_0024_00241208_00243147.x = _0024_00241207_00243146);
					Vector2 val3 = (_0024self__00243148.r.material.mainTextureOffset = _0024_00241208_00243147);
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

		internal bwbw _0024self__00243149;

		public _0024Anim_00243145(bwbw self_)
		{
			_0024self__00243149 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243149);
		}
	}

	private Renderer r;

	public override void OnEnable()
	{
		r = ((Component)this).gameObject.renderer;
		((MonoBehaviour)this).StartCoroutine_Auto(Anim());
	}

	public override IEnumerator Anim()
	{
		return new _0024Anim_00243145(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
