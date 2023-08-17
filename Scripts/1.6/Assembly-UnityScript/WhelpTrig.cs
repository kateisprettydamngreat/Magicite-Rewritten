using System;
using UnityEngine;

[Serializable]
public class WhelpTrig : MonoBehaviour
{
	public GameObject parent;

	private Whelp wasp;

	public override void Awake()
	{
		wasp = (Whelp)(object)parent.GetComponent("Whelp");
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
