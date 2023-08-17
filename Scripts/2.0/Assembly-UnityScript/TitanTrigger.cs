using System;
using UnityEngine;

[Serializable]
public class TitanTrigger : MonoBehaviour
{
	public bool isWorm;

	public GameObject parent;

	private AbyssalTitan titan;

	private WormScript worm;

	public virtual void Awake()
	{
		if (isWorm)
		{
			worm = (WormScript)parent.GetComponent("WormScript");
		}
		else
		{
			titan = (AbyssalTitan)parent.GetComponent("AbyssalTitan");
		}
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			if (isWorm)
			{
				worm.SendMessage("SetPlayer", c.gameObject);
			}
			else
			{
				titan.SendMessage("SetPlayer", c.gameObject);
			}
		}
	}

	public virtual void Main()
	{
	}
}
