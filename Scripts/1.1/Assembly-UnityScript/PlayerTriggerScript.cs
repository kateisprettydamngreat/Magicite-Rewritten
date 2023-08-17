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
	internal sealed class _0024TD_00242455 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalDMG_00242456;

			internal int _0024poo_00242457;

			internal Item _0024item_00242458;

			internal GameObject _0024d_00242459;

			internal int _0024se_00242460;

			internal GameObject _0024n2_00242461;

			internal int _0024DMG_00242462;

			internal PlayerTriggerScript _0024self__00242463;

			public _0024(int DMG, PlayerTriggerScript self_)
			{
				_0024DMG_00242462 = DMG;
				_0024self__00242463 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0276: Unknown result type (might be due to invalid IL or missing references)
				//IL_0286: Unknown result type (might be due to invalid IL or missing references)
				//IL_028b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0296: Expected O, but got Unknown
				//IL_0296: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Expected O, but got Unknown
				//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0104: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Expected O, but got Unknown
				//IL_037d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0387: Expected O, but got Unknown
				//IL_0204: Unknown result type (might be due to invalid IL or missing references)
				//IL_0209: Unknown result type (might be due to invalid IL or missing references)
				//IL_021c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0221: Unknown result type (might be due to invalid IL or missing references)
				//IL_022f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0234: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024finalDMG_00242456 = _0024DMG_00242462 - ShieldDEF;
					if (_0024finalDMG_00242456 < 1)
					{
						_0024finalDMG_00242456 = 1;
					}
					if (MenuScript.multiplayer > 0 && ((Component)_0024self__00242463).networkView.isMine && canTakeDamage && !GameScript.win)
					{
						GameScript.hitsTaken++;
						if (MenuScript.pHat == 24)
						{
							_0024finalDMG_00242456 = (int)((float)_0024finalDMG_00242456 * 0.5f);
						}
						if (MenuScript.pHat == 13)
						{
							_0024poo_00242457 = Random.Range(0, 5);
							if (_0024poo_00242457 == 0)
							{
								_0024item_00242458 = new Item(Random.Range(9, 12), 1, new int[4], 0f, null);
								_0024d_00242459 = (GameObject)Network.Instantiate(Resources.Load("item"), ((Component)_0024self__00242463).transform.position, Quaternion.identity, 1);
								_0024d_00242459.networkView.RPC("SetID", (RPCMode)6, new object[1] { _0024item_00242458.id });
								_0024d_00242459.networkView.RPC("SetD", (RPCMode)6, new object[1] { _0024item_00242458.d });
								_0024d_00242459.networkView.RPC("SetE", (RPCMode)6, new object[1] { _0024item_00242458.e });
								_0024d_00242459.networkView.RPC("SetQ", (RPCMode)6, new object[1] { _0024item_00242458.q });
							}
						}
						else if (MenuScript.pHat == 14)
						{
							_0024se_00242460 = Random.Range(0, 10);
							if (_0024se_00242460 == 0)
							{
								Network.Instantiate(Resources.Load("e/broodmother"), new Vector3(((Component)_0024self__00242463).transform.position.x, ((Component)_0024self__00242463).transform.position.y + 50f, 0f), Quaternion.identity, 0);
							}
						}
						((Component)_0024self__00242463).audio.PlayOneShot(_0024self__00242463.ow);
						canTakeDamage = false;
						_0024n2_00242461 = (GameObject)Network.Instantiate((Object)(GameObject)Resources.Load("TD1", typeof(GameObject)), ((Component)_0024self__00242463).transform.position, Quaternion.identity, 0);
						_0024n2_00242461.networkView.RPC("SDN", (RPCMode)2, new object[1] { _0024finalDMG_00242456 });
						_0024self__00242463.gameScript.TD(_0024finalDMG_00242456);
						_0024self__00242463.gameScript.LoadHearts();
						GameScript.canTakeDamage = false;
						((MonoBehaviour)_0024self__00242463).StartCoroutine_Auto(_0024self__00242463.GetHit());
						if (GameScript.HP >= 1)
						{
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
						GameScript.HP = 0;
						_0024self__00242463.player.SendMessage("Die");
						if (MenuScript.deathA == 1)
						{
							_0024self__00242463.player.SendMessage("DeathAnim");
						}
						isDead = true;
						_0024self__00242463.@base.animation.Play("dead");
					}
					goto IL_0392;
				case 2:
					canTakeDamage = true;
					goto IL_0392;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0392:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024DMG_00242464;

		internal PlayerTriggerScript _0024self__00242465;

		public _0024TD_00242455(int DMG, PlayerTriggerScript self_)
		{
			_0024DMG_00242464 = DMG;
			_0024self__00242465 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024DMG_00242464, _0024self__00242465);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GetHit_00242466 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024910_00242467;

			internal Vector3 _0024_0024911_00242468;

			internal int _0024_0024912_00242469;

			internal Vector3 _0024_0024913_00242470;

			internal PlayerTriggerScript _0024self__00242471;

			public _0024(PlayerTriggerScript self_)
			{
				_0024self__00242471 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Expected O, but got Unknown
				//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_0107: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_010a: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_0146: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					((Component)_0024self__00242471).animation.Play();
					_0024self__00242471.gameScript.heartsObj.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 2:
				{
					((Component)_0024self__00242471).animation.Stop();
					_0024self__00242471.gameScript.heartsObj.animation.Stop();
					GameScript.canTakeDamage = true;
					int num = (_0024_0024910_00242467 = 0);
					Vector3 val = (_0024_0024911_00242468 = ((Component)_0024self__00242471).transform.localPosition);
					float num2 = (_0024_0024911_00242468.z = _0024_0024910_00242467);
					Vector3 val3 = (((Component)_0024self__00242471).transform.localPosition = _0024_0024911_00242468);
					int num3 = (_0024_0024912_00242469 = 20);
					Vector3 val4 = (_0024_0024913_00242470 = _0024self__00242471.gameScript.heartsObj.transform.localPosition);
					float num4 = (_0024_0024913_00242470.z = _0024_0024912_00242469);
					Vector3 val6 = (_0024self__00242471.gameScript.heartsObj.transform.localPosition = _0024_0024913_00242470);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerTriggerScript _0024self__00242472;

		public _0024GetHit_00242466(PlayerTriggerScript self_)
		{
			_0024self__00242472 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242472);
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

	public override void Awake()
	{
		ShieldDEF = 0;
		cantTakeDamage = false;
		pController = (PlayerController)(object)player.GetComponent("PlayerController");
		canTakeDamage = true;
		canLeave = false;
		gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
	}

	public override void OnLevelWasLoaded(int level)
	{
		gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
	}

	public override IEnumerator TD(int DMG)
	{
		return new _0024TD_00242455(DMG, this).GetEnumerator();
	}

	public override IEnumerator GetHit()
	{
		return new _0024GetHit_00242466(this).GetEnumerator();
	}

	public override void AddItem(Item a)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (gameScript.AddItem(a) != 0)
		{
			((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/pickup", typeof(AudioClip)));
			if (MenuScript.multiplayer > 0)
			{
				Network.RemoveRPCs(a.g.networkView.viewID);
				Network.Destroy(a.g.networkView.viewID);
			}
			else
			{
				Object.Destroy((Object)(object)a.g);
			}
		}
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (!((Component)this).networkView.isMine)
		{
			return;
		}
		string tag = ((Component)c).tag;
		if (((Component)c).gameObject.layer == 26 && ((Object)((Component)c).gameObject).name == "nF")
		{
			canFortune = true;
			fortuneObj = ((Component)c).gameObject;
		}
		if (((Component)c).gameObject.layer == 29)
		{
			GameScript.isShopping = true;
			itemPurchasing = int.Parse(((Object)((Component)c).gameObject).name);
			player.SendMessage("WW");
			currentStand = ((Component)c).gameObject;
			MonoBehaviour.print((object)("Item To Buy: " + (object)itemPurchasing));
		}
		if (tag == "fireTrig")
		{
			GameScript.isCooking = true;
			MonoBehaviour.print((object)"COOKING");
		}
		if (((Component)c).gameObject.layer == 15)
		{
			if (MenuScript.multiplayer > 0)
			{
				if (((Component)this).networkView.isMine)
				{
					((Component)c).gameObject.SendMessage("Hit", (object)((Component)this).gameObject);
				}
			}
			else
			{
				((Component)c).gameObject.SendMessage("Hit", (object)((Component)this).gameObject);
			}
		}
		else if (((Component)c).gameObject.layer == 17)
		{
			player.networkView.RPC("AddGold", (RPCMode)2, new object[0]);
			gameScript.RefreshGold();
			((Component)this).audio.PlayOneShot(coinGet);
			((Component)c).gameObject.SendMessage("Die");
		}
		else if (((Component)c).gameObject.layer == 23)
		{
			if (MenuScript.multiplayer > 0 && ((Component)this).networkView.isMine)
			{
				((Component)this).audio.PlayOneShot(expGet);
				if (((Component)c).gameObject.tag == "huge")
				{
					player.networkView.RPC("AddEXP", (RPCMode)6, new object[1] { 2 });
				}
				else if (((Component)c).gameObject.tag == "big")
				{
					player.networkView.RPC("AddEXP", (RPCMode)6, new object[1] { 1 });
				}
				else
				{
					player.networkView.RPC("AddEXP", (RPCMode)6, new object[1] { 0 });
				}
				((Component)c).gameObject.SendMessage("Die");
			}
		}
		else if (((Component)c).gameObject.layer == 18)
		{
			if (!(((Component)c).gameObject.tag == "arrow"))
			{
			}
		}
		else if (((Component)c).gameObject.layer == 25)
		{
			if (MenuScript.multiplayer > 0 && ((Component)this).networkView.isMine && !((Component)c).gameObject.networkView.isMine)
			{
				player.SendMessage("bW", (object)((Component)c).gameObject);
			}
		}
		else if (((Component)c).gameObject.layer == 27)
		{
			MonoBehaviour.print((object)"HIT BY haz2");
			if (MenuScript.multiplayer > 0 && !((Component)c).gameObject.networkView.isMine)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(TD(1));
			}
		}
		else if (((Component)c).gameObject.layer == 26)
		{
			if (MenuScript.multiplayer > 0 && ((Component)this).networkView.isMine && !GameScript.interacting && ((Component)this).networkView.isMine)
			{
				MonoBehaviour.print((object)"CAN INTERACT");
				player.SendMessage("WW", (object)((Component)c).gameObject);
				GameScript.canInteract = true;
				GameScript.interacter = ((Object)((Component)c).gameObject).name;
			}
		}
		else
		{
			switch (tag)
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
		if (((Component)c).gameObject.layer == 30)
		{
			MonoBehaviour.print((object)"CANNOT INTERACT");
			GameScript.canInteract = false;
			GameScript.interacter = null;
		}
	}

	public override void SetDoor(int d)
	{
		if (MenuScript.multiplayer > 0)
		{
			if (((Component)this).networkView.isMine)
			{
				canLeave = true;
				GameScript.curDoor = d;
			}
		}
		else
		{
			canLeave = true;
			GameScript.curDoor = d;
		}
	}

	public override int SetBiome(string s, int d)
	{
		if (MenuScript.multiplayer > 0)
		{
			if (((Component)this).networkView.isMine)
			{
				GameScript.curDoor = d;
			}
		}
		else
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

	public override void Set()
	{
		gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
	}

	public override void OnTriggerExit(Collider c)
	{
		string tag = ((Component)c).tag;
		if (((Component)c).gameObject.layer == 29)
		{
			GameScript.isShopping = false;
			itemPurchasing = 0;
			player.SendMessage("WW2");
			purchasingItem = ((Component)c).gameObject;
		}
		switch (tag)
		{
		case "signEnter":
		case "sign":
		case "signComplete":
			bW.renderer.enabled = false;
			gameScript.Action(0);
			break;
		case "door0":
		case "door1":
		case "door2":
			canLeave = false;
			break;
		default:
			if (((Component)c).gameObject.layer == 25)
			{
				if (MenuScript.multiplayer > 0)
				{
					if (((Component)this).networkView.isMine)
					{
						player.SendMessage("bWN");
					}
				}
				else
				{
					player.SendMessage("bWN");
				}
			}
			else if (tag == "fireTrig")
			{
				GameScript.isCooking = false;
				MonoBehaviour.print((object)"NOT COOKING");
			}
			break;
		}
		if (((Component)c).gameObject.layer == 26)
		{
			MonoBehaviour.print((object)"CANNOT INTERACT");
			player.SendMessage("WW2");
			GameScript.canInteract = false;
			GameScript.interacter = null;
		}
	}

	public override void Main()
	{
	}
}
