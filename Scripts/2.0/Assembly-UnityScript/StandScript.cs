using System;
using UnityEngine;

[Serializable]
public class StandScript : MonoBehaviour
{
	private Ray ray;

	private RaycastHit hit;

	private bool relocated;

	public virtual void Awake()
	{
		ray.origin = transform.position;
		ray.direction = Vector3.down;
		if (!Physics.Raycast(ray, out hit, 2.1f))
		{
			gameObject.SetActive(value: false);
		}
	}

	[RPC]
	public virtual void Exile()
	{
		gameObject.transform.position = new Vector3(0f, -500f, -500f);
	}

	[RPC]
	public virtual void Disabled()
	{
		if ((bool)gameObject)
		{
			gameObject.SetActive(value: false);
		}
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 29 || (c.gameObject.layer == 11 && Network.isServer && !relocated))
		{
			relocated = true;
			GetComponent<NetworkView>().RPC("SA", RPCMode.All);
		}
	}

	[RPC]
	public virtual void SA()
	{
		gameObject.transform.position = new Vector3(0f, -500f, -500f);
	}

	public virtual void Main()
	{
	}
}
