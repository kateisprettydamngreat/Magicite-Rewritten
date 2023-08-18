using System;
using UnityEngine;

[Serializable]
public class octopusTrig : MonoBehaviour
{
	public GameObject parent;

	private octopus wasp;

	public virtual void Awake()
	{
		wasp = (octopus)parent.GetComponent("octopus");
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
