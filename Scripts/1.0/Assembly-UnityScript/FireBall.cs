using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FireBall : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241602 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Renderer _0024r2_00241603;

			internal float _0024_0024609_00241604;

			internal Vector2 _0024_0024610_00241605;

			internal float _0024_0024611_00241606;

			internal Vector2 _0024_0024612_00241607;

			internal FireBall _0024self__00241608;

			public _0024(FireBall self_)
			{
				_0024self__00241608 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_019c: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a6: Expected O, but got Unknown
				//IL_0121: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_014c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_017f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0184: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241608.r = _0024self__00241608.@base.renderer;
					_0024r2_00241603 = null;
					if (Object.op_Implicit((Object)(object)_0024self__00241608.base2))
					{
						_0024r2_00241603 = _0024self__00241608.base2.renderer;
					}
					_0024self__00241608.t = ((Component)_0024self__00241608).transform;
					goto case 2;
				case 2:
				{
					float num = (_0024_0024609_00241604 = _0024self__00241608.r.material.mainTextureOffset.x + 0.25f);
					Vector2 val = (_0024_0024610_00241605 = _0024self__00241608.r.material.mainTextureOffset);
					float num2 = (_0024_0024610_00241605.x = _0024_0024609_00241604);
					Vector2 val3 = (_0024self__00241608.r.material.mainTextureOffset = _0024_0024610_00241605);
					if (Object.op_Implicit((Object)(object)_0024r2_00241603))
					{
						float num3 = (_0024_0024611_00241606 = _0024r2_00241603.material.mainTextureOffset.x + 0.25f);
						Vector2 val4 = (_0024_0024612_00241607 = _0024r2_00241603.material.mainTextureOffset);
						float num4 = (_0024_0024612_00241607.x = _0024_0024611_00241606);
						Vector2 val6 = (_0024r2_00241603.material.mainTextureOffset = _0024_0024612_00241607);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00241608.wait)) ? 1 : 0);
					break;
				}
				case 3:
					if (MenuScript.multiplayer > 0)
					{
						Network.Destroy(((Component)_0024self__00241608).gameObject);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241608).gameObject);
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

		internal FireBall _0024self__00241609;

		public _0024Start_00241602(FireBall self_)
		{
			_0024self__00241609 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241609);
		}
	}

	public bool isRight;

	public GameObject @base;

	public GameObject base2;

	private Renderer r;

	public GameObject lightObj;

	public int min;

	public int max;

	public float wait;

	public float speed;

	private int MAG;

	private Transform t;

	public FireBall()
	{
		speed = 3f;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241602(this).GetEnumerator();
	}

	[RPC]
	public override void SetNN(int m)
	{
		MAG = m;
	}

	[RPC]
	public override void SetN(int m)
	{
		MAG = m;
	}

	public override void Set(int m)
	{
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("SetNN", (RPCMode)2, new object[1] { m });
		}
		else
		{
			MAG = m;
		}
	}

	public override void Update()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		speed += 0.2f * Time.deltaTime;
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
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 12)
		{
			((Component)c).gameObject.SendMessage("TD", (object)MAG);
			if (MenuScript.multiplayer > 0)
			{
				Network.Destroy(((Component)this).networkView.viewID);
				Network.RemoveRPCs(((Component)this).networkView.viewID);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
		}
	}

	public override void Main()
	{
	}
}
