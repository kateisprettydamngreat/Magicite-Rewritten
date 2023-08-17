using System;
using UnityEngine;

[Serializable]
public class Item
{
	public int id;

	public int q;

	public int[] e;

	public int d;

	public int tier;

	public GameObject g;

	public Item(int id, int q, int[] e, float d, GameObject g)
	{
		this.e = new int[4];
		this.id = id;
		this.q = q;
		this.d = (int)d;
		this.e = e;
		this.g = g;
	}

	public virtual int GetD()
	{
		return d;
	}
}
