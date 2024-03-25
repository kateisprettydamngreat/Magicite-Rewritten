using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class LavaBison : EnemyScript
{
    public virtual IEnumerator Start()
    {
        base.GetComponent<Animation>()["i"].layer = 0;
        base.GetComponent<Animation>()["a"].layer = 1;
        base.GetComponent<Animation>()["r"].layer = 0;
        int[] drops = new int[3] { 7, 19, 19 };
        SetStats(150, 6, 2, 10, 2f, drops, UnityEngine.Random.Range(10, 25), 10);

        while (true)
        {
            yield return StartCoroutine(MoveCheck());
            yield return StartCoroutine(AttackCheck());
        }
    }

    public virtual IEnumerator AttackCheck()
    {
        if (isMonster)
        {
            Ray ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
            Ray ray2 = new Ray(t.position, new Vector3(-1f, 0f, 0f));
            if (Physics.Raycast(ray, out hit, 20f, 256))
            {
                attacking = true;
                @base.GetComponent<Animation>().Stop();
                @base.GetComponent<Animation>().Play("a");
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                yield return new WaitForSeconds(0.7f);
                @base.GetComponent<Animation>().Play("r");
                atking = true;
                spdd = 16f;
                yield return new WaitForSeconds(1.5f);
                atking = false;
                spdd = 0f;
                @base.GetComponent<Animation>().Play("i");
            }
            else if (Physics.Raycast(ray2, out hit, 20f, 256))
            {
                attacking = true;
                @base.GetComponent<Animation>().Stop();
                @base.GetComponent<Animation>().Play("a");
                e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                yield return new WaitForSeconds(0.7f);
                @base.GetComponent<Animation>().Play("r");
                atking = true;
                spdd = -16f;
                yield return new WaitForSeconds(1.5f);
                atking = false;
                spdd = 0f;
                @base.GetComponent<Animation>().Play("i");
            }
        }
        yield return new WaitForSeconds(0.3f);
        attacking = false;
        r.velocity = new Vector3(0f, r.velocity.y, r.velocity.z);
    }

    public virtual IEnumerator MoveCheck()
    {
        if (isMonster)
        {
            atking = true;
        }
        yield return new WaitForSeconds(0.2f);
        atking = false;
        spdd = 0f;
    }

    private IEnumerator ATK()
    {
        Ray ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
        Ray ray2 = new Ray(t.position, new Vector3(-1f, 0f, 0f));

        if (Physics.Raycast(ray, out hit, 20f, 256))
        {
            attacking = true;
            @base.GetComponent<Animation>().Stop();
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            yield return new WaitForSeconds(0.7f);
            @base.GetComponent<Animation>().Play("r");
            atking = true;
            spdd = 16f;
            yield return new WaitForSeconds(UnityEngine.Random.Range(1, 4));
            atking = false;
            spdd = 0f;
            @base.GetComponent<Animation>().Play("i");
        }
        else if (Physics.Raycast(ray2, out hit, 20f, 256))
        {
            attacking = true;
            @base.GetComponent<Animation>().Stop();
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            yield return new WaitForSeconds(0.7f);
            @base.GetComponent<Animation>().Play("r");
            atking = true;
            spdd = -16f;
            yield return new WaitForSeconds(UnityEngine.Random.Range(1, 4));
            atking = false;
            spdd = 0f;
            @base.GetComponent<Animation>().Play("i");
        }
    }

    public virtual IEnumerator T()
    {
        if (!turning)
        {
            turning = true;
            if (e.transform.rotation.y != 0f)
            {
                e.transform.rotation = Quaternion.Euler(0, 0, 0);
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
            }
            else
            {
                e.transform.rotation = Quaternion.Euler(0, 180, 0);
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
            }
            spdd *= -1f;
            yield return new WaitForSeconds(1f);
            turning = false;
        }
    }

	private RaycastHit hit;

	private float spdd;

	private bool atking;

	private bool isMonster;

	private bool turning;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	public LavaBison()
	{
		mask2 = 2048;
	}

	public override void TD(int dmg)
	{
		if (!takingDamage)
		{
			if (!isMonster)
			{
				isMonster = true;
				gameObject.layer = 9;
			}
			GetComponent<AudioSource>().PlayOneShot(aHit);
			int num = dmg - DEF;
			if (num < 1)
			{
				num = 1;
			}
			GetComponent<NetworkView>().RPC("TDN", RPCMode.All, num);
			GetComponent<NetworkView>().RPC("TDN2", RPCMode.All, num);
		}
	}


	[RPC]
	public virtual void Turn(int dir)
	{
		if (dir == 0)
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

	public override void Update()
	{
		r1U.origin = transform.position;
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		r2U.direction = Vector3.right;
		if (atking && Network.isServer)
		{
			float x = spdd;
			Vector3 velocity = r.velocity;
			float num = (velocity.x = x);
			Vector3 vector2 = (r.velocity = velocity);
		}
		if (Physics.Raycast(r1U, 1.5f, mask2) && !turning && e.transform.rotation.y == 0f && Network.isServer)
		{
			StartCoroutine_Auto(T());
		}
		if (Physics.Raycast(r2U, 1.5f, mask2) && !turning && e.transform.rotation.y != 0f && Network.isServer)
		{
			StartCoroutine_Auto(T());
		}
	}

	public override void Main()
	{
	}
}
