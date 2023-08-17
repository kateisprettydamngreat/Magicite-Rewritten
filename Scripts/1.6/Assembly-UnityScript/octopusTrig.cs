using System;
using UnityEngine;

[Serializable]
public class octopusTrig : MonoBehaviour
{
	public GameObject parent;

	private octopus wasp;

	public override void Awake()
	{
		wasp = (octopus)(object)parent.GetComponent("octopus");
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
