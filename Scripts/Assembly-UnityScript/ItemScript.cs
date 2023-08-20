using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ItemScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241922 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ItemScript _0024self__00241923;

			public _0024(ItemScript self_)
			{
				_0024self__00241923 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241923.exiling)
					{
						_0024self__00241923.exiling = true;
						_0024self__00241923.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_0099;
				case 2:
					if (Network.isServer)
					{
						Network.Destroy(_0024self__00241923.GetComponent<NetworkView>().viewID);
						Network.RemoveRPCs(_0024self__00241923.GetComponent<NetworkView>().viewID);
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

		internal ItemScript _0024self__00241924;

		public _0024Exile_00241922(ItemScript self_)
		{
			_0024self__00241924 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241924);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241925 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024647_00241926;

			internal Vector3 _0024_0024648_00241927;

			internal ItemScript _0024self__00241928;

			public _0024(ItemScript self_)
			{
				_0024self__00241928 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241928.dropped && (_0024self__00241928.isLocal || Network.isServer))
					{
						_0024self__00241928.r.AddForce(new Vector3(UnityEngine.Random.Range(-1, 2), 1f, 0f) * 200f);
						int num = (_0024_0024647_00241926 = UnityEngine.Random.Range(5, 9));
						Vector3 vector = (_0024_0024648_00241927 = _0024self__00241928.r.velocity);
						float num2 = (_0024_0024648_00241927.y = _0024_0024647_00241926);
						Vector3 vector3 = (_0024self__00241928.r.velocity = _0024_0024648_00241927);
					}
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241928.@base.GetComponent<Collider>().enabled = true;
					_0024self__00241928.can = true;
					result = (Yield(3, new WaitForSeconds(30f)) ? 1 : 0);
					break;
				case 3:
					if (!_0024self__00241928.isLocal)
					{
						_0024self__00241928.StartCoroutine_Auto(_0024self__00241928.Exile());
					}
					else
					{
						UnityEngine.Object.Destroy(_0024self__00241928.gameObject);
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

		internal ItemScript _0024self__00241929;

		public _0024Start_00241925(ItemScript self_)
		{
			_0024self__00241929 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241929);
		}
	}

	public bool dropped;

	public bool isLocal;

	public GameObject @base;

	private Rigidbody r;

	private bool dying;

	private int d;

	private int[] e;

	private int id;

	private int mask;

	private Ray ray;

	private RaycastHit hit;

	private Transform t;

	private bool can;

	private int q;

	private bool exiling;

	public ItemScript()
	{
		e = new int[6];
		mask = 256;
	}

	public virtual void Awake()
	{
		t = transform;
		@base.GetComponent<Collider>().enabled = false;
		r = GetComponent<Rigidbody>();
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241922(this).GetEnumerator();
	}

	[RPC]
	public virtual void DR()
	{
		dropped = true;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241925(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (can && !dropped)
		{
			ray = new Ray(t.position, new Vector3(-1f, 0f, 0f));
			if (Physics.Raycast(ray, out hit, 3f, mask) && hit.transform.gameObject.GetComponent<NetworkView>().isMine)
			{
				int num = -7;
				Vector3 velocity = r.velocity;
				float num2 = (velocity.x = num);
				Vector3 vector2 = (r.velocity = velocity);
			}
			ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
			if (Physics.Raycast(ray, out hit, 3f, mask) && hit.transform.gameObject.GetComponent<NetworkView>().isMine)
			{
				int num3 = 7;
				Vector3 velocity2 = r.velocity;
				float num4 = (velocity2.x = num3);
				Vector3 vector4 = (r.velocity = velocity2);
			}
		}
	}

	[RPC]
	public virtual void InitL(int[] stats)
	{
		Item item = new Item(stats[0], stats[1], new int[4]
		{
			stats[2],
			stats[3],
			stats[4],
			stats[5]
		}, stats[6], null);
		id = item.id;
		q = item.q;
		e = item.e;
		d = item.d;
		@base.GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + item.id);
		@base.name = string.Empty + item.id;
		gameObject.name = string.Empty + item.id;
		d = item.d;
		e = item.e;
	}

	public virtual void Set(Item item)
	{
		GetComponent<NetworkView>().RPC("SetID", RPCMode.All, item.id);
		GetComponent<NetworkView>().RPC("SetD", RPCMode.All, item.d);
		GetComponent<NetworkView>().RPC("SetE", RPCMode.All, item.e);
		GetComponent<NetworkView>().RPC("SetQ", RPCMode.All, item.q);
	}

	public virtual void Hit(GameObject player)
	{
		Item value = new Item(int.Parse(gameObject.name), q, e, d, gameObject);
		if (isLocal)
		{
			player.SendMessage("AddItemL", value);
		}
		else
		{
			player.SendMessage("AddItem", value);
		}
	}

	[RPC]
	public virtual void SetN(Item item)
	{
		@base.GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + item.id);
		@base.name = string.Empty + item.id;
		gameObject.name = string.Empty + item.id;
		d = item.d;
		e = item.e;
	}

	}