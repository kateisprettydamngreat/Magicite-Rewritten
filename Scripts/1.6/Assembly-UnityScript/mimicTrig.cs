using System;
using UnityEngine;

[Serializable]
public class mimicTrig : MonoBehaviour
{
	public GameObject parent;

	private mimicScript wasp;

	public override void Awake()
	{
		wasp = (mimicScript)(object)parent.GetComponent("mimicScript");
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
