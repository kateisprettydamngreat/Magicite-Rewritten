using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class ChestScript : MonoBehaviour
{
	public bool isGold;

	private bool isOpened;

	private int[] drops;

	private int gold;

	public GameObject @base;

	public override void Awake()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer == 1 && GameScript.districtLevel > 5)
		{
			if (Random.Range(0, 8) == 0)
			{
				Network.Instantiate(Resources.Load("e/mimic"), ((Component)this).transform.position, Quaternion.identity, 0);
				Network.Destroy(((Component)this).networkView.viewID);
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

	public override void Begin()
	{
		int num = default(int);
		num = ((!isGold) ? Random.Range(2, 4) : Random.Range(3, 7));
		drops = new int[num];
		int num2 = default(int);
		for (num2 = 0; num2 < num; num2++)
		{
			drops[num2] = Random.Range(1, 56);
		}
		if (MenuScript.multiplayer == 1 && GameScript.curBiome == 6)
		{
			if (Random.Range(0, 6) == 0)
			{
				drops[0] = 565;
			}
		}
		else if (MenuScript.multiplayer == 1 && GameScript.curBiome == 8)
		{
			if (Random.Range(0, 6) == 0)
			{
				drops[0] = 530;
			}
		}
		else if (MenuScript.multiplayer == 1 && GameScript.curBiome == 3 && Random.Range(0, 6) == 0)
		{
			drops[1] = 905;
		}
		if (Random.Range(0, 7) == 0)
		{
			drops[0] = Random.Range(950, 958);
		}
		gold = Random.Range(2, 9);
	}

	[RPC]
	public override void Init(int a, int b, int c)
	{
		drops = new int[3];
		drops[0] = a;
		drops[1] = b;
		drops[2] = c;
		gold = Random.Range(2, 9);
	}

	[RPC]
	public override void O()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		if (isOpened)
		{
			return;
		}
		isOpened = true;
		GameScript.tempStats[9] = GameScript.tempStats[9] + 1;
		@base.animation.Play();
		float x = @base.renderer.material.mainTextureOffset.x + 0.5f;
		Vector2 mainTextureOffset = @base.renderer.material.mainTextureOffset;
		float num = (mainTextureOffset.x = x);
		Vector2 val2 = (@base.renderer.material.mainTextureOffset = mainTextureOffset);
		int num2 = default(int);
		GameObject val3 = null;
		if (!Network.isServer)
		{
			return;
		}
		Item item = new Item(0, 1, new int[4], 0f, null);
		for (num2 = 0; num2 < gold; num2++)
		{
			Network.Instantiate(Resources.Load("c"), ((Component)this).transform.position, Quaternion.identity, 0);
		}
		for (num2 = 0; num2 < Extensions[(Array)drops]; num2++)
		{
			if (drops[num2] != 0)
			{
				item.id = drops[num2];
				val3 = (GameObject)Network.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity, 0);
				val3.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
				val3.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
				val3.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
				val3.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
				if (item.id >= 500)
				{
					val3.networkView.RPC("SetE", (RPCMode)6, new object[1] { GetGearStats(item.id) });
					val3.networkView.RPC("SetD", (RPCMode)6, new object[1] { 100 });
				}
			}
		}
	}

	public override void Open()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		if (isGold)
		{
			return;
		}
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("O", (RPCMode)6, new object[0]);
		}
		else if (!isOpened)
		{
			isOpened = true;
			@base.animation.Play();
			float x = @base.renderer.material.mainTextureOffset.x + 0.5f;
			Vector2 mainTextureOffset = @base.renderer.material.mainTextureOffset;
			float num = (mainTextureOffset.x = x);
			Vector2 val2 = (@base.renderer.material.mainTextureOffset = mainTextureOffset);
			int num2 = default(int);
			for (num2 = 0; num2 < gold; num2++)
			{
				Object.Instantiate(Resources.Load("c"), ((Component)this).transform.position, Quaternion.identity);
			}
			Item item = new Item(0, 1, new int[4], 0f, null);
			for (num2 = 0; num2 < Extensions[(Array)drops]; num2++)
			{
				item.id = drops[num2];
				GameObject val3 = (GameObject)Object.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity);
				val3.SendMessage("Set", (object)item);
			}
		}
	}

	[RPC]
	public override void ServerO()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		isOpened = true;
		@base.animation.Play();
		float x = @base.renderer.material.mainTextureOffset.x + 0.5f;
		Vector2 mainTextureOffset = @base.renderer.material.mainTextureOffset;
		float num = (mainTextureOffset.x = x);
		Vector2 val2 = (@base.renderer.material.mainTextureOffset = mainTextureOffset);
	}

	public override void Open2()
	{
		isGold = false;
		Open();
	}

	public override int[] GetGearStats(int id)
	{
		int[] array = new int[4];
		return id switch
		{
			500 => new int[4] { 0, 2, 0, 0 }, 
			503 => new int[4] { 0, 8, 0, 0 }, 
			506 => new int[4] { 0, 15, 0, 0 }, 
			509 => new int[4] { 0, 25, 0, 0 }, 
			512 => new int[4] { 0, 4, 0, 0 }, 
			516 => new int[4] { 0, 4, 0, 0 }, 
			530 => new int[4] { 0, 0, 6, 0 }, 
			560 => new int[4] { 0, 15, 0, 0 }, 
			561 => new int[4] { 0, 30, 0, 0 }, 
			562 => new int[4] { 0, 48, 0, 0 }, 
			563 => new int[4] { 0, 8, 0, 0 }, 
			565 => new int[4] { 0, 55, 0, 0 }, 
			700 => new int[4] { 2, 4, 0, 0 }, 
			701 => new int[4] { 3, 6, 0, 0 }, 
			702 => new int[4] { 4, 9, 0, 0 }, 
			703 => new int[4] { 1, 2, 0, 0 }, 
			704 => new int[4] { 1, 2, 0, 0 }, 
			705 => new int[4] { 1, 0, 2, 0 }, 
			706 => new int[4] { 1, 0, 2, 0 }, 
			707 => new int[4] { 2, 0, 4, 0 }, 
			708 => new int[4] { 3, 0, 6, 0 }, 
			709 => new int[4] { 4, 0, 9, 0 }, 
			710 => new int[4] { 1, 0, 0, 2 }, 
			711 => new int[4] { 1, 0, 0, 2 }, 
			712 => new int[4] { 2, 0, 0, 4 }, 
			713 => new int[4] { 3, 0, 0, 6 }, 
			714 => new int[4] { 4, 0, 0, 9 }, 
			800 => new int[4] { 2, 4, 0, 0 }, 
			801 => new int[4] { 3, 6, 0, 0 }, 
			802 => new int[4] { 4, 9, 0, 0 }, 
			803 => new int[4] { 1, 2, 0, 0 }, 
			804 => new int[4] { 1, 2, 0, 0 }, 
			805 => new int[4] { 1, 0, 2, 0 }, 
			806 => new int[4] { 1, 0, 2, 0 }, 
			807 => new int[4] { 2, 0, 4, 0 }, 
			808 => new int[4] { 3, 0, 6, 0 }, 
			809 => new int[4] { 4, 0, 9, 0 }, 
			810 => new int[4] { 1, 0, 0, 2 }, 
			811 => new int[4] { 1, 0, 0, 2 }, 
			812 => new int[4] { 2, 0, 0, 4 }, 
			813 => new int[4] { 3, 0, 0, 6 }, 
			814 => new int[4] { 4, 0, 0, 9 }, 
			900 => new int[4] { 2, 0, 0, 0 }, 
			901 => new int[4] { 3, 0, 0, 0 }, 
			902 => new int[4] { 4, 0, 0, 0 }, 
			903 => new int[4] { 1, 0, 0, 0 }, 
			904 => new int[4] { 1, 0, 0, 0 }, 
			905 => new int[4] { 5, 2, 2, 2 }, 
			950 => new int[4] { 0, 5, 0, 0 }, 
			951 => new int[4] { 0, 0, 0, 5 }, 
			952 => new int[4] { 0, 0, 5, 0 }, 
			953 => new int[4] { 5, 0, 0, 0 }, 
			954 => new int[4] { -2, 8, 0, 0 }, 
			955 => new int[4] { -2, 0, 0, 8 }, 
			956 => new int[4] { -2, 0, 8, 0 }, 
			957 => new int[4] { 2, 2, 2, 2 }, 
			_ => new int[4], 
		};
	}

	public override void Main()
	{
	}
}
