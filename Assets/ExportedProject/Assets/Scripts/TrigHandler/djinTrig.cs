using System;
using UnityEngine;

[Serializable]
public class djinTrig : MonoBehaviour
{
	public GameObject parent;

	private djin wasp;

	public virtual void Awake()
	{
		wasp = (djin)parent.GetComponent("djin");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}