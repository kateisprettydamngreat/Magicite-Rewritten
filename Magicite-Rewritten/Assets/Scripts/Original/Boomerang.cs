using System;
using UnityEngine;
using System.Collections;

public class Boomerang : MonoBehaviour {

    private Transform transform;
    private Vector3 target;
    private Vector3 direction;
    private bool exiling;

    void Awake() {
        transform = GetComponent<Transform>();
        StartCoroutine(AutoShift());
        StartCoroutine(AutoDie());
    }

    void Update() {
        target = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
        direction = (target - transform.position).normalized;
        
        GetComponent<Rigidbody>().velocity = direction * 20f; 
    }

    void OnCollisionEnter(Collision c) {
        // hit logic
    }

    IEnumerator AutoShift() {
        while (true) {
            target = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
            direction = (target - transform.position).normalized;
            
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator AutoDie() {
        yield return new WaitForSeconds(20f);
        
        if (Network.isServer) {
            StartCoroutine(Exile());
        }
    }

    IEnumerator Exile() {
        if (!exiling) {
            exiling = true;
            
            transform.position = new Vector3(0, 0, -500f);
            
            yield return new WaitForSeconds(4f);
            
            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
        }
    }

}
