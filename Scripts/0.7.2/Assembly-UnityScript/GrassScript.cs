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
	internal sealed class _0024Start_00241607 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_0024604_00241608;

			internal Vector2 _0024_0024605_00241609;

			internal GrassScript _0024self__00241610;

			public _0024(GrassScript self_)
			{
				_0024self__00241610 = self_;
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
					_0024self__00241610.drop = _0024self__00241610.GetPlantItem(Random.Range(0, 4));
					_0024self__00241610.r = _0024self__00241610.@base.renderer;
					goto case 2;
				case 2:
				{
					float num = (_0024_0024604_00241608 = _0024self__00241610.r.material.mainTextureOffset.x + 0.5f);
					Vector2 val = (_0024_0024605_00241609 = _0024self__00241610.r.material.mainTextureOffset);
					float num2 = (_0024_0024605_00241609.x = _0024_0024604_00241608);
					Vector2 val3 = (_0024self__00241610.r.material.mainTextureOffset = _0024_0024605_00241609);
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

		internal GrassScript _0024self__00241611;

		public _0024Start_00241607(GrassScript self_)
		{
			_0024self__00241611 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241611);
		}
	}

	public GameObject @base;

	private Renderer r;

	private int drop;

	public override IEnumerator Start()
	{
		return new _0024Start_00241607(this).GetEnumerator();
	}

	public override void TD(int dmg)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
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
			val = (GameObject)Object.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity);
			val.SendMessage("Set", (object)item);
		}
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}

	[RPC]
	public override void TD2(int dmg)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		GameScript.tempStats[8] = GameScript.tempStats[8] + 1;
		int num = default(int);
		GameObject val = null;
		Item item = new Item(drop, 1, new int[4], 0f, null);
		for (num = 0; num < dmg; num++)
		{
			val = (GameObject)Network.Instantiate(Resources.Load("item"), ((Component)this).transform.position, Quaternion.identity, 1);
			val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
			val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
			val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
			val.networkView.RPC("SetQ", (RPCMode)6, new object[1] { item.q });
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
			2 => 11, 
			3 => 23, 
			_ => num, 
		};
	}

	public override void Main()
	{
	}
}
