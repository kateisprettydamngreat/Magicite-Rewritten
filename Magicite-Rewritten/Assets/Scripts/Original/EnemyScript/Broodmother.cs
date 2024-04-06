using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Broodmother : EnemyScript
{
    public virtual IEnumerator UpdateZrotation()
    {
        rotating = true;
        mouse_pos = player.transform.position;
        object_pos = transform.position;
        mouse_pos.z = -20f;
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * 57.29578f;
        t.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        yield return new WaitForSeconds(0.5f);

        atking = true;
        yield return new WaitForSeconds(2f);

        atking = false;
        yield return new WaitForSeconds(0.5f);

        rotating = false;
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

	public Broodmother()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 15, 15, 10 };
		SetStats(400, 3, 13, 150, 5f, array, UnityEngine.Random.Range(5, 15), 150);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			if (atking)
			{
				t.Translate(Vector3.left * Time.deltaTime * -10f);
			}
			if (!rotating)
			{
				StartCoroutine(UpdateZrotation());
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
