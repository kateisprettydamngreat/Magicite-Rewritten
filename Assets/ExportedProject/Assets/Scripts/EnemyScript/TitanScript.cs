using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class TitanScript : EnemyScript
{
    public virtual IEnumerator Start()
    {
        base.GetComponent<Animation>()["i"].layer = 0;
        base.GetComponent<Animation>()["r"].layer = 0;
        base.GetComponent<Animation>()["a"].layer = 1;
        base.GetComponent<Animation>()["r"].speed = 2f;
        base.GetComponent<Animation>()["i"].speed = 2f;
        base.GetComponent<Animation>()["a"].speed = 0.5f;
        int[] drops = new int[3] { 7, 18, 0 };
        SetStats(20, 1, 1, 3, 4f, drops, UnityEngine.Random.Range(2, 6), 3);

        yield return StartCoroutine(MoveCheck());
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
        if (!attacking)
        {
            moving = true;
            yield return new WaitForSeconds(UnityEngine.Random.Range(2, 6));
            int num = UnityEngine.Random.Range(1, 2);
            int dir = UnityEngine.Random.Range(1, 3);
            moving = false;
            this.dir = dir;
            GetComponent<Rigidbody>().velocity = new Vector3(0, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(1f);
    }
    private IEnumerator ATK()
    {
        Ray ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
        Ray ray2 = new Ray(t.position, new Vector3(-1f, 0f, 0f));
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


	public virtual void Attack(GameObject target)
	{
	}
}
