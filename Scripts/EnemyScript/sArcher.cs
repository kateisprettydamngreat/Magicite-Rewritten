using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class sArcher : EnemyScript
{
    public IEnumerator Attack(Vector3 pp)
    {
        ATKING = true;

        if (pp.x > transform.position.x)
        {
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
        }
        else
        {
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
        }

        yield return new WaitForSeconds(0.3f);

        GetComponent<NetworkView>().RPC("A1", RPCMode.All);

        yield return new WaitForSeconds(0.6f);

        if (player)
        {
            target_pos = player.transform.position;
            object_pos = transform.position;
            target_pos.z = -20f;
            target_pos.x = target_pos.x - object_pos.x;
            target_pos.y = target_pos.y - object_pos.y;
            float angle = Mathf.Atan2(target_pos.y, target_pos.x) * 57.29578f;
            Network.Instantiate(Resources.Load("haz/arrow"), transform.position, Quaternion.Euler(new Vector3(0f, 0f, angle)), 0);
        }

        yield return new WaitForSeconds(2.5f);

        ATKING = false;
    }

	private Vector3 target_pos;

	private Vector3 object_pos;

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

	public sArcher()
	{
		mask = 256;
		mask2 = 2048;
	}

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(15, 2, 2, 15, 2f, array, UnityEngine.Random.Range(10, 25), 15);
	}

	public override void Update()
	{
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 18f) && !ATKING && Network.isServer)
		{
			StartCoroutine_Auto(Attack(player.transform.position));
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

	public virtual void Set(GameObject p)
	{
		player = p;
	}
}
