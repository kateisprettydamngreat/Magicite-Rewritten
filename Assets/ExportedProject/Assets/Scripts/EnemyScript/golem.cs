using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
//check on this, I don't trust that code.
[Serializable]
public class golem : EnemyScript
{
    public virtual IEnumerator ChargeRight()
    {
        if (!charging && Network.isServer)
        {
            int num = 16;
            Vector3 velocity = r.velocity;
            velocity.y = num;
            r.velocity = velocity;
            charging = true;
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
            spdd = 7;
            yield return new WaitForSeconds(1f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            charging = false;
        }
    }

    public virtual IEnumerator ChargeLeft()
    {
        if (!charging && Network.isServer)
        {
            r.velocity = new Vector3(r.velocity.x, 16, r.velocity.z);
            charging = true;
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
            spdd = -7;
            yield return new WaitForSeconds(1f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            charging = false;
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

	public golem()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 19, 20, 17 };
		SetStats(35, 3, 0, 4, 10f, array, UnityEngine.Random.Range(6, 20), 4);
		@base.GetComponent<Animation>()["a"].speed = 1.7f;
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
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 13f) && !knocking)
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
		if (charging && !knocking)
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
		@base.GetComponent<Animation>().Play("a");
	}

	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}
}
