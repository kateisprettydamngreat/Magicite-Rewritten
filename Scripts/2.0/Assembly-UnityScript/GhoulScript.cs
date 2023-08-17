using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class GhoulScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Summon_00241851 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00241852;

			internal GhoulScript _0024self__00241853;

			public _0024(GhoulScript self_)
			{
				_0024self__00241853 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024g_00241852 = null;
					goto IL_0023;
				case 2:
					if (_0024self__00241853.atking && (bool)_0024self__00241853.player && _0024self__00241853.canFire)
					{
						_0024g_00241852 = (GameObject)Network.Instantiate(Resources.Load("haz/ghoulFire"), _0024self__00241853.transform.position, Quaternion.identity, 0);
						_0024g_00241852.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024self__00241853.player.transform.position);
					}
					goto IL_0023;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0023:
					result = (Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GhoulScript _0024self__00241854;

		public _0024Summon_00241851(GhoulScript self_)
		{
			_0024self__00241854 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241854);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241855 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GhoulScript _0024self__00241856;

			public _0024(GhoulScript self_)
			{
				_0024self__00241856 = self_;
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
					if ((bool)_0024self__00241856.player)
					{
						_0024self__00241856.curVector = _0024self__00241856.player.transform.position - _0024self__00241856.t.position;
						if (!(_0024self__00241856.player.transform.position.x <= _0024self__00241856.t.position.x))
						{
							_0024self__00241856.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00241856.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00241856.atking = true;
						result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00241856.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GhoulScript _0024self__00241857;

		public _0024Attack_00241855(GhoulScript self_)
		{
			_0024self__00241857 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241857);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool canFire;

	public GhoulScript()
	{
		speed = 6f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(100, 5, 0, 7, 10f, array, UnityEngine.Random.Range(6, 20), 8);
		if (Network.isServer)
		{
			StartCoroutine_Auto(Attack());
			StartCoroutine_Auto(Summon());
		}
	}

	public virtual IEnumerator Summon()
	{
		return new _0024Summon_00241851(this).GetEnumerator();
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 35f) && !knocking)
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
		return new _0024Attack_00241855(this).GetEnumerator();
	}
}
