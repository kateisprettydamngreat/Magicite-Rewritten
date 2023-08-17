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
	internal sealed class _0024UpdateZrotation_00241445 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Broodmother _0024self__00241446;

			public _0024(Broodmother self_)
			{
				_0024self__00241446 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0046: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_012b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0141: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Expected O, but got Unknown
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_016a: Expected O, but got Unknown
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241446.rotating = true;
					_0024self__00241446.mouse_pos = _0024self__00241446.player.transform.position;
					_0024self__00241446.object_pos = ((Component)_0024self__00241446).transform.position;
					_0024self__00241446.mouse_pos.z = -20f;
					_0024self__00241446.mouse_pos.x = _0024self__00241446.mouse_pos.x - _0024self__00241446.object_pos.x;
					_0024self__00241446.mouse_pos.y = _0024self__00241446.mouse_pos.y - _0024self__00241446.object_pos.y;
					_0024self__00241446.angle = Mathf.Atan2(_0024self__00241446.mouse_pos.y, _0024self__00241446.mouse_pos.x) * 57.29578f;
					_0024self__00241446.t.rotation = Quaternion.Euler(new Vector3(0f, 0f, _0024self__00241446.angle));
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241446.atking = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241446.atking = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241446.rotating = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Broodmother _0024self__00241447;

		public _0024UpdateZrotation_00241445(Broodmother self_)
		{
			_0024self__00241447 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241447);
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
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 15, 15, 10 };
		SetStats(400, 3, 13, 150, 5f, array, Random.Range(5, 15), 150);
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player))
		{
			if (atking && MenuScript.multiplayer == 1)
			{
				t.Translate(Vector3.left * Time.deltaTime * -10f);
			}
			if (!rotating && MenuScript.multiplayer == 1)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(UpdateZrotation());
			}
		}
	}

	public override IEnumerator UpdateZrotation()
	{
		return new _0024UpdateZrotation_00241445(this).GetEnumerator();
	}

	[RPC]
	public override void Turn(int a)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (a == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion val2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion val4 = (e.transform.rotation = rotation2);
		}
	}

	[RPC]
	public override void ATK()
	{
	}

	[RPC]
	public override void IDLE()
	{
	}

	public override void K()
	{
	}

	public override void KN()
	{
	}
}
