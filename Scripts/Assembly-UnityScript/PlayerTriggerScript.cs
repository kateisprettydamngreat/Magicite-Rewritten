using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class PlayerTriggerScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00242351 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalDMG_00242352;

			internal int _0024poo_00242353;

			internal int _0024i_00242354;

			internal Item _0024droppedItem_00242355;

			internal GameObject _0024ddd_00242356;

			internal int[] _0024stats_00242357;

			internal int _0024se_00242358;

			internal GameObject _0024n2_00242359;

			internal int _0024DMG_00242360;

			internal PlayerTriggerScript _0024self__00242361;

			public _0024(int DMG, PlayerTriggerScript self_)
			{
				_0024DMG_00242360 = DMG;
				_0024self__00242361 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024finalDMG_00242352 = _0024DMG_00242360 - ShieldDEF;
					if (_0024finalDMG_00242352 < 1)
					{
						_0024finalDMG_00242352 = 1;
					}
					if (_0024self__00242361.GetComponent<NetworkView>().isMine && canTakeDamage && !GameScript.win)
					{
						GameScript.hitsTaken++;
						if (MenuScript.pHat == 24)
						{
							_0024finalDMG_00242352 = (int)((float)_0024finalDMG_00242352 * 0.5f);
						}
						if (MenuScript.pHat == 13)
						{
							_0024poo_00242353 = UnityEngine.Random.Range(0, 5);
							if (_0024poo_00242353 == 0)
							{
								_0024i_00242354 = default(int);
								_0024droppedItem_00242355 = null;
								_0024ddd_00242356 = null;
								_0024stats_00242357 = null;
								if (!(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= _0024self__00242361.player.transform.position.x))
								{
									_0024ddd_00242356 = (GameObject)Network.Instantiate(Resources.Load("iNetwork"), new Vector3(_0024self__00242361.player.transform.position.x + 3f, _0024self__00242361.player.transform.position.y, 0f), Quaternion.identity, 0);
								}
								else
								{
									_0024ddd_00242356 = (GameObject)Network.Instantiate(Resources.Load("iNetwork"), new Vector3(_0024self__00242361.player.transform.position.x - 3f, _0024self__00242361.player.transform.position.y, 0f), Quaternion.identity, 0);
								}
								_0024droppedItem_00242355 = new Item(UnityEngine.Random.Range(9, 12), 1, new int[3], 0f, null);
								_0024stats_00242357 = new int[7] { _0024droppedItem_00242355.id, _0024droppedItem_00242355.q, 0, 0, 0, 0, 0 };
								_0024ddd_00242356.GetComponent<NetworkView>().RPC("InitL", RPCMode.All, _0024stats_00242357);
							}
						}
						else if (MenuScript.pHat == 14)
						{
							_0024se_00242358 = UnityEngine.Random.Range(0, 10);
							if (_0024se_00242358 == 0)
							{
								Network.Instantiate(Resources.Load("e/broodmother"), new Vector3(_0024self__00242361.transform.position.x, _0024self__00242361.transform.position.y + 50f, 0f), Quaternion.identity, 0);
							}
						}
						_0024self__00242361.GetComponent<AudioSource>().PlayOneShot(_0024self__00242361.ow);
						canTakeDamage = false;
						_0024n2_00242359 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("TD1", typeof(GameObject)), _0024self__00242361.transform.position, Quaternion.identity);
						_0024n2_00242359.SendMessage("SDN", _0024finalDMG_00242352);
						_0024self__00242361.gameScript.TD(_0024finalDMG_00242352);
						_0024self__00242361.gameScript.LoadHearts();
						GameScript.canTakeDamage = false;
						_0024self__00242361.StartCoroutine_Auto(_0024self__00242361.GetHit());
						if (GameScript.HP >= 1)
						{
							result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
						GameScript.HP = 0;
						_0024self__00242361.player.SendMessage("Die");
						if (MenuScript.deathA == 1)
						{
							_0024self__00242361.player.SendMessage("DeathAnim");
						}
						isDead = true;
						_0024self__00242361.@base.GetComponent<Animation>().Play("dead");
					}
					goto IL_0409;
				case 2:
					canTakeDamage = true;
					goto IL_0409;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0409:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024DMG_00242362;

		internal PlayerTriggerScript _0024self__00242363;

		public _0024TD_00242351(int DMG, PlayerTriggerScript self_)
		{
			_0024DMG_00242362 = DMG;
			_0024self__00242363 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024DMG_00242362, _0024self__00242363);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GetHit_00242364 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024845_00242365;

			internal Vector3 _0024_0024846_00242366;

			internal int _0024_0024847_00242367;

			internal Vector3 _0024_0024848_00242368;

			internal PlayerTriggerScript _0024self__00242369;

			public _0024(PlayerTriggerScript self_)
			{
				_0024self__00242369 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242369.GetComponent<Animation>().Play();
					_0024self__00242369.gameScript.heartsObj.GetComponent<Animation>().Play();
					result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00242369.GetComponent<Animation>().Stop();
					_0024self__00242369.gameScript.heartsObj.GetComponent<Animation>().Stop();
					GameScript.canTakeDamage = true;
					int num = (_0024_0024845_00242365 = 0);
					Vector3 vector = (_0024_0024846_00242366 = _0024self__00242369.transform.localPosition);
					float num2 = (_0024_0024846_00242366.z = _0024_0024845_00242365);
					Vector3 vector3 = (_0024self__00242369.transform.localPosition = _0024_0024846_00242366);
					int num3 = (_0024_0024847_00242367 = 20);
					Vector3 vector4 = (_0024_0024848_00242368 = _0024self__00242369.gameScript.heartsObj.transform.localPosition);
					float num4 = (_0024_0024848_00242368.z = _0024_0024847_00242367);
					Vector3 vector6 = (_0024self__00242369.gameScript.heartsObj.transform.localPosition = _0024_0024848_00242368);
					YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerTriggerScript _0024self__00242370;

		public _0024GetHit_00242364(PlayerTriggerScript self_)
		{
			_0024self__00242370 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242370);
		}
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

	public virtual IEnumerator TD(int DMG)
	{
		return new _0024TD_00242351(DMG, this).GetEnumerator();
	}

	public virtual IEnumerator GetHit()
	{
		return new _0024GetHit_00242364(this).GetEnumerator();
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
				StartCoroutine_Auto(TD(1));
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
		return s switch
		{
			"d0" => 0, 
			"d1" => 1, 
			"d2" => 2, 
			"d3" => 3, 
			_ => num, 
		};
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

	public virtual void Main()
	{
	}
}
