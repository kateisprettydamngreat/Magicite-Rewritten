using System;
using UnityEngine;

[Serializable]
public class skelredTrig : MonoBehaviour
{
	public GameObject parent;

	private skelred wasp;

	public override void Awake()
	{
		wasp = (skelred)(object)parent.GetComponent("skelred");
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
