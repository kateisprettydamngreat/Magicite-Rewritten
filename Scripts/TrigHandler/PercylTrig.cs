using System;
using UnityEngine;

[Serializable]
public class PercylTrig : MonoBehaviour
{
	public GameObject parent;

	private Percyl wasp;

	public virtual void Awake()
	{
		wasp = (Percyl)parent.GetComponent("Percyl");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}