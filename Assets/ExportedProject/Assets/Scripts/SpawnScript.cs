using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class SpawnScript : MonoBehaviour
{
	public IEnumerator SpawnTown()
	{
		if (Network.isServer && !spawningTown)
		{
			spawningTown = true;
			print("SPAWNSCRIPT SPAWNING TOWN");

			int i = default(int);
			curTownStyle = Random.Range(0, 1);

			Network.Instantiate(Resources.Load("npc/npc" + 1), slot[1].transform.position, Quaternion.identity, 0);
			Network.Instantiate(Resources.Load("house/hBlacksmith"), slot[1].transform.position, Quaternion.identity, 0);
			Network.Instantiate(Resources.Load("npc/npc" + 2), slot[3].transform.position, Quaternion.identity, 0);
			Network.Instantiate(Resources.Load("npc/npc" + 3), slot[6].transform.position, Quaternion.identity, 0);
			Network.Instantiate(Resources.Load("house/hLeatherworker"), slot[6].transform.position, Quaternion.identity, 0);
			Network.Instantiate(Resources.Load("npc/npc" + 4), slot[12].transform.position, Quaternion.identity, 0);
			Network.Instantiate(Resources.Load("house/hTailor"), slot[12].transform.position, Quaternion.identity, 0);
			Network.Instantiate(Resources.Load("npc/npc" + 2), slot[9].transform.position, Quaternion.identity, 0);
			Network.Instantiate(Resources.Load("npc/npc" + 5), slot[14].transform.position, Quaternion.identity, 0);
			Network.Instantiate(Resources.Load("house/hHoarder"), slot[14].transform.position, Quaternion.identity, 0);

			for (i = 0; i < slot.Length - 2; i += 3)
			{
				if (slot[i] != null)
				{
					int num = Random.Range(0, 3);
					if (num < 2 && Network.isServer)
					{
						if (Network.isServer && i != 9 && i != 10)
						{
							Network.Instantiate(Resources.Load("npc/m" + 1), slot[i].transform.position, Quaternion.identity, 0);
							Network.Instantiate(Resources.Load("house/h" + Random.Range(1, 3) + "s1"), slot[i].transform.position, Quaternion.identity, 0);
						}
					}
					else
					{
						int nn = Random.Range(0, 3);
						if (nn == 0)
						{
							Network.Instantiate(Resources.Load("e/chick"), slot[i].transform.position, Quaternion.identity, 0);
							Network.Instantiate(Resources.Load("e/chick"), slot[i].transform.position, Quaternion.identity, 0);
						}
						else if (nn == 1)
						{
							Network.Instantiate(Resources.Load("e/chick"), slot[i].transform.position, Quaternion.identity, 0);
						}
					}
				}
			}

			for (i = 0; i < top.Length; i++)
			{
				if (top[i] != null)
				{
					int b = Random.Range(0, 3);
					if (b == 0)
					{
						SpawnTopLantern(top[i].transform.TransformPoint(Vector3.right));
					}
				}
			}

			yield return new WaitForSeconds(5f);

			spawningTown = false;
		}
	}
	public GameObject[] particle;

	public GameObject[] slot;

	public GameObject[] top;

	public GameObject bg;

	public int zType;

	private int[] slotInt;

	private bool spawningTown;

	private int curTownStyle;

	public SpawnScript()
	{
		particle = new GameObject[20];
		slot = new GameObject[18];
		top = new GameObject[10];
		slotInt = new int[20];
	}

	public virtual void OnDestroy()
	{
		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
	}

	public virtual void Awake()
	{
		if (Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Init", RPCMode.All, GameScript.curBiome, zType);
		}
	}

	public virtual void Start()
	{
		if (Network.isServer)
		{
			if (GameScript.isTown)
			{
				StartCoroutine_Auto(SpawnTown());
			}
			else if (GameScript.curBiome == 0)
			{
				SpawnGrass();
			}
			else if (GameScript.curBiome == 1)
			{
				SpawnSnow();
			}
			else if (GameScript.curBiome == 2)
			{
				SpawnCave();
			}
			else if (GameScript.curBiome == 3)
			{
				SpawnDungeon();
			}
			else if (GameScript.curBiome == 4)
			{
				SpawnDesert();
			}
			else if (GameScript.curBiome == 5)
			{
				SpawnVeldt();
			}
			else if (GameScript.curBiome == 6)
			{
				SpawnLava();
			}
			else if (GameScript.curBiome == 7)
			{
				SpawnSwamp();
			}
			else if (GameScript.curBiome == 8)
			{
				SpawnCrystal();
			}
			else if (GameScript.curBiome == 9)
			{
				SpawnCrater();
			}
			else if (GameScript.curBiome == 19)
			{
				SpawnFinal();
			}
		}
	}

	[RPC]
	public virtual void Init(int c, int t)
	{
		particle[GameScript.curBiome].SetActive(value: true);
		GetComponent<Renderer>().material = (Material)Resources.Load("lv/b" + c + "lv" + t);
		bg.GetComponent<Renderer>().material = (Material)Resources.Load("bg/bg" + c);
	}

	public virtual void SpawnDesert()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 == 0)
			{
				SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 >= 10)
			{
				if (num2 < 13)
				{
					SpawnCactus(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 25)
				{
					SpawnSpire(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 35)
				{
					SpawnSnake(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 50)
				{
					SpawnSnake(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 60)
				{
					SpawnOre(slot[num].transform.TransformPoint(Vector3.right));
				}
				else
				{
					SpawnTreeDesert(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if (top[num] != null && UnityEngine.Random.Range(0, 6) == 0)
			{
				SpawnTopSpire(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public virtual void SpawnSwamp()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 == 0)
			{
				SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 2)
			{
				SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 10)
			{
				SpawnGas(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 13)
			{
				SpawnPlantSwamp(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 25)
			{
				SpawnTreeSwamp(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 35)
			{
				SpawnSnail(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 50)
			{
				SpawnSwampEnemy(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 60)
			{
				SpawnOre(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 3) == 0)
				{
					SpawnSwampEnemy(slot[num].transform.TransformPoint(Vector3.right));
				}
				if (UnityEngine.Random.Range(0, 7) == 0)
				{
					SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else
			{
				SpawnTreeSwamp(slot[num].transform.TransformPoint(Vector3.right));
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if (!(top[num] != null) || UnityEngine.Random.Range(0, 10) == 0)
			{
			}
		}
	}

	public virtual void SpawnCrystal()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 < 2)
			{
				if (UnityEngine.Random.Range(0, 3) == 0)
				{
					SpawnDopple(slot[num].transform.TransformPoint(Vector3.right));
				}
				else
				{
					SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else if (num2 < 4)
			{
				SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
			}
			else
			{
				if (num2 < 10)
				{
					continue;
				}
				if (num2 < 13)
				{
					SpawnCrystalPlant(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 25)
				{
					int num3 = UnityEngine.Random.Range(0, 3);
					if (num3 < 2)
					{
						SpawnTreeCrystal(slot[num].transform.TransformPoint(Vector3.right));
					}
					else
					{
						SpawnCrystalHazard(slot[num].transform.TransformPoint(Vector3.right));
					}
				}
				else if (num2 < 35)
				{
					SpawnCrystalEnemy(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 50)
				{
					SpawnCrystalEnemy(slot[num].transform.TransformPoint(Vector3.right));
					if (UnityEngine.Random.Range(0, 8) == 0)
					{
						SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
					}
				}
				else if (num2 < 60)
				{
					SpawnOre(slot[num].transform.TransformPoint(Vector3.right));
				}
				else
				{
					int num4 = UnityEngine.Random.Range(0, 3);
					if (num4 < 2)
					{
						SpawnTreeCrystal(slot[num].transform.TransformPoint(Vector3.right));
					}
					else
					{
						SpawnCrystalHazard(slot[num].transform.TransformPoint(Vector3.right));
					}
				}
			}
		}
	}

	public virtual void SpawnCrater()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 == 0)
			{
				SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 2)
			{
				SpawnFlameCrater(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 10)
			{
				SpawnFlameCrater(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 13)
			{
				SpawnFlameCrater(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 25)
			{
				SpawnTreeCrater(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 35)
			{
				SpawnCraterEnemy(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 50)
			{
				SpawnCraterEnemy(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 6) == 0)
				{
					SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else if (num2 < 60)
			{
				SpawnOre(slot[num].transform.TransformPoint(Vector3.right));
			}
			else
			{
				SpawnTreeCrater(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 5) == 0)
				{
					SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
		}
	}

	public virtual void SpawnCraterEnemy(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 45);
		if (num < 16)
		{
			SpawnButterfly(pos);
		}
		else if (num < 44)
		{
			SpawnSkelCrater(pos);
		}
		else
		{
			SpawnCommander(pos);
		}
	}

	public virtual void SpawnGrass()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 == 0)
			{
				switch (UnityEngine.Random.Range(0, 3))
				{
				case 0:
					SpawnHive(slot[num].transform.TransformPoint(Vector3.right));
					break;
				case 1:
					SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
					break;
				default:
					SpawnPercyl(slot[num].transform.TransformPoint(Vector3.right));
					break;
				}
			}
			else if (num2 < 2)
			{
				SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 10)
			{
				SpawnVines(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 13)
			{
				SpawnPlant(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 25)
			{
				SpawnTree(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 35)
			{
				SpawnBison(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 50)
			{
				SpawnGrassEnemy(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 2) == 0)
				{
					SpawnVines(slot[num].transform.TransformPoint(Vector3.right));
				}
				if (UnityEngine.Random.Range(0, 8) == 0)
				{
					SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else if (num2 < 60)
			{
				SpawnOre(slot[num].transform.TransformPoint(Vector3.right));
			}
			else
			{
				SpawnTree(slot[num].transform.TransformPoint(Vector3.right));
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if (top[num] != null && UnityEngine.Random.Range(0, 10) == 0)
			{
				SpawnTopVines(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public virtual void SpawnDungeon()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 < 2)
			{
				SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 5) == 0)
				{
					SpawnKing(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else if (num2 < 10)
			{
				SpawnBall(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 13)
			{
				SpawnDungeonEnemy(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 25)
			{
				SpawnPillar(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 4) == 0)
				{
					SpawnOre2(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else
			{
				if (num2 < 35)
				{
					continue;
				}
				if (num2 < 50)
				{
					SpawnDungeonEnemy(slot[num].transform.TransformPoint(Vector3.right));
					if (UnityEngine.Random.Range(0, 4) == 0)
					{
						SpawnBall(slot[num].transform.TransformPoint(Vector3.right));
					}
				}
				else if (num2 < 60)
				{
					SpawnOre2(slot[num].transform.TransformPoint(Vector3.right));
				}
				else
				{
					if (UnityEngine.Random.Range(0, 3) == 0)
					{
						SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
					}
					SpawnPillar(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if (!(top[num] != null) || UnityEngine.Random.Range(0, 10) == 0)
			{
			}
		}
	}

	public virtual void SpawnVeldt()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 == 0)
			{
				continue;
			}
			if (num2 < 2)
			{
				SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
			}
			else
			{
				if (num2 < 10)
				{
					continue;
				}
				if (num2 < 13)
				{
					SpawnPlantVeldt(slot[num].transform.TransformPoint(Vector3.right));
					continue;
				}
				if (num2 < 25)
				{
					SpawnTreeVeldt(slot[num].transform.TransformPoint(Vector3.right));
					SpawnSheep(slot[num].transform.TransformPoint(Vector3.right));
					continue;
				}
				if (num2 < 35)
				{
					SpawnSheep(slot[num].transform.TransformPoint(Vector3.right));
					continue;
				}
				if (num2 < 50)
				{
					SpawnVeldtEnemy(slot[num].transform.TransformPoint(Vector3.right));
					continue;
				}
				if (num2 < 60)
				{
					SpawnOre2(slot[num].transform.TransformPoint(Vector3.right));
					continue;
				}
				SpawnTreeVeldt(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 3) == 0)
				{
					SpawnVeldtEnemy(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if (top[num] != null && UnityEngine.Random.Range(0, 10) == 0)
			{
				SpawnTopShroom(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public virtual void SpawnLava()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 == 0)
			{
				SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 2) == 0)
				{
					SpawnBlackDragon(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else if (num2 < 2)
			{
				SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 10)
			{
				SpawnPlantFire(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 13)
			{
				SpawnOre2(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 25)
			{
				SpawnFlame(slot[num].transform.TransformPoint(Vector3.right));
			}
			else
			{
				if (num2 < 35)
				{
					continue;
				}
				if (num2 < 50)
				{
					SpawnLavaEnemy(slot[num].transform.TransformPoint(Vector3.right));
					SpawnOre2(slot[num].transform.TransformPoint(Vector3.right));
					continue;
				}
				if (num2 < 60)
				{
					SpawnOre2(slot[num].transform.TransformPoint(Vector3.right));
					if (UnityEngine.Random.Range(0, 4) == 0)
					{
						SpawnLavaEnemy(slot[num].transform.TransformPoint(Vector3.right));
					}
					continue;
				}
				switch (UnityEngine.Random.Range(0, 7))
				{
				case 0:
					SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
					break;
				case 1:
					SpawnLavaEnemy(slot[num].transform.TransformPoint(Vector3.right));
					break;
				}
				SpawnTreeLava(slot[num].transform.TransformPoint(Vector3.right));
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if (top[num] != null && UnityEngine.Random.Range(0, 10) == 0)
			{
				SpawnTopShroom(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public virtual void SpawnFinal()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 == 0)
			{
				continue;
			}
			if (num2 < 10)
			{
				SpawnOreDark(slot[num].transform.TransformPoint(Vector3.right));
				continue;
			}
			if (num2 < 13)
			{
				SpawnOreDark(slot[num].transform.TransformPoint(Vector3.right));
				continue;
			}
			if (num2 < 25)
			{
				SpawnTreeFinal(slot[num].transform.TransformPoint(Vector3.right));
				continue;
			}
			if (num2 < 35)
			{
				SpawnFinalEnemy(slot[num].transform.TransformPoint(Vector3.right));
				continue;
			}
			if (num2 < 50)
			{
				SpawnFinalEnemy(slot[num].transform.TransformPoint(Vector3.right));
				continue;
			}
			if (num2 < 60)
			{
				SpawnOreDark(slot[num].transform.TransformPoint(Vector3.right));
				continue;
			}
			SpawnTreeFinal(slot[num].transform.TransformPoint(Vector3.right));
			if (UnityEngine.Random.Range(0, 3) == 0)
			{
				SpawnFinalEnemy(slot[num].transform.TransformPoint(Vector3.right));
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if (top[num] != null && UnityEngine.Random.Range(0, 10) == 0)
			{
				SpawnTopShroom(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public virtual void SpawnSnowEnemy(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 50);
		GameObject gameObject = null;
		if (Network.isServer)
		{
			if (num < 20)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/slimeIce"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
			else if (num < 35)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/fairy"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
			else if (num < 47)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/iceKnight"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
			else
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/bigYeti"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
		}
	}

	public virtual void SpawnLavaEnemy(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 11);
		GameObject gameObject = null;
		if (Network.isServer)
		{
			if (num < 3)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/whelp"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
			else if (num < 7)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/skeletonRed"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
			else
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/lavaBison"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
		}
	}

	public virtual void SpawnVeldtEnemy(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 20);
		GameObject gameObject = null;
		if (Network.isServer)
		{
			if (num < 8)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/shroomBaby"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
			else if (num < 12)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/jelly"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
			else if (num < 14)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/shroom"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
			else
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/shroomMage"), pos, Quaternion.identity, 0);
				gameObject.transform.parent = transform;
			}
		}
	}

	public virtual void SpawnDungeonEnemy(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 12);
		GameObject gameObject = null;
		if (!Network.isServer)
		{
			return;
		}
		if (num < 7)
		{
			if (UnityEngine.Random.Range(0, 3) == 0)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/sKnight"), pos, Quaternion.identity, 0);
			}
			else
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/sArcher"), pos, Quaternion.identity, 0);
			}
		}
		else if (num < 9)
		{
			gameObject = (GameObject)Network.Instantiate(Resources.Load("e/mino"), pos, Quaternion.identity, 0);
		}
		else
		{
			gameObject = (GameObject)Network.Instantiate(Resources.Load("e/djin"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnSwampEnemy(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 11);
		GameObject gameObject = null;
		if (Network.isServer)
		{
			if (num < 5)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/Gob"), pos, Quaternion.identity, 0);
			}
			else if (num < 7)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/Gob"), pos, Quaternion.identity, 0);
			}
			else
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/chief"), pos, Quaternion.identity, 0);
			}
		}
	}

	public virtual void SpawnFinalEnemy(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 11);
		GameObject gameObject = null;
		if (Network.isServer)
		{
			if (num < 5)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/ghoul"), pos, Quaternion.identity, 0);
			}
			else if (num < 7)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/blueWorm"), pos, Quaternion.identity, 0);
			}
			else
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("e/fallenKnight"), pos, Quaternion.identity, 0);
			}
		}
	}

	public virtual void SpawnCrystalEnemy(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 40);
		if (!Network.isServer)
		{
			return;
		}
		if (num == 0)
		{
			Network.Instantiate(Resources.Load("e/golem"), pos, Quaternion.identity, 0);
		}
		else if (num >= 3)
		{
			if (num < 22)
			{
				Network.Instantiate(Resources.Load("e/batCrystal"), pos, Quaternion.identity, 0);
				Network.Instantiate(Resources.Load("e/snailCrystal"), pos, Quaternion.identity, 0);
			}
			else
			{
				Network.Instantiate(Resources.Load("e/golem"), pos, Quaternion.identity, 0);
			}
		}
	}

	public virtual void SpawnCaveEnemy(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 50);
		if (!Network.isServer)
		{
			return;
		}
		if (num == 0)
		{
			Network.Instantiate(Resources.Load("e/spider"), pos, Quaternion.identity, 0);
		}
		else if (num >= 3)
		{
			if (num < 22)
			{
				Network.Instantiate(Resources.Load("e/bat"), pos, Quaternion.identity, 0);
			}
			else
			{
				Network.Instantiate(Resources.Load("e/spider"), pos, Quaternion.identity, 0);
			}
		}
	}

	public virtual void SpawnGrassEnemy(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 34);
		if (num < 17)
		{
			SpawnSlime(pos);
		}
		else if (num < 22)
		{
			SpawnWasp(pos);
		}
		else if (num < 28)
		{
			SpawnBoar(pos);
		}
		else if (num < 33)
		{
			SpawnGrassSpider(pos);
		}
		else
		{
			SpawnTyrannox(pos);
		}
	}

	public virtual void SpawnCrystalHazard(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 3);
		if (num < 2 && Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/crystalSpike"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnGrassHazard(Vector3 pos)
	{
		int num = UnityEngine.Random.Range(0, 3);
		if (num < 2)
		{
			if (Network.isServer)
			{
				GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/shooter"), pos, Quaternion.identity, 0);
			}
		}
		else if (Network.isServer)
		{
			GameObject gameObject2 = (GameObject)Network.Instantiate(Resources.Load("haz/spinBlade"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnCave()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 < 3)
			{
				SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 4)
			{
				SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 20)
			{
				SpawnTreeCave(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 25)
			{
				SpawnEgg(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 35)
			{
				SpawnEgg(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 50)
			{
				SpawnCaveEnemy(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 6) == 0)
				{
					SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else if (num2 < 80)
			{
				if (UnityEngine.Random.Range(0, 2) == 0)
				{
					SpawnOre(slot[num].transform.TransformPoint(Vector3.right));
				}
				else
				{
					SpawnTreeCave(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else
			{
				SpawnCaveEnemy(slot[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public virtual void SpawnSnow()
	{
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!(slot[num] != null))
			{
				continue;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			if (num2 == 0)
			{
				SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 3) == 0)
				{
					SpawnQueen(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else if (num2 < 2)
			{
				SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 7)
			{
				SpawnSpikes(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 13)
			{
				SpawnPlantSnow(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 25)
			{
				SpawnSnowTree(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 35)
			{
				if (UnityEngine.Random.Range(0, 2) == 0)
				{
					SpawnSnowEnemy(slot[num].transform.TransformPoint(Vector3.right));
				}
				SpawnBunny(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 50)
			{
				SpawnSnowEnemy(slot[num].transform.TransformPoint(Vector3.right));
				if (UnityEngine.Random.Range(0, 7) == 0)
				{
					SpawnSpikes(slot[num].transform.TransformPoint(Vector3.right));
				}
				if (UnityEngine.Random.Range(0, 4) == 0)
				{
					SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else if (num2 < 60)
			{
				SpawnOre(slot[num].transform.TransformPoint(Vector3.right));
			}
			else
			{
				SpawnSnowTree(slot[num].transform.TransformPoint(Vector3.right));
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if (!(top[num] != null) || UnityEngine.Random.Range(0, 10) == 0)
			{
			}
		}
	}

	public virtual void SpawnSkelBoss(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/bear"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnSkeleton(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/skel"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnSnake(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/snake"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnSkelCrater(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/skelCrater"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnButterfly(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/butterfly"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnSlime(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/slime"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnGrassSpider(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/spiderGrass"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnBoar(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/boar"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTyrannox(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/tyrannox"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnCommander(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/commander"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnWasp(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/wasp"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnSkeletonMage(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/skelMage"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnBunny(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/bunny"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnBison(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/pig"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnSnail(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/snail"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnSheep(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/sheep"), pos, Quaternion.identity, 0);
			gameObject.transform.parent = transform;
		}
	}

	public virtual void SpawnOreDark(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dCrystalite"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnOreLegend(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = null;
			switch (UnityEngine.Random.Range(0, 3))
			{
			case 0:
				gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dDragonite"), pos, Quaternion.identity, 0);
				break;
			case 1:
				gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dAdamantite"), pos, Quaternion.identity, 0);
				break;
			default:
				gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dObsidian"), pos, Quaternion.identity, 0);
				break;
			}
		}
	}

	public virtual void SpawnOre(Vector3 pos)
	{
		if (!Network.isServer)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, 10);
		if (GameScript.curBiome == 0)
		{
			num = 1;
		}
		if (num == 0)
		{
			Network.Instantiate(Resources.Load("e/OreSpider"), pos, Quaternion.identity, 0);
			return;
		}
		GameObject gameObject = null;
		int num2 = UnityEngine.Random.Range(0, 100);
		if (num2 < 80)
		{
			gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dIron"), pos, Quaternion.identity, 0);
		}
		else if (num2 < 95)
		{
			gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dGold"), pos, Quaternion.identity, 0);
		}
		else
		{
			gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dDiamonite"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnOre2(Vector3 pos)
	{
		if (!Network.isServer)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, 20);
		if (GameScript.curBiome == 0)
		{
			num = 1;
		}
		if (num == 0)
		{
			Network.Instantiate(Resources.Load("e/OreSpider"), pos, Quaternion.identity, 0);
			return;
		}
		GameObject gameObject = null;
		int num2 = UnityEngine.Random.Range(0, 100);
		if (num2 < 48)
		{
			gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dIron"), pos, Quaternion.identity, 0);
		}
		else if (num2 < 84)
		{
			gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dGold"), pos, Quaternion.identity, 0);
		}
		else
		{
			gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dDiamonite"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnPercyl(Vector3 pos)
	{
		if (Network.isServer && GameScript.districtLevel >= 2)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/percyl"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnQueen(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/fQueen"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnDopple(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/scourgeKnight"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnBlackDragon(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/blackDragon"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnKing(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("e/king"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnFlameCrater(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/flameCrater"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnFlame(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/flame"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTreeCrystal(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/treeCrystal"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTreeCrater(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/treeCrater"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTree(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/tree"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTreeCave(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/treeCave"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTreeSwamp(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/treeSwamp"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTreeFinal(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/treeFinal"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTreeVeldt(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/treeVeldt"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTreeLava(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/treeLava"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnCactus(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/cactus"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTreeDesert(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/treeDesert"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnCrystalPlant(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/plantCrystal"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnPlantFire(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/plantFire"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnPlantSwamp(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/plantSwamp"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnPlantSnow(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/plantSnow"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnBug(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/bugSpot"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnPlant(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/plant"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnPlantVeldt(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/plantVeldt"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnSnowTree(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/treeSnow"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnPillar(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/pillar"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnFairyGem(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/fairyGem"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnDragonGem(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/dragonGem"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnEgg(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/spiderEgg"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnSpikes(Vector3 pos)
	{
		if (Network.isServer)
		{
			int num = UnityEngine.Random.Range(0, 2);
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/snowSpawner"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnGas(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/Gas"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnHive(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/beeHive"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnBall(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/ballSpike"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnVines(Vector3 pos)
	{
		if (Network.isServer)
		{
			if (UnityEngine.Random.Range(0, 2) == 0)
			{
				GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/vines"), pos, Quaternion.identity, 0);
			}
			else
			{
				GameObject gameObject2 = (GameObject)Network.Instantiate(Resources.Load("haz/vines2"), pos, Quaternion.identity, 0);
			}
		}
	}

	public virtual void SpawnTopVines(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/vinesTop"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTopShroom(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("haz/shroomTop"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnTopLantern(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("lanternTop"), pos, Quaternion.Euler(0f, 0f, 0f), 0);
		}
	}

	public virtual void SpawnTopSpire(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("spireTop"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnSpire(Vector3 pos)
	{
		if (Network.isServer)
		{
			GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("spireBottom"), pos, Quaternion.identity, 0);
		}
	}

	public virtual void SpawnChest(Vector3 pos)
	{
		if (Network.isServer)
		{
			if (UnityEngine.Random.Range(0, 8) == 0)
			{
				GameObject gameObject = (GameObject)Network.Instantiate(Resources.Load("interact/chest2"), pos, Quaternion.identity, 0);
			}
			else
			{
				GameObject gameObject2 = (GameObject)Network.Instantiate(Resources.Load("interact/chest"), pos, Quaternion.identity, 0);
			}
		}
	}

	}