using System;
using UnityEngine;

[Serializable]
public class newBoarTrig : MonoBehaviour
{
	public GameObject parent;

	private newBoar wasp;

	public virtual void Awake()
	{
		wasp = (newBoar)parent.GetComponent("newBoar");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}