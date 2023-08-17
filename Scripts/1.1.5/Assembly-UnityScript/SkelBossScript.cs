using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SkelBossScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242647 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242648;

			internal SkelBossScript _0024self__00242649;

			public _0024(SkelBossScript self_)
			{
				_0024self__00242649 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242649.@base.animation["i"].layer = 0;
					_0024self__00242649.@base.animation["r"].layer = 0;
					_0024self__00242649.@base.animation["a"].layer = 1;
					_0024drops_00242648 = new int[3] { 7, 18, 0 };
					_0024self__00242649.SetStats(20, 1, 1, 3, 0f, _0024drops_00242648, Random.Range(2, 6), 6);
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242649).StartCoroutine_Auto(_0024self__00242649.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SkelBossScript _0024self__00242650;

		public _0024Start_00242647(SkelBossScript self_)
		{
			_0024self__00242650 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242650);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242651 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00242652;

			internal Ray _0024ray2_00242653;

			internal int _0024num_00242654;

			internal int _0024_0024988_00242655;

			internal Vector3 _0024_0024989_00242656;

			internal int _0024_0024990_00242657;

			internal Vector3 _0024_0024991_00242658;

			internal int _0024_0024992_00242659;

			internal Vector3 _0024_0024993_00242660;

			internal SkelBossScript _0024self__00242661;

			public _0024(SkelBossScript self_)
			{
				_0024self__00242661 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0090: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0201: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_022a: Unknown result type (might be due to invalid IL or missing references)
				//IL_022b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_023a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0244: Expected O, but got Unknown
				//IL_038a: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0404: Expected O, but got Unknown
				//IL_0411: Unknown result type (might be due to invalid IL or missing references)
				//IL_041b: Expected O, but got Unknown
				//IL_0445: Unknown result type (might be due to invalid IL or missing references)
				//IL_044a: Unknown result type (might be due to invalid IL or missing references)
				//IL_044b: Unknown result type (might be due to invalid IL or missing references)
				//IL_044d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0452: Unknown result type (might be due to invalid IL or missing references)
				//IL_0479: Unknown result type (might be due to invalid IL or missing references)
				//IL_047e: Unknown result type (might be due to invalid IL or missing references)
				//IL_047f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0486: Unknown result type (might be due to invalid IL or missing references)
				//IL_024f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0156: Unknown result type (might be due to invalid IL or missing references)
				//IL_030c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0311: Unknown result type (might be due to invalid IL or missing references)
				//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b4: Expected O, but got Unknown
				//IL_010b: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Expected O, but got Unknown
				//IL_0168: Unknown result type (might be due to invalid IL or missing references)
				//IL_0172: Expected O, but got Unknown
				//IL_0323: Unknown result type (might be due to invalid IL or missing references)
				//IL_032d: Expected O, but got Unknown
				//IL_0365: Unknown result type (might be due to invalid IL or missing references)
				//IL_036f: Expected O, but got Unknown
				//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e1: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024ray_00242652 = new Ray(_0024self__00242661.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00242653 = new Ray(_0024self__00242661.t.position, new Vector3(-1f, 0f, 0f));
					_0024num_00242654 = default(int);
					if (Physics.Raycast(_0024ray_00242652, ref _0024self__00242661.hit, 20f, 256))
					{
						_0024num_00242654 = Random.Range(0, 5);
						if (_0024num_00242654 == 0)
						{
							_0024self__00242661.attacking = true;
							_0024self__00242661.@base.animation.Play("a");
							_0024self__00242661.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242661.attacking = true;
							_0024self__00242661.@base.animation.Play("r");
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
						}
						break;
					}
					if (Physics.Raycast(_0024ray2_00242653, ref _0024self__00242661.hit, 20f, 256))
					{
						_0024num_00242654 = Random.Range(0, 5);
						if (_0024num_00242654 == 0)
						{
							_0024self__00242661.attacking = true;
							_0024self__00242661.@base.animation.Play("a");
							_0024self__00242661.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.7f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242661.attacking = true;
							_0024self__00242661.@base.animation.Play("r");
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(0.5f)) ? 1 : 0);
						}
						break;
					}
					goto case 3;
				case 2:
					if (MenuScript.multiplayer <= 0)
					{
						Object.Instantiate((Object)(object)_0024self__00242661.boneThrowR, _0024self__00242661.t.position, Quaternion.identity);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
				{
					_0024self__00242661.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					int num5 = (_0024_0024988_00242655 = 25);
					Vector3 val7 = (_0024_0024989_00242656 = _0024self__00242661.r.velocity);
					float num6 = (_0024_0024989_00242656.x = _0024_0024988_00242655);
					Vector3 val9 = (_0024self__00242661.r.velocity = _0024_0024989_00242656);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 6:
					if (MenuScript.multiplayer <= 0)
					{
						Object.Instantiate((Object)(object)_0024self__00242661.boneThrowL, _0024self__00242661.t.position, Quaternion.identity);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 8:
				{
					_0024self__00242661.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					int num3 = (_0024_0024990_00242657 = -25);
					Vector3 val4 = (_0024_0024991_00242658 = _0024self__00242661.r.velocity);
					float num4 = (_0024_0024991_00242658.x = _0024_0024990_00242657);
					Vector3 val6 = (_0024self__00242661.r.velocity = _0024_0024991_00242658);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(9, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 3:
				case 5:
				case 7:
				case 9:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(10, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 10:
				{
					_0024self__00242661.attacking = false;
					int num = (_0024_0024992_00242659 = 0);
					Vector3 val = (_0024_0024993_00242660 = _0024self__00242661.r.velocity);
					float num2 = (_0024_0024993_00242660.x = _0024_0024992_00242659);
					Vector3 val3 = (_0024self__00242661.r.velocity = _0024_0024993_00242660);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SkelBossScript _0024self__00242662;

		public _0024AttackCheck_00242651(SkelBossScript self_)
		{
			_0024self__00242662 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242662);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00242663 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242664;

			internal int _0024dir_00242665;

			internal int _0024_0024994_00242666;

			internal Vector3 _0024_0024995_00242667;

			internal SkelBossScript _0024self__00242668;

			public _0024(SkelBossScript self_)
			{
				_0024self__00242668 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_010a: Expected O, but got Unknown
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_009e: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242668.attacking)
					{
						((Component)_0024self__00242668).audio.PlayOneShot(_0024self__00242668.a);
						_0024self__00242668.dir = 0;
						int num = (_0024_0024994_00242666 = 0);
						Vector3 val = (_0024_0024995_00242667 = _0024self__00242668._0024get_rigidbody_00242669().velocity);
						float num2 = (_0024_0024995_00242667.x = _0024_0024994_00242666);
						Vector3 val3 = (_0024self__00242668._0024get_rigidbody_00242670().velocity = _0024_0024995_00242667);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(0, 3))) ? 1 : 0);
						break;
					}
					goto IL_00f7;
				case 2:
					_0024num_00242664 = Random.Range(1, 2);
					_0024dir_00242665 = Random.Range(1, 3);
					_0024self__00242668.moving = false;
					_0024self__00242668.dir = _0024dir_00242665;
					goto IL_00f7;
				case 3:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00f7:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)_0024num_00242664)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SkelBossScript _0024self__00242671;

		public _0024MoveCheck_00242663(SkelBossScript self_)
		{
			_0024self__00242671 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242671);
		}
	}

	private RaycastHit hit;

	public GameObject boneThrowL;

	public GameObject boneThrowR;

	public override IEnumerator Start()
	{
		return new _0024Start_00242647(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242651(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00242663(this).GetEnumerator();
	}

	internal Rigidbody _0024get_rigidbody_00242669()
	{
		return ((Component)this).rigidbody;
	}

	internal Rigidbody _0024get_rigidbody_00242670()
	{
		return ((Component)this).rigidbody;
	}
}
