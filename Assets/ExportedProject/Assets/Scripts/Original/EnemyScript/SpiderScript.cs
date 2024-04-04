using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SpiderScript : EnemyScript
{
    public virtual IEnumerator ChargeRight()
    {
        if (!charging && Network.isServer)
        {
            int num = 15;
            Vector3 velocity = r.velocity;
            velocity.y = num;
            r.velocity = velocity;
            charging = true;
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
            spdd = 5;
            yield return new WaitForSeconds(1f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            charging = false;
        }
    }

    public virtual IEnumerator ChargeLeft()
    {
        if (!charging && Network.isServer)
        {
            int num = 15;
            Vector3 velocity = r.velocity;
            velocity.y = num;
            r.velocity = velocity;
            charging = true;
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
            spdd = -5;
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

	public SpiderScript()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 1;
		int[] array = new int[3] { 23, 0, 10 };
		SetStats(20, 2, 13, 6, 5f, array, UnityEngine.Random.Range(5, 15), 6);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 7f) && !knocking)
		{
			if (!(player.transform.position.x <= t.position.x))
			{
				StartCoroutine(ChargeRight());
			}
			else
			{
				StartCoroutine(ChargeLeft());
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