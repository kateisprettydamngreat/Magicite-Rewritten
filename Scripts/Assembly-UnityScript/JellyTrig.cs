using System;
using UnityEngine;

[Serializable]
public class JellyTrig : MonoBehaviour
{
	public GameObject parent;

	private Jelly wasp;

	public virtual void Awake()
	{
		wasp = (Jelly)parent.GetComponent("Jelly");
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
