using System;
using UnityEngine;

[Serializable]
public class SpireScript : MonoBehaviour
{
	public GameObject @base;

	public Material[] mat;

	public SpireScript()
	{
		mat = (Material[])(object)new Material[3];
	}

	public override void Start()
	{
		int num = Random.Range(0, 3);
		@base.renderer.material = mat[num];
	}

	public override void Main()
	{
	}
}
