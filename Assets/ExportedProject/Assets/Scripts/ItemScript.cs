using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ItemScript : MonoBehaviour
{
	public IEnumerator Exile() 
	{
		if (!exiling) {
			exiling = true;
			t.position = new Vector3(0f, 0f, -500f); 
			yield return new WaitForSeconds(4f);
			
			if (Network.isServer) {
				Network.Destroy(GetComponent<NetworkView>().viewID);
				Network.RemoveRPCs(GetComponent<NetworkView>().viewID); 
			}
		}
	}
    public IEnumerator Start()
    {
        int result;
        if (!dropped && (isLocal || Network.isServer))
        {
            r.AddForce(new Vector3(UnityEngine.Random.Range(-1, 2), 1f, 0f) * 200f);
            int num = UnityEngine.Random.Range(5, 9);
            Vector3 vector = r.velocity;
            float num2 = vector.y = num;
            r.velocity = vector;
        }

        yield return new WaitForSeconds(0.3f);

        @base.GetComponent<Collider>().enabled = true;
        can = true;

        yield return new WaitForSeconds(30f);

        if (!isLocal)
        {
            StartCoroutine(Exile());
        }
        else
        {
            UnityEngine.Object.Destroy(gameObject);
        }
    }


	public bool dropped;

	public bool isLocal;

	public GameObject @base;

	private Rigidbody r;

	private bool dying;

	private int d;

	private int[] e;

	private int id;

	private int mask;

	private Ray ray;

	private RaycastHit hit;

	private Transform t;

	private bool can;

	private int q;

	private bool exiling;

	public ItemScript()
	{
		e = new int[6];
		mask = 256;
	}

	public virtual void Awake()
	{
		t = transform;
		@base.GetComponent<Collider>().enabled = false;
		r = GetComponent<Rigidbody>();
	}


	[RPC]
	public virtual void DR()
	{
		dropped = true;
	}


	public virtual void Update()
	{
		if (can && !dropped)
		{
			ray = new Ray(t.position, new Vector3(-1f, 0f, 0f));
			if (Physics.Raycast(ray, out hit, 3f, mask) && hit.transform.gameObject.GetComponent<NetworkView>().isMine)
			{
				int num = -7;
				Vector3 velocity = r.velocity;
				float num2 = (velocity.x = num);
				Vector3 vector2 = (r.velocity = velocity);
			}
			ray = new Ray(t.position, new Vector3(1f, 0f, 0f));
			if (Physics.Raycast(ray, out hit, 3f, mask) && hit.transform.gameObject.GetComponent<NetworkView>().isMine)
			{
				int num3 = 7;
				Vector3 velocity2 = r.velocity;
				float num4 = (velocity2.x = num3);
				Vector3 vector4 = (r.velocity = velocity2);
			}
		}
	}

	[RPC]
	public virtual void InitL(int[] stats)
	{
		Item item = new Item(stats[0], stats[1], new int[4]
		{
			stats[2],
			stats[3],
			stats[4],
			stats[5]
		}, stats[6], null);
		id = item.id;
		q = item.q;
		e = item.e;
		d = item.d;
		@base.GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + item.id);
		@base.name = string.Empty + item.id;
		gameObject.name = string.Empty + item.id;
		d = item.d;
		e = item.e;
	}

	public virtual void Set(Item item)
	{
		GetComponent<NetworkView>().RPC("SetID", RPCMode.All, item.id);
		GetComponent<NetworkView>().RPC("SetD", RPCMode.All, item.d);
		GetComponent<NetworkView>().RPC("SetE", RPCMode.All, item.e);
		GetComponent<NetworkView>().RPC("SetQ", RPCMode.All, item.q);
	}

	public virtual void Hit(GameObject player)
	{
		Item value = new Item(int.Parse(gameObject.name), q, e, d, gameObject);
		if (isLocal)
		{
			player.SendMessage("AddItemL", value);
		}
		else
		{
			player.SendMessage("AddItem", value);
		}
	}

	[RPC]
	public virtual void SetN(Item item)
	{
		@base.GetComponent<Renderer>().material = (Material)Resources.Load("i/i" + item.id);
		@base.name = string.Empty + item.id;
		gameObject.name = string.Empty + item.id;
		d = item.d;
		e = item.e;
	}

	}