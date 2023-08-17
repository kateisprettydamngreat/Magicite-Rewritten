using System;
using UnityEngine;

[Serializable]
public class TownReturnScript : MonoBehaviour
{
	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			Application.LoadLevel(0);
		}
	}

	public virtual void Main()
	{
	}
}
