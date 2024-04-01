using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SkeletonScript : EnemyScript
{
    public virtual IEnumerator Start()
    {
        base.GetComponent<Animation>()["i"].layer = 0;
        base.GetComponent<Animation>()["a"].layer = 1;
        int[] drops = new int[3] { 7, 18, 0 };
        SetStats(50, 10, 10, 8, 4f, drops, UnityEngine.Random.Range(7, 16), 8);

        while (true)
        {
            yield return StartCoroutine(MoveCheck());
            yield return StartCoroutine(AttackCheck());
        }
    }

    public virtual IEnumerator AttackCheck()
    {
        if (Network.isServer)
        {
            GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
        }
        yield return new WaitForSeconds(0.3f);
        attacking = false;
        r.velocity = new Vector3(0, r.velocity.y, r.velocity.z);
    }
    public virtual IEnumerator MoveCheck()
    {
        while (true)
        {
            if (!attacking)
            {
                moving = true;
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                yield return new WaitForSeconds(UnityEngine.Random.Range(0, 3));
                int num = UnityEngine.Random.Range(0, 4);
                dir = UnityEngine.Random.Range(1, 3);
                yield return new WaitForSeconds(num);
                moving = false;
                dir = 0;
            }
            else
            {
                yield return new WaitForSeconds(0.2f);
            }
            yield return null;
        }
    }

    IEnumerator ATK()
    {
        Vector3 startPos = new Vector3(t.position.x, t.position.y - 0.5f, 0f);
        Ray ray = new Ray(startPos, new Vector3(1f, 0f, 0f));
        Ray ray2 = new Ray(startPos, new Vector3(-1f, 0f, 0f));

        if (Physics.Raycast(ray, out hit, 10f, 256))
        {
            attacking = true;
            @base.GetComponent<Animation>().Stop();
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            yield return new WaitForSeconds(2f);
        }
        else if (Physics.Raycast(ray2, out hit, 10f, 256))
        {
            attacking = true;
            @base.GetComponent<Animation>().Stop();
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            yield return new WaitForSeconds(2f);
        }
    }

	private RaycastHit hit;
}
