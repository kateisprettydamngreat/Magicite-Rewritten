using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class LightBlast : MonoBehaviour
{
    [SerializeField] private Material fireMaterial;

    [SerializeField] private GameObject[] bases;

    [SerializeField] private GameObject particleFire;

    [SerializeField] private int tier;

    [SerializeField] private bool isRight;

    private void OnTriggerEnter(Collider c) 
    {
        if (c.gameObject.layer == 9 || c.gameObject.layer == 12) 
        {
            Exile();
            c.gameObject.SendMessage("TakeDamage", GetDamage());
        }
        else if (c.gameObject.layer == 8)
        {
            c.gameObject.GetComponent<NetworkView>().RPC("TakeDamage", RPCMode.All, GetDamage());
            Exile();
        }
    }

    private int GetDamage()
    {
        return 150 + tier * tier; 
    }

    private void Exile()
    {
        transform.position = Vector3.left * 500f;
        Network.Destroy(GetComponent<NetworkView>().viewID);
    }

    private void Start() 
    {
        GetComponent<Collider>().enabled = true;
        Invoke(nameof(Exile), 2f);
    }
}