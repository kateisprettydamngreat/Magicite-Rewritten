using System;
using UnityEngine;

[Serializable]
public class ChangeScript : MonoBehaviour
{
	public override void OnTriggerEnter(Collider c)
	{
		Application.LoadLevel(2);
	}

	public override void Main()
	{
	}
}
