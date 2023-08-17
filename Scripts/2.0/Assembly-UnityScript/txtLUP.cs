using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class txtLUP : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242979 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242980;

			internal float _0024_00241121_00242981;

			internal Vector3 _0024_00241122_00242982;

			internal txtLUP _0024self__00242983;

			public _0024(txtLUP self_)
			{
				_0024self__00242983 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00242980 = default(int);
					_0024i_00242980 = 0;
					goto IL_00c6;
				case 2:
					_0024i_00242980++;
					goto IL_00c6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00c6:
					if (_0024i_00242980 < 20)
					{
						float num = (_0024_00241121_00242981 = _0024self__00242983.t.position.y + 0.1f);
						Vector3 vector = (_0024_00241122_00242982 = _0024self__00242983.t.position);
						float num2 = (_0024_00241122_00242982.y = _0024_00241121_00242981);
						Vector3 vector3 = (_0024self__00242983.t.position = _0024_00241122_00242982);
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal txtLUP _0024self__00242984;

		public _0024Start_00242979(txtLUP self_)
		{
			_0024self__00242984 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242984);
		}
	}

	private Transform t;

	public TextMesh txtSentence;

	public virtual void Awake()
	{
		t = transform;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242979(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
