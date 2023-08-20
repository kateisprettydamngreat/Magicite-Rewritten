using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class VineScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242695 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242696;

			internal int _0024num_00242697;

			internal VineScript _0024self__00242698;

			public _0024(VineScript self_)
			{
				_0024self__00242698 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00242696 = default(int);
					_0024i_00242696 = 0;
					goto IL_00b0;
				case 2:
					_0024i_00242696++;
					goto IL_00b0;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00b0:
					if (_0024i_00242696 < 3)
					{
						_0024self__00242698.@base[_0024i_00242696].GetComponent<Animation>()["i"].speed = 0.5f;
						_0024self__00242698.@base[_0024i_00242696].GetComponent<Animation>().Play();
						_0024num_00242697 = UnityEngine.Random.Range(1, 5);
						result = (Yield(2, new WaitForSeconds((float)_0024num_00242697 * 0.5f)) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal VineScript _0024self__00242699;

		public _0024Start_00242695(VineScript self_)
		{
			_0024self__00242699 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242699);
		}
	}

	public GameObject[] @base;

	public VineScript()
	{
		@base = new GameObject[3];
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242695(this).GetEnumerator();
	}

	}