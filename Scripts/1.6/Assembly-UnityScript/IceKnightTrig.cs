using System;
using UnityEngine;

[Serializable]
public class IceKnightTrig : MonoBehaviour
{
	public GameObject parent;

	private IceKnight wasp;

	public override void Awake()
	{
		wasp = (IceKnight)(object)parent.GetComponent("IceKnight");
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
