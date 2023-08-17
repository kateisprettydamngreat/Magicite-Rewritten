using System;

[Serializable]
public class Gear
{
	public int id;

	public int[] e;

	public float d;

	public Gear(int id, int[] e, float d)
	{
		this.e = new int[6];
		this.id = id;
		this.d = d;
		this.e = e;
	}
}
