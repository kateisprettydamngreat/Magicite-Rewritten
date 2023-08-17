using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class CoinScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241330 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CoinScript _0024self__00241331;

			public _0024(CoinScript self_)
			{
				_0024self__00241331 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds((float)UnityEngine.Random.Range(1, 4) * 0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241331.core.GetComponent<Animation>().Play();
					_0024self__00241331.@base.GetComponent<Collider>().enabled = true;
					_0024self__00241331.can = true;
					result = (Yield(3, new WaitForSeconds(15f)) ? 1 : 0);
					break;
				case 3:
					UnityEngine.Object.Destroy(_0024self__00241331.gameObject);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal CoinScript _0024self__00241332;

		public _0024Start_00241330(CoinScript self_)
		{
			_0024self__00241332 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241332);
		}
	}

	public GameObject @base;

	public GameObject core;

	private Rigidbody r;

	private int mask;

	private Ray ray;

	private RaycastHit hit;

	private Transform t;

	private bool can;

	public CoinScript()
	{
		mask = 256;
	}

	public virtual void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		r.AddForce(new Vector3(UnityEngine.Random.Range(-10, 10) * 50, UnityEngine.Random.Range(-10, 10) * 50, 0f));
	}

	public virtual void Update()
	{
		if (can)
		{
			ray = new Ray(t.position, new Vector3(-1f, 0f, 0f));
			if (Physics.Raycast(ray, out hit, 3f, mask))
			{
				int num = -9;
				Vector3 velocity = r.velocity;
				float num2 = (velocity.x = num);
				Vector3 vector2 = (r.velocity = velocity);
			}
			ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
			if (Physics.Raycast(ray, out hit, 3f, mask))
			{
				int num3 = 9;
				Vector3 velocity2 = r.velocity;
				float num4 = (velocity2.x = num3);
				Vector3 vector4 = (r.velocity = velocity2);
			}
		}
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241330(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
