using System;
using UnityEngine;

[Serializable]
public class BlueWormTrig : MonoBehaviour
{
	public GameObject parent;

	private BlueWorm wasp;

	public override void Awake()
	{
		wasp = (BlueWorm)(object)parent.GetComponent("BlueWorm");
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
