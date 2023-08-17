using System;
using UnityEngine;

[Serializable]
public class PercylTrig : MonoBehaviour
{
	public GameObject parent;

	private Percyl wasp;

	public override void Awake()
	{
		wasp = (Percyl)(object)parent.GetComponent("Percyl");
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
