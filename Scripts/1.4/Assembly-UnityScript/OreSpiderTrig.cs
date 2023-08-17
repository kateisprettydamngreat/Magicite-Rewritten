using System;
using UnityEngine;

[Serializable]
public class OreSpiderTrig : MonoBehaviour
{
	public GameObject parent;

	private OreSpider wasp;

	public override void Awake()
	{
		wasp = (OreSpider)(object)parent.GetComponent("OreSpider");
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			((Component)wasp).SendMessage("SetPlayer", (object)((Component)c).gameObject);
		}
	}

	public override void Main()
	{
	}
}
