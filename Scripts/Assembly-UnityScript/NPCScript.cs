using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class NPCScript : MonoBehaviour
{
	public GameObject altarCoin;
	private bool disabled;
	public GameObject altarObj;
	public GameObject[] stand;
	public TextMesh txtTalk;
	public bool isMerchant;
	public bool isBlacksmith;
	public bool isTailor;
	public bool isLeatherworker;
	public bool isTreasureHunter;
	public bool isAltar;
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
	
	[RPC]
	public virtual IEnumerator TalkN(string a)
	{
		while (true)
		{
			txtTalk.text = a + string.Empty;
			yield return new WaitForSeconds(2f);
			txtTalk.text = string.Empty;
			yield return null;
		}
	}

	public virtual IEnumerator Start()
	{
		if (!isAltar)
		{
			yield break;
		}

		yield return StartCoroutine_Auto(Move());
	}
	[RPC]
	public virtual IEnumerator TDN(int dmg)
	{
		takingDamage = true;
		yield return new WaitForSeconds(0.2f);

		hp -= dmg;
		int i;
		if (hp < 1)
		{
			for (i = 0; i < GOLD; i++)
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

		yield return null;
	}

	[RPC]
	public IEnumerator TDN2(int dmg)
	{
		GameObject n2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("TD", typeof(GameObject)), t.position, Quaternion.identity);
		n2.SendMessage("SD", dmg);
		@base.GetComponent<Animation>().Play();

		yield return new WaitForSeconds(0.2f);

		if (hp >= 1)
		{
			yield return new WaitForSeconds(0.2f);
			@base.GetComponent<Animation>().Stop();
			takingDamage = false;
			Vector3 originalPosition = @base.transform.localPosition;
			originalPosition.z = 0;
			@base.transform.localPosition = originalPosition;
		}
		else
		{
			yield return null;
		}
	}

	public IEnumerator Move()
	{
		canMove = true;

		yield return new WaitForSeconds(UnityEngine.Random.Range(1, 3));

		canMove = false;

		yield return new WaitForSeconds(UnityEngine.Random.Range(1, 10));

		canMove = true;

		yield return new WaitForSeconds(UnityEngine.Random.Range(1, 4));

		canMove = false;

		yield return new WaitForSeconds(UnityEngine.Random.Range(1, 10));
	}

	[RPC]
	public virtual IEnumerator<WaitForSeconds> Talk(int a) {
    while (true) {
        string message = null;

        switch(a) {
            case 1:
                message = "Smelt your ores!";
                break;
            case 3:
                message = "Refine your Monster Hide!";
                break;
            case 4:
                message = "Craft fancy fabrics!";
                break;
            case 5:
                message = "Sell me your treasure!";
                break;
            default:
                yield break; // Exit the coroutine for unknown cases
        }

        if (Network.isServer) {
            this.GetComponent<NetworkView>().RPC("TalkN", RPCMode.All, message);
        }

        yield return new WaitForSeconds(UnityEngine.Random.Range(5, 11));
    }}
//Now exiting: enumeration station

	public NPCScript()
	{
		stand = new GameObject[4];
	}

	public virtual void OnDestroy()
	{
		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
	}

	public virtual void Awake()
	{
		base2.GetComponent<Animation>()["i"].speed = 0.5f;
		GOLD = UnityEngine.Random.Range(2, 6);
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		takingDamage = false;
		maxHP = 50;
		hp = maxHP;
		t = transform;
		if (isBlacksmith)
		{
			StartCoroutine_Auto(Talk(1));
		}
		else if (isLeatherworker)
		{
			StartCoroutine_Auto(Talk(3));
		}
		else if (isTailor)
		{
			StartCoroutine_Auto(Talk(4));
		}
		else if (isTreasureHunter)
		{
			StartCoroutine_Auto(Talk(5));
		}
		else if (isAltar)
		{
			InitializeAltar();
		}
	}

	public virtual void InitializeAltar()
	{
		int num = UnityEngine.Random.Range(0, 8);
		altarObj.GetComponent<Renderer>().material = (Material)Resources.Load("altar" + num);
		GameScript.curAltar = num;
	}

	[RPC]
	public virtual void O()
	{
		int num = 0;
		for (num = 0; num < 4; num++)
		{
			stand[num].SetActive(value: false);
		}
	}

	public virtual void TD(int dmg)
	{
		if (!isMerchant && !isBlacksmith && !isTailor && !isTreasureHunter && !isLeatherworker && !isAltar)
		{
			if (isMerchant)
			{
				GetComponent<NetworkView>().RPC("O", RPCMode.All);
			}
			if (!takingDamage)
			{
				GetComponent<NetworkView>().RPC("TDN", RPCMode.All, dmg);
				GetComponent<NetworkView>().RPC("TDN2", RPCMode.All, dmg);
			}
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
			Network.Instantiate(Resources.Load("noInter"), t.position, Quaternion.identity, 0);
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
		if (canMove && !isAltar)
		{
			float x = speed;
			Vector3 velocity = GetComponent<Rigidbody>().velocity;
			float num = (velocity.x = x);
			Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		}
		if (isAltar && GameScript.usedAltar && !disabled)
		{
			disabled = true;
			Disable();
		}
	}

	public virtual void Disable()
	{
		altarObj.SetActive(value: false);
		altarCoin.SetActive(value: false);
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
}