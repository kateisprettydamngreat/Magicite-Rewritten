using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class PlayerController : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242292 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242293;

			public _0024(PlayerController self_)
			{
				_0024self__00242293 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (armor > 0)
					{
						b = armor;
					}
					else
					{
						b = MenuScript.pBody;
					}
					if (h != 0)
					{
						if (helm > 0)
						{
							h = helm;
						}
						else
						{
							h = MenuScript.pVariant;
						}
					}
					else
					{
						h = MenuScript.pVariant;
					}
					race = MenuScript.pRace;
					_0024self__00242293.UpdateAppearance();
					goto IL_0092;
				case 2:
					_0024self__00242293.gameScript.DecreaseHunger();
					goto IL_0092;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0092:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(60f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242294;

		public _0024Start_00242292(PlayerController self_)
		{
			_0024self__00242294 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242294);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Leavee_00242295 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242296;

			public _0024(PlayerController self_)
			{
				_0024self__00242296 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242296.fade.fadeOut();
					GameScript.curBiome = GameScript.door[GameScript.curDoor];
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (GameScript.isTown)
					{
						GameScript.isTown = false;
					}
					else if (GameScript.districtLevel == 21)
					{
						GameScript.isTown = false;
					}
					else
					{
						GameScript.isTown = true;
					}
					_0024self__00242296.gameScript.SaveInventory();
					Application.LoadLevel(1);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242297;

		public _0024Leavee_00242295(PlayerController self_)
		{
			_0024self__00242297 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242297);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Offledge_00242298 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242299;

			public _0024(PlayerController self_)
			{
				_0024self__00242299 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242299.offledge)
					{
						_0024self__00242299.offledge = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						break;
					}
					goto IL_00e7;
				case 2:
					if (Physics.Raycast(_0024self__00242299.ray, ref _0024self__00242299.hit, 1.5f))
					{
						if (((Component)((RaycastHit)(ref _0024self__00242299.hit)).transform).gameObject.layer == 11)
						{
							_0024self__00242299.grounded = true;
							mode = 0;
							_0024self__00242299.canDoubleJump = true;
						}
						else
						{
							mode = 2;
							_0024self__00242299.grounded = false;
						}
					}
					else
					{
						mode = 2;
						_0024self__00242299.grounded = false;
					}
					_0024self__00242299.offledge = false;
					goto IL_00e7;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00e7:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242300;

		public _0024Offledge_00242298(PlayerController self_)
		{
			_0024self__00242300 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242300);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Dash_00242301 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024832_00242302;

			internal Vector3 _0024_0024833_00242303;

			internal int _0024_0024834_00242304;

			internal Vector3 _0024_0024835_00242305;

			internal int _0024_0024836_00242306;

			internal Vector3 _0024_0024837_00242307;

			internal int _0024_0024838_00242308;

			internal Vector3 _0024_0024839_00242309;

			internal int _0024a_00242310;

			internal PlayerController _0024self__00242311;

			public _0024(int a, PlayerController self_)
			{
				_0024a_00242310 = a;
				_0024self__00242311 = self_;
			}

			public override bool MoveNext()
			{
				//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0258: Unknown result type (might be due to invalid IL or missing references)
				//IL_025d: Unknown result type (might be due to invalid IL or missing references)
				//IL_025e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0260: Unknown result type (might be due to invalid IL or missing references)
				//IL_0265: Unknown result type (might be due to invalid IL or missing references)
				//IL_028c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0291: Unknown result type (might be due to invalid IL or missing references)
				//IL_0292: Unknown result type (might be due to invalid IL or missing references)
				//IL_0299: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Unknown result type (might be due to invalid IL or missing references)
				//IL_0229: Unknown result type (might be due to invalid IL or missing references)
				//IL_022e: Unknown result type (might be due to invalid IL or missing references)
				//IL_022f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0236: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_018f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0194: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_012a: Unknown result type (might be due to invalid IL or missing references)
				//IL_012f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_0136: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ad: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!(_0024self__00242311.gameScript.stamina < 1f))
					{
						((Component)_0024self__00242311).audio.PlayOneShot(_0024self__00242311.audioDash);
						_0024self__00242311.dashing = true;
						_0024self__00242311.gameScript.Stamina();
						_0024self__00242311.gameScript.stamina = _0024self__00242311.gameScript.stamina - 1f;
						_0024self__00242311.gameScript.LoadSTA();
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242311).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242311.t.position });
						}
						else
						{
							_0024self__00242311.po(_0024self__00242311.t.position);
						}
						if (_0024self__00242311.grounded)
						{
							if (_0024a_00242310 != 0)
							{
								int num = (_0024_0024834_00242304 = 18);
								Vector3 val = (_0024_0024835_00242305 = _0024self__00242311.r.velocity);
								float num2 = (_0024_0024835_00242305.x = _0024_0024834_00242304);
								Vector3 val3 = (_0024self__00242311.r.velocity = _0024_0024835_00242305);
							}
							else
							{
								int num3 = (_0024_0024832_00242302 = -18);
								Vector3 val4 = (_0024_0024833_00242303 = _0024self__00242311.r.velocity);
								float num4 = (_0024_0024833_00242303.x = _0024_0024832_00242302);
								Vector3 val6 = (_0024self__00242311.r.velocity = _0024_0024833_00242303);
							}
						}
						else if (_0024a_00242310 != 0)
						{
							int num5 = (_0024_0024838_00242308 = 15);
							Vector3 val7 = (_0024_0024839_00242309 = _0024self__00242311.r.velocity);
							float num6 = (_0024_0024839_00242309.x = _0024_0024838_00242308);
							Vector3 val9 = (_0024self__00242311.r.velocity = _0024_0024839_00242309);
						}
						else
						{
							int num7 = (_0024_0024836_00242306 = -15);
							Vector3 val10 = (_0024_0024837_00242307 = _0024self__00242311.r.velocity);
							float num8 = (_0024_0024837_00242307.x = _0024_0024836_00242306);
							Vector3 val12 = (_0024self__00242311.r.velocity = _0024_0024837_00242307);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242311.t.position, Quaternion.identity);
					goto IL_02e8;
				case 2:
					_0024self__00242311.dashing = false;
					goto IL_02e8;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02e8:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242312;

		internal PlayerController _0024self__00242313;

		public _0024Dash_00242301(int a, PlayerController self_)
		{
			_0024a_00242312 = a;
			_0024self__00242313 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242312, _0024self__00242313);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShieldN_00242314 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242315;

			public _0024(PlayerController self_)
			{
				_0024self__00242315 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242315).networkView.isMine)
					{
						_0024self__00242315.shieldObj.SetActive(true);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
						break;
					}
					goto IL_0089;
				case 2:
					PlayerTriggerScript.ShieldDEF -= 4;
					if (PlayerTriggerScript.ShieldDEF < 0)
					{
						PlayerTriggerScript.ShieldDEF = 0;
					}
					if (PlayerTriggerScript.ShieldDEF == 0)
					{
						_0024self__00242315.shieldObj.SetActive(false);
					}
					goto IL_0089;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0089:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242316;

		public _0024ShieldN_00242314(PlayerController self_)
		{
			_0024self__00242316 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242316);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Shield_00242317 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242318;

			public _0024(PlayerController self_)
			{
				_0024self__00242318 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					PlayerTriggerScript.ShieldDEF += 4;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242318).networkView.RPC("ShieldN", (RPCMode)2, new object[0]);
						goto IL_00ac;
					}
					_0024self__00242318.shieldObj.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
					break;
				case 2:
					PlayerTriggerScript.ShieldDEF -= 4;
					if (PlayerTriggerScript.ShieldDEF < 0)
					{
						PlayerTriggerScript.ShieldDEF = 0;
					}
					if (PlayerTriggerScript.ShieldDEF == 0)
					{
						_0024self__00242318.shieldObj.SetActive(false);
					}
					goto IL_00ac;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00ac:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242319;

		public _0024Shield_00242317(PlayerController self_)
		{
			_0024self__00242319 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242319);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FloatN_00242320 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242321;

			public _0024(PlayerController self_)
			{
				_0024self__00242321 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242321).networkView.isMine)
					{
						_0024self__00242321.particleFloat.SetActive(true);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
						break;
					}
					goto IL_00be;
				case 2:
					_0024self__00242321.floatCounter--;
					if (_0024self__00242321.floatCounter < 0)
					{
						_0024self__00242321.floatCounter = 0;
					}
					if (_0024self__00242321.floatCounter == 0)
					{
						_0024self__00242321.particleFloat.SetActive(false);
						((Component)_0024self__00242321).rigidbody.useGravity = true;
						GameScript.isFloating = false;
					}
					goto IL_00be;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00be:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242322;

		public _0024FloatN_00242320(PlayerController self_)
		{
			_0024self__00242322 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242322);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Float_00242323 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024840_00242324;

			internal Vector3 _0024_0024841_00242325;

			internal PlayerController _0024self__00242326;

			public _0024(PlayerController self_)
			{
				_0024self__00242326 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					_0024self__00242326.floatCounter++;
					((Component)_0024self__00242326).rigidbody.useGravity = false;
					int num = (_0024_0024840_00242324 = 10);
					Vector3 val = (_0024_0024841_00242325 = ((Component)_0024self__00242326).rigidbody.velocity);
					float num2 = (_0024_0024841_00242325.y = _0024_0024840_00242324);
					Vector3 val3 = (((Component)_0024self__00242326).rigidbody.velocity = _0024_0024841_00242325);
					GameScript.isFloating = true;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242326).networkView.RPC("FloatN", (RPCMode)2, new object[0]);
						goto IL_015a;
					}
					_0024self__00242326.particleFloat.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				}
				case 2:
					_0024self__00242326.floatCounter--;
					if (_0024self__00242326.floatCounter < 0)
					{
						_0024self__00242326.floatCounter = 0;
					}
					if (_0024self__00242326.floatCounter == 0)
					{
						_0024self__00242326.particleFloat.SetActive(false);
						((Component)_0024self__00242326).rigidbody.useGravity = true;
						GameScript.isFloating = false;
					}
					goto IL_015a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_015a:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242327;

		public _0024Float_00242323(PlayerController self_)
		{
			_0024self__00242327 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242327);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeN_00242328 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242329;

			public _0024(PlayerController self_)
			{
				_0024self__00242329 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242329).networkView.isMine)
					{
						_0024self__00242329.particleCharge.SetActive(true);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
						break;
					}
					goto IL_00a7;
				case 2:
					_0024self__00242329.chargeBoost -= 4;
					if (_0024self__00242329.chargeBoost < 0)
					{
						_0024self__00242329.chargeBoost = 0;
					}
					if (_0024self__00242329.chargeBoost == 0)
					{
						_0024self__00242329.particleCharge.SetActive(false);
					}
					goto IL_00a7;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a7:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242330;

		public _0024ChargeN_00242328(PlayerController self_)
		{
			_0024self__00242330 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242330);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Charge_00242331 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242332;

			public _0024(PlayerController self_)
			{
				_0024self__00242332 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242332.chargeBoost += 4;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242332).networkView.RPC("ChargeN", (RPCMode)2, new object[0]);
						goto IL_00d6;
					}
					_0024self__00242332.particleCharge.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242332.chargeBoost -= 4;
					if (_0024self__00242332.chargeBoost < 0)
					{
						_0024self__00242332.chargeBoost = 0;
					}
					if (_0024self__00242332.chargeBoost == 0)
					{
						_0024self__00242332.particleCharge.SetActive(false);
					}
					goto IL_00d6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00d6:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242333;

		public _0024Charge_00242331(PlayerController self_)
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
	internal sealed class _0024mWeaponsN_00242334 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242335;

			internal PlayerController _0024self__00242336;

			public _0024(int a, PlayerController self_)
			{
				_0024a_00242335 = a;
				_0024self__00242336 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00242336).networkView.isMine)
					{
						_0024self__00242336.mWeapon.SetActive(true);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
						break;
					}
					goto IL_008e;
				case 2:
					mBonus -= _0024a_00242335;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00242336.mWeapon.SetActive(false);
					}
					goto IL_008e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_008e:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242337;

		internal PlayerController _0024self__00242338;

		public _0024mWeaponsN_00242334(int a, PlayerController self_)
		{
			_0024a_00242337 = a;
			_0024self__00242338 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242337, _0024self__00242338);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeapons_00242339 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242340;

			internal PlayerController _0024self__00242341;

			public _0024(int a, PlayerController self_)
			{
				_0024a_00242340 = a;
				_0024self__00242341 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					mBonus += _0024a_00242340;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242341).networkView.RPC("mWeaponsN", (RPCMode)2, new object[1] { _0024a_00242340 });
						goto IL_00c4;
					}
					_0024self__00242341.mWeapon.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					mBonus -= _0024a_00242340;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00242341.mWeapon.SetActive(false);
					}
					goto IL_00c4;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00c4:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242342;

		internal PlayerController _0024self__00242343;

		public _0024mWeapons_00242339(int a, PlayerController self_)
		{
			_0024a_00242342 = a;
			_0024self__00242343 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00242342, _0024self__00242343);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Jump_00242344 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024842_00242345;

			internal Vector3 _0024_0024843_00242346;

			internal int _0024_0024844_00242347;

			internal Vector3 _0024_0024845_00242348;

			internal PlayerController _0024self__00242349;

			public _0024(PlayerController self_)
			{
				_0024self__00242349 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_011d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0122: Unknown result type (might be due to invalid IL or missing references)
				//IL_0123: Unknown result type (might be due to invalid IL or missing references)
				//IL_012a: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242349.djA = true;
					((Component)_0024self__00242349).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP", typeof(AudioClip)));
					_0024self__00242349.canBoost = true;
					_0024self__00242349.grounded = false;
					mode = 2;
					if (!GameScript.isFloating)
					{
						int num = (_0024_0024844_00242347 = 24);
						Vector3 val = (_0024_0024845_00242348 = _0024self__00242349.r.velocity);
						float num2 = (_0024_0024845_00242348.y = _0024_0024844_00242347);
						Vector3 val3 = (_0024self__00242349.r.velocity = _0024_0024845_00242348);
					}
					else
					{
						int num3 = (_0024_0024842_00242345 = 12);
						Vector3 val4 = (_0024_0024843_00242346 = _0024self__00242349.r.velocity);
						float num4 = (_0024_0024843_00242346.y = _0024_0024842_00242345);
						Vector3 val6 = (_0024self__00242349.r.velocity = _0024_0024843_00242346);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242349.canBoost = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242350;

		public _0024Jump_00242344(PlayerController self_)
		{
			_0024self__00242350 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242350);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DoubleJump_00242351 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024846_00242352;

			internal Vector3 _0024_0024847_00242353;

			internal int _0024_0024848_00242354;

			internal Vector3 _0024_0024849_00242355;

			internal PlayerController _0024self__00242356;

			public _0024(PlayerController self_)
			{
				_0024self__00242356 = self_;
			}

			public override bool MoveNext()
			{
				//IL_022b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected O, but got Unknown
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0180: Unknown result type (might be due to invalid IL or missing references)
				//IL_0181: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0200: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!(_0024self__00242356.gameScript.stamina < 1f))
					{
						_0024self__00242356.djA = false;
						((Component)_0024self__00242356).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00242356.canBoost = false;
						_0024self__00242356.canBoost2 = true;
						_0024self__00242356.gameScript.Stamina();
						_0024self__00242356.gameScript.stamina = _0024self__00242356.gameScript.stamina - 1f;
						_0024self__00242356.gameScript.LoadSTA();
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242356).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00242356.t.position });
						}
						else
						{
							_0024self__00242356.po(_0024self__00242356.t.position);
						}
						_0024self__00242356.canDoubleJump = false;
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024848_00242354 = 26);
							Vector3 val = (_0024_0024849_00242355 = _0024self__00242356.r.velocity);
							float num2 = (_0024_0024849_00242355.y = _0024_0024848_00242354);
							Vector3 val3 = (_0024self__00242356.r.velocity = _0024_0024849_00242355);
						}
						else
						{
							int num3 = (_0024_0024846_00242352 = 12);
							Vector3 val4 = (_0024_0024847_00242353 = _0024self__00242356.r.velocity);
							float num4 = (_0024_0024847_00242353.y = _0024_0024846_00242352);
							Vector3 val6 = (_0024self__00242356.r.velocity = _0024_0024847_00242353);
						}
						mode = 2;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00242356.t.position, Quaternion.identity);
					goto IL_023b;
				case 2:
					_0024self__00242356.canBoost2 = false;
					goto IL_023b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_023b:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242357;

		public _0024DoubleJump_00242351(PlayerController self_)
		{
			_0024self__00242357 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242357);
		}
	}

	public GameObject blood;

	public GameObject particleRoar;

	public GameObject particleFloat;

	[NonSerialized]
	public static int mBonus;

	private int floatCounter;

	public GameObject mWeapon;

	public GameObject shieldObj;

	public GameObject particleClair;

	private int chargeBoost;

	public GameObject particleCharge;

	public GameObject particleRage;

	[NonSerialized]
	public static bool isBoss;

	[NonSerialized]
	public static int mode;

	[NonSerialized]
	public static int interact;

	[NonSerialized]
	public static bool facingRight;

	[NonSerialized]
	public static GameObject aCube;

	[NonSerialized]
	public static GameObject lUp;

	[NonSerialized]
	public static int b;

	[NonSerialized]
	public static int h;

	[NonSerialized]
	public static int race;

	[NonSerialized]
	public static int o;

	[NonSerialized]
	public static int helm;

	[NonSerialized]
	public static int armor;

	[NonSerialized]
	public static int offhand;

	private bool charging;

	private bool offledge;

	public AudioClip themeCave;

	public AudioClip themeTown;

	public GameObject levelUpObj;

	public GameObject attackCube;

	public GameObject pop;

	public GameObject @base;

	public GameObject p;

	public GameObject head;

	public GameObject head2;

	public GameObject body;

	public GameObject arm1;

	public GameObject arm2;

	public GameObject leg;

	public GameObject weapon;

	public GameObject offHand;

	public TextMesh[] txtName;

	public AudioClip audioDash;

	public bool attacking;

	public bool cantMove;

	public bool running;

	private bool moving;

	private int cc;

	private bool jA;

	private bool djA;

	private GameScript gameScript;

	private bool canMove;

	private Vector3 newPos;

	private Vector3 newPos2;

	private Ray ray;

	private RaycastHit hit;

	private int mask;

	private LayerMask m;

	private bool dead;

	private PlayerTriggerScript trigger;

	private bool dashing;

	private int jumping;

	private Ray[] rays;

	private float gravity;

	private bool grounded;

	private Transform t;

	private Rigidbody r;

	private FadeInOut fade;

	private bool canDoubleJump;

	private bool canBoost;

	private bool canBoost2;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private bool cantLeft;

	private bool cantRight;

	private int itemPurchasing;

	public PlayerController()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		txtName = (TextMesh[])(object)new TextMesh[2];
		mask = 2048;
		m = LayerMask.op_Implicit(2048);
		rays = (Ray[])(object)new Ray[4];
		gravity = 10f;
	}

	[RPC]
	public override void Boss()
	{
		isBoss = true;
	}

	public override void Awake()
	{
		isBoss = false;
		PlayerTriggerScript.isDead = false;
		fade = (FadeInOut)(object)((Component)Camera.main).gameObject.GetComponent("FadeInOut");
		aCube = attackCube;
		lUp = levelUpObj;
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
		trigger = (PlayerTriggerScript)(object)((Component)((Component)this).transform.Find("p")).GetComponent("PlayerTriggerScript");
		((Component)this).collider.material.dynamicFriction = 0f;
		GameScript.facingLeft = true;
		@base.animation["i"].layer = 1;
		@base.animation["i"].speed = 2f;
		@base.animation["r"].layer = 1;
		@base.animation["a1"].layer = 2;
		@base.animation["a2"].layer = 2;
		@base.animation["a3"].layer = 2;
		@base.animation["j"].layer = 1;
		@base.animation["dj"].layer = 1;
		@base.animation["a2"].speed = 1.5f;
		@base.animation["a3"].speed = 2f;
		@base.animation["a4"].layer = 2;
		@base.animation["dead"].layer = 1;
		@base.animation["a4"].speed = 2f;
	}

	public override void Clair(int a)
	{
		if (a == 1)
		{
			particleClair.SetActive(true);
		}
		else
		{
			particleClair.SetActive(false);
		}
	}

	public override void Rage(int a)
	{
		if (a == 1)
		{
			particleRage.SetActive(true);
		}
		else
		{
			particleRage.SetActive(false);
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242292(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		((Ray)(ref r1U)).origin = ((Component)this).transform.position;
		float y = ((Ray)(ref r1U)).origin.y + 0.6f;
		Vector3 origin = ((Ray)(ref r1U)).origin;
		float num = (origin.y = y);
		Vector3 val2 = (((Ray)(ref r1U)).origin = origin);
		((Ray)(ref r1U)).direction = Vector3.left;
		((Ray)(ref r2U)).origin = ((Component)this).transform.position;
		float y2 = ((Ray)(ref r2U)).origin.y + 0.6f;
		Vector3 origin2 = ((Ray)(ref r2U)).origin;
		float num2 = (origin2.y = y2);
		Vector3 val4 = (((Ray)(ref r2U)).origin = origin2);
		((Ray)(ref r2U)).direction = Vector3.right;
		((Ray)(ref r1D)).origin = ((Component)this).transform.position;
		float y3 = ((Ray)(ref r1D)).origin.y - 0.7f;
		Vector3 origin3 = ((Ray)(ref r1D)).origin;
		float num3 = (origin3.y = y3);
		Vector3 val6 = (((Ray)(ref r1D)).origin = origin3);
		((Ray)(ref r1D)).direction = Vector3.left;
		((Ray)(ref r2D)).origin = ((Component)this).transform.position;
		float y4 = ((Ray)(ref r2D)).origin.y - 0.7f;
		Vector3 origin4 = ((Ray)(ref r2D)).origin;
		float num4 = (origin4.y = y4);
		Vector3 val8 = (((Ray)(ref r2D)).origin = origin4);
		((Ray)(ref r2D)).direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.2f, mask) || Physics.Raycast(r1D, 1.2f, mask))
		{
			cantLeft = true;
		}
		else
		{
			cantLeft = false;
		}
		if (Physics.Raycast(r2U, 1.2f, mask) || Physics.Raycast(r2D, 1.2f, mask))
		{
			cantRight = true;
		}
		else
		{
			cantRight = false;
		}
		if (!(r.velocity.y >= -25f))
		{
			int num5 = -25;
			Vector3 velocity = r.velocity;
			float num6 = (velocity.y = num5);
			Vector3 val10 = (r.velocity = velocity);
		}
		if (!GameScript.takingDamage)
		{
			if (!(Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= t.position.x + 0.1f))
			{
				if (GameScript.facingLeft)
				{
					GameScript.facingLeft = false;
					p.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
				}
			}
			else if (!(Camera.main.ScreenToWorldPoint(Input.mousePosition).x >= t.position.x - 0.1f) && !GameScript.facingLeft)
			{
				GameScript.facingLeft = true;
				p.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			ray = new Ray(t.position, new Vector3(0f, -1f, 0f));
			if (Physics.Raycast(ray, ref hit, 1.5f))
			{
				if (((Component)((RaycastHit)(ref hit)).transform).gameObject.layer == 11)
				{
					grounded = true;
					mode = 0;
					canDoubleJump = true;
				}
				else
				{
					mode = 2;
					((MonoBehaviour)this).StartCoroutine_Auto(Offledge());
				}
			}
			else
			{
				mode = 2;
				((MonoBehaviour)this).StartCoroutine_Auto(Offledge());
			}
			if (Input.GetKey((KeyCode)97) && !cantLeft && !dashing)
			{
				if (grounded)
				{
					mode = 1;
				}
				else
				{
					mode = 2;
				}
				float x = 0f - GameScript.SPD - (float)chargeBoost;
				Vector3 velocity2 = r.velocity;
				float num7 = (velocity2.x = x);
				Vector3 val12 = (r.velocity = velocity2);
			}
			if (Input.GetKeyDown((KeyCode)113))
			{
				mode = 2;
				MonoBehaviour.print((object)"asdddf");
				((MonoBehaviour)this).StartCoroutine_Auto(Dash(0));
			}
			else if (Input.GetKeyDown((KeyCode)101))
			{
				mode = 2;
				((MonoBehaviour)this).StartCoroutine_Auto(Dash(1));
			}
			if (Input.GetKey((KeyCode)100) && !cantRight && !dashing)
			{
				if (grounded)
				{
					mode = 1;
				}
				else
				{
					mode = 2;
				}
				float x2 = GameScript.SPD + (float)chargeBoost;
				Vector3 velocity3 = r.velocity;
				float num8 = (velocity3.x = x2);
				Vector3 val14 = (r.velocity = velocity3);
			}
			if (Input.GetKeyDown((KeyCode)115) && GameScript.isFloating)
			{
				int num9 = -10;
				Vector3 velocity4 = r.velocity;
				float num10 = (velocity4.y = num9);
				Vector3 val16 = (r.velocity = velocity4);
			}
			if (Input.GetKeyDown((KeyCode)119) && GameScript.isFloating)
			{
				int num11 = 10;
				Vector3 velocity5 = r.velocity;
				float num12 = (velocity5.y = num11);
				Vector3 val18 = (r.velocity = velocity5);
			}
			if (Input.GetKeyUp((KeyCode)97))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num13 = 0;
				Vector3 velocity6 = r.velocity;
				float num14 = (velocity6.x = num13);
				Vector3 val20 = (r.velocity = velocity6);
			}
			else if (Input.GetKeyUp((KeyCode)100))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num15 = 0;
				Vector3 velocity7 = r.velocity;
				float num16 = (velocity7.x = num15);
				Vector3 val22 = (r.velocity = velocity7);
			}
			if (Input.GetKeyDown((KeyCode)32))
			{
				if (grounded)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(Jump());
				}
				else if (canDoubleJump)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(DoubleJump());
				}
			}
			if (Input.GetKey((KeyCode)32) && !dashing)
			{
				if (canBoost)
				{
					float y5 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity8 = r.velocity;
					float num17 = (velocity8.y = y5);
					Vector3 val24 = (r.velocity = velocity8);
				}
				else if (canBoost2)
				{
					float y6 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity9 = r.velocity;
					float num18 = (velocity9.y = y6);
					Vector3 val26 = (r.velocity = velocity9);
				}
			}
			if (Input.GetKeyDown((KeyCode)119))
			{
				if (trigger.canLeave)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(Leavee());
				}
				if (GameScript.canInteract && !GameScript.interacting)
				{
					gameScript.Interact();
				}
				if (GameScript.isShopping && PlayerTriggerScript.itemPurchasing != 0)
				{
					gameScript.Purchase(PlayerTriggerScript.itemPurchasing);
				}
			}
		}
		if (GameScript.HP <= 0)
		{
			MonoBehaviour.print((object)"ISDEADD");
			mode = 99;
		}
		if (mode == 0)
		{
			@base.animation.Play("i");
			jA = false;
		}
		else if (mode == 1)
		{
			@base.animation.Play("r");
			jA = false;
		}
		else if (mode == 2)
		{
			if (!jA)
			{
				@base.animation.Play("j");
				jA = true;
			}
			if (!djA)
			{
				@base.animation.Play("dj");
				djA = true;
			}
		}
		else if (mode == 3)
		{
			@base.animation.Play("a1");
			jA = false;
		}
		else if (mode == 99)
		{
			@base.animation.Play("dead");
		}
		else
		{
			jA = false;
		}
		if (dashing)
		{
			@base.animation.Play("j");
		}
	}

	public override IEnumerator Leavee()
	{
		return new _0024Leavee_00242295(this).GetEnumerator();
	}

	public override IEnumerator Offledge()
	{
		return new _0024Offledge_00242298(this).GetEnumerator();
	}

	public override IEnumerator Dash(int a)
	{
		return new _0024Dash_00242301(a, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ShieldN()
	{
		return new _0024ShieldN_00242314(this).GetEnumerator();
	}

	public override IEnumerator Shield()
	{
		return new _0024Shield_00242317(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator FloatN()
	{
		return new _0024FloatN_00242320(this).GetEnumerator();
	}

	public override IEnumerator Float()
	{
		return new _0024Float_00242323(this).GetEnumerator();
	}

	public override void Roar(int a)
	{
		if (a == 1)
		{
			particleRoar.SetActive(true);
		}
		else
		{
			particleRoar.SetActive(false);
		}
	}

	[RPC]
	public override IEnumerator ChargeN()
	{
		return new _0024ChargeN_00242328(this).GetEnumerator();
	}

	public override IEnumerator Charge()
	{
		return new _0024Charge_00242331(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator mWeaponsN(int a)
	{
		return new _0024mWeaponsN_00242334(a, this).GetEnumerator();
	}

	public override IEnumerator mWeapons(int a)
	{
		return new _0024mWeapons_00242339(a, this).GetEnumerator();
	}

	public override IEnumerator Jump()
	{
		return new _0024Jump_00242344(this).GetEnumerator();
	}

	public override IEnumerator DoubleJump()
	{
		return new _0024DoubleJump_00242351(this).GetEnumerator();
	}

	public override void UpdateHead(int hh)
	{
		h = hh;
		UpdateAppearance();
	}

	public override void UpdateBody(int bb)
	{
		b = bb;
		UpdateAppearance();
	}

	public override void UpdateOffhand(int oo)
	{
		o = oo;
		UpdateAppearance();
	}

	public override void OnLevelWasLoaded(int level)
	{
		gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
		GameScript.cLevel = PlayerPrefs.GetInt("cLevel");
		GameObject val = null;
	}

	public override void TD(int dmg)
	{
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(trigger.TD(dmg));
		}
	}

	public override void Initialize()
	{
	}

	public override void UpdateAppearance()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		head.renderer.material = (Material)Resources.Load("r/r" + (object)race, typeof(Material));
		if (helm == 0)
		{
			head2.renderer.material = (Material)Resources.Load("h/h" + (object)(h + (MenuScript.pColor - 1) * 14), typeof(Material));
		}
		else
		{
			head2.renderer.material = (Material)Resources.Load("h/h" + (object)h, typeof(Material));
		}
		body.renderer.material = (Material)Resources.Load("b/b" + (object)b, typeof(Material));
		arm1.renderer.material = (Material)Resources.Load("a/a" + (object)b, typeof(Material));
		arm2.renderer.material = (Material)Resources.Load("a/a" + (object)b, typeof(Material));
		leg.renderer.material = (Material)Resources.Load("l/l" + (object)b, typeof(Material));
		offHand.renderer.material = (Material)Resources.Load("o/o" + (object)o, typeof(Material));
	}

	[RPC]
	public override void po(Vector3 pos)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate((Object)(object)pop, pos, Quaternion.Euler(0f, 180f, 180f));
	}

	public override void K(bool a)
	{
	}

	public override void TDp()
	{
		float num = (float)GameScript.MAXHP * 0.2f;
		int dMG = (int)num;
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(trigger.TD(dMG));
		}
	}

	public override void Main()
	{
	}
}
