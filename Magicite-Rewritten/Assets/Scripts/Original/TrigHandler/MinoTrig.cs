using System;
using UnityEngine;

[Serializable]
public class MinoTrig : MonoBehaviour
{
	public GameObject parent;

	private Mino wasp;

	public virtual void Awake()
	{
		wasp = (Mino)parent.GetComponent("Mino");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}