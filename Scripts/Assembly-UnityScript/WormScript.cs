using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class WormScript : MonoBehaviour
{
	public IEnumerator Start() {
		HP = maxHP;
		drops = new int[3] { 7, 18, 0 };
		t = transform;
		StartCoroutine(Initialize());
		
		if (isHead) {
			int i = 0;
			mainHead.GetComponent<Animation>().Play();
			yield return new WaitForSeconds(0.1f);
			while(i < 7) {
				parts[i].GetComponent<Animation>().Play("wBody"); 
				i++;
				yield return new WaitForSeconds(0.1f);
			}
		}
	}

	public IEnumerator Initialize() {

		if(isHead) {
			GetComponent<NetworkView>().RPC("SetHead", RPCMode.All);
			speed = 10f;
			yield return new WaitForSeconds(0.2f);
			StartCoroutine(Attack());
		}

	}

	public IEnumerator Attack() {
		while(true) {
		if(player) {
			if(Network.isServer) {
			time = UnityEngine.Random.Range(8, 11);
			curVector = player.transform.position - transform.position;  
			attacking = true;
			
			yield return new WaitForSeconds(time);
			} 
			else {
			yield return new WaitForSeconds(time);
			}
			
			attacking = false;
		}

		yield return new WaitForSeconds(0.5f);
		}
	}

	[RPC]
	public IEnumerator TDN(int dmg) 
	{
		takingDamage = true;
		yield return new WaitForSeconds(0.2f);
		
		HP -= dmg;
		if(HP < 1) 
		{
			Die();
		}
		else 
		{
			takingDamage = false;
		}
	}

	[RPC]
	public IEnumerator TDN2(int dmg)
	{
		GameObject n2 = Instantiate(Resources.Load("TD"), t.position, Quaternion.identity) as GameObject;
		n2.SendMessage("SD", dmg);
		
		yield return new WaitForSeconds(0.2f);
		yield return new WaitForSeconds(0.2f);
		
		if(HP < 1)
		{
			Die();
		}
		else
		{
			takingDamage = false; 
		}
	}

	[RPC]
	public IEnumerator KnockbackCoroutine(bool left) {

		knocking = true;
		bool wasKinematic = false;

		if (GetComponent<Rigidbody>().isKinematic) {
			wasKinematic = true;
			GetComponent<Rigidbody>().isKinematic = false;
		}

		if (left) {
			GetComponent<Rigidbody>().velocity = new Vector3(-15, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
			GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, 10, GetComponent<Rigidbody>().velocity.z);
			yield return new WaitForEndOfFrame();
		}
		else {
			GetComponent<Rigidbody>().velocity = new Vector3(15, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
			GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, 10, GetComponent<Rigidbody>().velocity.z);
			yield return new WaitForEndOfFrame();
		}

		yield return new WaitForSeconds(0.5f);

		knocking = false;
		if (wasKinematic) {
			GetComponent<Rigidbody>().isKinematic = true;
		}

	}


	public bool isBase;

	public bool isHead;

	public GameObject head;

	public float speed;

	public float space;

	public float time;

	public GameObject mainHead;

	public Material leadHead;

	public GameObject[] parts;

	public GameObject[] parts2;

	private bool knocking;

	private Transform t;

	private bool moving;

	private GameObject player;

	private Vector3 curVector;

	private bool attacking;

	private Vector3 a;

	private Vector3 b;

	private int HP;

	private int maxHP;

	private int GOLD;

	public int[] drops;

	private bool takingDamage;

	public WormScript()
	{
		parts = new GameObject[5];
		parts2 = new GameObject[7];
		maxHP = 1;
		GOLD = 20;
		drops = new int[3];
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
		int num = default(int);
		if (!isBase)
		{
			return;
		}
		for (num = 0; num < parts2.Length; num++)
		{
			if ((bool)parts2[num])
			{
				parts2[num].SendMessage("SetPlayer", g);
			}
		}
		StartCoroutine_Auto(Attack());
	}

	[RPC]
	public virtual void SetHead()
	{
		mainHead.GetComponent<Renderer>().material = leadHead;
		mainHead.GetComponent<Animation>().Play("wHead");
	}

	public virtual void Update()
	{
		if (!head)
		{
			head = gameObject;
			isHead = true;
			StartCoroutine_Auto(Initialize());
		}
		if (isHead)
		{
			if ((bool)player && attacking && Network.isServer)
			{
				t.Translate(curVector.normalized * speed * Time.deltaTime);
			}
		}
		else if (Network.isServer)
		{
			if (!(Mathf.Abs(head.transform.position.x - t.position.x) <= space))
			{
				t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
			}
			if (!(Mathf.Abs(head.transform.position.y - t.position.y) <= space))
			{
				t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
			}
		}
	}

	public virtual void TD(int dmg)
	{
		if (!takingDamage)
		{
			GetComponent<NetworkView>().RPC("TDN", RPCMode.All, dmg);
			GetComponent<NetworkView>().RPC("TDN2", RPCMode.All, dmg);
		}
	}

	public virtual void Die()
	{
		GameObject gameObject = null;
		int num = default(int);
		Item item = null;
		for (num = 0; num < GOLD; num++)
		{
			Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
		}
		if (drops[0] > 0 && UnityEngine.Random.Range(0, 2) == 0)
		{
			int num2 = UnityEngine.Random.Range(1, 3);
			item = new Item(drops[0], 1, new int[6], 0f, null);
			for (num = 0; num < num2; num++)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetID", RPCMode.All, item.id);
				gameObject.GetComponent<NetworkView>().RPC("SetD", RPCMode.All, item.d);
				gameObject.GetComponent<NetworkView>().RPC("SetE", RPCMode.All, item.e);
			}
		}
		if (drops[1] > 0 && UnityEngine.Random.Range(0, 4) == 0)
		{
			int num3 = UnityEngine.Random.Range(1, 3);
			item = new Item(drops[1], 1, new int[6], 0f, null);
			for (num = 0; num < num3; num++)
			{
				gameObject = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
				gameObject.GetComponent<NetworkView>().RPC("SetID", RPCMode.All, item.id);
				gameObject.GetComponent<NetworkView>().RPC("SetD", RPCMode.All, item.d);
				gameObject.GetComponent<NetworkView>().RPC("SetE", RPCMode.All, item.e);
			}
		}
		if (Network.isServer)
		{
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
			Network.Destroy(GetComponent<NetworkView>().viewID);
		}
	}

	public virtual void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			c.SendMessage("TD", 18);
		}
	}

	public virtual void K(bool l)
	{
		GetComponent<NetworkView>().RPC("KN", RPCMode.All, l);
	}

	}