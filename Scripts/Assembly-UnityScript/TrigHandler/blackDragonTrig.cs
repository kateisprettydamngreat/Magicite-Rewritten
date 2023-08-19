using System;
using UnityEngine;

[Serializable]
public class blackDragonTrig : MonoBehaviour
{
	public GameObject parent;

	private blackDragon wasp;

	public virtual void Awake()
	{
		wasp = (blackDragon)parent.GetComponent("blackDragon");
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
