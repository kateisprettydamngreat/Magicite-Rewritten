using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class fQueen : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Summon_00242855 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal fQueen _0024self__00242856;

			public _0024(fQueen self_)
			{
				_0024self__00242856 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242856.summoned = 0;
					result = (Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
					break;
				case 2:
					if (Network.isServer)
					{
						goto IL_004a;
					}
					YieldDefault(1);
					goto case 1;
				case 3:
					if (_0024self__00242856.summoned < 8)
					{
						_0024self__00242856.summoned++;
						Network.Instantiate(Resources.Load("e/fairy"), _0024self__00242856.t.position, Quaternion.identity, 0);
					}
					goto IL_004a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_004a:
					result = (Yield(3, new WaitForSeconds(5f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal fQueen _0024self__00242857;

		public _0024Summon_00242855(fQueen self_)
		{
			_0024self__00242857 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242857);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024UpdateZrotation_00242858 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal fQueen _0024self__00242859;

			public _0024(fQueen self_)
			{
				_0024self__00242859 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242859.atking = true;
					result = (Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242859.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal fQueen _0024self__00242860;

		public _0024UpdateZrotation_00242858(fQueen self_)
		{
			_0024self__00242860 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242860);
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

	private int summoned;

	public fQueen()
	{
		speed = 10f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 71, 71, 71 };
		SetStats(850, 4, 13, 350, 5f, array, 20, 350);
		StartCoroutine_Auto(UpdateZrotation());
		StartCoroutine_Auto(Summon());
	}

	public virtual IEnumerator Summon()
	{
		return new _0024Summon_00242855(this).GetEnumerator();
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public virtual void FixedUpdate()
	{
		if ((bool)player && atking && Network.isServer)
		{
			if (!(player.transform.position.x + 0.5f <= t.position.x))
			{
				t.Translate(Vector3.left * -5f * Time.deltaTime);
			}
			else if (!(player.transform.position.x - 0.5f >= t.position.x))
			{
				t.Translate(Vector3.left * 5f * Time.deltaTime);
			}
			if (!(player.transform.position.y + 1f <= t.position.y))
			{
				t.Translate(Vector3.up * 4f * Time.deltaTime);
			}
			else if (!(player.transform.position.y - 1f >= t.position.y))
			{
				t.Translate(Vector3.up * -4f * Time.deltaTime);
			}
		}
	}

	public virtual IEnumerator UpdateZrotation()
	{
		return new _0024UpdateZrotation_00242858(this).GetEnumerator();
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
