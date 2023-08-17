using System;
using UnityEngine;

[Serializable]
public class GiantBugTrig : MonoBehaviour
{
	public GameObject parent;

	private GiantBug wasp;

	public override void Awake()
	{
		wasp = (GiantBug)(object)parent.GetComponent("GiantBug");
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
