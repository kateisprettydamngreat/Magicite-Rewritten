using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Destro : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241351 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Destro _0024self__00241352;

			public _0024(Destro self_)
			{
				_0024self__00241352 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (Network.isServer)
					{
						result = (Yield(2, new WaitForSeconds(_0024self__00241352.wait)) ? 1 : 0);
						break;
					}
					goto IL_0052;
				case 2:
					Network.Destroy(_0024self__00241352.GetComponent<NetworkView>().viewID);
					goto IL_0052;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0052:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Destro _0024self__00241353;

		public _0024Start_00241351(Destro self_)
		{
			_0024self__00241353 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241353);
		}
	}

	public GameObject[] bars;

	public float wait;

	public Destro()
	{
		bars = new GameObject[2];
		wait = 0.3f;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241351(this).GetEnumerator();
	}

	[RPC]
	public virtual void SetHH(int a)
	{
		if (GetComponent<NetworkView>().isMine)
		{
			bars[0].SendMessage("SetHH", (float)a * 0.5f);
			bars[1].SendMessage("SetHH", (float)a * 0.5f);
		}
	}

	}