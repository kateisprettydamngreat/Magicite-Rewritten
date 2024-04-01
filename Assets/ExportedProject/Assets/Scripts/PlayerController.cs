using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class PlayerController : MonoBehaviour
{
    public virtual IEnumerator Start()
    {
        int b, h = 0;
        if (armor > 0)
        {
            b = armor;
        }
        else
        {
            b = MenuScript.pBody;
        }
        if (h != 0)
        {
            if (helm > 0)
            {
                h = helm;
            }
            else
            {
                h = MenuScript.pVariant;
            }
        }
        else
        {
            h = MenuScript.pVariant;
        }
        race = MenuScript.pRace;
        UpdateAppearance();

        while (true)
        {
            yield return new WaitForSeconds(60f);
            gameScript.DecreaseHunger();
        }
    }

    public virtual IEnumerator Leavee()
    {
        fade.fadeOut();
        GameScript.curBiome = GameScript.door[GameScript.curDoor];
        yield return new WaitForSeconds(0.2f);

        if (GameScript.isTown || GameScript.districtLevel == 21)
        {
            GameScript.isTown = false;
        }
        else
        {
            GameScript.isTown = true;
        }

        gameScript.SaveInventory();
        Application.LoadLevel(0);
    }

    public virtual IEnumerator Offledge()
    {
        offledge = true;
        yield return new WaitForSeconds(0.2f);

        if (Physics.Raycast(ray, out hit, 1.5f) && hit.transform.gameObject.layer == 11)
        {
            grounded = true;
            mode = 0;
            canDoubleJump = true;
        }
        else
        {
            mode = 2;
            grounded = false;
        }

        offledge = false;
    }

    public IEnumerator Dash(int direction)
    {
        AudioClip audioDash = null;
        GameScript gameScript = null;
        bool dashing = false;
        bool grounded = false;
        Rigidbody r = null;
        Transform t = null;

        if (gameScript.stamina < 1f)
        {
            Instantiate(Resources.Load("noSta"), t.position, Quaternion.identity);
            yield break;
        }
		GetComponent<AudioSource>().PlayOneShot(audioDash);
        dashing = true;
        gameScript.Stamina();
        gameScript.stamina -= 1f;
        gameScript.LoadSTA();
        GetComponent<NetworkView>().RPC("po", RPCMode.All, t.position);

        int dashSpeed = grounded ? 18 : 15;
        dashSpeed *= direction != 0 ? 1 : -1;

        r.velocity = new Vector3(dashSpeed, r.velocity.y, r.velocity.z);

        yield return new WaitForSeconds(0.3f);

        dashing = false;
    }

    [RPC]
    public IEnumerator ShieldN()
    {
        if (GetComponent<NetworkView>().isMine)
        {
            shieldObj.SetActive(true);
            yield return new WaitForSeconds(20f);
            PlayerTriggerScript.ShieldDEF -= 4;
            if (PlayerTriggerScript.ShieldDEF < 0)
            {
                PlayerTriggerScript.ShieldDEF = 0;
            }
            if (PlayerTriggerScript.ShieldDEF == 0)
            {
                shieldObj.SetActive(false);
            }
        }
	}

    [RPC]
    public IEnumerator FloatN()
	{
        if (GetComponent<NetworkView>().isMine)
        {
            particleFloat.SetActive(true);
            yield return new WaitForSeconds(10f);
            floatCounter--;
            if (floatCounter <= 0)
            {
                floatCounter = 0;
                particleFloat.SetActive(false);
                GetComponent<Rigidbody>().useGravity = true;
                GameScript.isFloating = false;
            }
        }
	}

	[RPC]
	public IEnumerator ChargeN()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			particleCharge.SetActive(true);
			yield return new WaitForSeconds(10f);
			chargeBoost = Mathf.Max(0, chargeBoost - 4);
			if (chargeBoost == 0)
			{
				particleCharge.SetActive(false);
			}
		}
	}

	[RPC]
	public IEnumerator mWeaponsN(int a)
	{
		if (GetComponent<NetworkView>().isMine)
		{
			mWeapon.SetActive(true);
			yield return new WaitForSeconds(20f);
			mBonus -= a;
			if (mBonus < 0)
			{
				mBonus = 0;
			}
			if (mBonus == 0)
			{
				mWeapon.SetActive(false);
			}
		}
	}
    public IEnumerator Jump()
    {
        djA = true;
        GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/JUMP", typeof(AudioClip)));
        canBoost = true;
        grounded = false;

        if (!GameScript.isFloating)
        {
            r.velocity = new Vector3(r.velocity.x, 24, r.velocity.z);
        }
        else
        {
            r.velocity = new Vector3(r.velocity.x, 12, r.velocity.z);
        }

        yield return new WaitForSeconds(1f);

        canBoost = false;
    }
    public IEnumerator DoubleJump()
    {
        if (gameScript.stamina >= 1f)
        {
            djA = false;
            GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
            canBoost = false;
            canBoost2 = true;
            gameScript.Stamina();
            gameScript.stamina -= 1f;
            gameScript.LoadSTA();
            GetComponent<NetworkView>().RPC("po", RPCMode.All, t.position);
            canDoubleJump = false;

            if (!GameScript.isFloating)
            {
                r.velocity = new Vector3(r.velocity.x, 26, r.velocity.z);
            }
            else
            {
                r.velocity = new Vector3(r.velocity.x, 12, r.velocity.z);
            }

            yield return new WaitForSeconds(1f);
            canBoost2 = false;
        }
        else
        {
            Instantiate(Resources.Load("noSta"), t.position, Quaternion.identity);
        }
    }
	public PlayerController()
	{
		txtName = new TextMesh[2];
		mask = 2048;
		m = 2048;
		rays = new Ray[4];
		gravity = 10f;
	}

	[RPC]
	public virtual void Boss()
	{
		isBoss = true;
	}

	public virtual void Awake()
	{
		isBoss = false;
		PlayerTriggerScript.isDead = false;
		fade = (FadeInOut)Camera.main.gameObject.GetComponent("FadeInOut");
		aCube = attackCube;
		lUp = levelUpObj;
		t = transform;
		r = GetComponent<Rigidbody>();
		gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
		trigger = (PlayerTriggerScript)transform.Find("p").GetComponent("PlayerTriggerScript");
		GetComponent<Collider>().material.dynamicFriction = 0f;
		GameScript.facingLeft = true;
		@base.GetComponent<Animation>()["i"].layer = 1;
		@base.GetComponent<Animation>()["i"].speed = 2f;
		@base.GetComponent<Animation>()["r"].layer = 1;
		@base.GetComponent<Animation>()["a1"].layer = 2;
		@base.GetComponent<Animation>()["a2"].layer = 2;
		@base.GetComponent<Animation>()["a3"].layer = 2;
		@base.GetComponent<Animation>()["j"].layer = 1;
		@base.GetComponent<Animation>()["dj"].layer = 1;
		@base.GetComponent<Animation>()["a2"].speed = 1.5f;
		@base.GetComponent<Animation>()["a3"].speed = 2f;
		@base.GetComponent<Animation>()["a4"].layer = 2;
		@base.GetComponent<Animation>()["dead"].layer = 1;
		@base.GetComponent<Animation>()["a4"].speed = 2f;
	}

	public virtual void Clair(int a)
	{
		if (a == 1)
		{
			particleClair.SetActive(value: true);
		}
		else
		{
			particleClair.SetActive(value: false);
		}
	}

	public virtual void Rage(int a)
	{
		if (a == 1)
		{
			particleRage.SetActive(value: true);
		}
		else
		{
			particleRage.SetActive(value: false);
		}
	}


	public virtual void Update()
	{
		r1U.origin = transform.position;
		float y = r1U.origin.y + 0.6f;
		Vector3 origin = r1U.origin;
		float num = (origin.y = y);
		Vector3 vector2 = (r1U.origin = origin);
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		float y2 = r2U.origin.y + 0.6f;
		Vector3 origin2 = r2U.origin;
		float num2 = (origin2.y = y2);
		Vector3 vector4 = (r2U.origin = origin2);
		r2U.direction = Vector3.right;
		r1D.origin = transform.position;
		float y3 = r1D.origin.y - 0.7f;
		Vector3 origin3 = r1D.origin;
		float num3 = (origin3.y = y3);
		Vector3 vector6 = (r1D.origin = origin3);
		r1D.direction = Vector3.left;
		r2D.origin = transform.position;
		float y4 = r2D.origin.y - 0.7f;
		Vector3 origin4 = r2D.origin;
		float num4 = (origin4.y = y4);
		Vector3 vector8 = (r2D.origin = origin4);
		r2D.direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.2f, mask) || Physics.Raycast(r1D, 1.2f, mask))
		{
			cantLeft = true;
		}
		else
		{
			cantLeft = false;
		}
		if (Physics.Raycast(r2U, 1.2f, mask) || Physics.Raycast(r2D, 1.2f, mask))
		{
			cantRight = true;
		}
		else
		{
			cantRight = false;
		}
		if (!(r.velocity.y >= -25f))
		{
			int num5 = -25;
			Vector3 velocity = r.velocity;
			float num6 = (velocity.y = num5);
			Vector3 vector10 = (r.velocity = velocity);
		}
		if (!GameScript.takingDamage)
		{
			if (!(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= t.position.x + 0.1f))
			{
				if (GameScript.facingLeft)
				{
					GameScript.facingLeft = false;
					p.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
				}
			}
			else if (!(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x >= t.position.x - 0.1f) && !GameScript.facingLeft)
			{
				GameScript.facingLeft = true;
				p.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			ray = new Ray(t.position, new Vector3(0f, -1f, 0f));
			if (Physics.Raycast(ray, out hit, 1.5f))
			{
				if (hit.transform.gameObject.layer == 11)
				{
					grounded = true;
					mode = 0;
					canDoubleJump = true;
				}
				else
				{
					mode = 2;
					StartCoroutine(Offledge());
				}
			}
			else
			{
				mode = 2;
				StartCoroutine(Offledge());
			}
			if (UnityEngine.Input.GetKey(KeyCode.A) && !cantLeft && !dashing)
			{
				if (grounded)
				{
					mode = 1;
				}
				else
				{
					mode = 2;
				}
				float x = 0f - GameScript.SPD - (float)chargeBoost;
				Vector3 velocity2 = r.velocity;
				float num7 = (velocity2.x = x);
				Vector3 vector12 = (r.velocity = velocity2);
			}
			if (UnityEngine.Input.GetKeyDown(KeyCode.Q))
			{
				mode = 2;
				MonoBehaviour.print("asdddf");
				StartCoroutine(Dash(0));
			}
			else if (UnityEngine.Input.GetKeyDown(KeyCode.E))
			{
				mode = 2;
				StartCoroutine(Dash(1));
			}
			if (UnityEngine.Input.GetKey(KeyCode.D) && !cantRight && !dashing)
			{
				if (grounded)
				{
					mode = 1;
				}
				else
				{
					mode = 2;
				}
				float x2 = GameScript.SPD + (float)chargeBoost;
				Vector3 velocity3 = r.velocity;
				float num8 = (velocity3.x = x2);
				Vector3 vector14 = (r.velocity = velocity3);
			}
			if (UnityEngine.Input.GetKeyDown(KeyCode.S) && GameScript.isFloating)
			{
				int num9 = -10;
				Vector3 velocity4 = r.velocity;
				float num10 = (velocity4.y = num9);
				Vector3 vector16 = (r.velocity = velocity4);
			}
			if (UnityEngine.Input.GetKeyDown(KeyCode.W) && GameScript.isFloating)
			{
				int num11 = 10;
				Vector3 velocity5 = r.velocity;
				float num12 = (velocity5.y = num11);
				Vector3 vector18 = (r.velocity = velocity5);
			}
			if (UnityEngine.Input.GetKeyUp(KeyCode.A))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num13 = 0;
				Vector3 velocity6 = r.velocity;
				float num14 = (velocity6.x = num13);
				Vector3 vector20 = (r.velocity = velocity6);
			}
			else if (UnityEngine.Input.GetKeyUp(KeyCode.D))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num15 = 0;
				Vector3 velocity7 = r.velocity;
				float num16 = (velocity7.x = num15);
				Vector3 vector22 = (r.velocity = velocity7);
			}
			if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
			{
				if (grounded)
				{
					StartCoroutine(Jump());
				}
				else if (canDoubleJump)
				{
					StartCoroutine(DoubleJump());
				}
			}
			if (UnityEngine.Input.GetKey(KeyCode.Space) && !dashing)
			{
				if (canBoost)
				{
					float y5 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity8 = r.velocity;
					float num17 = (velocity8.y = y5);
					Vector3 vector24 = (r.velocity = velocity8);
				}
				else if (canBoost2)
				{
					float y6 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity9 = r.velocity;
					float num18 = (velocity9.y = y6);
					Vector3 vector26 = (r.velocity = velocity9);
				}
			}
			if (UnityEngine.Input.GetKeyDown(KeyCode.W))
			{
				if (trigger.canLeave)
				{
					StartCoroutine(Leavee());
				}
				if (GameScript.canInteract && !GameScript.interacting)
				{
					gameScript.Interact();
				}
				if (GameScript.isShopping && PlayerTriggerScript.itemPurchasing != 0)
				{
					gameScript.Purchase(PlayerTriggerScript.itemPurchasing);
				}
			}
		}
		if (GameScript.HP <= 0)
		{
			MonoBehaviour.print("ISDEADD");
			mode = 99;
		}
		if (mode == 0)
		{
			@base.GetComponent<Animation>().Play("i");
			jA = false;
		}
		else if (mode == 1)
		{
			@base.GetComponent<Animation>().Play("r");
			jA = false;
		}
		else if (mode == 2)
		{
			if (!jA)
			{
				@base.GetComponent<Animation>().Play("j");
				jA = true;
			}
			if (!djA)
			{
				@base.GetComponent<Animation>().Play("dj");
				djA = true;
			}
		}
		else if (mode == 3)
		{
			@base.GetComponent<Animation>().Play("a1");
			jA = false;
		}
		else if (mode == 99)
		{
			@base.GetComponent<Animation>().Play("dead");
		}
		else
		{
			jA = false;
		}
		if (dashing)
		{
			@base.GetComponent<Animation>().Play("j");
		}
	}

	public virtual void Shield()
	{
		PlayerTriggerScript.ShieldDEF += 4;
		GetComponent<NetworkView>().RPC("ShieldN", RPCMode.All);
	}

	public virtual void Float()
	{
		floatCounter++;
		GetComponent<Rigidbody>().useGravity = false;
		int num = 10;
		Vector3 velocity = GetComponent<Rigidbody>().velocity;
		float num2 = (velocity.y = num);
		Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		GameScript.isFloating = true;
		GetComponent<NetworkView>().RPC("FloatN", RPCMode.All);
	}

	public virtual void Roar(int a)
	{
		if (a == 1)
		{
			particleRoar.SetActive(value: true);
		}
		else
		{
			particleRoar.SetActive(value: false);
		}
	}


	public virtual void Charge()
	{
		chargeBoost += 4;
		GetComponent<NetworkView>().RPC("ChargeN", RPCMode.All);
	}

	public virtual void mWeapons(int a)
	{
		mBonus += a;
		GetComponent<NetworkView>().RPC("mWeaponsN", RPCMode.All, a);
	}


	public virtual void UpdateHead(int hh)
	{
		h = hh;
		UpdateAppearance();
	}

	public virtual void UpdateBody(int bb)
	{
		b = bb;
		UpdateAppearance();
	}

	public virtual void UpdateOffhand(int oo)
	{
		o = oo;
		UpdateAppearance();
	}

	public virtual void OnLevelWasLoaded(int level)
	{
		gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
		GameScript.cLevel = PlayerPrefs.GetInt("cLevel");
		GameObject gameObject = null;
	}

	public virtual void TD(int dmg)
	{
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			StartCoroutine(trigger.TD(dmg));
		}
	}

	public virtual void Initialize()
	{
	}

	public virtual void UpdateAppearance()
	{
		head.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race, typeof(Material));
		if (helm == 0)
		{
			head2.GetComponent<Renderer>().material = (Material)Resources.Load("h/h" + (h + (MenuScript.pColor - 1) * 14), typeof(Material));
		}
		else
		{
			head2.GetComponent<Renderer>().material = (Material)Resources.Load("h/h" + h, typeof(Material));
		}
		body.GetComponent<Renderer>().material = (Material)Resources.Load("b/b" + b, typeof(Material));
		arm1.GetComponent<Renderer>().material = (Material)Resources.Load("a/a" + b, typeof(Material));
		arm2.GetComponent<Renderer>().material = (Material)Resources.Load("a/a" + b, typeof(Material));
		leg.GetComponent<Renderer>().material = (Material)Resources.Load("l/l" + b, typeof(Material));
		offHand.GetComponent<Renderer>().material = (Material)Resources.Load("o/o" + o, typeof(Material));
	}

	[RPC]
	public virtual void po(Vector3 pos)
	{
		UnityEngine.Object.Instantiate(pop, pos, Quaternion.Euler(0f, 180f, 180f));
	}

	public virtual void K(bool a)
	{
	}

	public virtual void TDp()
	{
		float num = (float)GameScript.MAXHP * 0.2f;
		int dMG = (int)num;
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			StartCoroutine(trigger.TD(dMG));
		}
	}

	public GameObject blood;
	public GameObject particleRoar;
	public GameObject particleFloat;
	[NonSerialized] public static int mBonus;
	private int floatCounter;
	public GameObject mWeapon;
	public GameObject shieldObj;
	public GameObject particleClair;
	private int chargeBoost;
	public GameObject particleCharge;
	public GameObject particleRage;
	[NonSerialized] public static bool isBoss;
	[NonSerialized] public static int mode;
	[NonSerialized] public static int interact;
	[NonSerialized] public static bool facingRight;
	[NonSerialized] public static GameObject aCube;
	[NonSerialized] public static GameObject lUp;
	[NonSerialized] public static int b;
	[NonSerialized] public static int h;
	[NonSerialized] public static int race;
	[NonSerialized] public static int o;
	[NonSerialized] public static int helm;
	[NonSerialized] public static int armor;
	[NonSerialized] public static int offhand;
	private bool charging;
	private bool offledge;
	public AudioClip themeCave;
	public AudioClip themeTown;
	public GameObject levelUpObj;
	public GameObject attackCube;
	public GameObject pop;
	public GameObject @base;
	public GameObject p;
	public GameObject head;
	public GameObject head2;
	public GameObject body;
	public GameObject arm1;
	public GameObject arm2;
	public GameObject leg;
	public GameObject weapon;
	public GameObject offHand;
	public TextMesh[] txtName;
	public AudioClip audioDash;
	public bool attacking;
	public bool cantMove;
	public bool running;
	private bool moving;
	private int cc;
	private bool jA;
	private bool djA;
	private GameScript gameScript;
	private bool canMove;
	private Vector3 newPos;
	private Vector3 newPos2;
	private Ray ray;
	private RaycastHit hit;
	private int mask;
	private LayerMask m;
	private bool dead;
	private PlayerTriggerScript trigger;
	private bool dashing;
	private int jumping;
	private Ray[] rays;
	private float gravity;
	private bool grounded;
	private Transform t;
	private Rigidbody r;
	private FadeInOut fade;
	private bool canDoubleJump;
	private bool canBoost;
	private bool canBoost2;
	private Ray r1U;
	private Ray r2U;
	private Ray r1D;
	private Ray r2D;
	private bool cantLeft;
	private bool cantRight;
	private int itemPurchasing;

	}