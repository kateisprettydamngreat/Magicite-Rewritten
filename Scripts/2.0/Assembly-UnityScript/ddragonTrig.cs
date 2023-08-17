using System;
using UnityEngine;

[Serializable]
public class ddragonTrig : MonoBehaviour
{
	public GameObject parent;

	private ScourgeDragon wasp;

	public virtual void Awake()
	{
		wasp = (ScourgeDragon)parent.GetComponent("ScourgeDragon");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("Set", c.gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
