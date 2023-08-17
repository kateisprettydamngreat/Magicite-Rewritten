using System;
using UnityEngine;

[Serializable]
public class InvaderTrig : MonoBehaviour
{
	public GameObject parent;

	private InvaderScript wasp;

	public override void Awake()
	{
		wasp = (InvaderScript)(object)parent.GetComponent("InvaderScript");
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
