using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class KnightBlade : MonoBehaviour
{
    private Transform t;

    private int speed = 10;

    private int dmg;

    public virtual void Awake()
    {
        t = transform;
    }

    public virtual void Update()
    {
        t.Translate(Vector3.down * Time.deltaTime * speed);
    }

    public virtual void Set(int a)
    {
        dmg = a;
    }

    public virtual void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.layer == 9 || c.gameObject.layer == 12)
        {
            c.gameObject.SendMessage("TD", dmg);
        }
        else if (c.gameObject.layer == 11)
        {
            Destroy(gameObject);
        }
    }
}
