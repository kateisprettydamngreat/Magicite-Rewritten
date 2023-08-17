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
	internal sealed class _0024Start_00241871 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_0024627_00241872;

			internal Vector2 _0024_0024628_00241873;

			internal GrassScript _0024self__00241874;

			public _0024(GrassScript self_)
			{
				_0024self__00241874 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241874.drop = _0024self__00241874.GetPlantItem(UnityEngine.Random.Range(0, 4));
					_0024self__00241874.r = _0024self__00241874.@base.GetComponent<Renderer>();
					goto case 2;
				case 2:
				{
					float num = (_0024_0024627_00241872 = _0024self__00241874.r.material.mainTextureOffset.x + 0.5f);
					Vector2 vector = (_0024_0024628_00241873 = _0024self__00241874.r.material.mainTextureOffset);
					float num2 = (_0024_0024628_00241873.x = _0024_0024627_00241872);
					Vector2 vector3 = (_0024self__00241874.r.material.mainTextureOffset = _0024_0024628_00241873);
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GrassScript _0024self__00241875;

		public _0024Start_00241871(GrassScript self_)
		{
			_0024self__00241875 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241875);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241876 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GrassScript _0024self__00241877;

			public _0024(GrassScript self_)
			{
				_0024self__00241877 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241877.exiling)
					{
						_0024self__00241877.exiling = true;
						_0024self__00241877.transform.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_0099;
				case 2:
					if (Network.isServer)
					{
						Network.Destroy(_0024self__00241877.GetComponent<NetworkView>().viewID);
						Network.RemoveRPCs(_0024self__00241877.GetComponent<NetworkView>().viewID);
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

		internal GrassScript _0024self__00241878;

		public _0024Exile_00241876(GrassScript self_)
		{
			_0024self__00241878 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241878);
		}
	}

	public GameObject @base;

	private Renderer r;

	private int drop;

	private bool exiling;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241871(this).GetEnumerator();
	}

	public virtual void TD(int dmg)
	{
		int num = default(int);
		GameObject gameObject = null;
		GetComponent<NetworkView>().RPC("TD2", RPCMode.All, dmg);
	}

	[RPC]
	public virtual void TD2(int dmg)
	{
		GameScript.tempStats[7] = GameScript.tempStats[7] + 1;
		int num = default(int);
		GameObject gameObject = null;
		int q = 1;
		int[] array = null;
		if ((MenuScript.curTrait[2] == 3 || MenuScript.curTrait[1] == 3) && UnityEngine.Random.Range(0, 2) == 0)
		{
			q = 2;
		}
		Item item = new Item(drop, q, new int[4], 0f, null);
		if (GameScript.tempStats[7] > 9)
		{
			MenuScript.canUnlockHat[1] = 1;
		}
		if (dmg > 10)
		{
			dmg -= 10;
			if (UnityEngine.Random.Range(0, 4) == 0)
			{
				int id = UnityEngine.Random.Range(1, 57);
				Item item2 = new Item(id, 1, new int[4], 0f, null);
				GameObject gameObject2 = null;
				gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), transform.position, Quaternion.identity);
				array = new int[7] { item2.id, item2.q, 0, 0, 0, 0, 0 };
				gameObject2.SendMessage("InitL", array);
			}
		}
		int num2 = default(int);
		for (num = 0; num < dmg; num++)
		{
			if (num != 0)
			{
				if (UnityEngine.Random.Range(0, 2) == 0)
				{
					gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), transform.position, Quaternion.identity);
					array = new int[7] { item.id, item.q, 0, 0, 0, 0, 0 };
					gameObject.SendMessage("InitL", array);
				}
			}
			else
			{
				gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), transform.position, Quaternion.identity);
				array = new int[7] { item.id, item.q, 0, 0, 0, 0, 0 };
				gameObject.SendMessage("InitL", array);
			}
		}
		transform.position = new Vector3(0f, 0f, -500f);
		if (Network.isServer)
		{
			StartCoroutine_Auto(Exile());
		}
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241876(this).GetEnumerator();
	}

	public virtual int GetPlantItem(int a)
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

	public virtual void Main()
	{
	}
}
