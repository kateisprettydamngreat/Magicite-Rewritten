using System;
using UnityEngine;
using System.Collections;

public class BoneThrw : MonoBehaviour {

    public bool isRight;
    public GameObject baseObject;
    
    private Renderer renderer;
    private float speed;
    private Transform transform;
    private bool exiling;
    
    void Start() {
        renderer = baseObject.GetComponent<Renderer>();
        transform = transform;
        
        if (isRight) {
            // ...
        }
        
        StartCoroutine(DelayedExile());
    }

    void Update() {
        speed += 0.2f;
        
        if (isRight) {
            transform.Translate(Vector3.left * Time.deltaTime * -speed);
        } else {
            transform.Translate(Vector3.left * Time.deltaTime * speed); 
        }
    }

    void OnTriggerEnter(Collider c) {
        if (c.gameObject.layer != 9) {
            Destroy(gameObject);
        }
    }

    IEnumerator DelayedExile() {
        if (Network.isServer) {
            yield return new WaitForSeconds(2f);
            
            StartCoroutine(Exile());
        }
    }

    IEnumerator Exile() {
        if (!exiling) {
            exiling = true;
            transform.position = new Vector3(0f, 0f, -500f);
        
            yield return new WaitForSeconds(4f);

            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID);        
        }
    }

}