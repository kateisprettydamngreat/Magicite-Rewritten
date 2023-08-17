using System;
using UnityEngine;

[Serializable]
public class ddragonTrig : MonoBehaviour
{
	public GameObject parent;

	private ScourgeDragon wasp;

	public override void Awake()
	{
		wasp = (ScourgeDragon)(object)parent.GetComponent("ScourgeDragon");
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
