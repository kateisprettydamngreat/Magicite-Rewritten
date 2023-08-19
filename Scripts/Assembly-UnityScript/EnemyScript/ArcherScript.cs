using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ArcherScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241155 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00241156;

			internal ArcherScript _0024self__00241157;

			public _0024(ArcherScript self_)
			{
				_0024self__00241157 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241157.@base.GetComponent<Animation>()["i"].layer = 0;
					_0024self__00241157.@base.GetComponent<Animation>()["a"].layer = 1;
					_0024drops_00241156 = new int[3] { 15, 18, 15 };
					_0024self__00241157.SetStats(40, 13, 10, 8, 3f, _0024drops_00241156, UnityEngine.Random.Range(7, 15), 8);
					goto case 2;
				case 2:
					result = (Yield(2, _0024self__00241157.StartCoroutine_Auto(_0024self__00241157.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArcherScript _0024self__00241158;

		public _0024Start_00241155(ArcherScript self_)
		{
			_0024self__00241158 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__00241158);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241159 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal Vector3 _0024startPos_00241160;

			internal Ray _0024ray_00241161;

			internal Ray _0024ray2_00241162;

			internal int _0024_0024389_00241163;

			internal Vector3 _0024_0024390_00241164;

			internal int _0024_0024391_00241165;

			internal Vector3 _0024_0024392_00241166;

			internal int _0024_0024393_00241167;

			internal Vector3 _0024_0024394_00241168;

			internal int _0024_0024395_00241169;

			internal Vector3 _0024_0024396_00241170;

			internal int _0024_0024397_00241171;

			internal Vector3 _0024_0024398_00241172;

			internal ArcherScript _0024self__00241173;

			public _0024(ArcherScript self_)
			{
				_0024self__00241173 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241173.attacking)
					{
						_0024startPos_00241160 = new Vector3(_0024self__00241173.t.position.x, _0024self__00241173.t.position.y - 0.5f, 0f);
						_0024ray_00241161 = new Ray(_0024startPos_00241160, new Vector3(1f, 0f, 0f));
						_0024ray2_00241162 = new Ray(_0024startPos_00241160, new Vector3(-1f, 0f, 0f));
						if (Physics.Raycast(_0024ray_00241161, out _0024self__00241173.hit, 15f, 256))
						{
							_0024self__00241173.GetComponent<AudioSource>().PlayOneShot(_0024self__00241173.audioFire);
							_0024self__00241173.attacking = true;
							_0024self__00241173.@base.GetComponent<Animation>().Play("a");
							_0024self__00241173.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (Yield(2, new WaitForSeconds(0.4f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00241162, out _0024self__00241173.hit, 15f, 256))
						{
							_0024self__00241173.GetComponent<AudioSource>().PlayOneShot(_0024self__00241173.audioFire);
							_0024self__00241173.attacking = true;
							_0024self__00241173.@base.GetComponent<Animation>().Play("a");
							_0024self__00241173.e.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
							result = (Yield(4, new WaitForSeconds(0.4f)) ? 1 : 0);
							break;
						}
					}
					goto case 3;
				case 2:
				{
					if (Network.isServer)
					{
						Network.Instantiate(_0024self__00241173.arrowR, _0024self__00241173.t.position, Quaternion.identity, 0);
					}
					int num7 = (_0024_0024389_00241163 = 10);
					Vector3 vector10 = (_0024_0024390_00241164 = _0024self__00241173.r.velocity);
					float num8 = (_0024_0024390_00241164.y = _0024_0024389_00241163);
					Vector3 vector12 = (_0024self__00241173.r.velocity = _0024_0024390_00241164);
					int num9 = (_0024_0024391_00241165 = -3);
					Vector3 vector13 = (_0024_0024392_00241166 = _0024self__00241173.r.velocity);
					float num10 = (_0024_0024392_00241166.x = _0024_0024391_00241165);
					Vector3 vector15 = (_0024self__00241173.r.velocity = _0024_0024392_00241166);
					result = (Yield(3, new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 4:
				{
					if (Network.isServer)
					{
						Network.Instantiate(_0024self__00241173.arrowL, _0024self__00241173.t.position, Quaternion.identity, 0);
					}
					int num3 = (_0024_0024393_00241167 = 10);
					Vector3 vector4 = (_0024_0024394_00241168 = _0024self__00241173.r.velocity);
					float num4 = (_0024_0024394_00241168.y = _0024_0024393_00241167);
					Vector3 vector6 = (_0024self__00241173.r.velocity = _0024_0024394_00241168);
					int num5 = (_0024_0024395_00241169 = 3);
					Vector3 vector7 = (_0024_0024396_00241170 = _0024self__00241173.r.velocity);
					float num6 = (_0024_0024396_00241170.x = _0024_0024395_00241169);
					Vector3 vector9 = (_0024self__00241173.r.velocity = _0024_0024396_00241170);
					result = (Yield(5, new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 3:
				case 5:
					result = (Yield(6, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 6:
				{
					_0024self__00241173.attacking = false;
					int num = (_0024_0024397_00241171 = 0);
					Vector3 vector = (_0024_0024398_00241172 = _0024self__00241173.r.velocity);
					float num2 = (_0024_0024398_00241172.x = _0024_0024397_00241171);
					Vector3 vector3 = (_0024self__00241173.r.velocity = _0024_0024398_00241172);
					YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArcherScript _0024self__00241174;

		public _0024AttackCheck_00241159(ArcherScript self_)
		{
			_0024self__00241174 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new _0024(_0024self__00241174);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241175 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024num_00241176;

			internal int _0024dir_00241177;

			internal int _0024_0024399_00241178;

			internal Vector3 _0024_0024400_00241179;

			internal ArcherScript _0024self__00241180;

			public _0024(ArcherScript self_)
			{
				_0024self__00241180 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00241180.attacking)
					{
						_0024self__00241180.moving = true;
						int num = (_0024_0024399_00241178 = 0);
						Vector3 vector = (_0024_0024400_00241179 = _0024self__00241180.GetComponent<Rigidbody>().velocity);
						float num2 = (_0024_0024400_00241179.x = _0024_0024399_00241178);
						Vector3 vector3 = (_0024self__00241180.GetComponent<Rigidbody>().velocity = _0024_0024400_00241179);
						result = (Yield(2, new WaitForSeconds(UnityEngine.Random.Range(0, 3))) ? 1 : 0);
					}
					else
					{
						result = (Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					}
					break;
				case 2:
					_0024num_00241176 = UnityEngine.Random.Range(0, 4);
					_0024dir_00241177 = UnityEngine.Random.Range(1, 3);
					_0024self__00241180.dir = _0024dir_00241177;
					result = (Yield(3, new WaitForSeconds(_0024num_00241176)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241180.moving = false;
					_0024self__00241180.dir = 0;
					goto case 4;
				case 4:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArcherScript _0024self__00241181;

		public _0024MoveCheck_00241175(ArcherScript self_)
		{
			_0024self__00241181 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241181);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00241182 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal Vector3 _0024startPos_00241183;

			internal Ray _0024ray_00241184;

			internal Ray _0024ray2_00241185;

			internal int _0024_0024401_00241186;

			internal Vector3 _0024_0024402_00241187;

			internal int _0024_0024403_00241188;

			internal Vector3 _0024_0024404_00241189;

			internal int _0024_0024405_00241190;

			internal Vector3 _0024_0024406_00241191;

			internal int _0024_0024407_00241192;

			internal Vector3 _0024_0024408_00241193;

			internal ArcherScript _0024self__00241194;

			public _0024(ArcherScript self_)
			{
				_0024self__00241194 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024startPos_00241183 = new Vector3(_0024self__00241194.t.position.x, _0024self__00241194.t.position.y - 0.5f, 0f);
					_0024ray_00241184 = new Ray(_0024startPos_00241183, new Vector3(1f, 0f, 0f));
					_0024ray2_00241185 = new Ray(_0024startPos_00241183, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241184, out _0024self__00241194.hit, 15f, 256))
					{
						_0024self__00241194.attacking = true;
						_0024self__00241194.GetComponent<AudioSource>().PlayOneShot(_0024self__00241194.audioFire);
						_0024self__00241194.attacking = true;
						_0024self__00241194.@base.GetComponent<Animation>().Play("a");
						_0024self__00241194.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (Yield(2, new WaitForSeconds(0.4f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241185, out _0024self__00241194.hit, 15f, 256))
					{
						_0024self__00241194.GetComponent<AudioSource>().PlayOneShot(_0024self__00241194.audioFire);
						_0024self__00241194.attacking = true;
						_0024self__00241194.@base.GetComponent<Animation>().Play("a");
						_0024self__00241194.e.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
						result = (Yield(4, new WaitForSeconds(0.4f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 2:
				{
					Network.Instantiate(_0024self__00241194.arrowR, _0024self__00241194.t.position, Quaternion.identity, 0);
					int num5 = (_0024_0024401_00241186 = 10);
					Vector3 vector7 = (_0024_0024402_00241187 = _0024self__00241194.r.velocity);
					float num6 = (_0024_0024402_00241187.y = _0024_0024401_00241186);
					Vector3 vector9 = (_0024self__00241194.r.velocity = _0024_0024402_00241187);
					int num7 = (_0024_0024403_00241188 = -3);
					Vector3 vector10 = (_0024_0024404_00241189 = _0024self__00241194.r.velocity);
					float num8 = (_0024_0024404_00241189.x = _0024_0024403_00241188);
					Vector3 vector12 = (_0024self__00241194.r.velocity = _0024_0024404_00241189);
					result = (Yield(3, new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 4:
				{
					Network.Instantiate(_0024self__00241194.arrowL, _0024self__00241194.t.position, Quaternion.identity, 0);
					int num = (_0024_0024405_00241190 = 10);
					Vector3 vector = (_0024_0024406_00241191 = _0024self__00241194.r.velocity);
					float num2 = (_0024_0024406_00241191.y = _0024_0024405_00241190);
					Vector3 vector3 = (_0024self__00241194.r.velocity = _0024_0024406_00241191);
					int num3 = (_0024_0024407_00241192 = 3);
					Vector3 vector4 = (_0024_0024408_00241193 = _0024self__00241194.r.velocity);
					float num4 = (_0024_0024408_00241193.x = _0024_0024407_00241192);
					Vector3 vector6 = (_0024self__00241194.r.velocity = _0024_0024408_00241193);
					result = (Yield(5, new WaitForEndOfFrame()) ? 1 : 0);
					break;
				}
				case 3:
				case 5:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ArcherScript _0024self__00241195;

		public _0024ATK_00241182(ArcherScript self_)
		{
			_0024self__00241195 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new _0024(_0024self__00241195);
		}
	}

	private RaycastHit hit;

	public GameObject arrowR;

	public GameObject arrowL;

	public AudioClip audioFire;

	public virtual IEnumerator Start()
	{
		return new _0024Start_00241155(this).GetEnumerator();
	}

	public virtual IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241159(this).GetEnumerator();
	}

	public virtual IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241175(this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator ATK()
	{
		return new _0024ATK_00241182(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
