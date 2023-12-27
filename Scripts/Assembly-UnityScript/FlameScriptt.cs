using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class FlameScriptt : MonoBehaviour
{
    [SerializeField] private GameObject baseObject;

    private IEnumerator StartCoroutine()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(0, 3) * 0.5f);
        yield return new WaitForSeconds(UnityEngine.Random.Range(0, 5) * 0.5f);

        if (Network.isServer)
        {
            GetComponent<NetworkView>().RPC("PlayAnimation", RPCMode.All);
        }
    }

    [RPC]
    private void PlayAnimation()
    {
        baseObject.GetComponent<Animation>().Play(); 
    }

    private void Start()
    {
        StartCoroutine(StartCoroutine());
    }
}
