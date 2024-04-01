using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class BigYeti : EnemyScript
{
    public virtual IEnumerator Check()
    {
        int prevHP = default(int);
        while (true)
        {
            prevHP = HP;
            yield return new WaitForSeconds(2f);
            if (HP < prevHP && Network.isServer)
            {
                int num = UnityEngine.Random.Range(0, 2);
                if (num == 0 && !roaring)
                {
                    roaring = true;
                    GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
                    StartCoroutine(Meteor());
                    yield return new WaitForSeconds(1f);
                    roaring = false;
                }
            }
            yield return new WaitForSeconds(1f);
        }
    }

    public virtual IEnumerator Meteor()
    {
        if (Network.isServer)
        {
            int i = 0;
            atking = true;
            GameObject g = null;
            Vector3 pp2 = Vector3.zero;
            if (e.transform.rotation.y > 0.1f)
            {
                pp2 = new Vector3(1f, 0f, 0f);
            }
            else
            {
                pp2 = new Vector3(-1f, 0f, 0f);
            }
            Debug.Log(e.transform.rotation.y + "is rotation");
            yield return new WaitForSeconds(0.5f);

            g = Network.Instantiate(Resources.Load("haz/yetiSnow"), transform.position, Quaternion.identity, 0) as GameObject;
            g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, pp2);
            pp2.y += 0.25f;
            yield return new WaitForSeconds(0.2f);

            g = Network.Instantiate(Resources.Load("haz/yetiSnow"), transform.position, Quaternion.identity, 0) as GameObject;
            g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, pp2);
            pp2.y -= 0.5f;
            yield return new WaitForSeconds(0.2f);

            g = Network.Instantiate(Resources.Load("haz/yetiSnow"), transform.position, Quaternion.identity, 0) as GameObject;
            g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, pp2);
            yield return new WaitForSeconds(0.4f);

            atking = false;
        }
    }

    public virtual IEnumerator ChargeRight()
    {
        if (!charging && Network.isServer && !atking)
        {
            charging = true;
            yield return new WaitForSeconds(1f);
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
            yield return new WaitForSeconds(0.2f);
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
            spdd = 8;
            yield return new WaitForSeconds(2f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            spdd = 0;
            charging = false;
        }
    }

    public virtual IEnumerator ChargeLeft()
    {
        if (!charging && Network.isServer && !atking)
        {
            charging = true;
            yield return new WaitForSeconds(1f);
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
            yield return new WaitForSeconds(0.2f);
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
            spdd = -8;
            yield return new WaitForSeconds(2f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            spdd = 0;
            charging = false;
        }
    }

	private GameObject player;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private bool roaring;

	private bool atking;

	private Ray r2U;

	public BigYeti()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(150, 4, 0, 40, 10f, array, UnityEngine.Random.Range(6, 20), 40);
		StartCoroutine(Check());
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
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 30f) && !knocking)
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
	}

	[RPC]
	public virtual void ATK()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("r");
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
