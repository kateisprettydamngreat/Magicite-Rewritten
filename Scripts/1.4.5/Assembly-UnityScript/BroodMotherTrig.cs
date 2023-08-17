using System;
using UnityEngine;

[Serializable]
public class BroodMotherTrig : MonoBehaviour
{
	public GameObject parent;

	private Broodmother wasp;

	public override void Awake()
	{
		wasp = (Broodmother)(object)parent.GetComponent("Broodmother");
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
