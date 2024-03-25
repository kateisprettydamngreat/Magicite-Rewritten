using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Mino : EnemyScript
{
    public virtual IEnumerator ChargeRight()
    {
        if (!charging && Network.isServer)
        {
            charging = true;
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
            GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
            yield return new WaitForSeconds(1f);
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
            spdd = 12;
            running = true;
            yield return new WaitForSeconds(1.5f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            charging = false;
            running = false;
        }
    }
    public virtual IEnumerator ChargeLeft()
    {
        if (!charging && Network.isServer)
        {
            charging = true;
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
            GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
            yield return new WaitForSeconds(1f);
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
            spdd = -12;
            running = true;
            yield return new WaitForSeconds(1.5f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            charging = false;
            running = false;
        }
    }

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	private bool running;

	public Mino()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["r"].speed = 2f;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 20, 15, 15 };
		SetStats(85, 7, 0, 40, 10f, array, UnityEngine.Random.Range(6, 20), 40);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		r1U.origin = transform.position;
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		r2U.direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.5f, mask2) && e.transform.rotation.y == 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 1.5f, mask2) && e.transform.rotation.y != 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
			spdd *= -1;
		}
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 15f) && !knocking)
		{
			if (!(player.transform.position.x <= t.position.x))
			{
				StartCoroutine_Auto(ChargeRight());
			}
			else
			{
				StartCoroutine_Auto(ChargeLeft());
			}
		}
		if (charging && !knocking && running)
		{
			int num = spdd;
			Vector3 velocity = r.velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (r.velocity = velocity);
		}
	}

	[RPC]
	public virtual void Turn(int a)
	{
		if (a == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion quaternion2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion quaternion4 = (e.transform.rotation = rotation2);
		}
	}

	[RPC]
	public virtual void ATK()
	{
		@base.GetComponent<Animation>().Play("r");
	}

	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}

	[RPC]
	public virtual void ROAR()
	{
		@base.GetComponent<Animation>().Play("a");
	}
}
