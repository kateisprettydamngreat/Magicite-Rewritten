using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ForestSpikes : MonoBehaviour
{
    public GameObject baseGameObject;

    private Animation baseAnimation;

    private void Start()
    {
        baseAnimation = baseGameObject.GetComponent<Animation>();

        StartCoroutine(SpikeAnimationCoroutine());
    }

    private IEnumerator SpikeAnimationCoroutine()
    {
        yield return new WaitForSeconds(GetRandomWaitTime());
        baseAnimation.Play();

        if (Network.isServer)
        {
            GetComponent<NetworkView>().RPC("PlayAnimation", RPCMode.All);
        }
    }

    [RPC]
    private void PlayAnimation()
    {
        baseAnimation.Play();
    }

    private float GetRandomWaitTime()
    {
        return UnityEngine.Random.Range(0, 5) * 0.5f;
    }
}