using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FireBall : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241487 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Renderer _0024r2_00241488;

			internal float _0024_0024553_00241489;

			internal Vector2 _0024_0024554_00241490;

			internal float _0024_0024555_00241491;

			internal Vector2 _0024_0024556_00241492;

			internal FireBall _0024self__00241493;

			public _0024(FireBall self_)
			{
				_0024self__00241493 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241493.r = _0024self__00241493.@base.GetComponent<Renderer>();
					_0024r2_00241488 = null;
					if ((bool)_0024self__00241493.base2)
					{
						_0024r2_00241488 = _0024self__00241493.base2.GetComponent<Renderer>();
					}
					_0024self__00241493.t = _0024self__00241493.transform;
					goto case 2;
				case 2:
				{
					float num = (_0024_0024553_00241489 = _0024self__00241493.r.material.mainTextureOffset.x + 0.25f);
					Vector2 vector = (_0024_0024554_00241490 = _0024self__00241493.r.material.mainTextureOffset);
					float num2 = (_0024_0024554_00241490.x = _0024_0024553_00241489);
					Vector2 vector3 = (_0024self__00241493.r.material.mainTextureOffset = _0024_0024554_00241490);
					if ((bool)_0024r2_00241488)
					{
						float num3 = (_0024_0024555_00241491 = _0024r2_00241488.GetComponent<Material>().mainTextureOffset.x + 0.25f);
						Vector2 vector4 = (_0024_0024556_00241492 = _0024r2_00241488.GetComponent<Material>().mainTextureOffset);
						float num4 = (_0024_0024556_00241492.x = _0024_0024555_00241491);
						Vector2 vector6 = (_0024r2_00241488.GetComponent<Material>().mainTextureOffset = _0024_0024556_00241492);
					}
					result = (Yield(2, new WaitForSeconds(_0024self__00241493.wait)) ? 1 : 0);
					break;
				}
				case 3:
					if (_0024self__00241493.GetComponent<NetworkView>().isMine)
					{
						_0024self__00241493.StartCoroutine_Auto(_0024self__00241493.Exile());
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

		internal FireBall _0024self__00241494;

		public _0024Start_00241487(FireBall self_)
		{
			_0024self__00241494 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241494);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Exile_00241495 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal FireBall _0024self__00241496;

			public _0024(FireBall self_)
			{
				_0024self__00241496 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241496.exiling)
					{
						_0024self__00241496.exiling = true;
						_0024self__00241496.t.position = new Vector3(0f, 0f, -500f);
						result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
						break;
					}
					goto IL_008f;
				case 2:
					Network.Destroy(_0024self__00241496.GetComponent<NetworkView>().viewID);
					Network.RemoveRPCs(_0024self__00241496.GetComponent<NetworkView>().viewID);
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

		internal FireBall _0024self__00241497;

		public _0024Exile_00241495(FireBall self_)
		{
			_0024self__00241497 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241497);
		}
	}

	public bool isRight;

	public GameObject @base;

	public GameObject base2;

	private Renderer r;

	public GameObject lightObj;

	public int min;

	public int max;

	public float wait;

	public float speed;

	private int MAG;

	private Transform t;

	private bool exiling;

	public FireBall()
	{
		speed = 3f;
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241487(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator Exile()
	{
		return new _0024Exile_00241495(this).GetEnumerator();
	}

	[RPC]
	public virtual void SetNN(int m)
	{
		MAG = m;
	}

	[RPC]
	public virtual void SetN(int m)
	{
		MAG = m;
	}

	public virtual void Set(int m)
	{
		GetComponent<NetworkView>().RPC("SetNN", RPCMode.All, m);
	}

	public virtual void Update()
	{
		speed += 0.2f * Time.deltaTime;
		if (isRight)
		{
			t.Translate(Vector3.left * Time.deltaTime * (0f - speed));
		}
		else
		{
			t.Translate(Vector3.left * Time.deltaTime * speed);
		}
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 9 || c.gameObject.layer == 12)
		{
			c.gameObject.SendMessage("TD", MAG);
			StartCoroutine_Auto(Exile());
		}
		else if (c.gameObject.layer == 8 && MenuScript.pvp == 1 && !GetComponent<NetworkView>().isMine)
		{
			c.gameObject.SendMessage("TD", MAG);
		}
	}

	}