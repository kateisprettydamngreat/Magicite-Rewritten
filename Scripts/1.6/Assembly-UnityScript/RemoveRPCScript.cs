using System;
using UnityEngine;

[Serializable]
public class RemoveRPCScript : MonoBehaviour
{
	public override void OnDestroy()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Network.RemoveRPCs(((Component)this).networkView.viewID);
	}

	public override void Main()
	{
	}
}
