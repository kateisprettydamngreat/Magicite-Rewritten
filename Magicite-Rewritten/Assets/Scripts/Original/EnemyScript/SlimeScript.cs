using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SlimeScript : EnemyScript
{
    public virtual IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(0, 6));
            yield return StartCoroutine(MoveCheck());
        }
    }

    public virtual IEnumerator MoveCheck()
    {
        int num = UnityEngine.Random.Range(0, 2);
        if (num != 0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-10, UnityEngine.Random.Range(10, 16), 0);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(10, UnityEngine.Random.Range(10, 16), 0);
        }
        yield return new WaitForSeconds(3f);
    }

	public override void Awake()
	{
		int[] array = new int[3] { 9, 18, 15 };
		SetStats(10, 1, 0, 3, 4f, array, UnityEngine.Random.Range(5, 15), 3);
		@base.GetComponent<Animation>()["i"].speed = 0.5f;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
	}

}
