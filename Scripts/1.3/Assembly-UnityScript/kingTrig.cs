using System;
using UnityEngine;

[Serializable]
public class kingTrig : MonoBehaviour
{
	public GameObject parent;

	private king wasp;

	public override void Awake()
	{
		wasp = (king)(object)parent.GetComponent("king");
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
