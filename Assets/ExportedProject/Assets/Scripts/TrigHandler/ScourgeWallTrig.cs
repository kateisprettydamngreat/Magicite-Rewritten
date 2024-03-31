using System;
using UnityEngine;

[Serializable]
public class ScourgeWallTrig : MonoBehaviour
{
	public GameObject parent;

	private ScourgeWall wasp;

	public virtual void Awake()
	{
		wasp = (ScourgeWall)parent.GetComponent("ScourgeWall");
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			wasp.SendMessage("SetPlayer", c.gameObject);
		}
	}

	}