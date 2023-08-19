using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class djin : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242847 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00242848;

			internal Vector3 _0024pp2_00242849;

			internal int _0024num_00242850;

			internal Vector3 _0024pp_00242851;

			internal djin _0024self__00242852;

			public _0024(Vector3 pp, djin self_)
			{
				_0024pp_00242851 = pp;
				_0024self__00242852 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242852.ATKING = true;
					if (!(_0024pp_00242851.x <= _0024self__00242852.transform.position.x))
					{
						_0024self__00242852.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
					}
					else
					{
						_0024self__00242852.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
					}
					_0024g_00242848 = null;
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242852.GetComponent<NetworkView>().RPC("A1", RPCMode.All);
					result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					if ((bool)_0024self__00242852.player)
					{
						_0024pp2_00242849 = _0024self__00242852.player.transform.position;
						if (Network.isServer)
						{
							_0024g_00242848 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), _0024self__00242852.djinPoint.transform.position, Quaternion.identity, 0);
							_0024g_00242848.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00242849);
							result = (Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
							break;
						}
					}
					goto IL_02ba;
				case 4:
					_0024pp2_00242849 = _0024self__00242852.player.transform.position;
					_0024g_00242848 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), _0024self__00242852.djinPoint.transform.position, Quaternion.identity, 0);
					_0024g_00242848.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00242849);
					result = (Yield(5, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 5:
					_0024pp2_00242849 = _0024self__00242852.player.transform.position;
					_0024g_00242848 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), _0024self__00242852.djinPoint.transform.position, Quaternion.identity, 0);
					_0024g_00242848.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00242849);
					goto IL_02ba;
				case 6:
					_0024self__00242852.atking = false;
					if ((bool)_0024self__00242852.player)
					{
						_0024num_00242850 = UnityEngine.Random.Range(0, 3);
						if (_0024num_00242850 == 0)
						{
							_0024self__00242852.curVector = _0024self__00242852.t.position - _0024self__00242852.player.transform.position;
						}
						else
						{
							_0024self__00242852.curVector = _0024self__00242852.player.transform.position - _0024self__00242852.t.position;
						}
						if (!(_0024self__00242852.player.transform.position.x <= _0024self__00242852.t.position.x))
						{
							_0024self__00242852.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00242852.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00242852.atking = true;
						result = (Yield(7, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 7;
				case 7:
					_0024self__00242852.atking = false;
					result = (Yield(8, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 8:
					_0024self__00242852.ATKING = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02ba:
					if ((bool)_0024self__00242852.player)
					{
						_0024self__00242852.curVector = _0024self__00242852.t.position - _0024self__00242852.player.transform.position;
						if (!(_0024self__00242852.player.transform.position.x <= _0024self__00242852.t.position.x))
						{
							_0024self__00242852.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00242852.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
					}
					_0024self__00242852.atking = true;
					result = (Yield(6, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00242853;

		internal djin _0024self__00242854;

		public _0024Attack_00242847(Vector3 pp, djin self_)
		{
			_0024pp_00242853 = pp;
			_0024self__00242854 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024pp_00242853, _0024self__00242854);
		}
	}

	public GameObject djinPoint;

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

	public djin()
	{
		speed = 10f;
		mask = 256;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(85, 6, 2, 10, 2f, array, UnityEngine.Random.Range(10, 25), 10);
		float y = transform.position.y + (float)UnityEngine.Random.Range(3, 10);
		Vector3 position = transform.position;
		float num = (position.y = y);
		Vector3 vector2 = (transform.position = position);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player)
		{
			if (!(Mathf.Abs(player.transform.position.x - t.position.x) >= 18f) && !ATKING)
			{
				StartCoroutine_Auto(Attack(player.transform.position));
			}
			else if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 10f) && !knocking && r.isKinematic)
			{
				t.Translate(curVector.normalized * 6f * Time.deltaTime);
			}
		}
	}

	public virtual IEnumerator Attack(Vector3 pp)
	{
		return new _0024Attack_00242847(pp, this).GetEnumerator();
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
}
