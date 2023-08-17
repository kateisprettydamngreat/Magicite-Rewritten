using System;
using UnityEngine;

[Serializable]
public class WhelpTrig : MonoBehaviour
{
	public GameObject parent;

	private Whelp wasp;

	public virtual void Awake()
	{
		wasp = (Whelp)parent.GetComponent("Whelp");
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
