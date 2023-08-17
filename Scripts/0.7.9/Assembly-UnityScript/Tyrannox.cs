using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Tyrannox : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00242642 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024prevHP_00242643;

			internal int _0024num_00242644;

			internal Tyrannox _0024self__00242645;

			public _0024(Tyrannox self_)
			{
				_0024self__00242645 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0109: Expected O, but got Unknown
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected O, but got Unknown
				//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024prevHP_00242643 = default(int);
					goto case 4;
				case 4:
					_0024prevHP_00242643 = _0024self__00242645.HP;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242645.HP < _0024prevHP_00242643 && MenuScript.multiplayer == 1)
					{
						_0024num_00242644 = Random.Range(0, 3);
						if (_0024num_00242644 == 0 && !_0024self__00242645.roaring)
						{
							_0024self__00242645.roaring = true;
							((Component)_0024self__00242645).networkView.RPC("ROAR", (RPCMode)2, new object[0]);
							((MonoBehaviour)_0024self__00242645).StartCoroutine_Auto(_0024self__00242645.Meteor());
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
					}
					goto IL_00fb;
				case 3:
					_0024self__00242645.roaring = false;
					goto IL_00fb;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00fb:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Tyrannox _0024self__00242646;

		public _0024Check_00242642(Tyrannox self_)
		{
			_0024self__00242646 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242646);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Meteor_00242647 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242648;

			internal Tyrannox _0024self__00242649;

			public _0024(Tyrannox self_)
			{
				_0024self__00242649 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_009c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00242648 = default(int);
					if (Network.isServer)
					{
						_0024i_00242648 = 0;
						goto IL_00b9;
					}
					goto IL_00c5;
				case 2:
					_0024i_00242648++;
					goto IL_00b9;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00c5:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
					IL_00b9:
					if (_0024i_00242648 < 6)
					{
						Network.Instantiate(Resources.Load("rckP"), new Vector3(_0024self__00242649.t.position.x + (float)Random.Range(-20, 20), _0024self__00242649.t.position.y + 35f, 0f), Quaternion.identity, 0);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					goto IL_00c5;
				}
				return (byte)result != 0;
			}
		}

		internal Tyrannox _0024self__00242650;

		public _0024Meteor_00242647(Tyrannox self_)
		{
			_0024self__00242650 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242650);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242651 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Tyrannox _0024self__00242652;

			public _0024(Tyrannox self_)
			{
				_0024self__00242652 = self_;
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
					if (!_0024self__00242652.charging && MenuScript.multiplayer == 1)
					{
						_0024self__00242652.charging = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0139;
				case 2:
					((Component)_0024self__00242652).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00242652).networkView.RPC("ROAR", (RPCMode)2, new object[0]);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1.3f)) ? 1 : 0);
					break;
				case 4:
					((Component)_0024self__00242652).networkView.RPC("ATK", (RPCMode)2, new object[0]);
					_0024self__00242652.spdd = 6;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 5:
					((Component)_0024self__00242652).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00242652.spdd = 0;
					_0024self__00242652.charging = false;
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

		internal Tyrannox _0024self__00242653;

		public _0024ChargeRight_00242651(Tyrannox self_)
		{
			_0024self__00242653 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242653);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242654 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Tyrannox _0024self__00242655;

			public _0024(Tyrannox self_)
			{
				_0024self__00242655 = self_;
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
					if (!_0024self__00242655.charging && MenuScript.multiplayer == 1)
					{
						_0024self__00242655.charging = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_013a;
				case 2:
					((Component)_0024self__00242655).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00242655).networkView.RPC("ROAR", (RPCMode)2, new object[0]);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1.3f)) ? 1 : 0);
					break;
				case 4:
					((Component)_0024self__00242655).networkView.RPC("ATK", (RPCMode)2, new object[0]);
					_0024self__00242655.spdd = -6;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 5:
					((Component)_0024self__00242655).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00242655.spdd = 0;
					_0024self__00242655.charging = false;
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

		internal Tyrannox _0024self__00242656;

		public _0024ChargeLeft_00242654(Tyrannox self_)
		{
			_0024self__00242656 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242656);
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

	public Tyrannox()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		@base.animation["i"].layer = 0;
		@base.animation["a1"].layer = 0;
		@base.animation["a2"].layer = 1;
		@base.animation["a3"].layer = 1;
		@base.animation["a1"].speed = 2f;
		@base.animation["a2"].speed = 1.5f;
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 19, 20, 17 };
		SetStats(100, 3, 0, 40, 10f, array, Random.Range(6, 20), 40);
		((MonoBehaviour)this).StartCoroutine_Auto(Check());
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
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
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
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
		if (Object.op_Implicit((Object)(object)player) && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 30f) && !knocking)
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
		return new _0024Check_00242642(this).GetEnumerator();
	}

	public override IEnumerator Meteor()
	{
		return new _0024Meteor_00242647(this).GetEnumerator();
	}

	public override IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00242651(this).GetEnumerator();
	}

	public override IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242654(this).GetEnumerator();
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
		if (Object.op_Implicit((Object)(object)@base))
		{
			@base.animation.Play("a2");
		}
	}

	[RPC]
	public override void ATK()
	{
		if (Object.op_Implicit((Object)(object)@base))
		{
			@base.animation.Play("a1");
		}
	}

	[RPC]
	public override void SUMMON()
	{
		if (Object.op_Implicit((Object)(object)@base))
		{
			@base.animation.Play("a3");
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
