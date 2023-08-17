using System;
using UnityEngine;

[Serializable]
public class HazTrig : MonoBehaviour
{
	public bool negatePlayerDamage;

	public bool canDMG;

	public int dmg;

	public bool ice;

	public override void OnTriggerEnter(Collider c)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)c).gameObject.layer == 8 && !negatePlayerDamage)
		{
			if (ice)
			{
				if (MenuScript.pvp == 1)
				{
					MonoBehaviour.print((object)("hit dmg: " + (object)dmg));
					((Component)c).gameObject.SendMessage("TD", (object)dmg);
				}
			}
			else
			{
				((Component)c).gameObject.SendMessage("TD", (object)dmg);
			}
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
		if (a < 1)
		{
			a = 1;
		}
		dmg = a;
		((Component)this).collider.isTrigger = true;
		((Component)this).collider.enabled = true;
		((Component)this).gameObject.layer = 0;
	}

	[RPC]
	public override void SetHH(int a)
	{
		if (((Component)this).networkView.isMine)
		{
			if (a < 1)
			{
				a = 1;
			}
			dmg = a;
			((Component)this).collider.isTrigger = true;
			((Component)this).collider.enabled = true;
			((Component)this).gameObject.layer = 0;
		}
		else if (MenuScript.pvp == 1)
		{
			((Component)this).collider.enabled = true;
		}
		else
		{
			((Component)this).collider.enabled = false;
		}
	}

	public override void Main()
	{
	}
}
