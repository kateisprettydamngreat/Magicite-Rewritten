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
	internal sealed class _0024GoCrazy_00243058 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024x_00243059;

			internal int _0024y_00243060;

			internal int _0024i_00243061;

			internal bat _0024self__00243062;

			public _0024(bat self_)
			{
				_0024self__00243062 = self_;
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
					_0024x_00243059 = Random.Range(-5, 5);
					_0024y_00243060 = Random.Range(-5, 5);
					_0024i_00243061 = default(int);
					_0024self__00243062.crazyVec = new Vector3((float)_0024x_00243059, (float)_0024y_00243060, 0f);
					_0024self__00243062.crazy = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00243062.crazy = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bat _0024self__00243063;

		public _0024GoCrazy_00243058(bat self_)
		{
			_0024self__00243063 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243063);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00243064 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bat _0024self__00243065;

			public _0024(bat self_)
			{
				_0024self__00243065 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0147: Unknown result type (might be due to invalid IL or missing references)
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
					if (Object.op_Implicit((Object)(object)_0024self__00243065.player) && MenuScript.multiplayer == 1)
					{
						_0024self__00243065.curVector = _0024self__00243065.player.transform.position - _0024self__00243065.t.position;
						if (!(_0024self__00243065.player.transform.position.x <= _0024self__00243065.t.position.x))
						{
							_0024self__00243065.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00243065.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00243065.atking = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00243065.atking = false;
					((Component)_0024self__00243065).rigidbody.velocity = new Vector3(0f, 0f, 0f);
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bat _0024self__00243066;

		public _0024Attack_00243064(bat self_)
		{
			_0024self__00243066 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243066);
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
		return new _0024GoCrazy_00243058(this).GetEnumerator();
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
		int[] array = new int[3] { 0, 15, 17 };
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
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && MenuScript.multiplayer == 1 && atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 10f) && !knocking)
		{
			((Component)this).rigidbody.velocity = ((Vector3)(ref curVector)).normalized * speed;
		}
		if (crazy && MenuScript.multiplayer == 1)
		{
			((Component)this).rigidbody.velocity = ((Vector3)(ref curVector)).normalized * 20f;
		}
	}

	public override IEnumerator Attack()
	{
		return new _0024Attack_00243064(this).GetEnumerator();
	}
}
