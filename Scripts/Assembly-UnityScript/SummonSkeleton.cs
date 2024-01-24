using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SummonSkeleton : MonoBehaviour
{
    public IEnumerator Exile()
    {
        exiling = true;
        transform.position = new Vector3(0f, 0f, -500f);
        yield return new WaitForSeconds(4f);

        var networkView = GetComponent<NetworkView>();
        if (networkView)
        {
            Network.Destroy(networkView.viewID);
            Network.RemoveRPCs(networkView.viewID);
        }

        exiling = false;
    }
    public IEnumerator Die()
    {
        yield return new WaitForSeconds(this.waitt);
        if (GetComponent<NetworkView>().isMine)
        {
            StartCoroutine(Exile());
        }
    }
	public IEnumerator HitN()
		{
			if (GetComponent<NetworkView>().isMine)
			{
				// Perform raycast checks and send messages
				CheckAndSendMessage(new Vector3(1f, 0f, 0f));
				CheckAndSendMessage(new Vector3(-1f, 0f, 0f));
				
				// Rotate based on raycast hits
				RotateOnRaycastHit(new Vector3(1f, 0f, 0f));
				RotateOnRaycastHit(new Vector3(-1f, 0f, 0f));
				
				// Wait for 0.4 seconds
				yield return new WaitForSeconds(0.4f);
			}
		}

		private void CheckAndSendMessage(Vector3 direction)
		{
			Ray ray = new Ray(transform.position, direction);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 3f, 512) && (hit.transform.gameObject.layer == 9 || hit.transform.gameObject.layer == 12))
			{
				hit.transform.gameObject.SendMessage("TD", DOOD);
			}
		}

		private void RotateOnRaycastHit(Vector3 direction)
		{
			Ray ray = new Ray(transform.position, direction);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 3f, 2048))
			{
				if (transform.rotation.y <= 0f)
				{
					transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 180, transform.rotation.eulerAngles.z);
				}
				else
				{
					transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, transform.rotation.eulerAngles.z);
				}
			}
		}

	public bool isZombie;

	public GameObject @base;

	public GameObject e;

	private Ray ray;

	private RaycastHit hit;

	private Transform t;

	private Rigidbody r;

	private int HP;

	private int ATK;

	private int DEX;

	private bool left;

	private Vector3 newPos;

	private int waitt;

	private int DOOD;

	private bool exiling;

	public SummonSkeleton()
	{
		HP = 20;
		waitt = 16;
		DOOD = 1;
	}

	public virtual void Set(int dex)
	{
		DEX = dex;
		waitt = (int)((float)waitt + (float)DEX * 0.7f);
		ATK = (int)((float)DEX * 0.5f);
	}

	[RPC]
	public virtual void SetN(int dex)
	{
		DEX = dex;
		waitt = (int)((float)waitt + (float)DEX * 0.7f);
		ATK = (int)((float)DEX * 0.5f);
	}

	public virtual void Awake()
	{
		if (isZombie)
		{
			DOOD = 5;
		}
		r = GetComponent<Rigidbody>();
		t = transform;
		@base.GetComponent<Animation>()["a"].layer = 1;
		int num = 15;
		Vector3 velocity = r.velocity;
		float num2 = (velocity.y = num);
		Vector3 vector2 = (r.velocity = velocity);
		Hit();
		StartCoroutine_Auto(Die());
	}

	public virtual void Update()
	{
		newPos = new Vector3(t.position.x, t.position.y - 1f, 0f);
		if (t.rotation.y == 0f)
		{
			left = true;
		}
		else
		{
			left = false;
		}
		if (left)
		{
			int num = 8;
			Vector3 velocity = GetComponent<Rigidbody>().velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		}
		else
		{
			int num3 = -8;
			Vector3 velocity2 = GetComponent<Rigidbody>().velocity;
			float num4 = (velocity2.x = num3);
			Vector3 vector4 = (GetComponent<Rigidbody>().velocity = velocity2);
		}
	}

	public virtual void Hit()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			StartCoroutine_Auto(HitN());
		}
	}

	}