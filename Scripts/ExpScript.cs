using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ExpScript : MonoBehaviour
{
    public virtual IEnumerator Start()
    {
        yield return new WaitForSeconds(0.3f);
        @base.GetComponent<Collider>().enabled = true;
        can = true;
        yield return new WaitForSeconds(20f);
        UnityEngine.Object.Destroy(gameObject);
    }

    public GameObject @base;

    public GameObject core;

    private Rigidbody r;

    private int mask;

    private Ray ray;

    private RaycastHit hit;

    private Transform t;

    private bool can;

    public ExpScript()
    {
        mask = 256;
    }

    public virtual void Awake()
    {
        r = GetComponent<Rigidbody>();
        t = transform;
        r.AddForce(new Vector3(UnityEngine.Random.Range(-4, 4) * 100, UnityEngine.Random.Range(2, 5) * 150, 0f));
    }

    public virtual void Update()
    {
        if (can)
        {
            ray = new Ray(t.position, new Vector3(-1f, 0f, 0f));
            if (Physics.Raycast(ray, out hit, 3f, mask) && hit.transform.gameObject.GetComponent<NetworkView>().isMine)
            {
                r.velocity = new Vector3(-7, r.velocity.y, r.velocity.z);
            }
            ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
            if (Physics.Raycast(ray, out hit, 3f, mask) && hit.transform.gameObject.GetComponent<NetworkView>().isMine)
            {
                r.velocity = new Vector3(7, r.velocity.y, r.velocity.z);
            }
        }
    }
}

