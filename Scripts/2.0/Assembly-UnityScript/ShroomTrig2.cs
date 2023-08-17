using System;
using UnityEngine;

[Serializable]
public class ShroomTrig2 : MonoBehaviour
{
	public GameObject parent;

	private Shroom wasp;

	public virtual void Awake()
	{
		wasp = (Shroom)parent.GetComponent("Shroom");
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
