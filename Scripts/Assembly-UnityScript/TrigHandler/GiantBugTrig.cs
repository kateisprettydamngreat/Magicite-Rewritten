using System;
using UnityEngine;

[Serializable]
public class GiantBugTrig : MonoBehaviour
{
	public GameObject parent;

	private GiantBug wasp;

	public virtual void Awake()
	{
		wasp = (GiantBug)parent.GetComponent("GiantBug");
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
