using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class ArrowScript : MonoBehaviour
{
    public bool isBolt;
    public bool isEnemy;
    public Material fireMaterial;
    public GameObject[] baseObjects;
    public GameObject particleFire;
    public GameObject particleMulti;
    public int tier;
    public bool isRight;

    private Renderer renderer;
    private float speed = 30f;
    private int MAG;
    private bool cantMove;
    private bool initialized;
    private bool left;
    private bool fire;
    private bool exiling;
    private Transform arrowTransform;

    private void Start()
    {
        StartCoroutine(AnimateArrow());
    }

    private IEnumerator AnimateArrow()
    {
        arrowTransform = transform;
        if (isEnemy)
        {
            speed = 23f;
        }

        yield return new WaitForSeconds(0.1f);

        GetComponent<Collider>().enabled = true;

        yield return new WaitForSeconds(2f);

        StartCoroutine(Exile());
    }

    private IEnumerator Exile()
    {
        if (!exiling)
        {
            exiling = true;
            arrowTransform.position = new Vector3(0f, 0f, -500f);
            yield return new WaitForSeconds(4f);
        }

        Network.Destroy(GetComponent<NetworkView>().viewID);
        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
    }

    private void Update()
    {
        if (!cantMove)
        {
            float moveDirection = isRight ? -1f : 1f;
            arrowTransform.Translate(Vector3.left * Time.deltaTime * speed * moveDirection);
        }
    }

    private int GetDmg(int tier)
    {
        switch (tier)
        {
            case 0: return 1;
            case 1: return 1;
            case 2: return 4;
            case 3: return 11;
            case 4: return 20;
            case 5: return 40;
            default: return 1;
        }
    }

    private int GetID(int tier)
    {
        switch (tier)
        {
            case 0: return 52;
            case 1: return 53;
            case 2: return 54;
            case 3: return 55;
            case 4: return 56;
            case 5: return 57;
            default: return 53;
        }
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "fWisp" && !fire)
        {
            fire = true;
            MAG *= 2;
            GetComponent<NetworkView>().RPC("FireN", RPCMode.All);
        }
        if (!(transform.position.x <= c.gameObject.transform.position.x))
        {
            left = true;
        }
        else
        {
            left = false;
        }
        if (!isEnemy && (c.gameObject.layer == 9 || c.gameObject.layer == 12))
        {
            cantMove = true;
            c.gameObject.SendMessage("TD", MAG);
            if (Network.isServer)
            {
                StartCoroutine(Exile());
            }
        }
        else if (c.gameObject.layer == 8)
        {
            if (isEnemy)
            {
                c.gameObject.SendMessage("TD", MAG);
                StartCoroutine(Exile());
            }
            else if (MenuScript.pvp == 1 && !GetComponent<NetworkView>().isMine)
            {
                c.gameObject.SendMessage("TD", MAG);
                MonoBehaviour.print("hit");
            }
        }
        else if (c.gameObject.layer == 11 && !isBolt && !initialized && !isEnemy && GetComponent<NetworkView>().isMine)
        {
            initialized = true;
            cantMove = true;
            Item item = new Item(GetID(tier), 1, new int[4], 0f, null);
            GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), arrowTransform.position, Quaternion.identity);
            int[] array = new int[7]
            {
                item.id,
                item.q,
                item.e[0],
                item.e[1],
                item.e[2],
                item.e[3],
                item.d
            };
            gameObject.SendMessage("InitL", array);
            arrowTransform.position = new Vector3(0f, 0f, -500f);
            if (Network.isServer)
            {
                StartCoroutine(Exile());
            }
        }
    }

    [RPC]
    private void FireN()
    {
        fire = true;
        baseObjects[0].GetComponent<Renderer>().material = fireMaterial;
        baseObjects[1].GetComponent<Renderer>().material = fireMaterial;
        particleFire.SetActive(true);
    }

    [RPC]
    private void SetN(float m)
    {
        int num = (int)m;
        MAG = num + GetDmg(tier);
    }

    private void Set(int m)
    {
        GetComponent<NetworkView>().RPC("SetN", (RPCMode)m);
    }

    [RPC]
    private void SetMulti()
    {
        particleMulti.SetActive(true);
    }
}
