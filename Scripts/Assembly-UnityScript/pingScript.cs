using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class pingScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Animate_00242936 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241085_00242937;

			internal Vector2 _0024_00241086_00242938;

			internal pingScript _0024self__00242939;

			public _0024(pingScript self_)
			{
				_0024self__00242939 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242939.r = _0024self__00242939.GetComponent<Renderer>();
					goto case 2;
				case 2:
				{
					float num = (_0024_00241085_00242937 = _0024self__00242939.@base.GetComponent<Renderer>().material.mainTextureOffset.x + 0.5f);
					Vector2 vector = (_0024_00241086_00242938 = _0024self__00242939.@base.GetComponent<Renderer>().material.mainTextureOffset);
					float num2 = (_0024_00241086_00242938.x = _0024_00241085_00242937);
					Vector2 vector3 = (_0024self__00242939.@base.GetComponent<Renderer>().material.mainTextureOffset = _0024_00241086_00242938);
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

		internal pingScript _0024self__00242940;

		public _0024Animate_00242936(pingScript self_)
		{
			_0024self__00242940 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242940);
		}
	}

	public int num;

	public GameObject @base;

	private Renderer r;

	public Material pingGood;

	public Material pingBad;

	public Material pingTrying;

	public virtual void OnEnable()
	{
		GetComponent<Collider>().enabled = true;
		Shit();
	}

	public virtual void Shit()
	{
	}

	public virtual IEnumerator Animate()
	{
		return new _0024Animate_00242936(this).GetEnumerator();
	}

	}