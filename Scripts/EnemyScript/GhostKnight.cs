using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
//this.dood, really? Seriously? *sigh*
[Serializable]
public class GhostKnight : EnemyScript
{
    public virtual IEnumerator Charge()
    {
        Vector3 dood = default(Vector3);
        this.dood = dood;
        this.dood = this.player.transform.position - this.t.position;
        this.dood.Normalize();
        this.dood.z = 0f;
        int turn = 0;
        if (!(this.player.transform.position.x <= this.t.position.x))
        {
            turn = 1;
        }
        this.GetComponent<NetworkView>().RPC("E", RPCMode.All, turn);
        this.attackCharge = true;
        MonoBehaviour.print("dood is " + this.dood);
        yield return new WaitForSeconds(1f);
        this.attackCharge = false;
        yield return new WaitForSeconds(1f);
        this.charging = false;
    }

	public GameObject ghostSword;

	private GameObject player;

	private bool charging;

	private bool attackCharge;

	private Vector3 dood;

	private GameObject sword1;

	private GameObject sword2;

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 42, 42, 42 };
		SetStats(4000, 5, 0, 250, 10f, array, UnityEngine.Random.Range(6, 20), 40);
		if (Network.isServer)
		{
			sword1 = (GameObject)Network.Instantiate(ghostSword, t.position, Quaternion.identity, 0);
			sword2 = (GameObject)Network.Instantiate(ghostSword, t.position, Quaternion.identity, 0);
			sword1.SendMessage("Set", gameObject);
			sword2.SendMessage("Set", gameObject);
		}
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if (Network.isServer && (bool)player)
		{
			if (!charging)
			{
				charging = true;
				StartCoroutine_Auto(Charge());
			}
			if (attackCharge)
			{
				t.Translate(dood * 13f * Time.deltaTime);
			}
		}
	}


	[RPC]
	public virtual void E(int a)
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
}
