using System;
using UnityEngine;

[Serializable]
public class MinoTrig : MonoBehaviour
{
	public GameObject parent;

	private Mino wasp;

	public override void Awake()
	{
		wasp = (Mino)(object)parent.GetComponent("Mino");
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
