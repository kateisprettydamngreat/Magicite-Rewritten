using System;
using UnityEngine;

[Serializable]
public class GobTrig : MonoBehaviour
{
	public GameObject parent;

	private GobScript wasp;

	public override void Awake()
	{
		wasp = (GobScript)(object)parent.GetComponent("GobScript");
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
