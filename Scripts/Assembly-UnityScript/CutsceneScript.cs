using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class CutsceneScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241336 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CutsceneScript _0024self__00241337;

			public _0024(CutsceneScript self_)
			{
				_0024self__00241337 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241337.shade.SetActive(value: true);
					_0024self__00241337.StartCoroutine_Auto(_0024self__00241337.Write("\"Long ago there was\na time of peace.\""));
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241337.shade.SetActive(value: false);
					_0024self__00241337.txtQuote.gameObject.SetActive(value: false);
					_0024self__00241337.txtQuote.text = string.Empty;
					_0024self__00241337.pic1.SetActive(value: true);
					result = (Yield(3, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241337.txtQuote.gameObject.SetActive(value: true);
					_0024self__00241337.StartCoroutine_Auto(_0024self__00241337.Write("\"We lived on the surface,\nfree of danger.\""));
					_0024self__00241337.shade.SetActive(value: true);
					_0024self__00241337.pic1.SetActive(value: false);
					result = (Yield(4, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241337.shade.SetActive(value: false);
					_0024self__00241337.txtQuote.text = string.Empty;
					_0024self__00241337.txtQuote.gameObject.SetActive(value: false);
					_0024self__00241337.pic2.SetActive(value: true);
					result = (Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241337.shade.SetActive(value: true);
					_0024self__00241337.pic2.SetActive(value: false);
					_0024self__00241337.txtQuote.gameObject.SetActive(value: true);
					_0024self__00241337.StartCoroutine_Auto(_0024self__00241337.Write("\"But something happened...\""));
					result = (Yield(6, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 6:
					_0024self__00241337.shade.SetActive(value: false);
					_0024self__00241337.txtQuote.text = string.Empty;
					_0024self__00241337.txtQuote.gameObject.SetActive(value: false);
					_0024self__00241337.pic1.SetActive(value: true);
					result = (Yield(7, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 7:
					_0024self__00241337.StartCoroutine_Auto(_0024self__00241337.ScreenFlash());
					_0024self__00241337.pic1.SetActive(value: false);
					_0024self__00241337.pic3.SetActive(value: true);
					result = (Yield(8, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 8:
					_0024self__00241337.shade.SetActive(value: true);
					_0024self__00241337.pic3.SetActive(value: false);
					_0024self__00241337.txtQuote.gameObject.SetActive(value: true);
					_0024self__00241337.StartCoroutine_Auto(_0024self__00241337.Write("The Scourge was unleashed\nupon the world.\nMany of us died."));
					result = (Yield(9, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 9:
					_0024self__00241337.pic4.SetActive(value: true);
					_0024self__00241337.txtQuote.text = string.Empty;
					_0024self__00241337.txtQuote.gameObject.SetActive(value: false);
					_0024self__00241337.shade.SetActive(value: false);
					result = (Yield(10, new WaitForSeconds(2.5f)) ? 1 : 0);
					break;
				case 10:
					_0024self__00241337.hand.GetComponent<Animation>().Play();
					result = (Yield(11, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 11:
					_0024self__00241337.blood.SetActive(value: true);
					_0024self__00241337.woman1.GetComponent<Animation>().Play("d");
					_0024self__00241337.child1.GetComponent<Animation>().Play("d");
					result = (Yield(12, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 12:
					_0024self__00241337.pic4.SetActive(value: false);
					_0024self__00241337.shade.SetActive(value: true);
					_0024self__00241337.txtQuote.gameObject.SetActive(value: true);
					_0024self__00241337.StartCoroutine_Auto(_0024self__00241337.Write("\"The rest of us sought\nshelter underground.\""));
					result = (Yield(13, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 13:
					_0024self__00241337.shade.SetActive(value: false);
					_0024self__00241337.pic5.SetActive(value: true);
					_0024self__00241337.txtQuote.text = string.Empty;
					_0024self__00241337.txtQuote.gameObject.SetActive(value: false);
					_0024self__00241337.StartCoroutine_Auto(_0024self__00241337.ShadowPeople());
					result = (Yield(14, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 14:
					_0024self__00241337.pic5.SetActive(value: false);
					_0024self__00241337.shade.SetActive(value: true);
					_0024self__00241337.txtQuote.gameObject.SetActive(value: true);
					_0024self__00241337.StartCoroutine_Auto(_0024self__00241337.Write("\"But amidst all of this chaos,\nWe found hope...\""));
					result = (Yield(15, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 15:
					_0024self__00241337.txtQuote.text = string.Empty;
					_0024self__00241337.txtQuote.gameObject.SetActive(value: false);
					_0024self__00241337.shade.SetActive(value: false);
					_0024self__00241337.pic6.SetActive(value: true);
					result = (Yield(16, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 16:
					_0024self__00241337.pic6.SetActive(value: false);
					_0024self__00241337.shade.SetActive(value: true);
					_0024self__00241337.txtQuote.gameObject.SetActive(value: true);
					_0024self__00241337.txtQuote.text = "...Magicite.";
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal CutsceneScript _0024self__00241338;

		public _0024Start_00241336(CutsceneScript self_)
		{
			_0024self__00241338 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241338);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShadowPeople_00241339 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CutsceneScript _0024self__00241340;

			public _0024(CutsceneScript self_)
			{
				_0024self__00241340 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241340.shadeP[0].GetComponent<Animation>().Play();
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241340.shadeP[1].GetComponent<Animation>().Play();
					result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241340.shadeP[2].GetComponent<Animation>().Play();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal CutsceneScript _0024self__00241341;

		public _0024ShadowPeople_00241339(CutsceneScript self_)
		{
			_0024self__00241341 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241341);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ScreenFlash_00241342 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CutsceneScript _0024self__00241343;

			public _0024(CutsceneScript self_)
			{
				_0024self__00241343 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241343.flash.SetActive(value: true);
					result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241343.flash.SetActive(value: false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal CutsceneScript _0024self__00241344;

		public _0024ScreenFlash_00241342(CutsceneScript self_)
		{
			_0024self__00241344 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241344);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Write_00241345 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241346;

			internal string _0024s_00241347;

			internal CutsceneScript _0024self__00241348;

			public _0024(string s, CutsceneScript self_)
			{
				_0024s_00241347 = s;
				_0024self__00241348 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00241346 = default(int);
					_0024self__00241348.txtQuote.text = string.Empty;
					_0024i_00241346 = 0;
					goto IL_00a3;
				case 2:
					_0024i_00241346++;
					goto IL_00a3;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a3:
					if (_0024i_00241346 < _0024s_00241347.Length)
					{
						_0024self__00241348.txtQuote.text = _0024self__00241348.txtQuote.text + _0024s_00241347[_0024i_00241346];
						result = (Yield(2, new WaitForSeconds(0.01f)) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024s_00241349;

		internal CutsceneScript _0024self__00241350;

		public _0024Write_00241345(string s, CutsceneScript self_)
		{
			_0024s_00241349 = s;
			_0024self__00241350 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024s_00241349, _0024self__00241350);
		}
	}

	public GameObject[] shadeP;

	public GameObject woman1;

	public GameObject child1;

	public GameObject hand;

	public GameObject blood;

	public GameObject shade;

	public TextMesh txtQuote;

	public GameObject flash;

	public GameObject pic1;

	public GameObject pic2;

	public GameObject pic3;

	public GameObject pic4;

	public GameObject pic5;

	public GameObject pic6;

	public GameObject pic7;

	public CutsceneScript()
	{
		shadeP = new GameObject[3];
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241336(this).GetEnumerator();
	}

	public virtual IEnumerator ShadowPeople()
	{
		return new _0024ShadowPeople_00241339(this).GetEnumerator();
	}

	public virtual IEnumerator ScreenFlash()
	{
		return new _0024ScreenFlash_00241342(this).GetEnumerator();
	}

	public virtual IEnumerator Write(string s)
	{
		return new _0024Write_00241345(s, this).GetEnumerator();
	}

	}