using System;
using UnityEngine;

[Serializable]
public class skelredTrig : MonoBehaviour
{
	public GameObject parent;

	private skelred wasp;

	public virtual void Awake()
	{
		wasp = (skelred)parent.GetComponent("skelred");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}