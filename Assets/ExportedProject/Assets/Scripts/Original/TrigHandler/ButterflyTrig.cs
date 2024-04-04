using System;
using UnityEngine;

[Serializable]
public class ButterflyTrig : MonoBehaviour
{
	public GameObject parent;

	private ButterflyScript wasp;

	public virtual void Awake()
	{
		wasp = (ButterflyScript)parent.GetComponent("ButterflyScript");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}