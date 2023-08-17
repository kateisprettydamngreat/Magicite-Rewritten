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
	internal sealed class _0024Attack_00242383 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024noo_00242384;

			internal int _0024n_00242385;

			internal GameObject _0024g_00242386;

			internal int _0024_0024849_00242387;

			internal Vector3 _0024_0024850_00242388;

			internal int _0024_0024851_00242389;

			internal Vector3 _0024_0024852_00242390;

			internal int _0024_0024853_00242391;

			internal Vector3 _0024_0024854_00242392;

			internal Vector3 _0024pp_00242393;

			internal ScourgeKnightScript _0024self__00242394;

			public _0024(Vector3 pp, ScourgeKnightScript self_)
			{
				_0024pp_00242393 = pp;
				_0024self__00242394 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024noo_00242384 = UnityEngine.Random.Range(0, 4);
					if (_0024noo_00242384 == 0)
					{
						_0024self__00242394.ATKING = true;
						_0024self__00242394.GetComponent<NetworkView>().RPC("J", RPCMode.All);
						int num = (_0024_0024849_00242387 = 26);
						Vector3 vector = (_0024_0024850_00242388 = _0024self__00242394.r.velocity);
						float num2 = (_0024_0024850_00242388.y = _0024_0024849_00242387);
						Vector3 vector3 = (_0024self__00242394.r.velocity = _0024_0024850_00242388);
						_0024n_00242385 = UnityEngine.Random.Range(0, 2);
						if (_0024n_00242385 != 0)
						{
							int num3 = (_0024_0024853_00242391 = -13);
							Vector3 vector4 = (_0024_0024854_00242392 = _0024self__00242394.r.velocity);
							float num4 = (_0024_0024854_00242392.x = _0024_0024853_00242391);
							Vector3 vector6 = (_0024self__00242394.r.velocity = _0024_0024854_00242392);
						}
						else
						{
							int num5 = (_0024_0024851_00242389 = 13);
							Vector3 vector7 = (_0024_0024852_00242390 = _0024self__00242394.r.velocity);
							float num6 = (_0024_0024852_00242390.x = _0024_0024851_00242389);
							Vector3 vector9 = (_0024self__00242394.r.velocity = _0024_0024852_00242390);
						}
						result = (Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
					}
					else
					{
						_0024self__00242394.ATKING = true;
						if (!(_0024pp_00242393.x <= _0024self__00242394.transform.position.x))
						{
							_0024self__00242394.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						}
						else
						{
							_0024self__00242394.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						}
						_0024g_00242386 = null;
						result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024self__00242394.ATKING = false;
					goto IL_032c;
				case 3:
					_0024self__00242394.GetComponent<NetworkView>().RPC("A1", RPCMode.All);
					result = (Yield(4, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 4:
					if ((bool)_0024self__00242394.player)
					{
						_0024g_00242386 = (GameObject)Network.Instantiate(Resources.Load("haz/scourgeFire"), _0024self__00242394.transform.position, Quaternion.identity, 0);
						_0024g_00242386.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024self__00242394.player.transform.position);
					}
					result = (Yield(5, new WaitForSeconds(1.8f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00242394.ATKING = false;
					goto IL_032c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_032c:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00242395;

		internal ScourgeKnightScript _0024self__00242396;

		public _0024Attack_00242383(Vector3 pp, ScourgeKnightScript self_)
		{
			_0024pp_00242395 = pp;
			_0024self__00242396 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024pp_00242395, _0024self__00242396);
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

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["j"].layer = 2;
		@base.GetComponent<Animation>()["a"].speed = 1.7f;
		@base.GetComponent<Animation>()["j"].speed = 0.5f;
		int[] array = new int[3] { 15, 15, 15 };
		SetStats(200, 3, 2, 15, 2f, array, UnityEngine.Random.Range(10, 25), 15);
	}

	public override void Update()
	{
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !ATKING && Network.isServer)
		{
			StartCoroutine_Auto(Attack(player.transform.position));
		}
	}

	public virtual IEnumerator Attack(Vector3 pp)
	{
		return new _0024Attack_00242383(pp, this).GetEnumerator();
	}

	[RPC]
	public virtual void A1()
	{
		@base.GetComponent<Animation>().Play("a");
	}

	[RPC]
	public virtual void J()
	{
		@base.GetComponent<Animation>().Play("j");
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

	[RPC]
	public virtual void I()
	{
		@base.SetActive(value: true);
	}

	public virtual void SetPlayer(GameObject p)
	{
		if (!initialized)
		{
			initialized = true;
			@base.SetActive(value: true);
			if (Network.isServer)
			{
				GetComponent<NetworkView>().RPC("I", RPCMode.All);
			}
		}
		player = p;
	}
}
