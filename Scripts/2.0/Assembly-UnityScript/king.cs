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
	internal sealed class _0024Attack_00242898 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024pp2_00242899;

			internal GameObject _0024g_00242900;

			internal king _0024self__00242901;

			public _0024(king self_)
			{
				_0024self__00242901 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242901.ATKING = true;
					_0024self__00242901.atking = false;
					_0024self__00242901.MOVING = false;
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242901.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
					result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242901.GetComponent<NetworkView>().RPC("ATK2", RPCMode.All);
					if ((bool)_0024self__00242901.player)
					{
						_0024pp2_00242899 = _0024self__00242901.player.transform.position;
						if (Network.isServer)
						{
							_0024g_00242900 = null;
							_0024g_00242900 = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), _0024self__00242901.transform.position, Quaternion.identity, 0);
							_0024g_00242900.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00242899);
						}
						_0024g_00242900.GetComponent<NetworkView>().RPC("Set", RPCMode.All, _0024pp2_00242899);
					}
					result = (Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					if ((bool)_0024self__00242901.player && Network.isServer)
					{
						_0024self__00242901.curVector = _0024self__00242901.player.transform.position - _0024self__00242901.t.position;
						if (!(_0024self__00242901.player.transform.position.x <= _0024self__00242901.transform.position.x))
						{
							_0024self__00242901.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
						}
						else
						{
							_0024self__00242901.GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
						}
					}
					_0024self__00242901.MOVING = true;
					result = (Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00242901.ATKING = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal king _0024self__00242902;

		public _0024Attack_00242898(king self_)
		{
			_0024self__00242902 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242902);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK2_00242903 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242904;

			internal king _0024self__00242905;

			public _0024(king self_)
			{
				_0024self__00242905 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00242904 = default(int);
					_0024self__00242905.CRAZE = true;
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					for (_0024i_00242904 = 0; _0024i_00242904 < 4; _0024i_00242904++)
					{
						_0024self__00242905.swords[_0024i_00242904].GetComponent<Collider>().enabled = true;
					}
					result = (Yield(3, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 3:
					for (_0024i_00242904 = 0; _0024i_00242904 < 4; _0024i_00242904++)
					{
						_0024self__00242905.swords[_0024i_00242904].GetComponent<Collider>().enabled = false;
					}
					_0024self__00242905.CRAZE = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal king _0024self__00242906;

		public _0024ATK2_00242903(king self_)
		{
			_0024self__00242906 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242906);
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
		swords = new GameObject[4];
		speed = 10f;
		mask = 256;
		mask2 = 2048;
	}

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["i"].speed = 0.7f;
		@base.GetComponent<Animation>()["a"].layer = 1;
		@base.GetComponent<Animation>()["a"].speed = 1.5f;
		int[] array = new int[3] { 7, 18, 20 };
		SetStats(600, 8, 2, 700, 2f, array, UnityEngine.Random.Range(10, 25), 700);
		float y = transform.position.y + (float)UnityEngine.Random.Range(3, 10);
		Vector3 position = transform.position;
		float num = (position.y = y);
		Vector3 vector2 = (transform.position = position);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
		if ((bool)player)
		{
			curVector = player.transform.position - t.position;
			if (!(player.transform.position.x <= transform.position.x))
			{
				GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
			}
			else
			{
				GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
			}
		}
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			if (!(Mathf.Abs(player.transform.position.x - t.position.x) >= 50f) && !ATKING)
			{
				StartCoroutine_Auto(Attack(player.transform.position));
			}
			if (MOVING && (bool)player && !knocking && r.isKinematic)
			{
				t.Translate(curVector.normalized * 8f * Time.deltaTime);
			}
			if (CRAZE && (bool)player && !knocking && r.isKinematic)
			{
				t.Translate(curVector.normalized * 2f * Time.deltaTime);
			}
		}
	}

	public virtual IEnumerator Attack(Vector3 pp)
	{
		return new _0024Attack_00242898(this).GetEnumerator();
	}

	[RPC]
	public virtual void ATK()
	{
		@base.GetComponent<Animation>().Play("a");
		GetComponent<AudioSource>().PlayOneShot(roar);
	}

	[RPC]
	public virtual void Turn(int dir)
	{
		if (dir == 0)
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
	public virtual IEnumerator ATK2()
	{
		return new _0024ATK2_00242903(this).GetEnumerator();
	}
}
