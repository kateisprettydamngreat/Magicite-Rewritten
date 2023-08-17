using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class sArcher : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00243106 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00243107;

			internal float _0024angle_00243108;

			internal Object _0024ar_00243109;

			internal Vector3 _0024pp_00243110;

			internal sArcher _0024self__00243111;

			public _0024(Vector3 pp, sArcher self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024pp_00243110 = pp;
				_0024self__00243111 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0046: Unknown result type (might be due to invalid IL or missing references)
				//IL_0296: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Expected O, but got Unknown
				//IL_017f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0184: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_019f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_014f: Expected O, but got Unknown
				//IL_026b: Unknown result type (might be due to invalid IL or missing references)
				//IL_027a: Unknown result type (might be due to invalid IL or missing references)
				//IL_027f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f2: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00243111.ATKING = true;
					if (!(_0024pp_00243110.x <= ((Component)_0024self__00243111).transform.position.x))
					{
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00243111).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
						}
						else
						{
							_0024self__00243111.Turn(1);
						}
					}
					else if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00243111).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
					}
					else
					{
						_0024self__00243111.Turn(0);
					}
					_0024g_00243107 = null;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00243111).networkView.RPC("A1", (RPCMode)2, new object[0]);
					}
					else
					{
						_0024self__00243111.@base.animation.Play("a1");
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.6f)) ? 1 : 0);
					break;
				case 3:
					if (Object.op_Implicit((Object)(object)_0024self__00243111.player))
					{
						_0024self__00243111.target_pos = _0024self__00243111.player.transform.position;
						_0024self__00243111.object_pos = ((Component)_0024self__00243111).transform.position;
						_0024self__00243111.target_pos.z = -20f;
						_0024self__00243111.target_pos.x = _0024self__00243111.target_pos.x - _0024self__00243111.object_pos.x;
						_0024self__00243111.target_pos.y = _0024self__00243111.target_pos.y - _0024self__00243111.object_pos.y;
						_0024angle_00243108 = Mathf.Atan2(_0024self__00243111.target_pos.y, _0024self__00243111.target_pos.x) * 57.29578f;
						if (MenuScript.multiplayer > 0)
						{
							_0024ar_00243109 = Network.Instantiate(Resources.Load("haz/arrow"), ((Component)_0024self__00243111).transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00243108)), 0);
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(2.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00243111.ATKING = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00243112;

		internal sArcher _0024self__00243113;

		public _0024Attack_00243106(Vector3 pp, sArcher self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024pp_00243112 = pp;
			_0024self__00243113 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024pp_00243112, _0024self__00243113);
		}
	}

	private Vector3 target_pos;

	private Vector3 object_pos;

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

	public sArcher()
	{
		mask = 256;
		mask2 = 2048;
	}

	public override void Start()
	{
		@base.animation["i"].layer = 0;
		@base.animation["a"].layer = 1;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(15, 2, 2, 15, 2f, array, Random.Range(10, 25), 15);
	}

	public override void Update()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 18f) && !ATKING && MenuScript.multiplayer == 1)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Attack(player.transform.position));
		}
	}

	public override IEnumerator Attack(Vector3 pp)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Attack_00243106(pp, this).GetEnumerator();
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

	public override void Set(GameObject p)
	{
		player = p;
	}
}
