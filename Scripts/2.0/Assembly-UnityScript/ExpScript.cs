using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ExpScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241460 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ExpScript _0024self__00241461;

			public _0024(ExpScript self_)
			{
				_0024self__00241461 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241461.@base.GetComponent<Collider>().enabled = true;
					_0024self__00241461.can = true;
					result = (Yield(3, new WaitForSeconds(20f)) ? 1 : 0);
					break;
				case 3:
					UnityEngine.Object.Destroy(_0024self__00241461.gameObject);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ExpScript _0024self__00241462;

		public _0024Start_00241460(ExpScript self_)
		{
			_0024self__00241462 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241462);
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

	public ExpScript()
	{
		mask = 256;
	}

	public virtual void Awake()
	{
		r = GetComponent<Rigidbody>();
		t = transform;
		r.AddForce(new Vector3(UnityEngine.Random.Range(-4, 4) * 100, UnityEngine.Random.Range(2, 5) * 150, 0f));
	}

	public virtual void Update()
	{
		if (can)
		{
			ray = new Ray(t.position, new Vector3(-1f, 0f, 0f));
			if (Physics.Raycast(ray, out hit, 3f, mask) && hit.transform.gameObject.GetComponent<NetworkView>().isMine)
			{
				int num = -7;
				Vector3 velocity = r.velocity;
				float num2 = (velocity.x = num);
				Vector3 vector2 = (r.velocity = velocity);
			}
			ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
			if (Physics.Raycast(ray, out hit, 3f, mask) && hit.transform.gameObject.GetComponent<NetworkView>().isMine)
			{
				int num3 = 7;
				Vector3 velocity2 = r.velocity;
				float num4 = (velocity2.x = num3);
				Vector3 vector4 = (r.velocity = velocity2);
			}
		}
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241460(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
