using System;
using UnityEngine;
using System.Collections;

public class BugSpotScript : MonoBehaviour {

    private Renderer renderer;
    private int dropId;
    private bool exiling;

    void Start() {
        if (Network.isServer) {
            dropId = UnityEngine.Random.Range(0, 3);
            GetComponent<NetworkView>().RPC("SetDropId", RPCMode.All, dropId);
        }
    }

    [RPC]
    void SetDropId(int id) {
        dropId = id;
    }

    void TakeDamage(int damage) {
        if (damage > 0) {
            GameScript.tempStats[8]++;
            
            for (int i = 0; i < damage; i++) {
                Instantiate(Resources.Load("iLocal"), transform.position, Quaternion.identity);
            }
            
            transform.position = new Vector3(0, 0, -500);
            
            if (Network.isServer) {
                StartCoroutine(Exile());
            }
        }
    }

    IEnumerator Exile() {
        if (!exiling) {
            exiling = true;
            
            yield return new WaitForSeconds(4f);

            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
        }
    }
    
    int GetPlantItem(int id) {
        switch (id) {
            case 0: return 9;
            case 1: return 10;
            case 2: return 11;
        }
        
        return 0;
    }

}