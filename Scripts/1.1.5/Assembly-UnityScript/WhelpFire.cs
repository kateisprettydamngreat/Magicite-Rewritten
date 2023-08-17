using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class WhelpFire : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242898 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WhelpFire _0024self__00242899;

			public _0024(WhelpFire self_)
			{
				_0024self__00242899 = self_;
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
						Network.Destroy(((Component)_0024self__00242899).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00242899).gameObject);
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

		internal WhelpFire _0024self__00242900;

		public _0024Start_00242898(WhelpFire self_)
		{
			_0024self__00242900 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242900);
		}
	}

	public bool isFast;

	public bool yeti;

	private Vector3 playerPos;

	private Rigidbody r;

	private Vector3 finalVec;

	private Transform t;

	private bool canShoot;

	private int speed;

	public WhelpFire()
	{
		speed = 10;
	}

	public override void Awake()
	{
		if (isFast)
		{
			speed = Random.Range(5, 18);
		}
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
	}

	[RPC]
	public override void Set(Vector3 v)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		playerPos = v;
		if (!yeti)
		{
			finalVec = Vector3.Normalize(playerPos - ((Component)this).transform.position);
		}
		else
		{
			finalVec = v;
		}
		canShoot = true;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242898(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (canShoot)
		{
			t.Translate(finalVec * (float)speed * Time.deltaTime);
		}
	}

	public override void Main()
	{
	}
}
