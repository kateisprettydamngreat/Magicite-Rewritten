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
	internal sealed class _0024Start_00241194 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CritScript _0024self__00241195;

			public _0024(CritScript self_)
			{
				_0024self__00241195 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Expected O, but got Unknown
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241195.stop = true;
					if (MenuScript.multiplayer > 0)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					Object.Destroy((Object)(object)((Component)_0024self__00241195).gameObject, 0.5f);
					goto IL_00a2;
				case 3:
					Network.RemoveRPCs(((Component)_0024self__00241195).networkView.viewID);
					Network.Destroy(((Component)_0024self__00241195).networkView.viewID);
					goto IL_00a2;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a2:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal CritScript _0024self__00241196;

		public _0024Start_00241194(CritScript self_)
		{
			_0024self__00241196 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241196);
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
		return new _0024Start_00241194(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (!stop && Object.op_Implicit((Object)(object)t))
		{
			t.Translate(Vector3.up * Time.deltaTime * -8f);
		}
	}

	public override void Main()
	{
	}
}
