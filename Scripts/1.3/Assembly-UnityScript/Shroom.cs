using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Shroom : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FaceRight_00242636 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024962_00242637;

			internal Vector3 _0024_0024963_00242638;

			internal Shroom _0024self__00242639;

			public _0024(Shroom self_)
			{
				_0024self__00242639 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242639.atking && MenuScript.multiplayer == 1 && !_0024self__00242639.running)
					{
						int num = (_0024_0024962_00242637 = 8);
						Vector3 val = (_0024_0024963_00242638 = _0024self__00242639.r.velocity);
						float num2 = (_0024_0024963_00242638.y = _0024_0024962_00242637);
						Vector3 val3 = (_0024self__00242639.r.velocity = _0024_0024963_00242638);
						_0024self__00242639.running = true;
						((Component)_0024self__00242639).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
						((Component)_0024self__00242639).networkView.RPC("RUN", (RPCMode)2, new object[0]);
						_0024self__00242639.spdd = Random.Range(-1, 2) * 4;
						if (_0024self__00242639.spdd == 0)
						{
							_0024self__00242639.spdd = 4;
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 3) * 0.3f)) ? 1 : 0);
						break;
					}
					goto IL_015b;
				case 2:
					((Component)_0024self__00242639).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00242639.running = false;
					goto IL_015b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_015b:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Shroom _0024self__00242640;

		public _0024FaceRight_00242636(Shroom self_)
		{
			_0024self__00242640 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242640);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FaceLeft_00242641 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024964_00242642;

			internal Vector3 _0024_0024965_00242643;

			internal Shroom _0024self__00242644;

			public _0024(Shroom self_)
			{
				_0024self__00242644 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_012f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242644.atking && MenuScript.multiplayer == 1 && !_0024self__00242644.running)
					{
						int num = (_0024_0024964_00242642 = 8);
						Vector3 val = (_0024_0024965_00242643 = _0024self__00242644.r.velocity);
						float num2 = (_0024_0024965_00242643.y = _0024_0024964_00242642);
						Vector3 val3 = (_0024self__00242644.r.velocity = _0024_0024965_00242643);
						_0024self__00242644.running = true;
						((Component)_0024self__00242644).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
						((Component)_0024self__00242644).networkView.RPC("RUN", (RPCMode)2, new object[0]);
						_0024self__00242644.spdd = Random.Range(-1, 2) * 4;
						if (_0024self__00242644.spdd == 0)
						{
							_0024self__00242644.spdd = -4;
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(1, 2) * 0.3f)) ? 1 : 0);
						break;
					}
					goto IL_015c;
				case 2:
					((Component)_0024self__00242644).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00242644.running = false;
					goto IL_015c;
				case 1:
					{
						result = 0;
						break;
					}
					IL_015c:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Shroom _0024self__00242645;

		public _0024FaceLeft_00242641(Shroom self_)
		{
			_0024self__00242645 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242645);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TRY_00242646 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Shroom _0024self__00242647;

			public _0024(Shroom self_)
			{
				_0024self__00242647 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242647.TRYatking = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Shroom _0024self__00242648;

		public _0024TRY_00242646(Shroom self_)
		{
			_0024self__00242648 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242648);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATTACK_00242649 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Shroom _0024self__00242650;

			public _0024(Shroom self_)
			{
				_0024self__00242650 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Expected O, but got Unknown
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242650.atking = true;
					_0024self__00242650.spdd = 0;
					((Component)_0024self__00242650).networkView.RPC("ATK", (RPCMode)2, new object[0]);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.35f)) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242650.atking = false;
					_0024self__00242650.TRYatking = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Shroom _0024self__00242651;

		public _0024ATTACK_00242649(Shroom self_)
		{
			_0024self__00242651 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242651);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242652 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Shroom _0024self__00242653;

			public _0024(Shroom self_)
			{
				_0024self__00242653 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Expected O, but got Unknown
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242653.@base.animation.Play("r");
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242653.swordBox.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242653.swordBox.SetActive(false);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Shroom _0024self__00242654;

		public _0024ATK_00242652(Shroom self_)
		{
			_0024self__00242654 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242654);
		}
	}

	public GameObject swordBox;

	public AudioClip audioMove;

	public AudioClip audioAttack;

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	private bool running;

	private bool TRYatking;

	public Shroom()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 19, 20, 17 };
		SetStats(50, 4, 0, 4, 10f, array, Random.Range(6, 20), 4);
		@base.animation["i"].layer = 0;
		@base.animation["a"].layer = 0;
		@base.animation["r"].layer = 1;
		@base.animation["r"].speed = 0.5f;
		@base.animation["a"].speed = 2f;
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && MenuScript.multiplayer == 1)
		{
			int num = (int)Mathf.Abs(player.transform.position.x - t.position.x);
			if (num < 20 && !knocking)
			{
				if (!(player.transform.position.x <= t.position.x))
				{
					((MonoBehaviour)this).StartCoroutine_Auto(FaceRight());
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine_Auto(FaceLeft());
				}
				if (num < 7 && !TRYatking && !atking)
				{
					TRYatking = true;
					if (Random.Range(0, 3) == 0)
					{
						((MonoBehaviour)this).StartCoroutine_Auto(ATTACK());
					}
					else
					{
						((MonoBehaviour)this).StartCoroutine_Auto(TRY());
					}
				}
			}
		}
		if (running && !knocking)
		{
			int num2 = spdd;
			Vector3 velocity = r.velocity;
			float num3 = (velocity.x = num2);
			Vector3 val2 = (r.velocity = velocity);
		}
	}

	public override IEnumerator FaceRight()
	{
		return new _0024FaceRight_00242636(this).GetEnumerator();
	}

	public override IEnumerator FaceLeft()
	{
		return new _0024FaceLeft_00242641(this).GetEnumerator();
	}

	public override IEnumerator TRY()
	{
		return new _0024TRY_00242646(this).GetEnumerator();
	}

	public override IEnumerator ATTACK()
	{
		return new _0024ATTACK_00242649(this).GetEnumerator();
	}

	[RPC]
	public override void Turn(int a)
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
		if (a == 0)
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

	[RPC]
	public override void RUN()
	{
		@base.animation.Play("a");
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00242652(this).GetEnumerator();
	}

	[RPC]
	public override void IDLE()
	{
		@base.animation.Play("i");
	}
}
