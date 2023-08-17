using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class AbyssalTitan : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Trigger_00241261 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal AbyssalTitan _0024self__00241262;

			public _0024(AbyssalTitan self_)
			{
				_0024self__00241262 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Expected O, but got Unknown
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(5, 10))) ? 1 : 0);
					break;
				case 2:
					_0024self__00241262.trigger.SetActive(false);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(5, 10))) ? 1 : 0);
					break;
				case 3:
					_0024self__00241262.trigger.SetActive(true);
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal AbyssalTitan _0024self__00241263;

		public _0024Trigger_00241261(AbyssalTitan self_)
		{
			_0024self__00241263 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241263);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241264 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal AbyssalTitan _0024self__00241265;

			public _0024(AbyssalTitan self_)
			{
				_0024self__00241265 = self_;
			}

			public override bool MoveNext()
			{
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (Object.op_Implicit((Object)(object)_0024self__00241265.player))
					{
						_0024self__00241265.curVector = _0024self__00241265.player.transform.position - _0024self__00241265.t.position;
						if (!(_0024self__00241265.player.transform.position.x <= _0024self__00241265.t.position.x))
						{
							_0024self__00241265.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00241265.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00241265.atking = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00241265).networkView.RPC("ShootA", (RPCMode)2, new object[0]);
						if (MenuScript.multiplayer == 1)
						{
							((MonoBehaviour)_0024self__00241265).StartCoroutine_Auto(_0024self__00241265.Shoot());
						}
					}
					else
					{
						((MonoBehaviour)_0024self__00241265).StartCoroutine_Auto(_0024self__00241265.Shoot());
					}
					_0024self__00241265.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal AbyssalTitan _0024self__00241266;

		public _0024Attack_00241264(AbyssalTitan self_)
		{
			_0024self__00241266 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241266);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Shoot_00241267 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241268;

			internal AbyssalTitan _0024self__00241269;

			public _0024(AbyssalTitan self_)
			{
				_0024self__00241269 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0146: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Expected O, but got Unknown
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Expected O, but got Unknown
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Expected O, but got Unknown
				//IL_0171: Unknown result type (might be due to invalid IL or missing references)
				//IL_0176: Unknown result type (might be due to invalid IL or missing references)
				//IL_020b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0215: Expected O, but got Unknown
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_019f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Expected O, but got Unknown
				//IL_01db: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241268 = default(int);
					if (MenuScript.multiplayer > 0)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					_0024self__00241269.@base.animation.Play("a");
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024i_00241268 = 0;
					goto IL_00fd;
				case 3:
					_0024i_00241268++;
					goto IL_00fd;
				case 5:
					_0024i_00241268 = 0;
					goto IL_01f8;
				case 6:
					_0024i_00241268++;
					goto IL_01f8;
				case 4:
				case 7:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01f8:
					if (_0024i_00241268 < 3)
					{
						if (_0024self__00241269.e.transform.rotation.y != 0f)
						{
							Object.Instantiate(Resources.Load("ballR"), _0024self__00241269.t.position, Quaternion.identity);
						}
						else
						{
							Object.Instantiate(Resources.Load("ballL"), _0024self__00241269.t.position, Quaternion.identity);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.2f)) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(0.2f)) ? 1 : 0);
					}
					break;
					IL_00fd:
					if (_0024i_00241268 < 3)
					{
						if (_0024self__00241269.e.transform.rotation.y != 0f)
						{
							Network.Instantiate(Resources.Load("ballR"), _0024self__00241269.t.position, Quaternion.identity, 0);
						}
						else
						{
							Network.Instantiate(Resources.Load("ballL"), _0024self__00241269.t.position, Quaternion.identity, 0);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					}
					break;
				}
				return (byte)result != 0;
			}
		}

		internal AbyssalTitan _0024self__00241270;

		public _0024Shoot_00241267(AbyssalTitan self_)
		{
			_0024self__00241270 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241270);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00241271 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00241272;

			internal int _0024_0024404_00241273;

			internal Vector3 _0024_0024405_00241274;

			internal int _0024_0024406_00241275;

			internal Vector3 _0024_0024407_00241276;

			internal int _0024_0024408_00241277;

			internal Vector3 _0024_0024409_00241278;

			internal int _0024_0024410_00241279;

			internal Vector3 _0024_0024411_00241280;

			internal bool _0024l_00241281;

			internal AbyssalTitan _0024self__00241282;

			public _0024(bool l, AbyssalTitan self_)
			{
				_0024l_00241281 = l;
				_0024self__00241282 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_0251: Expected O, but got Unknown
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_0195: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_021f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0224: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Expected O, but got Unknown
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00241282).networkView.RPC("KN", (RPCMode)2, new object[1] { _0024l_00241281 });
						goto IL_027e;
					}
					_0024self__00241282.knocking = true;
					_0024wasK_00241272 = default(bool);
					if (((Component)_0024self__00241282).rigidbody.isKinematic)
					{
						_0024wasK_00241272 = true;
						((Component)_0024self__00241282).rigidbody.isKinematic = false;
					}
					if (_0024l_00241281)
					{
						int num = (_0024_0024404_00241273 = -15);
						Vector3 val = (_0024_0024405_00241274 = ((Component)_0024self__00241282).rigidbody.velocity);
						float num2 = (_0024_0024405_00241274.x = _0024_0024404_00241273);
						Vector3 val3 = (((Component)_0024self__00241282).rigidbody.velocity = _0024_0024405_00241274);
						int num3 = (_0024_0024406_00241275 = 10);
						Vector3 val4 = (_0024_0024407_00241276 = ((Component)_0024self__00241282).rigidbody.velocity);
						float num4 = (_0024_0024407_00241276.y = _0024_0024406_00241275);
						Vector3 val6 = (((Component)_0024self__00241282).rigidbody.velocity = _0024_0024407_00241276);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024408_00241277 = 15);
						Vector3 val7 = (_0024_0024409_00241278 = ((Component)_0024self__00241282).rigidbody.velocity);
						float num6 = (_0024_0024409_00241278.x = _0024_0024408_00241277);
						Vector3 val9 = (((Component)_0024self__00241282).rigidbody.velocity = _0024_0024409_00241278);
						int num7 = (_0024_0024410_00241279 = 10);
						Vector3 val10 = (_0024_0024411_00241280 = ((Component)_0024self__00241282).rigidbody.velocity);
						float num8 = (_0024_0024411_00241280.y = _0024_0024410_00241279);
						Vector3 val12 = (((Component)_0024self__00241282).rigidbody.velocity = _0024_0024411_00241280);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241282.knocking = false;
					if (_0024wasK_00241272)
					{
						((Component)_0024self__00241282).rigidbody.isKinematic = true;
					}
					goto IL_027e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_027e:
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00241283;

		internal AbyssalTitan _0024self__00241284;

		public _0024K_00241271(bool l, AbyssalTitan self_)
		{
			_0024l_00241283 = l;
			_0024self__00241284 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00241283, _0024self__00241284);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	public GameObject trigger;

	public AbyssalTitan()
	{
		speed = 15f;
	}

	public override void Awake()
	{
		@base.animation["i"].layer = 1;
		@base.animation["a"].layer = 2;
		((Component)this).audio.PlayOneShot(scourge1);
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(220, 12, 1, 170, 10f, array, Random.Range(10, 30), 170);
		player = GameObject.Find("player(Clone)");
		if ((Object)(object)player == (Object)null)
		{
			player = GameObject.Find("playerN(Clone)");
		}
		((MonoBehaviour)this).StartCoroutine_Auto(Attack());
		((MonoBehaviour)this).StartCoroutine_Auto(Trigger());
		if (MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			MAXHP = 220 + 100 * (Network.connections.Length + 1);
			HP = MAXHP;
			MonoBehaviour.print((object)((object)HP + "is HP======"));
		}
	}

	public override void OnDestroy()
	{
		GameScript.bossDefeated = true;
	}

	public override IEnumerator Trigger()
	{
		return new _0024Trigger_00241261(this).GetEnumerator();
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 13)
		{
			MonoBehaviour.print((object)"hit");
			((Component)c).gameObject.SendMessage("TD", (object)ATK);
		}
		else if (((Component)c).gameObject.layer == 18)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(TD(1));
		}
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 200f) && !knocking && r.isKinematic)
		{
			t.Translate(((Vector3)(ref curVector)).normalized * speed * Time.deltaTime);
		}
	}

	public override IEnumerator Attack()
	{
		return new _0024Attack_00241264(this).GetEnumerator();
	}

	public override IEnumerator Shoot()
	{
		return new _0024Shoot_00241267(this).GetEnumerator();
	}

	[RPC]
	public override void ShootA()
	{
		@base.animation.Play("a");
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00241271(l, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
