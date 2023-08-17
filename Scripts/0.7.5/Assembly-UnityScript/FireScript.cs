using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FireScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241450 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal FireScript _0024self__00241451;

			public _0024(FireScript self_)
			{
				_0024self__00241451 = self_;
			}

			public override bool MoveNext()
			{
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0085: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Expected O, but got Unknown
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					((MonoBehaviour)_0024self__00241451).StartCoroutine_Auto(_0024self__00241451.Animate());
					result = (((MenuScript.multiplayer <= 0) ? ((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(20f)) : ((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(20f))) ? 1 : 0);
					break;
				case 2:
					Network.RemoveRPCs(((Component)_0024self__00241451).networkView.viewID);
					Network.Destroy(((Component)_0024self__00241451).networkView.viewID);
					goto IL_00a4;
				case 3:
					Object.Destroy((Object)(object)((Component)_0024self__00241451).gameObject);
					goto IL_00a4;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a4:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal FireScript _0024self__00241452;

		public _0024Start_00241450(FireScript self_)
		{
			_0024self__00241452 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241452);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Animate_00241453 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241454;

			internal float _0024_0024586_00241455;

			internal Vector2 _0024_0024587_00241456;

			internal FireScript _0024self__00241457;

			public _0024(FireScript self_)
			{
				_0024self__00241457 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0039: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241454 = default(int);
					goto case 2;
				case 2:
				{
					float num = (_0024_0024586_00241455 = _0024self__00241457.r.material.mainTextureOffset.x + 0.25f);
					Vector2 val = (_0024_0024587_00241456 = _0024self__00241457.r.material.mainTextureOffset);
					float num2 = (_0024_0024587_00241456.x = _0024_0024586_00241455);
					Vector2 val3 = (_0024self__00241457.r.material.mainTextureOffset = _0024_0024587_00241456);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal FireScript _0024self__00241458;

		public _0024Animate_00241453(FireScript self_)
		{
			_0024self__00241458 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241458);
		}
	}

	public GameObject @base;

	private Renderer r;

	public override void Awake()
	{
		r = @base.renderer;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241450(this).GetEnumerator();
	}

	public override IEnumerator Animate()
	{
		return new _0024Animate_00241453(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
