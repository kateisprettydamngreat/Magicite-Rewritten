using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class WaspScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GoCrazy_00242700 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024x_00242701;

			internal int _0024y_00242702;

			internal int _0024i_00242703;

			internal WaspScript _0024self__00242704;

			public _0024(WaspScript self_)
			{
				_0024self__00242704 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024x_00242701 = UnityEngine.Random.Range(-5, 5);
					_0024y_00242702 = UnityEngine.Random.Range(-5, 5);
					_0024i_00242703 = default(int);
					_0024self__00242704.crazyVec = new Vector3(_0024x_00242701, _0024y_00242702, 0f);
					_0024self__00242704.crazy = true;
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242704.crazy = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal WaspScript _0024self__00242705;

		public _0024GoCrazy_00242700(WaspScript self_)
		{
			_0024self__00242705 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242705);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242706 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WaspScript _0024self__00242707;

			public _0024(WaspScript self_)
			{
				_0024self__00242707 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 2:
					if ((bool)_0024self__00242707.player && Network.isServer)
					{
						_0024self__00242707.curVector = _0024self__00242707.player.transform.position - _0024self__00242707.t.position;
						if (!(_0024self__00242707.player.transform.position.x <= _0024self__00242707.t.position.x))
						{
							_0024self__00242707.GetComponent<NetworkView>().RPC("TURN", RPCMode.All, 1);
						}
						else
						{
							_0024self__00242707.GetComponent<NetworkView>().RPC("TURN", RPCMode.All, 0);
						}
						_0024self__00242707.atking = true;
						result = (Yield(3, new WaitForSeconds(1.2f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00242707.atking = false;
					_0024self__00242707.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal WaspScript _0024self__00242708;

		public _0024Attack_00242706(WaspScript self_)
		{
			_0024self__00242708 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242708);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip waspSound;

	private bool crazy;

	private Vector3 crazyVec;

	public WaspScript()
	{
		speed = 8f;
	}

	public virtual IEnumerator GoCrazy()
	{
		return new _0024GoCrazy_00242700(this).GetEnumerator();
	}

	public override void Awake()
	{
		if (Network.isServer)
		{
			StartCoroutine_Auto(GoCrazy());
		}
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 18, 20, 19 };
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
			GetComponent<Rigidbody>().velocity = curVector.normalized * speed;
		}
	}

	public virtual IEnumerator Attack()
	{
		return new _0024Attack_00242706(this).GetEnumerator();
	}

	[RPC]
	public virtual void TURN(int a)
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
