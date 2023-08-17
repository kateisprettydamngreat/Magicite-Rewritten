using System;
using UnityEngine;

[Serializable]
public class mimicTrig : MonoBehaviour
{
	public GameObject parent;

	private mimicScript wasp;

	public virtual void Awake()
	{
		wasp = (mimicScript)parent.GetComponent("mimicScript");
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
