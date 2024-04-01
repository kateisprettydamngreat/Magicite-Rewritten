using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class GiantBug : EnemyScript
{
    public virtual IEnumerator Attack()
    {
        yield return new WaitForSeconds(1f);

        if ((bool)player && Network.isServer)
        {
            GetComponent<NetworkView>().RPC("SpeedUp", RPCMode.All);
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
            yield return new WaitForSeconds(2.5f);
            GetComponent<NetworkView>().RPC("SpeedDown", RPCMode.All);
        }

        atking = false;
    }

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	public GiantBug()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(85, 3, 0, 40, 10f, array, UnityEngine.Random.Range(5, 15), 40);
		StartCoroutine(Attack());
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !knocking && r.isKinematic)
		{
			t.Translate(curVector.normalized * 20f * Time.deltaTime);
		}
	}
	[RPC]
	public virtual void SpeedUp()
	{
		@base.GetComponent<Animation>()["i"].speed = 2f;
	}

	[RPC]
	public virtual void SpeedDown()
	{
		@base.GetComponent<Animation>()["i"].speed = 1f;
	}
}
