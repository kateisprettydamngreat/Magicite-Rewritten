using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class octopus : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024GoCrazy_00243092 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024x_00243093;

			internal int _0024y_00243094;

			internal int _0024i_00243095;

			internal octopus _0024self__00243096;

			public _0024(octopus self_)
			{
				_0024self__00243096 = self_;
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
					_0024x_00243093 = Random.Range(-5, 5);
					_0024y_00243094 = Random.Range(-5, 5);
					_0024i_00243095 = default(int);
					_0024self__00243096.crazyVec = new Vector3((float)_0024x_00243093, (float)_0024y_00243094, 0f);
					_0024self__00243096.crazy = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00243096.crazy = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal octopus _0024self__00243097;

		public _0024GoCrazy_00243092(octopus self_)
		{
			_0024self__00243097 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243097);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00243098 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal octopus _0024self__00243099;

			public _0024(octopus self_)
			{
				_0024self__00243099 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_0031: Expected O, but got Unknown
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0127: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					if (Object.op_Implicit((Object)(object)_0024self__00243099.player) && MenuScript.multiplayer == 1)
					{
						_0024self__00243099.curVector = _0024self__00243099.player.transform.position - _0024self__00243099.t.position;
						if (!(_0024self__00243099.player.transform.position.x <= _0024self__00243099.t.position.x))
						{
							((Component)_0024self__00243099).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
						}
						else
						{
							((Component)_0024self__00243099).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
						}
						_0024self__00243099.atking = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00243099.atking = false;
					((Component)_0024self__00243099).rigidbody.velocity = new Vector3(0f, 0f, 0f);
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal octopus _0024self__00243100;

		public _0024Attack_00243098(octopus self_)
		{
			_0024self__00243100 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243100);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool crazy;

	private Vector3 crazyVec;

	public octopus()
	{
		speed = 10f;
	}

	public override IEnumerator GoCrazy()
	{
		return new _0024GoCrazy_00243092(this).GetEnumerator();
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
		return new _0024Attack_00243098(this).GetEnumerator();
	}

	[RPC]
	public override void Turn(int a)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (a == 0)
		{
			e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
		}
		else
		{
			e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
		}
	}
}
