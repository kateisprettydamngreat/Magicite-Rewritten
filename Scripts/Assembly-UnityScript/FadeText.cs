using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FadeText : MonoBehaviour
{

  public virtual void OnEnable()
  {
    StartCoroutine(Die());
  }

  public virtual IEnumerator Die()
  {
    yield return new WaitForSeconds(2f);
    gameObject.SetActive(false);
  }

}
