using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class BoarScript : EnemyScript
{
    public virtual IEnumerator Start()
    {
        base.GetComponent<Animation>()["i"].layer = 0;
        base.GetComponent<Animation>()["a"].layer = 1;
        base.GetComponent<Animation>()["r"].layer = 0;
        base.GetComponent<Animation>()["r"].speed = 2f;
        int[] drops = new int[3] { 18, 20, 19 };
        SetStats(35, 2, 2, 11, 2f, drops, UnityEngine.Random.Range(5, 15), 11);

        yield return StartCoroutine(MoveCheck());
        yield return StartCoroutine(AttackCheck());
    }
    public virtual IEnumerator AttackCheck()
    {
        Ray ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
        Ray ray2 = new Ray(t.position, new Vector3(-1f, 0f, 0f));

        if (Physics.Raycast(ray, out hit, 20f, 256))
        {
            attacking = true;
            base.GetComponent<Animation>().Stop();
            base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            yield return new WaitForSeconds(0.7f);
            base.GetComponent<Animation>().Play("r");
            atking = true;
            spdd = 16f;
            yield return new WaitForSeconds(1.5f);
            atking = false;
            spdd = 0f;
            base.GetComponent<Animation>().Play("i");
        }
        else if (Physics.Raycast(ray2, out hit, 20f, 256))
        {
            attacking = true;
            base.GetComponent<Animation>().Stop();
            base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            yield return new WaitForSeconds(0.7f);
            base.GetComponent<Animation>().Play("r");
            atking = true;
            spdd = -16f;
            yield return new WaitForSeconds(1.5f);
            atking = false;
            spdd = 0f;
            base.GetComponent<Animation>().Play("i");
        }
        else
        {
            yield return new WaitForSeconds(0.3f);
            attacking = false;
            r.velocity = new Vector3(0, r.velocity.y, r.velocity.z);
        }
    }
    public virtual IEnumerator MoveCheck()
    {
        atking = true;
        yield return new WaitForSeconds(0.2f);
        atking = false;
        spdd = 0f;
    }

    public virtual IEnumerator ATK()
    {
        Ray ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
        Ray ray2 = new Ray(t.position, new Vector3(-1f, 0f, 0f));

        if (Physics.Raycast(ray, out hit, 20f, 256))
        {
            attacking = true;
            @base.GetComponent<Animation>().Stop();
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            yield return new WaitForSeconds(0.7f);
            @base.GetComponent<Animation>().Play("r");
            atking = true;
            spdd = 16f;
            yield return new WaitForSeconds(UnityEngine.Random.Range(1, 4));
            atking = false;
            spdd = 0f;
            @base.GetComponent<Animation>().Play("i");
        }
        else if (Physics.Raycast(ray2, out hit, 20f, 256))
        {
            attacking = true;
            @base.GetComponent<Animation>().Stop();
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            yield return new WaitForSeconds(0.7f);
            @base.GetComponent<Animation>().Play("r");
            atking = true;
            spdd = -16f;
            yield return new WaitForSeconds(UnityEngine.Random.Range(1, 4));
            atking = false;
            spdd = 0f;
            @base.GetComponent<Animation>().Play("i");
        }
    }

	private RaycastHit hit;

	private float spdd;

	private bool atking;


	public override void Update()
	{
		if (atking)
		{
			float x = spdd;
			Vector3 velocity = r.velocity;
			float num = (velocity.x = x);
			Vector3 vector2 = (r.velocity = velocity);
		}
	}
}
