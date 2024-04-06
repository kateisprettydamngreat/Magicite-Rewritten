using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class FireAnimate : MonoBehaviour
{
    [SerializeField] private Renderer renderer;
    
    private float offsetX;
    private Vector2 offset;

    private void Awake()
    {
        renderer = GetComponent<Renderer>(); 
    }

    private IEnumerator Animate()
    {
        while (true) 
        {
            offsetX = renderer.material.mainTextureOffset.x + 0.25f;
            offset = renderer.material.mainTextureOffset;
            offset.x = offsetX;
            renderer.material.mainTextureOffset = offset;
            
            yield return new WaitForSeconds(0.2f);
        }
    }
    
    private void Start()
    {
        StartCoroutine(Animate());
    }
}