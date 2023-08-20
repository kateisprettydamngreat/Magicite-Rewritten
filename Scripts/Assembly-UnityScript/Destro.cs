using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class Destro : MonoBehaviour
{
    public GameObject[] bars;
    public float wait = 0.3f;

    private IEnumerator Start()
    {
        return DestroyObjectAfterDelay();
    }

    private IEnumerator DestroyObjectAfterDelay()
    {
        if (Network.isServer)
        {
            yield return new WaitForSeconds(wait);
            Network.Destroy(GetComponent<NetworkView>().viewID);
        }
    }

    [RPC]
    private void SetHH(int a)
    {
        if (GetComponent<NetworkView>().isMine)
        {
            float adjustedValue = a * 0.5f;
            bars[0].SendMessage("SetHH", adjustedValue);
            bars[1].SendMessage("SetHH", adjustedValue);
        }
    }
}
