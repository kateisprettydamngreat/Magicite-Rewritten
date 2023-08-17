using System;
using UnityEngine;

[Serializable]
public class SpawnScript : MonoBehaviour
{
	public GameObject[] particle;

	public GameObject[] slot;

	public GameObject[] top;

	public GameObject bg;

	public int zType;

	private int[] slotInt;

	private int curTownStyle;

	public SpawnScript()
	{
		particle = (GameObject[])(object)new GameObject[20];
		slot = (GameObject[])(object)new GameObject[18];
		top = (GameObject[])(object)new GameObject[10];
		slotInt = new int[20];
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
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				((Component)this).networkView.RPC("Init", (RPCMode)6, new object[2]
				{
					GameScript.curBiome,
					zType
				});
			}
		}
		else
		{
			particle[GameScript.curBiome].SetActive(true);
			((Component)this).renderer.material = (Material)Resources.Load("lv/b" + (object)GameScript.curBiome + "lv" + (object)zType);
			bg.renderer.material = (Material)Resources.Load("bg/bg" + (object)GameScript.curBiome);
		}
	}

	public override void Start()
	{
		if (GameScript.isTown)
		{
			SpawnTown();
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

	[RPC]
	public override void Init(int c, int t)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		particle[GameScript.curBiome].SetActive(true);
		((Component)this).renderer.material = (Material)Resources.Load("lv/b" + (object)c + "lv" + (object)t);
		bg.renderer.material = (Material)Resources.Load("bg/bg" + (object)c);
	}

	public override void SpawnTown()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer != 1)
		{
			return;
		}
		int num = default(int);
		curTownStyle = Random.Range(0, 1);
		Network.Instantiate(Resources.Load("npc/npc" + (object)1), slot[1].transform.position, Quaternion.identity, 0);
		Network.Instantiate(Resources.Load("house/hBlacksmith"), slot[1].transform.position, Quaternion.identity, 0);
		Network.Instantiate(Resources.Load("npc/npc" + (object)2), slot[3].transform.position, Quaternion.identity, 0);
		Network.Instantiate(Resources.Load("npc/npc" + (object)2), slot[9].transform.position, Quaternion.identity, 0);
		Network.Instantiate(Resources.Load("npc/npc" + (object)3), slot[6].transform.position, Quaternion.identity, 0);
		Network.Instantiate(Resources.Load("house/hLeatherworker"), slot[6].transform.position, Quaternion.identity, 0);
		Network.Instantiate(Resources.Load("npc/npc" + (object)4), slot[12].transform.position, Quaternion.identity, 0);
		Network.Instantiate(Resources.Load("house/hTailor"), slot[12].transform.position, Quaternion.identity, 0);
		Network.Instantiate(Resources.Load("npc/npc" + (object)5), slot[14].transform.position, Quaternion.identity, 0);
		Network.Instantiate(Resources.Load("house/hHoarder"), slot[14].transform.position, Quaternion.identity, 0);
		for (num = 0; num < slot.Length - 2; num += 3)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 3);
			if (num2 < 2 && MenuScript.multiplayer == 1)
			{
				if (Network.isServer)
				{
					Network.Instantiate(Resources.Load("npc/m" + (object)1), slot[num].transform.position, Quaternion.identity, 0);
					Network.Instantiate(Resources.Load("house/h" + (object)Random.Range(1, 3) + "s1"), slot[num].transform.position, Quaternion.identity, 0);
				}
				continue;
			}
			switch (Random.Range(0, 3))
			{
			case 0:
				Network.Instantiate(Resources.Load("e/chick"), slot[num].transform.position, Quaternion.identity, 0);
				Network.Instantiate(Resources.Load("e/chick"), slot[num].transform.position, Quaternion.identity, 0);
				break;
			case 1:
				Network.Instantiate(Resources.Load("e/chick"), slot[num].transform.position, Quaternion.identity, 0);
				break;
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if ((Object)(object)top[num] != (Object)null && Random.Range(0, 3) == 0)
			{
				SpawnTopLantern(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public override void SpawnDesert()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
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
			if ((Object)(object)top[num] != (Object)null && Random.Range(0, 6) == 0)
			{
				SpawnTopSpire(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public override void SpawnSwamp()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
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
				if (Random.Range(0, 3) == 0)
				{
					SpawnSwampEnemy(slot[num].transform.TransformPoint(Vector3.right));
				}
				if (Random.Range(0, 7) == 0)
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
			if (!((Object)(object)top[num] != (Object)null) || Random.Range(0, 10) == 0)
			{
			}
		}
	}

	public override void SpawnCrystal()
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
			if (num2 < 2)
			{
				if (Random.Range(0, 3) == 0)
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
					int num3 = Random.Range(0, 3);
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
					if (Random.Range(0, 8) == 0)
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
					int num4 = Random.Range(0, 3);
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

	public override void SpawnCrater()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
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
				if (Random.Range(0, 6) == 0)
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
				if (Random.Range(0, 5) == 0)
				{
					SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
		}
	}

	public override void SpawnCraterEnemy(Vector3 pos)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(0, 45);
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

	public override void SpawnGrass()
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
			if (num2 == 0)
			{
				switch (Random.Range(0, 3))
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
				if (Random.Range(0, 2) == 0)
				{
					SpawnVines(slot[num].transform.TransformPoint(Vector3.right));
				}
				if (Random.Range(0, 8) == 0)
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
			if ((Object)(object)top[num] != (Object)null && Random.Range(0, 10) == 0)
			{
				SpawnTopVines(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public override void SpawnDungeon()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
			if (num2 < 2)
			{
				SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
				if (Random.Range(0, 5) == 0)
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
				if (Random.Range(0, 4) == 0)
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
					if (Random.Range(0, 4) == 0)
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
					if (Random.Range(0, 3) == 0)
					{
						SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
					}
					SpawnPillar(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if (!((Object)(object)top[num] != (Object)null) || Random.Range(0, 10) == 0)
			{
			}
		}
	}

	public override void SpawnVeldt()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
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
				if (Random.Range(0, 3) == 0)
				{
					SpawnVeldtEnemy(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if ((Object)(object)top[num] != (Object)null && Random.Range(0, 10) == 0)
			{
				SpawnTopShroom(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public override void SpawnLava()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
			if (num2 == 0)
			{
				SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
				if (Random.Range(0, 2) == 0)
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
					if (Random.Range(0, 4) == 0)
					{
						SpawnLavaEnemy(slot[num].transform.TransformPoint(Vector3.right));
					}
					continue;
				}
				switch (Random.Range(0, 7))
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
			if ((Object)(object)top[num] != (Object)null && Random.Range(0, 10) == 0)
			{
				SpawnTopShroom(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public override void SpawnFinal()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
			if (num2 != 0)
			{
				if (num2 < 10)
				{
					SpawnOreDark(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 13)
				{
					SpawnOreDark(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 25)
				{
					SpawnTreeFinal(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 35)
				{
					SpawnFinalEnemy(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 50)
				{
					SpawnFinalEnemy(slot[num].transform.TransformPoint(Vector3.right));
				}
				else if (num2 < 60)
				{
					SpawnOreDark(slot[num].transform.TransformPoint(Vector3.right));
				}
				else
				{
					SpawnTreeFinal(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
		}
		for (num = 0; num < top.Length; num++)
		{
			if ((Object)(object)top[num] != (Object)null && Random.Range(0, 10) == 0)
			{
				SpawnTopShroom(top[num].transform.TransformPoint(Vector3.right));
			}
		}
	}

	public override void SpawnSnowEnemy(Vector3 pos)
	{
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		int num = Random.Range(0, 50);
		GameObject val = null;
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				if (num < 20)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/slimeIce"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
				else if (num < 35)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/fairy"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
				else if (num < 47)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/iceKnight"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
				else
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/bigYeti"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
			}
		}
		else if (num < 10)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/slimeIce"), pos, Quaternion.identity);
			val.transform.parent = ((Component)this).transform;
		}
		else
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/yeti"), pos, Quaternion.identity);
			val.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnLavaEnemy(Vector3 pos)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		int num = Random.Range(0, 11);
		GameObject val = null;
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				if (num < 3)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/whelp"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
				else if (num < 7)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/skeletonRed"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
				else
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/lavaBison"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
			}
		}
		else if (num < 5)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/whelp"), pos, Quaternion.identity);
			val.transform.parent = ((Component)this).transform;
		}
		else if (num < 7)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/lavaBison"), pos, Quaternion.identity);
			val.transform.parent = ((Component)this).transform;
		}
		else
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/lavaBison"), pos, Quaternion.identity);
			val.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnVeldtEnemy(Vector3 pos)
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		int num = Random.Range(0, 20);
		GameObject val = null;
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				if (num < 8)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/shroomBaby"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
				else if (num < 12)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/jelly"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
				else if (num < 14)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/shroom"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
				else
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/shroomMage"), pos, Quaternion.identity, 0);
					val.transform.parent = ((Component)this).transform;
				}
			}
		}
		else if (num < 5)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/shroomBaby"), pos, Quaternion.identity);
			val.transform.parent = ((Component)this).transform;
		}
		else if (num < 7)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/shroom"), pos, Quaternion.identity);
			val.transform.parent = ((Component)this).transform;
		}
		else
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/shroomMage"), pos, Quaternion.identity);
			val.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnDungeonEnemy(Vector3 pos)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		int num = Random.Range(0, 12);
		GameObject val = null;
		if (MenuScript.multiplayer <= 0 || !Network.isServer)
		{
			return;
		}
		if (num < 7)
		{
			if (Random.Range(0, 3) == 0)
			{
				val = (GameObject)Network.Instantiate(Resources.Load("e/sKnight"), pos, Quaternion.identity, 0);
			}
			else
			{
				val = (GameObject)Network.Instantiate(Resources.Load("e/sArcher"), pos, Quaternion.identity, 0);
			}
		}
		else if (num < 9)
		{
			val = (GameObject)Network.Instantiate(Resources.Load("e/mino"), pos, Quaternion.identity, 0);
		}
		else
		{
			val = (GameObject)Network.Instantiate(Resources.Load("e/djin"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnSwampEnemy(Vector3 pos)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		int num = Random.Range(0, 11);
		GameObject val = null;
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				if (num < 5)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/Gob"), pos, Quaternion.identity, 0);
				}
				else if (num < 7)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/Gob"), pos, Quaternion.identity, 0);
				}
				else
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/chief"), pos, Quaternion.identity, 0);
				}
			}
		}
		else if (num < 5)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/Gob"), pos, Quaternion.identity);
		}
		else if (num < 7)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/Gob"), pos, Quaternion.identity);
		}
		else
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/chief"), pos, Quaternion.identity);
		}
	}

	public override void SpawnFinalEnemy(Vector3 pos)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		int num = Random.Range(0, 11);
		GameObject val = null;
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				if (num < 5)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/ghoul"), pos, Quaternion.identity, 0);
				}
				else if (num < 7)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/blueWorm"), pos, Quaternion.identity, 0);
				}
				else
				{
					val = (GameObject)Network.Instantiate(Resources.Load("e/fallenKnight"), pos, Quaternion.identity, 0);
				}
			}
		}
		else if (num < 5)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/ghoul"), pos, Quaternion.identity);
		}
		else if (num < 7)
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/blueWorm"), pos, Quaternion.identity);
		}
		else
		{
			val = (GameObject)Object.Instantiate(Resources.Load("e/fallenKnight"), pos, Quaternion.identity);
		}
	}

	public override void SpawnCrystalEnemy(Vector3 pos)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(0, 40);
		if (MenuScript.multiplayer <= 0 || !Network.isServer)
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

	public override void SpawnCaveEnemy(Vector3 pos)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(0, 50);
		if (MenuScript.multiplayer > 0)
		{
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
		else
		{
			GameObject val = (GameObject)Object.Instantiate(Resources.Load("e/spider"), pos, Quaternion.identity);
			val.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnGrassEnemy(Vector3 pos)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(0, 34);
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

	public override void SpawnCrystalHazard(Vector3 pos)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		int num = Random.Range(0, 3);
		if (num < 2 && MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/crystalSpike"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnGrassHazard(Vector3 pos)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		int num = Random.Range(0, 3);
		if (num < 2)
		{
			if (MenuScript.multiplayer > 0 && Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/shooter"), pos, Quaternion.identity, 0);
			}
		}
		else if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val2 = (GameObject)Network.Instantiate(Resources.Load("haz/spinBlade"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val3 = (GameObject)Object.Instantiate(Resources.Load("haz/spinBlade"), pos, Quaternion.identity);
		}
	}

	public override void SpawnCave()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
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
				if (Random.Range(0, 6) == 0)
				{
					SpawnBug(slot[num].transform.TransformPoint(Vector3.right));
				}
			}
			else if (num2 < 80)
			{
				if (Random.Range(0, 2) == 0)
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

	public override void SpawnSnow()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		for (num = 0; num < slot.Length; num++)
		{
			if (!((Object)(object)slot[num] != (Object)null))
			{
				continue;
			}
			int num2 = Random.Range(0, 100);
			if (num2 == 0)
			{
				SpawnChest(slot[num].transform.TransformPoint(Vector3.right));
				if (Random.Range(0, 3) == 0)
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
				if (Random.Range(0, 2) == 0)
				{
					SpawnSnowEnemy(slot[num].transform.TransformPoint(Vector3.right));
				}
				SpawnBunny(slot[num].transform.TransformPoint(Vector3.right));
			}
			else if (num2 < 50)
			{
				SpawnSnowEnemy(slot[num].transform.TransformPoint(Vector3.right));
				if (Random.Range(0, 7) == 0)
				{
					SpawnSpikes(slot[num].transform.TransformPoint(Vector3.right));
				}
				if (Random.Range(0, 4) == 0)
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
			if (!((Object)(object)top[num] != (Object)null) || Random.Range(0, 10) == 0)
			{
			}
		}
	}

	public override void SpawnSkelBoss(Vector3 pos)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/bear"), pos, Quaternion.identity, 0);
				val.transform.parent = ((Component)this).transform;
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("e/bear"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnSkeleton(Vector3 pos)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/skel"), pos, Quaternion.identity, 0);
				val.transform.parent = ((Component)this).transform;
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("e/skel"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnSnake(Vector3 pos)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/snake"), pos, Quaternion.identity, 0);
				val.transform.parent = ((Component)this).transform;
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("e/snake"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnSkelCrater(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/skelCrater"), pos, Quaternion.identity, 0);
			val.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnButterfly(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/butterfly"), pos, Quaternion.identity, 0);
			val.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnSlime(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/slime"), pos, Quaternion.identity, 0);
			val.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnGrassSpider(Vector3 pos)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/spiderGrass"), pos, Quaternion.identity, 0);
				val.transform.parent = ((Component)this).transform;
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("e/spiderGrass"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnBoar(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/boar"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnTyrannox(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/tyrannox"), pos, Quaternion.identity, 0);
			val.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnCommander(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/commander"), pos, Quaternion.identity, 0);
			val.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnWasp(Vector3 pos)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/wasp"), pos, Quaternion.identity, 0);
				val.transform.parent = ((Component)this).transform;
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("e/wasp"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnSkeletonMage(Vector3 pos)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/skelMage"), pos, Quaternion.identity, 0);
				val.transform.parent = ((Component)this).transform;
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("e/skelMage"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnBunny(Vector3 pos)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/bunny"), pos, Quaternion.identity, 0);
				val.transform.parent = ((Component)this).transform;
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("e/bunny"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnBison(Vector3 pos)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/pig"), pos, Quaternion.identity, 0);
				val.transform.parent = ((Component)this).transform;
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("e/pig"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnSnail(Vector3 pos)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/snail"), pos, Quaternion.identity, 0);
				val.transform.parent = ((Component)this).transform;
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("e/snail"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnSheep(Vector3 pos)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/sheep"), pos, Quaternion.identity, 0);
				val.transform.parent = ((Component)this).transform;
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("e/sheep"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnOreDark(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/dCrystalite"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/dCrystalite"), pos, Quaternion.identity);
		}
	}

	public override void SpawnOreLegend(Vector3 pos)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = null;
				switch (Random.Range(0, 3))
				{
				case 0:
					val = (GameObject)Network.Instantiate(Resources.Load("interact/dDragonite"), pos, Quaternion.identity, 0);
					break;
				case 1:
					val = (GameObject)Network.Instantiate(Resources.Load("interact/dAdamantite"), pos, Quaternion.identity, 0);
					break;
				default:
					val = (GameObject)Network.Instantiate(Resources.Load("interact/dObsidian"), pos, Quaternion.identity, 0);
					break;
				}
			}
		}
		else
		{
			GameObject val2 = null;
			((GameObject)(Random.Range(0, 3) switch
			{
				0 => (object)(GameObject)Object.Instantiate(Resources.Load("interact/dDragonite"), pos, Quaternion.identity), 
				1 => (object)(GameObject)Object.Instantiate(Resources.Load("interact/dAdamantite"), pos, Quaternion.identity), 
				_ => (object)(GameObject)Object.Instantiate(Resources.Load("interact/dObsidian"), pos, Quaternion.identity), 
			})).transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnOre(Vector3 pos)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		if (MenuScript.multiplayer <= 0 || !Network.isServer)
		{
			return;
		}
		int num = Random.Range(0, 10);
		if (GameScript.curBiome == 0)
		{
			num = 1;
		}
		if (num == 0)
		{
			Network.Instantiate(Resources.Load("e/OreSpider"), pos, Quaternion.identity, 0);
			return;
		}
		GameObject val = null;
		int num2 = Random.Range(0, 100);
		if (num2 < 80)
		{
			val = (GameObject)Network.Instantiate(Resources.Load("interact/dIron"), pos, Quaternion.identity, 0);
		}
		else if (num2 < 95)
		{
			val = (GameObject)Network.Instantiate(Resources.Load("interact/dGold"), pos, Quaternion.identity, 0);
		}
		else
		{
			val = (GameObject)Network.Instantiate(Resources.Load("interact/dDiamonite"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnOre2(Vector3 pos)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		if (MenuScript.multiplayer <= 0 || !Network.isServer)
		{
			return;
		}
		int num = Random.Range(0, 20);
		if (GameScript.curBiome == 0)
		{
			num = 1;
		}
		if (num == 0)
		{
			Network.Instantiate(Resources.Load("e/OreSpider"), pos, Quaternion.identity, 0);
			return;
		}
		GameObject val = null;
		int num2 = Random.Range(0, 100);
		if (num2 < 48)
		{
			val = (GameObject)Network.Instantiate(Resources.Load("interact/dIron"), pos, Quaternion.identity, 0);
		}
		else if (num2 < 84)
		{
			val = (GameObject)Network.Instantiate(Resources.Load("interact/dGold"), pos, Quaternion.identity, 0);
		}
		else
		{
			val = (GameObject)Network.Instantiate(Resources.Load("interact/dDiamonite"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnPercyl(Vector3 pos)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer && GameScript.districtLevel >= 2)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/percyl"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnQueen(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/fQueen"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnDopple(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/scourgeKnight"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnBlackDragon(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/blackDragon"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnKing(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("e/king"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnFlameCrater(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/flameCrater"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnFlame(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/flame"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnTreeCrystal(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/treeCrystal"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnTreeCrater(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/treeCrater"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnTree(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/tree"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnTreeCave(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/treeCave"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnTreeSwamp(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/treeSwamp"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/treeSwamp"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnTreeFinal(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/treeFinal"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/treeFinal"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnTreeVeldt(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/treeVeldt"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/treeVeldt"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnTreeLava(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/treeLava"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/treeLava"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnCactus(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/cactus"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/cactus"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnTreeDesert(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/treeDesert"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/treeDesert"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnCrystalPlant(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/plantCrystal"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnPlantFire(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/plantFire"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/plantFire"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnPlantSwamp(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/plantSwamp"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/plantSwamp"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnPlantSnow(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/plantSnow"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/plantSnow"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnBug(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/bugSpot"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnPlant(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/plant"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/plant"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnPlantVeldt(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/plantVeldt"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/plantVeldt"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnSnowTree(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/treeSnow"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/treeSnow"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnPillar(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/pillar"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/pillar"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnFairyGem(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/fairyGem"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnDragonGem(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/dragonGem"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnEgg(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/spiderEgg"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/spiderEgg"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnSpikes(Vector3 pos)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				int num = Random.Range(0, 2);
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/snowSpawner"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("haz/bigSnow"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnGas(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/Gas"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnHive(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/beeHive"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnBall(Vector3 pos)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0 && Network.isServer)
		{
			GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/ballSpike"), pos, Quaternion.identity, 0);
		}
	}

	public override void SpawnVines(Vector3 pos)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				if (Random.Range(0, 2) == 0)
				{
					GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/vines"), pos, Quaternion.identity, 0);
				}
				else
				{
					GameObject val2 = (GameObject)Network.Instantiate(Resources.Load("haz/vines2"), pos, Quaternion.identity, 0);
				}
			}
		}
		else
		{
			GameObject val3 = (GameObject)Object.Instantiate(Resources.Load("haz/vines"), pos, Quaternion.identity);
			val3.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnTopVines(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/vinesTop"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("haz/vinesTop"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnTopShroom(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("haz/shroomTop"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("haz/shroomTop"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnTopLantern(Vector3 pos)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("lanternTop"), pos, Quaternion.Euler(0f, 0f, 0f), 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("lanternTop"), pos, Quaternion.Euler(0f, 0f, 0f));
		}
	}

	public override void SpawnTopSpire(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("spireTop"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("spireTop"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnSpire(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("spireBottom"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("spireBottom"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void SpawnChest(Vector3 pos)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				GameObject val = (GameObject)Network.Instantiate(Resources.Load("interact/chest"), pos, Quaternion.identity, 0);
			}
		}
		else
		{
			GameObject val2 = (GameObject)Object.Instantiate(Resources.Load("interact/chest"), pos, Quaternion.identity);
			val2.transform.parent = ((Component)this).transform;
		}
	}

	public override void Main()
	{
	}
}
