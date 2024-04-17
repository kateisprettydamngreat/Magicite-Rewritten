using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class VineScript : MonoBehaviour
{
    public GameObject[] vineBase;
    public IEnumerator Start()
    {
        for (int i = 0; i < 3; i++)
        {
            vineBase[i].GetComponent<Animation>().speed = 0.5f;
            vineBase[i].GetComponent<Animation>().Play();
            yield return null;
        }
    }
}