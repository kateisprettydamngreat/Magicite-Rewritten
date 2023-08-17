using System;
using UnityEngine;

[Serializable]
public class golemTrig : MonoBehaviour
{
	public GameObject parent;

	private golem wasp;

	public virtual void Awake()
	{
		wasp = (golem)parent.GetComponent("golem");
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
