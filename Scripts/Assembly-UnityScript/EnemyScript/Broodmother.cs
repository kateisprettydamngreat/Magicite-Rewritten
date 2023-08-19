using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Broodmother : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UpdateZrotation_00241290 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Broodmother _0024self__00241291;

			public _0024(Broodmother self_)
			{
				_0024self__00241291 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241291.rotating = true;
					_0024self__00241291.mouse_pos = _0024self__00241291.player.transform.position;
					_0024self__00241291.object_pos = _0024self__00241291.transform.position;
					_0024self__00241291.mouse_pos.z = -20f;
					_0024self__00241291.mouse_pos.x = _0024self__00241291.mouse_pos.x - _0024self__00241291.object_pos.x;
					_0024self__00241291.mouse_pos.y = _0024self__00241291.mouse_pos.y - _0024self__00241291.object_pos.y;
					_0024self__00241291.angle = Mathf.Atan2(_0024self__00241291.mouse_pos.y, _0024self__00241291.mouse_pos.x) * 57.29578f;
					_0024self__00241291.t.rotation = Quaternion.Euler(new Vector3(0f, 0f, _0024self__00241291.angle));
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241291.atking = true;
					result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241291.atking = false;
					result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241291.rotating = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Broodmother _0024self__00241292;

		public _0024UpdateZrotation_00241290(Broodmother self_)
		{
			_0024self__00241292 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241292);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private float zRotation;

	private bool rotating;

	private Vector3 mouse_pos;

	private Vector3 object_pos;

	private float angle;

	public Broodmother()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 15, 15, 10 };
		SetStats(400, 3, 13, 150, 5f, array, UnityEngine.Random.Range(5, 15), 150);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			if (atking)
			{
				t.Translate(Vector3.left * Time.deltaTime * -10f);
			}
			if (!rotating)
			{
				StartCoroutine_Auto(UpdateZrotation());
			}
		}
	}

	public virtual IEnumerator UpdateZrotation()
	{
		return new _0024UpdateZrotation_00241290(this).GetEnumerator();
	}

	[RPC]
	public virtual void Turn(int a)
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

	[RPC]
	public virtual void ATK()
	{
	}

	[RPC]
	public virtual void IDLE()
	{
	}

	public virtual void K()
	{
	}

	public virtual void KN()
	{
	}
}
