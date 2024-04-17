using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ChickenScript : EnemyScript
{
    public virtual IEnumerator Moove()
    {
        mooving = true;
        int num = UnityEngine.Random.Range(0, 5);
        if (num != 0)
        {
            if (num == 1)
            {
                MOV = true;
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
                spdd = 8;
            }
            else
            {
                GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
                MOV = true;
                spdd = -8;
            }
        }
        yield return new WaitForSeconds(1f);
        mooving = false;
        MOV = false;
    }
	private int spdd;

	private bool mooving;

	private bool MOV;

	public override void Awake()
	{
		int[] array = new int[3] { 21, 21, 0 };
		SetStats(7, 1, 1, 3, 3f, array, UnityEngine.Random.Range(2, 6), 2);
		r = GetComponent<Rigidbody>();
		t = transform;
	}

	public override void Update()
	{
		if (!mooving && Network.isServer)
		{
			StartCoroutine_Auto(Moove());
		}
		if (MOV && Network.isServer)
		{
			int num = spdd;
			Vector3 velocity = r.velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (r.velocity = velocity);
		}
	}


	[RPC]
	public virtual void Turn(int a)
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
