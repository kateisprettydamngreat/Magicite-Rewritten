using System;
using UnityEngine;

[Serializable]
public class HazTrig : MonoBehaviour
{
	public bool negatePlayerDamage;

	public bool canDMG;

	public int dmg;

	public override void OnTriggerEnter(Collider c)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)c).gameObject.layer == 8 && !negatePlayerDamage)
		{
			bool flag = default(bool);
			if (!(((Component)c).gameObject.transform.position.x <= ((Component)this).transform.position.x))
			{
				((Component)c).gameObject.SendMessage("K", (object)false);
			}
			else
			{
				((Component)c).gameObject.SendMessage("K", (object)true);
			}
			((Component)c).gameObject.SendMessage("TD", (object)dmg);
		}
		else if (((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 12)
		{
			((Component)c).gameObject.SendMessage("Knock22", (object)((Component)this).gameObject.transform.position);
			if (canDMG)
			{
				((Component)c).gameObject.SendMessage("TD", (object)dmg);
			}
		}
	}

	[RPC]
	public override void SetH(int a)
	{
		dmg = a;
		((Component)this).collider.isTrigger = true;
		((Component)this).gameObject.layer = 0;
	}

	public override void Main()
	{
	}
}
