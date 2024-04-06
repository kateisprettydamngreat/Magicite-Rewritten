using System;
using UnityEngine;

[Serializable]
public class ScourgeKnightTrig : MonoBehaviour
{
	public GameObject parent;

	private ScourgeKnightScript wasp;

	public virtual void Awake()
	{
		wasp = (ScourgeKnightScript)parent.GetComponent("ScourgeKnightScript");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}