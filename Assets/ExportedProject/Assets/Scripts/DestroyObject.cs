using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class Destro : MonoBehaviour
{
    public GameObject[] bars; //Health bars
    public float wait = 0.3f; //wait time

    private IEnumerator Start()
    {
        return DestroyObjectAfterDelay(); //Initializes DestroyObjectAfterDelay
    }

    private IEnumerator DestroyObjectAfterDelay()
    {
        if (Network.isServer) //If the client IS the server as in, the host
        {
            yield return new WaitForSeconds(wait); //Wait for the amount of time set in the float "wait", from earlier
            Network.Destroy(GetComponent<NetworkView>().viewID); //Afterwards, use the network library to destroy it.
        }
    }

    [RPC]
    private void SetHH(int a) //adjusts the heathbars accordingly
    {
        if (GetComponent<NetworkView>().isMine)
        {
            float adjustedValue = a * 0.5f;
            bars[0].SendMessage("SetHH", adjustedValue);
            bars[1].SendMessage("SetHH", adjustedValue);
        }
    }
}
