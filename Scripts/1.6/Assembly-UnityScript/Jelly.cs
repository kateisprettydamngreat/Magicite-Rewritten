using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Jelly : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Summon_00242079 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00242080;

			internal Jelly _0024self__00242081;

			public _0024(Jelly self_)
			{
				_0024self__00242081 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Expected O, but got Unknown
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024g_00242080 = null;
					goto IL_0027;
				case 2:
					if (_0024self__00242081.atking && Object.op_Implicit((Object)(object)_0024self__00242081.player) && _0024self__00242081.canFire && MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242081).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					goto IL_0027;
				case 3:
					_0024g_00242080 = (GameObject)Network.Instantiate(Resources.Load("haz/jellyFire"), ((Component)_0024self__00242081).transform.position, Quaternion.identity, 0);
					_0024g_00242080.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024self__00242081.player.transform.position });
					goto IL_0027;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0027:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Jelly _0024self__00242082;

		public _0024Summon_00242079(Jelly self_)
		{
			_0024self__00242082 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242082);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242083 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Jelly _0024self__00242084;

			public _0024(Jelly self_)
			{
				_0024self__00242084 = self_;
			}

			public override bool MoveNext()
			{
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (Object.op_Implicit((Object)(object)_0024self__00242084.player))
					{
						_0024self__00242084.curVector = _0024self__00242084.player.transform.position - _0024self__00242084.t.position;
						if (!(_0024self__00242084.player.transform.position.x <= _0024self__00242084.t.position.x))
						{
							_0024self__00242084.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00242084.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00242084.atking = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00242084.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal Jelly _0024self__00242085;

		public _0024Attack_00242083(Jelly self_)
		{
			_0024self__00242085 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242085);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool canFire;

	public Jelly()
	{
		speed = 4f;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 15, 566 };
		SetStats(50, 1, 0, 7, 10f, array, Random.Range(6, 20), 8);
		@base.animation["i"].layer = 0;
		@base.animation["a"].layer = 1;
		@base.animation["a"].speed = 0.5f;
		if (MenuScript.multiplayer > 0)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Attack());
		}
		((MonoBehaviour)this).StartCoroutine_Auto(Summon());
	}

	public override IEnumerator Summon()
	{
		return new _0024Summon_00242079(this).GetEnumerator();
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && MenuScript.multiplayer == 1)
		{
			if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 10f) && !knocking)
			{
				canFire = true;
				((Component)this).rigidbody.velocity = ((Vector3)(ref curVector)).normalized * speed;
			}
			else
			{
				canFire = false;
			}
		}
	}

	public override IEnumerator Attack()
	{
		return new _0024Attack_00242083(this).GetEnumerator();
	}

	[RPC]
	public override void ATK()
	{
		@base.animation.Play("a");
	}
}
