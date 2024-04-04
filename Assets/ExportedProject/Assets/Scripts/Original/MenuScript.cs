using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Android;

[Serializable]
public class MenuScript : MonoBehaviour
{
    public IEnumerator ApplyRes()
    {
        int pp = GetRes1();
        int pp2 = GetRes2();
        y = Screen.fullScreen;
        Screen.SetResolution(pp, pp2, y);
        PlayerPrefs.SetInt("res", curRes); // Assuming curRes is defined elsewhere in the class
        PlayerPrefs.SetInt("FULLSCREEN", y ? 1 : 0);
        bApply.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        DetectRes();
    }

    public IEnumerator Statistics()
    {
        fade.fadeOut();
        yield return new WaitForSeconds(0.2f);
        fade.fadeIn();
        txtHighScore[0].text = PlayerPrefs.GetInt("hScore").ToString();
        txtHighScore[1].text = txtHighScore[0].text;
        int playerLevel = GetPlayerLevel();
        float curEXP = GetCurEXP(playerLevel);
        float levelCap = GetLevelCap(playerLevel);
        float percent = curEXP / levelCap * 8.5f;
        MonoBehaviour.print($"Current Level:{playerLevel} Total EXP:{accountEXP} Next Level:{curEXP}/{levelCap}");
        menuMain.SetActive(false);
        menuStats.SetActive(true);
        txtAccountLevel.text = "Player Level : " + playerLevel;
        txtCurEXP.text = $"{curEXP}/{levelCap}";
        Vector3 scale = barEXP.transform.localScale;
        scale.x = percent;
        barEXP.transform.localScale = scale;
    }

    public IEnumerator Play()
    {
        fade.fadeOut();
        yield return new WaitForSeconds(0.2f);

        fade.fadeIn();
        enteringIP = false;
        menuMain.SetActive(false);
        menuMultiplayer.SetActive(false);

        if (!Network.isClient)
        {
            try
            {
                port = int.Parse(txtPort.text);
            }
            catch (Exception)
            {
                port = 7777;
            }

            bool useNat = !Network.HavePublicAddress();
            Network.InitializeServer(10, port, useNat);
            print("Initialized Server" + txtIP[0].text + " Port:" + port);
        }

        int[] curTrait = new int[3]; // Assuming curTrait is declared somewhere in MenuScript
        curTrait[1] = UnityEngine.Random.Range(1, MAX_TRAITS);
        curTrait[2] = UnityEngine.Random.Range(1, MAX_TRAITS);
        if (curTrait[2] == curTrait[1])
        {
            curTrait[2] = (curTrait[2] % (MAX_TRAITS - 1)) + 1;
        }

        Renderer trait1Renderer = trait1.GetComponent<Renderer>();
        Renderer trait2Renderer = trait2.GetComponent<Renderer>();
        trait1Renderer.material = Resources.Load<Material>($"t/t{curTrait[1]}");
        trait2Renderer.material = Resources.Load<Material>($"t/t{curTrait[2]}");

        menuCharacterCreate.SetActive(true);
    }

    public IEnumerator Options()
    {
        fade.fadeOut();
        yield return new WaitForSeconds(0.2f);
        fade.fadeIn();
        menuMain.SetActive(false);
        menuOptions.SetActive(true);
    }

    public IEnumerator RefreshServers()
    {
        for (int i = 0; i < server.Length; i++)
        {
            server[i].SetActive(false);
            string serverIP = PlayerPrefs.GetString("serverIP" + i);
            if (!string.IsNullOrEmpty(serverIP))
            {
                server[i].SetActive(true);
                txtServerIP[i].text = serverIP;
            }
        }

        yield return new WaitForSeconds(0.1f);
    }

    public IEnumerator Done()
    {
        fade.fadeOut();
        yield return new WaitForSeconds(0.2f);

        fade.fadeIn();
        curHat = 0;
        curCompanion = 0;
        curRace = 0;
        bApply.SetActive(false);
        menuMain.SetActive(true);
        menuStats.SetActive(false);
        menuLobby.SetActive(false);
        menuCharacterCreate.SetActive(false);
        menuOptions.SetActive(false);
        menuMultiplayer.SetActive(false);
    }

    [RPC]
    public IEnumerator ReadyGame()
    {
        fade.fadeOut();
        yield return new WaitForSeconds(0.2f);

        fade.fadeIn();
        SaveCharacter();

        if (noLobby)
        {
            yield return StartCoroutine(BeginGame());
        }
        else
        {
            MenuLobby();
            yield return new WaitForSeconds(0.1f);
        }
    }

    [RPC]
    public IEnumerator BeginGame()
    {
        PlayerPrefs.SetInt("stat0", PlayerPrefs.GetInt("stat0") + 1);
        fade.fadeOut();
        yield return new WaitForSeconds(0.2f);
        SaveCharacter();
        Application.LoadLevel(2);
    }


    [NonSerialized] public static int GameMode;

    [NonSerialized] public static int goldChests;

    public GameObject buttonPVP;

    public GameObject pvpX;

    [NonSerialized] public static int pvp;

    public GameObject[] playerCompanion;

    public TextMesh txtCompanionName;

    public GameObject menuCompanion;

    public GameObject[] shineCompanion;

    private int selectedCompanion;

    public TextMesh[] txtCompanionUnlock;

    public TextMesh[] txtCompanionDescription;

    public GameObject companionSelect;

    public TextMesh[] txtGameMode;

    public GameObject menuCredits;

    public GameObject shadeCredits;

    [NonSerialized] public static int companion;

    [NonSerialized] public static int deathA;

    [NonSerialized] public static int[] raceStats = new int[4];

    public TextMesh[] txtHatUnlock;

    public TextMesh[] txtHatDescription;

    public TextMesh txtHatName;

    public GameObject menuHat;

    public GameObject[] shineHat;

    public GameObject hatSelect;

    private int selectedHat;

    public TextMesh[] txtRaceUnlock;

    [NonSerialized] public static int[] canUnlockRace = new int[15];

    [NonSerialized] public static int[] canUnlockHat = new int[25];

    [NonSerialized] public static int[] canUnlockCompanion = new int[17];

    [NonSerialized] public static int[] raceUnlock = new int[15];

    [NonSerialized] public static int[] companionUnlock = new int[17];

    [NonSerialized] public static int[] hatUnlock = new int[25];

    [NonSerialized] public static int pHat;

    public GameObject bApply;

    private int curVariant;

    private int curHat;

    private int curCompanion;

    public TextMesh txtHosting;

    public TextMesh txtRes;

    public TextMesh txtVolume;

    [NonSerialized] public static int curScore;

    [NonSerialized] public static int curRes;

    public TextMesh[] txtHighScore;

    private int port;

    public TextMesh txtPort;

    private bool enteringPort;

    public GameObject raceSelect;

    private bool writing;

    public GameObject[] shine;

    public GameObject menuRace;

    [NonSerialized] public static int[] startingItemID = new int[3];

    public GameObject[] startingItems;

    public TextMesh txtRaceName;

    public TextMesh txtRaceStats;

    public TextMesh[] txtRaceDescription;

    public TextMesh[] txtStory;

    private int selectedRace;

    public TextMesh txtCurEXP;

    public GameObject barEXP;

    public TextMesh txtAccountLevel;

    [NonSerialized] public static int accountEXP;

    public GameObject bStartGame;

    public GameObject cursorInfo;

    public TextMesh txtMenuName;

    public TextMesh txtMenuDesc;

    public TextMesh txtConnecting;

    public GameObject menuConnecting;

    private int doneConnecting;

    private bool isMale;

    [NonSerialized] public static string curName;

    [NonSerialized] public static string ip = "192.168.0.2";

    [NonSerialized] public static int growthStatGood1;

    [NonSerialized] public static int growthStatGood2;

    [NonSerialized] public static int growthStatBad;

    [NonSerialized] public static int pVariant;

    [NonSerialized] public static int pBody;

    [NonSerialized] public static int pColor;

    [NonSerialized] public static int pRace;

    [NonSerialized] public static int pOffhand;

    [NonSerialized] public static int[] playerStat = new int[6];

    private FadeInOut fade;

    private int curPlayers;

    public TextMesh[] txtPlayer;

    public TextMesh[] txtRace;

    public GameObject menuLobby;

    public TextMesh[] txtStats;

    public GameObject[] server;

    [NonSerialized] public static string[] serverIP = new string[4];

    [NonSerialized] public static int numServers;

    public TextMesh[] txtServerIP;

    public GameObject menuMain;

    public GameObject menuOptions;

    public GameObject menuStats;

    public GameObject menuCards;

    public GameObject menuCharacterSelect;

    public GameObject menuCharacterCreate;

    public GameObject menuMultiplayer;

    public TextMesh[] txtIP;

    public TextMesh txtFullscreen;

    public TextMesh txtFullscreen2;

    public TextMesh[] txtSlot;

    public TextMesh[] txtSlot2;

    public TextMesh[] txtName;

    public TextMesh[] txtHead;

    public TextMesh[] txtColor;

    public TextMesh[] txtBody;

    public TextMesh[] txtStat;

    public GameObject[] playerBody;

    public GameObject trait1;

    public GameObject trait2;

    private bool noLobby;

    private int statCap;

    private string curServer;

    private int MAX_HEAD;

    private int MAX_COLOR;

    private int MAX_BODY;

    private int MAX_SKIN;

    private int MAX_TRAITS;

    private int MAX_RACE;

    private Ray ray;

    private RaycastHit hit;

    private int curHead;

    private int curColor;

    private int curBody;

    private int curSkin;

    private int curRace;

    private int[] curStat;

    private bool enteringName;

    [NonSerialized] public static int[] curTrait = new int[3];

    private bool enteringIP;

    public Texture2D cursorTexture;

    private CursorMode cursorMode;

    private Vector2 hotSpot;

    private int mask;

    private Ray rayCursor;

    private RaycastHit cursorHit;

    private bool isSelectingRace;

    [NonSerialized] public static int volume;

    private int FULLSCREEN;

    private bool y;

    private bool ForceFullscreen;

    public MenuScript()
    {
        playerCompanion = new GameObject[17];
        shineCompanion = new GameObject[17];
        txtCompanionUnlock = new TextMesh[2];
        txtCompanionDescription = new TextMesh[2];
        txtGameMode = new TextMesh[2];
        txtHatUnlock = new TextMesh[2];
        txtHatDescription = new TextMesh[2];
        shineHat = new GameObject[30];
        txtRaceUnlock = new TextMesh[2];
        txtHighScore = new TextMesh[2];
        shine = new GameObject[15];
        startingItems = new GameObject[3];
        txtRaceDescription = new TextMesh[2];
        txtStory = new TextMesh[2];
        txtPlayer = new TextMesh[4];
        txtRace = new TextMesh[2];
        txtStats = new TextMesh[16];
        server = new GameObject[4];
        txtServerIP = new TextMesh[4];
        txtIP = new TextMesh[2];
        txtSlot = new TextMesh[3];
        txtSlot2 = new TextMesh[3];
        txtName = new TextMesh[2];
        txtHead = new TextMesh[2];
        txtColor = new TextMesh[2];
        txtBody = new TextMesh[2];
        txtStat = new TextMesh[12];
        playerBody = new GameObject[7];
        statCap = 20;
        MAX_HEAD = 14;
        MAX_COLOR = 3;
        MAX_BODY = 6;
        MAX_SKIN = 1;
        MAX_TRAITS = 13;
        MAX_RACE = 1;
        curStat = new int[6];
        cursorMode = CursorMode.Auto;
        hotSpot = new Vector2(8f, 8f);
        mask = 1024;
    }

    public virtual void DetectRes()
    {
        if (!(Camera.main.aspect < 1.7f))
        {
            Camera.main.orthographicSize = 12f;
        }
        else if (!(Camera.main.aspect < 1.5f))
        {
            Camera.main.orthographicSize = 13f;
        }
        else if (!(Camera.main.aspect < 1.3f))
        {
            Camera.main.orthographicSize = 14.5f;
        }
        else if (!(Camera.main.aspect < 1.25f))
        {
            Camera.main.orthographicSize = 15.2f;
        }
    }

    public virtual void Awake()
    {
        goldChests = PlayerPrefs.GetInt("gChests");
        menuCredits.SetActive(value: false);
        pvp = 0;
        companion = 0;
        DetectRes();
        curHat = 0;
        deathA = PlayerPrefs.GetInt("deathA");
        if (PlayerPrefs.GetInt("fTime") == 0)
        {
            PlayerPrefs.SetInt("volume", 10);
            PlayerPrefs.SetInt("fTime", 1);
        }

        curRes = PlayerPrefs.GetInt("res");
        FULLSCREEN = PlayerPrefs.GetInt("fScreen");
        if (FULLSCREEN != 0)
        {
            y = true;
        }
        else
        {
            y = false;
        }

        txtRes.text = GetRes1() + "x" + GetRes2();
        volume = PlayerPrefs.GetInt("volume");
        txtVolume.text = "Audio: " + volume;
        curRace = 0;
        SetStartingItemIDs(curRace);
        int num = default(int);
        accountEXP = PlayerPrefs.GetInt("aEXP");
        for (num = 0; num < 15; num++)
        {
            raceUnlock[num] = PlayerPrefs.GetInt("rU" + num);
        }

        for (num = 0; num < 25; num++)
        {
            hatUnlock[num] = PlayerPrefs.GetInt("hU" + num);
        }

        for (num = 0; num < 10; num++)
        {
            companionUnlock[num] = PlayerPrefs.GetInt("cU" + num);
        }

        if (raceUnlock[0] == 0)
        {
            raceUnlock[0] = 2;
            PlayerPrefs.SetInt("rU0", 2);
        }

        LoadStats();
        fade = (FadeInOut)Camera.main.gameObject.GetComponent("FadeInOut");
        numServers = 0;
        for (num = 0; num < 4; num++)
        {
            serverIP[num] = PlayerPrefs.GetString("serverIP" + num);
            if (serverIP[num] != string.Empty)
            {
                numServers++;
            }
        }
    }

    public virtual void SetInfoText(int slot)
    {
        cursorInfo.SetActive(value: true);
        txtMenuName.text = GetTraitName(curTrait[slot]);
        txtMenuDesc.text = GetTraitDesc(curTrait[slot]);
    }

    public virtual void Update()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        rayCursor = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
        if (Physics.Raycast(rayCursor, out cursorHit, 25f, mask))
        {
            if (cursorHit.transform.gameObject.layer == 10)
            {
                int infoText = int.Parse(cursorHit.transform.gameObject.name);
                SetInfoText(infoText);
            }
        }
        else
        {
            cursorInfo.SetActive(value: false);
        }

        if (UnityEngine.Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 70f))
            {
                ((AudioSource)GetComponent(typeof(AudioSource))).PlayOneShot(
                    (AudioClip)Resources.Load("Au/CLICK(2)", typeof(AudioClip)));
                GameObject gameObject = hit.transform.gameObject;
                if (gameObject.tag == "shine")
                {
                    SelectRace(gameObject.name);
                }
                else if (gameObject.tag == "shine2")
                {
                    SelectHat(gameObject.name);
                }
                else if (gameObject.tag == "shine3")
                {
                    SelectCompanion(gameObject.name);
                }

                switch (gameObject.name)
                {
                    case "bSingleplayer":
                        GameMode = 0;
                        noLobby = true;
                        StartCoroutine(Play());
                        Randomize();
                        if (GameMode == 0)
                        {
                            txtGameMode[0].color = Color.white;
                            txtGameMode[0].text = "Normal Mode";
                        }
                        else
                        {
                            txtGameMode[0].color = Color.red;
                            txtGameMode[0].text = "Madman Mode";
                        }

                        break;
                    case "bMultiplayer":
                        Multiplayer();
                        noLobby = false;
                        Randomize();
                        break;
                    case "bEnterIP":
                        txtIP[0].text = string.Empty;
                        enteringIP = true;
                        enteringPort = false;
                        break;
                    case "bEnterPort":
                        txtPort.text = string.Empty;
                        enteringPort = true;
                        enteringIP = false;
                        break;
                    case "bOptions":
                        StartCoroutine(Options());
                        break;
                    case "bDone":
                        StartCoroutine(Done());
                        break;
                    case "bDone2":
                        Done2();
                        break;
                    case "bHost":
                        StartCoroutine(Play());
                        break;
                    case "bConnect":
                        StartCoroutine(Play());
                        break;
                    case "bSound":
                        UpdateSound(0);
                        break;
                    case "bGraphics":
                        UpdateGraphics();
                        break;
                    case "bQuit":
                        Application.Quit();
                        break;
                    case "bFullscreen":
                        Fullscreen();
                        break;
                    case "bStats":
                        StartCoroutine(Statistics());
                        break;
                    case "bCards":
                        Cards();
                        break;
                    case "2":
                        ChangeTrait2(0);
                        break;
                    case "bTwitter":
                        Application.OpenURL("https://twitter.com/SeanYoungSG");
                        break;
                    case "bFacebook":
                        Application.OpenURL("https://www.facebook.com/magicitegame");
                        break;
                    case "bReddit":
                        Application.OpenURL("https://www.reddit.com/r/Magicite/");
                        break;
                    case "1":
                        ChangeTrait1(0);
                        break;
                    case "bBack":
                        StartCoroutine(Done());
                        Network.Disconnect();
                        break;
                    case "bBackR":
                        menuRace.SetActive(value: false);
                        menuHat.SetActive(value: false);
                        menuCompanion.SetActive(value: false);
                        UpdateAppearance();
                        break;
                    case "bStart":
                        GetComponent<NetworkView>().RPC("BeginGame", RPCMode.All);
                        break;
                    case "bHead":
                        ChangeHead(1);
                        break;
                    case "bADD":
                        AddServer();
                        goto case "bColor";
                    case "bColor":
                        ChangeColor(1);
                        break;
                    case "bBody":
                        ChangeBody(1);
                        break;
                    case "bStat":
                        RandomizeStats();
                        break;
                    case "bRandomize":
                        Randomize();
                        break;
                    case "bRace":
                        RaceMenu();
                        break;
                    case "bHat":
                        HatMenu();
                        break;
                    case "enterName":
                        EnterName();
                        break;
                    case "bCreate":
                        StartCoroutine(ReadyGame());
                        break;
                    case "bMode":
                        ModeSwitch();
                        break;
                    case "bRefresh":
                        StartCoroutine(RefreshServers());
                        break;
                    case "bDelete":
                        Delete();
                        break;
                    case "bBlocker":
                        Blocker();
                        break;
                    case "bS0":
                        Port(0);
                        break;
                    case "bS1":
                        Port(1);
                        break;
                    case "bS2":
                        Port(2);
                        break;
                    case "bS3":
                        Port(3);
                        break;
                    case "x0":
                        DeleteServer(0);
                        break;
                    case "x1":
                        DeleteServer(1);
                        break;
                    case "x2":
                        DeleteServer(2);
                        break;
                    case "x3":
                        DeleteServer(3);
                        break;
                    case "bRes":
                        UpdateRes(0);
                        break;
                    case "bApply":
                        StartCoroutine(ApplyRes());
                        break;
                    case "bVariant":
                        Variant();
                        break;
                    case "bCompanion":
                        Companion();
                        break;
                    case "bCredits":
                        Credits();
                        break;
                    case "cClose":
                        CloseCredits();
                        break;
                    case "bPVP":
                        if (pvp != 0)
                        {
                            pvp = 0;
                            pvpX.SetActive(value: false);
                        }
                        else
                        {
                            pvp = 1;
                            pvpX.SetActive(value: true);
                        }

                        break;
                }
            }
        }

        if (UnityEngine.Input.GetMouseButtonDown(1))
        {
            ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 70f))
            {
                ((AudioSource)GetComponent(typeof(AudioSource))).PlayOneShot(
                    (AudioClip)Resources.Load("Au/CLICK(2)", typeof(AudioClip)));
                GameObject gameObject2 = hit.transform.gameObject;
                switch (gameObject2.name)
                {
                    case "bPlay":
                        StartCoroutine(Play());
                        break;
                    case "bOptions":
                        StartCoroutine(Options());
                        break;
                    case "bDone":
                        StartCoroutine(Done());
                        break;
                    case "bSound":
                        UpdateSound(1);
                        break;
                    case "bGraphics":
                        UpdateGraphics();
                        break;
                    case "bFullscreen":
                        Fullscreen();
                        break;
                    case "bBack":
                        StartCoroutine(Done());
                        break;
                    case "bHead":
                        ChangeHead(0);
                        break;
                    case "bColor":
                        ChangeColor(0);
                        break;
                    case "bRace":
                        ChangeRace(0);
                        break;
                    case "bBody":
                        ChangeBody(0);
                        break;
                    case "bStats":
                        RandomizeStats();
                        break;
                    case "2":
                        ChangeTrait2(1);
                        break;
                    case "1":
                        ChangeTrait1(1);
                        break;
                    case "bRandomize":
                        Randomize();
                        break;
                    case "bRes":
                        UpdateRes(1);
                        break;
                }
            }
        }

        // TODO: Caleb, commenting for now
        // if (enteringName)
        // {
        //     IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(UnityEngine.Input.inputString);
        //     while (enumerator.MoveNext())
        //     {
        //         char c = (char)enumerator.Current;
        //         if (c == "\b"[0])
        //         {
        //             if (txtName[0].text.Length != 0)
        //             {
        //                 txtName[0].text = txtName[0].text.Substring(0, txtName[0].text.Length - 1);
        //             }
        //         }
        //         else if (c == "\n"[0] || c == "\r"[0])
        //         {
        //             enteringName = false;
        //         }
        //         else if (txtName[0].text.Length < 10)
        //         {
        //             txtName[0].text = txtName[0].text + c;
        //             UnityRuntimeServices.Update(enumerator, c);
        //         }
        //     }
        // }

        // if (enteringIP)
        // {
        //     IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(UnityEngine.Input.inputString);
        //     while (enumerator2.MoveNext())
        //     {
        //         char c2 = (char)enumerator2.Current;
        //         if (c2 == "\b"[0])
        //         {
        //             if (txtIP[0].text.Length != 0)
        //             {
        //                 txtIP[0].text = txtIP[0].text.Substring(0, txtIP[0].text.Length - 1);
        //             }
        //         }
        //         else if (c2 == "\n"[0] || c2 == "\r"[0])
        //         {
        //             enteringIP = false;
        //         }
        //         else if (txtIP[0].text.Length < 20)
        //         {
        //             txtIP[0].text = txtIP[0].text + c2;
        //             UnityRuntimeServices.Update(enumerator2, c2);
        //         }
        //
        //         ip = txtIP[0].text;
        //     }
        // }

        if (!enteringPort)
        {
            return;
        }

        // IEnumerator enumerator3 = UnityRuntimeServices.GetEnumerator(UnityEngine.Input.inputString);
        // while (enumerator3.MoveNext())
        // {
        //     char c3 = (char)enumerator3.Current;
        //     if (c3 == "\b"[0])
        //     {
        //         if (txtPort.text.Length != 0)
        //         {
        //             txtPort.text = txtPort.text.Substring(0, txtPort.text.Length - 1);
        //         }
        //     }
        //     else if (c3 == "\n"[0] || c3 == "\r"[0])
        //     {
        //         enteringPort = false;
        //     }
        //     else if (txtPort.text.Length < 20)
        //     {
        //         txtPort.text += c3;
        //         UnityRuntimeServices.Update(enumerator3, c3);
        //     }
        //
        //     try
        //     {
        //         port = int.Parse(txtPort.text);
        //     }
        //     catch (Exception)
        //     {
        //     }
        // }
    }

    public virtual void ModeSwitch()
    {
        GameMode++;
        if (GameMode > 1)
        {
            GameMode = 0;
        }

        if (GameMode == 0)
        {
            txtGameMode[0].color = Color.white;
            txtGameMode[0].text = "Normal Mode";
        }
        else
        {
            txtGameMode[0].color = Color.red;
            txtGameMode[0].text = "Madman Mode";
        }
    }

    public virtual void ChangeTrait1(int a)
    {
        switch (a)
        {
            case 0:
                curTrait[1] = curTrait[1] + 1;
                if (curTrait[1] == curTrait[2])
                {
                    curTrait[1] = curTrait[1] + 1;
                }

                if (curTrait[1] > MAX_TRAITS)
                {
                    curTrait[1] = 1;
                }

                break;
            case 1:
                curTrait[1] = curTrait[1] - 1;
                if (curTrait[1] == curTrait[2])
                {
                    curTrait[1] = curTrait[1] - 1;
                }

                if (curTrait[1] < 1)
                {
                    curTrait[1] = MAX_TRAITS;
                }

                break;
        }

        ((Renderer)trait1.GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("t/t" + curTrait[1], typeof(Material));
    }

    public virtual void ChangeTrait2(int a)
    {
        switch (a)
        {
            case 0:
                curTrait[2] = curTrait[2] + 1;
                if (curTrait[2] == curTrait[1])
                {
                    curTrait[2] = curTrait[2] + 1;
                }

                if (curTrait[2] > MAX_TRAITS)
                {
                    curTrait[2] = 1;
                }

                break;
            case 1:
                curTrait[2] = curTrait[2] - 1;
                if (curTrait[2] == curTrait[1])
                {
                    curTrait[2] = curTrait[2] - 1;
                }

                if (curTrait[2] < 1)
                {
                    curTrait[2] = MAX_TRAITS;
                }

                break;
        }

        ((Renderer)trait2.GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("t/t" + curTrait[2], typeof(Material));
    }

    public virtual void Credits()
    {
        ((AudioSource)GetComponent(typeof(AudioSource))).Play();
        menuCredits.SetActive(value: true);
        ((Animation)menuCredits.GetComponent(typeof(Animation))).Play();
        shadeCredits.SetActive(value: true);
    }

    public virtual void CloseCredits()
    {
        ((AudioSource)GetComponent(typeof(AudioSource))).Stop();
        menuCredits.SetActive(value: false);
        shadeCredits.SetActive(value: false);
    }

    public virtual void Port(int a)
    {
        ip = serverIP[a];
        try
        {
            port = int.Parse(txtPort.text);
        }
        catch (Exception)
        {
            port = 7777;
        }

        TryConnect();
    }

    public virtual void Blocker()
    {
        if (doneConnecting != 0)
        {
            if (doneConnecting == 1)
            {
                StartCoroutine(Play());
                menuConnecting.SetActive(value: false);
                doneConnecting = 0;
            }
            else
            {
                menuConnecting.SetActive(value: false);
                doneConnecting = 0;
            }
        }
    }

    public virtual void Variant()
    {
        if (raceUnlock[curRace] > curVariant + 1)
        {
            curVariant++;
            if (curVariant > 2)
            {
                curVariant = 0;
            }

            UpdateAppearance();
        }
        else
        {
            curVariant = 0;
            UpdateAppearance();
        }
    }

    public virtual void Companion()
    {
        selectedCompanion = curCompanion;
        if (curCompanion > 0)
        {
            companionSelect.transform.position = shineCompanion[curCompanion].transform.position;
        }
        else
        {
            companionSelect.transform.position = new Vector3(0f, 50f, 0f);
        }

        RefreshCompanionMenu();
        menuCompanion.SetActive(value: true);
    }

    public virtual void UpdateRes(int dir)
    {
        bApply.SetActive(value: true);
        if (dir == 0)
        {
            if (curRes < 11)
            {
                curRes++;
            }
            else
            {
                curRes = 0;
            }
        }
        else if (curRes > 0)
        {
            curRes--;
        }
        else
        {
            curRes = 11;
        }

        bool flag = default(bool);
        if (Screen.fullScreen)
        {
            flag = true;
        }
        else
        {
            flag = false;
        }

        txtRes.text = GetRes1() + "x" + GetRes2();
    }

    public virtual int GetRes1()
    {
        int num = default(int);
        switch (curRes)
        {
            case 0:
                return 640;
            case 1:
                return 800;
            case 2:
                return 1024;
            case 3:
                return 1152;
            case 4:
            case 5:
            case 6:
                return 1280;
            case 7:
                return 1366;
            case 8:
                return 1400;
            case 9:
            case 10:
                return 1600;
            case 11:
                return 1920;
            default:
                return num;
        }
    }

    public virtual int GetRes2()
    {
        int num = default(int);
        switch (curRes)
        {
            case 0:
                return 480;
            case 1:
                return 600;
            case 2:
                return 768;
            case 3:
                return 864;
            case 4:
                return 720;
            case 5:
                return 960;
            case 6:
                return 1024;
            case 7:
                return 768;
            case 8:
                return 1050;
            case 9:
                return 900;
            case 10:
                return 1024;
            case 11:
                return 1080;
            default:
                return num;
        }
    }

    public virtual void TryConnect()
    {
        txtConnecting.text = "Connecting to " + ip + " port " + port;
        Network.Connect(ip, port);
        menuConnecting.SetActive(value: true);
    }

    public virtual void OnFailedToConnect()
    {
        txtConnecting.text = "Failed to connect to " + ip;
        doneConnecting = -1;
    }

    public virtual void AddServer()
    {
        if (numServers < 3)
        {
            MonoBehaviour.print("adding server");
            PlayerPrefs.SetString("serverIP" + numServers, ip);
            serverIP[numServers] = ip;
            numServers++;
            StartCoroutine(RefreshServers());
        }
    }

    public virtual void RaceMenu()
    {
        selectedRace = curRace;
        raceSelect.transform.position = shine[curRace].transform.position;
        RefreshRaceMenu();
        menuRace.SetActive(value: true);
    }

    public virtual void HatMenu()
    {
        selectedHat = curHat;
        if (curHat > 0)
        {
            hatSelect.transform.position = shineHat[curHat].transform.position;
        }
        else
        {
            hatSelect.transform.position = new Vector3(0f, 50f, 0f);
        }

        RefreshHatMenu();
        menuHat.SetActive(value: true);
    }

    public virtual void RefreshCompanionMenu()
    {
        int num = default(int);
        for (num = 1; num < 17; num++)
        {
            if (companionUnlock[num] > 0)
            {
                ((Renderer)shineCompanion[num].GetComponent(typeof(Renderer))).material =
                    (Material)Resources.Load("sh1");
                shineCompanion[num].gameObject.tag = "shine3";
            }
            else
            {
                ((Renderer)shineCompanion[num].GetComponent(typeof(Renderer))).material =
                    (Material)Resources.Load("sh2");
                shineCompanion[num].gameObject.tag = "Untagged";
            }
        }

        txtCompanionName.text = GetCompanionName(selectedCompanion);
        ShowCompanionDescription();
    }

    public virtual void RefreshHatMenu()
    {
        int num = default(int);
        for (num = 1; num < 25; num++)
        {
            if (hatUnlock[num] > 0)
            {
                ((Renderer)shineHat[num].GetComponent(typeof(Renderer))).material = (Material)Resources.Load("sh1");
                shineHat[num].gameObject.tag = "shine2";
            }
            else
            {
                ((Renderer)shineHat[num].GetComponent(typeof(Renderer))).material = (Material)Resources.Load("sh2");
                shineHat[num].gameObject.tag = "Untagged";
            }
        }

        txtHatName.text = GetHatName(selectedHat);
        ShowHatDescription();
    }

    public virtual string GetCompName(int a)
    {
        string result = null;
        switch (a)
        {
            case 1:
                result = "Cloud";
                break;
            case 2:
                result = "Axe";
                break;
            case 3:
                result = "Frost";
                break;
            case 4:
                result = "Arrow";
                break;
            case 5:
                result = "Comet";
                break;
            case 6:
                result = "Fortune";
                break;
            case 7:
                result = "Ultima";
                break;
            case 8:
                result = "Chaos";
                break;
        }

        return result;
    }

    public virtual string GetHatName(int a)
    {
        string text = null;
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
                return "Black Dragon Helm";
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

    public virtual string GetCompanionName(int a)
    {
        string text = null;
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
            default:
                return string.Empty;
        }
    }

    public virtual void RefreshRaceMenu()
    {
        int num = default(int);
        for (num = 0; num < 15; num++)
        {
            if (raceUnlock[num] > 0)
            {
                ((Renderer)shine[num].GetComponent(typeof(Renderer))).material = (Material)Resources.Load("sh1");
                shine[num].gameObject.tag = "shine";
            }
            else
            {
                ((Renderer)shine[num].GetComponent(typeof(Renderer))).material = (Material)Resources.Load("sh2");
                shine[num].gameObject.tag = "Untagged";
            }
        }

        txtRaceName.text = GetRaceName(selectedRace);
        txtRaceStats.text = GetRaceStats(selectedRace);
        ShowRaceDescription();
        ShowStartingItems();
    }

    public virtual void SelectCompanion(string name)
    {
        switch (name)
        {
            case "01":
                raceSelect.transform.position = shineHat[1].transform.position;
                curCompanion = 1;
                RefreshCompanionMenu();
                break;
            case "02":
                raceSelect.transform.position = shineHat[2].transform.position;
                curCompanion = 2;
                RefreshCompanionMenu();
                break;
            case "03":
                raceSelect.transform.position = shineHat[3].transform.position;
                curCompanion = 3;
                RefreshCompanionMenu();
                break;
            case "04":
                raceSelect.transform.position = shineHat[4].transform.position;
                curCompanion = 4;
                RefreshCompanionMenu();
                break;
            case "05":
                raceSelect.transform.position = shineHat[5].transform.position;
                curCompanion = 5;
                RefreshCompanionMenu();
                break;
            case "06":
                raceSelect.transform.position = shineHat[6].transform.position;
                curCompanion = 6;
                RefreshCompanionMenu();
                break;
            case "07":
                raceSelect.transform.position = shineHat[7].transform.position;
                curCompanion = 7;
                RefreshCompanionMenu();
                break;
            case "08":
                raceSelect.transform.position = shineHat[8].transform.position;
                curCompanion = 8;
                RefreshCompanionMenu();
                break;
            case "09":
                raceSelect.transform.position = shineHat[9].transform.position;
                curCompanion = 9;
                RefreshCompanionMenu();
                break;
            case "10":
                curCompanion = 10;
                RefreshCompanionMenu();
                break;
            case "11":
                curCompanion = 11;
                RefreshCompanionMenu();
                break;
            case "12":
                curCompanion = 12;
                RefreshCompanionMenu();
                break;
            case "13":
                curCompanion = 13;
                RefreshCompanionMenu();
                break;
            case "14":
                curCompanion = 14;
                RefreshCompanionMenu();
                break;
            case "15":
                curCompanion = 15;
                RefreshCompanionMenu();
                break;
            case "16":
                curCompanion = 16;
                RefreshCompanionMenu();
                break;
            case "17":
                curCompanion = 17;
                RefreshCompanionMenu();
                break;
            case "18":
                curCompanion = 18;
                RefreshCompanionMenu();
                break;
        }

        companionSelect.transform.position = shineCompanion[curCompanion].transform.position;
    }

    public virtual void SelectHat(string name)
    {
        switch (name)
        {
            case "01":
                raceSelect.transform.position = shineHat[1].transform.position;
                curHat = 1;
                RefreshHatMenu();
                break;
            case "02":
                raceSelect.transform.position = shineHat[2].transform.position;
                curHat = 2;
                RefreshHatMenu();
                break;
            case "03":
                raceSelect.transform.position = shineHat[3].transform.position;
                curHat = 3;
                RefreshHatMenu();
                break;
            case "04":
                raceSelect.transform.position = shineHat[4].transform.position;
                curHat = 4;
                RefreshHatMenu();
                break;
            case "05":
                raceSelect.transform.position = shineHat[5].transform.position;
                curHat = 5;
                RefreshHatMenu();
                break;
            case "06":
                raceSelect.transform.position = shineHat[6].transform.position;
                curHat = 6;
                RefreshHatMenu();
                break;
            case "07":
                raceSelect.transform.position = shineHat[7].transform.position;
                curHat = 7;
                RefreshHatMenu();
                break;
            case "08":
                raceSelect.transform.position = shineHat[8].transform.position;
                curHat = 8;
                RefreshHatMenu();
                break;
            case "09":
                raceSelect.transform.position = shineHat[9].transform.position;
                curHat = 9;
                RefreshHatMenu();
                break;
            case "10":
                curHat = 10;
                RefreshHatMenu();
                break;
            case "11":
                curHat = 11;
                RefreshHatMenu();
                break;
            case "12":
                curHat = 12;
                RefreshHatMenu();
                break;
            case "13":
                curHat = 13;
                RefreshHatMenu();
                break;
            case "14":
                curHat = 14;
                RefreshHatMenu();
                break;
            case "15":
                curHat = 15;
                RefreshHatMenu();
                break;
            case "16":
                curHat = 16;
                RefreshHatMenu();
                break;
            case "17":
                curHat = 17;
                RefreshHatMenu();
                break;
            case "18":
                curHat = 18;
                RefreshHatMenu();
                break;
            case "19":
                curHat = 19;
                RefreshHatMenu();
                break;
            case "20":
                curHat = 20;
                RefreshHatMenu();
                break;
            case "21":
                curHat = 21;
                RefreshHatMenu();
                break;
            case "22":
                curHat = 22;
                RefreshHatMenu();
                break;
            case "23":
                curHat = 23;
                RefreshHatMenu();
                break;
            case "24":
                curHat = 24;
                RefreshHatMenu();
                break;
        }

        hatSelect.transform.position = shineHat[curHat].transform.position;
    }

    public virtual void SelectRace(string name)
    {
        switch (name)
        {
            case "00":
                raceSelect.transform.position = shine[0].transform.position;
                curRace = 0;
                RefreshRaceMenu();
                break;
            case "01":
                raceSelect.transform.position = shine[1].transform.position;
                curRace = 1;
                RefreshRaceMenu();
                break;
            case "02":
                raceSelect.transform.position = shine[2].transform.position;
                curRace = 2;
                RefreshRaceMenu();
                break;
            case "03":
                raceSelect.transform.position = shine[3].transform.position;
                curRace = 3;
                RefreshRaceMenu();
                break;
            case "04":
                raceSelect.transform.position = shine[4].transform.position;
                curRace = 4;
                RefreshRaceMenu();
                break;
            case "05":
                raceSelect.transform.position = shine[5].transform.position;
                curRace = 5;
                RefreshRaceMenu();
                break;
            case "06":
                raceSelect.transform.position = shine[6].transform.position;
                curRace = 6;
                RefreshRaceMenu();
                break;
            case "07":
                raceSelect.transform.position = shine[7].transform.position;
                curRace = 7;
                RefreshRaceMenu();
                break;
            case "08":
                raceSelect.transform.position = shine[8].transform.position;
                curRace = 8;
                RefreshRaceMenu();
                break;
            case "09":
                raceSelect.transform.position = shine[9].transform.position;
                curRace = 9;
                RefreshRaceMenu();
                break;
            case "10":
                raceSelect.transform.position = shine[10].transform.position;
                curRace = 10;
                RefreshRaceMenu();
                break;
            case "11":
                raceSelect.transform.position = shine[11].transform.position;
                curRace = 11;
                RefreshRaceMenu();
                break;
            case "12":
                raceSelect.transform.position = shine[12].transform.position;
                curRace = 12;
                RefreshRaceMenu();
                break;
            case "13":
                raceSelect.transform.position = shine[13].transform.position;
                curRace = 13;
                RefreshRaceMenu();
                break;
            case "14":
                raceSelect.transform.position = shine[14].transform.position;
                curRace = 14;
                RefreshRaceMenu();
                break;
        }

        SetRaceStats();
        raceSelect.transform.position = shine[curRace].transform.position;
        SetStartingItemIDs(curRace);
        curVariant = 0;
    }

    public virtual void SetStartingItemIDs(int r)
    {
        switch (r)
        {
            case 0:
                startingItemID[0] = 501;
                startingItemID[1] = 9999;
                startingItemID[2] = 9999;
                return;
            case 1:
                startingItemID[0] = 513;
                startingItemID[1] = 8888;
                startingItemID[2] = 8888;
                return;
            case 2:
                startingItemID[0] = 516;
                startingItemID[1] = 518;
                startingItemID[2] = 8888;
                return;
            case 3:
                startingItemID[0] = 501;
                startingItemID[1] = 515;
                startingItemID[2] = 9999;
                return;
        }

        switch (r)
        {
            case 3:
                startingItemID[0] = 501;
                startingItemID[1] = 563;
                startingItemID[2] = 8888;
                break;
            case 4:
                startingItemID[0] = 501;
                startingItemID[1] = 563;
                startingItemID[2] = 9999;
                break;
            case 5:
                startingItemID[0] = 501;
                startingItemID[1] = 601;
                startingItemID[2] = 9999;
                break;
            case 6:
                startingItemID[0] = 501;
                startingItemID[1] = 42;
                startingItemID[2] = 43;
                break;
            case 7:
                startingItemID[0] = 501;
                startingItemID[1] = 804;
                startingItemID[2] = 9999;
                break;
            case 8:
                startingItemID[0] = 7;
                startingItemID[1] = 7;
                startingItemID[2] = 7;
                break;
            case 9:
                startingItemID[0] = 501;
                startingItemID[1] = 529;
                startingItemID[2] = 7;
                break;
            case 10:
                startingItemID[0] = 501;
                startingItemID[1] = 957;
                startingItemID[2] = 950;
                break;
            case 11:
                startingItemID[0] = 501;
                startingItemID[1] = 565;
                startingItemID[2] = 600;
                break;
            case 12:
                startingItemID[0] = 514;
                startingItemID[1] = 531;
                startingItemID[2] = 0;
                break;
            case 13:
                startingItemID[0] = 603;
                startingItemID[1] = 0;
                startingItemID[2] = 0;
                break;
            case 14:
                startingItemID[0] = 506;
                startingItemID[1] = 501;
                startingItemID[2] = 0;
                break;
            default:
                startingItemID[0] = 0;
                startingItemID[1] = 0;
                startingItemID[2] = 0;
                break;
        }
    }

    public virtual void SetRace(int ra)
    {
        if (ra == 99)
        {
            selectedRace = curRace;
            RefreshRaceMenu();
        }
        else
        {
            selectedRace = ra;
            RefreshRaceMenu();
        }
    }

    public virtual void SetHat(int ra)
    {
        if (ra == 99)
        {
            selectedHat = curHat;
            RefreshHatMenu();
        }
        else
        {
            selectedHat = ra;
            RefreshHatMenu();
        }
    }

    public virtual void SetComp(int ra)
    {
        if (ra == 99)
        {
            selectedCompanion = curCompanion;
            RefreshCompanionMenu();
        }
        else
        {
            selectedCompanion = ra;
            RefreshCompanionMenu();
        }
    }

    public virtual string GetRaceName(int race)
    {
        string text = null;
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
                return string.Empty;
        }
    }

    public virtual string GetRaceStats(int race)
    {
        string text = null;
        if (raceUnlock[race] > 0)
        {
            switch (race)
            {
                case 0:
                    return "HP +1\n";
                case 1:
                    return "HP +1\nMAG+1\n";
                case 2:
                    return "HP -1\nATk+2";
                case 3:
                    return "HP -1\nDEX+4";
                case 4:
                    return "ATK +1";
                case 5:
                    return "HP-1\nMAG+4";
                case 6:
                    return "DEX +3";
                case 7:
                    return "ATK +1\nDEX +1\nMAG +1";
                case 8:
                    return "HP -1\nATK -1\nDEX -1\nMAG -1";
                case 9:
                    return "ATK +2\nDEX +2";
                case 10:
                    return "ATK +1\nDEX +3";
                case 11:
                    return "MAG +3";
                case 12:
                    return "ATK +1\nDEX +3\nMAG +1";
                case 13:
                    return "MAG +4";
                case 14:
                    return "HP +7\nATK +3";
                default:
                    return " ";
            }
        }

        return "???";
    }

    public virtual void SetRaceStats()
    {
        int num = default(int);
        for (num = 0; num < 4; num++)
        {
            raceStats[num] = 0;
        }

        switch (curRace)
        {
            case 0:
                raceStats[0] = raceStats[0] + 1;
                break;
            case 1:
                raceStats[0] = raceStats[0] + 1;
                raceStats[3] = raceStats[3] + 1;
                break;
            case 2:
                raceStats[0] = raceStats[0] - 1;
                raceStats[1] = raceStats[1] + 2;
                break;
            case 3:
                raceStats[0] = raceStats[0] - 1;
                raceStats[2] = raceStats[2] + 4;
                break;
            case 4:
                raceStats[1] = raceStats[1] + 1;
                break;
            case 5:
                raceStats[0] = raceStats[0] - 1;
                raceStats[3] = raceStats[3] + 4;
                break;
            case 6:
                raceStats[2] = raceStats[2] + 1;
                break;
            case 7:
                raceStats[1] = raceStats[1] + 1;
                raceStats[2] = raceStats[2] + 1;
                raceStats[3] = raceStats[3] + 1;
                break;
            case 8:
                raceStats[1] = raceStats[1] - 1;
                raceStats[2] = raceStats[2] - 1;
                raceStats[3] = raceStats[3] - 1;
                raceStats[0] = raceStats[0] - 1;
                break;
            case 9:
                raceStats[2] = raceStats[2] + 2;
                raceStats[1] = raceStats[1] + 2;
                break;
            case 10:
                raceStats[2] = raceStats[2] + 3;
                raceStats[1] = raceStats[1] + 1;
                break;
            case 11:
                raceStats[3] = raceStats[3] + 3;
                break;
            case 12:
                raceStats[1] = raceStats[1] + 1;
                raceStats[2] = raceStats[2] + 3;
                raceStats[3] = raceStats[3] + 1;
                break;
            case 13:
                raceStats[3] = raceStats[3] + 4;
                break;
            case 14:
                raceStats[0] = raceStats[0] + 7;
                raceStats[1] = raceStats[1] + 3;
                break;
        }
    }

    public virtual void ShowCompanionDescription()
    {
        writing = false;
        string text = null;
        text = GetUnlockCompanion(selectedCompanion);
        string text2 = string.Empty;
        if (companionUnlock[selectedCompanion] > 0)
        {
            switch (selectedCompanion)
            {
                case 1:
                    text2 = "A magical fairy that's imbued with healing magic. Heals its owner for\n" +
                            "1 HP upon reaching the end of a district.";
                    break;
                case 2:
                    text2 = "Ancient Bats are immortal beings that love to eat. When not in a town, this\n" +
                            "companion will sometimes spit out a random item it ate from a time long ago.";
                    break;
                case 3:
                    text2 = "A Beetle that imbues its master with immense agility. Speed is doubled when\n" +
                            "traveling with this companion.\n";
                    break;
                case 4:
                    text2 = "A rare mechanical being crafted from magical metals. This companion will\n" +
                            "summon a spinning gadget blade near its owner whenever they dash in the air.\n" +
                            "The Gadget Blade will deal damage equal to half of the player's ATK.";
                    break;
                case 5:
                    text2 = "Gorgon Eyes lurk deep underground after escaping from a Gorgon corpse. The\n" +
                            "eyes are immortal and possess a tremendous amount of magical ability. The\n" +
                            "Owner of this companion regains 1 extra mana every 1.5 seconds.";
                    break;
                case 6:
                    text2 = "A rare type of slime that's not only friendly, but also has the ability to\n" +
                            "fly. The owner of this companion will not be affected by gravity.";
                    break;
                case 7:
                    text2 = "The elusive Gooey Ghost allows the user to jump an infinite amount of times.\n";
                    break;
                case 8:
                    text2 = "The Flame of Hope burns on with the fiery determination of people in Deephaven,\n" +
                            "following only legendary heroes whose fates will change the world forever.\n" +
                            "Upon leveling up, the owner will gain 1 extra point in a random stat.";
                    break;
                case 9:
                    text2 = "This sacred machine forged from another time is a heroic symbol of the true\n" +
                            "saviors of Deephaven. Your speed is doubled and you can fly.";
                    break;
                default:
                    text2 = " ";
                    break;
            }
        }

        int num = default(int);
        writing = true;
        txtCompanionDescription[0].text = text2;
        txtCompanionDescription[1].text = txtCompanionDescription[0].text;
        txtCompanionUnlock[0].text = text;
        txtCompanionUnlock[1].text = txtCompanionUnlock[0].text;
    }

    public virtual void ShowHatDescription()
    {
        writing = false;
        string text = null;
        text = GetUnlockHat(selectedHat);
        string text2 = string.Empty;
        if (hatUnlock[selectedHat] > 0)
        {
            switch (selectedHat)
            {
                case 1:
                    text2 = "The headband of Deephaven's Gatherer Guild. The wearer has a 25% chance of\n" +
                            "acquiring a random item when gathering ingredients.";
                    break;
                case 2:
                    text2 = "Standard Deephaven mining gear. The wearer has a 25% chance of yielding\nanother" +
                            " ore when hitting an ore deposit with a Pick.";
                    break;
                case 3:
                    text2 = "This scarf was worn by the legendary warriors who died fighting the Scourge\n" +
                            "in the early days of Deephaven. 33% chance on level up to gain an additional\n" +
                            "ATK stat.";
                    break;
                case 4:
                    text2 = "A hat fashioned from the finest threads harvested from the Overworld. 33%\n" +
                            "chance on level up to gain an additional DEX stat.";
                    break;
                case 5:
                    text2 = "Despite being a time of turmoil and destruction, there are still forms of\n" +
                            "entertainment in Deephaven. This hat belongs to a traveling wizard circus that\n" +
                            "performs dazzling spells and tricks. 33% chance on level up to gain and\n" +
                            "additional MAG stat.";
                    break;
                case 6:
                    text2 = "These Bunny Ears imbue the wearer's body with immense agility, unlocking the\n" +
                            "ability to triple jump.";
                    break;
                case 7:
                    text2 = "A hat fashioned from Bat fur, teeth, and claws. The wearer becomes insanely\n" +
                            "quick on their feet! Dash distance is doubled.";
                    break;
                case 8:
                    text2 = "A must have for any true fan of the Tyrannox. This hat is carefully crafted from\n" +
                            "Tyrannox hides and organs, granting the wearer the ability to summon highly toxic\n" +
                            "meteors that scale with MAG when attacking bare handed. Consumes 1 Mana.";
                    break;
                case 9:
                    text2 = "A common piece of equipment for Deephaven explorers. These Wasp Goggles bestow\n" +
                            "the wearer with bonus speed and slows falling. During the excavation of caves\n" +
                            "these were required as a safety precaution. ";
                    break;
                case 10:
                    text2 = "Stolen from the rabid Tiki Tribes, this magical mask is said to be cursed with\n" +
                            "mysterious properties. Upon arriving at a new district, you have a 50% chance of\n" +
                            "gaining 3 HP or losing 1 HP.";
                    break;
                case 11:
                    text2 = "Everyone knows that if you have a long flowing white beard you are very\n" +
                            "wise and better with magic. Casting spells have a 66% chance of not consuming\n" +
                            "mana. ";
                    break;
                case 12:
                    text2 = "A crown fitting for a true hero of Deephaven. It's gold plating and ruby gem\nradiates " +
                            "with awe. 33% chance on level up to gain an additional random stat.";
                    break;
                case 13:
                    text2 = "An actual Shroom body part. It kind of smells. Upon taking damage, you have a\n" +
                            "20% chance of dropping a random ingredient from the giant Shroom\ngrowing on your head.";
                    break;
                case 14:
                    text2 = "It is hard to keep up with the fashion in Deephaven. One not so popular trend is\n" +
                            "to put a Broodmother's Egg on top of your head despite it being very dangerous.\n" +
                            "Upon being hit, there is a 10% chance that a Broodmother Spider will spawn.";
                    break;
                case 15:
                    text2 = "A cursed Skeleton mask. The wearer's chance of landing a critical hit is now\n" + "25%.";
                    break;
                case 16:
                    text2 = "This Dragon hat is worn during festivals and special occasions in Deephaven. It is\n" +
                            "a sign of status and prestige. Attacking bare handed will shoot a fireball that\n" +
                            "deals damage equal to the amount of MAG you have, consuming 1 mana.";
                    break;
                case 17:
                    text2 = "No one dares to put a Scourge Mask on. The Scourge's flesh have demonic\n" +
                            "properties that drain it's wearer's HP. Your HP will be drained by 1 every 2\n" +
                            "minutes.";
                    break;
                case 18:
                    text2 = "The Fabled Ice Queen's Crown. The wearer has a 20% chance to recover HP when\n" +
                            "recovering a Mana point.";
                    break;
                case 19:
                    text2 = "Worn by the Viking Warriors who sailed the seas in the Overworld. Those who\nwear this" +
                            "ancient armor will have a 10% chance on attack to summon a giant\nViking Axe to deal\n" +
                            "double ATK damage.";
                    break;
                case 20:
                    text2 = "The mythical and fearsome Black Dragon is one of the most deadly creatures in\n" +
                            "Deephaven. For the wearer, dashes and jumps no longer cost stamina. ";
                    break;
                case 21:
                    text2 = "The Skeleton King wanders the Dungeons in Deephaven, capturing stray\n" +
                            "wanderers. His hood allows users to summon skeletons when attacking bare\n\n" +
                            "handed. Consumes 1 Mana.";
                    break;
                case 22:
                    text2 = "Percyl the Penguin roams various parts of Deephaven, challenging anyone he\n" +
                            "comes across to a duel. His hat grants double the amount of gold for the wearer.";
                    break;
                case 23:
                    text2 = "Thank you for all of the love and support for my game, I couldn't have done this\n" +
                            "without you. I hope you have many crazy and exciting adventures in Deephaven!\n" +
                            "This hat has no in-game effects.";
                    break;
                case 24:
                    text2 = "A helm only worn by Kings in the Overworld. This prestigious helm grants the\n" +
                            "ultimate defense, reducing all incoming damage by half.";
                    break;
                default:
                    text2 = " ";
                    break;
            }
        }

        int num = default(int);
        writing = true;
        txtHatDescription[0].text = text2;
        txtHatDescription[1].text = txtHatDescription[0].text;
        txtHatUnlock[0].text = text;
        txtHatUnlock[1].text = txtHatUnlock[0].text;
    }

    public virtual void ShowRaceDescription()
    {
        writing = false;
        string text = null;
        text = GetUnlockRace(selectedRace);
        string text2 = string.Empty;
        if (raceUnlock[selectedRace] > 0)
        {
            switch (selectedRace)
            {
                case 0:
                    text2 = "Peons are the common folk of Deephaven. These simple yet ambitous people\n" +
                            "strive to expand their colonies underground through mining, farming, and crafting.\n" +
                            "Perhaps one day these unlikely heroes will rebuild an army and take back the\n" +
                            "Overworld.";
                    break;
                case 1:
                    text2 = "Nobles are the direct descendants of kings in the Overworld.\n" +
                            "Some can afford to travel through safe routes in Deephaven\n" +
                            "to the surface, if only for a moment to feel the sun on their\n" +
                            "skin. Nobles have much influence on the expansion in Deephaven.";
                    break;
                case 2:
                    text2 = "These gargantuan brutes were driven underground from their\n" +
                            "mountainous home lands. Although not very intelligent, these\n" +
                            "barbarians hold incredible might and power which has allowed\n" +
                            "them to aggressively expand in Deephaven.";
                    break;
                case 3:
                    text2 = "The agile Dwelves are a race of peace and harmony. But Don't\n" +
                            "be fooled, when threatened they are unmatched with bows\n" +
                            "and deadly magic. Dwelves aim to forge The Grand Alliance\n" +
                            "composed of all races in order to defeat the Scourge.";
                    break;
                case 4:
                    text2 = "These people are what remain of the Great War in the Overworld. Most of them\n" +
                            "were wanted criminals but all were true soldiers who risked everything\n" +
                            "to prevent the Scourge from taking over.";
                    break;
                case 5:
                    text2 = "Legends told of an ancient race that lived long before this\n" +
                            "age of chaos and destruction. Until the Scourge attacked, the\n" +
                            "Remnant lived reclusive lives deep within the Icy Wastes.\n" +
                            "But now these magical beings have joined in on the fight against the\n" +
                            "Scourge, and aid in the collection and refinement of Magicite.";
                    break;
                case 6:
                    text2 = "High above Wyvern's Rock was the colony of Trogon. This\n" +
                            "bird-like race used to be the backbone of the trading system\n" +
                            "when the Overworld was flourishing. Daring, agile, and quite\n" +
                            "intelligent, the Trogon do what they can to transport goods\n" +
                            "throughout the intricate and dangerous passageways of Deephaven.";
                    break;
                case 7:
                    text2 = "Earthkin were born deep underground. Very little is known\n" +
                            "about this mysterious race.";
                    break;
                case 8:
                    text2 = "Pigfolk are shunned in Deephaven. These extremely dumb yet\n" +
                            "good spirited people just want to help fight the Scourge. ";
                    break;
                case 9:
                    text2 = "The Aquatic Qualogg lived in the underground rivers before\n" +
                            "any other race fled from the surface. It took them quite some time\n" +
                            "to accept these strangers into their homelands.";
                    break;
                case 10:
                    text2 = "Bandicoots are cunning, smart, and extremely greedy. These\n" +
                            "thieves have followed everyone into Deephaven with the sole\n" +
                            "purpose of hoarding items and stealing from those unaware.";
                    break;
                case 11:
                    text2 = "Thought to be a legend, the Djinn are powerful entities that\n" +
                            "have lived for millions of years. They possess incredible magic\n" +
                            "powers and have been a major influence in the fight against the Scourge.";
                    break;
                case 12:
                    text2 = "The Lizardmen are adept hunters, whose skill and prowess in combat\n" +
                            "have aided in the struggle against the Scourge. Mainly a hunting and\n" +
                            "gathering race, these people do not stay in one place for very long.";
                    break;
                case 13:
                    text2 = "A spawn of the Scourge. An enemy to all.";
                    break;
                case 14:
                    text2 = "A remnant of the great Spirit Knight Axelark III. Some say he was the strongest\n" +
                            "knight of the Overworld, the only one to slay a Wight Wyvern in battle.";
                    break;
                default:
                    text2 = " ";
                    break;
            }
        }

        int num = default(int);
        writing = true;
        txtRaceDescription[0].text = text2;
        txtRaceDescription[1].text = txtRaceDescription[0].text;
        txtRaceUnlock[0].text = text;
        txtRaceUnlock[1].text = txtRaceUnlock[0].text;
    }

    public virtual string GetUnlockCompanion(int num)
    {
        string result = null;
        switch (num)
        {
            case 1:
                result = "100% Unlock chance after reaching district 15 in a single playthrough.";
                break;
            case 2:
                result = "100% Unlock chance after beating the game.";
                break;
            case 3:
                result = "100% Unlock chance after reaching level 40 in a single playthrough.";
                break;
            case 4:
                result = "100% Unlock chance after beating the game while under level 5.";
                break;
            case 5:
                result = "100% Unlock chance after beating the game without interacting with any NPCs.";
                break;
            case 6:
                result = "100% Unlock chance after beating the game without chopping a single tree.";
                break;
            case 7:
                result = "100% Unlock after crafting the 3 Legendary Swords in a single playthrough.";
                break;
            case 8:
                result = "100% Unlock chance after beating the game with Ryvenrath's Scale equipped.";
                break;
            case 9:
                result = "100% Unlock chance after beating the game in Madman Mode.";
                break;
        }

        return result;
    }

    public virtual string GetUnlockHat(int num)
    {
        string result = null;
        switch (num)
        {
            case 1:
                result = "20% Unlock chance after gathering 10 plants in a single playerthrough.";
                break;
            case 2:
                result = "20% Unlock chance after mining 10 Ores in a single playthrough.";
                break;
            case 3:
                result = "100% Unlock chance after defeating 10 monsters in a single biome.";
                break;
            case 4:
                result = "20% Unlock chance after shooting 100 Arrows in a single playthrough.";
                break;
            case 5:
                result = "20% Unlock chance after crafting any magic staff in a playthrough.";
                break;
            case 6:
                result = "20% after visiting the Tundra biome in a single playthrough.";
                break;
            case 7:
                result = "20% after visiting the Cave biome in a single playthrough.";
                break;
            case 8:
                result = "20% Unlock chance after defeating a Tyrannox in a single playthrough.";
                break;
            case 9:
                result = "20% Unlock chance after destroying a beehive in a single playthrough.";
                break;
            case 10:
                result = "20% Unlock chance after visiting the Swamp Biome in a single playthrough.";
                break;
            case 11:
                result = "100% Unlock chance after choosing only Mage Skills.";
                break;
            case 12:
                result = "100% Unlock chance after beating the game.";
                break;
            case 13:
                result = "20% Unlock chance after visiting the Veldt Biome in a single playthrough.";
                break;
            case 14:
                result = "20% Unlock chance after defeating a Broodmother in a single playthrough.";
                break;
            case 15:
                result = "20% Unlock chance after visiting the Dungeon Biome in a single playthrough.";
                break;
            case 16:
                result = "20% Unlock chance after visiting the Volcano Biome in a single playthrough.";
                break;
            case 17:
                result = "20% Unlock chance after visiting the Scourge Lair in a single playthrough.";
                break;
            case 18:
                result = "20% Unlock chance after defeating the Ice Queen.";
                break;
            case 19:
                result = "100% Unlock chance after choosing only Warrior Skills.";
                break;
            case 20:
                result = "100% Unlock chance after defeating the Black Dragon.";
                break;
            case 21:
                result = "100% Unlock chance after defeating the Skeleton King.";
                break;
            case 22:
                result = "100% Unlock chance after defeating Percyl.";
                break;
            case 23:
                result = "Unlocked by using a cheat code. Press the L key in-game.";
                break;
            case 24:
                result = "100% Unlock chance after beating the game without taking any damage.";
                break;
        }

        return result;
    }

    public virtual string GetUnlockRace(int num)
    {
        string result = null;
        switch (num)
        {
            case 0:
                result = "20% Unlock chance after chopping 50 trees in a single playthrough.";
                break;
            case 1:
                result = "20% Unlock chance after slaying 15 monsters in a single playthrough.";
                break;
            case 2:
                result = "20% Unlock chance after mining 20 Ores in a single playthrough.";
                break;
            case 3:
                result = "20% Unlock chance after acquiring your first skill in a playthrough.";
                break;
            case 4:
                result = "20% Unlock chance after acquiring your second skill in a playthrough.";
                break;
            case 5:
                result = "20% Unlock chance after beating the game.";
                break;
            case 6:
                result = "100% Unlock chance after beating the game in under an hour.";
                break;
            case 7:
                result = "20% Unlock chance after reaching district 10 in a playthrough.";
                break;
            case 8:
                result = "100% Unlock chance after beating the game without using an HP potion.";
                break;
            case 9:
                result = "100% Unlock chance after beating the game without crafting anything.";
                break;
            case 10:
                result = "50% Unlock chance after visiting the Crater biome.";
                break;
            case 11:
                result = "100% Unlock chance after beating the game by only killing 1 enemy.";
                break;
            case 12:
                result = "Unlocked by naming your character something...";
                break;
            case 13:
                result = "Unlocked after opening a total of 20 Golden Chests.";
                break;
            case 14:
                result = "Unlocked after defeating secret boss Spirit Knight, Axelark III.";
                break;
        }

        return result;
    }

    public virtual void ShowStartingItems()
    {
        int[] array = new int[3];
        if (raceUnlock[selectedRace] <= 0)
        {
            array = new int[3] { 8888, 8888, 8888 };
        }
        else
        {
            switch (selectedRace)
            {
                case 0:
                    array = new int[3] { 501, 9999, 9999 };
                    break;
                case 1:
                    array = new int[3] { 513, 0, 0 };
                    break;
                case 2:
                    array = new int[3] { 516, 518, 0 };
                    break;
                case 3:
                    array = new int[3] { 501, 515, 9999 };
                    break;
                case 4:
                    array = new int[3] { 501, 563, 0 };
                    break;
                case 5:
                    array = new int[3] { 501, 601, 0 };
                    break;
                case 6:
                    array = new int[3] { 501, 42, 43 };
                    break;
                case 7:
                    array = new int[3] { 501, 804, 9999 };
                    break;
                case 8:
                    array = new int[3] { 7, 7, 7 };
                    break;
                case 9:
                    array = new int[3] { 501, 529, 9999 };
                    break;
                case 10:
                    array = new int[3] { 501, 957, 950 };
                    break;
                case 11:
                    array = new int[3] { 501, 565, 600 };
                    break;
                case 12:
                    array = new int[3] { 514, 531, 0 };
                    break;
                case 13:
                    array = new int[3] { 603, 0, 0 };
                    break;
                case 14:
                case 15:
                    array = new int[3] { 506, 501, 0 };
                    break;
                default:
                    array = new int[3];
                    break;
            }
        }

        ((Renderer)startingItems[0].GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("i/i" + array[0]);
        ((Renderer)startingItems[1].GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("i/i" + array[1]);
        ((Renderer)startingItems[2].GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("i/i" + array[2]);
    }

    public virtual void DeleteServer(int a)
    {
        numServers--;
        PlayerPrefs.SetString("serverIP" + a, string.Empty);
        int num = default(int);
        for (num = a; num < 4; num++)
        {
            string @string = PlayerPrefs.GetString("serverIP" + (num + 1));
            PlayerPrefs.SetString("serverIP" + num, @string);
            PlayerPrefs.SetString("serverIP" + (num + 1), string.Empty);
        }

        StartCoroutine(RefreshServers());
    }

    public virtual int GetCurEXP(int pLevel)
    {
        int num = accountEXP;
        if (pLevel > 1)
        {
            num -= GetTotalEXP(pLevel);
        }

        return num;
    }

    public virtual int GetLevelCap(int pLevel)
    {
        int num = 0;
        int num2 = 100;
        int num3 = default(int);
        for (num3 = 1; num3 < pLevel; num3++)
        {
            num2 = (int)((float)num2 * 1.2f);
        }

        if (pLevel == 0)
        {
            num2 = 0;
        }

        return num2;
    }

    public virtual int GetTotalEXP(int lvl)
    {
        int num = default(int);
        int num2 = default(int);
        for (num = 0; num < lvl; num++)
        {
            num2 += GetLevelCap(num);
        }

        return num2;
    }

    public virtual int GetPlayerLevel()
    {
        int num = accountEXP;
        int num2 = 0;
        int num3 = default(int);
        int num4 = 100;
        while (num >= 0)
        {
            num -= num4;
            num4 = (int)((float)num4 * 1.2f);
            num2++;
        }

        return num2;
    }

    public virtual void Cards()
    {
    }

    public virtual void Multiplayer()
    {
        menuMultiplayer.SetActive(value: true);
        StartCoroutine(RefreshServers());
        menuMain.SetActive(value: false);
    }


    public virtual void Done2()
    {
        menuStats.SetActive(value: true);
    }

    public virtual void UpdateSound(int dir)
    {
        if (dir == 0)
        {
            if (volume < 10)
            {
                volume++;
            }
            else
            {
                volume = 0;
            }
        }
        else if (volume > 0)
        {
            volume--;
        }
        else
        {
            volume = 10;
        }

        UpdateVolume(volume);
        txtVolume.text = "Audio: " + volume;
    }

    public virtual void UpdateVolume(int v)
    {
        AudioListener.volume = (float)v * 0.1f;
        PlayerPrefs.SetInt("volume", v);
    }

    public virtual void UpdateGraphics()
    {
    }

    public virtual void OnPlayerDisconnected()
    {
        MonoBehaviour.print("player disconnected. players connected : " + Network.connections.Length);
        RefreshLobby(Network.connections.Length - 1);
        GetComponent<NetworkView>().RPC("RefreshLobby", RPCMode.AllBuffered, Network.connections.Length - 1);
    }

    public virtual void OnPlayerConnected(NetworkPlayer player)
    {
        Debug.Log("Player " + Network.connections.Length + " connected from " + player.ipAddress + ":" + player.port);
        GetComponent<NetworkView>().RPC("RefreshLobby", RPCMode.AllBuffered, Network.connections.Length);
        if (Network.connections.Length > 3)
        {
            Network.CloseConnection(player, sendDisconnectionNotification: false);
        }
    }

    [RPC]
    public virtual void RefreshLobby(int c)
    {
        bStartGame.SetActive(value: true);
        int num = default(int);
        for (num = 0; num < 4; num++)
        {
            if (num < c + 1)
            {
                txtPlayer[num].text = "Player " + (num + 1);
                ((Renderer)txtPlayer[num].gameObject.GetComponent(typeof(Renderer))).material.color = Color.green;
            }
            else
            {
                txtPlayer[num].text = "-";
                ((Renderer)txtPlayer[num].gameObject.GetComponent(typeof(Renderer))).material.color = Color.white;
            }
        }
    }

    public virtual void AddPlayerToLobby()
    {
        int length = Network.connections.Length;
        txtPlayer[length].text = "Player " + length;
    }

    public virtual void Fullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        if (Screen.fullScreen)
        {
            txtFullscreen.text = "Fullscreen: OFF";
            txtFullscreen2.text = "Fullscreen: OFF";
        }
        else
        {
            txtFullscreen.text = "Fullscreen: ON";
            txtFullscreen2.text = "Fullscreen: ON";
        }
    }

    public virtual void EnterName()
    {
        enteringName = true;
        txtName[0].text = string.Empty;
    }

    public virtual void CharacterCreate()
    {
        Randomize();
        menuMain.SetActive(value: false);
        menuCharacterSelect.SetActive(value: false);
        RandomizeStats();
        curTrait[1] = UnityEngine.Random.Range(1, MAX_TRAITS);
        curTrait[2] = UnityEngine.Random.Range(1, MAX_TRAITS);
        if (curTrait[2] == curTrait[1] && curTrait[2] == MAX_TRAITS - 1)
        {
            curTrait[2] = 1;
        }
        else if (curTrait[2] == curTrait[1])
        {
            curTrait[2] = curTrait[2] + 1;
        }

        ((Renderer)trait1.GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("t/t" + curTrait[1], typeof(Material));
        ((Renderer)trait2.GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("t/t" + curTrait[2], typeof(Material));
        menuCharacterCreate.SetActive(value: true);
        Randomize();
    }

    public virtual Item EmptyItem()
    {
        return new Item(0, 0, new int[6], 0f, null);
    }

    public virtual void ChangeRace(int dir)
    {
        if (dir == 1)
        {
            if (curRace < MAX_RACE)
            {
                curRace++;
            }
            else
            {
                curRace = 1;
            }
        }
        else if (curRace > 1)
        {
            curRace--;
        }
        else
        {
            curRace = MAX_RACE;
        }

        UpdateAppearance();
    }

    public virtual void ChangeHead(int dir)
    {
        if (dir == 1)
        {
            if (curHead < MAX_HEAD)
            {
                curHead++;
            }
            else
            {
                curHead = 1;
            }
        }
        else if (curHead > 1)
        {
            curHead--;
        }
        else
        {
            curHead = MAX_HEAD;
        }

        UpdateAppearance();
    }

    public virtual void ChangeColor(int dir)
    {
        if (dir == 1)
        {
            if (curColor < MAX_COLOR)
            {
                curColor++;
            }
            else
            {
                curColor = 1;
            }
        }
        else if (curColor > 1)
        {
            curColor--;
        }
        else
        {
            curColor = MAX_COLOR;
        }

        UpdateAppearance();
    }

    public virtual void ChangeBody(int dir)
    {
        if (dir == 1)
        {
            if (curBody < MAX_BODY)
            {
                curBody++;
            }
            else
            {
                curBody = 1;
            }
        }
        else if (curBody > 1)
        {
            curBody--;
        }
        else
        {
            curBody = MAX_BODY;
        }

        UpdateAppearance();
    }

    public virtual void Randomize()
    {
        curHead = UnityEngine.Random.Range(1, MAX_HEAD + 1);
        if (curHead == 2 || curHead == 5 || curHead == 7 || curHead == 9 || curHead == 14 || curHead == 16)
        {
            isMale = false;
        }
        else
        {
            isMale = true;
        }

        curColor = UnityEngine.Random.Range(1, MAX_COLOR + 1);
        curBody = UnityEngine.Random.Range(1, MAX_BODY + 1);
        curSkin = UnityEngine.Random.Range(1, MAX_SKIN + 1);
        UpdateAppearance();
        RandomizeStats();
        RandomizeName();
    }

    public virtual void RandomizeName()
    {
        curName = GetPrefix() + string.Empty + GetSuffix();
        txtName[0].text = curName;
    }

    public virtual string RandomName()
    {
        return null;
    }

    public virtual void UpdateAppearance()
    {
        int num = default(int);
        ((Renderer)playerBody[0].GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("r/r" + curRace + "h" + curVariant, typeof(Material));
        ((Renderer)playerBody[1].GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("hat/hat" + curHat, typeof(Material));
        ((Renderer)playerBody[2].GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("r/r" + curRace + "b", typeof(Material));
        ((Renderer)playerBody[3].GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("r/r" + curRace + "a", typeof(Material));
        ((Renderer)playerBody[4].GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("r/r" + curRace + "a", typeof(Material));
        ((Renderer)playerBody[5].GetComponent(typeof(Renderer))).material =
            (Material)Resources.Load("r/r" + curRace + "l", typeof(Material));
        UpdateCompanion();
        txtHead[0].text = "Variant: " + (curVariant + 1);
        txtColor[0].text = "Companion: " + curCompanion;
        txtBody[0].text = "Hat: " + curHat;
        txtRace[0].text = "Race: " + curRace;
    }

    public virtual void UpdateCompanion()
    {
        int num = default(int);
        for (num = 0; num < 10; num++)
        {
            if (num == curCompanion)
            {
                playerCompanion[num].SetActive(value: true);
            }
            else
            {
                playerCompanion[num].SetActive(value: false);
            }
        }
    }

    public virtual string GetHumanStory()
    {
        txtStory[0].text = GetHumanStatement();
        txtStory[1].text = GetHumanEffect();
        return null;
    }

    public virtual string GetHumanStatement()
    {
        int num = UnityEngine.Random.Range(0, 1);
        string result = null;
        if (num == 0)
        {
            result = txtName[0].text + "'s " + GetPerson() + " was a " + GetAdjective() + " " + GetProfession() + ".";
        }

        return result;
    }

    public virtual string GetHumanEffect()
    {
        int num = UnityEngine.Random.Range(0, 1);
        string result = null;
        if (num == 0)
        {
            result = "This caused " + txtName[0].text + " to become a " + GetProfession() + " in order to\n" +
                     GetVerb() + " " + GetHisHer() + " " + GetNoun();
        }

        return result;
    }

    public virtual string GetVerb()
    {
        int num = UnityEngine.Random.Range(0, 10);
        string result = null;
        int num2 = num;
        switch (num2)
        {
            case 0:
                result = "slay";
                break;
            case 1:
                result = "eat";
                break;
            case 2:
                result = "save";
                break;
            case 3:
                result = "play with";
                break;
            case 4:
                result = "careful";
                break;
            case 5:
                result = "help";
                break;
            case 6:
                result = "look after";
                break;
            case 7:
                result = "kiss";
                break;
            default:
                if (num2 == 7)
                {
                    result = "love";
                    break;
                }

                switch (num2)
                {
                    case 7:
                        result = "avenge";
                        break;
                    case 8:
                        result = "kill";
                        break;
                    case 9:
                        result = "reunite with";
                        break;
                }

                break;
        }

        return result;
    }

    public virtual string GetNoun()
    {
        int num = UnityEngine.Random.Range(0, 10);
        string result = null;
        int num2 = num;
        switch (num2)
        {
            case 0:
                result = "chickens";
                break;
            case 1:
                result = "pet pigs";
                break;
            case 2:
                result = "parents";
                break;
            case 3:
                result = "weapons";
                break;
            case 4:
                result = "grandpa";
                break;
            case 5:
                result = "mother";
                break;
            case 6:
                result = "farming tools";
                break;
            case 7:
                result = "childhood crush";
                break;
            default:
                if (num2 == 7)
                {
                    result = "father";
                    break;
                }

                switch (num2)
                {
                    case 7:
                        result = "rival";
                        break;
                    case 8:
                        result = "siblings";
                        break;
                    case 9:
                        result = "friends";
                        break;
                }

                break;
        }

        return result;
    }

    public virtual string GetHisHer()
    {
        string text = null;
        if (isMale)
        {
            return "his";
        }

        return "her";
    }

    public virtual string GetPerson()
    {
        int num = UnityEngine.Random.Range(0, 8);
        string result = null;
        switch (num)
        {
            case 0:
                result = "father";
                break;
            case 1:
                result = "mother";
                break;
            case 2:
                result = "best friend";
                break;
            case 3:
                result = "grandpa";
                break;
            case 4:
                result = "grandma";
                break;
            case 5:
                result = "idol";
                break;
            case 6:
                result = "rival";
                break;
            case 7:
                result = "lover";
                break;
        }

        return result;
    }

    public virtual string GetAdjective()
    {
        int num = UnityEngine.Random.Range(0, 10);
        string result = null;
        int num2 = num;
        switch (num2)
        {
            case 0:
                result = "brave";
                break;
            case 1:
                result = "adventurous";
                break;
            case 2:
                result = "creative";
                break;
            case 3:
                result = "lazy";
                break;
            case 4:
                result = "careful";
                break;
            case 5:
                result = "terrible";
                break;
            case 6:
                result = "grumpy";
                break;
            case 7:
                result = "dangerous";
                break;
            default:
                if (num2 == 7)
                {
                    result = "dangerous";
                    break;
                }

                switch (num2)
                {
                    case 7:
                        result = "crazy";
                        break;
                    case 8:
                        result = "valiant";
                        break;
                    case 9:
                        result = "wicked";
                        break;
                }

                break;
        }

        return result;
    }

    public virtual string GetProfession()
    {
        int num = UnityEngine.Random.Range(0, 10);
        string result = null;
        int num2 = num;
        switch (num2)
        {
            case 0:
                result = "Cook";
                break;
            case 1:
                result = "Bard";
                break;
            case 2:
                result = "Artist";
                break;
            case 3:
                result = "Adventurer";
                break;
            case 4:
                result = "Merchant";
                break;
            case 5:
                result = "Ruler";
                break;
            case 6:
                result = "Inn Keeper";
                break;
            case 7:
                result = "Murderer";
                break;
            default:
                if (num2 == 7)
                {
                    result = "Oaf";
                    break;
                }

                switch (num2)
                {
                    case 7:
                        result = "Knight";
                        break;
                    case 8:
                        result = "Dragon Slayer";
                        break;
                    case 9:
                        result = "Farmer";
                        break;
                }

                break;
        }

        return result;
    }

    public virtual void RandomizeStats()
    {
        int num = 0;
        int num2 = 0;
        growthStatGood1 = UnityEngine.Random.Range(0, 4);
        growthStatGood2 = UnityEngine.Random.Range(0, 4);
        if (growthStatGood2 == growthStatGood1)
        {
            if (growthStatGood2 < 3)
            {
                growthStatGood2++;
            }
            else
            {
                growthStatGood2 = 0;
            }
        }

        growthStatBad = UnityEngine.Random.Range(0, 4);
        for (num = 0; num < 4; num++)
        {
            playerStat[num] = 3;
            if (growthStatGood1 == num)
            {
                playerStat[num]++;
            }

            if (growthStatGood2 == num)
            {
                playerStat[num]++;
            }

            if (growthStatBad == num)
            {
                playerStat[num]--;
            }
        }

        playerStat[0] = playerStat[0] + 2;
        for (num = 0; num < 4; num++)
        {
            txtStat[num].text = GetStatName(num) + ": " + playerStat[num];
            if (playerStat[num] > 3)
            {
                ((Renderer)txtStat[num].GetComponent(typeof(Renderer))).material.color = Color.green;
            }
            else if (playerStat[num] < 3)
            {
                ((Renderer)txtStat[num].GetComponent(typeof(Renderer))).material.color = Color.red;
            }
            else
            {
                ((Renderer)txtStat[num].GetComponent(typeof(Renderer))).material.color = Color.white;
            }
        }
    }

    public virtual void SaveCharacter()
    {
        int num = default(int);
        for (num = 0; num < 31; num++)
        {
            GameScript.inventory[num] = EmptyItem();
        }

        for (num = 0; num < 15; num++)
        {
            GameScript.npcInventory[num] = EmptyItem();
        }

        PlayerPrefs.SetInt("cLevel", 1);
        if (GetComponent<NetworkView>().isMine)
        {
            PlayerPrefs.SetString("cName", txtName[0].text);
        }

        for (num = 0; num < 6; num++)
        {
            PlayerPrefs.SetInt("s" + num, curStat[num]);
        }

        if (curTrait[1] == 6 || curTrait[2] == 6)
        {
            playerStat[1] = playerStat[1] + 2;
            playerStat[2] = playerStat[2] - 1;
        }

        if (curTrait[1] == 7 || curTrait[2] == 7)
        {
            playerStat[1] = playerStat[1] - 1;
            playerStat[0] = playerStat[0] + 4;
        }

        if (curTrait[1] == 8 || curTrait[2] == 8)
        {
            playerStat[2] = playerStat[2] + 2;
        }

        if (curTrait[1] == 9 || curTrait[2] == 9)
        {
            playerStat[0] = playerStat[0] + 2;
        }

        if (curTrait[1] == 11 || curTrait[2] == 11)
        {
            playerStat[3] = playerStat[3] + 4;
        }

        pVariant = curVariant;
        pBody = curBody;
        pRace = curRace;
        pHat = curHat;
        companion = curCompanion;
        curName = txtName[0].text;
        pColor = curColor;
        PlayerPrefs.SetInt("hair", curHead);
        PlayerPrefs.SetInt("body", curBody);
    }

    public virtual void OnDisconnectedFromServer()
    {
        StartCoroutine(Done());
    }

    public virtual void OnConnectedToServer()
    {
        MonoBehaviour.print("Connected to Host. You are a Client.");
        txtConnecting.text = "Successfully Connected!";
        doneConnecting = 1;
        Blocker();
    }

    public virtual void MenuLobby()
    {
        menuLobby.SetActive(value: true);
        menuCharacterCreate.SetActive(value: false);
        buttonPVP.SetActive(value: true);
        RefreshLobby(Network.connections.Length);
        txtHosting.gameObject.SetActive(value: true);
        txtHosting.text = "Hosting on Port " + port;
    }

    public virtual void OnServerInitialized()
    {
        GetComponent<NetworkView>().RPC("SetPlayer", RPCMode.All);
    }

    public virtual void LoadStats()
    {
        int num = default(int);
        accountEXP = PlayerPrefs.GetInt("aEXP");
        for (num = 0; num < 13; num++)
        {
            txtStats[num].text = string.Empty + PlayerPrefs.GetInt("stat" + num);
        }
    }

    public virtual string GetStatsName(int a)
    {
        string text = null;
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
                return "Quests Completed";
            case 11:
                return "Items Bought";
            case 12:
                return "Bosses Defeated";
            default:
                return string.Empty;
        }
    }

    public virtual string GetStatName(int a)
    {
        string text = null;
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

    public virtual void Delete()
    {
        PlayerPrefs.DeleteAll();
        LoadStats();
        Application.Quit();
    }

    public virtual string GetMaleName()
    {
        int num = UnityEngine.Random.Range(0, 54);
        string result = null;
        switch (num)
        {
            case 0:
                result = string.Empty;
                break;
            case 1:
                result = string.Empty;
                break;
            case 2:
                result = string.Empty;
                break;
            case 3:
                result = string.Empty;
                break;
            case 4:
                result = string.Empty;
                break;
            case 5:
                result = string.Empty;
                break;
            case 6:
                result = string.Empty;
                break;
            case 7:
                result = string.Empty;
                break;
            case 8:
                result = string.Empty;
                break;
            case 9:
                result = string.Empty;
                break;
            case 10:
                result = string.Empty;
                break;
            case 11:
                result = string.Empty;
                break;
            case 12:
                result = string.Empty;
                break;
            case 13:
                result = string.Empty;
                break;
            case 14:
                result = string.Empty;
                break;
            case 15:
                result = string.Empty;
                break;
            case 16:
                result = string.Empty;
                break;
            case 17:
                result = string.Empty;
                break;
            case 18:
                result = string.Empty;
                break;
            case 19:
                result = string.Empty;
                break;
            case 20:
                result = string.Empty;
                break;
            case 21:
                result = string.Empty;
                break;
            case 22:
                result = string.Empty;
                break;
            case 23:
                result = string.Empty;
                break;
            case 24:
                result = string.Empty;
                break;
            case 25:
                result = string.Empty;
                break;
            case 26:
                result = string.Empty;
                break;
            case 27:
                result = string.Empty;
                break;
            case 28:
                result = string.Empty;
                break;
            case 29:
                result = string.Empty;
                break;
            case 30:
                result = string.Empty;
                break;
            case 31:
                result = string.Empty;
                break;
            case 32:
                result = string.Empty;
                break;
            case 33:
                result = string.Empty;
                break;
            case 34:
                result = string.Empty;
                break;
            case 35:
                result = string.Empty;
                break;
            case 36:
                result = string.Empty;
                break;
            case 37:
                result = string.Empty;
                break;
            case 38:
                result = string.Empty;
                break;
            case 39:
                result = string.Empty;
                break;
            case 40:
                result = string.Empty;
                break;
            case 41:
                result = string.Empty;
                break;
            case 42:
                result = string.Empty;
                break;
            case 43:
                result = string.Empty;
                break;
            case 44:
                result = string.Empty;
                break;
            case 45:
                result = string.Empty;
                break;
            case 46:
                result = string.Empty;
                break;
            case 47:
                result = string.Empty;
                break;
            case 48:
                result = string.Empty;
                break;
            case 49:
                result = string.Empty;
                break;
            case 50:
                result = string.Empty;
                break;
            case 51:
                result = string.Empty;
                break;
            case 52:
                result = string.Empty;
                break;
            case 53:
                result = string.Empty;
                break;
        }

        return result;
    }

    public virtual string GetFemaleName()
    {
        int num = UnityEngine.Random.Range(0, 54);
        string result = null;
        switch (num)
        {
            case 0:
                result = string.Empty;
                break;
            case 1:
                result = string.Empty;
                break;
            case 2:
                result = string.Empty;
                break;
            case 3:
                result = string.Empty;
                break;
            case 4:
                result = string.Empty;
                break;
            case 5:
                result = string.Empty;
                break;
            case 6:
                result = string.Empty;
                break;
            case 7:
                result = string.Empty;
                break;
            case 8:
                result = string.Empty;
                break;
            case 9:
                result = string.Empty;
                break;
            case 10:
                result = string.Empty;
                break;
            case 11:
                result = string.Empty;
                break;
            case 12:
                result = string.Empty;
                break;
            case 13:
                result = string.Empty;
                break;
            case 14:
                result = string.Empty;
                break;
            case 15:
                result = string.Empty;
                break;
            case 16:
                result = string.Empty;
                break;
            case 17:
                result = string.Empty;
                break;
            case 18:
                result = string.Empty;
                break;
            case 19:
                result = string.Empty;
                break;
            case 20:
                result = string.Empty;
                break;
            case 21:
                result = string.Empty;
                break;
            case 22:
                result = string.Empty;
                break;
            case 23:
                result = string.Empty;
                break;
            case 24:
                result = string.Empty;
                break;
            case 25:
                result = string.Empty;
                break;
            case 26:
                result = string.Empty;
                break;
            case 27:
                result = string.Empty;
                break;
            case 28:
                result = string.Empty;
                break;
            case 29:
                result = string.Empty;
                break;
            case 30:
                result = string.Empty;
                break;
            case 31:
                result = string.Empty;
                break;
            case 32:
                result = string.Empty;
                break;
            case 33:
                result = string.Empty;
                break;
            case 34:
                result = string.Empty;
                break;
            case 35:
                result = string.Empty;
                break;
            case 36:
                result = string.Empty;
                break;
            case 37:
                result = string.Empty;
                break;
            case 38:
                result = string.Empty;
                break;
            case 39:
                result = string.Empty;
                break;
            case 40:
                result = string.Empty;
                break;
            case 41:
                result = string.Empty;
                break;
            case 42:
                result = string.Empty;
                break;
            case 43:
                result = string.Empty;
                break;
            case 44:
                result = string.Empty;
                break;
            case 45:
                result = string.Empty;
                break;
            case 46:
                result = string.Empty;
                break;
            case 47:
                result = string.Empty;
                break;
            case 48:
                result = string.Empty;
                break;
            case 49:
                result = string.Empty;
                break;
            case 50:
                result = string.Empty;
                break;
            case 51:
                result = string.Empty;
                break;
            case 52:
                result = string.Empty;
                break;
            case 53:
                result = string.Empty;
                break;
        }

        return result;
    }

    public virtual string GetPrefix()
    {
        int num = UnityEngine.Random.Range(0, 16);
        string result = null;
        switch (num)
        {
            case 0:
                result = "Wys";
                break;
            case 1:
                result = "Wos";
                break;
            case 2:
                result = "Rath";
                break;
            case 3:
                result = "Fel";
                break;
            case 4:
                result = "Law";
                break;
            case 5:
                result = "Red";
                break;
            case 6:
                result = "Gar";
                break;
            case 7:
                result = "Len";
                break;
            case 8:
                result = "Lod";
                break;
            case 9:
                result = "Eli";
                break;
            case 10:
                result = "Ral";
                break;
            case 11:
                result = "Grog";
                break;
            case 12:
                result = "Lel";
                break;
            case 13:
                result = "Syv";
                break;
            case 14:
                result = "Beo";
                break;
            case 15:
                result = "Nil";
                break;
        }

        return result;
    }

    public virtual string GetSuffix()
    {
        int num = UnityEngine.Random.Range(0, 16);
        string result = null;
        switch (num)
        {
            case 0:
                result = "gar";
                break;
            case 1:
                result = "gan";
                break;
            case 2:
                result = "wulf";
                break;
            case 3:
                result = "hart";
                break;
            case 4:
                result = "even";
                break;
            case 5:
                result = "ke";
                break;
            case 6:
                result = "vand";
                break;
            case 7:
                result = "enian";
                break;
            case 8:
                result = "rend";
                break;
            case 9:
                result = "roth";
                break;
            case 10:
                result = "lla";
                break;
            case 11:
                result = "ilia";
                break;
            case 12:
                result = "anna";
                break;
            case 13:
                result = "enne";
                break;
            case 14:
                result = "nor";
                break;
            case 15:
                result = "nen";
                break;
        }

        return result;
    }

    [RPC]
    public virtual void SetPlayer()
    {
        if (curPlayers < 4)
        {
            txtPlayer[curPlayers].text = "Player " + curPlayers;
            curPlayers++;
        }
    }

    public virtual string GetRaceDesc(int a)
    {
        string text = null;
        switch (a)
        {
            case 0:
                text = "\n";
                break;
            case 1:
                text = string.Empty;
                break;
            case 2:
                text = string.Empty;
                break;
            case 3:
                text = string.Empty;
                break;
            case 4:
                text = string.Empty;
                break;
            case 5:
                text = string.Empty;
                break;
        }

        return null;
    }

    public virtual string GetTraitName(int id)
    {
        string text = null;
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

    public virtual string GetTraitDesc(int id)
    {
        string text = null;
        switch (id)
        {
            case 1:
                return "50% chance your Axe\nwill not lose durability.";
            case 2:
                return "50% chance your Pick\nwill not lose durability.";
            case 3:
                return "50% chance to collect \ntwice as many\ningredients when\ngathering.";
            case 4:
                return "50% chance to\ncraft Big Potions with\nonly basic ingredients.";
            case 5:
                return "+10 LCK when crafting\nWeapons or Gear";
            case 6:
                return "+2 ATK\n-1 DEF.";
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
                return "Allows you to open\nGolden Chests";
            case 13:
                return "Has a chance to steal gold\nwhen walking by NPCs.";
            default:
                return "NULL";
        }
    }

    public virtual string GetItemName(int id)
    {
        string text = null;
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
                return "Iron Arrow";
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
        string text = null;
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
}