using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class txtLUP : MonoBehaviour
{
    private Transform t;
    public TextMesh txtSentence;

    public virtual void Awake() 
    {
        t = transform;
    }

    public virtual IEnumerator Start()
    {
        for (int i = 0; i < 20; i++) 
        {
            t.position = new Vector3(t.position.x, t.position.y + 0.1f, t.position.z); 
            yield return new WaitForSeconds(0.1f);
        }
    }
}
