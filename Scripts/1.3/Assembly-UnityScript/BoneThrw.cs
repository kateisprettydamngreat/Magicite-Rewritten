using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BoneThrw : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241424 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BoneThrw _0024self__00241425;

			public _0024(BoneThrw self_)
			{
				_0024self__00241425 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241425.r = _0024self__00241425.@base.renderer;
					_0024self__00241425.t = ((Component)_0024self__00241425).transform;
					if (_0024self__00241425.isRight)
					{
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						Network.Destroy(((Component)_0024self__00241425).gameObject);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241425).gameObject);
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

		internal BoneThrw _0024self__00241426;

		public _0024Start_00241424(BoneThrw self_)
		{
			_0024self__00241426 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241426);
		}
	}

	public bool isRight;

	public GameObject @base;

	private Renderer r;

	private float speed;

	private Transform t;

	public BoneThrw()
	{
		speed = 5f;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241424(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		speed += 0.2f;
		if (isRight)
		{
			t.Translate(Vector3.left * Time.deltaTime * (0f - speed));
		}
		else
		{
			t.Translate(Vector3.left * Time.deltaTime * speed);
		}
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer != 9)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public override void Main()
	{
	}
}
