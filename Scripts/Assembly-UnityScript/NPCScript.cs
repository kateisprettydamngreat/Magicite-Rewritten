using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class NPCScript : MonoBehaviour
{
	public GameObject altarCoin;
	private bool disabled;
	public GameObject altarObj;
	public GameObject[] stand;
	public TextMesh txtTalk;
	public bool isMerchant;
	public bool isBlacksmith;
	public bool isTailor;
	public bool isLeatherworker;
	public bool isTreasureHunter;
	public bool isAltar;
	private int pos;
	private Transform t;
	private int moving;
	private int maxHP;
	private int hp;
	private bool takingDamage;
	public GameObject @base;
	public GameObject base2;
	public float speed;
	public Transform npc;
	private Rigidbody r;
	private int GOLD;
	private bool canMove;
	
	[RPC]
	public virtual IEnumerator TalkN(string a)
	{
		while (true)
		{
			txtTalk.text = a + string.Empty;
			yield return new WaitForSeconds(2f);
			txtTalk.text = string.Empty;
			yield return null;
		}
	}
	[Serializable]
	public virtual IEnumerator Start()
	{
		if (!isAltar)
		{
			yield break;
		}

		yield return StartCoroutine_Auto(Move());
	}
	[Serializable]
	internal sealed class _0024TDN_00242100 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
	
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242101;

			internal int _0024dmg_00242102;

			internal NPCScript _0024self__00242103;

			public _0024(int dmg, NPCScript self_)
			{
				_0024dmg_00242102 = dmg;
				_0024self__00242103 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242103.takingDamage = true;
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242103.hp -= _0024dmg_00242102;
					_0024i_00242101 = default(int);
					if (_0024self__00242103.hp < 1)
					{
						for (_0024i_00242101 = 0; _0024i_00242101 < _0024self__00242103.GOLD; _0024i_00242101++)
						{
							Network.Instantiate(Resources.Load("c"), _0024self__00242103.t.position, Quaternion.identity, 0);
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(_0024self__00242103.GetComponent<NetworkView>().viewID);
							Network.Destroy(_0024self__00242103.GetComponent<NetworkView>().viewID);
						}
					}
					else
					{
						_0024self__00242103.takingDamage = false;
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242104;

		internal NPCScript _0024self__00242105;

		public _0024TDN_00242100(int dmg, NPCScript self_)
		{
			_0024dmg_00242104 = dmg;
			_0024self__00242105 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dmg_00242104, _0024self__00242105);
		}
	}
	[RPC]
	public virtual IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242100(dmg, this).GetEnumerator();
	}

	[Serializable]
	internal sealed class _0024TDN2_00242106 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
	
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242107;

			internal int _0024_0024691_00242108;

			internal Vector3 _0024_0024692_00242109;

			internal int _0024dmg_00242110;

			internal NPCScript _0024self__00242111;

			public _0024(int dmg, NPCScript self_)
			{
				_0024dmg_00242110 = dmg;
				_0024self__00242111 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024n2_00242107 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242111.t.position, Quaternion.identity);
					_0024n2_00242107.SendMessage("SD", _0024dmg_00242110);
					_0024self__00242111.@base.GetComponent<Animation>().Play();
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242111.hp < 1)
					{
						goto IL_014c;
					}
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00242111.@base.GetComponent<Animation>().Stop();
					_0024self__00242111.takingDamage = false;
					int num = (_0024_0024691_00242108 = 0);
					Vector3 vector = (_0024_0024692_00242109 = _0024self__00242111.@base.transform.localPosition);
					float num2 = (_0024_0024692_00242109.z = _0024_0024691_00242108);
					Vector3 vector3 = (_0024self__00242111.@base.transform.localPosition = _0024_0024692_00242109);
					goto IL_014c;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_014c:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242112;

		internal NPCScript _0024self__00242113;

		public _0024TDN2_00242106(int dmg, NPCScript self_)
		{
			_0024dmg_00242112 = dmg;
			_0024self__00242113 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dmg_00242112, _0024self__00242113);
		}
	}
	[RPC]
	public virtual IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242106(dmg, this).GetEnumerator();
	}

	[Serializable]
	internal sealed class _0024Move_00242114 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
	
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCScript _0024self__00242115;

			public _0024(NPCScript self_)
			{
				_0024self__00242115 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242115.canMove = true;
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242115.canMove = false;
					result = (Yield(3, new WaitForSeconds(UnityEngine.Random.Range(1, 10))) ? 1 : 0);
					break;
				case 3:
					_0024self__00242115.canMove = true;
					result = (Yield(4, new WaitForSeconds(UnityEngine.Random.Range(1, 4))) ? 1 : 0);
					break;
				case 4:
					_0024self__00242115.canMove = false;
					result = (Yield(5, new WaitForSeconds(UnityEngine.Random.Range(1, 10))) ? 1 : 0);
					break;
				case 5:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal NPCScript _0024self__00242116;

		public _0024Move_00242114(NPCScript self_)
		{
			_0024self__00242116 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242116);
		}
	}
	public virtual IEnumerator Move()
	{
		return new _0024Move_00242114(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator<WaitForSeconds> Talk(int a) {
    while (true) {
        string message = null;

        switch(a) {
            case 1:
                message = "Smelt your ores!";
                break;
            case 3:
                message = "Refine your Monster Hide!";
                break;
            case 4:
                message = "Craft fancy fabrics!";
                break;
            case 5:
                message = "Sell me your treasure!";
                break;
            default:
                yield break; // Exit the coroutine for unknown cases
        }

        if (Network.isServer) {
            this.GetComponent<NetworkView>().RPC("TalkN", RPCMode.All, message);
        }

        yield return new WaitForSeconds(UnityEngine.Random.Range(5, 11));
    }}
//Now exiting: enumeration station

	public NPCScript()
	{
		stand = new GameObject[4];
	}

	public virtual void OnDestroy()
	{
		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
	}

	public virtual void Awake()
	{
		base2.GetComponent<Animation>()["i"].speed = 0.5f;
		GOLD = UnityEngine.Random.Range(2, 6);
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		takingDamage = false;
		maxHP = 50;
		hp = maxHP;
		t = transform;
		if (isBlacksmith)
		{
			StartCoroutine_Auto(Talk(1));
		}
		else if (isLeatherworker)
		{
			StartCoroutine_Auto(Talk(3));
		}
		else if (isTailor)
		{
			StartCoroutine_Auto(Talk(4));
		}
		else if (isTreasureHunter)
		{
			StartCoroutine_Auto(Talk(5));
		}
		else if (isAltar)
		{
			InitializeAltar();
		}
	}

	public virtual void InitializeAltar()
	{
		int num = UnityEngine.Random.Range(0, 8);
		altarObj.GetComponent<Renderer>().material = (Material)Resources.Load("altar" + num);
		GameScript.curAltar = num;
	}

	[RPC]
	public virtual void O()
	{
		int num = 0;
		for (num = 0; num < 4; num++)
		{
			stand[num].SetActive(value: false);
		}
	}

	public virtual void TD(int dmg)
	{
		if (!isMerchant && !isBlacksmith && !isTailor && !isTreasureHunter && !isLeatherworker && !isAltar)
		{
			if (isMerchant)
			{
				GetComponent<NetworkView>().RPC("O", RPCMode.All);
			}
			if (!takingDamage)
			{
				GetComponent<NetworkView>().RPC("TDN", RPCMode.All, dmg);
				GetComponent<NetworkView>().RPC("TDN2", RPCMode.All, dmg);
			}
		}
	}

	public virtual void Die()
	{
		int num = default(int);
		for (num = 0; num < GOLD; num++)
		{
			Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
		}
		if (Network.isServer)
		{
			Network.Instantiate(Resources.Load("noInter"), t.position, Quaternion.identity, 0);
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
			Network.Destroy(gameObject);
		}
		else
		{
			GetComponent<NetworkView>().RPC("die", RPCMode.Server);
		}
	}

	public virtual void Update()
	{
		if (canMove && !isAltar)
		{
			float x = speed;
			Vector3 velocity = GetComponent<Rigidbody>().velocity;
			float num = (velocity.x = x);
			Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		}
		if (isAltar && GameScript.usedAltar && !disabled)
		{
			disabled = true;
			Disable();
		}
	}

	public virtual void Disable()
	{
		altarObj.SetActive(value: false);
		altarCoin.SetActive(value: false);
	}

	[RPC]
	public virtual void DieN(NetworkViewID id)
	{
		if (GetComponent<NetworkView>().viewID == id)
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	[RPC]
	public virtual void Initialize(NetworkViewID id)
	{
		GetComponent<NetworkView>().viewID = id;
	}
}