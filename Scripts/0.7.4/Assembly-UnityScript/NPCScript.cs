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
	internal sealed class _0024Talk_00241920 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241921;

			internal NPCScript _0024self__00241922;

			public _0024(int a, NPCScript self_)
			{
				_0024a_00241921 = a;
				_0024self__00241922 = self_;
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
					if (_0024a_00241921 == 1)
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
							((Component)_0024self__00241922).networkView.RPC("TalkN", (RPCMode)2, new object[1] { "Smelt your ores!" });
						}
						goto IL_00a7;
					}
					_0024self__00241922.txtTalk.text = "Smelt your ores!";
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241922.txtTalk.text = string.Empty;
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

		internal int _0024a_00241923;

		internal NPCScript _0024self__00241924;

		public _0024Talk_00241920(int a, NPCScript self_)
		{
			_0024a_00241923 = a;
			_0024self__00241924 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241923, _0024self__00241924);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TalkN_00241925 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024a_00241926;

			internal NPCScript _0024self__00241927;

			public _0024(string a, NPCScript self_)
			{
				_0024a_00241926 = a;
				_0024self__00241927 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241927.txtTalk.text = _0024a_00241926 + string.Empty;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241927.txtTalk.text = string.Empty;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024a_00241928;

		internal NPCScript _0024self__00241929;

		public _0024TalkN_00241925(string a, NPCScript self_)
		{
			_0024a_00241928 = a;
			_0024self__00241929 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241928, _0024self__00241929);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241930 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal NPCScript _0024self__00241931;

			public _0024(NPCScript self_)
			{
				_0024self__00241931 = self_;
			}

			public override bool MoveNext()
			{
				return base._state switch
				{
					1 => false, 
					_ => ((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00241931).StartCoroutine_Auto(_0024self__00241931.Move())), 
				};
			}
		}

		internal NPCScript _0024self__00241932;

		public _0024Start_00241930(NPCScript self_)
		{
			_0024self__00241932 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00241932);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00241933 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241934;

			internal int _0024dmg_00241935;

			internal NPCScript _0024self__00241936;

			public _0024(int dmg, NPCScript self_)
			{
				_0024dmg_00241935 = dmg;
				_0024self__00241936 = self_;
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
					_0024self__00241936.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241936.hp -= _0024dmg_00241935;
					_0024i_00241934 = default(int);
					if (_0024self__00241936.hp < 1)
					{
						if (MenuScript.multiplayer > 0)
						{
							for (_0024i_00241934 = 0; _0024i_00241934 < _0024self__00241936.GOLD; _0024i_00241934++)
							{
								Network.Instantiate(Resources.Load("c"), _0024self__00241936.t.position, Quaternion.identity, 0);
							}
						}
						else
						{
							for (_0024i_00241934 = 0; _0024i_00241934 < _0024self__00241936.GOLD; _0024i_00241934++)
							{
								Object.Instantiate(Resources.Load("c"), _0024self__00241936.t.position, Quaternion.identity);
							}
						}
						if (Network.isServer)
						{
							Network.RemoveRPCs(((Component)_0024self__00241936).networkView.viewID);
							Network.Destroy(((Component)_0024self__00241936).networkView.viewID);
						}
					}
					else
					{
						_0024self__00241936.takingDamage = false;
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

		internal int _0024dmg_00241937;

		internal NPCScript _0024self__00241938;

		public _0024TDN_00241933(int dmg, NPCScript self_)
		{
			_0024dmg_00241937 = dmg;
			_0024self__00241938 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241937, _0024self__00241938);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00241939 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00241940;

			internal int _0024_0024703_00241941;

			internal Vector3 _0024_0024704_00241942;

			internal int _0024dmg_00241943;

			internal NPCScript _0024self__00241944;

			public _0024(int dmg, NPCScript self_)
			{
				_0024dmg_00241943 = dmg;
				_0024self__00241944 = self_;
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
					_0024n2_00241940 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00241944.t.position, Quaternion.identity);
					_0024n2_00241940.SendMessage("SD", (object)_0024dmg_00241943);
					_0024self__00241944.@base.animation.Play();
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241944.hp < 1)
					{
						goto IL_014c;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
				{
					_0024self__00241944.@base.animation.Stop();
					_0024self__00241944.takingDamage = false;
					int num = (_0024_0024703_00241941 = 0);
					Vector3 val = (_0024_0024704_00241942 = _0024self__00241944.@base.transform.localPosition);
					float num2 = (_0024_0024704_00241942.z = _0024_0024703_00241941);
					Vector3 val3 = (_0024self__00241944.@base.transform.localPosition = _0024_0024704_00241942);
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

		internal int _0024dmg_00241945;

		internal NPCScript _0024self__00241946;

		public _0024TDN2_00241939(int dmg, NPCScript self_)
		{
			_0024dmg_00241945 = dmg;
			_0024self__00241946 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00241945, _0024self__00241946);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Move_00241947 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal NPCScript _0024self__00241948;

			public _0024(NPCScript self_)
			{
				_0024self__00241948 = self_;
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
					_0024self__00241948.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					_0024self__00241948.canMove = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(1, 10))) ? 1 : 0);
					break;
				case 3:
					_0024self__00241948.canMove = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds((float)Random.Range(1, 4))) ? 1 : 0);
					break;
				case 4:
					_0024self__00241948.canMove = false;
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

		internal NPCScript _0024self__00241949;

		public _0024Move_00241947(NPCScript self_)
		{
			_0024self__00241949 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241949);
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
		return new _0024Talk_00241920(a, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TalkN(string a)
	{
		return new _0024TalkN_00241925(a, this).GetEnumerator();
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241930(this).GetEnumerator();
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
		return new _0024TDN_00241933(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00241939(dmg, this).GetEnumerator();
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
		return new _0024Move_00241947(this).GetEnumerator();
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
