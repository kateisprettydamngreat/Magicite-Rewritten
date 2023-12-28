using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class DmgScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241354 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024487_00241355;

			internal Vector3 _0024_0024488_00241356;

			internal DmgScript _0024self__00241357;

			public _0024(DmgScript self_)
			{
				_0024self__00241357 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241357.t = _0024self__00241357.transform;
					if (_0024self__00241357.isAltar)
					{
						_0024self__00241357.wait = 3.5f;
					}
					else
					{
						_0024self__00241357.wait = 1f;
					}
					result = (Yield(2, new WaitForSeconds(0.15f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241357.stop = true;
					int num = (_0024_0024487_00241355 = -10);
					Vector3 vector = (_0024_0024488_00241356 = _0024self__00241357.t.position);
					float num2 = (_0024_0024488_00241356.z = _0024_0024487_00241355);
					Vector3 vector3 = (_0024self__00241357.t.position = _0024_0024488_00241356);
					if (_0024self__00241357.type == 0)
					{
						result = (Yield(3, new WaitForSeconds(_0024self__00241357.wait)) ? 1 : 0);
						break;
					}
					if (_0024self__00241357.type == 3)
					{
						UnityEngine.Object.Destroy(_0024self__00241357.gameObject, _0024self__00241357.wait);
					}
					else
					{
						UnityEngine.Object.Destroy(_0024self__00241357.gameObject, _0024self__00241357.wait);
					}
					goto IL_0168;
				}
				case 3:
					UnityEngine.Object.Destroy(_0024self__00241357.gameObject);
					goto IL_0168;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0168:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal DmgScript _0024self__00241358;

		public _0024Start_00241354(DmgScript self_)
		{
			_0024self__00241358 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241358);
		}
	}

	public int type;

	public TextMesh txtDmg;

	public TextMesh txtDmg2;

	private Transform t;

	private float num;

	private bool stop;

	public bool isAltar;

	private float wait;

	public DmgScript()
	{
		num = 10f;
	}

	public virtual void Awake()
	{
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241354(this).GetEnumerator();
	}

	public virtual void Update()
	{
		if (!stop)
		{
			float y = t.position.y + this.num * Time.deltaTime;
			Vector3 position = t.position;
			float num = (position.y = y);
			Vector3 vector2 = (t.position = position);
		}
	}

	public virtual void SD(int a)
	{
		if (type == 1)
		{
			txtDmg.text = "+" + a + " HP";
		}
		else if (type == 2)
		{
			txtDmg.text = "+" + a + " Mana";
		}
		else if (type == 3)
		{
			txtDmg.text = "+" + a;
			txtDmg2.text = "+" + a;
		}
		txtDmg2.text = txtDmg.text;
	}

	[RPC]
	public virtual void SDSN(string a)
	{
		txtDmg.text = string.Empty + a;
		txtDmg2.text = string.Empty + a;
	}

	public virtual void SDS(string a)
	{
		txtDmg.text = string.Empty + a;
		txtDmg2.text = string.Empty + a;
	}

	public virtual void SDN(int a)
	{
		if (type == 1)
		{
			txtDmg.text = "+" + a + " HP";
		}
		else if (type == 2)
		{
			txtDmg.text = "+" + a + " Mana";
		}
		else
		{
			txtDmg.text = string.Empty + a;
			txtDmg2.text = string.Empty + a;
		}
		txtDmg2.text = txtDmg2.text;
	}

	[RPC]
	public virtual void Initialize(NetworkViewID id)
	{
		GetComponent<NetworkView>().viewID = id;
	}

	}