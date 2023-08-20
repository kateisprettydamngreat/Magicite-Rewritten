using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class StoneScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242623 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal StoneScript _0024self__00242624;

			public _0024(StoneScript self_)
			{
				_0024self__00242624 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242624.exiling)
					{
						_0024self__00242624.exiling = true;
						_0024self__00242624.transform.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00242624.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00242624.GetComponent<NetworkView>().viewID);
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

		internal StoneScript _0024self__00242625;

		public _0024Exile_00242623(StoneScript self_)
		{
			_0024self__00242625 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242625);
		}
	}

	public bool isPoison;

	public bool isLeft;

	private Vector3 vec;

	private bool exiling;

	public virtual void Set(Vector3 p)
	{
		Vector3 vector = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition) - p;
		vec = vector / vector.magnitude;
	}

	public virtual void Start()
	{
		GetComponent<Rigidbody>().AddForce(vec * 2900f);
	}

	public virtual void OnCollisionEnter(Collision c)
	{
		if (isPoison && (c.gameObject.layer == 9 || c.gameObject.layer == 12 || c.gameObject.layer == 11) && GetComponent<NetworkView>().isMine)
		{
			Network.Instantiate(Resources.Load("haz/poison"), transform.position, Quaternion.identity, 0);
			StartCoroutine_Auto(Exile());
		}
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00242623(this).GetEnumerator();
	}

	}