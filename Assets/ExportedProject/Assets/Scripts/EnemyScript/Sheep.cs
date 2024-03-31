using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Sheep : EnemyScript
{
    public virtual IEnumerator Start()
    {
        int[] drops = new int[3] { 7, 18, 20 };
        SetStats(7, 1, 1, 3, 3f, drops, UnityEngine.Random.Range(2, 6), 2);
        yield return StartCoroutine(MoveCheck());
    }
    public virtual IEnumerator MoveCheck()
    {
        attacking = false;
        moving = true;
        GetComponent<Rigidbody>().velocity = new Vector3(0, GetComponent<Rigidbody>().velocity.y, 0);
        yield return new WaitForSeconds(UnityEngine.Random.Range(0, 3));
        int num = UnityEngine.Random.Range(0, 4);
        int dir = UnityEngine.Random.Range(1, 3);
        this.dir = dir;
        yield return new WaitForSeconds(num);
        moving = false;
        this.dir = 0;
    }
}
