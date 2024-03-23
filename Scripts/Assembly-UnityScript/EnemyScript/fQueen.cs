using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class fQueen : EnemyScript
{
    public virtual IEnumerator Summon()
    {
        summoned = 0;
        yield return new WaitForSeconds(20f);
        while (true)
        {
            if (Network.isServer)
            {
                if (summoned < 8)
                {
                    summoned++;
                    Network.Instantiate(Resources.Load("e/fairy"), t.position, Quaternion.identity, 0);
                }
            }
            yield return new WaitForSeconds(5f);
        }
    }
    public virtual IEnumerator UpdateZrotation()
    {
        yield return new WaitForSeconds(2f);
        atking = true;
        yield return new WaitForSeconds(1.5f);
        atking = false;
    }

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private float zRotation;

	private bool rotating;

	private Vector3 mouse_pos;

	private Vector3 object_pos;

	private float angle;

	private int summoned;

	public fQueen()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 71, 71, 71 };
		SetStats(850, 4, 13, 350, 5f, array, 20, 350);
		StartCoroutine_Auto(UpdateZrotation());
		StartCoroutine_Auto(Summon());
	}


	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public virtual void FixedUpdate()
	{
		if ((bool)player && atking && Network.isServer)
		{
			if (!(player.transform.position.x + 0.5f <= t.position.x))
			{
				t.Translate(Vector3.left * -5f * Time.deltaTime);
			}
			else if (!(player.transform.position.x - 0.5f >= t.position.x))
			{
				t.Translate(Vector3.left * 5f * Time.deltaTime);
			}
			if (!(player.transform.position.y + 1f <= t.position.y))
			{
				t.Translate(Vector3.up * 4f * Time.deltaTime);
			}
			else if (!(player.transform.position.y - 1f >= t.position.y))
			{
				t.Translate(Vector3.up * -4f * Time.deltaTime);
			}
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
	}

	[RPC]
	public virtual void IDLE()
	{
	}

	public virtual void K()
	{
	}

	public virtual void KN()
	{
	}
}
