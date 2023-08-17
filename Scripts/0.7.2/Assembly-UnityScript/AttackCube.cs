using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class AttackCube : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241092 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal AttackCube _0024self__00241093;

			public _0024(AttackCube self_)
			{
				_0024self__00241093 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!Object.op_Implicit((Object)(object)_0024self__00241093.gameScript))
					{
						_0024self__00241093.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal AttackCube _0024self__00241094;

		public _0024Start_00241092(AttackCube self_)
		{
			_0024self__00241094 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241094);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Anim_00241095 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241096;

			internal int _0024_0024366_00241097;

			internal Vector2 _0024_0024367_00241098;

			internal float _0024_0024368_00241099;

			internal Vector2 _0024_0024369_00241100;

			internal int _0024_0024370_00241101;

			internal Vector2 _0024_0024371_00241102;

			internal AttackCube _0024self__00241103;

			public _0024(AttackCube self_)
			{
				_0024self__00241103 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0137: Unknown result type (might be due to invalid IL or missing references)
				//IL_0141: Expected O, but got Unknown
				//IL_0183: Unknown result type (might be due to invalid IL or missing references)
				//IL_0188: Unknown result type (might be due to invalid IL or missing references)
				//IL_0189: Unknown result type (might be due to invalid IL or missing references)
				//IL_018b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				int result;
				int num5;
				Vector2 val7;
				float num6;
				Vector2 val9;
				switch (base._state)
				{
				default:
				{
					_0024i_00241096 = default(int);
					int num = (_0024_0024366_00241097 = 0);
					Vector2 val = (_0024_0024367_00241098 = _0024self__00241103.atkAnim.renderer.material.mainTextureOffset);
					float num2 = (_0024_0024367_00241098.x = _0024_0024366_00241097);
					Vector2 val3 = (_0024self__00241103.atkAnim.renderer.material.mainTextureOffset = _0024_0024367_00241098);
					_0024i_00241096 = 0;
					goto IL_0154;
				}
				case 2:
					_0024i_00241096++;
					goto IL_0154;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0154:
					if (_0024i_00241096 < 3)
					{
						float num3 = (_0024_0024368_00241099 = _0024self__00241103.atkAnim.renderer.material.mainTextureOffset.x + 0.25f);
						Vector2 val4 = (_0024_0024369_00241100 = _0024self__00241103.atkAnim.renderer.material.mainTextureOffset);
						float num4 = (_0024_0024369_00241100.x = _0024_0024368_00241099);
						Vector2 val6 = (_0024self__00241103.atkAnim.renderer.material.mainTextureOffset = _0024_0024369_00241100);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.05f)) ? 1 : 0);
						break;
					}
					num5 = (_0024_0024370_00241101 = 0);
					val7 = (_0024_0024371_00241102 = _0024self__00241103.atkAnim.renderer.material.mainTextureOffset);
					num6 = (_0024_0024371_00241102.x = _0024_0024370_00241101);
					val9 = (_0024self__00241103.atkAnim.renderer.material.mainTextureOffset = _0024_0024371_00241102);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal AttackCube _0024self__00241104;

		public _0024Anim_00241095(AttackCube self_)
		{
			_0024self__00241104 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241104);
		}
	}

	public GameObject player;

	public GameObject critObj;

	private CameraScript cameraScript;

	public GameObject atkAnim;

	private int gather;

	private GameScript gameScript;

	public AttackCube()
	{
		gather = 1;
	}

	public override void OnLevelWasLoaded(int level)
	{
		gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
	}

	public override void Awake()
	{
		gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
		if (MenuScript.curTrait[1] == 3 || MenuScript.curTrait[2] == 3)
		{
			gather = 2;
		}
		cameraScript = (CameraScript)(object)((Component)Camera.main).gameObject.GetComponent("CameraScript");
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241092(this).GetEnumerator();
	}

	public override void OnEnable()
	{
		MonoBehaviour.print((object)"ENABLEDDD");
	}

	public override IEnumerator Anim()
	{
		return new _0024Anim_00241095(this).GetEnumerator();
	}

	public override void OnTriggerEnter(Collider c)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		if (!Object.op_Implicit((Object)(object)((Component)this).gameObject))
		{
			return;
		}
		if (((Component)c).gameObject.tag == "npc" || ((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 11)
		{
			if (!Object.op_Implicit((Object)(object)((Component)c).gameObject))
			{
				return;
			}
			((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/swipe", typeof(AudioClip)));
			((Component)Camera.main).animation.Play("shaake");
			int num = GameScript.tempPlayerStat[1] + MenuScript.playerStat[1] + GameScript.tempLevelStat[1];
			if (GameScript.rage)
			{
				num *= 2;
			}
			int num2 = Random.Range(0, 100);
			if (num2 < 6)
			{
				num *= 2;
				if (MenuScript.multiplayer <= 0)
				{
					Object.Instantiate((Object)(object)critObj, ((Component)this).transform.position, Quaternion.identity);
				}
				MonoBehaviour.print((object)"CRITICAL HIT!!!!!!!!!!!!!!!!!");
			}
			MonoBehaviour.print((object)("mBonus is " + (object)PlayerController.mBonus));
			MonoBehaviour.print((object)("pre : " + (object)num));
			if (MenuScript.multiplayer > 0)
			{
				if (PlayerControllerN.mBonus > 0)
				{
					num += PlayerControllerN.mBonus;
				}
			}
			else if (PlayerController.mBonus > 0)
			{
				num += PlayerController.mBonus;
			}
			MonoBehaviour.print((object)("post : " + (object)num));
			((Component)c).gameObject.SendMessage("TD", (object)num);
			((Component)c).gameObject.SendMessage("K", (object)GameScript.facingLeft);
			Durability(GameScript.inventory[GameScript.curActiveSlot].id);
		}
		else if (((Component)c).gameObject.layer == 20)
		{
			int id = GameScript.inventory[GameScript.curActiveSlot].id;
			if (((Component)c).gameObject.tag == "tree")
			{
				if (id == 501 || id == 504 || id == 507 || id == 510 || id == 513 || id == 521 || id == 524 || id == 527 || id == 517)
				{
					((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/chop", typeof(AudioClip)));
					((Component)c).gameObject.SendMessage("TD", (object)GameScript.finalATKChop);
					Durability(GameScript.inventory[GameScript.curActiveSlot].id);
				}
			}
			else if (((Component)c).gameObject.tag == "ore")
			{
				if (id == 502 || id == 505 || id == 508 || id == 511 || id == 514 || id == 522 || id == 525 || id == 528)
				{
					((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/mine", typeof(AudioClip)));
					((Component)c).gameObject.SendMessage("TD", (object)GameScript.finalATKMine);
					Durability(GameScript.inventory[GameScript.curActiveSlot].id);
				}
			}
			else if (((Component)c).gameObject.tag == "plant")
			{
				((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/gather", typeof(AudioClip)));
				((Component)c).gameObject.SendMessage("TD", (object)gather);
			}
			else if (((Component)c).gameObject.tag == "bug" && id == 529)
			{
				((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/netSwing", typeof(AudioClip)));
				((Component)c).gameObject.SendMessage("TD", (object)GameScript.finalATKNet);
				Durability(GameScript.inventory[GameScript.curActiveSlot].id);
			}
		}
		else if (((Component)c).gameObject.tag == "chest")
		{
			((Component)Camera.main).animation.Play("shaake");
			((Component)c).SendMessage("Open");
		}
		else if (((Component)c).gameObject.layer == 8 && MenuScript.multiplayer > 0 && !((Component)c).gameObject.networkView.isMine && ((Component)this).networkView.isMine)
		{
			((Component)Camera.main).animation.Play("shaake");
			((Component)c).gameObject.networkView.RPC("TD", (RPCMode)2, new object[1] { 1 });
			((Component)c).gameObject.networkView.RPC("K", (RPCMode)2, new object[1] { GameScript.facingLeft });
		}
	}

	public override void Durability(int id)
	{
		if (id >= 500)
		{
			GameScript.inventory[GameScript.curActiveSlot].d = GameScript.inventory[GameScript.curActiveSlot].d - 1;
			if (GameScript.inventory[GameScript.curActiveSlot].d <= 0)
			{
				GameScript.inventory[GameScript.curActiveSlot].id = 0;
				player.SendMessage("Break");
			}
			else if (GameScript.inventory[GameScript.curActiveSlot].d == 5)
			{
				player.SendMessage("Write", (object)0);
			}
		}
		player.SendMessage("RA");
	}

	public override void Main()
	{
	}
}
