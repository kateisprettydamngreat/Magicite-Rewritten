using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SpiderScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242815 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241030_00242816;

			internal Vector3 _0024_00241031_00242817;

			internal SpiderScript _0024self__00242818;

			public _0024(SpiderScript self_)
			{
				_0024self__00242818 = self_;
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
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242818.charging && MenuScript.multiplayer == 1)
					{
						int num = (_0024_00241030_00242816 = 15);
						Vector3 val = (_0024_00241031_00242817 = _0024self__00242818.r.velocity);
						float num2 = (_0024_00241031_00242817.y = _0024_00241030_00242816);
						Vector3 val3 = (_0024self__00242818.r.velocity = _0024_00241031_00242817);
						_0024self__00242818.charging = true;
						((Component)_0024self__00242818).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
						((Component)_0024self__00242818).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						_0024self__00242818.spdd = 5;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_011c;
				case 2:
					((Component)_0024self__00242818).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00242818.charging = false;
					goto IL_011c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_011c:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal SpiderScript _0024self__00242819;

		public _0024ChargeRight_00242815(SpiderScript self_)
		{
			_0024self__00242819 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242819);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242820 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241032_00242821;

			internal Vector3 _0024_00241033_00242822;

			internal SpiderScript _0024self__00242823;

			public _0024(SpiderScript self_)
			{
				_0024self__00242823 = self_;
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
				//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242823.charging && MenuScript.multiplayer == 1)
					{
						int num = (_0024_00241032_00242821 = 15);
						Vector3 val = (_0024_00241033_00242822 = _0024self__00242823.r.velocity);
						float num2 = (_0024_00241033_00242822.y = _0024_00241032_00242821);
						Vector3 val3 = (_0024self__00242823.r.velocity = _0024_00241033_00242822);
						_0024self__00242823.charging = true;
						((Component)_0024self__00242823).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
						((Component)_0024self__00242823).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						_0024self__00242823.spdd = -5;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_011d;
				case 2:
					((Component)_0024self__00242823).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00242823.charging = false;
					goto IL_011d;
				case 1:
					{
						result = 0;
						break;
					}
					IL_011d:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal SpiderScript _0024self__00242824;

		public _0024ChargeLeft_00242820(SpiderScript self_)
		{
			_0024self__00242824 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242824);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	public SpiderScript()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		@base.animation["i"].layer = 0;
		@base.animation["r"].layer = 1;
		int[] array = new int[3] { 23, 0, 10 };
		SetStats(20, 2, 13, 6, 5f, array, Random.Range(5, 15), 6);
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 7f) && !knocking)
		{
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
		return new _0024ChargeRight_00242815(this).GetEnumerator();
	}

	public override IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242820(this).GetEnumerator();
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
