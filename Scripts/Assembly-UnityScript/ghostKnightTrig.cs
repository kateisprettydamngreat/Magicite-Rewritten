using System;
using UnityEngine;

[Serializable]
public class ghostKnightTrig : MonoBehaviour
{
	public GameObject parent;

	private GhostKnight wasp;

	public virtual void Awake()
	{
		wasp = (GhostKnight)parent.GetComponent("GhostKnight");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
