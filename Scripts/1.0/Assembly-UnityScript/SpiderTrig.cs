using System;
using UnityEngine;

[Serializable]
public class SpiderTrig : MonoBehaviour
{
	public GameObject parent;

	private SpiderGrass wasp;

	public override void Awake()
	{
		wasp = (SpiderGrass)(object)parent.GetComponent("SpiderGrass");
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
