using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Whelp : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242601 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00242602;

			internal Vector3 _0024pp2_00242603;

			internal int _0024num_00242604;

			internal Vector3 _0024pp_00242605;

			internal Whelp _0024self__00242606;

			public _0024(Vector3 pp, Whelp self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024pp_00242605 = pp;
				_0024self__00242606 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0531: Unknown result type (might be due to invalid IL or missing references)
				//IL_053b: Expected O, but got Unknown
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
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
				//IL_045c: Unknown result type (might be due to invalid IL or missing references)
				//IL_046c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0471: Unknown result type (might be due to invalid IL or missing references)
				//IL_0476: Unknown result type (might be due to invalid IL or missing references)
				//IL_041d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0432: Unknown result type (might be due to invalid IL or missing references)
				//IL_0437: Unknown result type (might be due to invalid IL or missing references)
				//IL_043c: Unknown result type (might be due to invalid IL or missing references)
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
				//IL_048b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0490: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_050f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0519: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242606.ATKING = true;
					if (!(_0024pp_00242605.x <= ((Component)_0024self__00242606).transform.position.x))
					{
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242606).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
						}
						else
						{
							_0024self__00242606.Turn(1);
						}
					}
					else if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242606).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
					}
					else
					{
						_0024self__00242606.Turn(0);
					}
					_0024g_00242602 = null;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242606).networkView.RPC("A1", (RPCMode)2, new object[0]);
					}
					else
					{
						_0024self__00242606.@base.animation.Play("a");
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 3:
					if (Object.op_Implicit((Object)(object)_0024self__00242606.player))
					{
						_0024pp2_00242603 = _0024self__00242606.player.transform.position;
						if (MenuScript.multiplayer > 0)
						{
							if (MenuScript.multiplayer == 1)
							{
								_0024g_00242602 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), ((Component)_0024self__00242606).transform.position, Quaternion.identity, 0);
								_0024g_00242602.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00242603 });
								_0024pp2_00242603.y += 10f;
								_0024g_00242602 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), ((Component)_0024self__00242606).transform.position, Quaternion.identity, 0);
								_0024g_00242602.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00242603 });
								_0024pp2_00242603.y -= 20f;
								_0024g_00242602 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), ((Component)_0024self__00242606).transform.position, Quaternion.identity, 0);
							}
							_0024g_00242602.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00242603 });
						}
					}
					if (Object.op_Implicit((Object)(object)_0024self__00242606.player))
					{
						_0024self__00242606.curVector = _0024self__00242606.t.position - _0024self__00242606.player.transform.position;
						if (!(_0024self__00242606.player.transform.position.x <= _0024self__00242606.t.position.x))
						{
							_0024self__00242606.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00242606.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
					}
					_0024self__00242606.atking = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242606.atking = false;
					if (Object.op_Implicit((Object)(object)_0024self__00242606.player))
					{
						_0024num_00242604 = Random.Range(0, 3);
						if (_0024num_00242604 == 0)
						{
							_0024self__00242606.curVector = _0024self__00242606.t.position - _0024self__00242606.player.transform.position;
						}
						else
						{
							_0024self__00242606.curVector = _0024self__00242606.player.transform.position - _0024self__00242606.t.position;
						}
						if (!(_0024self__00242606.player.transform.position.x <= _0024self__00242606.t.position.x))
						{
							_0024self__00242606.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00242606.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00242606.atking = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 5;
				case 5:
					_0024self__00242606.atking = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 6:
					_0024self__00242606.ATKING = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00242607;

		internal Whelp _0024self__00242608;

		public _0024Attack_00242601(Vector3 pp, Whelp self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024pp_00242607 = pp;
			_0024self__00242608 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024pp_00242607, _0024self__00242608);
		}
	}

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

	public Whelp()
	{
		speed = 10f;
		mask = 256;
		mask2 = 2048;
	}

	public override void Start()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		@base.animation["i"].layer = 0;
		@base.animation["a"].layer = 1;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(150, 6, 2, 10, 2f, array, Random.Range(10, 25), 10);
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
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && MenuScript.multiplayer == 1)
		{
			if (!(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !ATKING)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Attack(player.transform.position));
			}
			else if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !knocking && r.isKinematic)
			{
				t.Translate(((Vector3)(ref curVector)).normalized * 9f * Time.deltaTime);
			}
		}
	}

	public override IEnumerator Attack(Vector3 pp)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Attack_00242601(pp, this).GetEnumerator();
	}

	[RPC]
	public override void A1()
	{
		@base.animation.Play("a");
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
