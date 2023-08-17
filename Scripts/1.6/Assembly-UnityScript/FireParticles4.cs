using System;
using UnityEngine;

[Serializable]
public class FireParticles4 : MonoBehaviour
{
	public GameObject ParticleA;

	public override void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		RaycastHit val = default(RaycastHit);
		Ray val2 = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Input.GetMouseButtonDown(0) && Physics.Raycast(val2, ref val, 200f))
		{
			GameObject val3 = (GameObject)Object.Instantiate((Object)(object)ParticleA, ((RaycastHit)(ref val)).point, Quaternion.identity);
			Object.Destroy((Object)(object)val3, 12f);
		}
	}

	public override void Main()
	{
	}
}
