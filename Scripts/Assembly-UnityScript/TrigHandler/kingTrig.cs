using System;
using UnityEngine;

[Serializable]
public class kingTrig : MonoBehaviour
{
	public GameObject parent;

	private king wasp;

	public virtual void Awake()
	{
		wasp = (king)parent.GetComponent("king");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
