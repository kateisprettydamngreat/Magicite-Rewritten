using System;
using UnityEngine;

[Serializable]
public class NPCBasicScript : MonoBehaviour
{
	public bool isChild;

	public GameObject head;

	public GameObject body;

	public GameObject leg;

	public Material maleLeg;

	public Material femaleLeg;

	private int maxC;

	private int maxA;

	public NPCBasicScript()
	{
		maxC = 5;
		maxA = 5;
	}

	public virtual void Start()
	{
		if (isChild)
		{
			GetComponent<NetworkView>().RPC("CreateChild", RPCMode.All, UnityEngine.Random.Range(0, maxC), UnityEngine.Random.Range(0, maxC));
		}
		else
		{
			GetComponent<NetworkView>().RPC("CreateAdult", RPCMode.All, UnityEngine.Random.Range(0, maxA), UnityEngine.Random.Range(0, maxA));
		}
	}

	[RPC]
	public virtual void CreateChild(int h, int b)
	{
		int num = UnityEngine.Random.Range(0, 3);
		if (num < 2)
		{
			head.GetComponent<Renderer>().material = (Material)Resources.Load("cHM" + h);
			body.GetComponent<Renderer>().material = (Material)Resources.Load("cBM" + b);
		}
		else
		{
			head.GetComponent<Renderer>().material = (Material)Resources.Load("cHF" + h);
			body.GetComponent<Renderer>().material = (Material)Resources.Load("cBF" + b);
		}
	}

	[RPC]
	public virtual void CreateAdult(int h, int b)
	{
		int num = UnityEngine.Random.Range(0, 3);
		if (num < 2)
		{
			head.GetComponent<Renderer>().material = (Material)Resources.Load("aHM" + h);
			body.GetComponent<Renderer>().material = (Material)Resources.Load("aBM" + b);
			leg.GetComponent<Renderer>().material = maleLeg;
		}
		else
		{
			head.GetComponent<Renderer>().material = (Material)Resources.Load("aHF" + h);
			body.GetComponent<Renderer>().material = (Material)Resources.Load("aBF" + b);
			leg.GetComponent<Renderer>().material = femaleLeg;
		}
	}

	public virtual void Main()
	{
	}
}
