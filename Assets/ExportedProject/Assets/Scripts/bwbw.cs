using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bwbw : MonoBehaviour
{
    private Renderer renderer;

    private IEnumerator Animate()
    {
        while (true)
        {
            renderer.material.mainTextureOffset = new Vector2(
              renderer.material.mainTextureOffset.x + 0.5f,
              renderer.material.mainTextureOffset.y);

            yield return new WaitForSeconds(0.2f);
        }
    }

    private void OnEnable()
    {
        renderer = GetComponent<Renderer>();
        StartCoroutine(Animate());
    }
}
