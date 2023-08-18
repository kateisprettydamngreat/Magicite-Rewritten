using System;
using UnityEngine;

[Serializable]
public class beeHive : MonoBehaviour
{
	public GameObject wasp;

	private int hp;

	public GameObject @base;

	private bool burst;

	public beeHive()
	{
		hp = 12;
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 19 || c.gameObject.layer == 24)
		{
			GetComponent<NetworkView>().RPC("TD", RPCMode.All);
		}
	}

	[RPC]
	public virtual void TD()
	{
		@base.GetComponent<Animation>().Play();
		hp--;
		if (hp % 4 == 0 && Network.isServer)
		{
			Network.Instantiate(wasp, transform.position, Quaternion.identity, 0);
		}
		if (hp > 0)
		{
			return;
		}
		MenuScript.canUnlockHat[9] = 1;
		if (Network.isServer && !burst)
		{
			burst = true;
			int num = default(int);
			for (num = 0; num < 5; num++)
			{
				Network.Instantiate(wasp, new Vector3(transform.position.x + (float)UnityEngine.Random.Range(-2, 3), transform.position.y + (float)UnityEngine.Random.Range(-2, 3), 0f), Quaternion.identity, 0);
			}
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
			Network.Destroy(GetComponent<NetworkView>().viewID);
		}
	}

	public virtual void Main()
	{
	}
}
