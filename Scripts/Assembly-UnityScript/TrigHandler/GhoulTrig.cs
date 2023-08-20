using System;
using UnityEngine;

[Serializable]
public class GhoulTrig : MonoBehaviour
{
	public GameObject parent;

	private GhoulScript wasp;

	public virtual void Awake()
	{
		wasp = (GhoulScript)parent.GetComponent("GhoulScript");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}