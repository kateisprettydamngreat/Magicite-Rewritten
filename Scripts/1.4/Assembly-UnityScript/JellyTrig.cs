using System;
using UnityEngine;

[Serializable]
public class JellyTrig : MonoBehaviour
{
	public GameObject parent;

	private Jelly wasp;

	public override void Awake()
	{
		wasp = (Jelly)(object)parent.GetComponent("Jelly");
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
