using System;
using UnityEngine;

[Serializable]
public class PortScript : MonoBehaviour
{
	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			c.SendMessage("OpenMenu", (object)0);
		}
	}

	public virtual void Main()
	{
	}
}
