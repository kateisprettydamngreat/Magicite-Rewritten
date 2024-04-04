using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class WaspScript : EnemyScript
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
        yield return new WaitForSeconds(0.7f);

        if ((bool)player && Network.isServer)
        {
            curVector = player.transform.position - t.position;
            if (!(player.transform.position.x <= t.position.x))
            {
                GetComponent<NetworkView>().RPC("TURN", RPCMode.All, 1);
            }
            else
            {
                GetComponent<NetworkView>().RPC("TURN", RPCMode.All, 0);
            }
            atking = true;
            yield return new WaitForSeconds(1.2f);
        }

        atking = false;
        GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
    }

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip waspSound;

	private bool crazy;

	private Vector3 crazyVec;

	public WaspScript()
	{
		speed = 8f;
	}

	public override void Awake()
	{
		if (Network.isServer)
		{
			StartCoroutine(GoCrazy());
		}
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 18, 20, 19 };
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
			GetComponent<Rigidbody>().velocity = curVector.normalized * speed;
		}
	}

	[RPC]
	public virtual void TURN(int a)
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
