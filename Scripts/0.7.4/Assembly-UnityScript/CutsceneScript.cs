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
	internal sealed class _0024Start_00241240 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CutsceneScript _0024self__00241241;

			public _0024(CutsceneScript self_)
			{
				_0024self__00241241 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Expected O, but got Unknown
				//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Expected O, but got Unknown
				//IL_0147: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Expected O, but got Unknown
				//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Expected O, but got Unknown
				//IL_020e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Expected O, but got Unknown
				//IL_026e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0278: Expected O, but got Unknown
				//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c4: Expected O, but got Unknown
				//IL_0322: Unknown result type (might be due to invalid IL or missing references)
				//IL_032c: Expected O, but got Unknown
				//IL_0386: Unknown result type (might be due to invalid IL or missing references)
				//IL_0390: Expected O, but got Unknown
				//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bd: Expected O, but got Unknown
				//IL_040e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0418: Expected O, but got Unknown
				//IL_0476: Unknown result type (might be due to invalid IL or missing references)
				//IL_0480: Expected O, but got Unknown
				//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_04f8: Expected O, but got Unknown
				//IL_0556: Unknown result type (might be due to invalid IL or missing references)
				//IL_0560: Expected O, but got Unknown
				//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_05c1: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241241.shade.SetActive(true);
					((MonoBehaviour)_0024self__00241241).StartCoroutine_Auto(_0024self__00241241.Write("\"Long ago there was\na time of peace.\""));
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241241.shade.SetActive(false);
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(false);
					_0024self__00241241.txtQuote.text = string.Empty;
					_0024self__00241241.pic1.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(true);
					((MonoBehaviour)_0024self__00241241).StartCoroutine_Auto(_0024self__00241241.Write("\"We lived on the surface,\nfree of danger.\""));
					_0024self__00241241.shade.SetActive(true);
					_0024self__00241241.pic1.SetActive(false);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241241.shade.SetActive(false);
					_0024self__00241241.txtQuote.text = string.Empty;
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(false);
					_0024self__00241241.pic2.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241241.shade.SetActive(true);
					_0024self__00241241.pic2.SetActive(false);
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(true);
					((MonoBehaviour)_0024self__00241241).StartCoroutine_Auto(_0024self__00241241.Write("\"But something happened...\""));
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 6:
					_0024self__00241241.shade.SetActive(false);
					_0024self__00241241.txtQuote.text = string.Empty;
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(false);
					_0024self__00241241.pic1.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 7:
					((MonoBehaviour)_0024self__00241241).StartCoroutine_Auto(_0024self__00241241.ScreenFlash());
					_0024self__00241241.pic1.SetActive(false);
					_0024self__00241241.pic3.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 8:
					_0024self__00241241.shade.SetActive(true);
					_0024self__00241241.pic3.SetActive(false);
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(true);
					((MonoBehaviour)_0024self__00241241).StartCoroutine_Auto(_0024self__00241241.Write("The Scourge was unleashed\nupon the world.\nMany of us died."));
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(9, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 9:
					_0024self__00241241.pic4.SetActive(true);
					_0024self__00241241.txtQuote.text = string.Empty;
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(false);
					_0024self__00241241.shade.SetActive(false);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(10, new WaitForSeconds(2.5f)) ? 1 : 0);
					break;
				case 10:
					_0024self__00241241.hand.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(11, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 11:
					_0024self__00241241.blood.SetActive(true);
					_0024self__00241241.woman1.animation.Play("d");
					_0024self__00241241.child1.animation.Play("d");
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(12, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 12:
					_0024self__00241241.pic4.SetActive(false);
					_0024self__00241241.shade.SetActive(true);
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(true);
					((MonoBehaviour)_0024self__00241241).StartCoroutine_Auto(_0024self__00241241.Write("\"The rest of us sought\nshelter underground.\""));
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(13, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 13:
					_0024self__00241241.shade.SetActive(false);
					_0024self__00241241.pic5.SetActive(true);
					_0024self__00241241.txtQuote.text = string.Empty;
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(false);
					((MonoBehaviour)_0024self__00241241).StartCoroutine_Auto(_0024self__00241241.ShadowPeople());
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(14, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 14:
					_0024self__00241241.pic5.SetActive(false);
					_0024self__00241241.shade.SetActive(true);
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(true);
					((MonoBehaviour)_0024self__00241241).StartCoroutine_Auto(_0024self__00241241.Write("\"But amidst all of this chaos,\nWe found hope...\""));
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(15, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 15:
					_0024self__00241241.txtQuote.text = string.Empty;
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(false);
					_0024self__00241241.shade.SetActive(false);
					_0024self__00241241.pic6.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(16, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 16:
					_0024self__00241241.pic6.SetActive(false);
					_0024self__00241241.shade.SetActive(true);
					((Component)_0024self__00241241.txtQuote).gameObject.SetActive(true);
					_0024self__00241241.txtQuote.text = "...Magicite.";
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal CutsceneScript _0024self__00241242;

		public _0024Start_00241240(CutsceneScript self_)
		{
			_0024self__00241242 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241242);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShadowPeople_00241243 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CutsceneScript _0024self__00241244;

			public _0024(CutsceneScript self_)
			{
				_0024self__00241244 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_0041: Expected O, but got Unknown
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241244.shadeP[0].animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241244.shadeP[1].animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241244.shadeP[2].animation.Play();
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal CutsceneScript _0024self__00241245;

		public _0024ShadowPeople_00241243(CutsceneScript self_)
		{
			_0024self__00241245 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241245);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ScreenFlash_00241246 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CutsceneScript _0024self__00241247;

			public _0024(CutsceneScript self_)
			{
				_0024self__00241247 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0039: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241247.flash.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241247.flash.SetActive(false);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal CutsceneScript _0024self__00241248;

		public _0024ScreenFlash_00241246(CutsceneScript self_)
		{
			_0024self__00241248 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241248);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Write_00241249 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241250;

			internal string _0024s_00241251;

			internal CutsceneScript _0024self__00241252;

			public _0024(string s, CutsceneScript self_)
			{
				_0024s_00241251 = s;
				_0024self__00241252 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_0090: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241250 = default(int);
					_0024self__00241252.txtQuote.text = string.Empty;
					_0024i_00241250 = 0;
					goto IL_00a3;
				case 2:
					_0024i_00241250++;
					goto IL_00a3;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a3:
					if (_0024i_00241250 < _0024s_00241251.Length)
					{
						_0024self__00241252.txtQuote.text = _0024self__00241252.txtQuote.text + (object)_0024s_00241251[_0024i_00241250];
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.01f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024s_00241253;

		internal CutsceneScript _0024self__00241254;

		public _0024Write_00241249(string s, CutsceneScript self_)
		{
			_0024s_00241253 = s;
			_0024self__00241254 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024s_00241253, _0024self__00241254);
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
		shadeP = (GameObject[])(object)new GameObject[3];
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241240(this).GetEnumerator();
	}

	public override IEnumerator ShadowPeople()
	{
		return new _0024ShadowPeople_00241243(this).GetEnumerator();
	}

	public override IEnumerator ScreenFlash()
	{
		return new _0024ScreenFlash_00241246(this).GetEnumerator();
	}

	public override IEnumerator Write(string s)
	{
		return new _0024Write_00241249(s, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
