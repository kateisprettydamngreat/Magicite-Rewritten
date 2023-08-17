using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FallenKnight : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024T_00241620 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024602_00241621;

			internal Quaternion _0024_0024603_00241622;

			internal int _0024_0024604_00241623;

			internal Quaternion _0024_0024605_00241624;

			internal FallenKnight _0024self__00241625;

			public _0024(FallenKnight self_)
			{
				_0024self__00241625 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_0127: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_015e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0165: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00be: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241625.turning && !_0024self__00241625.ATKING)
					{
						_0024self__00241625.turning = true;
						if (_0024self__00241625.e.transform.rotation.y != 0f)
						{
							int num = (_0024_0024602_00241621 = 0);
							Quaternion val = (_0024_0024603_00241622 = _0024self__00241625.e.transform.rotation);
							float num2 = (_0024_0024603_00241622.y = _0024_0024602_00241621);
							Quaternion val3 = (_0024self__00241625.e.transform.rotation = _0024_0024603_00241622);
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00241625).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
							}
						}
						else
						{
							int num3 = (_0024_0024604_00241623 = 180);
							Quaternion val4 = (_0024_0024605_00241624 = _0024self__00241625.e.transform.rotation);
							float num4 = (_0024_0024605_00241624.y = _0024_0024604_00241623);
							Quaternion val6 = (_0024self__00241625.e.transform.rotation = _0024_0024605_00241624);
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00241625).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
							}
						}
						_0024self__00241625.spd *= -1;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_01cf;
				case 2:
					_0024self__00241625.turning = false;
					goto IL_01cf;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01cf:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal FallenKnight _0024self__00241626;

		public _0024T_00241620(FallenKnight self_)
		{
			_0024self__00241626 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241626);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241627 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024606_00241628;

			internal Quaternion _0024_0024607_00241629;

			internal int _0024_0024608_00241630;

			internal Quaternion _0024_0024609_00241631;

			internal int _0024dir_00241632;

			internal FallenKnight _0024self__00241633;

			public _0024(int dir, FallenKnight self_)
			{
				_0024dir_00241632 = dir;
				_0024self__00241633 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Expected O, but got Unknown
				//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bd: Expected O, but got Unknown
				//IL_0264: Unknown result type (might be due to invalid IL or missing references)
				//IL_026e: Expected O, but got Unknown
				//IL_0350: Unknown result type (might be due to invalid IL or missing references)
				//IL_035a: Expected O, but got Unknown
				//IL_038b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0395: Expected O, but got Unknown
				//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0300: Unknown result type (might be due to invalid IL or missing references)
				//IL_0307: Unknown result type (might be due to invalid IL or missing references)
				//IL_032c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0336: Expected O, but got Unknown
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_024b: Expected O, but got Unknown
				//IL_012b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Unknown result type (might be due to invalid IL or missing references)
				//IL_0137: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0165: Unknown result type (might be due to invalid IL or missing references)
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_016c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Expected O, but got Unknown
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241633.ATKING)
					{
						_0024self__00241633.ATKING = true;
						if (_0024dir_00241632 == 0)
						{
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00241633).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
								((Component)_0024self__00241633).networkView.RPC("Roar", (RPCMode)2, new object[0]);
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1.2f)) ? 1 : 0);
							}
							else
							{
								int num = (_0024_0024606_00241628 = 0);
								Quaternion val = (_0024_0024607_00241629 = _0024self__00241633.e.transform.rotation);
								float num2 = (_0024_0024607_00241629.y = _0024_0024606_00241628);
								Quaternion val3 = (_0024self__00241633.e.transform.rotation = _0024_0024607_00241629);
								_0024self__00241633.@base.animation.Play("a");
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1.2f)) ? 1 : 0);
							}
						}
						else if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00241633).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
							((Component)_0024self__00241633).networkView.RPC("Roar", (RPCMode)2, new object[0]);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(1.2f)) ? 1 : 0);
						}
						else
						{
							int num3 = (_0024_0024608_00241630 = 180);
							Quaternion val4 = (_0024_0024609_00241631 = _0024self__00241633.e.transform.rotation);
							float num4 = (_0024_0024609_00241631.y = _0024_0024608_00241630);
							Quaternion val6 = (_0024self__00241633.e.transform.rotation = _0024_0024609_00241631);
							_0024self__00241633.@base.animation.Play("a");
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(1.2f)) ? 1 : 0);
						}
						break;
					}
					goto IL_03a6;
				case 2:
					_0024self__00241633.spd = -10;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241633.spd = 0;
					_0024self__00241633.@base.animation.Play("i");
					goto IL_0386;
				case 4:
					_0024self__00241633.spd = -10;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241633.spd = 0;
					_0024self__00241633.@base.animation.Play("i");
					goto IL_0386;
				case 6:
					_0024self__00241633.spd = 10;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 7:
					_0024self__00241633.spd = 0;
					_0024self__00241633.@base.animation.Play("i");
					goto IL_0386;
				case 8:
					_0024self__00241633.spd = 10;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(9, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 9:
					_0024self__00241633.spd = 0;
					_0024self__00241633.@base.animation.Play("i");
					goto IL_0386;
				case 10:
					_0024self__00241633.ATKING = false;
					goto IL_03a6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0386:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(10, new WaitForSeconds(1f)) ? 1 : 0);
					break;
					IL_03a6:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dir_00241634;

		internal FallenKnight _0024self__00241635;

		public _0024Attack_00241627(int dir, FallenKnight self_)
		{
			_0024dir_00241634 = dir;
			_0024self__00241635 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dir_00241634, _0024self__00241635);
		}
	}

	private RaycastHit hit;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private int mask;

	private bool ATKING;

	private int spd;

	private bool turning;

	private int mask2;

	private bool rocking;

	public FallenKnight()
	{
		mask = 256;
		mask2 = 2048;
	}

	public override void Start()
	{
		@base.animation["i"].layer = 0;
		@base.animation["r"].layer = 0;
		@base.animation["a"].layer = 1;
		@base.animation["r"].speed = 0.5f;
		@base.animation["a"].speed = 0.2f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(30, 6, 2, 10, 2f, array, Random.Range(10, 25), 10);
	}

	public override void Update()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		int num = spd;
		Vector3 velocity = r.velocity;
		float num2 = (velocity.x = num);
		Vector3 val2 = (r.velocity = velocity);
		((Ray)(ref r1U)).origin = ((Component)this).transform.position;
		((Ray)(ref r1U)).direction = Vector3.left;
		((Ray)(ref r2U)).origin = ((Component)this).transform.position;
		((Ray)(ref r2U)).direction = Vector3.right;
		((Ray)(ref r1D)).origin = ((Component)this).transform.position;
		float y = ((Ray)(ref r1D)).origin.y - 1f;
		Vector3 origin = ((Ray)(ref r1D)).origin;
		float num3 = (origin.y = y);
		Vector3 val4 = (((Ray)(ref r1D)).origin = origin);
		((Ray)(ref r1D)).direction = Vector3.left;
		((Ray)(ref r2D)).origin = ((Component)this).transform.position;
		float y2 = ((Ray)(ref r2D)).origin.y - 1f;
		Vector3 origin2 = ((Ray)(ref r2D)).origin;
		float num4 = (origin2.y = y2);
		Vector3 val6 = (((Ray)(ref r2D)).origin = origin2);
		((Ray)(ref r2D)).direction = Vector3.right;
		if (Physics.Raycast(r1U, 15f, mask) || (Physics.Raycast(r1D, 15f, mask) && !ATKING))
		{
			if (MenuScript.multiplayer > 0)
			{
				if (MenuScript.multiplayer == 1 && !ATKING)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(Attack(0));
				}
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Attack(0));
			}
		}
		if (Physics.Raycast(r2U, 15f, mask) || (Physics.Raycast(r2D, 15f, mask) && !ATKING))
		{
			if (MenuScript.multiplayer > 0)
			{
				if (MenuScript.multiplayer == 1 && !ATKING)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(Attack(1));
				}
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Attack(1));
			}
		}
		if (Physics.Raycast(r1U, 3f, mask2) || (Physics.Raycast(r1D, 3f, mask2) && !turning && e.transform.rotation.y == 0f))
		{
			if (MenuScript.multiplayer > 0)
			{
				if (MenuScript.multiplayer == 1)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(T());
				}
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine_Auto(T());
			}
		}
		if (!Physics.Raycast(r2U, 3f, mask2) && (!Physics.Raycast(r2D, 3f, mask2) || turning || e.transform.rotation.y == 0f))
		{
			return;
		}
		if (MenuScript.multiplayer > 0)
		{
			if (MenuScript.multiplayer == 1)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(T());
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine_Auto(T());
		}
	}

	public override IEnumerator T()
	{
		return new _0024T_00241620(this).GetEnumerator();
	}

	[RPC]
	public override void I()
	{
		@base.animation.Play("i");
	}

	public override IEnumerator Attack(int dir)
	{
		return new _0024Attack_00241627(dir, this).GetEnumerator();
	}

	[RPC]
	public override void Roar()
	{
		@base.animation.Play("a");
	}

	[RPC]
	public override void Turn(int dir)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (dir == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion val2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion val4 = (e.transform.rotation = rotation2);
		}
	}
}
