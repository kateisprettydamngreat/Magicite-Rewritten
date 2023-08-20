using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class EffectScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024End_00241359 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal EffectScript _0024self__00241360;

			public _0024(EffectScript self_)
			{
				_0024self__00241360 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
					Network.RemoveRPCs(_0024self__00241360.GetComponent<NetworkView>().viewID);
					Network.Destroy(_0024self__00241360.GetComponent<NetworkView>().viewID);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal EffectScript _0024self__00241361;

		public _0024End_00241359(EffectScript self_)
		{
			_0024self__00241361 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241361);
		}
	}

	public int type;

	private int mag;

	public virtual void Awake()
	{
		if (type == 2)
		{
			GetComponent<Collider>().enabled = false;
		}
	}

	public virtual void Start()
	{
		if (type != 2)
		{
			StartCoroutine_Auto(End());
		}
	}

	public virtual IEnumerator End()
	{
		return new _0024End_00241359(this).GetEnumerator();
	}

	public virtual void SetMag(int a)
	{
		mag = a;
		GetComponent<Collider>().enabled = true;
		StartCoroutine_Auto(End());
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (type == 0)
		{
			c.gameObject.SendMessage("Charge");
		}
		else if (type == 1)
		{
			c.gameObject.SendMessage("Shield");
		}
		else if (type == 2)
		{
			c.gameObject.SendMessage("mWeapons", mag);
		}
		else if (type == 3)
		{
			c.gameObject.SendMessage("drumATK");
		}
		else if (type == 4)
		{
			c.gameObject.SendMessage("drumDEX");
		}
		else if (type == 5)
		{
			c.gameObject.SendMessage("drumMAG");
		}
	}

	}