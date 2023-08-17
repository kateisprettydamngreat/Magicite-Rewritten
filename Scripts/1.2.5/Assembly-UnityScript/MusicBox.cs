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
	internal sealed class _0024SetMusic_00242133 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242134;

			internal int _0024a_00242135;

			internal MusicBox _0024self__00242136;

			public _0024(int a, MusicBox self_)
			{
				_0024a_00242135 = a;
				_0024self__00242136 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a2: Expected O, but got Unknown
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Expected O, but got Unknown
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024a_00242135 == 99)
					{
						_0024num_00242134 = Random.Range(10, 13);
						_0024self__00242136.curTune = (AudioClip)Resources.Load("tune/" + (object)_0024num_00242134);
					}
					else
					{
						_0024self__00242136.curBiome = _0024a_00242135;
						_0024self__00242136.curTune = (AudioClip)Resources.Load("tune/" + (object)_0024self__00242136.curBiome);
					}
					((Component)_0024self__00242136).audio.clip = _0024self__00242136.curTune;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					((Component)_0024self__00242136).audio.Play();
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242137;

		internal MusicBox _0024self__00242138;

		public _0024SetMusic_00242133(int a, MusicBox self_)
		{
			_0024a_00242137 = a;
			_0024self__00242138 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242137, _0024self__00242138);
		}
	}

	private int curBiome;

	public AudioClip curTune;

	private bool dood;

	public override void Start()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		if (Network.isServer)
		{
			if (GameScript.isTown)
			{
				int num = Random.Range(10, 13);
				curTune = (AudioClip)Resources.Load("tune/" + (object)num);
			}
			else
			{
				curBiome = GameScript.curBiome;
				curTune = (AudioClip)Resources.Load("tune/" + (object)curBiome);
			}
			((Component)this).audio.clip = curTune;
		}
	}

	public override IEnumerator SetMusic(int a)
	{
		return new _0024SetMusic_00242133(a, this).GetEnumerator();
	}

	public override void Update()
	{
		if (MenuScript.multiplayer > 0)
		{
			if (PlayerControllerN.isBoss)
			{
				SetBoss();
			}
		}
		else if (PlayerController.isBoss)
		{
			SetBoss();
		}
	}

	public override void SetBoss()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (!dood)
		{
			dood = true;
			((Component)this).audio.Stop();
			curTune = (AudioClip)Resources.Load("tune/boss1");
			((Component)this).audio.clip = curTune;
			((Component)this).audio.Play();
		}
	}

	public override void Main()
	{
	}
}
