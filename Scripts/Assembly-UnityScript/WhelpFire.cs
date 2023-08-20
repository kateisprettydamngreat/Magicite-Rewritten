using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class WhelpFire : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242717 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WhelpFire _0024self__00242718;

			public _0024(WhelpFire self_)
			{
				_0024self__00242718 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(6f)) ? 1 : 0);
					break;
				case 2:
					if (Network.isServer)
					{
						_0024self__00242718.StartCoroutine_Auto(_0024self__00242718.Exile());
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal WhelpFire _0024self__00242719;

		public _0024Start_00242717(WhelpFire self_)
		{
			_0024self__00242719 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242719);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242720 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WhelpFire _0024self__00242721;

			public _0024(WhelpFire self_)
			{
				_0024self__00242721 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242721.exiling)
					{
						_0024self__00242721.exiling = true;
						_0024self__00242721.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00242721.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00242721.GetComponent<NetworkView>().viewID);
					goto IL_008f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_008f:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal WhelpFire _0024self__00242722;

		public _0024Exile_00242720(WhelpFire self_)
		{
			_0024self__00242722 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242722);
		}
	}

	public bool isFast;

	public bool yeti;

	private Vector3 playerPos;

	private Rigidbody r;

	private Vector3 finalVec;

	private Transform t;

	private bool canShoot;

	private int speed;

	private bool exiling;

	public WhelpFire()
	{
		speed = 10;
	}

	public virtual void Awake()
	{
		if (isFast)
		{
			speed = UnityEngine.Random.Range(5, 18);
		}
		t = transform;
		r = GetComponent<Rigidbody>();
	}

	[RPC]
	public virtual void Set(Vector3 v)
	{
		playerPos = v;
		if (!yeti)
		{
			finalVec = Vector3.Normalize(playerPos - transform.position);
		}
		else
		{
			finalVec = v;
		}
		canShoot = true;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242717(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00242720(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (canShoot)
		{
			t.Translate(finalVec * speed * Time.deltaTime);
		}
	}

	}