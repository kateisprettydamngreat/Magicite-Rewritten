using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ScourgeKnightScript : EnemyScript
{
    public virtual IEnumerator Attack(Vector3 pp)
    {
        int noo = UnityEngine.Random.Range(0, 4);
        if (noo == 0)
        {
            ATKING = true;
            GetComponent<NetworkView>().RPC("J", RPCMode.All);
            r.velocity = new Vector3(r.velocity.x, 26, r.velocity.z);
            int n = UnityEngine.Random.Range(0, 2);
            if (n != 0)
            {
                r.velocity = new Vector3(-13, r.velocity.y, r.velocity.z);
            }
            else
            {
                r.velocity = new Vector3(13, r.velocity.y, r.velocity.z);
            }
            yield return new WaitForSeconds(1.5f);
            ATKING = false;
        }
        else
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
            yield return new WaitForSeconds(0.3f);
            GetComponent<NetworkView>().RPC("A1", RPCMode.All);
            yield return new WaitForSeconds(0.4f);
            if (player != null)
            {
                GameObject g = (GameObject)Network.Instantiate(Resources.Load("haz/scourgeFire"), transform.position, Quaternion.identity, 0);
                g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, player.transform.position);
            }
            yield return new WaitForSeconds(1.8f);
            ATKING = false;
        }
    }

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

	private bool initialized;

	public ScourgeKnightScript()
	{
		mask = 256;
		mask2 = 2048;
	}

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["j"].layer = 2;
		@base.GetComponent<Animation>()["a"].speed = 1.7f;
		@base.GetComponent<Animation>()["j"].speed = 0.5f;
		int[] array = new int[3] { 15, 15, 15 };
		SetStats(200, 3, 2, 15, 2f, array, UnityEngine.Random.Range(10, 25), 15);
	}

	public override void Update()
	{
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !ATKING && Network.isServer)
		{
			StartCoroutine(Attack(player.transform.position));
		}
	}

	[RPC]
	public virtual void A1()
	{
		@base.GetComponent<Animation>().Play("a");
	}

	[RPC]
	public virtual void J()
	{
		@base.GetComponent<Animation>().Play("j");
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

	[RPC]
	public virtual void I()
	{
		@base.SetActive(value: true);
	}

	public virtual void SetPlayer(GameObject p)
	{
		if (!initialized)
		{
			initialized = true;
			@base.SetActive(value: true);
			if (Network.isServer)
			{
				GetComponent<NetworkView>().RPC("I", RPCMode.All);
			}
		}
		player = p;
	}
}
