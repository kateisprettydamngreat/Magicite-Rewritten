using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BoltScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Bolt_00241430 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241431;

			internal float _0024_0024498_00241432;

			internal Vector2 _0024_0024499_00241433;

			internal BoltScript _0024self__00241434;

			public _0024(BoltScript self_)
			{
				_0024self__00241434 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e2: Expected O, but got Unknown
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					((Component)_0024self__00241434).collider.enabled = true;
					_0024i_00241431 = default(int);
					_0024i_00241431 = 0;
					goto IL_00f5;
				case 2:
					_0024i_00241431++;
					goto IL_00f5;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00f5:
					if (_0024i_00241431 < 12)
					{
						float num = (_0024_0024498_00241432 = _0024self__00241434.@base.renderer.material.mainTextureOffset.x + 0.25f);
						Vector2 val = (_0024_0024499_00241433 = _0024self__00241434.@base.renderer.material.mainTextureOffset);
						float num2 = (_0024_0024499_00241433.x = _0024_0024498_00241432);
						Vector2 val3 = (_0024self__00241434.@base.renderer.material.mainTextureOffset = _0024_0024499_00241433);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.05f)) ? 1 : 0);
						break;
					}
					if (MenuScript.multiplayer > 0)
					{
						Network.Destroy(((Component)_0024self__00241434).networkView.viewID);
						Network.RemoveRPCs(((Component)_0024self__00241434).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241434).gameObject);
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BoltScript _0024self__00241435;

		public _0024Bolt_00241430(BoltScript self_)
		{
			_0024self__00241435 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241435);
		}
	}

	public GameObject @base;

	private int MAG;

	public override void Set(int m)
	{
		((Component)this).networkView.RPC("SETN", (RPCMode)2, new object[1] { m });
	}

	[RPC]
	public override void SETN(int m)
	{
		MAG = m;
		((MonoBehaviour)this).StartCoroutine_Auto(Bolt());
	}

	public override IEnumerator Bolt()
	{
		return new _0024Bolt_00241430(this).GetEnumerator();
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 12)
		{
			((Component)c).gameObject.SendMessage("TD", (object)MAG);
		}
		else if (((Component)c).gameObject.layer == 8 && MenuScript.pvp == 1 && !((Component)this).networkView.isMine)
		{
			((Component)c).gameObject.SendMessage("TD", (object)MAG);
		}
	}

	public override void Main()
	{
	}
}
