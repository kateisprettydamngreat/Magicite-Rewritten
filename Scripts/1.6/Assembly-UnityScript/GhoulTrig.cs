using System;
using UnityEngine;

[Serializable]
public class GhoulTrig : MonoBehaviour
{
	public GameObject parent;

	private GhoulScript wasp;

	public override void Awake()
	{
		wasp = (GhoulScript)(object)parent.GetComponent("GhoulScript");
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
