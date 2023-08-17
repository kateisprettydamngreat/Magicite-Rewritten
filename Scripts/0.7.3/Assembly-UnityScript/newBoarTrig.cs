using System;
using UnityEngine;

[Serializable]
public class newBoarTrig : MonoBehaviour
{
	public GameObject parent;

	private newBoar wasp;

	public override void Awake()
	{
		wasp = (newBoar)(object)parent.GetComponent("newBoar");
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
