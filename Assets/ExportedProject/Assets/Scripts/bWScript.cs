using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class bWScript : MonoBehaviour
{
    private Renderer r;

    public virtual IEnumerator Start()
    {
        while (true)
        {
            r = GetComponent<Renderer>();

            var offsetX = r.material.mainTextureOffset.x + 0.5f;
            var mainTextureOffset = r.material.mainTextureOffset;
            mainTextureOffset.x = offsetX;
            r.material.mainTextureOffset = mainTextureOffset;

            yield return new WaitForSeconds(0.2f);

            offsetX = r.material.mainTextureOffset.x - 0.5f;
            mainTextureOffset = r.material.mainTextureOffset;
            mainTextureOffset.x = offsetX;
            r.material.mainTextureOffset = mainTextureOffset;

            yield return new WaitForSeconds(0.2f);
        }
    }
}
