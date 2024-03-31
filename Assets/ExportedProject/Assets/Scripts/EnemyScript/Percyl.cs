using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Percyl : EnemyScript
{
    public virtual IEnumerator ChargeRight()
    {
        if (!charging && Network.isServer)
        {
            charging = true;
            int num = UnityEngine.Random.Range(0, 3);
            if (num == 0)
            {
                spdd = 0;
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
                GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
                r.velocity = new Vector3(r.velocity.x, 5f, r.velocity.z);
                GetComponent<NetworkView>().RPC("RUN2", RPCMode.All);
                yield return new WaitForSeconds(1f);
                r.velocity = new Vector3(25f, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(0.3f);
                r.velocity = new Vector3(25f, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(0.3f);
                r.velocity = new Vector3(25f, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(0.5f);
                GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
                spdd = 0;
            }
            else
            {
                spdd = 0;
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
                GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
                yield return new WaitForSeconds(0.5f);
                r.velocity = new Vector3(20f, 30f, r.velocity.z);
                yield return new WaitForSeconds(2f);
                spdd = 0;
            }
            yield return new WaitForSeconds(1f);
            charging = false;
        }
    }

    public virtual IEnumerator ChargeLeft()
    {
        if (!charging && Network.isServer)
        {
            charging = true;
            int num = UnityEngine.Random.Range(0, 3);
            if (num == 0)
            {
                spdd = 0;
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
                GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
                r.velocity = new Vector3(r.velocity.x, 5, r.velocity.z);
                GetComponent<NetworkView>().RPC("RUN2", RPCMode.All);
                yield return new WaitForSeconds(1f);
                r.velocity = new Vector3(-25, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(0.3f);
                r.velocity = new Vector3(-25, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(0.3f);
                r.velocity = new Vector3(-25, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(0.5f);
                GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
                spdd = 0;
            }
            else
            {
                spdd = 0;
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
                GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
                yield return new WaitForSeconds(0.5f);
                r.velocity = new Vector3(r.velocity.x, 30, r.velocity.z);
                r.velocity = new Vector3(-20, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(2f);
                spdd = 0;
            }

            yield return new WaitForSeconds(1f);
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

	public Percyl()
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
		SetStats(600, 4, 0, 4, 200f, array, UnityEngine.Random.Range(6, 20), 200);
		@base.GetComponent<Animation>()["r1"].layer = 2;
		@base.GetComponent<Animation>()["r2"].layer = 1;
		@base.GetComponent<Animation>()["i"].layer = 1;
		@base.GetComponent<Animation>()["a"].layer = 2;
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
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !knocking && Network.isServer)
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
		if (charging && knocking)
		{
		}
	}

	[RPC]
	public virtual void Turn(int a)
	{
		if (a == 0)
		{
			int num = 180;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion quaternion2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 0;
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
	public virtual void RUN()
	{
		@base.GetComponent<Animation>().Play("r1");
	}

	[RPC]
	public virtual void RUN2()
	{
		@base.GetComponent<Animation>().Play("r2");
	}

	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}
}
