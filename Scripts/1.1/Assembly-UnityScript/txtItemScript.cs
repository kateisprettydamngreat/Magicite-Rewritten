using System;
using UnityEngine;

[Serializable]
public class txtItemScript : MonoBehaviour
{
	public TextMesh txt1;

	public TextMesh txt2;

	private int num;

	private Transform t;

	public override void Start()
	{
		t = ((Component)this).transform;
		Object.Destroy((Object)(object)((Component)this).gameObject, 0.5f);
		num = Random.Range(1, 4);
	}

	public override void ST(string s)
	{
		txt1.text = "+1 " + s;
		txt2.text = "+1 " + s;
	}

	public override void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		t.Translate(Vector3.up * (float)num * Time.deltaTime);
	}

	public override void Main()
	{
	}
}
