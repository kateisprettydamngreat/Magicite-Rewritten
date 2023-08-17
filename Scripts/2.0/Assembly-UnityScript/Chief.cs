using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Chief : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241324 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00241325;

			internal Vector3 _0024pp_00241326;

			internal Chief _0024self__00241327;

			public _0024(Vector3 pp, Chief self_)
			{
				_0024pp_00241326 = pp;
				_0024self__00241327 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241327.ATKING = true;
					if (!(_0024pp_00241326.x <= _0024self__00241327.transform.position.x))
					{
						_0024self__00241327.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
					}
					else
					{
						_0024self__00241327.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
					}
					_0024g_00241325 = null;
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241327.GetComponent<NetworkView>().RPC("A1", RPCMode.All);
					result = (Yield(3, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 3:
					if ((bool)_0024self__00241327.player)
					{
						_0024g_00241325 = (GameObject)Network.Instantiate(Resources.Load("haz/shroomFire"), _0024self__00241327.transform.position, Quaternion.identity, 0);
						_0024g_00241325.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024self__00241327.player.transform.position);
					}
					result = (Yield(4, new WaitForSeconds(1.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241327.ATKING = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00241328;

		internal Chief _0024self__00241329;

		public _0024Attack_00241324(Vector3 pp, Chief self_)
		{
			_0024pp_00241328 = pp;
			_0024self__00241329 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024pp_00241328, _0024self__00241329);
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

	public Chief()
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
		if ((bool)player && Network.isServer && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 18f) && !ATKING)
		{
			StartCoroutine_Auto(Attack(player.transform.position));
		}
	}

	public virtual IEnumerator Attack(Vector3 pp)
	{
		return new _0024Attack_00241324(pp, this).GetEnumerator();
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
