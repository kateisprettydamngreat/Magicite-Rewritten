using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ArcherScript : EnemyScript
{
    private void Start()
    {
        base.GetComponent<Animation>()["i"].layer = 0;
        base.GetComponent<Animation>()["a"].layer = 1;
        int[] drops = new int[3] { 15, 18, 15 };
        SetStats(40, 13, 10, 8, 3f, drops, UnityEngine.Random.Range(7, 15), 8);
        StartCoroutine(AttackCheck());
    }
	public IEnumerator AttackCheck()
	{
		if (!attacking)
		{
			Vector3 startPos = new Vector3(t.position.x, t.position.y - 0.5f, 0f);
			Ray ray = new Ray(startPos, new Vector3(1f, 0f, 0f));
			Ray ray2 = new Ray(startPos, new Vector3(-1f, 0f, 0f));

			if (Physics.Raycast(ray, out hit, 15f, 256))
			{
				GetComponent<AudioSource>().PlayOneShot(audioFire);
				attacking = true;
				@base.GetComponent<Animation>().Play("a");
				e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
				yield return new WaitForSeconds(0.4f);

				if (Network.isServer)
				{
					Network.Instantiate(arrowR, t.position, Quaternion.identity, 0);
				}
				r.velocity = new Vector3(r.velocity.x, 10f, r.velocity.z);
				r.velocity = new Vector3(-3f, r.velocity.y, r.velocity.z);
				yield return new WaitForEndOfFrame();
			}
			else if (Physics.Raycast(ray2, out hit, 15f, 256))
			{
				GetComponent<AudioSource>().PlayOneShot(audioFire);
				attacking = true;
				@base.GetComponent<Animation>().Play("a");
				e.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
				yield return new WaitForSeconds(0.4f);

				if (Network.isServer)
				{
					Network.Instantiate(arrowL, t.position, Quaternion.identity, 0);
				}
				r.velocity = new Vector3(r.velocity.x, 10f, r.velocity.z);
				r.velocity = new Vector3(3f, r.velocity.y, r.velocity.z);
				yield return new WaitForEndOfFrame();
			}
		}

		yield return new WaitForSeconds(1f);
		attacking = false;
		r.velocity = new Vector3(0f, r.velocity.y, r.velocity.z);
	}

	public IEnumerator MoveCheck()
	{
		if (!attacking)
		{
			moving = true;
			GetComponent<Rigidbody>().velocity = new Vector3(0, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
			yield return new WaitForSeconds(UnityEngine.Random.Range(0, 3));

			int num = UnityEngine.Random.Range(0, 4);
			int dir = UnityEngine.Random.Range(1, 3);
			this.dir = dir;
			yield return new WaitForSeconds(num);

			moving = false;
			this.dir = 0;
		}
		else
		{
			yield return new WaitForSeconds(0.2f);
		}
	}

    public IEnumerator ATK()
    {
        Vector3 startPos = new Vector3(t.position.x, t.position.y - 0.5f, 0f);
        Ray ray = new Ray(startPos, new Vector3(1f, 0f, 0f));
        Ray ray2 = new Ray(startPos, new Vector3(-1f, 0f, 0f));

        if (Physics.Raycast(ray, out hit, 15f, 256))
        {
            attacking = true;
            GetComponent<AudioSource>().PlayOneShot(audioFire);
            attacking = true;
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            yield return new WaitForSeconds(0.4f);

            if (Network.isServer)
            {
                Network.Instantiate(arrowR, t.position, Quaternion.identity, 0);
            }
            r.velocity = new Vector3(r.velocity.x, 10f, r.velocity.z);
            r.velocity = new Vector3(-3f, r.velocity.y, r.velocity.z);
            yield return new WaitForEndOfFrame();
        }
        else if (Physics.Raycast(ray2, out hit, 15f, 256))
        {
            GetComponent<AudioSource>().PlayOneShot(audioFire);
            attacking = true;
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
            yield return new WaitForSeconds(0.4f);

            if (Network.isServer)
            {
                Network.Instantiate(arrowL, t.position, Quaternion.identity, 0);
            }
            r.velocity = new Vector3(r.velocity.x, 10f, r.velocity.z);
            r.velocity = new Vector3(3f, r.velocity.y, r.velocity.z);
            yield return new WaitForEndOfFrame();
        }
    }

	private RaycastHit hit;

	public GameObject arrowR;

	public GameObject arrowL;

	public AudioClip audioFire;
}
