using System;
using UnityEngine;

[Serializable]
public class ChickenKingTrig : MonoBehaviour
{
	public GameObject parent;

	private ChickenKing wasp;

	public virtual void Awake()
	{
		wasp = (ChickenKing)parent.GetComponent("ChickenKing");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}