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
	internal sealed class _0024Start_00241212 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024448_00241213;

			internal Vector3 _0024_0024449_00241214;

			internal DmgScript _0024self__00241215;

			public _0024(DmgScript self_)
			{
				_0024self__00241215 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_0042: Expected O, but got Unknown
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0105: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241215.t = ((Component)_0024self__00241215).transform;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.15f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241215.stop = true;
					int num = (_0024_0024448_00241213 = -10);
					Vector3 val = (_0024_0024449_00241214 = _0024self__00241215.t.position);
					float num2 = (_0024_0024449_00241214.z = _0024_0024448_00241213);
					Vector3 val3 = (_0024self__00241215.t.position = _0024_0024449_00241214);
					if (MenuScript.multiplayer > 0)
					{
						if (_0024self__00241215.type == 0)
						{
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.7f)) ? 1 : 0);
							break;
						}
						Object.Destroy((Object)(object)((Component)_0024self__00241215).gameObject, 1f);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00241215).gameObject, 1f);
					}
					goto IL_013d;
				}
				case 3:
					if (MenuScript.multiplayer == 1)
					{
						Network.RemoveRPCs(((Component)_0024self__00241215).networkView.viewID);
						Network.Destroy(((Component)_0024self__00241215).networkView.viewID);
					}
					goto IL_013d;
				case 1:
					{
						result = 0;
						break;
					}
					IL_013d:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal DmgScript _0024self__00241216;

		public _0024Start_00241212(DmgScript self_)
		{
			_0024self__00241216 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241216);
		}
	}

	public int type;

	public TextMesh txtDmg;

	public TextMesh txtDmg2;

	private Transform t;

	private float num;

	private bool stop;

	public DmgScript()
	{
		num = 10f;
	}

	public override void Awake()
	{
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241212(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!stop)
		{
			float y = t.position.y + this.num * Time.deltaTime;
			Vector3 position = t.position;
			float num = (position.y = y);
			Vector3 val2 = (t.position = position);
		}
	}

	public override void SD(int a)
	{
		if (type == 1)
		{
			txtDmg.text = "+" + (object)a + " HP";
		}
		else if (type == 2)
		{
			txtDmg.text = "+" + (object)a + " Mana";
		}
		else
		{
			txtDmg.text = string.Empty + (object)a;
			txtDmg2.text = string.Empty + (object)a;
		}
		txtDmg2.text = txtDmg2.text;
	}

	[RPC]
	public override void SDSN(string a)
	{
		txtDmg.text = string.Empty + a;
		txtDmg2.text = string.Empty + a;
	}

	public override void SDS(string a)
	{
		txtDmg.text = string.Empty + a;
		txtDmg2.text = string.Empty + a;
	}

	[RPC]
	public override void SDN(int a)
	{
		if (type == 1)
		{
			txtDmg.text = "+" + (object)a + " HP";
		}
		else if (type == 2)
		{
			txtDmg.text = "+" + (object)a + " Mana";
		}
		else
		{
			txtDmg.text = string.Empty + (object)a;
			txtDmg2.text = string.Empty + (object)a;
		}
		txtDmg2.text = txtDmg2.text;
	}

	[RPC]
	public override void Initialize(NetworkViewID id)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).networkView.viewID = id;
	}

	public override void Main()
	{
	}
}
