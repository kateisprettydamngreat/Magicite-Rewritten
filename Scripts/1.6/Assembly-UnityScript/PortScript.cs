using System;
using UnityEngine;

[Serializable]
public class PortScript : MonoBehaviour
{
	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			((Component)c).SendMessage("OpenMenu", (object)0);
		}
	}

	public override void Main()
	{
	}
}
