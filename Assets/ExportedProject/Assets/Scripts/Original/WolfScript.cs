using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WolfScript : MonoBehaviour
{
    private bool exiling;

    [RPC]
    private IEnumerator ExileRoutine()
    {
        exiling = true;
        transform.position = Vector3.down * 500;
        yield return new WaitForSeconds(4);
        Network.Destroy(GetComponent<NetworkView>().viewID);
        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
    }

    [RPC]
    private void Exile()
    {
        StartCoroutine(ExileRoutine());
    }
}