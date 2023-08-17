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
	internal sealed class _0024DropStuff_00242781 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00242782;

			internal Item _0024item_00242783;

			internal GameObject _0024d_00242784;

			internal SpriteScript _0024self__00242785;

			public _0024(SpriteScript self_)
			{
				_0024self__00242785 = self_;
			}

			public override bool MoveNext()
			{
				//IL_008b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0090: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Expected O, but got Unknown
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer == 1)
					{
						goto IL_0027;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 2:
					if (!GameScript.isTown)
					{
						_0024num_00242782 = Random.Range(1, 45);
						_0024item_00242783 = new Item(_0024num_00242782, 1, new int[4], 0f, null);
						_0024d_00242784 = (GameObject)Network.Instantiate(Resources.Load("item"), ((Component)_0024self__00242785).transform.position, Quaternion.identity, 0);
						_0024d_00242784.networkView.RPC("SetID", (RPCMode)6, new object[1] { _0024item_00242783.id });
						_0024d_00242784.networkView.RPC("SetD", (RPCMode)6, new object[1] { _0024item_00242783.d });
						_0024d_00242784.networkView.RPC("SetE", (RPCMode)6, new object[1] { _0024item_00242783.e });
						_0024d_00242784.networkView.RPC("SetQ", (RPCMode)6, new object[1] { _0024item_00242783.q });
					}
					goto IL_0027;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0027:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds((float)Random.Range(40, 60))) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SpriteScript _0024self__00242786;

		public _0024DropStuff_00242781(SpriteScript self_)
		{
			_0024self__00242786 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242786);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChangePos_00242787 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SpriteScript _0024self__00242788;

			public _0024(SpriteScript self_)
			{
				_0024self__00242788 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Expected O, but got Unknown
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242788.bonusX = Random.Range(-4, 5);
					_0024self__00242788.bonusY = Random.Range(1, 4);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
				case 3:
					_0024self__00242788.bonusX = Random.Range(-4, 5);
					_0024self__00242788.bonusY = Random.Range(2, 4);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2.5f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SpriteScript _0024self__00242789;

		public _0024ChangePos_00242787(SpriteScript self_)
		{
			_0024self__00242789 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242789);
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

	public override void Awake()
	{
		Object.DontDestroyOnLoad((Object)(object)this);
		((MonoBehaviour)this).StartCoroutine_Auto(ChangePos());
		if (isBat)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(DropStuff());
		}
	}

	public override IEnumerator DropStuff()
	{
		return new _0024DropStuff_00242781(this).GetEnumerator();
	}

	public override void OnLevelWasLoaded(int level)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (Application.loadedLevel == 0)
		{
			Network.Destroy(((Component)this).networkView.viewID);
		}
		else
		{
			((Component)this).transform.position = new Vector3(0f, 0f, 0f);
		}
	}

	[RPC]
	public override void SETN(GameObject a)
	{
		p = a;
	}

	public override void Set(GameObject a)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		p = a;
		startTime = Time.time;
		startMarker = p.transform;
		endMarker = ((Component)this).transform;
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
		initialized = true;
	}

	public override IEnumerator ChangePos()
	{
		return new _0024ChangePos_00242787(this).GetEnumerator();
	}

	public override void Start()
	{
	}

	public override void Update()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (initialized)
		{
			float num = (Time.time - startTime) * speed;
			float num2 = num / journeyLength;
			Vector3 val = new Vector3(startMarker.position.x + (float)bonusX, startMarker.position.y + (float)bonusY, 0f);
			((Component)this).transform.localPosition = Vector3.Lerp(val, endMarker.position, 0.95f);
		}
	}

	public override void Main()
	{
	}
}
