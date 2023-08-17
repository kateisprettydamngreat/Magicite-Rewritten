using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class jellyFire : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Set_00243055 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024v_00243056;

			internal jellyFire _0024self__00243057;

			public _0024(Vector3 v, jellyFire self_)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				_0024v_00243056 = v;
				_0024self__00243057 = self_;
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
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00243057.playerPos = _0024v_00243056;
					_0024self__00243057.finalVec = Vector3.Normalize(_0024self__00243057.playerPos - ((Component)_0024self__00243057).transform.position);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00243057.canShoot = true;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024v_00243058;

		internal jellyFire _0024self__00243059;

		public _0024Set_00243055(Vector3 v, jellyFire self_)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_0024v_00243058 = v;
			_0024self__00243059 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024v_00243058, _0024self__00243059);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00243060 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal jellyFire _0024self__00243061;

			public _0024(jellyFire self_)
			{
				_0024self__00243061 = self_;
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
						Network.Destroy(((Component)_0024self__00243061).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00243061).gameObject);
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

		internal jellyFire _0024self__00243062;

		public _0024Start_00243060(jellyFire self_)
		{
			_0024self__00243062 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243062);
		}
	}

	private Vector3 playerPos;

	private Rigidbody r;

	private Vector3 finalVec;

	private Transform t;

	private bool canShoot;

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
	}

	[RPC]
	public override IEnumerator Set(Vector3 v)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new _0024Set_00243055(v, this).GetEnumerator();
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00243060(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (canShoot)
		{
			t.Translate(finalVec * 8f * Time.deltaTime);
		}
	}

	public override void Main()
	{
	}
}
