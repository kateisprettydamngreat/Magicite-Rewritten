using System;
using UnityEngine;

[Serializable]
public class OreSpiderTrig : MonoBehaviour
{
	public GameObject parent;

	private OreSpider wasp;

	public virtual void Awake()
	{
		wasp = (OreSpider)parent.GetComponent("OreSpider");
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
