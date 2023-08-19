using System;
using UnityEngine;

[Serializable]
public class sArcherTrig : MonoBehaviour
{
	public GameObject parent;

	private sArcher wasp;

	public virtual void Awake()
	{
		wasp = (sArcher)parent.GetComponent("sArcher");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("Set", c.gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
