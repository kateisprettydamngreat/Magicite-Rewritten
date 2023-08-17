using System;
using UnityEngine;

[Serializable]
public class BigYetiTrig : MonoBehaviour
{
	public GameObject parent;

	private BigYeti wasp;

	public override void Awake()
	{
		wasp = (BigYeti)(object)parent.GetComponent("BigYeti");
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
