using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ScourgeWall : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShootStuff_00242400 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242401;

			internal ScourgeWall _0024self__00242402;

			public _0024(ScourgeWall self_)
			{
				_0024self__00242402 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00242401 = default(int);
					if (Network.isServer)
					{
						goto IL_003a;
					}
					YieldDefault(1);
					goto case 1;
				case 2:
					_0024self__00242402.GetComponent<NetworkView>().RPC("SHOOT", RPCMode.All);
					result = (Yield(3, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 3:
					_0024i_00242401 = 0;
					goto IL_011d;
				case 4:
					_0024i_00242401++;
					goto IL_011d;
				case 1:
					{
						result = 0;
						break;
					}
					IL_011d:
					if (_0024i_00242401 < 5)
					{
						if (!_0024self__00242402.ded)
						{
							Network.Instantiate(_0024self__00242402.ball1, _0024self__00242402.headPoint.transform.position, Quaternion.identity, 0);
							Network.Instantiate(_0024self__00242402.ball2, _0024self__00242402.headPoint.transform.position, Quaternion.identity, 0);
						}
						result = (Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					goto IL_003a;
					IL_003a:
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(4, 7))) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeWall _0024self__00242403;

		public _0024ShootStuff_00242400(ScourgeWall self_)
		{
			_0024self__00242403 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242403);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DeathAnim_00242404 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024musicBox_00242405;

			internal ScourgeWall _0024self__00242406;

			public _0024(ScourgeWall self_)
			{
				_0024self__00242406 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024musicBox_00242405 = GameObject.Find("musicBox");
					_0024musicBox_00242405.SendMessage("Victory");
					_0024self__00242406.ded = true;
					_0024self__00242406.deathParticle.SetActive(value: true);
					_0024self__00242406.white.SetActive(value: true);
					_0024self__00242406.GetComponent<AudioSource>().PlayOneShot(_0024self__00242406.scourgeded);
					result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242406.white.SetActive(value: false);
					result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242406.GetComponent<AudioSource>().PlayOneShot(_0024self__00242406.scourgeded);
					_0024self__00242406.white.SetActive(value: true);
					result = (Yield(4, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242406.white.SetActive(value: false);
					result = (Yield(5, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 5:
					if (Network.isServer)
					{
						_0024self__00242406.spd = 8f;
					}
					_0024self__00242406.GetComponent<AudioSource>().PlayOneShot(_0024self__00242406.scourgeded);
					_0024self__00242406.white.SetActive(value: true);
					result = (Yield(6, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 6:
					_0024self__00242406.white.SetActive(value: false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeWall _0024self__00242407;

		public _0024DeathAnim_00242404(ScourgeWall self_)
		{
			_0024self__00242407 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242407);
		}
	}

	public AudioClip scourgeded;

	public GameObject white;

	public GameObject deathParticle;

	public GameObject ball1;

	public GameObject ball2;

	private Transform t;

	private GameObject player;

	private int hp;

	public GameObject e;

	public GameObject mainHead;

	public GameObject headPoint;

	private float spd;

	private bool ded;

	public ScourgeWall()
	{
		hp = 4500;
		spd = -1.5f;
	}

	public virtual void Start()
	{
		if (Network.isServer)
		{
			int num = 0;
			num += Network.connections.Length * 700;
			GetComponent<NetworkView>().RPC("HPSET", RPCMode.All, num);
		}
		if (MenuScript.GameMode == 1)
		{
			spd = -3f;
		}
		mainHead.GetComponent<Animation>()["i"].layer = 0;
		mainHead.GetComponent<Animation>()["a"].layer = 1;
		mainHead.GetComponent<Animation>()["a"].speed = 0.7f;
		t = transform;
		StartCoroutine_Auto(ShootStuff());
	}

	[RPC]
	public virtual void HPSET(int BONUS)
	{
		hp += BONUS;
	}

	[RPC]
	public virtual void SHOOT()
	{
		if (!ded)
		{
			mainHead.GetComponent<Animation>().Play("a");
		}
	}

	[RPC]
	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public virtual IEnumerator ShootStuff()
	{
		return new _0024ShootStuff_00242400(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (!Network.isServer)
		{
			return;
		}
		t.Translate(Vector3.left * spd * Time.deltaTime);
		if ((bool)player)
		{
			if (!(player.transform.position.y + 1f <= t.position.y))
			{
				t.Translate(Vector3.up * 1f * Time.deltaTime);
			}
			else if (!(player.transform.position.y - 1f >= t.position.y))
			{
				t.Translate(Vector3.up * -1f * Time.deltaTime);
			}
		}
	}

	[RPC]
	public virtual void TD(int dmg)
	{
		if (ded)
		{
			return;
		}
		if (Network.isServer)
		{
			hp -= dmg;
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("TD", typeof(GameObject)), t.position, Quaternion.identity);
			gameObject.SendMessage("SDN", dmg);
			if (hp <= 0)
			{
				if (GameScript.districtLevel >= 20)
				{
					GetComponent<NetworkView>().RPC("Win", RPCMode.All);
					spd = 5f;
					ded = true;
					GetComponent<NetworkView>().RPC("DeathAnim", RPCMode.All);
				}
				else
				{
					spd = 5f;
				}
			}
		}
		else
		{
			GetComponent<NetworkView>().RPC("TD", RPCMode.Server, dmg);
		}
	}

	[RPC]
	public virtual IEnumerator DeathAnim()
	{
		return new _0024DeathAnim_00242404(this).GetEnumerator();
	}

	public virtual void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.layer == 8)
		{
			c.gameObject.SendMessage("TD", 75);
			int num = 40;
			Vector3 velocity = c.gameObject.GetComponent<Rigidbody>().velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (c.gameObject.GetComponent<Rigidbody>().velocity = velocity);
		}
	}

	[RPC]
	public virtual void Win()
	{
		GameScript.win = true;
	}

	[RPC]
	public virtual void TDN(int dmg)
	{
		hp -= dmg;
	}

	public virtual void K()
	{
	}

	[RPC]
	public virtual void KN()
	{
	}

	[RPC]
	public virtual void Knock22()
	{
	}

	public virtual void Main()
	{
	}
}
