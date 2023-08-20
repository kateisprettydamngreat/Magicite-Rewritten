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
	internal sealed class _0024Start_00242374 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ProjectileScript _0024self__00242375;

			public _0024(ProjectileScript self_)
			{
				_0024self__00242375 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242375.t = _0024self__00242375.transform;
					if (Network.isServer)
					{
						result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
						break;
					}
					goto IL_005f;
				case 2:
					Network.Destroy(_0024self__00242375.GetComponent<NetworkView>().viewID);
					goto IL_005f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_005f:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ProjectileScript _0024self__00242376;

		public _0024Start_00242374(ProjectileScript self_)
		{
			_0024self__00242376 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242376);
		}
	}

	public float speed;

	public GameObject lightObj;

	private Transform t;

	private bool stuck;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242374(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (!stuck)
		{
			t.Translate(Vector3.up * Time.deltaTime * speed);
		}
	}

	public virtual void Die()
	{
		stuck = true;
	}

	}