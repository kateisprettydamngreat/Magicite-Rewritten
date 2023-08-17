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
	internal sealed class _0024Start_00241485 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CritScript _0024self__00241486;

			public _0024(CritScript self_)
			{
				_0024self__00241486 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241486.stop = true;
					if (MenuScript.multiplayer > 0)
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241486).gameObject, 0.5f);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241486).gameObject, 0.5f);
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal CritScript _0024self__00241487;

		public _0024Start_00241485(CritScript self_)
		{
			_0024self__00241487 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241487);
		}
	}

	private Transform t;

	private bool stop;

	public override void Awake()
	{
		t = ((Component)this).transform;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241485(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (!stop && Object.op_Implicit((Object)(object)t))
		{
			t.Translate(Vector3.up * Time.deltaTime * 6f);
		}
	}

	public override void Main()
	{
	}
}
