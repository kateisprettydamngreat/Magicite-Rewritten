using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BlueWorm : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Action_00241332 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241333;

			internal Vector3 _0024pos_00241334;

			internal BlueWorm _0024self__00241335;

			public _0024(BlueWorm self_)
			{
				_0024self__00241335 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Expected O, but got Unknown
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_010d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_019c: Expected O, but got Unknown
				//IL_014e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Unknown result type (might be due to invalid IL or missing references)
				//IL_0165: Unknown result type (might be due to invalid IL or missing references)
				//IL_016f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00241333 = default(int);
					_0024pos_00241334 = default(Vector3);
					goto case 5;
				case 5:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(2, 5))) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							((Component)_0024self__00241335).networkView.RPC("A", (RPCMode)2, new object[0]);
						}
					}
					else
					{
						_0024self__00241335.@base.animation.Play("a");
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024i_00241333 = 0;
					goto IL_0182;
				case 4:
					_0024i_00241333++;
					goto IL_0182;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0182:
					if (_0024i_00241333 < 6)
					{
						_0024pos_00241334 = new Vector3(_0024self__00241335.t.position.x + (float)Random.Range(-8, 8), _0024self__00241335.t.position.y + 28f, 0f);
						if (MenuScript.multiplayer > 0)
						{
							Network.Instantiate(Resources.Load("rckW"), _0024pos_00241334, Quaternion.identity, 0);
						}
						else
						{
							Object.Instantiate(Resources.Load("rckW"), _0024pos_00241334, Quaternion.identity);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					}
					else
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(1f)) ? 1 : 0);
					}
					break;
				}
				return (byte)result != 0;
			}
		}

		internal BlueWorm _0024self__00241336;

		public _0024Action_00241332(BlueWorm self_)
		{
			_0024self__00241336 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241336);
		}
	}

	private RaycastHit hit;

	private int mask;

	private int spd;

	private bool turning;

	private int mask2;

	private bool ATKING;

	private GameObject player;

	private bool initialized;

	public BlueWorm()
	{
		mask = 256;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		@base.animation["i"].layer = 0;
		@base.animation["i"].speed = 0.5f;
		@base.animation["i1"].layer = 1;
		@base.animation["i"].speed = 0.5f;
		@base.animation["a"].layer = 1;
		@base.animation["a"].speed = 0.5f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(100, 6, 2, 0, 2f, array, Random.Range(10, 25), 10);
	}

	public override void Update()
	{
	}

	public override void K()
	{
	}

	public override void KN()
	{
	}

	[RPC]
	public override void A()
	{
		@base.animation.CrossFade("a");
	}

	[RPC]
	public override void I()
	{
		@base.animation.Play("i1");
	}

	[RPC]
	public override void Turn(int dir)
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
		if (dir == 0)
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

	public override void Set()
	{
		MonoBehaviour.print((object)"SETTT");
		if (!initialized)
		{
			initialized = true;
			@base.SetActive(true);
			@base.animation.Play("i1");
			if (MenuScript.multiplayer > 0 && Network.isServer)
			{
				((Component)this).networkView.RPC("I", (RPCMode)2, new object[0]);
			}
			((MonoBehaviour)this).StartCoroutine_Auto(Action());
		}
	}

	public override IEnumerator Action()
	{
		return new _0024Action_00241332(this).GetEnumerator();
	}
}
