using System;
using UnityEngine;

[Serializable]
public class ChickenKingTrig : MonoBehaviour
{
	public GameObject parent;

	private ChickenKing wasp;

	public override void Awake()
	{
		wasp = (ChickenKing)(object)parent.GetComponent("ChickenKing");
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
