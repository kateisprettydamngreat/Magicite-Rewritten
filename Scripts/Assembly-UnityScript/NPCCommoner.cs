using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class NPCCommoner : MonoBehaviour
{
    public virtual IEnumerator Talk()
    {
        while (true)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(5, 20));
            yield return new WaitForSeconds(UnityEngine.Random.Range(0, 6));
            if (Network.isServer)
            {
                GetComponent<NetworkView>().RPC("SaySomething", RPCMode.All, UnityEngine.Random.Range(0, 10));
            }
            yield return new WaitForSeconds(UnityEngine.Random.Range(0, 6));
        }
    }
    private IEnumerator SaySomething(int a)
    {
        string s = null;
        switch (a)
        {
            case 0:
                s = "Life is great.";
                break;
            case 1:
                s = "Deephaven is scary.";
                break;
            case 2:
                s = "I'm hungry";
                break;
            case 3:
                s = "I hate chicken.";
                break;
            case 4:
                s = "The Scourge suck!";
                break;
            case 5:
                s = "I miss the sun...";
                break;
            case 6:
                s = "*Cough*";
                break;
            case 7:
                s = "Someone smells funny.";
                break;
            case 8:
                s = "Idk what I want.";
                break;
            case 9:
                s = "I need to poop!";
                break;
        }
        txtTalk.text = s;
        txtTalk2.text = s;
        yield return new WaitForSeconds(2f);
        txtTalk.text = string.Empty;
        txtTalk2.text = string.Empty;
    }
    public virtual IEnumerator Start()
    {
        StartCoroutine(Move());
        yield break;
    }

    public virtual IEnumerator TDN(int dmg)
    {
        txtTalk.text = "Ow!";
        takingDamage = true;
        yield return new WaitForSeconds(0.2f);

        hp -= dmg;
        if (hp < 1)
        {
            for (int i = 0; i < GOLD; i++)
            {
                Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
            }
            if (Network.isServer)
            {
                Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
                Network.Destroy(GetComponent<NetworkView>().viewID);
            }
        }
        else
        {
            takingDamage = false;
        }

        yield return new WaitForSeconds(0.5f);
        txtTalk.text = string.Empty;
    }
    public virtual IEnumerator TDN2(int dmg)
    {
        GameObject n2 = (GameObject)Instantiate((GameObject)Resources.Load("TD", typeof(GameObject)), t.position, Quaternion.identity);
        n2.SendMessage("SD", dmg);
        base.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(0.2f);
        if (hp >= 1)
        {
            yield return new WaitForSeconds(0.2f);
            base.GetComponent<Animation>().Stop();
            takingDamage = false;
            base.transform.localPosition = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y, 0f);
        }
    }
    public virtual IEnumerator Move()
    {
        int num = UnityEngine.Random.Range(-1, 2);
        if (num != 0)
        {
            speed *= (float)num;
        }
        if (speed > 0f)
        {
            npc.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else
        {
            npc.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        canMove = true;
        yield return new WaitForSeconds(UnityEngine.Random.Range(1, 3));

        canMove = false;
        num = UnityEngine.Random.Range(-1, 2);
        if (num != 0)
        {
            speed *= (float)num;
        }
        if (speed > 0f)
        {
            npc.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else
        {
            npc.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        yield return new WaitForSeconds(UnityEngine.Random.Range(1, 10));
    }
    public virtual IEnumerator KnockN(Vector3 p)
    {
        if (p.x <= t.position.x)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(10f, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-10f, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        }

        yield return new WaitForSeconds(0.2f);

        GetComponent<Rigidbody>().velocity = new Vector3(0f, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
    }

    public virtual IEnumerator K(bool l)

    {
        if (l)
        {
            r.velocity = new Vector3(-10, 10, 0);
            yield return new WaitForEndOfFrame();
        }
        else
        {
            r.velocity = new Vector3(10, 10, 0);
            yield return new WaitForEndOfFrame();
        }
    }

	private int pos;

	private Transform t;

	private int moving;

	private int maxHP;

	private int hp;

	private bool takingDamage;

	public GameObject @base;

	public GameObject base2;

	public float speed;

	public Transform npc;

	private Rigidbody r;

	private int GOLD;

	private bool canMove;

	private int race;

	public GameObject head2;

	public GameObject head;

	public TextMesh txtTalk;

	public TextMesh txtTalk2;

	public virtual void OnDestroy()
	{
		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
	}

	public virtual void Awake()
	{
		StartCoroutine_Auto(Talk());
		race = GetRace();
		int num = UnityEngine.Random.Range(1, 49);
		if (Network.isServer)
		{
			GetComponent<NetworkView>().RPC("SetAppearance", RPCMode.All, race, UnityEngine.Random.Range(0, 3));
		}
		base2.GetComponent<Animation>()["i"].speed = 0.7f;
		GOLD = UnityEngine.Random.Range(2, 6);
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		takingDamage = false;
		maxHP = 10;
		hp = maxHP;
		t = transform;
	}

	[RPC]
	public virtual void SetAppearance(int r, int v)
	{
		head.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + r + "h" + v);
	}

	public virtual int GetRace()
	{
		int num = UnityEngine.Random.Range(0, 100);
		int num2 = default(int);
		if (num < 40)
		{
			return 0;
		}
		if (num < 60)
		{
			return 1;
		}
		if (num < 70)
		{
			return 2;
		}
		if (num < 85)
		{
			return 3;
		}
		if (num < 90)
		{
			return 4;
		}
		if (num < 95)
		{
			return 5;
		}
		return 6;
	}

	public virtual void TD(int dmg)
	{
		if (!takingDamage)
		{
			GetComponent<NetworkView>().RPC("TDN", RPCMode.All, dmg);
			GetComponent<NetworkView>().RPC("TDN2", RPCMode.All, dmg);
		}
	}

	public virtual void Die()
	{
		int num = default(int);
		for (num = 0; num < GOLD; num++)
		{
			Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
		}
		if (Network.isServer)
		{
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
			Network.Destroy(gameObject);
		}
		else
		{
			GetComponent<NetworkView>().RPC("die", RPCMode.Server);
		}
	}

	public virtual void Update()
	{
		if (canMove)
		{
			float x = speed;
			Vector3 velocity = GetComponent<Rigidbody>().velocity;
			float num = (velocity.x = x);
			Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		}
	}

	[RPC]
	public virtual void DieN(NetworkViewID id)
	{
		if (GetComponent<NetworkView>().viewID == id)
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	[RPC]
	public virtual void Initialize(NetworkViewID id)
	{
		GetComponent<NetworkView>().viewID = id;
	}

	public virtual void Knock(Vector3 p)
	{
		GetComponent<NetworkView>().RPC("KnockN", RPCMode.All, p);
	}
	}