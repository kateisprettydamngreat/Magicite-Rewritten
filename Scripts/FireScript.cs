using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FireScript : MonoBehaviour
{
    private Renderer r;
    private bool exiling;

    public void Awake()
    {
        r = base.GetComponent<Renderer>();
    }

    public IEnumerator Start()
    {
        StartCoroutine(Animate());
        yield return new WaitForSeconds(20f);

        if (GetComponent<NetworkView>().isMine)
        {
            StartCoroutine(Exile());
        }
    }

    private IEnumerator Animate()
    {
        var offset = r.material.mainTextureOffset;
        offset.x += 0.25f;
        r.material.mainTextureOffset = offset;

        yield return new WaitForSeconds(0.1f);
    }

    [RPC]
    private IEnumerator Exile()
    {
        if (!exiling)
        {
            exiling = true;
            transform.position = Vector3.zero;

            yield return new WaitForSeconds(4f);

            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
        }
    }
}
