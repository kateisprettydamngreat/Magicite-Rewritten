using System;
using UnityEngine;

[Serializable]
public class MusicBox : MonoBehaviour
{
	private int curBiome;

	public AudioClip curTune;

	private bool dood;

	public override void Start()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
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
		((Component)this).audio.Play();
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
