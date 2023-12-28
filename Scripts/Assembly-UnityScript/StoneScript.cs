using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class StoneScript : MonoBehaviour
{
	[RPC]
	public IEnumerator Exile() 
	{
		if (!exiling) {
			exiling = true;
			
			transform.position = new Vector3(0f, 0f, -500f);
			
			yield return new WaitForSeconds(4f);
			
			NetworkView view = GetComponent<NetworkView>();
			Network.Destroy(view.viewID);
			Network.RemoveRPCs(view.viewID);
		}
	}


	public bool isPoison;

	public bool isLeft;

	private Vector3 vec;

	private bool exiling;

	public virtual void Set(Vector3 p)
	{
		Vector3 vector = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition) - p;
		vec = vector / vector.magnitude;
	}

	public virtual void Start()
	{
		GetComponent<Rigidbody>().AddForce(vec * 2900f);
	}

	public virtual void OnCollisionEnter(Collision c)
	{
		if (isPoison && (c.gameObject.layer == 9 || c.gameObject.layer == 12 || c.gameObject.layer == 11) && GetComponent<NetworkView>().isMine)
		{
			Network.Instantiate(Resources.Load("haz/poison"), transform.position, Quaternion.identity, 0);
			StartCoroutine_Auto(Exile());
		}
	}


	}