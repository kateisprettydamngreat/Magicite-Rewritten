using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ScourgeTimer : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Tick_00242110 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_0024802_00242111;

			internal Vector3 _0024_0024803_00242112;

			internal ScourgeTimer _0024self__00242113;

			public _0024(ScourgeTimer self_)
			{
				_0024self__00242113 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0090: Unknown result type (might be due to invalid IL or missing references)
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Expected O, but got Unknown
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						goto IL_0106;
					}
					goto IL_0030;
				case 2:
				{
					curTime += 1f;
					float num = (_0024_0024802_00242111 = curTime / _0024self__00242113.maxTime * 1.5f - 0.75f);
					Vector3 val = (_0024_0024803_00242112 = _0024self__00242113.cursor.transform.localPosition);
					float num2 = (_0024_0024803_00242112.x = _0024_0024802_00242111);
					Vector3 val3 = (_0024self__00242113.cursor.transform.localPosition = _0024_0024803_00242112);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				}
				case 3:
					if (curTime != 10f)
					{
						goto IL_0030;
					}
					_0024self__00242113.gameScript.ScourgeAttack();
					goto IL_0106;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0030:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
					IL_0106:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal ScourgeTimer _0024self__00242114;

		public _0024Tick_00242110(ScourgeTimer self_)
		{
			_0024self__00242114 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242114);
		}
	}

	public GameObject gameManager;

	public GameObject cursor;

	private GameScript gameScript;

	[NonSerialized]
	public static float curTime;

	private float maxTime;

	public ScourgeTimer()
	{
		maxTime = 10f;
	}

	public override void Awake()
	{
		gameScript = (GameScript)(object)gameManager.GetComponent("GameScript");
		((MonoBehaviour)this).StartCoroutine_Auto(Tick());
	}

	public override IEnumerator Tick()
	{
		return new _0024Tick_00242110(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
