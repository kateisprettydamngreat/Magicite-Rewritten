using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class AnimateScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241147 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_0024387_00241148;

			internal Vector2 _0024_0024388_00241149;

			internal AnimateScript _0024self__00241150;

			public _0024(AnimateScript self_)
			{
				_0024self__00241150 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00241150.isWisp)
					{
						_0024self__00241150.StartCoroutine_Auto(_0024self__00241150.Die());
					}
					_0024self__00241150.r = _0024self__00241150.@base.GetComponent<Renderer>();
					goto case 2;
				case 2:
				{
					_0024self__00241150.lightObj.GetComponent<Light>().intensity = 0.5f * (float)UnityEngine.Random.Range(_0024self__00241150.min, _0024self__00241150.max);
					float num = (_0024_0024387_00241148 = _0024self__00241150.r.material.mainTextureOffset.x + 0.25f);
					Vector2 vector = (_0024_0024388_00241149 = _0024self__00241150.r.material.mainTextureOffset);
					float num2 = (_0024_0024388_00241149.x = _0024_0024387_00241148);
					Vector2 vector3 = (_0024self__00241150.r.material.mainTextureOffset = _0024_0024388_00241149);
					result = (Yield(2, new WaitForSeconds(_0024self__00241150.wait)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal AnimateScript _0024self__00241151;

		public _0024Start_00241147(AnimateScript self_)
		{
			_0024self__00241151 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241151);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00241152 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal AnimateScript _0024self__00241153;

			public _0024(AnimateScript self_)
			{
				_0024self__00241153 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					UnityEngine.Object.Destroy(_0024self__00241153.gameObject);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal AnimateScript _0024self__00241154;

		public _0024Die_00241152(AnimateScript self_)
		{
			_0024self__00241154 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241154);
		}
	}

	public bool isWisp;

	public GameObject @base;

	private Renderer r;

	public GameObject lightObj;

	public int min;

	public int max;

	public float wait;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241147(this).GetEnumerator();
	}

	public virtual IEnumerator Die()
	{
		return new _0024Die_00241152(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
