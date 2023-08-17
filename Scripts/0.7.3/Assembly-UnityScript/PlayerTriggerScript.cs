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
	internal sealed class _0024TD_00242018 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024finalDMG_00242019;

			internal GameObject _0024n2_00242020;

			internal int _0024DMG_00242021;

			internal PlayerTriggerScript _0024self__00242022;

			public _0024(int DMG, PlayerTriggerScript self_)
			{
				_0024DMG_00242021 = DMG;
				_0024self__00242022 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Expected O, but got Unknown
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Expected O, but got Unknown
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0197: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024finalDMG_00242019 = _0024DMG_00242021 - ShieldDEF;
					if (_0024finalDMG_00242019 < 1)
					{
						_0024finalDMG_00242019 = 1;
					}
					if (MenuScript.multiplayer > 0 && ((Component)_0024self__00242022).networkView.isMine && canTakeDamage && !GameScript.win)
					{
						((Component)_0024self__00242022).audio.PlayOneShot(_0024self__00242022.ow);
						canTakeDamage = false;
						_0024n2_00242020 = (GameObject)Network.Instantiate((Object)(GameObject)Resources.Load("TD1", typeof(GameObject)), ((Component)_0024self__00242022).transform.position, Quaternion.identity, 0);
						_0024n2_00242020.networkView.RPC("SDN", (RPCMode)2, new object[1] { _0024finalDMG_00242019 });
						_0024self__00242022.gameScript.TD(_0024finalDMG_00242019);
						_0024self__00242022.gameScript.LoadHearts();
						GameScript.canTakeDamage = false;
						((MonoBehaviour)_0024self__00242022).StartCoroutine_Auto(_0024self__00242022.GetHit());
						if (GameScript.HP >= 1)
						{
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
						GameScript.HP = 0;
						_0024self__00242022.player.SendMessage("Die");
						isDead = true;
						_0024self__00242022.@base.animation.Play("dead");
					}
					goto IL_01a2;
				case 2:
					canTakeDamage = true;
					goto IL_01a2;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01a2:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024DMG_00242023;

		internal PlayerTriggerScript _0024self__00242024;

		public _0024TD_00242018(int DMG, PlayerTriggerScript self_)
		{
			_0024DMG_00242023 = DMG;
			_0024self__00242024 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024DMG_00242023, _0024self__00242024);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GetHit_00242025 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024775_00242026;

			internal Vector3 _0024_0024776_00242027;

			internal int _0024_0024777_00242028;

			internal Vector3 _0024_0024778_00242029;

			internal PlayerTriggerScript _0024self__00242030;

			public _0024(PlayerTriggerScript self_)
			{
				_0024self__00242030 = self_;
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
					((Component)_0024self__00242030).animation.Play();
					_0024self__00242030.gameScript.heartsObj.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 2:
				{
					((Component)_0024self__00242030).animation.Stop();
					_0024self__00242030.gameScript.heartsObj.animation.Stop();
					GameScript.canTakeDamage = true;
					int num = (_0024_0024775_00242026 = 0);
					Vector3 val = (_0024_0024776_00242027 = ((Component)_0024self__00242030).transform.localPosition);
					float num2 = (_0024_0024776_00242027.z = _0024_0024775_00242026);
					Vector3 val3 = (((Component)_0024self__00242030).transform.localPosition = _0024_0024776_00242027);
					int num3 = (_0024_0024777_00242028 = 20);
					Vector3 val4 = (_0024_0024778_00242029 = _0024self__00242030.gameScript.heartsObj.transform.localPosition);
					float num4 = (_0024_0024778_00242029.z = _0024_0024777_00242028);
					Vector3 val6 = (_0024self__00242030.gameScript.heartsObj.transform.localPosition = _0024_0024778_00242029);
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

		internal PlayerTriggerScript _0024self__00242031;

		public _0024GetHit_00242025(PlayerTriggerScript self_)
		{
			_0024self__00242031 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242031);
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
		return new _0024TD_00242018(DMG, this).GetEnumerator();
	}

	public override IEnumerator GetHit()
	{
		return new _0024GetHit_00242025(this).GetEnumerator();
	}

	public override void AddItem(Item a)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (gameScript.AddItem(a) != 0)
		{
			MonoBehaviour.print((object)((object)a.q + " is QQQQQQQQQQQQQ"));
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
					gameScript.GainEXP(20);
					GameScript.tempStats[3] = GameScript.tempStats[3] + 20;
				}
				else if (((Component)c).gameObject.tag == "big")
				{
					gameScript.GainEXP(8);
					GameScript.tempStats[3] = GameScript.tempStats[3] + 8;
				}
				else
				{
					gameScript.GainEXP(1);
					GameScript.tempStats[3] = GameScript.tempStats[3] + 1;
				}
				((Component)c).gameObject.SendMessage("Die");
			}
		}
		else if (((Component)c).gameObject.layer == 18)
		{
			if (((Component)c).gameObject.tag == "arrow")
			{
				((Component)c).SendMessage("Stuck");
				((Component)c).gameObject.transform.parent = ((Component)this).transform;
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
