using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class InvaderScript : EnemyScript
{
    public virtual IEnumerator Trigger()
    {
        yield return new WaitForSeconds(10f);
        trigger.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        trigger.SetActive(true);
        yield return new WaitForSeconds(5f);
    }
    public virtual IEnumerator Attack()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if ((bool)player)
            {
                curVector = player.transform.position - t.position;
                if (!(player.transform.position.x <= t.position.x))
                {
                    e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                }
                else
                {
                    e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                }
                atking = true;
                yield return new WaitForSeconds(2f);
            }
            speed = UnityEngine.Random.Range(12, 18);
            atking = false;
        }
    }

	public GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	public GameObject trigger;

	public InvaderScript()
	{
		speed = 15f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 7, 9, 0 };
		SetStats(999999, 9999, 3, 8, 15f, array, UnityEngine.Random.Range(6, 20), 8);
		StartCoroutine_Auto(Attack());
		StartCoroutine_Auto(Trigger());
	}


	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && atking && !knocking && r.isKinematic)
		{
			t.Translate(curVector.normalized * speed * Time.deltaTime);
		}
	}

}
