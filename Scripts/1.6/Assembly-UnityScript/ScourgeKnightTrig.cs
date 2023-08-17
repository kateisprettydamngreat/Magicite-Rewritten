using System;
using UnityEngine;

[Serializable]
public class ScourgeKnightTrig : MonoBehaviour
{
	public GameObject parent;

	private ScourgeKnightScript wasp;

	public override void Awake()
	{
		wasp = (ScourgeKnightScript)(object)parent.GetComponent("ScourgeKnightScript");
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
