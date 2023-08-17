using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ArrowScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241342 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ArrowScript _0024self__00241343;

			public _0024(ArrowScript self_)
			{
				_0024self__00241343 = self_;
			}

			public override bool MoveNext()
			{
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Expected O, but got Unknown
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241343.t = ((Component)_0024self__00241343).transform;
					if (_0024self__00241343.isEnemy)
					{
						_0024self__00241343.speed = 23f;
					}
					if (_0024self__00241343.isRight)
					{
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					((Component)_0024self__00241343).collider.enabled = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 3:
					if (MenuScript.multiplayer > 0)
					{
						Network.Destroy(((Component)_0024self__00241343).gameObject);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241343).gameObject);
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

		internal ArrowScript _0024self__00241344;

		public _0024Start_00241342(ArrowScript self_)
		{
			_0024self__00241344 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241344);
		}
	}

	public bool isBolt;

	public bool isEnemy;

	public Material fireA;

	public GameObject[] @base;

	public GameObject particleFire;

	public GameObject particleMulti;

	public int tier;

	public bool isRight;

	private Renderer r;

	public GameObject lightObj;

	public int min;

	public int max;

	public float wait;

	private float speed;

	private int MAG;

	private bool cantMove;

	private bool initialized;

	private bool left;

	private bool fire;

	private Transform t;

	public ArrowScript()
	{
		@base = (GameObject[])(object)new GameObject[2];
		speed = 30f;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241342(this).GetEnumerator();
	}

	[RPC]
	public override void SetN(int m)
	{
		MAG = m + GetDmg(tier);
	}

	public override void Set(int m)
	{
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("SetN", (RPCMode)m, new object[0]);
		}
		else
		{
			MAG = m + GetDmg(tier);
		}
	}

	[RPC]
	public override void SetMulti()
	{
		particleMulti.SetActive(true);
	}

	public override int GetDmg(int a)
	{
		int num = default(int);
		return a switch
		{
			0 => 1, 
			1 => 1, 
			2 => 4, 
			3 => 11, 
			4 => 20, 
			5 => 40, 
			_ => 1, 
		};
	}

	public override void Update()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (!cantMove)
		{
			if (isRight)
			{
				t.Translate(Vector3.left * Time.deltaTime * (0f - speed));
			}
			else
			{
				t.Translate(Vector3.left * Time.deltaTime * speed);
			}
		}
	}

	public override int GetID(int a)
	{
		int num = default(int);
		return a switch
		{
			0 => 52, 
			1 => 53, 
			2 => 54, 
			3 => 55, 
			4 => 56, 
			5 => 57, 
			_ => 53, 
		};
	}

	[RPC]
	public override void FireN()
	{
		fire = true;
		@base[0].renderer.material = fireA;
		@base[1].renderer.material = fireA;
		particleFire.SetActive(true);
	}

	public override void OnTriggerEnter(Collider c)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)c).gameObject.tag == "fWisp")
		{
			if (MenuScript.multiplayer > 0)
			{
				if (!fire)
				{
					fire = true;
					MAG *= 2;
					((Component)this).networkView.RPC("FireN", (RPCMode)2, new object[0]);
				}
			}
			else if (!fire)
			{
				@base[0].renderer.material = fireA;
				@base[1].renderer.material = fireA;
				particleFire.SetActive(true);
				fire = true;
				MAG *= 2;
			}
		}
		if (!(((Component)this).transform.position.x <= ((Component)c).gameObject.transform.position.x))
		{
			left = true;
		}
		else
		{
			left = false;
		}
		if (!isEnemy && (((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 12))
		{
			cantMove = true;
			((Component)c).gameObject.SendMessage("TD", (object)MAG);
			if (MenuScript.multiplayer > 0)
			{
				Network.Destroy(((Component)this).networkView.viewID);
				Network.RemoveRPCs(((Component)this).networkView.viewID);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
		}
		else if (((Component)c).gameObject.layer == 8)
		{
			if (isEnemy)
			{
				((Component)c).gameObject.SendMessage("TD", (object)MAG);
				Network.Destroy(((Component)this).networkView.viewID);
				Network.RemoveRPCs(((Component)this).networkView.viewID);
			}
			else if (MenuScript.pvp == 1 && !((Component)this).networkView.isMine)
			{
				((Component)c).gameObject.SendMessage("TD", (object)MAG);
				MonoBehaviour.print((object)"hit");
			}
		}
		else if (((Component)c).gameObject.layer == 11 && !isBolt && !initialized && !isEnemy && MenuScript.multiplayer == 1)
		{
			initialized = true;
			cantMove = true;
			Item item = new Item(GetID(tier), 1, new int[4], 0f, null);
			GameObject val = null;
			if (MenuScript.multiplayer > 0)
			{
				val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
				val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
				val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
				val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
			}
			else
			{
				val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
				val.SendMessage("Set", (object)item);
			}
			if (MenuScript.multiplayer > 0)
			{
				Network.Destroy(((Component)this).networkView.viewID);
				Network.RemoveRPCs(((Component)this).networkView.viewID);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
		}
	}

	public override void Main()
	{
	}
}
