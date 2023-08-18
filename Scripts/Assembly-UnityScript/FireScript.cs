using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FireScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241498 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal FireScript _0024self__00241499;

			public _0024(FireScript self_)
			{
				_0024self__00241499 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241499.StartCoroutine_Auto(_0024self__00241499.Animate());
					result = (Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241499.GetComponent<NetworkView>().isMine)
					{
						_0024self__00241499.StartCoroutine_Auto(_0024self__00241499.Exile());
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

		internal FireScript _0024self__00241500;

		public _0024Start_00241498(FireScript self_)
		{
			_0024self__00241500 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241500);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Animate_00241501 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241502;

			internal float _0024_0024557_00241503;

			internal Vector2 _0024_0024558_00241504;

			internal FireScript _0024self__00241505;

			public _0024(FireScript self_)
			{
				_0024self__00241505 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00241502 = default(int);
					goto case 2;
				case 2:
				{
					float num = (_0024_0024557_00241503 = _0024self__00241505.r.material.mainTextureOffset.x + 0.25f);
					Vector2 vector = (_0024_0024558_00241504 = _0024self__00241505.r.material.mainTextureOffset);
					float num2 = (_0024_0024558_00241504.x = _0024_0024557_00241503);
					Vector2 vector3 = (_0024self__00241505.r.material.mainTextureOffset = _0024_0024558_00241504);
					result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal FireScript _0024self__00241506;

		public _0024Animate_00241501(FireScript self_)
		{
			_0024self__00241506 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241506);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241507 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal FireScript _0024self__00241508;

			public _0024(FireScript self_)
			{
				_0024self__00241508 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241508.exiling)
					{
						_0024self__00241508.exiling = true;
						_0024self__00241508.transform.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00241508.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00241508.GetComponent<NetworkView>().viewID);
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

		internal FireScript _0024self__00241509;

		public _0024Exile_00241507(FireScript self_)
		{
			_0024self__00241509 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241509);
		}
	}

	public GameObject @base;

	private Renderer r;

	private bool exiling;

	public virtual void Awake()
	{
		r = @base.GetComponent<Renderer>();
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241498(this).GetEnumerator();
	}

	public virtual IEnumerator Animate()
	{
		return new _0024Animate_00241501(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241507(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
