// Decompiled with JetBrains decompiler
// Type: GameScript
// Assembly: Assembly-UnityScript, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 02B1B6D8-E57A-4719-B6A1-229EE70B1103
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Magicite\Magicite_Data\Managed\Assembly-UnityScript.dll

using Boo.Lang.Runtime;
using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class GameScript : MonoBehaviour
{
//Declarations
#region NonSerialized Fields
  [NonSerialized] public static bool debugMode;
  [NonSerialized] public static bool usedAltar;
  [NonSerialized] public static int curAltar;
  [NonSerialized] public static int[] legendary = new int[3];
  [NonSerialized] public static bool interacted;
  [NonSerialized] public static int hitsTaken;
  [NonSerialized] public static bool isCat;
  [NonSerialized] public static int vBonus;
  [NonSerialized] public static int drumATK;
  [NonSerialized] public static int drumDEX;
  [NonSerialized] public static int drumMAG;
  [NonSerialized] public static int timer;
  [NonSerialized] public static int potsUsed;
  [NonSerialized] public static int arrowsShot;
  [NonSerialized] public static bool win;
  [NonSerialized] public static int eggCounter;
  [NonSerialized] public static int fairyCounter;
  [NonSerialized] public static int dragonCounter;
  [NonSerialized] public static int finalBoss;
  [NonSerialized] public static GameObject aSphere;
  [NonSerialized] public static int[] doorBiome = new int[3];
  [NonSerialized] public static GameObject barrierObj;
  [NonSerialized] public static int districtLevel;
  [NonSerialized] public static bool isShopping;
  [NonSerialized] public static int curGold;
  [NonSerialized] public static int[] tempStats = new int[16];
  [NonSerialized] public static int[] tempPlayerStat = new int[4];
  [NonSerialized] public static int[] tempLevelStat = new int[4];
  [NonSerialized] public static int[] tempGearStat = new int[4];
  [NonSerialized] public static bool interacting;
  [NonSerialized] public static bool canTakeDamage = true;
  [NonSerialized] public static int curZone;
  [NonSerialized] public static int curStyle;
  [NonSerialized] public static bool takingDamage;
  [NonSerialized] public static int curBiome;
  [NonSerialized] public static GameObject player;
  [NonSerialized] public static bool menuOpen;
  [NonSerialized] public static bool isInstance;
  [NonSerialized] public static bool facingLeft;
  [NonSerialized] public static bool isReturning;
  [NonSerialized] public static bool changingScene;
  [NonSerialized] public static int cLevel;
  [NonSerialized] public static bool isTown;
  [NonSerialized] public static int hunger;
  [NonSerialized] public static bool isInitialized;
  [NonSerialized] public static int HP;
  [NonSerialized] public static int playerLevel;
  [NonSerialized] public static float exp;
  [NonSerialized] public static float maxEXP = 8f;
  [NonSerialized] public static int count = 8;
  [NonSerialized] public static int readyPlayers;
  [NonSerialized] public static int playersDead;
  [NonSerialized] public static int[] door = new int[3];
  [NonSerialized] public static int finalATK;
  [NonSerialized] public static int finalATKChop;
  [NonSerialized] public static int finalATKMine = 1;
  [NonSerialized] public static int curDoor;
  [NonSerialized] public static bool attacking;
  [NonSerialized] public static int finalATKNet;
  [NonSerialized] public static Item[] npcInventory = new Item[15];
  [NonSerialized] public static bool isCooking;
  [NonSerialized] public static bool canInteract;
  [NonSerialized] public static string interacter;
  [NonSerialized] public static bool inventoryOpen;
  [NonSerialized] public static bool selectingSkill;
  [NonSerialized] public static bool rage;
  [NonSerialized] public static bool clair;
  [NonSerialized] public static int curSkill;
  [NonSerialized] public static int curActiveSlot;
  [NonSerialized] public static int MAG;
  [NonSerialized] public static float SPD = 30f;
  [NonSerialized] public static int MAXHP;
  [NonSerialized] public static int MAXMAG;
  [NonSerialized] public static int DEX;
  [NonSerialized] public static int[] skill = new int[3];
#endregion NonSerialized Fields
#region Serializable Fields
  public GameObject menuAltar;
  public GameObject[] cheatButton;
  private bool addingInput;
  public TextMesh txtInput;
  private int inputCount;
  private int[] inputString;
  private bool cheating;
  public GameObject menuCheat;
  private bool spawningTown;
  public GameObject menuHoarder;
  public Material blacksmithMenu;
  public TextMesh txtNPCName;
  public Material tailorMenu;
  public Material leatherworkerMenu;
  public GameObject musicBox;
  public TextMesh txtTimer;
  private bool selectingReward;
  public GameObject[] rewardChestObj;
  private int[] rewardChest;
  public Material rewShade;
  public Material rewChest;
  public Material rewOpened;
  private int npcInteract;
  public GameObject rewardTop;
  public GameObject rewardBot;
  public GameObject rewardIcon;
  public GameObject rewardShade;
  public TextMesh[] txtRewardTop;
  public TextMesh[] txtRewardBot;
  private bool usingDrum;
  private bool[] isVariant;
  private int[] reward;
  public GameObject menuVictory;
  private string txtStatuss;
  public TextMesh txtStatus2;
  public TextMesh[] txtHighScore;
  public GameObject bAgain;
  public GameObject bMenu;
  public GameObject blackk;
  public LayerMask mask;
  private float[] skillCooldown;
  public GameObject[] skillObj;
  public GameObject menuSkill;
  public GameObject exitObj;
  private bool ATKING;
  public TextMesh txtDied;
  public TextMesh txtZone;
  public TextMesh txtGoldCounter;
  public GameObject expBack2;
  public TextMesh txtLevelEXP;
  public TextMesh txtPercent;
  public TextMesh txtDur;
  public GameObject barEXPback;
  public GameObject barEXP;
  public TextMesh txtStatEXP;
  public GameObject[] barBack;
  public GameObject[] barFill;
  public GameObject gearStats;
  public TextMesh txtDesc;
  public TextMesh[] txtGearStat;
  public GameObject[] trait;
  public AudioClip audioSelect;
  private bool usingPot;
  public AudioClip audioSelect2;
  public AudioClip audioSelect3;
  public AudioClip audioCraftt;
  private bool ForceFullscreen;
  private int accountEXP;
  private float tempEXP;
  public GameObject worm;
  public GameObject GUImana;
  public GameObject goldCounter;
  public GameObject[] skillObjShade;
  public GameObject menuStats;
  public TextMesh[] txtStats;
  public GameObject[] statObj;
  public GameObject menuBlacksmith;
  public GameObject menuAlchemist;
  public GameObject menuTailor;
  public GameObject selectCraft1;
  public GameObject selectCraft2;
  public TextMesh txtLevelName;
  public TextMesh txtStatus;
  private int maxHunger;
  private bool shifting;
  public TextMesh[] txtPlayerStat;
  public Item[] inventory = new Item[31];
  private Item[] temp;
  private bool canAttack;
  public int ATK;
  public int STA;
  public int ATKChop;
  public int ATKMine;
  private int lowestQ;
  private string levelName;
  public Material staminaMaterial;
  public GameObject barStamina;
  public GameObject barMana;
  public AudioClip audioLevelUp;
  public TextMesh txtName;
  public TextMesh txtLevel;
  public TextMesh[] txtBarInfo;
  public Material materialHunger;
  public Material materialHungerNot;
  public int maxStamina;
  public float stamina;
  public GameObject txtItem;
  public AudioClip audioMelee;
  public GameObject menuNewTown;
  public GameObject menuLeaveTown;
  public GameObject menuReturnTown;
  public GameObject menuDefeated;
  public GameObject menuExit;
  public GameObject menuCraft;
  public GameObject sSelected;
  public TextMesh selectedQ;
  public GameObject infoObject;
  public TextMesh[] txtInfoName;
  public TextMesh[] txtStat;
  public TextMesh[] txtInfoEnchantment;
  public GameObject[] inventorySlot;
  public TextMesh[] inventoryQ;
  public GameObject select;
  public GameObject heartsObj;
  public GameObject bg;
  public GameObject bd;
  public TextMesh[] txtIP;
  public GameObject shade;
  public GameObject menuInventory;
  public GameObject menuEquipped;
  private Item craft0;
  private Item craft1;
  private bool crafting;
  private Item firstItemSelected;
  private Item secondItemSelected;
  private int firstItemSelectedSlot;
  private bool usingItem;
  private int secondItemSelectedSlot;
  private GameObject bridge;
  private bool isDead;
  private int interact;
  private int[] curTownNPCs;
  private int hasCurTown;
  private int curTownBiome;
  private Ray ray;
  private Item itemSelected;
  private bool holdingItem;
  private RaycastHit hit;
  private bool enteringIP;
  private int curCharacter;
  private bool generatingLevel;
  private Ray rayCursor;
  private RaycastHit cursorHit;
  private bool dead;
  private bool @using;
  private FadeInOut fade;
  private float atkWait;
  private string atkAnim;
  public GameObject head;
  public GameObject head2;
  public GameObject body;
  public GameObject arm1;
  public GameObject arm2;
  public GameObject leg;
  public GameObject weapon;
  public GameObject offHand;
  public GameObject @base;
  public bool immobilized;
  public Texture2D cursorTexture;
  public Texture2D cursorTexture2;
  private CursorMode cursorMode;
  private Vector2 hotSpot;
#endregion Serializable Fields

// GameScript Constructor
public GameScript()
{
  #region Array
    atkAnim = "a1";
    atkWait = 0.45f;
    barBack = new GameObject[4];
    barFill = new GameObject[4];
    bSmithObject = new GameObject[15];
    bSmithText = new TextMesh[15];
    canAttack = true;
    cheatButton = new GameObject[4];
    curTownNPCs = new int[9];
    hotSpot = new Vector2(8f, 8f);
    inputString = new int[7];
    inventoryQ = new TextMesh[31];
    inventorySlot = new GameObject[31];
    isVariant = new bool[15];
    LUP = new GameObject[4];
    maxHunger = 10;
    maxStamina = 10;
    reward = new int[50];
    rewardChest = new int[4];
    rewardChestObj = new GameObject[4];
    skillCooldown = new float[3];
    skillObj = new GameObject[3];
    skillObjShade = new GameObject[3];
    statObj = new GameObject[16];
    temp = new Item[20];
    trait = new GameObject[3];
    txtBarInfo = new TextMesh[4];
    txtGearStat = new TextMesh[4];
    txtHighScore = new TextMesh[2];
    txtInfoEnchantment = new TextMesh[2];
    txtInfoName = new TextMesh[2];
    txtIP = new TextMesh[2];
    txtPlayerStat = new TextMesh[4];
    txtRewardBot = new TextMesh[2];
    txtRewardTop = new TextMesh[2];
    txtStat = new TextMesh[2];
    txtStats = new TextMesh[16];
	#region Properties
    cursorMode = CursorMode.Auto;
    isDead = false;
    atkWait = 0.45f;
    atkAnim = "a1";
    hotSpot = new Vector2(8f, 8f);
}
//takingDamage
  public virtual void TD(int a) => GameScript.HP -= a;
	//what is TD?
//PurchaseHandler
	public virtual void Purchase(int id)
	{
		MonoBehaviour.print($"Purchasing function called. ID: {id}");

		if (id == 0)
				return;

		int itemPrice = GetItemPrice(id);

		if (GameScript.curGold < itemPrice)
		{
				PlayPurchaseFailSound();
				return;
		}

		ProcessPurchase(id, itemPrice);
	}

	private void PlayPurchaseFailSound()
	{
		AudioSource audioSource = GetComponent<AudioSource>();
		AudioClip failClip = Resources.Load<AudioClip>("Au/FAIL");
		audioSource.PlayOneShot(failClip);
	}

	private void ProcessPurchase(int id, int itemPrice)
	{
		GameScript.curGold -= itemPrice;
		PlayerTriggerScript.itemPurchasing = 0;

		Item purchasedItem = CreatePurchasedItem(id);

		if (purchasedItem.id >= 500)
		{
				purchasedItem.d = (int)GetMaxDurability(purchasedItem.id);
				purchasedItem.e = GetGearStats(purchasedItem.id);
		}

		SpawnPurchasedItem(purchasedItem);

		PlayerTriggerScript.currentStand.GetComponent<NetworkView>().RPC("Exile", RPCMode.All);
		GameScript.isShopping = false;
		RefreshGold();

		AudioSource audioSource = GetComponent<AudioSource>();
		AudioClip purchaseClip = Resources.Load<AudioClip>("Au/PURCHASE");
		audioSource.PlayOneShot(purchaseClip);

		GameScript.player.SendMessage("WW2");
		GameScript.tempStats[11]++;
	}

	private Item CreatePurchasedItem(int id)
	{
		return new Item(id, 1, new int[4], 0.0f, null);
	}

	private void SpawnPurchasedItem(Item item)
	{
		int[] initializationData = new int[7]
		{
				item.id,
				item.q,
				0,
				0,
				0,
				0,
				100
		};

		GameObject newItem = (GameObject)UnityEngine.Object.Instantiate(
				Resources.Load("iLocal"),
				GameScript.player.transform.position,
				Quaternion.identity
		);

		newItem.SendMessage("InitL", initializationData);
		}

	public virtual int GetItemPrice(int id)
  {
      Dictionary<int, int> itemPrices = new Dictionary<int, int>
        {{ 1, 5 },
        { 2, 10 },
        { 3, 5 },
        { 4, 15 },
        { 5, 30 },
        { 6, 70 },
        { 7, 5 },
        { 8, 8 },
        { 9, 10 },
        { 10, 10 },
        { 11, 10 },
        { 12, 30 },
        { 13, 60 },
        { 14, 140 },
        { 15, 20 },
        { 16, 20 },
        { 17, 20 },
        { 18, 7 },
        { 19, 7 },
        { 20, 7 },
        { 21, 5 },
        { 22, 10 },
        { 23, 10 },
        { 24, 15 },
        { 25, 20 },
        { 26, 10 },
        { 27, 15 },
        { 28, 30 },
        { 29, 20 },
        { 30, 20 },
        { 31, 20 },
        { 32, 60 },
        { 33, 120 },
        { 34, 280 },
        { 35, 120 },
        { 36, 240 },
        { 37, 560 },
        { 38, 10 },
        { 39, 20 },
        { 40, 40 },
        { 41, 80 },
        { 42, 45 },
        { 43, 45 },
        { 44, 20 },
        { 45, 45 },
        { 46, 500 },
        { 47, 30 },
        { 48, 65 },
        { 49, 10 },
        { 50, 15 },
        { 51, 5 },
        { 52, 5 },
        { 53, 10 },
        { 54, 20 },
        { 55, 40 },
        { 56, 60 },
        { 500, 35 },
        { 501, 30 },
        { 502, 45 },
        { 503, 120 },
        { 504, 120 },
        { 505, 120 },
        { 506, 300 },
        { 507, 300 },
        { 508, 300 },
        { 509, 700 },
        { 510, 700 },
        { 511, 700 },
        { 512, 55 },
        { 513, 50 },
        { 514, 65 },
        { 515, 100 },
        { 516, 55 },
        { 517, 50 },
        { 518, 65 },
        { 519, 200 },
        { 550, 330 },
        { 560, 135 },
        { 561, 255 },
        { 562, 1000 },
        { 563, 95 },
        { 566, 1000 },
        { 600, 100 },
        { 601, 100 },
        { 602, 100 },
        { 700, 90 },
        { 701, 180 },
        { 702, 420 },
        { 800, 90 },
        { 801, 180 },
        { 802, 420 },
        { 900, 90 },
        { 901, 180 },
        { 902, 420 },
        { 999, 999 } // Default price for unknown items
      };

      int price;
      if (itemPrices.TryGetValue(id, out price))
      {
          return price * 2; // Double the price
      }

      return itemPrices[999] * 2; // Default price for unknown items
  }

	public virtual void RefreshGold()
	{
	    txtGoldCounter.text = $"x{GameScript.curGold}";
	    goldCounter.GetComponent<Animation>().Play();
	}

	//The murder button
  public virtual void SetDead() => this.isDead = true;

	public virtual void SetRevive()
	{
	    isDead = false;
	    GameScript.HP = 1;
	    LoadHearts();
	}

	public virtual void LoadEXP()
	{
	    float exp = GameScript.exp;
	    float maxExp = GameScript.maxEXP;

	    txtStatEXP.text = $"{exp}/{maxExp}";

	    float expRatio = exp / maxExp * 1.15f; // Adjusted the constant for clarity
	    Vector3 newScale = new Vector3(expRatio, barEXP.transform.localScale.y, barEXP.transform.localScale.z);
	    barEXP.transform.localScale = newScale;

	    txtLevel.text = $"Lv: {GameScript.playerLevel}";
	}

	public virtual IEnumerator Invader()
	{
	    return new GameScript.$Invader$1516(this).GetEnumerator();
	}

	public static void EggCounter()
	{
	    // Increment the egg counter
	    GameScript.eggCounter++;

	    // Check if the egg counter is less than 3
	    if (GameScript.eggCounter < 3)
	        return;

	    // Reset the egg counter
	    GameScript.eggCounter = 0;

	    // Release the broodmother
	    Network.Instantiate(
	        Resources.Load("e/broodmother"),
	        new Vector3(GameScript.player.transform.position.x, GameScript.player.transform.position.y + 50f, 0.0f),
	        Quaternion.identity,
	        0
	    );
	}

	public static void FairyCounter()
	{
	    // Increment the fairy counter
	    GameScript.fairyCounter++;

	    // Check if the fairy counter is less than 3
	    if (GameScript.fairyCounter < 3)
	        return;

	    // Reset the fairy counter
	    GameScript.fairyCounter = 0;

	    // Instantiate the "fQueen" game object using the Network system
	    Network.Instantiate(
	        Resources.Load("e/fQueen"),
	        new Vector3(GameScript.player.transform.position.x, GameScript.player.transform.position.y + 50f, 0.0f),
	        Quaternion.identity,
	        0
	    );
	}

	public static void DragonCounter()
	{
	    // Increment the dragon counter
	    GameScript.dragonCounter++;

	    // Check if the dragon counter is less than 1
	    if (GameScript.dragonCounter < 1)
	        return;

	    // Reset the dragon counter
	    GameScript.dragonCounter = 0;

	    // Instantiate the "scourgeDragon" game object using the Network system
	    Network.Instantiate(
	        Resources.Load("e/scourgeDragon"),
	        new Vector3(GameScript.player.transform.position.x, GameScript.player.transform.position.y - 30f, 0.0f),
	        Quaternion.identity,
	        0
	    );
	}

	public virtual void DetectRes()
	{
	    if (Camera.main.aspect >= 1.7f)
	    {
	        Camera.main.orthographicSize = 12f;
	    }
	    else if (Camera.main.aspect >= 1.5f)
	    {
	        Camera.main.orthographicSize = 13f;
	    }
	    else if (Camera.main.aspect >= 1.3f)
	    {
	        Camera.main.orthographicSize = 14.5f;
	    }
	    else if (Camera.main.aspect >= 1.25f)
	    {
	        Camera.main.orthographicSize = 15.2f;
	    }
	}

	public virtual IEnumerator Timer()
	{
	    return new GameScript.$Timer$1521(this).GetEnumerator();
	}

	public virtual void Awake()
	{
	    GameScript.usedAltar = false;
	    Application.targetFrameRate = 60;
	    GameScript.drumATK = 0;
	    GameScript.drumDEX = 0;
	    GameScript.drumMAG = 0;

	    if (Network.isServer)
	        this.StartCoroutine_Auto(this.Timer());

	    this.DetectRes();
	    this.ATKING = false;
	    this.usingPot = false;
	    GameScript.win = false;
	    this.@using = false;
	    GameScript.finalATKNet = 0;
	    GameScript.isFloating = false;
	    GameScript.menuOpen = false;
	    this.canAttack = true;
	    this.dead = false;
	    GameScript.attacking = false;
	    GameScript.inventoryOpen = false;
	    this.immobilized = false;
	    PlayerTriggerScript.isDead = false;
	    PlayerTriggerScript.canTakeDamage = true;
	    GameScript.eggCounter = 0;
	    GameScript.fairyCounter = 0;
	    GameScript.dragonCounter = 0;
	    GameScript.DEXBonus = 0;
	    GameScript.rage = false;
	    PlayerControllerN.downed = false;
	    GameScript.manaWait = 10;
	    this.RefreshSkills();

	    if (!GameScript.isTown)
	        this.StartCoroutine_Auto(this.Invader());

	    Network.minimumAllocatableViewIDs = 700;

	    GameScript.bossDefeated = false;
	    this.txtDied.text = RuntimeServices.op_Addition(MenuScript.curName, " has fallen.");
	    GameScript.isShopping = false;
	    this.accountEXP = MenuScript.accountEXP;
	    this.txtLevel.text = RuntimeServices.op_Addition("Lv: ", (object)GameScript.playerLevel);
	    GameScript.isCooking = false;
	    this.LoadEXP();
	    this.maxHunger = MenuScript.curTrait[1] == 10 || MenuScript.curTrait[2] == 10 ? 12 : 8;
	    GameScript.inventoryOpen = false;
	    GameScript.takingDamage = false;
	    this.fade = (FadeInOut)Camera.main.gameObject.GetComponent("FadeInOut");
	    GameScript.readyPlayers = 0;
	    int playerLevel = GameScript.playerLevel;
	    this.maxStamina = playerLevel > 4 ? (playerLevel > 12 ? 12 : playerLevel) : 4;
	    this.stamina = (float)this.maxStamina;

	    if (!GameScript.isInitialized)
	    {
	        GameScript.win = false;
	        GameScript.interacted = false;
	        GameScript.hitsTaken = 0;

	        for (int index = 0; index < 14; ++index)
	            MenuScript.canUnlockRace[index] = 0;

	        for (int index = 0; index < 25; ++index)
	            MenuScript.canUnlockHat[index] = 0;

	        for (int index = 0; index < 3; ++index)
	            GameScript.legendary[index] = 0;

	        GameScript.arrowsShot = 0;
	        GameScript.curGold = 0;
	        GameScript.potsUsed = 0;
	        GameScript.timer = 0;
	        GameScript.selectingSkill = false;
	        GameScript.curBiome = 0;
	        GameScript.finalBoss = 0;
	        GameScript.skill[0] = 0;
	        GameScript.skill[1] = 0;
	        GameScript.skill[2] = 0;
	        this.RefreshSkills();
	        GameScript.curSkill = 0;
	        GameScript.districtLevel = 1;

	        for (int index = 0; index < 15; ++index)
	            GameScript.tempStats[index] = 0;

	        this.RefreshGold();
	        GameScript.curActiveSlot = 0;
	        GameScript.playerLevel = 1;
	        GameScript.count = 0;
	        GameScript.exp = 0.0f;
	        GameScript.maxEXP = 8f;
	        GameScript.hunger = 8;
	        GameScript.isInitialized = true;

	        for (int index = 0; index < 4; ++index)
	        {
	            GameScript.tempGearStat[index] = 0;
	            GameScript.tempLevelStat[index] = 0;
	            GameScript.tempPlayerStat[index] = 0;
	        }

	        GameScript.MAXHP = MenuScript.playerStat[0] + GameScript.tempPlayerStat[0] + GameScript.tempLevelStat[0];
	        GameScript.HP = GameScript.MAXHP;
	        this.ATK = MenuScript.playerStat[1] + GameScript.tempPlayerStat[1] + GameScript.tempLevelStat[1];
	        GameScript.MAXMAG = MenuScript.playerStat[3] + GameScript.tempPlayerStat[3] + GameScript.tempLevelStat[3] + GameScript.tempGearStat[3];
	        GameScript.MAG = GameScript.MAXMAG;
	        GameScript.DEX = MenuScript.playerStat[2] + GameScript.tempPlayerStat[2] + GameScript.tempLevelStat[2] + GameScript.tempGearStat[2];
	        GameScript.SPD = (float)((double)GameScript.DEX * 0.05000000074505806 + 7.5999999046325684);
	        this.SetRaceStats();

	        if (MenuScript.pHat == 9)
	            GameScript.SPD += 4f;

	        this.SetStartingItems();

	        if (GameScript.districtLevel % 5 != 0)
	            ;

	        switch (GameScript.districtLevel)
	        {
	            case 20:
	                GameScript.finalBoss = 1;
	                break;
	            case 21:
	                GameScript.curBiome = 19;
	                GameScript.isTown = false;
	                break;
	        }

	        GameScript.curBiome = 0;
	    }
	    else
	    {
	        ++GameScript.districtLevel;

	        if (GameScript.districtLevel == 10)
	            MenuScript.canUnlockRace[7] = 1;

	        if (GameScript.districtLevel % 5 != 0)
	            ;

	        switch (GameScript.districtLevel)
	        {
	            case 20:
	                GameScript.finalBoss = 1;
	                break;
	            case 21:
	                GameScript.curBiome = 19;
	                GameScript.isTown = false;
	                break;
	        }

	        if (GameScript.selectingSkill)
	            this.SkillMenu();

	        GameScript.MAXHP = MenuScript.playerStat[0] + GameScript.tempPlayerStat[0] + GameScript.tempLevelStat[0];
	        this.ATK = MenuScript.playerStat[1] + GameScript.tempPlayerStat[1] + GameScript.tempLevelStat[1];
	        GameScript.MAXMAG = MenuScript.playerStat[3] + GameScript.tempPlayerStat[3] + GameScript.tempLevelStat[3] + GameScript.tempGearStat[3];
	        GameScript.DEX = MenuScript.playerStat[2] + GameScript.tempPlayerStat[2] + GameScript.tempLevelStat[2] + GameScript.tempGearStat[2];
	        GameScript.SPD = (float)((double)GameScript.DEX * 0.05000000074505806 + 7.5999999046325684);

	        if (MenuScript.pHat == 9)
	            GameScript.SPD += 4f;

	        this.RefreshGold();
	    }

	    this.select.transform.localPosition = this.GetSelectPos((object)GameScript.curActiveSlot);
	    this.UpdateHunger();
	    GameScript.facingLeft = false;
	    this.dead = false;
	    string curName = MenuScript.curName;
	    Vector3 position = new Vector3(2f, 2f, 0.0f);

	    switch (GameScript.curBiome)
	    {
	        case 1:
	            MenuScript.canUnlockHat[6] = 1;
	            break;
	        case 2:
	            MenuScript.canUnlockHat[7] = 1;
	            break;
	        case 3:
	            MenuScript.canUnlockHat[15] = 1;
	            break;
	        case 5:
	            MenuScript.canUnlockHat[13] = 1;
	            break;
	        case 6:
	            MenuScript.canUnlockHat[16] = 1;
	            break;
	        case 7:
	            MenuScript.canUnlockHat[10] = 1;
	            break;
	        case 9:
	            MenuScript.canUnlockRace[10] = 1;
	            break;
	        case 19:
	            MenuScript.canUnlockHat[17] = 1;
	            break;
	    }

	    GameScript.door[0] = 0;
	    GameScript.door[1] = 0;
	    GameScript.door[2] = 0;

	    if (GameScript.changingScene)
	        ;

	    if (!(bool)(UnityEngine.Object)GameScript.player)
	    {
	        GameScript.player = (GameObject)Network.Instantiate(Resources.Load("playerN"), position, Quaternion.identity, 0);

	        if (GameScript.player.GetComponent<NetworkView>().isMine)
	        {
	            int num7 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
	            int armor = PlayerControllerN.armor;
	            int offhand = PlayerControllerN.offhand;
	            GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object)num7, (object)armor, (object)MenuScript.pRace, (object)offhand, (object)MenuScript.pHat);
	            GameScript.player.GetComponent<NetworkView>().RPC("AssignName", RPCMode.All, (object)MenuScript.curName);
	        }
	    }
	    else if (GameScript.player.GetComponent<NetworkView>().isMine)
	    {
	        int num8 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
	        int armor = PlayerControllerN.armor;
	        int offhand = PlayerControllerN.offhand;
	        GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object)num8, (object)armor, (object)MenuScript.pRace, (object)offhand, (object)MenuScript.pHat);
	        GameScript.player.GetComponent<NetworkView>().RPC("AssignName", RPCMode.All, (object)MenuScript.curName);
	    }

	    GameScript.player.SendMessage("Initialize");

	    if (GameScript.player.GetComponent<NetworkView>().isMine)
	    {
	        this.trait[1].GetComponent<Renderer>().material = (Material)Resources.Load(RuntimeServices.op_Addition("t/t", (object)MenuScript.curTrait[1]), typeof(Material));
	        this.trait[2].GetComponent<Renderer>().material = (Material)Resources.Load(RuntimeServices.op_Addition("t/t", (object)MenuScript.curTrait[2]), typeof(Material));

	        if (GameScript.hunger == 0)
	            GameScript.hunger = this.maxHunger;

	        this.UpdateHunger();
	    }

	    this.@base = GameObject.Find("base");
	    this.head = GameObject.Find("head");
	    this.head2 = GameObject.Find("head2");
	    this.body = GameObject.Find("body");
	    this.arm1 = GameObject.Find("arm1");
	    this.arm2 = GameObject.Find("arm2");
	    this.leg = GameObject.Find("leg");
	    this.weapon = GameObject.Find("item");
	    this.hasCurTown = PlayerPrefs.GetInt("hasTown");
	    GameScript.player.transform.position = new Vector3(0.0f, -1.5f, 0.0f);
	    this.UpdateCharacterWeapon();
	    this.StartCoroutine_Auto(this.GenerateText());
	    this.GenerateLevelName();
	    this.StartCoroutine_Auto(this.ScourgeMaskTick());
	    GameScript.player.transform.position = new Vector3(0.0f, -1.5f, 0.0f);
	    GameScript.player.SendMessage("Initialize");

	    if (GameScript.player.GetComponent<NetworkView>().isMine)
	    {
	        this.trait[1].GetComponent<Renderer>().material = (Material)Resources.Load(RuntimeServices.op_Addition("t/t", (object)MenuScript.curTrait[1]), typeof(Material));
	        this.trait[2].GetComponent<Renderer>().material = (Material)Resources.Load(RuntimeServices.op_Addition("t/t", (object)MenuScript.curTrait[2]), typeof(Material));

	        if (GameScript.hunger == 0)
	            GameScript.hunger = this.maxHunger;

	        this.UpdateHunger();
	    }

	    Camera.main.SendMessage("SetPlayer", (object)GameScript.player);
	    this.@base = GameObject.Find("base");
	    this.head = GameObject.Find("head");
	    this.head2 = GameObject.Find("head2");
	    this.body = GameObject.Find("body");
	    this.arm1 = GameObject.Find("arm1");
	    this.arm2 = GameObject.Find("arm2");
	    this.leg = GameObject.Find("leg");
	    this.weapon = GameObject.Find("weapon");
	    this.UpdateCharacterWeapon();
	    GameScript.isInstance = true;

	    if (!GameScript.isTown)
	    {
	        if (Network.isServer)
	            this.StartCoroutine_Auto(this.GenerateLevel());
	    }
	    else if (Network.isServer)
	        this.StartCoroutine_Auto(this.SpawnTownNetwork());

	    if ((bool)(UnityEngine.Object)GameScript.player)
	    {
	        Camera.main.SendMessage("SetPlayer", (object)GameScript.player.gameObject);
	        GameScript.player.SendMessage("Initialize");
	    }

	    this.RefreshActionBar();
	    this.maxStamina += this.STA;
	    this.RefreshPlayerStats();
	    this.StartCoroutine_Auto(this.RecoverMana());

	    if (Network.isServer && GameScript.curBiome == 19)
	        Network.Instantiate(Resources.Load("e/scourgeWall"), new Vector3(-15f, 0.0f, 0.0f), Quaternion.identity, 0);

	    this.LoadEXP();
	    this.StartCoroutine_Auto(this.TikiCheck());
	    this.LoadSTA();

	    if (MenuScript.companion == 1)
	        this.HealC();
	    else if (MenuScript.companion == 3)
	        GameScript.SPD *= 2f;
	    else if (MenuScript.companion == 9)
	        GameScript.SPD *= 3f;
	    if (MenuScript.companion == 5)
	        this.StartCoroutine_Auto(this.RegenManaComp());
	}


	public virtual IEnumerator RegenManaComp()
	{
	    return new GameScript.$RegenManaComp$1524(this).GetEnumerator();
	}

	public virtual void HealC()
	{
	    GameScript.HP = Mathf.Min(GameScript.HP + 1, GameScript.MAXHP);
	}

	public virtual void SetRaceStats()
	{
	    for (int index = 0; index < 4; ++index)
	    {
	        GameScript.tempLevelStat[index] += MenuScript.raceStats[index];
	    }
	}

	public virtual IEnumerator ScourgeMaskTick()
	{
	    return new GameScript.$ScourgeMaskTick$1527().GetEnumerator();
	}

	public virtual IEnumerator TikiCheck()
	{
	    return new GameScript.$TikiCheck$1528(this).GetEnumerator();
	}

	public virtual IEnumerator RecoverMana()
	{
	    return new GameScript.$RecoverMana$1533(this).GetEnumerator();
	}

	public virtual void SetStartingItems()
	{
	    for (int index = 0; index < 3; ++index)
	    {
	        if (MenuScript.startingItemID[index] != 8888)
	        {
	            if (MenuScript.startingItemID[index] == 9999)
	            {
	                int id = UnityEngine.Random.Range(0, 54);
	                if (id == 49 || id == 11)
	                    id = 9;

	                switch (id)
	                {
	                    case 13:
	                        id = 5;
	                        break;
	                    case 14:
	                        id = 4;
	                        break;
	                    default:
	                        if (id == 32 || id == 35 || id == 36 || id == 37)
	                        {
	                            id = 4;
	                            break;
	                        }
	                        switch (id)
	                        {
	                            case 33:
	                                id = 5;
	                                break;
	                            case 34:
	                                id = 5;
	                                break;
	                        }
	                        break;
	                }

	                GameScript.inventory[index] = new Item(id, 1, new int[4], 0.0f, null);
	            }
	            else
	            {
	                if (MenuScript.startingItemID[index] < 500)
	                {
	                    GameScript.inventory[index] = new Item(MenuScript.startingItemID[index], 1, new int[4], 0.0f, null);
	                }
	                else
	                {
	                    int[] gearStats = this.GetGearStats(MenuScript.startingItemID[index]);
	                    float maxDurability = this.GetMaxDurability(MenuScript.startingItemID[index]);
	                    GameScript.inventory[index] = new Item(MenuScript.startingItemID[index], 1, gearStats, maxDurability, null);
	                }
	            }
	        }
	    }
	}

  public virtual IEnumerator ScourgeBoss(int d) => (IEnumerator) new GameScript.\u0024ScourgeBoss\u00241537(d).GetEnumerator();

  public virtual IEnumerator Write(int num) => (IEnumerator) new GameScript.\u0024Write\u00241541(num, this).GetEnumerator();

  public virtual void GlobalWrite(int a)
  {
    if (!Network.isServer)
      return;
    GameScript.player.GetComponent<NetworkView>().RPC("WritePlayer", RPCMode.All, (object) a);
  }

  public virtual IEnumerator WriteFinal(int a) => (IEnumerator) new GameScript.\u0024WriteFinal\u00241548(a, this).GetEnumerator();

  public virtual IEnumerator GenerateText() => (IEnumerator) new GameScript.\u0024GenerateText\u00241555(this).GetEnumerator();

  public virtual void GenerateLevelName()
  {
    string lhs = GameScript.curBiome == 19 ? "The Scourge Lair" : RuntimeServices.op_Addition(RuntimeServices.op_Addition("District ", (object) GameScript.districtLevel), ": ");
    string rhs;
    switch (GameScript.curBiome)
    {
      case 0:
        rhs = RuntimeServices.op_Addition(this.GetForestPrefix(), " Forest");
        break;
      case 1:
        rhs = RuntimeServices.op_Addition(this.GetTundraPrefix(), " Tundra");
        break;
      case 2:
        rhs = RuntimeServices.op_Addition(this.GetCavePrefix(), " Cave");
        break;
      case 3:
        rhs = RuntimeServices.op_Addition(this.GetDungeonPrefix(), " Dungeon");
        break;
      case 4:
        rhs = RuntimeServices.op_Addition(this.GetCavePrefix(), " Desert");
        break;
      case 5:
        rhs = RuntimeServices.op_Addition(this.GetCavePrefix(), " Veldt");
        break;
      case 6:
        rhs = RuntimeServices.op_Addition(this.GetCavePrefix(), " Volcano");
        break;
      case 7:
        rhs = RuntimeServices.op_Addition(this.GetCavePrefix(), " Swamp");
        break;
      case 8:
        rhs = RuntimeServices.op_Addition(this.GetCavePrefix(), " Quarry");
        break;
      case 9:
        rhs = RuntimeServices.op_Addition(this.GetCavePrefix(), " Crater");
        break;
      default:
        rhs = string.Empty;
        break;
    }
    string str = RuntimeServices.op_Addition(lhs, rhs);
    if (!Network.isServer)
      return;
    GameScript.player.GetComponent<NetworkView>().RPC("SetZoneName", RPCMode.All, (object) str);
  }

  public virtual string GetForestPrefix()
  {
    int num1 = UnityEngine.Random.Range(0, 10);
    int num2 = UnityEngine.Random.Range(0, 10);
    string lhs = (string) null;
    string rhs = (string) null;
    switch (num1)
    {
      case 0:
        lhs = "Thorn";
        break;
      case 1:
        lhs = "Bush";
        break;
      case 2:
        lhs = "Leaf";
        break;
      case 3:
        lhs = "Vine";
        break;
      case 4:
        lhs = "Rock";
        break;
      case 5:
        lhs = "Earth";
        break;
      case 6:
        lhs = "Toad";
        break;
      case 7:
        lhs = "Green";
        break;
      case 8:
        lhs = "Tree";
        break;
      case 9:
        lhs = "Deep";
        break;
      case 10:
        lhs = "Lush";
        break;
    }
    switch (num2)
    {
      case 0:
        rhs = "vale";
        break;
      case 1:
        rhs = "wreath";
        break;
      case 2:
        rhs = "night";
        break;
      case 3:
        rhs = "fire";
        break;
      case 4:
        rhs = "roar";
        break;
      case 5:
        rhs = "fang";
        break;
      case 6:
        rhs = "road";
        break;
      case 7:
        rhs = "wild";
        break;
      case 8:
        rhs = "wood";
        break;
      case 9:
        rhs = "grand";
        break;
      case 10:
        rhs = "flower";
        break;
    }
    return RuntimeServices.op_Addition(lhs, rhs);
  }

  public virtual string GetTundraPrefix()
  {
    int num1 = UnityEngine.Random.Range(0, 10);
    int num2 = UnityEngine.Random.Range(0, 10);
    string str1 = (string) null;
    string str2 = (string) null;
    switch (num1)
    {
      case 0:
        str1 = "Thorn";
        break;
      case 1:
        str1 = "Bush";
        break;
      case 2:
        str1 = "Leaf";
        break;
      case 3:
        str1 = "Vine";
        break;
      case 4:
        str1 = "Rock";
        break;
      case 5:
        str1 = "Earth";
        break;
      case 6:
        str1 = "Toad";
        break;
      case 7:
        str1 = "Green";
        break;
      case 8:
        str1 = "Tree";
        break;
      case 9:
        str1 = "Deep";
        break;
      case 10:
        str1 = "Lush";
        break;
    }
    switch (num2)
    {
      case 0:
        str2 = "vale";
        break;
      case 1:
        str2 = "wreath";
        break;
      case 2:
        str2 = "night";
        break;
      case 3:
        str2 = "fire";
        break;
      case 4:
        str2 = "roar";
        break;
      case 5:
        str2 = "fang";
        break;
      case 6:
        str2 = "road";
        break;
      case 7:
        str2 = "wild";
        break;
      case 8:
        str2 = "wood";
        break;
      case 9:
        str2 = "grand";
        break;
      case 10:
        str2 = "flower";
        break;
    }
    return UnityEngine.Random.Range(0, 2) == 0 ? RuntimeServices.op_Addition(str1, str2) : RuntimeServices.op_Addition(str2, str1);
  }

  public virtual string GetDungeonPrefix()
  {
    int num1 = UnityEngine.Random.Range(0, 10);
    int num2 = UnityEngine.Random.Range(0, 10);
    string str1 = (string) null;
    string str2 = (string) null;
    switch (num1)
    {
      case 0:
        str1 = "Thorn";
        break;
      case 1:
        str1 = "Bush";
        break;
      case 2:
        str1 = "Leaf";
        break;
      case 3:
        str1 = "Vine";
        break;
      case 4:
        str1 = "Rock";
        break;
      case 5:
        str1 = "Earth";
        break;
      case 6:
        str1 = "Toad";
        break;
      case 7:
        str1 = "Green";
        break;
      case 8:
        str1 = "Tree";
        break;
      case 9:
        str1 = "Deep";
        break;
      case 10:
        str1 = "Lush";
        break;
    }
    switch (num2)
    {
      case 0:
        str2 = "vale";
        break;
      case 1:
        str2 = "wreath";
        break;
      case 2:
        str2 = "night";
        break;
      case 3:
        str2 = "fire";
        break;
      case 4:
        str2 = "roar";
        break;
      case 5:
        str2 = "fang";
        break;
      case 6:
        str2 = "road";
        break;
      case 7:
        str2 = "wild";
        break;
      case 8:
        str2 = "wood";
        break;
      case 9:
        str2 = "grand";
        break;
      case 10:
        str2 = "flower";
        break;
    }
    return UnityEngine.Random.Range(0, 2) == 0 ? RuntimeServices.op_Addition(str1, str2) : RuntimeServices.op_Addition(str2, str1);
  }

  public virtual string GetCavePrefix()
  {
    int num1 = UnityEngine.Random.Range(0, 10);
    int num2 = UnityEngine.Random.Range(0, 10);
    string str1 = (string) null;
    string str2 = (string) null;
    switch (num1)
    {
      case 0:
        str1 = "Thorn";
        break;
      case 1:
        str1 = "Bush";
        break;
      case 2:
        str1 = "Leaf";
        break;
      case 3:
        str1 = "Vine";
        break;
      case 4:
        str1 = "Rock";
        break;
      case 5:
        str1 = "Earth";
        break;
      case 6:
        str1 = "Toad";
        break;
      case 7:
        str1 = "Green";
        break;
      case 8:
        str1 = "Tree";
        break;
      case 9:
        str1 = "Deep";
        break;
      case 10:
        str1 = "Lush";
        break;
    }
    switch (num2)
    {
      case 0:
        str2 = "vale";
        break;
      case 1:
        str2 = "wreath";
        break;
      case 2:
        str2 = "night";
        break;
      case 3:
        str2 = "fire";
        break;
      case 4:
        str2 = "roar";
        break;
      case 5:
        str2 = "fang";
        break;
      case 6:
        str2 = "road";
        break;
      case 7:
        str2 = "wild";
        break;
      case 8:
        str2 = "wood";
        break;
      case 9:
        str2 = "grand";
        break;
      case 10:
        str2 = "flower";
        break;
    }
    return UnityEngine.Random.Range(0, 2) == 0 ? RuntimeServices.op_Addition(str1, str2) : RuntimeServices.op_Addition(str2, str1);
  }

  public virtual IEnumerator Start() => (IEnumerator) new GameScript.\u0024Start\u00241561(this).GetEnumerator();

  public virtual IEnumerator StaminaStart() => (IEnumerator) new GameScript.\u0024StaminaStart\u00241564(this).GetEnumerator();

  public virtual void LoadSTA()
  {
    int playerLevel = GameScript.playerLevel;
    this.maxStamina = playerLevel > 4 ? (playerLevel > 12 ? 12 : playerLevel) : 4;
    int num1 = new int();
    float maxStamina = (float) this.maxStamina;
    float stamina = this.stamina;
    this.txtBarInfo[3].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) this.stamina, "/"), (object) this.maxStamina);
    float num2 = maxStamina * 0.3f;
    Vector3 localScale1 = this.barBack[3].transform.localScale;
    double num3 = (double) (localScale1.x = num2);
    Vector3 vector3_1 = this.barBack[3].transform.localScale = localScale1;
    float num4 = stamina * 0.3f;
    Vector3 localScale2 = this.barFill[3].transform.localScale;
    double num5 = (double) (localScale2.x = num4);
    Vector3 vector3_2 = this.barFill[3].transform.localScale = localScale2;
  }

  public virtual void DecreaseHunger()
  {
    if (!GameScript.isTown)
    {
      if (GameScript.hunger > this.maxHunger)
        GameScript.hunger = this.maxHunger;
      if (GameScript.hunger > 0)
        --GameScript.hunger;
      else
        GameScript.player.SendMessage("TD", (object) 1);
      switch (GameScript.hunger)
      {
        case 0:
          this.StartCoroutine_Auto(this.Write(2));
          break;
        case 3:
          this.StartCoroutine_Auto(this.Write(1));
          break;
      }
    }
    this.UpdateHunger();
  }

  public virtual void ShowSkillDesc(int a)
  {
    this.txtSkillDesc.text = this.GetSkillDesc(a);
    this.txtSkillName.text = RuntimeServices.op_Addition(string.Empty, this.GetSkillName(a));
    this.skillDesc.SetActive(true);
  }

  public virtual void CloseSkillDesc()
  {
    this.txtSkillDesc.text = string.Empty;
    this.txtSkillName.text = string.Empty;
    this.skillDesc.SetActive(false);
  }

  public virtual void UpdateHunger()
  {
    if (GameScript.hunger > this.maxHunger)
      GameScript.hunger = this.maxHunger;
    this.txtBarInfo[2].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.hunger, "/"), (object) this.maxHunger);
    float num1 = (float) this.maxHunger * 0.3f;
    Vector3 localScale1 = this.barBack[2].transform.localScale;
    double num2 = (double) (localScale1.x = num1);
    Vector3 vector3_1 = this.barBack[2].transform.localScale = localScale1;
    float num3 = (float) GameScript.hunger * 0.3f;
    Vector3 localScale2 = this.barFill[2].transform.localScale;
    double num4 = (double) (localScale2.x = num3);
    Vector3 vector3_2 = this.barFill[2].transform.localScale = localScale2;
  }

  public virtual string GetTraitDesc(int id)
  {
    switch (id)
    {
      case 1:
        return "Chops down trees quicker.";
      case 2:
        return "Mines ores faster.";
      case 3:
        return "Collects twice as many\ningredients when gathering.";
      case 4:
        return "50% chance to\ncraft Big Potions with\nonly basic ingredients.";
      case 5:
        return "Higher chance at\ncrafting rare weapons\n& gear.";
      case 6:
        return "+2 ATK\n-1 HP";
      case 7:
        return "+4 HP\n-1 ATK.";
      case 8:
        return "+2 DEX";
      case 9:
        return "+2 HP";
      case 10:
        return "Hunger Cap is doubled.";
      case 11:
        return "+2 MAG";
      case 12:
        return "Doesn't need a key when\nopening chests or locks.";
      default:
        return "NULL";
    }
  }

  public virtual string GetTraitName(int id)
  {
    switch (id)
    {
      case 1:
        return "Woodcutter";
      case 2:
        return "Miner";
      case 3:
        return "Gatherer";
      case 4:
        return "Potion Brewer";
      case 5:
        return "Artisan";
      case 6:
        return "Aggressive";
      case 7:
        return "Defensive";
      case 8:
        return "Swift";
      case 9:
        return "Healthy";
      case 10:
        return "Big Eater";
      case 11:
        return "Intelligent";
      case 12:
        return "Lockmaster";
      case 13:
        return "Pickpocket";
      default:
        return "NULL";
    }
  }

  public virtual void ShowTraitDesc(int slot)
  {
    this.traitDesc.SetActive(true);
    this.txtTraitName.text = this.GetTraitName(MenuScript.curTrait[slot]);
    this.txtTraitDesc.text = this.GetTraitDesc(MenuScript.curTrait[slot]);
  }

  public virtual void OpenDoor()
  {
    if (!(bool) (UnityEngine.Object) GameScript.exitObj)
      return;
    GameScript.exitObj.SendMessage("Open");
  }

  public virtual IEnumerator WriteEgg() => (IEnumerator) new GameScript.\u0024WriteEgg\u00241568(this).GetEnumerator();

  public virtual IEnumerator AddInput(int a) => (IEnumerator) new GameScript.\u0024AddInput\u00241571(a, this).GetEnumerator();

  public virtual void CheckInput()
  {
    int num = new int();
    string lhs = string.Empty;
    for (int index = 0; index < 7; ++index)
      lhs = RuntimeServices.op_Addition(lhs, RuntimeServices.op_Addition(string.Empty, (object) this.inputString[index]));
    switch (lhs)
    {
      case "1131313":
        this.txtInput.text = "Cat Form";
        this.CatForm();
        break;
      case "1414131":
        this.txtInput.text = "Unlocked Sean Hat";
        MenuScript.canUnlockHat[23] = 1;
        break;
      case "4431321":
        this.txtInput.text = "Title Set";
        this.SetTitle(1);
        break;
      case "3311323":
        this.txtInput.text = "Title Set";
        this.SetTitle(2);
        break;
      case "4141222":
        this.txtInput.text = "Title Set";
        this.SetTitle(3);
        break;
      case "2334344":
        this.txtInput.text = "Title Set";
        this.SetTitle(4);
        break;
      case "1123111":
        this.txtInput.text = "Title Set";
        this.SetTitle(5);
        break;
      case "1123122":
        this.txtInput.text = "Title Set";
        this.SetTitle(6);
        break;
      case "3313134":
        this.txtInput.text = "Emote!";
        this.Exclusive();
        break;
      case "4441142":
        this.txtInput.text = "Death Unlocked";
        this.DeathAnim();
        break;
      case "1234123":
        this.txtInput.text = "Jared's Bear Hat";
        this.BearHat();
        break;
      default:
        this.txtInput.text = "Invalid Code";
        break;
    }
  }

  public virtual void BearHat() => GameScript.player.GetComponent<NetworkView>().RPC("SetBearHat", RPCMode.All);

  public virtual void Exclusive()
  {
    if (!(bool) (UnityEngine.Object) GameScript.player)
      return;
    Network.Instantiate(Resources.Load("exclusive"), GameScript.player.transform.position, Quaternion.identity, 0);
    int num1 = 20;
    Vector3 velocity = GameScript.player.GetComponent<Rigidbody>().velocity;
    double num2 = (double) (velocity.y = (float) num1);
    Vector3 vector3 = GameScript.player.GetComponent<Rigidbody>().velocity = velocity;
  }

  public virtual void DeathAnim()
  {
    if (MenuScript.deathA == 0)
    {
      PlayerPrefs.SetInt("deathA", 1);
      MenuScript.deathA = 1;
    }
    else
    {
      PlayerPrefs.SetInt("deathA", 1);
      MenuScript.deathA = 1;
    }
  }

  public virtual void SetTitle(int a)
  {
    string str;
    switch (a)
    {
      case 1:
        str = "Item Creator";
        break;
      case 2:
        str = "Enemy Creator";
        break;
      case 3:
        str = "Creator of Gods";
        break;
      case 4:
        str = "Ultimate Fan";
        break;
      case 5:
        str = "Creator of Worlds";
        break;
      case 6:
        str = "Champion";
        break;
      default:
        str = string.Empty;
        break;
    }
    if (!(bool) (UnityEngine.Object) GameScript.player)
      return;
    GameScript.player.GetComponent<NetworkView>().RPC("AssignTitle", RPCMode.All, (object) str);
  }

  public virtual void CatForm()
  {
    if (GameScript.isCat)
    {
      GameScript.isCat = false;
      GameScript.player.SendMessage("Cat", (object) 0);
    }
    else
    {
      GameScript.isCat = true;
      GameScript.player.SendMessage("Cat", (object) 1);
    }
  }

  public virtual void Update()
  {
    if (GameScript.eggCounter >= 3 && !this.writingEgg)
      this.StartCoroutine_Auto(this.WriteEgg());
    if (UnityEngine.Input.GetKeyDown(KeyCode.P) && GameScript.debugMode)
      GameScript.districtLevel = 20;
    if (UnityEngine.Input.GetKeyDown(KeyCode.I) && GameScript.debugMode)
    {
      Network.Instantiate(Resources.Load("e/jelly"), new Vector3(GameScript.player.transform.position.x + 10f, GameScript.player.transform.position.y, 0.0f), Quaternion.identity, 0);
      GameScript.HP = GameScript.MAXHP;
      GameScript.MAG = GameScript.MAXMAG;
      this.LoadHearts();
      GameScript.curGold += 200;
      this.RefreshGold();
      GameObject gameObject1 = (double) Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= (double) GameScript.player.transform.position.x ? (GameObject) UnityEngine.Object.Instantiate(Resources.Load("iLocal"), new Vector3(GameScript.player.transform.position.x - 3f, GameScript.player.transform.position.y, 0.0f), Quaternion.identity) : (GameObject) UnityEngine.Object.Instantiate(Resources.Load("iLocal"), new Vector3(GameScript.player.transform.position.x + 3f, GameScript.player.transform.position.y, 0.0f), Quaternion.identity);
      Item obj1 = new Item(567, 1, new int[4], 999f, (GameObject) null);
      int[] numArray1 = new int[7]
      {
        obj1.id,
        obj1.q,
        0,
        0,
        0,
        0,
        obj1.d
      };
      gameObject1.SendMessage("InitL", (object) numArray1);
      GameObject gameObject2 = (double) Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= (double) GameScript.player.transform.position.x ? (GameObject) UnityEngine.Object.Instantiate(Resources.Load("iLocal"), new Vector3(GameScript.player.transform.position.x - 3f, GameScript.player.transform.position.y, 0.0f), Quaternion.identity) : (GameObject) UnityEngine.Object.Instantiate(Resources.Load("iLocal"), new Vector3(GameScript.player.transform.position.x + 3f, GameScript.player.transform.position.y, 0.0f), Quaternion.identity);
      Item obj2 = new Item(12, 1, new int[4], 999f, (GameObject) null);
      int[] numArray2 = new int[7]
      {
        obj2.id,
        obj2.q,
        0,
        0,
        0,
        0,
        obj2.d
      };
      gameObject2.SendMessage("InitL", (object) numArray2);
    }
    if (UnityEngine.Input.GetKeyDown(KeyCode.U) && GameScript.debugMode)
      this.GainEXP(150);
    if (!GameScript.debugMode)
      ;
    if (UnityEngine.Input.GetButtonDown("Slot 1"))
      this.SelectSlot(0);
    else if (UnityEngine.Input.GetButtonDown("Slot 2"))
      this.SelectSlot(1);
    else if (UnityEngine.Input.GetButtonDown("Slot 3"))
      this.SelectSlot(2);
    else if (UnityEngine.Input.GetButtonDown("Slot 4"))
      this.SelectSlot(3);
    else if (UnityEngine.Input.GetButtonDown("Slot 5"))
      this.SelectSlot(4);
    if ((bool) (UnityEngine.Object) GameScript.player)
      Debug.DrawRay(GameScript.player.transform.position, new Vector3(1f, 0.0f, 0.0f), Color.green);
    if (GameScript.bossDefeated)
    {
      this.OpenDoor();
      GameScript.bossDefeated = false;
    }
    if (GameScript.inventoryOpen || GameScript.menuOpen)
      Cursor.SetCursor(this.cursorTexture2, this.hotSpot, this.cursorMode);
    else
      Cursor.SetCursor(this.cursorTexture, this.hotSpot, this.cursorMode);
    if (UnityEngine.Input.GetKeyDown(KeyCode.F1))
      Screen.SetResolution(512, 320, false);
    else if (UnityEngine.Input.GetKeyDown(KeyCode.F2))
      Screen.SetResolution(640, 400, false);
    else if (UnityEngine.Input.GetKeyDown(KeyCode.F3))
      Screen.SetResolution(800, 500, false);
    else if (UnityEngine.Input.GetKeyDown(KeyCode.F4))
      Screen.SetResolution(960, 600, false);
    else if (UnityEngine.Input.GetKeyDown(KeyCode.F5))
      Screen.SetResolution(1120, 700, false);
    else if (UnityEngine.Input.GetKeyDown(KeyCode.F6))
      Screen.SetResolution(1920, 1080, true);
    if (UnityEngine.Input.GetButtonDown("Inventory") && !this.dead)
      this.OpenInventory();
    int slot1;
    if (GameScript.inventoryOpen)
    {
      this.rayCursor = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
      if (Physics.Raycast(this.rayCursor, out this.cursorHit, 10f, (int) this.mask))
      {
        if (this.cursorHit.transform.gameObject.layer == 10)
        {
          if (this.cursorHit.transform.gameObject.tag == "sIcon")
          {
            int index = int.Parse(this.cursorHit.transform.gameObject.name);
            this.ShowSkillDesc(GameScript.skill[index]);
          }
          else if (this.cursorHit.transform.gameObject.tag == "tIcon")
          {
            this.ShowTraitDesc(int.Parse(this.cursorHit.transform.gameObject.name));
          }
          else
          {
            this.CloseSkillDesc();
            this.traitDesc.SetActive(false);
            slot1 = int.Parse(this.cursorHit.transform.gameObject.tag);
            if (slot1 < 100)
            {
              if (GameScript.inventory[slot1].id != 0)
                this.SetInfoText(slot1, GameScript.inventory[slot1].id);
              else
                this.infoObject.SetActive(false);
            }
          }
        }
        else
        {
          this.CloseSkillDesc();
          this.traitDesc.SetActive(false);
        }
      }
      else
      {
        this.CloseSkillDesc();
        this.traitDesc.SetActive(false);
        this.infoObject.SetActive(false);
      }
    }
    if (UnityEngine.Input.GetButtonDown("CheatKey"))
    {
      if (this.cheating)
      {
        this.cheating = false;
        this.menuCheat.SetActive(false);
      }
      else
      {
        this.cheating = true;
        if (!GameScript.inventoryOpen)
          this.OpenInventory();
        this.menuCheat.SetActive(true);
      }
    }
    if (UnityEngine.Input.GetButtonDown("Skill 1") && !this.dead && GameScript.HP > 0)
      this.UseSkill(0);
    if (UnityEngine.Input.GetButtonDown("Skill 2") && !this.dead && GameScript.HP > 0)
      this.UseSkill(1);
    if (UnityEngine.Input.GetButtonDown("Skill 3") && !this.dead && GameScript.HP > 0)
      this.UseSkill(2);
    if (UnityEngine.Input.GetKeyDown(KeyCode.Escape))
    {
      PlayerPrefs.SetInt("gChests", MenuScript.goldChests);
      if (GameScript.inventoryOpen)
        this.OpenInventory();
      else if (!GameScript.menuOpen && !this.dead)
      {
        if (Network.connections.Length == 0)
          Time.timeScale = 0.0f;
        this.menuExit.SetActive(true);
        GameScript.menuOpen = true;
        this.OpenInventory();
      }
      else if (GameScript.menuOpen && !this.dead)
      {
        if (Network.connections.Length == 0)
          Time.timeScale = 1f;
        this.menuExit.SetActive(false);
        GameScript.menuOpen = false;
      }
    }
    if (UnityEngine.Input.GetButtonDown("Craft"))
      this.shifting = true;
    if (UnityEngine.Input.GetButtonUp("Craft"))
      this.shifting = false;
    if (UnityEngine.Input.GetButtonDown("Melee Attack") && GameScript.menuOpen)
    {
      this.GetComponent<AudioSource>().PlayOneShot(this.audioSelect2);
      this.ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
      if (Physics.Raycast(this.ray, out this.hit, 20f))
      {
        string name = this.hit.transform.gameObject.name;
        if (this.hit.transform.gameObject.tag == "sP")
        {
          if (this.hit.transform.gameObject.name == "sP0")
            this.SelectSkill(0);
          else if (this.hit.transform.gameObject.name == "sP1")
            this.SelectSkill(1);
          else if (this.hit.transform.gameObject.name == "sP2")
            this.SelectSkill(2);
          else
            this.SelectSkill(3);
        }
        switch (name)
        {
          case "bLeave":
            this.LeaveTown();
            break;
          case "bStay":
            GameScript.menuOpen = false;
            this.menuLeaveTown.SetActive(false);
            this.menuReturnTown.SetActive(false);
            break;
          case "bReturn":
            this.ReturnTown();
            break;
          case "0":
            this.StartCoroutine_Auto(this.SelectReward(0));
            break;
          case "1":
            this.StartCoroutine_Auto(this.SelectReward(1));
            break;
          case "2":
            this.StartCoroutine_Auto(this.SelectReward(2));
            break;
          case "3":
            this.StartCoroutine_Auto(this.SelectReward(3));
            break;
          case "bClose":
            this.CloseReward();
            break;
        }
      }
    }
    if (UnityEngine.Input.GetButtonDown("Melee Attack") && GameScript.inventoryOpen && !this.shifting)
    {
      this.ResetCraft();
      this.ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
      if (Physics.Raycast(this.ray, out this.hit, 20f))
      {
        if (this.hit.transform.gameObject.tag == "sP")
        {
          if (this.hit.transform.gameObject.name == "sP0")
            this.SelectSkill(0);
          else if (this.hit.transform.gameObject.name == "sP1")
            this.SelectSkill(1);
          else if (this.hit.transform.gameObject.name == "sP2")
            this.SelectSkill(2);
          else
            this.SelectSkill(3);
        }
        this.GetComponent<AudioSource>().PlayOneShot(this.audioSelect2);
        GameObject gameObject = this.hit.transform.gameObject;
        if (gameObject.name == "drop" && this.holdingItem)
          this.DropItem();
        else if (gameObject.name == "sell" && this.holdingItem)
          this.SellItem();
        else if (gameObject.name == "b1")
          this.StartCoroutine_Auto(this.AddInput(1));
        else if (gameObject.name == "b2")
          this.StartCoroutine_Auto(this.AddInput(2));
        else if (gameObject.name == "b3")
          this.StartCoroutine_Auto(this.AddInput(3));
        else if (gameObject.name == "b4")
          this.StartCoroutine_Auto(this.AddInput(4));
        else if (gameObject.layer == 10 && gameObject.tag != "sIcon" && gameObject.tag != "tIcon")
        {
          int slot2 = int.Parse(gameObject.tag);
          if (!this.holdingItem && GameScript.inventory[slot2].id != 0)
            this.SelectItem(slot2);
          else if (this.holdingItem && GameScript.inventory[slot2].id == 0)
            this.PlaceItem(slot2, gameObject);
          else if (this.holdingItem && GameScript.inventory[slot2].id < 500)
          {
            if (GameScript.inventory[slot2].id == this.itemSelected.id)
              this.CombineItem(slot2);
            else
              this.SwapItem(slot2);
          }
          else if (this.holdingItem && GameScript.inventory[slot2].id >= 500)
          {
            if (slot2 == 20 && this.itemSelected.id >= 700 && this.itemSelected.id < 800)
              this.SwapItem(slot2);
            else if (slot2 == 21 && this.itemSelected.id >= 800 && this.itemSelected.id < 900)
              this.SwapItem(slot2);
            else if (slot2 == 22 && this.itemSelected.id >= 900 && this.itemSelected.id < 950)
              this.SwapItem(slot2);
            else if ((slot2 == 24 || slot2 == 25) && this.itemSelected.id >= 950 && this.itemSelected.id < 1000)
              this.SwapItem(slot2);
            else if (slot2 < 20)
              this.SwapItem(slot2);
          }
        }
        else if (gameObject.layer == 30)
        {
          int slot3 = int.Parse(gameObject.name);
          if (!this.holdingItem && GameScript.npcInventory[slot3].id != 0)
            this.SelectItemNPC(slot3);
          else if (this.holdingItem && GameScript.npcInventory[slot3].id == 0)
            this.PlaceItemNPC(slot3, gameObject);
          else if (this.holdingItem && GameScript.npcInventory[slot3].id < 500)
          {
            if (GameScript.npcInventory[slot3].id == this.itemSelected.id)
              this.CombineItemNPC(slot3);
            else
              this.SwapItemNPC(slot3);
          }
          else if (this.holdingItem && GameScript.npcInventory[slot3].id >= 500)
          {
            if (slot3 == 20 && this.itemSelected.id >= 700 && this.itemSelected.id < 800)
              this.SwapItemNPC(slot3);
            else if (slot3 == 21 && this.itemSelected.id >= 800 && this.itemSelected.id < 900)
              this.SwapItemNPC(slot3);
            else if (slot3 < 20)
              this.SwapItemNPC(slot3);
          }
        }
      }
    }
    else if (UnityEngine.Input.GetButtonDown("Use Item") && GameScript.inventoryOpen && !this.shifting)
    {
      this.ResetCraft();
      this.ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
      if (Physics.Raycast(this.ray, out this.hit, 20f))
      {
        if (this.hit.transform.gameObject.tag == "sP")
        {
          if (this.hit.transform.gameObject.name == "sP0")
            this.SelectSkill(0);
          else if (this.hit.transform.gameObject.name == "sP1")
            this.SelectSkill(1);
          else if (this.hit.transform.gameObject.name == "sP2")
            this.SelectSkill(2);
          else
            this.SelectSkill(3);
        }
        this.GetComponent<AudioSource>().PlayOneShot(this.audioSelect);
        GameObject gameObject = this.hit.transform.gameObject;
        if (gameObject.layer == 10)
        {
          int slot4 = int.Parse(gameObject.tag);
          if (!this.holdingItem && GameScript.inventory[slot4].id != 0 && slot4 < 28)
            this.SelectHalfItem(slot4);
          else if (!this.holdingItem && GameScript.inventory[slot4].id != 0 && slot4 >= 28)
            this.SelectOneItem(slot4);
          else if (this.holdingItem && GameScript.inventory[slot4].id == 0 && slot4 != 20 && slot4 != 21 && slot4 != 22 && slot4 != 24 && slot4 != 25)
            this.PlaceOneItem(slot4, gameObject);
          else if (this.holdingItem && GameScript.inventory[slot4].id == this.itemSelected.id && slot4 >= 28)
            this.AddOneItemHolding(slot4);
          else if (this.holdingItem && GameScript.inventory[slot4].id == this.itemSelected.id)
            this.AddOneItem(slot4);
        }
        else if (gameObject.layer == 30)
        {
          int slot5 = int.Parse(gameObject.name);
          if (!this.holdingItem && GameScript.npcInventory[slot5].id != 0 && slot5 < 11)
            this.SelectHalfItemNPC(slot5);
          else if (!this.holdingItem && GameScript.npcInventory[slot5].id != 0 && slot5 == 11)
            this.SelectOneItemNPC(slot5);
          else if (this.holdingItem && GameScript.npcInventory[slot5].id == 0 && slot5 < 11)
            this.PlaceOneItemNPC(slot5, gameObject);
          else if (this.holdingItem && GameScript.npcInventory[slot5].id == this.itemSelected.id && slot5 == 11)
            this.AddOneItemHoldingNPC(slot5);
          else if (this.holdingItem && GameScript.npcInventory[slot5].id == this.itemSelected.id)
            this.AddOneItemNPC(slot5);
        }
      }
    }
    else if (UnityEngine.Input.GetButtonDown("Melee Attack") && GameScript.inventoryOpen && this.shifting && !this.holdingItem)
    {
      this.ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
      if (Physics.Raycast(this.ray, out this.hit, 20f))
      {
        GameObject gameObject = this.hit.transform.gameObject;
        if (this.hit.transform.gameObject.layer == 10)
        {
          int index = int.Parse(gameObject.tag);
          if (gameObject.layer == 10 && GameScript.inventory[index].id != 0)
          {
            this.GetComponent<AudioSource>().PlayOneShot(this.audioSelect3);
            if (index < 20 && !this.crafting)
            {
              if (index == this.firstItemSelectedSlot)
              {
                this.firstItemSelectedSlot = -1;
                this.firstItemSelected = (Item) null;
                this.selectCraft1.SetActive(false);
              }
              else if (!RuntimeServices.EqualityOperator((object) this.firstItemSelected, (object) null))
              {
                this.crafting = true;
                this.secondItemSelected = GameScript.inventory[slot1];
                this.secondItemSelectedSlot = index;
                this.selectCraft2.SetActive(true);
                this.selectCraft2.transform.position = this.inventorySlot[index].transform.position;
                this.StartCoroutine_Auto(this.Craft());
              }
              else
              {
                this.firstItemSelectedSlot = index;
                this.firstItemSelected = GameScript.inventory[index];
                this.selectCraft1.SetActive(true);
                this.selectCraft1.transform.position = this.inventorySlot[index].transform.position;
              }
            }
          }
        }
      }
    }
    else if (UnityEngine.Input.GetButtonDown("Use Item") && !GameScript.inventoryOpen && !this.isDead && !this.immobilized && !this.usingItem)
      this.StartCoroutine_Auto(this.UseItem(GameScript.curActiveSlot));
    else if (UnityEngine.Input.GetButtonDown("Melee Attack") && !GameScript.inventoryOpen)
    {
      this.ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
      if (!this.isDead && (bool) (UnityEngine.Object) GameScript.player && GameScript.player.GetComponent<NetworkView>().isMine)
        this.Attack(GameScript.curActiveSlot);
      if (Physics.Raycast(this.ray, out this.hit, 20f))
      {
        GameObject gameObject = this.hit.transform.gameObject;
        if (this.hit.transform.gameObject.tag == "sP")
        {
          if (this.hit.transform.gameObject.name == "sP0")
            this.SelectSkill(0);
          else if (this.hit.transform.gameObject.name == "sP1")
            this.SelectSkill(1);
          else if (this.hit.transform.gameObject.name == "sP2")
            this.SelectSkill(2);
          else
            this.SelectSkill(3);
        }
        switch (gameObject.name)
        {
          case "bResume":
            this.Resume();
            break;
          case "bOptions":
            this.Options();
            break;
          case "bMenu":
            this.StartCoroutine_Auto(this.Menuu());
            break;
          case "bQuit":
            this.SaveStats();
            this.StartCoroutine_Auto(this.Menuu());
            break;
          case "bAgain":
            this.Again();
            break;
        }
      }
    }
    if ((double) UnityEngine.Input.GetAxis("mS") > 0.0 && !this.dead)
    {
      this.Scroll(0);
    }
    else
    {
      if ((double) UnityEngine.Input.GetAxis("mS") >= 0.0 || this.dead)
        return;
      this.Scroll(1);
    }
  }

  public virtual void SellItem()
  {
    int num1 = new int();
    int num2 = new int();
    Item itemSelected = this.itemSelected;
    int num3 = UnityEngine.Random.Range(0, 10);
    int num4 = num3 >= 6 ? (num3 >= 9 ? 4 : 3) : 2;
    if (itemSelected.id == 1 || itemSelected.id == 2 || itemSelected.id == 3)
      num4 = 1;
    this.GetComponent<AudioSource>().PlayOneShot((AudioClip) Resources.Load("Au/PURCHASE", typeof (AudioClip)));
    int num5 = num4 * itemSelected.q;
    GameScript.curGold += num5;
    this.RefreshGold();
    this.itemSelected = this.EmptyItem();
    this.holdingItem = false;
    this.sSelected.SetActive(false);
  }

  public virtual void DropItem()
  {
    int num = new int();
    GameObject gameObject = (double) Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= (double) GameScript.player.transform.position.x ? (GameObject) Network.Instantiate(Resources.Load("iNetwork"), new Vector3(GameScript.player.transform.position.x - 3f, GameScript.player.transform.position.y, 0.0f), Quaternion.identity, 0) : (GameObject) Network.Instantiate(Resources.Load("iNetwork"), new Vector3(GameScript.player.transform.position.x + 3f, GameScript.player.transform.position.y, 0.0f), Quaternion.identity, 0);
    Item obj = new Item(this.itemSelected.id, this.itemSelected.q, this.itemSelected.e, (float) this.itemSelected.d, (GameObject) null);
    int[] numArray = new int[7]
    {
      obj.id,
      obj.q,
      obj.e[0],
      obj.e[1],
      obj.e[2],
      obj.e[3],
      obj.d
    };
    gameObject.GetComponent<NetworkView>().RPC("InitL", RPCMode.All, (object) numArray);
    this.itemSelected = this.EmptyItem();
    this.holdingItem = false;
    this.sSelected.SetActive(false);
  }

  public virtual IEnumerator Craft() => (IEnumerator) new GameScript.\u0024Craft\u00241576(this).GetEnumerator();

  public virtual void SaveStats()
  {
    int num = new int();
    this.tempEXP = 0.0f;
    for (int s = 0; s < 15; ++s)
      this.tempEXP += this.ConvertToEXP(s, (float) GameScript.tempStats[s]);
    PlayerPrefs.SetInt("aEXP", MenuScript.accountEXP);
    for (int rhs = 0; rhs < 15; ++rhs)
      PlayerPrefs.SetInt(RuntimeServices.op_Addition("stat", (object) rhs), GameScript.tempStats[rhs] + PlayerPrefs.GetInt(RuntimeServices.op_Addition("stat", (object) rhs)));
    MenuScript.curScore = (int) ((double) this.tempEXP * 2.0);
    if (MenuScript.curScore > PlayerPrefs.GetInt("hScore"))
      PlayerPrefs.SetInt("hScore", MenuScript.curScore);
    this.SetRewards();
  }

  public virtual bool ChanceRace(int a)
  {
    int max;
    switch (a)
    {
      case 6:
        max = 1;
        break;
      case 8:
        max = 1;
        break;
      case 9:
        max = 1;
        break;
      case 10:
        max = 2;
        break;
      case 11:
        max = 1;
        break;
      case 12:
        max = 1;
        break;
      case 13:
        max = 1;
        break;
      case 14:
        max = 1;
        break;
      default:
        max = 5;
        break;
    }
    return UnityEngine.Random.Range(0, max) == 0;
  }

  public virtual bool ChanceHat(int a)
  {
    MonoBehaviour.print((object) RuntimeServices.op_Addition((object) a, " is hat "));
    int max;
    switch (a)
    {
      case 3:
        max = 1;
        break;
      case 11:
        max = 1;
        break;
      case 12:
        max = 1;
        break;
      case 18:
        max = 1;
        break;
      case 19:
        max = 1;
        break;
      case 20:
        max = 1;
        break;
      case 21:
        max = 1;
        break;
      case 22:
        max = 1;
        break;
      case 23:
        max = 1;
        break;
      case 24:
        max = 1;
        break;
      default:
        max = 5;
        break;
    }
    int num = new int();
    return (max != 1 ? UnityEngine.Random.Range(0, max) : 0) == 0;
  }

  public virtual void SetRewards()
  {
    int num1 = new int();
    int num2 = new int();
    for (int index1 = 0; index1 < GameScript.playerLevel; ++index1)
    {
      if (UnityEngine.Random.Range(0, 5) == 0)
      {
        int index2 = UnityEngine.Random.Range(0, 50);
        while (this.reward[index2] != 0)
        {
          ++index2;
          if (index2 > 49)
            index2 = 0;
        }
        this.reward[index2] = 999;
      }
    }
    for (int a = 0; a < 15; ++a)
    {
      if (MenuScript.raceUnlock[a] < 3 && MenuScript.canUnlockRace[a] == 1 && this.ChanceRace(a))
      {
        int rhs = UnityEngine.Random.Range(0, 50);
        while (this.reward[rhs] != 0)
        {
          ++rhs;
          if (rhs > 49)
            rhs = 0;
        }
        this.reward[rhs] = a + 1;
        MonoBehaviour.print((object) RuntimeServices.op_Addition("temp is ", (object) rhs));
        this.isVariant[a] = MenuScript.raceUnlock[a] > 0;
      }
    }
    for (int index3 = 1; index3 < 10; ++index3)
    {
      if (MenuScript.companionUnlock[index3] == 0 && MenuScript.canUnlockCompanion[index3] == 1)
      {
        int index4 = UnityEngine.Random.Range(0, 50);
        while (this.reward[index4] != 0)
        {
          ++index4;
          if (index4 > 49)
            index4 = 0;
        }
        this.reward[index4] = index3 + 100;
      }
    }
    for (int a = 0; a < 25; ++a)
    {
      if (MenuScript.hatUnlock[a] == 0 && MenuScript.canUnlockHat[a] == 1 && this.ChanceHat(a))
      {
        int index = UnityEngine.Random.Range(0, 50);
        while (this.reward[index] != 0)
        {
          ++index;
          if (index > 49)
            index = 0;
        }
        this.reward[index] = a + 200;
      }
    }
    this.RewardShowCheck();
  }

  public virtual void CloseReward()
  {
    this.selectingReward = false;
    this.rewardTop.SetActive(false);
    this.rewardBot.SetActive(false);
    this.rewardShade.SetActive(false);
  }

  public virtual IEnumerator SelectReward(int c) => (IEnumerator) new GameScript.\u0024SelectReward\u00241594(c, this).GetEnumerator();

  public virtual IEnumerator UnlockHat(int h) => (IEnumerator) new GameScript.\u0024UnlockHat\u00241602(h, this).GetEnumerator();

  public virtual IEnumerator UnlockComp(int h) => (IEnumerator) new GameScript.\u0024UnlockComp\u00241607(h, this).GetEnumerator();

  public virtual IEnumerator UnlockVariant(int r) => (IEnumerator) new GameScript.\u0024UnlockVariant\u00241612(r, this).GetEnumerator();

  public virtual IEnumerator UnlockRace(int h) => (IEnumerator) new GameScript.\u0024UnlockRace\u00241617(h, this).GetEnumerator();

  public virtual string GetHatName(int a)
  {
    switch (a)
    {
      case 1:
        return "Gatherer Headband";
      case 2:
        return "Miner Cap";
      case 3:
        return "Berserker Scarf";
      case 4:
        return "Robin Hood Hat";
      case 5:
        return "Magician Hat";
      case 6:
        return "Bunny Ears";
      case 7:
        return "Bat Wing";
      case 8:
        return "Tyrannox Hat";
      case 9:
        return "Wasp Glasses";
      case 10:
        return "Tiki Mask";
      case 11:
        return "Wizard Beard";
      case 12:
        return "Hero Crown";
      case 13:
        return "Shroom Hat";
      case 14:
        return "Spider Egg";
      case 15:
        return "Skeleton Mask";
      case 16:
        return "Dragon Hat";
      case 17:
        return "Scourge Mask";
      case 18:
        return "Frost Crown";
      case 19:
        return "Viking Helm";
      case 20:
        return "Black Dragon Hat";
      case 21:
        return "Skeleton King Hood";
      case 22:
        return "Pirate Hat";
      case 23:
        return "Sean's Head";
      case 24:
        return "Overworld Helm";
      default:
        return string.Empty;
    }
  }

  public virtual string GetRaceName(int race)
  {
    switch (race)
    {
      case 0:
        return "Peon";
      case 1:
        return "Noble";
      case 2:
        return "Orclops";
      case 3:
        return "Dwelf";
      case 4:
        return "Crusader";
      case 5:
        return "Remnant";
      case 6:
        return "Trogon";
      case 7:
        return "Earthkin";
      case 8:
        return "Pigfolk";
      case 9:
        return "Qualogg";
      case 10:
        return "Bandicoot";
      case 11:
        return "Djinn";
      case 12:
        return "Lizardman";
      case 13:
        return "Scourgeling";
      case 14:
        return "Spirit";
      default:
        return "null";
    }
  }

  public virtual string GetCompName(int a)
  {
    switch (a)
    {
      case 1:
        return "Regen Fairy";
      case 2:
        return "Ancient Bat";
      case 3:
        return "Haste Beetle";
      case 4:
        return "Gadget Guard";
      case 5:
        return "Gorgon Eye";
      case 6:
        return "Floaty Slime";
      case 7:
        return "Gooey Ghost";
      case 8:
        return "Flame of Hope";
      case 9:
        return "4th Age Droid";
      case 10:
        return "Tiki Mask";
      case 11:
        return "Wizard Beard";
      case 12:
        return "Hero Crown";
      case 13:
        return "Shroom Hat";
      case 14:
        return "Spider Egg";
      case 15:
        return "Skeleton Mask";
      case 16:
        return "Dragon Hat";
      case 17:
        return "Black";
      default:
        return string.Empty;
    }
  }

  public virtual int GetScoreBonus()
  {
    int num = UnityEngine.Random.Range(0, 100);
    return num <= 90 ? (num <= 70 ? 50 : 200) : 500;
  }

  public virtual void RewardShowCheck()
  {
    int num1 = new int();
    int num2 = new int();
    for (int index = 0; index < 4; ++index)
    {
      if (this.rewardChest[index] == 0)
      {
        int nextReward = this.GetNextReward();
        if (nextReward == 0)
        {
          if (this.rewardChestObj != null)
          {
            this.rewardChestObj[index].GetComponent<Renderer>().material = this.rewShade;
            this.rewardChest[index] = 0;
            this.rewardChestObj[index].GetComponent<Animation>().Stop();
          }
        }
        else if (this.rewardChestObj != null)
        {
          this.rewardChestObj[index].GetComponent<Renderer>().material = this.rewChest;
          this.rewardChestObj[index].GetComponent<Animation>().Play();
          this.rewardChest[index] = nextReward;
        }
      }
    }
  }

  public virtual int GetNextReward()
  {
    int num = new int();
    int nextReward = 0;
    for (int index = 0; index < 50; ++index)
    {
      if (this.reward[index] > 0)
      {
        nextReward = this.reward[index];
        this.reward[index] = 0;
        break;
      }
    }
    return nextReward;
  }

  public virtual float ConvertToEXP(int s, float v)
  {
    switch (s)
    {
      case 1:
        v *= 0.5f;
        break;
      case 2:
        v *= 0.5f;
        break;
      case 3:
        v *= 0.3f;
        break;
      case 4:
        v *= 0.3f;
        break;
      case 5:
        v *= 1f;
        break;
      case 6:
        v *= 0.4f;
        break;
      case 7:
        v *= 0.4f;
        break;
      case 8:
        v *= 0.3f;
        break;
      case 9:
        v *= 0.7f;
        break;
      case 10:
        v *= 2f;
        break;
      case 11:
        v *= 10f;
        break;
      case 12:
        v *= 2f;
        break;
      case 13:
        v *= 60f;
        break;
      case 14:
        v *= 4f;
        break;
      default:
        v *= 0.1f;
        break;
    }
    return v;
  }

  public virtual void BreakSound() => this.gameObject.GetComponent<AudioSource>().PlayOneShot((AudioClip) Resources.Load("Au/break", typeof (AudioClip)));

  public virtual void ResetCraft()
  {
    this.firstItemSelected = (Item) null;
    this.secondItemSelected = (Item) null;
    this.firstItemSelectedSlot = -1;
    this.secondItemSelectedSlot = -1;
    this.crafting = false;
    this.selectCraft1.SetActive(false);
    this.selectCraft2.SetActive(false);
  }

  public virtual void ExitMenuSave()
  {
  }

  public virtual IEnumerator Menuu() => (IEnumerator) new GameScript.\u0024Menuu\u00241622(this).GetEnumerator();

  [RPC]
  public virtual IEnumerator AgainN() => (IEnumerator) new GameScript.\u0024AgainN\u00241625(this).GetEnumerator();

  public virtual void Again()
  {
    if (!Network.isServer)
      return;
    GameScript.player.GetComponent<NetworkView>().RPC("AgainN", RPCMode.All);
  }

  public virtual void Stamina() => this.barStamina.GetComponent<Animation>().Play();

  public virtual void ReturnTown()
  {
    GameScript.changingScene = true;
    GameScript.isReturning = true;
    GameScript.isInstance = false;
    this.SaveInventory();
    GameScript.player.GetComponent<NetworkView>().RPC("LoadLevel", RPCMode.All, (object) 1, (object) false);
  }

  public virtual void LeaveTown()
  {
    GameScript.changingScene = true;
    GameScript.isInstance = true;
    this.SaveInventory();
    GameScript.player.GetComponent<NetworkView>().RPC("LoadLevel", RPCMode.All, (object) 1, (object) true);
  }

  public virtual IEnumerator SpawnTownNetwork() => (IEnumerator) new GameScript.\u0024SpawnTownNetwork\u00241628(this).GetEnumerator();

  public virtual void SetBGNetwork(int tBiome)
  {
  }

  public virtual Vector3 GetHousePos(int a)
  {
    Vector3 housePos = new Vector3();
    switch (a)
    {
      case 0:
        housePos = new Vector3(-9f, 3.5f, 1.5f);
        break;
      case 1:
        housePos = new Vector3(-5f, 3.5f, 1.5f);
        break;
      case 2:
        housePos = new Vector3(5f, 3.5f, 1.5f);
        break;
      case 3:
        housePos = new Vector3(9f, 3.5f, 1.5f);
        break;
      case 4:
        housePos = new Vector3(-9f, -4f, 1.5f);
        break;
      case 5:
        housePos = new Vector3(-5f, -4f, 1.5f);
        break;
      case 6:
        housePos = new Vector3(0.0f, -4f, 1.5f);
        break;
      case 7:
        housePos = new Vector3(5f, -4f, 1.5f);
        break;
      case 8:
        housePos = new Vector3(9f, -4f, 1.5f);
        break;
    }
    return housePos;
  }

  public virtual void UseMana(int m)
  {
    GameScript.MAG -= m;
    this.barMana.GetComponent<Animation>().Play();
    this.LoadMana();
  }

  public virtual IEnumerator ThrowPoison() => (IEnumerator) new GameScript.\u0024ThrowPoison\u00241638(this).GetEnumerator();

  public virtual IEnumerator ThrowDagger(int a) => (IEnumerator) new GameScript.\u0024ThrowDagger\u00241642(a, this).GetEnumerator();

  public virtual IEnumerator ThrowRock() => (IEnumerator) new GameScript.\u0024ThrowRock\u00241653(this).GetEnumerator();

  public virtual IEnumerator UseTotalBiscuit() => (IEnumerator) new GameScript.\u0024UseTotalBiscuit\u00241657(this).GetEnumerator();

  public virtual IEnumerator UseHPPotion(int heal) => (IEnumerator) new GameScript.\u0024UseHPPotion\u00241660(heal, this).GetEnumerator();

  public virtual IEnumerator UseManaPotion(int heal) => (IEnumerator) new GameScript.\u0024UseManaPotion\u00241666(heal, this).GetEnumerator();

  public virtual IEnumerator UseDrum(int drum) => (IEnumerator) new GameScript.\u0024UseDrum\u00241672(drum, this).GetEnumerator();

  public virtual IEnumerator UseItem(int slot) => (IEnumerator) new GameScript.\u0024UseItem\u00241677(slot, this).GetEnumerator();

  [RPC]
  public virtual void Poop(Vector3 pos)
  {
    this.GetComponent<AudioSource>().PlayOneShot((AudioClip) Resources.Load("Au/poop"));
    UnityEngine.Object.Instantiate(Resources.Load("poop"), pos, Quaternion.identity);
  }

  public virtual void Attack(int slot)
  {
    if (GameScript.attacking)
      return;
    GameScript.attacking = true;
    this.StartCoroutine_Auto(this.MeleeAttack());
  }

  public virtual void UseKey()
  {
  }

  public virtual void Ice()
  {
    if (GameScript.MAG < 3)
      return;
    if (MenuScript.pHat == 11)
    {
      if (UnityEngine.Random.Range(0, 3) == 0)
        this.UseMana(3);
    }
    else
      this.UseMana(3);
    GameScript.player.SendMessage("iceShard", (object) (GameScript.MAXMAG + GameScript.drumMAG));
    this.GUImana.GetComponent<Animation>().Play();
  }

  public virtual void Bolt()
  {
    MonoBehaviour.print((object) RuntimeServices.op_Addition((object) MenuScript.pHat, " curhat"));
    if (GameScript.MAG < 1)
      return;
    if (MenuScript.pHat == 11)
    {
      if (UnityEngine.Random.Range(0, 3) == 0)
        this.UseMana(1);
    }
    else
      this.UseMana(1);
    ((GameObject) Network.Instantiate(Resources.Load("proj/bolt"), GameScript.player.transform.position, Quaternion.identity, 0)).SendMessage("Set", (object) (GameScript.MAXMAG + GameScript.drumMAG));
    this.GUImana.GetComponent<Animation>().Play();
  }

  public virtual void Fireball()
  {
    if (GameScript.MAG < 1)
      return;
    if (MenuScript.pHat == 11)
    {
      if (UnityEngine.Random.Range(0, 3) == 0)
        this.UseMana(1);
    }
    else
      this.UseMana(1);
    (!GameScript.facingLeft ? (GameObject) Network.Instantiate(Resources.Load("proj/fireballR"), GameScript.player.transform.position, Quaternion.identity, 0) : (GameObject) Network.Instantiate(Resources.Load("proj/fireballL"), GameScript.player.transform.position, Quaternion.identity, 0)).SendMessage("Set", (object) (GameScript.MAXMAG + GameScript.drumMAG));
    this.GUImana.GetComponent<Animation>().Play();
  }

  public virtual IEnumerator MeleeAttack() => (IEnumerator) new GameScript.\u0024MeleeAttack\u00241738(this).GetEnumerator();

  public virtual IEnumerator v() => (IEnumerator) new GameScript.\u0024v\u00241746().GetEnumerator();

  public virtual IEnumerator KnockBack(Transform h) => (IEnumerator) new GameScript.\u0024KnockBack\u00241747(h).GetEnumerator();

  public virtual void SelectOneItemNPC(int slot)
  {
    if (GameScript.npcInventory[slot].id < 500)
    {
      this.GetComponent<AudioSource>().PlayOneShot(this.audioCrafted);
      this.itemSelected = new Item(GameScript.npcInventory[slot].id, 1, GameScript.npcInventory[slot].e, (float) GameScript.npcInventory[slot].d, (GameObject) null);
      this.UpdateHoldingItem();
      this.holdingItem = true;
      --GameScript.npcInventory[slot].q;
      --GameScript.npcInventory[0].q;
      --GameScript.npcInventory[1].q;
      if (GameScript.npcInventory[0].q <= 0)
        GameScript.npcInventory[0].id = 0;
      if (GameScript.npcInventory[1].q <= 0)
        GameScript.npcInventory[1].id = 0;
      this.BarCheck();
      if (slot == 2 || slot == 3 || slot == 4)
        this.HelmCheck();
      if (slot == 5 || slot == 6 || slot == 7)
        this.ArmorCheck();
      if (slot == 8 || slot == 9 || slot == 10)
        this.ShieldCheck();
      this.RefreshBlacksmith();
    }
    else
      this.SelectItem(slot);
  }

  public virtual void SelectOneItem(int slot)
  {
    if (GameScript.inventory[slot].id < 500)
    {
      this.itemSelected = new Item(GameScript.inventory[slot].id, 1, GameScript.inventory[slot].e, (float) GameScript.inventory[slot].d, (GameObject) null);
      this.UpdateHoldingItem();
      this.holdingItem = true;
      --GameScript.inventory[slot].q;
    }
    else
      this.SelectItem(slot);
  }

  public virtual void SelectHalfItemNPC(int slot)
  {
    int num = new int();
    if (GameScript.npcInventory[slot].q == 1)
      this.SelectItemNPC(slot);
    else if (GameScript.npcInventory[slot].q % 2 == 0)
    {
      this.itemSelected = new Item(GameScript.npcInventory[slot].id, (int) ((double) GameScript.npcInventory[slot].q * 0.5), GameScript.npcInventory[slot].e, (float) GameScript.npcInventory[slot].d, (GameObject) null);
      GameScript.npcInventory[slot].q = (int) ((double) GameScript.npcInventory[slot].q * 0.5);
      this.UpdateHoldingItem();
      this.holdingItem = true;
      int q = this.itemSelected.q;
      if (slot == 11)
      {
        GameScript.npcInventory[0].q -= q;
        GameScript.npcInventory[1].q -= q;
      }
    }
    else
    {
      this.itemSelected = new Item(GameScript.npcInventory[slot].id, (int) ((double) GameScript.npcInventory[slot].q * 0.5 + 1.0), GameScript.npcInventory[slot].e, (float) GameScript.npcInventory[slot].d, (GameObject) null);
      GameScript.npcInventory[slot].q = (int) ((double) GameScript.npcInventory[slot].q * 0.5);
      this.holdingItem = true;
      this.UpdateHoldingItem();
      int q = this.itemSelected.q;
      if (slot == 11)
      {
        GameScript.npcInventory[0].q -= q;
        GameScript.npcInventory[1].q -= q;
      }
    }
    if (slot == 1 || slot == 0)
      this.BarCheck();
    this.RefreshBlacksmith();
  }

  public virtual void SelectHalfItem(int slot)
  {
    int num = new int();
    if (slot >= 20 && slot <= 25)
      return;
    if (GameScript.inventory[slot].q == 1 || GameScript.inventory[slot].q == 0)
      this.SelectItem(slot);
    else if (GameScript.inventory[slot].q % 2 == 0)
    {
      this.itemSelected = new Item(GameScript.inventory[slot].id, (int) ((double) GameScript.inventory[slot].q * 0.5), GameScript.inventory[slot].e, (float) GameScript.inventory[slot].d, (GameObject) null);
      GameScript.inventory[slot].q = (int) ((double) GameScript.inventory[slot].q * 0.5);
      this.UpdateHoldingItem();
      this.holdingItem = true;
      if (slot < 5)
        this.RefreshActionBar();
      else
        this.RefreshInventory();
      int q = this.itemSelected.q;
      if (slot <= 27)
        return;
      GameScript.inventory[26].q -= q;
      GameScript.inventory[27].q -= q;
      this.RefreshInventory();
    }
    else
    {
      this.itemSelected = new Item(GameScript.inventory[slot].id, (int) ((double) GameScript.inventory[slot].q * 0.5 + 1.0), GameScript.inventory[slot].e, (float) GameScript.inventory[slot].d, (GameObject) null);
      GameScript.inventory[slot].q = (int) ((double) GameScript.inventory[slot].q * 0.5);
      this.holdingItem = true;
      this.UpdateHoldingItem();
      if (slot < 5)
        this.RefreshActionBar();
      else
        this.RefreshInventory();
      int q = this.itemSelected.q;
      if (slot <= 27)
        return;
      GameScript.inventory[26].q -= q;
      GameScript.inventory[27].q -= q;
      this.RefreshInventory();
    }
  }

  public virtual void SelectItemNPC(int slot)
  {
    this.holdingItem = true;
    switch (slot)
    {
      case 0:
      case 1:
        this.BarCheck();
        this.itemSelected = GameScript.npcInventory[slot];
        GameScript.npcInventory[slot] = this.EmptyItem();
        break;
      case 2:
      case 3:
      case 4:
        this.HelmCheck();
        this.itemSelected = GameScript.npcInventory[slot];
        GameScript.npcInventory[slot] = this.EmptyItem();
        break;
      case 5:
      case 6:
      case 7:
        this.ArmorCheck();
        this.itemSelected = GameScript.npcInventory[slot];
        GameScript.npcInventory[slot] = this.EmptyItem();
        break;
      case 8:
      case 9:
      case 10:
        this.ShieldCheck();
        this.itemSelected = GameScript.npcInventory[slot];
        GameScript.npcInventory[slot] = this.EmptyItem();
        break;
      case 11:
        this.GetComponent<AudioSource>().PlayOneShot(this.audioCrafted);
        if (GameScript.npcInventory[0].q > this.lowestQ)
          GameScript.npcInventory[0].q -= this.lowestQ;
        else
          GameScript.npcInventory[0] = this.EmptyItem();
        if (GameScript.npcInventory[1].q > this.lowestQ)
          GameScript.npcInventory[1].q -= this.lowestQ;
        else
          GameScript.npcInventory[1] = this.EmptyItem();
        this.itemSelected = GameScript.npcInventory[11];
        GameScript.npcInventory[11] = this.EmptyItem();
        break;
      case 12:
        this.GetComponent<AudioSource>().PlayOneShot(this.audioCrafted);
        if (GameScript.npcInventory[2].q > 1)
          --GameScript.npcInventory[2].q;
        else
          GameScript.npcInventory[2] = this.EmptyItem();
        if (GameScript.npcInventory[3].q > 1)
          --GameScript.npcInventory[3].q;
        else
          GameScript.npcInventory[3] = this.EmptyItem();
        if (GameScript.npcInventory[4].q > 1)
          --GameScript.npcInventory[4].q;
        else
          GameScript.npcInventory[4] = this.EmptyItem();
        this.itemSelected = new Item(GameScript.npcInventory[12].id, 1, this.GetGearStats(GameScript.npcInventory[12].id), this.GetMaxDurability(GameScript.npcInventory[12].id), (GameObject) null);
        GameScript.npcInventory[12] = this.EmptyItem();
        this.HelmCheck();
        break;
      case 13:
        this.GetComponent<AudioSource>().PlayOneShot(this.audioCrafted);
        if (GameScript.npcInventory[5].q > 1)
          --GameScript.npcInventory[5].q;
        else
          GameScript.npcInventory[5] = this.EmptyItem();
        if (GameScript.npcInventory[6].q > 1)
          --GameScript.npcInventory[6].q;
        else
          GameScript.npcInventory[6] = this.EmptyItem();
        if (GameScript.npcInventory[7].q > 1)
          --GameScript.npcInventory[7].q;
        else
          GameScript.npcInventory[7] = this.EmptyItem();
        this.itemSelected = new Item(GameScript.npcInventory[13].id, 1, this.GetGearStats(GameScript.npcInventory[13].id), this.GetMaxDurability(GameScript.npcInventory[13].id), (GameObject) null);
        GameScript.npcInventory[13] = this.EmptyItem();
        this.ArmorCheck();
        break;
      case 14:
        this.GetComponent<AudioSource>().PlayOneShot(this.audioCrafted);
        if (GameScript.npcInventory[8].q > 1)
          --GameScript.npcInventory[8].q;
        else
          GameScript.npcInventory[8] = this.EmptyItem();
        if (GameScript.npcInventory[9].q > 1)
          --GameScript.npcInventory[9].q;
        else
          GameScript.npcInventory[9] = this.EmptyItem();
        if (GameScript.npcInventory[10].q > 1)
          --GameScript.npcInventory[10].q;
        else
          GameScript.npcInventory[10] = this.EmptyItem();
        this.itemSelected = new Item(GameScript.npcInventory[14].id, 1, this.GetGearStats(GameScript.npcInventory[14].id), this.GetMaxDurability(GameScript.npcInventory[14].id), (GameObject) null);
        GameScript.npcInventory[14] = this.EmptyItem();
        this.ShieldCheck();
        break;
      default:
        this.itemSelected = GameScript.npcInventory[slot];
        GameScript.npcInventory[slot] = this.EmptyItem();
        break;
    }
    switch (slot)
    {
      case 0:
      case 1:
        GameScript.npcInventory[slot] = this.EmptyItem();
        this.BarCheck();
        break;
      case 2:
      case 3:
      case 4:
        GameScript.npcInventory[slot] = this.EmptyItem();
        this.HelmCheck();
        break;
      case 5:
      case 6:
      case 7:
        GameScript.npcInventory[slot] = this.EmptyItem();
        this.ArmorCheck();
        break;
      case 8:
      case 9:
      case 10:
        GameScript.npcInventory[slot] = this.EmptyItem();
        this.ShieldCheck();
        break;
    }
    this.RefreshBlacksmith();
    this.UpdateHoldingItem();
    this.RefreshBlacksmith();
  }

  public virtual void SelectItem(int slot)
  {
    int num1 = new int();
    int num2 = new int();
    int num3 = new int();
    int num4 = new int();
    switch (slot)
    {
      case 20:
        PlayerController.helm = 0;
        for (int index = 0; index < 4; ++index)
        {
          if (GameScript.tempGearStat[index] - GameScript.inventory[slot].e[index] >= 0)
            GameScript.tempGearStat[index] = GameScript.tempGearStat[index] - GameScript.inventory[slot].e[index];
        }
        if (GameScript.player.GetComponent<NetworkView>().isMine)
        {
          PlayerControllerN.helm = 0;
          int num5 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
          int armor = PlayerControllerN.armor;
          int offhand = PlayerControllerN.offhand;
          GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object) num5, (object) armor, (object) MenuScript.pRace, (object) offhand, (object) MenuScript.pHat);
          break;
        }
        break;
      case 21:
        PlayerController.armor = 0;
        if (GameScript.player.GetComponent<NetworkView>().isMine)
        {
          PlayerControllerN.armor = 0;
          int num6 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
          int armor = PlayerControllerN.armor;
          int offhand = PlayerControllerN.offhand;
          GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object) num6, (object) armor, (object) MenuScript.pRace, (object) offhand, (object) MenuScript.pHat);
        }
        for (int index = 0; index < 4; ++index)
        {
          if (GameScript.tempGearStat[index] - GameScript.inventory[slot].e[index] >= 0)
            GameScript.tempGearStat[index] = GameScript.tempGearStat[index] - GameScript.inventory[slot].e[index];
        }
        break;
      case 22:
        PlayerController.offhand = 0;
        if (GameScript.player.GetComponent<NetworkView>().isMine)
        {
          PlayerControllerN.offhand = 0;
          int num7 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
          int armor = PlayerControllerN.armor;
          int offhand = PlayerControllerN.offhand;
          GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object) num7, (object) armor, (object) MenuScript.pRace, (object) offhand, (object) MenuScript.pHat);
          this.inventoryQ[slot].text = RuntimeServices.op_Addition(string.Empty, (object) GameScript.inventory[slot].q);
        }
        for (int index = 0; index < 4; ++index)
        {
          if (GameScript.tempGearStat[index] - GameScript.inventory[slot].e[index] >= 0)
            GameScript.tempGearStat[index] = GameScript.tempGearStat[index] - GameScript.inventory[slot].e[index];
        }
        break;
      case 24:
      case 25:
        for (int index = 0; index < 4; ++index)
          GameScript.tempGearStat[index] = GameScript.tempGearStat[index] - GameScript.inventory[slot].e[index];
        break;
    }
    this.holdingItem = true;
    this.itemSelected = GameScript.inventory[slot];
    GameScript.inventory[slot] = this.EmptyItem();
    this.UpdateHoldingItem();
    if (slot < 5)
      this.RefreshActionBar();
    else
      this.RefreshInventory();
    GameScript.MAXMAG = MenuScript.playerStat[3] + GameScript.tempPlayerStat[3] + GameScript.tempLevelStat[3] + GameScript.tempGearStat[3];
    GameScript.DEX = MenuScript.playerStat[2] + GameScript.tempPlayerStat[2] + GameScript.tempLevelStat[2] + GameScript.tempGearStat[2];
    this.UpdateCharacterWeapon();
  }

  public virtual Item EmptyItem() => new Item(0, 0, new int[4], 0.0f, (GameObject) null);

  public virtual void UpdateHoldingItem()
  {
    this.sSelected.GetComponent<Renderer>().material = (Material) Resources.Load(RuntimeServices.op_Addition("i/i", (object) this.itemSelected.id));
    this.sSelected.SetActive(true);
    if (this.itemSelected.q > 1)
      this.selectedQ.text = RuntimeServices.op_Addition(string.Empty, (object) this.itemSelected.q);
    else
      this.selectedQ.text = string.Empty;
  }

  public virtual void PlaceItemNPC(int slot, GameObject g)
  {
    if (slot >= 11)
      return;
    this.holdingItem = false;
    GameScript.npcInventory[slot] = this.itemSelected;
    this.itemSelected = this.EmptyItem();
    this.sSelected.SetActive(false);
    if (this.npcInteract == 1)
    {
      switch (slot)
      {
        case 0:
        case 1:
          this.BarCheck();
          break;
        case 2:
        case 3:
        case 4:
          this.HelmCheck();
          break;
        case 5:
        case 6:
        case 7:
          this.ArmorCheck();
          break;
        case 8:
        case 9:
        case 10:
          this.ShieldCheck();
          break;
      }
      this.RefreshBlacksmith();
    }
    else if (this.npcInteract == 3)
    {
      switch (slot)
      {
        case 0:
        case 1:
          this.HideCheck();
          break;
        case 2:
        case 3:
        case 4:
          this.CapCheck();
          break;
        case 5:
        case 6:
        case 7:
          this.LeatherCheck();
          break;
      }
      this.RefreshLeatherworker();
    }
    else
    {
      if (this.npcInteract != 4)
        return;
      switch (slot)
      {
        case 0:
        case 1:
          this.ClothCheck();
          break;
        case 2:
        case 3:
        case 4:
          this.HoodCheck();
          break;
        case 5:
        case 6:
        case 7:
          this.RobeCheck();
          break;
      }
      this.RefreshTailor();
    }
  }

  public virtual void BarCheck()
  {
    if (GameScript.npcInventory[0].id != 0 && GameScript.npcInventory[1].id != 0)
    {
      string str = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.npcInventory[0].id, "c"), (object) GameScript.npcInventory[1].id);
      this.lowestQ = GameScript.npcInventory[0].q >= GameScript.npcInventory[1].q ? GameScript.npcInventory[1].q : GameScript.npcInventory[0].q;
      switch (str)
      {
        case "4c4":
          this.CraftShow(12, this.lowestQ, 11);
          break;
        case "5c5":
          this.CraftShow(13, this.lowestQ, 11);
          break;
        case "6c6":
          this.CraftShow(14, this.lowestQ, 11);
          break;
        default:
          GameScript.npcInventory[11] = this.EmptyItem();
          this.RefreshBlacksmith();
          break;
      }
    }
    else
    {
      GameScript.npcInventory[11] = this.EmptyItem();
      this.RefreshBlacksmith();
    }
  }

  public virtual void HideCheck()
  {
    if (GameScript.npcInventory[0].id != 0 && GameScript.npcInventory[1].id != 0)
    {
      string str = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.npcInventory[0].id, "c"), (object) GameScript.npcInventory[1].id);
      this.lowestQ = GameScript.npcInventory[0].q >= GameScript.npcInventory[1].q ? GameScript.npcInventory[1].q : GameScript.npcInventory[0].q;
      switch (str)
      {
        case "82c39":
          this.CraftShow(83, this.lowestQ, 11);
          break;
        case "82c51":
          this.CraftShow(84, this.lowestQ, 11);
          break;
        case "82c12":
          this.CraftShow(85, this.lowestQ, 11);
          break;
        case "82c13":
          this.CraftShow(86, this.lowestQ, 11);
          break;
        case "82c14":
          this.CraftShow(87, this.lowestQ, 11);
          break;
        default:
          GameScript.npcInventory[11] = this.EmptyItem();
          this.RefreshBlacksmith();
          break;
      }
    }
    else
    {
      GameScript.npcInventory[11] = this.EmptyItem();
      this.RefreshBlacksmith();
    }
  }

  public virtual void ClothCheck()
  {
    if (GameScript.npcInventory[0].id != 0 && GameScript.npcInventory[1].id != 0)
    {
      string str = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.npcInventory[0].id, "c"), (object) GameScript.npcInventory[1].id);
      this.lowestQ = GameScript.npcInventory[0].q >= GameScript.npcInventory[1].q ? GameScript.npcInventory[1].q : GameScript.npcInventory[0].q;
      switch (str)
      {
        case "94c39":
          this.CraftShow(88, this.lowestQ, 11);
          break;
        case "94c51":
          this.CraftShow(89, this.lowestQ, 11);
          break;
        case "94c12":
          this.CraftShow(90, this.lowestQ, 11);
          break;
        case "94c13":
          this.CraftShow(91, this.lowestQ, 11);
          break;
        case "94c14":
          this.CraftShow(92, this.lowestQ, 11);
          break;
        default:
          GameScript.npcInventory[11] = this.EmptyItem();
          this.RefreshBlacksmith();
          break;
      }
    }
    else
    {
      GameScript.npcInventory[11] = this.EmptyItem();
      this.RefreshBlacksmith();
    }
  }

  public virtual void CapCheck()
  {
    if (GameScript.npcInventory[2].id != 0 && GameScript.npcInventory[3].id != 0 && GameScript.npcInventory[4].id != 0)
    {
      string str = RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.npcInventory[2].id, "c"), (object) GameScript.npcInventory[3].id), "c"), (object) GameScript.npcInventory[4].id);
      int num = new int();
      this.lowestQ = GameScript.npcInventory[2].q;
      if (GameScript.npcInventory[3].q < this.lowestQ)
        this.lowestQ = GameScript.npcInventory[3].q;
      if (GameScript.npcInventory[4].q < this.lowestQ)
        this.lowestQ = GameScript.npcInventory[4].q;
      switch (str)
      {
        case "83c83c83":
          this.CraftShow(705, 1, 12);
          break;
        case "84c84c84":
          this.CraftShow(706, 1, 12);
          break;
        case "85c85c85":
          this.CraftShow(707, 1, 12);
          break;
        case "86c86c86":
          this.CraftShow(708, 1, 12);
          break;
        case "87c87c87":
          this.CraftShow(709, 1, 12);
          break;
        default:
          GameScript.npcInventory[12] = this.EmptyItem();
          this.RefreshBlacksmith();
          break;
      }
    }
    else
    {
      GameScript.npcInventory[12] = this.EmptyItem();
      this.RefreshBlacksmith();
    }
  }

  public virtual void HoodCheck()
  {
    if (GameScript.npcInventory[2].id != 0 && GameScript.npcInventory[3].id != 0 && GameScript.npcInventory[4].id != 0)
    {
      string str = RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.npcInventory[2].id, "c"), (object) GameScript.npcInventory[3].id), "c"), (object) GameScript.npcInventory[4].id);
      int num = new int();
      this.lowestQ = GameScript.npcInventory[2].q;
      if (GameScript.npcInventory[3].q < this.lowestQ)
        this.lowestQ = GameScript.npcInventory[3].q;
      if (GameScript.npcInventory[4].q < this.lowestQ)
        this.lowestQ = GameScript.npcInventory[4].q;
      switch (str)
      {
        case "88c88c88":
          this.CraftShow(710, 1, 12);
          break;
        case "89c89c89":
          this.CraftShow(711, 1, 12);
          break;
        case "90c90c90":
          this.CraftShow(712, 1, 12);
          break;
        case "91c91c91":
          this.CraftShow(713, 1, 12);
          break;
        case "92c92c92":
          this.CraftShow(714, 1, 12);
          break;
        default:
          GameScript.npcInventory[12] = this.EmptyItem();
          this.RefreshBlacksmith();
          break;
      }
    }
    else
    {
      GameScript.npcInventory[12] = this.EmptyItem();
      this.RefreshBlacksmith();
    }
  }

  public virtual void HelmCheck()
  {
    if (GameScript.npcInventory[2].id != 0 && GameScript.npcInventory[3].id != 0 && GameScript.npcInventory[4].id != 0)
    {
      string str = RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.npcInventory[2].id, "c"), (object) GameScript.npcInventory[3].id), "c"), (object) GameScript.npcInventory[4].id);
      int num = new int();
      this.lowestQ = GameScript.npcInventory[2].q;
      if (GameScript.npcInventory[3].q < this.lowestQ)
        this.lowestQ = GameScript.npcInventory[3].q;
      if (GameScript.npcInventory[4].q < this.lowestQ)
        this.lowestQ = GameScript.npcInventory[4].q;
      switch (str)
      {
        case "12c12c12":
          this.CraftShow(700, 1, 12);
          break;
        case "13c13c13":
          this.CraftShow(701, 1, 12);
          break;
        case "14c14c14":
          this.CraftShow(702, 1, 12);
          break;
        case "39c39c39":
          this.CraftShow(703, 1, 12);
          break;
        case "51c51c51":
          this.CraftShow(704, 1, 12);
          break;
        default:
          GameScript.npcInventory[12] = this.EmptyItem();
          this.RefreshBlacksmith();
          break;
      }
    }
    else
    {
      GameScript.npcInventory[12] = this.EmptyItem();
      this.RefreshBlacksmith();
    }
  }

  public virtual void LeatherCheck()
  {
    if (GameScript.npcInventory[5].id != 0 && GameScript.npcInventory[6].id != 0 && GameScript.npcInventory[7].id != 0)
    {
      string str = RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.npcInventory[5].id, "c"), (object) GameScript.npcInventory[6].id), "c"), (object) GameScript.npcInventory[7].id);
      int num = new int();
      this.lowestQ = GameScript.npcInventory[5].q;
      if (this.lowestQ <= GameScript.npcInventory[6].q)
        ;
      this.lowestQ = GameScript.npcInventory[6].q;
      if (this.lowestQ <= GameScript.npcInventory[6].q)
        ;
      this.lowestQ = GameScript.npcInventory[6].q;
      switch (str)
      {
        case "83c83c83":
          this.CraftShow(805, 1, 13);
          break;
        case "84c84c84":
          this.CraftShow(806, 1, 13);
          break;
        case "85c85c85":
          this.CraftShow(807, 1, 13);
          break;
        case "86c86c86":
          this.CraftShow(808, 1, 13);
          break;
        case "87c87c87":
          this.CraftShow(809, 1, 13);
          break;
        default:
          GameScript.npcInventory[13] = this.EmptyItem();
          this.RefreshBlacksmith();
          this.RefreshLeatherworker();
          this.RefreshTailor();
          break;
      }
    }
    else
    {
      GameScript.npcInventory[13] = this.EmptyItem();
      this.RefreshBlacksmith();
      this.RefreshLeatherworker();
      this.RefreshTailor();
    }
  }

  public virtual void RobeCheck()
  {
    if (GameScript.npcInventory[5].id != 0 && GameScript.npcInventory[6].id != 0 && GameScript.npcInventory[7].id != 0)
    {
      string str = RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.npcInventory[5].id, "c"), (object) GameScript.npcInventory[6].id), "c"), (object) GameScript.npcInventory[7].id);
      int num = new int();
      this.lowestQ = GameScript.npcInventory[5].q;
      if (this.lowestQ <= GameScript.npcInventory[6].q)
        ;
      this.lowestQ = GameScript.npcInventory[6].q;
      if (this.lowestQ <= GameScript.npcInventory[6].q)
        ;
      this.lowestQ = GameScript.npcInventory[6].q;
      switch (str)
      {
        case "88c88c88":
          this.CraftShow(810, 1, 13);
          break;
        case "89c89c89":
          this.CraftShow(811, 1, 13);
          break;
        case "90c90c90":
          this.CraftShow(812, 1, 13);
          break;
        case "91c91c91":
          this.CraftShow(813, 1, 13);
          break;
        case "92c92c92":
          this.CraftShow(814, 1, 13);
          break;
        default:
          GameScript.npcInventory[13] = this.EmptyItem();
          this.RefreshBlacksmith();
          this.RefreshLeatherworker();
          this.RefreshTailor();
          break;
      }
    }
    else
    {
      GameScript.npcInventory[13] = this.EmptyItem();
      this.RefreshBlacksmith();
      this.RefreshLeatherworker();
      this.RefreshTailor();
    }
  }

  public virtual void ArmorCheck()
  {
    if (GameScript.npcInventory[5].id != 0 && GameScript.npcInventory[6].id != 0 && GameScript.npcInventory[7].id != 0)
    {
      string str = RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.npcInventory[5].id, "c"), (object) GameScript.npcInventory[6].id), "c"), (object) GameScript.npcInventory[7].id);
      int num = new int();
      this.lowestQ = GameScript.npcInventory[5].q;
      if (this.lowestQ <= GameScript.npcInventory[6].q)
        ;
      this.lowestQ = GameScript.npcInventory[6].q;
      if (this.lowestQ <= GameScript.npcInventory[6].q)
        ;
      this.lowestQ = GameScript.npcInventory[6].q;
      switch (str)
      {
        case "12c12c12":
          this.CraftShow(800, 1, 13);
          break;
        case "13c13c13":
          this.CraftShow(801, 1, 13);
          break;
        case "14c14c14":
          this.CraftShow(802, 1, 13);
          break;
        case "39c39c39":
          this.CraftShow(803, 1, 13);
          break;
        case "51c51c51":
          this.CraftShow(804, 1, 13);
          break;
        default:
          GameScript.npcInventory[13] = this.EmptyItem();
          this.RefreshBlacksmith();
          break;
      }
    }
    else
    {
      GameScript.npcInventory[13] = this.EmptyItem();
      this.RefreshBlacksmith();
    }
  }

  public virtual void ShieldCheck()
  {
    if (GameScript.npcInventory[8].id != 0 && GameScript.npcInventory[9].id != 0 && GameScript.npcInventory[10].id != 0)
    {
      string str = RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.npcInventory[8].id, "c"), (object) GameScript.npcInventory[9].id), "c"), (object) GameScript.npcInventory[10].id);
      int num = new int();
      this.lowestQ = GameScript.npcInventory[8].q;
      if (this.lowestQ <= GameScript.npcInventory[9].q)
        ;
      this.lowestQ = GameScript.npcInventory[9].q;
      if (this.lowestQ <= GameScript.npcInventory[10].q)
        ;
      this.lowestQ = GameScript.npcInventory[10].q;
      switch (str)
      {
        case "12c12c12":
          this.CraftShow(900, 1, 14);
          break;
        case "13c13c13":
          this.CraftShow(901, 1, 14);
          break;
        case "14c14c14":
          this.CraftShow(902, 1, 14);
          break;
        case "39c39c39":
          this.CraftShow(903, 1, 14);
          break;
        case "51c51c51":
          this.CraftShow(904, 1, 14);
          break;
        default:
          GameScript.npcInventory[14] = this.EmptyItem();
          this.RefreshBlacksmith();
          break;
      }
    }
    else
    {
      GameScript.npcInventory[14] = this.EmptyItem();
      this.RefreshBlacksmith();
    }
  }

  public virtual void PlaceItem(int slot, GameObject g)
  {
    int num1 = new int();
    int num2 = new int();
    int num3 = new int();
    int num4 = new int();
    if (slot < 28)
    {
      switch (slot)
      {
        case 20:
          if (this.itemSelected.id >= 700 && this.itemSelected.id < 800)
          {
            this.holdingItem = false;
            GameScript.inventory[slot] = this.itemSelected;
            this.itemSelected = this.EmptyItem();
            this.sSelected.SetActive(false);
            PlayerController.helm = GameScript.inventory[slot].id;
            if (GameScript.player.GetComponent<NetworkView>().isMine)
              PlayerControllerN.helm = GameScript.inventory[slot].id;
            for (int index = 0; index < 4; ++index)
              GameScript.tempGearStat[index] = GameScript.tempGearStat[index] + GameScript.inventory[slot].e[index];
            if (GameScript.player.GetComponent<NetworkView>().isMine)
            {
              int num5 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
              int armor = PlayerControllerN.armor;
              int offhand = PlayerControllerN.offhand;
              GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object) num5, (object) armor, (object) MenuScript.pRace, (object) offhand, (object) MenuScript.pHat);
            }
            this.RefreshInventory();
            break;
          }
          break;
        case 21:
          if (this.itemSelected.id >= 800 && this.itemSelected.id < 900)
          {
            this.holdingItem = false;
            GameScript.inventory[slot] = this.itemSelected;
            PlayerController.armor = this.itemSelected.id;
            if (GameScript.player.GetComponent<NetworkView>().isMine)
            {
              PlayerControllerN.armor = GameScript.inventory[slot].id;
              int num6 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
              int armor = PlayerControllerN.armor;
              int offhand = PlayerControllerN.offhand;
              GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object) num6, (object) armor, (object) MenuScript.pRace, (object) offhand, (object) MenuScript.pHat);
            }
            for (int index = 0; index < 4; ++index)
              GameScript.tempGearStat[index] = GameScript.tempGearStat[index] + GameScript.inventory[slot].e[index];
            this.itemSelected = this.EmptyItem();
            this.sSelected.SetActive(false);
            this.RefreshInventory();
            break;
          }
          break;
        case 22:
          if (this.itemSelected.id >= 900 && this.itemSelected.id < 950)
          {
            this.holdingItem = false;
            GameScript.inventory[slot] = this.itemSelected;
            for (int index = 0; index < 4; ++index)
              GameScript.tempGearStat[index] = GameScript.tempGearStat[index] + GameScript.inventory[slot].e[index];
            PlayerController.offhand = this.itemSelected.id;
            if (GameScript.player.GetComponent<NetworkView>().isMine)
            {
              PlayerControllerN.offhand = GameScript.inventory[slot].id;
              int num7 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
              int armor = PlayerControllerN.armor;
              int offhand = PlayerControllerN.offhand;
              GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object) num7, (object) armor, (object) MenuScript.pRace, (object) offhand, (object) MenuScript.pHat);
            }
            this.itemSelected = this.EmptyItem();
            this.sSelected.SetActive(false);
            this.RefreshInventory();
            break;
          }
          break;
        case 23:
          if (this.itemSelected.id >= 52 && this.itemSelected.id <= 56)
          {
            this.holdingItem = false;
            GameScript.inventory[slot] = this.itemSelected;
            this.itemSelected = this.EmptyItem();
            this.inventoryQ[slot].text = RuntimeServices.op_Addition(string.Empty, (object) GameScript.inventory[slot].q);
            this.sSelected.SetActive(false);
            this.RefreshInventory();
            break;
          }
          break;
        case 24:
          if (this.itemSelected.id >= 950 && this.itemSelected.id < 958)
          {
            this.holdingItem = false;
            GameScript.inventory[slot] = this.itemSelected;
            this.itemSelected = this.EmptyItem();
            this.sSelected.SetActive(false);
            for (int index = 0; index < 4; ++index)
              GameScript.tempGearStat[index] = GameScript.tempGearStat[index] + GameScript.inventory[slot].e[index];
            this.RefreshInventory();
            break;
          }
          break;
        case 25:
          if (this.itemSelected.id >= 950 && this.itemSelected.id < 958)
          {
            this.holdingItem = false;
            GameScript.inventory[slot] = this.itemSelected;
            this.itemSelected = this.EmptyItem();
            this.sSelected.SetActive(false);
            for (int index = 0; index < 4; ++index)
              GameScript.tempGearStat[index] = GameScript.tempGearStat[index] + GameScript.inventory[slot].e[index];
            this.RefreshInventory();
            break;
          }
          break;
        case 100:
          if (this.itemSelected.id == 4 || this.itemSelected.id == 5 || this.itemSelected.id == 6)
          {
            this.holdingItem = false;
            GameScript.npcInventory[int.Parse(g.name)] = this.itemSelected;
            this.itemSelected = this.EmptyItem();
            this.sSelected.SetActive(false);
            this.RefreshBlacksmith();
            break;
          }
          break;
        default:
          this.holdingItem = false;
          GameScript.inventory[slot] = this.itemSelected;
          this.itemSelected = this.EmptyItem();
          this.sSelected.SetActive(false);
          if (slot < 5)
          {
            this.RefreshActionBar();
            break;
          }
          this.RefreshInventory();
          break;
      }
    }
    this.UpdateCharacterWeapon();
    GameScript.MAXMAG = MenuScript.playerStat[3] + GameScript.tempPlayerStat[3] + GameScript.tempLevelStat[3] + GameScript.tempGearStat[3];
    this.LoadMana();
    GameScript.DEX = MenuScript.playerStat[2] + GameScript.tempPlayerStat[2] + GameScript.tempLevelStat[2] + GameScript.tempGearStat[2];
  }

  public virtual void RefreshTailor()
  {
    int num = new int();
    for (int index = 0; index < 15; ++index)
    {
      if (GameScript.npcInventory[index].id != 0)
      {
        this.bSmithObject[index].GetComponent<Renderer>().enabled = true;
        this.bSmithObject[index].GetComponent<Renderer>().material = (Material) Resources.Load(RuntimeServices.op_Addition("i/i", (object) GameScript.npcInventory[index].id));
        this.bSmithText[index].text = GameScript.npcInventory[index].q <= 1 || GameScript.npcInventory[index].id >= 500 ? string.Empty : RuntimeServices.op_Addition(string.Empty, (object) GameScript.npcInventory[index].q);
      }
      else
      {
        this.bSmithObject[index].GetComponent<Renderer>().enabled = false;
        this.bSmithText[index].text = string.Empty;
      }
    }
    this.bSmithObject[8].SetActive(false);
    this.bSmithObject[9].SetActive(false);
    this.bSmithObject[10].SetActive(false);
    this.bSmithObject[14].SetActive(false);
  }

  public virtual void RefreshLeatherworker()
  {
    int num = new int();
    for (int index = 0; index < 15; ++index)
    {
      if (GameScript.npcInventory[index].id != 0)
      {
        this.bSmithObject[index].GetComponent<Renderer>().enabled = true;
        this.bSmithObject[index].GetComponent<Renderer>().material = (Material) Resources.Load(RuntimeServices.op_Addition("i/i", (object) GameScript.npcInventory[index].id));
        this.bSmithText[index].text = GameScript.npcInventory[index].q <= 1 || GameScript.npcInventory[index].id >= 500 ? string.Empty : RuntimeServices.op_Addition(string.Empty, (object) GameScript.npcInventory[index].q);
      }
      else
      {
        this.bSmithObject[index].GetComponent<Renderer>().enabled = false;
        this.bSmithText[index].text = string.Empty;
      }
    }
    this.bSmithObject[8].SetActive(false);
    this.bSmithObject[9].SetActive(false);
    this.bSmithObject[10].SetActive(false);
    this.bSmithObject[14].SetActive(false);
  }

  public virtual void RefreshBlacksmith()
  {
    int num = new int();
    for (int index = 0; index < 15; ++index)
    {
      if (GameScript.npcInventory[index].id != 0)
      {
        this.bSmithObject[index].GetComponent<Renderer>().enabled = true;
        this.bSmithObject[index].GetComponent<Renderer>().material = (Material) Resources.Load(RuntimeServices.op_Addition("i/i", (object) GameScript.npcInventory[index].id));
        this.bSmithText[index].text = GameScript.npcInventory[index].q <= 1 || GameScript.npcInventory[index].id >= 500 ? string.Empty : RuntimeServices.op_Addition(string.Empty, (object) GameScript.npcInventory[index].q);
      }
      else
      {
        this.bSmithObject[index].GetComponent<Renderer>().enabled = false;
        this.bSmithText[index].text = string.Empty;
      }
    }
    this.bSmithObject[8].SetActive(true);
    this.bSmithObject[9].SetActive(true);
    this.bSmithObject[10].SetActive(true);
    this.bSmithObject[14].SetActive(true);
  }

  public virtual void CraftShow(int s0, int q, int i)
  {
    GameScript.npcInventory[i] = new Item(s0, q, new int[4], 0.0f, (GameObject) null);
    this.RefreshBlacksmith();
  }

  public virtual void PlaceOneItemNPC(int slot, GameObject g)
  {
    if (this.itemSelected.id >= 500)
    {
      this.PlaceItemNPC(slot, g);
    }
    else
    {
      GameScript.npcInventory[slot] = new Item(this.itemSelected.id, 1, this.itemSelected.e, (float) this.itemSelected.d, (GameObject) null);
      --this.itemSelected.q;
      this.RefreshBlacksmith();
      if (this.itemSelected.q == 0)
      {
        this.holdingItem = false;
        this.itemSelected = this.EmptyItem();
        this.sSelected.SetActive(false);
      }
      this.UpdateHoldingItem();
      if (this.npcInteract == 1)
      {
        switch (slot)
        {
          case 0:
          case 1:
            this.BarCheck();
            break;
          case 2:
          case 3:
          case 4:
            this.HelmCheck();
            break;
          case 5:
          case 6:
          case 7:
            this.ArmorCheck();
            break;
          case 8:
          case 9:
          case 10:
            this.ShieldCheck();
            break;
        }
        this.RefreshBlacksmith();
      }
      else if (this.npcInteract == 3)
      {
        switch (slot)
        {
          case 0:
          case 1:
            this.HideCheck();
            break;
          case 2:
          case 3:
          case 4:
            this.CapCheck();
            break;
          case 5:
          case 6:
          case 7:
            this.LeatherCheck();
            break;
        }
        this.RefreshLeatherworker();
      }
      else
      {
        if (this.npcInteract != 4)
          return;
        switch (slot)
        {
          case 0:
          case 1:
            this.ClothCheck();
            break;
          case 2:
          case 3:
          case 4:
            this.HoodCheck();
            break;
          case 5:
          case 6:
          case 7:
            this.RobeCheck();
            break;
        }
        this.RefreshTailor();
      }
    }
  }

  public virtual void PlaceOneItem(int slot, GameObject g)
  {
    if (slot >= 28)
      return;
    if (this.itemSelected.id >= 500)
    {
      this.PlaceItem(slot, g);
    }
    else
    {
      GameScript.inventory[slot] = new Item(this.itemSelected.id, 1, this.itemSelected.e, (float) this.itemSelected.d, (GameObject) null);
      --this.itemSelected.q;
      switch (slot)
      {
        case 26:
          this.craft0 = GameScript.inventory[slot];
          if (slot < 5)
          {
            this.RefreshActionBar();
            break;
          }
          this.RefreshInventory();
          break;
        case 27:
          this.craft1 = GameScript.inventory[slot];
          if (slot < 5)
          {
            this.RefreshActionBar();
            break;
          }
          this.RefreshInventory();
          break;
      }
      if (this.itemSelected.q == 0)
      {
        this.holdingItem = false;
        this.itemSelected = this.EmptyItem();
        this.sSelected.SetActive(false);
      }
      this.UpdateHoldingItem();
      if (slot < 5)
        this.RefreshActionBar();
      else
        this.RefreshInventory();
      this.UpdateCharacterWeapon();
    }
  }

  public virtual void AddOneItemHoldingNPC(int slot)
  {
    if (GameScript.npcInventory[slot].id >= 500)
      return;
    switch (slot)
    {
      case 11:
        this.GetComponent<AudioSource>().PlayOneShot(this.audioCrafted);
        if (GameScript.npcInventory[0].q > 1)
          --GameScript.npcInventory[0].q;
        else
          GameScript.npcInventory[0] = this.EmptyItem();
        if (GameScript.npcInventory[1].q > 1)
        {
          --GameScript.npcInventory[1].q;
          break;
        }
        GameScript.npcInventory[1] = this.EmptyItem();
        break;
      case 12:
        this.GetComponent<AudioSource>().PlayOneShot(this.audioCrafted);
        if (GameScript.npcInventory[2].q > 1)
          --GameScript.npcInventory[2].q;
        else
          GameScript.npcInventory[2] = this.EmptyItem();
        if (GameScript.npcInventory[3].q > 1)
          --GameScript.npcInventory[3].q;
        else
          GameScript.npcInventory[3] = this.EmptyItem();
        if (GameScript.npcInventory[4].q > 1)
          --GameScript.npcInventory[4].q;
        else
          GameScript.npcInventory[4] = this.EmptyItem();
        GameScript.npcInventory[12] = this.EmptyItem();
        this.HelmCheck();
        break;
      case 13:
        this.GetComponent<AudioSource>().PlayOneShot(this.audioCrafted);
        if (GameScript.npcInventory[5].q > 1)
          --GameScript.npcInventory[5].q;
        else
          GameScript.npcInventory[5] = this.EmptyItem();
        if (GameScript.npcInventory[6].q > 1)
          --GameScript.npcInventory[6].q;
        else
          GameScript.npcInventory[6] = this.EmptyItem();
        if (GameScript.npcInventory[7].q > 1)
          --GameScript.npcInventory[7].q;
        else
          GameScript.npcInventory[7] = this.EmptyItem();
        GameScript.npcInventory[13] = this.EmptyItem();
        this.ArmorCheck();
        break;
      case 14:
        this.GetComponent<AudioSource>().PlayOneShot(this.audioCrafted);
        if (GameScript.npcInventory[8].q > 1)
          --GameScript.npcInventory[8].q;
        else
          GameScript.npcInventory[8] = this.EmptyItem();
        if (GameScript.npcInventory[9].q > 1)
          --GameScript.npcInventory[9].q;
        else
          GameScript.npcInventory[9] = this.EmptyItem();
        if (GameScript.npcInventory[10].q > 1)
          --GameScript.npcInventory[10].q;
        else
          GameScript.npcInventory[10] = this.EmptyItem();
        GameScript.npcInventory[14] = this.EmptyItem();
        this.ShieldCheck();
        break;
    }
    this.GetComponent<AudioSource>().PlayOneShot(this.audioCrafted);
    ++this.itemSelected.q;
    this.UpdateHoldingItem();
    if (GameScript.npcInventory[0].q == 0)
      GameScript.npcInventory[0] = this.EmptyItem();
    if (GameScript.npcInventory[1].q == 0)
      GameScript.npcInventory[1] = this.EmptyItem();
    switch (slot)
    {
      case 0:
      case 1:
      case 11:
        this.BarCheck();
        break;
      case 2:
      case 3:
      case 4:
        this.HelmCheck();
        break;
      case 5:
      case 6:
      case 7:
        this.ArmorCheck();
        break;
      case 8:
      case 9:
      case 10:
        this.ShieldCheck();
        break;
    }
    this.RefreshBlacksmith();
  }

  public virtual void AddOneItemHolding(int slot) => ++this.itemSelected.q;

  public virtual void AddOneItemNPC(int slot)
  {
    if (GameScript.npcInventory[slot].q + 1 > 99 || GameScript.npcInventory[slot].id >= 500)
      return;
    ++GameScript.npcInventory[slot].q;
    --this.itemSelected.q;
    if (this.itemSelected.q == 0)
    {
      this.holdingItem = false;
      this.itemSelected = this.EmptyItem();
      this.sSelected.SetActive(false);
    }
    this.RefreshBlacksmith();
    if (this.npcInteract == 1)
    {
      switch (slot)
      {
        case 0:
        case 1:
          this.BarCheck();
          break;
        case 2:
        case 3:
        case 4:
          this.HelmCheck();
          break;
        case 5:
        case 6:
        case 7:
          this.ArmorCheck();
          break;
        case 8:
        case 9:
        case 10:
          this.ShieldCheck();
          break;
      }
      this.RefreshBlacksmith();
    }
    else if (this.npcInteract == 3)
    {
      switch (slot)
      {
        case 0:
        case 1:
          this.HideCheck();
          break;
        case 2:
        case 3:
        case 4:
          this.CapCheck();
          break;
        case 5:
        case 6:
        case 7:
          this.LeatherCheck();
          break;
      }
      this.RefreshLeatherworker();
    }
    else if (this.npcInteract == 4)
    {
      switch (slot)
      {
        case 0:
        case 1:
          this.ClothCheck();
          break;
        case 2:
        case 3:
        case 4:
          this.HoodCheck();
          break;
        case 5:
        case 6:
        case 7:
          this.RobeCheck();
          break;
      }
      this.RefreshTailor();
    }
    this.UpdateHoldingItem();
  }

  public virtual void AddOneItem(int slot)
  {
    if ((GameScript.inventory[slot].q + 1 > 99 || GameScript.inventory[slot].id >= 500) && (GameScript.inventory[slot].q + 1 > 999 || GameScript.inventory[slot].id < 52 || GameScript.inventory[slot].id > 56))
      return;
    ++GameScript.inventory[slot].q;
    --this.itemSelected.q;
    if (this.itemSelected.q == 0)
    {
      this.holdingItem = false;
      this.itemSelected = this.EmptyItem();
      this.sSelected.SetActive(false);
    }
    if (slot < 5)
      this.RefreshActionBar();
    else
      this.RefreshInventory();
    this.UpdateHoldingItem();
  }

  public virtual void SwapItemNPC(int slot)
  {
    if (slot < 11)
    {
      Item obj = GameScript.npcInventory[slot];
      GameScript.npcInventory[slot] = this.itemSelected;
      this.itemSelected = obj;
      this.UpdateHoldingItem();
      switch (slot)
      {
        case 0:
        case 1:
          this.BarCheck();
          break;
        case 2:
        case 3:
        case 4:
          this.HelmCheck();
          break;
        case 5:
        case 6:
        case 7:
          this.ArmorCheck();
          break;
        case 8:
        case 9:
        case 10:
          this.ShieldCheck();
          break;
      }
    }
    this.RefreshBlacksmith();
  }

  public virtual void SwapItem(int slot)
  {
    int num1 = new int();
    int num2 = new int();
    int num3 = new int();
    Item obj = GameScript.inventory[slot];
    int num4 = new int();
    GameScript.inventory[slot] = this.itemSelected;
    this.itemSelected = obj;
    this.UpdateHoldingItem();
    switch (slot)
    {
      case 20:
        for (int index = 0; index < 4; ++index)
          GameScript.tempGearStat[index] = GameScript.tempGearStat[index] - this.itemSelected.e[index];
        for (int index = 0; index < 4; ++index)
          GameScript.tempGearStat[index] = GameScript.tempGearStat[index] + GameScript.inventory[slot].e[index];
        PlayerController.helm = GameScript.inventory[slot].id;
        if (GameScript.player.GetComponent<NetworkView>().isMine)
        {
          PlayerControllerN.helm = GameScript.inventory[slot].id;
          int num5 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
          int armor = PlayerControllerN.armor;
          int offhand = PlayerControllerN.offhand;
          GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object) num5, (object) armor, (object) MenuScript.pRace, (object) offhand, (object) MenuScript.pHat);
          break;
        }
        break;
      case 21:
        for (int index = 0; index < 4; ++index)
          GameScript.tempGearStat[index] = GameScript.tempGearStat[index] - this.itemSelected.e[index];
        for (int index = 0; index < 4; ++index)
          GameScript.tempGearStat[index] = GameScript.tempGearStat[index] + GameScript.inventory[slot].e[index];
        PlayerController.armor = GameScript.inventory[slot].id;
        if (GameScript.player.GetComponent<NetworkView>().isMine)
        {
          PlayerControllerN.armor = GameScript.inventory[slot].id;
          int num6 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
          int armor = PlayerControllerN.armor;
          int offhand = PlayerControllerN.offhand;
          GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object) num6, (object) armor, (object) MenuScript.pRace, (object) offhand, (object) MenuScript.pHat);
          break;
        }
        break;
      case 22:
        for (int index = 0; index < 4; ++index)
          GameScript.tempGearStat[index] = GameScript.tempGearStat[index] - this.itemSelected.e[index];
        for (int index = 0; index < 4; ++index)
          GameScript.tempGearStat[index] = GameScript.tempGearStat[index] + GameScript.inventory[slot].e[index];
        PlayerController.offhand = GameScript.inventory[slot].id;
        if (GameScript.player.GetComponent<NetworkView>().isMine)
        {
          PlayerControllerN.offhand = GameScript.inventory[slot].id;
          int num7 = PlayerControllerN.helm <= 0 ? MenuScript.pVariant : PlayerControllerN.helm;
          int armor = PlayerControllerN.armor;
          int offhand = PlayerControllerN.offhand;
          GameScript.player.GetComponent<NetworkView>().RPC("UpdateAppearance", RPCMode.All, (object) num7, (object) armor, (object) MenuScript.pRace, (object) offhand, (object) MenuScript.pHat);
          break;
        }
        break;
      case 24:
      case 25:
        for (int index = 0; index < 4; ++index)
          GameScript.tempGearStat[index] = GameScript.tempGearStat[index] - this.itemSelected.e[index];
        for (int index = 0; index < 4; ++index)
          GameScript.tempGearStat[index] = GameScript.tempGearStat[index] + GameScript.inventory[slot].e[index];
        break;
    }
    if (slot < 5)
      this.RefreshActionBar();
    else
      this.RefreshInventory();
    this.UpdateCharacterWeapon();
  }

  public virtual void CombineItemNPC(int slot)
  {
    if (GameScript.npcInventory[slot].id >= 500)
      return;
    if (GameScript.npcInventory[slot].q + this.itemSelected.q <= 99)
    {
      GameScript.npcInventory[slot].q += this.itemSelected.q;
      this.holdingItem = false;
      this.itemSelected = this.EmptyItem();
      this.sSelected.SetActive(false);
    }
    else
    {
      this.itemSelected.q -= 99 - GameScript.npcInventory[slot].q;
      GameScript.npcInventory[slot].q = 99;
    }
    if (this.npcInteract == 1)
    {
      switch (slot)
      {
        case 0:
        case 1:
          this.BarCheck();
          break;
        case 2:
        case 3:
        case 4:
          this.HelmCheck();
          break;
        case 5:
        case 6:
        case 7:
          this.ArmorCheck();
          break;
        case 8:
        case 9:
        case 10:
          this.ShieldCheck();
          break;
      }
      this.RefreshBlacksmith();
    }
    else if (this.npcInteract == 3)
    {
      switch (slot)
      {
        case 0:
        case 1:
          this.HideCheck();
          break;
        case 2:
        case 3:
        case 4:
          this.CapCheck();
          break;
        case 5:
        case 6:
        case 7:
          this.LeatherCheck();
          break;
      }
      this.RefreshLeatherworker();
    }
    else if (this.npcInteract == 4)
    {
      switch (slot)
      {
        case 0:
        case 1:
          this.ClothCheck();
          break;
        case 2:
        case 3:
        case 4:
          this.HoodCheck();
          break;
        case 5:
        case 6:
        case 7:
          this.RobeCheck();
          break;
      }
      this.RefreshTailor();
    }
    this.RefreshBlacksmith();
  }

  public virtual void CombineItem(int slot)
  {
    if (GameScript.inventory[slot].q + this.itemSelected.q <= 99 || GameScript.inventory[slot].q + this.itemSelected.q <= 999 && this.itemSelected.id >= 52 && this.itemSelected.id <= 56)
    {
      GameScript.inventory[slot].q += this.itemSelected.q;
      this.holdingItem = false;
      this.itemSelected = this.EmptyItem();
      this.sSelected.SetActive(false);
    }
    else
    {
      this.itemSelected.q -= 99 - GameScript.inventory[slot].q;
      GameScript.inventory[slot].q = 99;
    }
    if (slot < 5)
      this.RefreshActionBar();
    else
      this.RefreshInventory();
  }

  public virtual void DeleteInventory()
  {
    int num = new int();
    for (int index = 0; index < 31; ++index)
      GameScript.inventory[index] = this.EmptyItem();
    for (int index = 0; index < 15; ++index)
      GameScript.npcInventory[index] = this.EmptyItem();
  }

  public virtual void LoadInventory()
  {
    int num = new int();
    this.DeleteInventory();
    for (int rhs = 0; rhs < 31; ++rhs)
    {
      GameScript.inventory[rhs].id = PlayerPrefs.GetInt(RuntimeServices.op_Addition("id", (object) rhs));
      GameScript.inventory[rhs].q = PlayerPrefs.GetInt(RuntimeServices.op_Addition("q", (object) rhs));
      GameScript.inventory[rhs].d = PlayerPrefs.GetInt(RuntimeServices.op_Addition("d", (object) rhs));
    }
  }

  public virtual void SaveInventory()
  {
    int num = new int();
    for (int rhs = 0; rhs < 31; ++rhs)
    {
      if (GameScript.inventory[rhs] != null)
      {
        PlayerPrefs.SetInt(RuntimeServices.op_Addition("id", (object) rhs), GameScript.inventory[rhs].id);
        PlayerPrefs.SetInt(RuntimeServices.op_Addition("q", (object) rhs), GameScript.inventory[rhs].q);
        PlayerPrefs.SetInt(RuntimeServices.op_Addition("d", (object) rhs), GameScript.inventory[rhs].d);
      }
    }
  }

  public virtual void RefreshPlayerStats()
  {
    int num = new int();
    int[] numArray = new int[4];
    for (int index = 0; index < 4; ++index)
      numArray[index] = GameScript.tempPlayerStat[index] + GameScript.tempGearStat[index] + MenuScript.playerStat[index] + GameScript.tempLevelStat[index];
    numArray[1] = numArray[1] + GameScript.drumATK;
    numArray[2] = numArray[2] + GameScript.drumDEX;
    numArray[3] = numArray[3] + GameScript.drumMAG;
    for (int a = 0; a < 4; ++a)
      this.txtPlayerStat[a].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition(this.GetStatName(a), ": "), (object) numArray[a]);
    GameScript.MAXHP = numArray[0] <= 0 ? 1 : numArray[0];
    GameScript.MAXMAG = numArray[3];
    this.LoadHearts();
    this.LoadMana();
  }

  public virtual string GetStatName(int a)
  {
    switch (a)
    {
      case 0:
        return "HP";
      case 1:
        return "ATK";
      case 2:
        return "DEX";
      case 3:
        return "MAG";
      default:
        return "NULL";
    }
  }

  public virtual int AddItem(Item item)
  {
    int num1 = new int();
    int num2 = new int();
    if (item.id < 500)
    {
      if (item.id >= 52 && item.id <= 59 && item.id == GameScript.inventory[23].id)
      {
        GameScript.inventory[23].q += item.q;
        ((GameObject) UnityEngine.Object.Instantiate((UnityEngine.Object) this.txtItem, GameScript.player.transform.position, Quaternion.identity)).SendMessage("ST", (object) this.GetItemName(item.id));
        if (GameScript.inventoryOpen)
          this.RefreshInventory();
        return 1;
      }
      for (int index = 0; index < 20; ++index)
      {
        if (GameScript.inventory[index].id == item.id && GameScript.inventory[index].q < 99 || GameScript.inventory[index].id == item.id && GameScript.inventory[index].id >= 52 && GameScript.inventory[index].id <= 56 && GameScript.inventory[index].q < 999)
        {
          GameScript.inventory[index].q += item.q;
          num2 = 1;
          ((GameObject) UnityEngine.Object.Instantiate((UnityEngine.Object) this.txtItem, GameScript.player.transform.position, Quaternion.identity)).SendMessage("ST", (object) this.GetItemName(item.id));
          this.RefreshActionBar();
          if (GameScript.inventoryOpen)
            this.RefreshInventory();
          this.UpdateCharacterWeapon();
          return 1;
        }
      }
      for (int index = 0; index < 20; ++index)
      {
        if (GameScript.inventory[index].id == 0)
        {
          GameScript.inventory[index].id = item.id;
          GameScript.inventory[index].q = item.q;
          num2 = 1;
          ((GameObject) UnityEngine.Object.Instantiate((UnityEngine.Object) this.txtItem, GameScript.player.transform.position, Quaternion.identity)).SendMessage("ST", (object) this.GetItemName(item.id));
          this.RefreshActionBar();
          if (GameScript.inventoryOpen)
            this.RefreshInventory();
          this.UpdateCharacterWeapon();
          return 1;
        }
      }
    }
    else
    {
      for (int index = 0; index < 20; ++index)
      {
        if (GameScript.inventory[index].id == 0)
        {
          GameScript.inventory[index].id = item.id;
          GameScript.inventory[index].q = item.q;
          GameScript.inventory[index].e = item.e;
          GameScript.inventory[index].d = item.d;
          ((GameObject) UnityEngine.Object.Instantiate((UnityEngine.Object) this.txtItem, GameScript.player.transform.position, Quaternion.identity)).SendMessage("ST", (object) this.GetGearName(item.id));
          this.RefreshActionBar();
          if (GameScript.inventoryOpen)
            this.RefreshInventory();
          this.UpdateCharacterWeapon();
          return 1;
        }
      }
    }
    return 0;
  }

  public virtual void SetInfoText(int slot, int id)
  {
    this.infoObject.SetActive(true);
    if (id >= 500)
    {
      this.gearStats.SetActive(true);
      this.txtDesc.gameObject.SetActive(false);
      this.txtInfoName[0].text = this.GetGearName(id);
      this.txtDur.text = RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition("Durability: ", (object) GameScript.inventory[slot].d), "/"), (object) this.GetMaxDurability(id));
      if (GameScript.inventory[slot].tier == 3)
        this.txtInfoName[0].gameObject.GetComponent<Renderer>().material.color = Color.magenta;
      else if (GameScript.inventory[slot].tier == 2)
        this.txtInfoName[0].gameObject.GetComponent<Renderer>().material.color = Color.yellow;
      else if (GameScript.inventory[slot].tier == 1)
        this.txtInfoName[0].gameObject.GetComponent<Renderer>().material.color = Color.cyan;
      else
        this.txtInfoName[0].gameObject.GetComponent<Renderer>().material.color = Color.white;
      int num = new int();
      for (int a = 0; a < 4; ++a)
      {
        if (GameScript.inventory[slot].e[a] > 0)
        {
          this.txtGearStat[a].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition(this.GetStatName(a), "+ "), (object) GameScript.inventory[slot].e[a]);
          this.txtGearStat[a].gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (GameScript.inventory[slot].e[a] < 0)
        {
          this.txtGearStat[a].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition(this.GetStatName(a), string.Empty), (object) GameScript.inventory[slot].e[a]);
          this.txtGearStat[a].gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
          this.txtGearStat[a].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition(this.GetStatName(a), "+ "), (object) 0);
          this.txtGearStat[a].gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
      }
    }
    else
    {
      this.gearStats.SetActive(false);
      this.txtDesc.gameObject.SetActive(true);
      this.txtDesc.text = this.GetItemDesc(id);
      this.txtInfoName[0].text = this.GetItemName(id);
      this.txtInfoName[0].gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    this.txtInfoName[1].text = this.txtInfoName[0].text;
  }

  public virtual string GetItemDesc(int id)
  {
    switch (id)
    {
      case 1:
        return "A basic piece of\nwood used to\nmake planks.";
      case 7:
        return "Restores 1 hunger.";
      case 8:
        return "Restores 3 hunger.\n50% chance to heal.";
      case 9:
        return "A vital ingredient\nfor making potions.";
      case 15:
        return "Heals 2 HP.";
      case 21:
        return "Restores 1 hunger.";
      case 22:
        return "Restores 3 hunger.\n50% chance to heal.";
      case 42:
        return "Heals 5 HP.";
      case 46:
        return "increases HP and\nMAG by 3.";
      case 95:
        return "Cannot be used in\nTown.";
      default:
        return string.Empty;
    }
  }

  public virtual void SelectSlot(int a)
  {
    if (this.@using || this.usingItem || this.usingPot || this.ATKING)
      return;
    GameScript.curActiveSlot = a;
    this.UpdateCharacterWeapon();
    this.select.transform.localPosition = this.GetSelectPos((object) GameScript.curActiveSlot);
  }

  public virtual void Scroll(int dir)
  {
    if (this.@using || this.usingItem || this.usingPot || this.ATKING)
      return;
    if (dir == 0)
    {
      if (GameScript.curActiveSlot > 0)
        --GameScript.curActiveSlot;
      else
        GameScript.curActiveSlot = 4;
    }
    else if (GameScript.curActiveSlot < 4)
      ++GameScript.curActiveSlot;
    else
      GameScript.curActiveSlot = 0;
    this.UpdateCharacterWeapon();
    this.RefreshPlayerStats();
    this.select.transform.localPosition = this.GetSelectPos((object) GameScript.curActiveSlot);
  }

  public virtual Vector3 GetSelectPos(object slot)
  {
    Vector3 selectPos = new Vector3();
    object lhs = slot;
    if (RuntimeServices.EqualityOperator(lhs, (object) 0))
      selectPos = new Vector3(-18.75f, 11.05f, 8.75f);
    else if (RuntimeServices.EqualityOperator(lhs, (object) 1))
      selectPos = new Vector3(-16.85f, 11.05f, 8.75f);
    else if (RuntimeServices.EqualityOperator(lhs, (object) 2))
      selectPos = new Vector3(-15f, 11.05f, 8.75f);
    else if (RuntimeServices.EqualityOperator(lhs, (object) 3))
      selectPos = new Vector3(-13.15f, 11.05f, 8.75f);
    else if (RuntimeServices.EqualityOperator(lhs, (object) 4))
      selectPos = new Vector3(-11.25f, 11.05f, 8.75f);
    return selectPos;
  }

  public virtual void Close()
  {
    GameScript.menuOpen = false;
    this.menuExit.SetActive(false);
    this.shade.SetActive(false);
  }

  public virtual void EnterIP()
  {
    this.enteringIP = true;
    this.txtIP[0].text = string.Empty;
    this.txtIP[1].text = string.Empty;
  }

  public virtual void Resume()
  {
    if (Network.connections.Length == 0)
      Time.timeScale = 1f;
    this.menuExit.SetActive(false);
    GameScript.menuOpen = false;
  }

  public virtual void SetTextInfo()
  {
    this.txtName.text = RuntimeServices.op_Addition(string.Empty, MenuScript.curName);
    this.txtLevel.text = RuntimeServices.op_Addition("Lv.", (object) GameScript.playerLevel);
    this.txtBarInfo[0].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.HP, "/"), (object) GameScript.MAXHP);
    this.txtBarInfo[1].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.MAG, "/"), (object) GameScript.MAXMAG);
    this.txtBarInfo[3].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) this.stamina, "/"), (object) this.maxStamina);
  }

  public virtual void OpenInventory()
  {
    if (!GameScript.inventoryOpen && !GameScript.menuOpen)
    {
      if (this.@using)
        return;
      this.RefreshPlayerStats();
      this.RefreshInventory();
      this.SetTextInfo();
      this.menuInventory.SetActive(true);
      this.GetComponent<AudioSource>().PlayOneShot((AudioClip) Resources.Load("Au/invOpen", typeof (AudioClip)));
      this.menuEquipped.SetActive(true);
      GameScript.inventoryOpen = true;
    }
    else
    {
      this.menuCheat.SetActive(false);
      this.cheating = false;
      this.CloseSkillDesc();
      if (this.holdingItem)
        this.DropItem();
      if (GameScript.interacting)
      {
        this.menuBlacksmith.SetActive(false);
        this.menuHoarder.SetActive(false);
        int num = new int();
        for (int index = 0; index < 15; ++index)
        {
          if (GameScript.npcInventory[index].id != 0 && index < 11)
          {
            Item obj = new Item(GameScript.npcInventory[index].id, GameScript.npcInventory[index].q, GameScript.npcInventory[index].e, (float) GameScript.npcInventory[index].d, (GameObject) null);
            ((GameObject) UnityEngine.Object.Instantiate(Resources.Load("iLocal"), GameScript.player.transform.position, Quaternion.identity)).SendMessage("InitL", (object) new int[7]
            {
              obj.id,
              obj.q,
              obj.e[0],
              obj.e[1],
              obj.e[2],
              obj.e[3],
              obj.d
            });
          }
          GameScript.npcInventory[index] = this.EmptyItem();
        }
        GameScript.interacting = false;
      }
      GameScript.inventoryOpen = false;
      this.ResetCraft();
      this.infoObject.SetActive(false);
      this.menuInventory.SetActive(false);
      this.GetComponent<AudioSource>().PlayOneShot((AudioClip) Resources.Load("Au/invClose", typeof (AudioClip)));
      this.menuEquipped.SetActive(false);
    }
  }

  public virtual void RefreshActionBar()
  {
    for (int index = 0; index < 5; ++index)
    {
      if (GameScript.inventory[index].id != 0)
      {
        this.inventorySlot[index].GetComponent<Renderer>().enabled = true;
        this.inventorySlot[index].GetComponent<Renderer>().material = (Material) Resources.Load(RuntimeServices.op_Addition("i/i", (object) GameScript.inventory[index].id));
        this.inventoryQ[index].text = GameScript.inventory[index].q <= 1 ? string.Empty : RuntimeServices.op_Addition(string.Empty, (object) GameScript.inventory[index].q);
      }
      else
      {
        this.inventorySlot[index].GetComponent<Renderer>().enabled = false;
        this.inventoryQ[index].text = string.Empty;
      }
    }
  }

  public virtual void RefreshInventory()
  {
    for (int index = 5; index < 31; ++index)
    {
      if (GameScript.inventory[index].id != 0)
      {
        this.inventorySlot[index].GetComponent<Renderer>().enabled = true;
        this.inventorySlot[index].GetComponent<Renderer>().material = (Material) Resources.Load(RuntimeServices.op_Addition("i/i", (object) GameScript.inventory[index].id));
        if (GameScript.inventory[index].q > 1)
        {
          if (index < 20 || index > 25)
            this.inventoryQ[index].text = RuntimeServices.op_Addition(string.Empty, (object) GameScript.inventory[index].q);
        }
        else if (index < 20 || index > 25)
          this.inventoryQ[index].text = string.Empty;
        if (index == 23)
          this.inventoryQ[index].text = GameScript.inventory[index].q <= 1 ? string.Empty : RuntimeServices.op_Addition(string.Empty, (object) GameScript.inventory[index].q);
      }
      else
      {
        this.inventorySlot[index].GetComponent<Renderer>().enabled = false;
        if (index < 20 || index > 25)
          this.inventoryQ[index].text = string.Empty;
        if (index == 23)
          this.inventoryQ[23].text = string.Empty;
      }
    }
  }

  public virtual IEnumerator GenerateLevel() => (IEnumerator) new GameScript.\u0024GenerateLevel\u00241760(this).GetEnumerator();

  public virtual void SetMusic(int a) => this.musicBox.SendMessage(nameof (SetMusic), (object) a);

  public virtual void LoadMana()
  {
    this.txtBarInfo[1].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.MAG, "/"), (object) GameScript.MAXMAG);
    float num1 = (float) GameScript.MAXMAG * 0.2f;
    Vector3 localScale1 = this.barBack[1].transform.localScale;
    double num2 = (double) (localScale1.x = num1);
    Vector3 vector3_1 = this.barBack[1].transform.localScale = localScale1;
    float num3 = (float) GameScript.MAG * 0.2f;
    Vector3 localScale2 = this.barFill[1].transform.localScale;
    double num4 = (double) (localScale2.x = num3);
    Vector3 vector3_2 = this.barFill[1].transform.localScale = localScale2;
  }

  public virtual void LoadHearts()
  {
    if (GameScript.HP < 0)
      GameScript.HP = 0;
    if (GameScript.HP > GameScript.MAXHP)
      GameScript.HP = GameScript.MAXHP;
    if ((bool) (UnityEngine.Object) this.txtBarInfo[0])
      this.txtBarInfo[0].text = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) GameScript.HP, "/"), (object) GameScript.MAXHP);
    if (!(bool) (UnityEngine.Object) this.barBack[0] || !(bool) (UnityEngine.Object) this.barFill[0])
      return;
    float num1 = (float) GameScript.MAXHP * 0.2f;
    Vector3 localScale1 = this.barBack[0].transform.localScale;
    double num2 = (double) (localScale1.x = num1);
    Vector3 vector3_1 = this.barBack[0].transform.localScale = localScale1;
    float num3 = (float) GameScript.HP * 0.2f;
    Vector3 localScale2 = this.barFill[0].transform.localScale;
    double num4 = (double) (localScale2.x = num3);
    Vector3 vector3_2 = this.barFill[0].transform.localScale = localScale2;
  }

  public virtual IEnumerator Die() => (IEnumerator) new GameScript.\u0024Die\u00241771(this).GetEnumerator();

  public virtual void ShowTimer()
  {
    int timer = GameScript.timer;
    int rhs1 = 0;
    int rhs2 = 0;
    for (; timer >= 60; timer -= 60)
      ++rhs1;
    for (; rhs1 >= 60; rhs1 -= 60)
      ++rhs2;
    if ((bool) (UnityEngine.Object) this.txtTimer)
      this.txtTimer.text = RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition("Total Time: ", (object) rhs2), ":"), (object) rhs1), ":"), (object) timer);
    if (rhs2 > 1 || !GameScript.win)
      return;
    MenuScript.canUnlockRace[6] = 1;
  }

  public virtual IEnumerator ShowStats() => (IEnumerator) new GameScript.\u0024ShowStats\u00241776(this).GetEnumerator();

  public virtual IEnumerator ShowEXP() => (IEnumerator) new GameScript.\u0024ShowEXP\u00241780(this).GetEnumerator();

  public virtual int GetCurEXP(int pLevel)
  {
    int accountExp = this.accountEXP;
    if (pLevel > 1)
      accountExp -= this.GetTotalEXP(pLevel);
    return accountExp;
  }

  public virtual int GetLevelCap(int pLevel)
  {
    int levelCap = 100;
    int num = new int();
    for (int index = 1; index < pLevel; ++index)
      levelCap = (int) ((double) levelCap * 1.2000000476837158);
    if (pLevel == 0)
      levelCap = 0;
    return levelCap;
  }

  public virtual int GetTotalEXP(int lvl)
  {
    int num = new int();
    int totalExp = new int();
    for (int pLevel = 0; pLevel < lvl; ++pLevel)
      totalExp += this.GetLevelCap(pLevel);
    return totalExp;
  }

  public virtual int GetPlayerLevel()
  {
    int accountExp = this.accountEXP;
    int playerLevel = 0;
    int num1 = new int();
    int num2 = 100;
    while (accountExp >= 0)
    {
      accountExp -= num2;
      num2 = (int) ((double) num2 * 1.2000000476837158);
      ++playerLevel;
    }
    return playerLevel;
  }

  public virtual IEnumerator StatShow(int a) => (IEnumerator) new GameScript.\u0024StatShow\u00241787(a, this).GetEnumerator();

  public virtual string GetStatsName(int a)
  {
    switch (a)
    {
      case 0:
        return "Characters Created";
      case 1:
        return "Enemies Defeated";
      case 2:
        return "Gold Collected";
      case 3:
        return "EXP Acquired";
      case 4:
        return "Items Crafted";
      case 5:
        return "Trees Chopped";
      case 6:
        return "Ore Mined";
      case 7:
        return "Resources Gathered";
      case 8:
        return "Foods Eaten";
      case 9:
        return "Chests Opened";
      case 10:
        return "Bosses Defeated";
      case 11:
        return "Items Bought";
      default:
        return string.Empty;
    }
  }

  public virtual void OnApplicationQuit()
  {
    GameScript.changingScene = false;
    this.DeleteCharacter();
    this.SaveInventory();
  }

  public virtual void DeleteCharacter()
  {
    GameScript.isInitialized = false;
    this.DeleteInventory();
    PlayerController.helm = 0;
    PlayerControllerN.helm = 0;
    GameScript.curBiome = 0;
    if ((bool) (UnityEngine.Object) GameScript.player)
      GameScript.player.SendMessage("UpdateHead", (object) MenuScript.pVariant, SendMessageOptions.DontRequireReceiver);
    PlayerController.armor = 0;
    PlayerControllerN.armor = 0;
    if ((bool) (UnityEngine.Object) GameScript.player)
      GameScript.player.SendMessage("UpdateBody", (object) MenuScript.pBody, SendMessageOptions.DontRequireReceiver);
    PlayerController.offhand = 0;
    PlayerControllerN.offhand = 0;
    if ((bool) (UnityEngine.Object) GameScript.player)
      GameScript.player.SendMessage("UpdateOffhand", (object) MenuScript.pBody, SendMessageOptions.DontRequireReceiver);
    for (int rhs = 0; rhs < 31; ++rhs)
    {
      PlayerPrefs.SetInt(RuntimeServices.op_Addition("id", (object) rhs), 0);
      PlayerPrefs.SetInt(RuntimeServices.op_Addition("q", (object) rhs), 0);
      PlayerPrefs.SetInt(RuntimeServices.op_Addition("e", (object) rhs), 0);
      PlayerPrefs.SetInt(RuntimeServices.op_Addition("d", (object) rhs), 0);
      if (rhs < 20)
        PlayerPrefs.SetInt(RuntimeServices.op_Addition("e", (object) rhs), 0);
    }
    PlayerPrefs.SetInt("cLevel", 0);
  }

  public virtual void UpdateCharacterWeapon()
  {
    int id = GameScript.inventory[GameScript.curActiveSlot].id;
    if (id < 500)
    {
      for (int index = 0; index < 4; ++index)
        GameScript.tempPlayerStat[index] = 0;
    }
    else
    {
      for (int index = 0; index < 4; ++index)
        GameScript.tempPlayerStat[index] = GameScript.inventory[GameScript.curActiveSlot].e[index];
    }
    int num1 = id;
    if (num1 == 500)
      GameScript.finalATKChop = this.ATKChop;
    else if (num1 == 512)
      GameScript.finalATKChop = this.ATKChop;
    else if (num1 == 503)
      GameScript.finalATKChop = this.ATKChop;
    else if (num1 == 506)
      GameScript.finalATKChop = this.ATKChop;
    else if (num1 == 509)
      GameScript.finalATKChop = this.ATKChop;
    else if (num1 == 501)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop + 1;
      GameScript.finalATKMine = this.ATKMine;
    }
    else if (num1 == 502)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop;
      GameScript.finalATKMine = this.ATKMine + 1;
    }
    else if (num1 == 504)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop + 3;
      GameScript.finalATKMine = this.ATKMine;
    }
    else if (num1 == 505)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop;
      GameScript.finalATKMine = this.ATKMine + 3;
    }
    else if (num1 == 507)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop + 4;
      GameScript.finalATKMine = this.ATKMine;
    }
    else if (num1 == 508)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop;
      GameScript.finalATKMine = this.ATKMine + 4;
    }
    else if (num1 == 510)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop + 5;
      GameScript.finalATKMine = this.ATKMine;
    }
    else if (num1 == 511)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop;
      GameScript.finalATKMine = this.ATKMine + 5;
    }
    else if (num1 == 513)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop + 2;
      GameScript.finalATKMine = this.ATKMine;
    }
    else if (num1 == 514)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop;
      GameScript.finalATKMine = this.ATKMine + 2;
    }
    else if (num1 == 517)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop + 2;
      GameScript.finalATKMine = this.ATKMine;
    }
    else if (num1 == 518)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop;
      GameScript.finalATKMine = this.ATKMine + 2;
    }
    else if (num1 == 529)
    {
      GameScript.finalATKNet = 1;
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop;
      GameScript.finalATKMine = this.ATKMine;
    }
    else if (num1 == 504)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop + 3;
    }
    else if (num1 == 506)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop;
    }
    else if (num1 == 509)
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop;
    }
    else if (num1 == 560)
    {
      GameScript.finalATKChop = this.ATKChop;
    }
    else
    {
      GameScript.finalATK = this.ATK;
      GameScript.finalATKChop = this.ATKChop;
      GameScript.finalATKMine = this.ATKMine;
    }
    if (MenuScript.curTrait[1] == 1 || MenuScript.curTrait[2] == 1)
      GameScript.finalATKChop += 10;
    if (MenuScript.pHat == 2)
      GameScript.finalATKMine += 10;
    if (Network.isClient || Network.isServer)
      GameScript.player.GetComponent<NetworkView>().RPC("uI", RPCMode.All, (object) GameScript.inventory[GameScript.curActiveSlot].id);
    else
      this.weapon.GetComponent<Renderer>().material = (Material) Resources.Load(RuntimeServices.op_Addition("iE/i", (object) GameScript.inventory[GameScript.curActiveSlot].id));
    SphereCollider component = (SphereCollider) GameScript.aSphere.GetComponent(typeof (SphereCollider));
    if (id >= 500 && id < 560)
    {
      this.atkAnim = "a1";
      float num2 = 0.4f;
      Vector3 center = component.center;
      double num3 = (double) (center.x = num2);
      Vector3 vector3 = component.center = center;
      component.radius = 0.6f;
      this.atkWait = 0.45f;
    }
    else if (id >= 560 && id < 580)
    {
      this.atkAnim = "a2";
      float num4 = 0.7f;
      Vector3 center = component.center;
      double num5 = (double) (center.x = num4);
      Vector3 vector3 = component.center = center;
      component.radius = 1f;
      this.atkWait = 1f;
    }
    else if (id >= 600 && id < 650)
    {
      this.atkAnim = "a1";
      float num6 = 0.4f;
      Vector3 center = component.center;
      double num7 = (double) (center.x = num6);
      Vector3 vector3 = component.center = center;
      component.radius = 0.6f;
      this.atkWait = 0.45f;
    }
    else
    {
      float num8 = 0.1f;
      Vector3 center = component.center;
      double num9 = (double) (center.x = num8);
      Vector3 vector3 = component.center = center;
      component.radius = 0.6f;
      this.atkAnim = "a1";
      this.atkWait = 0.45f;
    }
    if (!GameScript.inventoryOpen)
      return;
    this.RefreshPlayerStats();
  }

  public virtual string GetSkillName(int a)
  {
    switch (a)
    {
      case 1:
        return "Throwing Axe";
      case 2:
        return "Berserker's Rage";
      case 3:
        return "Charge!";
      case 4:
        return "Guardian's Aura";
      case 5:
        return "Knight's Blade";
      case 6:
        return "Magic Weapons";
      case 7:
        return "Clairvoyance";
      case 8:
        return "Necromancer's Minion";
      case 9:
        return "Warp";
      case 10:
        return "Levitate";
      case 11:
        return "Hunter's Roar";
      case 12:
        return "Triple Shot";
      case 13:
        return "Druid's Arrow";
      case 14:
        return "Fire Wisp";
      case 15:
        return "Dire Wolf";
      default:
        return "null";
    }
  }

  public virtual string GetSkillDesc(int id)
  {
    switch (id)
    {
      case 1:
        return "Hurl a giant axe that\npasses through enemies.\nDeals damage based on\nATK/2.";
      case 2:
        return "For 10 seconds, your\nATK is doubled.";
      case 3:
        return "You and nearby Allies\ngain 4 SPD for 10\nseconds.";
      case 4:
        return "You and nearby Allies\ntake 4 less damage\nfor 10 seconds.";
      case 5:
        return "Perform an extra jump\nwhile summoning a badass\nsword. Based on ATK.";
      case 6:
        return "You and nearby Allies\ndeal bonus damage equal\nto your MAG for\n10 seconds.";
      case 7:
        return "For 10 seconds, you\nrapidly regain mana.";
      case 8:
        return "Summon a minion at your\ncursor's location. Shoots\nfireballs whaaat.";
      case 9:
        return "Teleport left or right\nbased on cursor location.";
      case 10:
        return "Makes your friends\njealous.";
      case 11:
        return "You and nearby Allies\ngain 10 DEX for 10\nseconds.";
      case 12:
        return "Next shot fired will\nshoot 3 arrows.\nWith double damage.\nConsumes 3 arrows.";
      case 13:
        return "Perform an extra jump\nwhile summoning a badass\narrow. Based on DEX.";
      case 14:
        return "Summons wisp at cursor\nlocation. Arrows passing\nthrough will deal\n2x damage.";
      case 15:
        return "Summon a wolf that runs\naround and kills shit.";
      default:
        return "null";
    }
  }

  public virtual string GetEnchantmentName(int id)
  {
    switch (id)
    {
      case 1:
        return "Power I";
      case 2:
        return "Power II";
      case 3:
        return "Power III";
      case 4:
        return "Wrath I";
      case 5:
        return "Wrath II";
      case 6:
        return "Wrath III";
      case 7:
        return "Swiftness I";
      case 8:
        return "Swiftness II";
      case 9:
        return "Switftness III";
      default:
        return "[Empty]";
    }
  }

  public virtual string GetStatBonus(int id)
  {
    switch (id)
    {
      case 500:
        return "ATK+1";
      case 503:
        return "ATK+2";
      default:
        return string.Empty;
    }
  }

  public virtual float GetMaxDurability(int id)
  {
    float num1 = new float();
    int num2 = id;
    if (num2 == 500 || num2 == 501 || num2 == 502)
      return 50f;
    if (num2 == 503 || num2 == 504 || num2 == 505)
      return 80f;
    if (num2 == 506 || num2 == 507 || num2 == 508)
      return 160f;
    if (num2 == 509 || num2 == 510 || num2 == 511)
      return 250f;
    if (num2 == 512 || num2 == 513 || num2 == 514)
      return 55f;
    if (num2 == 515)
      return 100f;
    if (num2 == 516 || num2 == 517 || num2 == 518)
      return 60f;
    switch (num2)
    {
      case 519:
        return 50f;
      case 560:
        return 90f;
      case 561:
        return 180f;
      case 562:
        return 270f;
      default:
        if (num2 == 563 || num2 == 565)
          return 65f;
        if (num2 == 560)
          return 100f;
        if (num2 == 567)
          return 50f;
        if (num2 == 568 || num2 == 569 || num2 == 570)
          return 180f;
        if (num2 == 600 || num2 == 601 || num2 == 602)
          return 50f;
        return num2 == 603 ? 300f : 65f;
    }
  }

  public virtual int[] GetGearStats(int id)
  {
    int[] numArray = new int[4];
    switch (id)
    {
      case 500:
        return new int[4]{ 0, 2, 0, 0 };
      case 503:
        return new int[4]{ 0, 8, 0, 0 };
      case 506:
        return new int[4]{ 0, 15, 0, 0 };
      case 509:
        return new int[4]{ 0, 25, 0, 0 };
      case 512:
        return new int[4]{ 0, 4, 0, 0 };
      case 516:
        return new int[4]{ 0, 4, 0, 0 };
      case 519:
        return new int[4]{ 0, 18, 0, 0 };
      case 520:
        return new int[4]{ 5, 27, 5, 5 };
      case 521:
        return new int[4]{ 2, 30, 2, 2 };
      case 530:
        return new int[4]{ 0, 0, 6, 0 };
      case 531:
        return new int[4]{ 2, 11, 0, 0 };
      case 532:
        return new int[4]{ 2, 11, 0, 0 };
      case 533:
        return new int[4]{ 5, 30, 2, 2 };
      case 534:
        return new int[4]{ 0, 75, 0, 0 };
      case 535:
        return new int[4]{ 0, 0, 15, 15 };
      case 536:
        return new int[4]{ 0, 0, 3, 0 };
      case 560:
        return new int[4]{ 0, 15, 0, 0 };
      case 561:
        return new int[4]{ 0, 30, 0, 0 };
      case 562:
        return new int[4]{ 0, 48, 0, 0 };
      case 563:
        return new int[4]{ 0, 8, 0, 0 };
      case 565:
        return new int[4]{ 0, 55, 0, 0 };
      case 566:
        return new int[4]{ -3, 100, 0, 0 };
      case 567:
        return new int[4]{ 0, 35, 0, 0 };
      case 568:
        return new int[4]{ 0, 95, 0, 10 };
      case 569:
        return new int[4]{ 0, 95, 0, 10 };
      case 570:
        return new int[4]{ 0, 95, 0, 10 };
      case 700:
        return new int[4]{ 2, 4, 0, 0 };
      case 701:
        return new int[4]{ 3, 6, 0, 0 };
      case 702:
        return new int[4]{ 4, 9, 0, 0 };
      case 703:
        return new int[4]{ 1, 2, 0, 0 };
      case 704:
        return new int[4]{ 1, 2, 0, 0 };
      case 705:
        return new int[4]{ 1, 0, 2, 0 };
      case 706:
        return new int[4]{ 1, 0, 2, 0 };
      case 707:
        return new int[4]{ 2, 0, 4, 0 };
      case 708:
        return new int[4]{ 3, 0, 6, 0 };
      case 709:
        return new int[4]{ 4, 0, 9, 0 };
      case 710:
        return new int[4]{ 1, 0, 0, 2 };
      case 711:
        return new int[4]{ 1, 0, 0, 2 };
      case 712:
        return new int[4]{ 2, 0, 0, 4 };
      case 713:
        return new int[4]{ 3, 0, 0, 6 };
      case 714:
        return new int[4]{ 4, 0, 0, 9 };
      case 800:
        return new int[4]{ 2, 4, 0, 0 };
      case 801:
        return new int[4]{ 3, 6, 0, 0 };
      case 802:
        return new int[4]{ 4, 9, 0, 0 };
      case 803:
        return new int[4]{ 1, 2, 0, 0 };
      case 804:
        return new int[4]{ 1, 2, 0, 0 };
      case 805:
        return new int[4]{ 1, 0, 2, 0 };
      case 806:
        return new int[4]{ 1, 0, 2, 0 };
      case 807:
        return new int[4]{ 2, 0, 4, 0 };
      case 808:
        return new int[4]{ 3, 0, 6, 0 };
      case 809:
        return new int[4]{ 4, 0, 9, 0 };
      case 810:
        return new int[4]{ 1, 0, 0, 2 };
      case 811:
        return new int[4]{ 1, 0, 0, 2 };
      case 812:
        return new int[4]{ 2, 0, 0, 4 };
      case 813:
        return new int[4]{ 3, 0, 0, 6 };
      case 814:
        return new int[4]{ 4, 0, 0, 9 };
      case 900:
        return new int[4]{ 2, 0, 0, 0 };
      case 901:
        return new int[4]{ 3, 0, 0, 0 };
      case 902:
        return new int[4]{ 4, 0, 0, 0 };
      case 903:
        return new int[4]{ 1, 0, 0, 0 };
      case 904:
        return new int[4]{ 1, 0, 0, 0 };
      case 905:
        return new int[4]{ 5, 2, 2, 2 };
      case 906:
        return new int[4]{ 5, 2, 0, 5 };
      case 907:
        return new int[4]{ 3, 5, 5, 0 };
      case 950:
        return new int[4]{ 0, 5, 0, 0 };
      case 951:
        return new int[4]{ 0, 0, 0, 5 };
      case 952:
        return new int[4]{ 0, 0, 5, 0 };
      case 953:
        return new int[4]{ 5, 0, 0, 0 };
      case 954:
        return new int[4]{ -2, 8, 0, 0 };
      case 955:
        return new int[4]{ -2, 0, 0, 8 };
      case 956:
        return new int[4]{ -2, 0, 8, 0 };
      case 957:
        return new int[4]{ 2, 2, 2, 2 };
      default:
        return new int[4];
    }
  }

  public virtual void Options()
  {
  }

  public virtual void OnDisconnectedFromServer()
  {
    PlayerPrefs.SetInt("gChests", MenuScript.goldChests);
    GameScript.isInitialized = false;
    GameScript.isReturning = false;
    GameScript.isInstance = false;
    GameScript.changingScene = false;
    this.DeleteCharacter();
    this.DeleteInventory();
    Application.LoadLevel(1);
  }

  public virtual void OnPlayerConnected(NetworkPlayer player)
  {
    if (!Network.isServer)
      return;
    Network.CloseConnection(player, false);
  }

  public virtual void OnPlayerDisconnected(NetworkPlayer player)
  {
    Network.RemoveRPCs(player);
    Network.DestroyPlayerObjects(player);
  }

  public virtual void Action(int act)
  {
    if (act > 0)
      this.interact = act;
    else
      this.interact = 0;
  }

  public virtual void SetLeatherworker()
  {
    this.menuBlacksmith.GetComponent<Renderer>().material = this.leatherworkerMenu;
    this.txtNPCName.text = "Finn the Leatherworker";
  }

  public virtual void SetTailor()
  {
    this.menuBlacksmith.GetComponent<Renderer>().material = this.tailorMenu;
    this.txtNPCName.text = "Flora the Tailor";
  }

  public virtual void Interact()
  {
    GameScript.interacting = true;
    int num = 0;
    switch (GameScript.interacter)
    {
      case "n1":
        this.txtNPCName.text = "Grognar the Blacksmith";
        this.menuBlacksmith.GetComponent<Renderer>().material = this.blacksmithMenu;
        this.menuBlacksmith.SetActive(true);
        this.RefreshBlacksmith();
        this.npcInteract = 1;
        GameScript.interacted = true;
        break;
      case "n3":
        this.menuBlacksmith.SetActive(true);
        this.SetLeatherworker();
        this.RefreshLeatherworker();
        this.npcInteract = 3;
        GameScript.interacted = true;
        break;
      case "n4":
        this.menuBlacksmith.SetActive(true);
        this.SetTailor();
        this.RefreshTailor();
        this.npcInteract = 4;
        GameScript.interacted = true;
        break;
      case "n5":
        this.menuHoarder.SetActive(true);
        this.npcInteract = 5;
        GameScript.interacted = true;
        break;
      case "n6":
        this.Altar();
        num = 1;
        break;
      default:
        num = 1;
        break;
    }
    if (GameScript.inventoryOpen || num != 0)
      return;
    this.OpenInventory();
  }

  public virtual void Altar()
  {
    if (GameScript.curGold >= 500 && !GameScript.usedAltar)
    {
      GameScript.usedAltar = true;
      GameScript.curGold -= 500;
      this.RefreshGold();
      int curAltar = GameScript.curAltar;
      switch (curAltar)
      {
        case 0:
          GameScript.tempGearStat[1] = GameScript.tempGearStat[1] + 5;
          break;
        case 1:
          if (GameScript.tempGearStat[0] > 0)
          {
            GameScript.tempGearStat[0] = GameScript.tempGearStat[0] - 1;
            break;
          }
          break;
        case 2:
          GameScript.tempGearStat[0] = GameScript.tempGearStat[0] + 2;
          GameScript.tempGearStat[1] = GameScript.tempGearStat[1] + 2;
          GameScript.tempGearStat[2] = GameScript.tempGearStat[2] + 2;
          GameScript.tempGearStat[3] = GameScript.tempGearStat[3] + 2;
          break;
        case 3:
          if (GameScript.HP > 1)
          {
            --GameScript.HP;
            this.LoadHearts();
            break;
          }
          break;
        case 4:
          GameScript.HP = GameScript.MAXHP;
          this.LoadHearts();
          break;
        case 6:
          GameScript.tempGearStat[2] = GameScript.tempGearStat[2] + 5;
          break;
      }
      this.RefreshPlayerStats();
      ((GameObject) Network.Instantiate(Resources.Load("txtAltar"), GameScript.player.transform.position, Quaternion.identity, 0)).SendMessage("Set", (object) curAltar);
      this.GetComponent<AudioSource>().PlayOneShot((AudioClip) Resources.Load("Au/altar", typeof (AudioClip)));
    }
    GameScript.interacting = false;
  }

  public virtual void InteractCancel()
  {
    if (GameScript.inventoryOpen)
      this.OpenInventory();
    this.menuAlchemist.SetActive(false);
    this.menuBlacksmith.SetActive(false);
    this.menuTailor.SetActive(false);
    GameScript.interacting = false;
  }

  public virtual void GainEXP(int a)
  {
    if (GameScript.HP <= 0)
      return;
    GameScript.exp += (float) a;
    this.barEXPback.GetComponent<Animation>().Play();
    if ((double) GameScript.exp >= (double) GameScript.maxEXP)
    {
      if (GameScript.playerLevel == 1)
        GameScript.count = 8;
      GameScript.maxEXP = (float) (GameScript.count + GameScript.playerLevel * 5);
      GameScript.exp = 0.0f;
      this.LevelUp();
    }
    this.LoadEXP();
  }

  public virtual IEnumerator AdditionalStat(int a) => (IEnumerator) new GameScript.\u0024AdditionalStat\u00241794(a, this).GetEnumerator();

  public virtual IEnumerator ShowLUP(int a) => (IEnumerator) new GameScript.\u0024ShowLUP\u00241799(a, this).GetEnumerator();

  public virtual void LevelUp()
  {
    ++GameScript.playerLevel;
    this.txtLevel.text = RuntimeServices.op_Addition("Lv: ", (object) GameScript.playerLevel);
    int num1 = new int();
    for (int a = 0; a < 4; ++a)
    {
      if (a == MenuScript.growthStatGood1 || a == MenuScript.growthStatGood2)
      {
        if (GameScript.playerLevel % 2 == 0)
        {
          GameScript.tempLevelStat[a] = GameScript.tempLevelStat[a] + 1;
          this.StartCoroutine_Auto(this.ShowLUP(a));
          if (a == 0)
            ++GameScript.HP;
        }
      }
      else if (a == MenuScript.growthStatBad)
      {
        if (GameScript.playerLevel % 4 == 0)
        {
          GameScript.tempLevelStat[a] = GameScript.tempLevelStat[a] + 1;
          this.StartCoroutine_Auto(this.ShowLUP(a));
          if (a == 0)
            ++GameScript.HP;
        }
      }
      else if (GameScript.playerLevel % 3 == 0)
      {
        GameScript.tempLevelStat[a] = GameScript.tempLevelStat[a] + 1;
        this.StartCoroutine_Auto(this.ShowLUP(a));
        if (a == 0)
          ++GameScript.HP;
      }
    }
    if (MenuScript.companion == 8)
    {
      int index = UnityEngine.Random.Range(0, 4);
      int num2 = GameScript.tempLevelStat[index] = GameScript.tempLevelStat[index] + 1;
    }
    switch (MenuScript.pHat)
    {
      case 3:
        if (UnityEngine.Random.Range(0, 3) == 0)
        {
          GameScript.tempLevelStat[1] = GameScript.tempLevelStat[1] + 1;
          this.StartCoroutine_Auto(this.AdditionalStat(1));
          break;
        }
        break;
      case 4:
        if (UnityEngine.Random.Range(0, 3) == 0)
        {
          GameScript.tempLevelStat[2] = GameScript.tempLevelStat[2] + 1;
          this.StartCoroutine_Auto(this.AdditionalStat(2));
          break;
        }
        break;
      case 5:
        if (UnityEngine.Random.Range(0, 3) == 0)
        {
          GameScript.tempLevelStat[3] = GameScript.tempLevelStat[3] + 1;
          this.StartCoroutine_Auto(this.AdditionalStat(3));
          break;
        }
        break;
      case 12:
        if (UnityEngine.Random.Range(0, 3) == 0)
        {
          int a = UnityEngine.Random.Range(0, 4);
          GameScript.tempLevelStat[a] = GameScript.tempLevelStat[a] + 1;
          this.StartCoroutine_Auto(this.AdditionalStat(a));
          break;
        }
        break;
    }
    GameScript.MAXHP = MenuScript.playerStat[0] + GameScript.tempPlayerStat[0] + GameScript.tempLevelStat[0];
    this.ATK = MenuScript.playerStat[1] + GameScript.tempPlayerStat[1] + GameScript.tempLevelStat[1];
    GameScript.MAXMAG = MenuScript.playerStat[3] + GameScript.tempPlayerStat[3] + GameScript.tempLevelStat[3] + GameScript.tempGearStat[3];
    GameScript.DEX = MenuScript.playerStat[2] + GameScript.tempPlayerStat[2] + GameScript.tempLevelStat[2] + GameScript.tempGearStat[2];
    GameScript.SPD = (float) ((double) GameScript.DEX * 0.05000000074505806 + 7.5999999046325684);
    if (MenuScript.companion == 3)
      GameScript.SPD *= 2f;
    if (MenuScript.pHat == 9)
      GameScript.SPD += 4f;
    GameScript.player.GetComponent<NetworkView>().RPC(nameof (LevelUp), RPCMode.All);
    if (GameScript.playerLevel % 5 == 0 && GameScript.curSkill <= 2)
      this.SkillMenu();
    this.RefreshPlayerStats();
    this.LoadHearts();
    this.LoadMana();
    int playerLevel = GameScript.playerLevel;
    this.maxStamina = playerLevel > 4 ? (playerLevel > 12 ? 12 : playerLevel) : 4;
    this.LoadSTA();
  }

  public virtual void SelectSkill(int a)
  {
    this.menuSkill.SetActive(false);
    GameScript.selectingSkill = false;
    a *= 5;
    int num1 = a + 5;
    this.GetComponent<AudioSource>().PlayOneShot((AudioClip) Resources.Load("Au/SKILL", typeof (AudioClip)));
    int num2 = a + UnityEngine.Random.Range(1, 6);
    int num3 = new int();
    int lhs = 0;
    int num4 = 0;
    for (int index = 0; index < 3; ++index)
    {
      if (index == GameScript.curSkill)
        GameScript.skill[GameScript.curSkill] = num2;
      else if (GameScript.skill[index] == num2)
      {
        if (num2 < num1)
          ++num2;
        else
          num2 = a + 1;
      }
      if (GameScript.skill[index] > 5 && GameScript.skill[index] < 11)
        ++lhs;
      if (GameScript.skill[index] >= 1 && GameScript.skill[index] <= 5)
        ++num4;
    }
    MonoBehaviour.print((object) RuntimeServices.op_Addition((object) lhs, " IS SKILL count"));
    if (lhs > 2)
      MenuScript.canUnlockHat[11] = 1;
    if (num4 > 2)
      MenuScript.canUnlockHat[19] = 1;
    this.RefreshSkills();
    switch (GameScript.curSkill)
    {
      case 0:
        MenuScript.canUnlockRace[3] = 1;
        break;
      case 1:
        MenuScript.canUnlockRace[4] = 1;
        break;
    }
    ++GameScript.curSkill;
  }

  public virtual void SkillMenu()
  {
    GameScript.selectingSkill = true;
    this.menuSkill.SetActive(true);
  }

  public virtual void RefreshSkills()
  {
    int num = new int();
    for (int index = 0; index < 3; ++index)
    {
      if (GameScript.skill[index] > 0)
      {
        this.skillObj[index].SetActive(true);
        this.skillObj[index].GetComponent<Renderer>().material = (Material) Resources.Load(RuntimeServices.op_Addition("sI/s", (object) GameScript.skill[index]));
      }
      else
        this.skillObj[index].SetActive(false);
    }
  }

  public virtual float GetSkillCooldown(int a)
  {
    int num = new int();
    int skillCooldown;
    switch (a)
    {
      case 1:
        skillCooldown = 200;
        break;
      case 2:
        skillCooldown = 400;
        break;
      case 3:
        skillCooldown = 400;
        break;
      case 4:
        skillCooldown = 400;
        break;
      case 5:
        skillCooldown = 150;
        break;
      case 6:
        skillCooldown = 400;
        break;
      case 7:
        skillCooldown = 200;
        break;
      case 8:
        skillCooldown = 350;
        break;
      case 9:
        skillCooldown = 150;
        break;
      case 10:
        skillCooldown = 200;
        break;
      case 11:
        skillCooldown = 400;
        break;
      case 12:
        skillCooldown = 150;
        break;
      case 13:
        skillCooldown = 150;
        break;
      case 14:
        skillCooldown = 150;
        break;
      case 15:
        skillCooldown = 150;
        break;
      default:
        skillCooldown = 150;
        break;
    }
    return (float) skillCooldown;
  }

  public virtual IEnumerator SkillTick(int a, float max) => (IEnumerator) new GameScript.\u0024SkillTick\u00241804(a, max, this).GetEnumerator();

  public virtual void UseSkill(int b)
  {
    int a = GameScript.skill[b];
    if ((double) this.skillCooldown[b] > 0.0 || a <= 0)
      return;
    this.skillObj[b].GetComponent<Animation>().Play();
    int skillCooldown = (int) this.GetSkillCooldown(a);
    this.skillCooldown[b] = (float) skillCooldown;
    this.StartCoroutine_Auto(this.SkillTick(b, (float) skillCooldown));
    switch (a)
    {
      case 1:
        Vector3 vector3_1 = new Vector3();
        Vector3 euler1 = (double) Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= (double) GameScript.player.transform.position.x ? new Vector3(0.0f, 180f, 0.0f) : new Vector3(0.0f, 0.0f, 0.0f);
        int num1 = (MenuScript.playerStat[1] + GameScript.tempPlayerStat[1] + GameScript.tempLevelStat[1] + GameScript.tempGearStat[1]) / 2;
        ((GameObject) Network.Instantiate(Resources.Load("skill/throwAxe"), GameScript.player.transform.position, Quaternion.Euler(euler1), 0)).SendMessage("Set", (object) num1);
        GameScript.player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, (object) "dj");
        ((GameObject) Network.Instantiate(Resources.Load("text"), GameScript.player.transform.position, Quaternion.identity, 0)).GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, (object) "TAKE THAT!");
        break;
      case 2:
        GameScript.rage = true;
        GameScript.player.GetComponent<NetworkView>().RPC("Rage", RPCMode.All, (object) 1);
        ((GameObject) Network.Instantiate(Resources.Load("text"), GameScript.player.transform.position, Quaternion.identity, 0)).GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, (object) "I'M SO ANGRY!");
        this.StartCoroutine_Auto(this.RageTick());
        break;
      case 3:
        Network.Instantiate(Resources.Load("skill/Charge"), GameScript.player.transform.position, Quaternion.identity, 0);
        ((GameObject) Network.Instantiate(Resources.Load("text"), GameScript.player.transform.position, Quaternion.identity, 0)).GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, (object) "CHARGE!");
        break;
      case 4:
        Network.Instantiate(Resources.Load("skill/Shield"), GameScript.player.transform.position, Quaternion.identity, 0);
        break;
      case 5:
        int num2 = 38;
        Vector3 velocity1 = GameScript.player.GetComponent<Rigidbody>().velocity;
        double num3 = (double) (velocity1.y = (float) num2);
        Vector3 vector3_2 = GameScript.player.GetComponent<Rigidbody>().velocity = velocity1;
        int num4 = MenuScript.playerStat[1] + GameScript.tempPlayerStat[1] + GameScript.tempLevelStat[1] + GameScript.tempGearStat[1];
        ((GameObject) Network.Instantiate(Resources.Load("skill/kBlade"), GameScript.player.transform.position, Quaternion.identity, 0)).SendMessage("Set", (object) num4);
        GameScript.player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, (object) "dj");
        ((GameObject) Network.Instantiate(Resources.Load("text"), GameScript.player.transform.position, Quaternion.identity, 0)).GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, (object) "Woohoo!");
        break;
      case 6:
        ((GameObject) Network.Instantiate(Resources.Load("skill/mWeapons"), GameScript.player.transform.position, Quaternion.identity, 0)).SendMessage("SetMag", (object) GameScript.MAXMAG);
        break;
      case 7:
        GameScript.clair = true;
        GameScript.player.GetComponent<NetworkView>().RPC("Clair", RPCMode.All, (object) 1);
        ((GameObject) Network.Instantiate(Resources.Load("text"), GameScript.player.transform.position, Quaternion.identity, 0)).GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, (object) "I'M FOCUSED!");
        this.StartCoroutine_Auto(this.ManaTick());
        break;
      case 8:
        Vector3 euler2 = (double) Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= (double) GameScript.player.transform.position.x ? new Vector3(0.0f, 180f, 0.0f) : new Vector3(0.0f, 0.0f, 0.0f);
        Vector3 position = new Vector3(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x, Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).y, 0.0f);
        ((GameObject) Network.Instantiate(Resources.Load("skill/minion"), position, Quaternion.Euler(euler2), 0)).GetComponent<NetworkView>().RPC("SetN", RPCMode.All, (object) GameScript.MAXMAG);
        break;
      case 9:
        Network.Instantiate(Resources.Load("warp"), GameScript.player.transform.position, Quaternion.Euler(0.0f, 180f, 180f), 0);
        Ray ray1 = new Ray();
        RaycastHit hitInfo = new RaycastHit();
        int layerMask = 2048;
        if ((double) Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x > (double) GameScript.player.transform.position.x)
        {
          Ray ray2 = new Ray(GameScript.player.transform.position, new Vector3(1f, 0.0f, 0.0f));
          Vector3 vector3_3 = new Vector3(GameScript.player.transform.position.x + 8f, GameScript.player.transform.position.y, 0.0f);
          if (!Physics.Raycast(ray2, out hitInfo, 8.4f, layerMask))
          {
            GameScript.player.transform.position = vector3_3;
            int num5 = 0;
            Vector3 velocity2 = GameScript.player.GetComponent<Rigidbody>().velocity;
            double num6 = (double) (velocity2.x = (float) num5);
            Vector3 vector3_4 = GameScript.player.GetComponent<Rigidbody>().velocity = velocity2;
          }
        }
        else
        {
          Ray ray3 = new Ray(GameScript.player.transform.position, new Vector3(-1f, 0.0f, 0.0f));
          Vector3 vector3_5 = new Vector3(GameScript.player.transform.position.x - 8f, GameScript.player.transform.position.y, 0.0f);
          if (!Physics.Raycast(ray3, out hitInfo, 8.4f, layerMask))
          {
            GameScript.player.transform.position = vector3_5;
            int num7 = 0;
            Vector3 velocity3 = GameScript.player.GetComponent<Rigidbody>().velocity;
            double num8 = (double) (velocity3.x = (float) num7);
            Vector3 vector3_6 = GameScript.player.GetComponent<Rigidbody>().velocity = velocity3;
          }
        }
        Network.Instantiate(Resources.Load("warp"), GameScript.player.transform.position, Quaternion.Euler(0.0f, 180f, 180f), 0);
        break;
      case 10:
        GameScript.player.SendMessage("Float", (object) 1);
        ((GameObject) Network.Instantiate(Resources.Load("text"), GameScript.player.transform.position, Quaternion.identity, 0)).GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, (object) "PUT ME DOWN!");
        break;
      case 11:
        GameScript.player.GetComponent<NetworkView>().RPC("Roar", RPCMode.All, (object) 1);
        ((GameObject) Network.Instantiate(Resources.Load("text"), GameScript.player.transform.position, Quaternion.identity, 0)).GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, (object) "RAAAAH");
        this.StartCoroutine_Auto(this.RoarTick());
        break;
      case 12:
        GameScript.multishot = true;
        break;
      case 13:
        int num9 = 38;
        Vector3 velocity4 = GameScript.player.GetComponent<Rigidbody>().velocity;
        double num10 = (double) (velocity4.y = (float) num9);
        Vector3 vector3_7 = GameScript.player.GetComponent<Rigidbody>().velocity = velocity4;
        ((GameObject) Network.Instantiate(Resources.Load("skill/dArrow"), GameScript.player.transform.position, Quaternion.identity, 0)).SendMessage("Set", (object) GameScript.finalATK);
        GameScript.player.GetComponent<NetworkView>().RPC("mA", RPCMode.All, (object) "dj");
        ((GameObject) Network.Instantiate(Resources.Load("text"), GameScript.player.transform.position, Quaternion.identity, 0)).GetComponent<NetworkView>().RPC("SDSN", RPCMode.All, (object) "WOOHOO!");
        break;
      case 14:
        Vector3 vector3_8 = new Vector3(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x, Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).y, 0.0f);
        this.GetComponent<NetworkView>().RPC("Wisp", RPCMode.All, (object) vector3_8);
        break;
      case 15:
        Vector3 euler3 = (double) Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= (double) GameScript.player.transform.position.x ? new Vector3(0.0f, 180f, 0.0f) : new Vector3(0.0f, 0.0f, 0.0f);
        ((GameObject) Network.Instantiate(Resources.Load("skill/wolf"), GameScript.player.transform.position, Quaternion.Euler(euler3), 0)).GetComponent<NetworkView>().RPC("SetN", RPCMode.All, (object) (GameScript.DEX + GameScript.DEXBonus));
        break;
    }
  }

  [RPC]
  public virtual void Wisp(Vector3 mP) => UnityEngine.Object.Instantiate(Resources.Load("skill/wisp"), mP, Quaternion.identity);

  public virtual IEnumerator RageTick() => (IEnumerator) new GameScript.\u0024RageTick\u00241814().GetEnumerator();

  public virtual IEnumerator RoarTick() => (IEnumerator) new GameScript.\u0024RoarTick\u00241815().GetEnumerator();

  public virtual IEnumerator FloatTick() => (IEnumerator) new GameScript.\u0024FloatTick\u00241816().GetEnumerator();

  public virtual IEnumerator ManaTick() => (IEnumerator) new GameScript.\u0024ManaTick\u00241817(this).GetEnumerator();

  public virtual string GetItemName(int id)
  {
    switch (id)
    {
      case 1:
        return "Wood";
      case 2:
        return "Wooden Plank";
      case 3:
        return "Wooden Stick";
      case 4:
        return "Ironite Ore";
      case 5:
        return "Goldium Ore";
      case 6:
        return "Diamonite Ore";
      case 7:
        return "Raw Meat";
      case 8:
        return "Cooked Meat";
      case 9:
        return "Herb";
      case 10:
        return "Shroom";
      case 11:
        return "Root";
      case 12:
        return "Ironite Bar";
      case 13:
        return "Goldium Bar";
      case 14:
        return "Diamonite Bar";
      case 15:
        return "HP Potion";
      case 16:
        return "Mana Potion";
      case 17:
        return "Vial of Poison";
      case 18:
        return "Monster Bone";
      case 19:
        return "Monster Hide";
      case 20:
        return "Monster Pelt";
      case 21:
        return "Raw Chicken";
      case 22:
        return "Cooked Chicken";
      case 23:
        return "Spider Web";
      case 24:
        return "Sword Hilt";
      case 25:
        return "Wooden Blade";
      case 26:
        return "Axe Handle";
      case 27:
        return "Pick Handle";
      case 28:
        return "Unstrung Bow";
      case 29:
        return "String";
      case 30:
        return "Fire Bug";
      case 31:
        return "Thunder Bug";
      case 32:
        return "Ironite Blade";
      case 33:
        return "Goldmium Blade";
      case 34:
        return "Diamonite Blade";
      case 35:
        return "Ironite Great Blade";
      case 36:
        return "Goldium Great Blade";
      case 37:
        return "Diamonite Great Blade";
      case 38:
        return "Stone";
      case 39:
        return "Refined Stone";
      case 40:
        return "Stone Blade";
      case 41:
        return "Stone Great Blade";
      case 42:
        return "Big HP Potion";
      case 43:
        return "Big Mana Potion";
      case 44:
        return "Mysterious Potion";
      case 45:
        return "Big Mysterious Potion";
      case 46:
        return "Total Biscuit";
      case 47:
        return "Coal";
      case 48:
        return "Firestarter";
      case 49:
        return "Mystery Key";
      case 50:
        return "Bone Blade";
      case 51:
        return "Refined Bone";
      case 52:
        return "Bone Arrow";
      case 53:
        return "Stone Arrow";
      case 54:
        return "Ironite Arrow";
      case 55:
        return "Goldium Arrow";
      case 56:
        return "Diamonite Arrow";
      case 57:
        return "Dragonite Arrow";
      case 58:
        return "Adamantite Arrow";
      case 59:
        return "Obsidian Arrow";
      case 60:
        return "Crystalite Fragment";
      case 61:
        return "Crystalite Shard";
      case 62:
        return "Dragonite Ore";
      case 63:
        return "Dragonite Bar";
      case 64:
        return "Adamantite Ore";
      case 65:
        return "Adamantite Bar";
      case 66:
        return "Obsidian Ore";
      case 67:
        return "Obsidian Bar";
      case 68:
        return "Net";
      case 69:
        return "Fire Gem I";
      case 70:
        return "Thunder Gem I";
      case 71:
        return "Ice Gem I";
      case 72:
        return "Stone Dagger";
      case 73:
        return "Bone Dagger";
      case 74:
        return "Ironite Dagger";
      case 75:
        return "Goldium Dagger";
      case 76:
        return "Diamonite Dagger";
      case 77:
        return "Tribal Drum";
      case 78:
        return "Drum of Strength";
      case 79:
        return "Drum of Dexterity";
      case 80:
        return "Drum of Wisdom";
      case 81:
        return "Ice Bug";
      case 82:
        return "Refined Leather";
      case 83:
        return "Rugged Leather";
      case 84:
        return "Tribal Leather";
      case 85:
        return "Elegant Leather";
      case 86:
        return "Royal Leather";
      case 87:
        return "Luminous Leather";
      case 88:
        return "Rugged Fabric";
      case 89:
        return "Tribal Fabric";
      case 90:
        return "Elegant Fabric";
      case 91:
        return "Royal Fabric";
      case 92:
        return "Luminous Fabric";
      case 94:
        return "Refined Cloth";
      case 95:
        return "Spirit Gem";
      default:
        return "NULL";
    }
  }

  public virtual string GetGearName(int id)
  {
    switch (id)
    {
      case 500:
        return "Wooden Sword";
      case 501:
        return "Wooden Axe";
      case 502:
        return "Wooden Pick";
      case 503:
        return "Ironite Sword";
      case 504:
        return "Ironite Axe";
      case 505:
        return "Ironite Pick";
      case 506:
        return "Goldium Sword";
      case 507:
        return "Goldium Axe";
      case 508:
        return "Goldium Pick";
      case 509:
        return "Diamonite Sword";
      case 510:
        return "Diamonite Axe";
      case 511:
        return "Diamonite Pick";
      case 512:
        return "Stone Sword";
      case 513:
        return "Stone Axe";
      case 514:
        return "Stone Pick";
      case 515:
        return "Wooden Bow";
      case 516:
        return "Bone Sword";
      case 517:
        return "Bone Axe";
      case 518:
        return "Bone Pick";
      case 519:
        return "Wooden Club";
      case 520:
        return "Lightbringer";
      case 521:
        return "Scourge Blade";
      case 522:
        return "Dragonite Pick";
      case 523:
        return "Wightslayer";
      case 524:
        return "Adamantite Axe";
      case 525:
        return "Adamantite Pick";
      case 526:
        return "Spellblade";
      case 527:
        return "Obsidian Axe";
      case 528:
        return "Obsidian Pick";
      case 529:
        return "Bug Net";
      case 530:
        return "Crystal Bow";
      case 531:
        return "Emerald Katana";
      case 532:
        return "Emerald Combat Axe";
      case 533:
        return "Obsidian Sword";
      case 534:
        return "Laser Sword";
      case 535:
        return "Laser Crossbow";
      case 536:
        return "Fire Bow";
      case 550:
        return "Giant Fish";
      case 560:
        return "Ironite Great Axe";
      case 561:
        return "Goldium Great Axe";
      case 562:
        return "Diamonite Great Axe";
      case 563:
        return "Stone Great Axe";
      case 564:
        return "Hellswrath";
      case 565:
        return "The Philibuster";
      case 566:
        return "Jelly Blade";
      case 567:
        return "Zweihander";
      case 568:
        return "Icebrand";
      case 569:
        return "Firebrand";
      case 570:
        return "Thunderbrand";
      case 600:
        return "Fireball";
      case 601:
        return "Bolt";
      case 602:
        return "Frostshard";
      case 603:
        return "Summon Zombie";
      case 700:
        return "Ironite Helm";
      case 701:
        return "Goldium Helm";
      case 702:
        return "Diamonite Helm";
      case 703:
        return "Stone Helm";
      case 704:
        return "Bone Helm";
      case 705:
        return "Rugged Cap";
      case 706:
        return "Tribal Cap";
      case 707:
        return "Elegant Cap";
      case 708:
        return "Royal Cap";
      case 709:
        return "Luminous Cap";
      case 710:
        return "Rugged Hood";
      case 711:
        return "Tribal Hood";
      case 712:
        return "Elegant Hood";
      case 713:
        return "Royal Hood";
      case 714:
        return "Luminous Hood";
      case 800:
        return "Ironite Armor";
      case 801:
        return "Goldium Armor";
      case 802:
        return "Diamonite Armor";
      case 803:
        return "Stone Armor";
      case 804:
        return "Bone Armor";
      case 805:
        return "Rugged Cloak";
      case 806:
        return "Tribal Cloak";
      case 807:
        return "Elegant Cloak";
      case 808:
        return "Royal Cloak";
      case 809:
        return "Luminous Cloak";
      case 810:
        return "Rugged Robes";
      case 811:
        return "Tribal Robes";
      case 812:
        return "Elegant Robes";
      case 813:
        return "Royal Robes";
      case 814:
        return "Luminous Robes";
      case 900:
        return "Ironite Shield";
      case 901:
        return "Goldium Shield";
      case 902:
        return "Diamonite Shield";
      case 903:
        return "Stone Shield";
      case 904:
        return "Bone Shield";
      case 905:
        return "Ryvenrath's Scale";
      case 906:
        return "Paladin Guard";
      case 907:
        return "Scourge Shield";
      case 950:
        return "Ring of Power";
      case 951:
        return "Ring of Wisdom";
      case 952:
        return "Ring of Nature";
      case 953:
        return "Ring of Life";
      case 954:
        return "Ring of Rage";
      case 955:
        return "Ring of Insanity";
      case 956:
        return "Archer's Ring";
      case 957:
        return "Ring of Balance";
      default:
        return "NULL";
    }
  }

  public virtual void Main()
  {
  }
}
