using System;
using UnityEngine;

[Serializable]
public class SpireScript : MonoBehaviour
{
	public GameObject @base;

	public Material[] mat;

	public SpireScript()
	{
		mat = new Material[3];
	}

	public virtual void Start()
	{
		int num = UnityEngine.Random.Range(0, 3);
		@base.GetComponent<Renderer>().material = mat[num];
	}

	}