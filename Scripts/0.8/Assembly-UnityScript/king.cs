using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class king : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00243011 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024pp2_00243012;

			internal GameObject _0024g_00243013;

			internal king _0024self__00243014;

			public _0024(king self_)
			{
				_0024self__00243014 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Expected O, but got Unknown
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Expected O, but got Unknown
				//IL_017d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Expected O, but got Unknown
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0285: Unknown result type (might be due to invalid IL or missing references)
				//IL_028f: Expected O, but got Unknown
				//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0203: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Unknown result type (might be due to invalid IL or missing references)
				//IL_010b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_011b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Expected O, but got Unknown
				//IL_013f: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024self__00243014.ATKING = true;
					_0024self__00243014.atking = false;
					_0024self__00243014.MOVING = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					((Component)_0024self__00243014).networkView.RPC("ATK", (RPCMode)2, new object[0]);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					((Component)_0024self__00243014).networkView.RPC("ATK2", (RPCMode)2, new object[0]);
					if (Object.op_Implicit((Object)(object)_0024self__00243014.player))
					{
						_0024pp2_00243012 = _0024self__00243014.player.transform.position;
						if (MenuScript.multiplayer > 0)
						{
							if (MenuScript.multiplayer == 1)
							{
								_0024g_00243013 = null;
								_0024g_00243013 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), ((Component)_0024self__00243014).transform.position, Quaternion.identity, 0);
								_0024g_00243013.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00243012 });
							}
							_0024g_00243013.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024pp2_00243012 });
						}
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					if (Object.op_Implicit((Object)(object)_0024self__00243014.player))
					{
						_0024self__00243014.curVector = _0024self__00243014.player.transform.position - _0024self__00243014.t.position;
						if (!(_0024self__00243014.player.transform.position.x <= ((Component)_0024self__00243014).transform.position.x))
						{
							if (MenuScript.multiplayer > 0)
							{
								((Component)_0024self__00243014).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
							}
						}
						else if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00243014).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
						}
					}
					_0024self__00243014.MOVING = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00243014.ATKING = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal king _0024self__00243015;

		public _0024Attack_00243011(king self_)
		{
			_0024self__00243015 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243015);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK2_00243016 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00243017;

			internal king _0024self__00243018;

			public _0024(king self_)
			{
				_0024self__00243018 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Expected O, but got Unknown
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024i_00243017 = default(int);
					_0024self__00243018.CRAZE = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					for (_0024i_00243017 = 0; _0024i_00243017 < 4; _0024i_00243017++)
					{
						_0024self__00243018.swords[_0024i_00243017].collider.enabled = true;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 3:
					for (_0024i_00243017 = 0; _0024i_00243017 < 4; _0024i_00243017++)
					{
						_0024self__00243018.swords[_0024i_00243017].collider.enabled = false;
					}
					_0024self__00243018.CRAZE = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal king _0024self__00243019;

		public _0024ATK2_00243016(king self_)
		{
			_0024self__00243019 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243019);
		}
	}

	public AudioClip roar;

	public GameObject[] swords;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private RaycastHit hit;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private int mask;

	private int spd;

	private bool turning;

	private int mask2;

	private bool ATKING;

	private GameObject player;

	private bool atking;

	private bool towards;

	private bool CRAZE;

	private bool MOVING;

	public king()
	{
		swords = (GameObject[])(object)new GameObject[4];
		speed = 10f;
		mask = 256;
		mask2 = 2048;
	}

	public override void Start()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		@base.animation["i"].layer = 0;
		@base.animation["i"].speed = 0.7f;
		@base.animation["a"].layer = 1;
		@base.animation["a"].speed = 1.5f;
		int[] array = new int[3] { 7, 18, 20 };
		SetStats(1000, 8, 2, 700, 2f, array, Random.Range(10, 25), 700);
		float y = ((Component)this).transform.position.y + (float)Random.Range(3, 10);
		Vector3 position = ((Component)this).transform.position;
		float num = (position.y = y);
		Vector3 val2 = (((Component)this).transform.position = position);
	}

	public override void SetPlayer(GameObject g)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		player = g;
		if (!Object.op_Implicit((Object)(object)player))
		{
			return;
		}
		curVector = player.transform.position - t.position;
		if (!(player.transform.position.x <= ((Component)this).transform.position.x))
		{
			if (MenuScript.multiplayer > 0)
			{
				((Component)this).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
			}
		}
		else if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
		}
	}

	public override void Update()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)player) && MenuScript.multiplayer == 1)
		{
			if (!(Mathf.Abs(player.transform.position.x - t.position.x) >= 50f) && !ATKING)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(Attack(player.transform.position));
			}
			if (MOVING && Object.op_Implicit((Object)(object)player) && !knocking && r.isKinematic)
			{
				t.Translate(((Vector3)(ref curVector)).normalized * 8f * Time.deltaTime);
			}
			if (CRAZE && Object.op_Implicit((Object)(object)player) && !knocking && r.isKinematic)
			{
				t.Translate(((Vector3)(ref curVector)).normalized * 2f * Time.deltaTime);
			}
		}
	}

	public override IEnumerator Attack(Vector3 pp)
	{
		return new _0024Attack_00243011(this).GetEnumerator();
	}

	[RPC]
	public override void ATK()
	{
		@base.animation.Play("a");
		((Component)this).audio.PlayOneShot(roar);
	}

	[RPC]
	public override void Turn(int dir)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (dir == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion val2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion val4 = (e.transform.rotation = rotation2);
		}
	}

	[RPC]
	public override IEnumerator ATK2()
	{
		return new _0024ATK2_00243016(this).GetEnumerator();
	}
}