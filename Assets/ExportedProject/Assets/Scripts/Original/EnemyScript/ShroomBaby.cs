using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ShroomBaby : EnemyScript
{
    public virtual IEnumerator Start()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(0, 6));
        base.GetComponent<Animation>()["i"].speed = 0.5f;
        yield return StartCoroutine(MoveCheck());
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
        yield return new WaitForSeconds(1f);
    }

	public override void Awake()
	{
		int[] array = new int[3] { 20, 19, 15 };
		SetStats(15, 4, 0, 5, 4f, array, UnityEngine.Random.Range(5, 15), 7);
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
	}
}
