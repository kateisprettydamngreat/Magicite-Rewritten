using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SnakeScript : EnemyScript
{
    public virtual IEnumerator Start()
    {
        canChange = true;
        base.GetComponent<Animation>()["i"].layer = 0;
        int[] drops = new int[3] { 7, 18, 0 };
        SetStats(354, 1, 1, 3, 6f, drops, UnityEngine.Random.Range(2, 6), 3);
        moving = true;
        dir = UnityEngine.Random.Range(1, 3);
        StartCoroutine(Check());

        while (true)
        {
            yield return StartCoroutine(ChangeDir());
        }
    }

    public virtual IEnumerator Check()
    {
        while (true)
        {
            if (t.position.x == prev)
            {
                StartCoroutine(ChangeDir());
            }
            prev = t.position.x;
            yield return new WaitForSeconds(1f);
        }
    }

    public IEnumerator ChangeDir()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(3, 10));

        canChange = false;
        if (dir == 1)
        {
            dir = 2;
        }
        else
        {
            dir = 1;
        }
        SPD += 3;

        yield return new WaitForSeconds(0.3f);

        SPD -= 3;
        canChange = true;
    }

	private RaycastHit hit;

	private bool canChange;

	private Ray ray;

	private Ray ray2;

	private float prev;

	public SnakeScript()
	{
		prev = 1f;
	}
}
