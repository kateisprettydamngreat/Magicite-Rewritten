using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ProjectileScript : MonoBehaviour
{
    public float speed;

    public GameObject lightObj;
    
    private Transform t;

    private bool stuck;

    IEnumerator Start()
    {
        t = transform;
        
        if (Network.isServer)
        {
            yield return new WaitForSeconds(3f);
            
            Network.Destroy(GetComponent<NetworkView>().viewID);
        }
    }

    void Update()
    {
        if (!stuck)
        {
            t.Translate(Vector3.up * Time.deltaTime * speed); 
        }
    }

    public void Die()
    {
        stuck = true;
    }
}