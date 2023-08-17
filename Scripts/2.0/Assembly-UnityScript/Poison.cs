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
	internal sealed class _0024Start_00242371 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Poison _0024self__00242372;

			public _0024(Poison self_)
			{
				_0024self__00242372 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(6f)) ? 1 : 0);
					break;
				case 2:
					if (Network.isServer)
					{
						_0024self__00242372.parent.SendMessage("Exile");
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Poison _0024self__00242373;

		public _0024Start_00242371(Poison self_)
		{
			_0024self__00242373 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242373);
		}
	}

	public GameObject parent;

	private bool exiling;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242371(this).GetEnumerator();
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8 || c.gameObject.layer == 9)
		{
			MonoBehaviour.print("LAYER ++++++++++ " + c.gameObject.layer);
			c.gameObject.SendMessage("TDp");
			bool flag = default(bool);
			flag = ((!(transform.position.x < c.gameObject.transform.position.x)) ? true : false);
			c.gameObject.SendMessage("K", flag);
		}
	}

	public virtual void Main()
	{
	}
}
