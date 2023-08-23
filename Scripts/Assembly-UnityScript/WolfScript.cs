using System;
using System.Collections;
using UnityEngine;
//Untested, but compiles! Not 100% sure it is correct though...
[Serializable]
public class WolfScript : MonoBehaviour
{
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
    private bool exiling;

    public void Awake()
    {
        r = GetComponent<Rigidbody>();
        t = transform;
        @base.GetComponent<Animation>()["i"].layer = 1;
        @base.GetComponent<Animation>()["a"].layer = 1;
        int num = 15;
        Vector3 velocity = r.velocity;
        velocity.y = (float)num;
        r.velocity = velocity;
        Hit();
        StartCoroutine(Die());
    }

    public IEnumerator Exile()
    {
        exiling = true;
        newPos = transform.position + Vector3.up * 50f;
        yield return new WaitForSeconds(3f);
        transform.position = newPos;
        exiling = false;
    }

	public IEnumerator Die()
	{
		if (GetComponent<NetworkView>().isMine)
		{
			StartCoroutine(Exile());
			yield return new WaitForSeconds(3f);
			Network.Destroy(this.GetComponent<NetworkView>().viewID);
			Network.RemoveRPCs(this.GetComponent<NetworkView>().viewID);
		}
		else
		{
			yield return null;
		}
	}

    public void Update()
    {
        if (t.rotation.y == 0f)
        {
            left = true;
        }
        else
        {
            left = false;
        }

        int num;
        if (left)
        {
            num = 13;
        }
        else
        {
            num = -13;
        }

        Vector3 velocity = GetComponent<Rigidbody>().velocity;
        velocity.x = (float)num;
        GetComponent<Rigidbody>().velocity = velocity;
    }

    public IEnumerator HitN()
    {
        yield return new WaitForSeconds(1f);
        HP -= 5;
        if (HP <= 0)
        {
            if (GetComponent<NetworkView>().isMine)
            {
                StartCoroutine(Exile());
            }
            yield return new WaitForSeconds(3f);
            Destroy(gameObject);
        }
    }

    public void Hit()
    {
        if (GetComponent<NetworkView>().isMine)
        {
            StartCoroutine(HitN());
        }
    }

    // Token: 0x06000B1C RID: 2844 RVA: 0x000517D0 File Offset: 0x0004F9D0
    public void Main()
    {
    }
}
