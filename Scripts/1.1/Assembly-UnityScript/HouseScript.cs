using System;
using UnityEngine;

[Serializable]
public class HouseScript : MonoBehaviour
{
	[RPC]
	public override void Initialize(NetworkViewID id)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).networkView.viewID = id;
	}

	public override void Main()
	{
	}
}
