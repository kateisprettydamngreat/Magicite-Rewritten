using System;
using UnityEngine;

[Serializable]
public class StoneScript : MonoBehaviour
{
	public bool isPoison;

	public bool isLeft;

	private Vector3 vec;

	public override void Set(Vector3 p)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Camera.main.ScreenToWorldPoint(Input.mousePosition) - p;
		vec = val / ((Vector3)(ref val)).magnitude;
	}

	public override void Start()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (MenuScript.multiplayer > 0)
		{
			((Component)this).rigidbody.AddForce(vec * 2900f);
		}
		else
		{
			((Component)this).rigidbody.AddForce(vec * 2900f);
		}
	}

	public override void OnCollisionEnter(Collision c)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (isPoison && (c.gameObject.layer == 9 || c.gameObject.layer == 12 || c.gameObject.layer == 11))
		{
			if (MenuScript.multiplayer > 0)
			{
				Network.Instantiate(Resources.Load("haz/poison"), ((Component)this).transform.position, Quaternion.identity, 0);
				Network.RemoveRPCs(((Component)this).networkView.viewID);
				Network.Destroy(((Component)this).networkView.viewID);
			}
			else
			{
				Object.Instantiate(Resources.Load("haz/poison"), ((Component)this).transform.position, Quaternion.identity);
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
		}
	}

	public override void Main()
	{
	}
}
