using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class IceSlimeScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241898 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal IceSlimeScript _0024self__00241899;

			public _0024(IceSlimeScript self_)
			{
				_0024self__00241899 = self_;
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
					result = (Yield(3, _0024self__00241899.StartCoroutine_Auto(_0024self__00241899.MoveCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal IceSlimeScript _0024self__00241900;

		public _0024Start_00241898(IceSlimeScript self_)
		{
			_0024self__00241900 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new _0024(_0024self__00241900);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241901 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241902;

			internal int _0024_0024639_00241903;

			internal Vector3 _0024_0024640_00241904;

			internal int _0024_0024641_00241905;

			internal Vector3 _0024_0024642_00241906;

			internal int _0024_0024643_00241907;

			internal Vector3 _0024_0024644_00241908;

			internal int _0024_0024645_00241909;

			internal Vector3 _0024_0024646_00241910;

			internal IceSlimeScript _0024self__00241911;

			public _0024(IceSlimeScript self_)
			{
				_0024self__00241911 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024num_00241902 = UnityEngine.Random.Range(0, 2);
					if (_0024num_00241902 != 0)
					{
						int num = (_0024_0024643_00241907 = -5);
						Vector3 vector = (_0024_0024644_00241908 = _0024self__00241911.GetComponent<Rigidbody>().velocity);
						float num2 = (_0024_0024644_00241908.x = _0024_0024643_00241907);
						Vector3 vector3 = (_0024self__00241911.GetComponent<Rigidbody>().velocity = _0024_0024644_00241908);
						int num3 = (_0024_0024645_00241909 = UnityEngine.Random.Range(10, 16));
						Vector3 vector4 = (_0024_0024646_00241910 = _0024self__00241911.GetComponent<Rigidbody>().velocity);
						float num4 = (_0024_0024646_00241910.y = _0024_0024645_00241909);
						Vector3 vector6 = (_0024self__00241911.GetComponent<Rigidbody>().velocity = _0024_0024646_00241910);
					}
					else
					{
						int num5 = (_0024_0024639_00241903 = 5);
						Vector3 vector7 = (_0024_0024640_00241904 = _0024self__00241911.GetComponent<Rigidbody>().velocity);
						float num6 = (_0024_0024640_00241904.x = _0024_0024639_00241903);
						Vector3 vector9 = (_0024self__00241911.GetComponent<Rigidbody>().velocity = _0024_0024640_00241904);
						int num7 = (_0024_0024641_00241905 = UnityEngine.Random.Range(10, 16));
						Vector3 vector10 = (_0024_0024642_00241906 = _0024self__00241911.GetComponent<Rigidbody>().velocity);
						float num8 = (_0024_0024642_00241906.y = _0024_0024641_00241905);
						Vector3 vector12 = (_0024self__00241911.GetComponent<Rigidbody>().velocity = _0024_0024642_00241906);
					}
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
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

		internal IceSlimeScript _0024self__00241912;

		public _0024MoveCheck_00241901(IceSlimeScript self_)
		{
			_0024self__00241912 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241912);
		}
	}

	public override void Awake()
	{
		int[] array = new int[3] { 10, 9, 16 };
		SetStats(15, 2, 0, 6, 7f, array, UnityEngine.Random.Range(5, 15), 6);
		@base.GetComponent<Animation>()["i"].speed = 0.5f;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241898(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241901(this).GetEnumerator();
	}
}
