using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class RockScript : MonoBehaviour
{
    private Transform t;

    private int speed;

    public int bonus;

    private bool exiling;

    public void Awake()
    {
        t = transform;
        speed = UnityEngine.Random.Range(8, 15);
        GetComponent<NetworkView>().RPC("Die", RPCMode.All);
    }

    public void Update() 
    {
        t.Translate(Vector3.up * Time.deltaTime * -(speed + bonus));
    }

    [RPC]
    public IEnumerator Die()
    {
        yield return new WaitForSeconds(4f);
        
        if (Network.isServer)
        {
            StartCoroutine(Exile()); 
        }
    }

    [RPC]
    public IEnumerator Exile()
    {
        if (!exiling)
        {
            exiling = true;
            t.position = new Vector3(0f, 0f, -500f);
            
            yield return new WaitForSeconds(4f);
            
            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
        }
    }
}
