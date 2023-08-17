using System;
using UnityEngine;

[Serializable]
public class ShroomTrig2 : MonoBehaviour
{
	public GameObject parent;

	private Shroom wasp;

	public override void Awake()
	{
		wasp = (Shroom)(object)parent.GetComponent("Shroom");
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
