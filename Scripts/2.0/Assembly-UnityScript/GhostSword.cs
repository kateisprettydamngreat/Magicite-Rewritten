using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class GhostSword : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Charge_00241848 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GhostSword _0024self__00241849;

			public _0024(GhostSword self_)
			{
				_0024self__00241849 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(1, 3))) ? 1 : 0);
					break;
				case 2:
					if ((bool)_0024self__00241849.p)
					{
						_0024self__00241849.dirdood = _0024self__00241849.p.position - _0024self__00241849.t.position;
					}
					else
					{
						_0024self__00241849.dirdood = new Vector3(0f, 0f, 0f);
					}
					_0024self__00241849.dirdood.z = 0f;
					_0024self__00241849.dirdood.Normalize();
					_0024self__00241849.charging = true;
					result = (Yield(3, new WaitForSeconds(UnityEngine.Random.Range(1, 3))) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GhostSword _0024self__00241850;

		public _0024Charge_00241848(GhostSword self_)
		{
			_0024self__00241850 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241850);
		}
	}

	private Transform t;

	private Transform p;

	private bool charging;

	private Vector3 dirdood;

	public virtual void Start()
	{
		t = transform;
		if (Network.isServer)
		{
			StartCoroutine_Auto(Charge());
		}
	}

	public virtual void Set(GameObject a)
	{
		p = a.transform;
	}

	public virtual IEnumerator Charge()
	{
		return new _0024Charge_00241848(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (Network.isServer && (bool)p && charging)
		{
			t.Translate(dirdood * 9f * Time.deltaTime);
		}
	}

	public virtual void Main()
	{
	}
}
