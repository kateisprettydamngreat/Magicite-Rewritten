using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SnowSpawner : MonoBehaviour
{
    private Transform t;
    
    private IEnumerator SpawnSnow() 
    {
        var wait = new WaitForSeconds(UnityEngine.Random.Range(0.0f, 2.5f));  
        yield return wait;
        
        if (UnityEngine.Random.Range(0, 2) == 0) {
            Instantiate(Resources.Load("rckS1"), GetSpawnPosition(), Quaternion.identity); 
        } else {
            Instantiate(Resources.Load("rckS"), GetSpawnPosition(), Quaternion.identity);
        }
    }
    
    private Vector3 GetSpawnPosition() 
    {
        return new Vector3(t.position.x, t.position.y + 35f, 0f); 
    }

    private IEnumerator Start()
    {
        t = transform;
        
        while(true) {
            if (Network.isServer) {
                SpawnSnow();  
                yield return new WaitForSeconds(3f); 
            }
            else {
                yield return null;
            }
        }
    }
}
