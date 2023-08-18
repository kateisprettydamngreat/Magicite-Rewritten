using System;
using UnityEngine;

[Serializable]
public class BigSnow : MonoBehaviour
{
	public bool is2;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	private Ray r3;

	private Ray r4;

	private float spd;

	public GameObject @base;

	private Transform t;

	public BigSnow()
	{
		mask2 = 2048;
	}

	public virtual void Awake()
	{
		t = transform;
		if (is2 && Network.isServer)
		{
			float y = t.position.y - 0.5f;
			Vector3 position = t.position;
			float num = (position.y = y);
			Vector3 vector2 = (t.position = position);
		}
	}

	public virtual void Start()
	{
		if (Network.isServer)
		{
			if (UnityEngine.Random.Range(0, 2) == 0)
			{
				GetComponent<NetworkView>().RPC("RollRight", RPCMode.All);
			}
			else
			{
				GetComponent<NetworkView>().RPC("RollLeft", RPCMode.All);
			}
		}
	}

	[RPC]
	public virtual void RollLeft()
	{
		spd = 3f;
		@base.GetComponent<Animation>()["sB"].speed = -1f;
	}

	[RPC]
	public virtual void RollRight()
	{
		spd = -3f;
		@base.GetComponent<Animation>()["sB"].speed = 1f;
	}

	public virtual void Update()
	{
		if (Network.isServer)
		{
			t.Translate(Vector3.left * Time.deltaTime * spd);
			r1U.origin = transform.position;
			r1U.direction = Vector3.left;
			r2U.origin = transform.position;
			r2U.direction = Vector3.right;
			r3.origin = transform.position;
			float x = r3.origin.x + 2f;
			Vector3 origin = r3.origin;
			float num = (origin.x = x);
			Vector3 vector2 = (r3.origin = origin);
			r3.direction = Vector3.down;
			r4.origin = transform.position;
			float x2 = r4.origin.x - 2f;
			Vector3 origin2 = r4.origin;
			float num2 = (origin2.x = x2);
			Vector3 vector4 = (r4.origin = origin2);
			r4.direction = Vector3.down;
			if (Physics.Raycast(r1U, 3f, mask2))
			{
				GetComponent<NetworkView>().RPC("RollRight", RPCMode.All);
			}
			if (Physics.Raycast(r2U, 3f, mask2))
			{
				GetComponent<NetworkView>().RPC("RollLeft", RPCMode.All);
			}
			if (!Physics.Raycast(r3, 1.5f, mask2))
			{
				GetComponent<NetworkView>().RPC("RollLeft", RPCMode.All);
			}
			if (!Physics.Raycast(r4, 1.5f, mask2))
			{
				GetComponent<NetworkView>().RPC("RollRight", RPCMode.All);
			}
		}
	}

	public virtual void Main()
	{
	}
}
