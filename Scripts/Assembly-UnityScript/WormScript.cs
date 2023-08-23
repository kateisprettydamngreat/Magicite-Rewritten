using System.Collections;
using UnityEngine;
// Untested, but compiles!
public class WormScript : MonoBehaviour
{
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

    private void Start()
    {
        StartCoroutine(StartCoroutine()); 
    }

    private IEnumerator StartCoroutine()
    {
        HP = maxHP; 
        drops = new int[3] { 7, 18, 0 };
        t = transform; 
        yield return StartCoroutine(Initialize()); 

        if (isHead)
        {
            yield return new WaitForSeconds(0.1f); 
            mainHead.GetComponent<Animation>().Play(); 
            for (int i = 0; i < 7; i++)
            {
                parts[i].GetComponent<Animation>().Play("wBody"); 
                yield return new WaitForSeconds(0.1f); 
            }
        }
    }

    private IEnumerator Initialize()
    {
        if (isHead)
        {
            GetComponent<NetworkView>().RPC("SetHead", RPCMode.All); 
            speed = 10f; 
            yield return new WaitForSeconds(0.2f); 
            StartCoroutine(Attack());
        }
    }

    private IEnumerator Attack()
    {
        while (true)
        {
            if (player != null && Network.isServer)
            {
                time = Random.Range(8, 11); 
                curVector = player.transform.position - t.position; 
                attacking = true; 
                yield return new WaitForSeconds(time); 
            }
            else
            {
                yield return new WaitForSeconds(time); 
            }
            attacking = false; 
            yield return new WaitForSeconds(0.5f); 
        }
    }

    private void Update()
    {
        if (!head)
        {
            head = gameObject;
            isHead = true;
            StartCoroutine(Initialize());
        }

        if (isHead)
        {
            if (player != null && attacking && Network.isServer)
            {
                t.Translate(curVector.normalized * speed * Time.deltaTime); 
            }
        }
        else if (Network.isServer)
        {
            float distanceX = Mathf.Abs(head.transform.position.x - t.position.x);
            float distanceY = Mathf.Abs(head.transform.position.y - t.position.y);

            if (distanceX > space || distanceY > space)
            {
                t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
            }
        }
    }

    
	private void TD(int dmg)
	{
		if (!takingDamage)
		{
			GetComponent<NetworkView>().RPC("TDN", RPCMode.All, dmg);
			GetComponent<NetworkView>().RPC("TDN2", RPCMode.All, dmg);
		}
	}

	[RPC]
	private IEnumerator TDN(int dmg)
	{
		takingDamage = true;
		yield return new WaitForSeconds(0.2f);

		HP -= dmg;
		if (HP < 1)
		{
			Die();
		}
		else
		{
			takingDamage = false;
		}
	}

	[RPC]
	private IEnumerator TDN2(int dmg)
	{
		GameObject n2 = (GameObject)Instantiate(Resources.Load("TD"), t.position, Quaternion.identity);
		n2.SendMessage("SD", dmg);
		yield return new WaitForSeconds(0.2f);

		if (HP >= 1)
		{
			takingDamage = false;
		}
	}

private void Die()
{
    GameObject gameObject = null;
    for (int num = 0; num < GOLD; num++)
    {
        Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
    }

    if (drops[0] > 0 && UnityEngine.Random.Range(0, 2) == 0)
    {
        int num2 = UnityEngine.Random.Range(1, 3);
        Item item = new Item(drops[0], 1, new int[6], 0f, null);
        for (int num = 0; num < num2; num++)
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
        Item item = new Item(drops[1], 1, new int[6], 0f, null);
        for (int num = 0; num < num3; num++)
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

	private void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.layer == 8)
		{
			c.SendMessage("TD", 18);
		}
	}

	private void K(bool l)
	{
		GetComponent<NetworkView>().RPC("KN", RPCMode.All, l);
	}

	[RPC]
	private IEnumerator KN(bool l)
	{
		bool wasK = false;
		if (GetComponent<Rigidbody>().isKinematic)
		{
			wasK = true;
			GetComponent<Rigidbody>().isKinematic = false;
		}

		if (l)
		{
			GetComponent<Rigidbody>().velocity = new Vector3(-15f, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
			yield return new WaitForEndOfFrame();
		}
		else
		{
			GetComponent<Rigidbody>().velocity = new Vector3(15f, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
			yield return new WaitForEndOfFrame();
		}

		yield return new WaitForSeconds(0.5f);

		knocking = false;
		if (wasK)
		{
			GetComponent<Rigidbody>().isKinematic = true;
		}
	}

<<<<<<< HEAD
	}
=======
}
>>>>>>> 2661a49ac1a223a7afb052bc62af12f844cb666c
