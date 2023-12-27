using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Deatha : MonoBehaviour
{
    public virtual IEnumerator Start()
    {
        yield return new WaitForSeconds(4f);

        Network.Destroy(GetComponent<NetworkView>().viewID);
    }

}
