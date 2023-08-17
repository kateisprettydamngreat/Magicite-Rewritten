using System;
using UnityEngine;

[Serializable]
public class CoinTrigger : MonoBehaviour
{
	public GameObject Parent;

	public override void Start()
	{
	}

	public override void Die()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer > 0)
		{
			Network.RemoveRPCs(Parent.networkView.viewID);
			Network.Destroy(Parent.networkView.viewID);
		}
		else
		{
			Object.Destroy((Object)(object)Parent.gameObject);
		}
	}

	public override void Main()
	{
	}
}
