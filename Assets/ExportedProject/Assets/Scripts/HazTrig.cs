using System;
using UnityEngine;

[Serializable]
public class HazTrig : MonoBehaviour
{
    public bool negatePlayerDamage;
    public bool canDamage;
    public int damage;
    public bool isIce;

    private void OnTriggerEnter(Collider other)
    {
        int otherLayer = other.gameObject.layer;

        if (otherLayer == 8 && !negatePlayerDamage)
        {
            if (isIce && MenuScript.pvp == 1) //Pvp? Interesting. A remnant of when that was planned?
            {
                Debug.Log($"Ice hit damage: {damage}");
                other.gameObject.SendMessage("TD", damage);
            }
            else
            {
                other.gameObject.SendMessage("TD", damage);
            }
        }
        else if (otherLayer == 9 || otherLayer == 12)
        {
            other.gameObject.SendMessage("Knock22", gameObject.transform.position, SendMessageOptions.DontRequireReceiver);
            if (canDamage)
            {
                other.gameObject.SendMessage("TD", damage);
            }
        }
    }

    [RPC]
    private void SetDamage(int a)
    {
        damage = Mathf.Max(a, 1);
        GetComponent<Collider>().isTrigger = true;
        GetComponent<Collider>().enabled = true;
        gameObject.layer = 0;
    }

    [RPC]
    private void SetDamageForPlayer(int a)
    {
        if (GetComponent<NetworkView>().isMine)
        {
            damage = Mathf.Max(a, 1);
            GetComponent<Collider>().isTrigger = true;
            GetComponent<Collider>().enabled = true;
            gameObject.layer = 0;
        }
        else
        {
            GetComponent<Collider>().enabled = MenuScript.pvp == 1;
        }
    }
}
