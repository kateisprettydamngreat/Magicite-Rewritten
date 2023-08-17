using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class GhoulScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Summon_00241926 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00241927;

			internal GhoulScript _0024self__00241928;

			public _0024(GhoulScript self_)
			{
				_0024self__00241928 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_010c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0116: Expected O, but got Unknown
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Expected O, but got Unknown
				//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024g_00241927 = null;
					goto IL_0023;
				case 2:
					if (_0024self__00241928.atking && Object.op_Implicit((Object)(object)_0024self__00241928.player) && _0024self__00241928.canFire)
					{
						if (MenuScript.multiplayer > 0)
						{
							_0024g_00241927 = (GameObject)Network.Instantiate(Resources.Load("haz/ghoulFire"), ((Component)_0024self__00241928).transform.position, Quaternion.identity, 0);
							_0024g_00241927.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024self__00241928.player.transform.position });
						}
						else
						{
							_0024g_00241927 = (GameObject)Object.Instantiate(Resources.Load("haz/ghoulFire"), ((Component)_0024self__00241928).transform.position, Quaternion.identity);
							_0024g_00241927.SendMessage("Set", (object)_0024self__00241928.player.transform.position);
						}
					}
					goto IL_0023;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0023:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GhoulScript _0024self__00241929;

		public _0024Summon_00241926(GhoulScript self_)
		{
			_0024self__00241929 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241929);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241930 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GhoulScript _0024self__00241931;

			public _0024(GhoulScript self_)
			{
				_0024self__00241931 = self_;
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
					if (Object.op_Implicit((Object)(object)_0024self__00241931.player))
					{
						_0024self__00241931.curVector = _0024self__00241931.player.transform.position - _0024self__00241931.t.position;
						if (!(_0024self__00241931.player.transform.position.x <= _0024self__00241931.t.position.x))
						{
							_0024self__00241931.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00241931.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00241931.atking = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00241931.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GhoulScript _0024self__00241932;

		public _0024Attack_00241930(GhoulScript self_)
		{
			_0024self__00241932 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241932);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool canFire;

	public GhoulScript()
	{
		speed = 6f;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(70, 5, 0, 7, 10f, array, Random.Range(6, 20), 8);
		if (MenuScript.multiplayer > 0)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Attack());
		}
		((MonoBehaviour)this).StartCoroutine_Auto(Summon());
	}

	public override IEnumerator Summon()
	{
		return new _0024Summon_00241926(this).GetEnumerator();
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
		return new _0024Attack_00241930(this).GetEnumerator();
	}
}
