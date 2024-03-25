using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SkelBossScript : EnemyScript
{
    public virtual IEnumerator Start()
    {
        base.GetComponent<Animation>()["i"].layer = 0;
        base.GetComponent<Animation>()["r"].layer = 0;
        base.GetComponent<Animation>()["a"].layer = 1;
        int[] drops = new int[3] { 7, 18, 0 };
        SetStats(20, 1, 1, 3, 0f, drops, UnityEngine.Random.Range(2, 6), 6);

        while (true)
        {
            yield return StartCoroutine(AttackCheck());
        }
    }

    public virtual IEnumerator AttackCheck()
    {
        Ray ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
        Ray ray2 = new Ray(t.position, new Vector3(-1f, 0f, 0f));
        int num;

        if (Physics.Raycast(ray, out hit, 20f, 256))
        {
            num = UnityEngine.Random.Range(0, 5);
            if (num == 0)
            {
                attacking = true;
                base.GetComponent<Animation>().Play("a");
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                yield return new WaitForSeconds(0.7f);
                yield return new WaitForSeconds(0.5f);
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                r.velocity = new Vector3(25f, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(0.5f);
            }
            else
            {
                attacking = true;
                base.GetComponent<Animation>().Play("r");
                yield return new WaitForSeconds(0.5f);
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                r.velocity = new Vector3(25f, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(0.5f);
            }
        }
        else if (Physics.Raycast(ray2, out hit, 20f, 256))
        {
            num = UnityEngine.Random.Range(0, 5);
            if (num == 0)
            {
                attacking = true;
                base.GetComponent<Animation>().Play("a");
                e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                yield return new WaitForSeconds(0.7f);
                yield return new WaitForSeconds(0.5f);
                e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                r.velocity = new Vector3(-25f, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(0.5f);
            }
            else
            {
                attacking = true;
                base.GetComponent<Animation>().Play("r");
                yield return new WaitForSeconds(0.5f);
                e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                r.velocity = new Vector3(-25f, r.velocity.y, r.velocity.z);
                yield return new WaitForSeconds(0.5f);
            }
        }

        yield return new WaitForSeconds(0.3f);
        attacking = false;
        r.velocity = new Vector3(0f, r.velocity.y, r.velocity.z);
    }
    public virtual IEnumerator MoveCheck()
    {
        if (!attacking)
        {
            GetComponent<AudioSource>().PlayOneShot(a);
            dir = 0;
            GetComponent<Rigidbody>().velocity = new Vector3(0, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
            yield return new WaitForSeconds(UnityEngine.Random.Range(0, 3));
        }

        int num = UnityEngine.Random.Range(1, 2);
        int dir = UnityEngine.Random.Range(1, 3);
        moving = false;
        this.dir = dir;

        yield return new WaitForSeconds(num);
    }

	private RaycastHit hit;

	public GameObject boneThrowL;

	public GameObject boneThrowR;
}
