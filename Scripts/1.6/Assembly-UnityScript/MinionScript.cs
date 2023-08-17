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
	internal sealed class _0024Up_00242161 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MinionScript _0024self__00242162;

			public _0024(MinionScript self_)
			{
				_0024self__00242162 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Expected O, but got Unknown
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Expected O, but got Unknown
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_0041: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242162.up = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242162.up = false;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242162.up = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MinionScript _0024self__00242163;

		public _0024Up_00242161(MinionScript self_)
		{
			_0024self__00242163 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242163);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242164 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024f_00242165;

			internal MinionScript _0024self__00242166;

			public _0024(MinionScript self_)
			{
				_0024self__00242166 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0138: Unknown result type (might be due to invalid IL or missing references)
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Expected O, but got Unknown
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Expected O, but got Unknown
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d2: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					((MonoBehaviour)_0024self__00242166).StartCoroutine_Auto(_0024self__00242166.Die());
					((MonoBehaviour)_0024self__00242166).StartCoroutine_Auto(_0024self__00242166.Up());
					_0024f_00242165 = null;
					goto IL_0051;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							((Component)_0024self__00242166).networkView.RPC("ATK", (RPCMode)2, new object[0]);
							_0024f_00242165 = (GameObject)Network.Instantiate((Object)(object)_0024self__00242166.fireball, ((Component)_0024self__00242166).transform.position, ((Component)_0024self__00242166).transform.rotation, 0);
							_0024f_00242165.networkView.RPC("SetN", (RPCMode)2, new object[1] { _0024self__00242166.mag });
						}
					}
					else
					{
						_0024self__00242166.@base.animation.Play("a");
						_0024f_00242165 = (GameObject)Object.Instantiate((Object)(object)_0024self__00242166.fireball, ((Component)_0024self__00242166).transform.position, ((Component)_0024self__00242166).transform.rotation);
						_0024f_00242165.SendMessage("Set", (object)_0024self__00242166.mag);
					}
					goto IL_0051;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0051:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MinionScript _0024self__00242167;

		public _0024Start_00242164(MinionScript self_)
		{
			_0024self__00242167 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242167);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Die_00242168 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MinionScript _0024self__00242169;

			public _0024(MinionScript self_)
			{
				_0024self__00242169 = self_;
			}

			public override bool MoveNext()
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected O, but got Unknown
				//IL_0040: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(7f)) ? 1 : 0);
					break;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						Network.RemoveRPCs(((Component)_0024self__00242169).networkView.viewID);
						Network.Destroy(((Component)_0024self__00242169).networkView.viewID);
					}
					else
					{
						Object.Destroy((Object)(object)((Component)_0024self__00242169).gameObject);
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MinionScript _0024self__00242170;

		public _0024Die_00242168(MinionScript self_)
		{
			_0024self__00242170 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242170);
		}
	}

	public GameObject fireball;

	public GameObject @base;

	private int mag;

	private bool up;

	private Transform t;

	[RPC]
	public override void Set(int a)
	{
		mag = a;
	}

	[RPC]
	public override void SetN(int a)
	{
		mag = a;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		@base.animation["i"].layer = 1;
		@base.animation["a"].layer = 2;
	}

	public override void OnTriggerEnter(Collider c)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)c).gameObject.layer == 9)
		{
			if (MenuScript.multiplayer > 0)
			{
				Network.RemoveRPCs(((Component)this).networkView.viewID);
				Network.Destroy(((Component)this).networkView.viewID);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
		}
	}

	public override IEnumerator Up()
	{
		return new _0024Up_00242161(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (up)
		{
			t.Translate(Vector3.up * Time.deltaTime * 2f);
		}
		else
		{
			t.Translate(Vector3.up * Time.deltaTime * -2f);
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242164(this).GetEnumerator();
	}

	[RPC]
	public override void ATK()
	{
		@base.animation.Play("a");
	}

	public override IEnumerator Die()
	{
		return new _0024Die_00242168(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
