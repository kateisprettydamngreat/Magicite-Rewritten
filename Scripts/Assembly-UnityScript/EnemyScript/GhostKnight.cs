using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class GhostKnight : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Charge_00241843 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024_0024384_00241844;

			internal int _0024turn_00241845;

			internal GhostKnight _0024self__00241846;

			public _0024(GhostKnight self_)
			{
				_0024self__00241846 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					GhostKnight ghostKnight = _0024self__00241846;
					_0024_0024384_00241844 = default(Vector3);
					ghostKnight.dood = _0024_0024384_00241844;
					_0024self__00241846.dood = _0024self__00241846.player.transform.position - _0024self__00241846.t.position;
					_0024self__00241846.dood.Normalize();
					_0024self__00241846.dood.z = 0f;
					_0024turn_00241845 = 0;
					if (!(_0024self__00241846.player.transform.position.x <= _0024self__00241846.t.position.x))
					{
						_0024turn_00241845 = 1;
					}
					_0024self__00241846.GetComponent<NetworkView>().RPC("E", RPCMode.All, _0024turn_00241845);
					_0024self__00241846.attackCharge = true;
					MonoBehaviour.print("dood is " + _0024self__00241846.dood);
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				}
				case 2:
					_0024self__00241846.attackCharge = false;
					result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241846.charging = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GhostKnight _0024self__00241847;

		public _0024Charge_00241843(GhostKnight self_)
		{
			_0024self__00241847 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241847);
		}
	}

	public GameObject ghostSword;

	private GameObject player;

	private bool charging;

	private bool attackCharge;

	private Vector3 dood;

	private GameObject sword1;

	private GameObject sword2;

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 42, 42, 42 };
		SetStats(4000, 5, 0, 250, 10f, array, UnityEngine.Random.Range(6, 20), 40);
		if (Network.isServer)
		{
			sword1 = (GameObject)Network.Instantiate(ghostSword, t.position, Quaternion.identity, 0);
			sword2 = (GameObject)Network.Instantiate(ghostSword, t.position, Quaternion.identity, 0);
			sword1.SendMessage("Set", gameObject);
			sword2.SendMessage("Set", gameObject);
		}
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if (Network.isServer && (bool)player)
		{
			if (!charging)
			{
				charging = true;
				StartCoroutine_Auto(Charge());
			}
			if (attackCharge)
			{
				t.Translate(dood * 13f * Time.deltaTime);
			}
		}
	}

	public virtual IEnumerator Charge()
	{
		return new _0024Charge_00241843(this).GetEnumerator();
	}

	[RPC]
	public virtual void E(int a)
	{
		if (a == 0)
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
