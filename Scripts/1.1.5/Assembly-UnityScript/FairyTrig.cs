using System;
using UnityEngine;

[Serializable]
public class FairyTrig : MonoBehaviour
{
	public GameObject parent;

	private Fairy wasp;

	public override void Awake()
	{
		wasp = (Fairy)(object)parent.GetComponent("Fairy");
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
