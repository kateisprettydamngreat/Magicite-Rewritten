using System;
using UnityEngine;

[Serializable]
public class SpiderTrig : MonoBehaviour
{
	public GameObject parent;

	private SpiderGrass wasp;

	public virtual void Awake()
	{
		wasp = (SpiderGrass)parent.GetComponent("SpiderGrass");
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
