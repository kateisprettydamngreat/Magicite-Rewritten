using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ShroomMage : EnemyScript
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

        yield return new WaitForSeconds(0.3f);

        GetComponent<NetworkView>().RPC("A1", RPCMode.All);

        yield return new WaitForSeconds(0.4f);

        if ((bool)player && Network.isServer)
        {
            GameObject g = (GameObject)Network.Instantiate(Resources.Load("haz/shroomFire"), transform.position, Quaternion.identity, 0);
            g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, player.transform.position);
        }

        yield return new WaitForSeconds(1f);

        ATKING = false;
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

	public ShroomMage()
	{
		mask = 256;
		mask2 = 2048;
	}

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 1;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["a1"].layer = 1;
		@base.GetComponent<Animation>()["a1"].speed = 0.5f;
		@base.GetComponent<Animation>()["r"].speed = 0.5f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(46, 6, 2, 10, 2f, array, UnityEngine.Random.Range(10, 25), 10);
	}

	public override void Update()
	{
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 18f) && !ATKING)
		{
			StartCoroutine_Auto(Attack(player.transform.position));
		}
	}

	[RPC]
	public virtual void A1()
	{
		@base.GetComponent<Animation>().Play("a1");
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

	public virtual void Set(GameObject p)
	{
		player = p;
	}
}
