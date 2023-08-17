using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SummonSkeleton : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00242874 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SummonSkeleton _0024self__00242875;

			public _0024(SummonSkeleton self_)
			{
				_0024self__00242875 = self_;
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
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)_0024self__00242875.waitt)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						Network.RemoveRPCs(((Component)_0024self__00242875).networkView.viewID);
						Network.Destroy(((Component)_0024self__00242875).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00242875).gameObject);
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

		internal SummonSkeleton _0024self__00242876;

		public _0024Die_00242874(SummonSkeleton self_)
		{
			_0024self__00242876 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242876);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HitN_00242877 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241060_00242878;

			internal Quaternion _0024_00241061_00242879;

			internal int _0024_00241062_00242880;

			internal Quaternion _0024_00241063_00242881;

			internal int _0024_00241064_00242882;

			internal Quaternion _0024_00241065_00242883;

			internal int _0024_00241066_00242884;

			internal Quaternion _0024_00241067_00242885;

			internal SummonSkeleton _0024self__00242886;

			public _0024(SummonSkeleton self_)
			{
				_0024self__00242886 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_0105: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0301: Unknown result type (might be due to invalid IL or missing references)
				//IL_0306: Unknown result type (might be due to invalid IL or missing references)
				//IL_030b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0316: Unknown result type (might be due to invalid IL or missing references)
				//IL_0214: Unknown result type (might be due to invalid IL or missing references)
				//IL_0219: Unknown result type (might be due to invalid IL or missing references)
				//IL_0421: Unknown result type (might be due to invalid IL or missing references)
				//IL_042b: Expected O, but got Unknown
				//IL_0342: Unknown result type (might be due to invalid IL or missing references)
				//IL_0347: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02da: Unknown result type (might be due to invalid IL or missing references)
				//IL_02db: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_023f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0244: Unknown result type (might be due to invalid IL or missing references)
				//IL_0245: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Unknown result type (might be due to invalid IL or missing references)
				//IL_024b: Unknown result type (might be due to invalid IL or missing references)
				//IL_026f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0274: Unknown result type (might be due to invalid IL or missing references)
				//IL_0275: Unknown result type (might be due to invalid IL or missing references)
				//IL_027c: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03db: Unknown result type (might be due to invalid IL or missing references)
				//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_03de: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_040a: Unknown result type (might be due to invalid IL or missing references)
				//IL_040f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0410: Unknown result type (might be due to invalid IL or missing references)
				//IL_0417: Unknown result type (might be due to invalid IL or missing references)
				//IL_0370: Unknown result type (might be due to invalid IL or missing references)
				//IL_0375: Unknown result type (might be due to invalid IL or missing references)
				//IL_0376: Unknown result type (might be due to invalid IL or missing references)
				//IL_0378: Unknown result type (might be due to invalid IL or missing references)
				//IL_037d: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242886).networkView.isMine)
					{
						goto case 2;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 2:
					_0024self__00242886.ray = new Ray(_0024self__00242886.t.position, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242886.ray, ref _0024self__00242886.hit, 3f, 512) && (((Component)((RaycastHit)(ref _0024self__00242886.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242886.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242886.hit)).transform).gameObject.SendMessage("TD", (object)_0024self__00242886.DOOD);
					}
					_0024self__00242886.ray = new Ray(_0024self__00242886.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242886.ray, ref _0024self__00242886.hit, 3f, 512) && (((Component)((RaycastHit)(ref _0024self__00242886.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242886.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242886.hit)).transform).gameObject.SendMessage("TD", (object)_0024self__00242886.DOOD);
					}
					_0024self__00242886.ray = new Ray(_0024self__00242886.t.position, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242886.ray, ref _0024self__00242886.hit, 3f, 2048))
					{
						if (_0024self__00242886.t.rotation.y <= 0f)
						{
							int num = (_0024_00241062_00242880 = 180);
							Quaternion val = (_0024_00241063_00242881 = _0024self__00242886.t.rotation);
							float num2 = (_0024_00241063_00242881.y = _0024_00241062_00242880);
							Quaternion val3 = (_0024self__00242886.t.rotation = _0024_00241063_00242881);
						}
						else
						{
							int num3 = (_0024_00241060_00242878 = 0);
							Quaternion val4 = (_0024_00241061_00242879 = _0024self__00242886.t.rotation);
							float num4 = (_0024_00241061_00242879.y = _0024_00241060_00242878);
							Quaternion val6 = (_0024self__00242886.t.rotation = _0024_00241061_00242879);
						}
					}
					_0024self__00242886.ray = new Ray(_0024self__00242886.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242886.ray, ref _0024self__00242886.hit, 3f, 2048))
					{
						if (_0024self__00242886.t.rotation.y <= 0f)
						{
							int num5 = (_0024_00241066_00242884 = 180);
							Quaternion val7 = (_0024_00241067_00242885 = _0024self__00242886.t.rotation);
							float num6 = (_0024_00241067_00242885.y = _0024_00241066_00242884);
							Quaternion val9 = (_0024self__00242886.t.rotation = _0024_00241067_00242885);
						}
						else
						{
							int num7 = (_0024_00241064_00242882 = 0);
							Quaternion val10 = (_0024_00241065_00242883 = _0024self__00242886.t.rotation);
							float num8 = (_0024_00241065_00242883.y = _0024_00241064_00242882);
							Quaternion val12 = (_0024self__00242886.t.rotation = _0024_00241065_00242883);
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

		internal SummonSkeleton _0024self__00242887;

		public _0024HitN_00242877(SummonSkeleton self_)
		{
			_0024self__00242887 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242887);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Hit_00242888 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241068_00242889;

			internal Quaternion _0024_00241069_00242890;

			internal int _0024_00241070_00242891;

			internal Quaternion _0024_00241071_00242892;

			internal int _0024_00241072_00242893;

			internal Quaternion _0024_00241073_00242894;

			internal int _0024_00241074_00242895;

			internal Quaternion _0024_00241075_00242896;

			internal SummonSkeleton _0024self__00242897;

			public _0024(SummonSkeleton self_)
			{
				_0024self__00242897 = self_;
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
				//IL_0167: Unknown result type (might be due to invalid IL or missing references)
				//IL_0172: Unknown result type (might be due to invalid IL or missing references)
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_017c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Unknown result type (might be due to invalid IL or missing references)
				//IL_0235: Unknown result type (might be due to invalid IL or missing references)
				//IL_023a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0245: Unknown result type (might be due to invalid IL or missing references)
				//IL_0357: Unknown result type (might be due to invalid IL or missing references)
				//IL_0362: Unknown result type (might be due to invalid IL or missing references)
				//IL_0367: Unknown result type (might be due to invalid IL or missing references)
				//IL_036c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0377: Unknown result type (might be due to invalid IL or missing references)
				//IL_0271: Unknown result type (might be due to invalid IL or missing references)
				//IL_0276: Unknown result type (might be due to invalid IL or missing references)
				//IL_0482: Unknown result type (might be due to invalid IL or missing references)
				//IL_048c: Expected O, but got Unknown
				//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0302: Unknown result type (might be due to invalid IL or missing references)
				//IL_0307: Unknown result type (might be due to invalid IL or missing references)
				//IL_0308: Unknown result type (might be due to invalid IL or missing references)
				//IL_030a: Unknown result type (might be due to invalid IL or missing references)
				//IL_030f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0336: Unknown result type (might be due to invalid IL or missing references)
				//IL_033b: Unknown result type (might be due to invalid IL or missing references)
				//IL_033c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0343: Unknown result type (might be due to invalid IL or missing references)
				//IL_029c: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0437: Unknown result type (might be due to invalid IL or missing references)
				//IL_043c: Unknown result type (might be due to invalid IL or missing references)
				//IL_043d: Unknown result type (might be due to invalid IL or missing references)
				//IL_043f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0444: Unknown result type (might be due to invalid IL or missing references)
				//IL_046b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0470: Unknown result type (might be due to invalid IL or missing references)
				//IL_0471: Unknown result type (might be due to invalid IL or missing references)
				//IL_0478: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03de: Unknown result type (might be due to invalid IL or missing references)
				//IL_0405: Unknown result type (might be due to invalid IL or missing references)
				//IL_040a: Unknown result type (might be due to invalid IL or missing references)
				//IL_040b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0412: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						if (((Component)_0024self__00242897).networkView.isMine)
						{
							((MonoBehaviour)_0024self__00242897).StartCoroutine_Auto(_0024self__00242897.HitN());
						}
						((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
						goto case 1;
					}
					goto case 2;
				case 2:
					_0024self__00242897.newPos = new Vector3(_0024self__00242897.t.position.x, _0024self__00242897.t.position.y - 1f, 0f);
					_0024self__00242897.ray = new Ray(_0024self__00242897.newPos, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242897.ray, ref _0024self__00242897.hit, 5f, 512) && (((Component)((RaycastHit)(ref _0024self__00242897.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242897.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242897.hit)).transform).gameObject.SendMessage("TD", (object)_0024self__00242897.DOOD);
					}
					_0024self__00242897.ray = new Ray(_0024self__00242897.newPos, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242897.ray, ref _0024self__00242897.hit, 5f, 512) && (((Component)((RaycastHit)(ref _0024self__00242897.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242897.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242897.hit)).transform).gameObject.SendMessage("TD", (object)_0024self__00242897.DOOD);
					}
					_0024self__00242897.ray = new Ray(_0024self__00242897.newPos, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242897.ray, ref _0024self__00242897.hit, 3f, 2048))
					{
						if (_0024self__00242897.t.rotation.y <= 0f)
						{
							int num = (_0024_00241070_00242891 = 180);
							Quaternion val = (_0024_00241071_00242892 = _0024self__00242897.t.rotation);
							float num2 = (_0024_00241071_00242892.y = _0024_00241070_00242891);
							Quaternion val3 = (_0024self__00242897.t.rotation = _0024_00241071_00242892);
						}
						else
						{
							int num3 = (_0024_00241068_00242889 = 0);
							Quaternion val4 = (_0024_00241069_00242890 = _0024self__00242897.t.rotation);
							float num4 = (_0024_00241069_00242890.y = _0024_00241068_00242889);
							Quaternion val6 = (_0024self__00242897.t.rotation = _0024_00241069_00242890);
						}
					}
					_0024self__00242897.ray = new Ray(_0024self__00242897.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242897.ray, ref _0024self__00242897.hit, 3f, 2048))
					{
						if (_0024self__00242897.t.rotation.y <= 0f)
						{
							int num5 = (_0024_00241074_00242895 = 180);
							Quaternion val7 = (_0024_00241075_00242896 = _0024self__00242897.t.rotation);
							float num6 = (_0024_00241075_00242896.y = _0024_00241074_00242895);
							Quaternion val9 = (_0024self__00242897.t.rotation = _0024_00241075_00242896);
						}
						else
						{
							int num7 = (_0024_00241072_00242893 = 0);
							Quaternion val10 = (_0024_00241073_00242894 = _0024self__00242897.t.rotation);
							float num8 = (_0024_00241073_00242894.y = _0024_00241072_00242893);
							Quaternion val12 = (_0024self__00242897.t.rotation = _0024_00241073_00242894);
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

		internal SummonSkeleton _0024self__00242898;

		public _0024Hit_00242888(SummonSkeleton self_)
		{
			_0024self__00242898 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242898);
		}
	}

	public bool isZombie;

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

	private int DOOD;

	public SummonSkeleton()
	{
		HP = 20;
		waitt = 16;
		DOOD = 1;
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
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if (isZombie)
		{
			DOOD = 5;
		}
		r = ((Component)this).rigidbody;
		t = ((Component)this).transform;
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
		return new _0024Die_00242874(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		newPos = new Vector3(t.position.x, t.position.y - 1f, 0f);
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
			int num = 8;
			Vector3 velocity = ((Component)this).rigidbody.velocity;
			float num2 = (velocity.x = num);
			Vector3 val2 = (((Component)this).rigidbody.velocity = velocity);
		}
		else
		{
			int num3 = -8;
			Vector3 velocity2 = ((Component)this).rigidbody.velocity;
			float num4 = (velocity2.x = num3);
			Vector3 val4 = (((Component)this).rigidbody.velocity = velocity2);
		}
	}

	public override IEnumerator HitN()
	{
		return new _0024HitN_00242877(this).GetEnumerator();
	}

	public override IEnumerator Hit()
	{
		return new _0024Hit_00242888(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
