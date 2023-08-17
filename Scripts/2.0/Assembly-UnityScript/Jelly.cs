using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Jelly : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Summon_00241930 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00241931;

			internal Jelly _0024self__00241932;

			public _0024(Jelly self_)
			{
				_0024self__00241932 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024g_00241931 = null;
					goto IL_0027;
				case 2:
					if (_0024self__00241932.atking && (bool)_0024self__00241932.player && _0024self__00241932.canFire)
					{
						_0024self__00241932.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					goto IL_0027;
				case 3:
					_0024g_00241931 = (GameObject)Network.Instantiate(Resources.Load("haz/jellyFire"), _0024self__00241932.transform.position, Quaternion.identity, 0);
					_0024g_00241931.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024self__00241932.player.transform.position);
					goto IL_0027;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0027:
					result = (Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Jelly _0024self__00241933;

		public _0024Summon_00241930(Jelly self_)
		{
			_0024self__00241933 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241933);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241934 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Jelly _0024self__00241935;

			public _0024(Jelly self_)
			{
				_0024self__00241935 = self_;
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
					if ((bool)_0024self__00241935.player)
					{
						_0024self__00241935.curVector = _0024self__00241935.player.transform.position - _0024self__00241935.t.position;
						if (!(_0024self__00241935.player.transform.position.x <= _0024self__00241935.t.position.x))
						{
							_0024self__00241935.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00241935.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00241935.atking = true;
						result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00241935.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Jelly _0024self__00241936;

		public _0024Attack_00241934(Jelly self_)
		{
			_0024self__00241936 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241936);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool canFire;

	public Jelly()
	{
		speed = 4f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 15, 566 };
		SetStats(50, 1, 0, 7, 10f, array, UnityEngine.Random.Range(6, 20), 8);
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["a"].speed = 0.5f;
		if (Network.isServer)
		{
			StartCoroutine_Auto(Attack());
			StartCoroutine_Auto(Summon());
		}
	}

	public virtual IEnumerator Summon()
	{
		return new _0024Summon_00241930(this).GetEnumerator();
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 10f) && !knocking)
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
		return new _0024Attack_00241934(this).GetEnumerator();
	}

	[RPC]
	public virtual void ATK()
	{
		@base.GetComponent<Animation>().Play("a");
	}
}
