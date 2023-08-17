using System;
using UnityEngine;

[Serializable]
public class GobTrig : MonoBehaviour
{
	public GameObject parent;

	private Gob wasp;

	public override void Awake()
	{
		wasp = (Gob)(object)parent.GetComponent("Gob");
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
