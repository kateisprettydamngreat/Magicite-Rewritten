using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EnemyProjectile : MonoBehaviour
{

    public float speed;

    public bool isLeft;

    private Transform t;

    private bool stuck;

    private bool exiling;

    public virtual IEnumerator Start()
    {

        t = transform;

        if (Network.isServer)
        {
            yield return new WaitForSeconds(5f);

            StartCoroutine(Exile());
        }
    }

    public virtual IEnumerator Exile()
    {

        if (!exiling)
        {
            exiling = true;

            t.position = new Vector3(0f, 0f, -500f);

            yield return new WaitForSeconds(4f);

            if (Network.isServer)
            {
                Network.Destroy(GetComponent<NetworkView>().viewID);
                Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
            }
        }
    }

    public virtual void Update()
    {
        if (!stuck)
        {
            if (isLeft)
            {
                t.Translate(Vector3.left * speed * Time.deltaTime);
            }
            else
            {
                t.Translate(Vector3.left * (0f - speed) * Time.deltaTime);
            }
        }
    }

    public virtual void Stuck()
    {
        stuck = true;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Collider>().enabled = false;
    }

    public virtual void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.layer == 11 && Network.isServer)
        {
            StartCoroutine(Exile());
        }
    }

}