using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class PlayerTriggerScript : MonoBehaviour
{
    public virtual IEnumerator TD(int DMG)
    {
        int finalDMG = DMG - ShieldDEF;
        if (finalDMG < 1)
        {
            finalDMG = 1;
        }
        if (GetComponent<NetworkView>().isMine && canTakeDamage && !GameScript.win)
        {
            GameScript.hitsTaken++;
            if (MenuScript.pHat == 24)
            {
                finalDMG = (int)((float)finalDMG * 0.5f);
            }
            if (MenuScript.pHat == 13)
            {
                int poo = UnityEngine.Random.Range(0, 5);
                if (poo == 0)
                {
                    int i = default(int);
                    Item droppedItem = null;
                    GameObject ddd = null;
                    int[] stats = null;
                    if (!(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= player.transform.position.x))
                    {
                        ddd = (GameObject)Network.Instantiate(Resources.Load("iNetwork"), new Vector3(player.transform.position.x + 3f, player.transform.position.y, 0f), Quaternion.identity, 0);
                    }
                    else
                    {
                        ddd = (GameObject)Network.Instantiate(Resources.Load("iNetwork"), new Vector3(player.transform.position.x - 3f, player.transform.position.y, 0f), Quaternion.identity, 0);
                    }
                    droppedItem = new Item(UnityEngine.Random.Range(9, 12), 1, new int[3], 0f, null);
                    stats = new int[7] { droppedItem.id, droppedItem.q, 0, 0, 0, 0, 0 };
                    ddd.GetComponent<NetworkView>().RPC("InitL", RPCMode.All, stats);
                }
            }
            else if (MenuScript.pHat == 14)
            {
                int se = UnityEngine.Random.Range(0, 10);
                if (se == 0)
                {
                    Network.Instantiate(Resources.Load("e/broodmother"), new Vector3(transform.position.x, transform.position.y + 50f, 0f), Quaternion.identity, 0);
                }
            }
            GetComponent<AudioSource>().PlayOneShot(ow);
            canTakeDamage = false;
            GameObject n2 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("TD1", typeof(GameObject)), transform.position, Quaternion.identity);
            n2.SendMessage("SDN", finalDMG);
            gameScript.TD(finalDMG);
            gameScript.LoadHearts();
            GameScript.canTakeDamage = false;
            StartCoroutine(GetHit());
            if (GameScript.HP >= 1)
            {
                yield return new WaitForSeconds(1f);
                canTakeDamage = true;
            }
            else
            {
                GameScript.HP = 0;
                player.SendMessage("Die");
                if (MenuScript.deathA == 1)
                {
                    player.SendMessage("DeathAnim");
                }
                isDead = true;
                @base.GetComponent<Animation>().Play("dead");
            }
        }
    }


    private IEnumerator GetHit()
    {
        GetComponent<Animation>().Play();
        gameScript.heartsObj.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(0.7f);
        GetComponent<Animation>().Stop();
        gameScript.heartsObj.GetComponent<Animation>().Stop();
        GameScript.canTakeDamage = true;
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 0);
        gameScript.heartsObj.transform.localPosition = new Vector3(gameScript.heartsObj.transform.localPosition.x, gameScript.heartsObj.transform.localPosition.y, 20);
    }

	public AudioClip ow;

	[NonSerialized]
	public static int ShieldDEF;

	[NonSerialized]
	public static int itemPurchasing;

	[NonSerialized]
	public static GameObject purchasingItem;

	[NonSerialized]
	public static GameObject currentStand;

	[NonSerialized]
	public static bool cantTakeDamage;

	[NonSerialized]
	public static bool isDead;

	public GameObject player;

	public GameObject @base;

	public GameObject txtDmg;

	public GameObject bW;

	public GameScript gameScript;

	public AudioClip coinGet;

	public AudioClip expGet;

	public bool canLeave;

	[NonSerialized]
	public static bool canTakeDamage;

	private PlayerController pController;

	public bool canFortune;

	[NonSerialized]
	public static GameObject fortuneObj;

	public virtual void Awake()
	{
		ShieldDEF = 0;
		cantTakeDamage = false;
		pController = (PlayerController)player.GetComponent("PlayerController");
		canTakeDamage = true;
		canLeave = false;
		gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
	}

	public virtual void OnLevelWasLoaded(int level)
	{
		gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
	}

	public virtual void AddItem(Item a)
	{
		if (gameScript.AddItem(a) != 0)
		{
			GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/pickup", typeof(AudioClip)));
			a.g.GetComponent<NetworkView>().RPC("Exile", RPCMode.All);
		}
	}

	public virtual void AddItemL(Item a)
	{
		if (gameScript.AddItem(a) != 0)
		{
			GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/pickup", typeof(AudioClip)));
			UnityEngine.Object.Destroy(a.g);
		}
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (!GetComponent<NetworkView>().isMine)
		{
			return;
		}
		string text = c.tag;
		if (c.gameObject.layer == 26 && c.gameObject.name == "nF")
		{
			canFortune = true;
			fortuneObj = c.gameObject;
		}
		if (c.gameObject.layer == 29)
		{
			GameScript.isShopping = true;
			itemPurchasing = int.Parse(c.gameObject.name);
			player.SendMessage("WW");
			GameScript.canInteract = true;
			currentStand = c.gameObject;
		}
		if (text == "fireTrig")
		{
			GameScript.isCooking = true;
		}
		if (c.gameObject.layer == 15)
		{
			if (GetComponent<NetworkView>().isMine)
			{
				c.gameObject.SendMessage("Hit", gameObject);
			}
		}
		else if (c.gameObject.layer == 17)
		{
			player.GetComponent<NetworkView>().RPC("AddGold", RPCMode.All);
			GetComponent<AudioSource>().PlayOneShot(coinGet);
			c.gameObject.SendMessage("Die");
		}
		else if (c.gameObject.layer == 23)
		{
			if (GetComponent<NetworkView>().isMine)
			{
				GetComponent<AudioSource>().PlayOneShot(expGet);
				if (c.gameObject.tag == "huge")
				{
					player.SendMessage("AddEXP", 2);
				}
				else if (c.gameObject.tag == "big")
				{
					player.SendMessage("AddEXP", 1);
				}
				else
				{
					player.SendMessage("AddEXP", (object)0);
				}
				c.gameObject.SendMessage("Die");
			}
		}
		else if (c.gameObject.layer == 18)
		{
			if (!(c.gameObject.tag == "arrow"))
			{
			}
		}
		else if (c.gameObject.layer == 25)
		{
			if (GetComponent<NetworkView>().isMine && !c.gameObject.GetComponent<NetworkView>().isMine)
			{
				player.SendMessage("bW", c.gameObject);
			}
		}
		else if (c.gameObject.layer == 27)
		{
			MonoBehaviour.print("HIT BY haz2");
			if (!c.gameObject.GetComponent<NetworkView>().isMine)
			{
				StartCoroutine(TD(1));
			}
		}
		else if (c.gameObject.layer == 26)
		{
			if (GetComponent<NetworkView>().isMine && !GameScript.interacting)
			{
				player.SendMessage("WW", c.gameObject);
				GameScript.canInteract = true;
				GameScript.interacter = c.gameObject.name;
			}
		}
		else
		{
			switch (text)
			{
			case "door0":
				SetDoor(0);
				break;
			case "door1":
				SetDoor(1);
				break;
			case "door2":
				SetDoor(2);
				break;
			}
		}
		if (c.gameObject.layer == 30)
		{
			MonoBehaviour.print("CANNOT INTERACT");
			GameScript.canInteract = false;
			GameScript.interacter = null;
		}
	}

	public virtual void SetDoor(int d)
	{
		player.GetComponent<NetworkView>().RPC("SDoor", RPCMode.All, d);
		if (GetComponent<NetworkView>().isMine)
		{
			canLeave = true;
			GameScript.curDoor = d;
		}
		GameScript.curDoor = d;
	}

	public virtual int SetBiome(string s, int d)
	{
		if (GetComponent<NetworkView>().isMine)
		{
			GameScript.curDoor = d;
		}
		int num = default(int);
		switch (s)
		{
			case "d0":
				return 0;
			case "d1":
				return 1;
			case "d2":
				return 2;
			case "d3":
				return 3;
			default:
				return num;
		}
	}

	public virtual void Set()
	{
		gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
	}

	public virtual void OnTriggerExit(Collider c)
	{
		string text = c.tag;
		if (c.gameObject.layer == 29)
		{
			GameScript.isShopping = false;
			itemPurchasing = 0;
			player.SendMessage("WW2");
			purchasingItem = c.gameObject;
		}
		switch (text)
		{
		case "signEnter":
		case "sign":
		case "signComplete":
			bW.GetComponent<Renderer>().enabled = false;
			gameScript.Action(0);
			break;
		case "door0":
		case "door1":
		case "door2":
			canLeave = false;
			break;
		default:
			if (c.gameObject.layer == 25)
			{
				if (GetComponent<NetworkView>().isMine)
				{
					player.SendMessage("bWN");
				}
			}
			else if (text == "fireTrig")
			{
				GameScript.isCooking = false;
				MonoBehaviour.print("NOT COOKING");
			}
			break;
		}
		if (c.gameObject.layer == 26)
		{
			MonoBehaviour.print("CANNOT INTERACT");
			player.SendMessage("WW2");
			GameScript.canInteract = false;
			GameScript.interacter = null;
		}
	}

	}