using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EffectScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024End_00241324 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal EffectScript _0024self__00241325;

			public _0024(EffectScript self_)
			{
				_0024self__00241325 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Expected O, but got Unknown
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((MenuScript.multiplayer <= 0) ? ((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) : ((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f))) ? 1 : 0);
					break;
				case 2:
					Network.RemoveRPCs(((Component)_0024self__00241325).networkView.viewID);
					Network.Destroy(((Component)_0024self__00241325).networkView.viewID);
					goto IL_0091;
				case 3:
					Object.Destroy((Object)(object)((Component)_0024self__00241325).gameObject);
					goto IL_0091;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0091:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal EffectScript _0024self__00241326;

		public _0024End_00241324(EffectScript self_)
		{
			_0024self__00241326 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241326);
		}
	}

	public int type;

	private int mag;

	public override void Awake()
	{
		if (type == 2)
		{
			((Component)this).collider.enabled = false;
		}
	}

	public override void Start()
	{
		if (type != 2)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(End());
		}
	}

	public override IEnumerator End()
	{
		return new _0024End_00241324(this).GetEnumerator();
	}

	public override void SetMag(int a)
	{
		mag = a;
		((Component)this).collider.enabled = true;
		((MonoBehaviour)this).StartCoroutine_Auto(End());
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (type == 0)
		{
			((Component)c).gameObject.SendMessage("Charge");
		}
		else if (type == 1)
		{
			((Component)c).gameObject.SendMessage("Shield");
		}
		else if (type == 2)
		{
			((Component)c).gameObject.SendMessage("mWeapons", (object)mag);
		}
		else if (type == 3)
		{
			((Component)c).gameObject.SendMessage("drumATK");
		}
		else if (type == 4)
		{
			((Component)c).gameObject.SendMessage("drumDEX");
		}
		else if (type == 5)
		{
			((Component)c).gameObject.SendMessage("drumMAG");
		}
	}

	public override void Main()
	{
	}
}
