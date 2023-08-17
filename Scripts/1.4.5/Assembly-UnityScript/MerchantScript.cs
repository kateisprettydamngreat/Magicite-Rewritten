using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class MerchantScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241237 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal MerchantScript _0024self__00241238;

			public _0024(MerchantScript self_)
			{
				_0024self__00241238 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a0: Expected O, but got Unknown
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							goto IL_0039;
						}
						((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
						goto case 1;
					}
					goto case 4;
				case 2:
					((Component)_0024self__00241238).networkView.RPC("Talkn", (RPCMode)2, new object[1] { _0024self__00241238.GetRandomText() });
					goto IL_0039;
				case 4:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForSeconds((float)Random.Range(2, 8))) ? 1 : 0);
					break;
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)(object)((MonoBehaviour)_0024self__00241238).StartCoroutine_Auto(_0024self__00241238.Talkn(_0024self__00241238.GetRandomText()))) ? 1 : 0);
					break;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0039:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForSeconds((float)Random.Range(3, 12))) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MerchantScript _0024self__00241239;

		public _0024Start_00241237(MerchantScript self_)
		{
			_0024self__00241239 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024self__00241239);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Talkn_00241240 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00241241;

			internal MerchantScript _0024self__00241242;

			public _0024(string s, MerchantScript self_)
			{
				_0024s_00241241 = s;
				_0024self__00241242 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241242.@base.animation.Play("t");
					_0024self__00241242.txtTalk.text = _0024s_00241241;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241242.txtTalk.text = string.Empty;
					_0024self__00241242.@base.animation.Play("i");
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024s_00241243;

		internal MerchantScript _0024self__00241244;

		public _0024Talkn_00241240(string s, MerchantScript self_)
		{
			_0024s_00241243 = s;
			_0024self__00241244 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024s_00241243, _0024self__00241244);
		}
	}

	public GameObject @base;

	public GameObject[] stand;

	public TextMesh[] txtPrice;

	public TextMesh txtTalk;

	public GameObject[] items;

	private int[] itemID;

	private int[] itemQ;

	private int merchantType;

	public MerchantScript()
	{
		stand = (GameObject[])(object)new GameObject[4];
		txtPrice = (TextMesh[])(object)new TextMesh[8];
		items = (GameObject[])(object)new GameObject[4];
		itemID = new int[4];
		itemQ = new int[4];
	}

	public override void Awake()
	{
		int num = Random.Range(0, 10);
		if (num < 1)
		{
			merchantType = 1;
			SetItems();
		}
		else
		{
			merchantType = 2;
			SetGear();
		}
	}

	[RPC]
	public override void Knock22(Vector3 a)
	{
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241237(this).GetEnumerator();
	}

	public override string GetRandomText()
	{
		int num = Random.Range(0, 5);
		string result = null;
		switch (num)
		{
		case 0:
			result = "Get ya goods here!";
			break;
		case 1:
			result = "Waddya buyin', stranger?";
			break;
		case 2:
			result = "Got a lot of good things on sale, stranger!";
			break;
		case 3:
			result = "I have the finest items for sale!";
			break;
		case 4:
			result = "It is dangerous to go alone! Buy something.";
			break;
		}
		return result;
	}

	[RPC]
	public override IEnumerator Talkn(string s)
	{
		return new _0024Talkn_00241240(s, this).GetEnumerator();
	}

	public override void OnDestroy()
	{
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			stand[num].SetActive(false);
		}
	}

	public override void SetItems()
	{
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			itemID[num] = Random.Range(1, 56);
			itemQ[num] = Random.Range(1, 4);
			if (itemID[num] == 49 || itemID[num] == 11 || itemID[num] == 46)
			{
				itemID[num] = 15;
			}
		}
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				((Component)this).networkView.RPC("RefreshItemsRPC", (RPCMode)2, new object[4]
				{
					itemID[0],
					itemID[1],
					itemID[2],
					itemID[3]
				});
			}
		}
		else
		{
			RefreshItems();
		}
	}

	public override void SetGear()
	{
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			itemID[num] = Random.Range(500, 520);
		}
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				((Component)this).networkView.RPC("RefreshItemsRPC", (RPCMode)2, new object[4]
				{
					itemID[0],
					itemID[1],
					itemID[2],
					itemID[3]
				});
			}
		}
		else
		{
			RefreshItems();
		}
	}

	[RPC]
	public override void RefreshItemsRPC(int id1, int id2, int id3, int id4)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		items[0].renderer.material = (Material)Resources.Load("i/i" + (object)id1);
		txtPrice[0].text = string.Empty + (object)GetItemPrice(id1);
		items[1].renderer.material = (Material)Resources.Load("i/i" + (object)id2);
		txtPrice[1].text = string.Empty + (object)GetItemPrice(id2);
		items[2].renderer.material = (Material)Resources.Load("i/i" + (object)id3);
		txtPrice[2].text = string.Empty + (object)GetItemPrice(id3);
		items[3].renderer.material = (Material)Resources.Load("i/i" + (object)id4);
		txtPrice[3].text = string.Empty + (object)GetItemPrice(id4);
		txtPrice[4].text = txtPrice[0].text;
		txtPrice[5].text = txtPrice[1].text;
		txtPrice[6].text = txtPrice[2].text;
		txtPrice[7].text = txtPrice[3].text;
		((Object)stand[0]).name = string.Empty + (object)id1;
		((Object)stand[1]).name = string.Empty + (object)id2;
		((Object)stand[2]).name = string.Empty + (object)id3;
		((Object)stand[3]).name = string.Empty + (object)id4;
	}

	public override void RefreshItems()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			items[num].renderer.material = (Material)Resources.Load("i/i" + (object)itemID[num], typeof(Material));
			((Object)stand[num]).name = string.Empty + (object)itemID[num];
		}
		txtPrice[0].text = string.Empty + (object)GetItemPrice(itemID[0]);
		txtPrice[1].text = string.Empty + (object)GetItemPrice(itemID[1]);
		txtPrice[2].text = string.Empty + (object)GetItemPrice(itemID[2]);
		txtPrice[3].text = string.Empty + (object)GetItemPrice(itemID[3]);
		txtPrice[4].text = txtPrice[0].text;
		txtPrice[5].text = txtPrice[1].text;
		txtPrice[6].text = txtPrice[2].text;
		txtPrice[7].text = txtPrice[3].text;
	}

	public override int GetItemPrice(int id)
	{
		int num = default(int);
		return id switch
		{
			1 => 5, 
			2 => 10, 
			3 => 5, 
			4 => 15, 
			5 => 30, 
			6 => 70, 
			7 => 5, 
			8 => 8, 
			9 => 10, 
			10 => 10, 
			11 => 10, 
			12 => 30, 
			13 => 60, 
			14 => 140, 
			15 => 20, 
			16 => 20, 
			17 => 20, 
			18 => 7, 
			19 => 7, 
			20 => 7, 
			21 => 5, 
			22 => 10, 
			23 => 10, 
			24 => 15, 
			25 => 20, 
			26 => 10, 
			27 => 15, 
			28 => 30, 
			29 => 20, 
			30 => 20, 
			31 => 20, 
			32 => 60, 
			33 => 120, 
			34 => 280, 
			35 => 120, 
			36 => 240, 
			37 => 560, 
			38 => 10, 
			39 => 20, 
			40 => 40, 
			41 => 80, 
			42 => 45, 
			43 => 45, 
			44 => 20, 
			45 => 45, 
			46 => 100, 
			47 => 30, 
			48 => 65, 
			49 => 10, 
			50 => 15, 
			51 => 5, 
			52 => 5, 
			53 => 10, 
			54 => 20, 
			55 => 40, 
			56 => 60, 
			500 => 35, 
			501 => 30, 
			502 => 45, 
			503 => 120, 
			504 => 120, 
			505 => 120, 
			506 => 300, 
			507 => 300, 
			508 => 300, 
			509 => 700, 
			510 => 700, 
			511 => 700, 
			512 => 55, 
			513 => 50, 
			514 => 65, 
			515 => 100, 
			516 => 55, 
			517 => 50, 
			518 => 65, 
			519 => 200, 
			550 => 330, 
			560 => 135, 
			561 => 255, 
			562 => 1000, 
			563 => 95, 
			600 => 100, 
			601 => 100, 
			602 => 100, 
			700 => 90, 
			701 => 180, 
			702 => 420, 
			800 => 90, 
			801 => 180, 
			802 => 420, 
			900 => 90, 
			901 => 180, 
			902 => 420, 
			_ => 999, 
		} * 2;
	}

	public override void Main()
	{
	}
}
