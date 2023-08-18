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
		exit = new GameObject[3];
	}

	public virtual void OnDestroy()
	{
		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
	}

	public virtual void Awake()
	{
		if (Network.isServer)
		{
			GameScript.barrierObj = barrierObj;
			if (!isEntrance)
			{
				GameScript.exitObj = gameObject;
			}
		}
	}

	[RPC]
	public virtual void OpenN()
	{
		barrierObj.SetActive(value: false);
	}

	[RPC]
	public virtual void CloseN()
	{
		barrierObj.SetActive(value: true);
	}

	public virtual void Close()
	{
		GetComponent<NetworkView>().RPC("CloseN", RPCMode.All);
	}

	public virtual void Open()
	{
		GetComponent<NetworkView>().RPC("OpenN", RPCMode.All);
	}

	public virtual void Start()
	{
		if (isEntrance)
		{
			if (Network.isServer)
			{
				GetComponent<NetworkView>().RPC("InitializeEn", RPCMode.All, GameScript.curBiome);
			}
			return;
		}
		if (Network.isServer)
		{
			GetComponent<NetworkView>().RPC("InitializeEx", RPCMode.All, GameScript.curBiome);
		}
		if (GameScript.curBiome != 19)
		{
			SetExits();
		}
	}

	[RPC]
	public virtual void InitializeEn(int c)
	{
		GetComponent<Renderer>().material = (Material)Resources.Load("lv/en" + c);
		bg.GetComponent<Renderer>().material = (Material)Resources.Load("bg/bgd" + c);
	}

	[RPC]
	public virtual void InitializeEx(int c)
	{
		GetComponent<Renderer>().material = (Material)Resources.Load("lv/ex" + c);
		bg.GetComponent<Renderer>().material = (Material)Resources.Load("bg/bgd" + c);
	}

	public virtual int GetBiomeCap()
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

	public virtual void SetExits()
	{
		if (GameScript.finalBoss == 1)
		{
			if (Network.isServer)
			{
				GetComponent<NetworkView>().RPC("SetFinalDoor", RPCMode.All, 99);
			}
			return;
		}
		if (GameScript.isTown)
		{
			if (Network.isServer)
			{
				GetComponent<NetworkView>().RPC("SetTownDoor", RPCMode.All, GameScript.curBiome);
			}
			return;
		}
		int num = 3;
		int num2 = default(int);
		for (num2 = 0; num2 < num; num2++)
		{
			int possibleBiome = GetPossibleBiome(GameScript.districtLevel);
			if (Network.isServer)
			{
				GetComponent<NetworkView>().RPC("SetE", RPCMode.All, num2, possibleBiome);
			}
		}
	}

	public virtual int GetPossibleBiome(int a)
	{
		int num = default(int);
		int result = default(int);
		if (a < 5)
		{
			return UnityEngine.Random.Range(0, 4) switch
			{
				0 => 7, 
				1 => 1, 
				_ => 0, 
			};
		}
		if (a < 7)
		{
			switch (UnityEngine.Random.Range(0, 5))
			{
			case 0:
				return 2;
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
				switch (UnityEngine.Random.Range(0, 3))
				{
				case 0:
					return 2;
				case 1:
					return 5;
				default:
					if (UnityEngine.Random.Range(0, 2) == 0)
					{
						return 3;
					}
					return 8;
				}
			}
			if (a >= 15)
			{
				if (a < 17)
				{
					return UnityEngine.Random.Range(0, 5) switch
					{
						0 => 3, 
						1 => 6, 
						2 => 5, 
						3 => 2, 
						_ => 9, 
					};
				}
				return UnityEngine.Random.Range(0, 3) switch
				{
					0 => 3, 
					1 => 6, 
					_ => 9, 
				};
			}
			switch (UnityEngine.Random.Range(0, 4))
			{
			case 0:
				return 3;
			case 1:
				return 3;
			case 2:
				return 5;
			case 3:
				return 2;
			}
		}
		return result;
	}

	[RPC]
	public virtual void SetE(int i, int b)
	{
		exit[i].SetActive(value: true);
		exit[i].GetComponent<Renderer>().material = (Material)Resources.Load("lv/d" + b);
		exit[i].name = "d" + b;
		if (Network.isServer)
		{
			GameScript.doorBiome[i] = b;
		}
	}

	[RPC]
	public virtual void SetFinalDoor(int b)
	{
		exit[1].SetActive(value: true);
		exit[1].GetComponent<Renderer>().material = (Material)Resources.Load("lv/d" + b);
		exit[1].name = "d" + b;
		if (Network.isServer)
		{
			GameScript.doorBiome[1] = b;
		}
	}

	[RPC]
	public virtual void SetTownDoor(int b)
	{
		exit[1].SetActive(value: true);
		exit[1].GetComponent<Renderer>().material = (Material)Resources.Load("lv/d" + b);
		exit[1].name = "d" + b;
		if (Network.isServer)
		{
			GameScript.doorBiome[1] = b;
		}
	}

	public virtual void Main()
	{
	}
}
