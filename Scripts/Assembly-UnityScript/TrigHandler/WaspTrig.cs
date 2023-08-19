using System;
using UnityEngine;

[Serializable]
public class WaspTrig : MonoBehaviour
{
	public GameObject parent;

	private WaspScript wasp;

	public virtual void Awake()
	{
		wasp = (WaspScript)parent.GetComponent("WaspScript");
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
