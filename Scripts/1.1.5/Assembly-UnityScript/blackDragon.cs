using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class blackDragon : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00243027 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00243028;

			internal Vector3 _0024pp2_00243029;

			internal Vector3 _0024pp_00243030;

			internal blackDragon _0024self__00243031;

			public _0024(Vector3 pp, blackDragon self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024pp_00243030 = pp;
				_0024self__00243031 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_04df: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e9: Expected O, but got Unknown
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_040a: Unknown result type (might be due to invalid IL or missing references)
				//IL_041a: Unknown result type (might be due to invalid IL or missing references)
				//IL_041f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0424: Unknown result type (might be due to invalid IL or missing references)
				//IL_0439: Unknown result type (might be due to invalid IL or missing references)
				//IL_043e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0451: Unknown result type (might be due to invalid IL or missing references)
				//IL_0456: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Expected O, but got Unknown
				//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ce: Expected O, but got Unknown
				//IL_030a: Unknown result type (might be due to invalid IL or missing references)
				//IL_031f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0324: Unknown result type (might be due to invalid IL or missing references)
				//IL_0329: Unknown result type (might be due to invalid IL or missing references)
				//IL_033e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0343: Unknown result type (might be due to invalid IL or missing references)
				//IL_0356: Unknown result type (might be due to invalid IL or missing references)
				//IL_035b: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_047e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fa: Expected O, but got Unknown
				//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0382: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d2: Expected O, but got Unknown
				//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_023c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Expected O, but got Unknown
				//IL_0260: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ba: Expected O, but got Unknown
				//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c7: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00243031.ATKING = true;
					if (!(_0024pp_00243030.x <= ((Component)_0024self__00243031).transform.position.x))
					{
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00243031).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
						}
						else
						{
							_0024self__00243031.Turn(1);
						}
					}
					else if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00243031).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
					}
					else
					{
						_0024self__00243031.Turn(0);
					}
					_0024g_00243028 = null;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00243031).networkView.RPC("A1", (RPCMode)2, new object[0]);
					}
					else
					{
						_0024self__00243031.@base.animation.Play("a");
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 3:
					if (Object.op_Implicit((Object)(object)_0024self__00243031.player))
					{
						_0024pp2_00243029 = _0024self__00243031.player.transform.position;
						if (MenuScript.multiplayer > 0)
						{
							if (MenuScript.multiplayer == 1)
							{
								_0024g_00243028 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire2"), ((Component)_0024self__00243031).transform.position, Quaternion.identity, 0);
								_0024g_00243028.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00243029 });
								_0024pp2_00243029.y += 10f;
								_0024g_00243028 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire2"), ((Component)_0024self__00243031).transform.position, Quaternion.identity, 0);
								_0024g_00243028.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00243029 });
								_0024pp2_00243029.y -= 20f;
								_0024g_00243028 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire2"), ((Component)_0024self__00243031).transform.position, Quaternion.identity, 0);
							}
							_0024g_00243028.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00243029 });
						}
					}
					if (Object.op_Implicit((Object)(object)_0024self__00243031.player))
					{
						_0024self__00243031.curVector = _0024self__00243031.t.position - _0024self__00243031.player.transform.position;
						if (!(_0024self__00243031.player.transform.position.x <= _0024self__00243031.t.position.x))
						{
							_0024self__00243031.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00243031.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
					}
					_0024self__00243031.atking = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00243031.atking = false;
					if (Object.op_Implicit((Object)(object)_0024self__00243031.player))
					{
						_0024self__00243031.curVector = _0024self__00243031.player.transform.position - _0024self__00243031.t.position;
						if (!(_0024self__00243031.player.transform.position.x <= _0024self__00243031.t.position.x))
						{
							_0024self__00243031.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00243031.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00243031.atking = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 5;
				case 5:
					_0024self__00243031.atking = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 6:
					_0024self__00243031.ATKING = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00243032;

		internal blackDragon _0024self__00243033;

		public _0024Attack_00243027(Vector3 pp, blackDragon self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024pp_00243032 = pp;
			_0024self__00243033 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024pp_00243032, _0024self__00243033);
		}
	}

	public AudioClip roar;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

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

	private bool atking;

	public blackDragon()
	{
		speed = 10f;
		mask = 256;
		mask2 = 2048;
	}

	public override void Start()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		@base.animation["i"].layer = 0;
		@base.animation["i"].speed = 0.7f;
		@base.animation["a"].layer = 1;
		int[] array = new int[3] { 7, 18, 20 };
		SetStats(1000, 8, 2, 700, 2f, array, Random.Range(10, 25), 700);
		float y = ((Component)this).transform.position.y + (float)Random.Range(3, 10);
		Vector3 position = ((Component)this).transform.position;
		float num = (position.y = y);
		Vector3 val2 = (((Component)this).transform.position = position);
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
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && MenuScript.multiplayer == 1)
		{
			if (!(Mathf.Abs(player.transform.position.x - t.position.x) >= 50f) && !ATKING)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Attack(player.transform.position));
			}
			else if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 50f) && !knocking && r.isKinematic)
			{
				t.Translate(((Vector3)(ref curVector)).normalized * 6f * Time.deltaTime);
			}
		}
	}

	public override IEnumerator Attack(Vector3 pp)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Attack_00243027(pp, this).GetEnumerator();
	}

	[RPC]
	public override void A1()
	{
		@base.animation.Play("a");
		((Component)this).audio.PlayOneShot(roar);
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
}
