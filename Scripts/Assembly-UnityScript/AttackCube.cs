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
	internal sealed class _0024Start_00241202 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal AttackCube _0024self__00241203;

			public _0024(AttackCube self_)
			{
				_0024self__00241203 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241203.gameScript)
					{
						_0024self__00241203.gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
					}
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal AttackCube _0024self__00241204;

		public _0024Start_00241202(AttackCube self_)
		{
			_0024self__00241204 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241204);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Anim_00241205 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241206;

			internal int _0024_0024409_00241207;

			internal Vector2 _0024_0024410_00241208;

			internal float _0024_0024411_00241209;

			internal Vector2 _0024_0024412_00241210;

			internal int _0024_0024413_00241211;

			internal Vector2 _0024_0024414_00241212;

			internal AttackCube _0024self__00241213;

			public _0024(AttackCube self_)
			{
				_0024self__00241213 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				int num5;
				Vector2 vector7;
				float num6;
				Vector2 vector9;
				switch (_state)
				{
				default:
				{
					_0024i_00241206 = default(int);
					int num = (_0024_0024409_00241207 = 0);
					Vector2 vector = (_0024_0024410_00241208 = _0024self__00241213.atkAnim.GetComponent<Renderer>().material.mainTextureOffset);
					float num2 = (_0024_0024410_00241208.x = _0024_0024409_00241207);
					Vector2 vector3 = (_0024self__00241213.atkAnim.GetComponent<Renderer>().material.mainTextureOffset = _0024_0024410_00241208);
					_0024i_00241206 = 0;
					goto IL_0154;
				}
				case 2:
					_0024i_00241206++;
					goto IL_0154;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0154:
					if (_0024i_00241206 < 3)
					{
						float num3 = (_0024_0024411_00241209 = _0024self__00241213.atkAnim.GetComponent<Renderer>().material.mainTextureOffset.x + 0.25f);
						Vector2 vector4 = (_0024_0024412_00241210 = _0024self__00241213.atkAnim.GetComponent<Renderer>().material.mainTextureOffset);
						float num4 = (_0024_0024412_00241210.x = _0024_0024411_00241209);
						Vector2 vector6 = (_0024self__00241213.atkAnim.GetComponent<Renderer>().material.mainTextureOffset = _0024_0024412_00241210);
						result = (Yield(2, new WaitForSeconds(0.05f)) ? 1 : 0);
						break;
					}
					num5 = (_0024_0024413_00241211 = 0);
					vector7 = (_0024_0024414_00241212 = _0024self__00241213.atkAnim.GetComponent<Renderer>().material.mainTextureOffset);
					num6 = (_0024_0024414_00241212.x = _0024_0024413_00241211);
					vector9 = (_0024self__00241213.atkAnim.GetComponent<Renderer>().material.mainTextureOffset = _0024_0024414_00241212);
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal AttackCube _0024self__00241214;

		public _0024Anim_00241205(AttackCube self_)
		{
			_0024self__00241214 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241214);
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

	public virtual void OnLevelWasLoaded(int level)
	{
		gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
	}

	public virtual void Awake()
	{
		gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
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
		cameraScript = (CameraScript)Camera.main.gameObject.GetComponent("CameraScript");
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241202(this).GetEnumerator();
	}

	public virtual void OnEnable()
	{
	}

	public virtual IEnumerator Anim()
	{
		return new _0024Anim_00241205(this).GetEnumerator();
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (!gameObject)
		{
			return;
		}
		if (c.gameObject.tag == "npc" || c.gameObject.layer == 9 || c.gameObject.layer == 11 || c.gameObject.layer == 8)
		{
			if (!c.gameObject)
			{
				return;
			}
			int num = GameScript.tempPlayerStat[1] + MenuScript.playerStat[1] + GameScript.tempLevelStat[1] + GameScript.drumATK + GameScript.tempGearStat[1] + GameScript.vBonus;
			if (GameScript.rage)
			{
				num *= 2;
			}
			int num2 = UnityEngine.Random.Range(0, 100);
			int num3 = 5;
			if (MenuScript.pHat == 15)
			{
				num3 = 25;
			}
			if (num2 <= num3)
			{
				num *= 2;
				UnityEngine.Object.Instantiate(critObj, transform.position, Quaternion.identity);
			}
			if (PlayerControllerN.mBonus > 0)
			{
				num += PlayerControllerN.mBonus;
			}
			if (c.gameObject.layer == 8)
			{
				if (MenuScript.pvp == 1 && !c.gameObject.GetComponent<NetworkView>().isMine && GetComponent<NetworkView>().isMine && !c.gameObject.GetComponent<NetworkView>().isMine)
				{
					MonoBehaviour.print("hitting object not ours.");
					GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/swipe", typeof(AudioClip)));
					Camera.main.GetComponent<Animation>().Play("shaake");
					c.gameObject.GetComponent<NetworkView>().RPC("TD", RPCMode.All, num);
					c.gameObject.GetComponent<NetworkView>().RPC("K", RPCMode.All, GameScript.facingLeft);
				}
			}
			else
			{
				GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/swipe", typeof(AudioClip)));
				Camera.main.GetComponent<Animation>().Play("shaake");
				if (GameScript.debugMode)
				{
					num = 99999;
				}
				c.gameObject.SendMessage("TD", num);
				c.gameObject.SendMessage("K", GameScript.facingLeft);
				Durability(GameScript.inventory[GameScript.curActiveSlot].id);
			}
		}
		else if (c.gameObject.layer == 20)
		{
			int id = GameScript.inventory[GameScript.curActiveSlot].id;
			if (c.gameObject.tag == "tree")
			{
				if (id != 501 && id != 504 && id != 507 && id != 510 && id != 513 && id != 521 && id != 524 && id != 527 && id != 517)
				{
					return;
				}
				GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/chop", typeof(AudioClip)));
				c.gameObject.SendMessage("TD", GameScript.finalATKChop);
				if (MenuScript.curTrait[1] == 1 || MenuScript.curTrait[2] == 1)
				{
					if (UnityEngine.Random.Range(0, 2) == 0)
					{
						Durability(GameScript.inventory[GameScript.curActiveSlot].id);
					}
				}
				else
				{
					Durability(GameScript.inventory[GameScript.curActiveSlot].id);
				}
			}
			else if (c.gameObject.tag == "ore")
			{
				if (id != 502 && id != 505 && id != 508 && id != 511 && id != 514 && id != 522 && id != 525 && id != 528 && id != 518)
				{
					return;
				}
				GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/mine", typeof(AudioClip)));
				c.gameObject.SendMessage("TD", GameScript.finalATKMine);
				if (MenuScript.curTrait[1] == 2 || MenuScript.curTrait[2] == 2)
				{
					if (UnityEngine.Random.Range(0, 2) == 0)
					{
						Durability(GameScript.inventory[GameScript.curActiveSlot].id);
					}
				}
				else
				{
					Durability(GameScript.inventory[GameScript.curActiveSlot].id);
				}
			}
			else if (c.gameObject.tag == "plant")
			{
				GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/gather", typeof(AudioClip)));
				c.gameObject.SendMessage("TD", gather);
			}
			else if (c.gameObject.tag == "bug" && id == 529)
			{
				GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/netSwing", typeof(AudioClip)));
				c.gameObject.SendMessage("TD", GameScript.finalATKNet);
				Durability(GameScript.inventory[GameScript.curActiveSlot].id);
			}
		}
		else
		{
			if (!(c.gameObject.tag == "chest"))
			{
				return;
			}
			if (c.gameObject.name == "chest2(Clone)")
			{
				Camera.main.GetComponent<Animation>().Play("shaake");
				if (MenuScript.curTrait[2] == 12 || MenuScript.curTrait[1] == 12)
				{
					c.SendMessage("Open");
					MenuScript.goldChests++;
				}
			}
			else
			{
				Camera.main.GetComponent<Animation>().Play("shaake");
				c.SendMessage("Open");
			}
		}
	}

	public virtual void Durability(int id)
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

	public virtual void Main()
	{
	}
}
