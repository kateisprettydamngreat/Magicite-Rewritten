using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class djin : EnemyScript
{
    public virtual IEnumerator Attack(Vector3 pp)
    {
        ATKING = true;
        if (!(pp.x <= transform.position.x))
        {
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
        }
        else
        {
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
        }
        GameObject g = null;
        yield return new WaitForSeconds(0.3f);
        GetComponent<NetworkView>().RPC("A1", RPCMode.All);
        yield return new WaitForSeconds(0.5f);
        if ((bool)player)
        {
            Vector3 pp2 = player.transform.position;
            if (Network.isServer)
            {
                g = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), djinPoint.transform.position, Quaternion.identity, 0);
                g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, pp2);
                yield return new WaitForSeconds(0.3f);
            }
            pp2 = player.transform.position;
            g = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), djinPoint.transform.position, Quaternion.identity, 0);
            g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, pp2);
            yield return new WaitForSeconds(0.3f);
            pp2 = player.transform.position;
            g = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), djinPoint.transform.position, Quaternion.identity, 0);
            g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, pp2);
        }
        if ((bool)player)
        {
            curVector = t.position - player.transform.position;
            if (!(player.transform.position.x <= t.position.x))
            {
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else
            {
                e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
        }
        atking = true;
        yield return new WaitForSeconds(0.5f);
        atking = false;
        if ((bool)player)
        {
            int num = UnityEngine.Random.Range(0, 3);
            if (num == 0)
            {
                curVector = t.position - player.transform.position;
            }
            else
            {
                curVector = player.transform.position - t.position;
            }
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
        yield return new WaitForSeconds(1.5f);
        ATKING = false;
    }

	public GameObject djinPoint;

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

	public djin()
	{
		speed = 10f;
		mask = 256;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(85, 6, 2, 10, 2f, array, UnityEngine.Random.Range(10, 25), 10);
		float y = transform.position.y + (float)UnityEngine.Random.Range(3, 10);
		Vector3 position = transform.position;
		float num = (position.y = y);
		Vector3 vector2 = (transform.position = position);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player)
		{
			if (!(Mathf.Abs(player.transform.position.x - t.position.x) >= 18f) && !ATKING)
			{
				StartCoroutine_Auto(Attack(player.transform.position));
			}
			else if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 10f) && !knocking && r.isKinematic)
			{
				t.Translate(curVector.normalized * 6f * Time.deltaTime);
			}
		}
	}

	[RPC]
	public virtual void A1()
	{
		@base.GetComponent<Animation>().Play("a");
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
