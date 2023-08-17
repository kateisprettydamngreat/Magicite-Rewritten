using System;
using UnityEngine;

[Serializable]
public class ButterflyTrig : MonoBehaviour
{
	public GameObject parent;

	private ButterflyScript wasp;

	public override void Awake()
	{
		wasp = (ButterflyScript)(object)parent.GetComponent("ButterflyScript");
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
