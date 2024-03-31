using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class EnemyScript : MonoBehaviour
{
    public virtual IEnumerator SetStatsN(int hp, int atk)
    {
        yield return new WaitForSeconds(0.5f);
        MAXHP = hp;
        HP = hp;
        ATK = atk;
    }

    [RPC]
    public virtual IEnumerator Exile()
    {
        if (!exiling)
        {
            exiling = true;
            t.position = new Vector3(0f, 0f, -500f);
            yield return new WaitForSeconds(4f);
            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
        }
    }

    public virtual IEnumerator Knock22(Vector3 p)
    {
        bool wasK = false;
        if (r.isKinematic)
        {
            wasK = true;
            GetComponent<Rigidbody>().isKinematic = false;
        }
        GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, 2f, GetComponent<Rigidbody>().velocity.z);
        if (p.x <= t.position.x)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(10f, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-10f, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        }
        yield return new WaitForSeconds(0.2f);
        if (wasK)
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    public virtual IEnumerator KnockN(Vector3 p)
    {
        Vector3 velocity = GetComponent<Rigidbody>().velocity;
        velocity.y = 2;
        GetComponent<Rigidbody>().velocity = velocity;

        if (p.x <= t.position.x)
        {
            velocity = GetComponent<Rigidbody>().velocity;
            velocity.x = 10;
            GetComponent<Rigidbody>().velocity = velocity;
        }
        else
        {
            velocity = GetComponent<Rigidbody>().velocity;
            velocity.x = -10;
            GetComponent<Rigidbody>().velocity = velocity;
        }

        yield return new WaitForSeconds(0.2f);

        velocity = GetComponent<Rigidbody>().velocity;
        velocity.x = 0;
        GetComponent<Rigidbody>().velocity = velocity;
    }

    public IEnumerator TDN(int dmg)
    {
        GameObject n3 = (GameObject)Instantiate(Resources.Load("TD", typeof(GameObject)), t.position, Quaternion.identity);
        n3.SendMessage("SDN", dmg);
        takingDamage = true;
        e.GetComponent<Animation>().Play();
        HP -= dmg;
        if (Network.isServer && bossID == 99 && HP < 1000 && !sworded)
        {
            sworded = true;
            sword3 = (GameObject)Network.Instantiate(Resources.Load("ghostSword"), t.position, Quaternion.identity, 0);
            sword3.SendMessage("Set", gameObject);
        }
        if (HP < 1)
        {
            StartCoroutine(Die());
        }
        else
        {
            takingDamage = false;
        }
        e.GetComponent<Animation>().Play();
        if (!GetComponent<Rigidbody>().isKinematic)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        }
        if (HP >= 1)
        {
            yield return new WaitForSeconds(0.2f);
            e.GetComponent<Animation>().Stop();
            takingDamage = false;
            e.transform.localPosition = new Vector3(e.transform.localPosition.x, e.transform.localPosition.y, 0);
        }
    }


    public virtual IEnumerator Die()
    {
        if (!dyindood)
        {
            GameObject d = null;
            int i = default(int);
            Item item = null;
            if (isChicken && Network.isServer)
            {
                int ppp = UnityEngine.Random.Range(0, 8);
                if (ppp == 0)
                {
                    Network.Instantiate(Resources.Load("e/chickenKing"), new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
                }
            }
            if (bossID > 0)
            {
                GameScript.tempStats[10] = GameScript.tempStats[10] + 1;
            }
            if (bossID == 1)
            {
                MenuScript.canUnlockHat[8] = 1;
            }
            else if (bossID == 2)
            {
                MenuScript.canUnlockHat[14] = 1;
            }
            else if (bossID == 3)
            {
                MenuScript.canUnlockHat[18] = 1;
            }
            else if (bossID == 4)
            {
                MenuScript.canUnlockHat[20] = 1;
            }
            else if (bossID == 5)
            {
                MenuScript.canUnlockHat[21] = 1;
            }
            else if (bossID == 6)
            {
                MenuScript.canUnlockHat[22] = 1;
            }
            else if (bossID == 99 && Network.isServer)
            {
                GetComponent<NetworkView>().RPC("DED", RPCMode.All);
            }
            GameScript.tempStats[1] = GameScript.tempStats[1] + 1;
            if (GameScript.tempStats[1] > 14)
            {
                MenuScript.canUnlockRace[1] = 1;
            }
            else if (GameScript.tempStats[1] >= 10)
            {
                MenuScript.canUnlockHat[3] = 1;
            }
            if (Network.isServer)
            {
                GetComponent<NetworkView>().RPC("DropLocal", RPCMode.All);
            }
            if (Network.isServer)
            {
                if (bossID == 99)
                {
                    dyindood = true;
                    yield return new WaitForSeconds(0.5f);
                }
                StartCoroutine(Exile());
            }
        }
    }
	
    private IEnumerator KN(bool l)
    {
        knocking = true;
        bool wasK = false;
        if (r.isKinematic)
        {
            wasK = true;
            r.isKinematic = false;
        }
        if (l)
        {
            r.velocity = new Vector3(-15, r.velocity.y, r.velocity.z);
            r.velocity = new Vector3(r.velocity.x, 10, r.velocity.z);
            yield return new WaitForEndOfFrame();
        }
        else
        {
            r.velocity = new Vector3(15, r.velocity.y, r.velocity.z);
            r.velocity = new Vector3(r.velocity.x, 10, r.velocity.z);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(0.2f);
        knocking = false;
        if (wasK)
        {
            r.isKinematic = true;
        }
    }


	public bool isChicken;

	public int bossID;

	public AudioClip a;

	public AudioClip aHit;

	public GameObject @base;

	public GameObject e;

	public bool moving;

	public int dir;

	public int HP;

	public int MAXHP;

	public int ATK;

	public int DEF;

	public int EXP;

	public int SPD;

	public int[] drops;

	public Transform t;

	public bool takingDamage;

	public Rigidbody r;

	private int GOLD;

	private int exp;

	public bool attacking;

	public bool knocking;

	private float poisonDMG;

	private bool dyindood;

	private GameObject sword3;

	private GameObject sword4;

	private bool sworded;

	private bool exiling;

	public EnemyScript()
	{
		drops = new int[3];
	}

	public virtual void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
	}

	public virtual void SetStats(int HP, int ATK, int DEF, int EXP, float SPD, int[] drops, int coins, int exp)
	{
		MAXHP = HP;
		this.HP = MAXHP;
		this.ATK = ATK;
		this.DEF = DEF;
		this.EXP = EXP;
		this.SPD = (int)SPD;
		this.drops = drops;
		GOLD = coins;
		this.exp = exp;
		poisonDMG = MAXHP;
		poisonDMG *= 0.2f;
		MAXHP = (int)((float)MAXHP + (float)HP * 0.5f * (float)Network.connections.Length);
		this.ATK = (int)((float)this.ATK + (float)ATK * 0.4f * (float)Network.connections.Length);
		GetComponent<NetworkView>().RPC("SetStatsN", RPCMode.All, MAXHP, this.ATK);
	}

	public virtual void Update()
	{
		if (!attacking && !knocking)
		{
			if (dir == 1 && moving)
			{
				@base.GetComponent<Animation>().Play("r");
				int num = -SPD;
				Vector3 velocity = GetComponent<Rigidbody>().velocity;
				float num2 = (velocity.x = num);
				Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
				e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			}
			else if (dir == 2 && moving)
			{
				@base.GetComponent<Animation>().Play("r");
				int sPD = SPD;
				Vector3 velocity2 = GetComponent<Rigidbody>().velocity;
				float num3 = (velocity2.x = sPD);
				Vector3 vector4 = (GetComponent<Rigidbody>().velocity = velocity2);
				e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			else
			{
				@base.GetComponent<Animation>().Play("i");
			}
		}
	}

	public virtual void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.layer == 8)
		{
			c.gameObject.SendMessage("TD", ATK);
		}
	}


	public virtual void Knock(Vector3 p)
	{
		GetComponent<NetworkView>().RPC("KnockN", RPCMode.All, p);
	}


	public virtual void TD(int dmg)
	{
		if (!takingDamage)
		{
			GetComponent<AudioSource>().PlayOneShot(aHit);
			int num = dmg;
			if (num < 1)
			{
				num = 1;
			}
			GetComponent<NetworkView>().RPC("TDN", RPCMode.All, num);
		}
	}


	[RPC]
	public virtual void DED()
	{
		MenuScript.canUnlockRace[14] = 1;
		GameObject gameObject = GameObject.Find("musicBox");
		gameObject.SendMessage("SetNormal");
	}



	[RPC]
	public virtual void DropLocal()
	{
		int num = default(int);
		Item item = null;
		GameObject gameObject = null;
		int[] array = null;
		for (num = 0; num < GOLD; num++)
		{
			UnityEngine.Object.Instantiate(Resources.Load("c"), t.position, Quaternion.identity);
		}
		int num2 = exp;
		while (num2 >= 20)
		{
			num2 -= 20;
			UnityEngine.Object.Instantiate(Resources.Load("expHuge"), t.position, Quaternion.identity);
		}
		while (num2 >= 8)
		{
			num2 -= 8;
			UnityEngine.Object.Instantiate(Resources.Load("expBig"), t.position, Quaternion.identity);
		}
		for (num = 0; num < num2; num++)
		{
			UnityEngine.Object.Instantiate(Resources.Load("exp"), t.position, Quaternion.identity);
		}
		if (drops[0] > 0 && UnityEngine.Random.Range(0, 2) == 0)
		{
			int num3 = UnityEngine.Random.Range(1, 3);
			for (num = 0; num < num3; num++)
			{
				item = new Item(drops[0], 1, new int[4], 0f, null);
				if (item.id == 566)
				{
					item.e = new int[4] { -3, 100, 0, 0 };
					item.d = 100;
				}
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
				array = new int[7]
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
			}
		}
		if (drops[1] > 0 && UnityEngine.Random.Range(0, 4) == 0)
		{
			int num4 = UnityEngine.Random.Range(1, 3);
			item = new Item(drops[1], 1, new int[2], 0f, null);
			for (num = 0; num < num4; num++)
			{
				if (item.id == 566)
				{
					item.e = new int[4] { -3, 100, 0, 0 };
					item.d = 100;
				}
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
				array = new int[7] { item.id, item.q, 0, 0, 0, 0, item.d };
				gameObject.SendMessage("InitL", array);
			}
		}
		if (drops[2] > 0 && UnityEngine.Random.Range(0, 8) == 0)
		{
			int num5 = UnityEngine.Random.Range(1, 3);
			item = new Item(drops[2], 1, new int[4], 0f, null);
			if (item.id == 566)
			{
				item.e = new int[4] { -3, 100, 0, 0 };
				item.d = 100;
			}
			for (num = 0; num < num5; num++)
			{
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), t.position, Quaternion.identity);
				array = new int[7]
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
			}
		}
	}


	public virtual void K(bool l)
	{
		GetComponent<NetworkView>().RPC("KN", RPCMode.All, l);
	}

	public virtual void TDp()
	{
		int dmg = (int)poisonDMG;
		TD(dmg);
	}

	}