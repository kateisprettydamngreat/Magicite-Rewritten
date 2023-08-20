using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EnemyProjectile : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241362 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal EnemyProjectile _0024self__00241363;

			public _0024(EnemyProjectile self_)
			{
				_0024self__00241363 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241363.t = _0024self__00241363.transform;
					if (Network.isServer)
					{
						result = (Yield(2, new WaitForSeconds(5f)) ? 1 : 0);
						break;
					}
					goto IL_0061;
				case 2:
					_0024self__00241363.StartCoroutine_Auto(_0024self__00241363.Exile());
					goto IL_0061;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0061:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal EnemyProjectile _0024self__00241364;

		public _0024Start_00241362(EnemyProjectile self_)
		{
			_0024self__00241364 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241364);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241365 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal EnemyProjectile _0024self__00241366;

			public _0024(EnemyProjectile self_)
			{
				_0024self__00241366 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241366.exiling)
					{
						_0024self__00241366.exiling = true;
						_0024self__00241366.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00241366.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00241366.GetComponent<NetworkView>().viewID);
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

		internal EnemyProjectile _0024self__00241367;

		public _0024Exile_00241365(EnemyProjectile self_)
		{
			_0024self__00241367 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241367);
		}
	}

	public float speed;

	public bool isLeft;

	private Transform t;

	private bool stuck;

	private bool exiling;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241362(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241365(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (!stuck)
		{
			if (isLeft)
			{
				t.Translate(Vector3.left * speed * Time.deltaTime);
			}
			else
			{
				t.Translate(Vector3.left * (0f - speed) * Time.deltaTime);
			}
		}
	}

	public virtual void Stuck()
	{
		stuck = true;
		GetComponent<Rigidbody>().isKinematic = true;
		GetComponent<Collider>().enabled = false;
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 11 && Network.isServer)
		{
			StartCoroutine_Auto(Exile());
		}
	}

	}