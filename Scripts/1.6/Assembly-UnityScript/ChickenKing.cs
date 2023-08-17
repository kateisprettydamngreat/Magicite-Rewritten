using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ChickenKing : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Jump_00241455 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241456;

			internal int _0024_0024510_00241457;

			internal Vector3 _0024_0024511_00241458;

			internal ChickenKing _0024self__00241459;

			public _0024(ChickenKing self_)
			{
				_0024self__00241459 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Expected O, but got Unknown
				//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ca: Expected O, but got Unknown
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024a_00241456 = Random.Range(0, 3);
					if (_0024a_00241456 == 0)
					{
						((Component)_0024self__00241459).audio.PlayOneShot((AudioClip)Resources.Load("Au/ch"));
					}
					if (_0024self__00241459.charging)
					{
						int num = (_0024_0024510_00241457 = 35);
						Vector3 val = (_0024_0024511_00241458 = ((Component)_0024self__00241459).rigidbody.velocity);
						float num2 = (_0024_0024511_00241458.y = _0024_0024510_00241457);
						Vector3 val3 = (((Component)_0024self__00241459).rigidbody.velocity = _0024_0024511_00241458);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2.5f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ChickenKing _0024self__00241460;

		public _0024Jump_00241455(ChickenKing self_)
		{
			_0024self__00241460 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241460);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00241461 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024prevHP_00241462;

			internal int _0024num_00241463;

			internal ChickenKing _0024self__00241464;

			public _0024(ChickenKing self_)
			{
				_0024self__00241464 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Expected O, but got Unknown
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected O, but got Unknown
				//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024prevHP_00241462 = default(int);
					goto case 4;
				case 4:
					_0024prevHP_00241462 = _0024self__00241464.HP;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241464.HP < _0024prevHP_00241462 && MenuScript.multiplayer == 1)
					{
						_0024num_00241463 = Random.Range(0, 3);
						if (_0024num_00241463 == 0 && !_0024self__00241464.roaring)
						{
							_0024self__00241464.roaring = true;
							((Component)_0024self__00241464).networkView.RPC("ROAR", (RPCMode)2, new object[0]);
							_0024self__00241464.Meteor();
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
					}
					goto IL_00ef;
				case 3:
					_0024self__00241464.roaring = false;
					goto IL_00ef;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00ef:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ChickenKing _0024self__00241465;

		public _0024Check_00241461(ChickenKing self_)
		{
			_0024self__00241465 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241465);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00241466 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ChickenKing _0024self__00241467;

			public _0024(ChickenKing self_)
			{
				_0024self__00241467 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Expected O, but got Unknown
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c5: Expected O, but got Unknown
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Expected O, but got Unknown
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241467.charging && MenuScript.multiplayer == 1)
					{
						_0024self__00241467.charging = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0139;
				case 2:
					((Component)_0024self__00241467).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00241467).networkView.RPC("ROAR", (RPCMode)2, new object[0]);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1.3f)) ? 1 : 0);
					break;
				case 4:
					((Component)_0024self__00241467).networkView.RPC("ATK", (RPCMode)2, new object[0]);
					_0024self__00241467.spdd = 6;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 5:
					((Component)_0024self__00241467).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00241467.spdd = 0;
					_0024self__00241467.charging = false;
					goto IL_0139;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0139:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ChickenKing _0024self__00241468;

		public _0024ChargeRight_00241466(ChickenKing self_)
		{
			_0024self__00241468 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241468);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00241469 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ChickenKing _0024self__00241470;

			public _0024(ChickenKing self_)
			{
				_0024self__00241470 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Expected O, but got Unknown
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c5: Expected O, but got Unknown
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0101: Expected O, but got Unknown
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241470.charging && MenuScript.multiplayer == 1)
					{
						_0024self__00241470.charging = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_013a;
				case 2:
					((Component)_0024self__00241470).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00241470).networkView.RPC("ROAR", (RPCMode)2, new object[0]);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1.3f)) ? 1 : 0);
					break;
				case 4:
					((Component)_0024self__00241470).networkView.RPC("ATK", (RPCMode)2, new object[0]);
					_0024self__00241470.spdd = -6;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 5:
					((Component)_0024self__00241470).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00241470.spdd = 0;
					_0024self__00241470.charging = false;
					goto IL_013a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_013a:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ChickenKing _0024self__00241471;

		public _0024ChargeLeft_00241469(ChickenKing self_)
		{
			_0024self__00241471 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241471);
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

	private bool roaring;

	private Ray r2U;

	public ChickenKing()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		@base.animation["i"].layer = 0;
		@base.animation["a"].layer = 0;
		@base.animation["a"].speed = 2f;
		@base.animation["i"].speed = 2f;
		((MonoBehaviour)this).StartCoroutine_Auto(Jump());
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 42, 42, 42 };
		SetStats(300, 2, 0, 40, 10f, array, Random.Range(6, 20), 40);
		((MonoBehaviour)this).StartCoroutine_Auto(Check());
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override IEnumerator Jump()
	{
		return new _0024Jump_00241455(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		((Ray)(ref r1U)).origin = ((Component)this).transform.position;
		((Ray)(ref r1U)).direction = Vector3.left;
		((Ray)(ref r2U)).origin = ((Component)this).transform.position;
		((Ray)(ref r2U)).direction = Vector3.right;
		if (Physics.Raycast(r1U, 3f, mask2) && e.transform.rotation.y == 0f && MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 3f, mask2) && e.transform.rotation.y != 0f && MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
			spdd *= -1;
		}
		if (Object.op_Implicit((Object)(object)player) && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 150f) && !knocking)
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
		else
		{
			int num3 = 0;
			Vector3 velocity2 = r.velocity;
			float num4 = (velocity2.x = num3);
			Vector3 val4 = (r.velocity = velocity2);
		}
		if (roaring)
		{
			int num5 = 0;
			Vector3 velocity3 = r.velocity;
			float num6 = (velocity3.x = num5);
			Vector3 val6 = (r.velocity = velocity3);
		}
	}

	public override IEnumerator Check()
	{
		return new _0024Check_00241461(this).GetEnumerator();
	}

	public override void Meteor()
	{
	}

	public override IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00241466(this).GetEnumerator();
	}

	public override IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00241469(this).GetEnumerator();
	}

	[RPC]
	public override void Turn(int a)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)e))
		{
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
	}

	[RPC]
	public override void ROAR()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)@base))
		{
			@base.animation.Play("a");
		}
		if (Network.isServer)
		{
			int num = 50;
			Vector3 velocity = ((Component)this).rigidbody.velocity;
			float num2 = (velocity.y = num);
			Vector3 val2 = (((Component)this).rigidbody.velocity = velocity);
		}
	}

	[RPC]
	public override void ATK()
	{
		if (Object.op_Implicit((Object)(object)@base))
		{
			@base.animation.Play("a");
		}
	}

	[RPC]
	public override void SUMMON()
	{
		if (Object.op_Implicit((Object)(object)@base))
		{
			@base.animation.Play("a");
		}
	}

	[RPC]
	public override void IDLE()
	{
		if (Object.op_Implicit((Object)(object)@base))
		{
			@base.animation.Play("i");
		}
	}
}
