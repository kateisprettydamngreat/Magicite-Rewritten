using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BoltScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Bolt_00241266 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241267;

			internal float _0024_0024445_00241268;

			internal Vector2 _0024_0024446_00241269;

			internal BoltScript _0024self__00241270;

			public _0024(BoltScript self_)
			{
				_0024self__00241270 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241270.GetComponent<Collider>().enabled = true;
					_0024i_00241267 = default(int);
					_0024i_00241267 = 0;
					goto IL_00f5;
				case 2:
					_0024i_00241267++;
					goto IL_00f5;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00f5:
					if (_0024i_00241267 < 12)
					{
						float num = (_0024_0024445_00241268 = _0024self__00241270.@base.GetComponent<Renderer>().material.mainTextureOffset.x + 0.25f);
						Vector2 vector = (_0024_0024446_00241269 = _0024self__00241270.@base.GetComponent<Renderer>().material.mainTextureOffset);
						float num2 = (_0024_0024446_00241269.x = _0024_0024445_00241268);
						Vector2 vector3 = (_0024self__00241270.@base.GetComponent<Renderer>().material.mainTextureOffset = _0024_0024446_00241269);
						result = (Yield(2, new WaitForSeconds(0.05f)) ? 1 : 0);
						break;
					}
					if (Network.isServer)
					{
						_0024self__00241270.StartCoroutine_Auto(_0024self__00241270.Exile());
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BoltScript _0024self__00241271;

		public _0024Bolt_00241266(BoltScript self_)
		{
			_0024self__00241271 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241271);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241272 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BoltScript _0024self__00241273;

			public _0024(BoltScript self_)
			{
				_0024self__00241273 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241273.exiling)
					{
						_0024self__00241273.exiling = true;
						_0024self__00241273.transform.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00241273.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00241273.GetComponent<NetworkView>().viewID);
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

		internal BoltScript _0024self__00241274;

		public _0024Exile_00241272(BoltScript self_)
		{
			_0024self__00241274 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241274);
		}
	}

	public GameObject @base;

	private int MAG;

	private bool exiling;

	public virtual void Set(int m)
	{
		GetComponent<NetworkView>().RPC("SETN", RPCMode.All, m);
	}

	[RPC]
	public virtual void SETN(int m)
	{
		MAG = m;
		StartCoroutine_Auto(Bolt());
	}

	public virtual IEnumerator Bolt()
	{
		return new _0024Bolt_00241266(this).GetEnumerator();
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 9 || c.gameObject.layer == 12)
		{
			c.gameObject.SendMessage("TD", MAG);
		}
		else if (c.gameObject.layer == 8 && MenuScript.pvp == 1 && !GetComponent<NetworkView>().isMine)
		{
			c.gameObject.SendMessage("TD", MAG);
		}
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241272(this).GetEnumerator();
	}

	}