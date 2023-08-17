using System;
using UnityEngine;

[Serializable]
public class BroodMotherTrig : MonoBehaviour
{
	public GameObject parent;

	private Broodmother wasp;

	public virtual void Awake()
	{
		wasp = (Broodmother)parent.GetComponent("Broodmother");
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
