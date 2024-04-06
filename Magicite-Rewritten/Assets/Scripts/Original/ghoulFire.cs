using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ghoulFire : MonoBehaviour
{
    private Vector3 playerPos;
    private Rigidbody r;
    private Vector3 moveDirection;
    private bool canShoot;
    private float speed = 18;

    public void Awake()
    {
        r = GetComponent<Rigidbody>();
    }

    public void SetTarget(Vector3 targetPos)
    {
        playerPos = targetPos;
        moveDirection = (playerPos - transform.position).normalized;
        canShoot = true;
    }

    public void FixedUpdate()
    {
        if (canShoot) {
            r.velocity = moveDirection * (speed * Time.deltaTime);
        }
    }

    public void DestroyAfterDelay(float delay)
    {
        Invoke("NetworkDestroy", delay);
    }

    private void NetworkDestroy()
    {
        Network.Destroy(GetComponent<NetworkView>().viewID);
        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
    }
}
