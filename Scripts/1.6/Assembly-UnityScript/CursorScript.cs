using System;
using UnityEngine;

[Serializable]
public class CursorScript : MonoBehaviour
{
	private Transform t;

	public override void Start()
	{
		t = ((Component)this).transform;
	}

	public override void LateUpdate()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		float x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
		Vector3 position = t.position;
		float num = (position.x = x);
		Vector3 val2 = (t.position = position);
		float y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
		Vector3 position2 = t.position;
		float num2 = (position2.y = y);
		Vector3 val4 = (t.position = position2);
	}

	public override void Main()
	{
	}
}
