using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ShroomFire : MonoBehaviour
{
	[RPC]
	public IEnumerator Exile() 
	{
		if (!exiling) 
		{
			exiling = true;
			t.position = new Vector3(0f, 0f, -500f); 
			yield return new WaitForSeconds(4f);
			Network.Destroy(GetComponent<NetworkView>().viewID);
			Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
		}
	}


	public IEnumerator Start() {

		// Wait for 6 seconds
		yield return new WaitForSeconds(6f);
		
		// Check if this is the local player's instance
		if (GetComponent<NetworkView>().isMine) {
		
		// Start despawn sequence
		StartCoroutine(Exile()); 
		}
	}
	private Vector3 playerPos;

	private Rigidbody r;

	private Vector3 finalVec;

	private Transform t;

	private bool canShoot;

	private bool exiling;


	public virtual void Awake()
	{
		t = transform;
		r = GetComponent<Rigidbody>();
	}

	[RPC]
	public virtual void Set(Vector3 v)
	{
		playerPos = v;
		finalVec = Vector3.Normalize(playerPos - transform.position);
		canShoot = true;
	}


	public virtual void Update()
	{
		if (canShoot)
		{
			t.Translate(finalVec * 9f * Time.deltaTime);
		}
	}

	}