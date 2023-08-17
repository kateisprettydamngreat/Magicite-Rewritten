using System;
using UnityEngine;

[Serializable]
public class HazTrig : MonoBehaviour
{
	public int dmg;

	public override void OnTriggerEnter(Collider c)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)c).gameObject.layer == 8)
		{
			bool flag = default(bool);
			if (!(((Component)c).gameObject.transform.position.x <= ((Component)this).transform.position.x))
			{
				((Component)c).gameObject.SendMessage("K", (object)false);
			}
			else
			{
				((Component)c).gameObject.SendMessage("K", (object)true);
			}
			((Component)c).gameObject.SendMessage("TD", (object)dmg);
		}
		else if (((Component)c).gameObject.layer == 9 || ((Component)c).gameObject.layer == 12)
		{
			((Component)c).gameObject.SendMessage("Knock22", (object)((Component)this).gameObject.transform.position);
		}
	}

	public override void Main()
	{
	}
}
