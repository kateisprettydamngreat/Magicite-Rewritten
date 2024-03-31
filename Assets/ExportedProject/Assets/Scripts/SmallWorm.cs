using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SmallWorm : MonoBehaviour
{
    public virtual IEnumerator Start()
    {
        HP = maxHP;
        drops = new int[3] { 7, 18, 0 };
        t = transform;
        Initialize();
        if (isHead)
        {
            mainHead.GetComponent<Animation>().Play();
            yield return new WaitForSeconds(0.1f);
            for (int i = 0; i < 5; i++)
            {
                parts[i].GetComponent<Animation>().Play("wBody");
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
    IEnumerator Attack()
    {
        time = UnityEngine.Random.Range(8, 11);
        curVector = player.transform.position - t.position;
        attacking = true;
        yield return new WaitForSeconds(time);
        attacking = false;
    }

    public virtual IEnumerator TDN(int dmg)
    {
        takingDamage = true;
        yield return new WaitForSeconds(0.2f);
        HP -= dmg;
        if (HP < 1)
        {
            Die();
        }
        else
        {
            takingDamage = false;
        }
    }
    public virtual IEnumerator TDN2(int dmg)
    {
        GameObject n2 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("TD", typeof(GameObject)), t.position, Quaternion.identity);
        n2.SendMessage("SD", dmg);
        yield return new WaitForSeconds(0.2f);
        yield return new WaitForSeconds(0.2f);
        if (HP >= 1)
        {
            yield return new WaitForSeconds(0.2f);
            takingDamage = false;
        }
    }

	public bool isHead;

	public GameObject head;

	public float speed;

	public float space;

	public float time;

	public GameObject mainHead;

	public Material leadHead;

	public GameObject[] parts;

	private Transform t;

	private bool moving;

	private GameObject player;

	private Vector3 curVector;

	private bool attacking;

	private Vector3 a;

	private Vector3 b;

	private int HP;

	private int maxHP;

	private int GOLD;

	public int[] drops;

	private bool takingDamage;

	public SmallWorm()
	{
		parts = new GameObject[5];
		maxHP = 10;
		GOLD = 10;
		drops = new int[3];
	}


	public virtual void Initialize()
	{
		if (!isHead)
		{
		}
	}


	public virtual void Update()
	{
		if (!head)
		{
			head = gameObject;
			isHead = true;
			Initialize();
		}
		if (isHead)
		{
			if (attacking)
			{
				t.Translate(curVector.normalized * speed * Time.deltaTime);
			}
			return;
		}
		if (!(Mathf.Abs(head.transform.position.x - t.position.x) <= space))
		{
			t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
		}
		if (!(Mathf.Abs(head.transform.position.y - t.position.y) <= space))
		{
			t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
		}
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
		GameObject gameObject = null;
		int num = default(int);
		for (num = 0; num < GOLD; num++)
		{
			Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
		}
		if (drops[0] > 0 && UnityEngine.Random.Range(0, 2) == 0)
		{
			int num2 = UnityEngine.Random.Range(1, 3);
			for (num = 0; num < num2; num++)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, drops[0]);
			}
		}
		if (drops[1] > 0 && UnityEngine.Random.Range(0, 4) == 0)
		{
			int num3 = UnityEngine.Random.Range(1, 3);
			for (num = 0; num < num3; num++)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, drops[1]);
			}
		}
		UnityEngine.Object.Destroy(this.gameObject);
		if (Network.isServer)
		{
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
			Network.Destroy(GetComponent<NetworkView>().viewID);
		}
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			c.SendMessage("TD", 10);
		}
	}

	}