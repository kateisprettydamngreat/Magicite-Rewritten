using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ScourgeKnightScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242604 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024noo_00242605;

			internal int _0024n_00242606;

			internal GameObject _0024g_00242607;

			internal int _0024_0024938_00242608;

			internal Vector3 _0024_0024939_00242609;

			internal int _0024_0024940_00242610;

			internal Vector3 _0024_0024941_00242611;

			internal int _0024_0024942_00242612;

			internal Vector3 _0024_0024943_00242613;

			internal Vector3 _0024pp_00242614;

			internal ScourgeKnightScript _0024self__00242615;

			public _0024(Vector3 pp, ScourgeKnightScript self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024pp_00242614 = pp;
				_0024self__00242615 = self_;
			}

			public override bool MoveNext()
			{
				//IL_01db: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e7: Expected O, but got Unknown
				//IL_014e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_0156: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_0188: Unknown result type (might be due to invalid IL or missing references)
				//IL_018f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ea: Expected O, but got Unknown
				//IL_0393: Unknown result type (might be due to invalid IL or missing references)
				//IL_0398: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ac: Expected O, but got Unknown
				//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0325: Unknown result type (might be due to invalid IL or missing references)
				//IL_032a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0335: Unknown result type (might be due to invalid IL or missing references)
				//IL_033f: Expected O, but got Unknown
				//IL_0368: Unknown result type (might be due to invalid IL or missing references)
				//IL_0199: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a3: Expected O, but got Unknown
				//IL_0283: Unknown result type (might be due to invalid IL or missing references)
				//IL_028d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024noo_00242605 = Random.Range(0, 4);
					if (_0024noo_00242605 == 0)
					{
						_0024self__00242615.ATKING = true;
						((Component)_0024self__00242615).networkView.RPC("J", (RPCMode)2, new object[0]);
						int num = (_0024_0024938_00242608 = 26);
						Vector3 val = (_0024_0024939_00242609 = _0024self__00242615.r.velocity);
						float num2 = (_0024_0024939_00242609.y = _0024_0024938_00242608);
						Vector3 val3 = (_0024self__00242615.r.velocity = _0024_0024939_00242609);
						_0024n_00242606 = Random.Range(0, 2);
						if (_0024n_00242606 != 0)
						{
							int num3 = (_0024_0024942_00242612 = -13);
							Vector3 val4 = (_0024_0024943_00242613 = _0024self__00242615.r.velocity);
							float num4 = (_0024_0024943_00242613.x = _0024_0024942_00242612);
							Vector3 val6 = (_0024self__00242615.r.velocity = _0024_0024943_00242613);
						}
						else
						{
							int num5 = (_0024_0024940_00242610 = 13);
							Vector3 val7 = (_0024_0024941_00242611 = _0024self__00242615.r.velocity);
							float num6 = (_0024_0024941_00242611.x = _0024_0024940_00242610);
							Vector3 val9 = (_0024self__00242615.r.velocity = _0024_0024941_00242611);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
						break;
					}
					_0024self__00242615.ATKING = true;
					if (!(_0024pp_00242614.x <= ((Component)_0024self__00242615).transform.position.x))
					{
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242615).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
						}
						else
						{
							_0024self__00242615.Turn(1);
						}
					}
					else if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242615).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
					}
					else
					{
						_0024self__00242615.Turn(0);
					}
					_0024g_00242607 = null;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242615.ATKING = false;
					goto IL_03f8;
				case 3:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242615).networkView.RPC("A1", (RPCMode)2, new object[0]);
					}
					else
					{
						_0024self__00242615.@base.animation.Play("a1");
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 4:
					if (Object.op_Implicit((Object)(object)_0024self__00242615.player))
					{
						if (MenuScript.multiplayer > 0)
						{
							_0024g_00242607 = (GameObject)Network.Instantiate(Resources.Load("haz/scourgeFire"), ((Component)_0024self__00242615).transform.position, Quaternion.identity, 0);
							_0024g_00242607.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024self__00242615.player.transform.position });
						}
						else
						{
							_0024g_00242607 = (GameObject)Object.Instantiate(Resources.Load("haz/scourgeFire"), ((Component)_0024self__00242615).transform.position, Quaternion.identity);
							_0024g_00242607.SendMessage("Set", (object)_0024self__00242615.player.transform.position);
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(1.8f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00242615.ATKING = false;
					goto IL_03f8;
				case 1:
					{
						result = 0;
						break;
					}
					IL_03f8:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00242616;

		internal ScourgeKnightScript _0024self__00242617;

		public _0024Attack_00242604(Vector3 pp, ScourgeKnightScript self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024pp_00242616 = pp;
			_0024self__00242617 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024pp_00242616, _0024self__00242617);
		}
	}

	private RaycastHit hit;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private int mask;

	private int spd;

	private bool turning;

	private int mask2;

	private bool ATKING;

	private GameObject player;

	private bool initialized;

	public ScourgeKnightScript()
	{
		mask = 256;
		mask2 = 2048;
	}

	public override void Start()
	{
		@base.animation["i"].layer = 0;
		@base.animation["a"].layer = 1;
		@base.animation["j"].layer = 2;
		@base.animation["a"].speed = 1.7f;
		@base.animation["j"].speed = 0.5f;
		int[] array = new int[3] { 15, 15, 15 };
		SetStats(200, 3, 2, 15, 2f, array, Random.Range(10, 25), 15);
	}

	public override void Update()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !ATKING && MenuScript.multiplayer == 1)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Attack(player.transform.position));
		}
	}

	public override IEnumerator Attack(Vector3 pp)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Attack_00242604(pp, this).GetEnumerator();
	}

	[RPC]
	public override void A1()
	{
		@base.animation.Play("a");
	}

	[RPC]
	public override void J()
	{
		@base.animation.Play("j");
	}

	[RPC]
	public override void Turn(int dir)
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
		if (dir == 0)
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
	public override void I()
	{
		@base.SetActive(true);
	}

	public override void SetPlayer(GameObject p)
	{
		if (!initialized)
		{
			initialized = true;
			@base.SetActive(true);
			if (MenuScript.multiplayer > 0 && Network.isServer)
			{
				((Component)this).networkView.RPC("I", (RPCMode)2, new object[0]);
			}
		}
		player = p;
	}
}
