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
	internal sealed class _0024Die_00242741 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SummonSkeleton _0024self__00242742;

			public _0024(SummonSkeleton self_)
			{
				_0024self__00242742 = self_;
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
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)_0024self__00242742.waitt)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						Network.RemoveRPCs(((Component)_0024self__00242742).networkView.viewID);
						Network.Destroy(((Component)_0024self__00242742).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00242742).gameObject);
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

		internal SummonSkeleton _0024self__00242743;

		public _0024Die_00242741(SummonSkeleton self_)
		{
			_0024self__00242743 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242743);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HitN_00242744 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241029_00242745;

			internal Quaternion _0024_00241030_00242746;

			internal int _0024_00241031_00242747;

			internal Quaternion _0024_00241032_00242748;

			internal int _0024_00241033_00242749;

			internal Quaternion _0024_00241034_00242750;

			internal int _0024_00241035_00242751;

			internal Quaternion _0024_00241036_00242752;

			internal SummonSkeleton _0024self__00242753;

			public _0024(SummonSkeleton self_)
			{
				_0024self__00242753 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0106: Unknown result type (might be due to invalid IL or missing references)
				//IL_010b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_011b: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0302: Unknown result type (might be due to invalid IL or missing references)
				//IL_0200: Unknown result type (might be due to invalid IL or missing references)
				//IL_0205: Unknown result type (might be due to invalid IL or missing references)
				//IL_040d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0417: Expected O, but got Unknown
				//IL_032e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0333: Unknown result type (might be due to invalid IL or missing references)
				//IL_028d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0292: Unknown result type (might be due to invalid IL or missing references)
				//IL_0293: Unknown result type (might be due to invalid IL or missing references)
				//IL_0295: Unknown result type (might be due to invalid IL or missing references)
				//IL_029a: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_022b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_0232: Unknown result type (might be due to invalid IL or missing references)
				//IL_0237: Unknown result type (might be due to invalid IL or missing references)
				//IL_025b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0260: Unknown result type (might be due to invalid IL or missing references)
				//IL_0261: Unknown result type (might be due to invalid IL or missing references)
				//IL_0268: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0403: Unknown result type (might be due to invalid IL or missing references)
				//IL_035c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0361: Unknown result type (might be due to invalid IL or missing references)
				//IL_0362: Unknown result type (might be due to invalid IL or missing references)
				//IL_0364: Unknown result type (might be due to invalid IL or missing references)
				//IL_0369: Unknown result type (might be due to invalid IL or missing references)
				//IL_0390: Unknown result type (might be due to invalid IL or missing references)
				//IL_0395: Unknown result type (might be due to invalid IL or missing references)
				//IL_0396: Unknown result type (might be due to invalid IL or missing references)
				//IL_039d: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242753).networkView.isMine)
					{
						goto case 2;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 2:
					_0024self__00242753.ray = new Ray(_0024self__00242753.t.position, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242753.ray, ref _0024self__00242753.hit, 3f, 512) && (((Component)((RaycastHit)(ref _0024self__00242753.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242753.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242753.hit)).transform).gameObject.SendMessage("TD", (object)1);
					}
					_0024self__00242753.ray = new Ray(_0024self__00242753.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242753.ray, ref _0024self__00242753.hit, 3f, 512) && (((Component)((RaycastHit)(ref _0024self__00242753.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242753.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242753.hit)).transform).gameObject.SendMessage("TD", (object)1);
					}
					_0024self__00242753.ray = new Ray(_0024self__00242753.t.position, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242753.ray, ref _0024self__00242753.hit, 3f, 2048))
					{
						if (_0024self__00242753.t.rotation.y <= 0f)
						{
							int num = (_0024_00241031_00242747 = 180);
							Quaternion val = (_0024_00241032_00242748 = _0024self__00242753.t.rotation);
							float num2 = (_0024_00241032_00242748.y = _0024_00241031_00242747);
							Quaternion val3 = (_0024self__00242753.t.rotation = _0024_00241032_00242748);
						}
						else
						{
							int num3 = (_0024_00241029_00242745 = 0);
							Quaternion val4 = (_0024_00241030_00242746 = _0024self__00242753.t.rotation);
							float num4 = (_0024_00241030_00242746.y = _0024_00241029_00242745);
							Quaternion val6 = (_0024self__00242753.t.rotation = _0024_00241030_00242746);
						}
					}
					_0024self__00242753.ray = new Ray(_0024self__00242753.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242753.ray, ref _0024self__00242753.hit, 3f, 2048))
					{
						if (_0024self__00242753.t.rotation.y <= 0f)
						{
							int num5 = (_0024_00241035_00242751 = 180);
							Quaternion val7 = (_0024_00241036_00242752 = _0024self__00242753.t.rotation);
							float num6 = (_0024_00241036_00242752.y = _0024_00241035_00242751);
							Quaternion val9 = (_0024self__00242753.t.rotation = _0024_00241036_00242752);
						}
						else
						{
							int num7 = (_0024_00241033_00242749 = 0);
							Quaternion val10 = (_0024_00241034_00242750 = _0024self__00242753.t.rotation);
							float num8 = (_0024_00241034_00242750.y = _0024_00241033_00242749);
							Quaternion val12 = (_0024self__00242753.t.rotation = _0024_00241034_00242750);
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

		internal SummonSkeleton _0024self__00242754;

		public _0024HitN_00242744(SummonSkeleton self_)
		{
			_0024self__00242754 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242754);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Hit_00242755 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241037_00242756;

			internal Quaternion _0024_00241038_00242757;

			internal int _0024_00241039_00242758;

			internal Quaternion _0024_00241040_00242759;

			internal int _0024_00241041_00242760;

			internal Quaternion _0024_00241042_00242761;

			internal int _0024_00241043_00242762;

			internal Quaternion _0024_00241044_00242763;

			internal SummonSkeleton _0024self__00242764;

			public _0024(SummonSkeleton self_)
			{
				_0024self__00242764 = self_;
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
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0168: Unknown result type (might be due to invalid IL or missing references)
				//IL_016d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0172: Unknown result type (might be due to invalid IL or missing references)
				//IL_017d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0211: Unknown result type (might be due to invalid IL or missing references)
				//IL_021c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0221: Unknown result type (might be due to invalid IL or missing references)
				//IL_0226: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_0343: Unknown result type (might be due to invalid IL or missing references)
				//IL_034e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0353: Unknown result type (might be due to invalid IL or missing references)
				//IL_0358: Unknown result type (might be due to invalid IL or missing references)
				//IL_0363: Unknown result type (might be due to invalid IL or missing references)
				//IL_025d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0262: Unknown result type (might be due to invalid IL or missing references)
				//IL_046e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0478: Expected O, but got Unknown
				//IL_038f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0394: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0322: Unknown result type (might be due to invalid IL or missing references)
				//IL_0327: Unknown result type (might be due to invalid IL or missing references)
				//IL_0328: Unknown result type (might be due to invalid IL or missing references)
				//IL_032f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0288: Unknown result type (might be due to invalid IL or missing references)
				//IL_028d: Unknown result type (might be due to invalid IL or missing references)
				//IL_028e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0290: Unknown result type (might be due to invalid IL or missing references)
				//IL_0295: Unknown result type (might be due to invalid IL or missing references)
				//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0423: Unknown result type (might be due to invalid IL or missing references)
				//IL_0428: Unknown result type (might be due to invalid IL or missing references)
				//IL_0429: Unknown result type (might be due to invalid IL or missing references)
				//IL_042b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0430: Unknown result type (might be due to invalid IL or missing references)
				//IL_0457: Unknown result type (might be due to invalid IL or missing references)
				//IL_045c: Unknown result type (might be due to invalid IL or missing references)
				//IL_045d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0464: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						if (((Component)_0024self__00242764).networkView.isMine)
						{
							((MonoBehaviour)_0024self__00242764).StartCoroutine_Auto(_0024self__00242764.HitN());
						}
						((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
						goto case 1;
					}
					goto case 2;
				case 2:
					_0024self__00242764.newPos = new Vector3(_0024self__00242764.t.position.x, _0024self__00242764.t.position.y - 1f, 0f);
					_0024self__00242764.ray = new Ray(_0024self__00242764.newPos, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242764.ray, ref _0024self__00242764.hit, 5f, 512) && (((Component)((RaycastHit)(ref _0024self__00242764.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242764.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242764.hit)).transform).gameObject.SendMessage("TD", (object)1);
					}
					_0024self__00242764.ray = new Ray(_0024self__00242764.newPos, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242764.ray, ref _0024self__00242764.hit, 5f, 512) && (((Component)((RaycastHit)(ref _0024self__00242764.hit)).transform).gameObject.layer == 9 || ((Component)((RaycastHit)(ref _0024self__00242764.hit)).transform).gameObject.layer == 12))
					{
						((Component)((RaycastHit)(ref _0024self__00242764.hit)).transform).gameObject.SendMessage("TD", (object)1);
					}
					_0024self__00242764.ray = new Ray(_0024self__00242764.newPos, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242764.ray, ref _0024self__00242764.hit, 3f, 2048))
					{
						if (_0024self__00242764.t.rotation.y <= 0f)
						{
							int num = (_0024_00241039_00242758 = 180);
							Quaternion val = (_0024_00241040_00242759 = _0024self__00242764.t.rotation);
							float num2 = (_0024_00241040_00242759.y = _0024_00241039_00242758);
							Quaternion val3 = (_0024self__00242764.t.rotation = _0024_00241040_00242759);
						}
						else
						{
							int num3 = (_0024_00241037_00242756 = 0);
							Quaternion val4 = (_0024_00241038_00242757 = _0024self__00242764.t.rotation);
							float num4 = (_0024_00241038_00242757.y = _0024_00241037_00242756);
							Quaternion val6 = (_0024self__00242764.t.rotation = _0024_00241038_00242757);
						}
					}
					_0024self__00242764.ray = new Ray(_0024self__00242764.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242764.ray, ref _0024self__00242764.hit, 3f, 2048))
					{
						if (_0024self__00242764.t.rotation.y <= 0f)
						{
							int num5 = (_0024_00241043_00242762 = 180);
							Quaternion val7 = (_0024_00241044_00242763 = _0024self__00242764.t.rotation);
							float num6 = (_0024_00241044_00242763.y = _0024_00241043_00242762);
							Quaternion val9 = (_0024self__00242764.t.rotation = _0024_00241044_00242763);
						}
						else
						{
							int num7 = (_0024_00241041_00242760 = 0);
							Quaternion val10 = (_0024_00241042_00242761 = _0024self__00242764.t.rotation);
							float num8 = (_0024_00241042_00242761.y = _0024_00241041_00242760);
							Quaternion val12 = (_0024self__00242764.t.rotation = _0024_00241042_00242761);
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

		internal SummonSkeleton _0024self__00242765;

		public _0024Hit_00242755(SummonSkeleton self_)
		{
			_0024self__00242765 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242765);
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

	public SummonSkeleton()
	{
		HP = 20;
		waitt = 16;
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
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
		return new _0024Die_00242741(this).GetEnumerator();
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
		return new _0024HitN_00242744(this).GetEnumerator();
	}

	public override IEnumerator Hit()
	{
		return new _0024Hit_00242755(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
