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
	internal sealed class _0024Animate_00242419 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242420;

			internal float _0024_0024871_00242421;

			internal Vector2 _0024_0024872_00242422;

			internal Shine _0024self__00242423;

			public _0024(Shine self_)
			{
				_0024self__00242423 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242423.r = _0024self__00242423.GetComponent<Renderer>();
					_0024i_00242420 = default(int);
					goto IL_0042;
				case 2:
					_0024i_00242420 = 0;
					goto IL_0113;
				case 3:
					_0024i_00242420++;
					goto IL_0113;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0113:
					if (_0024i_00242420 < 4)
					{
						float num = (_0024_0024871_00242421 = _0024self__00242423.r.material.mainTextureOffset.x + 0.25f);
						Vector2 vector = (_0024_0024872_00242422 = _0024self__00242423.r.material.mainTextureOffset);
						float num2 = (_0024_0024872_00242422.x = _0024_0024871_00242421);
						Vector2 vector3 = (_0024self__00242423.r.material.mainTextureOffset = _0024_0024872_00242422);
						result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_0042;
					IL_0042:
					result = (Yield(2, new WaitForSeconds((float)UnityEngine.Random.Range(2, 6) * 0.4f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Shine _0024self__00242424;

		public _0024Animate_00242419(Shine self_)
		{
			_0024self__00242424 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242424);
		}
	}

	public AudioClip soun;

	public int ra;

	private Renderer r;

	public GameObject g;

	private MenuScript gameScript;

	public int type;

	public virtual void Awake()
	{
		gameScript = (MenuScript)g.GetComponent("MenuScript");
	}

	public virtual void OnEnable()
	{
	}

	public virtual IEnumerator Animate()
	{
		return new _0024Animate_00242419(this).GetEnumerator();
	}

	public virtual void OnMouseEnter()
	{
		GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/CLICKh", typeof(AudioClip)));
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

	public virtual void OnMouseExit()
	{
		gameScript.SetRace(99);
		gameScript.SetHat(99);
		gameScript.SetComp(99);
	}

	public virtual void Main()
	{
	}
}
