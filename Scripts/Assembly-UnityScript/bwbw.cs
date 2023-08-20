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
	internal sealed class _0024Anim_00242990 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241125_00242991;

			internal Vector2 _0024_00241126_00242992;

			internal bwbw _0024self__00242993;

			public _0024(bwbw self_)
			{
				_0024self__00242993 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					float num = (_0024_00241125_00242991 = _0024self__00242993.r.material.mainTextureOffset.x + 0.5f);
					Vector2 vector = (_0024_00241126_00242992 = _0024self__00242993.r.material.mainTextureOffset);
					float num2 = (_0024_00241126_00242992.x = _0024_00241125_00242991);
					Vector2 vector3 = (_0024self__00242993.r.material.mainTextureOffset = _0024_00241126_00242992);
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

		internal bwbw _0024self__00242994;

		public _0024Anim_00242990(bwbw self_)
		{
			_0024self__00242994 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242994);
		}
	}

	private Renderer r;

	public virtual void OnEnable()
	{
		r = gameObject.GetComponent<Renderer>();
		StartCoroutine_Auto(Anim());
	}

	public virtual IEnumerator Anim()
	{
		return new _0024Anim_00242990(this).GetEnumerator();
	}

	}