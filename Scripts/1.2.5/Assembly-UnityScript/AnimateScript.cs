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
	internal sealed class _0024Start_00241275 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_0024406_00241276;

			internal Vector2 _0024_0024407_00241277;

			internal AnimateScript _0024self__00241278;

			public _0024(AnimateScript self_)
			{
				_0024self__00241278 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_0107: Unknown result type (might be due to invalid IL or missing references)
				//IL_010c: Unknown result type (might be due to invalid IL or missing references)
				//IL_010d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0114: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024self__00241278.isWisp)
					{
						((MonoBehaviour)_0024self__00241278).StartCoroutine_Auto(_0024self__00241278.Die());
					}
					_0024self__00241278.r = _0024self__00241278.@base.renderer;
					goto case 2;
				case 2:
				{
					_0024self__00241278.lightObj.light.intensity = 0.5f * (float)Random.Range(_0024self__00241278.min, _0024self__00241278.max);
					float num = (_0024_0024406_00241276 = _0024self__00241278.r.material.mainTextureOffset.x + 0.25f);
					Vector2 val = (_0024_0024407_00241277 = _0024self__00241278.r.material.mainTextureOffset);
					float num2 = (_0024_0024407_00241277.x = _0024_0024406_00241276);
					Vector2 val3 = (_0024self__00241278.r.material.mainTextureOffset = _0024_0024407_00241277);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00241278.wait)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal AnimateScript _0024self__00241279;

		public _0024Start_00241275(AnimateScript self_)
		{
			_0024self__00241279 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241279);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00241280 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal AnimateScript _0024self__00241281;

			public _0024(AnimateScript self_)
			{
				_0024self__00241281 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Expected O, but got Unknown
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						Network.RemoveRPCs(((Component)_0024self__00241281).networkView.viewID);
						Network.Destroy(((Component)_0024self__00241281).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241281).gameObject);
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal AnimateScript _0024self__00241282;

		public _0024Die_00241280(AnimateScript self_)
		{
			_0024self__00241282 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241282);
		}
	}

	public bool isWisp;

	public GameObject @base;

	private Renderer r;

	public GameObject lightObj;

	public int min;

	public int max;

	public float wait;

	public override IEnumerator Start()
	{
		return new _0024Start_00241275(this).GetEnumerator();
	}

	public override IEnumerator Die()
	{
		return new _0024Die_00241280(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
