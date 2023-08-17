using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ButterflyScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Summon_00241296 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00241297;

			internal ButterflyScript _0024self__00241298;

			public _0024(ButterflyScript self_)
			{
				_0024self__00241298 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024g_00241297 = null;
					goto IL_0023;
				case 2:
					if (_0024self__00241298.atking && (bool)_0024self__00241298.player && _0024self__00241298.canFire)
					{
						_0024g_00241297 = (GameObject)Network.Instantiate(Resources.Load("haz/butterflyF"), _0024self__00241298.transform.position, Quaternion.identity, 0);
						_0024g_00241297.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024self__00241298.player.transform.position);
					}
					goto IL_0023;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0023:
					result = (Yield(2, new WaitForSeconds(0.8f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ButterflyScript _0024self__00241299;

		public _0024Summon_00241296(ButterflyScript self_)
		{
			_0024self__00241299 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241299);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241300 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ButterflyScript _0024self__00241301;

			public _0024(ButterflyScript self_)
			{
				_0024self__00241301 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if ((bool)_0024self__00241301.player)
					{
						_0024self__00241301.curVector = _0024self__00241301.player.transform.position - _0024self__00241301.t.position;
						if (!(_0024self__00241301.player.transform.position.x <= _0024self__00241301.t.position.x))
						{
							_0024self__00241301.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00241301.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00241301.atking = true;
						result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00241301.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ButterflyScript _0024self__00241302;

		public _0024Attack_00241300(ButterflyScript self_)
		{
			_0024self__00241302 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241302);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool canFire;

	public ButterflyScript()
	{
		speed = 7f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(105, 5, 0, 50, 10f, array, UnityEngine.Random.Range(6, 20), 50);
		if (Network.isServer)
		{
			StartCoroutine_Auto(Attack());
			StartCoroutine_Auto(Summon());
		}
	}

	public virtual IEnumerator Summon()
	{
		return new _0024Summon_00241296(this).GetEnumerator();
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 40f) && !knocking)
			{
				canFire = true;
				GetComponent<Rigidbody>().velocity = curVector.normalized * speed;
			}
			else
			{
				canFire = false;
			}
		}
	}

	public virtual IEnumerator Attack()
	{
		return new _0024Attack_00241300(this).GetEnumerator();
	}
}
