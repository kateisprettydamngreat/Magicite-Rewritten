using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class octopus : EnemyScript
{
    public virtual IEnumerator GoCrazy()
    {
        int x = UnityEngine.Random.Range(-5, 5);
        int y = UnityEngine.Random.Range(-5, 5);
        crazyVec = new Vector3(x, y, 0f);
        crazy = true;
        yield return new WaitForSeconds(1f);
        crazy = false;
    }

    public virtual IEnumerator Attack()
    {
        yield return new WaitForSeconds(0.5f);

        if ((bool)player && Network.isServer)
        {
            curVector = player.transform.position - t.position;
            if (!(player.transform.position.x <= t.position.x))
            {
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
            }
            else
            {
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
            }
            atking = true;
            yield return new WaitForSeconds(0.7f);
        }

        atking = false;
        GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
    }

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool crazy;

	private Vector3 crazyVec;

	public octopus()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		if (Network.isServer)
		{
			StartCoroutine(GoCrazy());
		}
		@base.GetComponent<Animation>()["i"].speed = 0.6f;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(25, 2, 0, 8, 10f, array, UnityEngine.Random.Range(5, 15), 8);
		StartCoroutine(Attack());
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer && atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 10f) && !knocking)
		{
			GetComponent<Rigidbody>().velocity = curVector.normalized * speed;
		}
		if (crazy && Network.isServer)
		{
			GetComponent<Rigidbody>().velocity = curVector.normalized * 20f;
		}
	}

	[RPC]
	public virtual void Turn(int a)
	{
		if (a == 0)
		{
			e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
		}
		else
		{
			e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
		}
	}
}
