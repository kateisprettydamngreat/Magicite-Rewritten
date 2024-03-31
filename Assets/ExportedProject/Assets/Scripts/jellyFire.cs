using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class jellyFire : MonoBehaviour
{

    private Vector3 playerPos;
    private Rigidbody rigidbody;
    private Vector3 moveDirection;
    private Transform transform;
    
    private bool canShoot;
    private bool exiling;

    public void Awake()
    {
        transform = GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody>();
    }

    [RPC]
    public void SetTarget(Vector3 targetPos)
    {
        playerPos = targetPos;
        moveDirection = (playerPos - transform.position).normalized;
        canShoot = true;
    }

    public void Update()
    {
        if (canShoot && Network.isServer) {
            transform.Translate(moveDirection * 8f * Time.deltaTime);
        }
    }

    [RPC]
    public void Exile() 
    {
        if (!exiling)
        {
            exiling = true;
            transform.position = Vector3.zero;
            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID); 
        }
    }

}
