using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ShooterScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242331 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ShooterScript _0024self__00242332;

			public _0024(ShooterScript self_)
			{
				_0024self__00242332 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_009e: Expected O, but got Unknown
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Expected O, but got Unknown
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected O, but got Unknown
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b6: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						((MonoBehaviour)_0024self__00242332).StartCoroutine_Auto(_0024self__00242332.Attack());
						((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
						goto case 1;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 5) * 0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242332.@base.animation.Play("i");
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(0, 4) * 0.5f)) ? 1 : 0);
					break;
				case 3:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242332.@base.animation.Play("a");
					((Component)_0024self__00242332).audio.PlayOneShot(_0024self__00242332.a);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 5:
					if (MenuScript.multiplayer > 0)
					{
						Object.Instantiate((Object)(object)_0024self__00242332.blade, _0024self__00242332.t.position, Quaternion.identity);
					}
					else
					{
						Object.Instantiate((Object)(object)_0024self__00242332.blade, _0024self__00242332.t.position, Quaternion.identity);
					}
					goto case 3;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ShooterScript _0024self__00242333;

		public _0024Start_00242331(ShooterScript self_)
		{
			_0024self__00242333 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242333);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242334 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ShooterScript _0024self__00242335;

			public _0024(ShooterScript self_)
			{
				_0024self__00242335 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Expected O, but got Unknown
				//IL_00db: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e5: Expected O, but got Unknown
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_0105: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Expected O, but got Unknown
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (Network.isServer)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 5) * 0.5f)) ? 1 : 0);
						break;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 2:
					_0024self__00242335.@base.animation.Play("i");
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(0, 4) * 0.5f)) ? 1 : 0);
					break;
				case 3:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242335.@base.animation.Play("a");
					((Component)_0024self__00242335).audio.PlayOneShot(_0024self__00242335.a);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 5:
					Network.Instantiate((Object)(object)_0024self__00242335.blade, _0024self__00242335.t.position, Quaternion.identity, 0);
					goto case 3;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ShooterScript _0024self__00242336;

		public _0024Attack_00242334(ShooterScript self_)
		{
			_0024self__00242336 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242336);
		}
	}

	public GameObject @base;

	public GameObject blade;

	public AudioClip a;

	private Transform t;

	public override void OnDestroy()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer > 0)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
		}
	}

	public override void Awake()
	{
		@base.animation["i"].layer = 0;
		@base.animation["a"].layer = 1;
		t = ((Component)this).transform;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242331(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator Attack()
	{
		return new _0024Attack_00242334(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
