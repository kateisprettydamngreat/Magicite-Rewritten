using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EnemyProjectile : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241517 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal EnemyProjectile _0024self__00241518;

			public _0024(EnemyProjectile self_)
			{
				_0024self__00241518 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0046: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241518.t = ((Component)_0024self__00241518).transform;
					if (MenuScript.multiplayer > 0)
					{
						if (Network.isServer)
						{
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(5f)) ? 1 : 0);
							break;
						}
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241518).gameObject, 5f);
					}
					goto IL_0081;
				case 2:
					Network.Destroy(((Component)_0024self__00241518).networkView.viewID);
					goto IL_0081;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0081:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal EnemyProjectile _0024self__00241519;

		public _0024Start_00241517(EnemyProjectile self_)
		{
			_0024self__00241519 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241519);
		}
	}

	public float speed;

	public bool isLeft;

	private Transform t;

	private bool stuck;

	public override IEnumerator Start()
	{
		return new _0024Start_00241517(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (!stuck)
		{
			if (isLeft)
			{
				t.Translate(Vector3.left * speed * Time.deltaTime);
			}
			else
			{
				t.Translate(Vector3.left * (0f - speed) * Time.deltaTime);
			}
		}
	}

	public override void Stuck()
	{
		stuck = true;
		((Component)this).rigidbody.isKinematic = true;
		((Component)this).collider.enabled = false;
	}

	public override void OnTriggerEnter(Collider c)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)c).gameObject.layer != 11)
		{
			return;
		}
		if (MenuScript.multiplayer > 0)
		{
			if (Network.isServer)
			{
				Network.RemoveRPCs(((Component)this).networkView.viewID);
				Network.Destroy(((Component)this).networkView.viewID);
			}
		}
		else
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public override void Main()
	{
	}
}
