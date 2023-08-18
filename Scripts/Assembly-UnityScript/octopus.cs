using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class octopus : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GoCrazy_00242927 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024x_00242928;

			internal int _0024y_00242929;

			internal int _0024i_00242930;

			internal octopus _0024self__00242931;

			public _0024(octopus self_)
			{
				_0024self__00242931 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024x_00242928 = UnityEngine.Random.Range(-5, 5);
					_0024y_00242929 = UnityEngine.Random.Range(-5, 5);
					_0024i_00242930 = default(int);
					_0024self__00242931.crazyVec = new Vector3(_0024x_00242928, _0024y_00242929, 0f);
					_0024self__00242931.crazy = true;
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242931.crazy = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal octopus _0024self__00242932;

		public _0024GoCrazy_00242927(octopus self_)
		{
			_0024self__00242932 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242932);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242933 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal octopus _0024self__00242934;

			public _0024(octopus self_)
			{
				_0024self__00242934 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					if ((bool)_0024self__00242934.player && Network.isServer)
					{
						_0024self__00242934.curVector = _0024self__00242934.player.transform.position - _0024self__00242934.t.position;
						if (!(_0024self__00242934.player.transform.position.x <= _0024self__00242934.t.position.x))
						{
							_0024self__00242934.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						}
						else
						{
							_0024self__00242934.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						}
						_0024self__00242934.atking = true;
						result = (Yield(3, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00242934.atking = false;
					_0024self__00242934.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal octopus _0024self__00242935;

		public _0024Attack_00242933(octopus self_)
		{
			_0024self__00242935 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242935);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool crazy;

	private Vector3 crazyVec;

	public octopus()
	{
		speed = 10f;
	}

	public virtual IEnumerator GoCrazy()
	{
		return new _0024GoCrazy_00242927(this).GetEnumerator();
	}

	public override void Awake()
	{
		if (Network.isServer)
		{
			StartCoroutine_Auto(GoCrazy());
		}
		@base.GetComponent<Animation>()["i"].speed = 0.6f;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(25, 2, 0, 8, 10f, array, UnityEngine.Random.Range(5, 15), 8);
		StartCoroutine_Auto(Attack());
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer && atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 10f) && !knocking)
		{
			GetComponent<Rigidbody>().velocity = curVector.normalized * speed;
		}
		if (crazy && Network.isServer)
		{
			GetComponent<Rigidbody>().velocity = curVector.normalized * 20f;
		}
	}

	public virtual IEnumerator Attack()
	{
		return new _0024Attack_00242933(this).GetEnumerator();
	}

	[RPC]
	public virtual void Turn(int a)
	{
		if (a == 0)
		{
			e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
		}
		else
		{
			e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
		}
	}
}
