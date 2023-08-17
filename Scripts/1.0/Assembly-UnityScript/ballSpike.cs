using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ballSpike : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242993 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242994;

			internal float _0024_00241121_00242995;

			internal Vector3 _0024_00241122_00242996;

			internal ballSpike _0024self__00242997;

			public _0024(ballSpike self_)
			{
				_0024self__00242997 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Expected O, but got Unknown
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242997.t = ((Component)_0024self__00242997).transform;
					if (MenuScript.multiplayer == 1)
					{
						float num = (_0024_00241121_00242995 = _0024self__00242997.t.position.y + (float)Random.Range(0, 5));
						Vector3 val = (_0024_00241122_00242996 = _0024self__00242997.t.position);
						float num2 = (_0024_00241122_00242996.y = _0024_00241121_00242995);
						Vector3 val3 = (_0024self__00242997.t.position = _0024_00241122_00242996);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 5) * 0.1f)) ? 1 : 0);
						break;
					}
					goto IL_0157;
				case 2:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(0, 5) * 0.1f)) ? 1 : 0);
					break;
				case 3:
					_0024num_00242994 = Random.Range(0, 2);
					if (_0024num_00242994 == 0)
					{
						((Component)_0024self__00242997).networkView.RPC("swing", (RPCMode)6, new object[1] { 1 });
					}
					else
					{
						((Component)_0024self__00242997).networkView.RPC("swing", (RPCMode)6, new object[1] { 0 });
					}
					goto IL_0157;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0157:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ballSpike _0024self__00242998;

		public _0024Start_00242993(ballSpike self_)
		{
			_0024self__00242998 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242998);
		}
	}

	private Transform t;

	public GameObject @base;

	public override IEnumerator Start()
	{
		return new _0024Start_00242993(this).GetEnumerator();
	}

	[RPC]
	public override void swing(int a)
	{
		if (a == 0)
		{
			@base.animation["swingB"].speed = 1f;
		}
		else
		{
			@base.animation["swingB"].speed = -1f;
		}
		@base.animation.Play();
	}

	public override void Main()
	{
	}
}
