using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class BlueWorm : EnemyScript
{
    public virtual IEnumerator Action()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(2, 5));

        if (Network.isServer)
        {
            GetComponent<NetworkView>().RPC("A", RPCMode.All);
        }

        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < 6; i++)
        {
            Vector3 pos = new Vector3(t.position.x + (float)UnityEngine.Random.Range(-8, 8), t.position.y + 28f, 0f);
            Network.Instantiate(Resources.Load("rckW"), pos, Quaternion.identity, 0);
            yield return new WaitForSeconds(0.5f);
        }

        yield return new WaitForSeconds(1f);
    }
	private RaycastHit hit;

	private int mask;

	private int spd;

	private bool turning;

	private int mask2;

	private bool ATKING;

	private GameObject player;

	private bool initialized;

	public BlueWorm()
	{
		mask = 256;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["i"].speed = 0.5f;
		@base.GetComponent<Animation>()["i1"].layer = 1;
		@base.GetComponent<Animation>()["i"].speed = 0.5f;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["a"].speed = 0.5f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(100, 6, 2, 0, 2f, array, UnityEngine.Random.Range(10, 25), 10);
	}

	public override void Update()
	{
	}

	public virtual void K()
	{
	}

	public virtual void KN()
	{
	}

	[RPC]
	public virtual void A()
	{
		@base.GetComponent<Animation>().CrossFade("a");
	}

	[RPC]
	public virtual void I()
	{
		@base.GetComponent<Animation>().Play("i1");
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

	public virtual void Set()
	{
		MonoBehaviour.print("SETTT");
		if (!initialized)
		{
			initialized = true;
			@base.SetActive(value: true);
			@base.GetComponent<Animation>().Play("i1");
			if (Network.isServer)
			{
				GetComponent<NetworkView>().RPC("I", RPCMode.All);
			}
			StartCoroutine(Action());
		}
	}

}
