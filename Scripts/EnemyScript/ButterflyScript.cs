using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ButterflyScript : EnemyScript
{
    public virtual IEnumerator Summon()
    {
        GameObject g = null;
        while (true)
        {
            if (atking && player && canFire)
            {
                g = (GameObject)Network.Instantiate(Resources.Load("haz/butterflyF"), transform.position, Quaternion.identity, 0);
                g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, player.transform.position);
            }
            yield return new WaitForSeconds(0.8f);
        }
    }
    public virtual IEnumerator Attack()
    {
        yield return new WaitForSeconds(1f);

        if (player)
        {
            curVector = player.transform.position - t.position;
            if (player.transform.position.x > t.position.x)
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

	public ButterflyScript()
	{
		speed = 7f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(105, 5, 0, 50, 10f, array, UnityEngine.Random.Range(6, 20), 50);
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
			if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 40f) && !knocking)
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

}
