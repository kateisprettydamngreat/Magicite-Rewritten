using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using UnityEngine;

[Serializable]
public class pingScript : MonoBehaviour
{
    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    public IEnumerator Animate()
    {
        while (true)
        {
            var material = renderer.material;
            var offset = material.mainTextureOffset;
            offset.x = 0.5f;
            material.mainTextureOffset = offset;
            yield return new WaitForSeconds(0.2f);
        }
    }
}