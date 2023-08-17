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
	internal sealed class _0024Start_00241345 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal AttackCube _0024self__00241346;

			public _0024(AttackCube self_)
			{
				_0024self__00241346 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!Object.op_Implicit((Object)(object)_0024self__00241346.gameScript))
					{
						_0024self__00241346.gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
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

		internal AttackCube _0024self__00241347;

		public _0024Start_00241345(AttackCube self_)
		{
			_0024self__00241347 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241347);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Anim_00241348 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241349;

			internal int _0024_0024436_00241350;

			internal Vector2 _0024_0024437_00241351;

			internal float _0024_0024438_00241352;

			internal Vector2 _0024_0024439_00241353;

			internal int _0024_0024440_00241354;

			internal Vector2 _0024_0024441_00241355;

			internal AttackCube _0024self__00241356;

			public _0024(AttackCube self_)
			{
				_0024self__00241356 = self_;
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
					_0024i_00241349 = default(int);
					int num = (_0024_0024436_00241350 = 0);
					Vector2 val = (_0024_0024437_00241351 = _0024self__00241356.atkAnim.renderer.material.mainTextureOffset);
					float num2 = (_0024_0024437_00241351.x = _0024_0024436_00241350);
					Vector2 val3 = (_0024self__00241356.atkAnim.renderer.material.mainTextureOffset = _0024_0024437_00241351);
					_0024i_00241349 = 0;
					goto IL_0154;
				}
				case 2:
					_0024i_00241349++;
					goto IL_0154;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0154:
					if (_0024i_00241349 < 3)
					{
						float num3 = (_0024_0024438_00241352 = _0024self__00241356.atkAnim.renderer.material.mainTextureOffset.x + 0.25f);
						Vector2 val4 = (_0024_0024439_00241353 = _0024self__00241356.atkAnim.renderer.material.mainTextureOffset);
						float num4 = (_0024_0024439_00241353.x = _0024_0024438_00241352);
						Vector2 val6 = (_0024self__00241356.atkAnim.renderer.material.mainTextureOffset = _0024_0024439_00241353);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.05f)) ? 1 : 0);
						break;
					}
					num5 = (_0024_0024440_00241354 = 0);
					val7 = (_0024_0024441_00241355 = _0024self__00241356.atkAnim.renderer.material.mainTextureOffset);
					num6 = (_0024_0024441_00241355.x = _0024_0024440_00241354);
					val9 = (_0024self__00241356.atkAnim.renderer.material.mainTextureOffset = _0024_0024441_00241355);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal AttackCube _0024self__00241357;

		public _0024Anim_00241348(AttackCube self_)
		{
			_0024self__00241357 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241357);
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
		else
		{
			gather = 1;
		}
		if (MenuScript.pHat == 1)
		{
			gather += 10;
		}
		cameraScript = (CameraScript)(object)((Component)Camera.main).gameObject.GetComponent("CameraScript");
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241345(this).GetEnumerator();
	}

	public override void OnEnable()
	{
	}

	public override IEnumerator Anim()
	{
		return new _0024Anim_00241348(this).GetEnumerator();
	}

	public override void OnTriggerEnter(Collider c)
	{
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		if (!Object.op_Implicit((Object)(object)((Component)this).gameObject))
		{
			return;
		}
		if (((Component)c).gameObject.tag == "npc" || ((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 11 || ((Component)c).gameObject.layer == 8)
		{
			if (!Object.op_Implicit((Object)(object)((Component)c).gameObject))
			{
				return;
			}
			int num = GameScript.tempPlayerStat[1] + MenuScript.playerStat[1] + GameScript.tempLevelStat[1] + GameScript.drumATK + GameScript.tempGearStat[1] + GameScript.vBonus;
			if (GameScript.rage)
			{
				num *= 2;
			}
			int num2 = Random.Range(0, 100);
			int num3 = 5;
			if (MenuScript.pHat == 15)
			{
				num3 = 25;
			}
			if (num2 <= num3)
			{
				num *= 2;
				if (MenuScript.multiplayer > 0)
				{
					Object.Instantiate((Object)(object)critObj, ((Component)this).transform.position, Quaternion.identity);
				}
				else
				{
					Object.Instantiate((Object)(object)critObj, ((Component)this).transform.position, Quaternion.identity);
				}
			}
			if (MenuScript.multiplayer > 0 && PlayerControllerN.mBonus > 0)
			{
				num += PlayerControllerN.mBonus;
			}
			if (((Component)c).gameObject.layer == 8)
			{
				if (MenuScript.pvp == 1 && !((Component)c).gameObject.networkView.isMine && ((Component)this).networkView.isMine && !((Component)c).gameObject.networkView.isMine)
				{
					MonoBehaviour.print((object)"hitting object not ours.");
					((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/swipe", typeof(AudioClip)));
					((Component)Camera.main).animation.Play("shaake");
					((Component)c).gameObject.networkView.RPC("TD", (RPCMode)2, new object[1] { num });
					((Component)c).gameObject.networkView.RPC("K", (RPCMode)2, new object[1] { GameScript.facingLeft });
				}
			}
			else
			{
				MonoBehaviour.print((object)"hitting object not ours.");
				((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/swipe", typeof(AudioClip)));
				((Component)Camera.main).animation.Play("shaake");
				((Component)c).gameObject.SendMessage("TD", (object)num);
				((Component)c).gameObject.SendMessage("K", (object)GameScript.facingLeft);
				Durability(GameScript.inventory[GameScript.curActiveSlot].id);
			}
		}
		else if (((Component)c).gameObject.layer == 20)
		{
			int id = GameScript.inventory[GameScript.curActiveSlot].id;
			if (((Component)c).gameObject.tag == "tree")
			{
				if (id != 501 && id != 504 && id != 507 && id != 510 && id != 513 && id != 521 && id != 524 && id != 527 && id != 517)
				{
					return;
				}
				((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/chop", typeof(AudioClip)));
				((Component)c).gameObject.SendMessage("TD", (object)GameScript.finalATKChop);
				if (MenuScript.curTrait[1] == 1 || MenuScript.curTrait[2] == 1)
				{
					if (Random.Range(0, 2) == 0)
					{
						Durability(GameScript.inventory[GameScript.curActiveSlot].id);
					}
				}
				else
				{
					Durability(GameScript.inventory[GameScript.curActiveSlot].id);
				}
			}
			else if (((Component)c).gameObject.tag == "ore")
			{
				if (id != 502 && id != 505 && id != 508 && id != 511 && id != 514 && id != 522 && id != 525 && id != 528 && id != 518)
				{
					return;
				}
				((Component)this).audio.PlayOneShot((AudioClip)Resources.Load("Au/mine", typeof(AudioClip)));
				((Component)c).gameObject.SendMessage("TD", (object)GameScript.finalATKMine);
				if (MenuScript.curTrait[1] == 2 || MenuScript.curTrait[2] == 2)
				{
					if (Random.Range(0, 2) == 0)
					{
						Durability(GameScript.inventory[GameScript.curActiveSlot].id);
					}
				}
				else
				{
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
		else
		{
			if (!(((Component)c).gameObject.tag == "chest"))
			{
				return;
			}
			if (((Object)((Component)c).gameObject).name == "chest2(Clone)")
			{
				((Component)Camera.main).animation.Play("shaake");
				if (MenuScript.curTrait[2] == 12 || MenuScript.curTrait[1] == 12)
				{
					((Component)c).SendMessage("Open");
					MenuScript.goldChests++;
				}
			}
			else
			{
				((Component)Camera.main).animation.Play("shaake");
				((Component)c).SendMessage("Open");
			}
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
