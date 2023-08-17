using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class MenuScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ApplyRes_00241686 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024pp_00241687;

			internal int _0024pp2_00241688;

			internal MenuScript _0024self__00241689;

			public _0024(MenuScript self_)
			{
				_0024self__00241689 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024pp_00241687 = _0024self__00241689.GetRes1();
					_0024pp2_00241688 = _0024self__00241689.GetRes2();
					if (Screen.fullScreen)
					{
						_0024self__00241689.y = true;
					}
					else
					{
						_0024self__00241689.y = false;
					}
					Screen.SetResolution(_0024pp_00241687, _0024pp2_00241688, _0024self__00241689.y);
					PlayerPrefs.SetInt("res", curRes);
					if (_0024self__00241689.y)
					{
						PlayerPrefs.SetInt("FULLSCREEN", 1);
					}
					else
					{
						PlayerPrefs.SetInt("FULLSCREEN", 0);
					}
					_0024self__00241689.bApply.SetActive(false);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241689.DetectRes();
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MenuScript _0024self__00241690;

		public _0024ApplyRes_00241686(MenuScript self_)
		{
			_0024self__00241690 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241690);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Statistics_00241691 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024pLevel_00241692;

			internal float _0024curEXP_00241693;

			internal float _0024cap_00241694;

			internal float _0024percent_00241695;

			internal float _0024_0024635_00241696;

			internal Vector3 _0024_0024636_00241697;

			internal MenuScript _0024self__00241698;

			public _0024(MenuScript self_)
			{
				_0024self__00241698 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0200: Unknown result type (might be due to invalid IL or missing references)
				//IL_0201: Unknown result type (might be due to invalid IL or missing references)
				//IL_0206: Unknown result type (might be due to invalid IL or missing references)
				//IL_022e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0233: Unknown result type (might be due to invalid IL or missing references)
				//IL_0234: Unknown result type (might be due to invalid IL or missing references)
				//IL_023a: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241698.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241698.fade.fadeIn();
					_0024self__00241698.txtHighScore[0].text = string.Empty + (object)PlayerPrefs.GetInt("hScore");
					_0024self__00241698.txtHighScore[1].text = _0024self__00241698.txtHighScore[0].text;
					_0024pLevel_00241692 = _0024self__00241698.GetPlayerLevel();
					_0024curEXP_00241693 = _0024self__00241698.GetCurEXP(_0024pLevel_00241692);
					_0024cap_00241694 = _0024self__00241698.GetLevelCap(_0024pLevel_00241692);
					_0024percent_00241695 = _0024curEXP_00241693 / _0024cap_00241694 * 8.5f;
					MonoBehaviour.print((object)("Current Level:" + (object)_0024pLevel_00241692 + " Total EXP:" + (object)accountEXP + " Next Level:" + (object)_0024curEXP_00241693 + "/" + (object)_0024cap_00241694));
					_0024self__00241698.menuMain.SetActive(false);
					_0024self__00241698.menuStats.SetActive(true);
					_0024self__00241698.txtAccountLevel.text = "Player Level : " + (object)_0024pLevel_00241692;
					_0024self__00241698.txtCurEXP.text = (object)_0024curEXP_00241693 + "/" + (object)_0024cap_00241694;
					float num = (_0024_0024635_00241696 = _0024percent_00241695);
					Vector3 val = (_0024_0024636_00241697 = _0024self__00241698.barEXP.transform.localScale);
					float num2 = (_0024_0024636_00241697.x = _0024_0024635_00241696);
					Vector3 val3 = (_0024self__00241698.barEXP.transform.localScale = _0024_0024636_00241697);
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

		internal MenuScript _0024self__00241699;

		public _0024Statistics_00241691(MenuScript self_)
		{
			_0024self__00241699 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241699);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Play_00241700 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024useNat_00241701;

			internal MenuScript _0024self__00241702;

			public _0024(MenuScript self_)
			{
				_0024self__00241702 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241702.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241702.fade.fadeIn();
					_0024self__00241702.enteringIP = false;
					_0024self__00241702.menuMain.SetActive(false);
					_0024self__00241702.menuMultiplayer.SetActive(false);
					if (multiplayer == 1)
					{
						try
						{
							_0024self__00241702.port = int.Parse(_0024self__00241702.txtPort.text);
						}
						catch (Exception)
						{
							_0024self__00241702.port = 7777;
						}
						_0024useNat_00241701 = !Network.HavePublicAddress();
						Network.InitializeServer(10, _0024self__00241702.port, false);
						MonoBehaviour.print((object)("Initialized Server" + _0024self__00241702.txtIP[0].text + " Port:" + (object)_0024self__00241702.port));
					}
					else if (multiplayer != 2)
					{
					}
					_0024self__00241702.menuCharacterCreate.SetActive(true);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MenuScript _0024self__00241703;

		public _0024Play_00241700(MenuScript self_)
		{
			_0024self__00241703 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241703);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Options_00241704 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MenuScript _0024self__00241705;

			public _0024(MenuScript self_)
			{
				_0024self__00241705 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241705.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241705.fade.fadeIn();
					_0024self__00241705.menuMain.SetActive(false);
					_0024self__00241705.menuOptions.SetActive(true);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MenuScript _0024self__00241706;

		public _0024Options_00241704(MenuScript self_)
		{
			_0024self__00241706 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241706);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RefreshServers_00241707 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241708;

			internal MenuScript _0024self__00241709;

			public _0024(MenuScript self_)
			{
				_0024self__00241709 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241708 = default(int);
					MonoBehaviour.print((object)((object)numServers + " is num servers"));
					for (_0024i_00241708 = 0; _0024i_00241708 < 4; _0024i_00241708++)
					{
						_0024self__00241709.server[_0024i_00241708].SetActive(false);
						serverIP[_0024i_00241708] = PlayerPrefs.GetString("serverIP" + (object)_0024i_00241708);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					for (_0024i_00241708 = 0; _0024i_00241708 < 4; _0024i_00241708++)
					{
						if (!string.IsNullOrEmpty(serverIP[_0024i_00241708]))
						{
							_0024self__00241709.server[_0024i_00241708].SetActive(true);
							_0024self__00241709.txtServerIP[_0024i_00241708].text = string.Empty + serverIP[_0024i_00241708];
						}
						else
						{
							_0024self__00241709.server[_0024i_00241708].SetActive(false);
						}
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MenuScript _0024self__00241710;

		public _0024RefreshServers_00241707(MenuScript self_)
		{
			_0024self__00241710 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241710);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Done_00241711 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MenuScript _0024self__00241712;

			public _0024(MenuScript self_)
			{
				_0024self__00241712 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241712.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241712.fade.fadeIn();
					_0024self__00241712.bApply.SetActive(false);
					multiplayer = 0;
					_0024self__00241712.menuMain.SetActive(true);
					_0024self__00241712.menuStats.SetActive(false);
					_0024self__00241712.menuLobby.SetActive(false);
					_0024self__00241712.menuCharacterCreate.SetActive(false);
					_0024self__00241712.menuOptions.SetActive(false);
					_0024self__00241712.menuMultiplayer.SetActive(false);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MenuScript _0024self__00241713;

		public _0024Done_00241711(MenuScript self_)
		{
			_0024self__00241713 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241713);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ReadyGame_00241714 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MenuScript _0024self__00241715;

			public _0024(MenuScript self_)
			{
				_0024self__00241715 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241715.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241715.fade.fadeIn();
					_0024self__00241715.SaveCharacter();
					if (multiplayer == 1)
					{
						if (_0024self__00241715.noLobby)
						{
							((MonoBehaviour)_0024self__00241715).StartCoroutine_Auto(_0024self__00241715.BeginGame());
						}
						else
						{
							_0024self__00241715.MenuLobby();
						}
					}
					else if (multiplayer == 2)
					{
						_0024self__00241715.MenuLobby();
					}
					else
					{
						((MonoBehaviour)_0024self__00241715).StartCoroutine_Auto(_0024self__00241715.BeginGame());
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MenuScript _0024self__00241716;

		public _0024ReadyGame_00241714(MenuScript self_)
		{
			_0024self__00241716 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241716);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024BeginGame_00241717 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MenuScript _0024self__00241718;

			public _0024(MenuScript self_)
			{
				_0024self__00241718 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					PlayerPrefs.SetInt("stat0", PlayerPrefs.GetInt("stat0") + 1);
					_0024self__00241718.fade.fadeOut();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (multiplayer == 2)
					{
						_0024self__00241718.SaveCharacter();
					}
					Application.LoadLevel(1);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MenuScript _0024self__00241719;

		public _0024BeginGame_00241717(MenuScript self_)
		{
			_0024self__00241719 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241719);
		}
	}

	public GameObject bApply;

	public TextMesh txtHosting;

	public TextMesh txtRes;

	public TextMesh txtVolume;

	[NonSerialized]
	public static int curScore;

	[NonSerialized]
	public static int curRes;

	public TextMesh[] txtHighScore;

	private int port;

	public TextMesh txtPort;

	private bool enteringPort;

	public GameObject raceSelect;

	private bool writing;

	public GameObject[] shine;

	public GameObject menuRace;

	[NonSerialized]
	public static int[] startingItemID = new int[3];

	public GameObject[] startingItems;

	public TextMesh txtRaceName;

	public TextMesh txtRaceStats;

	public TextMesh txtRaceDescription;

	public TextMesh[] txtStory;

	private int selectedRace;

	public TextMesh txtCurEXP;

	public GameObject barEXP;

	public TextMesh txtAccountLevel;

	[NonSerialized]
	public static int accountEXP;

	public GameObject bStartGame;

	public GameObject cursorInfo;

	public TextMesh txtMenuName;

	public TextMesh txtMenuDesc;

	public TextMesh txtConnecting;

	public GameObject menuConnecting;

	private int doneConnecting;

	private bool isMale;

	[NonSerialized]
	public static string curName;

	[NonSerialized]
	public static int multiplayer;

	[NonSerialized]
	public static string ip = "192.168.0.2";

	[NonSerialized]
	public static int growthStatGood1;

	[NonSerialized]
	public static int growthStatGood2;

	[NonSerialized]
	public static int growthStatBad;

	[NonSerialized]
	public static int pHead;

	[NonSerialized]
	public static int pBody;

	[NonSerialized]
	public static int pColor;

	[NonSerialized]
	public static int pRace;

	[NonSerialized]
	public static int pOffhand;

	[NonSerialized]
	public static int[] playerStat = new int[6];

	private FadeInOut fade;

	private int curPlayers;

	public TextMesh[] txtPlayer;

	public TextMesh[] txtRace;

	public GameObject menuLobby;

	public TextMesh[] txtStats;

	public GameObject[] server;

	[NonSerialized]
	public static string[] serverIP = new string[4];

	[NonSerialized]
	public static int numServers;

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

	[NonSerialized]
	public static int[] curTrait = new int[3];

	private bool enteringIP;

	public Texture2D cursorTexture;

	private CursorMode cursorMode;

	private Vector2 hotSpot;

	private int mask;

	private Ray rayCursor;

	private RaycastHit cursorHit;

	private int[] raceUnlocked;

	private bool isSelectingRace;

	[NonSerialized]
	public static int volume;

	private int FULLSCREEN;

	private bool y;

	private bool ForceFullscreen;

	public MenuScript()
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		txtHighScore = (TextMesh[])(object)new TextMesh[2];
		shine = (GameObject[])(object)new GameObject[12];
		startingItems = (GameObject[])(object)new GameObject[3];
		txtStory = (TextMesh[])(object)new TextMesh[2];
		txtPlayer = (TextMesh[])(object)new TextMesh[4];
		txtRace = (TextMesh[])(object)new TextMesh[2];
		txtStats = (TextMesh[])(object)new TextMesh[16];
		server = (GameObject[])(object)new GameObject[4];
		txtServerIP = (TextMesh[])(object)new TextMesh[4];
		txtIP = (TextMesh[])(object)new TextMesh[2];
		txtSlot = (TextMesh[])(object)new TextMesh[3];
		txtSlot2 = (TextMesh[])(object)new TextMesh[3];
		txtName = (TextMesh[])(object)new TextMesh[2];
		txtHead = (TextMesh[])(object)new TextMesh[2];
		txtColor = (TextMesh[])(object)new TextMesh[2];
		txtBody = (TextMesh[])(object)new TextMesh[2];
		txtStat = (TextMesh[])(object)new TextMesh[12];
		playerBody = (GameObject[])(object)new GameObject[7];
		statCap = 20;
		MAX_HEAD = 14;
		MAX_COLOR = 3;
		MAX_BODY = 6;
		MAX_SKIN = 1;
		MAX_TRAITS = 13;
		MAX_RACE = 1;
		curStat = new int[6];
		cursorMode = (CursorMode)0;
		hotSpot = new Vector2(8f, 8f);
		mask = 1024;
		raceUnlocked = new int[13];
	}

	public override void DetectRes()
	{
		if (!(Camera.main.aspect < 1.7f))
		{
			Debug.Log((object)"16:9");
			Camera.main.orthographicSize = 12f;
		}
		else if (!(Camera.main.aspect < 1.5f))
		{
			Debug.Log((object)"3:2");
			Camera.main.orthographicSize = 13f;
		}
		else if (!(Camera.main.aspect < 1.3f))
		{
			Debug.Log((object)"4:3");
			Camera.main.orthographicSize = 14.5f;
		}
		else if (!(Camera.main.aspect < 1.25f))
		{
			Debug.Log((object)"5:4");
			Camera.main.orthographicSize = 15.2f;
		}
	}

	public override void Awake()
	{
		DetectRes();
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
		txtRes.text = (object)GetRes1() + "x" + (object)GetRes2();
		volume = PlayerPrefs.GetInt("volume");
		txtVolume.text = "Audio: " + (object)volume;
		curRace = 1;
		SetStartingItemIDs(curRace);
		multiplayer = 0;
		int num = default(int);
		accountEXP = PlayerPrefs.GetInt("aEXP");
		for (num = 0; num < 12; num++)
		{
			if (PlayerPrefs.GetInt("rU") > 0)
			{
				raceUnlocked[num] = 1;
			}
			else
			{
				raceUnlocked[num] = 0;
			}
		}
		raceUnlocked[0] = 1;
		raceUnlocked[1] = 1;
		LoadStats();
		fade = (FadeInOut)(object)((Component)Camera.main).gameObject.GetComponent("FadeInOut");
		numServers = 0;
		for (num = 0; num < 4; num++)
		{
			serverIP[num] = PlayerPrefs.GetString("serverIP" + (object)num);
			if (serverIP[num] != string.Empty)
			{
				numServers++;
			}
		}
	}

	public override void SetInfoText(int slot)
	{
		cursorInfo.SetActive(true);
		txtMenuName.text = GetTraitName(curTrait[slot]);
		txtMenuDesc.text = GetTraitDesc(curTrait[slot]);
	}

	public override void Update()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected O, but got Unknown
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		rayCursor = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(rayCursor, ref cursorHit, 25f, mask))
		{
			MonoBehaviour.print((object)"HIT");
			if (((Component)((RaycastHit)(ref cursorHit)).transform).gameObject.layer == 10)
			{
				MonoBehaviour.print((object)"HIT2");
				int infoText = int.Parse(((Object)((Component)((RaycastHit)(ref cursorHit)).transform).gameObject).name);
				SetInfoText(infoText);
			}
		}
		else
		{
			cursorInfo.SetActive(false);
		}
		if (Input.GetMouseButtonDown(0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, ref hit, 70f))
			{
				((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/gather", typeof(AudioClip)));
				GameObject gameObject = ((Component)((RaycastHit)(ref hit)).transform).gameObject;
				if (gameObject.tag == "shine")
				{
					SelectRace(((Object)gameObject).name);
					MonoBehaviour.print((object)"RACE");
				}
				switch (((Object)gameObject).name)
				{
				case "bSingleplayer":
					multiplayer = 1;
					noLobby = true;
					((MonoBehaviour)this).StartCoroutine_Auto(Play());
					Randomize();
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
					((MonoBehaviour)this).StartCoroutine_Auto(Options());
					break;
				case "bDone":
					((MonoBehaviour)this).StartCoroutine_Auto(Done());
					break;
				case "bDone2":
					Done2();
					break;
				case "bHost":
					multiplayer = 1;
					((MonoBehaviour)this).StartCoroutine_Auto(Play());
					break;
				case "bConnect":
					((MonoBehaviour)this).StartCoroutine_Auto(Play());
					multiplayer = 2;
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
					((MonoBehaviour)this).StartCoroutine_Auto(Statistics());
					break;
				case "bCards":
					Cards();
					break;
				case "bBack":
					((MonoBehaviour)this).StartCoroutine_Auto(Done());
					Network.Disconnect();
					break;
				case "bBackR":
					menuRace.SetActive(false);
					UpdateAppearance();
					break;
				case "bStart":
					((Component)this).networkView.RPC("BeginGame", (RPCMode)2, new object[0]);
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
				case "enterName":
					EnterName();
					break;
				case "bCreate":
					((MonoBehaviour)this).StartCoroutine_Auto(ReadyGame());
					break;
				case "bRefresh":
					((MonoBehaviour)this).StartCoroutine_Auto(RefreshServers());
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
					((MonoBehaviour)this).StartCoroutine_Auto(ApplyRes());
					break;
				}
			}
		}
		if (Input.GetMouseButtonDown(1))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, ref hit, 70f))
			{
				((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/CLICK(2)", typeof(AudioClip)));
				GameObject gameObject2 = ((Component)((RaycastHit)(ref hit)).transform).gameObject;
				switch (((Object)gameObject2).name)
				{
				case "bPlay":
					((MonoBehaviour)this).StartCoroutine_Auto(Play());
					break;
				case "bOptions":
					((MonoBehaviour)this).StartCoroutine_Auto(Options());
					break;
				case "bDone":
					((MonoBehaviour)this).StartCoroutine_Auto(Done());
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
					((MonoBehaviour)this).StartCoroutine_Auto(Done());
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
				case "bRandomize":
					Randomize();
					break;
				case "bRes":
					UpdateRes(1);
					break;
				}
			}
		}
		if (enteringName)
		{
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator((object)Input.inputString);
			while (enumerator.MoveNext())
			{
				char c = RuntimeServices.UnboxChar(enumerator.Current);
				if (c == "\b"[0])
				{
					if (txtName[0].text.Length != 0)
					{
						txtName[0].text = txtName[0].text.Substring(0, txtName[0].text.Length - 1);
					}
				}
				else if (c == "\n"[0] || c == "\r"[0])
				{
					enteringName = false;
				}
				else if (txtName[0].text.Length < 10)
				{
					txtName[0].text = txtName[0].text + (object)c;
					UnityRuntimeServices.Update(enumerator, (object)c);
				}
			}
		}
		if (enteringIP)
		{
			IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator((object)Input.inputString);
			while (enumerator2.MoveNext())
			{
				char c2 = RuntimeServices.UnboxChar(enumerator2.Current);
				if (c2 == "\b"[0])
				{
					if (txtIP[0].text.Length != 0)
					{
						txtIP[0].text = txtIP[0].text.Substring(0, txtIP[0].text.Length - 1);
					}
				}
				else if (c2 == "\n"[0] || c2 == "\r"[0])
				{
					enteringIP = false;
				}
				else if (txtIP[0].text.Length < 20)
				{
					txtIP[0].text = txtIP[0].text + (object)c2;
					UnityRuntimeServices.Update(enumerator2, (object)c2);
				}
				ip = txtIP[0].text;
			}
		}
		if (!enteringPort)
		{
			return;
		}
		IEnumerator enumerator3 = UnityRuntimeServices.GetEnumerator((object)Input.inputString);
		while (enumerator3.MoveNext())
		{
			char c3 = RuntimeServices.UnboxChar(enumerator3.Current);
			if (c3 == "\b"[0])
			{
				if (txtPort.text.Length != 0)
				{
					txtPort.text = txtPort.text.Substring(0, txtPort.text.Length - 1);
				}
			}
			else if (c3 == "\n"[0] || c3 == "\r"[0])
			{
				enteringPort = false;
			}
			else if (txtPort.text.Length < 20)
			{
				txtPort.text += (object)c3;
				UnityRuntimeServices.Update(enumerator3, (object)c3);
			}
			try
			{
				port = int.Parse(txtPort.text);
			}
			catch (Exception)
			{
			}
		}
	}

	public override void Port(int a)
	{
		multiplayer = 2;
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

	public override void Blocker()
	{
		if (doneConnecting != 0)
		{
			if (doneConnecting == 1)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Play());
				menuConnecting.SetActive(false);
				doneConnecting = 0;
			}
			else
			{
				menuConnecting.SetActive(false);
				doneConnecting = 0;
			}
		}
	}

	public override IEnumerator ApplyRes()
	{
		return new _0024ApplyRes_00241686(this).GetEnumerator();
	}

	public override void UpdateRes(int dir)
	{
		bApply.SetActive(true);
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
		txtRes.text = (object)GetRes1() + "x" + (object)GetRes2();
	}

	public override int GetRes1()
	{
		int num = default(int);
		return curRes switch
		{
			0 => 640, 
			1 => 800, 
			2 => 1024, 
			3 => 1152, 
			4 => 1280, 
			5 => 1280, 
			6 => 1280, 
			7 => 1366, 
			8 => 1400, 
			9 => 1600, 
			10 => 1600, 
			11 => 1920, 
			_ => num, 
		};
	}

	public override int GetRes2()
	{
		int num = default(int);
		return curRes switch
		{
			0 => 480, 
			1 => 600, 
			2 => 768, 
			3 => 864, 
			4 => 720, 
			5 => 960, 
			6 => 1024, 
			7 => 768, 
			8 => 1050, 
			9 => 900, 
			10 => 1024, 
			11 => 1080, 
			_ => num, 
		};
	}

	public override void TryConnect()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		txtConnecting.text = "Connecting to " + ip + " port " + (object)port;
		Network.Connect(ip, port);
		menuConnecting.SetActive(true);
	}

	public override void OnFailedToConnect()
	{
		txtConnecting.text = "Failed to connect to " + ip;
		doneConnecting = -1;
	}

	public override void AddServer()
	{
		if (numServers < 3)
		{
			MonoBehaviour.print((object)"adding server");
			PlayerPrefs.SetString("serverIP" + (object)numServers, ip);
			serverIP[numServers] = ip;
			numServers++;
			((MonoBehaviour)this).StartCoroutine_Auto(RefreshServers());
		}
	}

	public override void RaceMenu()
	{
		selectedRace = curRace;
		RefreshRaceMenu();
		menuRace.SetActive(true);
	}

	public override void RefreshRaceMenu()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		int num = default(int);
		for (num = 0; num < 12; num++)
		{
			if (raceUnlocked[num] > 0)
			{
				shine[num].renderer.material = (Material)Resources.Load("sh1");
				shine[num].gameObject.tag = "shine";
			}
			else
			{
				shine[num].renderer.material = (Material)Resources.Load("sh2");
				shine[num].gameObject.tag = "Untagged";
			}
		}
		txtRaceName.text = GetRaceName(selectedRace);
		txtRaceStats.text = GetRaceStats(selectedRace);
		ShowRaceDescription();
		ShowStartingItems();
	}

	public override void SelectRace(string name)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		switch (name)
		{
		case "01":
			raceSelect.transform.position = shine[0].transform.position;
			curRace = 1;
			RefreshRaceMenu();
			break;
		case "02":
			raceSelect.transform.position = shine[1].transform.position;
			curRace = 2;
			RefreshRaceMenu();
			break;
		case "03":
			raceSelect.transform.position = shine[2].transform.position;
			curRace = 3;
			RefreshRaceMenu();
			break;
		case "04":
			raceSelect.transform.position = shine[3].transform.position;
			curRace = 4;
			RefreshRaceMenu();
			break;
		case "05":
			raceSelect.transform.position = shine[4].transform.position;
			curRace = 5;
			RefreshRaceMenu();
			break;
		case "06":
			raceSelect.transform.position = shine[5].transform.position;
			curRace = 6;
			RefreshRaceMenu();
			break;
		case "07":
			raceSelect.transform.position = shine[6].transform.position;
			curRace = 7;
			RefreshRaceMenu();
			break;
		case "08":
			raceSelect.transform.position = shine[7].transform.position;
			curRace = 8;
			RefreshRaceMenu();
			break;
		}
		SetStartingItemIDs(curRace);
	}

	public override void SetStartingItemIDs(int r)
	{
		switch (r)
		{
		case 1:
			startingItemID[0] = 501;
			startingItemID[1] = 9999;
			startingItemID[2] = 9999;
			break;
		case 2:
			startingItemID[0] = 513;
			startingItemID[1] = 8888;
			startingItemID[2] = 8888;
			break;
		default:
			startingItemID[0] = 501;
			startingItemID[1] = 9999;
			startingItemID[2] = 9999;
			break;
		}
	}

	public override void SetRace(int ra)
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

	public override string GetRaceName(int race)
	{
		string result = null;
		switch (race)
		{
		case 0:
			result = string.Empty;
			break;
		case 1:
			result = "Peon";
			break;
		case 2:
			result = "Noble";
			break;
		case 3:
			result = "Orclops";
			break;
		case 4:
			result = "Dwelf";
			break;
		case 5:
			result = "Remnant";
			break;
		case 6:
			result = "Trogon";
			break;
		case 7:
			result = "Earthkin";
			break;
		case 8:
			result = "Pigfolk";
			break;
		}
		return result;
	}

	public override string GetRaceStats(int race)
	{
		string result = null;
		if (raceUnlocked[race - 1] > 0)
		{
			switch (race)
			{
			case 0:
				result = string.Empty;
				break;
			case 1:
				result = "HP +1\n\nItems purchased\nfrom Merchant are\n25% cheaper.";
				break;
			case 2:
				result = "HP +1\nLCK +1\n";
				break;
			case 3:
				result = "Orclops";
				break;
			case 4:
				result = "Dwelf";
				break;
			case 5:
				result = "Remnant";
				break;
			case 6:
				result = "Trogon";
				break;
			case 7:
				result = "Earthkin";
				break;
			case 8:
				result = "Pigfolk";
				break;
			}
		}
		else
		{
			result = "???";
		}
		return result;
	}

	public override void ShowRaceDescription()
	{
		writing = false;
		string text = null;
		if (raceUnlocked[selectedRace - 1] > 0)
		{
			switch (selectedRace)
			{
			case 0:
				text = string.Empty;
				break;
			case 1:
				text = "Peons are the common folk of Deephaven. These simple yet\n" + "ambitous people strive to expand their colonies\n" + "underground through mining, farming, and crafting. Perhaps\n" + "one day these unlikely heroes will rebuild an army and take\n" + "back the Overworld.";
				break;
			case 2:
				text = "Nobles are the direct descendants of kings in the Overworld.\n" + "Some can afford to travel through safe routes in Deephaven\n" + "to the surface, if only for a moment to feel the sun on their\n" + "skin. Nobles have much influence on the expansion in Deephaven.";
				break;
			case 3:
				text = "These gargantuan brutes were driven underground from their\n" + "mountainous home lands. Although not very intelligent, these\n" + "barbarians hold incredible might and power which has allowed\n" + "them to aggressively expand in Deephaven.";
				break;
			case 4:
				text = "The agile Dwelves are a race of peace and harmony. But Don't\n" + "be fooled, when threatened they are unmatched with bows\n" + "and deadly magic. Dwelves aim to forge The Grand Alliance\n" + "composed of all races in order to defeat the Scourge.";
				break;
			case 5:
				text = "Legends told of an ancient race that lived long before this\n" + "age of chaos and destruction. Until the Scourge attacked, the\n" + "Remnant lived reclusive lives deep within the Icy Wastes.\n" + "But now these magical beings have joined in on the fight against the\n" + "Scourge, and aid in the collection and refinement of Magicite.";
				break;
			case 6:
				text = "High above Wyvern's Rock was the colony of Trogon. This\n" + "bird-like race used to be the backbone of the trading system\n" + "when the Overworld was flourishing. Daring, agile, and quite\n" + "intelligent, the Trogon do what they can to transport goods\n" + "throughout the intricate and dangerous passageways of Deephaven.";
				break;
			case 7:
				text = "Earthkin";
				break;
			case 8:
				text = "Pigfolk";
				break;
			}
		}
		else
		{
			text = GetUnlockRace(selectedRace);
		}
		int num = default(int);
		writing = true;
		txtRaceDescription.text = text;
	}

	public override string GetUnlockRace(int num)
	{
		string result = null;
		switch (num)
		{
		case 2:
			result = "Unlocked by acquiring over 1000 Gold.";
			break;
		case 3:
			result = "Unlocked by completing 3 Orclops quests in a single\nplaythrough.";
			break;
		case 4:
			result = "Unlocked by completing 3 Dwelf quests in a single\nplaythrough.";
			break;
		case 5:
			result = "Unlocked by defeating the Scourge Dragon.";
			break;
		case 6:
			result = "Unlocked by visiting 10 different biomes in a single\nplaythrough.";
			break;
		case 7:
			result = "Unlocked by crafting over 5000 items.";
			break;
		case 8:
			result = "Unlocked by reaching the final boss without using a potion.";
			break;
		}
		return result;
	}

	public override void ShowStartingItems()
	{
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		int[] array = new int[3];
		array = ((raceUnlocked[selectedRace - 1] <= 0) ? new int[3] { 8888, 8888, 8888 } : (selectedRace switch
		{
			1 => new int[3] { 501, 9999, 9999 }, 
			2 => new int[3] { 513, 0, 0 }, 
			3 => new int[3] { 519, 18, 9999 }, 
			4 => new int[3] { 501, 0, 0 }, 
			5 => new int[3] { 501, 9999, 9999 }, 
			6 => new int[3] { 501, 9999, 9999 }, 
			7 => new int[3] { 501, 9999, 9999 }, 
			8 => new int[3] { 501, 9999, 9999 }, 
			_ => new int[3], 
		}));
		startingItems[0].renderer.material = (Material)Resources.Load("i/i" + (object)array[0]);
		startingItems[1].renderer.material = (Material)Resources.Load("i/i" + (object)array[1]);
		startingItems[2].renderer.material = (Material)Resources.Load("i/i" + (object)array[2]);
	}

	public override void DeleteServer(int a)
	{
		numServers--;
		PlayerPrefs.SetString("serverIP" + (object)a, string.Empty);
		int num = default(int);
		for (num = a; num < 4; num++)
		{
			string @string = PlayerPrefs.GetString("serverIP" + (object)(num + 1));
			PlayerPrefs.SetString("serverIP" + (object)num, @string);
			PlayerPrefs.SetString("serverIP" + (object)(num + 1), string.Empty);
		}
		((MonoBehaviour)this).StartCoroutine_Auto(RefreshServers());
	}

	public override IEnumerator Statistics()
	{
		return new _0024Statistics_00241691(this).GetEnumerator();
	}

	public override int GetCurEXP(int pLevel)
	{
		int num = accountEXP;
		if (pLevel > 1)
		{
			num -= GetTotalEXP(pLevel);
		}
		return num;
	}

	public override int GetLevelCap(int pLevel)
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

	public override int GetTotalEXP(int lvl)
	{
		int num = default(int);
		int num2 = default(int);
		for (num = 0; num < lvl; num++)
		{
			num2 += GetLevelCap(num);
		}
		return num2;
	}

	public override int GetPlayerLevel()
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

	public override void Cards()
	{
	}

	public override IEnumerator Play()
	{
		return new _0024Play_00241700(this).GetEnumerator();
	}

	public override IEnumerator Options()
	{
		return new _0024Options_00241704(this).GetEnumerator();
	}

	public override void Multiplayer()
	{
		menuMultiplayer.SetActive(true);
		((MonoBehaviour)this).StartCoroutine_Auto(RefreshServers());
		menuMain.SetActive(false);
	}

	public override IEnumerator RefreshServers()
	{
		return new _0024RefreshServers_00241707(this).GetEnumerator();
	}

	public override void Host()
	{
		multiplayer = 1;
	}

	public override void Connect()
	{
		multiplayer = 2;
	}

	public override IEnumerator Done()
	{
		return new _0024Done_00241711(this).GetEnumerator();
	}

	public override void Done2()
	{
		menuStats.SetActive(true);
	}

	public override void UpdateSound(int dir)
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
		txtVolume.text = "Audio: " + (object)volume;
	}

	public override void UpdateVolume(int v)
	{
		AudioListener.volume = (float)v * 0.1f;
		PlayerPrefs.SetInt("volume", v);
	}

	public override void UpdateGraphics()
	{
	}

	public override void OnPlayerDisconnected()
	{
		MonoBehaviour.print((object)("player disconnected. players connected : " + (object)Network.connections.Length));
		RefreshLobby(Network.connections.Length - 1);
		if (multiplayer == 1)
		{
			((Component)this).networkView.RPC("RefreshLobby", (RPCMode)6, new object[1] { Network.connections.Length - 1 });
		}
	}

	public override void OnPlayerConnected(NetworkPlayer player)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Player " + (object)Network.connections.Length + " connected from " + ((NetworkPlayer)(ref player)).ipAddress + ":" + (object)((NetworkPlayer)(ref player)).port));
		if (multiplayer == 1)
		{
			((Component)this).networkView.RPC("RefreshLobby", (RPCMode)6, new object[1] { Network.connections.Length });
			if (Network.connections.Length > 3)
			{
				Network.CloseConnection(player, false);
			}
		}
	}

	[RPC]
	public override void RefreshLobby(int c)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		MonoBehaviour.print((object)("CONNECTIONS: " + (object)c));
		if (multiplayer == 2)
		{
			bStartGame.SetActive(false);
		}
		else if (multiplayer == 1)
		{
			bStartGame.SetActive(true);
		}
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			if (num < c + 1)
			{
				txtPlayer[num].text = "Player " + (object)(num + 1);
				((Component)txtPlayer[num]).gameObject.renderer.material.color = Color.green;
			}
			else
			{
				txtPlayer[num].text = "-";
				((Component)txtPlayer[num]).gameObject.renderer.material.color = Color.white;
			}
		}
	}

	public override void AddPlayerToLobby()
	{
		int length = Network.connections.Length;
		txtPlayer[length].text = "Player " + (object)length;
	}

	public override void Fullscreen()
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

	public override void EnterName()
	{
		enteringName = true;
		txtName[0].text = string.Empty;
	}

	public override void CharacterCreate()
	{
		Randomize();
		menuMain.SetActive(false);
		menuCharacterSelect.SetActive(false);
		RandomizeStats();
		menuCharacterCreate.SetActive(true);
		Randomize();
	}

	public override Item EmptyItem()
	{
		return new Item(0, 0, new int[6], 0f, null);
	}

	[RPC]
	public override IEnumerator ReadyGame()
	{
		return new _0024ReadyGame_00241714(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator BeginGame()
	{
		return new _0024BeginGame_00241717(this).GetEnumerator();
	}

	public override void ChangeRace(int dir)
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

	public override void ChangeHead(int dir)
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

	public override void ChangeColor(int dir)
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

	public override void ChangeBody(int dir)
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

	public override void Randomize()
	{
		curHead = Random.Range(1, MAX_HEAD + 1);
		if (curHead == 2 || curHead == 5 || curHead == 7 || curHead == 9 || curHead == 14 || curHead == 16)
		{
			isMale = false;
		}
		else
		{
			isMale = true;
		}
		curColor = Random.Range(1, MAX_COLOR + 1);
		curBody = Random.Range(1, MAX_BODY + 1);
		curSkin = Random.Range(1, MAX_SKIN + 1);
		UpdateAppearance();
		RandomizeStats();
		RandomizeName();
		GetHumanStory();
	}

	public override void RandomizeName()
	{
		curName = GetPrefix() + string.Empty + GetSuffix();
		txtName[0].text = curName;
	}

	public override void UpdateAppearance()
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		if (curColor > 1)
		{
			playerBody[1].renderer.material = (Material)Resources.Load("h/h" + (object)(curHead + (curColor - 1) * 14), typeof(Material));
		}
		else
		{
			playerBody[1].renderer.material = (Material)Resources.Load("h/h" + (object)(curHead + (curColor - 1) * 15), typeof(Material));
		}
		playerBody[2].renderer.material = (Material)Resources.Load("b/b" + (object)curBody, typeof(Material));
		playerBody[3].renderer.material = (Material)Resources.Load("a/a" + (object)curBody, typeof(Material));
		playerBody[4].renderer.material = (Material)Resources.Load("a/a" + (object)curBody, typeof(Material));
		playerBody[5].renderer.material = (Material)Resources.Load("l/l" + (object)curBody, typeof(Material));
		playerBody[0].renderer.material = (Material)Resources.Load("r/r" + (object)curRace, typeof(Material));
		txtHead[0].text = "Head: " + (object)curHead;
		txtColor[0].text = "Color: " + (object)curColor;
		txtBody[0].text = "Body: " + (object)curBody;
		txtRace[0].text = "Race: " + (object)curRace;
	}

	public override string GetHumanStory()
	{
		txtStory[0].text = GetHumanStatement();
		txtStory[1].text = GetHumanEffect();
		return null;
	}

	public override string GetHumanStatement()
	{
		int num = Random.Range(0, 1);
		string result = null;
		if (num == 0)
		{
			result = txtName[0].text + "'s " + GetPerson() + " was a " + GetAdjective() + " " + GetProfession() + ".";
		}
		return result;
	}

	public override string GetHumanEffect()
	{
		int num = Random.Range(0, 1);
		string result = null;
		if (num == 0)
		{
			result = "This caused " + txtName[0].text + " to become a " + GetProfession() + " in order to\n" + GetVerb() + " " + GetHisHer() + " " + GetNoun();
		}
		return result;
	}

	public override string GetVerb()
	{
		int num = Random.Range(0, 10);
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

	public override string GetNoun()
	{
		int num = Random.Range(0, 10);
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

	public override string GetHisHer()
	{
		string text = null;
		if (isMale)
		{
			return "his";
		}
		return "her";
	}

	public override string GetPerson()
	{
		int num = Random.Range(0, 8);
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

	public override string GetAdjective()
	{
		int num = Random.Range(0, 10);
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

	public override string GetProfession()
	{
		int num = Random.Range(0, 10);
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

	public override void RandomizeStats()
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		curTrait[1] = Random.Range(1, MAX_TRAITS);
		curTrait[2] = Random.Range(1, MAX_TRAITS);
		if (curTrait[2] == curTrait[1] && curTrait[2] == MAX_TRAITS - 1)
		{
			curTrait[2] = 1;
		}
		else if (curTrait[2] == curTrait[1])
		{
			curTrait[2] = curTrait[2] + 1;
		}
		trait1.renderer.material = (Material)Resources.Load("t/t" + (object)curTrait[1], typeof(Material));
		trait2.renderer.material = (Material)Resources.Load("t/t" + (object)curTrait[2], typeof(Material));
		growthStatGood1 = Random.Range(0, 4);
		growthStatGood2 = Random.Range(0, 4);
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
		growthStatBad = Random.Range(0, 4);
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
			txtStat[num].text = GetStatName(num) + ": " + (object)playerStat[num];
			if (playerStat[num] > 3)
			{
				((Component)txtStat[num]).renderer.material.color = Color.green;
			}
			else if (playerStat[num] < 3)
			{
				((Component)txtStat[num]).renderer.material.color = Color.red;
			}
			else
			{
				((Component)txtStat[num]).renderer.material.color = Color.white;
			}
		}
	}

	public override void SaveCharacter()
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
		if (multiplayer > 0)
		{
			if (((Component)this).networkView.isMine)
			{
				PlayerPrefs.SetString("cName", txtName[0].text);
			}
		}
		else
		{
			PlayerPrefs.SetString("cName", txtName[0].text);
		}
		for (num = 0; num < 6; num++)
		{
			PlayerPrefs.SetInt("s" + (object)num, curStat[num]);
		}
		if (curTrait[1] == 6 || curTrait[2] == 6)
		{
			playerStat[1] = playerStat[1] + 2;
			playerStat[2] = playerStat[2] - 1;
		}
		if (curTrait[1] == 7 || curTrait[2] == 7)
		{
			playerStat[1] = playerStat[1] - 1;
			playerStat[2] = playerStat[2] + 2;
			playerStat[0] = playerStat[0] + 2;
		}
		if (curTrait[1] == 8 || curTrait[2] == 8)
		{
			playerStat[4] = playerStat[4] + 2;
		}
		if (curTrait[1] == 9 || curTrait[2] == 9)
		{
			playerStat[0] = playerStat[0] + 2;
		}
		if (curTrait[1] == 11 || curTrait[2] == 11)
		{
			playerStat[3] = playerStat[3] + 4;
		}
		pHead = curHead;
		pBody = curBody;
		pRace = curRace;
		curName = txtName[0].text;
		pColor = curColor;
		PlayerPrefs.SetInt("hair", curHead);
		PlayerPrefs.SetInt("body", curBody);
	}

	public override void OnDisconnectedFromServer()
	{
		((MonoBehaviour)this).StartCoroutine_Auto(Done());
	}

	public override void OnConnectedToServer()
	{
		txtConnecting.text = "Successfully Connected!";
		doneConnecting = 1;
	}

	public override void MenuLobby()
	{
		menuLobby.SetActive(true);
		menuCharacterCreate.SetActive(false);
		if (multiplayer == 1)
		{
			RefreshLobby(Network.connections.Length);
			((Component)txtHosting).gameObject.SetActive(true);
			txtHosting.text = "Hosting on Port " + (object)port;
		}
		else
		{
			((Component)txtHosting).gameObject.SetActive(false);
		}
	}

	public override void OnServerInitialized()
	{
		MonoBehaviour.print((object)"Server Initialized. Refreshing Lobby...");
		((Component)this).networkView.RPC("SetPlayer", (RPCMode)2, new object[0]);
	}

	public override void LoadStats()
	{
		int num = default(int);
		accountEXP = PlayerPrefs.GetInt("aEXP");
		for (num = 0; num < 13; num++)
		{
			txtStats[num].text = string.Empty + (object)PlayerPrefs.GetInt("stat" + (object)num);
		}
	}

	public override string GetStatsName(int a)
	{
		string text = null;
		return a switch
		{
			0 => "Characters Created", 
			1 => "Enemies Defeated", 
			2 => "Gold Collected", 
			3 => "EXP Acquired", 
			4 => "Items Crafted", 
			5 => "Trees Chopped", 
			6 => "Ore Mined", 
			7 => "Resources Gathered", 
			8 => "Foods Eaten", 
			9 => "Chests Opened", 
			10 => "Quests Completed", 
			11 => "Items Bought", 
			12 => "Altars Used", 
			_ => string.Empty, 
		};
	}

	public override string GetStatName(int a)
	{
		string text = null;
		return a switch
		{
			0 => "HP", 
			1 => "ATK", 
			2 => "DEX", 
			3 => "MAG", 
			_ => "NULL", 
		};
	}

	public override void Delete()
	{
		PlayerPrefs.DeleteAll();
		LoadStats();
	}

	public override string GetMaleName()
	{
		int num = Random.Range(0, 54);
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

	public override string GetFemaleName()
	{
		int num = Random.Range(0, 54);
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

	public override string GetPrefix()
	{
		int num = Random.Range(0, 16);
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

	public override string GetSuffix()
	{
		int num = Random.Range(0, 16);
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
	public override void SetPlayer()
	{
		if (curPlayers < 4)
		{
			txtPlayer[curPlayers].text = "Player " + (object)curPlayers;
			curPlayers++;
		}
	}

	public override string GetRaceDesc(int a)
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

	public override string GetTraitName(int id)
	{
		string text = null;
		return id switch
		{
			1 => "Woodcutter", 
			2 => "Miner", 
			3 => "Gatherer", 
			4 => "Potion Brewer", 
			5 => "Artisan", 
			6 => "Aggressive", 
			7 => "Defensive", 
			8 => "Swift", 
			9 => "Healthy", 
			10 => "Big Eater", 
			11 => "Intelligent", 
			12 => "Lockmaster", 
			13 => "Pickpocket", 
			_ => "NULL", 
		};
	}

	public override string GetTraitDesc(int id)
	{
		string text = null;
		return id switch
		{
			1 => "Chops down trees quicker.", 
			2 => "Mines ores faster.", 
			3 => "Collects twice as many\ningredients when gathering.", 
			4 => "Crafts Big Potions with\nonly basic ingredients.", 
			5 => "+10 LCK when crafting\nWeapons or Gear", 
			6 => "+2 ATK\n-1 DEF.", 
			7 => "+2 DEF\n+2 HP\n-1 ATK.", 
			8 => "+2 DEX", 
			9 => "+2 HP", 
			10 => "Hunger Cap is doubled.", 
			11 => "+2 MAG", 
			12 => "Doesn't need a key when\nopening chests or locks.", 
			13 => "Has a chance to steal gold\nwhen walking by NPCs.", 
			_ => "NULL", 
		};
	}

	public override string GetItemName(int id)
	{
		string text = null;
		return id switch
		{
			1 => "Wood", 
			2 => "Wooden Plank", 
			3 => "Wooden Stick", 
			4 => "Ironite Ore", 
			5 => "Goldium Ore", 
			6 => "Diamonite Ore", 
			7 => "Raw Meat", 
			8 => "Cooked Meat", 
			9 => "Herb", 
			10 => "Shroom", 
			11 => "Root", 
			12 => "Ironite Bar", 
			13 => "Goldium Bar", 
			14 => "Diamonite Bar", 
			15 => "HP Potion", 
			16 => "Mana Potion", 
			17 => "Vial of Poison", 
			18 => "Monster Bone", 
			19 => "Monster Hide", 
			20 => "Cloth", 
			21 => "Raw Chicken", 
			22 => "Cooked Chicken", 
			23 => "Spider Web", 
			24 => "Sword Hilt", 
			25 => "Wooden Blade", 
			26 => "Axe Handle", 
			27 => "Pick Handle", 
			28 => "Unstrung Bow", 
			29 => "String", 
			30 => "Fire Bug", 
			31 => "Thunder Bug", 
			32 => "Ironite Blade", 
			33 => "Goldmium Blade", 
			34 => "Diamonite Blade", 
			35 => "Ironite Great Blade", 
			36 => "Goldium Great Blade", 
			37 => "Diamonite Great Blade", 
			38 => "Stone", 
			39 => "Refined Stone", 
			40 => "Stone Blade", 
			41 => "Stone Great Blade", 
			42 => "Big HP Potion", 
			43 => "Big Mana Potion", 
			44 => "Mysterious Potion", 
			45 => "Big Mysterious Potion", 
			46 => "Key", 
			47 => "Coal", 
			48 => "Firestarter", 
			49 => "Cooked Chicken", 
			50 => "Bone Blade", 
			51 => "Refined Bone", 
			52 => "Bone Arrow", 
			53 => "Stone Arrow", 
			54 => "Iron Arrow", 
			55 => "Goldium Arrow", 
			56 => "Diamonite Arrow", 
			57 => "Dragonite Arrow", 
			58 => "Adamantite Arrow", 
			59 => "Obsidian Arrow", 
			60 => "Crystalite Fragment", 
			61 => "Crystalite Shard", 
			62 => "Dragonite Ore", 
			63 => "Dragonite Bar", 
			64 => "Adamantite Ore", 
			65 => "Adamantite Bar", 
			66 => "Obsidian Ore", 
			67 => "Obsidian Bar", 
			68 => "Net", 
			69 => "Fire Gem I", 
			70 => "Thunder Gem I", 
			_ => "NULL", 
		};
	}

	public override string GetGearName(int id)
	{
		string text = null;
		return id switch
		{
			500 => "Wooden Sword", 
			501 => "Wooden Axe", 
			502 => "Wooden Pick", 
			503 => "Ironite Sword", 
			504 => "Ironite Axe", 
			505 => "Ironite Pick", 
			506 => "Goldium Sword", 
			507 => "Goldium Axe", 
			508 => "Goldium Pick", 
			509 => "Diamonite Sword", 
			510 => "Diamonite Axe", 
			511 => "Diamonite Pick", 
			512 => "Stone Sword", 
			513 => "Stone Axe", 
			514 => "Stone Pick", 
			515 => "Wooden Bow", 
			516 => "Bone Sword", 
			517 => "Bone Axe", 
			518 => "Bone Pick", 
			519 => "Wooden Club", 
			520 => "Excalibur", 
			521 => "Dragonite Axe", 
			522 => "Dragonite Pick", 
			523 => "Wightslayer", 
			524 => "Adamantite Axe", 
			525 => "Adamantite Pick", 
			526 => "Spellblade", 
			527 => "Obsidian Axe", 
			528 => "Obsidian Pick", 
			529 => "Bug Net", 
			550 => "Giant Fish", 
			560 => "Ironite Great Axe", 
			561 => "Goldium Great Axe", 
			562 => "Diamonite Great Axe", 
			563 => "Stone Great Axe", 
			564 => "Hellswrath", 
			565 => "Vorpal Axe", 
			566 => "Godslayer", 
			600 => "Fireball", 
			601 => "Bolt", 
			602 => "Frostshard", 
			700 => "Ironite Helm", 
			701 => "Goldium Helm", 
			702 => "Diamonite Helm", 
			703 => "Stone Helm", 
			704 => "Bone Helm", 
			705 => "Green Hood", 
			706 => "Blue Hood", 
			707 => "Red Hood", 
			708 => "Black Hood", 
			709 => "Dragonite Helm", 
			710 => "Adamantite Helm", 
			711 => "Obsidian Helm", 
			800 => "Ironite Armor", 
			801 => "Goldium Armor", 
			802 => "Diamonite Armor", 
			803 => "Stone Armor", 
			804 => "Bone Armor", 
			900 => "Ironite Shield", 
			901 => "Goldium Shield", 
			902 => "Diamonite Shield", 
			903 => "Stone Shield", 
			904 => "Bone Shield", 
			_ => "NULL", 
		};
	}

	public override void Main()
	{
	}
}
