using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ShroomMage : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242468 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00242469;

			internal Vector3 _0024pp_00242470;

			internal ShroomMage _0024self__00242471;

			public _0024(Vector3 pp, ShroomMage self_)
			{
				_0024pp_00242470 = pp;
				_0024self__00242471 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242471.ATKING = true;
					if (!(_0024pp_00242470.x <= _0024self__00242471.transform.position.x))
					{
						_0024self__00242471.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
					}
					else
					{
						_0024self__00242471.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
					}
					_0024g_00242469 = null;
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242471.GetComponent<NetworkView>().RPC("A1", RPCMode.All);
					result = (Yield(3, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 3:
					if ((bool)_0024self__00242471.player && Network.isServer)
					{
						_0024g_00242469 = (GameObject)Network.Instantiate(Resources.Load("haz/shroomFire"), _0024self__00242471.transform.position, Quaternion.identity, 0);
						_0024g_00242469.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024self__00242471.player.transform.position);
					}
					result = (Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242471.ATKING = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00242472;

		internal ShroomMage _0024self__00242473;

		public _0024Attack_00242468(Vector3 pp, ShroomMage self_)
		{
			_0024pp_00242472 = pp;
			_0024self__00242473 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024pp_00242472, _0024self__00242473);
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

	public ShroomMage()
	{
		mask = 256;
		mask2 = 2048;
	}

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 1;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["a1"].layer = 1;
		@base.GetComponent<Animation>()["a1"].speed = 0.5f;
		@base.GetComponent<Animation>()["r"].speed = 0.5f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(46, 6, 2, 10, 2f, array, UnityEngine.Random.Range(10, 25), 10);
	}

	public override void Update()
	{
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 18f) && !ATKING)
		{
			StartCoroutine_Auto(Attack(player.transform.position));
		}
	}

	public virtual IEnumerator Attack(Vector3 pp)
	{
		return new _0024Attack_00242468(pp, this).GetEnumerator();
	}

	[RPC]
	public virtual void A1()
	{
		@base.GetComponent<Animation>().Play("a1");
	}

	[RPC]
	public virtual void Turn(int dir)
	{
		if (dir == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion quaternion2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion quaternion4 = (e.transform.rotation = rotation2);
		}
	}

	public virtual void Set(GameObject p)
	{
		player = p;
	}
}
