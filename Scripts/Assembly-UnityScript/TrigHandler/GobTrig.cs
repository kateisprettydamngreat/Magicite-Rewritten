using System;
using UnityEngine;

[Serializable]
public class GobTrig : MonoBehaviour
{
	public GameObject parent;

	private Gob wasp;

	public virtual void Awake()
	{
		wasp = (Gob)parent.GetComponent("Gob");
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
