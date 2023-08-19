using System;
using UnityEngine;

[Serializable]
public class BigYetiTrig : MonoBehaviour
{
	public GameObject parent;

	private BigYeti wasp;

	public virtual void Awake()
	{
		wasp = (BigYeti)parent.GetComponent("BigYeti");
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
