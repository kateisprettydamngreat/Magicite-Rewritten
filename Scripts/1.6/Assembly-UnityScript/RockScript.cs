using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class RockScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00242563 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal RockScript _0024self__00242564;

			public _0024(RockScript self_)
			{
				_0024self__00242564 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected O, but got Unknown
				//IL_0040: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer == 1)
					{
						Network.Destroy(((Component)_0024self__00242564).networkView.viewID);
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

		internal RockScript _0024self__00242565;

		public _0024Die_00242563(RockScript self_)
		{
			_0024self__00242565 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242565);
		}
	}

	private Transform t;

	private int speed;

	public int bonus;

	public override void Awake()
	{
		t = ((Component)this).transform;
		speed = Random.Range(8, 15);
		((Component)this).networkView.RPC("Die", (RPCMode)6, new object[0]);
	}

	public override void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		t.Translate(Vector3.up * Time.deltaTime * (float)(-(speed + bonus)));
	}

	[RPC]
	public override IEnumerator Die()
	{
		return new _0024Die_00242563(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
