using System;
using UnityEngine;

[Serializable]
public class BigSnow : MonoBehaviour
{
	public bool is2;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	private Ray r3;

	private Ray r4;

	private float spd;

	public GameObject @base;

	private Transform t;

	public BigSnow()
	{
		mask2 = 2048;
	}

	public override void Awake()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		t = ((Component)this).transform;
		if (is2 && MenuScript.multiplayer == 1)
		{
			float y = t.position.y - 0.5f;
			Vector3 position = t.position;
			float num = (position.y = y);
			Vector3 val2 = (t.position = position);
		}
	}

	public override void Start()
	{
		if (MenuScript.multiplayer == 1)
		{
			if (Random.Range(0, 2) == 0)
			{
				((Component)this).networkView.RPC("RollRight", (RPCMode)6, new object[0]);
			}
			else
			{
				((Component)this).networkView.RPC("RollLeft", (RPCMode)6, new object[0]);
			}
		}
	}

	[RPC]
	public override void RollLeft()
	{
		spd = 3f;
		@base.animation["sB"].speed = -1f;
	}

	[RPC]
	public override void RollRight()
	{
		spd = -3f;
		@base.animation["sB"].speed = 1f;
	}

	public override void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		t.Translate(Vector3.left * Time.deltaTime * spd);
		((Ray)(ref r1U)).origin = ((Component)this).transform.position;
		((Ray)(ref r1U)).direction = Vector3.left;
		((Ray)(ref r2U)).origin = ((Component)this).transform.position;
		((Ray)(ref r2U)).direction = Vector3.right;
		((Ray)(ref r3)).origin = ((Component)this).transform.position;
		float x = ((Ray)(ref r3)).origin.x + 2f;
		Vector3 origin = ((Ray)(ref r3)).origin;
		float num = (origin.x = x);
		Vector3 val2 = (((Ray)(ref r3)).origin = origin);
		((Ray)(ref r3)).direction = Vector3.down;
		((Ray)(ref r4)).origin = ((Component)this).transform.position;
		float x2 = ((Ray)(ref r4)).origin.x - 2f;
		Vector3 origin2 = ((Ray)(ref r4)).origin;
		float num2 = (origin2.x = x2);
		Vector3 val4 = (((Ray)(ref r4)).origin = origin2);
		((Ray)(ref r4)).direction = Vector3.down;
		if (Physics.Raycast(r1U, 3f, mask2) && MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("RollRight", (RPCMode)6, new object[0]);
		}
		if (Physics.Raycast(r2U, 3f, mask2) && MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("RollLeft", (RPCMode)6, new object[0]);
		}
		if (!Physics.Raycast(r3, 1.5f, mask2) && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("RollLeft", (RPCMode)6, new object[0]);
		}
		if (!Physics.Raycast(r4, 1.5f, mask2) && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("RollRight", (RPCMode)6, new object[0]);
		}
	}

	public override void Main()
	{
	}
}
