using System;
using UnityEngine;

[Serializable]
public class IceKnightTrig : MonoBehaviour
{
	public GameObject parent;

	private IceKnight wasp;

	public virtual void Awake()
	{
		wasp = (IceKnight)parent.GetComponent("IceKnight");
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
