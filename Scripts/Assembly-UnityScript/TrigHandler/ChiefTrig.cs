using System;
using UnityEngine;

[Serializable]
public class ChiefTrig : MonoBehaviour
{
	public GameObject parent;

	private Chief wasp;

	public virtual void Awake()
	{
		wasp = (Chief)parent.GetComponent("Chief");
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
