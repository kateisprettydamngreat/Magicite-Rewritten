using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class NPCScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Talk_00242258 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242259;

			internal NPCScript _0024self__00242260;

			public _0024(int a, NPCScript self_)
			{
				_0024a_00242259 = a;
				_0024self__00242260 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Expected O, but got Unknown
				//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Expected O, but got Unknown
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_015e: Expected O, but got Unknown
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024a_00242259 == 1)
					{
						goto case 2;
					}
					if (_0024a_00242259 == 3)
					{
						goto case 3;
					}
					if (_0024a_00242259 == 4)
					{
						goto case 4;
					}
					if (_0024a_00242259 == 5)
					{
						goto case 5;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 2:
					if (MenuScript.multiplayer > 0 && Network.isServer)
					{
						((Component)_0024self__00242260).networkView.RPC("TalkN", (RPCMode)2, new object[1] { "Smelt your ores!" });
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(5, 11))) ? 1 : 0);
					break;
				case 3:
					if (MenuScript.multiplayer > 0 && Network.isServer)
					{
						((Component)_0024self__00242260).networkView.RPC("TalkN", (RPCMode)2, new object[1] { "Refine your Monster Hide!" });
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(5, 11))) ? 1 : 0);
					break;
				case 4:
					if (MenuScript.multiplayer > 0 && Network.isServer)
					{
						((Component)_0024self__00242260).networkView.RPC("TalkN", (RPCMode)2, new object[1] { "Craft fancy fabrics!" });
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds((float)Random.Range(5, 11))) ? 1 : 0);
					break;
				case 5:
					if (MenuScript.multiplayer > 0 && Network.isServer)
					{
						((Component)_0024self__00242260).networkView.RPC("TalkN", (RPCMode)2, new object[1] { "Sell me your treasure!" });
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds((float)Random.Range(5, 8))) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242261;

		internal NPCScript _0024self__00242262;

		public _0024Talk_00242258(int a, NPCScript self_)
		{
			_0024a_00242261 = a;
			_0024self__00242262 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242261, _0024self__00242262);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TalkN_00242263 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024a_00242264;

			internal NPCScript _0024self__00242265;

			public _0024(string a, NPCScript self_)
			{
				_0024a_00242264 = a;
				_0024self__00242265 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242265.txtTalk.text = _0024a_00242264 + string.Empty;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242265.txtTalk.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024a_00242266;

		internal NPCScript _0024self__00242267;

		public _0024TalkN_00242263(string a, NPCScript self_)
		{
			_0024a_00242266 = a;
			_0024self__00242267 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242266, _0024self__00242267);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242268 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal NPCScript _0024self__00242269;

			public _0024(NPCScript self_)
			{
				_0024self__00242269 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242269.isAltar)
					{
						goto case 2;
					}
					((GenericGeneratorEnumerator<Coroutine>)this).YieldDefault(1);
					goto case 1;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242269).StartCoroutine_Auto(_0024self__00242269.Move())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal NPCScript _0024self__00242270;

		public _0024Start_00242268(NPCScript self_)
		{
			_0024self__00242270 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242270);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242271 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242272;

			internal int _0024dmg_00242273;

			internal NPCScript _0024self__00242274;

			public _0024(int dmg, NPCScript self_)
			{
				_0024dmg_00242273 = dmg;
				_0024self__00242274 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242274.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242274.hp -= _0024dmg_00242273;
					_0024i_00242272 = default(int);
					if (_0024self__00242274.hp < 1)
					{
						if (MenuScript.multiplayer > 0)
						{
							for (_0024i_00242272 = 0; _0024i_00242272 < _0024self__00242274.GOLD; _0024i_00242272++)
							{
								Network.Instantiate(Resources.Load("c"), _0024self__00242274.t.position, Quaternion.identity, 0);
							}
						}
						else
						{
							for (_0024i_00242272 = 0; _0024i_00242272 < _0024self__00242274.GOLD; _0024i_00242272++)
							{
								Object.Instantiate(Resources.Load("c"), _0024self__00242274.t.position, Quaternion.identity);
							}
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(((Component)_0024self__00242274).networkView.viewID);
							Network.Destroy(((Component)_0024self__00242274).networkView.viewID);
						}
					}
					else
					{
						_0024self__00242274.takingDamage = false;
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

		internal int _0024dmg_00242275;

		internal NPCScript _0024self__00242276;

		public _0024TDN_00242271(int dmg, NPCScript self_)
		{
			_0024dmg_00242275 = dmg;
			_0024self__00242276 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242275, _0024self__00242276);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242277 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242278;

			internal int _0024_0024776_00242279;

			internal Vector3 _0024_0024777_00242280;

			internal int _0024dmg_00242281;

			internal NPCScript _0024self__00242282;

			public _0024(int dmg, NPCScript self_)
			{
				_0024dmg_00242281 = dmg;
				_0024self__00242282 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0030: Unknown result type (might be due to invalid IL or missing references)
				//IL_0040: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected O, but got Unknown
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected O, but got Unknown
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Expected O, but got Unknown
				//IL_0109: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Unknown result type (might be due to invalid IL or missing references)
				//IL_0144: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024n2_00242278 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242282.t.position, Quaternion.identity);
					_0024n2_00242278.SendMessage("SD", (object)_0024dmg_00242281);
					_0024self__00242282.@base.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242282.hp < 1)
					{
						goto IL_014c;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00242282.@base.animation.Stop();
					_0024self__00242282.takingDamage = false;
					int num = (_0024_0024776_00242279 = 0);
					Vector3 val = (_0024_0024777_00242280 = _0024self__00242282.@base.transform.localPosition);
					float num2 = (_0024_0024777_00242280.z = _0024_0024776_00242279);
					Vector3 val3 = (_0024self__00242282.@base.transform.localPosition = _0024_0024777_00242280);
					goto IL_014c;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_014c:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242283;

		internal NPCScript _0024self__00242284;

		public _0024TDN2_00242277(int dmg, NPCScript self_)
		{
			_0024dmg_00242283 = dmg;
			_0024self__00242284 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242283, _0024self__00242284);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Move_00242285 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCScript _0024self__00242286;

			public _0024(NPCScript self_)
			{
				_0024self__00242286 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0039: Unknown result type (might be due to invalid IL or missing references)
				//IL_0043: Expected O, but got Unknown
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Expected O, but got Unknown
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Expected O, but got Unknown
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242286.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242286.canMove = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(1, 10))) ? 1 : 0);
					break;
				case 3:
					_0024self__00242286.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds((float)Random.Range(1, 4))) ? 1 : 0);
					break;
				case 4:
					_0024self__00242286.canMove = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds((float)Random.Range(1, 10))) ? 1 : 0);
					break;
				case 5:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal NPCScript _0024self__00242287;

		public _0024Move_00242285(NPCScript self_)
		{
			_0024self__00242287 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242287);
		}
	}

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

	public NPCScript()
	{
		stand = (GameObject[])(object)new GameObject[4];
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
		base2.animation["i"].speed = 0.5f;
		GOLD = Random.Range(2, 6);
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		takingDamage = false;
		maxHP = 50;
		hp = maxHP;
		t = ((Component)this).transform;
		if (isBlacksmith)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Talk(1));
		}
		else if (isLeatherworker)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Talk(3));
		}
		else if (isTailor)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Talk(4));
		}
		else if (isTreasureHunter)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Talk(5));
		}
		else if (isAltar)
		{
			Initializ();
		}
	}

	public override void Initializ()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		int num = Random.Range(0, 8);
		altarObj.renderer.material = (Material)Resources.Load("altar" + (object)num);
		GameScript.curAltar = num;
	}

	[RPC]
	public override IEnumerator Talk(int a)
	{
		return new _0024Talk_00242258(a, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TalkN(string a)
	{
		return new _0024TalkN_00242263(a, this).GetEnumerator();
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242268(this).GetEnumerator();
	}

	[RPC]
	public override void O()
	{
		int num = 0;
		for (num = 0; num < 4; num++)
		{
			stand[num].SetActive(false);
		}
	}

	public override void TD(int dmg)
	{
		if (!isMerchant && !isBlacksmith && !isTailor && !isTreasureHunter && !isLeatherworker && !isAltar)
		{
			if (isMerchant)
			{
				((Component)this).networkView.RPC("O", (RPCMode)2, new object[0]);
			}
			if (!takingDamage && MenuScript.multiplayer > 0)
			{
				((Component)this).networkView.RPC("TDN", (RPCMode)6, new object[1] { dmg });
				((Component)this).networkView.RPC("TDN2", (RPCMode)2, new object[1] { dmg });
			}
		}
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242271(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242277(dmg, this).GetEnumerator();
	}

	public override void Die()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		if (MenuScript.multiplayer > 0)
		{
			for (num = 0; num < GOLD; num++)
			{
				Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
			}
		}
		else
		{
			for (num = 0; num < GOLD; num++)
			{
				Object.Instantiate(Resources.Load("c"), t.position, Quaternion.identity);
			}
		}
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				Network.Instantiate(Resources.Load("noInter"), t.position, Quaternion.identity, 0);
				Network.RemoveRPCs(((Component)this).networkView.viewID);
				Network.Destroy(((Component)this).gameObject);
			}
			else
			{
				((Component)this).networkView.RPC("die", (RPCMode)0, new object[0]);
			}
		}
		else
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public override void Update()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (canMove && !isAltar)
		{
			float x = speed;
			Vector3 velocity = ((Component)this).rigidbody.velocity;
			float num = (velocity.x = x);
			Vector3 val2 = (((Component)this).rigidbody.velocity = velocity);
		}
		if (isAltar && GameScript.usedAltar && !disabled)
		{
			disabled = true;
			Disable();
		}
	}

	public override void Disable()
	{
		altarObj.SetActive(false);
		altarCoin.SetActive(false);
	}

	public override IEnumerator Move()
	{
		return new _0024Move_00242285(this).GetEnumerator();
	}

	[RPC]
	public override void DieN(NetworkViewID id)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).networkView.viewID == id)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	[RPC]
	public override void Initialize(NetworkViewID id)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).networkView.viewID = id;
	}

	public override void Knock(Vector3 p)
	{
	}

	[RPC]
	public override void KnockN(Vector3 p)
	{
	}

	public override void K(bool l)
	{
	}

	public override void Main()
	{
	}
}
