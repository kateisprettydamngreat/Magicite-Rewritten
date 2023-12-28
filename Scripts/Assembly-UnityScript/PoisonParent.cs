using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class PoisonParent : MonoBehaviour
{
    private bool exiling;
    
    public virtual void Start()
    {
    }

    [RPC]
    public virtual IEnumerator Exile()
    {
        if (!exiling)
        {
            exiling = true;
            transform.position = new Vector3(0f, 0f, -500f);
            
            yield return new WaitForSeconds(4f);
            
            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
        }
    }
}
