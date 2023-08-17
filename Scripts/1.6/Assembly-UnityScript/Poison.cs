using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Poison : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242557 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Poison _0024self__00242558;

			public _0024(Poison self_)
			{
				_0024self__00242558 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Expected O, but got Unknown
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					result = (((MenuScript.multiplayer <= 0) ? ((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(6f)) : ((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(6f))) ? 1 : 0);
					break;
				case 2:
					if (Network.isServer)
					{
						Network.RemoveRPCs(_0024self__00242558.parent.networkView.viewID);
						Network.Destroy(_0024self__00242558.parent.networkView.viewID);
					}
					goto IL_00a4;
				case 3:
					Object.Destroy((Object)(object)_0024self__00242558.parent.gameObject);
					goto IL_00a4;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a4:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Poison _0024self__00242559;

		public _0024Start_00242557(Poison self_)
		{
			_0024self__00242559 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242559);
		}
	}

	public GameObject parent;

	public override IEnumerator Start()
	{
		return new _0024Start_00242557(this).GetEnumerator();
	}

	public override void OnTriggerEnter(Collider c)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)c).gameObject.layer == 8 || ((Component)c).gameObject.layer == 9)
		{
			MonoBehaviour.print((object)("LAYER ++++++++++ " + (object)((Component)c).gameObject.layer));
			((Component)c).gameObject.SendMessage("TDp");
			bool flag = default(bool);
			flag = ((!(((Component)this).transform.position.x < ((Component)c).gameObject.transform.position.x)) ? true : false);
			((Component)c).gameObject.SendMessage("K", (object)flag);
		}
	}

	public override void Main()
	{
	}
}
