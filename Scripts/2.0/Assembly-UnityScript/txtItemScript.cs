using System;
using UnityEngine;

[Serializable]
public class txtItemScript : MonoBehaviour
{
	public TextMesh txt1;

	public TextMesh txt2;

	private int num;

	private Transform t;

	public virtual void Start()
	{
		t = transform;
		UnityEngine.Object.Destroy(gameObject, 0.5f);
		num = UnityEngine.Random.Range(1, 4);
	}

	public virtual void ST(string s)
	{
		txt1.text = "+1 " + s;
		txt2.text = "+1 " + s;
	}

	public virtual void Update()
	{
		t.Translate(Vector3.up * num * Time.deltaTime);
	}

	public virtual void Main()
	{
	}
}
