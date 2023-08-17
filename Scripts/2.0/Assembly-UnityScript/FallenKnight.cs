using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FallenKnight : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024T_00241475 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024545_00241476;

			internal Quaternion _0024_0024546_00241477;

			internal int _0024_0024547_00241478;

			internal Quaternion _0024_0024548_00241479;

			internal FallenKnight _0024self__00241480;

			public _0024(FallenKnight self_)
			{
				_0024self__00241480 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241480.turning && !_0024self__00241480.ATKING)
					{
						_0024self__00241480.turning = true;
						if (_0024self__00241480.e.transform.rotation.y != 0f)
						{
							int num = (_0024_0024545_00241476 = 0);
							Quaternion quaternion = (_0024_0024546_00241477 = _0024self__00241480.e.transform.rotation);
							float num2 = (_0024_0024546_00241477.y = _0024_0024545_00241476);
							Quaternion quaternion3 = (_0024self__00241480.e.transform.rotation = _0024_0024546_00241477);
							_0024self__00241480.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						}
						else
						{
							int num3 = (_0024_0024547_00241478 = 180);
							Quaternion quaternion4 = (_0024_0024548_00241479 = _0024self__00241480.e.transform.rotation);
							float num4 = (_0024_0024548_00241479.y = _0024_0024547_00241478);
							Quaternion quaternion6 = (_0024self__00241480.e.transform.rotation = _0024_0024548_00241479);
							_0024self__00241480.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						}
						_0024self__00241480.spd *= -1;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_01b9;
				case 2:
					_0024self__00241480.turning = false;
					goto IL_01b9;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01b9:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal FallenKnight _0024self__00241481;

		public _0024T_00241475(FallenKnight self_)
		{
			_0024self__00241481 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241481);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241482 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024dir_00241483;

			internal FallenKnight _0024self__00241484;

			public _0024(int dir, FallenKnight self_)
			{
				_0024dir_00241483 = dir;
				_0024self__00241484 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241484.ATKING)
					{
						_0024self__00241484.ATKING = true;
						if (_0024dir_00241483 == 0)
						{
							_0024self__00241484.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
							_0024self__00241484.GetComponent<NetworkView>().RPC("Roar", RPCMode.All);
							result = (Yield(2, new WaitForSeconds(1.2f)) ? 1 : 0);
						}
						else
						{
							_0024self__00241484.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
							_0024self__00241484.GetComponent<NetworkView>().RPC("Roar", RPCMode.All);
							result = (Yield(4, new WaitForSeconds(1.2f)) ? 1 : 0);
						}
						break;
					}
					goto IL_01b4;
				case 2:
					_0024self__00241484.spd = -10;
					result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241484.spd = 0;
					_0024self__00241484.@base.GetComponent<Animation>().Play("i");
					goto IL_0195;
				case 4:
					_0024self__00241484.spd = 10;
					result = (Yield(5, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241484.spd = 0;
					_0024self__00241484.@base.GetComponent<Animation>().Play("i");
					goto IL_0195;
				case 6:
					_0024self__00241484.ATKING = false;
					goto IL_01b4;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0195:
					result = (Yield(6, new WaitForSeconds(1f)) ? 1 : 0);
					break;
					IL_01b4:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dir_00241485;

		internal FallenKnight _0024self__00241486;

		public _0024Attack_00241482(int dir, FallenKnight self_)
		{
			_0024dir_00241485 = dir;
			_0024self__00241486 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024dir_00241485, _0024self__00241486);
		}
	}

	private RaycastHit hit;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private int mask;

	private bool ATKING;

	private int spd;

	private bool turning;

	private int mask2;

	private bool rocking;

	public FallenKnight()
	{
		mask = 256;
		mask2 = 2048;
	}

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["r"].speed = 0.5f;
		@base.GetComponent<Animation>()["a"].speed = 0.2f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(30, 6, 2, 10, 2f, array, UnityEngine.Random.Range(10, 25), 10);
	}

	public override void Update()
	{
		int num = spd;
		Vector3 velocity = r.velocity;
		float num2 = (velocity.x = num);
		Vector3 vector2 = (r.velocity = velocity);
		r1U.origin = transform.position;
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		r2U.direction = Vector3.right;
		r1D.origin = transform.position;
		float y = r1D.origin.y - 1f;
		Vector3 origin = r1D.origin;
		float num3 = (origin.y = y);
		Vector3 vector4 = (r1D.origin = origin);
		r1D.direction = Vector3.left;
		r2D.origin = transform.position;
		float y2 = r2D.origin.y - 1f;
		Vector3 origin2 = r2D.origin;
		float num4 = (origin2.y = y2);
		Vector3 vector6 = (r2D.origin = origin2);
		r2D.direction = Vector3.right;
		if ((Physics.Raycast(r1U, 15f, mask) || (Physics.Raycast(r1D, 15f, mask) && !ATKING)) && Network.isServer && !ATKING)
		{
			StartCoroutine_Auto(Attack(0));
		}
		if ((Physics.Raycast(r2U, 15f, mask) || (Physics.Raycast(r2D, 15f, mask) && !ATKING)) && Network.isServer && !ATKING)
		{
			StartCoroutine_Auto(Attack(1));
		}
		if ((Physics.Raycast(r1U, 3f, mask2) || (Physics.Raycast(r1D, 3f, mask2) && !turning && e.transform.rotation.y == 0f)) && Network.isServer)
		{
			StartCoroutine_Auto(T());
		}
		if ((Physics.Raycast(r2U, 3f, mask2) || (Physics.Raycast(r2D, 3f, mask2) && !turning && e.transform.rotation.y != 0f)) && Network.isServer)
		{
			StartCoroutine_Auto(T());
		}
	}

	public virtual IEnumerator T()
	{
		return new _0024T_00241475(this).GetEnumerator();
	}

	[RPC]
	public virtual void I()
	{
		@base.GetComponent<Animation>().Play("i");
	}

	public virtual IEnumerator Attack(int dir)
	{
		return new _0024Attack_00241482(dir, this).GetEnumerator();
	}

	[RPC]
	public virtual void Roar()
	{
		@base.GetComponent<Animation>().Play("a");
	}

	[RPC]
	public virtual void Turn(int dir)
	{
		if (dir == 0)
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
