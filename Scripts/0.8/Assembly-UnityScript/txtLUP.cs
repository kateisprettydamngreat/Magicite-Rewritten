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
	internal sealed class _0024Start_00243072 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00243073;

			internal float _0024_00241173_00243074;

			internal Vector3 _0024_00241174_00243075;

			internal txtLUP _0024self__00243076;

			public _0024(txtLUP self_)
			{
				_0024self__00243076 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0040: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00243073 = default(int);
					_0024i_00243073 = 0;
					goto IL_00c6;
				case 2:
					_0024i_00243073++;
					goto IL_00c6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00c6:
					if (_0024i_00243073 < 20)
					{
						float num = (_0024_00241173_00243074 = _0024self__00243076.t.position.y + 0.1f);
						Vector3 val = (_0024_00241174_00243075 = _0024self__00243076.t.position);
						float num2 = (_0024_00241174_00243075.y = _0024_00241173_00243074);
						Vector3 val3 = (_0024self__00243076.t.position = _0024_00241174_00243075);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal txtLUP _0024self__00243077;

		public _0024Start_00243072(txtLUP self_)
		{
			_0024self__00243077 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243077);
		}
	}

	private Transform t;

	public TextMesh txtSentence;

	public override void Awake()
	{
		t = ((Component)this).transform;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00243072(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
