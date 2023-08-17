using System;
using UnityEngine;

[Serializable]
public class BlueWormTrig : MonoBehaviour
{
	public GameObject parent;

	private BlueWorm wasp;

	public virtual void Awake()
	{
		wasp = (BlueWorm)parent.GetComponent("BlueWorm");
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
