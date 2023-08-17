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
	internal sealed class _0024Start_00242857 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242858;

			internal int _0024num_00242859;

			internal VineScript _0024self__00242860;

			public _0024(VineScript self_)
			{
				_0024self__00242860 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00242858 = default(int);
					_0024i_00242858 = 0;
					goto IL_00b0;
				case 2:
					_0024i_00242858++;
					goto IL_00b0;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00b0:
					if (_0024i_00242858 < 3)
					{
						_0024self__00242860.@base[_0024i_00242858].animation["i"].speed = 0.5f;
						_0024self__00242860.@base[_0024i_00242858].animation.Play();
						_0024num_00242859 = Random.Range(1, 5);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)_0024num_00242859 * 0.5f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal VineScript _0024self__00242861;

		public _0024Start_00242857(VineScript self_)
		{
			_0024self__00242861 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242861);
		}
	}

	public GameObject[] @base;

	public VineScript()
	{
		@base = (GameObject[])(object)new GameObject[3];
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242857(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
