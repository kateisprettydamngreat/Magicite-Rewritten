using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class DmgScript : MonoBehaviour
{
	public IEnumerator Start() 
	{
		yield return new WaitForSeconds(0.15f);
		
		transform.position = new Vector3(transform.position.x, transform.position.y, -10f);

		if (type == 0) {
			yield return new WaitForSeconds(wait);
		}
		else if (type == 3) {
			Destroy(gameObject, wait);
		}
		else {
			Destroy(gameObject, wait); 
		}

		Destroy(gameObject);
	}

	public int type;

	public TextMesh txtDmg;

	public TextMesh txtDmg2;

	private Transform t;

	private float num;

	private bool stop;

	public bool isAltar;

	private float wait;

	public DmgScript()
	{
		num = 10f;
	}

	public virtual void Awake()
	{
	}


    public virtual void Update()
    {
        if (t != null && !stop)
        {
            float y = t.position.y + this.num * Time.deltaTime;
            Vector3 position = t.position;
            float num = (position.y = y);
            Vector3 vector2 = (t.position = position);
        }
    }


	public virtual void SD(int a)
	{
		if (type == 1)
		{
			txtDmg.text = "+" + a + " HP";
		}
		else if (type == 2)
		{
			txtDmg.text = "+" + a + " Mana";
		}
		else if (type == 3)
		{
			txtDmg.text = "+" + a;
			txtDmg2.text = "+" + a;
		}
		txtDmg2.text = txtDmg.text;
	}

	[RPC]
	public virtual void SDSN(string a)
	{
		txtDmg.text = string.Empty + a;
		txtDmg2.text = string.Empty + a;
	}

	public virtual void SDS(string a)
	{
		txtDmg.text = string.Empty + a;
		txtDmg2.text = string.Empty + a;
	}

	public virtual void SDN(int a)
	{
		if (type == 1)
		{
			txtDmg.text = "+" + a + " HP";
		}
		else if (type == 2)
		{
			txtDmg.text = "+" + a + " Mana";
		}
		else
		{
			txtDmg.text = string.Empty + a;
			txtDmg2.text = string.Empty + a;
		}
		txtDmg2.text = txtDmg2.text;
	}

	[RPC]
	public virtual void Initialize(NetworkViewID id)
	{
		GetComponent<NetworkView>().viewID = id;
	}

	}