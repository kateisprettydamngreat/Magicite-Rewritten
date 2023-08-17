using System;
using UnityEngine;

[Serializable]
public class skelCraterTrig : MonoBehaviour
{
	public GameObject parent;

	private skelCrater wasp;

	public override void Awake()
	{
		wasp = (skelCrater)(object)parent.GetComponent("skelCrater");
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
