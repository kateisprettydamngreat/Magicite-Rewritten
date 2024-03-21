using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ChickenKing : EnemyScript
{
    public virtual IEnumerator Jump()
    {
        int a = UnityEngine.Random.Range(0, 3);
        if (a == 0)
        {
            GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/ch"));
        }
        if (charging)
        {
            int num = 35;
            Vector3 velocity = GetComponent<Rigidbody>().velocity;
            velocity.y = num;
            GetComponent<Rigidbody>().velocity = velocity;
        }
        yield return new WaitForSeconds(2.5f);
    }
    public IEnumerator Check()
    {
        int prevHP = default(int);
        while (true)
        {
            prevHP = HP;
            yield return new WaitForSeconds(3f);
            if (HP < prevHP && Network.isServer)
            {
                int num = UnityEngine.Random.Range(0, 3);
                if (num == 0 && !roaring)
                {
                    roaring = true;
                    GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
                    Meteor();
                    yield return new WaitForSeconds(1f);
                    roaring = false;
                }
            }
            yield return new WaitForSeconds(1f);
        }
    }

    public IEnumerator ChargeRight()
    {
        if (!charging && Network.isServer)
        {
            charging = true;
            yield return new WaitForSeconds(1f);
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
            yield return new WaitForSeconds(0.2f);
            GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
            yield return new WaitForSeconds(1.3f);
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
            spdd = 6;
            yield return new WaitForSeconds(3f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            spdd = 0;
            charging = false;
        }
    }
    public virtual IEnumerator ChargeLeft()
    {
        if (!charging && Network.isServer)
        {
            charging = true;
            yield return new WaitForSeconds(1f);
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
            yield return new WaitForSeconds(0.2f);
            GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
            yield return new WaitForSeconds(1.3f);
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
            spdd = -6;
            yield return new WaitForSeconds(3f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            spdd = 0;
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

	private bool roaring;

	private Ray r2U;

	public ChickenKing()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 0;
		@base.GetComponent<Animation>()["a"].speed = 2f;
		@base.GetComponent<Animation>()["i"].speed = 2f;
		StartCoroutine_Auto(Jump());
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 42, 42, 42 };
		SetStats(300, 2, 0, 40, 10f, array, UnityEngine.Random.Range(6, 20), 40);
		StartCoroutine_Auto(Check());
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
		if (Physics.Raycast(r1U, 3f, mask2) && e.transform.rotation.y == 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 3f, mask2) && e.transform.rotation.y != 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
			spdd *= -1;
		}
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 150f) && !knocking)
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
		else
		{
			int num3 = 0;
			Vector3 velocity2 = r.velocity;
			float num4 = (velocity2.x = num3);
			Vector3 vector4 = (r.velocity = velocity2);
		}
		if (roaring)
		{
			int num5 = 0;
			Vector3 velocity3 = r.velocity;
			float num6 = (velocity3.x = num5);
			Vector3 vector6 = (r.velocity = velocity3);
		}
	}


	public virtual void Meteor()
	{
	}


	[RPC]
	public virtual void Turn(int a)
	{
		if ((bool)e)
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
	}

	[RPC]
	public virtual void ROAR()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("a");
		}
		if (Network.isServer)
		{
			int num = 50;
			Vector3 velocity = GetComponent<Rigidbody>().velocity;
			float num2 = (velocity.y = num);
			Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		}
	}

	[RPC]
	public virtual void ATK()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("a");
		}
	}

	[RPC]
	public virtual void SUMMON()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("a");
		}
	}

	[RPC]
	public virtual void IDLE()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("i");
		}
	}
}
