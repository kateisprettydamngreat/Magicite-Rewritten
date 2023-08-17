using System;
using UnityEngine;

[Serializable]
public class TitanTrigger : MonoBehaviour
{
	public bool isWorm;

	public GameObject parent;

	private AbyssalTitan titan;

	private WormScript worm;

	public override void Awake()
	{
		if (isWorm)
		{
			worm = (WormScript)(object)parent.GetComponent("WormScript");
		}
		else
		{
			titan = (AbyssalTitan)(object)parent.GetComponent("AbyssalTitan");
		}
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			if (isWorm)
			{
				((Component)worm).SendMessage("SetPlayer", (object)((Component)c).gameObject);
			}
			else
			{
				((Component)titan).SendMessage("SetPlayer", (object)((Component)c).gameObject);
			}
		}
	}

	public override void Main()
	{
	}
}
