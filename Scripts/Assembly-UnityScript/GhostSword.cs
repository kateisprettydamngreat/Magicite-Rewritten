using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class GhostSword : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    
    private Vector3 moveDirection;
    private bool isCharging;

    private void Start()
    {
        StartCoroutine(ChargeRoutine());
    }

    private IEnumerator ChargeRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            
            if (targetTransform != null)
            {
                moveDirection = (targetTransform.position - transform.position).normalized; 
                moveDirection.z = 0;
                
                isCharging = true;
                
                yield return new WaitForSeconds(Random.Range(1, 3)); 
            }
        }
    }

    private void Update()
    {
        if (isCharging && targetTransform != null)
        {
            transform.Translate(moveDirection * 9f * Time.deltaTime);  
        }
    }

    public void SetTarget(GameObject target)
    {
        targetTransform = target.transform;
    }
}
