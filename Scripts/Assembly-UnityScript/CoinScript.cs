using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CoinScript : MonoBehaviour
{
    public GameObject @base;
    public GameObject core;
    private Rigidbody r;
    private int mask;
    private Ray ray;
    private RaycastHit hit;
    private Transform t;
    private bool can;
    public CoinScript()
    {
        mask = 256;
    }

    public virtual void Awake()
    {
        t = transform;
        r = GetComponent<Rigidbody>();
        r.AddForce(new Vector3(UnityEngine.Random.Range(-10, 10) * 50, UnityEngine.Random.Range(-10, 10) * 50, 0f));
    }

    public virtual void Update()
    {
        if (can)
        {
            ray = new Ray(t.position, new Vector3(-1f, 0f, 0f));
            if (Physics.Raycast(ray, out hit, 3f, mask))
            {
                r.velocity = new Vector3(-9, r.velocity.y, r.velocity.z);
            }

            ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
            if (Physics.Raycast(ray, out hit, 3f, mask))
            {
                r.velocity = new Vector3(9, r.velocity.y, r.velocity.z);
            }
        }
    }

    public virtual IEnumerator Start()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(0.2f, 0.8f));

        core.GetComponent<Animation>().Play();
        GetComponent<Collider>().enabled = true;
        can = true;

        yield return new WaitForSeconds(15f);

        UnityEngine.Object.Destroy(gameObject);
    }

}
