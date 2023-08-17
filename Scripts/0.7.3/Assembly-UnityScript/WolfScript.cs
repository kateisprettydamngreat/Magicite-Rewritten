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
	internal sealed class _0024Die_00242422 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WolfScript _0024self__00242423;

			public _0024(WolfScript self_)
			{
				_0024self__00242423 = self_;
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
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)_0024self__00242423.waitt)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						Network.RemoveRPCs(((Component)_0024self__00242423).networkView.viewID);
						Network.Destroy(((Component)_0024self__00242423).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00242423).gameObject);
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

		internal WolfScript _0024self__00242424;

		public _0024Die_00242422(WolfScript self_)
		{
			_0024self__00242424 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242424);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HitN_00242425 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024925_00242426;

			internal Quaternion _0024_0024926_00242427;

			internal int _0024_0024927_00242428;

			internal Quaternion _0024_0024928_00242429;

			internal int _0024_0024929_00242430;

			internal Quaternion _0024_0024930_00242431;

			internal int _0024_0024931_00242432;

			internal Quaternion _0024_0024932_00242433;

			internal WolfScript _0024self__00242434;

			public _0024(WolfScript self_)
			{
				_0024self__00242434 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0149: Unknown result type (might be due to invalid IL or missing references)
				//IL_014e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_015e: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0205: Unknown result type (might be due to invalid IL or missing references)
				//IL_020a: Unknown result type (might be due to invalid IL or missing references)
				//IL_020f: Unknown result type (might be due to invalid IL or missing references)
				//IL_021a: Unknown result type (might be due to invalid IL or missing references)
				//IL_032c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0337: Unknown result type (might be due to invalid IL or missing references)
				//IL_033c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0341: Unknown result type (might be due to invalid IL or missing references)
				//IL_034c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Unknown result type (might be due to invalid IL or missing references)
				//IL_024b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0457: Unknown result type (might be due to invalid IL or missing references)
				//IL_0461: Expected O, but got Unknown
				//IL_0378: Unknown result type (might be due to invalid IL or missing references)
				//IL_037d: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_02df: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_030b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0310: Unknown result type (might be due to invalid IL or missing references)
				//IL_0311: Unknown result type (might be due to invalid IL or missing references)
				//IL_0318: Unknown result type (might be due to invalid IL or missing references)
				//IL_0271: Unknown result type (might be due to invalid IL or missing references)
				//IL_0276: Unknown result type (might be due to invalid IL or missing references)
				//IL_0277: Unknown result type (might be due to invalid IL or missing references)
				//IL_0279: Unknown result type (might be due to invalid IL or missing references)
				//IL_027e: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_040c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0411: Unknown result type (might be due to invalid IL or missing references)
				//IL_0412: Unknown result type (might be due to invalid IL or missing references)
				//IL_0414: Unknown result type (might be due to invalid IL or missing references)
				//IL_0419: Unknown result type (might be due to invalid IL or missing references)
				//IL_0440: Unknown result type (might be due to invalid IL or missing references)
				//IL_0445: Unknown result type (might be due to invalid IL or missing references)
				//IL_0446: Unknown result type (might be due to invalid IL or missing references)
				//IL_044d: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03da: Unknown result type (might be due to invalid IL or missing references)
				//IL_03df: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242434).networkView.isMine)
					{
						goto case 2;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 2:
					_0024self__00242434.newPos = new Vector3(_0024self__00242434.t.position.x, _0024self__00242434.t.position.y - 1f, 0f);
					_0024self__00242434.ray = new Ray(_0024self__00242434.newPos, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242434.ray, ref _0024self__00242434.hit, 2.5f) && (((Component)((RaycastHit)(ref _0024self__00242434.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242434.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242434.hit)).transform).gameObject.SendMessage("TD", (object)_0024self__00242434.ATK);
					}
					_0024self__00242434.ray = new Ray(_0024self__00242434.newPos, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242434.ray, ref _0024self__00242434.hit, 2.5f) && (((Component)((RaycastHit)(ref _0024self__00242434.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242434.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242434.hit)).transform).gameObject.SendMessage("TD", (object)_0024self__00242434.ATK);
					}
					_0024self__00242434.ray = new Ray(_0024self__00242434.newPos, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242434.ray, ref _0024self__00242434.hit, 3f, 2048))
					{
						if (_0024self__00242434.t.rotation.y <= 0f)
						{
							int num = (_0024_0024927_00242428 = 180);
							Quaternion val = (_0024_0024928_00242429 = _0024self__00242434.t.rotation);
							float num2 = (_0024_0024928_00242429.y = _0024_0024927_00242428);
							Quaternion val3 = (_0024self__00242434.t.rotation = _0024_0024928_00242429);
						}
						else
						{
							int num3 = (_0024_0024925_00242426 = 0);
							Quaternion val4 = (_0024_0024926_00242427 = _0024self__00242434.t.rotation);
							float num4 = (_0024_0024926_00242427.y = _0024_0024925_00242426);
							Quaternion val6 = (_0024self__00242434.t.rotation = _0024_0024926_00242427);
						}
					}
					_0024self__00242434.ray = new Ray(_0024self__00242434.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242434.ray, ref _0024self__00242434.hit, 3f, 2048))
					{
						if (_0024self__00242434.t.rotation.y <= 0f)
						{
							int num5 = (_0024_0024931_00242432 = 180);
							Quaternion val7 = (_0024_0024932_00242433 = _0024self__00242434.t.rotation);
							float num6 = (_0024_0024932_00242433.y = _0024_0024931_00242432);
							Quaternion val9 = (_0024self__00242434.t.rotation = _0024_0024932_00242433);
						}
						else
						{
							int num7 = (_0024_0024929_00242430 = 0);
							Quaternion val10 = (_0024_0024930_00242431 = _0024self__00242434.t.rotation);
							float num8 = (_0024_0024930_00242431.y = _0024_0024929_00242430);
							Quaternion val12 = (_0024self__00242434.t.rotation = _0024_0024930_00242431);
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

		internal WolfScript _0024self__00242435;

		public _0024HitN_00242425(WolfScript self_)
		{
			_0024self__00242435 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242435);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Hit_00242436 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024933_00242437;

			internal Quaternion _0024_0024934_00242438;

			internal int _0024_0024935_00242439;

			internal Quaternion _0024_0024936_00242440;

			internal int _0024_0024937_00242441;

			internal Quaternion _0024_0024938_00242442;

			internal int _0024_0024939_00242443;

			internal Quaternion _0024_0024940_00242444;

			internal WolfScript _0024self__00242445;

			public _0024(WolfScript self_)
			{
				_0024self__00242445 = self_;
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
						if (((Component)_0024self__00242445).networkView.isMine)
						{
							((MonoBehaviour)_0024self__00242445).StartCoroutine_Auto(_0024self__00242445.HitN());
						}
						((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
						goto case 1;
					}
					goto case 2;
				case 2:
					_0024self__00242445.newPos = new Vector3(_0024self__00242445.t.position.x, _0024self__00242445.t.position.y - 1f, 0f);
					_0024self__00242445.ray = new Ray(_0024self__00242445.newPos, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242445.ray, ref _0024self__00242445.hit, 2.5f) && (((Component)((RaycastHit)(ref _0024self__00242445.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242445.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242445.hit)).transform).gameObject.SendMessage("TD", (object)1);
					}
					_0024self__00242445.ray = new Ray(_0024self__00242445.newPos, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242445.ray, ref _0024self__00242445.hit, 2.5f) && (((Component)((RaycastHit)(ref _0024self__00242445.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242445.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242445.hit)).transform).gameObject.SendMessage("TD", (object)1);
					}
					_0024self__00242445.ray = new Ray(_0024self__00242445.newPos, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242445.ray, ref _0024self__00242445.hit, 3f, 2048))
					{
						if (_0024self__00242445.t.rotation.y <= 0f)
						{
							int num = (_0024_0024935_00242439 = 180);
							Quaternion val = (_0024_0024936_00242440 = _0024self__00242445.t.rotation);
							float num2 = (_0024_0024936_00242440.y = _0024_0024935_00242439);
							Quaternion val3 = (_0024self__00242445.t.rotation = _0024_0024936_00242440);
						}
						else
						{
							int num3 = (_0024_0024933_00242437 = 0);
							Quaternion val4 = (_0024_0024934_00242438 = _0024self__00242445.t.rotation);
							float num4 = (_0024_0024934_00242438.y = _0024_0024933_00242437);
							Quaternion val6 = (_0024self__00242445.t.rotation = _0024_0024934_00242438);
						}
					}
					_0024self__00242445.ray = new Ray(_0024self__00242445.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242445.ray, ref _0024self__00242445.hit, 3f, 2048))
					{
						if (_0024self__00242445.t.rotation.y <= 0f)
						{
							int num5 = (_0024_0024939_00242443 = 180);
							Quaternion val7 = (_0024_0024940_00242444 = _0024self__00242445.t.rotation);
							float num6 = (_0024_0024940_00242444.y = _0024_0024939_00242443);
							Quaternion val9 = (_0024self__00242445.t.rotation = _0024_0024940_00242444);
						}
						else
						{
							int num7 = (_0024_0024937_00242441 = 0);
							Quaternion val10 = (_0024_0024938_00242442 = _0024self__00242445.t.rotation);
							float num8 = (_0024_0024938_00242442.y = _0024_0024937_00242441);
							Quaternion val12 = (_0024self__00242445.t.rotation = _0024_0024938_00242442);
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

		internal WolfScript _0024self__00242446;

		public _0024Hit_00242436(WolfScript self_)
		{
			_0024self__00242446 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242446);
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
		return new _0024Die_00242422(this).GetEnumerator();
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
		return new _0024HitN_00242425(this).GetEnumerator();
	}

	public override IEnumerator Hit()
	{
		return new _0024Hit_00242436(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
