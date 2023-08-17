using System;
using UnityEngine;

[Serializable]
public class RemoveRPCScript : MonoBehaviour
{
	public virtual void OnDestroy()
	{
		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
	}

	public virtual void Main()
	{
	}
}
