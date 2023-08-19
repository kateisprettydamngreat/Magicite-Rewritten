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
	internal sealed class _0024Attack_00242941 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00242942;

			internal float _0024angle_00242943;

			internal UnityEngine.Object _0024ar_00242944;

			internal Vector3 _0024pp_00242945;

			internal sArcher _0024self__00242946;

			public _0024(Vector3 pp, sArcher self_)
			{
				_0024pp_00242945 = pp;
				_0024self__00242946 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242946.ATKING = true;
					if (!(_0024pp_00242945.x <= _0024self__00242946.transform.position.x))
					{
						_0024self__00242946.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
					}
					else
					{
						_0024self__00242946.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
					}
					_0024g_00242942 = null;
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242946.GetComponent<NetworkView>().RPC("A1", RPCMode.All);
					result = (Yield(3, new WaitForSeconds(0.6f)) ? 1 : 0);
					break;
				case 3:
					if ((bool)_0024self__00242946.player)
					{
						_0024self__00242946.target_pos = _0024self__00242946.player.transform.position;
						_0024self__00242946.object_pos = _0024self__00242946.transform.position;
						_0024self__00242946.target_pos.z = -20f;
						_0024self__00242946.target_pos.x = _0024self__00242946.target_pos.x - _0024self__00242946.object_pos.x;
						_0024self__00242946.target_pos.y = _0024self__00242946.target_pos.y - _0024self__00242946.object_pos.y;
						_0024angle_00242943 = Mathf.Atan2(_0024self__00242946.target_pos.y, _0024self__00242946.target_pos.x) * 57.29578f;
						_0024ar_00242944 = Network.Instantiate(Resources.Load("haz/arrow"), _0024self__00242946.transform.position, Quaternion.Euler(new Vector3(0f, 0f, _0024angle_00242943)), 0);
					}
					result = (Yield(4, new WaitForSeconds(2.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242946.ATKING = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00242947;

		internal sArcher _0024self__00242948;

		public _0024Attack_00242941(Vector3 pp, sArcher self_)
		{
			_0024pp_00242947 = pp;
			_0024self__00242948 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024pp_00242947, _0024self__00242948);
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

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(15, 2, 2, 15, 2f, array, UnityEngine.Random.Range(10, 25), 15);
	}

	public override void Update()
	{
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 18f) && !ATKING && Network.isServer)
		{
			StartCoroutine_Auto(Attack(player.transform.position));
		}
	}

	public virtual IEnumerator Attack(Vector3 pp)
	{
		return new _0024Attack_00242941(pp, this).GetEnumerator();
	}

	[RPC]
	public virtual void A1()
	{
		@base.GetComponent<Animation>().Play("a");
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
