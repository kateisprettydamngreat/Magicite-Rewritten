using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class MerchantScript : MonoBehaviour
{
    public IEnumerator Start()
    {
        while (true)
        {
            if (Network.isServer)
            {
                GetComponent<NetworkView>().RPC("Talkn", RPCMode.All, GetRandomText());
            }

            yield return new WaitForSeconds(UnityEngine.Random.Range(3, 12));
        }
    }

    [RPC]
    public IEnumerator Talkn(string s)
    {
        GetComponent<Animation>().Play("t");
        txtTalk.text = s;
        yield return new WaitForSeconds(2f);
        txtTalk.text = string.Empty;
        GetComponent<Animation>().Play("i");
    }

    public GameObject @base;

    public GameObject[] stand;

    public TextMesh[] txtPrice;

    public TextMesh txtTalk;

    public GameObject[] items;

    private int[] itemID;

    private int[] itemQ;

    private int merchantType;

    public MerchantScript()
    {
        stand = new GameObject[4];
        txtPrice = new TextMesh[8];
        items = new GameObject[4];
        itemID = new int[4];
        itemQ = new int[4];
    }

    public virtual void Awake()
    {
        int num = UnityEngine.Random.Range(0, 10);
        if (num < 4 || GameScript.districtLevel >= 15)
        {
            merchantType = 1;
            SetItems();
        }
        else
        {
            merchantType = 2;
            SetGear();
        }
    }

    [RPC]
    public virtual void Knock22(Vector3 a)
    {
    }


    public virtual string GetRandomText()
    {
        int num = UnityEngine.Random.Range(0, 5);
        string result = null;
        switch (num)
        {
            case 0:
                result = "Get ya goods here!";
                break;
            case 1:
                result = "Waddya buyin', stranger?";
                break;
            case 2:
                result = "Got a lot of good things on sale, stranger!";
                break;
            case 3:
                result = "I have the finest items for sale!";
                break;
            case 4:
                result = "It is dangerous to go alone! Buy something.";
                break;
        }

        return result;
    }


    public virtual void OnDestroy()
    {
        int num = default(int);
        for (num = 0; num < 4; num++)
        {
            stand[num].SetActive(value: false);
        }
    }

    public virtual void SetItems()
    {
        int num = default(int);
        for (num = 0; num < 4; num++)
        {
            itemID[num] = UnityEngine.Random.Range(1, 56);
            itemQ[num] = UnityEngine.Random.Range(1, 4);
            if (itemID[num] == 49 || itemID[num] == 11 || itemID[num] == 46)
            {
                itemID[num] = 15;
            }

            if (GameScript.districtLevel >= 15)
            {
                itemID[0] = 95;
            }
        }

        if (Network.isServer)
        {
            GetComponent<NetworkView>().RPC("RefreshItemsRPC", RPCMode.All, itemID[0], itemID[1], itemID[2], itemID[3]);
        }
    }

    public virtual void SetGear()
    {
        int num = default(int);
        for (num = 0; num < 4; num++)
        {
            itemID[num] = UnityEngine.Random.Range(500, 520);
        }

        if (Network.isServer)
        {
            GetComponent<NetworkView>().RPC("RefreshItemsRPC", RPCMode.All, itemID[0], itemID[1], itemID[2], itemID[3]);
        }
    }

    [RPC]
    public virtual void RefreshItemsRPC(int id1, int id2, int id3, int id4)
    {
        items[0].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + id1);
        txtPrice[0].text = string.Empty + GetItemPrice(id1);
        items[1].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + id2);
        txtPrice[1].text = string.Empty + GetItemPrice(id2);
        items[2].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + id3);
        txtPrice[2].text = string.Empty + GetItemPrice(id3);
        items[3].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + id4);
        txtPrice[3].text = string.Empty + GetItemPrice(id4);
        txtPrice[4].text = txtPrice[0].text;
        txtPrice[5].text = txtPrice[1].text;
        txtPrice[6].text = txtPrice[2].text;
        txtPrice[7].text = txtPrice[3].text;
        stand[0].name = string.Empty + id1;
        stand[1].name = string.Empty + id2;
        stand[2].name = string.Empty + id3;
        stand[3].name = string.Empty + id4;
    }

    public virtual void RefreshItems()
    {
        int num = default(int);
        for (num = 0; num < 4; num++)
        {
            items[num].GetComponent<Renderer>().material =
                (Material)Resources.Load("i/i" + itemID[num], typeof(Material));
            stand[num].name = string.Empty + itemID[num];
        }

        txtPrice[0].text = string.Empty + GetItemPrice(itemID[0]);
        txtPrice[1].text = string.Empty + GetItemPrice(itemID[1]);
        txtPrice[2].text = string.Empty + GetItemPrice(itemID[2]);
        txtPrice[3].text = string.Empty + GetItemPrice(itemID[3]);
        txtPrice[4].text = txtPrice[0].text;
        txtPrice[5].text = txtPrice[1].text;
        txtPrice[6].text = txtPrice[2].text;
        txtPrice[7].text = txtPrice[3].text;
    }

    public virtual int GetItemPrice(int id)
    {
        int num = default(int);
        switch (id)
        {
            case 1:
                num = 5;
                break;
            case 2:
                num = 10;
                break;
            case 3:
                num = 5;
                break;
            case 4:
                num = 15;
                break;
            case 5:
                num = 30;
                break;
            case 6:
                num = 70;
                break;
            case 7:
                num = 5;
                break;
            case 8:
                num = 8;
                break;
            case 9:
            case 10:
            case 11:
                num = 10;
                break;
            case 12:
                num = 30;
                break;
            case 13:
                num = 60;
                break;
            case 14:
                num = 140;
                break;
            case 15:
            case 16:
            case 17:
                num = 20;
                break;
            case 18:
            case 19:
            case 20:
                num = 7;
                break;
            case 21:
                num = 5;
                break;
            case 22:
            case 23:
                num = 10;
                break;
            case 24:
                num = 15;
                break;
            case 25:
                num = 20;
                break;
            case 26:
                num = 10;
                break;
            case 27:
                num = 15;
                break;
            case 28:
                num = 30;
                break;
            case 29:
            case 30:
            case 31:
                num = 20;
                break;
            case 32:
                num = 60;
                break;
            case 33:
                num = 120;
                break;
            case 34:
                num = 280;
                break;
            case 35:
                num = 120;
                break;
            case 36:
                num = 240;
                break;
            case 37:
                num = 560;
                break;
            case 38:
                num = 10;
                break;
            case 39:
                num = 20;
                break;
            case 40:
                num = 40;
                break;
            case 41:
                num = 80;
                break;
            case 42:
            case 43:
                num = 45;
                break;
            case 44:
                num = 20;
                break;
            case 45:
                num = 45;
                break;
            case 46:
                num = 100;
                break;
            case 47:
                num = 30;
                break;
            case 48:
                num = 65;
                break;
            case 49:
                num = 10;
                break;
            case 50:
                num = 15;
                break;
            case 51:
            case 52:
                num = 5;
                break;
            case 53:
                num = 10;
                break;
            case 54:
                num = 20;
                break;
            case 55:
                num = 40;
                break;
            case 56:
                num = 60;
                break;
            case 95:
                num = 1000;
                break;
            case 500:
                num = 35;
                break;
            case 501:
                num = 30;
                break;
            case 502:
                num = 45;
                break;
            case 503:
            case 504:
            case 505:
                num = 120;
                break;
            case 506:
            case 507:
            case 508:
                num = 300;
                break;
            case 509:
            case 510:
            case 511:
                num = 700;
                break;
            case 512:
                num = 55;
                break;
            case 513:
                num = 50;
                break;
            case 514:
                num = 65;
                break;
            case 515:
                num = 100;
                break;
            case 516:
                num = 55;
                break;
            case 517:
                num = 50;
                break;
            case 518:
                num = 65;
                break;
            case 519:
                num = 200;
                break;
            case 550:
                num = 330;
                break;
            case 560:
                num = 135;
                break;
            case 561:
                num = 255;
                break;
            case 562:
                num = 1000;
                break;
            case 563:
                num = 95;
                break;
            case 600:
            case 601:
            case 602:
                num = 100;
                break;
            case 700:
                num = 90;
                break;
            case 701:
                num = 180;
                break;
            case 702:
                num = 420;
                break;
            case 800:
                num = 90;
                break;
            case 801:
                num = 180;
                break;
            case 802:
                num = 420;
                break;
            case 900:
                num = 90;
                break;
            case 901:
                num = 180;
                break;
            case 902:
                num = 420;
                break;
            default:
                num = 999;
                break;
        }

        return num * 2;
    }
}