using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SummonSkeleton : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242626 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SummonSkeleton _0024self__00242627;

			public _0024(SummonSkeleton self_)
			{
				_0024self__00242627 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242627.exiling)
					{
						_0024self__00242627.exiling = true;
						_0024self__00242627.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00242627.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00242627.GetComponent<NetworkView>().viewID);
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

		internal SummonSkeleton _0024self__00242628;

		public _0024Exile_00242626(SummonSkeleton self_)
		{
			_0024self__00242628 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242628);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00242629 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SummonSkeleton _0024self__00242630;

			public _0024(SummonSkeleton self_)
			{
				_0024self__00242630 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(_0024self__00242630.waitt)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242630.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242630.StartCoroutine_Auto(_0024self__00242630.Exile());
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

		internal SummonSkeleton _0024self__00242631;

		public _0024Die_00242629(SummonSkeleton self_)
		{
			_0024self__00242631 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242631);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HitN_00242632 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024961_00242633;

			internal Quaternion _0024_0024962_00242634;

			internal int _0024_0024963_00242635;

			internal Quaternion _0024_0024964_00242636;

			internal int _0024_0024965_00242637;

			internal Quaternion _0024_0024966_00242638;

			internal int _0024_0024967_00242639;

			internal Quaternion _0024_0024968_00242640;

			internal SummonSkeleton _0024self__00242641;

			public _0024(SummonSkeleton self_)
			{
				_0024self__00242641 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242641.GetComponent<NetworkView>().isMine)
					{
						goto case 2;
					}
					YieldDefault(1);
					goto case 1;
				case 2:
					_0024self__00242641.ray = new Ray(_0024self__00242641.t.position, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242641.ray, out _0024self__00242641.hit, 3f, 512) && (_0024self__00242641.hit.transform.gameObject.layer == 9 || _0024self__00242641.hit.transform.gameObject.layer == 12))
					{
						_0024self__00242641.hit.transform.gameObject.SendMessage("TD", _0024self__00242641.DOOD);
					}
					_0024self__00242641.ray = new Ray(_0024self__00242641.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242641.ray, out _0024self__00242641.hit, 3f, 512) && (_0024self__00242641.hit.transform.gameObject.layer == 9 || _0024self__00242641.hit.transform.gameObject.layer == 12))
					{
						_0024self__00242641.hit.transform.gameObject.SendMessage("TD", _0024self__00242641.DOOD);
					}
					_0024self__00242641.ray = new Ray(_0024self__00242641.t.position, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242641.ray, out _0024self__00242641.hit, 3f, 2048))
					{
						if (_0024self__00242641.t.rotation.y <= 0f)
						{
							int num = (_0024_0024963_00242635 = 180);
							Quaternion quaternion = (_0024_0024964_00242636 = _0024self__00242641.t.rotation);
							float num2 = (_0024_0024964_00242636.y = _0024_0024963_00242635);
							Quaternion quaternion3 = (_0024self__00242641.t.rotation = _0024_0024964_00242636);
						}
						else
						{
							int num3 = (_0024_0024961_00242633 = 0);
							Quaternion quaternion4 = (_0024_0024962_00242634 = _0024self__00242641.t.rotation);
							float num4 = (_0024_0024962_00242634.y = _0024_0024961_00242633);
							Quaternion quaternion6 = (_0024self__00242641.t.rotation = _0024_0024962_00242634);
						}
					}
					_0024self__00242641.ray = new Ray(_0024self__00242641.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242641.ray, out _0024self__00242641.hit, 3f, 2048))
					{
						if (_0024self__00242641.t.rotation.y <= 0f)
						{
							int num5 = (_0024_0024967_00242639 = 180);
							Quaternion quaternion7 = (_0024_0024968_00242640 = _0024self__00242641.t.rotation);
							float num6 = (_0024_0024968_00242640.y = _0024_0024967_00242639);
							Quaternion quaternion9 = (_0024self__00242641.t.rotation = _0024_0024968_00242640);
						}
						else
						{
							int num7 = (_0024_0024965_00242637 = 0);
							Quaternion quaternion10 = (_0024_0024966_00242638 = _0024self__00242641.t.rotation);
							float num8 = (_0024_0024966_00242638.y = _0024_0024965_00242637);
							Quaternion quaternion12 = (_0024self__00242641.t.rotation = _0024_0024966_00242638);
						}
					}
					result = (Yield(2, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SummonSkeleton _0024self__00242642;

		public _0024HitN_00242632(SummonSkeleton self_)
		{
			_0024self__00242642 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242642);
		}
	}

	public bool isZombie;

	public GameObject @base;

	public GameObject e;

	private Ray ray;

	private RaycastHit hit;

	private Transform t;

	private Rigidbody r;

	private int HP;

	private int ATK;

	private int DEX;

	private bool left;

	private Vector3 newPos;

	private int waitt;

	private int DOOD;

	private bool exiling;

	public SummonSkeleton()
	{
		HP = 20;
		waitt = 16;
		DOOD = 1;
	}

	public virtual void Set(int dex)
	{
		DEX = dex;
		waitt = (int)((float)waitt + (float)DEX * 0.7f);
		ATK = (int)((float)DEX * 0.5f);
	}

	[RPC]
	public virtual void SetN(int dex)
	{
		DEX = dex;
		waitt = (int)((float)waitt + (float)DEX * 0.7f);
		ATK = (int)((float)DEX * 0.5f);
	}

	public virtual void Awake()
	{
		if (isZombie)
		{
			DOOD = 5;
		}
		r = GetComponent<Rigidbody>();
		t = transform;
		@base.GetComponent<Animation>()["a"].layer = 1;
		int num = 15;
		Vector3 velocity = r.velocity;
		float num2 = (velocity.y = num);
		Vector3 vector2 = (r.velocity = velocity);
		Hit();
		StartCoroutine_Auto(Die());
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00242626(this).GetEnumerator();
	}

	public virtual IEnumerator Die()
	{
		return new _0024Die_00242629(this).GetEnumerator();
	}

	public virtual void Update()
	{
		newPos = new Vector3(t.position.x, t.position.y - 1f, 0f);
		if (t.rotation.y == 0f)
		{
			left = true;
		}
		else
		{
			left = false;
		}
		if (left)
		{
			int num = 8;
			Vector3 velocity = GetComponent<Rigidbody>().velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		}
		else
		{
			int num3 = -8;
			Vector3 velocity2 = GetComponent<Rigidbody>().velocity;
			float num4 = (velocity2.x = num3);
			Vector3 vector4 = (GetComponent<Rigidbody>().velocity = velocity2);
		}
	}

	public virtual IEnumerator HitN()
	{
		return new _0024HitN_00242632(this).GetEnumerator();
	}

	public virtual void Hit()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			StartCoroutine_Auto(HitN());
		}
	}

	public virtual void Main()
	{
	}
}
