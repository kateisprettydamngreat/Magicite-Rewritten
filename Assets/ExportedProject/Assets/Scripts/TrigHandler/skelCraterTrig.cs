using System;
using UnityEngine;

[Serializable]
public class skelCraterTrig : MonoBehaviour
{
	public GameObject parent;

	private skelCrater wasp;

	public virtual void Awake()
	{
		wasp = (skelCrater)parent.GetComponent("skelCrater");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}