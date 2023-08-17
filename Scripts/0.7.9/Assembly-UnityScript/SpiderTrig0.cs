using System;
using UnityEngine;

[Serializable]
public class SpiderTrig0 : MonoBehaviour
{
	public GameObject parent;

	private Spider wasp;

	public override void Awake()
	{
		wasp = (Spider)(object)parent.GetComponent("Spider");
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
