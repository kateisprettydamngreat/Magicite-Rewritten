using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EffectScript : MonoBehaviour
{

    public int type;

    private int mag;

    public virtual void Awake()
    {
        if (type == 2)
        {
            GetComponent<Collider>().enabled = false;
        }
    }

    public virtual void Start()
    {
        if (type != 2)
        {
            StartCoroutine(End());
        }
    }

    public IEnumerator End()
    {
        yield return new WaitForSeconds(0.3f);

        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
        Network.Destroy(GetComponent<NetworkView>().viewID);
    }

    public virtual void SetMag(int a)
    {
        mag = a;
        GetComponent<Collider>().enabled = true;
        StartCoroutine(End());
    }

    public virtual void OnTriggerEnter(Collider c)
    {
        if (type == 0)
        {
            c.gameObject.SendMessage("Charge");
        }
        else if (type == 1)
        {
            c.gameObject.SendMessage("Shield");
        }
        else if (type == 2)
        {
            c.gameObject.SendMessage("mWeapons", mag);
        }
        else if (type == 3)
        {
            c.gameObject.SendMessage("drumATK");
        }
        else if (type == 4)
        {
            c.gameObject.SendMessage("drumDEX");
        }
        else if (type == 5)
        {
            c.gameObject.SendMessage("drumMAG");
        }
    }

}
