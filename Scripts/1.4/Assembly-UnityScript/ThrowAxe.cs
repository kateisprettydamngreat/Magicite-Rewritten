using System;
using UnityEngine;

[Serializable]
public class ThrowAxe : MonoBehaviour
{
	private int dmg;

	private Transform t;

	public override void Awake()
	{
		t = ((Component)this).transform;
	}

	public override void Set(int a)
	{
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("SetN", (RPCMode)6, new object[1] { a });
		}
		else
		{
			dmg = a;
		}
	}

	[RPC]
	public override void SetN(int a)
	{
		dmg = a;
	}

	public override void OnTriggerEnter(Collider c)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 12)
		{
			((Component)c).gameObject.SendMessage("TD", (object)dmg);
			if (!(((Component)c).gameObject.transform.position.x <= t.position.x))
			{
				((Component)c).gameObject.SendMessage("K", (object)false);
			}
			else
			{
				((Component)c).gameObject.SendMessage("K", (object)true);
			}
		}
		else if (((Component)c).gameObject.layer == 8 && MenuScript.pvp == 1)
		{
			if (!((Component)this).networkView.isMine)
			{
				((Component)c).gameObject.SendMessage("TD", (object)dmg);
			}
		}
		else if (((Component)c).gameObject.layer == 11)
		{
			if (MenuScript.multiplayer > 0)
			{
				Network.RemoveRPCs(((Component)this).networkView.viewID);
				Network.Destroy(((Component)this).networkView.viewID);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
		}
	}

	public override void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		t.Translate(Vector3.left * -12f * Time.deltaTime);
	}

	public override void Main()
	{
	}
}
