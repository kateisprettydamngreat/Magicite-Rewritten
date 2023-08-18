using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class InvaderScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Trigger_00241916 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal InvaderScript _0024self__00241917;

			public _0024(InvaderScript self_)
			{
				_0024self__00241917 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241917.trigger.SetActive(value: false);
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241917.trigger.SetActive(value: true);
					result = (Yield(4, new WaitForSeconds(5f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal InvaderScript _0024self__00241918;

		public _0024Trigger_00241916(InvaderScript self_)
		{
			_0024self__00241918 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241918);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241919 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal InvaderScript _0024self__00241920;

			public _0024(InvaderScript self_)
			{
				_0024self__00241920 = self_;
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
					if ((bool)_0024self__00241920.player)
					{
						_0024self__00241920.curVector = _0024self__00241920.player.transform.position - _0024self__00241920.t.position;
						if (!(_0024self__00241920.player.transform.position.x <= _0024self__00241920.t.position.x))
						{
							_0024self__00241920.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						else
						{
							_0024self__00241920.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						_0024self__00241920.atking = true;
						result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00241920.speed = UnityEngine.Random.Range(12, 18);
					_0024self__00241920.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal InvaderScript _0024self__00241921;

		public _0024Attack_00241919(InvaderScript self_)
		{
			_0024self__00241921 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241921);
		}
	}

	public GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	public GameObject trigger;

	public InvaderScript()
	{
		speed = 15f;
	}

	public override void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
		GetComponent<Collider>().material.dynamicFriction = 0f;
		int[] array = new int[3] { 7, 9, 0 };
		SetStats(999999, 9999, 3, 8, 15f, array, UnityEngine.Random.Range(6, 20), 8);
		StartCoroutine_Auto(Attack());
		StartCoroutine_Auto(Trigger());
	}

	public virtual IEnumerator Trigger()
	{
		return new _0024Trigger_00241916(this).GetEnumerator();
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && atking && !knocking && r.isKinematic)
		{
			t.Translate(curVector.normalized * speed * Time.deltaTime);
		}
	}

	public virtual IEnumerator Attack()
	{
		return new _0024Attack_00241919(this).GetEnumerator();
	}
}
