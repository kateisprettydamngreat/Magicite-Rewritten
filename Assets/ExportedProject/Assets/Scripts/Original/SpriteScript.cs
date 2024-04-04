using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SpriteScript : MonoBehaviour
{
    public virtual IEnumerator DropStuff()
    {
        if (!GetComponent<NetworkView>().isMine)
        {
            yield return null;
            yield break;
        }

        while (true)
        {
            if (!GameScript.isTown)
            {
                int num = UnityEngine.Random.Range(1, 45);
                if (num == 49 || num == 11)
                {
                    num = 9;
                }

                Item item = new Item(num, 1, new int[4], 0f, null);
                GameObject d = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("iLocal"), transform.position, Quaternion.identity);
                int[] stats = new int[7]
                {
                item.id,
                item.q,
                item.e[0],
                item.e[1],
                item.e[2],
                item.e[3],
                item.d
                };
                d.SendMessage("InitL", stats);
            }

            yield return new WaitForSeconds(UnityEngine.Random.Range(40, 60));
        }
    }
    public virtual IEnumerator ChangePos()
    {
        bonusX = UnityEngine.Random.Range(-4, 5);
        bonusY = UnityEngine.Random.Range(1, 4);
        yield return new WaitForSeconds(3f);

        while (true)
        {
            bonusX = UnityEngine.Random.Range(-4, 5);
            bonusY = UnityEngine.Random.Range(2, 4);
            yield return new WaitForSeconds(2.5f);
        }
    }

	public bool isBat;

	public Transform startMarker;

	public Transform endMarker;

	public GameObject p;

	public float speed;

	private bool initialized;

	private float startTime;

	private int bonusX;

	private int bonusY;

	private float journeyLength;

	public Transform target;

	public float smooth;

	public SpriteScript()
	{
		speed = 1f;
		smooth = 5f;
	}

	public virtual void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(this);
		StartCoroutine(ChangePos());
		if (isBat)
		{
			StartCoroutine(DropStuff());
		}
	}


	public virtual void OnLevelWasLoaded(int level)
	{
		if (Application.loadedLevel == 0)
		{
			Network.Destroy(GetComponent<NetworkView>().viewID);
		}
		else
		{
			transform.position = new Vector3(0f, 0f, 0f);
		}
	}

	[RPC]
	public virtual void SETN(GameObject a)
	{
		p = a;
	}

	public virtual void Set(GameObject a)
	{
		p = a;
		startTime = Time.time;
		startMarker = p.transform;
		endMarker = transform;
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
		initialized = true;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (initialized)
		{
			float num = (Time.time - startTime) * speed;
			float num2 = num / journeyLength;
			Vector3 a = new Vector3(startMarker.position.x + (float)bonusX, startMarker.position.y + (float)bonusY, 0f);
			transform.localPosition = Vector3.Lerp(a, endMarker.position, 0.95f);
		}
	}

	}