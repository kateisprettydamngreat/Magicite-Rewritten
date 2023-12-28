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
            renderer.material.mainTextureOffset.x += 0.5f;
            yield return new WaitForSeconds(0.2f);
        }
    }
}