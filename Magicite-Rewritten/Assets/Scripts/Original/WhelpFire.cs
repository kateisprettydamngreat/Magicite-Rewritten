using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class WhelpFire : MonoBehaviour
{
    [SerializeField] private bool isFast;
    [SerializeField] private bool yeti;

    private Vector3 playerPos;
    private Rigidbody rigidbody;
    private Vector3 moveDirection;
    private Transform transform;
    private bool canShoot;
    private int speed;
    private bool exiling;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform = this.transform;

        if (isFast) {
            speed = Random.Range(5, 18);
        }
    }

    [RPC]
    private void SetTarget(Vector3 targetPosition)
    {
        playerPos = targetPosition;

        if (!yeti) {
            moveDirection = (playerPos - transform.position).normalized;
        }
        else {
            moveDirection = targetPosition;
        }

        canShoot = true;
    }

    private IEnumerator ExileRoutine()
    {
        if (!exiling) {
            exiling = true;

            transform.position = Vector3.zero;

            yield return new WaitForSeconds(4);

            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
        }
    }

    private void Update()
    {
        if (canShoot) {
            transform.Translate(moveDirection * speed * Time.deltaTime);
        }
    }
}
