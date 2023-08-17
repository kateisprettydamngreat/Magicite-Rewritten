using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class WolfScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00242723 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WolfScript _0024self__00242724;

			public _0024(WolfScript self_)
			{
				_0024self__00242724 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242724.exiling)
					{
						_0024self__00242724.exiling = true;
						_0024self__00242724.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00242724.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00242724.GetComponent<NetworkView>().viewID);
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

		internal WolfScript _0024self__00242725;

		public _0024Exile_00242723(WolfScript self_)
		{
			_0024self__00242725 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242725);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00242726 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WolfScript _0024self__00242727;

			public _0024(WolfScript self_)
			{
				_0024self__00242727 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(_0024self__00242727.waitt)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00242727.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242727.StartCoroutine_Auto(_0024self__00242727.Exile());
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

		internal WolfScript _0024self__00242728;

		public _0024Die_00242726(WolfScript self_)
		{
			_0024self__00242728 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242728);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HitN_00242729 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024995_00242730;

			internal Quaternion _0024_0024996_00242731;

			internal int _0024_0024997_00242732;

			internal Quaternion _0024_0024998_00242733;

			internal int _0024_0024999_00242734;

			internal Quaternion _0024_00241000_00242735;

			internal int _0024_00241001_00242736;

			internal Quaternion _0024_00241002_00242737;

			internal WolfScript _0024self__00242738;

			public _0024(WolfScript self_)
			{
				_0024self__00242738 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242738.GetComponent<NetworkView>().isMine)
					{
						goto case 2;
					}
					YieldDefault(1);
					goto case 1;
				case 2:
					_0024self__00242738.newPos = new Vector3(_0024self__00242738.t.position.x, _0024self__00242738.t.position.y - 1f, 0f);
					_0024self__00242738.ray = new Ray(_0024self__00242738.t.position, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242738.ray, out _0024self__00242738.hit, 2.5f) && (_0024self__00242738.hit.transform.gameObject.layer == 9 || _0024self__00242738.hit.transform.gameObject.layer == 12))
					{
						_0024self__00242738.hit.transform.gameObject.SendMessage("TD", _0024self__00242738.ATK);
					}
					_0024self__00242738.ray = new Ray(_0024self__00242738.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242738.ray, out _0024self__00242738.hit, 2.5f) && (_0024self__00242738.hit.transform.gameObject.layer == 9 || _0024self__00242738.hit.transform.gameObject.layer == 12))
					{
						_0024self__00242738.hit.transform.gameObject.SendMessage("TD", _0024self__00242738.ATK);
					}
					_0024self__00242738.ray = new Ray(_0024self__00242738.t.position, new Vector3(1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242738.ray, out _0024self__00242738.hit, 3f, 2048))
					{
						if (_0024self__00242738.t.rotation.y <= 0f)
						{
							int num = (_0024_0024997_00242732 = 180);
							Quaternion quaternion = (_0024_0024998_00242733 = _0024self__00242738.t.rotation);
							float num2 = (_0024_0024998_00242733.y = _0024_0024997_00242732);
							Quaternion quaternion3 = (_0024self__00242738.t.rotation = _0024_0024998_00242733);
						}
						else
						{
							int num3 = (_0024_0024995_00242730 = 0);
							Quaternion quaternion4 = (_0024_0024996_00242731 = _0024self__00242738.t.rotation);
							float num4 = (_0024_0024996_00242731.y = _0024_0024995_00242730);
							Quaternion quaternion6 = (_0024self__00242738.t.rotation = _0024_0024996_00242731);
						}
					}
					_0024self__00242738.ray = new Ray(_0024self__00242738.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024self__00242738.ray, out _0024self__00242738.hit, 3f, 2048))
					{
						if (_0024self__00242738.t.rotation.y <= 0f)
						{
							int num5 = (_0024_00241001_00242736 = 180);
							Quaternion quaternion7 = (_0024_00241002_00242737 = _0024self__00242738.t.rotation);
							float num6 = (_0024_00241002_00242737.y = _0024_00241001_00242736);
							Quaternion quaternion9 = (_0024self__00242738.t.rotation = _0024_00241002_00242737);
						}
						else
						{
							int num7 = (_0024_0024999_00242734 = 0);
							Quaternion quaternion10 = (_0024_00241000_00242735 = _0024self__00242738.t.rotation);
							float num8 = (_0024_00241000_00242735.y = _0024_0024999_00242734);
							Quaternion quaternion12 = (_0024self__00242738.t.rotation = _0024_00241000_00242735);
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

		internal WolfScript _0024self__00242739;

		public _0024HitN_00242729(WolfScript self_)
		{
			_0024self__00242739 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242739);
		}
	}

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

	private bool exiling;

	public WolfScript()
	{
		HP = 20;
		waitt = 10;
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
		r = GetComponent<Rigidbody>();
		t = transform;
		@base.GetComponent<Animation>()["i"].layer = 1;
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
		return new _0024Exile_00242723(this).GetEnumerator();
	}

	public virtual IEnumerator Die()
	{
		return new _0024Die_00242726(this).GetEnumerator();
	}

	public virtual void Update()
	{
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
			int num = 13;
			Vector3 velocity = GetComponent<Rigidbody>().velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		}
		else
		{
			int num3 = -13;
			Vector3 velocity2 = GetComponent<Rigidbody>().velocity;
			float num4 = (velocity2.x = num3);
			Vector3 vector4 = (GetComponent<Rigidbody>().velocity = velocity2);
		}
	}

	public virtual IEnumerator HitN()
	{
		return new _0024HitN_00242729(this).GetEnumerator();
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
