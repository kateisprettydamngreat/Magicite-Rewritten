using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ShooterScript : MonoBehaviour
{
	[RPC]
	public virtual IEnumerator Attack()
	{
		while (true) {
			if (Network.isServer) {
				yield return new WaitForSeconds(UnityEngine.Random.Range(0, 5) * 0.5f);
				
				GetComponent<Animation>().Play("i");
				
				yield return new WaitForSeconds(UnityEngine.Random.Range(0, 4) * 0.5f);
				
				yield return new WaitForSeconds(1f);
				
				GetComponent<Animation>().Play("a");
				GetComponent<AudioSource>().PlayOneShot(a);
			
				yield return new WaitForSeconds(0.5f);
				
				Network.Instantiate(blade, transform.position, Quaternion.identity, 0);
			}
			else {
				yield return null;
			}
		}
	}

	public GameObject @base;

	public GameObject blade;

	public AudioClip a;

	private Transform t;

	public virtual void OnDestroy()
	{
		Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
	}

	public virtual void Awake()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		t = transform;
	}

	public virtual void Start()
	{
		StartCoroutine(Attack());
	}
}