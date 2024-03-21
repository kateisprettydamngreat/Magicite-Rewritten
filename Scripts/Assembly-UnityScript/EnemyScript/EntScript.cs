using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EntScript : EnemyScript
{
    public virtual IEnumerator Start()
    {
        base.GetComponent<Animation>()["i"].layer = 0;
        int[] drops = new int[3] { 7, 18, 0 };
        SetStats(10, 1, 1, 3, 2f, drops, UnityEngine.Random.Range(2, 6), 3);
        StartCoroutine(AttackCheck());
        yield return new WaitForSeconds(0.7f);
    }

    public virtual IEnumerator AttackCheck()
    {
        Ray ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
        Ray ray2 = new Ray(t.position, new Vector3(-1f, 0f, 0f));
        if (Physics.Raycast(ray, out hit, 10f, 256))
        {
            e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            r.velocity = new Vector3(10f, UnityEngine.Random.Range(5, 10), r.velocity.z);
        }
        else if (Physics.Raycast(ray2, out hit, 10f, 256))
        {
            e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            r.velocity = new Vector3(-10f, UnityEngine.Random.Range(5, 10), r.velocity.z);
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
		int newDir = UnityEngine.Random.Range(1, 3); // Renamed the local variable to 'newDir'
		moving = false;
		dir = newDir; // Assign the value of 'newDir' to the field 'dir'

		yield return new WaitForSeconds(num);
	}


	private RaycastHit hit;

}
