using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class GiantBug : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241858 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GiantBug _0024self__00241859;

			public _0024(GiantBug self_)
			{
				_0024self__00241859 = self_;
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
					if ((bool)_0024self__00241859.player && Network.isServer)
					{
						_0024self__00241859.GetComponent<NetworkView>().RPC("SpeedUp", RPCMode.All);
						_0024self__00241859.curVector = _0024self__00241859.player.transform.position - _0024self__00241859.t.position;
						if (!(_0024self__00241859.player.transform.position.x <= _0024self__00241859.t.position.x))
						{
							_0024self__00241859.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00241859.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00241859.atking = true;
						result = (Yield(3, new WaitForSeconds(2.5f)) ? 1 : 0);
						break;
					}
					goto IL_0164;
				case 3:
					_0024self__00241859.GetComponent<NetworkView>().RPC("SpeedDown", RPCMode.All);
					goto IL_0164;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0164:
					_0024self__00241859.atking = false;
					goto default;
				}
				return (byte)result != 0;
			}
		}

		internal GiantBug _0024self__00241860;

		public _0024Attack_00241858(GiantBug self_)
		{
			_0024self__00241860 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241860);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	public GiantBug()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(85, 3, 0, 40, 10f, array, UnityEngine.Random.Range(5, 15), 40);
		StartCoroutine_Auto(Attack());
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !knocking && r.isKinematic)
		{
			t.Translate(curVector.normalized * 20f * Time.deltaTime);
		}
	}

	public virtual IEnumerator Attack()
	{
		return new _0024Attack_00241858(this).GetEnumerator();
	}

	[RPC]
	public virtual void SpeedUp()
	{
		@base.GetComponent<Animation>()["i"].speed = 2f;
	}

	[RPC]
	public virtual void SpeedDown()
	{
		@base.GetComponent<Animation>()["i"].speed = 1f;
	}
}
