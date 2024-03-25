using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class IceSlimeScript : EnemyScript
{
    public virtual IEnumerator Start()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(0, 6));
        while (true)
        {
            yield return StartCoroutine(MoveCheck());
        }
    }


    public virtual IEnumerator MoveCheck()
    {
        int num = UnityEngine.Random.Range(0, 2);
        if (num != 0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-5, UnityEngine.Random.Range(10, 16), 0);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(5, UnityEngine.Random.Range(10, 16), 0);
        }
        yield return new WaitForSeconds(2f);
    }

	public override void Awake()
	{
		int[] array = new int[3] { 10, 9, 16 };
		SetStats(15, 2, 0, 6, 7f, array, UnityEngine.Random.Range(5, 15), 6);
		@base.GetComponent<Animation>()["i"].speed = 0.5f;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
	}

}
