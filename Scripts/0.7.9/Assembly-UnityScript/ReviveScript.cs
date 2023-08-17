using System;
using UnityEngine;

[Serializable]
public class ReviveScript : MonoBehaviour
{
	public GameObject player;

	public override void HELP()
	{
		player.SendMessage("HELP");
	}

	public override void Main()
	{
	}
}
