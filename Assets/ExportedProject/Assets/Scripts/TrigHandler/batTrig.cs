using System;
using UnityEngine;

[Serializable]
public class batTrig : MonoBehaviour
{
	public GameObject parent;

	private bat wasp;

	public virtual void Awake()
	{
		wasp = (bat)parent.GetComponent("bat");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}