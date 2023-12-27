using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DmgScript : MonoBehaviour
{

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

    public virtual IEnumerator Start()
    {
        t = transform;
        if (isAltar)
        {
            wait = 3.5f;
        }
        else
        {
            wait = 1f;
        }

        yield return new WaitForSeconds(0.15f);

        stop = true;

        if (type == 0)
        {
            yield return new WaitForSeconds(wait);
        }
        else if (type == 3)
        {
            Destroy(gameObject, wait);
        }
        else
        {
            Destroy(gameObject, wait);
        }
    }

    public virtual void Update()
    {
        if (!stop)
        {
            float y = t.position.y + num * Time.deltaTime;
            t.position = new Vector3(t.position.x, y, t.position.z);
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
        txtDmg.text = a;
        txtDmg2.text = a;
    }

    public virtual void SDS(string a)
    {
        txtDmg.text = a;
        txtDmg2.text = a;
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
			txtDmg.text = a.ToString();
			txtDmg2.text = a.ToString();
		}
		txtDmg2.text = txtDmg2.text;
	}

    [RPC]
    public virtual void Initialize(NetworkViewID id)
    {
        GetComponent<NetworkView>().viewID = id;
    }

}
