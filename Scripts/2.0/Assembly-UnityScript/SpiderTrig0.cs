using System;
using UnityEngine;

[Serializable]
public class SpiderTrig0 : MonoBehaviour
{
	public GameObject parent;

	private Spider wasp;

	public virtual void Awake()
	{
		wasp = (Spider)parent.GetComponent("Spider");
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
