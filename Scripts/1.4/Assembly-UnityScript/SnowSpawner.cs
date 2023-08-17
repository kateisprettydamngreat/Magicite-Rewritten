using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SnowSpawner : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242791 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242792;

			internal SnowSpawner _0024self__00242793;

			public _0024(SnowSpawner self_)
			{
				_0024self__00242793 = self_;
			}

			public override bool MoveNext()
			{
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Expected O, but got Unknown
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Expected O, but got Unknown
				//IL_0106: Unknown result type (might be due to invalid IL or missing references)
				//IL_010b: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0123: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_0136: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00db: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0146: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242793.t = ((Component)_0024self__00242793).transform;
					if (MenuScript.multiplayer == 1)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 5) * 0.5f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 2:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(0, 5) * 0.5f)) ? 1 : 0);
					break;
				case 3:
				case 4:
					_0024num_00242792 = Random.Range(0, 2);
					if (_0024num_00242792 == 0)
					{
						Network.Instantiate(Resources.Load("rckS1"), new Vector3(_0024self__00242793.t.position.x, _0024self__00242793.t.position.y + 35f, 0f), Quaternion.identity, 0);
					}
					else
					{
						Network.Instantiate(Resources.Load("rckS"), new Vector3(_0024self__00242793.t.position.x, _0024self__00242793.t.position.y + 35f, 0f), Quaternion.identity, 0);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SnowSpawner _0024self__00242794;

		public _0024Start_00242791(SnowSpawner self_)
		{
			_0024self__00242794 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242794);
		}
	}

	private Transform t;

	public override IEnumerator Start()
	{
		return new _0024Start_00242791(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
