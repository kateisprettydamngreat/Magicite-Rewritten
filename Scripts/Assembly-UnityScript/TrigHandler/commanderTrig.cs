using System;
using UnityEngine;

[Serializable]
public class commanderTrig : MonoBehaviour
{
	public GameObject parent;

	private commander wasp;

	public virtual void Awake()
	{
		wasp = (commander)parent.GetComponent("commander");
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
