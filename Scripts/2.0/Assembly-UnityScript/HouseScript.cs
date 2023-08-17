using System;
using UnityEngine;

[Serializable]
public class HouseScript : MonoBehaviour
{
	[RPC]
	public virtual void Initialize(NetworkViewID id)
	{
		GetComponent<NetworkView>().viewID = id;
	}

	public virtual void Main()
	{
	}
}
