using System;
using UnityEngine;

[Serializable]
public class InvaderTrig : MonoBehaviour
{
	public GameObject parent;

	private InvaderScript wasp;

	public virtual void Awake()
	{
		wasp = (InvaderScript)parent.GetComponent("InvaderScript");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}