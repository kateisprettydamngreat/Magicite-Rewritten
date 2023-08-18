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
	internal sealed class _0024Attack_00242821 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00242822;

			internal Vector3 _0024pp2_00242823;

			internal Vector3 _0024pp_00242824;

			internal blackDragon _0024self__00242825;

			public _0024(Vector3 pp, blackDragon self_)
			{
				_0024pp_00242824 = pp;
				_0024self__00242825 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242825.ATKING = true;
					if (!(_0024pp_00242824.x <= _0024self__00242825.transform.position.x))
					{
						_0024self__00242825.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
					}
					else
					{
						_0024self__00242825.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
					}
					_0024g_00242822 = null;
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242825.GetComponent<NetworkView>().RPC("A1", RPCMode.All);
					result = (Yield(3, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 3:
					if ((bool)_0024self__00242825.player)
					{
						_0024pp2_00242823 = _0024self__00242825.player.transform.position;
						if (Network.isServer)
						{
							_0024g_00242822 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire2"), _0024self__00242825.transform.position, Quaternion.identity, 0);
							_0024g_00242822.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00242823);
							_0024pp2_00242823.y += 10f;
							_0024g_00242822 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire2"), _0024self__00242825.transform.position, Quaternion.identity, 0);
							_0024g_00242822.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00242823);
							_0024pp2_00242823.y -= 20f;
							_0024g_00242822 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire2"), _0024self__00242825.transform.position, Quaternion.identity, 0);
						}
						_0024g_00242822.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00242823);
					}
					if ((bool)_0024self__00242825.player)
					{
						_0024self__00242825.curVector = _0024self__00242825.t.position - _0024self__00242825.player.transform.position;
						if (!(_0024self__00242825.player.transform.position.x <= _0024self__00242825.t.position.x))
						{
							_0024self__00242825.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00242825.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
					}
					_0024self__00242825.atking = true;
					result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242825.atking = false;
					if ((bool)_0024self__00242825.player)
					{
						_0024self__00242825.curVector = _0024self__00242825.player.transform.position - _0024self__00242825.t.position;
						if (!(_0024self__00242825.player.transform.position.x <= _0024self__00242825.t.position.x))
						{
							_0024self__00242825.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00242825.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00242825.atking = true;
						result = (Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 5;
				case 5:
					_0024self__00242825.atking = false;
					result = (Yield(6, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 6:
					_0024self__00242825.ATKING = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024pp_00242826;

		internal blackDragon _0024self__00242827;

		public _0024Attack_00242821(Vector3 pp, blackDragon self_)
		{
			_0024pp_00242826 = pp;
			_0024self__00242827 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024pp_00242826, _0024self__00242827);
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

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["i"].speed = 0.7f;
		@base.GetComponent<Animation>()["a"].layer = 1;
		int[] array = new int[3] { 7, 18, 20 };
		SetStats(1000, 8, 2, 700, 2f, array, UnityEngine.Random.Range(10, 25), 700);
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
		if ((bool)player && Network.isServer)
		{
			if (!(Mathf.Abs(player.transform.position.x - t.position.x) >= 50f) && !ATKING)
			{
				StartCoroutine_Auto(Attack(player.transform.position));
			}
			else if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 50f) && !knocking && r.isKinematic)
			{
				t.Translate(curVector.normalized * 6f * Time.deltaTime);
			}
		}
	}

	public virtual IEnumerator Attack(Vector3 pp)
	{
		return new _0024Attack_00242821(pp, this).GetEnumerator();
	}

	[RPC]
	public virtual void A1()
	{
		@base.GetComponent<Animation>().Play("a");
		GetComponent<AudioSource>().PlayOneShot(roar);
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
