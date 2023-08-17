using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class GrassScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241946 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_0024684_00241947;

			internal Vector2 _0024_0024685_00241948;

			internal GrassScript _0024self__00241949;

			public _0024(GrassScript self_)
			{
				_0024self__00241949 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_009e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241949.drop = _0024self__00241949.GetPlantItem(Random.Range(0, 4));
					_0024self__00241949.r = _0024self__00241949.@base.renderer;
					goto case 2;
				case 2:
				{
					float num = (_0024_0024684_00241947 = _0024self__00241949.r.material.mainTextureOffset.x + 0.5f);
					Vector2 val = (_0024_0024685_00241948 = _0024self__00241949.r.material.mainTextureOffset);
					float num2 = (_0024_0024685_00241948.x = _0024_0024684_00241947);
					Vector2 val3 = (_0024self__00241949.r.material.mainTextureOffset = _0024_0024685_00241948);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GrassScript _0024self__00241950;

		public _0024Start_00241946(GrassScript self_)
		{
			_0024self__00241950 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241950);
		}
	}

	public GameObject @base;

	private Renderer r;

	private int drop;

	public override IEnumerator Start()
	{
		return new _0024Start_00241946(this).GetEnumerator();
	}

	public override void TD(int dmg)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		int num = default(int);
		GameObject val = null;
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).networkView.RPC("TD2", (RPCMode)2, new object[1] { dmg });
			return;
		}
		GameScript.tempStats[8] = GameScript.tempStats[8] + 1;
		Item item = new Item(drop, 1, new int[4], 0f, null);
		for (num = 0; num < dmg; num++)
		{
			if (dmg == 1)
			{
				if (Random.Range(0, 2) == 0)
				{
					val = (GameObject)Object.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity);
					val.SendMessage("Set", (object)item);
				}
			}
			else
			{
				val = (GameObject)Object.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity);
				val.SendMessage("Set", (object)item);
			}
		}
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}

	[RPC]
	public override void TD2(int dmg)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		GameScript.tempStats[7] = GameScript.tempStats[7] + 1;
		int num = default(int);
		GameObject val = null;
		Item item = new Item(drop, 1, new int[4], 0f, null);
		if (GameScript.tempStats[7] > 9)
		{
			MenuScript.canUnlockHat[1] = 1;
		}
		if (dmg > 10)
		{
			dmg -= 10;
			if (Random.Range(0, 4) == 0)
			{
				int id = Random.Range(1, 57);
				Item item2 = new Item(id, 1, new int[4], 0f, null);
				GameObject val2 = null;
				val2 = (GameObject)Network.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity, 1);
				val2.networkView.RPC("SetID", (RPCMode)6, new object[1] { item2.id });
				val2.networkView.RPC("SetD", (RPCMode)6, new object[1] { item2.d });
				val2.networkView.RPC("SetE", (RPCMode)6, new object[1] { item2.e });
				val2.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item2.q });
			}
		}
		int num2 = default(int);
		for (num2 = 0; num2 < Network.connections.Length + 1; num2++)
		{
			for (num = 0; num < dmg; num++)
			{
				if (num != 0)
				{
					if (Random.Range(0, 2) == 0)
					{
						val = (GameObject)Network.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity, 1);
						val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
						val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
						val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
						val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
					}
				}
				else
				{
					val = (GameObject)Network.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity, 1);
					val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
					val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
					val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
					val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
				}
			}
		}
		Network.RemoveRPCs(((Component)this).networkView.viewID);
		Network.Destroy(((Component)this).networkView.viewID);
	}

	public override int GetPlantItem(int a)
	{
		int num = default(int);
		return a switch
		{
			0 => 9, 
			1 => 10, 
			2 => 10, 
			3 => 23, 
			_ => num, 
		};
	}

	public override void Main()
	{
	}
}
