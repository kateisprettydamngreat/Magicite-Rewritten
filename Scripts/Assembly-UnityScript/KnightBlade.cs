using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class KnightBlade : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241937 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal KnightBlade _0024self__00241938;

			public _0024(KnightBlade self_)
			{
				_0024self__00241938 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241938.exiling)
					{
						_0024self__00241938.exiling = true;
						_0024self__00241938.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_0099;
				case 2:
					if (Network.isServer)
					{
						Network.Destroy(_0024self__00241938.GetComponent<NetworkView>().viewID);
						Network.RemoveRPCs(_0024self__00241938.GetComponent<NetworkView>().viewID);
					}
					goto IL_0099;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0099:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal KnightBlade _0024self__00241939;

		public _0024Exile_00241937(KnightBlade self_)
		{
			_0024self__00241939 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241939);
		}
	}

	private Transform t;

	private int speed;

	private int dmg;

	private bool exiling;

	public KnightBlade()
	{
		speed = 10;
	}

	public virtual void Awake()
	{
		t = transform;
	}

	public virtual void Update()
	{
		t.Translate(Vector3.down * Time.deltaTime * speed);
	}

	public virtual void Set(int a)
	{
		GetComponent<NetworkView>().RPC("SetN", RPCMode.All, a);
	}

	[RPC]
	public virtual void SetN(int a)
	{
		dmg = a;
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 9 || c.gameObject.layer == 12)
		{
			c.gameObject.SendMessage("TD", dmg);
			if (c.gameObject.transform.position.x <= t.position.x)
			{
			}
		}
		else if (c.gameObject.layer == 8)
		{
			if (!c.gameObject.GetComponent<NetworkView>().isMine)
			{
				c.gameObject.SendMessage("TD", dmg);
				if (c.gameObject.transform.position.x <= t.position.x)
				{
				}
			}
		}
		else if (c.gameObject.layer == 11)
		{
			StartCoroutine_Auto(Exile());
		}
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241937(this).GetEnumerator();
	}

	}