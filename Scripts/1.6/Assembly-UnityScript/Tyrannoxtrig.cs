using System;
using UnityEngine;

[Serializable]
public class Tyrannoxtrig : MonoBehaviour
{
	public GameObject parent;

	private Tyrannox wasp;

	public override void Awake()
	{
		wasp = (Tyrannox)(object)parent.GetComponent("Tyrannox");
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
