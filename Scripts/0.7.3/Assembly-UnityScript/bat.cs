using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class bat : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GoCrazy_00242539 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024x_00242540;

			internal int _0024y_00242541;

			internal int _0024i_00242542;

			internal bat _0024self__00242543;

			public _0024(bat self_)
			{
				_0024self__00242543 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024x_00242540 = Random.Range(-5, 5);
					_0024y_00242541 = Random.Range(-5, 5);
					_0024i_00242542 = default(int);
					_0024self__00242543.crazyVec = new Vector3((float)_0024x_00242540, (float)_0024y_00242541, 0f);
					_0024self__00242543.crazy = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242543.crazy = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bat _0024self__00242544;

		public _0024GoCrazy_00242539(bat self_)
		{
			_0024self__00242544 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242544);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242545 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bat _0024self__00242546;

			public _0024(bat self_)
			{
				_0024self__00242546 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0101: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_011b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (Object.op_Implicit((Object)(object)_0024self__00242546.player) && MenuScript.multiplayer == 1)
					{
						_0024self__00242546.curVector = _0024self__00242546.player.transform.position - _0024self__00242546.t.position;
						if (!(_0024self__00242546.player.transform.position.x <= _0024self__00242546.t.position.x))
						{
							_0024self__00242546.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00242546.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00242546.atking = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00242546.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bat _0024self__00242547;

		public _0024Attack_00242545(bat self_)
		{
			_0024self__00242547 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242547);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool crazy;

	private Vector3 crazyVec;

	public bat()
	{
		speed = 10f;
	}

	public override IEnumerator GoCrazy()
	{
		return new _0024GoCrazy_00242539(this).GetEnumerator();
	}

	public override void Awake()
	{
		if (MenuScript.multiplayer == 1)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(GoCrazy());
		}
		@base.animation["i"].speed = 0.6f;
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(25, 2, 0, 8, 10f, array, Random.Range(5, 15), 8);
		if (MenuScript.multiplayer > 0)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Attack());
			return;
		}
		if (MenuScript.multiplayer > 0)
		{
			player = GameObject.Find("playerN(Clone)");
		}
		else
		{
			player = GameObject.Find("player(Clone)");
		}
		((MonoBehaviour)this).StartCoroutine_Auto(Attack());
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && MenuScript.multiplayer == 1 && atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 18f) && !knocking && r.isKinematic)
		{
			t.Translate(((Vector3)(ref curVector)).normalized * 15f * Time.deltaTime);
		}
		if (crazy && MenuScript.multiplayer == 1)
		{
			t.Translate(((Vector3)(ref crazyVec)).normalized * 10f * Time.deltaTime);
		}
	}

	public override IEnumerator Attack()
	{
		return new _0024Attack_00242545(this).GetEnumerator();
	}
}
