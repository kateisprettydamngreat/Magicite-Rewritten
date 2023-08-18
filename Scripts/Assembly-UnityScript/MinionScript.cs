using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class MinionScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242006 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MinionScript _0024self__00242007;

			public _0024(MinionScript self_)
			{
				_0024self__00242007 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242007.exiling)
					{
						_0024self__00242007.exiling = true;
						_0024self__00242007.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_0099;
				case 2:
					if (Network.isServer)
					{
						Network.Destroy(_0024self__00242007.GetComponent<NetworkView>().viewID);
						Network.RemoveRPCs(_0024self__00242007.GetComponent<NetworkView>().viewID);
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

		internal MinionScript _0024self__00242008;

		public _0024Exile_00242006(MinionScript self_)
		{
			_0024self__00242008 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242008);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Up_00242009 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MinionScript _0024self__00242010;

			public _0024(MinionScript self_)
			{
				_0024self__00242010 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242010.up = true;
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242010.up = false;
					result = (Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242010.up = true;
					result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MinionScript _0024self__00242011;

		public _0024Up_00242009(MinionScript self_)
		{
			_0024self__00242011 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242011);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242012 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024f_00242013;

			internal MinionScript _0024self__00242014;

			public _0024(MinionScript self_)
			{
				_0024self__00242014 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242014.StartCoroutine_Auto(_0024self__00242014.Die());
					_0024self__00242014.StartCoroutine_Auto(_0024self__00242014.Up());
					_0024f_00242013 = null;
					goto IL_0051;
				case 2:
					if (Network.isServer)
					{
						_0024self__00242014.GetComponent<NetworkView>().RPC("ATK", RPCMode.All);
						_0024f_00242013 = (GameObject)Network.Instantiate(_0024self__00242014.fireball, _0024self__00242014.transform.position, _0024self__00242014.transform.rotation, 0);
						_0024f_00242013.GetComponent<NetworkView>().RPC("SetN", RPCMode.All, _0024self__00242014.mag);
					}
					goto IL_0051;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0051:
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MinionScript _0024self__00242015;

		public _0024Start_00242012(MinionScript self_)
		{
			_0024self__00242015 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242015);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00242016 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MinionScript _0024self__00242017;

			public _0024(MinionScript self_)
			{
				_0024self__00242017 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(7f)) ? 1 : 0);
					break;
				case 2:
					Network.RemoveRPCs(_0024self__00242017.GetComponent<NetworkView>().viewID);
					Network.Destroy(_0024self__00242017.GetComponent<NetworkView>().viewID);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MinionScript _0024self__00242018;

		public _0024Die_00242016(MinionScript self_)
		{
			_0024self__00242018 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242018);
		}
	}

	public GameObject fireball;

	public GameObject @base;

	private int mag;

	private bool up;

	private Transform t;

	private bool exiling;

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00242006(this).GetEnumerator();
	}

	[RPC]
	public virtual void Set(int a)
	{
		mag = a;
	}

	[RPC]
	public virtual void SetN(int a)
	{
		mag = a;
	}

	public virtual void Awake()
	{
		t = transform;
		@base.GetComponent<Animation>()["i"].layer = 1;
		@base.GetComponent<Animation>()["a"].layer = 2;
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 9 && GetComponent<NetworkView>().isMine)
		{
			StartCoroutine_Auto(Exile());
		}
	}

	public virtual IEnumerator Up()
	{
		return new _0024Up_00242009(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (up)
		{
			t.Translate(Vector3.up * Time.deltaTime * 2f);
		}
		else
		{
			t.Translate(Vector3.up * Time.deltaTime * -2f);
		}
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242012(this).GetEnumerator();
	}

	[RPC]
	public virtual void ATK()
	{
		@base.GetComponent<Animation>().Play("a");
	}

	public virtual IEnumerator Die()
	{
		return new _0024Die_00242016(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
