using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class FallenKnight : EnemyScript
{
    public IEnumerator T()
    {
        if (!turning && !ATKING)
        {
            turning = true;
            if (e.transform.rotation.y != 0f)
            {
                e.transform.rotation = Quaternion.Euler(0f, 0f, e.transform.rotation.z);
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
            }
            else
            {
                e.transform.rotation = Quaternion.Euler(0f, 180f, e.transform.rotation.z);
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
            }
            spd *= -1;
            yield return new WaitForSeconds(1f);
            turning = false;
        }
    }
    IEnumerator Attack(int dir)
    {
        if (!ATKING)
        {
            ATKING = true;
            if (dir == 0)
            {
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
                GetComponent<NetworkView>().RPC("Roar", RPCMode.All);
                yield return new WaitForSeconds(1.2f);
                spd = -10;
                yield return new WaitForSeconds(0.3f);
                spd = 0;
                @base.GetComponent<Animation>().Play("i");
            }
            else
            {
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
                GetComponent<NetworkView>().RPC("Roar", RPCMode.All);
                yield return new WaitForSeconds(1.2f);
                spd = 10;
                yield return new WaitForSeconds(0.3f);
                spd = 0;
                @base.GetComponent<Animation>().Play("i");
            }
            yield return new WaitForSeconds(1f);
            ATKING = false;
        }
    }

	private RaycastHit hit;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private int mask;

	private bool ATKING;

	private int spd;

	private bool turning;

	private int mask2;

	private bool rocking;

	public FallenKnight()
	{
		mask = 256;
		mask2 = 2048;
	}

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["r"].speed = 0.5f;
		@base.GetComponent<Animation>()["a"].speed = 0.2f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(30, 6, 2, 10, 2f, array, UnityEngine.Random.Range(10, 25), 10);
	}

	public override void Update()
	{
		int num = spd;
		Vector3 velocity = r.velocity;
		float num2 = (velocity.x = num);
		Vector3 vector2 = (r.velocity = velocity);
		r1U.origin = transform.position;
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		r2U.direction = Vector3.right;
		r1D.origin = transform.position;
		float y = r1D.origin.y - 1f;
		Vector3 origin = r1D.origin;
		float num3 = (origin.y = y);
		Vector3 vector4 = (r1D.origin = origin);
		r1D.direction = Vector3.left;
		r2D.origin = transform.position;
		float y2 = r2D.origin.y - 1f;
		Vector3 origin2 = r2D.origin;
		float num4 = (origin2.y = y2);
		Vector3 vector6 = (r2D.origin = origin2);
		r2D.direction = Vector3.right;
		if ((Physics.Raycast(r1U, 15f, mask) || (Physics.Raycast(r1D, 15f, mask) && !ATKING)) && Network.isServer && !ATKING)
		{
			StartCoroutine_Auto(Attack(0));
		}
		if ((Physics.Raycast(r2U, 15f, mask) || (Physics.Raycast(r2D, 15f, mask) && !ATKING)) && Network.isServer && !ATKING)
		{
			StartCoroutine_Auto(Attack(1));
		}
		if ((Physics.Raycast(r1U, 3f, mask2) || (Physics.Raycast(r1D, 3f, mask2) && !turning && e.transform.rotation.y == 0f)) && Network.isServer)
		{
			StartCoroutine_Auto(T());
		}
		if ((Physics.Raycast(r2U, 3f, mask2) || (Physics.Raycast(r2D, 3f, mask2) && !turning && e.transform.rotation.y != 0f)) && Network.isServer)
		{
			StartCoroutine_Auto(T());
		}
	}


	[RPC]
	public virtual void I()
	{
		@base.GetComponent<Animation>().Play("i");
	}


	[RPC]
	public virtual void Roar()
	{
		@base.GetComponent<Animation>().Play("a");
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
}
