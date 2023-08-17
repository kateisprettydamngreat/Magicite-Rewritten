using System;
using UnityEngine;

[Serializable]
public class djinTrig : MonoBehaviour
{
	public GameObject parent;

	private djin wasp;

	public override void Awake()
	{
		wasp = (djin)(object)parent.GetComponent("djin");
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
