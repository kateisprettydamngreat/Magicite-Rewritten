using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ScourgeWall : MonoBehaviour
{
    public IEnumerator ShootStuff()
    {
        while (true)
        {
            if (Network.isServer)
            {
                yield return new WaitForSeconds(UnityEngine.Random.Range(4, 7));
            }
            else
            {
                yield return null;
            }

            GetComponent<NetworkView>().RPC("SHOOT", RPCMode.All);
            yield return new WaitForSeconds(0.7f);

            for (int i = 0; i < 5; i++)
            {
                if (!ded)
                {
                    Network.Instantiate(ball1, headPoint.transform.position, Quaternion.identity, 0);
                    Network.Instantiate(ball2, headPoint.transform.position, Quaternion.identity, 0);
                }
                yield return new WaitForSeconds(0.3f);
            }
        }
    }
    IEnumerator DeathAnim()
    {
        GameObject musicBox = GameObject.Find("musicBox");
        musicBox.SendMessage("Victory");
        ded = true;
        deathParticle.SetActive(true);
        white.SetActive(true);
        GetComponent<AudioSource>().PlayOneShot(scourgeded);
        yield return new WaitForSeconds(0.1f);

        white.SetActive(false);
        yield return new WaitForSeconds(0.5f);

        GetComponent<AudioSource>().PlayOneShot(scourgeded);
        white.SetActive(true);
        yield return new WaitForSeconds(0.1f);

        white.SetActive(false);
        yield return new WaitForSeconds(0.2f);

        if (Network.isServer)
        {
            spd = 8f;
        }
        GetComponent<AudioSource>().PlayOneShot(scourgeded);
        white.SetActive(true);
        yield return new WaitForSeconds(0.1f);

        white.SetActive(false);
    }

	public AudioClip scourgeded;

	public GameObject white;

	public GameObject deathParticle;

	public GameObject ball1;

	public GameObject ball2;

	private Transform t;

	private GameObject player;

	private int hp;

	public GameObject e;

	public GameObject mainHead;

	public GameObject headPoint;

	private float spd;

	private bool ded;

	public ScourgeWall()
	{
		hp = 4500;
		spd = -1.5f;
	}

	public virtual void Start()
	{
		if (Network.isServer)
		{
			int num = 0;
			num += Network.connections.Length * 700;
			GetComponent<NetworkView>().RPC("HPSET", RPCMode.All, num);
		}
		if (MenuScript.GameMode == 1)
		{
			spd = -3f;
		}
		mainHead.GetComponent<Animation>()["i"].layer = 0;
		mainHead.GetComponent<Animation>()["a"].layer = 1;
		mainHead.GetComponent<Animation>()["a"].speed = 0.7f;
		t = transform;
		StartCoroutine(ShootStuff());
	}

	[RPC]
	public virtual void HPSET(int BONUS)
	{
		hp += BONUS;
	}

	[RPC]
	public virtual void SHOOT()
	{
		if (!ded)
		{
			mainHead.GetComponent<Animation>().Play("a");
		}
	}

	[RPC]
	public virtual void SetPlayer(GameObject g)
	{
		player = g;
	}


	public virtual void Update()
	{
		if (!Network.isServer)
		{
			return;
		}
		t.Translate(Vector3.left * spd * Time.deltaTime);
		if ((bool)player)
		{
			if (!(player.transform.position.y + 1f <= t.position.y))
			{
				t.Translate(Vector3.up * 1f * Time.deltaTime);
			}
			else if (!(player.transform.position.y - 1f >= t.position.y))
			{
				t.Translate(Vector3.up * -1f * Time.deltaTime);
			}
		}
	}

	[RPC]
	public virtual void TD(int dmg)
	{
		if (ded)
		{
			return;
		}
		if (Network.isServer)
		{
			hp -= dmg;
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("TD", typeof(GameObject)), t.position, Quaternion.identity);
			gameObject.SendMessage("SDN", dmg);
			if (hp <= 0)
			{
				if (GameScript.districtLevel >= 20)
				{
					GetComponent<NetworkView>().RPC("Win", RPCMode.All);
					spd = 5f;
					ded = true;
					GetComponent<NetworkView>().RPC("DeathAnim", RPCMode.All);
				}
				else
				{
					spd = 5f;
				}
			}
		}
		else
		{
			GetComponent<NetworkView>().RPC("TD", RPCMode.Server, dmg);
		}
	}


	public virtual void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.layer == 8)
		{
			c.gameObject.SendMessage("TD", 75);
			int num = 40;
			Vector3 velocity = c.gameObject.GetComponent<Rigidbody>().velocity;
			float num2 = (velocity.x = num);
			Vector3 vector2 = (c.gameObject.GetComponent<Rigidbody>().velocity = velocity);
		}
	}

	[RPC]
	public virtual void Win()
	{
		GameScript.win = true;
	}

	[RPC]
	public virtual void TDN(int dmg)
	{
		hp -= dmg;
	}

	public virtual void K()
	{
	}

	[RPC]
	public virtual void KN()
	{
	}

	[RPC]
	public virtual void Knock22()
	{
	}

	}