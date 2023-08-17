using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SpriteScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DropStuff_00242613 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242614;

			internal int[] _0024stats_00242615;

			internal Item _0024item_00242616;

			internal GameObject _0024d_00242617;

			internal SpriteScript _0024self__00242618;

			public _0024(SpriteScript self_)
			{
				_0024self__00242618 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242618.GetComponent<NetworkView>().isMine)
					{
						goto IL_0031;
					}
					YieldDefault(1);
					goto case 1;
				case 2:
					if (!GameScript.isTown)
					{
						_0024num_00242614 = UnityEngine.Random.Range(1, 45);
						if (_0024num_00242614 == 49 || _0024num_00242614 == 11)
						{
							_0024num_00242614 = 9;
						}
						_0024stats_00242615 = null;
						_0024item_00242616 = new Item(_0024num_00242614, 1, new int[4], 0f, null);
						_0024d_00242617 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), _0024self__00242618.transform.position, Quaternion.identity);
						_0024stats_00242615 = new int[7]
						{
							_0024item_00242616.id,
							_0024item_00242616.q,
							_0024item_00242616.e[0],
							_0024item_00242616.e[1],
							_0024item_00242616.e[2],
							_0024item_00242616.e[3],
							_0024item_00242616.d
						};
						_0024d_00242617.SendMessage("InitL", _0024stats_00242615);
					}
					goto IL_0031;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0031:
					result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(40, 60))) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SpriteScript _0024self__00242619;

		public _0024DropStuff_00242613(SpriteScript self_)
		{
			_0024self__00242619 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242619);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChangePos_00242620 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SpriteScript _0024self__00242621;

			public _0024(SpriteScript self_)
			{
				_0024self__00242621 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242621.bonusX = UnityEngine.Random.Range(-4, 5);
					_0024self__00242621.bonusY = UnityEngine.Random.Range(1, 4);
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
				case 3:
					_0024self__00242621.bonusX = UnityEngine.Random.Range(-4, 5);
					_0024self__00242621.bonusY = UnityEngine.Random.Range(2, 4);
					result = (Yield(3, new WaitForSeconds(2.5f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SpriteScript _0024self__00242622;

		public _0024ChangePos_00242620(SpriteScript self_)
		{
			_0024self__00242622 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242622);
		}
	}

	public bool isBat;

	public Transform startMarker;

	public Transform endMarker;

	public GameObject p;

	public float speed;

	private bool initialized;

	private float startTime;

	private int bonusX;

	private int bonusY;

	private float journeyLength;

	public Transform target;

	public float smooth;

	public SpriteScript()
	{
		speed = 1f;
		smooth = 5f;
	}

	public virtual void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(this);
		StartCoroutine_Auto(ChangePos());
		if (isBat)
		{
			StartCoroutine_Auto(DropStuff());
		}
	}

	public virtual IEnumerator DropStuff()
	{
		return new _0024DropStuff_00242613(this).GetEnumerator();
	}

	public virtual void OnLevelWasLoaded(int level)
	{
		if (Application.loadedLevel == 0)
		{
			Network.Destroy(GetComponent<NetworkView>().viewID);
		}
		else
		{
			transform.position = new Vector3(0f, 0f, 0f);
		}
	}

	[RPC]
	public virtual void SETN(GameObject a)
	{
		p = a;
	}

	public virtual void Set(GameObject a)
	{
		p = a;
		startTime = Time.time;
		startMarker = p.transform;
		endMarker = transform;
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
		initialized = true;
	}

	public virtual IEnumerator ChangePos()
	{
		return new _0024ChangePos_00242620(this).GetEnumerator();
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (initialized)
		{
			float num = (Time.time - startTime) * speed;
			float num2 = num / journeyLength;
			Vector3 a = new Vector3(startMarker.position.x + (float)bonusX, startMarker.position.y + (float)bonusY, 0f);
			transform.localPosition = Vector3.Lerp(a, endMarker.position, 0.95f);
		}
	}

	public virtual void Main()
	{
	}
}
