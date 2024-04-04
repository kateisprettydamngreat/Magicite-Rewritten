using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class Whelp : EnemyScript
{
    public virtual IEnumerator Attack(Vector3 pp)
    {
        ATKING = true;
        if (!(pp.x <= transform.position.x))
        {
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 1);
        }
        else
        {
            GetComponent<NetworkView>().RPC("Turn", RPCMode.All, 0);
        }

        yield return new WaitForSeconds(0.3f);

        GetComponent<NetworkView>().RPC("A1", RPCMode.All);

        yield return new WaitForSeconds(0.7f);

        if (player)
        {
            Vector3 pp2 = player.transform.position;
            if (Network.isServer)
            {
                GameObject g = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), transform.position, Quaternion.identity, 0);
                g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, pp2);
                pp2.y += 10f;
                g = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), transform.position, Quaternion.identity, 0);
                g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, pp2);
                pp2.y -= 20f;
                g = (GameObject)Network.Instantiate(Resources.Load("haz/whelpFire"), transform.position, Quaternion.identity, 0);
            }
            // g.GetComponent<NetworkView>().RPC("Set", RPCMode.All, pp2); TODO:  DONT
        }
        if (player)
        {
            curVector = t.position - player.transform.position;
            if (!(player.transform.position.x <= t.position.x))
            {
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else
            {
                e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
        }
        atking = true;

        yield return new WaitForSeconds(0.5f);

        atking = false;
        if (player)
        {
            int num = UnityEngine.Random.Range(0, 3);
            if (num == 0)
            {
                curVector = t.position - player.transform.position;
            }
            else
            {
                curVector = player.transform.position - t.position;
            }
            if (!(player.transform.position.x <= t.position.x))
            {
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else
            {
                e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            atking = true;

            yield return new WaitForSeconds(2f);
        }

        atking = false;

        yield return new WaitForSeconds(1.5f);

        ATKING = false;
    }

	public AudioClip roar;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private RaycastHit hit;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private int mask;

	private int spd;

	private bool turning;

	private int mask2;

	private bool ATKING;

	private GameObject player;

	private bool atking;

	public Whelp()
	{
		speed = 10f;
		mask = 256;
		mask2 = 2048;
	}

	public virtual void Start()
	{
		@base.GetComponent<Animation>()["i"].layer = 0;
		@base.GetComponent<Animation>()["a"].layer = 1;
		int[] array = new int[3] { 7, 15, 20 };
		SetStats(150, 6, 2, 10, 2f, array, UnityEngine.Random.Range(10, 25), 10);
		float y = transform.position.y + (float)UnityEngine.Random.Range(3, 10);
		Vector3 position = transform.position;
		float num = (position.y = y);
		Vector3 vector2 = (transform.position = position);
	}

	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		if ((bool)player && Network.isServer)
		{
			if (!(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !ATKING)
			{
				StartCoroutine(Attack(player.transform.position));
			}
			else if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 25f) && !knocking && r.isKinematic)
			{
				t.Translate(curVector.normalized * 9f * Time.deltaTime);
			}
		}
	}

	[RPC]
	public virtual void A1()
	{
		@base.GetComponent<Animation>().Play("a");
		GetComponent<AudioSource>().PlayOneShot(roar);
	}

	[RPC]
	public virtual void Turn(int dir)
	{
		if (dir == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion quaternion2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion quaternion4 = (e.transform.rotation = rotation2);
		}
	}
}