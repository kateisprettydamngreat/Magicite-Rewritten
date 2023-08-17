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
	internal sealed class _0024Start_00242074 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024720_00242075;

			internal Vector3 _0024_0024721_00242076;

			internal ItemScript _0024self__00242077;

			public _0024(ItemScript self_)
			{
				_0024self__00242077 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fa: Expected O, but got Unknown
				//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Expected O, but got Unknown
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_012a: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242077.dropped)
					{
						_0024self__00242077.r.AddForce(new Vector3((float)Random.Range(-1, 2), 1f, 0f) * 200f);
						int num = (_0024_0024720_00242075 = Random.Range(5, 9));
						Vector3 val = (_0024_0024721_00242076 = _0024self__00242077.r.velocity);
						float num2 = (_0024_0024721_00242076.y = _0024_0024720_00242075);
						Vector3 val3 = (_0024self__00242077.r.velocity = _0024_0024721_00242076);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242077.@base.collider.enabled = true;
					_0024self__00242077.can = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(30f)) ? 1 : 0);
					break;
				case 3:
					if (MenuScript.multiplayer > 0)
					{
						Network.RemoveRPCs(((Component)_0024self__00242077).networkView.viewID);
						Network.Destroy(((Component)_0024self__00242077).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00242077).gameObject);
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ItemScript _0024self__00242078;

		public _0024Start_00242074(ItemScript self_)
		{
			_0024self__00242078 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242078);
		}
	}

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

	private bool dropped;

	public ItemScript()
	{
		e = new int[6];
		mask = 256;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		@base.collider.enabled = false;
		r = ((Component)this).rigidbody;
	}

	[RPC]
	public override void DR()
	{
		dropped = true;
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242074(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (can && !dropped)
		{
			ray = new Ray(t.position, new Vector3(-1f, 0f, 0f));
			if (Physics.Raycast(ray, ref hit, 3f, mask))
			{
				int num = -7;
				Vector3 velocity = r.velocity;
				float num2 = (velocity.x = num);
				Vector3 val2 = (r.velocity = velocity);
			}
			ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
			if (Physics.Raycast(ray, ref hit, 3f, mask))
			{
				int num3 = 7;
				Vector3 velocity2 = r.velocity;
				float num4 = (velocity2.x = num3);
				Vector3 val4 = (r.velocity = velocity2);
			}
		}
	}

	[RPC]
	public override void SetQ(int q)
	{
		this.q = q;
	}

	[RPC]
	public override void SetD(int d)
	{
		this.d = d;
	}

	[RPC]
	public override void SetE(int[] e)
	{
		this.e = e;
	}

	[RPC]
	public override void SetID(int id)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		this.id = id;
		@base.renderer.material = (Material)Resources.Load("i/i" + (object)id);
		((Object)@base).name = string.Empty + (object)id;
		((Object)((Component)this).gameObject).name = string.Empty + (object)id;
	}

	public override void Set(Item item)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("SetID", (RPCMode)2, new object[1] { item.id });
			((Component)this).networkView.RPC("SetD", (RPCMode)2, new object[1] { item.d });
			((Component)this).networkView.RPC("SetE", (RPCMode)2, new object[1] { item.e });
			((Component)this).networkView.RPC("SetQ", (RPCMode)2, new object[1] { item.q });
		}
		else
		{
			@base.renderer.material = (Material)Resources.Load("i/i" + (object)item.id);
			((Object)@base).name = string.Empty + (object)item.id;
			((Object)((Component)this).gameObject).name = string.Empty + (object)item.id;
			d = item.d;
			e = item.e;
			q = item.q;
		}
	}

	public override void Hit(GameObject player)
	{
		Item item = new Item(int.Parse(((Object)((Component)this).gameObject).name), q, e, d, ((Component)this).gameObject);
		player.SendMessage("AddItem", (object)item);
	}

	public override void Die()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Network.RemoveRPCs(((Component)this).networkView.viewID);
		Network.Destroy(((Component)this).networkView.viewID);
	}

	[RPC]
	public override void SetN(Item item)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		@base.renderer.material = (Material)Resources.Load("i/i" + (object)item.id);
		((Object)@base).name = string.Empty + (object)item.id;
		((Object)((Component)this).gameObject).name = string.Empty + (object)item.id;
		d = item.d;
		e = item.e;
	}

	public override void D()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (!dying)
		{
			dying = true;
			Network.RemoveRPCs(@base.networkView.viewID);
			Network.Destroy(@base.networkView.viewID);
			Network.RemoveRPCs(((Component)this).networkView.viewID);
			Network.Destroy(((Component)this).networkView.viewID);
		}
	}

	public override void Main()
	{
	}
}
