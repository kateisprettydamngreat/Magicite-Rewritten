using System;
using UnityEngine;

[Serializable]
public class commanderTrig : MonoBehaviour
{
	public GameObject parent;

	private commander wasp;

	public override void Awake()
	{
		wasp = (commander)(object)parent.GetComponent("commander");
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
