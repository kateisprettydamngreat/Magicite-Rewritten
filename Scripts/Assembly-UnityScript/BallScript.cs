using System;
using System.Collections;
using UnityEngine;

public class BallScript : MonoBehaviour {

  public bool isLeft;
  public bool isTwo;
  public float speed;
  public float upSpeed;

  private Rigidbody rbody;

  void Awake() {
    rbody = GetComponent<Rigidbody>();

    if(Network.isServer) {
      StartCoroutine(Die());  
    }
  }

  void Update() {
    rbody.velocity = new Vector3(speed * (isLeft ? -1 : 1), upSpeed, 0); 
  }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(8, 12));

        if (isTwo)
        {
            Exile();
        }
        else
        {
            Destroy(gameObject);
        }
    }


  void Exile() {
    // Exile logic
  }

}
