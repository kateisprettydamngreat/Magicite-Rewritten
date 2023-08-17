using System;
using UnityEngine;

[Serializable]
public class golemTrig : MonoBehaviour
{
	public GameObject parent;

	private golem wasp;

	public override void Awake()
	{
		wasp = (golem)(object)parent.GetComponent("golem");
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
