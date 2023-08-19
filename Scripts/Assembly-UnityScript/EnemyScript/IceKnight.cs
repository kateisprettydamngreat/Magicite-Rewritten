using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class IceKnight : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FaceRight_00241879 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024631_00241880;

			internal Vector3 _0024_0024632_00241881;

			internal IceKnight _0024self__00241882;

			public _0024(IceKnight self_)
			{
				_0024self__00241882 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241882.atking && Network.isServer && !_0024self__00241882.running)
					{
						int num = (_0024_0024631_00241880 = 8);
						Vector3 vector = (_0024_0024632_00241881 = _0024self__00241882.r.velocity);
						float num2 = (_0024_0024632_00241881.y = _0024_0024631_00241880);
						Vector3 vector3 = (_0024self__00241882.r.velocity = _0024_0024632_00241881);
						_0024self__00241882.running = true;
						_0024self__00241882.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						_0024self__00241882.GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
						_0024self__00241882.spdd = UnityEngine.Random.Range(-1, 2) * 4;
						if (_0024self__00241882.spdd == 0)
						{
							_0024self__00241882.spdd = 4;
						}
						result = (Yield(2, new WaitForSeconds((float)UnityEngine.Random.Range(1, 3) * 0.3f)) ? 1 : 0);
						break;
					}
					goto IL_015a;
				case 2:
					_0024self__00241882.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00241882.running = false;
					goto IL_015a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_015a:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal IceKnight _0024self__00241883;

		public _0024FaceRight_00241879(IceKnight self_)
		{
			_0024self__00241883 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241883);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FaceLeft_00241884 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024633_00241885;

			internal Vector3 _0024_0024634_00241886;

			internal IceKnight _0024self__00241887;

			public _0024(IceKnight self_)
			{
				_0024self__00241887 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241887.atking && Network.isServer && !_0024self__00241887.running)
					{
						int num = (_0024_0024633_00241885 = 8);
						Vector3 vector = (_0024_0024634_00241886 = _0024self__00241887.r.velocity);
						float num2 = (_0024_0024634_00241886.y = _0024_0024633_00241885);
						Vector3 vector3 = (_0024self__00241887.r.velocity = _0024_0024634_00241886);
						_0024self__00241887.running = true;
						_0024self__00241887.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						_0024self__00241887.GetComponent<NetworkView>().RPC("RUN", RPCMode.All);
						_0024self__00241887.spdd = UnityEngine.Random.Range(-1, 2) * 4;
						if (_0024self__00241887.spdd == 0)
						{
							_0024self__00241887.spdd = -4;
						}
						result = (Yield(2, new WaitForSeconds((float)UnityEngine.Random.Range(1, 2) * 0.3f)) ? 1 : 0);
						break;
					}
					goto IL_015b;
				case 2:
					_0024self__00241887.GetComponent<NetworkView>().RPC("IDLE", RPCMode.All);
					_0024self__00241887.running = false;
					goto IL_015b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_015b:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal IceKnight _0024self__00241888;

		public _0024FaceLeft_00241884(IceKnight self_)
		{
			_0024self__00241888 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241888);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TRY_00241889 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal IceKnight _0024self__00241890;

			public _0024(IceKnight self_)
			{
				_0024self__00241890 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241890.TRYatking = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal IceKnight _0024self__00241891;

		public _0024TRY_00241889(IceKnight self_)
		{
			_0024self__00241891 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241891);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATTACK_00241892 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal IceKnight _0024self__00241893;

			public _0024(IceKnight self_)
			{
				_0024self__00241893 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241893.atking = true;
					_0024self__00241893.spdd = 0;
					_0024self__00241893.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					result = (Yield(2, new WaitForSeconds(0.35f)) ? 1 : 0);
					break;
				case 2:
					result = (Yield(3, new WaitForSeconds(1.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241893.atking = false;
					_0024self__00241893.TRYatking = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal IceKnight _0024self__00241894;

		public _0024ATTACK_00241892(IceKnight self_)
		{
			_0024self__00241894 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241894);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00241895 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal IceKnight _0024self__00241896;

			public _0024(IceKnight self_)
			{
				_0024self__00241896 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241896.@base.GetComponent<Animation>().Play("a");
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241896.swordBox.SetActive(value: true);
					result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241896.swordBox.SetActive(value: false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal IceKnight _0024self__00241897;

		public _0024ATK_00241895(IceKnight self_)
		{
			_0024self__00241897 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241897);
		}
	}

	public GameObject swordBox;

	public AudioClip audioMove;

	public AudioClip audioAttack;

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

	private bool running;

	private bool TRYatking;

	public IceKnight()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(35, 4, 0, 4, 10f, array, UnityEngine.Random.Range(6, 20), 4);
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["r"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["a"].speed = 1f;
		@base.GetComponent<Animation>()["r"].speed = 2f;
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			int num = (int)Mathf.Abs(player.transform.position.x - t.position.x);
			if (num < 20 && !knocking)
			{
				if (!(player.transform.position.x <= t.position.x))
				{
					StartCoroutine_Auto(FaceRight());
				}
				else
				{
					StartCoroutine_Auto(FaceLeft());
				}
				if (num < 7 && !TRYatking && !atking)
				{
					TRYatking = true;
					if (UnityEngine.Random.Range(0, 3) == 0)
					{
						StartCoroutine_Auto(ATTACK());
					}
					else
					{
						StartCoroutine_Auto(TRY());
					}
				}
			}
		}
		if (running && !knocking)
		{
			int num2 = spdd;
			Vector3 velocity = r.velocity;
			float num3 = (velocity.x = num2);
			Vector3 vector2 = (r.velocity = velocity);
		}
	}

	public virtual IEnumerator FaceRight()
	{
		return new _0024FaceRight_00241879(this).GetEnumerator();
	}

	public virtual IEnumerator FaceLeft()
	{
		return new _0024FaceLeft_00241884(this).GetEnumerator();
	}

	public virtual IEnumerator TRY()
	{
		return new _0024TRY_00241889(this).GetEnumerator();
	}

	public virtual IEnumerator ATTACK()
	{
		return new _0024ATTACK_00241892(this).GetEnumerator();
	}

	[RPC]
	public virtual void Turn(int a)
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

	[RPC]
	public virtual void RUN()
	{
		@base.GetComponent<Animation>().Play("r");
	}

	[RPC]
	public virtual IEnumerator ATK()
	{
		return new _0024ATK_00241895(this).GetEnumerator();
	}

	[RPC]
	public virtual void IDLE()
	{
		@base.GetComponent<Animation>().Play("i");
	}
}
