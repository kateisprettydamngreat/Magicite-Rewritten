using System;
using UnityEngine;

[Serializable]
public class ScourgeWallTrig : MonoBehaviour
{
	public GameObject parent;

	private ScourgeWall wasp;

	public override void Awake()
	{
		wasp = (ScourgeWall)(object)parent.GetComponent("ScourgeWall");
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
