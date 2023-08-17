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
	internal sealed class _0024Talk_00241979 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241980;

			internal NPCScript _0024self__00241981;

			public _0024(int a, NPCScript self_)
			{
				_0024a_00241980 = a;
				_0024self__00241981 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Expected O, but got Unknown
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024a_00241980 == 1)
					{
						goto case 3;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 3:
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							((Component)_0024self__00241981).networkView.RPC("TalkN", (RPCMode)2, new object[1] { "Smelt your ores!" });
						}
						goto IL_00a7;
					}
					_0024self__00241981.txtTalk.text = "Smelt your ores!";
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241981.txtTalk.text = string.Empty;
					goto IL_00a7;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a7:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(5, 11))) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241982;

		internal NPCScript _0024self__00241983;

		public _0024Talk_00241979(int a, NPCScript self_)
		{
			_0024a_00241982 = a;
			_0024self__00241983 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241982, _0024self__00241983);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TalkN_00241984 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024a_00241985;

			internal NPCScript _0024self__00241986;

			public _0024(string a, NPCScript self_)
			{
				_0024a_00241985 = a;
				_0024self__00241986 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241986.txtTalk.text = _0024a_00241985 + string.Empty;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241986.txtTalk.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024a_00241987;

		internal NPCScript _0024self__00241988;

		public _0024TalkN_00241984(string a, NPCScript self_)
		{
			_0024a_00241987 = a;
			_0024self__00241988 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241987, _0024self__00241988);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241989 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal NPCScript _0024self__00241990;

			public _0024(NPCScript self_)
			{
				_0024self__00241990 = self_;
			}

			public override bool MoveNext()
			{
				return base._state switch
				{
					1 => false, 
					_ => ((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00241990).StartCoroutine_Auto(_0024self__00241990.Move())), 
				};
			}
		}

		internal NPCScript _0024self__00241991;

		public _0024Start_00241989(NPCScript self_)
		{
			_0024self__00241991 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00241991);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00241992 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241993;

			internal int _0024dmg_00241994;

			internal NPCScript _0024self__00241995;

			public _0024(int dmg, NPCScript self_)
			{
				_0024dmg_00241994 = dmg;
				_0024self__00241995 = self_;
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
					_0024self__00241995.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241995.hp -= _0024dmg_00241994;
					_0024i_00241993 = default(int);
					if (_0024self__00241995.hp < 1)
					{
						if (MenuScript.multiplayer > 0)
						{
							for (_0024i_00241993 = 0; _0024i_00241993 < _0024self__00241995.GOLD; _0024i_00241993++)
							{
								Network.Instantiate(Resources.Load("c"), _0024self__00241995.t.position, Quaternion.identity, 0);
							}
						}
						else
						{
							for (_0024i_00241993 = 0; _0024i_00241993 < _0024self__00241995.GOLD; _0024i_00241993++)
							{
								Object.Instantiate(Resources.Load("c"), _0024self__00241995.t.position, Quaternion.identity);
							}
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(((Component)_0024self__00241995).networkView.viewID);
							Network.Destroy(((Component)_0024self__00241995).networkView.viewID);
						}
					}
					else
					{
						_0024self__00241995.takingDamage = false;
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

		internal int _0024dmg_00241996;

		internal NPCScript _0024self__00241997;

		public _0024TDN_00241992(int dmg, NPCScript self_)
		{
			_0024dmg_00241996 = dmg;
			_0024self__00241997 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241996, _0024self__00241997);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00241998 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00241999;

			internal int _0024_0024726_00242000;

			internal Vector3 _0024_0024727_00242001;

			internal int _0024dmg_00242002;

			internal NPCScript _0024self__00242003;

			public _0024(int dmg, NPCScript self_)
			{
				_0024dmg_00242002 = dmg;
				_0024self__00242003 = self_;
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
					_0024n2_00241999 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242003.t.position, Quaternion.identity);
					_0024n2_00241999.SendMessage("SD", (object)_0024dmg_00242002);
					_0024self__00242003.@base.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242003.hp < 1)
					{
						goto IL_014c;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00242003.@base.animation.Stop();
					_0024self__00242003.takingDamage = false;
					int num = (_0024_0024726_00242000 = 0);
					Vector3 val = (_0024_0024727_00242001 = _0024self__00242003.@base.transform.localPosition);
					float num2 = (_0024_0024727_00242001.z = _0024_0024726_00242000);
					Vector3 val3 = (_0024self__00242003.@base.transform.localPosition = _0024_0024727_00242001);
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

		internal int _0024dmg_00242004;

		internal NPCScript _0024self__00242005;

		public _0024TDN2_00241998(int dmg, NPCScript self_)
		{
			_0024dmg_00242004 = dmg;
			_0024self__00242005 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242004, _0024self__00242005);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Move_00242006 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCScript _0024self__00242007;

			public _0024(NPCScript self_)
			{
				_0024self__00242007 = self_;
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
					_0024self__00242007.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242007.canMove = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(1, 10))) ? 1 : 0);
					break;
				case 3:
					_0024self__00242007.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds((float)Random.Range(1, 4))) ? 1 : 0);
					break;
				case 4:
					_0024self__00242007.canMove = false;
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

		internal NPCScript _0024self__00242008;

		public _0024Move_00242006(NPCScript self_)
		{
			_0024self__00242008 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242008);
		}
	}

	public GameObject[] stand;

	public TextMesh txtTalk;

	public bool isMerchant;

	public bool isBlacksmith;

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
	}

	[RPC]
	public override IEnumerator Talk(int a)
	{
		return new _0024Talk_00241979(a, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TalkN(string a)
	{
		return new _0024TalkN_00241984(a, this).GetEnumerator();
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241989(this).GetEnumerator();
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
		if (!isMerchant && !isBlacksmith)
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
		return new _0024TDN_00241992(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00241998(dmg, this).GetEnumerator();
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (canMove)
		{
			float x = speed;
			Vector3 velocity = ((Component)this).rigidbody.velocity;
			float num = (velocity.x = x);
			Vector3 val2 = (((Component)this).rigidbody.velocity = velocity);
		}
	}

	public override IEnumerator Move()
	{
		return new _0024Move_00242006(this).GetEnumerator();
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
