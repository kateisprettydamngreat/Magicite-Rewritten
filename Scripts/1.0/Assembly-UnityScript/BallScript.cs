using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BallScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00241317 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BallScript _0024self__00241318;

			public _0024(BallScript self_)
			{
				_0024self__00241318 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Expected O, but got Unknown
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((MenuScript.multiplayer <= 0) ? ((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(4f)) : ((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(4f))) ? 1 : 0);
					break;
				case 2:
					Network.RemoveRPCs(((Component)_0024self__00241318).networkView.viewID);
					Network.Destroy(((Component)_0024self__00241318).networkView.viewID);
					goto IL_008b;
				case 3:
					Object.Destroy((Object)(object)((Component)_0024self__00241318).gameObject);
					goto IL_008b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_008b:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BallScript _0024self__00241319;

		public _0024Die_00241317(BallScript self_)
		{
			_0024self__00241319 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241319);
		}
	}

	public bool isLeft;

	private int dir;

	private int speed;

	private Transform t;

	public BallScript()
	{
		speed = 10;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		dir = Random.Range(-1, 2);
		if (isLeft)
		{
			speed = 10;
		}
		else
		{
			speed = -10;
		}
		((MonoBehaviour)this).StartCoroutine_Auto(Die());
	}

	public override IEnumerator Die()
	{
		return new _0024Die_00241317(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (dir == -1)
		{
			t.Translate(Vector3.up * 3f * Time.deltaTime);
		}
		else if (dir == 1)
		{
			t.Translate(Vector3.up * -3f * Time.deltaTime);
		}
		t.Translate(Vector3.left * (float)speed * Time.deltaTime);
	}

	public override void Main()
	{
	}
}
