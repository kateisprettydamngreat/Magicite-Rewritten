using System;
using UnityEngine;

[Serializable]
public class Tyrannoxtrig : MonoBehaviour
{
	public GameObject parent;

	private Tyrannox wasp;

	public virtual void Awake()
	{
		wasp = (Tyrannox)parent.GetComponent("Tyrannox");
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
