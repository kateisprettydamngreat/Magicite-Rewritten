using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class LightBlast : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242124 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal LightBlast _0024self__00242125;

			public _0024(LightBlast self_)
			{
				_0024self__00242125 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected O, but got Unknown
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242125.t = ((Component)_0024self__00242125).transform;
					if (_0024self__00242125.isRight)
					{
					}
					((Component)_0024self__00242125).collider.enabled = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						Network.Destroy(((Component)_0024self__00242125).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00242125).gameObject);
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

		internal LightBlast _0024self__00242126;

		public _0024Start_00242124(LightBlast self_)
		{
			_0024self__00242126 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242126);
		}
	}

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

	private int baseDMG;

	private Transform t;

	public LightBlast()
	{
		@base = (GameObject[])(object)new GameObject[2];
		speed = 32f;
		baseDMG = 150;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242124(this).GetEnumerator();
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
		MonoBehaviour.print((object)((object)MAG + "IS sTRENGTH " + (object)m + " is m"));
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
			1 => 1, 
			2 => 2, 
			3 => 4, 
			4 => 8, 
			_ => 1, 
		};
	}

	public override void Update()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		speed += 10f * Time.deltaTime;
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
		@base[0].renderer.material = fireA;
		@base[1].renderer.material = fireA;
		particleFire.SetActive(true);
	}

	public override void OnTriggerEnter(Collider c)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		if (!(((Component)this).transform.position.x <= ((Component)c).gameObject.transform.position.x))
		{
			left = true;
		}
		else
		{
			left = false;
		}
		if (((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 12)
		{
			cantMove = true;
			((Component)c).gameObject.SendMessage("TD", (object)150);
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
			if (MenuScript.multiplayer > 0 && !((Component)c).gameObject.networkView.isMine && ((Component)this).networkView.isMine)
			{
				((Component)c).gameObject.networkView.RPC("TD", (RPCMode)2, new object[1] { 150 });
				Network.Destroy(((Component)this).networkView.viewID);
				Network.RemoveRPCs(((Component)this).networkView.viewID);
			}
		}
		else if (((Component)c).gameObject.layer == 11 && !initialized)
		{
			initialized = true;
			cantMove = true;
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
