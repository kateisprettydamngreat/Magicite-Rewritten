using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class king : EnemyScript
{
    public virtual IEnumerator Attack(Vector3 pp)
    {
        ATKING = true;
        atking = false;
        MOVING = false;
        yield return new WaitForSeconds(1f);

        GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
        yield return new WaitForSeconds(0.5f);

        GetComponent<NetworkView>().RPC("ATK2", RPCMode.All);
        if (player)
        {
            Vector3 pp2 = player.transform.position;
            if (Network.isServer)
            {
                GameObject g = null;
                g = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), transform.position, Quaternion.identity, 0);
                g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, pp2);
            }
        }
        yield return new WaitForSeconds(1f);

        if (player && Network.isServer)
        {
            curVector = player.transform.position - t.position;
            if (player.transform.position.x > transform.position.x)
            {
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
            }
            else
            {
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
            }
        }
        MOVING = true;
        yield return new WaitForSeconds(2f);

        ATKING = false;
    }

    public virtual IEnumerator ATK2()
    {
        int i;
        CRAZE = true;
        yield return new WaitForSeconds(0.3f);
        for (i = 0; i < 4; i++)
        {
            swords[i].GetComponent<Collider>().enabled = true;
        }
        yield return new WaitForSeconds(0.4f);
        for (i = 0; i < 4; i++)
        {
            swords[i].GetComponent<Collider>().enabled = false;
        }
        CRAZE = false;
    }

	public AudioClip roar;

	public GameObject[] swords;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private RaycastHit hit;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private int mask;

	private int spd;

	private bool turning;

	private int mask2;

	private bool ATKING;

	private GameObject player;

	private bool atking;

	private bool towards;

	private bool CRAZE;

	private bool MOVING;

	public king()
	{
		swords = new GameObject[4];
		speed = 10f;
		mask = 256;
		mask2 = 2048;
	}

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["i"].speed = 0.7f;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["a"].speed = 1.5f;
		int[] array = new int[3] { 7, 18, 20 };
		SetStats(600, 8, 2, 700, 2f, array, UnityEngine.Random.Range(10, 25), 700);
		float y = transform.position.y + (float)UnityEngine.Random.Range(3, 10);
		Vector3 position = transform.position;
		float num = (position.y = y);
		Vector3 vector2 = (transform.position = position);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
		if ((bool)player)
		{
			curVector = player.transform.position - t.position;
			if (!(player.transform.position.x <= transform.position.x))
			{
				GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
			}
			else
			{
				GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
			}
		}
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			if (!(Mathf.Abs(player.transform.position.x - t.position.x) >= 50f) && !ATKING)
			{
				StartCoroutine_Auto(Attack(player.transform.position));
			}
			if (MOVING && (bool)player && !knocking && r.isKinematic)
			{
				t.Translate(curVector.normalized * 8f * Time.deltaTime);
			}
			if (CRAZE && (bool)player && !knocking && r.isKinematic)
			{
				t.Translate(curVector.normalized * 2f * Time.deltaTime);
			}
		}
	}


	[RPC]
	public virtual void ATK()
	{
		@base.GetComponent<Animation>().Play("a");
		GetComponent<AudioSource>().PlayOneShot(roar);
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

}
