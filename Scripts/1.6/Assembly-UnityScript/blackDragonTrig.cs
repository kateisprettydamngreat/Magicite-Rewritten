using System;
using UnityEngine;

[Serializable]
public class blackDragonTrig : MonoBehaviour
{
	public GameObject parent;

	private blackDragon wasp;

	public override void Awake()
	{
		wasp = (blackDragon)(object)parent.GetComponent("blackDragon");
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
