using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class MinionScript : MonoBehaviour {

  [SerializeField] private GameObject fireballPrefab;
  
  private Transform myTransform;
  private Animation myAnimation;
  private NetworkView myNetworkView;
  
  private ObjectPool fireballPool;
  
  private int idleLayer;
  private int attackLayer;

  private bool isMovingUp;
  
  void Awake() {
    myTransform = transform;
    myAnimation = base.GetComponent<Animation>();
    myNetworkView = GetComponent<NetworkView>();
    
    idleLayer = myAnimation["i"].layer;
    attackLayer = myAnimation["a"].layer;
  }

  void Start() {
    fireballPool = new ObjectPool(fireballPrefab);
    
    StartCoroutine(VerticalMovement());
  }
  
  void Attack() {
    GameObject fireball = fireballPool.GetPooledObject();
    
    if (fireball != null) {
      fireball.SetActive(true);
      fireball.transform.position = myTransform.position;
    }
  }
  
  IEnumerator VerticalMovement() {

    while(true) {
      myTransform.Translate(Vector3.up * Time.deltaTime * 2f);
      isMovingUp = true;
      yield return new WaitForSeconds(0.5f);
      
      myTransform.Translate(Vector3.up * Time.deltaTime * -2f);
      isMovingUp = false;
      yield return new WaitForSeconds(1f);
    }

  }
  
}