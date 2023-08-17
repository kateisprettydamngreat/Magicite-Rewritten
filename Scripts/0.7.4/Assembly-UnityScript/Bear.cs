using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Bear : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024T_00241154 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024411_00241155;

			internal Quaternion _0024_0024412_00241156;

			internal int _0024_0024413_00241157;

			internal Quaternion _0024_0024414_00241158;

			internal Bear _0024self__00241159;

			public _0024(Bear self_)
			{
				_0024self__00241159 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0114: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_014e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0155: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ae: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241159.turning)
					{
						_0024self__00241159.turning = true;
						if (_0024self__00241159.e.transform.rotation.y != 0f)
						{
							int num = (_0024_0024411_00241155 = 0);
							Quaternion val = (_0024_0024412_00241156 = _0024self__00241159.e.transform.rotation);
							float num2 = (_0024_0024412_00241156.y = _0024_0024411_00241155);
							Quaternion val3 = (_0024self__00241159.e.transform.rotation = _0024_0024412_00241156);
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00241159).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
							}
						}
						else
						{
							int num3 = (_0024_0024413_00241157 = 180);
							Quaternion val4 = (_0024_0024414_00241158 = _0024self__00241159.e.transform.rotation);
							float num4 = (_0024_0024414_00241158.y = _0024_0024413_00241157);
							Quaternion val6 = (_0024self__00241159.e.transform.rotation = _0024_0024414_00241158);
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00241159).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
							}
						}
						_0024self__00241159.spd *= -1;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_01bf;
				case 2:
					_0024self__00241159.turning = false;
					goto IL_01bf;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01bf:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Bear _0024self__00241160;

		public _0024T_00241154(Bear self_)
		{
			_0024self__00241160 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241160);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241161 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024415_00241162;

			internal Vector3 _0024_0024416_00241163;

			internal int _0024_0024417_00241164;

			internal Quaternion _0024_0024418_00241165;

			internal int _0024_0024419_00241166;

			internal Vector3 _0024_0024420_00241167;

			internal int _0024_0024421_00241168;

			internal Vector3 _0024_0024422_00241169;

			internal int _0024_0024423_00241170;

			internal Quaternion _0024_0024424_00241171;

			internal int _0024_0024425_00241172;

			internal Vector3 _0024_0024426_00241173;

			internal int _0024dir_00241174;

			internal Bear _0024self__00241175;

			public _0024(int dir, Bear self_)
			{
				_0024dir_00241174 = dir;
				_0024self__00241175 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Expected O, but got Unknown
				//IL_020b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0210: Unknown result type (might be due to invalid IL or missing references)
				//IL_0211: Unknown result type (might be due to invalid IL or missing references)
				//IL_0213: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_023f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0244: Unknown result type (might be due to invalid IL or missing references)
				//IL_0245: Unknown result type (might be due to invalid IL or missing references)
				//IL_024c: Unknown result type (might be due to invalid IL or missing references)
				//IL_027b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0285: Expected O, but got Unknown
				//IL_0336: Unknown result type (might be due to invalid IL or missing references)
				//IL_033b: Unknown result type (might be due to invalid IL or missing references)
				//IL_033c: Unknown result type (might be due to invalid IL or missing references)
				//IL_033e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0343: Unknown result type (might be due to invalid IL or missing references)
				//IL_036a: Unknown result type (might be due to invalid IL or missing references)
				//IL_036f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0370: Unknown result type (might be due to invalid IL or missing references)
				//IL_0377: Unknown result type (might be due to invalid IL or missing references)
				//IL_037e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0388: Expected O, but got Unknown
				//IL_0473: Unknown result type (might be due to invalid IL or missing references)
				//IL_0478: Unknown result type (might be due to invalid IL or missing references)
				//IL_0479: Unknown result type (might be due to invalid IL or missing references)
				//IL_047b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0480: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ed: Expected O, but got Unknown
				//IL_03db: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0414: Unknown result type (might be due to invalid IL or missing references)
				//IL_0419: Unknown result type (might be due to invalid IL or missing references)
				//IL_041a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0421: Unknown result type (might be due to invalid IL or missing references)
				//IL_0443: Unknown result type (might be due to invalid IL or missing references)
				//IL_044d: Expected O, but got Unknown
				//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02eb: Expected O, but got Unknown
				//IL_0173: Unknown result type (might be due to invalid IL or missing references)
				//IL_0178: Unknown result type (might be due to invalid IL or missing references)
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0180: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01db: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Expected O, but got Unknown
				//IL_0085: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241175.ATKING)
					{
						_0024self__00241175.ATKING = true;
						if (_0024dir_00241174 == 0)
						{
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00241175).networkView.RPC("Roar", (RPCMode)2, new object[0]);
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
								break;
							}
							int num9 = (_0024_0024417_00241164 = 0);
							Quaternion val13 = (_0024_0024418_00241165 = _0024self__00241175.e.transform.rotation);
							float num10 = (_0024_0024418_00241165.y = _0024_0024417_00241164);
							Quaternion val15 = (_0024self__00241175.e.transform.rotation = _0024_0024418_00241165);
							_0024self__00241175.@base.animation.Play("a");
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
						}
						else if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00241175).networkView.RPC("Roar", (RPCMode)2, new object[0]);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(1f)) ? 1 : 0);
						}
						else
						{
							int num11 = (_0024_0024423_00241170 = 180);
							Quaternion val16 = (_0024_0024424_00241171 = _0024self__00241175.e.transform.rotation);
							float num12 = (_0024_0024424_00241171.y = _0024_0024423_00241170);
							Quaternion val18 = (_0024self__00241175.e.transform.rotation = _0024_0024424_00241171);
							_0024self__00241175.@base.animation.Play("a");
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(8, new WaitForSeconds(1f)) ? 1 : 0);
						}
						break;
					}
					goto IL_0525;
				case 2:
				{
					int num7 = (_0024_0024415_00241162 = Random.Range(10, 30));
					Vector3 val10 = (_0024_0024416_00241163 = ((Component)_0024self__00241175).rigidbody.velocity);
					float num8 = (_0024_0024416_00241163.y = _0024_0024415_00241162);
					Vector3 val12 = (((Component)_0024self__00241175).rigidbody.velocity = _0024_0024416_00241163);
					((Component)_0024self__00241175).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				}
				case 3:
					_0024self__00241175.spd = 0;
					_0024self__00241175.@base.animation.Play("i");
					goto IL_0519;
				case 4:
				{
					int num5 = (_0024_0024419_00241166 = Random.Range(10, 30));
					Vector3 val7 = (_0024_0024420_00241167 = ((Component)_0024self__00241175).rigidbody.velocity);
					float num6 = (_0024_0024420_00241167.y = _0024_0024419_00241166);
					Vector3 val9 = (((Component)_0024self__00241175).rigidbody.velocity = _0024_0024420_00241167);
					_0024self__00241175.@base.animation.Play("r");
					_0024self__00241175.spd = -3;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				}
				case 5:
					_0024self__00241175.spd = 0;
					_0024self__00241175.@base.animation.Play("i");
					goto IL_0519;
				case 6:
				{
					((Component)_0024self__00241175).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
					int num3 = (_0024_0024421_00241168 = Random.Range(10, 30));
					Vector3 val4 = (_0024_0024422_00241169 = ((Component)_0024self__00241175).rigidbody.velocity);
					float num4 = (_0024_0024422_00241169.y = _0024_0024421_00241168);
					Vector3 val6 = (((Component)_0024self__00241175).rigidbody.velocity = _0024_0024422_00241169);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(7, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				}
				case 7:
					_0024self__00241175.spd = 0;
					_0024self__00241175.@base.animation.Play("i");
					goto IL_0519;
				case 8:
				{
					int num = (_0024_0024425_00241172 = Random.Range(10, 30));
					Vector3 val = (_0024_0024426_00241173 = ((Component)_0024self__00241175).rigidbody.velocity);
					float num2 = (_0024_0024426_00241173.y = _0024_0024425_00241172);
					Vector3 val3 = (((Component)_0024self__00241175).rigidbody.velocity = _0024_0024426_00241173);
					_0024self__00241175.spd = 3;
					_0024self__00241175.@base.animation.Play("r");
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(9, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				}
				case 9:
					_0024self__00241175.spd = 0;
					_0024self__00241175.@base.animation.Play("i");
					goto IL_0519;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0519:
					_0024self__00241175.ATKING = false;
					goto IL_0525;
					IL_0525:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dir_00241176;

		internal Bear _0024self__00241177;

		public _0024Attack_00241161(int dir, Bear self_)
		{
			_0024dir_00241176 = dir;
			_0024self__00241177 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dir_00241176, _0024self__00241177);
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

	public Bear()
	{
		mask = 256;
		mask2 = 2048;
	}

	public override void Start()
	{
		@base.animation["i"].layer = 0;
		@base.animation["r"].layer = 0;
		@base.animation["a"].layer = 1;
		@base.animation["r"].speed = 1.75f;
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
		if (Physics.Raycast(r1U, 10f, mask) || (Physics.Raycast(r1D, 10f, mask) && !ATKING))
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
		if (Physics.Raycast(r2U, 10f, mask) || (Physics.Raycast(r2D, 10f, mask) && !ATKING))
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
		if (Physics.Raycast(r1U, 4f, mask2) || (Physics.Raycast(r1D, 4f, mask2) && !turning && e.transform.rotation.y == 0f))
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
		if (!Physics.Raycast(r2U, 4f, mask2) && (!Physics.Raycast(r2D, 4f, mask2) || turning || e.transform.rotation.y == 0f))
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
		return new _0024T_00241154(this).GetEnumerator();
	}

	[RPC]
	public override void I()
	{
		@base.animation.Play("i");
	}

	public override IEnumerator Attack(int dir)
	{
		return new _0024Attack_00241161(dir, this).GetEnumerator();
	}

	[RPC]
	public override void Roar()
	{
		@base.animation.Play("a");
	}

	[RPC]
	public override void Turn(int dir)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
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
			@base.animation.Play("r");
			spd = -3;
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion val4 = (e.transform.rotation = rotation2);
			@base.animation.Play("r");
			spd = 3;
		}
	}
}
