using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Shine : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Animate_00242325 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242326;

			internal float _0024_0024878_00242327;

			internal Vector2 _0024_0024879_00242328;

			internal Shine _0024self__00242329;

			public _0024(Shine self_)
			{
				_0024self__00242329 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Expected O, but got Unknown
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242329.r = ((Component)_0024self__00242329).renderer;
					_0024i_00242326 = default(int);
					goto IL_0042;
				case 2:
					_0024i_00242326 = 0;
					goto IL_0113;
				case 3:
					_0024i_00242326++;
					goto IL_0113;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0113:
					if (_0024i_00242326 < 4)
					{
						float num = (_0024_0024878_00242327 = _0024self__00242329.r.material.mainTextureOffset.x + 0.25f);
						Vector2 val = (_0024_0024879_00242328 = _0024self__00242329.r.material.mainTextureOffset);
						float num2 = (_0024_0024879_00242328.x = _0024_0024878_00242327);
						Vector2 val3 = (_0024self__00242329.r.material.mainTextureOffset = _0024_0024879_00242328);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_0042;
					IL_0042:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(2, 6) * 0.4f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Shine _0024self__00242330;

		public _0024Animate_00242325(Shine self_)
		{
			_0024self__00242330 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242330);
		}
	}

	public AudioClip soun;

	public int ra;

	private Renderer r;

	public GameObject g;

	private MenuScript gameScript;

	public int type;

	public override void Awake()
	{
		gameScript = (MenuScript)(object)g.GetComponent("MenuScript");
	}

	public override void OnEnable()
	{
	}

	public override IEnumerator Animate()
	{
		return new _0024Animate_00242325(this).GetEnumerator();
	}

	public override void OnMouseEnter()
	{
		if (type == 0)
		{
			gameScript.SetRace(ra);
		}
		else if (type == 1)
		{
			gameScript.SetHat(ra);
		}
		else
		{
			gameScript.SetComp(ra);
		}
	}

	public override void OnMouseExit()
	{
		gameScript.SetRace(99);
		gameScript.SetHat(99);
		gameScript.SetComp(99);
	}

	public override void Main()
	{
	}
}
