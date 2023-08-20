using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class MusicBox : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SetMusic_00242025 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242026;

			internal int _0024a_00242027;

			internal MusicBox _0024self__00242028;

			public _0024(int a, MusicBox self_)
			{
				_0024a_00242027 = a;
				_0024self__00242028 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024a_00242027 == 99)
					{
						_0024num_00242026 = UnityEngine.Random.Range(10, 13);
						_0024self__00242028.curTune = (AudioClip)Resources.Load("tune/" + _0024num_00242026);
					}
					else
					{
						_0024self__00242028.curBiome = _0024a_00242027;
						_0024self__00242028.curTune = (AudioClip)Resources.Load("tune/" + _0024self__00242028.curBiome);
					}
					_0024self__00242028.GetComponent<AudioSource>().clip = _0024self__00242028.curTune;
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242028.GetComponent<AudioSource>().Play();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242029;

		internal MusicBox _0024self__00242030;

		public _0024SetMusic_00242025(int a, MusicBox self_)
		{
			_0024a_00242029 = a;
			_0024self__00242030 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00242029, _0024self__00242030);
		}
	}

	private int curBiome;

	public AudioClip curTune;

	private bool dood;

	private AudioClip prevTune;

	public virtual void Start()
	{
		if (Network.isServer)
		{
			if (GameScript.isTown)
			{
				int num = UnityEngine.Random.Range(10, 13);
				curTune = (AudioClip)Resources.Load("tune/" + num);
			}
			else
			{
				curBiome = GameScript.curBiome;
				curTune = (AudioClip)Resources.Load("tune/" + curBiome);
			}
			GetComponent<AudioSource>().clip = curTune;
		}
	}

	public virtual void Victory()
	{
		GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("tune/12");
		GetComponent<AudioSource>().Play();
	}

	public virtual IEnumerator SetMusic(int a)
	{
		return new _0024SetMusic_00242025(a, this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (PlayerControllerN.isBoss)
		{
			SetBoss();
		}
	}

	public virtual void SetNormal()
	{
		GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().clip = prevTune;
		GetComponent<AudioSource>().Play();
	}

	public virtual void SetBoss()
	{
		if (!dood)
		{
			dood = true;
			prevTune = curTune;
			GetComponent<AudioSource>().Stop();
			curTune = (AudioClip)Resources.Load("tune/boss1");
			GetComponent<AudioSource>().clip = curTune;
			GetComponent<AudioSource>().Play();
		}
	}

	}