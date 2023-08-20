using System;
using UnityEngine;

[Serializable]
public class ShroomTrig : MonoBehaviour
{
	public GameObject parent;

	private ShroomMage wasp;

	public virtual void Awake()
	{
		wasp = (ShroomMage)parent.GetComponent("ShroomMage");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("Set", c.gameObject);
		}
	}

	}