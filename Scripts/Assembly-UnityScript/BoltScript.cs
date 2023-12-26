using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BoltScript : MonoBehaviour
{
    public GameObject baseObject;

    private int magicDamage;
    private bool exiling;

    public void SetDamage(int damage)
    {
        GetComponent<NetworkView>().RPC("SetDamageRPC", RPCMode.All, damage);
    }

    [RPC]
    void SetDamageRPC(int damage)
    {
        magicDamage = damage;
        StartCoroutine(AnimateBolt());
    }

    IEnumerator AnimateBolt()
    {
        GetComponent<Collider>().enabled = true;

        for (int i = 0; i < 12; i++)
        {
            float x = GetComponent<Renderer>().material.mainTextureOffset.x + 0.25f;
            Vector2 offset = GetComponent<Renderer>().material.mainTextureOffset;
            offset.x = x;
            GetComponent<Renderer>().material.mainTextureOffset = offset;

            yield return new WaitForSeconds(0.05f);
        }

        if (Network.isServer)
        {
            StartCoroutine(Exile());
        }
    }

    public void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.layer == 9 || c.gameObject.layer == 12)
        {
            c.gameObject.SendMessage("TakeDamage", magicDamage);
        }
        else if (c.gameObject.layer == 8 && MenuScript.pvp == 1 && !GetComponent<NetworkView>().isMine)
        {
            c.gameObject.SendMessage("TakeDamage", magicDamage); 
        }
    }

    [RPC]
    IEnumerator Exile()
    {
        if (!exiling)
        {
            exiling = true;
            transform.position = new Vector3(0f, 0f, -500f);

            yield return new WaitForSeconds(4f);
            
            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
        }
    }
}