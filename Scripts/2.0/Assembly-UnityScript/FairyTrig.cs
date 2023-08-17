using System;
using UnityEngine;

[Serializable]
public class FairyTrig : MonoBehaviour
{
	public GameObject parent;

	private Fairy wasp;

	public virtual void Awake()
	{
		wasp = (Fairy)parent.GetComponent("Fairy");
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
