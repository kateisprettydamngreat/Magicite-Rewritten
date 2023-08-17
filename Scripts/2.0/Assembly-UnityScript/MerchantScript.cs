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
	internal sealed class _0024Start_00241133 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MerchantScript _0024self__00241134;

			public _0024(MerchantScript self_)
			{
				_0024self__00241134 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (Network.isServer)
					{
						goto IL_0026;
					}
					YieldDefault(1);
					goto case 1;
				case 2:
					_0024self__00241134.GetComponent<NetworkView>().RPC("Talkn", RPCMode.All, _0024self__00241134.GetRandomText());
					goto IL_0026;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0026:
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(3, 12))) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MerchantScript _0024self__00241135;

		public _0024Start_00241133(MerchantScript self_)
		{
			_0024self__00241135 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241135);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Talkn_00241136 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024s_00241137;

			internal MerchantScript _0024self__00241138;

			public _0024(string s, MerchantScript self_)
			{
				_0024s_00241137 = s;
				_0024self__00241138 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241138.@base.GetComponent<Animation>().Play("t");
					_0024self__00241138.txtTalk.text = _0024s_00241137;
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241138.txtTalk.text = string.Empty;
					_0024self__00241138.@base.GetComponent<Animation>().Play("i");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024s_00241139;

		internal MerchantScript _0024self__00241140;

		public _0024Talkn_00241136(string s, MerchantScript self_)
		{
			_0024s_00241139 = s;
			_0024self__00241140 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024s_00241139, _0024self__00241140);
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
		stand = new GameObject[4];
		txtPrice = new TextMesh[8];
		items = new GameObject[4];
		itemID = new int[4];
		itemQ = new int[4];
	}

	public virtual void Awake()
	{
		int num = UnityEngine.Random.Range(0, 10);
		if (num < 4 || GameScript.districtLevel >= 15)
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
	public virtual void Knock22(Vector3 a)
	{
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241133(this).GetEnumerator();
	}

	public virtual string GetRandomText()
	{
		int num = UnityEngine.Random.Range(0, 5);
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
	public virtual IEnumerator Talkn(string s)
	{
		return new _0024Talkn_00241136(s, this).GetEnumerator();
	}

	public virtual void OnDestroy()
	{
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			stand[num].SetActive(value: false);
		}
	}

	public virtual void SetItems()
	{
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			itemID[num] = UnityEngine.Random.Range(1, 56);
			itemQ[num] = UnityEngine.Random.Range(1, 4);
			if (itemID[num] == 49 || itemID[num] == 11 || itemID[num] == 46)
			{
				itemID[num] = 15;
			}
			if (GameScript.districtLevel >= 15)
			{
				itemID[0] = 95;
			}
		}
		if (Network.isServer)
		{
			GetComponent<NetworkView>().RPC("RefreshItemsRPC", RPCMode.All, itemID[0], itemID[1], itemID[2], itemID[3]);
		}
	}

	public virtual void SetGear()
	{
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			itemID[num] = UnityEngine.Random.Range(500, 520);
		}
		if (Network.isServer)
		{
			GetComponent<NetworkView>().RPC("RefreshItemsRPC", RPCMode.All, itemID[0], itemID[1], itemID[2], itemID[3]);
		}
	}

	[RPC]
	public virtual void RefreshItemsRPC(int id1, int id2, int id3, int id4)
	{
		items[0].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + id1);
		txtPrice[0].text = string.Empty + GetItemPrice(id1);
		items[1].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + id2);
		txtPrice[1].text = string.Empty + GetItemPrice(id2);
		items[2].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + id3);
		txtPrice[2].text = string.Empty + GetItemPrice(id3);
		items[3].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + id4);
		txtPrice[3].text = string.Empty + GetItemPrice(id4);
		txtPrice[4].text = txtPrice[0].text;
		txtPrice[5].text = txtPrice[1].text;
		txtPrice[6].text = txtPrice[2].text;
		txtPrice[7].text = txtPrice[3].text;
		stand[0].name = string.Empty + id1;
		stand[1].name = string.Empty + id2;
		stand[2].name = string.Empty + id3;
		stand[3].name = string.Empty + id4;
	}

	public virtual void RefreshItems()
	{
		int num = default(int);
		for (num = 0; num < 4; num++)
		{
			items[num].GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + itemID[num], typeof(Material));
			stand[num].name = string.Empty + itemID[num];
		}
		txtPrice[0].text = string.Empty + GetItemPrice(itemID[0]);
		txtPrice[1].text = string.Empty + GetItemPrice(itemID[1]);
		txtPrice[2].text = string.Empty + GetItemPrice(itemID[2]);
		txtPrice[3].text = string.Empty + GetItemPrice(itemID[3]);
		txtPrice[4].text = txtPrice[0].text;
		txtPrice[5].text = txtPrice[1].text;
		txtPrice[6].text = txtPrice[2].text;
		txtPrice[7].text = txtPrice[3].text;
	}

	public virtual int GetItemPrice(int id)
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
			95 => 1000, 
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

	public virtual void Main()
	{
	}
}
