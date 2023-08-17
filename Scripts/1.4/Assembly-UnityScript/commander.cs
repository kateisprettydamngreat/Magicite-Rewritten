using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class commander : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Summon_00243077 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00243078;

			internal commander _0024self__00243079;

			public _0024(commander self_)
			{
				_0024self__00243079 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_0031: Expected O, but got Unknown
				//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0103: Expected O, but got Unknown
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Expected O, but got Unknown
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024g_00243078 = null;
					goto IL_0023;
				case 2:
					if (Object.op_Implicit((Object)(object)_0024self__00243079.player) && _0024self__00243079.canFire)
					{
						if (MenuScript.multiplayer > 0)
						{
							_0024g_00243078 = (GameObject)Network.Instantiate(Resources.Load("haz/comFire"), ((Component)_0024self__00243079).transform.position, Quaternion.identity, 0);
							_0024g_00243078.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024self__00243079.player.transform.position });
						}
						else
						{
							_0024g_00243078 = (GameObject)Object.Instantiate(Resources.Load("haz/comFire"), ((Component)_0024self__00243079).transform.position, Quaternion.identity);
							_0024g_00243078.SendMessage("Set", (object)_0024self__00243079.player.transform.position);
						}
					}
					goto IL_0023;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0023:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal commander _0024self__00243080;

		public _0024Summon_00243077(commander self_)
		{
			_0024self__00243080 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243080);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00243081 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024nuu_00243082;

			internal int _0024_00241136_00243083;

			internal Vector3 _0024_00241137_00243084;

			internal commander _0024self__00243085;

			public _0024(commander self_)
			{
				_0024self__00243085 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00243085.charging && MenuScript.multiplayer == 1)
					{
						int num = (_0024_00241136_00243083 = 15);
						Vector3 val = (_0024_00241137_00243084 = _0024self__00243085.r.velocity);
						float num2 = (_0024_00241137_00243084.y = _0024_00241136_00243083);
						Vector3 val3 = (_0024self__00243085.r.velocity = _0024_00241137_00243084);
						_0024self__00243085.charging = true;
						((Component)_0024self__00243085).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
						((Component)_0024self__00243085).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						_0024nuu_00243082 = Random.Range(0, 3);
						if (_0024nuu_00243082 == 0)
						{
							_0024self__00243085.spdd = 4;
						}
						else
						{
							_0024self__00243085.spdd = -4;
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.75f)) ? 1 : 0);
						break;
					}
					goto IL_0149;
				case 2:
					((Component)_0024self__00243085).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00243085.charging = false;
					goto IL_0149;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0149:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal commander _0024self__00243086;

		public _0024ChargeRight_00243081(commander self_)
		{
			_0024self__00243086 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243086);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00243087 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024nuu_00243088;

			internal int _0024_00241138_00243089;

			internal Vector3 _0024_00241139_00243090;

			internal commander _0024self__00243091;

			public _0024(commander self_)
			{
				_0024self__00243091 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00243091.charging && MenuScript.multiplayer == 1)
					{
						int num = (_0024_00241138_00243089 = 15);
						Vector3 val = (_0024_00241139_00243090 = _0024self__00243091.r.velocity);
						float num2 = (_0024_00241139_00243090.y = _0024_00241138_00243089);
						Vector3 val3 = (_0024self__00243091.r.velocity = _0024_00241139_00243090);
						_0024self__00243091.charging = true;
						((Component)_0024self__00243091).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
						((Component)_0024self__00243091).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						_0024nuu_00243088 = Random.Range(0, 3);
						if (_0024nuu_00243088 == 0)
						{
							_0024self__00243091.spdd = -4;
						}
						else
						{
							_0024self__00243091.spdd = 4;
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.75f)) ? 1 : 0);
						break;
					}
					goto IL_0149;
				case 2:
					((Component)_0024self__00243091).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00243091.charging = false;
					goto IL_0149;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0149:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal commander _0024self__00243092;

		public _0024ChargeLeft_00243087(commander self_)
		{
			_0024self__00243092 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243092);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	private bool canFire;

	public commander()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(1500, 7, 0, 450, 10f, array, Random.Range(6, 20), 450);
		((MonoBehaviour)this).StartCoroutine_Auto(Summon());
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override IEnumerator Summon()
	{
		return new _0024Summon_00243077(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		((Ray)(ref r1U)).origin = ((Component)this).transform.position;
		((Ray)(ref r1U)).direction = Vector3.left;
		((Ray)(ref r2U)).origin = ((Component)this).transform.position;
		((Ray)(ref r2U)).direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.5f, mask2) && e.transform.rotation.y == 0f && MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 1.5f, mask2) && e.transform.rotation.y != 0f && MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
			spdd *= -1;
		}
		if (Object.op_Implicit((Object)(object)player) && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 40f) && !knocking)
		{
			canFire = true;
			if (!(player.transform.position.x <= t.position.x))
			{
				((MonoBehaviour)this).StartCoroutine_Auto(ChargeRight());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine_Auto(ChargeLeft());
			}
		}
		if (charging && !knocking)
		{
			int num = spdd;
			Vector3 velocity = r.velocity;
			float num2 = (velocity.x = num);
			Vector3 val2 = (r.velocity = velocity);
		}
	}

	public override IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00243081(this).GetEnumerator();
	}

	public override IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00243087(this).GetEnumerator();
	}

	[RPC]
	public override void Turn(int a)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (a == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion val2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion val4 = (e.transform.rotation = rotation2);
		}
	}

	[RPC]
	public override void ATK()
	{
		@base.animation.Play("a");
	}

	[RPC]
	public override void IDLE()
	{
		@base.animation.Play("i");
	}
}
