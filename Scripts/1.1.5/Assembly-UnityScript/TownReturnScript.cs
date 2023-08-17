using System;
using UnityEngine;

[Serializable]
public class TownReturnScript : MonoBehaviour
{
	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			Application.LoadLevel(1);
		}
	}

	public override void Main()
	{
	}
}
