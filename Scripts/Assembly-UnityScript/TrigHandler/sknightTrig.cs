using System;
using UnityEngine;

[Serializable]
public class sknightTrig : MonoBehaviour
{
	public GameObject parent;

	private sKnight wasp;

	public virtual void Awake()
	{
		wasp = (sKnight)parent.GetComponent("sKnight");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
