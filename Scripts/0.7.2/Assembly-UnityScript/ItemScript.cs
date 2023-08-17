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
	internal sealed class _0024Start_00241637 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ItemScript _0024self__00241638;

			public _0024(ItemScript self_)
			{
				_0024self__00241638 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Expected O, but got Unknown
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Expected O, but got Unknown
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241638.@base.collider.enabled = true;
					_0024self__00241638.can = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(15f)) ? 1 : 0);
					break;
				case 3:
					if (MenuScript.multiplayer > 0)
					{
						Network.RemoveRPCs(((Component)_0024self__00241638).networkView.viewID);
						Network.Destroy(((Component)_0024self__00241638).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241638).gameObject);
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

		internal ItemScript _0024self__00241639;

		public _0024Start_00241637(ItemScript self_)
		{
			_0024self__00241639 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241639);
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

	public ItemScript()
	{
		e = new int[6];
		mask = 256;
	}

	public override void Awake()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		t = ((Component)this).transform;
		@base.collider.enabled = false;
		r = ((Component)this).rigidbody;
		r.AddForce(new Vector3((float)Random.Range(-1, 2), 1f, 0f) * 200f);
		int num = Random.Range(5, 9);
		Vector3 velocity = r.velocity;
		float num2 = (velocity.y = num);
		Vector3 val2 = (r.velocity = velocity);
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241637(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		if (can)
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
