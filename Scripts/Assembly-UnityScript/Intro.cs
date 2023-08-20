using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Intro : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241913 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Intro _0024self__00241914;

			public _0024(Intro self_)
			{
				_0024self__00241914 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241914.logo.SetActive(value: true);
					_0024self__00241914.GetComponent<AudioSource>().PlayOneShot(_0024self__00241914.audioLogo);
					result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					Application.LoadLevel(1);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Intro _0024self__00241915;

		public _0024Start_00241913(Intro self_)
		{
			_0024self__00241915 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241915);
		}
	}

	public GameObject logo;

	public AudioClip audioLogo;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241913(this).GetEnumerator();
	}

	}