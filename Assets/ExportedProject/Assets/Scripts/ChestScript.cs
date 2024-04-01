using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class ChestScript : MonoBehaviour
{
	public bool isTwo;

	public bool isGold;

	private bool isOpened;

	private int[] drops;

	private int gold;

	public GameObject @base;

	public virtual void Awake()
	{
		if (Network.isServer && GameScript.districtLevel > 5)
		{
			if (UnityEngine.Random.Range(0, 8) == 0)
			{
				Network.Instantiate(Resources.Load("e/mimic"), transform.position, Quaternion.identity, 0);
				Network.Destroy(GetComponent<NetworkView>().viewID);
			}
			else
			{
				Begin();
			}
		}
		else
		{
			Begin();
		}
	}

	public virtual void Begin()
	{
		int num = default(int);
		if (isTwo)
		{
			num = 1;
			drops = new int[num];
			switch (UnityEngine.Random.Range(0, 6))
			{
			case 0:
				drops[0] = 520;
				break;
			case 1:
				drops[0] = 521;
				break;
			case 2:
				drops[0] = 906;
				break;
			case 3:
				drops[0] = 907;
				break;
			case 4:
				drops[0] = 536;
				break;
			case 5:
				drops[0] = 603;
				break;
			}
			return;
		}
		num = ((!isGold) ? UnityEngine.Random.Range(2, 4) : UnityEngine.Random.Range(3, 7));
		drops = new int[num];
		int num2 = default(int);
		for (num2 = 0; num2 < num; num2++)
		{
			drops[num2] = UnityEngine.Random.Range(1, 56);
			if (drops[num2] == 49 || drops[num2] == 11)
			{
				drops[num2] = 9;
			}
		}
		if (Network.isServer && GameScript.curBiome == 6)
		{
			if (UnityEngine.Random.Range(0, 6) == 0)
			{
				drops[0] = 565;
			}
		}
		else if (Network.isServer && GameScript.curBiome == 8)
		{
			if (UnityEngine.Random.Range(0, 6) == 0)
			{
				drops[0] = 530;
			}
		}
		else if (Network.isServer && GameScript.curBiome == 3)
		{
			if (UnityEngine.Random.Range(0, 6) == 0)
			{
				drops[1] = 905;
			}
		}
		else if (Network.isServer && GameScript.curBiome == 9)
		{
			if (UnityEngine.Random.Range(0, 5) == 0)
			{
				drops[0] = 46;
			}
			switch (UnityEngine.Random.Range(0, 9))
			{
			case 0:
				drops[1] = 534;
				break;
			case 1:
				drops[1] = 535;
				break;
			}
		}
		if (UnityEngine.Random.Range(0, 7) == 0)
		{
			drops[0] = UnityEngine.Random.Range(950, 958);
		}
		switch (UnityEngine.Random.Range(0, 10))
		{
		case 0:
			drops[0] = UnityEngine.Random.Range(531, 534);
			break;
		case 1:
			drops[0] = 567;
			break;
		}
		gold = UnityEngine.Random.Range(2, 9);
	}

	[RPC]
	public virtual void Init(int a, int b, int c)
	{
		drops = new int[3];
		drops[0] = a;
		drops[1] = b;
		drops[2] = c;
		gold = UnityEngine.Random.Range(2, 9);
	}

	[RPC]
	public virtual void O()
	{
		GameScript.tempStats[9] = GameScript.tempStats[9] + 1;
		@base.GetComponent<Animation>().Play();
		float x = @base.GetComponent<Renderer>().material.mainTextureOffset.x + 0.5f;
		Vector2 mainTextureOffset = @base.GetComponent<Renderer>().material.mainTextureOffset;
		float num = (mainTextureOffset.x = x);
		Vector2 vector2 = (@base.GetComponent<Renderer>().material.mainTextureOffset = mainTextureOffset);
		int num2 = default(int);
		GameObject gameObject = null;
		Item item = new Item(0, 1, new int[4], 0f, null);
		int[] array = null;
		for (num2 = 0; num2 < gold; num2++)
		{
			UnityEngine.Object.Instantiate(Resources.Load("c"), transform.position, Quaternion.identity);
		}
		for (num2 = 0; num2 < Extensions.get_length((System.Array)drops); num2++)
		{
			if (drops[num2] != 0)
			{
				item.id = drops[num2];
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), transform.position, Quaternion.identity);
				if (item.id >= 500)
				{
					item.e = GetGearStats(item.id);
					item.d = 100;
				}
				array = new int[7]
				{
					item.id,
					item.q,
					item.e[0],
					item.e[1],
					item.e[2],
					item.e[3],
					item.d
				};
				gameObject.SendMessage("InitL", array);
			}
		}
	}

	[RPC]
	public virtual void OO()
	{
		if (!isOpened)
		{
			isOpened = true;
			GetComponent<NetworkView>().RPC("O", RPCMode.All);
		}
	}

	public virtual void Open()
	{
		if (!isGold)
		{
			if (Network.isServer)
			{
				OO();
			}
			else
			{
				GetComponent<NetworkView>().RPC("OO", RPCMode.Server);
			}
		}
	}

	[RPC]
	public virtual void ServerO()
	{
		isOpened = true;
		@base.GetComponent<Animation>().Play();
		float x = @base.GetComponent<Renderer>().material.mainTextureOffset.x + 0.5f;
		Vector2 mainTextureOffset = @base.GetComponent<Renderer>().material.mainTextureOffset;
		float num = (mainTextureOffset.x = x);
		Vector2 vector2 = (@base.GetComponent<Renderer>().material.mainTextureOffset = mainTextureOffset);
	}

	public virtual void Open2()
	{
		isGold = false;
		Open();
	}

	public virtual int[] GetGearStats(int id)
	{
		int[] array = new int[4];
		switch (id)
		{
			case 500:
				return new int[4] { 0, 2, 0, 0 };
			case 503:
				return new int[4] { 0, 8, 0, 0 };
			case 506:
				return new int[4] { 0, 15, 0, 0 };
			case 509:
				return new int[4] { 0, 25, 0, 0 };
			case 512:
			case 516:
				return new int[4] { 0, 4, 0, 0 };
			case 520:
				return new int[4] { 5, 27, 5, 5 };
			case 521:
				return new int[4] { 2, 30, 2, 2 };
			case 530:
				return new int[4] { 0, 0, 6, 0 };
			case 531:
			case 532:
				return new int[4] { 2, 11, 0, 0 };
			case 533:
				return new int[4] { 5, 30, 2, 2 };
			case 534:
				return new int[4] { 0, 75, 0, 0 };
			case 535:
				return new int[4] { 0, 0, 15, 15 };
			case 536:
				return new int[4] { 0, 0, 3, 0 };
			case 560:
				return new int[4] { 0, 15, 0, 0 };
			case 561:
				return new int[4] { 0, 30, 0, 0 };
			case 562:
				return new int[4] { 0, 48, 0, 0 };
			case 563:
				return new int[4] { 0, 8, 0, 0 };
			case 565:
				return new int[4] { 0, 55, 0, 0 };
			case 566:
				return new int[4] { -3, 100, 0, 0 };
			case 567:
				return new int[4] { 0, 35, 0, 0 };
			case 568:
			case 569:
			case 570:
				return new int[4] { 0, 95, 0, 10 };
			case 700:
				return new int[4] { 2, 4, 0, 0 };
			case 701:
				return new int[4] { 3, 6, 0, 0 };
			case 702:
				return new int[4] { 4, 9, 0, 0 };
			case 703:
			case 704:
				return new int[4] { 1, 2, 0, 0 };
			case 705:
			case 706:
				return new int[4] { 1, 0, 2, 0 };
			case 707:
				return new int[4] { 2, 0, 4, 0 };
			case 708:
				return new int[4] { 3, 0, 6, 0 };
			case 709:
				return new int[4] { 4, 0, 9, 0 };
			case 710:
			case 711:
				return new int[4] { 1, 0, 0, 2 };
			case 712:
				return new int[4] { 2, 0, 0, 4 };
			case 713:
				return new int[4] { 3, 0, 0, 6 };
			case 714:
				return new int[4] { 4, 0, 0, 9 };
			case 800:
				return new int[4] { 2, 4, 0, 0 };
			case 801:
				return new int[4] { 3, 6, 0, 0 };
			case 802:
				return new int[4] { 4, 9, 0, 0 };
			case 803:
			case 804:
				return new int[4] { 1, 2, 0, 0 };
			case 805:
			case 806:
				return new int[4] { 1, 0, 2, 0 };
			case 807:
				return new int[4] { 2, 0, 4, 0 };
			case 808:
				return new int[4] { 3, 0, 6, 0 };
			case 809:
				return new int[4] { 4, 0, 9, 0 };
			case 810:
			case 811:
				return new int[4] { 1, 0, 0, 2 };
			case 812:
				return new int[4] { 2, 0, 0, 4 };
			case 813:
				return new int[4] { 3, 0, 0, 6 };
			case 814:
				return new int[4] { 4, 0, 0, 9 };
			case 900:
				return new int[4] { 2, 0, 0, 0 };
			case 901:
				return new int[4] { 3, 0, 0, 0 };
			case 902:
				return new int[4] { 4, 0, 0, 0 };
			case 903:
			case 904:
				return new int[4] { 1, 0, 0, 0 };
			case 905:
				return new int[4] { 5, 2, 2, 2 };
			case 906:
				return new int[4] { 5, 2, 0, 5 };
			case 907:
				return new int[4] { 3, 5, 5, 0 };
			case 950:
				return new int[4] { 0, 5, 0, 0 };
			case 951:
				return new int[4] { 0, 0, 0, 5 };
			case 952:
				return new int[4] { 0, 0, 5, 0 };
			case 953:
				return new int[4] { 5, 0, 0, 0 };
			case 954:
				return new int[4] { -2, 8, 0, 0 };
			case 955:
				return new int[4] { -2, 0, 0, 8 };
			case 956:
				return new int[4] { -2, 0, 8, 0 };
			case 957:
				return new int[4] { 2, 2, 2, 2 };
			default:
				return new int[4];
		}
	}

	}