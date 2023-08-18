using System;
using UnityEngine;

[Serializable]
public class HazTrig : MonoBehaviour
{
	public bool negatePlayerDamage;

	public bool canDMG;

	public int dmg;

	public bool ice;

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8 && !negatePlayerDamage)
		{
			if (ice)
			{
				if (MenuScript.pvp == 1)
				{
					MonoBehaviour.print("hit dmg: " + dmg);
					c.gameObject.SendMessage("TD", dmg);
				}
			}
			else
			{
				c.gameObject.SendMessage("TD", dmg);
			}
		}
		else if (c.gameObject.layer == 9 || c.gameObject.layer == 12)
		{
			c.gameObject.SendMessage("Knock22", gameObject.transform.position, SendMessageOptions.DontRequireReceiver);
			if (canDMG)
			{
				c.gameObject.SendMessage("TD", dmg);
			}
		}
	}

	[RPC]
	public virtual void SetH(int a)
	{
		if (a < 1)
		{
			a = 1;
		}
		dmg = a;
		GetComponent<Collider>().isTrigger = true;
		GetComponent<Collider>().enabled = true;
		gameObject.layer = 0;
	}

	[RPC]
	public virtual void SetHH(int a)
	{
		if (GetComponent<NetworkView>().isMine)
		{
			if (a < 1)
			{
				a = 1;
			}
			dmg = a;
			GetComponent<Collider>().isTrigger = true;
			GetComponent<Collider>().enabled = true;
			gameObject.layer = 0;
		}
		else if (MenuScript.pvp == 1)
		{
			GetComponent<Collider>().enabled = true;
		}
		else
		{
			GetComponent<Collider>().enabled = false;
		}
	}

	public virtual void Main()
	{
	}
}
