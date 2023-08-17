using System;
using UnityEngine;

[Serializable]
public class ENEXScript : MonoBehaviour
{
	public bool isEntrance;

	public GameObject bg;

	public GameObject[] exit;

	public GameObject barrierObj;

	public ENEXScript()
	{
		exit = (GameObject[])(object)new GameObject[3];
	}

	public override void OnDestroy()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer > 0)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
		}
	}

	public override void Awake()
	{
		if (MenuScript.multiplayer > 0)
		{
			if (MenuScript.multiplayer == 1)
			{
				GameScript.barrierObj = barrierObj;
				if (!isEntrance)
				{
					GameScript.exitObj = ((Component)this).gameObject;
				}
			}
		}
		else
		{
			GameScript.barrierObj = barrierObj;
			if (!isEntrance)
			{
				GameScript.exitObj = ((Component)this).gameObject;
			}
		}
	}

	[RPC]
	public override void OpenN()
	{
		barrierObj.SetActive(false);
	}

	[RPC]
	public override void CloseN()
	{
		barrierObj.SetActive(true);
	}

	public override void Close()
	{
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("CloseN", (RPCMode)6, new object[0]);
		}
		else
		{
			barrierObj.SetActive(true);
		}
	}

	public override void Open()
	{
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("OpenN", (RPCMode)6, new object[0]);
		}
		else
		{
			barrierObj.SetActive(false);
		}
	}

	public override void Start()
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		if (isEntrance)
		{
			if (MenuScript.multiplayer > 0)
			{
				if (Network.isServer)
				{
					((Component)this).networkView.RPC("InitializeEn", (RPCMode)6, new object[1] { GameScript.curBiome });
				}
			}
			else
			{
				((Component)this).renderer.material = (Material)Resources.Load("lv/en" + (object)GameScript.curBiome);
				bg.renderer.material = (Material)Resources.Load("bg/bgd" + (object)GameScript.curBiome);
			}
			return;
		}
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				((Component)this).networkView.RPC("InitializeEx", (RPCMode)6, new object[1] { GameScript.curBiome });
			}
		}
		else
		{
			((Component)this).renderer.material = (Material)Resources.Load("lv/ex" + (object)GameScript.curBiome);
			bg.renderer.material = (Material)Resources.Load("bg/bgd" + (object)GameScript.curBiome);
		}
		if (GameScript.curBiome != 19)
		{
			SetExits();
		}
	}

	[RPC]
	public override void InitializeEn(int c)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		((Component)this).renderer.material = (Material)Resources.Load("lv/en" + (object)c);
		bg.renderer.material = (Material)Resources.Load("bg/bgd" + (object)c);
	}

	[RPC]
	public override void InitializeEx(int c)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		((Component)this).renderer.material = (Material)Resources.Load("lv/ex" + (object)c);
		bg.renderer.material = (Material)Resources.Load("bg/bgd" + (object)c);
	}

	public override int GetBiomeCap()
	{
		int num = default(int);
		if (GameScript.districtLevel > 9)
		{
			return 5;
		}
		if (GameScript.districtLevel > 6)
		{
			return 4;
		}
		if (GameScript.districtLevel > 3)
		{
			return 3;
		}
		return 2;
	}

	public override void SetExits()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		if (GameScript.finalBoss == 1)
		{
			if (MenuScript.multiplayer > 0)
			{
				if (Network.isServer)
				{
					((Component)this).networkView.RPC("SetFinalDoor", (RPCMode)6, new object[1] { 99 });
				}
			}
			else
			{
				exit[1].SetActive(true);
				exit[1].renderer.material = (Material)Resources.Load("lv/d" + (object)99);
				((Object)exit[1]).name = "d" + (object)99;
				GameScript.door[1] = 99;
			}
			return;
		}
		if (GameScript.isTown)
		{
			if (MenuScript.multiplayer > 0)
			{
				if (Network.isServer)
				{
					((Component)this).networkView.RPC("SetTownDoor", (RPCMode)6, new object[1] { GameScript.curBiome });
				}
			}
			else
			{
				exit[1].SetActive(true);
				exit[1].renderer.material = (Material)Resources.Load("lv/d" + (object)GameScript.curBiome);
				((Object)exit[1]).name = "d" + (object)GameScript.curBiome;
				GameScript.door[1] = GameScript.curBiome;
			}
			return;
		}
		int num = 3;
		int num2 = default(int);
		for (num2 = 0; num2 < num; num2++)
		{
			int possibleBiome = GetPossibleBiome(GameScript.districtLevel);
			if (MenuScript.multiplayer > 0)
			{
				if (Network.isServer)
				{
					((Component)this).networkView.RPC("SetE", (RPCMode)6, new object[2] { num2, possibleBiome });
				}
			}
			else
			{
				exit[num2].SetActive(true);
				exit[num2].renderer.material = (Material)Resources.Load("lv/d" + (object)possibleBiome);
				((Object)exit[num2]).name = "d" + (object)possibleBiome;
				GameScript.door[num2] = possibleBiome;
			}
		}
	}

	public override int GetPossibleBiome(int a)
	{
		int num = default(int);
		int result = default(int);
		if (a < 5)
		{
			return Random.Range(0, 4) switch
			{
				0 => 7, 
				1 => 1, 
				_ => 0, 
			};
		}
		if (a < 7)
		{
			switch (Random.Range(0, 5))
			{
			case 0:
				return 0;
			case 1:
				return 1;
			case 2:
				return 7;
			case 3:
				return 2;
			case 4:
				return 5;
			}
		}
		else
		{
			if (a < 9)
			{
				switch (Random.Range(0, 3))
				{
				case 0:
					return 2;
				case 1:
					return 5;
				default:
					if (Random.Range(0, 2) == 0)
					{
						return 3;
					}
					return 8;
				}
			}
			if (a < 15)
			{
				switch (Random.Range(0, 4))
				{
				case 0:
					return 0;
				case 1:
					return 3;
				case 2:
					return 5;
				case 3:
					return 2;
				}
			}
			else if (a < 17)
			{
				switch (Random.Range(0, 4))
				{
				case 0:
					return 3;
				case 1:
					return 6;
				case 2:
					return 5;
				case 3:
					return 2;
				}
			}
			else
			{
				switch (Random.Range(0, 2))
				{
				case 0:
					return 3;
				case 1:
					return 6;
				}
			}
		}
		return result;
	}

	[RPC]
	public override void SetE(int i, int b)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		exit[i].SetActive(true);
		exit[i].renderer.material = (Material)Resources.Load("lv/d" + (object)b);
		((Object)exit[i]).name = "d" + (object)b;
		if (MenuScript.multiplayer == 1)
		{
			GameScript.doorBiome[i] = b;
		}
	}

	[RPC]
	public override void SetFinalDoor(int b)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		exit[1].SetActive(true);
		exit[1].renderer.material = (Material)Resources.Load("lv/d" + (object)b);
		((Object)exit[1]).name = "d" + (object)b;
		if (MenuScript.multiplayer == 1)
		{
			GameScript.doorBiome[1] = b;
		}
	}

	[RPC]
	public override void SetTownDoor(int b)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		exit[1].SetActive(true);
		exit[1].renderer.material = (Material)Resources.Load("lv/d" + (object)b);
		((Object)exit[1]).name = "d" + (object)b;
		if (MenuScript.multiplayer == 1)
		{
			GameScript.doorBiome[1] = b;
		}
	}

	public override void Main()
	{
	}
}
