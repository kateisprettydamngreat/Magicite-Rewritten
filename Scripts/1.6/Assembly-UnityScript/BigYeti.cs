using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BigYeti : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00241385 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024prevHP_00241386;

			internal int _0024num_00241387;

			internal BigYeti _0024self__00241388;

			public _0024(BigYeti self_)
			{
				_0024self__00241388 = self_;
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
					_0024prevHP_00241386 = default(int);
					goto case 4;
				case 4:
					_0024prevHP_00241386 = _0024self__00241388.HP;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241388.HP < _0024prevHP_00241386 && MenuScript.multiplayer == 1)
					{
						_0024num_00241387 = Random.Range(0, 2);
						if (_0024num_00241387 == 0 && !_0024self__00241388.roaring)
						{
							_0024self__00241388.roaring = true;
							((Component)_0024self__00241388).networkView.RPC("ROAR", (RPCMode)2, new object[0]);
							((MonoBehaviour)_0024self__00241388).StartCoroutine_Auto(_0024self__00241388.Meteor());
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
					}
					goto IL_00fb;
				case 3:
					_0024self__00241388.roaring = false;
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

		internal BigYeti _0024self__00241389;

		public _0024Check_00241385(BigYeti self_)
		{
			_0024self__00241389 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241389);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Meteor_00241390 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241391;

			internal GameObject _0024g_00241392;

			internal Vector3 _0024pp2_00241393;

			internal BigYeti _0024self__00241394;

			public _0024(BigYeti self_)
			{
				_0024self__00241394 = self_;
			}

			public override bool MoveNext()
			{
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0114: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Expected O, but got Unknown
				//IL_0143: Unknown result type (might be due to invalid IL or missing references)
				//IL_0176: Unknown result type (might be due to invalid IL or missing references)
				//IL_0180: Expected O, but got Unknown
				//IL_019b: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Expected O, but got Unknown
				//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Unknown result type (might be due to invalid IL or missing references)
				//IL_020c: Expected O, but got Unknown
				//IL_0227: Unknown result type (might be due to invalid IL or missing references)
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0237: Unknown result type (might be due to invalid IL or missing references)
				//IL_0241: Expected O, but got Unknown
				//IL_025b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0272: Unknown result type (might be due to invalid IL or missing references)
				//IL_027c: Expected O, but got Unknown
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f4: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241391 = default(int);
					if (MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
					{
						_0024self__00241394.atking = true;
						_0024g_00241392 = null;
						_0024pp2_00241393 = default(Vector3);
						if (!(_0024self__00241394.e.transform.rotation.y <= 0.1f))
						{
							_0024pp2_00241393 = new Vector3(1f, 0f, 0f);
						}
						else
						{
							_0024pp2_00241393 = new Vector3(-1f, 0f, 0f);
						}
						MonoBehaviour.print((object)((object)_0024self__00241394.e.transform.rotation.y + "is rotation"));
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_028d;
				case 2:
					_0024g_00241392 = (GameObject)Network.Instantiate(Resources.Load("haz/yetiSnow"), ((Component)_0024self__00241394).transform.position, Quaternion.identity, 0);
					_0024g_00241392.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00241393 });
					_0024pp2_00241393.y += 0.25f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024g_00241392 = (GameObject)Network.Instantiate(Resources.Load("haz/yetiSnow"), ((Component)_0024self__00241394).transform.position, Quaternion.identity, 0);
					_0024g_00241392.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00241393 });
					_0024pp2_00241393.y -= 0.5f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024g_00241392 = (GameObject)Network.Instantiate(Resources.Load("haz/yetiSnow"), ((Component)_0024self__00241394).transform.position, Quaternion.identity, 0);
					_0024g_00241392.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00241393 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241394.atking = false;
					goto IL_028d;
				case 1:
					{
						result = 0;
						break;
					}
					IL_028d:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BigYeti _0024self__00241395;

		public _0024Meteor_00241390(BigYeti self_)
		{
			_0024self__00241395 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241395);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00241396 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BigYeti _0024self__00241397;

			public _0024(BigYeti self_)
			{
				_0024self__00241397 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Expected O, but got Unknown
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Expected O, but got Unknown
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241397.charging && MenuScript.multiplayer == 1 && !_0024self__00241397.atking)
					{
						_0024self__00241397.charging = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0113;
				case 2:
					((Component)_0024self__00241397).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00241397).networkView.RPC("ATK", (RPCMode)2, new object[0]);
					_0024self__00241397.spdd = 8;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 4:
					((Component)_0024self__00241397).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00241397.spdd = 0;
					_0024self__00241397.charging = false;
					goto IL_0113;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0113:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BigYeti _0024self__00241398;

		public _0024ChargeRight_00241396(BigYeti self_)
		{
			_0024self__00241398 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241398);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00241399 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BigYeti _0024self__00241400;

			public _0024(BigYeti self_)
			{
				_0024self__00241400 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Expected O, but got Unknown
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00db: Expected O, but got Unknown
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241400.charging && MenuScript.multiplayer == 1 && !_0024self__00241400.atking)
					{
						_0024self__00241400.charging = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0114;
				case 2:
					((Component)_0024self__00241400).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00241400).networkView.RPC("ATK", (RPCMode)2, new object[0]);
					_0024self__00241400.spdd = -8;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 4:
					((Component)_0024self__00241400).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00241400.spdd = 0;
					_0024self__00241400.charging = false;
					goto IL_0114;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0114:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BigYeti _0024self__00241401;

		public _0024ChargeLeft_00241399(BigYeti self_)
		{
			_0024self__00241401 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241401);
		}
	}

	private GameObject player;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private bool roaring;

	private bool atking;

	private Ray r2U;

	public BigYeti()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		@base.animation["i"].layer = 0;
		@base.animation["r"].layer = 0;
		@base.animation["a"].layer = 1;
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(150, 4, 0, 40, 10f, array, Random.Range(6, 20), 40);
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
		return new _0024Check_00241385(this).GetEnumerator();
	}

	public override IEnumerator Meteor()
	{
		return new _0024Meteor_00241390(this).GetEnumerator();
	}

	public override IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00241396(this).GetEnumerator();
	}

	public override IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00241399(this).GetEnumerator();
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
			@base.animation.Play("a");
		}
	}

	[RPC]
	public override void ATK()
	{
		if (Object.op_Implicit((Object)(object)@base))
		{
			@base.animation.Play("r");
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
