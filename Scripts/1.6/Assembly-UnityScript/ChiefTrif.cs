using System;
using UnityEngine;

[Serializable]
public class ChiefTrif : MonoBehaviour
{
	public GameObject parent;

	private Chief wasp;

	public override void Awake()
	{
		wasp = (Chief)(object)parent.GetComponent("Chief");
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			((Component)wasp).SendMessage("Set", (object)((Component)c).gameObject);
		}
	}

	public override void Main()
	{
	}
}
