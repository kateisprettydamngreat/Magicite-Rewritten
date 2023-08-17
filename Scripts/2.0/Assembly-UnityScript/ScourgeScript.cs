using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ScourgeScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242397 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ScourgeScript _0024self__00242398;

			public _0024(ScourgeScript self_)
			{
				_0024self__00242398 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242398.curVector = _0024self__00242398.player.transform.position - _0024self__00242398.t.position;
					if (!(_0024self__00242398.player.transform.position.x <= _0024self__00242398.t.position.x))
					{
						_0024self__00242398.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
					}
					else
					{
						_0024self__00242398.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
					_0024self__00242398.atking = true;
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242398.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeScript _0024self__00242399;

		public _0024Attack_00242397(ScourgeScript self_)
		{
			_0024self__00242399 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242399);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	public ScourgeScript()
	{
		speed = 8f;
	}

	public override void Awake()
	{
		GetComponent<AudioSource>().PlayOneShot(scourge1);
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 7, 18, 0 };
		SetStats(10, 8, 1, 3, 2f, array, UnityEngine.Random.Range(2, 6), 2);
		player = GameObject.Find("player(Clone)");
		MonoBehaviour.print(player.transform.position.x);
		StartCoroutine_Auto(Attack());
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 13)
		{
			MonoBehaviour.print("hit");
			c.gameObject.SendMessage("TD", ATK);
		}
		else if (c.gameObject.layer == 18)
		{
			TD(1);
		}
	}

	public override void Update()
	{
		if (atking)
		{
			t.Translate(curVector.normalized * speed * Time.deltaTime);
		}
	}

	public virtual IEnumerator Attack()
	{
		return new _0024Attack_00242397(this).GetEnumerator();
	}

	public override void K(bool l)
	{
		GetComponent<NetworkView>().RPC("KN", RPCMode.All, l);
	}
}
