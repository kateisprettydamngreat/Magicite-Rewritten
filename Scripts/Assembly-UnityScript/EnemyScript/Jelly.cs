using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Jelly : EnemyScript
{
    public virtual IEnumerator Summon()
    {
        GameObject g = null;
        while (true)
        {
            if (atking && player && canFire)
            {
                GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
                yield return new WaitForSeconds(0.3f);
                g = (GameObject)Network.Instantiate(Resources.Load("haz/jellyFire"), transform.position, Quaternion.identity, 0);
                g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, player.transform.position);
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    public virtual IEnumerator Attack()
    {
        yield return new WaitForSeconds(1f);
        if ((bool)player)
        {
            curVector = player.transform.position - t.position;
            if (!(player.transform.position.x <= t.position.x))
            {
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else
            {
                e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            atking = true;
            yield return new WaitForSeconds(1f);
        }
        atking = false;
    }
	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool canFire;

	public Jelly()
	{
		speed = 4f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 15, 566 };
		SetStats(50, 1, 0, 7, 10f, array, UnityEngine.Random.Range(6, 20), 8);
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["a"].speed = 0.5f;
		if (Network.isServer)
		{
			StartCoroutine_Auto(Attack());
			StartCoroutine_Auto(Summon());
		}
	}



	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 10f) && !knocking)
			{
				canFire = true;
				GetComponent<Rigidbody>().velocity = curVector.normalized * speed;
			}
			else
			{
				canFire = false;
			}
		}
	}


	[RPC]
	public virtual void ATK()
	{
		@base.GetComponent<Animation>().Play("a");
	}
}
