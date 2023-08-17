using System;
using UnityEngine;

[Serializable]
public class KnightBlade : MonoBehaviour
{
	private Transform t;

	private int speed;

	private int dmg;

	public KnightBlade()
	{
		speed = 10;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
	}

	public override void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		t.Translate(Vector3.down * Time.deltaTime * (float)speed);
	}

	public override void Set(int a)
	{
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("SetN", (RPCMode)6, new object[1] { dmg });
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
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 12)
		{
			((Component)c).gameObject.SendMessage("TD", (object)dmg);
			if (((Component)c).gameObject.transform.position.x <= t.position.x)
			{
			}
		}
		else if (((Component)c).gameObject.layer == 8 && MenuScript.multiplayer > 0)
		{
			if (!((Component)c).gameObject.networkView.isMine)
			{
				((Component)c).gameObject.SendMessage("TD", (object)dmg);
				if (((Component)c).gameObject.transform.position.x <= t.position.x)
				{
				}
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

	public override void Main()
	{
	}
}
