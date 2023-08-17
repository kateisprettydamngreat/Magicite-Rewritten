using System;
using UnityEngine;

[Serializable]
public class DragonPart : MonoBehaviour
{
	public GameObject parent;

	public override void Start()
	{
	}

	public override void TD(int dmg)
	{
		parent.SendMessage("TD", (object)dmg);
	}

	public override void K()
	{
	}

	public override void KN()
	{
	}

	public override void Main()
	{
	}
}
