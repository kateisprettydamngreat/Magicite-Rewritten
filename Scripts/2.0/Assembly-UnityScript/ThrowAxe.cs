using System;
using UnityEngine;

[Serializable]
public class ThrowAxe : MonoBehaviour
{
	private int dmg;

	private Transform t;

	public virtual void Awake()
	{
		t = transform;
	}

	public virtual void Set(int a)
	{
		GetComponent<NetworkView>().RPC("SetN", RPCMode.All, a);
	}

	[RPC]
	public virtual void SetN(int a)
	{
		dmg = a;
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 9 || c.gameObject.layer == 12)
		{
			c.gameObject.SendMessage("TD", dmg);
			if (!(c.gameObject.transform.position.x <= t.position.x))
			{
				c.gameObject.SendMessage("K", false);
			}
			else
			{
				c.gameObject.SendMessage("K", true);
			}
		}
		else if (c.gameObject.layer == 8 && MenuScript.pvp == 1)
		{
			if (!GetComponent<NetworkView>().isMine)
			{
				c.gameObject.SendMessage("TD", dmg);
			}
		}
		else if (c.gameObject.layer == 11 && Network.isServer)
		{
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
			Network.Destroy(GetComponent<NetworkView>().viewID);
		}
	}

	public virtual void Update()
	{
		t.Translate(Vector3.left * -12f * Time.deltaTime);
	}

	public virtual void Main()
	{
	}
}
