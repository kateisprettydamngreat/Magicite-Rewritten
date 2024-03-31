using System;
using UnityEngine;
using System.Collections;

public class ballSpike : MonoBehaviour {

  private Transform spikeTransform;
  
  void Awake() {
    spikeTransform = transform;
    
    if(Network.isServer) {
      StartCoroutine(SpikeMovement());
    }
  }

  IEnumerator SpikeMovement() {
    while(true) {
      spikeTransform.position = new Vector3(spikeTransform.position.x, spikeTransform.position.y + UnityEngine.Random.Range(0, 5));
      
      yield return new WaitForSeconds(UnityEngine.Random.Range(0, 5) * 0.1f);
      
      if(UnityEngine.Random.Range(0, 2) == 0) {
        SwingSpike(1);  
      }
      else {
        SwingSpike(-1);
      }
      
      yield return new WaitForSeconds(UnityEngine.Random.Range(0, 5) * 0.1f);
    }
  }

  void SwingSpike(int direction) {
    if(direction == 1) {
      base.GetComponent<Animation>()["Swing"].speed = 1f;
    }
    else {
      base.GetComponent<Animation>()["Swing"].speed = -1f;
    }
    
    base.GetComponent<Animation>().Play(); 
  }

}
