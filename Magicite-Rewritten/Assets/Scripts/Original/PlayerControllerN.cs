using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class PlayerControllerN : MonoBehaviour
{
	public virtual IEnumerator iceShard(int mag)
	{
		shard.SetActive(true);
		if (GetComponent<NetworkView>().isMine)
		{
			shard.SetActive(true);
			GetComponent<NetworkView>().RPC("iceShardN", RPCMode.All, mag, 1);
			int finalM = (int)(mag * 0.5f);
			shard1.GetComponent<NetworkView>().RPC("SetHH", RPCMode.All, finalM);
			shard2.GetComponent<NetworkView>().RPC("SetHH", RPCMode.All, finalM);
			shard3.GetComponent<NetworkView>().RPC("SetHH", RPCMode.All, finalM);
			shardCount++;
			yield return new WaitForSeconds(20f);
			shardCount--;
			if (shardCount <= 0)
			{
				GetComponent<NetworkView>().RPC("iceShardN", RPCMode.All, mag, 0);
			}
		}
	}

	public virtual IEnumerator Start()
	{
		yield return new WaitForSeconds(2f);
		leavingLevel = false;
		while (true)
		{
			if (GetComponent<NetworkView>().isMine && !downed)
			{
				gameScript.DecreaseHunger();
			}
			yield return new WaitForSeconds(60f);
		}
	}

	public virtual IEnumerator SetZoneName(string s)
	{
		leaving = false;
		if (gameScript != null)
		{
			gameScript.txtZone.text = s;
			gameScript.txtLevelName.text = s;
			gameScript.txtLevelName.gameObject.SetActive(true);
		}
		else if (GetComponent<NetworkView>().isMine)
		{
			gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
			yield return new WaitForSeconds(0.5f);
			if (gameScript != null)
			{
				gameScript.txtZone.text = s;
				gameScript.txtLevelName.text = s;
				gameScript.txtLevelName.gameObject.SetActive(true);
			}
		}
	}

	public virtual IEnumerator DrumATKTick()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			yield return new WaitForSeconds(15f);
			if (GameScript.drumATK > 10)
			{
				GameScript.drumATK -= 10;
			}
			else
			{
				GameScript.drumATK = 0;
			}
			if (GameScript.drumATK <= 0)
			{
				GetComponent<NetworkView>().RPC("drumATKN", RPCMode.All, 0);
			}
		}
		while (true)
		{
			yield return null;
		}
	}

	public virtual IEnumerator DrumDEXTick()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			yield return new WaitForSeconds(15f);

			if (GameScript.drumDEX > 10)
			{
				GameScript.drumDEX -= 10;
			}
			else
			{
				GameScript.drumDEX = 0;
			}

			if (GameScript.drumDEX <= 0)
			{
				GetComponent<NetworkView>().RPC("drumDEXN", RPCMode.All, 0);
			}
		}
	}

	public virtual IEnumerator DrumMAGTick()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			yield return new WaitForSeconds(15f);
			if (GameScript.drumMAG > 10)
			{
				GameScript.drumMAG -= 10;
			}
			else
			{
				GameScript.drumMAG = 0;
			}
			GetComponent<NetworkView>().RPC("drumMAGN", RPCMode.All, 0);
		}
		while (true)
		{
			yield return null;
		}
	}

	public virtual IEnumerator mWeaponsN(int a)
	{
		mBonus += a;
		mWeapon.SetActive(true);
		yield return new WaitForSeconds(15f);
		mBonus -= a;
		if (mBonus < 0)
		{
			mBonus = 0;
		}
		if (mBonus == 0)
		{
			mWeapon.SetActive(false);
		}
	}

	public virtual IEnumerator HELP()
	{
		if (!reviving)
		{
			GetComponent<NetworkView>().RPC("EX", RPCMode.All);
			reviving = true;
			GetComponent<NetworkView>().RPC("Tick", RPCMode.All, 3);
			yield return new WaitForSeconds(1f);

			GetComponent<NetworkView>().RPC("Tick", RPCMode.All, 2);
			yield return new WaitForSeconds(1f);

			GetComponent<NetworkView>().RPC("Tick", RPCMode.All, 1);
			yield return new WaitForSeconds(1f);

			reviving = false;
			GetComponent<NetworkView>().RPC("Tick", RPCMode.All, 0);
			GetComponent<NetworkView>().RPC("Revive", RPCMode.All);
		}
	}

	public virtual IEnumerator ChargeN()
	{
		particleCharge.SetActive(true);
		yield return new WaitForSeconds(10f);
		chargeBoost -= 4;
		if (chargeBoost < 0)
		{
			chargeBoost = 0;
		}
		if (chargeBoost == 0)
		{
			particleCharge.SetActive(false);
		}
	}

	public IEnumerator Offledge()
	{
		if (!offledge)
		{
			offledge = true;
			yield return new WaitForSeconds(0.2f);

			if (Physics.Raycast(ray, out hit, 1.5f))
			{
				if (hit.transform.gameObject.layer == 11)
				{
					grounded = true;
					mode = 0;
					canDoubleJump = true;
				}
				else
				{
					mode = 2;
					grounded = false;
				}
			}
			else
			{
				mode = 2;
				grounded = false;
			}

			offledge = false;
		}
	}

	public virtual IEnumerator EnterDoor()
	{
		leaving = true;
		int cd = GameScript.curDoor;
		MonoBehaviour.print(cd + " CURDOR ");
		inDoor = true;
		GetComponent<NetworkView>().RPC("Leaving", RPCMode.All, cd);
		yield return new WaitForSeconds(2f);
		leaving = false;
	}

	public virtual IEnumerator LeaveDoor()
	{
		leaving = true;
		inDoor = false;
		trigger.canLeave = true;

		int num = 0;
		Vector3 pos = p.transform.position;
		pos.z = num;
		p.transform.position = pos;

		inDoor = false;
		GetComponent<NetworkView>().RPC("NotLeaving", RPCMode.Server, GameScript.curDoor);

		yield return new WaitForSeconds(0.2f);

		leaving = false;
	}

	public virtual IEnumerator HELPSTAY()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			gameScript.immobilized = true;
			immobilized = true;
			yield return new WaitForSeconds(3f);
			gameScript.immobilized = false;
			immobilized = false;
		}
	}

	public virtual IEnumerator Leaving(int d)
	{
		if (!leavingLevel)
		{
			leavingLevel = true;
			Camera.main.gameObject.SendMessage("fadeOut");
			yield return new WaitForSeconds(1f);
		}

		if (Network.isServer)
		{
			int a = default(int);
			GameScript.changingScene = true;
			int i = d;
			GameScript.curBiome = GameScript.doorBiome[i];
			if (GameScript.isTown)
			{
				GameScript.isTown = false;
			}
			else if (GameScript.districtLevel == 21)
			{
				GameScript.isTown = false;
			}
			else
			{
				GameScript.isTown = true;
			}
		}
		Application.LoadLevel(2);
	}

	public virtual IEnumerator Dash(int a)
	{
		if (gameScript.stamina >= 1f)
		{
			dashing = true;
			gameScript.Stamina();
			if (MenuScript.pHat != 20)
			{
				gameScript.stamina -= 1f;
			}
			gameScript.LoadSTA();
			int bonus = 0;
			if (MenuScript.pHat == 7)
			{
				bonus = 10;
			}
			GetComponent<NetworkView>().RPC("po", RPCMode.All, t.position);
			GetComponent<NetworkView>().RPC("AnimD", RPCMode.All);
			if (grounded)
			{
				if (a != 0)
				{
					r.velocity = new Vector3(18 + bonus, r.velocity.y, r.velocity.z);
				}
				else
				{
					r.velocity = new Vector3(-18 - bonus, r.velocity.y, r.velocity.z);
				}
			}
			else
			{
				if (MenuScript.companion == 4)
				{
					GameObject dd = (GameObject)Network.Instantiate(Resources.Load("skill/gadget"), transform.position, Quaternion.identity, 0);
					dd.SendMessage("SetHH", GameScript.finalATK);
				}
				if (a != 0)
				{
					r.velocity = new Vector3(15 + bonus, r.velocity.y, r.velocity.z);
				}
				else
				{
					r.velocity = new Vector3(-15 - bonus, r.velocity.y, r.velocity.z);
				}
			}
			yield return new WaitForSeconds(0.3f);
			dashing = false;
		}
		else
		{
			UnityEngine.Object.Instantiate(Resources.Load("noSta"), t.position, Quaternion.identity);
		}
	}
	public virtual IEnumerator Jump()
	{
		djA = true;
		GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/JUMP", typeof(AudioClip)));
		canBoost = true;
		grounded = false;
		mode = 2;
		if (!GameScript.isFloating)
		{
			r.velocity = new Vector3(r.velocity.x, 25, r.velocity.z);
		}
		else
		{
			r.velocity = new Vector3(r.velocity.x, 12, r.velocity.z);
		}
		yield return new WaitForSeconds(1f);
		if (MenuScript.companion != 7)
		{
			canBoost = false;
		}
	}
	public virtual IEnumerator DoubleJump()
	{
		if (gameScript.stamina >= 1f || MenuScript.companion == 7)
		{
			djA = false;
			GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
			canBoost = false;
			canBoost2 = true;
			if (MenuScript.companion != 7)
			{
				gameScript.Stamina();
			}
			if (MenuScript.pHat != 20 && MenuScript.companion != 7)
			{
				gameScript.stamina = gameScript.stamina - 1f;
			}
			gameScript.LoadSTA();
			GetComponent<NetworkView>().RPC("po", RPCMode.All, t.position);
			canDoubleJump = false;
			int bonus = 0;
			if (MenuScript.pHat == 9)
			{
				bonus = 24;
			}
			if (!GameScript.isFloating)
			{
				r.velocity = new Vector3(r.velocity.x, 27, r.velocity.z);
			}
			else
			{
				r.velocity = new Vector3(r.velocity.x, 12, r.velocity.z);
			}
			mode = 2;
			yield return new WaitForSeconds(1f);
			canBoost2 = false;
		}
		else
		{
			UnityEngine.Object.Instantiate(Resources.Load("noSta"), t.position, Quaternion.identity);
		}
	}
	public virtual IEnumerator TripleJump()
	{
		if (gameScript.stamina >= 1f)
		{
			djA = false;
			GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
			canBoost = false;
			canBoost2 = true;
			gameScript.Stamina();
			gameScript.stamina -= 1f;
			gameScript.LoadSTA();
			GetComponent<NetworkView>().RPC("po", RPCMode.All, t.position);
			canTripleJump = false;

			if (!GameScript.isFloating)
			{
				r.velocity = new Vector3(r.velocity.x, 26f, r.velocity.z);
			}
			else
			{
				r.velocity = new Vector3(r.velocity.x, 12f, r.velocity.z);
			}

			mode = 2;
			yield return new WaitForSeconds(1f);
			canBoost2 = false;
		}
		else
		{
			UnityEngine.Object.Instantiate(Resources.Load("noSta"), t.position, Quaternion.identity);
		}
	}

	public virtual IEnumerator Float()
	{
		GetComponent<NetworkView>().RPC("FloatN", RPCMode.All, 1);
		floatCounter++;
		GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, 10, GetComponent<Rigidbody>().velocity.z);
		GameScript.isFloating = true;
		yield return new WaitForSeconds(10f);
		floatCounter--;
		if (floatCounter < 0)
		{
			floatCounter = 0;
		}
		if (floatCounter == 0)
		{
			GetComponent<NetworkView>().RPC("FloatN", RPCMode.All, 0);
			if (MenuScript.companion != 6)
			{
				GameScript.isFloating = false;
			}
		}
	}

	public virtual IEnumerator BeginLevel()
	{
		if ((bool)fade)
		{
			fade.fadeOut();
		}
		yield return new WaitForSeconds(0.2f);
		Application.LoadLevel(2);
	}
	public virtual IEnumerator LoadLevel(int level, bool a)
	{
		fade.fadeOut();
		yield return new WaitForSeconds(0.2f);
		GameScript.changingScene = true;
		GameScript.isInstance = a;
		Application.LoadLevel(level);
	}

	public virtual IEnumerator OnLevelWasLoaded(int level)
	{
		GameScript.playersDead = 0;
		if ((bool)gameScript)
		{
			GameScript.playersDead = 0;
		}
		if (GameScript.HP <= 0)
		{
			downed = false;
			exclamation.SetActive(false);
			GameScript.canTakeDamage = true;
			mode = 0;
			GameScript.curGold = 0;
			if ((bool)gameScript)
			{
				gameScript.RefreshGold();
			}
			GetComponent<NetworkView>().RPC("SetRevive", RPCMode.All);
			gameScript.SetRevive();
			PlayerTriggerScript.canTakeDamage = true;
			trigger.enabled = true;
		}
		if (GetComponent<NetworkView>().isMine)
		{
			musicBox = GameObject.Find("musicBox");
		}
		if (MenuScript.companion == 6 || MenuScript.companion == 9)
		{
			GameScript.isFloating = true;
			GetComponent<Rigidbody>().useGravity = false;
		}
		GameScript.readyPlayers = 0;
		changing = false;
		if (MenuScript.pHat == 9)
		{
			waspEye = true;
		}
		if (Network.isServer)
		{
			HungerCheck();
		}
		particleRoar.SetActive(false);
		particleFloat.SetActive(false);
		mWeapon.SetActive(false);
		particleClair.SetActive(false);
		shieldObj.SetActive(false);
		particleCharge.SetActive(false);
		particleRage.SetActive(false);
		GetComponent<NetworkView>().RPC("drumATKN", RPCMode.All, 0);
		GetComponent<NetworkView>().RPC("drumDEXN", RPCMode.All, 0);
		GetComponent<NetworkView>().RPC("drumMAGN", RPCMode.All, 0);
		won = false;
		GetComponent<NetworkView>().RPC("bWN", RPCMode.All);
		reviveBox.GetComponent<BoxCollider>().enabled = false;
		chargeBoost = 0;
		isBoss = false;
		if (Network.isServer)
		{
			int nuu = GameScript.curBiome;
			if (GameScript.isTown)
			{
				nuu = 99;
			}
			GetComponent<NetworkView>().RPC("SetMusic", RPCMode.All, nuu);
		}
		if (GetComponent<NetworkView>().isMine)
		{
			if (Network.connections.Length == 0)
			{
				nameObj.SetActive(false);
			}
			attackCube.SetActive(false);
			if ((bool)t)
			{
				t.position = new Vector3(2f, -2f, 0f);
			}
			inDoor = false;
			if ((bool)trigger)
			{
				trigger.canLeave = false;
			}
			p.transform.position = new Vector3(p.transform.position.x, p.transform.position.y, 0f);
			for (int i = 0; i < 3; i++)
			{
				GameScript.door[i] = 0;
			}
			GameScript.readyPlayers = 0;
			gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
			GameScript.cLevel = PlayerPrefs.GetInt("cLevel");
		}
		yield return new WaitForSeconds(1f);
		gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
		leavingLevel = false;
	}

	public IEnumerator Check()
	{
		while (true)
		{
			yield return new WaitForSeconds(2.2f);

			if (GameScript.playersDead >= Network.connections.Length + 1)
			{
				GetComponent<NetworkView>().RPC("GameOver", RPCMode.All);
			}
		}
	}

	public virtual IEnumerator GameOver()
	{
		if (gameScript != null)
		{
			StartCoroutine(gameScript.Die());
		}
		else
		{
			if (GetComponent<NetworkView>().isMine)
			{
				gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
				yield return new WaitForSeconds(0.1f);
			}
			else
			{
				gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
				MonoBehaviour.print("gamescript trying ");
				yield return new WaitForSeconds(0.1f);
			}
			StartCoroutine(gameScript.Die());
		}
	}

	public virtual IEnumerator LevelUp()
	{
		levelUpObj.SetActive(true);
		GetComponent<AudioSource>().PlayOneShot(audioLevelUp);
		yield return new WaitForSeconds(1f);
		levelUpObj.SetActive(false);
	}

	public virtual IEnumerator ShieldN()
	{
		shieldObj.SetActive(true);
		yield return new WaitForSeconds(10f);

		PlayerTriggerScript.ShieldDEF -= 4;
		if (PlayerTriggerScript.ShieldDEF < 0)
		{
			PlayerTriggerScript.ShieldDEF = 0;
		}
		if (PlayerTriggerScript.ShieldDEF == 0)
		{
			shieldObj.SetActive(false);
		}
	}

	public virtual IEnumerator K(bool l)
	{
		if (!inDoor && GetComponent<NetworkView>().isMine)
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
	}

	public TextMesh[] txtTitle;

	public GameObject cat;

	public GameObject vikingAxe;

	public GameObject shard;

	public GameObject shard1;

	public GameObject shard2;

	public GameObject shard3;

	public GameObject drumAtkObj;

	public GameObject drumDexObj;

	public GameObject drumMagObj;

	private bool changing;

	public GameObject particleRoar;

	public GameObject particleFloat;

	private int floatCounter;

	public GameObject nameObj;

	[NonSerialized]
	public static int mBonus;

	public GameObject mWeapon;

	public GameObject particleClair;

	public GameObject shieldObj;

	private int chargeBoost;

	public GameObject particleCharge;

	public GameObject particleRage;

	[NonSerialized]
	public static bool isBoss;

	public AudioClip themeCave;

	public AudioClip themeTown;

	[NonSerialized]
	public static int helm;

	[NonSerialized]
	public static int armor;

	[NonSerialized]
	public static int offhand;

	public AudioClip audioLevelUp;

	public GameObject attackCube;

	public GameObject levelUpObj;

	public GameObject @base;

	public GameObject p;

	public GameObject head;

	public GameObject head2;

	public GameObject body;

	public GameObject body2;

	public GameObject arm1;

	public GameObject arm2;

	public GameObject leg;

	public GameObject weapon;

	public GameObject offHand;

	public TextMesh[] txtName;

	public GameObject pop;

	public GameObject bar;

	public GameObject ghost;

	public GameObject buttonW;

	public GameObject reviveBox;

	private int race;

	public GameObject exclamation;

	public TextMesh txtTick;

	[NonSerialized]
	public static bool leavingLevel;

	private bool offledge;

	private int mask;

	private bool leaving;

	private bool moving;

	private Transform t;

	private int cc;

	private GameScript gameScript;

	private PlayerTriggerScript trigger;

	private bool canMove;

	private bool dead;

	private Ray ray;

	private RaycastHit hit;

	private int mode;

	private bool grounded;

	private Rigidbody r;

	private bool canDoubleJump;

	[NonSerialized]
	public static bool downed;

	private bool dashing;

	private bool canBoost;

	private bool canBoost2;

	private int curDoorLocal;

	[NonSerialized]
	public static GameObject lObj;

	[NonSerialized]
	public static GameObject aCube;

	private bool inDoor;

	private bool canHelp;

	private GameObject downedAlly;

	private bool helping;

	private bool reviving;

	private bool immobilized;

	private FadeInOut fade;

	private bool jA;

	private bool djA;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private bool cantLeft;

	private bool cantRight;

	private GameObject companion;

	private bool slidingL;

	private bool slidingR;

	private bool won;

	private bool canTripleJump;

	private bool waspEye;

	private int shardCount;

	private GameObject musicBox;

	public PlayerControllerN()
	{
		txtTitle = new TextMesh[2];
		txtName = new TextMesh[2];
		mask = 2048;
	}

	public static GameObject GetLevelUp()
	{
		return lObj;
	}

	public virtual void V()
	{
		GetComponent<NetworkView>().RPC("VN", RPCMode.All);
	}

	[RPC]
	public virtual void VN(int m)
	{
		if (m == 1)
		{
			vikingAxe.SetActive(value: true);
		}
		else
		{
			vikingAxe.SetActive(value: false);
		}
	}

	public virtual void Cat(int a)
	{
		if (a == 0)
		{
			GetComponent<NetworkView>().RPC("CatN", RPCMode.All, 0);
		}
		else
		{
			GetComponent<NetworkView>().RPC("CatN", RPCMode.All, 1);
		}
	}

	[RPC]
	public virtual void CatN(int a)
	{
		if (a == 0)
		{
			cat.SetActive(value: false);
			@base.SetActive(value: true);
			cat.GetComponent<Animation>().Play();
			return;
		}
		cat.SetActive(value: true);
		@base.SetActive(value: false);
		if (mode == 99)
		{
			@base.GetComponent<Animation>().Play("dead");
		}
		else
		{
			@base.GetComponent<Animation>().Play("i");
		}
	}

	[RPC]
	public virtual void iceShardN(int dmg, int m)
	{
		if (m == 1)
		{
			shard.SetActive(value: true);
		}
		else
		{
			shard.SetActive(value: false);
		}
	}

	[RPC]
	public virtual void Rage(int a)
	{
		if (a == 1)
		{
			particleRage.SetActive(value: true);
		}
		else
		{
			particleRage.SetActive(value: false);
		}
	}

	[RPC]
	public virtual void Clair(int a)
	{
		if (a == 1)
		{
			particleClair.SetActive(value: true);
		}
		else
		{
			particleClair.SetActive(value: false);
		}
	}

	public static void DisableAttackCube()
	{
	}

	[RPC]
	public virtual void SetMusic(int a)
	{
		if ((bool)gameScript)
		{
			gameScript.SendMessage("SetMusic", a);
		}
	}

	public virtual void HungerCheck()
	{
		if (GameScript.isTown)
		{
			GetComponent<NetworkView>().RPC("hh", RPCMode.All, 1);
		}
		else
		{
			GetComponent<NetworkView>().RPC("hh", RPCMode.All, 0);
		}
	}

	[RPC]
	public virtual void hh(int a)
	{
		if (a == 0)
		{
			GameScript.isTown = false;
		}
		else
		{
			GameScript.isTown = true;
		}
	}

	[RPC]
	public virtual void PVP(int v)
	{
		MenuScript.pvp = v;
	}

	public virtual void Awake()
	{
		GameScript.readyPlayers = 0;
		if (MenuScript.pHat == 9)
		{
			waspEye = true;
		}
		GameScript.interacting = false;
		t = transform;
		r = GetComponent<Rigidbody>();
		if (GetComponent<NetworkView>().isMine)
		{
			if (MenuScript.pHat == 6)
			{
				canTripleJump = true;
			}
			if (MenuScript.companion > 0)
			{
				companion = (GameObject)Network.Instantiate(Resources.Load("comp/c" + MenuScript.companion), t.position, Quaternion.identity, 0);
				companion.SendMessage("Set", gameObject);
			}
		}
		else
		{
			GetComponent<Rigidbody>().isKinematic = true;
		}
		leaving = false;
		UnityEngine.Object.DontDestroyOnLoad(this);
		@base.GetComponent<Animation>()["a4"].layer = 2;
		@base.GetComponent<Animation>()["a4"].speed = 2f;
		@base.GetComponent<Animation>()["i"].speed = 2f;
		@base.GetComponent<Animation>()["a1"].layer = 2;
		@base.GetComponent<Animation>()["a2"].layer = 2;
		@base.GetComponent<Animation>()["a3"].layer = 2;
		@base.GetComponent<Animation>()["a2"].speed = 1.5f;
		if (GetComponent<NetworkView>().isMine)
		{
			aCube = attackCube;
			if (Network.isServer)
			{
				GameScript.playersDead = 0;
				GetComponent<NetworkView>().RPC("PVP", RPCMode.All, MenuScript.pvp);
			}
			inDoor = false;
			lObj = levelUpObj;
			if (GetComponent<NetworkView>().isMine)
			{
				fade = (FadeInOut)Camera.main.gameObject.GetComponent("FadeInOut");
				aCube = attackCube;
			}
			else
			{
				((AudioListener)gameObject.GetComponent(typeof(AudioListener))).enabled = false;
			}
			gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
			trigger = (PlayerTriggerScript)p.GetComponent("PlayerTriggerScript");
			GameScript.aSphere = aCube;
			Initialize();
			if ((bool)GetComponent<NetworkView>())
			{
				GetComponent<NetworkView>().RPC("D", RPCMode.All);
			}
			@base.GetComponent<Animation>()["i"].layer = 1;
			@base.GetComponent<Animation>()["r"].layer = 1;
			@base.GetComponent<Animation>()["j"].layer = 1;
			@base.GetComponent<Animation>()["dj"].layer = 1;
			@base.GetComponent<Animation>()["dead"].layer = 1;
			@base.GetComponent<Animation>()["a1"].layer = 2;
			@base.GetComponent<Animation>()["a2"].layer = 2;
			@base.GetComponent<Animation>()["a3"].layer = 2;
		}
		else
		{
			((AudioListener)gameObject.GetComponent(typeof(AudioListener))).enabled = false;
			gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
		}
	}

	[RPC]
	public virtual void drumATKN(int a)
	{
		if (a == 1)
		{
			drumAtkObj.SetActive(value: true);
		}
		else
		{
			drumAtkObj.SetActive(value: false);
		}
	}

	public virtual void drumATK()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			GameScript.drumATK += 10;
			GetComponent<NetworkView>().RPC("drumATKN", RPCMode.All, 1);
			StartCoroutine(DrumATKTick());
		}
	}

	[RPC]
	public virtual void drumDEXN(int a)
	{
		if (a == 1)
		{
			drumDexObj.SetActive(value: true);
		}
		else
		{
			drumDexObj.SetActive(value: false);
		}
	}

	public virtual void drumDEX()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			GameScript.drumDEX += 10;
			GetComponent<NetworkView>().RPC("drumDEXN", RPCMode.All, 1);
			StartCoroutine(DrumDEXTick());
		}
	}

	[RPC]
	public virtual void drumMAGN(int a)
	{
		if (a == 1)
		{
			drumMagObj.SetActive(value: true);
		}
		else
		{
			drumMagObj.SetActive(value: false);
		}
	}

	public virtual void drumMAG()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			GameScript.drumMAG += 10;
			GetComponent<NetworkView>().RPC("drumMAGN", RPCMode.All, 1);
			StartCoroutine(DrumMAGTick());
		}
	}

	public virtual void mWeapons(int a)
	{
		GetComponent<NetworkView>().RPC("mWeaponsN", RPCMode.All, a);
	}

	[RPC]
	public virtual void D()
	{
		levelUpObj.SetActive(value: false);
	}

	public virtual void Initialize()
	{
		UnityEngine.Object.DontDestroyOnLoad(this);
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		GameScript.facingLeft = false;
		@base.GetComponent<Animation>()["i"].layer = 1;
		@base.GetComponent<Animation>()["r"].layer = 1;
		@base.GetComponent<Animation>()["j"].layer = 1;
		@base.GetComponent<Animation>()["a1"].layer = 2;
	}

	[RPC]
	public virtual void EX()
	{
		exclamation.SetActive(value: false);
	}

	[RPC]
	public virtual void Tick(int a)
	{
		if (a == 0)
		{
			txtTick.text = string.Empty;
		}
		else
		{
			txtTick.text = string.Empty + a;
		}
	}

	public virtual void Charge()
	{
		chargeBoost += 4;
		GetComponent<NetworkView>().RPC("ChargeN", RPCMode.All);
	}

	[RPC]
	public virtual void AddEXP(int a)
	{
		if (!gameScript)
		{
			MonoBehaviour.print("NO GAMESCRIPT");
		}
		if ((bool)gameScript)
		{
			switch (a)
			{
			case 2:
				gameScript.GainEXP(20);
				GameScript.tempStats[3] = GameScript.tempStats[3] + 20;
				break;
			case 1:
				gameScript.GainEXP(8);
				GameScript.tempStats[3] = GameScript.tempStats[3] + 8;
				break;
			default:
				gameScript.GainEXP(1);
				GameScript.tempStats[3] = GameScript.tempStats[3] + 1;
				break;
			}
		}
	}

	[RPC]
	public virtual void AddGold()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			GameScript.tempStats[2] = GameScript.tempStats[2] + 1;
			GameScript.curGold++;
			if (MenuScript.pHat == 22)
			{
				GameScript.tempStats[2] = GameScript.tempStats[2] + 1;
				GameScript.curGold++;
			}
			if ((bool)gameScript)
			{
				gameScript.RefreshGold();
			}
		}
	}

	[RPC]
	public virtual void Roar(int a)
	{
		if (a == 1)
		{
			particleRoar.SetActive(value: true);
		}
		else
		{
			particleRoar.SetActive(value: false);
		}
	}

	public virtual void TimerSet(int a)
	{
		GetComponent<NetworkView>().RPC("SetFinalTime", RPCMode.All, a);
	}

	[RPC]
	public virtual void SetFinalTime(int a)
	{
		GameScript.timer = a;
	}
	public virtual void Update()
	{
		if (GameScript.win && !won)
		{
			won = true;
			GetComponent<NetworkView>().RPC("GameOver", RPCMode.All);
		}
		r1U.origin = transform.position;
		float y = r1U.origin.y + 0.6f;
		Vector3 origin = r1U.origin;
		float num = (origin.y = y);
		Vector3 vector2 = (r1U.origin = origin);
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		float y2 = r2U.origin.y + 0.6f;
		Vector3 origin2 = r2U.origin;
		float num2 = (origin2.y = y2);
		Vector3 vector4 = (r2U.origin = origin2);
		r2U.direction = Vector3.right;
		r1D.origin = transform.position;
		float y3 = r1D.origin.y - 0.7f;
		Vector3 origin3 = r1D.origin;
		float num3 = (origin3.y = y3);
		Vector3 vector6 = (r1D.origin = origin3);
		r1D.direction = Vector3.left;
		r2D.origin = transform.position;
		float y4 = r2D.origin.y - 0.7f;
		Vector3 origin4 = r2D.origin;
		float num4 = (origin4.y = y4);
		Vector3 vector8 = (r2D.origin = origin4);
		r2D.direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.2f, mask) || Physics.Raycast(r1D, 1.2f, mask))
		{
			cantLeft = true;
			slidingL = true;
		}
		else
		{
			slidingL = false;
			cantLeft = false;
		}
		if (Physics.Raycast(r2U, 1.2f, mask) || Physics.Raycast(r2D, 1.2f, mask))
		{
			cantRight = true;
		}
		else
		{
			slidingR = false;
			cantRight = false;
		}
		if (!(t.position.y >= -120f))
		{
			t.position = new Vector3(0f, 0f, 0f);
		}
		if (!GetComponent<NetworkView>().isMine || immobilized)
		{
			return;
		}
		if (!downed)
		{
			if (waspEye)
			{
				if (!(r.velocity.y >= -5f))
				{
					int num5 = -5;
					Vector3 velocity = r.velocity;
					float num6 = (velocity.y = num5);
					Vector3 vector10 = (r.velocity = velocity);
				}
			}
			else if (!(r.velocity.y >= -25f))
			{
				int num7 = -25;
				Vector3 velocity2 = r.velocity;
				float num8 = (velocity2.y = num7);
				Vector3 vector12 = (r.velocity = velocity2);
			}
			if (!(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= t.position.x))
			{
				if (GameScript.facingLeft && !inDoor)
				{
					GameScript.facingLeft = false;
					p.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
				}
			}
			else if (!GameScript.facingLeft && !inDoor)
			{
				GameScript.facingLeft = true;
				p.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			ray = new Ray(t.position, new Vector3(0f, -1f, 0f));
			if (Physics.Raycast(ray, out hit, 1f, mask))
			{
				if (hit.transform.gameObject.layer == 11)
				{
					grounded = true;
					mode = 0;
					canDoubleJump = true;
					if (MenuScript.pHat == 6)
					{
						canTripleJump = true;
					}
				}
				else
				{
					mode = 2;
					StartCoroutine(Offledge());
				}
			}
			else
			{
				mode = 2;
				StartCoroutine(Offledge());
			}
			if (UnityEngine.Input.GetButton("Left") && !inDoor && !dashing)
			{
				if (grounded)
				{
					mode = 1;
				}
				else
				{
					mode = 2;
				}
				if (!cantLeft)
				{
					float x = 0f - GameScript.SPD - (float)chargeBoost;
					Vector3 velocity3 = r.velocity;
					float num9 = (velocity3.x = x);
					Vector3 vector14 = (r.velocity = velocity3);
				}
			}
			if (!UnityEngine.Input.GetButtonDown("Left") || inDoor || GameScript.attacking || !r.isKinematic)
			{
			}
			if (!UnityEngine.Input.GetButtonDown("Right") || inDoor || GameScript.attacking || !r.isKinematic)
			{
			}
			if (UnityEngine.Input.GetButtonDown("Down") && GameScript.isFloating && !r.isKinematic)
			{
				if (MenuScript.companion == 9)
				{
					int num10 = -20;
					Vector3 velocity4 = r.velocity;
					float num11 = (velocity4.y = num10);
					Vector3 vector16 = (r.velocity = velocity4);
				}
				else
				{
					int num12 = -10;
					Vector3 velocity5 = r.velocity;
					float num13 = (velocity5.y = num12);
					Vector3 vector18 = (r.velocity = velocity5);
				}
			}
			if (UnityEngine.Input.GetButtonDown("Interact") && GameScript.isFloating && !r.isKinematic)
			{
				if (MenuScript.companion == 9)
				{
					int num14 = 20;
					Vector3 velocity6 = r.velocity;
					float num15 = (velocity6.y = num14);
					Vector3 vector20 = (r.velocity = velocity6);
				}
				else
				{
					int num16 = 10;
					Vector3 velocity7 = r.velocity;
					float num17 = (velocity7.y = num16);
					Vector3 vector22 = (r.velocity = velocity7);
				}
			}
			if (UnityEngine.Input.GetButtonDown("Dash Left") && !inDoor)
			{
				StartCoroutine(Dash(0));
			}
			else if (UnityEngine.Input.GetButtonDown("Dash Right") && !inDoor)
			{
				StartCoroutine(Dash(1));
			}
			if (UnityEngine.Input.GetButton("Right") && !inDoor && !dashing)
			{
				if (grounded)
				{
					mode = 1;
				}
				else
				{
					mode = 2;
				}
				if (!cantRight)
				{
					float x2 = GameScript.SPD + (float)chargeBoost;
					Vector3 velocity8 = r.velocity;
					float num18 = (velocity8.x = x2);
					Vector3 vector24 = (r.velocity = velocity8);
				}
			}
			if (UnityEngine.Input.GetButtonUp("Left") && !inDoor)
			{
				if (grounded)
				{
					mode = 0;
				}
				int num19 = 0;
				Vector3 velocity9 = r.velocity;
				float num20 = (velocity9.x = num19);
				Vector3 vector26 = (r.velocity = velocity9);
			}
			else if (UnityEngine.Input.GetButtonUp("Right"))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num21 = 0;
				Vector3 velocity10 = r.velocity;
				float num22 = (velocity10.x = num21);
				Vector3 vector28 = (r.velocity = velocity10);
			}
			if (UnityEngine.Input.GetButtonDown("Jump"))
			{
				if (grounded)
				{
					StartCoroutine(Jump());
				}
				else if (canDoubleJump || MenuScript.companion == 7)
				{
					StartCoroutine(DoubleJump());
				}
				else if (canTripleJump)
				{
					StartCoroutine(TripleJump());
				}
			}
			if (UnityEngine.Input.GetButton("Jump") && !dashing)
			{
				if (canBoost)
				{
					float y5 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity11 = r.velocity;
					float num23 = (velocity11.y = y5);
					Vector3 vector30 = (r.velocity = velocity11);
				}
				else if (canBoost2)
				{
					float y6 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity12 = r.velocity;
					float num24 = (velocity12.y = y6);
					Vector3 vector32 = (r.velocity = velocity12);
				}
			}
			if (UnityEngine.Input.GetButtonDown("Interact"))
			{
				if (GameScript.canInteract && !GameScript.interacting)
				{
					MonoBehaviour.print("Nice! Can Interact and not already interacting");
					GameScript.interacting = true;
					gameScript.Interact();
					WW2();
				}
				else
				{
					MonoBehaviour.print("canInteract: " + GameScript.canInteract + "   interacting: " + GameScript.interacting);
				}
				if (GameScript.isShopping && PlayerTriggerScript.itemPurchasing != 0 && PlayerTriggerScript.purchasingItem != null)
				{
					MonoBehaviour.print("Purchasing!");
					gameScript.Purchase(PlayerTriggerScript.itemPurchasing);
				}
				else
				{
					MonoBehaviour.print("isShopping: " + GameScript.isShopping + "   itemPruchasing:" + PlayerTriggerScript.itemPurchasing + "  purchasingItem: " + PlayerTriggerScript.purchasingItem);
				}
				if (trigger.canFortune)
				{
				}
				if (canHelp && !inDoor)
				{
					if ((bool)downedAlly)
					{
						GetComponent<NetworkView>().RPC("bWN", RPCMode.All);
						if ((bool)downedAlly)
						{
							downedAlly.SendMessage("HELP");
						}
						StartCoroutine(HELPSTAY());
					}
					else
					{
						helping = false;
						GetComponent<NetworkView>().RPC("bWN", RPCMode.All);
					}
				}
				if (trigger.canLeave && !inDoor && !leaving)
				{
					leaving = true;
					StartCoroutine(EnterDoor());
				}
				else if (inDoor && !leaving)
				{
					StartCoroutine(LeaveDoor());
				}
			}
			if (inDoor)
			{
				mode = 4;
				int num25 = 10;
				Vector3 position = p.transform.position;
				float num26 = (position.z = num25);
				Vector3 vector34 = (p.transform.position = position);
			}
		}
		if (GameScript.HP <= 0 || GameScript.win)
		{
			mode = 99;
			PlayerTriggerScript.isDead = true;
			PlayerTriggerScript.canTakeDamage = false;
		}
		if (GameScript.attacking)
		{
			return;
		}
		if (mode == 0)
		{
			GetComponent<NetworkView>().RPC("AnimIN", RPCMode.All);
			jA = false;
		}
		else if (mode == 1)
		{
			GetComponent<NetworkView>().RPC("AnimRN", RPCMode.All);
			jA = false;
		}
		else if (mode == 2)
		{
			if (!jA)
			{
				GetComponent<NetworkView>().RPC("AnimJumpN", RPCMode.All);
				jA = true;
			}
			if (!djA)
			{
				GetComponent<NetworkView>().RPC("AnimJump2N", RPCMode.All);
				djA = true;
			}
		}
		else if (mode == 3)
		{
			@base.GetComponent<Animation>().Play("a1");
			jA = false;
		}
		else
		{
			jA = false;
		}
	}

	[RPC]
	public virtual void SummonSpirit()
	{
		if ((bool)musicBox)
		{
			musicBox.SendMessage("SetBoss");
		}
		else
		{
			musicBox = GameObject.Find("musicBox");
			musicBox.SendMessage("SetBoss");
		}
		if (Network.isServer)
		{
			Network.Instantiate(Resources.Load("e/ghostKnight"), new Vector3(transform.position.x, transform.position.y + 18f, 0f), Quaternion.identity, 0);
		}
	}

	[RPC]
	public virtual void SetBearHat()
	{
		head2.GetComponent<Renderer>().material = (Material)Resources.Load("bearHat");
	}

	public virtual void DeathAnim()
	{
		Network.Instantiate(Resources.Load("deathA"), t.position, Quaternion.identity, 0);
	}

	[RPC]
	public virtual void AnimJumpN()
	{
		@base.GetComponent<Animation>().Play("j");
	}

	[RPC]
	public virtual void AnimJump2N()
	{
		@base.GetComponent<Animation>().Play("dj");
	}

	[RPC]
	public virtual void AnimIN()
	{
		@base.GetComponent<Animation>().Play("i");
	}

	[RPC]
	public virtual void AnimRN()
	{
		@base.GetComponent<Animation>().Play("r");
	}

	[RPC]
	public virtual void PrintState()
	{
		int num = default(int);
		for (num = 0; num < 3; num++)
		{
		}
	}

	[RPC]
	public virtual void SDoor(int a)
	{
	}


	[RPC]
	public virtual void NotLeaving(int d)
	{
		if (Network.isServer)
		{
			GameScript.door[d] = GameScript.door[d] - 1;
			GameScript.readyPlayers--;
			PrintState();
		}
	}

	[RPC]
	public virtual void ChangeScene()
	{
	}

	[RPC]
	public virtual void AnimD()
	{
		@base.GetComponent<Animation>().Play("dj");
	}

	[RPC]
	public virtual void AgainN()
	{
		inDoor = false;
		reviveBox.GetComponent<BoxCollider>().enabled = false;
		PlayerTriggerScript.canTakeDamage = true;
		mode = 0;
		downed = false;
		StartCoroutine(gameScript.AgainN());
	}

	[RPC]
	public virtual void Restart()
	{
		Application.LoadLevel(0);
	}

	[RPC]
	public virtual void Again()
	{
		GetComponent<NetworkView>().RPC("AgainN", RPCMode.All);
	}
	[RPC]
	public virtual void WritePlayer(int a)
	{
		gameScript.SendMessage("WriteFinal", a);
	}

	[RPC]
	public virtual void FloatN(int a)
	{
		if (a == 1)
		{
			particleFloat.SetActive(value: true);
			GetComponent<Rigidbody>().useGravity = false;
			return;
		}
		particleFloat.SetActive(value: false);
		if (MenuScript.companion != 6)
		{
			GetComponent<Rigidbody>().useGravity = true;
		}
	}

	[RPC]
	public virtual void TD(int dmg)
	{
		if (GetComponent<NetworkView>().isMine && !inDoor && !downed && (bool)trigger)
		{
			StartCoroutine(trigger.TD(dmg));
		}
	}

	public virtual void OnDestroy()
	{
		if ((bool)companion)
		{
			Network.Destroy(companion.GetComponent<NetworkView>().viewID);
		}
	}

	[RPC]
	public virtual void RemoveDoor(int d)
	{
		GameScript.door[d] = GameScript.door[d] - 1;
		GameScript.readyPlayers--;
	}

	public virtual void OnDisconnectedFromServer()
	{
		if (inDoor)
		{
			GetComponent<NetworkView>().RPC("RemoveDoor", RPCMode.Server, GameScript.curDoor);
		}
		UnityEngine.Object.Destroy(gameObject);
	}

	[RPC]
	public virtual void UpdateAppearance(int h, int b, int race, int o, int hat)
	{
		if (h >= 700)
		{
			head2.GetComponent<Renderer>().material = (Material)Resources.Load("h/h" + h, typeof(Material));
		}
		else
		{
			head.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race + "h" + h, typeof(Material));
			head2.GetComponent<Renderer>().material = (Material)Resources.Load("hat/hat" + hat, typeof(Material));
		}
		if (b > 0)
		{
			body.GetComponent<Renderer>().material = (Material)Resources.Load("b/b" + b, typeof(Material));
			arm1.GetComponent<Renderer>().material = (Material)Resources.Load("a/a" + b, typeof(Material));
			arm2.GetComponent<Renderer>().material = (Material)Resources.Load("a/a" + b, typeof(Material));
			leg.GetComponent<Renderer>().material = (Material)Resources.Load("l/l" + b, typeof(Material));
		}
		else
		{
			body.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race + "b", typeof(Material));
			arm1.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race + "a", typeof(Material));
			arm2.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race + "a", typeof(Material));
			leg.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race + "l", typeof(Material));
		}
		offHand.GetComponent<Renderer>().material = (Material)Resources.Load("o/o" + o, typeof(Material));
	}

	public virtual void bW(GameObject a)
	{
		if (GetComponent<NetworkView>().isMine)
		{
			downedAlly = a;
			buttonW.SetActive(value: true);
			canHelp = true;
		}
	}

	public virtual void WW()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			buttonW.SetActive(value: true);
		}
	}

	public virtual void WW2()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			buttonW.SetActive(value: false);
		}
	}

	[RPC]
	public virtual void bWN()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			buttonW.SetActive(value: false);
			canHelp = false;
		}
	}

	[RPC]
	public virtual void uI(int id)
	{
		weapon.GetComponent<Renderer>().material = (Material)Resources.Load("iE/i" + id, typeof(Material));
	}

	[RPC]
	public virtual void AssignTitle(string n)
	{
		txtTitle[0].text = n;
		txtTitle[1].text = n;
	}

	[RPC]
	public virtual void AssignName(string n)
	{
		txtName[0].text = n;
		txtName[1].text = n;
	}

	[RPC]
	public virtual void SetBGNetwork(int tBiome)
	{
		gameScript.SetBGNetwork(tBiome);
	}

	[RPC]
	public virtual void mA(string s)
	{
		mode = 3;
		@base.GetComponent<Animation>().Stop();
		@base.GetComponent<Animation>().Play(s);
	}

	[RPC]
	public virtual void Boss()
	{
		isBoss = true;
	}


	public virtual void RA()
	{
		gameScript.RefreshActionBar();
	}

	public virtual void Break()
	{
		GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/break", typeof(AudioClip)));
		gameScript.UpdateCharacterWeapon();
	}

	public virtual void Write(int a)
	{
		StartCoroutine(gameScript.Write(a));
	}


	[RPC]
	public virtual void SpawnNPC(NetworkViewID id, int pos, int n)
	{
	}

	public virtual Vector3 GetNPCPos(int a)
	{
		Vector3 vector = default(Vector3);
		switch (a)
		{
			case 0:
				return new Vector3(-9f, 3f, 1f);
			case 1:
				return new Vector3(-5f, 3f, 1f);
			case 2:
				return new Vector3(5f, 3f, 1f);
			case 3:
				return new Vector3(9f, 3f, 1f);
			case 4:
				return new Vector3(-9f, -4.5f, 1f);
			case 5:
				return new Vector3(-5f, -4.5f, 1f);
			case 6:
				return new Vector3(0f, -4.5f, 1f);
			case 7:
				return new Vector3(5f, -4.5f, 1f);
			case 8:
				return new Vector3(9f, -4.5f, 1f);
			default:
				return vector;
		}
	}

	[RPC]
	public virtual void po(Vector3 pos)
	{
		UnityEngine.Object.Instantiate(pop, pos, Quaternion.Euler(0f, 180f, 180f));
	}

	[RPC]
	public virtual void AddDeadPerson()
	{
		GameScript.playersDead++;
		StartCoroutine(Check());
	}


	[RPC]
	public virtual void RemoveDeadPerson()
	{
		GameScript.playersDead--;
		if (GameScript.playersDead < 0)
		{
			GameScript.playersDead = 0;
		}
	}


	[RPC]
	public virtual void AnimDead()
	{
		@base.GetComponent<Animation>().Play("dead");
		if (!GetComponent<NetworkView>().isMine)
		{
			r.isKinematic = false;
		}
	}

	[RPC]
	public virtual void SetDead()
	{
		exclamation.SetActive(value: true);
		reviveBox.GetComponent<BoxCollider>().enabled = true;
		if (!GetComponent<NetworkView>().isMine)
		{
			GetComponent<Rigidbody>().isKinematic = false;
		}
	}

	[RPC]
	public virtual void SetRevive()
	{
		exclamation.SetActive(value: false);
		reviveBox.GetComponent<BoxCollider>().enabled = false;
	}

	[RPC]
	public virtual void Revive()
	{
		if (Network.isServer)
		{
			RemoveDeadPerson();
			MonoBehaviour.print("isServer");
		}
		else
		{
			MonoBehaviour.print("not server");
			GetComponent<NetworkView>().RPC("RemoveDeadPerson", RPCMode.Server);
		}
		exclamation.SetActive(value: false);
		reviveBox.GetComponent<BoxCollider>().enabled = false;
		exclamation.SetActive(value: false);
		if (GetComponent<NetworkView>().isMine)
		{
			downed = false;
			GameScript.canTakeDamage = true;
			mode = 0;
			gameScript.SetRevive();
			PlayerTriggerScript.canTakeDamage = true;
			trigger.enabled = true;
		}
		else
		{
			r.isKinematic = true;
		}
	}

	[RPC]
	public virtual void Die()
	{
		if (!downed)
		{
			downed = true;
			if (GetComponent<NetworkView>().isMine)
			{
				GetComponent<NetworkView>().RPC("SetDead", RPCMode.All);
				gameScript.SetDead();
				trigger.enabled = false;
				GetComponent<NetworkView>().RPC("AnimDead", RPCMode.All);
				mode = 99;
			}
			else
			{
				MonoBehaviour.print("HELLO DOOD");
				r.isKinematic = false;
			}
			if (Network.isServer)
			{
				AddDeadPerson();
			}
			else
			{
				GetComponent<NetworkView>().RPC("AddDeadPerson", RPCMode.All);
			}
		}
	}

	public virtual void Rev()
	{
		GameScript.HP = 2;
		gameScript.LoadHearts();
		downed = false;
		trigger.enabled = true;
		GetComponent<Collider>().enabled = true;
		r.isKinematic = true;
		@base.gameObject.SetActive(value: true);
		bar.SetActive(value: false);
		mode = 0;
		ghost.SetActive(value: false);
	}

	[RPC]
	public virtual void RevCheck()
	{
		GameScript.playersDead--;
	}

	[RPC]
	public virtual void Lose()
	{
		t.position = new Vector3(99f, 99f, 99f);
	}



	public virtual void OnPlayerDisconnected(NetworkPlayer player)
	{
		Network.RemoveRPCs(player);
		Network.DestroyPlayerObjects(player);
		StartCoroutine(Check());
	}


	public virtual void Shield()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			PlayerTriggerScript.ShieldDEF += 4;
		}
		GetComponent<NetworkView>().RPC("ShieldN", RPCMode.All);
	}

	[RPC]
	public virtual void AnimRun()
	{
		if (!downed)
		{
			@base.GetComponent<Animation>().Stop();
			@base.GetComponent<Animation>().Play("r");
		}
		else
		{
			@base.GetComponent<Animation>().Play("dead");
		}
	}

	[RPC]
	public virtual void AnimIdle()
	{
		if (!downed)
		{
			@base.GetComponent<Animation>().Play("i");
		}
		else
		{
			@base.GetComponent<Animation>().Play("dead");
		}
	}

	[RPC]
	public virtual void AnimJump()
	{
		if (!downed)
		{
			@base.GetComponent<Animation>().Play("j");
		}
		else
		{
			@base.GetComponent<Animation>().Play("dead");
		}
	}

	[RPC]
	public virtual void AnimJump2()
	{
		if (!downed)
		{
			@base.GetComponent<Animation>().Play("dj");
		}
		else
		{
			@base.GetComponent<Animation>().Play("dead");
		}
	}

	public virtual void TDp()
	{
		float num = (float)GameScript.MAXHP * 0.2f;
		int dMG = (int)num;
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			StartCoroutine(trigger.TD(dMG));
		}
	}

	}
