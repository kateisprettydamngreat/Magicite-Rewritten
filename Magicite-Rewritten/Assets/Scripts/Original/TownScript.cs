using System;
using UnityEngine;

[Serializable]
public class TownScript : MonoBehaviour
{
	public GameObject floor1;

	public GameObject floor2;

	public GameObject platform1;

	public GameObject platform2;

	public virtual void Start()
	{
	}

	[RPC]
	public virtual void SetPlatforms(int b)
	{
		floor1.GetComponent<Renderer>().material = (Material)Resources.Load("floor/p" + b, typeof(Material));
		floor2.GetComponent<Renderer>().material = (Material)Resources.Load("floor/p" + b, typeof(Material));
		platform1.GetComponent<Renderer>().material = (Material)Resources.Load("platformS/p" + b, typeof(Material));
		platform2.GetComponent<Renderer>().material = (Material)Resources.Load("platformS/p" + b, typeof(Material));
	}

	}