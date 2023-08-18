using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BugSpotScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241293 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BugSpotScript _0024self__00241294;

			public _0024(BugSpotScript self_)
			{
				_0024self__00241294 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241294.exiling)
					{
						_0024self__00241294.exiling = true;
						_0024self__00241294.transform.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_0099;
				case 2:
					if (Network.isServer)
					{
						Network.Destroy(_0024self__00241294.GetComponent<NetworkView>().viewID);
						Network.RemoveRPCs(_0024self__00241294.GetComponent<NetworkView>().viewID);
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

		internal BugSpotScript _0024self__00241295;

		public _0024Exile_00241293(BugSpotScript self_)
		{
			_0024self__00241295 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241295);
		}
	}

	private Renderer r;

	private int drop;

	private bool exiling;

	public virtual void Start()
	{
		if (Network.isServer)
		{
			drop = UnityEngine.Random.Range(0, 3) switch
			{
				0 => 30, 
				1 => 31, 
				_ => 81, 
			};
			GetComponent<NetworkView>().RPC("SetDropN", RPCMode.All, drop);
		}
	}

	[RPC]
	public virtual void SetDropN(int a)
	{
		drop = a;
	}

	public virtual void TD(int dmg)
	{
		if (dmg > 0)
		{
			int num = default(int);
			GameObject gameObject = null;
			GetComponent<NetworkView>().RPC("TD2", RPCMode.All, dmg);
		}
	}

	[RPC]
	public virtual void TD2(int dmg)
	{
		if (dmg > 0)
		{
			GameScript.tempStats[8] = GameScript.tempStats[8] + 1;
			int num = default(int);
			GameObject gameObject = null;
			Item item = new Item(drop, 1, new int[4], 0f, null);
			for (num = 0; num < dmg; num++)
			{
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), transform.position, Quaternion.identity);
				int[] value = new int[7] { item.id, item.q, 0, 0, 0, 0, 0 };
				gameObject.SendMessage("InitL", value);
			}
			transform.position = new Vector3(0f, 0f, -500f);
			if (Network.isServer)
			{
				StartCoroutine_Auto(Exile());
			}
		}
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241293(this).GetEnumerator();
	}

	public virtual int GetPlantItem(int a)
	{
		int num = default(int);
		return a switch
		{
			0 => 9, 
			1 => 10, 
			2 => 11, 
			_ => num, 
		};
	}

	public virtual void Main()
	{
	}
}
