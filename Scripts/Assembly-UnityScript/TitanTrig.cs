using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class TitanTrig : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Trig_00242664 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal TitanTrig _0024self__00242665;

			public _0024(TitanTrig self_)
			{
				_0024self__00242665 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242665.GetComponent<Collider>().enabled = false;
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242665.GetComponent<Collider>().enabled = true;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal TitanTrig _0024self__00242666;

		public _0024Trig_00242664(TitanTrig self_)
		{
			_0024self__00242666 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242666);
		}
	}

	public GameObject parent;

	private TitanScript titanScript;

	private GameObject target;

	public virtual void Awake()
	{
		titanScript = (TitanScript)parent.GetComponent("TitanScript");
		StartCoroutine_Auto(Trig());
	}

	public virtual IEnumerator Trig()
	{
		return new _0024Trig_00242664(this).GetEnumerator();
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			target = c.gameObject;
			titanScript.Attack(target);
		}
	}

	public virtual void Main()
	{
	}
}
