using System;
using UnityEngine;

[Serializable]
public class fQueenTrig : MonoBehaviour
{
	public GameObject parent;

	private fQueen wasp;

	public virtual void Awake()
	{
		wasp = (fQueen)parent.GetComponent("fQueen");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}