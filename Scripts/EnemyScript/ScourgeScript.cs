using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ScourgeScript : EnemyScript
{
    public virtual IEnumerator Attack()
    {
        curVector = player.transform.position - t.position;
        if (player.transform.position.x <= t.position.x)
        {
            e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else
        {
            e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        atking = true;
        yield return new WaitForSeconds(2f);
        atking = false;
    }

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	public ScourgeScript()
	{
		speed = 8f;
	}

	public override void Awake()
	{
		GetComponent<AudioSource>().PlayOneShot(scourge1);
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(10, 8, 1, 3, 2f, array, UnityEngine.Random.Range(2, 6), 2);
		player = GameObject.Find("player(Clone)");
		MonoBehaviour.print(player.transform.position.x);
		StartCoroutine_Auto(Attack());
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 13)
		{
			MonoBehaviour.print("hit");
			c.gameObject.SendMessage("TD", ATK);
		}
		else if (c.gameObject.layer == 18)
		{
			TD(1);
		}
	}

	public override void Update()
	{
		if (atking)
		{
			t.Translate(curVector.normalized * speed * Time.deltaTime);
		}
	}

	public override void K(bool l)
	{
		GetComponent<NetworkView>().RPC("KN", RPCMode.All, l);
	}
}
