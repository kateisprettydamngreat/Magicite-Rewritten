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
	internal sealed class _0024Bolt_00241163 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241164;

			internal float _0024_0024417_00241165;

			internal Vector2 _0024_0024418_00241166;

			internal BoltScript _0024self__00241167;

			public _0024(BoltScript self_)
			{
				_0024self__00241167 = self_;
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
					((Component)_0024self__00241167).collider.enabled = true;
					_0024i_00241164 = default(int);
					_0024i_00241164 = 0;
					goto IL_00f5;
				case 2:
					_0024i_00241164++;
					goto IL_00f5;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00f5:
					if (_0024i_00241164 < 12)
					{
						float num = (_0024_0024417_00241165 = _0024self__00241167.@base.renderer.material.mainTextureOffset.x + 0.25f);
						Vector2 val = (_0024_0024418_00241166 = _0024self__00241167.@base.renderer.material.mainTextureOffset);
						float num2 = (_0024_0024418_00241166.x = _0024_0024417_00241165);
						Vector2 val3 = (_0024self__00241167.@base.renderer.material.mainTextureOffset = _0024_0024418_00241166);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.05f)) ? 1 : 0);
						break;
					}
					if (MenuScript.multiplayer > 0)
					{
						Network.Destroy(((Component)_0024self__00241167).networkView.viewID);
						Network.RemoveRPCs(((Component)_0024self__00241167).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241167).gameObject);
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BoltScript _0024self__00241168;

		public _0024Bolt_00241163(BoltScript self_)
		{
			_0024self__00241168 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241168);
		}
	}

	public GameObject @base;

	private int MAG;

	public override void Set(int m)
	{
		MAG = m;
		((MonoBehaviour)this).StartCoroutine_Auto(Bolt());
	}

	public override IEnumerator Bolt()
	{
		return new _0024Bolt_00241163(this).GetEnumerator();
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 12)
		{
			MonoBehaviour.print((object)("BOLT HIT " + (object)MAG));
			((Component)c).gameObject.SendMessage("TD", (object)MAG);
		}
	}

	public override void Main()
	{
	}
}
