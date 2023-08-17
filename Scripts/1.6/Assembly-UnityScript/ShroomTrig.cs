using System;
using UnityEngine;

[Serializable]
public class ShroomTrig : MonoBehaviour
{
	public GameObject parent;

	private ShroomMage wasp;

	public override void Awake()
	{
		wasp = (ShroomMage)(object)parent.GetComponent("ShroomMage");
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			((Component)wasp).SendMessage("Set", (object)((Component)c).gameObject);
		}
	}

	public override void Main()
	{
	}
}
