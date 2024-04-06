using System;
using UnityEngine;

[Serializable]
public class ChangeScript : MonoBehaviour
{
	public virtual void OnTriggerEnter(Collider c)
	{
		Application.LoadLevel(2);
	}
}