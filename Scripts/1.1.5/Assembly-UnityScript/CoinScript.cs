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
	internal sealed class _0024Start_00241422 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CoinScript _0024self__00241423;

			public _0024(CoinScript self_)
			{
				_0024self__00241423 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Expected O, but got Unknown
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Expected O, but got Unknown
				//IL_009c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 4) * 0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241423.core.animation.Play();
					_0024self__00241423.@base.collider.enabled = true;
					_0024self__00241423.can = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 3:
					if (MenuScript.multiplayer > 0)
					{
						Network.RemoveRPCs(((Component)_0024self__00241423).networkView.viewID);
						Network.Destroy(((Component)_0024self__00241423).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241423).gameObject);
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

		internal CoinScript _0024self__00241424;

		public _0024Start_00241422(CoinScript self_)
		{
			_0024self__00241424 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241424);
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

	public override void Awake()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		r.AddForce(new Vector3((float)(Random.Range(-10, 10) * 50), (float)(Random.Range(-10, 10) * 50), 0f));
	}

	public override void Update()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		if (can)
		{
			ray = new Ray(t.position, new Vector3(-1f, 0f, 0f));
			if (Physics.Raycast(ray, ref hit, 3f, mask))
			{
				int num = -9;
				Vector3 velocity = r.velocity;
				float num2 = (velocity.x = num);
				Vector3 val2 = (r.velocity = velocity);
			}
			ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
			if (Physics.Raycast(ray, ref hit, 3f, mask))
			{
				int num3 = 9;
				Vector3 velocity2 = r.velocity;
				float num4 = (velocity2.x = num3);
				Vector3 val4 = (r.velocity = velocity2);
			}
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241422(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
