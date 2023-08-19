using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlimeScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242529 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal SlimeScript _0024self__00242530;

			public _0024(SlimeScript self_)
			{
				_0024self__00242530 = self_;
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
				case 3:
					result = (Yield(3, _0024self__00242530.StartCoroutine_Auto(_0024self__00242530.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SlimeScript _0024self__00242531;

		public _0024Start_00242529(SlimeScript self_)
		{
			_0024self__00242531 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new _0024(_0024self__00242531);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242532 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242533;

			internal int _0024_0024917_00242534;

			internal Vector3 _0024_0024918_00242535;

			internal int _0024_0024919_00242536;

			internal Vector3 _0024_0024920_00242537;

			internal int _0024_0024921_00242538;

			internal Vector3 _0024_0024922_00242539;

			internal int _0024_0024923_00242540;

			internal Vector3 _0024_0024924_00242541;

			internal SlimeScript _0024self__00242542;

			public _0024(SlimeScript self_)
			{
				_0024self__00242542 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024num_00242533 = UnityEngine.Random.Range(0, 2);
					if (_0024num_00242533 != 0)
					{
						int num = (_0024_0024921_00242538 = -10);
						Vector3 vector = (_0024_0024922_00242539 = _0024self__00242542.GetComponent<Rigidbody>().velocity);
						float num2 = (_0024_0024922_00242539.x = _0024_0024921_00242538);
						Vector3 vector3 = (_0024self__00242542.GetComponent<Rigidbody>().velocity = _0024_0024922_00242539);
						int num3 = (_0024_0024923_00242540 = UnityEngine.Random.Range(10, 16));
						Vector3 vector4 = (_0024_0024924_00242541 = _0024self__00242542.GetComponent<Rigidbody>().velocity);
						float num4 = (_0024_0024924_00242541.y = _0024_0024923_00242540);
						Vector3 vector6 = (_0024self__00242542.GetComponent<Rigidbody>().velocity = _0024_0024924_00242541);
					}
					else
					{
						int num5 = (_0024_0024917_00242534 = 10);
						Vector3 vector7 = (_0024_0024918_00242535 = _0024self__00242542.GetComponent<Rigidbody>().velocity);
						float num6 = (_0024_0024918_00242535.x = _0024_0024917_00242534);
						Vector3 vector9 = (_0024self__00242542.GetComponent<Rigidbody>().velocity = _0024_0024918_00242535);
						int num7 = (_0024_0024919_00242536 = UnityEngine.Random.Range(10, 16));
						Vector3 vector10 = (_0024_0024920_00242537 = _0024self__00242542.GetComponent<Rigidbody>().velocity);
						float num8 = (_0024_0024920_00242537.y = _0024_0024919_00242536);
						Vector3 vector12 = (_0024self__00242542.GetComponent<Rigidbody>().velocity = _0024_0024920_00242537);
					}
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
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

		internal SlimeScript _0024self__00242543;

		public _0024MoveCheck_00242532(SlimeScript self_)
		{
			_0024self__00242543 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242543);
		}
	}

	public override void Awake()
	{
		int[] array = new int[3] { 9, 18, 15 };
		SetStats(10, 1, 0, 3, 4f, array, UnityEngine.Random.Range(5, 15), 3);
		@base.GetComponent<Animation>()["i"].speed = 0.5f;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242529(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242532(this).GetEnumerator();
	}
}
