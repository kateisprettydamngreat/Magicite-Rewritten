using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ShooterScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242425 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ShooterScript _0024self__00242426;

			public _0024(ShooterScript self_)
			{
				_0024self__00242426 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (Network.isServer)
					{
						result = (Yield(2, new WaitForSeconds((float)UnityEngine.Random.Range(0, 5) * 0.5f)) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				case 2:
					_0024self__00242426.@base.GetComponent<Animation>().Play("i");
					result = (Yield(3, new WaitForSeconds((float)UnityEngine.Random.Range(0, 4) * 0.5f)) ? 1 : 0);
					break;
				case 3:
					result = (Yield(4, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242426.@base.GetComponent<Animation>().Play("a");
					_0024self__00242426.GetComponent<AudioSource>().PlayOneShot(_0024self__00242426.a);
					result = (Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 5:
					Network.Instantiate(_0024self__00242426.blade, _0024self__00242426.t.position, Quaternion.identity, 0);
					goto case 3;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ShooterScript _0024self__00242427;

		public _0024Attack_00242425(ShooterScript self_)
		{
			_0024self__00242427 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242427);
		}
	}

	public GameObject @base;

	public GameObject blade;

	public AudioClip a;

	private Transform t;

	public virtual void OnDestroy()
	{
		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
	}

	public virtual void Awake()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		t = transform;
	}

	public virtual void Start()
	{
		StartCoroutine_Auto(Attack());
	}

	[RPC]
	public virtual IEnumerator Attack()
	{
		return new _0024Attack_00242425(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
