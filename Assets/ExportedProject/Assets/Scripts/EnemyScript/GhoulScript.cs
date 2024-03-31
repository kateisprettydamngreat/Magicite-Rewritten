using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class GhoulScript : EnemyScript
{
    public virtual IEnumerator Summon()
    {
        GameObject g = null;
        while (true)
        {
            if (atking && player && canFire)
            {
                g = (GameObject)Network.Instantiate(Resources.Load("haz/ghoulFire"), transform.position, Quaternion.identity, 0);
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
            yield return new WaitForSeconds(2f);
        }
        atking = false;
    }

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool canFire;

	public GhoulScript()
	{
		speed = 6f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(100, 5, 0, 7, 10f, array, UnityEngine.Random.Range(6, 20), 8);
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
			if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 35f) && !knocking)
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
