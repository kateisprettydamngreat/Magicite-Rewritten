using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ghoulFire : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Set_00243112 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024v_00243113;

			internal ghoulFire _0024self__00243114;

			public _0024(Vector3 v, ghoulFire self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024v_00243113 = v;
				_0024self__00243114 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00be: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00243114.playerPos = _0024v_00243113;
					_0024self__00243114.finalVec = Vector3.Normalize(_0024self__00243114.playerPos - ((Component)_0024self__00243114).transform.position);
					if (_0024self__00243114.isButterfly)
					{
						_0024self__00243114.wait = 2f;
						_0024self__00243114.spdd = 10;
					}
					else
					{
						_0024self__00243114.wait = 0.5f;
					}
					if (!_0024self__00243114.noWait)
					{
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00243114.wait)) ? 1 : 0);
						break;
					}
					goto case 2;
				case 2:
					_0024self__00243114.canShoot = true;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024v_00243115;

		internal ghoulFire _0024self__00243116;

		public _0024Set_00243112(Vector3 v, ghoulFire self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024v_00243115 = v;
			_0024self__00243116 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024v_00243115, _0024self__00243116);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00243117 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ghoulFire _0024self__00243118;

			public _0024(ghoulFire self_)
			{
				_0024self__00243118 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected O, but got Unknown
				//IL_0040: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(6f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						Network.Destroy(((Component)_0024self__00243118).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00243118).gameObject);
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

		internal ghoulFire _0024self__00243119;

		public _0024Start_00243117(ghoulFire self_)
		{
			_0024self__00243119 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243119);
		}
	}

	public bool noWait;

	private Vector3 playerPos;

	private Rigidbody r;

	private Vector3 finalVec;

	private Transform t;

	private bool canShoot;

	private float wait;

	public bool isButterfly;

	private int spdd;

	public ghoulFire()
	{
		spdd = 18;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
	}

	[RPC]
	public override IEnumerator Set(Vector3 v)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Set_00243112(v, this).GetEnumerator();
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00243117(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (canShoot)
		{
			t.Translate(finalVec * (float)spdd * Time.deltaTime);
		}
	}

	public override void Main()
	{
	}
}
