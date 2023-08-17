using System;
using UnityEngine;

[Serializable]
public class sknightTrig : MonoBehaviour
{
	public GameObject parent;

	private sKnight wasp;

	public override void Awake()
	{
		wasp = (sKnight)(object)parent.GetComponent("sKnight");
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
