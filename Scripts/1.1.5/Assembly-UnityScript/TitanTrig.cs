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
	internal sealed class _0024Trig_00242849 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal TitanTrig _0024self__00242850;

			public _0024(TitanTrig self_)
			{
				_0024self__00242850 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Expected O, but got Unknown
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					((Component)_0024self__00242850).collider.enabled = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00242850).collider.enabled = true;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal TitanTrig _0024self__00242851;

		public _0024Trig_00242849(TitanTrig self_)
		{
			_0024self__00242851 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242851);
		}
	}

	public GameObject parent;

	private TitanScript titanScript;

	private GameObject target;

	public override void Awake()
	{
		titanScript = (TitanScript)(object)parent.GetComponent("TitanScript");
		((MonoBehaviour)this).StartCoroutine_Auto(Trig());
	}

	public override IEnumerator Trig()
	{
		return new _0024Trig_00242849(this).GetEnumerator();
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			target = ((Component)c).gameObject;
			((MonoBehaviour)this).StartCoroutine_Auto(titanScript.Attack(target));
		}
	}

	public override void Main()
	{
	}
}
