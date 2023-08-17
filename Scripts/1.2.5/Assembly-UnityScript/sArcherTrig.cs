using System;
using UnityEngine;

[Serializable]
public class sArcherTrig : MonoBehaviour
{
	public GameObject parent;

	private sArcher wasp;

	public override void Awake()
	{
		wasp = (sArcher)(object)parent.GetComponent("sArcher");
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
