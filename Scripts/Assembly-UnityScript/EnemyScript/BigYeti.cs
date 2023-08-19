using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BigYeti : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Check_00241221 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024prevHP_00241222;

			internal int _0024num_00241223;

			internal BigYeti _0024self__00241224;

			public _0024(BigYeti self_)
			{
				_0024self__00241224 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024prevHP_00241222 = default(int);
					goto case 4;
				case 4:
					_0024prevHP_00241222 = _0024self__00241224.HP;
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241224.HP < _0024prevHP_00241222 && Network.isServer)
					{
						_0024num_00241223 = UnityEngine.Random.Range(0, 2);
						if (_0024num_00241223 == 0 && !_0024self__00241224.roaring)
						{
							_0024self__00241224.roaring = true;
							_0024self__00241224.GetComponent<NetworkView>().RPC("ROAR", RPCMode.All);
							_0024self__00241224.StartCoroutine_Auto(_0024self__00241224.Meteor());
							result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
							break;
						}
					}
					goto IL_00fa;
				case 3:
					_0024self__00241224.roaring = false;
					goto IL_00fa;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00fa:
					result = (Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal BigYeti _0024self__00241225;

		public _0024Check_00241221(BigYeti self_)
		{
			_0024self__00241225 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241225);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Meteor_00241226 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241227;

			internal GameObject _0024g_00241228;

			internal Vector3 _0024pp2_00241229;

			internal BigYeti _0024self__00241230;

			public _0024(BigYeti self_)
			{
				_0024self__00241230 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (Network.isServer)
					{
						_0024i_00241227 = default(int);
						_0024self__00241230.atking = true;
						_0024g_00241228 = null;
						_0024pp2_00241229 = default(Vector3);
						if (!(_0024self__00241230.e.transform.rotation.y <= 0.1f))
						{
							_0024pp2_00241229 = new Vector3(1f, 0f, 0f);
						}
						else
						{
							_0024pp2_00241229 = new Vector3(-1f, 0f, 0f);
						}
						MonoBehaviour.print(_0024self__00241230.e.transform.rotation.y + "is rotation");
						result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0281;
				case 2:
					_0024g_00241228 = (GameObject)Network.Instantiate(Resources.Load("haz/yetiSnow"), _0024self__00241230.transform.position, Quaternion.identity, 0);
					_0024g_00241228.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00241229);
					_0024pp2_00241229.y += 0.25f;
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024g_00241228 = (GameObject)Network.Instantiate(Resources.Load("haz/yetiSnow"), _0024self__00241230.transform.position, Quaternion.identity, 0);
					_0024g_00241228.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00241229);
					_0024pp2_00241229.y -= 0.5f;
					result = (Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024g_00241228 = (GameObject)Network.Instantiate(Resources.Load("haz/yetiSnow"), _0024self__00241230.transform.position, Quaternion.identity, 0);
					_0024g_00241228.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00241229);
					result = (Yield(5, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241230.atking = false;
					goto IL_0281;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0281:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BigYeti _0024self__00241231;

		public _0024Meteor_00241226(BigYeti self_)
		{
			_0024self__00241231 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241231);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00241232 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BigYeti _0024self__00241233;

			public _0024(BigYeti self_)
			{
				_0024self__00241233 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241233.charging && Network.isServer && !_0024self__00241233.atking)
					{
						_0024self__00241233.charging = true;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0112;
				case 2:
					_0024self__00241233.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241233.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					_0024self__00241233.spdd = 8;
					result = (Yield(4, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241233.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00241233.spdd = 0;
					_0024self__00241233.charging = false;
					goto IL_0112;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0112:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BigYeti _0024self__00241234;

		public _0024ChargeRight_00241232(BigYeti self_)
		{
			_0024self__00241234 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241234);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00241235 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BigYeti _0024self__00241236;

			public _0024(BigYeti self_)
			{
				_0024self__00241236 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241236.charging && Network.isServer && !_0024self__00241236.atking)
					{
						_0024self__00241236.charging = true;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0113;
				case 2:
					_0024self__00241236.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241236.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					_0024self__00241236.spdd = -8;
					result = (Yield(4, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241236.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00241236.spdd = 0;
					_0024self__00241236.charging = false;
					goto IL_0113;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0113:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BigYeti _0024self__00241237;

		public _0024ChargeLeft_00241235(BigYeti self_)
		{
			_0024self__00241237 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241237);
		}
	}

	private GameObject player;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private bool roaring;

	private bool atking;

	private Ray r2U;

	public BigYeti()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(150, 4, 0, 40, 10f, array, UnityEngine.Random.Range(6, 20), 40);
		StartCoroutine_Auto(Check());
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
		if (Physics.Raycast(r1U, 3f, mask2) && e.transform.rotation.y == 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 3f, mask2) && e.transform.rotation.y != 0f && Network.isServer)
		{
			GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
			spdd *= -1;
		}
		if ((bool)player && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 30f) && !knocking)
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
		if (charging && !knocking)
		{
			int num = spdd;
			Vector3 velocity = r.velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (r.velocity = velocity);
		}
		else
		{
			int num3 = 0;
			Vector3 velocity2 = r.velocity;
			float num4 = (velocity2.x = num3);
			Vector3 vector4 = (r.velocity = velocity2);
		}
		if (roaring)
		{
			int num5 = 0;
			Vector3 velocity3 = r.velocity;
			float num6 = (velocity3.x = num5);
			Vector3 vector6 = (r.velocity = velocity3);
		}
	}

	public virtual IEnumerator Check()
	{
		return new _0024Check_00241221(this).GetEnumerator();
	}

	public virtual IEnumerator Meteor()
	{
		return new _0024Meteor_00241226(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00241232(this).GetEnumerator();
	}

	public virtual IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00241235(this).GetEnumerator();
	}

	[RPC]
	public virtual void Turn(int a)
	{
		if ((bool)e)
		{
			if (a == 0)
			{
				int num = 0;
				Quaternion rotation = e.transform.rotation;
				float num2 = (rotation.y = num);
				Quaternion quaternion2 = (e.transform.rotation = rotation);
			}
			else
			{
				int num3 = 180;
				Quaternion rotation2 = e.transform.rotation;
				float num4 = (rotation2.y = num3);
				Quaternion quaternion4 = (e.transform.rotation = rotation2);
			}
		}
	}

	[RPC]
	public virtual void ROAR()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("a");
		}
	}

	[RPC]
	public virtual void ATK()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("r");
		}
	}

	[RPC]
	public virtual void SUMMON()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("a");
		}
	}

	[RPC]
	public virtual void IDLE()
	{
		if ((bool)@base)
		{
			@base.GetComponent<Animation>().Play("i");
		}
	}
}
