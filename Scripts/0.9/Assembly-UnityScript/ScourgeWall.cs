using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ScourgeWall : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShootStuff_00242550 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242551;

			internal ScourgeWall _0024self__00242552;

			public _0024(ScourgeWall self_)
			{
				_0024self__00242552 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Expected O, but got Unknown
				//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Expected O, but got Unknown
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00242551 = default(int);
					if (MenuScript.multiplayer == 1)
					{
						goto IL_003b;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 2:
					((Component)_0024self__00242552).networkView.RPC("SHOOT", (RPCMode)2, new object[0]);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 3:
					_0024i_00242551 = 0;
					goto IL_00e1;
				case 4:
					_0024i_00242551++;
					goto IL_00e1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00e1:
					if (_0024i_00242551 < 5)
					{
						Network.Instantiate(Resources.Load("ballR"), _0024self__00242552.headPoint.transform.position, Quaternion.identity, 0);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					goto IL_003b;
					IL_003b:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(4, 7))) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeWall _0024self__00242553;

		public _0024ShootStuff_00242550(ScourgeWall self_)
		{
			_0024self__00242553 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242553);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242554 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024dmg_00242555;

			internal ScourgeWall _0024self__00242556;

			public _0024(int dmg, ScourgeWall self_)
			{
				_0024dmg_00242555 = dmg;
				_0024self__00242556 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242556.hp -= _0024dmg_00242555;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242557;

		internal ScourgeWall _0024self__00242558;

		public _0024TDN_00242554(int dmg, ScourgeWall self_)
		{
			_0024dmg_00242557 = dmg;
			_0024self__00242558 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242557, _0024self__00242558);
		}
	}

	private Transform t;

	private GameObject player;

	private int hp;

	public GameObject e;

	public GameObject mainHead;

	public GameObject headPoint;

	public ScourgeWall()
	{
		hp = 4500;
	}

	public override void Start()
	{
		if (MenuScript.multiplayer == 1)
		{
			int num = 0;
			num += Network.connections.Length * 700;
			((Component)this).networkView.RPC("HPSET", (RPCMode)6, new object[1] { num });
		}
		mainHead.animation["i"].layer = 0;
		mainHead.animation["a"].layer = 1;
		mainHead.animation["a"].speed = 0.7f;
		t = ((Component)this).transform;
		((MonoBehaviour)this).StartCoroutine_Auto(ShootStuff());
	}

	[RPC]
	public override void HPSET(int BONUS)
	{
		hp += BONUS;
	}

	[RPC]
	public override void SHOOT()
	{
		mainHead.animation.Play("a");
	}

	[RPC]
	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override IEnumerator ShootStuff()
	{
		return new _0024ShootStuff_00242550(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		t.Translate(Vector3.left * -1.5f * Time.deltaTime);
		if (Object.op_Implicit((Object)(object)player))
		{
			if (!(player.transform.position.y + 1f <= t.position.y))
			{
				t.Translate(Vector3.up * 1f * Time.deltaTime);
			}
			else if (!(player.transform.position.y - 1f >= t.position.y))
			{
				t.Translate(Vector3.up * -1f * Time.deltaTime);
			}
		}
	}

	public override void TD(int dmg)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer > 0)
		{
			GameObject val = (GameObject)Network.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), t.position, Quaternion.identity, 0);
			val.networkView.RPC("SDN", (RPCMode)2, new object[1] { dmg });
			((Component)this).networkView.RPC("TDN", (RPCMode)6, new object[1] { dmg });
		}
		if (hp <= 0)
		{
			((Component)this).networkView.RPC("Win", (RPCMode)6, new object[0]);
			Network.Destroy(((Component)this).networkView.viewID);
		}
	}

	public override void OnCollisionEnter(Collision c)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (c.gameObject.layer == 8)
		{
			c.gameObject.SendMessage("TD", (object)75);
			int num = 40;
			Vector3 velocity = c.gameObject.rigidbody.velocity;
			float num2 = (velocity.x = num);
			Vector3 val2 = (c.gameObject.rigidbody.velocity = velocity);
		}
	}

	[RPC]
	public override void Win()
	{
		GameScript.win = true;
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242554(dmg, this).GetEnumerator();
	}

	public override void K()
	{
	}

	[RPC]
	public override void KN()
	{
	}

	[RPC]
	public override void Knock22()
	{
	}

	public override void Main()
	{
	}
}
