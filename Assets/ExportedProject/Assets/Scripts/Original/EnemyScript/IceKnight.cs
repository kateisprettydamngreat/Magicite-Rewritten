using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class IceKnight : EnemyScript
{
    public virtual IEnumerator FaceRight()
    {
        if (!atking && Network.isServer && !running)
        {
            int num = 8;
            Vector3 vector = r.velocity;
            vector.y = num;
            r.velocity = vector;
            running = true;
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
            GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
            spdd = UnityEngine.Random.Range(-1, 2) * 4;
            if (spdd == 0)
            {
                spdd = 4;
            }
            yield return new WaitForSeconds((float)UnityEngine.Random.Range(1, 3) * 0.3f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            running = false;
        }
        yield break;
    }

    public virtual IEnumerator FaceLeft()
    {
        if (!atking && Network.isServer && !running)
        {
            int num = 8;
            Vector3 vector = r.velocity;
            vector.y = num;
            r.velocity = vector;
            running = true;
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
            GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
            spdd = UnityEngine.Random.Range(-1, 2) * 4;
            if (spdd == 0)
            {
                spdd = -4;
            }
            yield return new WaitForSeconds((float)UnityEngine.Random.Range(1, 2) * 0.3f);
            GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
            running = false;
        }
        yield break;
    }

    public virtual IEnumerator TRY()
    {
        yield return new WaitForSeconds(1f);
        TRYatking = false;
    }

    public virtual IEnumerator ATTACK()
    {
        atking = true;
        spdd = 0;
        GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
        yield return new WaitForSeconds(0.35f);
        yield return new WaitForSeconds(1.2f);
        atking = false;
        TRYatking = false;
    }
    public virtual IEnumerator ATK()
    {
        base.GetComponent<Animation>().Play("a");
        yield return new WaitForSeconds(0.3f);
        swordBox.SetActive(true);
        yield return new WaitForSeconds(1f);
        swordBox.SetActive(false);
    }
	public GameObject swordBox;

	public AudioClip audioMove;

	public AudioClip audioAttack;

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	private bool running;

	private bool TRYatking;

	public IceKnight()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(35, 4, 0, 4, 10f, array, UnityEngine.Random.Range(6, 20), 4);
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["a"].speed = 1f;
		@base.GetComponent<Animation>()["r"].speed = 2f;
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			int num = (int)Mathf.Abs(player.transform.position.x - t.position.x);
			if (num < 20 && !knocking)
			{
				if (!(player.transform.position.x <= t.position.x))
				{
					StartCoroutine(FaceRight());
				}
				else
				{
					StartCoroutine(FaceLeft());
				}
				if (num < 7 && !TRYatking && !atking)
				{
					TRYatking = true;
					if (UnityEngine.Random.Range(0, 3) == 0)
					{
						StartCoroutine(ATTACK());
					}
					else
					{
						StartCoroutine(TRY());
					}
				}
			}
		}
		if (running && !knocking)
		{
			int num2 = spdd;
			Vector3 velocity = r.velocity;
			float num3 = (velocity.x = num2);
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

	[RPC]
	public virtual void RUN()
	{
		@base.GetComponent<Animation>().Play("r");
	}


	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}
}
