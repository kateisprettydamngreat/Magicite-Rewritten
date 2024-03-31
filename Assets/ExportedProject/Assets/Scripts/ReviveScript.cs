using System;
using UnityEngine;

[Serializable]
public class ReviveScript : MonoBehaviour
{
	public GameObject player;

	public virtual void HELP()
	{
		player.SendMessage("HELP");
	}

	}