using System;
using UnityEngine;

[Serializable]
public class fQueenTrig : MonoBehaviour
{
	public GameObject parent;

	private fQueen wasp;

	public override void Awake()
	{
		wasp = (fQueen)(object)parent.GetComponent("fQueen");
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
