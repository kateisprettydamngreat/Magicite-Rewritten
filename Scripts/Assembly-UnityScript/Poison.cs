using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Poison : MonoBehaviour
{
    public GameObject parent;
    
    private bool exiling;

    IEnumerator StartRoutine()
    {
        yield return new WaitForSeconds(6f);
        
        if (Network.isServer)
        {
            parent.SendMessage("Exile");
        }
    }

    public void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.layer == 8 || c.gameObject.layer == 9)
        {
            MonoBehaviour.print("LAYER ++++++++++ " + c.gameObject.layer);
            
            c.gameObject.SendMessage("TDp");
            
            var isLeft = transform.position.x >= c.gameObject.transform.position.x;
            c.gameObject.SendMessage("K", isLeft);
        }
    }
    
    private void Start()
    {
        StartCoroutine(StartRoutine());
    }
}