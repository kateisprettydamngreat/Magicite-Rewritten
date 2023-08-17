using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ShroomBaby : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242447 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal ShroomBaby _0024self__00242448;

			public _0024(ShroomBaby self_)
			{
				_0024self__00242448 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(0, 6))) ? 1 : 0);
					break;
				case 2:
					_0024self__00242448.@base.GetComponent<Animation>()["i"].speed = 0.5f;
					goto case 3;
				case 3:
					result = (Yield(3, _0024self__00242448.StartCoroutine_Auto(_0024self__00242448.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ShroomBaby _0024self__00242449;

		public _0024Start_00242447(ShroomBaby self_)
		{
			_0024self__00242449 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new _0024(_0024self__00242449);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242450 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242451;

			internal int _0024_0024883_00242452;

			internal Vector3 _0024_0024884_00242453;

			internal int _0024_0024885_00242454;

			internal Vector3 _0024_0024886_00242455;

			internal int _0024_0024887_00242456;

			internal Vector3 _0024_0024888_00242457;

			internal int _0024_0024889_00242458;

			internal Vector3 _0024_0024890_00242459;

			internal ShroomBaby _0024self__00242460;

			public _0024(ShroomBaby self_)
			{
				_0024self__00242460 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024num_00242451 = UnityEngine.Random.Range(0, 2);
					if (_0024num_00242451 != 0)
					{
						int num = (_0024_0024887_00242456 = -10);
						Vector3 vector = (_0024_0024888_00242457 = _0024self__00242460.GetComponent<Rigidbody>().velocity);
						float num2 = (_0024_0024888_00242457.x = _0024_0024887_00242456);
						Vector3 vector3 = (_0024self__00242460.GetComponent<Rigidbody>().velocity = _0024_0024888_00242457);
						int num3 = (_0024_0024889_00242458 = UnityEngine.Random.Range(10, 16));
						Vector3 vector4 = (_0024_0024890_00242459 = _0024self__00242460.GetComponent<Rigidbody>().velocity);
						float num4 = (_0024_0024890_00242459.y = _0024_0024889_00242458);
						Vector3 vector6 = (_0024self__00242460.GetComponent<Rigidbody>().velocity = _0024_0024890_00242459);
					}
					else
					{
						int num5 = (_0024_0024883_00242452 = 10);
						Vector3 vector7 = (_0024_0024884_00242453 = _0024self__00242460.GetComponent<Rigidbody>().velocity);
						float num6 = (_0024_0024884_00242453.x = _0024_0024883_00242452);
						Vector3 vector9 = (_0024self__00242460.GetComponent<Rigidbody>().velocity = _0024_0024884_00242453);
						int num7 = (_0024_0024885_00242454 = UnityEngine.Random.Range(10, 16));
						Vector3 vector10 = (_0024_0024886_00242455 = _0024self__00242460.GetComponent<Rigidbody>().velocity);
						float num8 = (_0024_0024886_00242455.y = _0024_0024885_00242454);
						Vector3 vector12 = (_0024self__00242460.GetComponent<Rigidbody>().velocity = _0024_0024886_00242455);
					}
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ShroomBaby _0024self__00242461;

		public _0024MoveCheck_00242450(ShroomBaby self_)
		{
			_0024self__00242461 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242461);
		}
	}

	public override void Awake()
	{
		int[] array = new int[3] { 20, 19, 15 };
		SetStats(15, 4, 0, 5, 4f, array, UnityEngine.Random.Range(5, 15), 7);
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242447(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242450(this).GetEnumerator();
	}
}
