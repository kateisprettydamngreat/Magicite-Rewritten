using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class WolfScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00242848 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WolfScript _0024self__00242849;

			public _0024(WolfScript self_)
			{
				_0024self__00242849 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Expected O, but got Unknown
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)_0024self__00242849.waitt)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						Network.RemoveRPCs(((Component)_0024self__00242849).networkView.viewID);
						Network.Destroy(((Component)_0024self__00242849).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00242849).gameObject);
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

		internal WolfScript _0024self__00242850;

		public _0024Die_00242848(WolfScript self_)
		{
			_0024self__00242850 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242850);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HitN_00242851 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241071_00242852;

			internal Quaternion _0024_00241072_00242853;

			internal int _0024_00241073_00242854;

			internal Quaternion _0024_00241074_00242855;

			internal int _0024_00241075_00242856;

			internal Quaternion _0024_00241076_00242857;

			internal int _0024_00241077_00242858;

			internal Quaternion _0024_00241078_00242859;

			internal WolfScript _0024self__00242860;

			public _0024(WolfScript self_)
			{
				_0024self__00242860 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_009c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0168: Unknown result type (might be due to invalid IL or missing references)
				//IL_0209: Unknown result type (might be due to invalid IL or missing references)
				//IL_0214: Unknown result type (might be due to invalid IL or missing references)
				//IL_0219: Unknown result type (might be due to invalid IL or missing references)
				//IL_021e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0229: Unknown result type (might be due to invalid IL or missing references)
				//IL_033b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0346: Unknown result type (might be due to invalid IL or missing references)
				//IL_034b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0350: Unknown result type (might be due to invalid IL or missing references)
				//IL_035b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0255: Unknown result type (might be due to invalid IL or missing references)
				//IL_025a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0466: Unknown result type (might be due to invalid IL or missing references)
				//IL_0470: Expected O, but got Unknown
				//IL_0387: Unknown result type (might be due to invalid IL or missing references)
				//IL_038c: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_031a: Unknown result type (might be due to invalid IL or missing references)
				//IL_031f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0320: Unknown result type (might be due to invalid IL or missing references)
				//IL_0327: Unknown result type (might be due to invalid IL or missing references)
				//IL_0280: Unknown result type (might be due to invalid IL or missing references)
				//IL_0285: Unknown result type (might be due to invalid IL or missing references)
				//IL_0286: Unknown result type (might be due to invalid IL or missing references)
				//IL_0288: Unknown result type (might be due to invalid IL or missing references)
				//IL_028d: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_041b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0420: Unknown result type (might be due to invalid IL or missing references)
				//IL_0421: Unknown result type (might be due to invalid IL or missing references)
				//IL_0423: Unknown result type (might be due to invalid IL or missing references)
				//IL_0428: Unknown result type (might be due to invalid IL or missing references)
				//IL_044f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0454: Unknown result type (might be due to invalid IL or missing references)
				//IL_0455: Unknown result type (might be due to invalid IL or missing references)
				//IL_045c: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242860).networkView.isMine)
					{
						goto case 2;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 2:
					_0024self__00242860.newPos = new Vector3(_0024self__00242860.t.position.x, _0024self__00242860.t.position.y - 1f, 0f);
					_0024self__00242860.ray = new Ray(_0024self__00242860.t.position, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242860.ray, ref _0024self__00242860.hit, 2.5f) && (((Component)((RaycastHit)(ref _0024self__00242860.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242860.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242860.hit)).transform).gameObject.SendMessage("TD", (object)_0024self__00242860.ATK);
					}
					_0024self__00242860.ray = new Ray(_0024self__00242860.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242860.ray, ref _0024self__00242860.hit, 2.5f) && (((Component)((RaycastHit)(ref _0024self__00242860.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242860.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242860.hit)).transform).gameObject.SendMessage("TD", (object)_0024self__00242860.ATK);
					}
					_0024self__00242860.ray = new Ray(_0024self__00242860.t.position, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242860.ray, ref _0024self__00242860.hit, 3f, 2048))
					{
						if (_0024self__00242860.t.rotation.y <= 0f)
						{
							int num = (_0024_00241073_00242854 = 180);
							Quaternion val = (_0024_00241074_00242855 = _0024self__00242860.t.rotation);
							float num2 = (_0024_00241074_00242855.y = _0024_00241073_00242854);
							Quaternion val3 = (_0024self__00242860.t.rotation = _0024_00241074_00242855);
						}
						else
						{
							int num3 = (_0024_00241071_00242852 = 0);
							Quaternion val4 = (_0024_00241072_00242853 = _0024self__00242860.t.rotation);
							float num4 = (_0024_00241072_00242853.y = _0024_00241071_00242852);
							Quaternion val6 = (_0024self__00242860.t.rotation = _0024_00241072_00242853);
						}
					}
					_0024self__00242860.ray = new Ray(_0024self__00242860.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242860.ray, ref _0024self__00242860.hit, 3f, 2048))
					{
						if (_0024self__00242860.t.rotation.y <= 0f)
						{
							int num5 = (_0024_00241077_00242858 = 180);
							Quaternion val7 = (_0024_00241078_00242859 = _0024self__00242860.t.rotation);
							float num6 = (_0024_00241078_00242859.y = _0024_00241077_00242858);
							Quaternion val9 = (_0024self__00242860.t.rotation = _0024_00241078_00242859);
						}
						else
						{
							int num7 = (_0024_00241075_00242856 = 0);
							Quaternion val10 = (_0024_00241076_00242857 = _0024self__00242860.t.rotation);
							float num8 = (_0024_00241076_00242857.y = _0024_00241075_00242856);
							Quaternion val12 = (_0024self__00242860.t.rotation = _0024_00241076_00242857);
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal WolfScript _0024self__00242861;

		public _0024HitN_00242851(WolfScript self_)
		{
			_0024self__00242861 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242861);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Hit_00242862 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241079_00242863;

			internal Quaternion _0024_00241080_00242864;

			internal int _0024_00241081_00242865;

			internal Quaternion _0024_00241082_00242866;

			internal int _0024_00241083_00242867;

			internal Quaternion _0024_00241084_00242868;

			internal int _0024_00241085_00242869;

			internal Quaternion _0024_00241086_00242870;

			internal WolfScript _0024self__00242871;

			public _0024(WolfScript self_)
			{
				_0024self__00242871 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00be: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_016b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0170: Unknown result type (might be due to invalid IL or missing references)
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_021d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0222: Unknown result type (might be due to invalid IL or missing references)
				//IL_022d: Unknown result type (might be due to invalid IL or missing references)
				//IL_033f: Unknown result type (might be due to invalid IL or missing references)
				//IL_034a: Unknown result type (might be due to invalid IL or missing references)
				//IL_034f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0354: Unknown result type (might be due to invalid IL or missing references)
				//IL_035f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0259: Unknown result type (might be due to invalid IL or missing references)
				//IL_025e: Unknown result type (might be due to invalid IL or missing references)
				//IL_046a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0474: Expected O, but got Unknown
				//IL_038b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0390: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_031e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0323: Unknown result type (might be due to invalid IL or missing references)
				//IL_0324: Unknown result type (might be due to invalid IL or missing references)
				//IL_032b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0284: Unknown result type (might be due to invalid IL or missing references)
				//IL_0289: Unknown result type (might be due to invalid IL or missing references)
				//IL_028a: Unknown result type (might be due to invalid IL or missing references)
				//IL_028c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0291: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_02be: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_041f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0424: Unknown result type (might be due to invalid IL or missing references)
				//IL_0425: Unknown result type (might be due to invalid IL or missing references)
				//IL_0427: Unknown result type (might be due to invalid IL or missing references)
				//IL_042c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0453: Unknown result type (might be due to invalid IL or missing references)
				//IL_0458: Unknown result type (might be due to invalid IL or missing references)
				//IL_0459: Unknown result type (might be due to invalid IL or missing references)
				//IL_0460: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03be: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						if (((Component)_0024self__00242871).networkView.isMine)
						{
							((MonoBehaviour)_0024self__00242871).StartCoroutine_Auto(_0024self__00242871.HitN());
						}
						((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
						goto case 1;
					}
					goto case 2;
				case 2:
					_0024self__00242871.newPos = new Vector3(_0024self__00242871.t.position.x, _0024self__00242871.t.position.y - 1f, 0f);
					_0024self__00242871.ray = new Ray(_0024self__00242871.newPos, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242871.ray, ref _0024self__00242871.hit, 2.5f) && (((Component)((RaycastHit)(ref _0024self__00242871.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242871.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242871.hit)).transform).gameObject.SendMessage("TD", (object)1);
					}
					_0024self__00242871.ray = new Ray(_0024self__00242871.newPos, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242871.ray, ref _0024self__00242871.hit, 2.5f) && (((Component)((RaycastHit)(ref _0024self__00242871.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242871.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242871.hit)).transform).gameObject.SendMessage("TD", (object)1);
					}
					_0024self__00242871.ray = new Ray(_0024self__00242871.newPos, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242871.ray, ref _0024self__00242871.hit, 3f, 2048))
					{
						if (_0024self__00242871.t.rotation.y <= 0f)
						{
							int num = (_0024_00241081_00242865 = 180);
							Quaternion val = (_0024_00241082_00242866 = _0024self__00242871.t.rotation);
							float num2 = (_0024_00241082_00242866.y = _0024_00241081_00242865);
							Quaternion val3 = (_0024self__00242871.t.rotation = _0024_00241082_00242866);
						}
						else
						{
							int num3 = (_0024_00241079_00242863 = 0);
							Quaternion val4 = (_0024_00241080_00242864 = _0024self__00242871.t.rotation);
							float num4 = (_0024_00241080_00242864.y = _0024_00241079_00242863);
							Quaternion val6 = (_0024self__00242871.t.rotation = _0024_00241080_00242864);
						}
					}
					_0024self__00242871.ray = new Ray(_0024self__00242871.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242871.ray, ref _0024self__00242871.hit, 3f, 2048))
					{
						if (_0024self__00242871.t.rotation.y <= 0f)
						{
							int num5 = (_0024_00241085_00242869 = 180);
							Quaternion val7 = (_0024_00241086_00242870 = _0024self__00242871.t.rotation);
							float num6 = (_0024_00241086_00242870.y = _0024_00241085_00242869);
							Quaternion val9 = (_0024self__00242871.t.rotation = _0024_00241086_00242870);
						}
						else
						{
							int num7 = (_0024_00241083_00242867 = 0);
							Quaternion val10 = (_0024_00241084_00242868 = _0024self__00242871.t.rotation);
							float num8 = (_0024_00241084_00242868.y = _0024_00241083_00242867);
							Quaternion val12 = (_0024self__00242871.t.rotation = _0024_00241084_00242868);
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal WolfScript _0024self__00242872;

		public _0024Hit_00242862(WolfScript self_)
		{
			_0024self__00242872 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242872);
		}
	}

	public GameObject @base;

	public GameObject e;

	private Ray ray;

	private RaycastHit hit;

	private Transform t;

	private Rigidbody r;

	private int HP;

	private int ATK;

	private int DEX;

	private bool left;

	private Vector3 newPos;

	private int waitt;

	public WolfScript()
	{
		HP = 20;
		waitt = 10;
	}

	public override void Set(int dex)
	{
		DEX = dex;
		waitt = (int)((float)waitt + (float)DEX * 0.7f);
		ATK = (int)((float)DEX * 0.5f);
	}

	[RPC]
	public override void SetN(int dex)
	{
		DEX = dex;
		waitt = (int)((float)waitt + (float)DEX * 0.7f);
		ATK = (int)((float)DEX * 0.5f);
	}

	public override void Awake()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		r = ((Component)this).rigidbody;
		t = ((Component)this).transform;
		@base.animation["i"].layer = 1;
		@base.animation["a"].layer = 1;
		int num = 15;
		Vector3 velocity = r.velocity;
		float num2 = (velocity.y = num);
		Vector3 val2 = (r.velocity = velocity);
		((MonoBehaviour)this).StartCoroutine_Auto(Hit());
		((MonoBehaviour)this).StartCoroutine_Auto(Die());
	}

	public override IEnumerator Die()
	{
		return new _0024Die_00242848(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (t.rotation.y == 0f)
		{
			left = true;
		}
		else
		{
			left = false;
		}
		if (left)
		{
			int num = 13;
			Vector3 velocity = ((Component)this).rigidbody.velocity;
			float num2 = (velocity.x = num);
			Vector3 val2 = (((Component)this).rigidbody.velocity = velocity);
		}
		else
		{
			int num3 = -13;
			Vector3 velocity2 = ((Component)this).rigidbody.velocity;
			float num4 = (velocity2.x = num3);
			Vector3 val4 = (((Component)this).rigidbody.velocity = velocity2);
		}
	}

	public override IEnumerator HitN()
	{
		return new _0024HitN_00242851(this).GetEnumerator();
	}

	public override IEnumerator Hit()
	{
		return new _0024Hit_00242862(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
