using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ProjectileScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242517 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ProjectileScript _0024self__00242518;

			public _0024(ProjectileScript self_)
			{
				_0024self__00242518 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0046: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242518.t = ((Component)_0024self__00242518).transform;
					if (MenuScript.multiplayer == 1)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
						break;
					}
					goto IL_0060;
				case 2:
					Network.Destroy(((Component)_0024self__00242518).networkView.viewID);
					goto IL_0060;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0060:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ProjectileScript _0024self__00242519;

		public _0024Start_00242517(ProjectileScript self_)
		{
			_0024self__00242519 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242519);
		}
	}

	public float speed;

	public GameObject lightObj;

	private Transform t;

	private bool stuck;

	public override IEnumerator Start()
	{
		return new _0024Start_00242517(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (!stuck)
		{
			t.Translate(Vector3.up * Time.deltaTime * speed);
		}
	}

	public override void Die()
	{
		stuck = true;
	}

	public override void Main()
	{
	}
}
