using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class CritScript : MonoBehaviour
{

    private Transform t;

    private bool stop;

    public virtual void Awake()
    {
        t = transform;
    }

    public virtual IEnumerator Start()
    {
        yield return new WaitForSeconds(0.3f);
        stop = true;
        UnityEngine.Object.Destroy(gameObject, 0.5f);
    }

    public virtual void Update()
    {
        if (!stop && t)
        {
            t.Translate(Vector3.up * Time.deltaTime * 6f);
        }
    }

}
