using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class YetiScript : EnemyScript
{
    public virtual IEnumerator Start()
    {
        base.GetComponent<Animation>()["i"].layer = 0;
        base.GetComponent<Animation>()["a"].layer = 1;
        base.GetComponent<Animation>()["i"].speed = 0.5f;
        int[] drops = new int[3] { 1, 0, 0 };
        SetStats(20, 2, 1, 8, 6f, drops, UnityEngine.Random.Range(3, 20), 6);

        while (true)
        {
            yield return StartCoroutine(AttackCheck());
        }
    }

    IEnumerator ATK()
    {
        Vector3 startPos = new Vector3(t.position.x, t.position.y - 0.3f, 0f);
        Ray ray = new Ray(startPos, new Vector3(1f, 0f, 0f));
        Ray ray2 = new Ray(startPos, new Vector3(-1f, 0f, 0f));
        int num = default(int);
        if (Physics.Raycast(ray, out hit, 20f, 256))
        {
            attacking = true;
            num = UnityEngine.Random.Range(0, 5);
            base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            yield return new WaitForSeconds(0.3f);
            if (Network.isServer)
            {
                Network.Instantiate(ballR, t.position, Quaternion.identity, 0);
            }
            yield return new WaitForSeconds(2f);
        }
        else if (Physics.Raycast(ray2, out hit, 20f, 256))
        {
            attacking = true;
            base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            yield return new WaitForSeconds(0.3f);
            if (Network.isServer)
            {
                Network.Instantiate(ballL, t.position, Quaternion.identity, 0);
            }
            yield return new WaitForSeconds(2f);
        }
        attacking = false;
    }

    private IEnumerator AttackCheck()
    {
        Vector3 startPos = new Vector3(t.position.x, t.position.y - 0.3f, 0f);
        Ray ray = new Ray(startPos, new Vector3(1f, 0f, 0f));
        Ray ray2 = new Ray(startPos, new Vector3(-1f, 0f, 0f));
        int num = 0;

        if (!attacking)
        {
            if (Physics.Raycast(ray, out hit, 20f, 256))
            {
                num = UnityEngine.Random.Range(0, 5);
                if (Network.isServer)
                {
                    int doodoo = UnityEngine.Random.Range(0, 3);
                    if (doodoo == 0)
                    {
                        r.velocity = new Vector3(r.velocity.x, 20f, r.velocity.z);
                    }
                }
                @base.GetComponent<Animation>().Play("a");
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                yield return new WaitForSeconds(0.3f);

                if (Network.isServer)
                {
                    Network.Instantiate(ballR, t.position, Quaternion.identity, 0);
                }
                yield return new WaitForSeconds(2f);
            }
            else if (Physics.Raycast(ray2, out hit, 20f, 256))
            {
                if (Network.isServer)
                {
                    int doodoso = UnityEngine.Random.Range(0, 3);
                    if (doodoso == 0)
                    {
                        r.velocity = new Vector3(r.velocity.x, 20f, r.velocity.z);
                    }
                }
                @base.GetComponent<Animation>().Play("a");
                e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                yield return new WaitForSeconds(0.3f);

                if (Network.isServer)
                {
                    Network.Instantiate(ballL, t.position, Quaternion.identity, 0);
                }
                yield return new WaitForSeconds(2f);
            }
        }

        yield return new WaitForSeconds(0.3f);
    }

	public GameObject ballL;

	public GameObject ballR;

	private RaycastHit hit;

	private int num;
}
