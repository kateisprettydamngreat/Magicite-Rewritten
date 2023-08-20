using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class CritScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241333 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CritScript _0024self__00241334;

			public _0024(CritScript self_)
			{
				_0024self__00241334 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241334.stop = true;
					UnityEngine.Object.Destroy(_0024self__00241334.gameObject, 0.5f);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal CritScript _0024self__00241335;

		public _0024Start_00241333(CritScript self_)
		{
			_0024self__00241335 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241335);
		}
	}

	private Transform t;

	private bool stop;

	public virtual void Awake()
	{
		t = transform;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241333(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (!stop && (bool)t)
		{
			t.Translate(Vector3.up * Time.deltaTime * 6f);
		}
	}

	}