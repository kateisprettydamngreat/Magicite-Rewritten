using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Percyl : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00242130 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242131;

			internal int _0024_0024705_00242132;

			internal Vector3 _0024_0024706_00242133;

			internal int _0024_0024707_00242134;

			internal Vector3 _0024_0024708_00242135;

			internal int _0024_0024709_00242136;

			internal Vector3 _0024_0024710_00242137;

			internal int _0024_0024711_00242138;

			internal Vector3 _0024_0024712_00242139;

			internal int _0024_0024713_00242140;

			internal Vector3 _0024_0024714_00242141;

			internal int _0024_0024715_00242142;

			internal Vector3 _0024_0024716_00242143;

			internal Percyl _0024self__00242144;

			public _0024(Percyl self_)
			{
				_0024self__00242144 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242144.charging && Network.isServer)
					{
						_0024self__00242144.charging = true;
						_0024num_00242131 = UnityEngine.Random.Range(0, 3);
						if (_0024num_00242131 == 0)
						{
							_0024self__00242144.spdd = 0;
							_0024self__00242144.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
							_0024self__00242144.GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
							int num11 = (_0024_0024705_00242132 = 5);
							Vector3 vector16 = (_0024_0024706_00242133 = _0024self__00242144.r.velocity);
							float num12 = (_0024_0024706_00242133.y = _0024_0024705_00242132);
							Vector3 vector18 = (_0024self__00242144.r.velocity = _0024_0024706_00242133);
							_0024self__00242144.GetComponent<NetworkView>().RPC("RUN2", RPCMode.All);
							result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242144.spdd = 0;
							_0024self__00242144.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
							_0024self__00242144.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
							result = (Yield(6, new WaitForSeconds(0.5f)) ? 1 : 0);
						}
						break;
					}
					goto IL_0424;
				case 2:
				{
					int num9 = (_0024_0024707_00242134 = 25);
					Vector3 vector13 = (_0024_0024708_00242135 = _0024self__00242144.r.velocity);
					float num10 = (_0024_0024708_00242135.x = _0024_0024707_00242134);
					Vector3 vector15 = (_0024self__00242144.r.velocity = _0024_0024708_00242135);
					result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				case 3:
				{
					int num7 = (_0024_0024709_00242136 = 25);
					Vector3 vector10 = (_0024_0024710_00242137 = _0024self__00242144.r.velocity);
					float num8 = (_0024_0024710_00242137.x = _0024_0024709_00242136);
					Vector3 vector12 = (_0024self__00242144.r.velocity = _0024_0024710_00242137);
					result = (Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				case 4:
				{
					int num5 = (_0024_0024711_00242138 = 25);
					Vector3 vector7 = (_0024_0024712_00242139 = _0024self__00242144.r.velocity);
					float num6 = (_0024_0024712_00242139.x = _0024_0024711_00242138);
					Vector3 vector9 = (_0024self__00242144.r.velocity = _0024_0024712_00242139);
					result = (Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 5:
					_0024self__00242144.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242144.spdd = 0;
					goto IL_0405;
				case 6:
				{
					int num = (_0024_0024713_00242140 = 30);
					Vector3 vector = (_0024_0024714_00242141 = _0024self__00242144.r.velocity);
					float num2 = (_0024_0024714_00242141.y = _0024_0024713_00242140);
					Vector3 vector3 = (_0024self__00242144.r.velocity = _0024_0024714_00242141);
					int num3 = (_0024_0024715_00242142 = 20);
					Vector3 vector4 = (_0024_0024716_00242143 = _0024self__00242144.r.velocity);
					float num4 = (_0024_0024716_00242143.x = _0024_0024715_00242142);
					Vector3 vector6 = (_0024self__00242144.r.velocity = _0024_0024716_00242143);
					result = (Yield(7, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				}
				case 7:
					_0024self__00242144.spdd = 0;
					goto IL_0405;
				case 8:
					_0024self__00242144.charging = false;
					goto IL_0424;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0405:
					result = (Yield(8, new WaitForSeconds(1f)) ? 1 : 0);
					break;
					IL_0424:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Percyl _0024self__00242145;

		public _0024ChargeRight_00242130(Percyl self_)
		{
			_0024self__00242145 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242145);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00242146 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242147;

			internal int _0024_0024717_00242148;

			internal Vector3 _0024_0024718_00242149;

			internal int _0024_0024719_00242150;

			internal Vector3 _0024_0024720_00242151;

			internal int _0024_0024721_00242152;

			internal Vector3 _0024_0024722_00242153;

			internal int _0024_0024723_00242154;

			internal Vector3 _0024_0024724_00242155;

			internal int _0024_0024725_00242156;

			internal Vector3 _0024_0024726_00242157;

			internal int _0024_0024727_00242158;

			internal Vector3 _0024_0024728_00242159;

			internal Percyl _0024self__00242160;

			public _0024(Percyl self_)
			{
				_0024self__00242160 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242160.charging && Network.isServer)
					{
						_0024self__00242160.charging = true;
						_0024num_00242147 = UnityEngine.Random.Range(0, 3);
						if (_0024num_00242147 == 0)
						{
							_0024self__00242160.spdd = 0;
							_0024self__00242160.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
							_0024self__00242160.GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
							int num11 = (_0024_0024717_00242148 = 5);
							Vector3 vector16 = (_0024_0024718_00242149 = _0024self__00242160.r.velocity);
							float num12 = (_0024_0024718_00242149.y = _0024_0024717_00242148);
							Vector3 vector18 = (_0024self__00242160.r.velocity = _0024_0024718_00242149);
							_0024self__00242160.GetComponent<NetworkView>().RPC("RUN2", RPCMode.All);
							result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242160.spdd = 0;
							_0024self__00242160.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
							_0024self__00242160.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
							result = (Yield(6, new WaitForSeconds(0.5f)) ? 1 : 0);
						}
						break;
					}
					goto IL_0424;
				case 2:
				{
					int num9 = (_0024_0024719_00242150 = -25);
					Vector3 vector13 = (_0024_0024720_00242151 = _0024self__00242160.r.velocity);
					float num10 = (_0024_0024720_00242151.x = _0024_0024719_00242150);
					Vector3 vector15 = (_0024self__00242160.r.velocity = _0024_0024720_00242151);
					result = (Yield(3, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				case 3:
				{
					int num7 = (_0024_0024721_00242152 = -25);
					Vector3 vector10 = (_0024_0024722_00242153 = _0024self__00242160.r.velocity);
					float num8 = (_0024_0024722_00242153.x = _0024_0024721_00242152);
					Vector3 vector12 = (_0024self__00242160.r.velocity = _0024_0024722_00242153);
					result = (Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				case 4:
				{
					int num5 = (_0024_0024723_00242154 = -25);
					Vector3 vector7 = (_0024_0024724_00242155 = _0024self__00242160.r.velocity);
					float num6 = (_0024_0024724_00242155.x = _0024_0024723_00242154);
					Vector3 vector9 = (_0024self__00242160.r.velocity = _0024_0024724_00242155);
					result = (Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 5:
					_0024self__00242160.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00242160.spdd = 0;
					goto IL_0405;
				case 6:
				{
					int num = (_0024_0024725_00242156 = 30);
					Vector3 vector = (_0024_0024726_00242157 = _0024self__00242160.r.velocity);
					float num2 = (_0024_0024726_00242157.y = _0024_0024725_00242156);
					Vector3 vector3 = (_0024self__00242160.r.velocity = _0024_0024726_00242157);
					int num3 = (_0024_0024727_00242158 = -20);
					Vector3 vector4 = (_0024_0024728_00242159 = _0024self__00242160.r.velocity);
					float num4 = (_0024_0024728_00242159.x = _0024_0024727_00242158);
					Vector3 vector6 = (_0024self__00242160.r.velocity = _0024_0024728_00242159);
					result = (Yield(7, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				}
				case 7:
					_0024self__00242160.spdd = 0;
					goto IL_0405;
				case 8:
					_0024self__00242160.charging = false;
					goto IL_0424;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0405:
					result = (Yield(8, new WaitForSeconds(1f)) ? 1 : 0);
					break;
					IL_0424:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Percyl _0024self__00242161;

		public _0024ChargeLeft_00242146(Percyl self_)
		{
			_0024self__00242161 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242161);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	public Percyl()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 19, 20, 17 };
		SetStats(600, 4, 0, 4, 200f, array, UnityEngine.Random.Range(6, 20), 200);
		@base.GetComponent<Animation>()["r1"].layer = 2;
		@base.GetComponent<Animation>()["r2"].layer = 1;
		@base.GetComponent<Animation>()["i"].layer = 1;
		@base.GetComponent<Animation>()["a"].layer = 2;
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		r1U.origin = transform.position;
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		r2U.direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.5f, mask2) && e.transform.rotation.y == 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 1.5f, mask2) && e.transform.rotation.y != 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
			spdd *= -1;
		}
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !knocking && Network.isServer)
		{
			if (!(player.transform.position.x <= t.position.x))
			{
				StartCoroutine_Auto(ChargeRight());
			}
			else
			{
				StartCoroutine_Auto(ChargeLeft());
			}
		}
		if (charging && knocking)
		{
		}
	}

	public virtual IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00242130(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00242146(this).GetEnumerator();
	}

	[RPC]
	public virtual void Turn(int a)
	{
		if (a == 0)
		{
			int num = 180;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion quaternion2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 0;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion quaternion4 = (e.transform.rotation = rotation2);
		}
	}

	[RPC]
	public virtual void ATK()
	{
		@base.GetComponent<Animation>().Play("a");
	}

	[RPC]
	public virtual void RUN()
	{
		@base.GetComponent<Animation>().Play("r1");
	}

	[RPC]
	public virtual void RUN2()
	{
		@base.GetComponent<Animation>().Play("r2");
	}

	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}
}
